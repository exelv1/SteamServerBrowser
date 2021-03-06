﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Threading;
using QueryMaster;

namespace ServerBrowser
{
  #region class TextEventArgs
  public class TextEventArgs : EventArgs
  {
    public string Text { get; private set; }

    public TextEventArgs(string text)
    {
      this.Text = text;
    }
  }
  #endregion

  #region class ServerListEventArgs
  public class ServerListEventArgs : EventArgs
  {
    public List<ServerRow> Rows { get; private set; }

    public ServerListEventArgs(List<ServerRow> rows)
    {
      this.Rows = rows;
    }
  }
  #endregion

  #region class ServerEventArgs
  public class ServerEventArgs : EventArgs
  {
    public ServerRow Server { get; private set; }

    public ServerEventArgs(ServerRow server)
    {
      this.Server = server;
    }
  }
  #endregion

  public class ServerQueryLogic
  {
    #region class UpdateRequest
    private class UpdateRequest
    {
      public readonly long Timestamp;
      public readonly int MaxResults;
      public readonly bool QueryServerRules;
      public readonly List<ServerRow> Servers = new List<ServerRow>();

      public UpdateRequest(int maxResults, bool queryServerRules)
      {
        this.Timestamp = DateTime.Now.Ticks;
        this.MaxResults = maxResults;
        this.QueryServerRules = queryServerRules;
      }

      public CountdownEvent PendingTasks;
      public int TaskCount;
      public int TasksWithRetries;

      public int DataModified; // bool, but there is no Interlocked.Exchange(bool)
      public volatile bool IsCancelled;
    }
    #endregion

    private volatile UpdateRequest currentRequest;
    private volatile List<ServerRow> allServers;
    private bool sendFirstUdpPacketTwice;

    public event EventHandler<TextEventArgs> UpdateStatus;
    public event EventHandler<ServerListEventArgs> ReloadServerListComplete;
    public event EventHandler<ServerEventArgs> RefreshSingleServerComplete;

    #region ctor()
    public ServerQueryLogic()
    {
      // fake a completed request
      this.currentRequest = new UpdateRequest(0, false);
      this.currentRequest.PendingTasks = new CountdownEvent(1);
      this.currentRequest.PendingTasks.Signal();
    }
    #endregion

    #region Servers
    public List<ServerRow> Servers { get { return this.allServers; } }
    #endregion

    #region IsUpdating
    public bool IsUpdating
    {
      get { return this.currentRequest.PendingTasks == null || !this.currentRequest.PendingTasks.IsSet; }
    }
    #endregion

    #region GetAndResetDataModified()
    public bool GetAndResetDataModified()
    {
      return Interlocked.Exchange(ref this.currentRequest.DataModified, 0) != 0;
    }
    #endregion

    #region Cancel()
    public void Cancel()
    {
      this.currentRequest.IsCancelled = true;
    }
    #endregion

    // reload server list

    #region ReloadServerList()
    public void ReloadServerList(IPEndPoint masterServerEndPoint, int maxResults, Game steamAppId, Region region, bool queryServerRules)
    {
      this.currentRequest.IsCancelled = true;

      MasterServer master = new MasterServer(masterServerEndPoint);
      master.GetAddressesLimit = maxResults;
      IpFilter filter = new IpFilter();
      filter.App = steamAppId;

      var request = new UpdateRequest(maxResults, queryServerRules); // use local var for thread safety
      this.currentRequest = request;
      master.GetAddresses(region, endpoints => OnMasterServerReceive(request, endpoints), filter);
    }
    #endregion

    #region OnMasterServerReceive()
    private void OnMasterServerReceive(UpdateRequest request, ReadOnlyCollection<IPEndPoint> endPoints)
    {
      if (request.IsCancelled)
        return;

      string statusText;
      if (endPoints == null)
        statusText = "Master server request timed out";
      else
      {
        statusText = "Requesting next batch of server list...";
        foreach (var ep in endPoints)
        {
          if (request.IsCancelled)
            return;
          if (ep.Address.Equals(IPAddress.Any))
          {
            statusText = "Master server returned " + request.Servers.Count + " servers";
            this.AllServersReceived(request);
          }
          else if (request.Servers.Count >= request.MaxResults)
          {
            statusText = "Server list limited to " + request.MaxResults + " entries";
            this.AllServersReceived(request);
            break;
          }
          else
            request.Servers.Add(new ServerRow(ep));
        }
      }

      request.DataModified = 1;
      if (this.UpdateStatus != null)
        this.UpdateStatus(this, new TextEventArgs(statusText));
    }
    #endregion

    #region AllServersReceived()
    private void AllServersReceived(UpdateRequest request)
    {
      var rows = request.Servers;

      // reuse old ServerRow objects for new list to preserve last known data until the update completes
      if (this.allServers != null)
      {
        var oldServers = new Dictionary<IPEndPoint, ServerRow>();
        foreach (var server in this.allServers)
          oldServers[server.EndPoint] = server;
        for (int i = 0, c = rows.Count; i < c; i++)
        {
          ServerRow oldServer;
          if (oldServers.TryGetValue(rows[i].EndPoint, out oldServer))
            rows[i] = oldServer;
        }
      }

      this.allServers = rows;

      request.TaskCount = rows.Count;

      // use a background thread so that the caller doesn't have to wait for the accumulated Thread.Sleep()
      ThreadPool.QueueUserWorkItem(dummy =>
      {
        request.PendingTasks = new CountdownEvent(rows.Count);
        foreach (var row in rows)
        {
          if (request.IsCancelled)
            return;
          var safeRow = row;
          ThreadPool.QueueUserWorkItem(context => UpdateServerAndDetails(request, safeRow, false));
          Thread.Sleep(5); // launching all threads at once results in totally wrong ping values
        }
        request.PendingTasks.Wait();

        if (request.IsCancelled)
          return;
        
        this.ReloadServerListFinished(request);
      });
    }
    #endregion

    #region ReloadServerListFinished()
    private void ReloadServerListFinished(UpdateRequest request)
    {
      if (request.TasksWithRetries > request.TaskCount / 3)
        this.sendFirstUdpPacketTwice = true;

      if (this.ReloadServerListComplete != null)
        this.ReloadServerListComplete(this, new ServerListEventArgs(request.Servers));      
    }
    #endregion

    // refresh single server

    #region RefreshSingleServer()
    public void RefreshSingleServer(ServerRow row)
    {
      row.Status = "updating...";
      this.currentRequest = new UpdateRequest(1, this.currentRequest.QueryServerRules);
      this.currentRequest.PendingTasks = new CountdownEvent(1);
      ThreadPool.QueueUserWorkItem(dummy => this.UpdateServerAndDetails(this.currentRequest, row, true));
    }
    #endregion

    // shared update code

    #region UpdateServerAndDetails()
    private void UpdateServerAndDetails(UpdateRequest request, ServerRow row, bool fireRefreshSingleServerComplete)
    {
      try
      {
        if (request.IsCancelled)
          return;

        string status;
        using (Server server = ServerQuery.GetServerInstance(EngineType.Source, row.EndPoint, false, 500, 500))
        {
          row.Retries = 0;
          server.SendFirstPacketTwice = this.sendFirstUdpPacketTwice;
          server.Retries = 3;
          status = "timeout";
          if (this.UpdateServerInfo(request, row, server))
          {
            this.UpdatePlayers(request, row, server);
            this.UpdateRules(request, row, server);
            status = "ok";
          }
          row.RequestTimestamp = request.Timestamp;
        }

        if (request.IsCancelled) // status might have changed
          return;

        if (row.Retries > 0)
          status += " (" + row.Retries + ")";
        row.Status = status;
        row.Update();
        request.DataModified = 1;

        if (fireRefreshSingleServerComplete && this.RefreshSingleServerComplete != null)
          this.RefreshSingleServerComplete(this, new ServerEventArgs(row));          
      }
      finally
      {
        request.PendingTasks.Signal();
      }
    }
    #endregion

    #region UpdateServerInfo()
    private bool UpdateServerInfo(UpdateRequest request, ServerRow row, Server server)
    {
      bool ok = ExecuteUpdate(request, row, server, retryCallback =>
      {
        row.ServerInfo = server.GetInfo(retryCallback);
      });
      if (!ok)
        row.ServerInfo = null;
      return ok;
    }
    #endregion

    #region UpdatePlayers()
    private void UpdatePlayers(UpdateRequest request, ServerRow row, Server server)
    {
      bool ok = ExecuteUpdate(request, row, server, retryCallback =>
      {
        var players = server.GetPlayers(retryCallback);
        row.Players = players == null ? null : new List<Player>(players);
      });
      if (!ok)
        row.Players = null;
    }
    #endregion

    #region UpdateRules()
    private void UpdateRules(UpdateRequest request, ServerRow row, Server server)
    {
      if (!request.QueryServerRules)
        return;
      bool ok = ExecuteUpdate(request, row, server, retryCallback =>
      {
        row.Rules = new List<Rule>(server.GetRules(retryCallback));
      });
      if (!ok)
        row.Rules = null;
    }
    #endregion

    #region ExecuteUpdate()
    /// <summary>
    /// Template method for common code needed in UpdateServerInfo, UpdatePlayers and UpdateRules
    /// </summary>
    private bool ExecuteUpdate(UpdateRequest request, ServerRow row, Server server, Action<Action<int>> updater)
    {
      if (request.IsCancelled)
        return false;

      try
      {
        row.Status = "updating " + row.Retries;
        request.DataModified = 1;
        updater(retry =>
        {
          if (request.IsCancelled)
            throw new OperationCanceledException();
          if (row.Retries == 0)
            Interlocked.Increment(ref request.TasksWithRetries);
          row.Status = "updating " + (++row.Retries + 1);
          request.DataModified = 1;
        });
        return true;
      }
      catch (TimeoutException)
      {
        return false;
      }
      catch
      {
        return true;
      }
    }
    #endregion
  }
}
