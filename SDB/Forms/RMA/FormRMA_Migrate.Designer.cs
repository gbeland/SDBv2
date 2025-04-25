namespace SDB.Forms.RMA
{
	partial class FormRMA_Migrate
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
			this.lblRmaNumber = new System.Windows.Forms.Label();
			this.txtRmaNumber = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.pnlLeft = new System.Windows.Forms.Panel();
			this.olvAssemblies = new BrightIdeasSoftware.ObjectListView();
			this.olvColReceive_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReceive_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReceive_AssemblySerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReceive_Receive_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReceive_Receive_User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColZone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColReceive_BinID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuUndoAssyMigrate = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlAssemblies_Control = new System.Windows.Forms.Panel();
			this.lblSelectedAssemblyID = new System.Windows.Forms.Label();
			this.txtTotalAssyQty = new System.Windows.Forms.TextBox();
			this.txtReceivedQty = new System.Windows.Forms.TextBox();
			this.lblReceive_ReceivedQty = new System.Windows.Forms.Label();
			this.pnlRight = new System.Windows.Forms.Panel();
			this.btnCreateBin = new System.Windows.Forms.Button();
			this.btnSelectBin = new System.Windows.Forms.Button();
			this.btnDeleteBin = new System.Windows.Forms.Button();
			this.btnPrintBinLabels_Current = new System.Windows.Forms.Button();
			this.btnPrintBinLabels_All = new System.Windows.Forms.Button();
			this.lblCurrentBinID = new System.Windows.Forms.Label();
			this.txtCurrentBinID = new System.Windows.Forms.TextBox();
			this.lblAssemblySerialNumber = new System.Windows.Forms.Label();
			this.btnMigrate = new System.Windows.Forms.Button();
			this.txtAssemblySerialNumber = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblInfo = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblBinAssyQty = new System.Windows.Forms.Label();
			this.pnlLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.pnlAssemblies_Control.SuspendLayout();
			this.pnlRight.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblRmaNumber
			// 
			this.lblRmaNumber.AutoSize = true;
			this.lblRmaNumber.Location = new System.Drawing.Point(28, 19);
			this.lblRmaNumber.Name = "lblRmaNumber";
			this.lblRmaNumber.Size = new System.Drawing.Size(71, 13);
			this.lblRmaNumber.TabIndex = 0;
			this.lblRmaNumber.Text = "RMA &Number";
			// 
			// txtRmaNumber
			// 
			this.txtRmaNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRmaNumber.Location = new System.Drawing.Point(105, 12);
			this.txtRmaNumber.Name = "txtRmaNumber";
			this.txtRmaNumber.Size = new System.Drawing.Size(146, 26);
			this.txtRmaNumber.TabIndex = 1;
			this.txtRmaNumber.Enter += new System.EventHandler(this.txtRmaNumber_Enter);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(257, 14);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(75, 23);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "&Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// pnlLeft
			// 
			this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLeft.Controls.Add(this.olvAssemblies);
			this.pnlLeft.Controls.Add(this.pnlAssemblies_Control);
			this.pnlLeft.Location = new System.Drawing.Point(12, 71);
			this.pnlLeft.Name = "pnlLeft";
			this.pnlLeft.Size = new System.Drawing.Size(810, 391);
			this.pnlLeft.TabIndex = 34;
			// 
			// olvAssemblies
			// 
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_Description);
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_FailureType);
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_AssemblySerialNumber);
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_Receive_Date);
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_Receive_User);
			this.olvAssemblies.AllColumns.Add(this.olvColZone);
			this.olvAssemblies.AllColumns.Add(this.olvColReceive_BinID);
			this.olvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColReceive_Description,
            this.olvColReceive_FailureType,
            this.olvColReceive_AssemblySerialNumber,
            this.olvColReceive_Receive_Date,
            this.olvColReceive_Receive_User,
            this.olvColZone,
            this.olvColReceive_BinID});
			this.olvAssemblies.ContextMenuStrip = this.contextMenuStrip1;
			this.olvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvAssemblies.FullRowSelect = true;
			this.olvAssemblies.GridLines = true;
			this.olvAssemblies.HideSelection = false;
			this.olvAssemblies.Location = new System.Drawing.Point(0, 30);
			this.olvAssemblies.MultiSelect = false;
			this.olvAssemblies.Name = "olvAssemblies";
			this.olvAssemblies.OwnerDraw = true;
			this.olvAssemblies.ShowGroups = false;
			this.olvAssemblies.Size = new System.Drawing.Size(810, 361);
			this.olvAssemblies.TabIndex = 1;
			this.olvAssemblies.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
			this.olvAssemblies.UseCompatibleStateImageBehavior = false;
			this.olvAssemblies.View = System.Windows.Forms.View.Details;
			this.olvAssemblies.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvAssemblies_FormatRow);
			this.olvAssemblies.SelectedIndexChanged += new System.EventHandler(this.olvAssemblies_SelectedIndexChanged);
			this.olvAssemblies.Click += new System.EventHandler(this.olvAssemblies_Click);
			// 
			// olvColReceive_Description
			// 
			this.olvColReceive_Description.AspectName = "Description";
			this.olvColReceive_Description.CellPadding = null;
			this.olvColReceive_Description.Text = "Assembly";
			this.olvColReceive_Description.Width = 260;
			// 
			// olvColReceive_FailureType
			// 
			this.olvColReceive_FailureType.AspectName = "FailureTypeDescription";
			this.olvColReceive_FailureType.CellPadding = null;
			this.olvColReceive_FailureType.Text = "Failure Type";
			this.olvColReceive_FailureType.Width = 180;
			// 
			// olvColReceive_AssemblySerialNumber
			// 
			this.olvColReceive_AssemblySerialNumber.AspectName = "SerialNumber";
			this.olvColReceive_AssemblySerialNumber.CellPadding = null;
			this.olvColReceive_AssemblySerialNumber.Text = "Serial Number";
			this.olvColReceive_AssemblySerialNumber.Width = 90;
			// 
			// olvColReceive_Receive_Date
			// 
			this.olvColReceive_Receive_Date.AspectName = "Receive_Date";
			this.olvColReceive_Receive_Date.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColReceive_Receive_Date.CellPadding = null;
			this.olvColReceive_Receive_Date.Text = "Received";
			this.olvColReceive_Receive_Date.Width = 70;
			// 
			// olvColReceive_Receive_User
			// 
			this.olvColReceive_Receive_User.AspectName = "Receive_UserName";
			this.olvColReceive_Receive_User.CellPadding = null;
			this.olvColReceive_Receive_User.Text = "By";
			this.olvColReceive_Receive_User.Width = 65;
			// 
			// olvColZone
			// 
			this.olvColZone.AspectName = "Receive_Zone";
			this.olvColZone.CellPadding = null;
			this.olvColZone.Text = "Old Zone";
			// 
			// olvColReceive_BinID
			// 
			this.olvColReceive_BinID.AspectName = "AssignedBinID";
			this.olvColReceive_BinID.CellPadding = null;
			this.olvColReceive_BinID.Text = "Bin";
			this.olvColReceive_BinID.Width = 75;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndoAssyMigrate});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(211, 26);
			// 
			// mnuUndoAssyMigrate
			// 
			this.mnuUndoAssyMigrate.Name = "mnuUndoAssyMigrate";
			this.mnuUndoAssyMigrate.Size = new System.Drawing.Size(210, 22);
			this.mnuUndoAssyMigrate.Text = "Undo Assembly Migrate...";
			this.mnuUndoAssyMigrate.Click += new System.EventHandler(this.mnuUndoAssyMigrate_Click);
			// 
			// pnlAssemblies_Control
			// 
			this.pnlAssemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlAssemblies_Control.Controls.Add(this.lblSelectedAssemblyID);
			this.pnlAssemblies_Control.Controls.Add(this.txtTotalAssyQty);
			this.pnlAssemblies_Control.Controls.Add(this.txtReceivedQty);
			this.pnlAssemblies_Control.Controls.Add(this.lblReceive_ReceivedQty);
			this.pnlAssemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAssemblies_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlAssemblies_Control.Name = "pnlAssemblies_Control";
			this.pnlAssemblies_Control.Size = new System.Drawing.Size(810, 30);
			this.pnlAssemblies_Control.TabIndex = 2;
			// 
			// lblSelectedAssemblyID
			// 
			this.lblSelectedAssemblyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblSelectedAssemblyID.Location = new System.Drawing.Point(3, 8);
			this.lblSelectedAssemblyID.Name = "lblSelectedAssemblyID";
			this.lblSelectedAssemblyID.Size = new System.Drawing.Size(54, 13);
			this.lblSelectedAssemblyID.TabIndex = 29;
			// 
			// txtTotalAssyQty
			// 
			this.txtTotalAssyQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalAssyQty.Location = new System.Drawing.Point(762, 6);
			this.txtTotalAssyQty.Name = "txtTotalAssyQty";
			this.txtTotalAssyQty.ReadOnly = true;
			this.txtTotalAssyQty.Size = new System.Drawing.Size(42, 20);
			this.txtTotalAssyQty.TabIndex = 28;
			// 
			// txtReceivedQty
			// 
			this.txtReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtReceivedQty.Location = new System.Drawing.Point(648, 6);
			this.txtReceivedQty.Name = "txtReceivedQty";
			this.txtReceivedQty.ReadOnly = true;
			this.txtReceivedQty.Size = new System.Drawing.Size(42, 20);
			this.txtReceivedQty.TabIndex = 26;
			// 
			// lblReceive_ReceivedQty
			// 
			this.lblReceive_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblReceive_ReceivedQty.AutoSize = true;
			this.lblReceive_ReceivedQty.Location = new System.Drawing.Point(696, 9);
			this.lblReceive_ReceivedQty.Name = "lblReceive_ReceivedQty";
			this.lblReceive_ReceivedQty.Size = new System.Drawing.Size(60, 13);
			this.lblReceive_ReceivedQty.TabIndex = 27;
			this.lblReceive_ReceivedQty.Text = "received of";
			// 
			// pnlRight
			// 
			this.pnlRight.Controls.Add(this.lblBinAssyQty);
			this.pnlRight.Controls.Add(this.btnCreateBin);
			this.pnlRight.Controls.Add(this.btnSelectBin);
			this.pnlRight.Controls.Add(this.btnDeleteBin);
			this.pnlRight.Controls.Add(this.btnPrintBinLabels_Current);
			this.pnlRight.Controls.Add(this.btnPrintBinLabels_All);
			this.pnlRight.Controls.Add(this.lblCurrentBinID);
			this.pnlRight.Controls.Add(this.txtCurrentBinID);
			this.pnlRight.Controls.Add(this.lblAssemblySerialNumber);
			this.pnlRight.Controls.Add(this.btnMigrate);
			this.pnlRight.Controls.Add(this.txtAssemblySerialNumber);
			this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlRight.Location = new System.Drawing.Point(828, 0);
			this.pnlRight.Name = "pnlRight";
			this.pnlRight.Size = new System.Drawing.Size(180, 474);
			this.pnlRight.TabIndex = 35;
			// 
			// btnCreateBin
			// 
			this.btnCreateBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreateBin.Location = new System.Drawing.Point(7, 60);
			this.btnCreateBin.Name = "btnCreateBin";
			this.btnCreateBin.Size = new System.Drawing.Size(167, 30);
			this.btnCreateBin.TabIndex = 42;
			this.btnCreateBin.Text = "&Create New Bin";
			this.toolTip1.SetToolTip(this.btnCreateBin, "Creates a new empty bin.");
			this.btnCreateBin.UseVisualStyleBackColor = false;
			this.btnCreateBin.Click += new System.EventHandler(this.btnReceive_CreateBin_Click);
			// 
			// btnSelectBin
			// 
			this.btnSelectBin.Location = new System.Drawing.Point(7, 96);
			this.btnSelectBin.Name = "btnSelectBin";
			this.btnSelectBin.Size = new System.Drawing.Size(167, 30);
			this.btnSelectBin.TabIndex = 41;
			this.btnSelectBin.Text = "&Select Existing Bin";
			this.toolTip1.SetToolTip(this.btnSelectBin, "Select an existing bin by entering or scanning its ID.");
			this.btnSelectBin.UseVisualStyleBackColor = false;
			this.btnSelectBin.Click += new System.EventHandler(this.btnReceive_SelectBox_Click);
			// 
			// btnDeleteBin
			// 
			this.btnDeleteBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDeleteBin.Location = new System.Drawing.Point(46, 132);
			this.btnDeleteBin.Name = "btnDeleteBin";
			this.btnDeleteBin.Size = new System.Drawing.Size(90, 23);
			this.btnDeleteBin.TabIndex = 40;
			this.btnDeleteBin.Text = "&Delete Bin";
			this.toolTip1.SetToolTip(this.btnDeleteBin, "Deletes currently selected bin. Note that it must be empty.");
			this.btnDeleteBin.UseVisualStyleBackColor = false;
			this.btnDeleteBin.Click += new System.EventHandler(this.btnReceive_DeleteBin_Click);
			// 
			// btnPrintBinLabels_Current
			// 
			this.btnPrintBinLabels_Current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintBinLabels_Current.Location = new System.Drawing.Point(7, 443);
			this.btnPrintBinLabels_Current.Name = "btnPrintBinLabels_Current";
			this.btnPrintBinLabels_Current.Size = new System.Drawing.Size(165, 23);
			this.btnPrintBinLabels_Current.TabIndex = 39;
			this.btnPrintBinLabels_Current.Text = "Print Selected &Bin Label";
			this.toolTip1.SetToolTip(this.btnPrintBinLabels_Current, "Prints the currently selected bin label.");
			this.btnPrintBinLabels_Current.UseVisualStyleBackColor = true;
			this.btnPrintBinLabels_Current.Click += new System.EventHandler(this.btnPrintBinLabels_Current_Click);
			// 
			// btnPrintBinLabels_All
			// 
			this.btnPrintBinLabels_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintBinLabels_All.Location = new System.Drawing.Point(7, 389);
			this.btnPrintBinLabels_All.Name = "btnPrintBinLabels_All";
			this.btnPrintBinLabels_All.Size = new System.Drawing.Size(165, 48);
			this.btnPrintBinLabels_All.TabIndex = 36;
			this.btnPrintBinLabels_All.Text = "Print &All Bin Labels";
			this.toolTip1.SetToolTip(this.btnPrintBinLabels_All, "Prints labels for all bins containing assemblies for this RMA.");
			this.btnPrintBinLabels_All.UseVisualStyleBackColor = true;
			this.btnPrintBinLabels_All.Click += new System.EventHandler(this.btnPrintBinLabels_All_Click);
			// 
			// lblCurrentBinID
			// 
			this.lblCurrentBinID.AutoSize = true;
			this.lblCurrentBinID.Location = new System.Drawing.Point(7, 6);
			this.lblCurrentBinID.Name = "lblCurrentBinID";
			this.lblCurrentBinID.Size = new System.Drawing.Size(67, 13);
			this.lblCurrentBinID.TabIndex = 34;
			this.lblCurrentBinID.Text = "Selected Bin";
			// 
			// txtCurrentBinID
			// 
			this.txtCurrentBinID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrentBinID.Location = new System.Drawing.Point(7, 22);
			this.txtCurrentBinID.MaxLength = 10;
			this.txtCurrentBinID.Name = "txtCurrentBinID";
			this.txtCurrentBinID.ReadOnly = true;
			this.txtCurrentBinID.Size = new System.Drawing.Size(167, 32);
			this.txtCurrentBinID.TabIndex = 33;
			this.txtCurrentBinID.Text = "NONE";
			this.txtCurrentBinID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblAssemblySerialNumber
			// 
			this.lblAssemblySerialNumber.AutoSize = true;
			this.lblAssemblySerialNumber.Location = new System.Drawing.Point(7, 217);
			this.lblAssemblySerialNumber.Name = "lblAssemblySerialNumber";
			this.lblAssemblySerialNumber.Size = new System.Drawing.Size(90, 13);
			this.lblAssemblySerialNumber.TabIndex = 31;
			this.lblAssemblySerialNumber.Text = "Assembly Serial #";
			// 
			// btnMigrate
			// 
			this.btnMigrate.Enabled = false;
			this.btnMigrate.Location = new System.Drawing.Point(7, 259);
			this.btnMigrate.Name = "btnMigrate";
			this.btnMigrate.Size = new System.Drawing.Size(167, 48);
			this.btnMigrate.TabIndex = 20;
			this.btnMigrate.Text = "&Record and Migrate";
			this.toolTip1.SetToolTip(this.btnMigrate, "Record serial number and migrate selected assembly to selected bin.");
			this.btnMigrate.UseVisualStyleBackColor = true;
			this.btnMigrate.Click += new System.EventHandler(this.btnMigrate_Click);
			// 
			// txtAssemblySerialNumber
			// 
			this.txtAssemblySerialNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAssemblySerialNumber.Location = new System.Drawing.Point(7, 233);
			this.txtAssemblySerialNumber.MaxLength = 16;
			this.txtAssemblySerialNumber.Name = "txtAssemblySerialNumber";
			this.txtAssemblySerialNumber.ReadOnly = true;
			this.txtAssemblySerialNumber.Size = new System.Drawing.Size(167, 20);
			this.txtAssemblySerialNumber.TabIndex = 32;
			this.txtAssemblySerialNumber.Enter += new System.EventHandler(this.txtAssemblySerialNumber_Enter);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(747, 14);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 37;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblInfo
			// 
			this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(12, 44);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(810, 24);
			this.lblInfo.TabIndex = 38;
			this.lblInfo.Text = "This form migrates existing assemblies to the new barcoded bin system, without ch" +
    "anging the receive date.";
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBinAssyQty
			// 
			this.lblBinAssyQty.Location = new System.Drawing.Point(107, 6);
			this.lblBinAssyQty.Name = "lblBinAssyQty";
			this.lblBinAssyQty.Size = new System.Drawing.Size(67, 13);
			this.lblBinAssyQty.TabIndex = 43;
			this.lblBinAssyQty.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FormRMAMigrate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1008, 474);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlLeft);
			this.Controls.Add(this.pnlRight);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtRmaNumber);
			this.Controls.Add(this.lblRmaNumber);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1024, 512);
			this.Name = "FormRMAMigrate";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RMA Inventory Migration";
			this.pnlLeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.pnlAssemblies_Control.ResumeLayout(false);
			this.pnlAssemblies_Control.PerformLayout();
			this.pnlRight.ResumeLayout(false);
			this.pnlRight.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRmaNumber;
		private System.Windows.Forms.TextBox txtRmaNumber;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Panel pnlLeft;
		private BrightIdeasSoftware.ObjectListView olvAssemblies;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Description;
		private BrightIdeasSoftware.OLVColumn olvColReceive_FailureType;
		private BrightIdeasSoftware.OLVColumn olvColReceive_AssemblySerialNumber;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_Date;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_User;
		private BrightIdeasSoftware.OLVColumn olvColZone;
		private BrightIdeasSoftware.OLVColumn olvColReceive_BinID;
		private System.Windows.Forms.Panel pnlAssemblies_Control;
		private System.Windows.Forms.Label lblSelectedAssemblyID;
		private System.Windows.Forms.TextBox txtTotalAssyQty;
		private System.Windows.Forms.TextBox txtReceivedQty;
		private System.Windows.Forms.Label lblReceive_ReceivedQty;
		private System.Windows.Forms.Panel pnlRight;
		private System.Windows.Forms.Button btnCreateBin;
		private System.Windows.Forms.Button btnSelectBin;
		private System.Windows.Forms.Button btnDeleteBin;
		private System.Windows.Forms.Button btnPrintBinLabels_Current;
		private System.Windows.Forms.Button btnPrintBinLabels_All;
		private System.Windows.Forms.Label lblCurrentBinID;
		private System.Windows.Forms.TextBox txtCurrentBinID;
		private System.Windows.Forms.Label lblAssemblySerialNumber;
		private System.Windows.Forms.Button btnMigrate;
		private System.Windows.Forms.TextBox txtAssemblySerialNumber;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuUndoAssyMigrate;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblBinAssyQty;
	}
}