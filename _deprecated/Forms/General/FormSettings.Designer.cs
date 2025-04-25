namespace SDB.Forms.General
{
    partial class FormSettings
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
            this.pnlServer = new System.Windows.Forms.Panel();
            this.tbxSamsungDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatabaseServer = new System.Windows.Forms.Label();
            this.lblServer_Timeout = new System.Windows.Forms.Label();
            this.lblServer_TimeoutSeconds = new System.Windows.Forms.Label();
            this.numServer_Timeout = new System.Windows.Forms.NumericUpDown();
            this.txtDBName_Monitoring = new System.Windows.Forms.TextBox();
            this.txtDBName_Service = new System.Windows.Forms.TextBox();
            this.lblDBName_Monitoring = new System.Windows.Forms.Label();
            this.lblDBName_Service = new System.Windows.Forms.Label();
            this.txtServer_User = new System.Windows.Forms.TextBox();
            this.lblServer_User = new System.Windows.Forms.Label();
            this.txtServer_Password = new System.Windows.Forms.TextBox();
            this.lblServer_Password = new System.Windows.Forms.Label();
            this.txtServer_Server = new System.Windows.Forms.TextBox();
            this.lblServer_Server = new System.Windows.Forms.Label();
            this.chkEmail_UseSSL = new System.Windows.Forms.CheckBox();
            this.lblEmail_ServerPort = new System.Windows.Forms.Label();
            this.txtEmail_ServerPort = new System.Windows.Forms.TextBox();
            this.lblEmail_Password = new System.Windows.Forms.Label();
            this.txtEmail_Password = new System.Windows.Forms.TextBox();
            this.txtEmail_User = new System.Windows.Forms.TextBox();
            this.lblEmail_User = new System.Windows.Forms.Label();
            this.txtEmail_Server = new System.Windows.Forms.TextBox();
            this.lblEmail_Server = new System.Windows.Forms.Label();
            this.pnlStartupOptions = new System.Windows.Forms.Panel();
            this.radStartupScreen_MagicInfo = new System.Windows.Forms.RadioButton();
            this.chkCameraCheckEnable = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radStartupScreen_Shipments = new System.Windows.Forms.RadioButton();
            this.lblStartupScreen = new System.Windows.Forms.Label();
            this.radStartupScreen_RMA = new System.Windows.Forms.RadioButton();
            this.radStartupScreen_Reports = new System.Windows.Forms.RadioButton();
            this.radStartupScreen_Tracker = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtVNCPath = new System.Windows.Forms.TextBox();
            this.txtDashboardURL = new System.Windows.Forms.TextBox();
            this.numVNCTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtVNCPasswordWindowTitle = new System.Windows.Forms.TextBox();
            this.txtServer_Update = new System.Windows.Forms.TextBox();
            this.chkAutoSubscribe_Modify = new System.Windows.Forms.CheckBox();
            this.chkAutoSubscribe_Create = new System.Windows.Forms.CheckBox();
            this.btnVNCPathBrowse = new System.Windows.Forms.Button();
            this.btnJournalFont_Change = new System.Windows.Forms.Button();
            this.txtTeamViewerPath = new System.Windows.Forms.TextBox();
            this.btnTeamViewerPathBrowse = new System.Windows.Forms.Button();
            this.tbxRealVNCPath = new System.Windows.Forms.TextBox();
            this.btnRealVNCEXE = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmailServer = new System.Windows.Forms.Label();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblDashboardURL = new System.Windows.Forms.Label();
            this.lblVNCPasswordWindowTitle = new System.Windows.Forms.Label();
            this.lblVNCTimeoutSeconds = new System.Windows.Forms.Label();
            this.lblVNCTimeout = new System.Windows.Forms.Label();
            this.lblDefaultMapZoomLevel = new System.Windows.Forms.Label();
            this.cmbDefaultMapZoomLevel = new System.Windows.Forms.ComboBox();
            this.lblVNCPath = new System.Windows.Forms.Label();
            this.pnlUpdateServer = new System.Windows.Forms.Panel();
            this.lblUpdateServer = new System.Windows.Forms.Label();
            this.lblUpdateServerRepeat = new System.Windows.Forms.Label();
            this.pnlVisual = new System.Windows.Forms.Panel();
            this.txtJournalFont = new System.Windows.Forms.TextBox();
            this.lblJournalFont = new System.Windows.Forms.Label();
            this.lblVisual = new System.Windows.Forms.Label();
            this.pnlVNC = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVNC = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabServers = new System.Windows.Forms.TabPage();
            this.pnlFileServer = new System.Windows.Forms.Panel();
            this.btnCameraImagePath = new System.Windows.Forms.Button();
            this.lblCameraImagePath = new System.Windows.Forms.Label();
            this.txtCameraImagePath = new System.Windows.Forms.TextBox();
            this.lblFileServer = new System.Windows.Forms.Label();
            this.tabExternalPrograms = new System.Windows.Forms.TabPage();
            this.pnlTeamViewer = new System.Windows.Forms.Panel();
            this.lblTeamViewer = new System.Windows.Forms.Label();
            this.lblTeamViewerExecutable = new System.Windows.Forms.Label();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.pnlPrinting = new System.Windows.Forms.Panel();
            this.lblRMA_ZoneLabel_PrinterName = new System.Windows.Forms.Label();
            this.cmbRMA_ZoneLabel_PrinterName = new System.Windows.Forms.ComboBox();
            this.lblRMA_BinLabel_PrinterName = new System.Windows.Forms.Label();
            this.cmbRMA_BinLabel_PrinterName = new System.Windows.Forms.ComboBox();
            this.lblPrinting = new System.Windows.Forms.Label();
            this.pnlServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServer_Timeout)).BeginInit();
            this.pnlStartupOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVNCTimeout)).BeginInit();
            this.pnlEmail.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlUpdateServer.SuspendLayout();
            this.pnlVisual.SuspendLayout();
            this.pnlVNC.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabServers.SuspendLayout();
            this.pnlFileServer.SuspendLayout();
            this.tabExternalPrograms.SuspendLayout();
            this.pnlTeamViewer.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            this.pnlPrinting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.LightGray;
            this.pnlServer.Controls.Add(this.tbxSamsungDBName);
            this.pnlServer.Controls.Add(this.label1);
            this.pnlServer.Controls.Add(this.lblDatabaseServer);
            this.pnlServer.Controls.Add(this.lblServer_Timeout);
            this.pnlServer.Controls.Add(this.lblServer_TimeoutSeconds);
            this.pnlServer.Controls.Add(this.numServer_Timeout);
            this.pnlServer.Controls.Add(this.txtDBName_Monitoring);
            this.pnlServer.Controls.Add(this.txtDBName_Service);
            this.pnlServer.Controls.Add(this.lblDBName_Monitoring);
            this.pnlServer.Controls.Add(this.lblDBName_Service);
            this.pnlServer.Controls.Add(this.txtServer_User);
            this.pnlServer.Controls.Add(this.lblServer_User);
            this.pnlServer.Controls.Add(this.txtServer_Password);
            this.pnlServer.Controls.Add(this.lblServer_Password);
            this.pnlServer.Controls.Add(this.txtServer_Server);
            this.pnlServer.Controls.Add(this.lblServer_Server);
            this.pnlServer.Location = new System.Drawing.Point(5, 5);
            this.pnlServer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Padding = new System.Windows.Forms.Padding(2);
            this.pnlServer.Size = new System.Drawing.Size(616, 166);
            this.pnlServer.TabIndex = 0;
            this.pnlServer.Text = "Database Server";
            // 
            // tbxSamsungDBName
            // 
            this.tbxSamsungDBName.Location = new System.Drawing.Point(213, 111);
            this.tbxSamsungDBName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSamsungDBName.MaxLength = 64;
            this.tbxSamsungDBName.Name = "tbxSamsungDBName";
            this.tbxSamsungDBName.Size = new System.Drawing.Size(157, 20);
            this.tbxSamsungDBName.TabIndex = 15;
            this.toolTip.SetToolTip(this.tbxSamsungDBName, "The name of the database used to store Samsung SBD data. Default \"magicinfo_lfd\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Samsung Database Name";
            // 
            // lblDatabaseServer
            // 
            this.lblDatabaseServer.AutoEllipsis = true;
            this.lblDatabaseServer.BackColor = System.Drawing.Color.Black;
            this.lblDatabaseServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatabaseServer.ForeColor = System.Drawing.Color.White;
            this.lblDatabaseServer.Location = new System.Drawing.Point(2, 2);
            this.lblDatabaseServer.Name = "lblDatabaseServer";
            this.lblDatabaseServer.Size = new System.Drawing.Size(612, 17);
            this.lblDatabaseServer.TabIndex = 0;
            this.lblDatabaseServer.Text = "Database Server";
            this.lblDatabaseServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServer_Timeout
            // 
            this.lblServer_Timeout.AutoSize = true;
            this.lblServer_Timeout.Location = new System.Drawing.Point(7, 138);
            this.lblServer_Timeout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer_Timeout.Name = "lblServer_Timeout";
            this.lblServer_Timeout.Size = new System.Drawing.Size(48, 13);
            this.lblServer_Timeout.TabIndex = 7;
            this.lblServer_Timeout.Text = "Timeout:";
            // 
            // lblServer_TimeoutSeconds
            // 
            this.lblServer_TimeoutSeconds.AutoSize = true;
            this.lblServer_TimeoutSeconds.Location = new System.Drawing.Point(112, 142);
            this.lblServer_TimeoutSeconds.Name = "lblServer_TimeoutSeconds";
            this.lblServer_TimeoutSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblServer_TimeoutSeconds.TabIndex = 9;
            this.lblServer_TimeoutSeconds.Text = "seconds";
            // 
            // numServer_Timeout
            // 
            this.numServer_Timeout.Location = new System.Drawing.Point(60, 136);
            this.numServer_Timeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numServer_Timeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numServer_Timeout.Name = "numServer_Timeout";
            this.numServer_Timeout.Size = new System.Drawing.Size(48, 20);
            this.numServer_Timeout.TabIndex = 8;
            this.toolTip.SetToolTip(this.numServer_Timeout, "Time to allow for database connections. Default: 20");
            this.numServer_Timeout.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numServer_Timeout.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // txtDBName_Monitoring
            // 
            this.txtDBName_Monitoring.Location = new System.Drawing.Point(213, 73);
            this.txtDBName_Monitoring.Margin = new System.Windows.Forms.Padding(2);
            this.txtDBName_Monitoring.MaxLength = 64;
            this.txtDBName_Monitoring.Name = "txtDBName_Monitoring";
            this.txtDBName_Monitoring.Size = new System.Drawing.Size(157, 20);
            this.txtDBName_Monitoring.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtDBName_Monitoring, "The name of the database used to store monitoring information. Default: \"pvm\"");
            this.txtDBName_Monitoring.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtDBName_Service
            // 
            this.txtDBName_Service.Location = new System.Drawing.Point(213, 35);
            this.txtDBName_Service.Margin = new System.Windows.Forms.Padding(2);
            this.txtDBName_Service.MaxLength = 64;
            this.txtDBName_Service.Name = "txtDBName_Service";
            this.txtDBName_Service.Size = new System.Drawing.Size(157, 20);
            this.txtDBName_Service.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtDBName_Service, "The name of the database used to store service database information. Default: \"el" +
        "ectronics\"");
            this.txtDBName_Service.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblDBName_Monitoring
            // 
            this.lblDBName_Monitoring.AutoSize = true;
            this.lblDBName_Monitoring.Location = new System.Drawing.Point(213, 57);
            this.lblDBName_Monitoring.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDBName_Monitoring.Name = "lblDBName_Monitoring";
            this.lblDBName_Monitoring.Size = new System.Drawing.Size(136, 13);
            this.lblDBName_Monitoring.TabIndex = 12;
            this.lblDBName_Monitoring.Text = "Monitoring Database Name";
            // 
            // lblDBName_Service
            // 
            this.lblDBName_Service.AutoSize = true;
            this.lblDBName_Service.Location = new System.Drawing.Point(213, 19);
            this.lblDBName_Service.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDBName_Service.Name = "lblDBName_Service";
            this.lblDBName_Service.Size = new System.Drawing.Size(123, 13);
            this.lblDBName_Service.TabIndex = 10;
            this.lblDBName_Service.Text = "Service Database Name";
            // 
            // txtServer_User
            // 
            this.txtServer_User.Location = new System.Drawing.Point(4, 73);
            this.txtServer_User.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer_User.MaxLength = 64;
            this.txtServer_User.Name = "txtServer_User";
            this.txtServer_User.Size = new System.Drawing.Size(157, 20);
            this.txtServer_User.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtServer_User, "The username to connect to the database. Note: This is not the same as your perso" +
        "nal user ID.");
            this.txtServer_User.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblServer_User
            // 
            this.lblServer_User.AutoSize = true;
            this.lblServer_User.Location = new System.Drawing.Point(4, 57);
            this.lblServer_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer_User.Name = "lblServer_User";
            this.lblServer_User.Size = new System.Drawing.Size(67, 13);
            this.lblServer_User.TabIndex = 3;
            this.lblServer_User.Text = "MySQL User";
            // 
            // txtServer_Password
            // 
            this.txtServer_Password.Location = new System.Drawing.Point(4, 111);
            this.txtServer_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer_Password.MaxLength = 64;
            this.txtServer_Password.Name = "txtServer_Password";
            this.txtServer_Password.Size = new System.Drawing.Size(157, 20);
            this.txtServer_Password.TabIndex = 6;
            this.txtServer_Password.UseSystemPasswordChar = true;
            this.txtServer_Password.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblServer_Password
            // 
            this.lblServer_Password.AutoSize = true;
            this.lblServer_Password.Location = new System.Drawing.Point(4, 95);
            this.lblServer_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer_Password.Name = "lblServer_Password";
            this.lblServer_Password.Size = new System.Drawing.Size(91, 13);
            this.lblServer_Password.TabIndex = 5;
            this.lblServer_Password.Text = "MySQL Password";
            // 
            // txtServer_Server
            // 
            this.txtServer_Server.Location = new System.Drawing.Point(4, 35);
            this.txtServer_Server.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer_Server.MaxLength = 64;
            this.txtServer_Server.Name = "txtServer_Server";
            this.txtServer_Server.Size = new System.Drawing.Size(157, 20);
            this.txtServer_Server.TabIndex = 2;
            this.txtServer_Server.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblServer_Server
            // 
            this.lblServer_Server.AutoSize = true;
            this.lblServer_Server.Location = new System.Drawing.Point(4, 19);
            this.lblServer_Server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer_Server.Name = "lblServer_Server";
            this.lblServer_Server.Size = new System.Drawing.Size(76, 13);
            this.lblServer_Server.TabIndex = 1;
            this.lblServer_Server.Text = "MySQL Server";
            // 
            // chkEmail_UseSSL
            // 
            this.chkEmail_UseSSL.AutoSize = true;
            this.chkEmail_UseSSL.Location = new System.Drawing.Point(192, 35);
            this.chkEmail_UseSSL.Name = "chkEmail_UseSSL";
            this.chkEmail_UseSSL.Size = new System.Drawing.Size(68, 17);
            this.chkEmail_UseSSL.TabIndex = 5;
            this.chkEmail_UseSSL.Text = "Use SSL";
            this.toolTip.SetToolTip(this.chkEmail_UseSSL, "Use Secure Sockets Layer (usually port 465 or 587)");
            this.chkEmail_UseSSL.UseVisualStyleBackColor = true;
            // 
            // lblEmail_ServerPort
            // 
            this.lblEmail_ServerPort.AutoSize = true;
            this.lblEmail_ServerPort.Location = new System.Drawing.Point(146, 17);
            this.lblEmail_ServerPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail_ServerPort.Name = "lblEmail_ServerPort";
            this.lblEmail_ServerPort.Size = new System.Drawing.Size(26, 13);
            this.lblEmail_ServerPort.TabIndex = 3;
            this.lblEmail_ServerPort.Text = "Port";
            // 
            // txtEmail_ServerPort
            // 
            this.txtEmail_ServerPort.Location = new System.Drawing.Point(149, 33);
            this.txtEmail_ServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_ServerPort.MaxLength = 5;
            this.txtEmail_ServerPort.Name = "txtEmail_ServerPort";
            this.txtEmail_ServerPort.Size = new System.Drawing.Size(38, 20);
            this.txtEmail_ServerPort.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtEmail_ServerPort, "SMTP is 25 by default. SSL is 465 or 587 (Gmail) by default.");
            this.txtEmail_ServerPort.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblEmail_Password
            // 
            this.lblEmail_Password.AutoSize = true;
            this.lblEmail_Password.Location = new System.Drawing.Point(2, 94);
            this.lblEmail_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail_Password.Name = "lblEmail_Password";
            this.lblEmail_Password.Size = new System.Drawing.Size(81, 13);
            this.lblEmail_Password.TabIndex = 8;
            this.lblEmail_Password.Text = "Email Password";
            // 
            // txtEmail_Password
            // 
            this.txtEmail_Password.Location = new System.Drawing.Point(5, 110);
            this.txtEmail_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_Password.MaxLength = 64;
            this.txtEmail_Password.Name = "txtEmail_Password";
            this.txtEmail_Password.Size = new System.Drawing.Size(182, 20);
            this.txtEmail_Password.TabIndex = 9;
            this.txtEmail_Password.UseSystemPasswordChar = true;
            this.txtEmail_Password.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtEmail_User
            // 
            this.txtEmail_User.Location = new System.Drawing.Point(5, 73);
            this.txtEmail_User.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_User.MaxLength = 64;
            this.txtEmail_User.Name = "txtEmail_User";
            this.txtEmail_User.Size = new System.Drawing.Size(182, 20);
            this.txtEmail_User.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtEmail_User, "The email account used to send email. Note: This is not the same as your personal" +
        " email account.");
            this.txtEmail_User.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblEmail_User
            // 
            this.lblEmail_User.AutoSize = true;
            this.lblEmail_User.Location = new System.Drawing.Point(2, 57);
            this.lblEmail_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail_User.Name = "lblEmail_User";
            this.lblEmail_User.Size = new System.Drawing.Size(83, 13);
            this.lblEmail_User.TabIndex = 6;
            this.lblEmail_User.Text = "Email Username";
            // 
            // txtEmail_Server
            // 
            this.txtEmail_Server.Location = new System.Drawing.Point(5, 33);
            this.txtEmail_Server.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail_Server.MaxLength = 64;
            this.txtEmail_Server.Name = "txtEmail_Server";
            this.txtEmail_Server.Size = new System.Drawing.Size(140, 20);
            this.txtEmail_Server.TabIndex = 2;
            this.txtEmail_Server.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblEmail_Server
            // 
            this.lblEmail_Server.AutoSize = true;
            this.lblEmail_Server.Location = new System.Drawing.Point(2, 17);
            this.lblEmail_Server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail_Server.Name = "lblEmail_Server";
            this.lblEmail_Server.Size = new System.Drawing.Size(66, 13);
            this.lblEmail_Server.TabIndex = 1;
            this.lblEmail_Server.Text = "Email Server";
            // 
            // pnlStartupOptions
            // 
            this.pnlStartupOptions.BackColor = System.Drawing.Color.LightGray;
            this.pnlStartupOptions.Controls.Add(this.radStartupScreen_MagicInfo);
            this.pnlStartupOptions.Controls.Add(this.chkCameraCheckEnable);
            this.pnlStartupOptions.Controls.Add(this.label6);
            this.pnlStartupOptions.Controls.Add(this.radStartupScreen_Shipments);
            this.pnlStartupOptions.Controls.Add(this.lblStartupScreen);
            this.pnlStartupOptions.Controls.Add(this.radStartupScreen_RMA);
            this.pnlStartupOptions.Controls.Add(this.radStartupScreen_Reports);
            this.pnlStartupOptions.Controls.Add(this.radStartupScreen_Tracker);
            this.pnlStartupOptions.Location = new System.Drawing.Point(5, 5);
            this.pnlStartupOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStartupOptions.Name = "pnlStartupOptions";
            this.pnlStartupOptions.Padding = new System.Windows.Forms.Padding(2);
            this.pnlStartupOptions.Size = new System.Drawing.Size(616, 128);
            this.pnlStartupOptions.TabIndex = 0;
            this.pnlStartupOptions.Text = "Startup Options";
            // 
            // radStartupScreen_MagicInfo
            // 
            this.radStartupScreen_MagicInfo.AutoSize = true;
            this.radStartupScreen_MagicInfo.Location = new System.Drawing.Point(24, 98);
            this.radStartupScreen_MagicInfo.Margin = new System.Windows.Forms.Padding(2);
            this.radStartupScreen_MagicInfo.Name = "radStartupScreen_MagicInfo";
            this.radStartupScreen_MagicInfo.Size = new System.Drawing.Size(72, 17);
            this.radStartupScreen_MagicInfo.TabIndex = 7;
            this.radStartupScreen_MagicInfo.TabStop = true;
            this.radStartupScreen_MagicInfo.Text = "MagicInfo";
            this.radStartupScreen_MagicInfo.UseVisualStyleBackColor = true;
            // 
            // chkCameraCheckEnable
            // 
            this.chkCameraCheckEnable.AutoSize = true;
            this.chkCameraCheckEnable.Location = new System.Drawing.Point(177, 41);
            this.chkCameraCheckEnable.Name = "chkCameraCheckEnable";
            this.chkCameraCheckEnable.Size = new System.Drawing.Size(204, 17);
            this.chkCameraCheckEnable.TabIndex = 6;
            this.chkCameraCheckEnable.Text = "Enable Asset Camera Check Updates";
            this.toolTip.SetToolTip(this.chkCameraCheckEnable, "Enables automatic updates of camera check notification buttons.");
            this.chkCameraCheckEnable.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Startup Options";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radStartupScreen_Shipments
            // 
            this.radStartupScreen_Shipments.AutoSize = true;
            this.radStartupScreen_Shipments.Location = new System.Drawing.Point(24, 81);
            this.radStartupScreen_Shipments.Margin = new System.Windows.Forms.Padding(2);
            this.radStartupScreen_Shipments.Name = "radStartupScreen_Shipments";
            this.radStartupScreen_Shipments.Size = new System.Drawing.Size(74, 17);
            this.radStartupScreen_Shipments.TabIndex = 5;
            this.radStartupScreen_Shipments.TabStop = true;
            this.radStartupScreen_Shipments.Text = "Shipments";
            this.radStartupScreen_Shipments.UseVisualStyleBackColor = true;
            // 
            // lblStartupScreen
            // 
            this.lblStartupScreen.AutoSize = true;
            this.lblStartupScreen.Location = new System.Drawing.Point(3, 19);
            this.lblStartupScreen.Name = "lblStartupScreen";
            this.lblStartupScreen.Size = new System.Drawing.Size(120, 13);
            this.lblStartupScreen.TabIndex = 1;
            this.lblStartupScreen.Text = "Default Startup Window";
            // 
            // radStartupScreen_RMA
            // 
            this.radStartupScreen_RMA.AutoSize = true;
            this.radStartupScreen_RMA.Location = new System.Drawing.Point(24, 48);
            this.radStartupScreen_RMA.Margin = new System.Windows.Forms.Padding(2);
            this.radStartupScreen_RMA.Name = "radStartupScreen_RMA";
            this.radStartupScreen_RMA.Size = new System.Drawing.Size(86, 17);
            this.radStartupScreen_RMA.TabIndex = 3;
            this.radStartupScreen_RMA.TabStop = true;
            this.radStartupScreen_RMA.Text = "RMA System";
            this.radStartupScreen_RMA.UseVisualStyleBackColor = true;
            // 
            // radStartupScreen_Reports
            // 
            this.radStartupScreen_Reports.AutoSize = true;
            this.radStartupScreen_Reports.Location = new System.Drawing.Point(24, 65);
            this.radStartupScreen_Reports.Margin = new System.Windows.Forms.Padding(2);
            this.radStartupScreen_Reports.Name = "radStartupScreen_Reports";
            this.radStartupScreen_Reports.Size = new System.Drawing.Size(62, 17);
            this.radStartupScreen_Reports.TabIndex = 4;
            this.radStartupScreen_Reports.TabStop = true;
            this.radStartupScreen_Reports.Text = "Reports";
            this.radStartupScreen_Reports.UseVisualStyleBackColor = true;
            // 
            // radStartupScreen_Tracker
            // 
            this.radStartupScreen_Tracker.AutoSize = true;
            this.radStartupScreen_Tracker.Location = new System.Drawing.Point(24, 32);
            this.radStartupScreen_Tracker.Margin = new System.Windows.Forms.Padding(2);
            this.radStartupScreen_Tracker.Name = "radStartupScreen_Tracker";
            this.radStartupScreen_Tracker.Size = new System.Drawing.Size(95, 17);
            this.radStartupScreen_Tracker.TabIndex = 2;
            this.radStartupScreen_Tracker.TabStop = true;
            this.radStartupScreen_Tracker.Text = "Ticket Tracker";
            this.radStartupScreen_Tracker.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(577, 502);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVNCPath
            // 
            this.txtVNCPath.Location = new System.Drawing.Point(6, 37);
            this.txtVNCPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtVNCPath.MaxLength = 256;
            this.txtVNCPath.Name = "txtVNCPath";
            this.txtVNCPath.ReadOnly = true;
            this.txtVNCPath.Size = new System.Drawing.Size(559, 20);
            this.txtVNCPath.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtVNCPath, "Path to TightVNC executable. Other VNC clients may work but are not tested.");
            // 
            // txtDashboardURL
            // 
            this.txtDashboardURL.Location = new System.Drawing.Point(6, 32);
            this.txtDashboardURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtDashboardURL.MaxLength = 256;
            this.txtDashboardURL.Name = "txtDashboardURL";
            this.txtDashboardURL.Size = new System.Drawing.Size(608, 20);
            this.txtDashboardURL.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtDashboardURL, "Example: http://192.168.92.2/dashboard/single.php?a=");
            this.txtDashboardURL.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // numVNCTimeout
            // 
            this.numVNCTimeout.Location = new System.Drawing.Point(178, 148);
            this.numVNCTimeout.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numVNCTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVNCTimeout.Name = "numVNCTimeout";
            this.numVNCTimeout.Size = new System.Drawing.Size(48, 20);
            this.numVNCTimeout.TabIndex = 7;
            this.toolTip.SetToolTip(this.numVNCTimeout, "How long SDB will wait to automatically input the VNC password before giving up.");
            this.numVNCTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numVNCTimeout.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // txtVNCPasswordWindowTitle
            // 
            this.txtVNCPasswordWindowTitle.Location = new System.Drawing.Point(178, 106);
            this.txtVNCPasswordWindowTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtVNCPasswordWindowTitle.MaxLength = 64;
            this.txtVNCPasswordWindowTitle.Name = "txtVNCPasswordWindowTitle";
            this.txtVNCPasswordWindowTitle.Size = new System.Drawing.Size(220, 20);
            this.txtVNCPasswordWindowTitle.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtVNCPasswordWindowTitle, "The title of the window that VNC shows for password entry.");
            this.txtVNCPasswordWindowTitle.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtServer_Update
            // 
            this.txtServer_Update.Location = new System.Drawing.Point(5, 33);
            this.txtServer_Update.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer_Update.MaxLength = 64;
            this.txtServer_Update.Name = "txtServer_Update";
            this.txtServer_Update.Size = new System.Drawing.Size(182, 20);
            this.txtServer_Update.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtServer_Update, "The address of the web server to check for application updates.");
            this.txtServer_Update.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // chkAutoSubscribe_Modify
            // 
            this.chkAutoSubscribe_Modify.AutoSize = true;
            this.chkAutoSubscribe_Modify.Location = new System.Drawing.Point(7, 43);
            this.chkAutoSubscribe_Modify.Name = "chkAutoSubscribe_Modify";
            this.chkAutoSubscribe_Modify.Size = new System.Drawing.Size(202, 17);
            this.chkAutoSubscribe_Modify.TabIndex = 2;
            this.chkAutoSubscribe_Modify.Text = "Auto-subscribe when modifying items.";
            this.toolTip.SetToolTip(this.chkAutoSubscribe_Modify, "Subscribe to items such as tickets, shipments and RMAs when modifying them.");
            this.chkAutoSubscribe_Modify.UseVisualStyleBackColor = true;
            // 
            // chkAutoSubscribe_Create
            // 
            this.chkAutoSubscribe_Create.AutoSize = true;
            this.chkAutoSubscribe_Create.Location = new System.Drawing.Point(8, 20);
            this.chkAutoSubscribe_Create.Name = "chkAutoSubscribe_Create";
            this.chkAutoSubscribe_Create.Size = new System.Drawing.Size(196, 17);
            this.chkAutoSubscribe_Create.TabIndex = 1;
            this.chkAutoSubscribe_Create.Text = "Auto-subscribe when creating items.";
            this.toolTip.SetToolTip(this.chkAutoSubscribe_Create, "Subscribe to items such as tickets, shipments and RMAs when creating them.");
            this.chkAutoSubscribe_Create.UseVisualStyleBackColor = true;
            // 
            // btnVNCPathBrowse
            // 
            this.btnVNCPathBrowse.Location = new System.Drawing.Point(570, 35);
            this.btnVNCPathBrowse.Name = "btnVNCPathBrowse";
            this.btnVNCPathBrowse.Size = new System.Drawing.Size(44, 23);
            this.btnVNCPathBrowse.TabIndex = 3;
            this.btnVNCPathBrowse.Text = "...";
            this.toolTip.SetToolTip(this.btnVNCPathBrowse, "Select VNC executable");
            this.btnVNCPathBrowse.UseVisualStyleBackColor = true;
            this.btnVNCPathBrowse.Click += new System.EventHandler(this.btnVNCPathBrowse_Click);
            // 
            // btnJournalFont_Change
            // 
            this.btnJournalFont_Change.Location = new System.Drawing.Point(399, 46);
            this.btnJournalFont_Change.Name = "btnJournalFont_Change";
            this.btnJournalFont_Change.Size = new System.Drawing.Size(44, 23);
            this.btnJournalFont_Change.TabIndex = 5;
            this.btnJournalFont_Change.Text = "...";
            this.toolTip.SetToolTip(this.btnJournalFont_Change, "Select Font");
            this.btnJournalFont_Change.UseVisualStyleBackColor = true;
            this.btnJournalFont_Change.Click += new System.EventHandler(this.btnJournalFont_Change_Click);
            // 
            // txtTeamViewerPath
            // 
            this.txtTeamViewerPath.Location = new System.Drawing.Point(6, 37);
            this.txtTeamViewerPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeamViewerPath.MaxLength = 256;
            this.txtTeamViewerPath.Name = "txtTeamViewerPath";
            this.txtTeamViewerPath.ReadOnly = true;
            this.txtTeamViewerPath.Size = new System.Drawing.Size(559, 20);
            this.txtTeamViewerPath.TabIndex = 2;
            this.toolTip.SetToolTip(this.txtTeamViewerPath, "Path to TightVNC executable. Other VNC clients may work but are not tested.");
            // 
            // btnTeamViewerPathBrowse
            // 
            this.btnTeamViewerPathBrowse.Location = new System.Drawing.Point(570, 35);
            this.btnTeamViewerPathBrowse.Name = "btnTeamViewerPathBrowse";
            this.btnTeamViewerPathBrowse.Size = new System.Drawing.Size(44, 23);
            this.btnTeamViewerPathBrowse.TabIndex = 3;
            this.btnTeamViewerPathBrowse.Text = "...";
            this.toolTip.SetToolTip(this.btnTeamViewerPathBrowse, "Select VNC executable");
            this.btnTeamViewerPathBrowse.UseVisualStyleBackColor = true;
            this.btnTeamViewerPathBrowse.Click += new System.EventHandler(this.btnTeamViewerPathBrowse_Click);
            // 
            // tbxRealVNCPath
            // 
            this.tbxRealVNCPath.Location = new System.Drawing.Point(10, 78);
            this.tbxRealVNCPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRealVNCPath.MaxLength = 256;
            this.tbxRealVNCPath.Name = "tbxRealVNCPath";
            this.tbxRealVNCPath.ReadOnly = true;
            this.tbxRealVNCPath.Size = new System.Drawing.Size(555, 20);
            this.tbxRealVNCPath.TabIndex = 10;
            this.toolTip.SetToolTip(this.tbxRealVNCPath, "Path to TightVNC executable. Other VNC clients may work but are not tested.");
            // 
            // btnRealVNCEXE
            // 
            this.btnRealVNCEXE.Location = new System.Drawing.Point(569, 78);
            this.btnRealVNCEXE.Name = "btnRealVNCEXE";
            this.btnRealVNCEXE.Size = new System.Drawing.Size(44, 23);
            this.btnRealVNCEXE.TabIndex = 11;
            this.btnRealVNCEXE.Text = "...";
            this.toolTip.SetToolTip(this.btnRealVNCEXE, "Select VNC executable");
            this.btnRealVNCEXE.UseVisualStyleBackColor = true;
            this.btnRealVNCEXE.Click += new System.EventHandler(this.btnRealVNCEXE_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(499, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(74, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.LightGray;
            this.pnlEmail.Controls.Add(this.lblEmailServer);
            this.pnlEmail.Controls.Add(this.lblEmail_Server);
            this.pnlEmail.Controls.Add(this.txtEmail_Server);
            this.pnlEmail.Controls.Add(this.lblEmail_User);
            this.pnlEmail.Controls.Add(this.txtEmail_User);
            this.pnlEmail.Controls.Add(this.chkEmail_UseSSL);
            this.pnlEmail.Controls.Add(this.txtEmail_Password);
            this.pnlEmail.Controls.Add(this.lblEmail_ServerPort);
            this.pnlEmail.Controls.Add(this.lblEmail_Password);
            this.pnlEmail.Controls.Add(this.txtEmail_ServerPort);
            this.pnlEmail.Location = new System.Drawing.Point(5, 176);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(616, 141);
            this.pnlEmail.TabIndex = 1;
            this.pnlEmail.Text = "Email Server";
            // 
            // lblEmailServer
            // 
            this.lblEmailServer.AutoEllipsis = true;
            this.lblEmailServer.BackColor = System.Drawing.Color.Black;
            this.lblEmailServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmailServer.ForeColor = System.Drawing.Color.White;
            this.lblEmailServer.Location = new System.Drawing.Point(0, 0);
            this.lblEmailServer.Name = "lblEmailServer";
            this.lblEmailServer.Size = new System.Drawing.Size(616, 17);
            this.lblEmailServer.TabIndex = 0;
            this.lblEmailServer.Text = "Email Server";
            this.lblEmailServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.LightGray;
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Controls.Add(this.txtDashboardURL);
            this.pnlDashboard.Controls.Add(this.lblDashboardURL);
            this.pnlDashboard.Location = new System.Drawing.Point(5, 6);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(616, 62);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Text = "Dashboard";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoEllipsis = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Black;
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(616, 17);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDashboardURL
            // 
            this.lblDashboardURL.AutoSize = true;
            this.lblDashboardURL.Location = new System.Drawing.Point(2, 17);
            this.lblDashboardURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboardURL.Name = "lblDashboardURL";
            this.lblDashboardURL.Size = new System.Drawing.Size(84, 13);
            this.lblDashboardURL.TabIndex = 1;
            this.lblDashboardURL.Text = "Dashboard URL";
            // 
            // lblVNCPasswordWindowTitle
            // 
            this.lblVNCPasswordWindowTitle.AutoSize = true;
            this.lblVNCPasswordWindowTitle.Location = new System.Drawing.Point(7, 109);
            this.lblVNCPasswordWindowTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVNCPasswordWindowTitle.Name = "lblVNCPasswordWindowTitle";
            this.lblVNCPasswordWindowTitle.Size = new System.Drawing.Size(143, 13);
            this.lblVNCPasswordWindowTitle.TabIndex = 4;
            this.lblVNCPasswordWindowTitle.Text = "VNC Password Window Title";
            // 
            // lblVNCTimeoutSeconds
            // 
            this.lblVNCTimeoutSeconds.AutoSize = true;
            this.lblVNCTimeoutSeconds.Location = new System.Drawing.Point(232, 150);
            this.lblVNCTimeoutSeconds.Name = "lblVNCTimeoutSeconds";
            this.lblVNCTimeoutSeconds.Size = new System.Drawing.Size(47, 13);
            this.lblVNCTimeoutSeconds.TabIndex = 8;
            this.lblVNCTimeoutSeconds.Text = "seconds";
            // 
            // lblVNCTimeout
            // 
            this.lblVNCTimeout.AutoSize = true;
            this.lblVNCTimeout.Location = new System.Drawing.Point(7, 150);
            this.lblVNCTimeout.Name = "lblVNCTimeout";
            this.lblVNCTimeout.Size = new System.Drawing.Size(144, 13);
            this.lblVNCTimeout.TabIndex = 6;
            this.lblVNCTimeout.Text = "VNC Auto-Password Timeout";
            // 
            // lblDefaultMapZoomLevel
            // 
            this.lblDefaultMapZoomLevel.AutoSize = true;
            this.lblDefaultMapZoomLevel.Location = new System.Drawing.Point(5, 23);
            this.lblDefaultMapZoomLevel.Name = "lblDefaultMapZoomLevel";
            this.lblDefaultMapZoomLevel.Size = new System.Drawing.Size(165, 13);
            this.lblDefaultMapZoomLevel.TabIndex = 1;
            this.lblDefaultMapZoomLevel.Text = "Default zoom level for map views:";
            // 
            // cmbDefaultMapZoomLevel
            // 
            this.cmbDefaultMapZoomLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultMapZoomLevel.FormattingEnabled = true;
            this.cmbDefaultMapZoomLevel.Items.AddRange(new object[] {
            "State/Province Level",
            "City Level",
            "Street Level"});
            this.cmbDefaultMapZoomLevel.Location = new System.Drawing.Point(177, 20);
            this.cmbDefaultMapZoomLevel.Name = "cmbDefaultMapZoomLevel";
            this.cmbDefaultMapZoomLevel.Size = new System.Drawing.Size(171, 21);
            this.cmbDefaultMapZoomLevel.TabIndex = 2;
            // 
            // lblVNCPath
            // 
            this.lblVNCPath.AutoSize = true;
            this.lblVNCPath.Location = new System.Drawing.Point(3, 18);
            this.lblVNCPath.Name = "lblVNCPath";
            this.lblVNCPath.Size = new System.Drawing.Size(148, 13);
            this.lblVNCPath.TabIndex = 1;
            this.lblVNCPath.Text = "Path to TightVNC executable:";
            // 
            // pnlUpdateServer
            // 
            this.pnlUpdateServer.BackColor = System.Drawing.Color.LightGray;
            this.pnlUpdateServer.Controls.Add(this.lblUpdateServer);
            this.pnlUpdateServer.Controls.Add(this.txtServer_Update);
            this.pnlUpdateServer.Controls.Add(this.lblUpdateServerRepeat);
            this.pnlUpdateServer.Location = new System.Drawing.Point(5, 323);
            this.pnlUpdateServer.Name = "pnlUpdateServer";
            this.pnlUpdateServer.Size = new System.Drawing.Size(616, 62);
            this.pnlUpdateServer.TabIndex = 2;
            this.pnlUpdateServer.Text = "Update Server";
            // 
            // lblUpdateServer
            // 
            this.lblUpdateServer.AutoEllipsis = true;
            this.lblUpdateServer.BackColor = System.Drawing.Color.Black;
            this.lblUpdateServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUpdateServer.ForeColor = System.Drawing.Color.White;
            this.lblUpdateServer.Location = new System.Drawing.Point(0, 0);
            this.lblUpdateServer.Name = "lblUpdateServer";
            this.lblUpdateServer.Size = new System.Drawing.Size(616, 17);
            this.lblUpdateServer.TabIndex = 0;
            this.lblUpdateServer.Text = "Update Server";
            this.lblUpdateServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpdateServerRepeat
            // 
            this.lblUpdateServerRepeat.AutoSize = true;
            this.lblUpdateServerRepeat.Location = new System.Drawing.Point(2, 18);
            this.lblUpdateServerRepeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateServerRepeat.Name = "lblUpdateServerRepeat";
            this.lblUpdateServerRepeat.Size = new System.Drawing.Size(76, 13);
            this.lblUpdateServerRepeat.TabIndex = 1;
            this.lblUpdateServerRepeat.Text = "Update Server";
            // 
            // pnlVisual
            // 
            this.pnlVisual.BackColor = System.Drawing.Color.LightGray;
            this.pnlVisual.Controls.Add(this.txtJournalFont);
            this.pnlVisual.Controls.Add(this.btnJournalFont_Change);
            this.pnlVisual.Controls.Add(this.lblJournalFont);
            this.pnlVisual.Controls.Add(this.lblVisual);
            this.pnlVisual.Controls.Add(this.lblDefaultMapZoomLevel);
            this.pnlVisual.Controls.Add(this.cmbDefaultMapZoomLevel);
            this.pnlVisual.Location = new System.Drawing.Point(5, 138);
            this.pnlVisual.Name = "pnlVisual";
            this.pnlVisual.Size = new System.Drawing.Size(616, 79);
            this.pnlVisual.TabIndex = 1;
            this.pnlVisual.Text = "Visual";
            // 
            // txtJournalFont
            // 
            this.txtJournalFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJournalFont.Location = new System.Drawing.Point(177, 48);
            this.txtJournalFont.Name = "txtJournalFont";
            this.txtJournalFont.ReadOnly = true;
            this.txtJournalFont.Size = new System.Drawing.Size(216, 20);
            this.txtJournalFont.TabIndex = 4;
            this.txtJournalFont.Text = "MS Sans Serif (8 pt)";
            // 
            // lblJournalFont
            // 
            this.lblJournalFont.AutoSize = true;
            this.lblJournalFont.Location = new System.Drawing.Point(5, 51);
            this.lblJournalFont.Name = "lblJournalFont";
            this.lblJournalFont.Size = new System.Drawing.Size(137, 13);
            this.lblJournalFont.TabIndex = 3;
            this.lblJournalFont.Text = "Ticket journal font and size:";
            // 
            // lblVisual
            // 
            this.lblVisual.AutoEllipsis = true;
            this.lblVisual.BackColor = System.Drawing.Color.Black;
            this.lblVisual.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVisual.ForeColor = System.Drawing.Color.White;
            this.lblVisual.Location = new System.Drawing.Point(0, 0);
            this.lblVisual.Name = "lblVisual";
            this.lblVisual.Size = new System.Drawing.Size(616, 17);
            this.lblVisual.TabIndex = 0;
            this.lblVisual.Text = "Visual";
            this.lblVisual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlVNC
            // 
            this.pnlVNC.BackColor = System.Drawing.Color.LightGray;
            this.pnlVNC.Controls.Add(this.label2);
            this.pnlVNC.Controls.Add(this.tbxRealVNCPath);
            this.pnlVNC.Controls.Add(this.btnRealVNCEXE);
            this.pnlVNC.Controls.Add(this.lblVNC);
            this.pnlVNC.Controls.Add(this.txtVNCPasswordWindowTitle);
            this.pnlVNC.Controls.Add(this.lblVNCPath);
            this.pnlVNC.Controls.Add(this.lblVNCPasswordWindowTitle);
            this.pnlVNC.Controls.Add(this.txtVNCPath);
            this.pnlVNC.Controls.Add(this.lblVNCTimeoutSeconds);
            this.pnlVNC.Controls.Add(this.btnVNCPathBrowse);
            this.pnlVNC.Controls.Add(this.numVNCTimeout);
            this.pnlVNC.Controls.Add(this.lblVNCTimeout);
            this.pnlVNC.Location = new System.Drawing.Point(5, 74);
            this.pnlVNC.Name = "pnlVNC";
            this.pnlVNC.Size = new System.Drawing.Size(616, 232);
            this.pnlVNC.TabIndex = 1;
            this.pnlVNC.Text = "VNC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path to RealVNC executable:";
            // 
            // lblVNC
            // 
            this.lblVNC.AutoEllipsis = true;
            this.lblVNC.BackColor = System.Drawing.Color.Black;
            this.lblVNC.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVNC.ForeColor = System.Drawing.Color.White;
            this.lblVNC.Location = new System.Drawing.Point(0, 0);
            this.lblVNC.Name = "lblVNC";
            this.lblVNC.Size = new System.Drawing.Size(616, 17);
            this.lblVNC.TabIndex = 0;
            this.lblVNC.Text = "VNC";
            this.lblVNC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.LightGray;
            this.pnlNotifications.Controls.Add(this.lblNotifications);
            this.pnlNotifications.Controls.Add(this.chkAutoSubscribe_Modify);
            this.pnlNotifications.Controls.Add(this.chkAutoSubscribe_Create);
            this.pnlNotifications.Location = new System.Drawing.Point(5, 223);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(616, 68);
            this.pnlNotifications.TabIndex = 2;
            this.pnlNotifications.Text = "Notifications and Subscriptions";
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoEllipsis = true;
            this.lblNotifications.BackColor = System.Drawing.Color.Black;
            this.lblNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotifications.ForeColor = System.Drawing.Color.White;
            this.lblNotifications.Location = new System.Drawing.Point(0, 0);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(616, 17);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications and Subscriptions";
            this.lblNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabServers);
            this.tabControl1.Controls.Add(this.tabExternalPrograms);
            this.tabControl1.Controls.Add(this.tabPreferences);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabServers
            // 
            this.tabServers.Controls.Add(this.pnlFileServer);
            this.tabServers.Controls.Add(this.pnlServer);
            this.tabServers.Controls.Add(this.pnlEmail);
            this.tabServers.Controls.Add(this.pnlUpdateServer);
            this.tabServers.Location = new System.Drawing.Point(4, 22);
            this.tabServers.Name = "tabServers";
            this.tabServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabServers.Size = new System.Drawing.Size(630, 459);
            this.tabServers.TabIndex = 0;
            this.tabServers.Text = "Server Connections";
            this.tabServers.UseVisualStyleBackColor = true;
            // 
            // pnlFileServer
            // 
            this.pnlFileServer.BackColor = System.Drawing.Color.LightGray;
            this.pnlFileServer.Controls.Add(this.btnCameraImagePath);
            this.pnlFileServer.Controls.Add(this.lblCameraImagePath);
            this.pnlFileServer.Controls.Add(this.txtCameraImagePath);
            this.pnlFileServer.Controls.Add(this.lblFileServer);
            this.pnlFileServer.Location = new System.Drawing.Point(5, 391);
            this.pnlFileServer.Name = "pnlFileServer";
            this.pnlFileServer.Size = new System.Drawing.Size(616, 62);
            this.pnlFileServer.TabIndex = 3;
            this.pnlFileServer.Text = "Update Server";
            // 
            // btnCameraImagePath
            // 
            this.btnCameraImagePath.Location = new System.Drawing.Point(538, 31);
            this.btnCameraImagePath.Name = "btnCameraImagePath";
            this.btnCameraImagePath.Size = new System.Drawing.Size(75, 23);
            this.btnCameraImagePath.TabIndex = 2;
            this.btnCameraImagePath.Text = "Choose...";
            this.btnCameraImagePath.UseVisualStyleBackColor = true;
            this.btnCameraImagePath.Click += new System.EventHandler(this.btnCameraImagePath_Click);
            // 
            // lblCameraImagePath
            // 
            this.lblCameraImagePath.AutoSize = true;
            this.lblCameraImagePath.Location = new System.Drawing.Point(2, 18);
            this.lblCameraImagePath.Name = "lblCameraImagePath";
            this.lblCameraImagePath.Size = new System.Drawing.Size(162, 13);
            this.lblCameraImagePath.TabIndex = 0;
            this.lblCameraImagePath.Text = "Output Folder for Camera Images";
            // 
            // txtCameraImagePath
            // 
            this.txtCameraImagePath.Location = new System.Drawing.Point(5, 33);
            this.txtCameraImagePath.Name = "txtCameraImagePath";
            this.txtCameraImagePath.ReadOnly = true;
            this.txtCameraImagePath.Size = new System.Drawing.Size(527, 20);
            this.txtCameraImagePath.TabIndex = 1;
            this.txtCameraImagePath.TabStop = false;
            // 
            // lblFileServer
            // 
            this.lblFileServer.AutoEllipsis = true;
            this.lblFileServer.BackColor = System.Drawing.Color.Black;
            this.lblFileServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFileServer.ForeColor = System.Drawing.Color.White;
            this.lblFileServer.Location = new System.Drawing.Point(0, 0);
            this.lblFileServer.Name = "lblFileServer";
            this.lblFileServer.Size = new System.Drawing.Size(616, 17);
            this.lblFileServer.TabIndex = 0;
            this.lblFileServer.Text = "File Server";
            this.lblFileServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabExternalPrograms
            // 
            this.tabExternalPrograms.Controls.Add(this.pnlTeamViewer);
            this.tabExternalPrograms.Controls.Add(this.pnlDashboard);
            this.tabExternalPrograms.Controls.Add(this.pnlVNC);
            this.tabExternalPrograms.Location = new System.Drawing.Point(4, 22);
            this.tabExternalPrograms.Name = "tabExternalPrograms";
            this.tabExternalPrograms.Padding = new System.Windows.Forms.Padding(3);
            this.tabExternalPrograms.Size = new System.Drawing.Size(630, 459);
            this.tabExternalPrograms.TabIndex = 1;
            this.tabExternalPrograms.Text = "External Programs";
            this.tabExternalPrograms.UseVisualStyleBackColor = true;
            // 
            // pnlTeamViewer
            // 
            this.pnlTeamViewer.BackColor = System.Drawing.Color.LightGray;
            this.pnlTeamViewer.Controls.Add(this.lblTeamViewer);
            this.pnlTeamViewer.Controls.Add(this.lblTeamViewerExecutable);
            this.pnlTeamViewer.Controls.Add(this.txtTeamViewerPath);
            this.pnlTeamViewer.Controls.Add(this.btnTeamViewerPathBrowse);
            this.pnlTeamViewer.Location = new System.Drawing.Point(6, 312);
            this.pnlTeamViewer.Name = "pnlTeamViewer";
            this.pnlTeamViewer.Size = new System.Drawing.Size(613, 82);
            this.pnlTeamViewer.TabIndex = 2;
            this.pnlTeamViewer.Text = "VNC";
            // 
            // lblTeamViewer
            // 
            this.lblTeamViewer.AutoEllipsis = true;
            this.lblTeamViewer.BackColor = System.Drawing.Color.Black;
            this.lblTeamViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeamViewer.ForeColor = System.Drawing.Color.White;
            this.lblTeamViewer.Location = new System.Drawing.Point(0, 0);
            this.lblTeamViewer.Name = "lblTeamViewer";
            this.lblTeamViewer.Size = new System.Drawing.Size(613, 17);
            this.lblTeamViewer.TabIndex = 0;
            this.lblTeamViewer.Text = "TeamViewer";
            this.lblTeamViewer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeamViewerExecutable
            // 
            this.lblTeamViewerExecutable.AutoSize = true;
            this.lblTeamViewerExecutable.Location = new System.Drawing.Point(3, 18);
            this.lblTeamViewerExecutable.Name = "lblTeamViewerExecutable";
            this.lblTeamViewerExecutable.Size = new System.Drawing.Size(161, 13);
            this.lblTeamViewerExecutable.TabIndex = 1;
            this.lblTeamViewerExecutable.Text = "Path to TeamViewer executable:";
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.pnlPrinting);
            this.tabPreferences.Controls.Add(this.pnlVisual);
            this.tabPreferences.Controls.Add(this.pnlNotifications);
            this.tabPreferences.Controls.Add(this.pnlStartupOptions);
            this.tabPreferences.Location = new System.Drawing.Point(4, 22);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreferences.Size = new System.Drawing.Size(630, 459);
            this.tabPreferences.TabIndex = 2;
            this.tabPreferences.Text = "Preferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // pnlPrinting
            // 
            this.pnlPrinting.BackColor = System.Drawing.Color.LightGray;
            this.pnlPrinting.Controls.Add(this.lblRMA_ZoneLabel_PrinterName);
            this.pnlPrinting.Controls.Add(this.cmbRMA_ZoneLabel_PrinterName);
            this.pnlPrinting.Controls.Add(this.lblRMA_BinLabel_PrinterName);
            this.pnlPrinting.Controls.Add(this.cmbRMA_BinLabel_PrinterName);
            this.pnlPrinting.Controls.Add(this.lblPrinting);
            this.pnlPrinting.Location = new System.Drawing.Point(5, 297);
            this.pnlPrinting.Name = "pnlPrinting";
            this.pnlPrinting.Size = new System.Drawing.Size(616, 104);
            this.pnlPrinting.TabIndex = 3;
            this.pnlPrinting.Text = "Notifications and Subscriptions";
            // 
            // lblRMA_ZoneLabel_PrinterName
            // 
            this.lblRMA_ZoneLabel_PrinterName.AutoSize = true;
            this.lblRMA_ZoneLabel_PrinterName.Location = new System.Drawing.Point(50, 50);
            this.lblRMA_ZoneLabel_PrinterName.Name = "lblRMA_ZoneLabel_PrinterName";
            this.lblRMA_ZoneLabel_PrinterName.Size = new System.Drawing.Size(121, 13);
            this.lblRMA_ZoneLabel_PrinterName.TabIndex = 2;
            this.lblRMA_ZoneLabel_PrinterName.Text = "RMA Zone Label Printer";
            // 
            // cmbRMA_ZoneLabel_PrinterName
            // 
            this.cmbRMA_ZoneLabel_PrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRMA_ZoneLabel_PrinterName.FormattingEnabled = true;
            this.cmbRMA_ZoneLabel_PrinterName.Location = new System.Drawing.Point(177, 47);
            this.cmbRMA_ZoneLabel_PrinterName.Name = "cmbRMA_ZoneLabel_PrinterName";
            this.cmbRMA_ZoneLabel_PrinterName.Size = new System.Drawing.Size(266, 21);
            this.cmbRMA_ZoneLabel_PrinterName.TabIndex = 3;
            // 
            // lblRMA_BinLabel_PrinterName
            // 
            this.lblRMA_BinLabel_PrinterName.AutoSize = true;
            this.lblRMA_BinLabel_PrinterName.Location = new System.Drawing.Point(57, 23);
            this.lblRMA_BinLabel_PrinterName.Name = "lblRMA_BinLabel_PrinterName";
            this.lblRMA_BinLabel_PrinterName.Size = new System.Drawing.Size(111, 13);
            this.lblRMA_BinLabel_PrinterName.TabIndex = 0;
            this.lblRMA_BinLabel_PrinterName.Text = "RMA Bin Label Printer";
            // 
            // cmbRMA_BinLabel_PrinterName
            // 
            this.cmbRMA_BinLabel_PrinterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRMA_BinLabel_PrinterName.FormattingEnabled = true;
            this.cmbRMA_BinLabel_PrinterName.Location = new System.Drawing.Point(177, 20);
            this.cmbRMA_BinLabel_PrinterName.Name = "cmbRMA_BinLabel_PrinterName";
            this.cmbRMA_BinLabel_PrinterName.Size = new System.Drawing.Size(266, 21);
            this.cmbRMA_BinLabel_PrinterName.TabIndex = 1;
            // 
            // lblPrinting
            // 
            this.lblPrinting.AutoEllipsis = true;
            this.lblPrinting.BackColor = System.Drawing.Color.Black;
            this.lblPrinting.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrinting.ForeColor = System.Drawing.Color.White;
            this.lblPrinting.Location = new System.Drawing.Point(0, 0);
            this.lblPrinting.Name = "lblPrinting";
            this.lblPrinting.Size = new System.Drawing.Size(616, 17);
            this.lblPrinting.TabIndex = 0;
            this.lblPrinting.Text = "Printing";
            this.lblPrinting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(662, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.pnlServer.ResumeLayout(false);
            this.pnlServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServer_Timeout)).EndInit();
            this.pnlStartupOptions.ResumeLayout(false);
            this.pnlStartupOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVNCTimeout)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlUpdateServer.ResumeLayout(false);
            this.pnlUpdateServer.PerformLayout();
            this.pnlVisual.ResumeLayout(false);
            this.pnlVisual.PerformLayout();
            this.pnlVNC.ResumeLayout(false);
            this.pnlVNC.PerformLayout();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabServers.ResumeLayout(false);
            this.pnlFileServer.ResumeLayout(false);
            this.pnlFileServer.PerformLayout();
            this.tabExternalPrograms.ResumeLayout(false);
            this.pnlTeamViewer.ResumeLayout(false);
            this.pnlTeamViewer.PerformLayout();
            this.tabPreferences.ResumeLayout(false);
            this.pnlPrinting.ResumeLayout(false);
            this.pnlPrinting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlServer;
		private System.Windows.Forms.Panel pnlStartupOptions;
		private System.Windows.Forms.Panel pnlEmail;
		private System.Windows.Forms.Panel pnlDashboard;
		private System.Windows.Forms.Panel pnlUpdateServer;
		private System.Windows.Forms.Panel pnlVisual;
		private System.Windows.Forms.Panel pnlVNC;
		private System.Windows.Forms.Panel pnlNotifications;
		private System.Windows.Forms.TextBox txtEmail_Server;
        private System.Windows.Forms.TextBox txtServer_Server;
        private System.Windows.Forms.Label lblEmail_Server;
        private System.Windows.Forms.Label lblServer_Server;
        private System.Windows.Forms.RadioButton radStartupScreen_RMA;
        private System.Windows.Forms.RadioButton radStartupScreen_Reports;
        private System.Windows.Forms.RadioButton radStartupScreen_Tracker;
		private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail_Password;
        private System.Windows.Forms.TextBox txtEmail_User;
        private System.Windows.Forms.Label lblEmail_Password;
        private System.Windows.Forms.Label lblEmail_User;
		private System.Windows.Forms.CheckBox chkEmail_UseSSL;
		private System.Windows.Forms.Label lblEmail_ServerPort;
		private System.Windows.Forms.TextBox txtEmail_ServerPort;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblStartupScreen;
		private System.Windows.Forms.TextBox txtServer_User;
		private System.Windows.Forms.Label lblServer_User;
		private System.Windows.Forms.TextBox txtServer_Password;
		private System.Windows.Forms.Label lblServer_Password;
		private System.Windows.Forms.TextBox txtDashboardURL;
		private System.Windows.Forms.Label lblDashboardURL;
		private System.Windows.Forms.Label lblVNCPath;
		private System.Windows.Forms.Button btnVNCPathBrowse;
		private System.Windows.Forms.TextBox txtVNCPath;
		private System.Windows.Forms.Label lblDefaultMapZoomLevel;
		private System.Windows.Forms.ComboBox cmbDefaultMapZoomLevel;
		private System.Windows.Forms.NumericUpDown numVNCTimeout;
		private System.Windows.Forms.Label lblVNCTimeout;
		private System.Windows.Forms.Label lblVNCTimeoutSeconds;
		private System.Windows.Forms.TextBox txtDBName_Monitoring;
		private System.Windows.Forms.TextBox txtDBName_Service;
		private System.Windows.Forms.Label lblDBName_Monitoring;
		private System.Windows.Forms.Label lblDBName_Service;
		private System.Windows.Forms.Label lblServer_Timeout;
		private System.Windows.Forms.Label lblServer_TimeoutSeconds;
		private System.Windows.Forms.NumericUpDown numServer_Timeout;
		private System.Windows.Forms.TextBox txtVNCPasswordWindowTitle;
		private System.Windows.Forms.Label lblVNCPasswordWindowTitle;
		private System.Windows.Forms.TextBox txtServer_Update;
		private System.Windows.Forms.Label lblUpdateServerRepeat;
		private System.Windows.Forms.RadioButton radStartupScreen_Shipments;
		private System.Windows.Forms.CheckBox chkAutoSubscribe_Modify;
		private System.Windows.Forms.CheckBox chkAutoSubscribe_Create;
		private System.Windows.Forms.Label lblDatabaseServer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblEmailServer;
		private System.Windows.Forms.Label lblDashboard;
		private System.Windows.Forms.Label lblUpdateServer;
		private System.Windows.Forms.Label lblVisual;
		private System.Windows.Forms.Label lblVNC;
		private System.Windows.Forms.Label lblNotifications;
		private System.Windows.Forms.TextBox txtJournalFont;
		private System.Windows.Forms.Button btnJournalFont_Change;
		private System.Windows.Forms.Label lblJournalFont;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabServers;
		private System.Windows.Forms.TabPage tabExternalPrograms;
		private System.Windows.Forms.Panel pnlTeamViewer;
		private System.Windows.Forms.Label lblTeamViewer;
		private System.Windows.Forms.Label lblTeamViewerExecutable;
		private System.Windows.Forms.TextBox txtTeamViewerPath;
		private System.Windows.Forms.Button btnTeamViewerPathBrowse;
		private System.Windows.Forms.TabPage tabPreferences;
		private System.Windows.Forms.Panel pnlPrinting;
		private System.Windows.Forms.Label lblRMA_BinLabel_PrinterName;
		private System.Windows.Forms.ComboBox cmbRMA_BinLabel_PrinterName;
		private System.Windows.Forms.Label lblPrinting;
		private System.Windows.Forms.Label lblRMA_ZoneLabel_PrinterName;
		private System.Windows.Forms.ComboBox cmbRMA_ZoneLabel_PrinterName;
		private System.Windows.Forms.Panel pnlFileServer;
		private System.Windows.Forms.Button btnCameraImagePath;
		private System.Windows.Forms.Label lblCameraImagePath;
		private System.Windows.Forms.TextBox txtCameraImagePath;
		private System.Windows.Forms.Label lblFileServer;
		private System.Windows.Forms.CheckBox chkCameraCheckEnable;
        private System.Windows.Forms.RadioButton radStartupScreen_MagicInfo;
        private System.Windows.Forms.TextBox tbxSamsungDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRealVNCPath;
        private System.Windows.Forms.Button btnRealVNCEXE;
    }
}