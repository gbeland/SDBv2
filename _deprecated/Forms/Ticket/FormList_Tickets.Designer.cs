namespace SDB.Forms.Ticket
{
	partial class FormList_Tickets
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvTickets = new BrightIdeasSoftware.ObjectListView();
			this.olcTicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAssetName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcOpenDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcIssue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcReportedType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcSymptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcSolution = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTech = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTechOnSite = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTOSTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCloseDT = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcDuration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcIsHeld = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.pnlSubControlRight = new System.Windows.Forms.Panel();
			this.pnlKey = new System.Windows.Forms.Panel();
			this.lblKey_Deleted = new System.Windows.Forms.Label();
			this.lblKey_Closed = new System.Windows.Forms.Label();
			this.lblKey_Held = new System.Windows.Forms.Label();
			this.lblKey_Open = new System.Windows.Forms.Label();
			this.lblKey_OpenOsa = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.txtTicketQty = new System.Windows.Forms.TextBox();
			this.lblTicketQty = new System.Windows.Forms.Label();
			this.pnlSubControlLeft = new System.Windows.Forms.Panel();
			this.lblView = new System.Windows.Forms.Label();
			this.radOpen = new System.Windows.Forms.RadioButton();
			this.radClosed = new System.Windows.Forms.RadioButton();
			this.radDeleted = new System.Windows.Forms.RadioButton();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlPagination = new System.Windows.Forms.Panel();
			this.lblPageMax = new System.Windows.Forms.Label();
			this.lblPage = new System.Windows.Forms.Label();
			this.cmbPage = new System.Windows.Forms.ComboBox();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.pnlSubControlRight.SuspendLayout();
			this.pnlKey.SuspendLayout();
			this.pnlSubControlLeft.SuspendLayout();
			this.pnlPagination.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(816, 531);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(897, 531);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.Controls.Add(this.olvTickets);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(960, 501);
			this.pnlContainer.TabIndex = 0;
			// 
			// olvTickets
			// 
			this.olvTickets.AllColumns.Add(this.olcTicketID);
			this.olvTickets.AllColumns.Add(this.olcAssetName);
			this.olvTickets.AllColumns.Add(this.olcOpenDateTime);
			this.olvTickets.AllColumns.Add(this.olcIssue);
			this.olvTickets.AllColumns.Add(this.olcReportedType);
			this.olvTickets.AllColumns.Add(this.olcSymptoms);
			this.olvTickets.AllColumns.Add(this.olcSolution);
			this.olvTickets.AllColumns.Add(this.olcTech);
			this.olvTickets.AllColumns.Add(this.olcTechOnSite);
			this.olvTickets.AllColumns.Add(this.olcTOSTime);
			this.olvTickets.AllColumns.Add(this.olcCloseDT);
			this.olvTickets.AllColumns.Add(this.olcDuration);
			this.olvTickets.AllColumns.Add(this.olcIsHeld);
			this.olvTickets.AllowColumnReorder = true;
			this.olvTickets.CellEditUseWholeCell = false;
			this.olvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcTicketID,
            this.olcAssetName,
            this.olcOpenDateTime,
            this.olcIssue,
            this.olcReportedType,
            this.olcSymptoms,
            this.olcSolution,
            this.olcTech,
            this.olcTechOnSite,
            this.olcTOSTime,
            this.olcCloseDT,
            this.olcDuration,
            this.olcIsHeld});
			this.olvTickets.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvTickets.EmptyListMsg = "No tickets found.";
			this.olvTickets.FullRowSelect = true;
			this.olvTickets.GridLines = true;
			this.olvTickets.HeaderWordWrap = true;
			this.olvTickets.HideSelection = false;
			this.olvTickets.Location = new System.Drawing.Point(0, 30);
			this.olvTickets.MultiSelect = false;
			this.olvTickets.Name = "olvTickets";
			this.olvTickets.SelectAllOnControlA = false;
			this.olvTickets.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvTickets.ShowCommandMenuOnRightClick = true;
			this.olvTickets.ShowGroups = false;
			this.olvTickets.ShowItemCountOnGroups = true;
			this.olvTickets.Size = new System.Drawing.Size(960, 471);
			this.olvTickets.SortGroupItemsByPrimaryColumn = false;
			this.olvTickets.TabIndex = 4;
			this.olvTickets.UseCompatibleStateImageBehavior = false;
			this.olvTickets.UseFilterIndicator = true;
			this.olvTickets.UseFiltering = true;
			this.olvTickets.UseOverlays = false;
			this.olvTickets.View = System.Windows.Forms.View.Details;
			this.olvTickets.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvTickets_FormatRow);
			this.olvTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTickets_MouseDoubleClick);
			// 
			// olcTicketID
			// 
			this.olcTicketID.AspectName = "ID";
			this.olcTicketID.Text = "Ticket";
			this.olcTicketID.UseFiltering = false;
			this.olcTicketID.Width = 55;
			// 
			// olcAssetName
			// 
			this.olcAssetName.AspectName = "ExtraProperties.AssetName";
			this.olcAssetName.Text = "Asset";
			this.olcAssetName.Width = 80;
			// 
			// olcOpenDateTime
			// 
			this.olcOpenDateTime.AspectName = "OpenDateTime";
			this.olcOpenDateTime.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olcOpenDateTime.Text = "Opened";
			this.olcOpenDateTime.Width = 100;
			// 
			// olcIssue
			// 
			this.olcIssue.AspectName = "CustomerIssueNumber";
			this.olcIssue.Text = "Issue";
			this.olcIssue.UseFiltering = false;
			// 
			// olcReportedType
			// 
			this.olcReportedType.AspectName = "ReportedType";
			this.olcReportedType.Text = "Reported";
			this.olcReportedType.ToolTipText = "Reported Type";
			// 
			// olcSymptoms
			// 
			this.olcSymptoms.AspectName = "ExtraProperties.Symptoms";
			this.olcSymptoms.Text = "Symptom(s)";
			this.olcSymptoms.Width = 190;
			// 
			// olcSolution
			// 
			this.olcSolution.AspectName = "ExtraProperties.Solutions";
			this.olcSolution.Text = "Solution(s)";
			this.olcSolution.Width = 190;
			// 
			// olcTech
			// 
			this.olcTech.AspectName = "ExtraProperties.AssignedTechName";
			this.olcTech.Text = "Tech";
			this.olcTech.Width = 150;
			// 
			// olcTechOnSite
			// 
			this.olcTechOnSite.AspectName = "FirstTechArrivalDateTime";
			this.olcTechOnSite.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olcTechOnSite.Text = "First TOS";
			this.olcTechOnSite.ToolTipText = "First Tech on Site";
			this.olcTechOnSite.Width = 100;
			// 
			// olcTOSTime
			// 
			this.olcTOSTime.AspectName = "TechArrivedDuration";
			this.olcTOSTime.Text = "TOS Dur";
			this.olcTOSTime.ToolTipText = "Time between ticket open and first tech on site.";
			this.olcTOSTime.UseFiltering = false;
			this.olcTOSTime.Width = 100;
			// 
			// olcCloseDT
			// 
			this.olcCloseDT.AspectName = "CloseDateTime";
			this.olcCloseDT.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olcCloseDT.Text = "Closed";
			this.olcCloseDT.Width = 100;
			// 
			// olcDuration
			// 
			this.olcDuration.AspectName = "Duration";
			this.olcDuration.AspectToStringFormat = "";
			this.olcDuration.Text = "Duration";
			this.olcDuration.UseFiltering = false;
			this.olcDuration.Width = 100;
			// 
			// olcIsHeld
			// 
			this.olcIsHeld.AspectName = "IsHeld";
			this.olcIsHeld.Text = "Held";
			this.olcIsHeld.Width = 75;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.pnlSubControlRight);
			this.pnlControl.Controls.Add(this.pnlSubControlLeft);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(960, 30);
			this.pnlControl.TabIndex = 7;
			// 
			// pnlSubControlRight
			// 
			this.pnlSubControlRight.Controls.Add(this.pnlKey);
			this.pnlSubControlRight.Controls.Add(this.btnExport);
			this.pnlSubControlRight.Controls.Add(this.txtTicketQty);
			this.pnlSubControlRight.Controls.Add(this.lblTicketQty);
			this.pnlSubControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlSubControlRight.Location = new System.Drawing.Point(261, 0);
			this.pnlSubControlRight.Name = "pnlSubControlRight";
			this.pnlSubControlRight.Size = new System.Drawing.Size(699, 30);
			this.pnlSubControlRight.TabIndex = 18;
			// 
			// pnlKey
			// 
			this.pnlKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlKey.BackColor = System.Drawing.Color.White;
			this.pnlKey.Controls.Add(this.lblKey_Deleted);
			this.pnlKey.Controls.Add(this.lblKey_Closed);
			this.pnlKey.Controls.Add(this.lblKey_Held);
			this.pnlKey.Controls.Add(this.lblKey_Open);
			this.pnlKey.Controls.Add(this.lblKey_OpenOsa);
			this.pnlKey.Location = new System.Drawing.Point(239, 2);
			this.pnlKey.Name = "pnlKey";
			this.pnlKey.Size = new System.Drawing.Size(290, 26);
			this.pnlKey.TabIndex = 17;
			// 
			// lblKey_Deleted
			// 
			this.lblKey_Deleted.AutoSize = true;
			this.lblKey_Deleted.Location = new System.Drawing.Point(240, 7);
			this.lblKey_Deleted.Name = "lblKey_Deleted";
			this.lblKey_Deleted.Size = new System.Drawing.Size(44, 13);
			this.lblKey_Deleted.TabIndex = 9;
			this.lblKey_Deleted.Text = "Deleted";
			// 
			// lblKey_Closed
			// 
			this.lblKey_Closed.AutoSize = true;
			this.lblKey_Closed.Location = new System.Drawing.Point(183, 7);
			this.lblKey_Closed.Name = "lblKey_Closed";
			this.lblKey_Closed.Size = new System.Drawing.Size(39, 13);
			this.lblKey_Closed.TabIndex = 8;
			this.lblKey_Closed.Text = "Closed";
			// 
			// lblKey_Held
			// 
			this.lblKey_Held.AutoSize = true;
			this.lblKey_Held.Location = new System.Drawing.Point(136, 7);
			this.lblKey_Held.Name = "lblKey_Held";
			this.lblKey_Held.Size = new System.Drawing.Size(29, 13);
			this.lblKey_Held.TabIndex = 6;
			this.lblKey_Held.Text = "Held";
			// 
			// lblKey_Open
			// 
			this.lblKey_Open.AutoSize = true;
			this.lblKey_Open.Location = new System.Drawing.Point(85, 7);
			this.lblKey_Open.Name = "lblKey_Open";
			this.lblKey_Open.Size = new System.Drawing.Size(33, 13);
			this.lblKey_Open.TabIndex = 4;
			this.lblKey_Open.Text = "Open";
			// 
			// lblKey_OpenOsa
			// 
			this.lblKey_OpenOsa.AutoSize = true;
			this.lblKey_OpenOsa.Location = new System.Drawing.Point(6, 7);
			this.lblKey_OpenOsa.Name = "lblKey_OpenOsa";
			this.lblKey_OpenOsa.Size = new System.Drawing.Size(61, 13);
			this.lblKey_OpenOsa.TabIndex = 2;
			this.lblKey_OpenOsa.Text = "Open+OSA";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(3, 3);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(100, 23);
			this.btnExport.TabIndex = 15;
			this.btnExport.Text = "&Export to file...";
			this.toolTip1.SetToolTip(this.btnExport, "Export current page of data to a file.");
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// txtTicketQty
			// 
			this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTicketQty.Location = new System.Drawing.Point(636, 3);
			this.txtTicketQty.Name = "txtTicketQty";
			this.txtTicketQty.ReadOnly = true;
			this.txtTicketQty.Size = new System.Drawing.Size(60, 22);
			this.txtTicketQty.TabIndex = 8;
			this.txtTicketQty.TabStop = false;
			this.txtTicketQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblTicketQty
			// 
			this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTicketQty.AutoSize = true;
			this.lblTicketQty.Location = new System.Drawing.Point(585, 8);
			this.lblTicketQty.Name = "lblTicketQty";
			this.lblTicketQty.Size = new System.Drawing.Size(45, 13);
			this.lblTicketQty.TabIndex = 7;
			this.lblTicketQty.Text = "Tickets:";
			// 
			// pnlSubControlLeft
			// 
			this.pnlSubControlLeft.Controls.Add(this.lblView);
			this.pnlSubControlLeft.Controls.Add(this.radOpen);
			this.pnlSubControlLeft.Controls.Add(this.radClosed);
			this.pnlSubControlLeft.Controls.Add(this.radDeleted);
			this.pnlSubControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlSubControlLeft.Location = new System.Drawing.Point(0, 0);
			this.pnlSubControlLeft.Name = "pnlSubControlLeft";
			this.pnlSubControlLeft.Size = new System.Drawing.Size(261, 30);
			this.pnlSubControlLeft.TabIndex = 9;
			this.pnlSubControlLeft.Visible = false;
			// 
			// lblView
			// 
			this.lblView.AutoSize = true;
			this.lblView.Location = new System.Drawing.Point(3, 9);
			this.lblView.Name = "lblView";
			this.lblView.Size = new System.Drawing.Size(33, 13);
			this.lblView.TabIndex = 3;
			this.lblView.Text = "View:";
			// 
			// radOpen
			// 
			this.radOpen.AutoSize = true;
			this.radOpen.Checked = true;
			this.radOpen.Location = new System.Drawing.Point(42, 7);
			this.radOpen.Name = "radOpen";
			this.radOpen.Size = new System.Drawing.Size(78, 17);
			this.radOpen.TabIndex = 0;
			this.radOpen.TabStop = true;
			this.radOpen.Text = "Open/Held";
			this.radOpen.UseVisualStyleBackColor = true;
			this.radOpen.Click += new System.EventHandler(this.radOpen_Click);
			// 
			// radClosed
			// 
			this.radClosed.AutoSize = true;
			this.radClosed.Location = new System.Drawing.Point(126, 7);
			this.radClosed.Name = "radClosed";
			this.radClosed.Size = new System.Drawing.Size(57, 17);
			this.radClosed.TabIndex = 1;
			this.radClosed.Text = "Closed";
			this.radClosed.UseVisualStyleBackColor = true;
			this.radClosed.Click += new System.EventHandler(this.radClosed_Click);
			// 
			// radDeleted
			// 
			this.radDeleted.AutoSize = true;
			this.radDeleted.Location = new System.Drawing.Point(189, 7);
			this.radDeleted.Name = "radDeleted";
			this.radDeleted.Size = new System.Drawing.Size(62, 17);
			this.radDeleted.TabIndex = 2;
			this.radDeleted.Text = "Deleted";
			this.radDeleted.UseVisualStyleBackColor = true;
			this.radDeleted.Click += new System.EventHandler(this.radDeleted_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnPrevious.Location = new System.Drawing.Point(63, 5);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(50, 23);
			this.btnPrevious.TabIndex = 11;
			this.btnPrevious.Text = "<";
			this.toolTip1.SetToolTip(this.btnPrevious, "Previous page");
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNext.Location = new System.Drawing.Point(289, 5);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(50, 23);
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = ">";
			this.toolTip1.SetToolTip(this.btnNext, "Next page");
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// pnlPagination
			// 
			this.pnlPagination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pnlPagination.Controls.Add(this.lblPageMax);
			this.pnlPagination.Controls.Add(this.lblPage);
			this.pnlPagination.Controls.Add(this.cmbPage);
			this.pnlPagination.Controls.Add(this.btnLast);
			this.pnlPagination.Controls.Add(this.btnNext);
			this.pnlPagination.Controls.Add(this.btnFirst);
			this.pnlPagination.Controls.Add(this.btnPrevious);
			this.pnlPagination.Location = new System.Drawing.Point(292, 526);
			this.pnlPagination.Name = "pnlPagination";
			this.pnlPagination.Size = new System.Drawing.Size(400, 33);
			this.pnlPagination.TabIndex = 13;
			this.pnlPagination.Visible = false;
			// 
			// lblPageMax
			// 
			this.lblPageMax.AutoSize = true;
			this.lblPageMax.Location = new System.Drawing.Point(235, 10);
			this.lblPageMax.Name = "lblPageMax";
			this.lblPageMax.Size = new System.Drawing.Size(25, 13);
			this.lblPageMax.TabIndex = 15;
			this.lblPageMax.Text = "of 0";
			// 
			// lblPage
			// 
			this.lblPage.AutoSize = true;
			this.lblPage.Location = new System.Drawing.Point(141, 10);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new System.Drawing.Size(32, 13);
			this.lblPage.TabIndex = 14;
			this.lblPage.Text = "Page";
			// 
			// cmbPage
			// 
			this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPage.FormattingEnabled = true;
			this.cmbPage.Location = new System.Drawing.Point(179, 7);
			this.cmbPage.Name = "cmbPage";
			this.cmbPage.Size = new System.Drawing.Size(50, 21);
			this.cmbPage.TabIndex = 13;
			this.toolTip1.SetToolTip(this.cmbPage, "Select page");
			this.cmbPage.SelectedIndexChanged += new System.EventHandler(this.cmbPage_SelectedIndexChanged);
			// 
			// btnLast
			// 
			this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnLast.Location = new System.Drawing.Point(347, 5);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(50, 23);
			this.btnLast.TabIndex = 10;
			this.btnLast.Text = ">|";
			this.toolTip1.SetToolTip(this.btnLast, "Last page");
			this.btnLast.UseVisualStyleBackColor = true;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnFirst.Location = new System.Drawing.Point(5, 5);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(50, 23);
			this.btnFirst.TabIndex = 11;
			this.btnFirst.Text = "|<";
			this.toolTip1.SetToolTip(this.btnFirst, "First page");
			this.btnFirst.UseVisualStyleBackColor = true;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// FormList_Tickets
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(984, 562);
			this.Controls.Add(this.pnlPagination);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 400);
			this.Name = "FormList_Tickets";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "List: Tickets";
			this.Shown += new System.EventHandler(this.FormList_Tickets_Shown);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlSubControlRight.ResumeLayout(false);
			this.pnlSubControlRight.PerformLayout();
			this.pnlKey.ResumeLayout(false);
			this.pnlKey.PerformLayout();
			this.pnlSubControlLeft.ResumeLayout(false);
			this.pnlSubControlLeft.PerformLayout();
			this.pnlPagination.ResumeLayout(false);
			this.pnlPagination.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvTickets;
		private BrightIdeasSoftware.OLVColumn olcTicketID;
		private BrightIdeasSoftware.OLVColumn olcOpenDateTime;
		private BrightIdeasSoftware.OLVColumn olcIssue;
		private BrightIdeasSoftware.OLVColumn olcSymptoms;
		private BrightIdeasSoftware.OLVColumn olcSolution;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblView;
		private System.Windows.Forms.RadioButton radDeleted;
		private System.Windows.Forms.RadioButton radClosed;
		private System.Windows.Forms.RadioButton radOpen;
		private BrightIdeasSoftware.OLVColumn olcTech;
		private BrightIdeasSoftware.OLVColumn olcCloseDT;
		private BrightIdeasSoftware.OLVColumn olcDuration;
		private System.Windows.Forms.Label lblTicketQty;
		private System.Windows.Forms.TextBox txtTicketQty;
		private System.Windows.Forms.Panel pnlSubControlLeft;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnExport;
		private BrightIdeasSoftware.OLVColumn olcTechOnSite;
		private BrightIdeasSoftware.OLVColumn olcTOSTime;
		private BrightIdeasSoftware.OLVColumn olcIsHeld;
		private System.Windows.Forms.Panel pnlSubControlRight;
		private BrightIdeasSoftware.OLVColumn olcAssetName;
		private BrightIdeasSoftware.OLVColumn olcReportedType;
		private System.Windows.Forms.Panel pnlPagination;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Panel pnlKey;
		private System.Windows.Forms.Label lblKey_Closed;
		private System.Windows.Forms.Label lblKey_Held;
		private System.Windows.Forms.Label lblKey_Open;
		private System.Windows.Forms.Label lblKey_OpenOsa;
		private System.Windows.Forms.Label lblKey_Deleted;
		private System.Windows.Forms.ComboBox cmbPage;
		private System.Windows.Forms.Label lblPageMax;
		private System.Windows.Forms.Label lblPage;
	}
}