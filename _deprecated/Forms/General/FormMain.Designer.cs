using SDB.UserControls;
using SDB.UserControls.Asset;
using SDB.UserControls.Customer;
using SDB.UserControls.General;
using SDB.UserControls.Tech;
using SDB.UserControls.Ticket;

namespace SDB.Forms.General
{
	sealed partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.txtCreateTicket_Asset = new System.Windows.Forms.TextBox();
            this.lblRightBar_CurrentDate = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblSearch_DateRangeTo = new System.Windows.Forms.Label();
            this.btnSearch_SearchAll = new System.Windows.Forms.Button();
            this.txtSearch_SearchAll = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch_Tech = new System.Windows.Forms.TextBox();
            this.btnSearch_DateRange = new System.Windows.Forms.Button();
            this.dtpSearch_DateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpSearch_DateTo = new System.Windows.Forms.DateTimePicker();
            this.txtSearch_Asset = new System.Windows.Forms.TextBox();
            this.txtSearch_Ticket = new System.Windows.Forms.TextBox();
            this.lblSearch_Tech = new System.Windows.Forms.Label();
            this.lblSearch_Asset = new System.Windows.Forms.Label();
            this.lblSearch_Ticket = new System.Windows.Forms.Label();
            this.txtLogin_Password = new System.Windows.Forms.TextBox();
            this.lblLogin_UserID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin_UserID = new System.Windows.Forms.TextBox();
            this.lblLogin_Password = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTracker = new System.Windows.Forms.TabPage();
            this.ticketTracker = new SDB.UserControls.Ticket.TicketTracker();
            this.tabTicket = new System.Windows.Forms.TabPage();
            this.ucTicketEditor1 = new SDB.UserControls.Ticket.TicketEditor();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.ucAssetEditor1 = new SDB.UserControls.Asset.AssetEditor();
            this.tabTech = new System.Windows.Forms.TabPage();
            this.ucTechEditor1 = new SDB.UserControls.Tech.TechEditor();
            this.tabMarket = new System.Windows.Forms.TabPage();
            this.customerEditor1 = new SDB.UserControls.Customer.CustomerEditor();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_UserDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Configure = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_AdminEmails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_AssetOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_Assemblies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_CameraTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_AssetTag_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_Markets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_RentalCompanies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_Salespeople = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_ShipmentMethods = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_SymptomsSolutions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_TOSChecklist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdmin_Config_RMAFailureRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_RMAComponents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_Config_RMAZones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_ActivityPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdmin_LogOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAdmin_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_CameraCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_CameraCheckReview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_CameraCheckAudit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuView_Notifications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuView_Lists = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_List_Asset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_List_Market = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_List_Rental = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_List_Tech = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_List_Ticket = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.magicInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuView_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRma_List = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRma_Migration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRma_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRma_Legacy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShipments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoto_RecentAssets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoto_RecentTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGoto_RecentTechs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_ChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.troubleshootingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Troubleshooting_ViewLogFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Troubleshooting_ReportProblem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrRefresh_GeneralNotes = new System.Windows.Forms.Timer(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCameraCheck_Due = new System.Windows.Forms.Button();
            this.btnCameraCheck_Fails = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain_RightBar = new System.Windows.Forms.Panel();
            this.pnlRightBar_GeneralNotes = new System.Windows.Forms.Panel();
            this.ucGeneralNotes1 = new SDB.UserControls.General.ucGeneralNotes();
            this.lblRightBar_GeneralNotes = new System.Windows.Forms.Label();
            this.pnlRightBar_Search = new System.Windows.Forms.Panel();
            this.lblRightBar_Search = new System.Windows.Forms.Label();
            this.pnlRightBar_CreateTicket = new System.Windows.Forms.Panel();
            this.lblRightBar_CreateTicket = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus_Connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPad = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_Email = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrIdleCheck = new System.Windows.Forms.Timer(this.components);
            this.btnNotifications = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lnkLogin_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tmrFlasher_Notifications = new System.Windows.Forms.Timer(this.components);
            this.tmrRefresh_Notifications = new System.Windows.Forms.Timer(this.components);
            this.tmrRefresh_Tracker = new System.Windows.Forms.Timer(this.components);
            this.tmrRefresh_CameraChecks = new System.Windows.Forms.Timer(this.components);
            this.tmrFlasher_CameraCheckDue = new System.Windows.Forms.Timer(this.components);
            this.tmrFlasher_CameraCheckReview = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckLogout = new System.Windows.Forms.Timer(this.components);
            this.tabMain.SuspendLayout();
            this.tabTracker.SuspendLayout();
            this.tabTicket.SuspendLayout();
            this.tabAsset.SuspendLayout();
            this.tabTech.SuspendLayout();
            this.tabMarket.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlMain_RightBar.SuspendLayout();
            this.pnlRightBar_GeneralNotes.SuspendLayout();
            this.pnlRightBar_Search.SuspendLayout();
            this.pnlRightBar_CreateTicket.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(117, 22);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(96, 23);
            this.btnCreateTicket.TabIndex = 2;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // txtCreateTicket_Asset
            // 
            this.txtCreateTicket_Asset.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCreateTicket_Asset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreateTicket_Asset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateTicket_Asset.Location = new System.Drawing.Point(3, 20);
            this.txtCreateTicket_Asset.MaxLength = 300;
            this.txtCreateTicket_Asset.Name = "txtCreateTicket_Asset";
            this.txtCreateTicket_Asset.Size = new System.Drawing.Size(109, 26);
            this.txtCreateTicket_Asset.TabIndex = 1;
            this.txtCreateTicket_Asset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtCreateTicket_Asset, "Asset name to create ticket for.");
            this.txtCreateTicket_Asset.GotFocus += new System.EventHandler(this.txtCreateTicket_Asset_GotFocus);
            this.txtCreateTicket_Asset.LostFocus += new System.EventHandler(this.txtCreateTicket_Asset_LostFocus);
            // 
            // lblRightBar_CurrentDate
            // 
            this.lblRightBar_CurrentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightBar_CurrentDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightBar_CurrentDate.ForeColor = System.Drawing.Color.Navy;
            this.lblRightBar_CurrentDate.Location = new System.Drawing.Point(0, 0);
            this.lblRightBar_CurrentDate.Name = "lblRightBar_CurrentDate";
            this.lblRightBar_CurrentDate.Size = new System.Drawing.Size(224, 30);
            this.lblRightBar_CurrentDate.TabIndex = 1;
            this.lblRightBar_CurrentDate.Text = "0000-00-00 00:00:00";
            this.lblRightBar_CurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lblSearch_DateRangeTo
            // 
            this.lblSearch_DateRangeTo.AutoSize = true;
            this.lblSearch_DateRangeTo.Location = new System.Drawing.Point(104, 26);
            this.lblSearch_DateRangeTo.Name = "lblSearch_DateRangeTo";
            this.lblSearch_DateRangeTo.Size = new System.Drawing.Size(16, 13);
            this.lblSearch_DateRangeTo.TabIndex = 1;
            this.lblSearch_DateRangeTo.Text = "to";
            // 
            // btnSearch_SearchAll
            // 
            this.btnSearch_SearchAll.Location = new System.Drawing.Point(67, 198);
            this.btnSearch_SearchAll.Name = "btnSearch_SearchAll";
            this.btnSearch_SearchAll.Size = new System.Drawing.Size(91, 23);
            this.btnSearch_SearchAll.TabIndex = 12;
            this.btnSearch_SearchAll.Text = "Search All";
            this.btnSearch_SearchAll.UseVisualStyleBackColor = true;
            this.btnSearch_SearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // txtSearch_SearchAll
            // 
            this.txtSearch_SearchAll.Location = new System.Drawing.Point(3, 174);
            this.txtSearch_SearchAll.MaxLength = 32;
            this.txtSearch_SearchAll.Name = "txtSearch_SearchAll";
            this.txtSearch_SearchAll.Size = new System.Drawing.Size(216, 20);
            this.txtSearch_SearchAll.TabIndex = 11;
            this.txtSearch_SearchAll.Enter += new System.EventHandler(this.txtSearchAll_Enter);
            this.txtSearch_SearchAll.Leave += new System.EventHandler(this.txtSearchAll_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(91, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch_Tech
            // 
            this.txtSearch_Tech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch_Tech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch_Tech.Location = new System.Drawing.Point(91, 123);
            this.txtSearch_Tech.MaxLength = 64;
            this.txtSearch_Tech.Name = "txtSearch_Tech";
            this.txtSearch_Tech.Size = new System.Drawing.Size(128, 20);
            this.txtSearch_Tech.TabIndex = 9;
            this.txtSearch_Tech.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch_Tech.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch_DateRange
            // 
            this.btnSearch_DateRange.Location = new System.Drawing.Point(45, 44);
            this.btnSearch_DateRange.Name = "btnSearch_DateRange";
            this.btnSearch_DateRange.Size = new System.Drawing.Size(134, 24);
            this.btnSearch_DateRange.TabIndex = 3;
            this.btnSearch_DateRange.Text = "Search Date Range";
            this.toolTip.SetToolTip(this.btnSearch_DateRange, "Find tickets opened in the specified date range.");
            this.btnSearch_DateRange.UseVisualStyleBackColor = true;
            this.btnSearch_DateRange.Click += new System.EventHandler(this.btnSearchDateRange_Click);
            // 
            // dtpSearch_DateFrom
            // 
            this.dtpSearch_DateFrom.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_DateFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_DateFrom.Location = new System.Drawing.Point(13, 20);
            this.dtpSearch_DateFrom.Name = "dtpSearch_DateFrom";
            this.dtpSearch_DateFrom.Size = new System.Drawing.Size(85, 20);
            this.dtpSearch_DateFrom.TabIndex = 0;
            // 
            // dtpSearch_DateTo
            // 
            this.dtpSearch_DateTo.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_DateTo.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_DateTo.Location = new System.Drawing.Point(126, 20);
            this.dtpSearch_DateTo.Name = "dtpSearch_DateTo";
            this.dtpSearch_DateTo.Size = new System.Drawing.Size(85, 20);
            this.dtpSearch_DateTo.TabIndex = 2;
            // 
            // txtSearch_Asset
            // 
            this.txtSearch_Asset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch_Asset.Location = new System.Drawing.Point(91, 99);
            this.txtSearch_Asset.MaxLength = 20;
            this.txtSearch_Asset.Name = "txtSearch_Asset";
            this.txtSearch_Asset.Size = new System.Drawing.Size(128, 20);
            this.txtSearch_Asset.TabIndex = 7;
            this.txtSearch_Asset.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch_Asset.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtSearch_Ticket
            // 
            this.txtSearch_Ticket.Location = new System.Drawing.Point(91, 75);
            this.txtSearch_Ticket.MaxLength = 10;
            this.txtSearch_Ticket.Name = "txtSearch_Ticket";
            this.txtSearch_Ticket.Size = new System.Drawing.Size(128, 20);
            this.txtSearch_Ticket.TabIndex = 5;
            this.txtSearch_Ticket.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch_Ticket.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lblSearch_Tech
            // 
            this.lblSearch_Tech.AutoSize = true;
            this.lblSearch_Tech.Location = new System.Drawing.Point(50, 126);
            this.lblSearch_Tech.Name = "lblSearch_Tech";
            this.lblSearch_Tech.Size = new System.Drawing.Size(35, 13);
            this.lblSearch_Tech.TabIndex = 8;
            this.lblSearch_Tech.Text = "Tech:";
            // 
            // lblSearch_Asset
            // 
            this.lblSearch_Asset.AutoSize = true;
            this.lblSearch_Asset.Location = new System.Drawing.Point(11, 102);
            this.lblSearch_Asset.Name = "lblSearch_Asset";
            this.lblSearch_Asset.Size = new System.Drawing.Size(74, 13);
            this.lblSearch_Asset.TabIndex = 6;
            this.lblSearch_Asset.Text = "Asset / Panel:";
            // 
            // lblSearch_Ticket
            // 
            this.lblSearch_Ticket.AutoSize = true;
            this.lblSearch_Ticket.Location = new System.Drawing.Point(9, 78);
            this.lblSearch_Ticket.Name = "lblSearch_Ticket";
            this.lblSearch_Ticket.Size = new System.Drawing.Size(76, 13);
            this.lblSearch_Ticket.TabIndex = 4;
            this.lblSearch_Ticket.Text = "Ticket / Issue:";
            // 
            // txtLogin_Password
            // 
            this.txtLogin_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin_Password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_Password.Location = new System.Drawing.Point(61, 127);
            this.txtLogin_Password.Name = "txtLogin_Password";
            this.txtLogin_Password.Size = new System.Drawing.Size(240, 26);
            this.txtLogin_Password.TabIndex = 4;
            this.txtLogin_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin_Password.UseSystemPasswordChar = true;
            this.txtLogin_Password.TextChanged += new System.EventHandler(this.txtLogin_Password_TextChanged);
            this.txtLogin_Password.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblLogin_UserID
            // 
            this.lblLogin_UserID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin_UserID.AutoSize = true;
            this.lblLogin_UserID.Location = new System.Drawing.Point(58, 40);
            this.lblLogin_UserID.Name = "lblLogin_UserID";
            this.lblLogin_UserID.Size = new System.Drawing.Size(46, 13);
            this.lblLogin_UserID.TabIndex = 0;
            this.lblLogin_UserID.Text = "User ID:";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.Location = new System.Drawing.Point(178, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin_UserID
            // 
            this.txtLogin_UserID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin_UserID.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin_UserID.Location = new System.Drawing.Point(61, 56);
            this.txtLogin_UserID.MaxLength = 10;
            this.txtLogin_UserID.Name = "txtLogin_UserID";
            this.txtLogin_UserID.Size = new System.Drawing.Size(240, 26);
            this.txtLogin_UserID.TabIndex = 3;
            this.txtLogin_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin_UserID.TextChanged += new System.EventHandler(this.txtLogin_UserID_TextChanged);
            this.txtLogin_UserID.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblLogin_Password
            // 
            this.lblLogin_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin_Password.AutoSize = true;
            this.lblLogin_Password.Location = new System.Drawing.Point(58, 111);
            this.lblLogin_Password.Name = "lblLogin_Password";
            this.lblLogin_Password.Size = new System.Drawing.Size(56, 13);
            this.lblLogin_Password.TabIndex = 0;
            this.lblLogin_Password.Text = "Password:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTracker);
            this.tabMain.Controls.Add(this.tabTicket);
            this.tabMain.Controls.Add(this.tabAsset);
            this.tabMain.Controls.Add(this.tabTech);
            this.tabMain.Controls.Add(this.tabMarket);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(847, 695);
            this.tabMain.TabIndex = 0;
            this.tabMain.Tag = "Orig Location 2,27";
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabTracker
            // 
            this.tabTracker.Controls.Add(this.ticketTracker);
            this.tabTracker.Location = new System.Drawing.Point(4, 22);
            this.tabTracker.Name = "tabTracker";
            this.tabTracker.Size = new System.Drawing.Size(839, 669);
            this.tabTracker.TabIndex = 10;
            this.tabTracker.Text = "Tracker";
            this.tabTracker.ToolTipText = "The Whirlwind";
            this.tabTracker.UseVisualStyleBackColor = true;
            // 
            // ticketTracker
            // 
            this.ticketTracker.Cursor = System.Windows.Forms.Cursors.Default;
            this.ticketTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketTracker.Location = new System.Drawing.Point(0, 0);
            this.ticketTracker.Name = "ticketTracker";
            this.ticketTracker.Size = new System.Drawing.Size(839, 669);
            this.ticketTracker.TabIndex = 0;
            this.ticketTracker.Ticket_Click += new SDB.UserControls.Ticket.TicketTracker.TicketDelegate(this.ticketTracker_Ticket_Click);
            this.ticketTracker.TicketRental_Click += new SDB.UserControls.Ticket.TicketTracker.TicketRentalDelegate(this.ticketTracker_TicketRental_Click);
            this.ticketTracker.Journal_Click += new SDB.UserControls.Ticket.TicketTracker.TicketDelegate(this.ticketTracker_Journal_Click);
            this.ticketTracker.Asset_Click += new SDB.UserControls.Ticket.TicketTracker.AssetDelegate(this.ticketTracker_Asset_Click);
            this.ticketTracker.Tech_Click += new SDB.UserControls.Ticket.TicketTracker.TechDelegate(this.ticketTracker_Tech_Click);
            // 
            // tabTicket
            // 
            this.tabTicket.Controls.Add(this.ucTicketEditor1);
            this.tabTicket.Location = new System.Drawing.Point(4, 22);
            this.tabTicket.Name = "tabTicket";
            this.tabTicket.Size = new System.Drawing.Size(839, 669);
            this.tabTicket.TabIndex = 9;
            this.tabTicket.Text = "Ticket";
            this.tabTicket.ToolTipText = "Ticket Editor";
            this.tabTicket.UseVisualStyleBackColor = true;
            // 
            // ucTicketEditor1
            // 
            this.ucTicketEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTicketEditor1.Location = new System.Drawing.Point(0, 0);
            this.ucTicketEditor1.Name = "ucTicketEditor1";
            this.ucTicketEditor1.Size = new System.Drawing.Size(839, 669);
            this.ucTicketEditor1.TabIndex = 0;
            this.ucTicketEditor1.TicketLoaded += new SDB.UserControls.Ticket.TicketEditor.TicketEvent(this.ucTicketEditor1_TicketLoaded);
            this.ucTicketEditor1.ViewOSA += new SDB.UserControls.Ticket.TicketEditor.TicketAssetTechEvent(this.ucTicketEditor1_ViewOSA);
            this.ucTicketEditor1.CreateRMA += new SDB.UserControls.Ticket.TicketEditor.TicketEvent(this.ucTicketEditor1_CreateRMA);
            this.ucTicketEditor1.CreateShipment += new SDB.UserControls.Ticket.TicketEditor.TicketAssetTechEvent(this.ucTicketEditor1_CreateShipment);
            this.ucTicketEditor1.ViewMarket += new SDB.UserControls.Ticket.TicketEditor.MarketEvent(this.ucTicketEditor1_ViewMarket);
            this.ucTicketEditor1.ViewTech += new SDB.UserControls.Ticket.TicketEditor.TechEvent(this.ucTicketEditor1_ViewTech);
            this.ucTicketEditor1.ViewAsset += new SDB.UserControls.Ticket.TicketEditor.AssetEvent(this.ucTicketEditor1_ViewAsset);
            this.ucTicketEditor1.LaunchDashboard += new SDB.UserControls.Ticket.TicketEditor.AssetEvent(this.ucTicketEditor1_LaunchDashboard);
            this.ucTicketEditor1.LaunchVNC += new SDB.UserControls.Ticket.TicketEditor.AssetEvent(this.ucTicketEditor1_LaunchVNC);
            this.ucTicketEditor1.LaunchTeamviewer += new SDB.UserControls.Ticket.TicketEditor.AssetEvent(this.ucTicketEditor1_LaunchTeamviewer);
            this.ucTicketEditor1.ViewLegacyRMA += new SDB.UserControls.Ticket.TicketEditor.RMAEvent(this.ucTicketEditor1_ViewLegacyRMA);
            this.ucTicketEditor1.ViewRMA += new SDB.UserControls.Ticket.TicketEditor.RMAEvent(this.ucTicketEditor1_ViewRMA);
            this.ucTicketEditor1.ViewShipment += new SDB.UserControls.Ticket.TicketEditor.ShipmentEvent(this.ucTicketEditor1_ViewShipment);
            this.ucTicketEditor1.ViewTracking += new SDB.UserControls.Ticket.TicketEditor.TrackingEvent(this.ucTicketEditor1_ViewTracking);
            this.ucTicketEditor1.TicketUpdated += new SDB.UserControls.Ticket.TicketEditor.UpdateEvent(this.ucTicketEditor1_TicketUpdated);
            // 
            // tabAsset
            // 
            this.tabAsset.Controls.Add(this.ucAssetEditor1);
            this.tabAsset.Location = new System.Drawing.Point(4, 22);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Size = new System.Drawing.Size(839, 669);
            this.tabAsset.TabIndex = 8;
            this.tabAsset.Text = "Asset";
            this.tabAsset.ToolTipText = "Asset Editor";
            this.tabAsset.UseVisualStyleBackColor = true;
            // 
            // ucAssetEditor1
            // 
            this.ucAssetEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssetEditor1.Location = new System.Drawing.Point(0, 0);
            this.ucAssetEditor1.Name = "ucAssetEditor1";
            this.ucAssetEditor1.Size = new System.Drawing.Size(839, 669);
            this.ucAssetEditor1.TabIndex = 0;
            this.ucAssetEditor1.TechDoubleClicked += new SDB.UserControls.Asset.AssetEditor.TechClickedEvent(this.ucAssetEditor1_TechDoubleClicked);
            this.ucAssetEditor1.TicketDoubleClicked += new SDB.UserControls.Asset.AssetEditor.TicketClickedEvent(this.ucAssetEditor1_TicketDoubleClicked);
            this.ucAssetEditor1.TicketCreated += new SDB.UserControls.Asset.AssetEditor.TicketCreatedEvent(this.ucAssetEditor1_TicketCreated);
            this.ucAssetEditor1.AssetLoaded += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_AssetLoaded);
            this.ucAssetEditor1.LaunchDashboard += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_LaunchDashboard);
            this.ucAssetEditor1.LaunchVNC += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_LaunchVNC);
            this.ucAssetEditor1.LaunchTeamviewer += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_LaunchTeamviewer);
            this.ucAssetEditor1.ViewMarket += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_MarketDoubleClicked);
            this.ucAssetEditor1.OpenURL_Camera += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_Camera);
            this.ucAssetEditor1.OpenURL_IBoot += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_IBoot);
            this.ucAssetEditor1.OpenURL_MiniGoose += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_MiniGoose);
            this.ucAssetEditor1.OpenURL_LatLongMap += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_LatLongMap);
            this.ucAssetEditor1.OpenURL_Server += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_Server);
            this.ucAssetEditor1.OpenURL_WebVNC += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_OpenURL_WebVNC);
            this.ucAssetEditor1.CreateShipment += new SDB.UserControls.Asset.AssetEditor.AssetEvent(this.ucAssetEditor1_CreateShipment);
            this.ucAssetEditor1.AssetClicked += new SDB.UserControls.Asset.AssetEditor.AssetIDEvent(this.ucAssetEditor1_AssetClicked);
            this.ucAssetEditor1.ViewLegacyRMA += new SDB.UserControls.Asset.AssetEditor.RMAClickedEvent(this.ucAssetEditor1_ViewLegacyRMA);
            this.ucAssetEditor1.ViewRMA += new SDB.UserControls.Asset.AssetEditor.RMAClickedEvent(this.ucAssetEditor1_ViewRMA);
            this.ucAssetEditor1.ViewShipment += new SDB.UserControls.Asset.AssetEditor.ShipmentEvent(this.ucAssetEditor1_ViewShipment);
            this.ucAssetEditor1.AssetUpdated += new SDB.UserControls.Asset.AssetEditor.UpdateEvent(this.ucAssetEditor1_AssetUpdated);
            this.ucAssetEditor1.ViewTracking += new SDB.UserControls.Asset.AssetEditor.TrackingEvent(this.ucAssetEditor1_ViewTracking);
            // 
            // tabTech
            // 
            this.tabTech.Controls.Add(this.ucTechEditor1);
            this.tabTech.Location = new System.Drawing.Point(4, 22);
            this.tabTech.Name = "tabTech";
            this.tabTech.Size = new System.Drawing.Size(839, 669);
            this.tabTech.TabIndex = 7;
            this.tabTech.Text = "Tech";
            this.tabTech.ToolTipText = "Tech Editor";
            this.tabTech.UseVisualStyleBackColor = true;
            // 
            // ucTechEditor1
            // 
            this.ucTechEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTechEditor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTechEditor1.Location = new System.Drawing.Point(0, 0);
            this.ucTechEditor1.Name = "ucTechEditor1";
            this.ucTechEditor1.Size = new System.Drawing.Size(839, 669);
            this.ucTechEditor1.TabIndex = 0;
            this.ucTechEditor1.ViewAsset += new SDB.UserControls.Tech.TechEditor.AssetEvent(this.ucTechEditor1_AssetDoubleClicked);
            this.ucTechEditor1.ViewTicket += new SDB.UserControls.Tech.TechEditor.TicketEvent(this.ucTechEditor1_TicketDoubleClicked);
            this.ucTechEditor1.TechLoaded += new SDB.UserControls.Tech.TechEditor.TechEvent(this.ucTechEditor1_TechLoaded);
            this.ucTechEditor1.CreateShipment += new SDB.UserControls.Tech.TechEditor.TechEvent(this.ucTechEditor1_CreateShipment);
            this.ucTechEditor1.ViewLegacyRMA += new SDB.UserControls.Tech.TechEditor.RMAEvent(this.ucTechEditor1_ViewLegacyRMA);
            this.ucTechEditor1.ViewRMA += new SDB.UserControls.Tech.TechEditor.RMAEvent(this.ucTechEditor1_ViewRMA);
            this.ucTechEditor1.ViewShipment += new SDB.UserControls.Tech.TechEditor.ShipmentEvent(this.ucTechEditor1_ViewShipment);
            this.ucTechEditor1.ViewTracking += new SDB.UserControls.Tech.TechEditor.TrackingEvent(this.ucTechEditor1_ViewTracking);
            this.ucTechEditor1.TechUpdated += new SDB.UserControls.Tech.TechEditor.UpdateEvent(this.ucTechEditor1_TechUpdated);
            // 
            // tabMarket
            // 
            this.tabMarket.Controls.Add(this.customerEditor1);
            this.tabMarket.Location = new System.Drawing.Point(4, 22);
            this.tabMarket.Name = "tabMarket";
            this.tabMarket.Size = new System.Drawing.Size(839, 669);
            this.tabMarket.TabIndex = 6;
            this.tabMarket.Text = "Market";
            this.tabMarket.ToolTipText = "Customer \\& Market Editor";
            this.tabMarket.UseVisualStyleBackColor = true;
            // 
            // customerEditor1
            // 
            this.customerEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerEditor1.Location = new System.Drawing.Point(0, 0);
            this.customerEditor1.Name = "customerEditor1";
            this.customerEditor1.Size = new System.Drawing.Size(839, 669);
            this.customerEditor1.TabIndex = 0;
            this.customerEditor1.MarketLoaded += new SDB.UserControls.Customer.CustomerEditor.MarketEvent(this.MarketLoaded);
            this.customerEditor1.MarketUpdated += new SDB.UserControls.Customer.CustomerEditor.UpdateEvent(this.customerEditor1_MarketUpdated);
            this.customerEditor1.ViewAsset += new SDB.UserControls.Customer.CustomerEditor.AssetEvent(this.Asset_Load);
            this.customerEditor1.ViewTicket += new SDB.UserControls.Customer.CustomerEditor.TicketEvent(this.Ticket_Load);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdministration,
            this.mnuReports,
            this.mnuView,
            this.mnuRma,
            this.mnuShipments,
            this.mnuGoto,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1071, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "_";
            // 
            // mnuAdministration
            // 
            this.mnuAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_Settings,
            this.mnuAdmin_UserDetails,
            this.mnuAdmin_Configure,
            this.mnuAdmin_ActivityPanel,
            this.toolStripSeparator2,
            this.mnuAdmin_LogOff,
            this.toolStripSeparator3,
            this.mnuAdmin_Exit});
            this.mnuAdministration.Name = "mnuAdministration";
            this.mnuAdministration.Size = new System.Drawing.Size(98, 20);
            this.mnuAdministration.Text = "&Administration";
            // 
            // mnuAdmin_Settings
            // 
            this.mnuAdmin_Settings.Name = "mnuAdmin_Settings";
            this.mnuAdmin_Settings.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_Settings.Text = "&Settings...";
            this.mnuAdmin_Settings.Click += new System.EventHandler(this.mnuAdmin_Settings_Click);
            // 
            // mnuAdmin_UserDetails
            // 
            this.mnuAdmin_UserDetails.Enabled = false;
            this.mnuAdmin_UserDetails.Name = "mnuAdmin_UserDetails";
            this.mnuAdmin_UserDetails.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_UserDetails.Text = "&User Details...";
            this.mnuAdmin_UserDetails.Click += new System.EventHandler(this.mnuAdmin_UserDetails_Click);
            // 
            // mnuAdmin_Configure
            // 
            this.mnuAdmin_Configure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_Config_AdminEmails,
            this.mnuAdmin_Config_AssetOptions,
            this.mnuAdmin_Config_Assemblies,
            this.mnuAdmin_Config_CameraTypes,
            this.mnuAdmin_AssetTag_Config,
            this.mnuAdmin_Config_Markets,
            this.mnuAdmin_Config_RentalCompanies,
            this.mnuAdmin_Config_Salespeople,
            this.mnuAdmin_Config_ShipmentMethods,
            this.mnuAdmin_Config_SymptomsSolutions,
            this.mnuAdmin_Config_TOSChecklist,
            this.mnuAdmin_Config_Users,
            this.toolStripSeparator4,
            this.mnuAdmin_Config_RMAFailureRepair,
            this.mnuAdmin_Config_RMAComponents,
            this.mnuAdmin_Config_RMAZones});
            this.mnuAdmin_Configure.Enabled = false;
            this.mnuAdmin_Configure.Name = "mnuAdmin_Configure";
            this.mnuAdmin_Configure.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_Configure.Text = "&Configure...";
            // 
            // mnuAdmin_Config_AdminEmails
            // 
            this.mnuAdmin_Config_AdminEmails.Name = "mnuAdmin_Config_AdminEmails";
            this.mnuAdmin_Config_AdminEmails.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_AdminEmails.Text = "Administrative &Email Addresses...";
            this.mnuAdmin_Config_AdminEmails.Click += new System.EventHandler(this.mnuAdmin_Config_AdminEmails_Click);
            // 
            // mnuAdmin_Config_AssetOptions
            // 
            this.mnuAdmin_Config_AssetOptions.Name = "mnuAdmin_Config_AssetOptions";
            this.mnuAdmin_Config_AssetOptions.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_AssetOptions.Text = "Asset Opt&ions...";
            this.mnuAdmin_Config_AssetOptions.Click += new System.EventHandler(this.mnuAdmin_Config_AssetOptions_Click);
            // 
            // mnuAdmin_Config_Assemblies
            // 
            this.mnuAdmin_Config_Assemblies.Name = "mnuAdmin_Config_Assemblies";
            this.mnuAdmin_Config_Assemblies.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_Assemblies.Text = "&Assemblies and Types...";
            this.mnuAdmin_Config_Assemblies.Click += new System.EventHandler(this.mnuAdmin_Config_Assemblies_Click);
            // 
            // mnuAdmin_Config_CameraTypes
            // 
            this.mnuAdmin_Config_CameraTypes.Name = "mnuAdmin_Config_CameraTypes";
            this.mnuAdmin_Config_CameraTypes.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_CameraTypes.Text = "Ca&mera Types...";
            this.mnuAdmin_Config_CameraTypes.Click += new System.EventHandler(this.mnuAdmin_Config_CameraTypes_Click);
            // 
            // mnuAdmin_AssetTag_Config
            // 
            this.mnuAdmin_AssetTag_Config.Name = "mnuAdmin_AssetTag_Config";
            this.mnuAdmin_AssetTag_Config.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_AssetTag_Config.Text = "Customer Category";
            this.mnuAdmin_AssetTag_Config.Click += new System.EventHandler(this.mnuAdmin_Config_CustomerAssetTags_Click);
            // 
            // mnuAdmin_Config_Markets
            // 
            this.mnuAdmin_Config_Markets.Name = "mnuAdmin_Config_Markets";
            this.mnuAdmin_Config_Markets.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_Markets.Text = "&Customers and Markets...";
            this.mnuAdmin_Config_Markets.Click += new System.EventHandler(this.mnuAdmin_Config_Markets_Click);
            // 
            // mnuAdmin_Config_RentalCompanies
            // 
            this.mnuAdmin_Config_RentalCompanies.Name = "mnuAdmin_Config_RentalCompanies";
            this.mnuAdmin_Config_RentalCompanies.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_RentalCompanies.Text = "&Rental Companies...";
            this.mnuAdmin_Config_RentalCompanies.Click += new System.EventHandler(this.mnuAdmin_Config_RentalCompanies_Click);
            // 
            // mnuAdmin_Config_Salespeople
            // 
            this.mnuAdmin_Config_Salespeople.Name = "mnuAdmin_Config_Salespeople";
            this.mnuAdmin_Config_Salespeople.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_Salespeople.Text = "Sales&people...";
            this.mnuAdmin_Config_Salespeople.Click += new System.EventHandler(this.mnuAdmin_Config_Salespeople_Click);
            // 
            // mnuAdmin_Config_ShipmentMethods
            // 
            this.mnuAdmin_Config_ShipmentMethods.Name = "mnuAdmin_Config_ShipmentMethods";
            this.mnuAdmin_Config_ShipmentMethods.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_ShipmentMethods.Text = "S&hipment Methods...";
            this.mnuAdmin_Config_ShipmentMethods.Click += new System.EventHandler(this.mnuAdmin_Config_ShipmentMethods_Click);
            // 
            // mnuAdmin_Config_SymptomsSolutions
            // 
            this.mnuAdmin_Config_SymptomsSolutions.Name = "mnuAdmin_Config_SymptomsSolutions";
            this.mnuAdmin_Config_SymptomsSolutions.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_SymptomsSolutions.Text = "&Symptoms and Solutions...";
            this.mnuAdmin_Config_SymptomsSolutions.Click += new System.EventHandler(this.mnuAdmin_Config_SymptomsSolutions_Click);
            // 
            // mnuAdmin_Config_TOSChecklist
            // 
            this.mnuAdmin_Config_TOSChecklist.Name = "mnuAdmin_Config_TOSChecklist";
            this.mnuAdmin_Config_TOSChecklist.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_TOSChecklist.Text = "&TechOnSite Checklist...";
            this.mnuAdmin_Config_TOSChecklist.Click += new System.EventHandler(this.mnuAdmin_Config_TechOnSiteChecklist_Click);
            // 
            // mnuAdmin_Config_Users
            // 
            this.mnuAdmin_Config_Users.Name = "mnuAdmin_Config_Users";
            this.mnuAdmin_Config_Users.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_Users.Text = "&Users...";
            this.mnuAdmin_Config_Users.Click += new System.EventHandler(this.mnuAdmin_Config_Users_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(245, 6);
            // 
            // mnuAdmin_Config_RMAFailureRepair
            // 
            this.mnuAdmin_Config_RMAFailureRepair.Name = "mnuAdmin_Config_RMAFailureRepair";
            this.mnuAdmin_Config_RMAFailureRepair.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_RMAFailureRepair.Text = "RMA &Failure and Repair Types...";
            this.mnuAdmin_Config_RMAFailureRepair.Click += new System.EventHandler(this.mnuAdmin_Config_RMAFailureRepair_Click);
            // 
            // mnuAdmin_Config_RMAComponents
            // 
            this.mnuAdmin_Config_RMAComponents.Name = "mnuAdmin_Config_RMAComponents";
            this.mnuAdmin_Config_RMAComponents.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_RMAComponents.Text = "RMA C&omponents...";
            this.mnuAdmin_Config_RMAComponents.Click += new System.EventHandler(this.mnuAdmin_Config_RMAComponents_Click);
            // 
            // mnuAdmin_Config_RMAZones
            // 
            this.mnuAdmin_Config_RMAZones.Name = "mnuAdmin_Config_RMAZones";
            this.mnuAdmin_Config_RMAZones.Size = new System.Drawing.Size(248, 22);
            this.mnuAdmin_Config_RMAZones.Text = "RMA &Zones...";
            this.mnuAdmin_Config_RMAZones.Click += new System.EventHandler(this.mnuAdmin_Config_RMAZones_Click);
            // 
            // mnuAdmin_ActivityPanel
            // 
            this.mnuAdmin_ActivityPanel.Enabled = false;
            this.mnuAdmin_ActivityPanel.Name = "mnuAdmin_ActivityPanel";
            this.mnuAdmin_ActivityPanel.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_ActivityPanel.Text = "&Activity Panel...";
            this.mnuAdmin_ActivityPanel.Click += new System.EventHandler(this.mnuAdmin_ActivityPanel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAdmin_LogOff
            // 
            this.mnuAdmin_LogOff.Enabled = false;
            this.mnuAdmin_LogOff.Name = "mnuAdmin_LogOff";
            this.mnuAdmin_LogOff.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_LogOff.Text = "&Log Off";
            this.mnuAdmin_LogOff.Click += new System.EventHandler(this.mnuAdmin_LogOff_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuAdmin_Exit
            // 
            this.mnuAdmin_Exit.Name = "mnuAdmin_Exit";
            this.mnuAdmin_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuAdmin_Exit.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_Exit.Text = "E&xit";
            this.mnuAdmin_Exit.Click += new System.EventHandler(this.mnuAdmin_Exit_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "R&eports";
            this.mnuReports.Visible = false;
            this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_CameraCheck,
            this.mnuView_CameraCheckReview,
            this.mnuView_CameraCheckAudit,
            this.toolStripSeparator10,
            this.mnuView_Notifications,
            this.toolStripSeparator7,
            this.mnuView_Lists,
            this.toolStripSeparator5,
            this.magicInfoToolStripMenuItem,
            this.toolStripSeparator8,
            this.mnuView_Refresh});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            this.mnuView.Visible = false;
            // 
            // mnuView_CameraCheck
            // 
            this.mnuView_CameraCheck.Name = "mnuView_CameraCheck";
            this.mnuView_CameraCheck.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuView_CameraCheck.Size = new System.Drawing.Size(234, 22);
            this.mnuView_CameraCheck.Text = "&Camera Check...";
            this.mnuView_CameraCheck.Click += new System.EventHandler(this.mnuView_CameraCheck_Click);
            // 
            // mnuView_CameraCheckReview
            // 
            this.mnuView_CameraCheckReview.Name = "mnuView_CameraCheckReview";
            this.mnuView_CameraCheckReview.Size = new System.Drawing.Size(234, 22);
            this.mnuView_CameraCheckReview.Text = "Camera Check R&eview...";
            this.mnuView_CameraCheckReview.Click += new System.EventHandler(this.mnuView_CameraCheckReview_Click);
            // 
            // mnuView_CameraCheckAudit
            // 
            this.mnuView_CameraCheckAudit.Name = "mnuView_CameraCheckAudit";
            this.mnuView_CameraCheckAudit.Size = new System.Drawing.Size(234, 22);
            this.mnuView_CameraCheckAudit.Text = "Camera Check &Audit...";
            this.mnuView_CameraCheckAudit.Click += new System.EventHandler(this.mnuView_CameraCheckAudit_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuView_Notifications
            // 
            this.mnuView_Notifications.Name = "mnuView_Notifications";
            this.mnuView_Notifications.Size = new System.Drawing.Size(234, 22);
            this.mnuView_Notifications.Text = "&Notifications...";
            this.mnuView_Notifications.Click += new System.EventHandler(this.mnuView_Notifications_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuView_Lists
            // 
            this.mnuView_Lists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_List_Asset,
            this.mnuView_List_Market,
            this.mnuView_List_Rental,
            this.mnuView_List_Tech,
            this.mnuView_List_Ticket});
            this.mnuView_Lists.Name = "mnuView_Lists";
            this.mnuView_Lists.Size = new System.Drawing.Size(234, 22);
            this.mnuView_Lists.Text = "&Lists";
            // 
            // mnuView_List_Asset
            // 
            this.mnuView_List_Asset.Name = "mnuView_List_Asset";
            this.mnuView_List_Asset.Size = new System.Drawing.Size(192, 22);
            this.mnuView_List_Asset.Text = "&Asset List...";
            this.mnuView_List_Asset.Click += new System.EventHandler(this.mnuView_List_Asset_Click);
            // 
            // mnuView_List_Market
            // 
            this.mnuView_List_Market.Name = "mnuView_List_Market";
            this.mnuView_List_Market.Size = new System.Drawing.Size(192, 22);
            this.mnuView_List_Market.Text = "&Market List...";
            this.mnuView_List_Market.Click += new System.EventHandler(this.mnuView_List_Market_Click);
            // 
            // mnuView_List_Rental
            // 
            this.mnuView_List_Rental.Name = "mnuView_List_Rental";
            this.mnuView_List_Rental.Size = new System.Drawing.Size(192, 22);
            this.mnuView_List_Rental.Text = "&Rental Company List...";
            this.mnuView_List_Rental.Click += new System.EventHandler(this.mnuView_List_Rental_Click);
            // 
            // mnuView_List_Tech
            // 
            this.mnuView_List_Tech.Name = "mnuView_List_Tech";
            this.mnuView_List_Tech.Size = new System.Drawing.Size(192, 22);
            this.mnuView_List_Tech.Text = "Tec&h List...";
            this.mnuView_List_Tech.Click += new System.EventHandler(this.mnuView_List_Tech_Click);
            // 
            // mnuView_List_Ticket
            // 
            this.mnuView_List_Ticket.Name = "mnuView_List_Ticket";
            this.mnuView_List_Ticket.Size = new System.Drawing.Size(192, 22);
            this.mnuView_List_Ticket.Text = "&Ticket List...";
            this.mnuView_List_Ticket.Click += new System.EventHandler(this.mnuView_List_Ticket_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(231, 6);
            // 
            // magicInfoToolStripMenuItem
            // 
            this.magicInfoToolStripMenuItem.Image = global::SDB.Properties.Resources.magicinfo_logo2;
            this.magicInfoToolStripMenuItem.Name = "magicInfoToolStripMenuItem";
            this.magicInfoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.magicInfoToolStripMenuItem.Text = "Samsung SDB";
            this.magicInfoToolStripMenuItem.Click += new System.EventHandler(this.magicInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuView_Refresh
            // 
            this.mnuView_Refresh.Name = "mnuView_Refresh";
            this.mnuView_Refresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuView_Refresh.Size = new System.Drawing.Size(234, 22);
            this.mnuView_Refresh.Text = "&Refresh";
            this.mnuView_Refresh.Click += new System.EventHandler(this.mnuView_Refresh_Click);
            // 
            // mnuRma
            // 
            this.mnuRma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRma_List,
            this.mnuRma_Migration,
            this.mnuRma_Inventory,
            this.toolStripSeparator1,
            this.mnuRma_Legacy});
            this.mnuRma.Name = "mnuRma";
            this.mnuRma.Size = new System.Drawing.Size(45, 20);
            this.mnuRma.Text = "&RMA";
            this.mnuRma.Visible = false;
            // 
            // mnuRma_List
            // 
            this.mnuRma_List.Name = "mnuRma_List";
            this.mnuRma_List.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.mnuRma_List.Size = new System.Drawing.Size(180, 22);
            this.mnuRma_List.Text = "&RMA";
            this.mnuRma_List.Click += new System.EventHandler(this.mnuRma_List_Click);
            // 
            // mnuRma_Migration
            // 
            this.mnuRma_Migration.Name = "mnuRma_Migration";
            this.mnuRma_Migration.Size = new System.Drawing.Size(180, 22);
            this.mnuRma_Migration.Text = "&Migration...";
            this.mnuRma_Migration.Visible = false;
            this.mnuRma_Migration.Click += new System.EventHandler(this.mnuRma_Migration_Click);
            // 
            // mnuRma_Inventory
            // 
            this.mnuRma_Inventory.Name = "mnuRma_Inventory";
            this.mnuRma_Inventory.Size = new System.Drawing.Size(180, 22);
            this.mnuRma_Inventory.Text = "&Inventory...";
            this.mnuRma_Inventory.Click += new System.EventHandler(this.mnuRma_Inventory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuRma_Legacy
            // 
            this.mnuRma_Legacy.Name = "mnuRma_Legacy";
            this.mnuRma_Legacy.Size = new System.Drawing.Size(180, 22);
            this.mnuRma_Legacy.Text = "L&egacy...";
            this.mnuRma_Legacy.Click += new System.EventHandler(this.mnuRma_Legacy_Click);
            // 
            // mnuShipments
            // 
            this.mnuShipments.Name = "mnuShipments";
            this.mnuShipments.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuShipments.Size = new System.Drawing.Size(75, 20);
            this.mnuShipments.Text = "&Shipments";
            this.mnuShipments.Visible = false;
            this.mnuShipments.Click += new System.EventHandler(this.mnuShipments_Click);
            // 
            // mnuGoto
            // 
            this.mnuGoto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGoto_RecentAssets,
            this.mnuGoto_RecentTickets,
            this.mnuGoto_RecentTechs});
            this.mnuGoto.Name = "mnuGoto";
            this.mnuGoto.Size = new System.Drawing.Size(50, 20);
            this.mnuGoto.Text = "&Go To";
            this.mnuGoto.Visible = false;
            // 
            // mnuGoto_RecentAssets
            // 
            this.mnuGoto_RecentAssets.Name = "mnuGoto_RecentAssets";
            this.mnuGoto_RecentAssets.Size = new System.Drawing.Size(150, 22);
            this.mnuGoto_RecentAssets.Text = "Recent &Assets";
            // 
            // mnuGoto_RecentTickets
            // 
            this.mnuGoto_RecentTickets.Name = "mnuGoto_RecentTickets";
            this.mnuGoto_RecentTickets.Size = new System.Drawing.Size(150, 22);
            this.mnuGoto_RecentTickets.Text = "Recent &Tickets";
            // 
            // mnuGoto_RecentTechs
            // 
            this.mnuGoto_RecentTechs.Name = "mnuGoto_RecentTechs";
            this.mnuGoto_RecentTechs.Size = new System.Drawing.Size(150, 22);
            this.mnuGoto_RecentTechs.Text = "Recent Tec&hs";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_ChangeLog,
            this.mnuHelp_CheckUpdates,
            this.toolStripSeparator6,
            this.troubleshootingToolStripMenuItem,
            this.toolStripSeparator9,
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp_ChangeLog
            // 
            this.mnuHelp_ChangeLog.Name = "mnuHelp_ChangeLog";
            this.mnuHelp_ChangeLog.Size = new System.Drawing.Size(255, 22);
            this.mnuHelp_ChangeLog.Text = "&Change Log";
            this.mnuHelp_ChangeLog.Click += new System.EventHandler(this.mnuHelp_ChangeLog_Click);
            // 
            // mnuHelp_CheckUpdates
            // 
            this.mnuHelp_CheckUpdates.Name = "mnuHelp_CheckUpdates";
            this.mnuHelp_CheckUpdates.Size = new System.Drawing.Size(255, 22);
            this.mnuHelp_CheckUpdates.Text = "Check for &Updates...";
            this.mnuHelp_CheckUpdates.Click += new System.EventHandler(this.mnuHelp_CheckUpdates_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(252, 6);
            // 
            // troubleshootingToolStripMenuItem
            // 
            this.troubleshootingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_Troubleshooting_ViewLogFile,
            this.mnuHelp_Troubleshooting_ReportProblem});
            this.troubleshootingToolStripMenuItem.Name = "troubleshootingToolStripMenuItem";
            this.troubleshootingToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.troubleshootingToolStripMenuItem.Text = "&Troubleshooting";
            // 
            // mnuHelp_Troubleshooting_ViewLogFile
            // 
            this.mnuHelp_Troubleshooting_ViewLogFile.Name = "mnuHelp_Troubleshooting_ViewLogFile";
            this.mnuHelp_Troubleshooting_ViewLogFile.Size = new System.Drawing.Size(166, 22);
            this.mnuHelp_Troubleshooting_ViewLogFile.Text = "View &Log File";
            this.mnuHelp_Troubleshooting_ViewLogFile.Click += new System.EventHandler(this.mnuHelp_Troubleshooting_ViewLogFile_Click);
            // 
            // mnuHelp_Troubleshooting_ReportProblem
            // 
            this.mnuHelp_Troubleshooting_ReportProblem.Name = "mnuHelp_Troubleshooting_ReportProblem";
            this.mnuHelp_Troubleshooting_ReportProblem.Size = new System.Drawing.Size(166, 22);
            this.mnuHelp_Troubleshooting_ReportProblem.Text = "&Report Problem...";
            this.mnuHelp_Troubleshooting_ReportProblem.Click += new System.EventHandler(this.mnuHelp_Troubleshooting_ReportProblem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(252, 6);
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(255, 22);
            this.mnuHelp_About.Text = "&About Prismview Service Database";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // tmrRefresh_GeneralNotes
            // 
            this.tmrRefresh_GeneralNotes.Interval = 300000;
            this.tmrRefresh_GeneralNotes.Tick += new System.EventHandler(this.tmrRefresh_GeneralNotes_Tick);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 100;
            // 
            // btnCameraCheck_Due
            // 
            this.btnCameraCheck_Due.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraCheck_Due.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraCheck_Due.Location = new System.Drawing.Point(768, 1);
            this.btnCameraCheck_Due.Name = "btnCameraCheck_Due";
            this.btnCameraCheck_Due.Size = new System.Drawing.Size(85, 23);
            this.btnCameraCheck_Due.TabIndex = 11;
            this.btnCameraCheck_Due.Text = "CC Due (0)";
            this.toolTip.SetToolTip(this.btnCameraCheck_Due, "Camera checks are due.");
            this.btnCameraCheck_Due.UseVisualStyleBackColor = false;
            this.btnCameraCheck_Due.Visible = false;
            this.btnCameraCheck_Due.Click += new System.EventHandler(this.btnCameraCheck_Due_Click);
            // 
            // btnCameraCheck_Fails
            // 
            this.btnCameraCheck_Fails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCameraCheck_Fails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCameraCheck_Fails.Location = new System.Drawing.Point(859, 1);
            this.btnCameraCheck_Fails.Name = "btnCameraCheck_Fails";
            this.btnCameraCheck_Fails.Size = new System.Drawing.Size(85, 23);
            this.btnCameraCheck_Fails.TabIndex = 12;
            this.btnCameraCheck_Fails.Text = "CC Fails (0)";
            this.toolTip.SetToolTip(this.btnCameraCheck_Fails, "Failed camera checks require ticket assignment.");
            this.btnCameraCheck_Fails.UseVisualStyleBackColor = false;
            this.btnCameraCheck_Fails.Visible = false;
            this.btnCameraCheck_Fails.Click += new System.EventHandler(this.btnCameraCheck_Fails_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDB.Properties.Resources.stop_24x24;
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Controls.Add(this.pnlMain_RightBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1071, 695);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Visible = false;
            // 
            // pnlMain_RightBar
            // 
            this.pnlMain_RightBar.Controls.Add(this.pnlRightBar_GeneralNotes);
            this.pnlMain_RightBar.Controls.Add(this.pnlRightBar_Search);
            this.pnlMain_RightBar.Controls.Add(this.pnlRightBar_CreateTicket);
            this.pnlMain_RightBar.Controls.Add(this.lblRightBar_CurrentDate);
            this.pnlMain_RightBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain_RightBar.Enabled = false;
            this.pnlMain_RightBar.Location = new System.Drawing.Point(847, 0);
            this.pnlMain_RightBar.Name = "pnlMain_RightBar";
            this.pnlMain_RightBar.Size = new System.Drawing.Size(224, 695);
            this.pnlMain_RightBar.TabIndex = 5;
            // 
            // pnlRightBar_GeneralNotes
            // 
            this.pnlRightBar_GeneralNotes.BackColor = System.Drawing.Color.LightGray;
            this.pnlRightBar_GeneralNotes.Controls.Add(this.ucGeneralNotes1);
            this.pnlRightBar_GeneralNotes.Controls.Add(this.lblRightBar_GeneralNotes);
            this.pnlRightBar_GeneralNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightBar_GeneralNotes.Location = new System.Drawing.Point(0, 309);
            this.pnlRightBar_GeneralNotes.Name = "pnlRightBar_GeneralNotes";
            this.pnlRightBar_GeneralNotes.Size = new System.Drawing.Size(224, 386);
            this.pnlRightBar_GeneralNotes.TabIndex = 22;
            // 
            // ucGeneralNotes1
            // 
            this.ucGeneralNotes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGeneralNotes1.Location = new System.Drawing.Point(0, 17);
            this.ucGeneralNotes1.Name = "ucGeneralNotes1";
            this.ucGeneralNotes1.Size = new System.Drawing.Size(224, 369);
            this.ucGeneralNotes1.TabIndex = 0;
            // 
            // lblRightBar_GeneralNotes
            // 
            this.lblRightBar_GeneralNotes.AutoEllipsis = true;
            this.lblRightBar_GeneralNotes.BackColor = System.Drawing.Color.DimGray;
            this.lblRightBar_GeneralNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightBar_GeneralNotes.ForeColor = System.Drawing.Color.White;
            this.lblRightBar_GeneralNotes.Location = new System.Drawing.Point(0, 0);
            this.lblRightBar_GeneralNotes.Name = "lblRightBar_GeneralNotes";
            this.lblRightBar_GeneralNotes.Size = new System.Drawing.Size(224, 17);
            this.lblRightBar_GeneralNotes.TabIndex = 0;
            this.lblRightBar_GeneralNotes.Text = "General Notes";
            this.lblRightBar_GeneralNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRightBar_Search
            // 
            this.pnlRightBar_Search.BackColor = System.Drawing.Color.LightGray;
            this.pnlRightBar_Search.Controls.Add(this.lblSearch_DateRangeTo);
            this.pnlRightBar_Search.Controls.Add(this.lblRightBar_Search);
            this.pnlRightBar_Search.Controls.Add(this.btnSearch_SearchAll);
            this.pnlRightBar_Search.Controls.Add(this.dtpSearch_DateFrom);
            this.pnlRightBar_Search.Controls.Add(this.txtSearch_SearchAll);
            this.pnlRightBar_Search.Controls.Add(this.lblSearch_Ticket);
            this.pnlRightBar_Search.Controls.Add(this.btnSearch);
            this.pnlRightBar_Search.Controls.Add(this.lblSearch_Asset);
            this.pnlRightBar_Search.Controls.Add(this.txtSearch_Tech);
            this.pnlRightBar_Search.Controls.Add(this.lblSearch_Tech);
            this.pnlRightBar_Search.Controls.Add(this.btnSearch_DateRange);
            this.pnlRightBar_Search.Controls.Add(this.txtSearch_Ticket);
            this.pnlRightBar_Search.Controls.Add(this.txtSearch_Asset);
            this.pnlRightBar_Search.Controls.Add(this.dtpSearch_DateTo);
            this.pnlRightBar_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightBar_Search.Location = new System.Drawing.Point(0, 82);
            this.pnlRightBar_Search.Name = "pnlRightBar_Search";
            this.pnlRightBar_Search.Size = new System.Drawing.Size(224, 227);
            this.pnlRightBar_Search.TabIndex = 21;
            // 
            // lblRightBar_Search
            // 
            this.lblRightBar_Search.AutoEllipsis = true;
            this.lblRightBar_Search.BackColor = System.Drawing.Color.DimGray;
            this.lblRightBar_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightBar_Search.ForeColor = System.Drawing.Color.White;
            this.lblRightBar_Search.Location = new System.Drawing.Point(0, 0);
            this.lblRightBar_Search.Name = "lblRightBar_Search";
            this.lblRightBar_Search.Size = new System.Drawing.Size(224, 17);
            this.lblRightBar_Search.TabIndex = 0;
            this.lblRightBar_Search.Text = "Search";
            this.lblRightBar_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlRightBar_CreateTicket
            // 
            this.pnlRightBar_CreateTicket.BackColor = System.Drawing.Color.LightGray;
            this.pnlRightBar_CreateTicket.Controls.Add(this.btnCreateTicket);
            this.pnlRightBar_CreateTicket.Controls.Add(this.lblRightBar_CreateTicket);
            this.pnlRightBar_CreateTicket.Controls.Add(this.txtCreateTicket_Asset);
            this.pnlRightBar_CreateTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightBar_CreateTicket.Location = new System.Drawing.Point(0, 30);
            this.pnlRightBar_CreateTicket.Name = "pnlRightBar_CreateTicket";
            this.pnlRightBar_CreateTicket.Size = new System.Drawing.Size(224, 52);
            this.pnlRightBar_CreateTicket.TabIndex = 20;
            this.pnlRightBar_CreateTicket.Visible = false;
            // 
            // lblRightBar_CreateTicket
            // 
            this.lblRightBar_CreateTicket.AutoEllipsis = true;
            this.lblRightBar_CreateTicket.BackColor = System.Drawing.Color.DimGray;
            this.lblRightBar_CreateTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightBar_CreateTicket.ForeColor = System.Drawing.Color.White;
            this.lblRightBar_CreateTicket.Location = new System.Drawing.Point(0, 0);
            this.lblRightBar_CreateTicket.Name = "lblRightBar_CreateTicket";
            this.lblRightBar_CreateTicket.Size = new System.Drawing.Size(224, 17);
            this.lblRightBar_CreateTicket.TabIndex = 0;
            this.lblRightBar_CreateTicket.Text = "Create Ticket";
            this.lblRightBar_CreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus_Connection,
            this.lblStatus_User,
            this.lblPad,
            this.lblStatus_Email});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1071, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus_Connection
            // 
            this.lblStatus_Connection.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblStatus_Connection.Name = "lblStatus_Connection";
            this.lblStatus_Connection.Size = new System.Drawing.Size(47, 19);
            this.lblStatus_Connection.Text = "Offline";
            // 
            // lblStatus_User
            // 
            this.lblStatus_User.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblStatus_User.Name = "lblStatus_User";
            this.lblStatus_User.Size = new System.Drawing.Size(34, 19);
            this.lblStatus_User.Text = "User";
            this.lblStatus_User.Visible = false;
            // 
            // lblPad
            // 
            this.lblPad.Name = "lblPad";
            this.lblPad.Size = new System.Drawing.Size(948, 19);
            this.lblPad.Spring = true;
            // 
            // lblStatus_Email
            // 
            this.lblStatus_Email.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus_Email.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblStatus_Email.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus_Email.Name = "lblStatus_Email";
            this.lblStatus_Email.Size = new System.Drawing.Size(61, 19);
            this.lblStatus_Email.Text = "Email: Idle";
            this.lblStatus_Email.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus_Email.Click += new System.EventHandler(this.lblStatus_Email_Click);
            // 
            // tmrIdleCheck
            // 
            this.tmrIdleCheck.Interval = 60000;
            this.tmrIdleCheck.Tick += new System.EventHandler(this.tmrIdleCheck_Tick);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Location = new System.Drawing.Point(950, 1);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(120, 23);
            this.btnNotifications.TabIndex = 9;
            this.btnNotifications.Text = "Notifications (0)";
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Visible = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lnkLogin_ForgotPassword);
            this.pnlLogin.Controls.Add(this.txtLogin_Password);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblLogin_UserID);
            this.pnlLogin.Controls.Add(this.txtLogin_UserID);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblLogin_Password);
            this.pnlLogin.Location = new System.Drawing.Point(355, 251);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(360, 240);
            this.pnlLogin.TabIndex = 10;
            // 
            // lnkLogin_ForgotPassword
            // 
            this.lnkLogin_ForgotPassword.AutoSize = true;
            this.lnkLogin_ForgotPassword.LinkColor = System.Drawing.Color.DimGray;
            this.lnkLogin_ForgotPassword.Location = new System.Drawing.Point(58, 190);
            this.lnkLogin_ForgotPassword.Name = "lnkLogin_ForgotPassword";
            this.lnkLogin_ForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.lnkLogin_ForgotPassword.TabIndex = 6;
            this.lnkLogin_ForgotPassword.TabStop = true;
            this.lnkLogin_ForgotPassword.Text = "Forgot Password";
            this.lnkLogin_ForgotPassword.Visible = false;
            this.lnkLogin_ForgotPassword.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.lnkLogin_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_ForgotPassword_LinkClicked);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoEllipsis = true;
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(358, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrFlasher_Notifications
            // 
            this.tmrFlasher_Notifications.Enabled = true;
            this.tmrFlasher_Notifications.Interval = 3000;
            this.tmrFlasher_Notifications.Tick += new System.EventHandler(this.tmrFlasher_Notifications_Tick);
            // 
            // tmrRefresh_Notifications
            // 
            this.tmrRefresh_Notifications.Interval = 60000;
            this.tmrRefresh_Notifications.Tick += new System.EventHandler(this.tmrRefresh_Notifications_Tick);
            // 
            // tmrRefresh_Tracker
            // 
            this.tmrRefresh_Tracker.Interval = 60000;
            this.tmrRefresh_Tracker.Tick += new System.EventHandler(this.tmrRefresh_Tracker_Tick);
            // 
            // tmrRefresh_CameraChecks
            // 
            this.tmrRefresh_CameraChecks.Interval = 120000;
            this.tmrRefresh_CameraChecks.Tick += new System.EventHandler(this.tmrRefresh_CameraChecks_Tick);
            // 
            // tmrFlasher_CameraCheckDue
            // 
            this.tmrFlasher_CameraCheckDue.Enabled = true;
            this.tmrFlasher_CameraCheckDue.Interval = 3000;
            this.tmrFlasher_CameraCheckDue.Tick += new System.EventHandler(this.tmrFlasher_CameraCheckDue_Tick);
            // 
            // tmrFlasher_CameraCheckReview
            // 
            this.tmrFlasher_CameraCheckReview.Enabled = true;
            this.tmrFlasher_CameraCheckReview.Interval = 3000;
            this.tmrFlasher_CameraCheckReview.Tick += new System.EventHandler(this.tmrFlasher_CameraCheckReview_Tick);
            // 
            // tmrCheckLogout
            // 
            this.tmrCheckLogout.Enabled = true;
            this.tmrCheckLogout.Interval = 300000;
            this.tmrCheckLogout.Tick += new System.EventHandler(this.tmrCheckLogout_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 743);
            this.Controls.Add(this.btnCameraCheck_Fails);
            this.Controls.Add(this.btnCameraCheck_Due);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(1087, 781);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Prismview Service Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabTracker.ResumeLayout(false);
            this.tabTicket.ResumeLayout(false);
            this.tabAsset.ResumeLayout(false);
            this.tabTech.ResumeLayout(false);
            this.tabMarket.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain_RightBar.ResumeLayout(false);
            this.pnlRightBar_GeneralNotes.ResumeLayout(false);
            this.pnlRightBar_Search.ResumeLayout(false);
            this.pnlRightBar_Search.PerformLayout();
            this.pnlRightBar_CreateTicket.ResumeLayout(false);
            this.pnlRightBar_CreateTicket.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

		private System.Windows.Forms.Label lblRightBar_CurrentDate;
		private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.TextBox txtCreateTicket_Asset;
		private System.Windows.Forms.Button btnCreateTicket;
		private System.Windows.Forms.Label lblSearch_Asset;
		private System.Windows.Forms.Label lblSearch_Ticket;
		private System.Windows.Forms.TextBox txtSearch_Asset;
		private System.Windows.Forms.TextBox txtSearch_Ticket;
		private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Label lblLogin_UserID;
        private System.Windows.Forms.TextBox txtLogin_UserID;
        private System.Windows.Forms.Label lblLogin_Password;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox txtLogin_Password;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministration;
		private System.Windows.Forms.ToolStripMenuItem mnuReports;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.Timer tmrRefresh_GeneralNotes;
		private System.Windows.Forms.DateTimePicker dtpSearch_DateTo;
        private System.Windows.Forms.DateTimePicker dtpSearch_DateFrom;
		private System.Windows.Forms.Button btnSearch_DateRange;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Settings;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_UserDetails;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch_Tech;
		private System.Windows.Forms.Label lblSearch_Tech;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Exit;
		private System.Windows.Forms.Button btnSearch_SearchAll;
		private System.Windows.Forms.TextBox txtSearch_SearchAll;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblSearch_DateRangeTo;
		private System.Windows.Forms.TabPage tabTech;
		private TechEditor ucTechEditor1;
		private System.Windows.Forms.TabPage tabAsset;
		private AssetEditor ucAssetEditor1;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus_Connection;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus_User;
		private ucGeneralNotes ucGeneralNotes1;
		private System.Windows.Forms.ToolStripStatusLabel lblPad;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus_Email;
		private System.Windows.Forms.TabPage tabTicket;
		private TicketEditor ucTicketEditor1;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_LogOff;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Configure;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_Markets;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_Assemblies;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_RentalCompanies;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_ShipmentMethods;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_SymptomsSolutions;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_RMAFailureRepair;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_RMAComponents;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_ActivityPanel;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp_ChangeLog;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp_CheckUpdates;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_CameraTypes;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_Salespeople;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_TOSChecklist;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_AdminEmails;
		private System.Windows.Forms.Timer tmrIdleCheck;
		private System.Windows.Forms.ToolStripMenuItem mnuView_Notifications;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.Button btnNotifications;
		private System.Windows.Forms.TabPage tabTracker;
		private System.Windows.Forms.Panel pnlMain_RightBar;
		private System.Windows.Forms.Panel pnlRightBar_GeneralNotes;
		private System.Windows.Forms.Label lblRightBar_GeneralNotes;
		private System.Windows.Forms.Panel pnlRightBar_Search;
		private System.Windows.Forms.Label lblRightBar_Search;
		private System.Windows.Forms.Panel pnlRightBar_CreateTicket;
		private System.Windows.Forms.Label lblRightBar_CreateTicket;
		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.Label lblLogin;
		private TicketTracker ticketTracker;
		private System.Windows.Forms.Timer tmrFlasher_Notifications;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_AssetOptions;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_Users;
		private System.Windows.Forms.ToolStripMenuItem mnuView_Lists;
		private System.Windows.Forms.ToolStripMenuItem mnuView_List_Asset;
		private System.Windows.Forms.ToolStripMenuItem mnuView_List_Market;
		private System.Windows.Forms.ToolStripMenuItem mnuView_List_Rental;
		private System.Windows.Forms.ToolStripMenuItem mnuView_List_Tech;
		private System.Windows.Forms.ToolStripMenuItem mnuView_List_Ticket;
		private System.Windows.Forms.ToolStripMenuItem mnuGoto;
		private System.Windows.Forms.ToolStripMenuItem mnuGoto_RecentTickets;
		private System.Windows.Forms.ToolStripMenuItem mnuGoto_RecentAssets;
		private System.Windows.Forms.ToolStripMenuItem mnuGoto_RecentTechs;
		private System.Windows.Forms.Timer tmrRefresh_Notifications;
		private System.Windows.Forms.Timer tmrRefresh_Tracker;
		private System.Windows.Forms.ToolStripMenuItem mnuAdmin_Config_RMAZones;
		private System.Windows.Forms.ToolStripMenuItem troubleshootingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp_Troubleshooting_ViewLogFile;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp_Troubleshooting_ReportProblem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem mnuRma;
		private System.Windows.Forms.ToolStripMenuItem mnuRma_List;
		private System.Windows.Forms.ToolStripMenuItem mnuRma_Migration;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuRma_Legacy;
		private System.Windows.Forms.ToolStripMenuItem mnuShipments;
		private System.Windows.Forms.ToolStripMenuItem mnuRma_Inventory;
		private System.Windows.Forms.ToolStripMenuItem mnuView_CameraCheck;
		private System.Windows.Forms.ToolStripMenuItem mnuView_Refresh;
		private System.Windows.Forms.ToolStripMenuItem mnuView_CameraCheckReview;
		private System.Windows.Forms.Button btnCameraCheck_Due;
		private System.Windows.Forms.Button btnCameraCheck_Fails;
		private System.Windows.Forms.Timer tmrRefresh_CameraChecks;
		private System.Windows.Forms.ToolStripMenuItem mnuView_CameraCheckAudit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.Timer tmrFlasher_CameraCheckDue;
		private System.Windows.Forms.Timer tmrFlasher_CameraCheckReview;
		private System.Windows.Forms.Timer tmrCheckLogout;
		private System.Windows.Forms.LinkLabel lnkLogin_ForgotPassword;
        private System.Windows.Forms.TabPage tabMarket;
        private CustomerEditor customerEditor1;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_AssetTag_Config;
        private System.Windows.Forms.ToolStripMenuItem magicInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}