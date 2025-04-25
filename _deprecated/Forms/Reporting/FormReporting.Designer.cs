using SDB.Classes.Misc;

namespace SDB.Forms.Reporting
{
	partial class FormReporting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting));
			this.grpType = new System.Windows.Forms.GroupBox();
			this.lblReportDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblAccountingReports = new System.Windows.Forms.Label();
			this.lstAccountingReports = new System.Windows.Forms.ListBox();
			this.lblRMAReports = new System.Windows.Forms.Label();
			this.lstRMAReports = new System.Windows.Forms.ListBox();
			this.lblTicketReports = new System.Windows.Forms.Label();
			this.lstTicketReports = new System.Windows.Forms.ListBox();
			this.lblSymptomReports = new System.Windows.Forms.Label();
			this.lstSymptomReports = new System.Windows.Forms.ListBox();
			this.grpParameters = new System.Windows.Forms.GroupBox();
			this.tabControl_ReportOptions = new System.Windows.Forms.TabControl();
			this.tabDates = new System.Windows.Forms.TabPage();
			this.pnlOptions_Dates = new System.Windows.Forms.Panel();
			this.pnlDates = new System.Windows.Forms.Panel();
			this.btnShortcut_Within30Days = new System.Windows.Forms.Button();
			this.btnShortcut_Within90Days = new System.Windows.Forms.Button();
			this.btnShortcut_Within60Days = new System.Windows.Forms.Button();
			this.btnShortcut_90PlusDays = new System.Windows.Forms.Button();
			this.btnShortcut_60PlusDays = new System.Windows.Forms.Button();
			this.ndtpDateFrom = new SDB.Classes.Misc.NullableDateTimePicker();
			this.ndtpDateTo = new SDB.Classes.Misc.NullableDateTimePicker();
			this.btnShortcut_Quarter = new System.Windows.Forms.Button();
			this.btnShortcut_Week = new System.Windows.Forms.Button();
			this.btnShortcut_30PlusDays = new System.Windows.Forms.Button();
			this.btnShortcut_Month = new System.Windows.Forms.Button();
			this.btnShortcut_Year = new System.Windows.Forms.Button();
			this.btnShortcut_Today = new System.Windows.Forms.Button();
			this.lblDateRange_To = new System.Windows.Forms.Label();
			this.lblDateRange_Shortcuts = new System.Windows.Forms.Label();
			this.chkAnyDate = new System.Windows.Forms.CheckBox();
			this.tabCustomers = new System.Windows.Forms.TabPage();
			this.pnlOptions_Customer = new System.Windows.Forms.Panel();
			this.chkAllCustomers = new System.Windows.Forms.CheckBox();
			this.lstCustomers = new System.Windows.Forms.ListBox();
			this.tabAssets = new System.Windows.Forms.TabPage();
			this.pnlOptions_Asset = new System.Windows.Forms.Panel();
			this.chkAllAssets = new System.Windows.Forms.CheckBox();
			this.lstAssets = new System.Windows.Forms.ListBox();
			this.tabTechs = new System.Windows.Forms.TabPage();
			this.pnlOptions_Tech = new System.Windows.Forms.Panel();
			this.chkAllTechs = new System.Windows.Forms.CheckBox();
			this.lstTechs = new System.Windows.Forms.ListBox();
			this.tabTicket = new System.Windows.Forms.TabPage();
			this.pnlOptions_Ticket = new System.Windows.Forms.Panel();
			this.chkTicketOptions_DurationHours = new System.Windows.Forms.CheckBox();
			this.chkTicketOptions_AllSolutions = new System.Windows.Forms.CheckBox();
			this.numTicketOptions_DurationHours = new System.Windows.Forms.NumericUpDown();
			this.chkTicketOptions_AllSymptoms = new System.Windows.Forms.CheckBox();
			this.lblTicketOptions_DurationHours = new System.Windows.Forms.Label();
			this.lstTicketSolutions = new System.Windows.Forms.ListBox();
			this.chkTicketOptions_Open = new System.Windows.Forms.CheckBox();
			this.lstTicketSymptoms = new System.Windows.Forms.ListBox();
			this.chkTicketOptions_Held = new System.Windows.Forms.CheckBox();
			this.chkTicketOptions_Closed = new System.Windows.Forms.CheckBox();
			this.tabRMA = new System.Windows.Forms.TabPage();
			this.pnlOptions_RMA = new System.Windows.Forms.Panel();
			this.chkRMAOptions_Pending = new System.Windows.Forms.CheckBox();
			this.chkRMAOptions_RootCauses = new System.Windows.Forms.CheckBox();
			this.lstRMAOptions_RootCauses = new System.Windows.Forms.ListBox();
			this.chkRMAOptions_RepairTypes = new System.Windows.Forms.CheckBox();
			this.lstRMAOptions_RepairTypes = new System.Windows.Forms.ListBox();
			this.chkRMAOptions_FailureTypes = new System.Windows.Forms.CheckBox();
			this.lstRMAOptions_FailureTypes = new System.Windows.Forms.ListBox();
			this.chkRMAOptions_AssemblyTypes = new System.Windows.Forms.CheckBox();
			this.lstRMAOptions_AssemblyTypes = new System.Windows.Forms.ListBox();
			this.chkRMAOptions_Finalized = new System.Windows.Forms.CheckBox();
			this.chkRMAOptions_Unreceived = new System.Windows.Forms.CheckBox();
			this.chkRMAOptions_Completed = new System.Windows.Forms.CheckBox();
			this.chkRMAOptions_Received = new System.Windows.Forms.CheckBox();
			this.chkRMAOptions_InProgress = new System.Windows.Forms.CheckBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblSeparator = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnReset = new System.Windows.Forms.Button();
			this.grpType.SuspendLayout();
			this.grpParameters.SuspendLayout();
			this.tabControl_ReportOptions.SuspendLayout();
			this.tabDates.SuspendLayout();
			this.pnlOptions_Dates.SuspendLayout();
			this.pnlDates.SuspendLayout();
			this.tabCustomers.SuspendLayout();
			this.pnlOptions_Customer.SuspendLayout();
			this.tabAssets.SuspendLayout();
			this.pnlOptions_Asset.SuspendLayout();
			this.tabTechs.SuspendLayout();
			this.pnlOptions_Tech.SuspendLayout();
			this.tabTicket.SuspendLayout();
			this.pnlOptions_Ticket.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTicketOptions_DurationHours)).BeginInit();
			this.tabRMA.SuspendLayout();
			this.pnlOptions_RMA.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpType
			// 
			this.grpType.Controls.Add(this.lblReportDescription);
			this.grpType.Controls.Add(this.txtDescription);
			this.grpType.Controls.Add(this.lblAccountingReports);
			this.grpType.Controls.Add(this.lstAccountingReports);
			this.grpType.Controls.Add(this.lblRMAReports);
			this.grpType.Controls.Add(this.lstRMAReports);
			this.grpType.Controls.Add(this.lblTicketReports);
			this.grpType.Controls.Add(this.lstTicketReports);
			this.grpType.Controls.Add(this.lblSymptomReports);
			this.grpType.Controls.Add(this.lstSymptomReports);
			this.grpType.Location = new System.Drawing.Point(12, 12);
			this.grpType.Name = "grpType";
			this.grpType.Size = new System.Drawing.Size(319, 575);
			this.grpType.TabIndex = 0;
			this.grpType.TabStop = false;
			this.grpType.Text = "Report Type";
			// 
			// lblReportDescription
			// 
			this.lblReportDescription.AutoSize = true;
			this.lblReportDescription.Location = new System.Drawing.Point(6, 16);
			this.lblReportDescription.Name = "lblReportDescription";
			this.lblReportDescription.Size = new System.Drawing.Size(60, 13);
			this.lblReportDescription.TabIndex = 8;
			this.lblReportDescription.Text = "Description";
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(6, 32);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(304, 84);
			this.txtDescription.TabIndex = 0;
			this.txtDescription.TabStop = false;
			this.txtDescription.Text = "Select a report type below.";
			// 
			// lblAccountingReports
			// 
			this.lblAccountingReports.AutoSize = true;
			this.lblAccountingReports.Location = new System.Drawing.Point(6, 458);
			this.lblAccountingReports.Name = "lblAccountingReports";
			this.lblAccountingReports.Size = new System.Drawing.Size(101, 13);
			this.lblAccountingReports.TabIndex = 7;
			this.lblAccountingReports.Text = "Accounting Reports";
			// 
			// lstAccountingReports
			// 
			this.lstAccountingReports.FormattingEnabled = true;
			this.lstAccountingReports.Location = new System.Drawing.Point(6, 471);
			this.lstAccountingReports.Name = "lstAccountingReports";
			this.lstAccountingReports.Size = new System.Drawing.Size(304, 95);
			this.lstAccountingReports.TabIndex = 6;
			this.lstAccountingReports.SelectedIndexChanged += new System.EventHandler(this.lstAccountingReports_SelectedIndexChanged);
			this.lstAccountingReports.DoubleClick += new System.EventHandler(this.lstReportList_DoubleClick);
			// 
			// lblRMAReports
			// 
			this.lblRMAReports.AutoSize = true;
			this.lblRMAReports.Location = new System.Drawing.Point(6, 346);
			this.lblRMAReports.Name = "lblRMAReports";
			this.lblRMAReports.Size = new System.Drawing.Size(71, 13);
			this.lblRMAReports.TabIndex = 5;
			this.lblRMAReports.Text = "RMA Reports";
			// 
			// lstRMAReports
			// 
			this.lstRMAReports.FormattingEnabled = true;
			this.lstRMAReports.Location = new System.Drawing.Point(6, 359);
			this.lstRMAReports.Name = "lstRMAReports";
			this.lstRMAReports.Size = new System.Drawing.Size(304, 95);
			this.lstRMAReports.TabIndex = 4;
			this.lstRMAReports.SelectedIndexChanged += new System.EventHandler(this.lstRMAReports_SelectedIndexChanged);
			this.lstRMAReports.DoubleClick += new System.EventHandler(this.lstReportList_DoubleClick);
			// 
			// lblTicketReports
			// 
			this.lblTicketReports.AutoSize = true;
			this.lblTicketReports.Location = new System.Drawing.Point(6, 234);
			this.lblTicketReports.Name = "lblTicketReports";
			this.lblTicketReports.Size = new System.Drawing.Size(109, 13);
			this.lblTicketReports.TabIndex = 3;
			this.lblTicketReports.Text = "Ticket-based Reports";
			// 
			// lstTicketReports
			// 
			this.lstTicketReports.FormattingEnabled = true;
			this.lstTicketReports.Location = new System.Drawing.Point(6, 247);
			this.lstTicketReports.Name = "lstTicketReports";
			this.lstTicketReports.Size = new System.Drawing.Size(304, 95);
			this.lstTicketReports.TabIndex = 2;
			this.lstTicketReports.SelectedIndexChanged += new System.EventHandler(this.lstTicketReports_SelectedIndexChanged);
			this.lstTicketReports.DoubleClick += new System.EventHandler(this.lstReportList_DoubleClick);
			// 
			// lblSymptomReports
			// 
			this.lblSymptomReports.AutoSize = true;
			this.lblSymptomReports.Location = new System.Drawing.Point(6, 122);
			this.lblSymptomReports.Name = "lblSymptomReports";
			this.lblSymptomReports.Size = new System.Drawing.Size(127, 13);
			this.lblSymptomReports.TabIndex = 1;
			this.lblSymptomReports.Text = "Symptoms-based Reports";
			// 
			// lstSymptomReports
			// 
			this.lstSymptomReports.FormattingEnabled = true;
			this.lstSymptomReports.Location = new System.Drawing.Point(6, 135);
			this.lstSymptomReports.Name = "lstSymptomReports";
			this.lstSymptomReports.Size = new System.Drawing.Size(304, 95);
			this.lstSymptomReports.TabIndex = 0;
			this.lstSymptomReports.SelectedIndexChanged += new System.EventHandler(this.lstSymptomReports_SelectedIndexChanged);
			this.lstSymptomReports.DoubleClick += new System.EventHandler(this.lstReportList_DoubleClick);
			// 
			// grpParameters
			// 
			this.grpParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpParameters.Controls.Add(this.tabControl_ReportOptions);
			this.grpParameters.Location = new System.Drawing.Point(337, 12);
			this.grpParameters.Name = "grpParameters";
			this.grpParameters.Size = new System.Drawing.Size(577, 525);
			this.grpParameters.TabIndex = 1;
			this.grpParameters.TabStop = false;
			this.grpParameters.Text = "Report Parameters";
			// 
			// tabControl_ReportOptions
			// 
			this.tabControl_ReportOptions.Controls.Add(this.tabDates);
			this.tabControl_ReportOptions.Controls.Add(this.tabCustomers);
			this.tabControl_ReportOptions.Controls.Add(this.tabAssets);
			this.tabControl_ReportOptions.Controls.Add(this.tabTechs);
			this.tabControl_ReportOptions.Controls.Add(this.tabTicket);
			this.tabControl_ReportOptions.Controls.Add(this.tabRMA);
			this.tabControl_ReportOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_ReportOptions.Location = new System.Drawing.Point(3, 16);
			this.tabControl_ReportOptions.Name = "tabControl_ReportOptions";
			this.tabControl_ReportOptions.SelectedIndex = 0;
			this.tabControl_ReportOptions.Size = new System.Drawing.Size(571, 506);
			this.tabControl_ReportOptions.TabIndex = 0;
			// 
			// tabDates
			// 
			this.tabDates.Controls.Add(this.pnlOptions_Dates);
			this.tabDates.Location = new System.Drawing.Point(4, 22);
			this.tabDates.Name = "tabDates";
			this.tabDates.Padding = new System.Windows.Forms.Padding(3);
			this.tabDates.Size = new System.Drawing.Size(563, 480);
			this.tabDates.TabIndex = 0;
			this.tabDates.Text = "Dates";
			this.tabDates.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_Dates
			// 
			this.pnlOptions_Dates.Controls.Add(this.pnlDates);
			this.pnlOptions_Dates.Controls.Add(this.chkAnyDate);
			this.pnlOptions_Dates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_Dates.Enabled = false;
			this.pnlOptions_Dates.Location = new System.Drawing.Point(3, 3);
			this.pnlOptions_Dates.Name = "pnlOptions_Dates";
			this.pnlOptions_Dates.Size = new System.Drawing.Size(557, 474);
			this.pnlOptions_Dates.TabIndex = 1;
			// 
			// pnlDates
			// 
			this.pnlDates.Controls.Add(this.btnShortcut_Within30Days);
			this.pnlDates.Controls.Add(this.btnShortcut_Within90Days);
			this.pnlDates.Controls.Add(this.btnShortcut_Within60Days);
			this.pnlDates.Controls.Add(this.btnShortcut_90PlusDays);
			this.pnlDates.Controls.Add(this.btnShortcut_60PlusDays);
			this.pnlDates.Controls.Add(this.ndtpDateFrom);
			this.pnlDates.Controls.Add(this.ndtpDateTo);
			this.pnlDates.Controls.Add(this.btnShortcut_Quarter);
			this.pnlDates.Controls.Add(this.btnShortcut_Week);
			this.pnlDates.Controls.Add(this.btnShortcut_30PlusDays);
			this.pnlDates.Controls.Add(this.btnShortcut_Month);
			this.pnlDates.Controls.Add(this.btnShortcut_Year);
			this.pnlDates.Controls.Add(this.btnShortcut_Today);
			this.pnlDates.Controls.Add(this.lblDateRange_To);
			this.pnlDates.Controls.Add(this.lblDateRange_Shortcuts);
			this.pnlDates.Location = new System.Drawing.Point(3, 26);
			this.pnlDates.Name = "pnlDates";
			this.pnlDates.Size = new System.Drawing.Size(382, 128);
			this.pnlDates.TabIndex = 0;
			// 
			// btnShortcut_Within30Days
			// 
			this.btnShortcut_Within30Days.Location = new System.Drawing.Point(35, 72);
			this.btnShortcut_Within30Days.Name = "btnShortcut_Within30Days";
			this.btnShortcut_Within30Days.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_Within30Days.TabIndex = 9;
			this.btnShortcut_Within30Days.Text = "Within 30 Days";
			this.btnShortcut_Within30Days.UseVisualStyleBackColor = true;
			this.btnShortcut_Within30Days.Click += new System.EventHandler(this.btnShortcut_Within30Days_Click);
			// 
			// btnShortcut_Within90Days
			// 
			this.btnShortcut_Within90Days.Location = new System.Drawing.Point(265, 72);
			this.btnShortcut_Within90Days.Name = "btnShortcut_Within90Days";
			this.btnShortcut_Within90Days.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_Within90Days.TabIndex = 11;
			this.btnShortcut_Within90Days.Text = "Within 90 Days";
			this.btnShortcut_Within90Days.UseVisualStyleBackColor = true;
			this.btnShortcut_Within90Days.Click += new System.EventHandler(this.btnShortcut_Within90Days_Click);
			// 
			// btnShortcut_Within60Days
			// 
			this.btnShortcut_Within60Days.Location = new System.Drawing.Point(150, 72);
			this.btnShortcut_Within60Days.Name = "btnShortcut_Within60Days";
			this.btnShortcut_Within60Days.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_Within60Days.TabIndex = 10;
			this.btnShortcut_Within60Days.Text = "Within 60 Days";
			this.btnShortcut_Within60Days.UseVisualStyleBackColor = true;
			this.btnShortcut_Within60Days.Click += new System.EventHandler(this.btnShortcut_Within60Days_Click);
			// 
			// btnShortcut_90PlusDays
			// 
			this.btnShortcut_90PlusDays.Location = new System.Drawing.Point(265, 101);
			this.btnShortcut_90PlusDays.Name = "btnShortcut_90PlusDays";
			this.btnShortcut_90PlusDays.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_90PlusDays.TabIndex = 14;
			this.btnShortcut_90PlusDays.Text = "Older than 90";
			this.toolTip1.SetToolTip(this.btnShortcut_90PlusDays, "Older than 90 days");
			this.btnShortcut_90PlusDays.UseVisualStyleBackColor = true;
			this.btnShortcut_90PlusDays.Click += new System.EventHandler(this.btnShortcut_90PlusDays_Click);
			// 
			// btnShortcut_60PlusDays
			// 
			this.btnShortcut_60PlusDays.Location = new System.Drawing.Point(150, 101);
			this.btnShortcut_60PlusDays.Name = "btnShortcut_60PlusDays";
			this.btnShortcut_60PlusDays.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_60PlusDays.TabIndex = 13;
			this.btnShortcut_60PlusDays.Text = "Older than 60";
			this.toolTip1.SetToolTip(this.btnShortcut_60PlusDays, "Older than 60 days");
			this.btnShortcut_60PlusDays.UseVisualStyleBackColor = true;
			this.btnShortcut_60PlusDays.Click += new System.EventHandler(this.btnShortcut_60PlusDays_Click);
			// 
			// ndtpDateFrom
			// 
			this.ndtpDateFrom.CustomFormat = "yyyy-MM-dd";
			this.ndtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpDateFrom.Location = new System.Drawing.Point(35, 4);
			this.ndtpDateFrom.Name = "ndtpDateFrom";
			this.ndtpDateFrom.Size = new System.Drawing.Size(107, 20);
			this.ndtpDateFrom.TabIndex = 0;
			this.ndtpDateFrom.Value = new System.DateTime(2012, 1, 16, 10, 58, 59, 161);
			this.ndtpDateFrom.ValueChanged += new System.EventHandler(this.ndtpDateFrom_ValueChanged);
			// 
			// ndtpDateTo
			// 
			this.ndtpDateTo.CustomFormat = "yyyy-MM-dd";
			this.ndtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpDateTo.Location = new System.Drawing.Point(170, 4);
			this.ndtpDateTo.Name = "ndtpDateTo";
			this.ndtpDateTo.Size = new System.Drawing.Size(107, 20);
			this.ndtpDateTo.TabIndex = 2;
			this.ndtpDateTo.Value = new System.DateTime(2012, 1, 16, 10, 58, 59, 161);
			this.ndtpDateTo.ValueChanged += new System.EventHandler(this.ndtpDateTo_ValueChanged);
			// 
			// btnShortcut_Quarter
			// 
			this.btnShortcut_Quarter.Location = new System.Drawing.Point(233, 43);
			this.btnShortcut_Quarter.Name = "btnShortcut_Quarter";
			this.btnShortcut_Quarter.Size = new System.Drawing.Size(60, 23);
			this.btnShortcut_Quarter.TabIndex = 7;
			this.btnShortcut_Quarter.Text = "Quarter";
			this.toolTip1.SetToolTip(this.btnShortcut_Quarter, "This Quarter");
			this.btnShortcut_Quarter.UseVisualStyleBackColor = true;
			this.btnShortcut_Quarter.Click += new System.EventHandler(this.btnShortcut_Quarter_Click);
			// 
			// btnShortcut_Week
			// 
			this.btnShortcut_Week.Location = new System.Drawing.Point(101, 43);
			this.btnShortcut_Week.Name = "btnShortcut_Week";
			this.btnShortcut_Week.Size = new System.Drawing.Size(60, 23);
			this.btnShortcut_Week.TabIndex = 5;
			this.btnShortcut_Week.Text = "Week";
			this.toolTip1.SetToolTip(this.btnShortcut_Week, "Past Week");
			this.btnShortcut_Week.UseVisualStyleBackColor = true;
			this.btnShortcut_Week.Click += new System.EventHandler(this.btnShortcut_Week_Click);
			// 
			// btnShortcut_30PlusDays
			// 
			this.btnShortcut_30PlusDays.Location = new System.Drawing.Point(35, 101);
			this.btnShortcut_30PlusDays.Name = "btnShortcut_30PlusDays";
			this.btnShortcut_30PlusDays.Size = new System.Drawing.Size(94, 23);
			this.btnShortcut_30PlusDays.TabIndex = 12;
			this.btnShortcut_30PlusDays.Text = "Older than 30";
			this.toolTip1.SetToolTip(this.btnShortcut_30PlusDays, "Older than 30 days");
			this.btnShortcut_30PlusDays.UseVisualStyleBackColor = true;
			this.btnShortcut_30PlusDays.Click += new System.EventHandler(this.btnShortcut_30PlusDays_Click);
			// 
			// btnShortcut_Month
			// 
			this.btnShortcut_Month.Location = new System.Drawing.Point(167, 43);
			this.btnShortcut_Month.Name = "btnShortcut_Month";
			this.btnShortcut_Month.Size = new System.Drawing.Size(60, 23);
			this.btnShortcut_Month.TabIndex = 6;
			this.btnShortcut_Month.Text = "Month";
			this.toolTip1.SetToolTip(this.btnShortcut_Month, "Past Month");
			this.btnShortcut_Month.UseVisualStyleBackColor = true;
			this.btnShortcut_Month.Click += new System.EventHandler(this.btnShortcut_Month_Click);
			// 
			// btnShortcut_Year
			// 
			this.btnShortcut_Year.Location = new System.Drawing.Point(299, 43);
			this.btnShortcut_Year.Name = "btnShortcut_Year";
			this.btnShortcut_Year.Size = new System.Drawing.Size(60, 23);
			this.btnShortcut_Year.TabIndex = 8;
			this.btnShortcut_Year.Text = "Year";
			this.toolTip1.SetToolTip(this.btnShortcut_Year, "Past Year");
			this.btnShortcut_Year.UseVisualStyleBackColor = true;
			this.btnShortcut_Year.Click += new System.EventHandler(this.btnShortcut_Year_Click);
			// 
			// btnShortcut_Today
			// 
			this.btnShortcut_Today.Location = new System.Drawing.Point(35, 43);
			this.btnShortcut_Today.Name = "btnShortcut_Today";
			this.btnShortcut_Today.Size = new System.Drawing.Size(60, 23);
			this.btnShortcut_Today.TabIndex = 4;
			this.btnShortcut_Today.Text = "Today";
			this.btnShortcut_Today.UseVisualStyleBackColor = true;
			this.btnShortcut_Today.Click += new System.EventHandler(this.btnShortcut_Today_Click);
			// 
			// lblDateRange_To
			// 
			this.lblDateRange_To.AutoSize = true;
			this.lblDateRange_To.Location = new System.Drawing.Point(148, 10);
			this.lblDateRange_To.Name = "lblDateRange_To";
			this.lblDateRange_To.Size = new System.Drawing.Size(16, 13);
			this.lblDateRange_To.TabIndex = 1;
			this.lblDateRange_To.Text = "to";
			// 
			// lblDateRange_Shortcuts
			// 
			this.lblDateRange_Shortcuts.AutoSize = true;
			this.lblDateRange_Shortcuts.Location = new System.Drawing.Point(32, 27);
			this.lblDateRange_Shortcuts.Name = "lblDateRange_Shortcuts";
			this.lblDateRange_Shortcuts.Size = new System.Drawing.Size(116, 13);
			this.lblDateRange_Shortcuts.TabIndex = 3;
			this.lblDateRange_Shortcuts.Text = "Date Range Shortcuts:";
			// 
			// chkAnyDate
			// 
			this.chkAnyDate.AutoSize = true;
			this.chkAnyDate.Location = new System.Drawing.Point(3, 3);
			this.chkAnyDate.Name = "chkAnyDate";
			this.chkAnyDate.Size = new System.Drawing.Size(70, 17);
			this.chkAnyDate.TabIndex = 9;
			this.chkAnyDate.Text = "Any Date";
			this.chkAnyDate.UseVisualStyleBackColor = true;
			this.chkAnyDate.CheckedChanged += new System.EventHandler(this.chkAnyDate_CheckedChanged);
			// 
			// tabCustomers
			// 
			this.tabCustomers.Controls.Add(this.pnlOptions_Customer);
			this.tabCustomers.Location = new System.Drawing.Point(4, 22);
			this.tabCustomers.Name = "tabCustomers";
			this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
			this.tabCustomers.Size = new System.Drawing.Size(563, 480);
			this.tabCustomers.TabIndex = 1;
			this.tabCustomers.Text = "Customers";
			this.tabCustomers.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_Customer
			// 
			this.pnlOptions_Customer.Controls.Add(this.chkAllCustomers);
			this.pnlOptions_Customer.Controls.Add(this.lstCustomers);
			this.pnlOptions_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_Customer.Enabled = false;
			this.pnlOptions_Customer.Location = new System.Drawing.Point(3, 3);
			this.pnlOptions_Customer.Name = "pnlOptions_Customer";
			this.pnlOptions_Customer.Size = new System.Drawing.Size(557, 474);
			this.pnlOptions_Customer.TabIndex = 3;
			// 
			// chkAllCustomers
			// 
			this.chkAllCustomers.AutoSize = true;
			this.chkAllCustomers.Checked = true;
			this.chkAllCustomers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAllCustomers.Location = new System.Drawing.Point(3, 3);
			this.chkAllCustomers.Name = "chkAllCustomers";
			this.chkAllCustomers.Size = new System.Drawing.Size(89, 17);
			this.chkAllCustomers.TabIndex = 0;
			this.chkAllCustomers.Text = "All Customers";
			this.chkAllCustomers.UseVisualStyleBackColor = true;
			this.chkAllCustomers.CheckedChanged += new System.EventHandler(this.chkAllCustomers_CheckedChanged);
			// 
			// lstCustomers
			// 
			this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstCustomers.Enabled = false;
			this.lstCustomers.FormattingEnabled = true;
			this.lstCustomers.Location = new System.Drawing.Point(157, 0);
			this.lstCustomers.Name = "lstCustomers";
			this.lstCustomers.ScrollAlwaysVisible = true;
			this.lstCustomers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstCustomers.Size = new System.Drawing.Size(400, 474);
			this.lstCustomers.TabIndex = 2;
			this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
			// 
			// tabAssets
			// 
			this.tabAssets.Controls.Add(this.pnlOptions_Asset);
			this.tabAssets.Location = new System.Drawing.Point(4, 22);
			this.tabAssets.Name = "tabAssets";
			this.tabAssets.Size = new System.Drawing.Size(563, 480);
			this.tabAssets.TabIndex = 2;
			this.tabAssets.Text = "Assets";
			this.tabAssets.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_Asset
			// 
			this.pnlOptions_Asset.Controls.Add(this.chkAllAssets);
			this.pnlOptions_Asset.Controls.Add(this.lstAssets);
			this.pnlOptions_Asset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_Asset.Enabled = false;
			this.pnlOptions_Asset.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions_Asset.Name = "pnlOptions_Asset";
			this.pnlOptions_Asset.Size = new System.Drawing.Size(563, 480);
			this.pnlOptions_Asset.TabIndex = 2;
			// 
			// chkAllAssets
			// 
			this.chkAllAssets.AutoSize = true;
			this.chkAllAssets.Checked = true;
			this.chkAllAssets.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAllAssets.Location = new System.Drawing.Point(3, 3);
			this.chkAllAssets.Name = "chkAllAssets";
			this.chkAllAssets.Size = new System.Drawing.Size(71, 17);
			this.chkAllAssets.TabIndex = 0;
			this.chkAllAssets.Text = "All Assets";
			this.chkAllAssets.UseVisualStyleBackColor = true;
			this.chkAllAssets.CheckedChanged += new System.EventHandler(this.chkAllAssets_CheckedChanged);
			// 
			// lstAssets
			// 
			this.lstAssets.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstAssets.Enabled = false;
			this.lstAssets.FormattingEnabled = true;
			this.lstAssets.Location = new System.Drawing.Point(163, 0);
			this.lstAssets.Name = "lstAssets";
			this.lstAssets.ScrollAlwaysVisible = true;
			this.lstAssets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstAssets.Size = new System.Drawing.Size(400, 480);
			this.lstAssets.TabIndex = 1;
			// 
			// tabTechs
			// 
			this.tabTechs.Controls.Add(this.pnlOptions_Tech);
			this.tabTechs.Location = new System.Drawing.Point(4, 22);
			this.tabTechs.Name = "tabTechs";
			this.tabTechs.Size = new System.Drawing.Size(563, 480);
			this.tabTechs.TabIndex = 3;
			this.tabTechs.Text = "Techs";
			this.tabTechs.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_Tech
			// 
			this.pnlOptions_Tech.Controls.Add(this.chkAllTechs);
			this.pnlOptions_Tech.Controls.Add(this.lstTechs);
			this.pnlOptions_Tech.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_Tech.Enabled = false;
			this.pnlOptions_Tech.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions_Tech.Name = "pnlOptions_Tech";
			this.pnlOptions_Tech.Size = new System.Drawing.Size(563, 480);
			this.pnlOptions_Tech.TabIndex = 2;
			// 
			// chkAllTechs
			// 
			this.chkAllTechs.AutoSize = true;
			this.chkAllTechs.Checked = true;
			this.chkAllTechs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAllTechs.Location = new System.Drawing.Point(3, 3);
			this.chkAllTechs.Name = "chkAllTechs";
			this.chkAllTechs.Size = new System.Drawing.Size(70, 17);
			this.chkAllTechs.TabIndex = 0;
			this.chkAllTechs.Text = "All Techs";
			this.chkAllTechs.UseVisualStyleBackColor = true;
			this.chkAllTechs.CheckedChanged += new System.EventHandler(this.chkAllTechs_CheckedChanged);
			// 
			// lstTechs
			// 
			this.lstTechs.Dock = System.Windows.Forms.DockStyle.Right;
			this.lstTechs.Enabled = false;
			this.lstTechs.FormattingEnabled = true;
			this.lstTechs.Location = new System.Drawing.Point(163, 0);
			this.lstTechs.Name = "lstTechs";
			this.lstTechs.ScrollAlwaysVisible = true;
			this.lstTechs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstTechs.Size = new System.Drawing.Size(400, 480);
			this.lstTechs.TabIndex = 1;
			// 
			// tabTicket
			// 
			this.tabTicket.Controls.Add(this.pnlOptions_Ticket);
			this.tabTicket.Location = new System.Drawing.Point(4, 22);
			this.tabTicket.Name = "tabTicket";
			this.tabTicket.Size = new System.Drawing.Size(563, 480);
			this.tabTicket.TabIndex = 4;
			this.tabTicket.Text = "Ticket";
			this.tabTicket.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_Ticket
			// 
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_DurationHours);
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_AllSolutions);
			this.pnlOptions_Ticket.Controls.Add(this.numTicketOptions_DurationHours);
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_AllSymptoms);
			this.pnlOptions_Ticket.Controls.Add(this.lblTicketOptions_DurationHours);
			this.pnlOptions_Ticket.Controls.Add(this.lstTicketSolutions);
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_Open);
			this.pnlOptions_Ticket.Controls.Add(this.lstTicketSymptoms);
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_Held);
			this.pnlOptions_Ticket.Controls.Add(this.chkTicketOptions_Closed);
			this.pnlOptions_Ticket.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_Ticket.Enabled = false;
			this.pnlOptions_Ticket.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions_Ticket.Name = "pnlOptions_Ticket";
			this.pnlOptions_Ticket.Size = new System.Drawing.Size(563, 480);
			this.pnlOptions_Ticket.TabIndex = 5;
			// 
			// chkTicketOptions_DurationHours
			// 
			this.chkTicketOptions_DurationHours.AutoSize = true;
			this.chkTicketOptions_DurationHours.Location = new System.Drawing.Point(3, 3);
			this.chkTicketOptions_DurationHours.Name = "chkTicketOptions_DurationHours";
			this.chkTicketOptions_DurationHours.Size = new System.Drawing.Size(181, 17);
			this.chkTicketOptions_DurationHours.TabIndex = 7;
			this.chkTicketOptions_DurationHours.Text = "List only tickets open longer than";
			this.chkTicketOptions_DurationHours.UseVisualStyleBackColor = true;
			this.chkTicketOptions_DurationHours.CheckedChanged += new System.EventHandler(this.chkTicketOptions_DurationHours_CheckedChanged);
			// 
			// chkTicketOptions_AllSolutions
			// 
			this.chkTicketOptions_AllSolutions.AutoSize = true;
			this.chkTicketOptions_AllSolutions.Checked = true;
			this.chkTicketOptions_AllSolutions.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTicketOptions_AllSolutions.Location = new System.Drawing.Point(290, 196);
			this.chkTicketOptions_AllSolutions.Name = "chkTicketOptions_AllSolutions";
			this.chkTicketOptions_AllSolutions.Size = new System.Drawing.Size(83, 17);
			this.chkTicketOptions_AllSolutions.TabIndex = 15;
			this.chkTicketOptions_AllSolutions.Text = "All Solutions";
			this.chkTicketOptions_AllSolutions.UseVisualStyleBackColor = true;
			this.chkTicketOptions_AllSolutions.CheckedChanged += new System.EventHandler(this.chkTicketOptions_AllSolutions_CheckedChanged);
			// 
			// numTicketOptions_DurationHours
			// 
			this.numTicketOptions_DurationHours.Enabled = false;
			this.numTicketOptions_DurationHours.Location = new System.Drawing.Point(190, 2);
			this.numTicketOptions_DurationHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numTicketOptions_DurationHours.Name = "numTicketOptions_DurationHours";
			this.numTicketOptions_DurationHours.Size = new System.Drawing.Size(59, 20);
			this.numTicketOptions_DurationHours.TabIndex = 1;
			this.numTicketOptions_DurationHours.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// chkTicketOptions_AllSymptoms
			// 
			this.chkTicketOptions_AllSymptoms.AutoSize = true;
			this.chkTicketOptions_AllSymptoms.Checked = true;
			this.chkTicketOptions_AllSymptoms.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTicketOptions_AllSymptoms.Location = new System.Drawing.Point(3, 196);
			this.chkTicketOptions_AllSymptoms.Name = "chkTicketOptions_AllSymptoms";
			this.chkTicketOptions_AllSymptoms.Size = new System.Drawing.Size(88, 17);
			this.chkTicketOptions_AllSymptoms.TabIndex = 14;
			this.chkTicketOptions_AllSymptoms.Text = "All Symptoms";
			this.chkTicketOptions_AllSymptoms.UseVisualStyleBackColor = true;
			this.chkTicketOptions_AllSymptoms.CheckedChanged += new System.EventHandler(this.chkTicketOptions_AllSymptoms_CheckedChanged);
			// 
			// lblTicketOptions_DurationHours
			// 
			this.lblTicketOptions_DurationHours.AutoSize = true;
			this.lblTicketOptions_DurationHours.Enabled = false;
			this.lblTicketOptions_DurationHours.Location = new System.Drawing.Point(255, 4);
			this.lblTicketOptions_DurationHours.Name = "lblTicketOptions_DurationHours";
			this.lblTicketOptions_DurationHours.Size = new System.Drawing.Size(33, 13);
			this.lblTicketOptions_DurationHours.TabIndex = 2;
			this.lblTicketOptions_DurationHours.Text = "hours";
			// 
			// lstTicketSolutions
			// 
			this.lstTicketSolutions.Enabled = false;
			this.lstTicketSolutions.FormattingEnabled = true;
			this.lstTicketSolutions.Location = new System.Drawing.Point(290, 214);
			this.lstTicketSolutions.Name = "lstTicketSolutions";
			this.lstTicketSolutions.ScrollAlwaysVisible = true;
			this.lstTicketSolutions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstTicketSolutions.Size = new System.Drawing.Size(270, 264);
			this.lstTicketSolutions.TabIndex = 13;
			// 
			// chkTicketOptions_Open
			// 
			this.chkTicketOptions_Open.AutoSize = true;
			this.chkTicketOptions_Open.Checked = true;
			this.chkTicketOptions_Open.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTicketOptions_Open.Location = new System.Drawing.Point(3, 27);
			this.chkTicketOptions_Open.Name = "chkTicketOptions_Open";
			this.chkTicketOptions_Open.Size = new System.Drawing.Size(52, 17);
			this.chkTicketOptions_Open.TabIndex = 3;
			this.chkTicketOptions_Open.Text = "Open";
			this.chkTicketOptions_Open.UseVisualStyleBackColor = true;
			this.chkTicketOptions_Open.CheckedChanged += new System.EventHandler(this.chkTicketType_CheckedChanged);
			// 
			// lstTicketSymptoms
			// 
			this.lstTicketSymptoms.Enabled = false;
			this.lstTicketSymptoms.FormattingEnabled = true;
			this.lstTicketSymptoms.Location = new System.Drawing.Point(3, 214);
			this.lstTicketSymptoms.Name = "lstTicketSymptoms";
			this.lstTicketSymptoms.ScrollAlwaysVisible = true;
			this.lstTicketSymptoms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstTicketSymptoms.Size = new System.Drawing.Size(270, 264);
			this.lstTicketSymptoms.TabIndex = 12;
			// 
			// chkTicketOptions_Held
			// 
			this.chkTicketOptions_Held.AutoSize = true;
			this.chkTicketOptions_Held.Checked = true;
			this.chkTicketOptions_Held.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTicketOptions_Held.Location = new System.Drawing.Point(61, 27);
			this.chkTicketOptions_Held.Name = "chkTicketOptions_Held";
			this.chkTicketOptions_Held.Size = new System.Drawing.Size(48, 17);
			this.chkTicketOptions_Held.TabIndex = 4;
			this.chkTicketOptions_Held.Text = "Held";
			this.chkTicketOptions_Held.UseVisualStyleBackColor = true;
			this.chkTicketOptions_Held.CheckedChanged += new System.EventHandler(this.chkTicketType_CheckedChanged);
			// 
			// chkTicketOptions_Closed
			// 
			this.chkTicketOptions_Closed.AutoSize = true;
			this.chkTicketOptions_Closed.Checked = true;
			this.chkTicketOptions_Closed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTicketOptions_Closed.Location = new System.Drawing.Point(115, 27);
			this.chkTicketOptions_Closed.Name = "chkTicketOptions_Closed";
			this.chkTicketOptions_Closed.Size = new System.Drawing.Size(58, 17);
			this.chkTicketOptions_Closed.TabIndex = 6;
			this.chkTicketOptions_Closed.Text = "Closed";
			this.chkTicketOptions_Closed.UseVisualStyleBackColor = true;
			this.chkTicketOptions_Closed.CheckedChanged += new System.EventHandler(this.chkTicketType_CheckedChanged);
			// 
			// tabRMA
			// 
			this.tabRMA.Controls.Add(this.pnlOptions_RMA);
			this.tabRMA.Location = new System.Drawing.Point(4, 22);
			this.tabRMA.Name = "tabRMA";
			this.tabRMA.Size = new System.Drawing.Size(563, 480);
			this.tabRMA.TabIndex = 5;
			this.tabRMA.Text = "RMA";
			this.tabRMA.UseVisualStyleBackColor = true;
			// 
			// pnlOptions_RMA
			// 
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_Pending);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_RootCauses);
			this.pnlOptions_RMA.Controls.Add(this.lstRMAOptions_RootCauses);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_RepairTypes);
			this.pnlOptions_RMA.Controls.Add(this.lstRMAOptions_RepairTypes);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_FailureTypes);
			this.pnlOptions_RMA.Controls.Add(this.lstRMAOptions_FailureTypes);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_AssemblyTypes);
			this.pnlOptions_RMA.Controls.Add(this.lstRMAOptions_AssemblyTypes);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_Finalized);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_Unreceived);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_Completed);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_Received);
			this.pnlOptions_RMA.Controls.Add(this.chkRMAOptions_InProgress);
			this.pnlOptions_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOptions_RMA.Enabled = false;
			this.pnlOptions_RMA.Location = new System.Drawing.Point(0, 0);
			this.pnlOptions_RMA.Name = "pnlOptions_RMA";
			this.pnlOptions_RMA.Size = new System.Drawing.Size(563, 480);
			this.pnlOptions_RMA.TabIndex = 6;
			// 
			// chkRMAOptions_Pending
			// 
			this.chkRMAOptions_Pending.AutoSize = true;
			this.chkRMAOptions_Pending.Checked = true;
			this.chkRMAOptions_Pending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_Pending.Location = new System.Drawing.Point(253, 3);
			this.chkRMAOptions_Pending.Name = "chkRMAOptions_Pending";
			this.chkRMAOptions_Pending.Size = new System.Drawing.Size(65, 17);
			this.chkRMAOptions_Pending.TabIndex = 3;
			this.chkRMAOptions_Pending.Text = "Pending";
			this.chkRMAOptions_Pending.UseVisualStyleBackColor = true;
			this.chkRMAOptions_Pending.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// chkRMAOptions_RootCauses
			// 
			this.chkRMAOptions_RootCauses.AutoSize = true;
			this.chkRMAOptions_RootCauses.Checked = true;
			this.chkRMAOptions_RootCauses.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_RootCauses.Location = new System.Drawing.Point(375, 37);
			this.chkRMAOptions_RootCauses.Name = "chkRMAOptions_RootCauses";
			this.chkRMAOptions_RootCauses.Size = new System.Drawing.Size(101, 17);
			this.chkRMAOptions_RootCauses.TabIndex = 12;
			this.chkRMAOptions_RootCauses.Text = "All Root Causes";
			this.chkRMAOptions_RootCauses.UseVisualStyleBackColor = true;
			this.chkRMAOptions_RootCauses.CheckedChanged += new System.EventHandler(this.chkRMAOptions_RootCauses_CheckedChanged);
			// 
			// lstRMAOptions_RootCauses
			// 
			this.lstRMAOptions_RootCauses.Enabled = false;
			this.lstRMAOptions_RootCauses.FormattingEnabled = true;
			this.lstRMAOptions_RootCauses.Location = new System.Drawing.Point(375, 55);
			this.lstRMAOptions_RootCauses.Name = "lstRMAOptions_RootCauses";
			this.lstRMAOptions_RootCauses.ScrollAlwaysVisible = true;
			this.lstRMAOptions_RootCauses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstRMAOptions_RootCauses.Size = new System.Drawing.Size(180, 420);
			this.lstRMAOptions_RootCauses.TabIndex = 13;
			// 
			// chkRMAOptions_RepairTypes
			// 
			this.chkRMAOptions_RepairTypes.AutoSize = true;
			this.chkRMAOptions_RepairTypes.Checked = true;
			this.chkRMAOptions_RepairTypes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_RepairTypes.Location = new System.Drawing.Point(189, 266);
			this.chkRMAOptions_RepairTypes.Name = "chkRMAOptions_RepairTypes";
			this.chkRMAOptions_RepairTypes.Size = new System.Drawing.Size(103, 17);
			this.chkRMAOptions_RepairTypes.TabIndex = 10;
			this.chkRMAOptions_RepairTypes.Text = "All Repair Types";
			this.chkRMAOptions_RepairTypes.UseVisualStyleBackColor = true;
			this.chkRMAOptions_RepairTypes.CheckedChanged += new System.EventHandler(this.chkRMAOptions_AllRepairTypes_CheckedChanged);
			// 
			// lstRMAOptions_RepairTypes
			// 
			this.lstRMAOptions_RepairTypes.Enabled = false;
			this.lstRMAOptions_RepairTypes.FormattingEnabled = true;
			this.lstRMAOptions_RepairTypes.Location = new System.Drawing.Point(189, 289);
			this.lstRMAOptions_RepairTypes.Name = "lstRMAOptions_RepairTypes";
			this.lstRMAOptions_RepairTypes.ScrollAlwaysVisible = true;
			this.lstRMAOptions_RepairTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstRMAOptions_RepairTypes.Size = new System.Drawing.Size(180, 186);
			this.lstRMAOptions_RepairTypes.TabIndex = 11;
			// 
			// chkRMAOptions_FailureTypes
			// 
			this.chkRMAOptions_FailureTypes.AutoSize = true;
			this.chkRMAOptions_FailureTypes.Checked = true;
			this.chkRMAOptions_FailureTypes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_FailureTypes.Location = new System.Drawing.Point(189, 37);
			this.chkRMAOptions_FailureTypes.Name = "chkRMAOptions_FailureTypes";
			this.chkRMAOptions_FailureTypes.Size = new System.Drawing.Size(103, 17);
			this.chkRMAOptions_FailureTypes.TabIndex = 8;
			this.chkRMAOptions_FailureTypes.Text = "All Failure Types";
			this.chkRMAOptions_FailureTypes.UseVisualStyleBackColor = true;
			this.chkRMAOptions_FailureTypes.CheckedChanged += new System.EventHandler(this.chkRMAOptions_FailureTypes_CheckedChanged);
			// 
			// lstRMAOptions_FailureTypes
			// 
			this.lstRMAOptions_FailureTypes.Enabled = false;
			this.lstRMAOptions_FailureTypes.FormattingEnabled = true;
			this.lstRMAOptions_FailureTypes.Location = new System.Drawing.Point(189, 55);
			this.lstRMAOptions_FailureTypes.Name = "lstRMAOptions_FailureTypes";
			this.lstRMAOptions_FailureTypes.ScrollAlwaysVisible = true;
			this.lstRMAOptions_FailureTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstRMAOptions_FailureTypes.Size = new System.Drawing.Size(180, 186);
			this.lstRMAOptions_FailureTypes.TabIndex = 9;
			// 
			// chkRMAOptions_AssemblyTypes
			// 
			this.chkRMAOptions_AssemblyTypes.AutoSize = true;
			this.chkRMAOptions_AssemblyTypes.Checked = true;
			this.chkRMAOptions_AssemblyTypes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_AssemblyTypes.Location = new System.Drawing.Point(3, 37);
			this.chkRMAOptions_AssemblyTypes.Name = "chkRMAOptions_AssemblyTypes";
			this.chkRMAOptions_AssemblyTypes.Size = new System.Drawing.Size(116, 17);
			this.chkRMAOptions_AssemblyTypes.TabIndex = 6;
			this.chkRMAOptions_AssemblyTypes.Text = "All Assembly Types";
			this.chkRMAOptions_AssemblyTypes.UseVisualStyleBackColor = true;
			this.chkRMAOptions_AssemblyTypes.CheckedChanged += new System.EventHandler(this.chkRMAOptions_AssemblyTypes_CheckedChanged);
			// 
			// lstRMAOptions_AssemblyTypes
			// 
			this.lstRMAOptions_AssemblyTypes.Enabled = false;
			this.lstRMAOptions_AssemblyTypes.FormattingEnabled = true;
			this.lstRMAOptions_AssemblyTypes.Location = new System.Drawing.Point(3, 55);
			this.lstRMAOptions_AssemblyTypes.Name = "lstRMAOptions_AssemblyTypes";
			this.lstRMAOptions_AssemblyTypes.ScrollAlwaysVisible = true;
			this.lstRMAOptions_AssemblyTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstRMAOptions_AssemblyTypes.Size = new System.Drawing.Size(180, 420);
			this.lstRMAOptions_AssemblyTypes.TabIndex = 7;
			// 
			// chkRMAOptions_Finalized
			// 
			this.chkRMAOptions_Finalized.AutoSize = true;
			this.chkRMAOptions_Finalized.Checked = true;
			this.chkRMAOptions_Finalized.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_Finalized.Location = new System.Drawing.Point(406, 3);
			this.chkRMAOptions_Finalized.Name = "chkRMAOptions_Finalized";
			this.chkRMAOptions_Finalized.Size = new System.Drawing.Size(67, 17);
			this.chkRMAOptions_Finalized.TabIndex = 5;
			this.chkRMAOptions_Finalized.Text = "Finalized";
			this.chkRMAOptions_Finalized.UseVisualStyleBackColor = true;
			this.chkRMAOptions_Finalized.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// chkRMAOptions_Unreceived
			// 
			this.chkRMAOptions_Unreceived.AutoSize = true;
			this.chkRMAOptions_Unreceived.Checked = true;
			this.chkRMAOptions_Unreceived.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_Unreceived.Location = new System.Drawing.Point(3, 3);
			this.chkRMAOptions_Unreceived.Name = "chkRMAOptions_Unreceived";
			this.chkRMAOptions_Unreceived.Size = new System.Drawing.Size(81, 17);
			this.chkRMAOptions_Unreceived.TabIndex = 0;
			this.chkRMAOptions_Unreceived.Text = "Unreceived";
			this.chkRMAOptions_Unreceived.UseVisualStyleBackColor = true;
			this.chkRMAOptions_Unreceived.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// chkRMAOptions_Completed
			// 
			this.chkRMAOptions_Completed.AutoSize = true;
			this.chkRMAOptions_Completed.Checked = true;
			this.chkRMAOptions_Completed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_Completed.Location = new System.Drawing.Point(324, 3);
			this.chkRMAOptions_Completed.Name = "chkRMAOptions_Completed";
			this.chkRMAOptions_Completed.Size = new System.Drawing.Size(76, 17);
			this.chkRMAOptions_Completed.TabIndex = 4;
			this.chkRMAOptions_Completed.Text = "Completed";
			this.chkRMAOptions_Completed.UseVisualStyleBackColor = true;
			this.chkRMAOptions_Completed.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// chkRMAOptions_Received
			// 
			this.chkRMAOptions_Received.AutoSize = true;
			this.chkRMAOptions_Received.Checked = true;
			this.chkRMAOptions_Received.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_Received.Location = new System.Drawing.Point(90, 3);
			this.chkRMAOptions_Received.Name = "chkRMAOptions_Received";
			this.chkRMAOptions_Received.Size = new System.Drawing.Size(72, 17);
			this.chkRMAOptions_Received.TabIndex = 1;
			this.chkRMAOptions_Received.Text = "Received";
			this.chkRMAOptions_Received.UseVisualStyleBackColor = true;
			this.chkRMAOptions_Received.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// chkRMAOptions_InProgress
			// 
			this.chkRMAOptions_InProgress.AutoSize = true;
			this.chkRMAOptions_InProgress.Checked = true;
			this.chkRMAOptions_InProgress.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkRMAOptions_InProgress.Location = new System.Drawing.Point(168, 3);
			this.chkRMAOptions_InProgress.Name = "chkRMAOptions_InProgress";
			this.chkRMAOptions_InProgress.Size = new System.Drawing.Size(79, 17);
			this.chkRMAOptions_InProgress.TabIndex = 2;
			this.chkRMAOptions_InProgress.Text = "In-Progress";
			this.chkRMAOptions_InProgress.UseVisualStyleBackColor = true;
			this.chkRMAOptions_InProgress.CheckedChanged += new System.EventHandler(this.chkRMAType_CheckedChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerate.Location = new System.Drawing.Point(815, 543);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(105, 38);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Generate Report";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblSeparator
			// 
			this.lblSeparator.BackColor = System.Drawing.Color.Black;
			this.lblSeparator.Location = new System.Drawing.Point(333, 12);
			this.lblSeparator.Name = "lblSeparator";
			this.lblSeparator.Size = new System.Drawing.Size(2, 575);
			this.lblSeparator.TabIndex = 6;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(340, 558);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// FormReporting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 593);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblSeparator);
			this.Controls.Add(this.grpParameters);
			this.Controls.Add(this.grpType);
			this.Controls.Add(this.btnGenerate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReporting";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reports";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporting_FormClosing);
			this.Load += new System.EventHandler(this.FormReporting_Load);
			this.Shown += new System.EventHandler(this.FormReporting_Shown);
			this.VisibleChanged += new System.EventHandler(this.FormReporting_VisibleChanged);
			this.grpType.ResumeLayout(false);
			this.grpType.PerformLayout();
			this.grpParameters.ResumeLayout(false);
			this.tabControl_ReportOptions.ResumeLayout(false);
			this.tabDates.ResumeLayout(false);
			this.pnlOptions_Dates.ResumeLayout(false);
			this.pnlOptions_Dates.PerformLayout();
			this.pnlDates.ResumeLayout(false);
			this.pnlDates.PerformLayout();
			this.tabCustomers.ResumeLayout(false);
			this.pnlOptions_Customer.ResumeLayout(false);
			this.pnlOptions_Customer.PerformLayout();
			this.tabAssets.ResumeLayout(false);
			this.pnlOptions_Asset.ResumeLayout(false);
			this.pnlOptions_Asset.PerformLayout();
			this.tabTechs.ResumeLayout(false);
			this.pnlOptions_Tech.ResumeLayout(false);
			this.pnlOptions_Tech.PerformLayout();
			this.tabTicket.ResumeLayout(false);
			this.pnlOptions_Ticket.ResumeLayout(false);
			this.pnlOptions_Ticket.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numTicketOptions_DurationHours)).EndInit();
			this.tabRMA.ResumeLayout(false);
			this.pnlOptions_RMA.ResumeLayout(false);
			this.pnlOptions_RMA.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpType;
		private System.Windows.Forms.GroupBox grpParameters;
		private System.Windows.Forms.ListBox lstRMAReports;
		private System.Windows.Forms.Label lblTicketReports;
		private System.Windows.Forms.ListBox lstTicketReports;
		private System.Windows.Forms.Label lblSymptomReports;
		private System.Windows.Forms.ListBox lstSymptomReports;
		private System.Windows.Forms.Label lblAccountingReports;
		private System.Windows.Forms.ListBox lstAccountingReports;
		private System.Windows.Forms.Label lblRMAReports;
		private System.Windows.Forms.Label lblDateRange_Shortcuts;
		private System.Windows.Forms.Label lblDateRange_To;
		private System.Windows.Forms.Button btnShortcut_Month;
		private System.Windows.Forms.Button btnShortcut_Quarter;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnShortcut_Week;
		private System.Windows.Forms.Button btnShortcut_Year;
		private System.Windows.Forms.CheckBox chkAllCustomers;
		private System.Windows.Forms.CheckBox chkAllAssets;
		private System.Windows.Forms.CheckBox chkAllTechs;
		private System.Windows.Forms.CheckBox chkTicketOptions_Open;
		private System.Windows.Forms.Label lblTicketOptions_DurationHours;
		private System.Windows.Forms.NumericUpDown numTicketOptions_DurationHours;
		private System.Windows.Forms.CheckBox chkTicketOptions_DurationHours;
		private System.Windows.Forms.CheckBox chkTicketOptions_Closed;
		private System.Windows.Forms.CheckBox chkTicketOptions_Held;
		private System.Windows.Forms.Button btnShortcut_Today;
		private System.Windows.Forms.CheckBox chkRMAOptions_Finalized;
		private System.Windows.Forms.CheckBox chkRMAOptions_Completed;
		private System.Windows.Forms.CheckBox chkRMAOptions_InProgress;
		private System.Windows.Forms.CheckBox chkRMAOptions_Received;
		private System.Windows.Forms.CheckBox chkRMAOptions_Unreceived;
		private System.Windows.Forms.ListBox lstCustomers;
		private System.Windows.Forms.ListBox lstTicketSolutions;
		private System.Windows.Forms.ListBox lstTicketSymptoms;
		private System.Windows.Forms.ListBox lstTechs;
		private System.Windows.Forms.ListBox lstAssets;
		private System.Windows.Forms.CheckBox chkTicketOptions_AllSolutions;
		private System.Windows.Forms.CheckBox chkTicketOptions_AllSymptoms;
		private System.Windows.Forms.Label lblReportDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.CheckBox chkAnyDate;
		private System.Windows.Forms.Label lblSeparator;
		private System.Windows.Forms.Button btnShortcut_30PlusDays;
		private NullableDateTimePicker ndtpDateTo;
		private NullableDateTimePicker ndtpDateFrom;
		private System.Windows.Forms.Panel pnlDates;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnShortcut_90PlusDays;
		private System.Windows.Forms.Button btnShortcut_60PlusDays;
		private System.Windows.Forms.TabControl tabControl_ReportOptions;
		private System.Windows.Forms.TabPage tabDates;
		private System.Windows.Forms.TabPage tabCustomers;
		private System.Windows.Forms.TabPage tabAssets;
		private System.Windows.Forms.TabPage tabTechs;
		private System.Windows.Forms.TabPage tabTicket;
		private System.Windows.Forms.TabPage tabRMA;
		private System.Windows.Forms.Panel pnlOptions_Dates;
		private System.Windows.Forms.Panel pnlOptions_Customer;
		private System.Windows.Forms.Panel pnlOptions_Asset;
		private System.Windows.Forms.Panel pnlOptions_Tech;
		private System.Windows.Forms.Panel pnlOptions_Ticket;
		private System.Windows.Forms.Panel pnlOptions_RMA;
		private System.Windows.Forms.CheckBox chkRMAOptions_RootCauses;
		private System.Windows.Forms.ListBox lstRMAOptions_RootCauses;
		private System.Windows.Forms.CheckBox chkRMAOptions_RepairTypes;
		private System.Windows.Forms.ListBox lstRMAOptions_RepairTypes;
		private System.Windows.Forms.CheckBox chkRMAOptions_FailureTypes;
		private System.Windows.Forms.ListBox lstRMAOptions_FailureTypes;
		private System.Windows.Forms.CheckBox chkRMAOptions_AssemblyTypes;
		private System.Windows.Forms.ListBox lstRMAOptions_AssemblyTypes;
		private System.Windows.Forms.CheckBox chkRMAOptions_Pending;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnShortcut_Within30Days;
		private System.Windows.Forms.Button btnShortcut_Within90Days;
		private System.Windows.Forms.Button btnShortcut_Within60Days;
	}
}