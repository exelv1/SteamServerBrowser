﻿using DevExpress.XtraEditors;

namespace ServerBrowser
{
  partial class ServerBrowserForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerBrowserForm));
      this.gcDetails = new DevExpress.XtraGrid.GridControl();
      this.gvDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colKey = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
      this.comboRegion = new DevExpress.XtraEditors.ComboBoxEdit();
      this.rbFavGame2 = new DevExpress.XtraEditors.CheckEdit();
      this.rbFavGame1 = new DevExpress.XtraEditors.CheckEdit();
      this.rbFavGame3 = new DevExpress.XtraEditors.CheckEdit();
      this.gcPlayers = new DevExpress.XtraGrid.GridControl();
      this.dsPlayer = new System.Windows.Forms.BindingSource(this.components);
      this.gvPlayers = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colScore = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gcServers = new DevExpress.XtraGrid.GridControl();
      this.dsServers = new System.Windows.Forms.BindingSource(this.components);
      this.gvServers = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colEndPoint = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDedicated = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPrivate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.riCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colKeywords = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPlayerCount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colHumanPlayers = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBots = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTotalPlayers = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMaxPlayers = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMap = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colPing = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
      this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.miConnect = new DevExpress.XtraBars.BarButtonItem();
      this.miConnectSpectator = new DevExpress.XtraBars.BarButtonItem();
      this.miCopyAddress = new DevExpress.XtraBars.BarButtonItem();
      this.miUpdateServerInfo = new DevExpress.XtraBars.BarButtonItem();
      this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
      this.panelPlayers = new DevExpress.XtraBars.Docking.DockPanel();
      this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
      this.panelServerDetails = new DevExpress.XtraBars.Docking.DockPanel();
      this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
      this.panelRules = new DevExpress.XtraBars.Docking.DockPanel();
      this.controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
      this.gcRules = new DevExpress.XtraGrid.GridControl();
      this.dsRules = new System.Windows.Forms.BindingSource(this.components);
      this.gvRules = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
      this.panelServerList = new DevExpress.XtraBars.Docking.DockPanel();
      this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
      this.btnSkin = new DevExpress.XtraEditors.SimpleButton();
      this.cbRefreshSelectedServer = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.btnQueryMaster = new DevExpress.XtraEditors.SimpleButton();
      this.panelTop = new DevExpress.XtraEditors.PanelControl();
      this.panelTopFill = new DevExpress.XtraEditors.PanelControl();
      this.panelControls = new DevExpress.XtraEditors.PanelControl();
      this.panelOptions = new DevExpress.XtraEditors.PanelControl();
      this.linkFilter1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
      this.cbAdvancedOptions = new DevExpress.XtraEditors.CheckButton();
      this.panelGame = new DevExpress.XtraEditors.PanelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.comboGames = new DevExpress.XtraEditors.ComboBoxEdit();
      this.picLogo = new DevExpress.XtraEditors.PictureEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.btnAddGameServer = new DevExpress.XtraEditors.SimpleButton();
      this.txtServerQuery = new DevExpress.XtraEditors.TextEdit();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.timerUpdateServerList = new System.Windows.Forms.Timer(this.components);
      this.panelAdvancedOptions = new DevExpress.XtraEditors.PanelControl();
      this.linkDownloadSkins = new DevExpress.XtraEditors.HyperlinkLabelControl();
      this.linkFilter2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
      this.spinRefreshInterval = new DevExpress.XtraEditors.SpinEdit();
      this.cbAlert = new DevExpress.XtraEditors.CheckEdit();
      this.cbShowGamePort = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
      this.comboMasterServer = new DevExpress.XtraEditors.ComboBoxEdit();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.cbShowPlayerCountDetailColumns = new DevExpress.XtraEditors.CheckEdit();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.txtStatus = new DevExpress.XtraEditors.LabelControl();
      this.menuServers = new DevExpress.XtraBars.PopupMenu(this.components);
      this.menuPlayers = new DevExpress.XtraBars.PopupMenu(this.components);
      this.timerReloadServers = new System.Windows.Forms.Timer(this.components);
      this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboRegion.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame3.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcPlayers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvPlayers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcServers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsServers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvServers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.panelContainer1.SuspendLayout();
      this.panelPlayers.SuspendLayout();
      this.dockPanel1_Container.SuspendLayout();
      this.panelServerDetails.SuspendLayout();
      this.dockPanel2_Container.SuspendLayout();
      this.panelRules.SuspendLayout();
      this.controlContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gcRules)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsRules)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvRules)).BeginInit();
      this.panelServerList.SuspendLayout();
      this.controlContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cbRefreshSelectedServer.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
      this.panelTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelTopFill)).BeginInit();
      this.panelTopFill.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControls)).BeginInit();
      this.panelControls.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelOptions)).BeginInit();
      this.panelOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelGame)).BeginInit();
      this.panelGame.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.comboGames.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtServerQuery.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelAdvancedOptions)).BeginInit();
      this.panelAdvancedOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spinRefreshInterval.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbAlert.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbShowGamePort.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboMasterServer.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbShowPlayerCountDetailColumns.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.menuServers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.menuPlayers)).BeginInit();
      this.SuspendLayout();
      // 
      // gcDetails
      // 
      this.gcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcDetails.Location = new System.Drawing.Point(0, 0);
      this.gcDetails.MainView = this.gvDetails;
      this.gcDetails.Name = "gcDetails";
      this.gcDetails.Size = new System.Drawing.Size(354, 582);
      this.gcDetails.TabIndex = 13;
      this.gcDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetails});
      // 
      // gvDetails
      // 
      this.gvDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKey,
            this.colValue});
      this.gvDetails.GridControl = this.gcDetails;
      this.gvDetails.Name = "gvDetails";
      this.gvDetails.OptionsBehavior.Editable = false;
      this.gvDetails.OptionsView.ShowGroupPanel = false;
      this.gvDetails.OptionsView.ShowIndicator = false;
      // 
      // colKey
      // 
      this.colKey.Caption = "Setting";
      this.colKey.FieldName = "Item1";
      this.colKey.Name = "colKey";
      this.colKey.Visible = true;
      this.colKey.VisibleIndex = 0;
      this.colKey.Width = 100;
      // 
      // colValue
      // 
      this.colValue.Caption = "Value";
      this.colValue.FieldName = "Item2";
      this.colValue.Name = "colValue";
      this.colValue.Visible = true;
      this.colValue.VisibleIndex = 1;
      this.colValue.Width = 150;
      // 
      // comboRegion
      // 
      this.comboRegion.Location = new System.Drawing.Point(80, 5);
      this.comboRegion.Name = "comboRegion";
      this.comboRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.comboRegion.Properties.DropDownRows = 10;
      this.comboRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.comboRegion.Size = new System.Drawing.Size(184, 20);
      this.comboRegion.TabIndex = 18;
      this.comboRegion.SelectedIndexChanged += new System.EventHandler(this.comboRegion_SelectedIndexChanged);
      // 
      // rbFavGame2
      // 
      this.rbFavGame2.Location = new System.Drawing.Point(154, 29);
      this.rbFavGame2.Name = "rbFavGame2";
      this.rbFavGame2.Properties.AutoWidth = true;
      this.rbFavGame2.Properties.Caption = "Toxikk";
      this.rbFavGame2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.rbFavGame2.Properties.RadioGroupIndex = 1;
      this.rbFavGame2.Size = new System.Drawing.Size(52, 19);
      this.rbFavGame2.TabIndex = 15;
      this.rbFavGame2.TabStop = false;
      this.rbFavGame2.ToolTip = "Use Ctrl+Click to assign the game selected above to this button";
      this.rbFavGame2.CheckedChanged += new System.EventHandler(this.rbFavGame_CheckedChanged);
      // 
      // rbFavGame1
      // 
      this.rbFavGame1.Location = new System.Drawing.Point(80, 29);
      this.rbFavGame1.Name = "rbFavGame1";
      this.rbFavGame1.Properties.AutoWidth = true;
      this.rbFavGame1.Properties.Caption = "Reflex";
      this.rbFavGame1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.rbFavGame1.Properties.RadioGroupIndex = 1;
      this.rbFavGame1.Size = new System.Drawing.Size(53, 19);
      this.rbFavGame1.TabIndex = 14;
      this.rbFavGame1.TabStop = false;
      this.rbFavGame1.ToolTip = "Use Ctrl+Click to assign the game selected above to this button";
      this.rbFavGame1.CheckedChanged += new System.EventHandler(this.rbFavGame_CheckedChanged);
      // 
      // rbFavGame3
      // 
      this.rbFavGame3.Location = new System.Drawing.Point(233, 29);
      this.rbFavGame3.Name = "rbFavGame3";
      this.rbFavGame3.Properties.AutoWidth = true;
      this.rbFavGame3.Properties.Caption = "Quake Live";
      this.rbFavGame3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.rbFavGame3.Properties.RadioGroupIndex = 1;
      this.rbFavGame3.Size = new System.Drawing.Size(75, 19);
      this.rbFavGame3.TabIndex = 13;
      this.rbFavGame3.TabStop = false;
      this.rbFavGame3.ToolTip = "Use Ctrl+Click to assign the game selected above to this button";
      this.rbFavGame3.CheckedChanged += new System.EventHandler(this.rbFavGame_CheckedChanged);
      // 
      // gcPlayers
      // 
      this.gcPlayers.DataSource = this.dsPlayer;
      this.gcPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcPlayers.Location = new System.Drawing.Point(0, 0);
      this.gcPlayers.MainView = this.gvPlayers;
      this.gcPlayers.Name = "gcPlayers";
      this.gcPlayers.Size = new System.Drawing.Size(354, 582);
      this.gcPlayers.TabIndex = 15;
      this.gcPlayers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPlayers});
      // 
      // dsPlayer
      // 
      this.dsPlayer.DataSource = typeof(QueryMaster.Player);
      // 
      // gvPlayers
      // 
      this.gvPlayers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colScore,
            this.colTime});
      this.gvPlayers.GridControl = this.gcPlayers;
      this.gvPlayers.Name = "gvPlayers";
      this.gvPlayers.OptionsView.ShowGroupPanel = false;
      this.gvPlayers.OptionsView.ShowIndicator = false;
      this.gvPlayers.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvPlayers_CustomUnboundColumnData);
      this.gvPlayers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPlayers_MouseDown);
      this.gvPlayers.DoubleClick += new System.EventHandler(this.gvPlayers_DoubleClick);
      // 
      // colName1
      // 
      this.colName1.FieldName = "Name";
      this.colName1.Name = "colName1";
      this.colName1.OptionsColumn.ReadOnly = true;
      this.colName1.Visible = true;
      this.colName1.VisibleIndex = 0;
      this.colName1.Width = 131;
      // 
      // colScore
      // 
      this.colScore.FieldName = "Score";
      this.colScore.Name = "colScore";
      this.colScore.OptionsColumn.AllowEdit = false;
      this.colScore.OptionsColumn.FixedWidth = true;
      this.colScore.OptionsColumn.ReadOnly = true;
      this.colScore.Visible = true;
      this.colScore.VisibleIndex = 1;
      this.colScore.Width = 48;
      // 
      // colTime
      // 
      this.colTime.FieldName = "Time";
      this.colTime.Name = "colTime";
      this.colTime.OptionsColumn.AllowEdit = false;
      this.colTime.OptionsColumn.FixedWidth = true;
      this.colTime.OptionsColumn.ReadOnly = true;
      this.colTime.Visible = true;
      this.colTime.VisibleIndex = 2;
      // 
      // gcServers
      // 
      this.gcServers.DataSource = this.dsServers;
      this.gcServers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcServers.Location = new System.Drawing.Point(0, 0);
      this.gcServers.MainView = this.gvServers;
      this.gcServers.Name = "gcServers";
      this.gcServers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCheckEdit});
      this.gcServers.Size = new System.Drawing.Size(1095, 582);
      this.gcServers.TabIndex = 16;
      this.gcServers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServers});
      // 
      // dsServers
      // 
      this.dsServers.DataSource = typeof(ServerBrowser.ServerRow);
      // 
      // gvServers
      // 
      this.gvServers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEndPoint,
            this.colName,
            this.colDedicated,
            this.colPrivate,
            this.colDescription,
            this.colKeywords,
            this.colPlayerCount,
            this.colHumanPlayers,
            this.colBots,
            this.colTotalPlayers,
            this.colMaxPlayers,
            this.colMap,
            this.colPing,
            this.colStatus});
      this.gvServers.GridControl = this.gcServers;
      this.gvServers.Name = "gvServers";
      this.gvServers.OptionsDetail.EnableMasterViewMode = false;
      this.gvServers.OptionsView.ColumnAutoWidth = false;
      this.gvServers.OptionsView.ShowAutoFilterRow = true;
      this.gvServers.OptionsView.ShowGroupPanel = false;
      this.gvServers.OptionsView.ShowIndicator = false;
      this.gvServers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPlayerCount, DevExpress.Data.ColumnSortOrder.Descending)});
      this.gvServers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvServers_FocusedRowChanged);
      this.gvServers.ColumnFilterChanged += new System.EventHandler(this.gvServers_ColumnFilterChanged);
      this.gvServers.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvServers_CustomUnboundColumnData);
      this.gvServers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvServers_MouseDown);
      this.gvServers.DoubleClick += new System.EventHandler(this.gvServers_DoubleClick);
      // 
      // colEndPoint
      // 
      this.colEndPoint.Caption = "Address";
      this.colEndPoint.FieldName = "Address";
      this.colEndPoint.Name = "colEndPoint";
      this.colEndPoint.OptionsColumn.ReadOnly = true;
      this.colEndPoint.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colEndPoint.Visible = true;
      this.colEndPoint.VisibleIndex = 0;
      this.colEndPoint.Width = 132;
      // 
      // colName
      // 
      this.colName.FieldName = "ServerInfo.Name";
      this.colName.Name = "colName";
      this.colName.OptionsColumn.AllowEdit = false;
      this.colName.OptionsColumn.ReadOnly = true;
      this.colName.Visible = true;
      this.colName.VisibleIndex = 1;
      this.colName.Width = 260;
      // 
      // colDedicated
      // 
      this.colDedicated.Caption = "Ded";
      this.colDedicated.FieldName = "Dedicated";
      this.colDedicated.Name = "colDedicated";
      this.colDedicated.ToolTip = "Dedicated";
      this.colDedicated.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
      this.colDedicated.Visible = true;
      this.colDedicated.VisibleIndex = 2;
      this.colDedicated.Width = 35;
      // 
      // colPrivate
      // 
      this.colPrivate.Caption = "Private";
      this.colPrivate.ColumnEdit = this.riCheckEdit;
      this.colPrivate.FieldName = "ServerInfo.IsPrivate";
      this.colPrivate.Name = "colPrivate";
      this.colPrivate.OptionsColumn.AllowEdit = false;
      this.colPrivate.Visible = true;
      this.colPrivate.VisibleIndex = 3;
      this.colPrivate.Width = 45;
      // 
      // riCheckEdit
      // 
      this.riCheckEdit.AutoHeight = false;
      this.riCheckEdit.Name = "riCheckEdit";
      // 
      // colDescription
      // 
      this.colDescription.Caption = "Description";
      this.colDescription.FieldName = "ServerInfo.Description";
      this.colDescription.Name = "colDescription";
      this.colDescription.OptionsColumn.AllowEdit = false;
      this.colDescription.Visible = true;
      this.colDescription.VisibleIndex = 4;
      this.colDescription.Width = 101;
      // 
      // colKeywords
      // 
      this.colKeywords.Caption = "Keywords";
      this.colKeywords.FieldName = "ServerInfo.Extra.Keywords";
      this.colKeywords.Name = "colKeywords";
      this.colKeywords.OptionsColumn.AllowEdit = false;
      this.colKeywords.Visible = true;
      this.colKeywords.VisibleIndex = 5;
      this.colKeywords.Width = 127;
      // 
      // colPlayerCount
      // 
      this.colPlayerCount.Caption = "Players";
      this.colPlayerCount.FieldName = "PlayerCount";
      this.colPlayerCount.Name = "colPlayerCount";
      this.colPlayerCount.OptionsColumn.AllowEdit = false;
      this.colPlayerCount.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
      this.colPlayerCount.Visible = true;
      this.colPlayerCount.VisibleIndex = 6;
      // 
      // colHumanPlayers
      // 
      this.colHumanPlayers.Caption = "Humans";
      this.colHumanPlayers.FieldName = "ServerInfo.Players";
      this.colHumanPlayers.Name = "colHumanPlayers";
      this.colHumanPlayers.OptionsColumn.AllowEdit = false;
      this.colHumanPlayers.ToolTip = "Human Players";
      this.colHumanPlayers.Visible = true;
      this.colHumanPlayers.VisibleIndex = 7;
      this.colHumanPlayers.Width = 30;
      // 
      // colBots
      // 
      this.colBots.Caption = "Bots";
      this.colBots.FieldName = "ServerInfo.Bots";
      this.colBots.Name = "colBots";
      this.colBots.OptionsColumn.AllowEdit = false;
      this.colBots.Visible = true;
      this.colBots.VisibleIndex = 8;
      this.colBots.Width = 30;
      // 
      // colTotalPlayers
      // 
      this.colTotalPlayers.Caption = "Total";
      this.colTotalPlayers.FieldName = "TotalPlayers";
      this.colTotalPlayers.Name = "colTotalPlayers";
      this.colTotalPlayers.OptionsColumn.AllowEdit = false;
      this.colTotalPlayers.ToolTip = "Total Players (Humans + Bots)";
      this.colTotalPlayers.Visible = true;
      this.colTotalPlayers.VisibleIndex = 9;
      this.colTotalPlayers.Width = 30;
      // 
      // colMaxPlayers
      // 
      this.colMaxPlayers.Caption = "Max";
      this.colMaxPlayers.FieldName = "ServerInfo.MaxPlayers";
      this.colMaxPlayers.Name = "colMaxPlayers";
      this.colMaxPlayers.OptionsColumn.AllowEdit = false;
      this.colMaxPlayers.ToolTip = "Maximum Players";
      this.colMaxPlayers.Visible = true;
      this.colMaxPlayers.VisibleIndex = 10;
      this.colMaxPlayers.Width = 30;
      // 
      // colMap
      // 
      this.colMap.Caption = "Map";
      this.colMap.FieldName = "ServerInfo.Map";
      this.colMap.Name = "colMap";
      this.colMap.OptionsColumn.AllowEdit = false;
      this.colMap.Visible = true;
      this.colMap.VisibleIndex = 11;
      this.colMap.Width = 110;
      // 
      // colPing
      // 
      this.colPing.Caption = "Ping";
      this.colPing.DisplayFormat.FormatString = "d";
      this.colPing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.colPing.FieldName = "ServerInfo.Ping";
      this.colPing.Name = "colPing";
      this.colPing.OptionsColumn.AllowEdit = false;
      this.colPing.Visible = true;
      this.colPing.VisibleIndex = 12;
      this.colPing.Width = 32;
      // 
      // colStatus
      // 
      this.colStatus.Caption = "Status";
      this.colStatus.FieldName = "Status";
      this.colStatus.Name = "colStatus";
      this.colStatus.OptionsColumn.AllowEdit = false;
      this.colStatus.Visible = true;
      this.colStatus.VisibleIndex = 13;
      this.colStatus.Width = 61;
      // 
      // dockManager1
      // 
      this.dockManager1.Form = this;
      this.dockManager1.MenuManager = this.barManager1;
      this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.panelServerList});
      this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraEditors.PanelControl"});
      this.dockManager1.StartDocking += new DevExpress.XtraBars.Docking.DockPanelCancelEventHandler(this.dockManager1_StartDocking);
      // 
      // barManager1
      // 
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.DockManager = this.dockManager1;
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.miConnect,
            this.miConnectSpectator,
            this.miCopyAddress,
            this.miUpdateServerInfo});
      this.barManager1.MaxItemId = 4;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(1465, 0);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 808);
      this.barDockControlBottom.Size = new System.Drawing.Size(1465, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 808);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(1465, 0);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 808);
      // 
      // miConnect
      // 
      this.miConnect.Caption = "Connect";
      this.miConnect.Id = 0;
      this.miConnect.Name = "miConnect";
      this.miConnect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miConnect_ItemClick);
      // 
      // miConnectSpectator
      // 
      this.miConnectSpectator.Caption = "Connect as Spectator";
      this.miConnectSpectator.Id = 1;
      this.miConnectSpectator.Name = "miConnectSpectator";
      this.miConnectSpectator.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miConnectSpectator_ItemClick);
      // 
      // miCopyAddress
      // 
      this.miCopyAddress.Caption = "Copy Address to Clipboard";
      this.miCopyAddress.Id = 2;
      this.miCopyAddress.Name = "miCopyAddress";
      this.miCopyAddress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miCopyAddress_ItemClick);
      // 
      // miUpdateServerInfo
      // 
      this.miUpdateServerInfo.Caption = "Update Information";
      this.miUpdateServerInfo.Id = 3;
      this.miUpdateServerInfo.Name = "miUpdateServerInfo";
      this.miUpdateServerInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miUpdateServerInfo_ItemClick);
      // 
      // panelContainer1
      // 
      this.panelContainer1.ActiveChild = this.panelPlayers;
      this.panelContainer1.Controls.Add(this.panelPlayers);
      this.panelContainer1.Controls.Add(this.panelServerDetails);
      this.panelContainer1.Controls.Add(this.panelRules);
      this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
      this.panelContainer1.ID = new System.Guid("30169f55-f874-4297-811b-db9e1af4c59a");
      this.panelContainer1.Location = new System.Drawing.Point(1103, 148);
      this.panelContainer1.Name = "panelContainer1";
      this.panelContainer1.OriginalSize = new System.Drawing.Size(362, 200);
      this.panelContainer1.Size = new System.Drawing.Size(362, 636);
      this.panelContainer1.Tabbed = true;
      this.panelContainer1.Text = "panelContainer1";
      // 
      // panelPlayers
      // 
      this.panelPlayers.Controls.Add(this.dockPanel1_Container);
      this.panelPlayers.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
      this.panelPlayers.ID = new System.Guid("5ff9161d-077a-43fb-9f49-f8a0728b7b57");
      this.panelPlayers.Location = new System.Drawing.Point(4, 23);
      this.panelPlayers.Name = "panelPlayers";
      this.panelPlayers.Options.AllowFloating = false;
      this.panelPlayers.Options.ShowCloseButton = false;
      this.panelPlayers.OriginalSize = new System.Drawing.Size(354, 528);
      this.panelPlayers.Size = new System.Drawing.Size(354, 582);
      this.panelPlayers.Text = "Players";
      // 
      // dockPanel1_Container
      // 
      this.dockPanel1_Container.Controls.Add(this.gcPlayers);
      this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
      this.dockPanel1_Container.Name = "dockPanel1_Container";
      this.dockPanel1_Container.Size = new System.Drawing.Size(354, 582);
      this.dockPanel1_Container.TabIndex = 0;
      // 
      // panelServerDetails
      // 
      this.panelServerDetails.Controls.Add(this.dockPanel2_Container);
      this.panelServerDetails.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
      this.panelServerDetails.ID = new System.Guid("adca8b15-d626-4469-97cf-a6cc21c21f6e");
      this.panelServerDetails.Location = new System.Drawing.Point(4, 23);
      this.panelServerDetails.Name = "panelServerDetails";
      this.panelServerDetails.Options.AllowFloating = false;
      this.panelServerDetails.Options.ShowCloseButton = false;
      this.panelServerDetails.OriginalSize = new System.Drawing.Size(354, 528);
      this.panelServerDetails.Size = new System.Drawing.Size(354, 582);
      this.panelServerDetails.Text = "Server Details";
      // 
      // dockPanel2_Container
      // 
      this.dockPanel2_Container.Controls.Add(this.gcDetails);
      this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
      this.dockPanel2_Container.Name = "dockPanel2_Container";
      this.dockPanel2_Container.Size = new System.Drawing.Size(354, 582);
      this.dockPanel2_Container.TabIndex = 0;
      // 
      // panelRules
      // 
      this.panelRules.Controls.Add(this.controlContainer2);
      this.panelRules.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
      this.panelRules.ID = new System.Guid("7cfd1891-8f2c-4d0a-bd2c-1bb030d15a66");
      this.panelRules.Location = new System.Drawing.Point(4, 23);
      this.panelRules.Name = "panelRules";
      this.panelRules.OriginalSize = new System.Drawing.Size(354, 528);
      this.panelRules.Size = new System.Drawing.Size(354, 582);
      this.panelRules.Text = "Rules";
      // 
      // controlContainer2
      // 
      this.controlContainer2.Controls.Add(this.gcRules);
      this.controlContainer2.Location = new System.Drawing.Point(0, 0);
      this.controlContainer2.Name = "controlContainer2";
      this.controlContainer2.Size = new System.Drawing.Size(354, 582);
      this.controlContainer2.TabIndex = 0;
      // 
      // gcRules
      // 
      this.gcRules.DataSource = this.dsRules;
      this.gcRules.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gcRules.Location = new System.Drawing.Point(0, 0);
      this.gcRules.MainView = this.gvRules;
      this.gcRules.Name = "gcRules";
      this.gcRules.Size = new System.Drawing.Size(354, 582);
      this.gcRules.TabIndex = 31;
      this.gcRules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRules});
      // 
      // dsRules
      // 
      this.dsRules.DataSource = typeof(QueryMaster.Rule);
      // 
      // gvRules
      // 
      this.gvRules.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
      this.gvRules.GridControl = this.gcRules;
      this.gvRules.Name = "gvRules";
      this.gvRules.OptionsView.ShowGroupPanel = false;
      this.gvRules.OptionsView.ShowIndicator = false;
      // 
      // gridColumn1
      // 
      this.gridColumn1.Caption = "Setting";
      this.gridColumn1.FieldName = "Name";
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.OptionsColumn.ReadOnly = true;
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 0;
      this.gridColumn1.Width = 100;
      // 
      // gridColumn2
      // 
      this.gridColumn2.Caption = "Value";
      this.gridColumn2.FieldName = "Value";
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.OptionsColumn.ReadOnly = true;
      this.gridColumn2.Visible = true;
      this.gridColumn2.VisibleIndex = 1;
      this.gridColumn2.Width = 150;
      // 
      // panelServerList
      // 
      this.panelServerList.Controls.Add(this.controlContainer1);
      this.panelServerList.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
      this.panelServerList.ID = new System.Guid("865607d4-b558-4563-b50b-7827abfe171b");
      this.panelServerList.Location = new System.Drawing.Point(0, 175);
      this.panelServerList.Name = "panelServerList";
      this.panelServerList.Options.AllowDockAsTabbedDocument = false;
      this.panelServerList.Options.AllowDockRight = false;
      this.panelServerList.Options.AllowDockTop = false;
      this.panelServerList.Options.AllowFloating = false;
      this.panelServerList.Options.FloatOnDblClick = false;
      this.panelServerList.Options.ShowAutoHideButton = false;
      this.panelServerList.Options.ShowCloseButton = false;
      this.panelServerList.OriginalSize = new System.Drawing.Size(1102, 609);
      this.panelServerList.Size = new System.Drawing.Size(1103, 609);
      this.panelServerList.Text = "Servers";
      // 
      // controlContainer1
      // 
      this.controlContainer1.Controls.Add(this.gcServers);
      this.controlContainer1.Location = new System.Drawing.Point(4, 23);
      this.controlContainer1.Name = "controlContainer1";
      this.controlContainer1.Size = new System.Drawing.Size(1095, 582);
      this.controlContainer1.TabIndex = 0;
      // 
      // btnSkin
      // 
      this.btnSkin.Location = new System.Drawing.Point(1016, 9);
      this.btnSkin.Name = "btnSkin";
      this.btnSkin.Size = new System.Drawing.Size(87, 25);
      this.btnSkin.TabIndex = 22;
      this.btnSkin.Text = "Change Skin";
      this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
      // 
      // cbRefreshSelectedServer
      // 
      this.cbRefreshSelectedServer.EditValue = true;
      this.cbRefreshSelectedServer.Location = new System.Drawing.Point(771, 34);
      this.cbRefreshSelectedServer.Name = "cbRefreshSelectedServer";
      this.cbRefreshSelectedServer.Properties.AutoWidth = true;
      this.cbRefreshSelectedServer.Properties.Caption = "Refresh server when selecting a row";
      this.cbRefreshSelectedServer.Size = new System.Drawing.Size(198, 19);
      this.cbRefreshSelectedServer.TabIndex = 21;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(30, 8);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(37, 13);
      this.labelControl1.TabIndex = 20;
      this.labelControl1.Text = "Region:";
      // 
      // btnQueryMaster
      // 
      this.btnQueryMaster.Location = new System.Drawing.Point(280, 2);
      this.btnQueryMaster.Name = "btnQueryMaster";
      this.btnQueryMaster.Size = new System.Drawing.Size(87, 25);
      this.btnQueryMaster.TabIndex = 19;
      this.btnQueryMaster.Text = "Update";
      this.btnQueryMaster.Click += new System.EventHandler(this.btnQueryMaster_Click);
      // 
      // panelTop
      // 
      this.panelTop.Controls.Add(this.panelTopFill);
      this.panelTop.Controls.Add(this.picLogo);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 0);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(1465, 58);
      this.panelTop.TabIndex = 25;
      // 
      // panelTopFill
      // 
      this.panelTopFill.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.panelTopFill.Appearance.Options.UseBackColor = true;
      this.panelTopFill.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelTopFill.Controls.Add(this.panelControls);
      this.panelTopFill.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelTopFill.Location = new System.Drawing.Point(2, 2);
      this.panelTopFill.Name = "panelTopFill";
      this.panelTopFill.Size = new System.Drawing.Size(1344, 54);
      this.panelTopFill.TabIndex = 25;
      // 
      // panelControls
      // 
      this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.panelControls.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.panelControls.Appearance.Options.UseBackColor = true;
      this.panelControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControls.Controls.Add(this.panelOptions);
      this.panelControls.Controls.Add(this.panelGame);
      this.panelControls.Location = new System.Drawing.Point(0, 1);
      this.panelControls.Name = "panelControls";
      this.panelControls.Size = new System.Drawing.Size(1344, 58);
      this.panelControls.TabIndex = 25;
      // 
      // panelOptions
      // 
      this.panelOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelOptions.Controls.Add(this.linkFilter1);
      this.panelOptions.Controls.Add(this.cbAdvancedOptions);
      this.panelOptions.Controls.Add(this.labelControl1);
      this.panelOptions.Controls.Add(this.btnQueryMaster);
      this.panelOptions.Controls.Add(this.comboRegion);
      this.panelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelOptions.Location = new System.Drawing.Point(375, 0);
      this.panelOptions.Name = "panelOptions";
      this.panelOptions.Size = new System.Drawing.Size(969, 58);
      this.panelOptions.TabIndex = 26;
      // 
      // linkFilter1
      // 
      this.linkFilter1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.linkFilter1.Location = new System.Drawing.Point(30, 32);
      this.linkFilter1.Name = "linkFilter1";
      this.linkFilter1.Size = new System.Drawing.Size(454, 13);
      this.linkFilter1.TabIndex = 33;
      this.linkFilter1.Text = "HINT: Use the top row of the table for simple filters or the <href>filter editor<" +
    "/href> for more complex filters.";
      this.linkFilter1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkFilter_HyperlinkClick);
      // 
      // cbAdvancedOptions
      // 
      this.cbAdvancedOptions.Location = new System.Drawing.Point(394, 2);
      this.cbAdvancedOptions.Name = "cbAdvancedOptions";
      this.cbAdvancedOptions.Size = new System.Drawing.Size(103, 25);
      this.cbAdvancedOptions.TabIndex = 25;
      this.cbAdvancedOptions.Text = "Show Options";
      this.cbAdvancedOptions.CheckedChanged += new System.EventHandler(this.cbAdvancedOptions_CheckedChanged);
      // 
      // panelGame
      // 
      this.panelGame.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelGame.Controls.Add(this.labelControl5);
      this.panelGame.Controls.Add(this.labelControl4);
      this.panelGame.Controls.Add(this.comboGames);
      this.panelGame.Controls.Add(this.rbFavGame1);
      this.panelGame.Controls.Add(this.rbFavGame3);
      this.panelGame.Controls.Add(this.rbFavGame2);
      this.panelGame.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelGame.Location = new System.Drawing.Point(0, 0);
      this.panelGame.Name = "panelGame";
      this.panelGame.Size = new System.Drawing.Size(375, 58);
      this.panelGame.TabIndex = 24;
      // 
      // labelControl5
      // 
      this.labelControl5.Location = new System.Drawing.Point(30, 32);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(27, 13);
      this.labelControl5.TabIndex = 18;
      this.labelControl5.Text = "Favs:";
      this.labelControl5.ToolTip = "To change a favorite, select a game and hold the Ctrl key and click on a fav";
      // 
      // labelControl4
      // 
      this.labelControl4.Location = new System.Drawing.Point(30, 8);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(31, 13);
      this.labelControl4.TabIndex = 17;
      this.labelControl4.Text = "Game:";
      this.labelControl4.ToolTip = "If a game is not listed here, you can enter it\'s Steam ApplicationID here";
      // 
      // comboGames
      // 
      this.comboGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.comboGames.Location = new System.Drawing.Point(80, 5);
      this.comboGames.Name = "comboGames";
      this.comboGames.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.comboGames.Properties.DropDownRows = 30;
      this.comboGames.Size = new System.Drawing.Size(268, 20);
      this.comboGames.TabIndex = 16;
      this.comboGames.SelectedIndexChanged += new System.EventHandler(this.comboGames_SelectedIndexChanged);
      // 
      // picLogo
      // 
      this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.picLogo.Dock = System.Windows.Forms.DockStyle.Right;
      this.picLogo.Location = new System.Drawing.Point(1346, 2);
      this.picLogo.Name = "picLogo";
      this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.picLogo.Properties.Appearance.Options.UseBackColor = true;
      this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
      this.picLogo.Size = new System.Drawing.Size(117, 54);
      this.picLogo.TabIndex = 23;
      this.picLogo.Visible = false;
      this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
      // 
      // labelControl3
      // 
      this.labelControl3.Location = new System.Drawing.Point(771, 60);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(418, 13);
      this.labelControl3.TabIndex = 24;
      this.labelControl3.Text = "NOTE: Auto-update will reorder the selected row, if a value in a sorted column ch" +
    "anges";
      // 
      // btnAddGameServer
      // 
      this.btnAddGameServer.Location = new System.Drawing.Point(303, 48);
      this.btnAddGameServer.Name = "btnAddGameServer";
      this.btnAddGameServer.Size = new System.Drawing.Size(47, 25);
      this.btnAddGameServer.TabIndex = 27;
      this.btnAddGameServer.Text = "Add";
      this.btnAddGameServer.Click += new System.EventHandler(this.btnAddGameServer_Click);
      // 
      // txtServerQuery
      // 
      this.txtServerQuery.Location = new System.Drawing.Point(82, 51);
      this.txtServerQuery.Name = "txtServerQuery";
      this.txtServerQuery.Size = new System.Drawing.Size(215, 20);
      this.txtServerQuery.TabIndex = 26;
      this.txtServerQuery.ToolTip = "Use <IP-address or host name>:<query port>";
      // 
      // labelControl6
      // 
      this.labelControl6.Location = new System.Drawing.Point(5, 54);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(65, 13);
      this.labelControl6.TabIndex = 25;
      this.labelControl6.Text = "Game server:";
      // 
      // timerUpdateServerList
      // 
      this.timerUpdateServerList.Enabled = true;
      this.timerUpdateServerList.Interval = 250;
      this.timerUpdateServerList.Tick += new System.EventHandler(this.timerUpdateServerList_Tick);
      // 
      // panelAdvancedOptions
      // 
      this.panelAdvancedOptions.Controls.Add(this.linkDownloadSkins);
      this.panelAdvancedOptions.Controls.Add(this.linkFilter2);
      this.panelAdvancedOptions.Controls.Add(this.spinRefreshInterval);
      this.panelAdvancedOptions.Controls.Add(this.cbRefreshSelectedServer);
      this.panelAdvancedOptions.Controls.Add(this.labelControl3);
      this.panelAdvancedOptions.Controls.Add(this.cbAlert);
      this.panelAdvancedOptions.Controls.Add(this.btnSkin);
      this.panelAdvancedOptions.Controls.Add(this.cbShowGamePort);
      this.panelAdvancedOptions.Controls.Add(this.labelControl9);
      this.panelAdvancedOptions.Controls.Add(this.comboMasterServer);
      this.panelAdvancedOptions.Controls.Add(this.labelControl7);
      this.panelAdvancedOptions.Controls.Add(this.cbShowPlayerCountDetailColumns);
      this.panelAdvancedOptions.Controls.Add(this.btnAddGameServer);
      this.panelAdvancedOptions.Controls.Add(this.txtServerQuery);
      this.panelAdvancedOptions.Controls.Add(this.labelControl6);
      this.panelAdvancedOptions.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelAdvancedOptions.Location = new System.Drawing.Point(0, 58);
      this.panelAdvancedOptions.Name = "panelAdvancedOptions";
      this.panelAdvancedOptions.Size = new System.Drawing.Size(1465, 90);
      this.panelAdvancedOptions.TabIndex = 30;
      this.panelAdvancedOptions.Visible = false;
      // 
      // linkDownloadSkins
      // 
      this.linkDownloadSkins.Cursor = System.Windows.Forms.Cursors.Hand;
      this.linkDownloadSkins.Location = new System.Drawing.Point(1016, 37);
      this.linkDownloadSkins.Name = "linkDownloadSkins";
      this.linkDownloadSkins.Size = new System.Drawing.Size(106, 13);
      this.linkDownloadSkins.TabIndex = 33;
      this.linkDownloadSkins.Text = "Download Bonus Skins";
      this.linkDownloadSkins.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkDownloadSkins_HyperlinkClick);
      // 
      // linkFilter2
      // 
      this.linkFilter2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.linkFilter2.Location = new System.Drawing.Point(668, 60);
      this.linkFilter2.Name = "linkFilter2";
      this.linkFilter2.Size = new System.Drawing.Size(22, 13);
      this.linkFilter2.TabIndex = 32;
      this.linkFilter2.Text = "filter";
      this.linkFilter2.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.linkFilter_HyperlinkClick);
      // 
      // spinRefreshInterval
      // 
      this.spinRefreshInterval.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spinRefreshInterval.Location = new System.Drawing.Point(900, 12);
      this.spinRefreshInterval.MenuManager = this.barManager1;
      this.spinRefreshInterval.Name = "spinRefreshInterval";
      this.spinRefreshInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spinRefreshInterval.Properties.DisplayFormat.FormatString = "n0";
      this.spinRefreshInterval.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spinRefreshInterval.Properties.Mask.EditMask = "d";
      this.spinRefreshInterval.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.spinRefreshInterval.Properties.MaxValue = new decimal(new int[] {
            15,
            0,
            0,
            0});
      this.spinRefreshInterval.Size = new System.Drawing.Size(47, 20);
      this.spinRefreshInterval.TabIndex = 31;
      this.spinRefreshInterval.EditValueChanged += new System.EventHandler(this.spinRefreshInterval_EditValueChanged);
      // 
      // cbAlert
      // 
      this.cbAlert.Location = new System.Drawing.Point(407, 57);
      this.cbAlert.MenuManager = this.barManager1;
      this.cbAlert.Name = "cbAlert";
      this.cbAlert.Properties.AutoWidth = true;
      this.cbAlert.Properties.Caption = "Show alert and play sound when servers pass the";
      this.cbAlert.Size = new System.Drawing.Size(261, 19);
      this.cbAlert.TabIndex = 2;
      this.cbAlert.CheckedChanged += new System.EventHandler(this.cbAlert_CheckedChanged);
      // 
      // cbShowGamePort
      // 
      this.cbShowGamePort.Location = new System.Drawing.Point(407, 12);
      this.cbShowGamePort.Name = "cbShowGamePort";
      this.cbShowGamePort.Properties.AutoWidth = true;
      this.cbShowGamePort.Properties.Caption = "Show Game Port in Address (instead of Query Port)";
      this.cbShowGamePort.Size = new System.Drawing.Size(269, 19);
      this.cbShowGamePort.TabIndex = 30;
      this.cbShowGamePort.ToolTip = resources.GetString("cbShowGamePort.ToolTip");
      this.cbShowGamePort.CheckedChanged += new System.EventHandler(this.cbShowGamePort_CheckedChanged);
      // 
      // labelControl9
      // 
      this.labelControl9.Location = new System.Drawing.Point(771, 15);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new System.Drawing.Size(113, 13);
      this.labelControl9.TabIndex = 3;
      this.labelControl9.Text = "Refresh interval (mins):";
      // 
      // comboMasterServer
      // 
      this.comboMasterServer.Location = new System.Drawing.Point(82, 12);
      this.comboMasterServer.Name = "comboMasterServer";
      this.comboMasterServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.comboMasterServer.Properties.Items.AddRange(new object[] {
            "hl1master.steampowered.com:27011",
            "hl2master.steampowered.com:27011",
            "95.211.211.141:27010"});
      this.comboMasterServer.Size = new System.Drawing.Size(268, 20);
      this.comboMasterServer.TabIndex = 29;
      // 
      // labelControl7
      // 
      this.labelControl7.Location = new System.Drawing.Point(5, 15);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(71, 13);
      this.labelControl7.TabIndex = 28;
      this.labelControl7.Text = "Master server:";
      // 
      // cbShowPlayerCountDetailColumns
      // 
      this.cbShowPlayerCountDetailColumns.EditValue = true;
      this.cbShowPlayerCountDetailColumns.Location = new System.Drawing.Point(407, 34);
      this.cbShowPlayerCountDetailColumns.MenuManager = this.barManager1;
      this.cbShowPlayerCountDetailColumns.Name = "cbShowPlayerCountDetailColumns";
      this.cbShowPlayerCountDetailColumns.Properties.AutoWidth = true;
      this.cbShowPlayerCountDetailColumns.Properties.Caption = "Show humans/bots/total/max counts in separate columns";
      this.cbShowPlayerCountDetailColumns.Size = new System.Drawing.Size(296, 19);
      this.cbShowPlayerCountDetailColumns.TabIndex = 1;
      this.cbShowPlayerCountDetailColumns.CheckedChanged += new System.EventHandler(this.cbShowPlayerCountDetailColumns_CheckedChanged);
      // 
      // panelControl1
      // 
      this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl1.Controls.Add(this.txtStatus);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl1.Location = new System.Drawing.Point(0, 784);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(1465, 24);
      this.panelControl1.TabIndex = 35;
      // 
      // txtStatus
      // 
      this.txtStatus.Location = new System.Drawing.Point(8, 3);
      this.txtStatus.Name = "txtStatus";
      this.txtStatus.Size = new System.Drawing.Size(0, 13);
      this.txtStatus.TabIndex = 0;
      // 
      // menuServers
      // 
      this.menuServers.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.miUpdateServerInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.miConnect),
            new DevExpress.XtraBars.LinkPersistInfo(this.miConnectSpectator),
            new DevExpress.XtraBars.LinkPersistInfo(this.miCopyAddress, true)});
      this.menuServers.Manager = this.barManager1;
      this.menuServers.Name = "menuServers";
      // 
      // menuPlayers
      // 
      this.menuPlayers.Manager = this.barManager1;
      this.menuPlayers.Name = "menuPlayers";
      // 
      // timerReloadServers
      // 
      this.timerReloadServers.Tick += new System.EventHandler(this.timerReloadServers_Tick);
      // 
      // alertControl1
      // 
      this.alertControl1.AutoHeight = true;
      this.alertControl1.FormMaxCount = 1;
      this.alertControl1.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alertControl1_AlertClick);
      // 
      // ServerBrowserForm
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1465, 808);
      this.Controls.Add(this.panelServerList);
      this.Controls.Add(this.panelContainer1);
      this.Controls.Add(this.panelControl1);
      this.Controls.Add(this.panelAdvancedOptions);
      this.Controls.Add(this.panelTop);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.Name = "ServerBrowserForm";
      this.Text = "Steam Server Browser";
      ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboRegion.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rbFavGame3.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcPlayers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvPlayers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gcServers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsServers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvServers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      this.panelContainer1.ResumeLayout(false);
      this.panelPlayers.ResumeLayout(false);
      this.dockPanel1_Container.ResumeLayout(false);
      this.panelServerDetails.ResumeLayout(false);
      this.dockPanel2_Container.ResumeLayout(false);
      this.panelRules.ResumeLayout(false);
      this.controlContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gcRules)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsRules)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvRules)).EndInit();
      this.panelServerList.ResumeLayout(false);
      this.controlContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cbRefreshSelectedServer.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
      this.panelTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelTopFill)).EndInit();
      this.panelTopFill.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControls)).EndInit();
      this.panelControls.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelOptions)).EndInit();
      this.panelOptions.ResumeLayout(false);
      this.panelOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelGame)).EndInit();
      this.panelGame.ResumeLayout(false);
      this.panelGame.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.comboGames.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtServerQuery.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelAdvancedOptions)).EndInit();
      this.panelAdvancedOptions.ResumeLayout(false);
      this.panelAdvancedOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spinRefreshInterval.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbAlert.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbShowGamePort.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.comboMasterServer.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbShowPlayerCountDetailColumns.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.menuServers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.menuPlayers)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gcDetails;
    private DevExpress.XtraGrid.Views.Grid.GridView gvDetails;
    private DevExpress.XtraGrid.GridControl gcPlayers;
    private DevExpress.XtraGrid.Views.Grid.GridView gvPlayers;
    private DevExpress.XtraGrid.GridControl gcServers;
    private DevExpress.XtraGrid.Views.Grid.GridView gvServers;
    private CheckEdit rbFavGame3;
    private ComboBoxEdit comboRegion;
    private CheckEdit rbFavGame2;
    private CheckEdit rbFavGame1;
    private DevExpress.XtraBars.Docking.DockManager dockManager1;
    private DevExpress.XtraBars.Docking.DockPanel panelServerDetails;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
    private DevExpress.XtraBars.Docking.DockPanel panelPlayers;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    private System.Windows.Forms.BindingSource dsServers;
    private DevExpress.XtraGrid.Columns.GridColumn colEndPoint;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colPing;
    private DevExpress.XtraGrid.Columns.GridColumn colHumanPlayers;
    private DevExpress.XtraGrid.Columns.GridColumn colMap;
    private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    private System.Windows.Forms.BindingSource dsPlayer;
    private DevExpress.XtraGrid.Columns.GridColumn colName1;
    private DevExpress.XtraGrid.Columns.GridColumn colScore;
    private DevExpress.XtraGrid.Columns.GridColumn colTime;
    private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    private DevExpress.XtraGrid.Columns.GridColumn colKey;
    private DevExpress.XtraGrid.Columns.GridColumn colValue;
    private DevExpress.XtraGrid.Columns.GridColumn colKeywords;
    private DevExpress.XtraGrid.Columns.GridColumn colPrivate;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEdit;
    private CheckEdit cbRefreshSelectedServer;
    private LabelControl labelControl1;
    private SimpleButton btnQueryMaster;
    private SimpleButton btnSkin;
    private PanelControl panelTop;
    private PictureEdit picLogo;
    private PanelControl panelGame;
    private PanelControl panelTopFill;
    private PanelControl panelControls;
    private PanelControl panelOptions;
    private LabelControl labelControl3;
    private DevExpress.XtraBars.Docking.DockPanel panelServerList;
    private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
    private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
    private DevExpress.XtraBars.Docking.DockPanel panelRules;
    private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
    private DevExpress.XtraGrid.GridControl gcRules;
    private DevExpress.XtraGrid.Views.Grid.GridView gvRules;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    private System.Windows.Forms.BindingSource dsRules;
    private DevExpress.XtraGrid.Columns.GridColumn colDedicated;
    private ComboBoxEdit comboGames;
    private LabelControl labelControl4;
    private LabelControl labelControl5;
    private System.Windows.Forms.Timer timerUpdateServerList;
    private SimpleButton btnAddGameServer;
    private TextEdit txtServerQuery;
    private LabelControl labelControl6;
    private PanelControl panelAdvancedOptions;
    private LabelControl labelControl7;
    private CheckButton cbAdvancedOptions;
    private ComboBoxEdit comboMasterServer;
    private PanelControl panelControl1;
    private LabelControl txtStatus;
    private CheckEdit cbShowGamePort;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.BarButtonItem miConnect;
    private DevExpress.XtraBars.BarButtonItem miConnectSpectator;
    private DevExpress.XtraBars.PopupMenu menuServers;
    private DevExpress.XtraBars.BarButtonItem miCopyAddress;
    private DevExpress.XtraBars.PopupMenu menuPlayers;
    private DevExpress.XtraBars.BarButtonItem miUpdateServerInfo;
    private DevExpress.XtraGrid.Columns.GridColumn colBots;
    private DevExpress.XtraGrid.Columns.GridColumn colTotalPlayers;
    private DevExpress.XtraGrid.Columns.GridColumn colMaxPlayers;
    private DevExpress.XtraGrid.Columns.GridColumn colPlayerCount;
    private LabelControl labelControl9;
    private CheckEdit cbAlert;
    private CheckEdit cbShowPlayerCountDetailColumns;
    private SpinEdit spinRefreshInterval;
    private System.Windows.Forms.Timer timerReloadServers;
    private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    private HyperlinkLabelControl linkFilter2;
    private HyperlinkLabelControl linkFilter1;
    private HyperlinkLabelControl linkDownloadSkins;



  }
}
