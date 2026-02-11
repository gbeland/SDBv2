namespace SDB.Forms.CameraCheck
{
	partial class FormCameraCheck_Audit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraCheck_Audit));
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlOutput = new System.Windows.Forms.Panel();
			this.olvCameraCheckResults = new BrightIdeasSoftware.ObjectListView();
			this.olcCameraCheckCustomer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckMarket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckAsset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckPanel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckUser = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckImageName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckSubmitDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckSymptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckTicket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCameraCheckNewTicket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnExport = new System.Windows.Forms.Button();
			this.pnlSelections = new System.Windows.Forms.Panel();
			this.chkFailsOnly = new System.Windows.Forms.CheckBox();
			this.pnlDateRange_Selectors = new System.Windows.Forms.Panel();
			this.radDateRange_Range = new System.Windows.Forms.RadioButton();
			this.radDateRange_LastDays = new System.Windows.Forms.RadioButton();
			this.pnlDateRange_Range = new System.Windows.Forms.Panel();
			this.lblFrom = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.lblTo = new System.Windows.Forms.Label();
			this.pnlDateRange_LastDays = new System.Windows.Forms.Panel();
			this.numLastNDays = new System.Windows.Forms.NumericUpDown();
			this.lblLastNDays_Unit = new System.Windows.Forms.Label();
			this.olvSecondary = new BrightIdeasSoftware.ObjectListView();
			this.olcMarket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvPrimary = new BrightIdeasSoftware.ObjectListView();
			this.lblInfo = new System.Windows.Forms.Label();
			this.radUser = new System.Windows.Forms.RadioButton();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.radCustomer = new System.Windows.Forms.RadioButton();
			this.timerImageLoad = new System.Windows.Forms.Timer(this.components);
			this.pnlDetail = new System.Windows.Forms.Panel();
			this.lblDetail = new System.Windows.Forms.Label();
			this.pbCameraImage = new System.Windows.Forms.PictureBox();
			this.btnShowMenu = new System.Windows.Forms.Button();
			this.pnlCameraImage = new System.Windows.Forms.Panel();
			this.pnlBottom.SuspendLayout();
			this.pnlOutput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvCameraCheckResults)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.pnlSelections.SuspendLayout();
			this.pnlDateRange_Selectors.SuspendLayout();
			this.pnlDateRange_Range.SuspendLayout();
			this.pnlDateRange_LastDays.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLastNDays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.olvSecondary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.olvPrimary)).BeginInit();
			this.pnlDetail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbCameraImage)).BeginInit();
			this.pnlCameraImage.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.btnClose);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 632);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(1384, 30);
			this.pnlBottom.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(1306, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlOutput
			// 
			this.pnlOutput.Controls.Add(this.olvCameraCheckResults);
			this.pnlOutput.Controls.Add(this.pnlControl);
			this.pnlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlOutput.Location = new System.Drawing.Point(563, 0);
			this.pnlOutput.Name = "pnlOutput";
			this.pnlOutput.Size = new System.Drawing.Size(821, 632);
			this.pnlOutput.TabIndex = 0;
			// 
			// olvCameraCheckResults
			// 
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckCustomer);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckMarket);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckAsset);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckPanel);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckUser);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckImageName);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckSubmitDateTime);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckStatus);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckSymptom);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckTicket);
			this.olvCameraCheckResults.AllColumns.Add(this.olcCameraCheckNewTicket);
			this.olvCameraCheckResults.AllowColumnReorder = true;
			this.olvCameraCheckResults.CellEditUseWholeCell = false;
			this.olvCameraCheckResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCameraCheckCustomer,
            this.olcCameraCheckMarket,
            this.olcCameraCheckAsset,
            this.olcCameraCheckPanel,
            this.olcCameraCheckUser,
            this.olcCameraCheckImageName,
            this.olcCameraCheckSubmitDateTime,
            this.olcCameraCheckStatus,
            this.olcCameraCheckSymptom,
            this.olcCameraCheckTicket,
            this.olcCameraCheckNewTicket});
			this.olvCameraCheckResults.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvCameraCheckResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvCameraCheckResults.FullRowSelect = true;
			this.olvCameraCheckResults.GridLines = true;
			this.olvCameraCheckResults.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvCameraCheckResults.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvCameraCheckResults.Location = new System.Drawing.Point(0, 30);
			this.olvCameraCheckResults.MultiSelect = false;
			this.olvCameraCheckResults.Name = "olvCameraCheckResults";
			this.olvCameraCheckResults.SelectAllOnControlA = false;
			this.olvCameraCheckResults.SelectColumnsMenuStaysOpen = false;
			this.olvCameraCheckResults.SelectColumnsOnRightClick = false;
			this.olvCameraCheckResults.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvCameraCheckResults.ShowCommandMenuOnRightClick = true;
			this.olvCameraCheckResults.ShowItemCountOnGroups = true;
			this.olvCameraCheckResults.Size = new System.Drawing.Size(821, 602);
			this.olvCameraCheckResults.SortGroupItemsByPrimaryColumn = false;
			this.olvCameraCheckResults.TabIndex = 1;
			this.olvCameraCheckResults.UseCompatibleStateImageBehavior = false;
			this.olvCameraCheckResults.UseFilterIndicator = true;
			this.olvCameraCheckResults.UseFiltering = true;
			this.olvCameraCheckResults.UseHotControls = false;
			this.olvCameraCheckResults.UseOverlays = false;
			this.olvCameraCheckResults.View = System.Windows.Forms.View.Details;
			this.olvCameraCheckResults.SelectedIndexChanged += new System.EventHandler(this.olvCameraCheckResults_SelectedIndexChanged);
			// 
			// olcCameraCheckCustomer
			// 
			this.olcCameraCheckCustomer.AspectName = "Asset_ID";
			this.olcCameraCheckCustomer.Text = "Customer";
			this.olcCameraCheckCustomer.Width = 120;
			// 
			// olcCameraCheckMarket
			// 
			this.olcCameraCheckMarket.AspectName = "Asset_ID";
			this.olcCameraCheckMarket.Text = "Market";
			this.olcCameraCheckMarket.Width = 100;
			// 
			// olcCameraCheckAsset
			// 
			this.olcCameraCheckAsset.AspectName = "Asset_ID";
			this.olcCameraCheckAsset.Text = "Asset";
			this.olcCameraCheckAsset.Width = 100;
			// 
			// olcCameraCheckPanel
			// 
			this.olcCameraCheckPanel.AspectName = "Asset_ID";
			this.olcCameraCheckPanel.Text = "Panel";
			this.olcCameraCheckPanel.Width = 100;
			// 
			// olcCameraCheckUser
			// 
			this.olcCameraCheckUser.AspectName = "User_ID";
			this.olcCameraCheckUser.Text = "User";
			this.olcCameraCheckUser.Width = 70;
			// 
			// olcCameraCheckImageName
			// 
			this.olcCameraCheckImageName.AspectName = "ImageName";
			this.olcCameraCheckImageName.Text = "Image";
			this.olcCameraCheckImageName.Width = 162;
			// 
			// olcCameraCheckSubmitDateTime
			// 
			this.olcCameraCheckSubmitDateTime.AspectName = "Submitted";
			this.olcCameraCheckSubmitDateTime.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm:ss}";
			this.olcCameraCheckSubmitDateTime.Text = "Datetime";
			this.olcCameraCheckSubmitDateTime.Width = 110;
			// 
			// olcCameraCheckStatus
			// 
			this.olcCameraCheckStatus.AspectName = "Status";
			this.olcCameraCheckStatus.Text = "Status";
			this.olcCameraCheckStatus.Width = 50;
			// 
			// olcCameraCheckSymptom
			// 
			this.olcCameraCheckSymptom.AspectName = "Symptom_ID";
			this.olcCameraCheckSymptom.Text = "Symptom";
			this.olcCameraCheckSymptom.Width = 70;
			// 
			// olcCameraCheckTicket
			// 
			this.olcCameraCheckTicket.AspectName = "Ticket_ID";
			this.olcCameraCheckTicket.Text = "Ticket ID";
			// 
			// olcCameraCheckNewTicket
			// 
			this.olcCameraCheckNewTicket.AspectName = "NewTicket";
			this.olcCameraCheckNewTicket.CheckBoxes = true;
			this.olcCameraCheckNewTicket.Text = "New?";
			this.olcCameraCheckNewTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcCameraCheckNewTicket.ToolTipText = "Resulted in a new ticket.";
			this.olcCameraCheckNewTicket.Width = 50;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(821, 30);
			this.pnlControl.TabIndex = 0;
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(6, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 0;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// pnlSelections
			// 
			this.pnlSelections.Controls.Add(this.chkFailsOnly);
			this.pnlSelections.Controls.Add(this.pnlDateRange_Selectors);
			this.pnlSelections.Controls.Add(this.pnlDateRange_Range);
			this.pnlSelections.Controls.Add(this.pnlDateRange_LastDays);
			this.pnlSelections.Controls.Add(this.olvSecondary);
			this.pnlSelections.Controls.Add(this.olvPrimary);
			this.pnlSelections.Controls.Add(this.lblInfo);
			this.pnlSelections.Controls.Add(this.radUser);
			this.pnlSelections.Controls.Add(this.btnGenerate);
			this.pnlSelections.Controls.Add(this.radCustomer);
			this.pnlSelections.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSelections.Location = new System.Drawing.Point(0, 0);
			this.pnlSelections.Name = "pnlSelections";
			this.pnlSelections.Size = new System.Drawing.Size(263, 632);
			this.pnlSelections.TabIndex = 0;
			// 
			// chkFailsOnly
			// 
			this.chkFailsOnly.AutoSize = true;
			this.chkFailsOnly.Location = new System.Drawing.Point(110, 515);
			this.chkFailsOnly.Name = "chkFailsOnly";
			this.chkFailsOnly.Size = new System.Drawing.Size(147, 17);
			this.chkFailsOnly.TabIndex = 4;
			this.chkFailsOnly.Text = "Show Only Failed Checks";
			this.chkFailsOnly.UseVisualStyleBackColor = true;
			// 
			// pnlDateRange_Selectors
			// 
			this.pnlDateRange_Selectors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlDateRange_Selectors.Controls.Add(this.radDateRange_Range);
			this.pnlDateRange_Selectors.Controls.Add(this.radDateRange_LastDays);
			this.pnlDateRange_Selectors.Location = new System.Drawing.Point(3, 538);
			this.pnlDateRange_Selectors.Name = "pnlDateRange_Selectors";
			this.pnlDateRange_Selectors.Size = new System.Drawing.Size(67, 87);
			this.pnlDateRange_Selectors.TabIndex = 5;
			// 
			// radDateRange_Range
			// 
			this.radDateRange_Range.AutoSize = true;
			this.radDateRange_Range.Location = new System.Drawing.Point(6, 4);
			this.radDateRange_Range.Name = "radDateRange_Range";
			this.radDateRange_Range.Size = new System.Drawing.Size(57, 17);
			this.radDateRange_Range.TabIndex = 14;
			this.radDateRange_Range.Text = "Range";
			this.radDateRange_Range.UseVisualStyleBackColor = true;
			this.radDateRange_Range.CheckedChanged += new System.EventHandler(this.radDateRange_Range_CheckedChanged);
			// 
			// radDateRange_LastDays
			// 
			this.radDateRange_LastDays.AutoSize = true;
			this.radDateRange_LastDays.Checked = true;
			this.radDateRange_LastDays.Location = new System.Drawing.Point(6, 64);
			this.radDateRange_LastDays.Name = "radDateRange_LastDays";
			this.radDateRange_LastDays.Size = new System.Drawing.Size(45, 17);
			this.radDateRange_LastDays.TabIndex = 15;
			this.radDateRange_LastDays.TabStop = true;
			this.radDateRange_LastDays.Text = "Last";
			this.radDateRange_LastDays.UseVisualStyleBackColor = true;
			// 
			// pnlDateRange_Range
			// 
			this.pnlDateRange_Range.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDateRange_Range.Controls.Add(this.lblFrom);
			this.pnlDateRange_Range.Controls.Add(this.dtpFrom);
			this.pnlDateRange_Range.Controls.Add(this.dtpTo);
			this.pnlDateRange_Range.Controls.Add(this.lblTo);
			this.pnlDateRange_Range.Enabled = false;
			this.pnlDateRange_Range.Location = new System.Drawing.Point(72, 538);
			this.pnlDateRange_Range.Name = "pnlDateRange_Range";
			this.pnlDateRange_Range.Size = new System.Drawing.Size(185, 53);
			this.pnlDateRange_Range.TabIndex = 6;
			// 
			// lblFrom
			// 
			this.lblFrom.AutoSize = true;
			this.lblFrom.Location = new System.Drawing.Point(3, 6);
			this.lblFrom.Name = "lblFrom";
			this.lblFrom.Size = new System.Drawing.Size(30, 13);
			this.lblFrom.TabIndex = 5;
			this.lblFrom.Text = "From";
			// 
			// dtpFrom
			// 
			this.dtpFrom.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFrom.Location = new System.Drawing.Point(39, 2);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(141, 20);
			this.dtpFrom.TabIndex = 6;
			this.dtpFrom.Value = new System.DateTime(2016, 3, 10, 17, 26, 3, 340);
			// 
			// dtpTo
			// 
			this.dtpTo.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTo.Location = new System.Drawing.Point(39, 28);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(141, 20);
			this.dtpTo.TabIndex = 8;
			this.dtpTo.Value = new System.DateTime(2016, 3, 10, 17, 25, 44, 110);
			// 
			// lblTo
			// 
			this.lblTo.AutoSize = true;
			this.lblTo.Location = new System.Drawing.Point(13, 32);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(20, 13);
			this.lblTo.TabIndex = 7;
			this.lblTo.Text = "To";
			// 
			// pnlDateRange_LastDays
			// 
			this.pnlDateRange_LastDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDateRange_LastDays.Controls.Add(this.numLastNDays);
			this.pnlDateRange_LastDays.Controls.Add(this.lblLastNDays_Unit);
			this.pnlDateRange_LastDays.Location = new System.Drawing.Point(72, 597);
			this.pnlDateRange_LastDays.Name = "pnlDateRange_LastDays";
			this.pnlDateRange_LastDays.Size = new System.Drawing.Size(81, 26);
			this.pnlDateRange_LastDays.TabIndex = 7;
			// 
			// numLastNDays
			// 
			this.numLastNDays.Location = new System.Drawing.Point(3, 3);
			this.numLastNDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.numLastNDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLastNDays.Name = "numLastNDays";
			this.numLastNDays.Size = new System.Drawing.Size(39, 20);
			this.numLastNDays.TabIndex = 10;
			this.numLastNDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numLastNDays.ValueChanged += new System.EventHandler(this.numLastNDays_ValueChanged);
			this.numLastNDays.Enter += new System.EventHandler(this.NumericUpDown_Enter);
			// 
			// lblLastNDays_Unit
			// 
			this.lblLastNDays_Unit.AutoSize = true;
			this.lblLastNDays_Unit.Location = new System.Drawing.Point(48, 5);
			this.lblLastNDays_Unit.Name = "lblLastNDays_Unit";
			this.lblLastNDays_Unit.Size = new System.Drawing.Size(29, 13);
			this.lblLastNDays_Unit.TabIndex = 11;
			this.lblLastNDays_Unit.Text = "days";
			// 
			// olvSecondary
			// 
			this.olvSecondary.AllColumns.Add(this.olcMarket);
			this.olvSecondary.CellEditUseWholeCell = false;
			this.olvSecondary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcMarket});
			this.olvSecondary.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSecondary.FullRowSelect = true;
			this.olvSecondary.GridLines = true;
			this.olvSecondary.HideSelection = false;
			this.olvSecondary.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvSecondary.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvSecondary.Location = new System.Drawing.Point(12, 282);
			this.olvSecondary.Name = "olvSecondary";
			this.olvSecondary.ShowFilterMenuOnRightClick = false;
			this.olvSecondary.ShowGroups = false;
			this.olvSecondary.Size = new System.Drawing.Size(245, 220);
			this.olvSecondary.TabIndex = 3;
			this.olvSecondary.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
			this.olvSecondary.UseCompatibleStateImageBehavior = false;
			this.olvSecondary.View = System.Windows.Forms.View.Details;
			this.olvSecondary.Visible = false;
			this.olvSecondary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvSecondary_MouseDoubleClick);
			// 
			// olcMarket
			// 
			this.olcMarket.AspectName = "CustomerPrefixAndName";
			this.olcMarket.Text = "Market";
			this.olcMarket.Width = 200;
			// 
			// olvPrimary
			// 
			this.olvPrimary.CellEditUseWholeCell = false;
			this.olvPrimary.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvPrimary.FullRowSelect = true;
			this.olvPrimary.GridLines = true;
			this.olvPrimary.HideSelection = false;
			this.olvPrimary.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvPrimary.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvPrimary.Location = new System.Drawing.Point(12, 56);
			this.olvPrimary.Name = "olvPrimary";
			this.olvPrimary.ShowFilterMenuOnRightClick = false;
			this.olvPrimary.ShowGroups = false;
			this.olvPrimary.Size = new System.Drawing.Size(245, 220);
			this.olvPrimary.TabIndex = 2;
			this.olvPrimary.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
			this.olvPrimary.UseCompatibleStateImageBehavior = false;
			this.olvPrimary.View = System.Windows.Forms.View.Details;
			this.olvPrimary.Visible = false;
			this.olvPrimary.SelectionChanged += new System.EventHandler(this.olvPrimary_SelectionChanged);
			this.olvPrimary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvPrimary_MouseDoubleClick);
			// 
			// lblInfo
			// 
			this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblInfo.Location = new System.Drawing.Point(0, 0);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Padding = new System.Windows.Forms.Padding(4);
			this.lblInfo.Size = new System.Drawing.Size(263, 30);
			this.lblInfo.TabIndex = 0;
			this.lblInfo.Text = "Select type of camera check audit to run.";
			// 
			// radUser
			// 
			this.radUser.AutoSize = true;
			this.radUser.Location = new System.Drawing.Point(87, 33);
			this.radUser.Name = "radUser";
			this.radUser.Size = new System.Drawing.Size(47, 17);
			this.radUser.TabIndex = 1;
			this.radUser.Text = "User";
			this.radUser.UseVisualStyleBackColor = true;
			this.radUser.CheckedChanged += new System.EventHandler(this.radUser_CheckedChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerate.Location = new System.Drawing.Point(182, 597);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 13;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// radCustomer
			// 
			this.radCustomer.AutoSize = true;
			this.radCustomer.Location = new System.Drawing.Point(12, 33);
			this.radCustomer.Name = "radCustomer";
			this.radCustomer.Size = new System.Drawing.Size(69, 17);
			this.radCustomer.TabIndex = 0;
			this.radCustomer.Text = "Customer";
			this.radCustomer.UseVisualStyleBackColor = true;
			this.radCustomer.CheckedChanged += new System.EventHandler(this.radCustomer_CheckedChanged);
			// 
			// timerImageLoad
			// 
			this.timerImageLoad.Interval = 200;
			this.timerImageLoad.Tick += new System.EventHandler(this.timerImageLoad_Tick);
			// 
			// pnlDetail
			// 
			this.pnlDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.pnlDetail.Controls.Add(this.lblDetail);
			this.pnlDetail.Controls.Add(this.pnlCameraImage);
			this.pnlDetail.Controls.Add(this.btnShowMenu);
			this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlDetail.Location = new System.Drawing.Point(263, 0);
			this.pnlDetail.Name = "pnlDetail";
			this.pnlDetail.Padding = new System.Windows.Forms.Padding(2);
			this.pnlDetail.Size = new System.Drawing.Size(300, 632);
			this.pnlDetail.TabIndex = 14;
			this.pnlDetail.Visible = false;
			// 
			// lblDetail
			// 
			this.lblDetail.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(2, 302);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(296, 200);
			this.lblDetail.TabIndex = 2;
			// 
			// pbCameraImage
			// 
			this.pbCameraImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbCameraImage.Location = new System.Drawing.Point(2, 2);
			this.pbCameraImage.Name = "pbCameraImage";
			this.pbCameraImage.Size = new System.Drawing.Size(292, 296);
			this.pbCameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbCameraImage.TabIndex = 1;
			this.pbCameraImage.TabStop = false;
			// 
			// btnShowMenu
			// 
			this.btnShowMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowMenu.Location = new System.Drawing.Point(200, 597);
			this.btnShowMenu.Name = "btnShowMenu";
			this.btnShowMenu.Size = new System.Drawing.Size(92, 23);
			this.btnShowMenu.TabIndex = 0;
			this.btnShowMenu.Text = "Show Menu";
			this.btnShowMenu.UseVisualStyleBackColor = true;
			this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
			// 
			// pnlCameraImage
			// 
			this.pnlCameraImage.Controls.Add(this.pbCameraImage);
			this.pnlCameraImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCameraImage.Location = new System.Drawing.Point(2, 2);
			this.pnlCameraImage.Name = "pnlCameraImage";
			this.pnlCameraImage.Padding = new System.Windows.Forms.Padding(2);
			this.pnlCameraImage.Size = new System.Drawing.Size(296, 300);
			this.pnlCameraImage.TabIndex = 3;
			// 
			// FormCameraCheck_Audit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1384, 662);
			this.Controls.Add(this.pnlOutput);
			this.Controls.Add(this.pnlDetail);
			this.Controls.Add(this.pnlSelections);
			this.Controls.Add(this.pnlBottom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 700);
			this.Name = "FormCameraCheck_Audit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Camera Check Audit";
			this.Load += new System.EventHandler(this.FormCameraCheck_Audit_Load);
			this.pnlBottom.ResumeLayout(false);
			this.pnlOutput.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvCameraCheckResults)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlSelections.ResumeLayout(false);
			this.pnlSelections.PerformLayout();
			this.pnlDateRange_Selectors.ResumeLayout(false);
			this.pnlDateRange_Selectors.PerformLayout();
			this.pnlDateRange_Range.ResumeLayout(false);
			this.pnlDateRange_Range.PerformLayout();
			this.pnlDateRange_LastDays.ResumeLayout(false);
			this.pnlDateRange_LastDays.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLastNDays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.olvSecondary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.olvPrimary)).EndInit();
			this.pnlDetail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbCameraImage)).EndInit();
			this.pnlCameraImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlOutput;
		private BrightIdeasSoftware.ObjectListView olvCameraCheckResults;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Panel pnlSelections;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.RadioButton radUser;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.RadioButton radCustomer;
		private BrightIdeasSoftware.ObjectListView olvSecondary;
		private BrightIdeasSoftware.ObjectListView olvPrimary;
		private BrightIdeasSoftware.OLVColumn olcMarket;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckAsset;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckUser;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckSubmitDateTime;
		private System.Windows.Forms.Label lblLastNDays_Unit;
		private System.Windows.Forms.NumericUpDown numLastNDays;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.Label lblFrom;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckCustomer;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckMarket;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckPanel;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckStatus;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckTicket;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckNewTicket;
		private System.Windows.Forms.Panel pnlDateRange_Range;
		private System.Windows.Forms.Panel pnlDateRange_LastDays;
		private System.Windows.Forms.RadioButton radDateRange_LastDays;
		private System.Windows.Forms.RadioButton radDateRange_Range;
		private System.Windows.Forms.Panel pnlDateRange_Selectors;
		private System.Windows.Forms.CheckBox chkFailsOnly;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckImageName;
		private System.Windows.Forms.Timer timerImageLoad;
		private System.Windows.Forms.Panel pnlDetail;
		private System.Windows.Forms.PictureBox pbCameraImage;
		private System.Windows.Forms.Button btnShowMenu;
		private System.Windows.Forms.Label lblDetail;
		private BrightIdeasSoftware.OLVColumn olcCameraCheckSymptom;
		private System.Windows.Forms.Panel pnlCameraImage;
	}
}