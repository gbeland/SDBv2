namespace SDB.Forms.RMA
{
	partial class FormRMA_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMA_Modify));
            this.grpRMADetails = new System.Windows.Forms.GroupBox();
            this.cmbTechs = new System.Windows.Forms.ComboBox();
            this.pnlPending = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radPending_Production = new System.Windows.Forms.RadioButton();
            this.txtPendingReason = new System.Windows.Forms.TextBox();
            this.radPending_Engineering = new System.Windows.Forms.RadioButton();
            this.chkPending = new System.Windows.Forms.CheckBox();
            this.lblRMADetails_RMANumber = new System.Windows.Forms.Label();
            this.txtRMANumber = new System.Windows.Forms.TextBox();
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.chkAPR = new System.Windows.Forms.CheckBox();
            this.txtLegacyRMA = new System.Windows.Forms.TextBox();
            this.lblLegacyRMA = new System.Windows.Forms.Label();
            this.radPONumber = new System.Windows.Forms.RadioButton();
            this.radJobNumber = new System.Windows.Forms.RadioButton();
            this.txtJob_PO = new System.Windows.Forms.TextBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.lblAsset = new System.Windows.Forms.Label();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAssemblyTypes = new System.Windows.Forms.GroupBox();
            this.olvAssemblies = new BrightIdeasSoftware.ObjectListView();
            this.olcAssy_Assembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDiscarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcFailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcGrid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcRepairStarted = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcRepairCompleted = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcRepairBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcFinalized = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlAssemblies_Control = new System.Windows.Forms.Panel();
            this.btnAssembly_Remove = new System.Windows.Forms.Button();
            this.lblAssemblies_Qty = new System.Windows.Forms.Label();
            this.txtAssemblies_Qty = new System.Windows.Forms.TextBox();
            this.btnAssembly_Add = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpRMADetails.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.grpAssemblyTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).BeginInit();
            this.pnlAssemblies_Control.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRMADetails
            // 
            this.grpRMADetails.Controls.Add(this.cmbTechs);
            this.grpRMADetails.Controls.Add(this.pnlPending);
            this.grpRMADetails.Controls.Add(this.chkPending);
            this.grpRMADetails.Controls.Add(this.lblRMADetails_RMANumber);
            this.grpRMADetails.Controls.Add(this.txtRMANumber);
            this.grpRMADetails.Controls.Add(this.chkSendEmail);
            this.grpRMADetails.Controls.Add(this.chkHot);
            this.grpRMADetails.Controls.Add(this.chkAPR);
            this.grpRMADetails.Controls.Add(this.txtLegacyRMA);
            this.grpRMADetails.Controls.Add(this.lblLegacyRMA);
            this.grpRMADetails.Controls.Add(this.radPONumber);
            this.grpRMADetails.Controls.Add(this.radJobNumber);
            this.grpRMADetails.Controls.Add(this.txtJob_PO);
            this.grpRMADetails.Controls.Add(this.lblAssignedTo);
            this.grpRMADetails.Controls.Add(this.lblAsset);
            this.grpRMADetails.Controls.Add(this.txtAsset);
            this.grpRMADetails.Controls.Add(this.lblTicketID);
            this.grpRMADetails.Controls.Add(this.txtTicketID);
            this.grpRMADetails.Location = new System.Drawing.Point(12, 12);
            this.grpRMADetails.Name = "grpRMADetails";
            this.grpRMADetails.Size = new System.Drawing.Size(895, 155);
            this.grpRMADetails.TabIndex = 0;
            this.grpRMADetails.TabStop = false;
            this.grpRMADetails.Text = "RMA Details";
            // 
            // cmbTechs
            // 
            this.cmbTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechs.FormattingEnabled = true;
            this.cmbTechs.Location = new System.Drawing.Point(497, 40);
            this.cmbTechs.Name = "cmbTechs";
            this.cmbTechs.Size = new System.Drawing.Size(251, 21);
            this.cmbTechs.Sorted = true;
            this.cmbTechs.TabIndex = 22;
            this.cmbTechs.SelectedIndexChanged += new System.EventHandler(this.cmbTechs_SelectedIndexChanged);
            // 
            // pnlPending
            // 
            this.pnlPending.Controls.Add(this.label1);
            this.pnlPending.Controls.Add(this.radPending_Production);
            this.pnlPending.Controls.Add(this.txtPendingReason);
            this.pnlPending.Controls.Add(this.radPending_Engineering);
            this.pnlPending.Location = new System.Drawing.Point(183, 109);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(565, 42);
            this.pnlPending.TabIndex = 21;
            this.pnlPending.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pending Reason";
            // 
            // radPending_Production
            // 
            this.radPending_Production.AutoSize = true;
            this.radPending_Production.Checked = true;
            this.radPending_Production.Location = new System.Drawing.Point(3, 3);
            this.radPending_Production.Name = "radPending_Production";
            this.radPending_Production.Size = new System.Drawing.Size(76, 17);
            this.radPending_Production.TabIndex = 19;
            this.radPending_Production.TabStop = true;
            this.radPending_Production.Text = "Production";
            this.radPending_Production.UseVisualStyleBackColor = true;
            // 
            // txtPendingReason
            // 
            this.txtPendingReason.Location = new System.Drawing.Point(145, 19);
            this.txtPendingReason.MaxLength = 128;
            this.txtPendingReason.Name = "txtPendingReason";
            this.txtPendingReason.Size = new System.Drawing.Size(338, 20);
            this.txtPendingReason.TabIndex = 18;
            this.toolTip.SetToolTip(this.txtPendingReason, "Information about why the RMA is pending.");
            // 
            // radPending_Engineering
            // 
            this.radPending_Engineering.AutoSize = true;
            this.radPending_Engineering.Location = new System.Drawing.Point(3, 20);
            this.radPending_Engineering.Name = "radPending_Engineering";
            this.radPending_Engineering.Size = new System.Drawing.Size(81, 17);
            this.radPending_Engineering.TabIndex = 20;
            this.radPending_Engineering.Text = "Engineering";
            this.radPending_Engineering.UseVisualStyleBackColor = true;
            // 
            // chkPending
            // 
            this.chkPending.AutoSize = true;
            this.chkPending.Location = new System.Drawing.Point(112, 109);
            this.chkPending.Name = "chkPending";
            this.chkPending.Size = new System.Drawing.Size(65, 17);
            this.chkPending.TabIndex = 17;
            this.chkPending.Text = "Pending";
            this.toolTip.SetToolTip(this.chkPending, "This RMA is pending and cannot be completed yet.");
            this.chkPending.UseVisualStyleBackColor = true;
            this.chkPending.CheckedChanged += new System.EventHandler(this.chkPending_CheckedChanged);
            // 
            // lblRMADetails_RMANumber
            // 
            this.lblRMADetails_RMANumber.AutoSize = true;
            this.lblRMADetails_RMANumber.Location = new System.Drawing.Point(6, 19);
            this.lblRMADetails_RMANumber.Name = "lblRMADetails_RMANumber";
            this.lblRMADetails_RMANumber.Size = new System.Drawing.Size(41, 13);
            this.lblRMADetails_RMANumber.TabIndex = 15;
            this.lblRMADetails_RMANumber.Text = "RMA #";
            // 
            // txtRMANumber
            // 
            this.txtRMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMANumber.Location = new System.Drawing.Point(6, 35);
            this.txtRMANumber.Name = "txtRMANumber";
            this.txtRMANumber.ReadOnly = true;
            this.txtRMANumber.Size = new System.Drawing.Size(100, 26);
            this.txtRMANumber.TabIndex = 16;
            this.txtRMANumber.TabStop = false;
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Location = new System.Drawing.Point(494, 86);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(106, 17);
            this.chkSendEmail.TabIndex = 13;
            this.chkSendEmail.Text = "Send RMA Email";
            this.toolTip.SetToolTip(this.chkSendEmail, "Send the assigned tech an email copy of the RMA.");
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkHot.Location = new System.Drawing.Point(286, 86);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(150, 17);
            this.chkHot.TabIndex = 12;
            this.chkHot.Text = "This RMA is a rush (HOT).";
            this.toolTip.SetToolTip(this.chkHot, "RMA will appear at the top of the queue.");
            this.chkHot.UseVisualStyleBackColor = true;
            // 
            // chkAPR
            // 
            this.chkAPR.AutoSize = true;
            this.chkAPR.Location = new System.Drawing.Point(112, 86);
            this.chkAPR.Name = "chkAPR";
            this.chkAPR.Size = new System.Drawing.Size(168, 17);
            this.chkAPR.TabIndex = 11;
            this.chkAPR.Text = "Advanced Parts Replacement";
            this.toolTip.SetToolTip(this.chkAPR, "Items on this RMA need to ship before we receive the defective item(s).");
            this.chkAPR.UseVisualStyleBackColor = true;
            // 
            // txtLegacyRMA
            // 
            this.txtLegacyRMA.Location = new System.Drawing.Point(754, 40);
            this.txtLegacyRMA.Name = "txtLegacyRMA";
            this.txtLegacyRMA.ReadOnly = true;
            this.txtLegacyRMA.Size = new System.Drawing.Size(100, 20);
            this.txtLegacyRMA.TabIndex = 10;
            this.toolTip.SetToolTip(this.txtLegacyRMA, "If this RMA replaces an old (Legacy) RMA, enter it here.");
            // 
            // lblLegacyRMA
            // 
            this.lblLegacyRMA.AutoSize = true;
            this.lblLegacyRMA.Location = new System.Drawing.Point(751, 24);
            this.lblLegacyRMA.Name = "lblLegacyRMA";
            this.lblLegacyRMA.Size = new System.Drawing.Size(79, 13);
            this.lblLegacyRMA.TabIndex = 9;
            this.lblLegacyRMA.Text = "Legacy RMA #";
            // 
            // radPONumber
            // 
            this.radPONumber.AutoSize = true;
            this.radPONumber.Location = new System.Drawing.Point(429, 22);
            this.radPONumber.Name = "radPONumber";
            this.radPONumber.Size = new System.Drawing.Size(50, 17);
            this.radPONumber.TabIndex = 5;
            this.radPONumber.Text = "PO #";
            this.radPONumber.UseVisualStyleBackColor = true;
            this.radPONumber.CheckedChanged += new System.EventHandler(this.radRMADetails_PONumber_CheckedChanged);
            // 
            // radJobNumber
            // 
            this.radJobNumber.AutoSize = true;
            this.radJobNumber.Checked = true;
            this.radJobNumber.Location = new System.Drawing.Point(372, 22);
            this.radJobNumber.Name = "radJobNumber";
            this.radJobNumber.Size = new System.Drawing.Size(52, 17);
            this.radJobNumber.TabIndex = 4;
            this.radJobNumber.TabStop = true;
            this.radJobNumber.Text = "Job #";
            this.radJobNumber.UseVisualStyleBackColor = true;
            // 
            // txtJob_PO
            // 
            this.txtJob_PO.Location = new System.Drawing.Point(372, 40);
            this.txtJob_PO.Name = "txtJob_PO";
            this.txtJob_PO.Size = new System.Drawing.Size(97, 20);
            this.txtJob_PO.TabIndex = 6;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(494, 24);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(66, 13);
            this.lblAssignedTo.TabIndex = 7;
            this.lblAssignedTo.Text = "Assigned To";
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Location = new System.Drawing.Point(215, 24);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(33, 13);
            this.lblAsset.TabIndex = 2;
            this.lblAsset.Text = "Asset";
            // 
            // txtAsset
            // 
            this.txtAsset.Location = new System.Drawing.Point(218, 40);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.ReadOnly = true;
            this.txtAsset.Size = new System.Drawing.Size(148, 20);
            this.txtAsset.TabIndex = 3;
            this.txtAsset.TabStop = false;
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(109, 24);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(47, 13);
            this.lblTicketID.TabIndex = 0;
            this.lblTicketID.Text = "Ticket #";
            // 
            // txtTicketID
            // 
            this.txtTicketID.Location = new System.Drawing.Point(112, 40);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(100, 20);
            this.txtTicketID.TabIndex = 1;
            this.txtTicketID.Leave += new System.EventHandler(this.txtTicketID_Leave);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(799, 467);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(685, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAssemblyTypes
            // 
            this.grpAssemblyTypes.Controls.Add(this.olvAssemblies);
            this.grpAssemblyTypes.Controls.Add(this.pnlAssemblies_Control);
            this.grpAssemblyTypes.Location = new System.Drawing.Point(15, 263);
            this.grpAssemblyTypes.Name = "grpAssemblyTypes";
            this.grpAssemblyTypes.Size = new System.Drawing.Size(895, 196);
            this.grpAssemblyTypes.TabIndex = 2;
            this.grpAssemblyTypes.TabStop = false;
            this.grpAssemblyTypes.Text = "Assemblies";
            // 
            // olvAssemblies
            // 
            this.olvAssemblies.AllColumns.Add(this.olcAssy_Assembly);
            this.olvAssemblies.AllColumns.Add(this.olcDiscarded);
            this.olvAssemblies.AllColumns.Add(this.olcFailureType);
            this.olvAssemblies.AllColumns.Add(this.olcGrid);
            this.olvAssemblies.AllColumns.Add(this.olcRepairStarted);
            this.olvAssemblies.AllColumns.Add(this.olcRepairCompleted);
            this.olvAssemblies.AllColumns.Add(this.olcRepairBy);
            this.olvAssemblies.AllColumns.Add(this.olcFinalized);
            this.olvAssemblies.CellEditUseWholeCell = false;
            this.olvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcAssy_Assembly,
            this.olcDiscarded,
            this.olcFailureType,
            this.olcGrid,
            this.olcRepairStarted,
            this.olcRepairCompleted,
            this.olcRepairBy,
            this.olcFinalized});
            this.olvAssemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssemblies.FullRowSelect = true;
            this.olvAssemblies.GridLines = true;
            this.olvAssemblies.Location = new System.Drawing.Point(3, 46);
            this.olvAssemblies.MultiSelect = false;
            this.olvAssemblies.Name = "olvAssemblies";
            this.olvAssemblies.ShowGroups = false;
            this.olvAssemblies.Size = new System.Drawing.Size(889, 147);
            this.olvAssemblies.SmallImageList = this.imageList1;
            this.olvAssemblies.TabIndex = 1;
            this.olvAssemblies.UseCompatibleStateImageBehavior = false;
            this.olvAssemblies.View = System.Windows.Forms.View.Details;
            this.olvAssemblies.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvAssemblies_FormatRow);
            // 
            // olcAssy_Assembly
            // 
            this.olcAssy_Assembly.AspectName = "Description";
            this.olcAssy_Assembly.Text = "Assembly";
            this.olcAssy_Assembly.Width = 300;
            // 
            // olcDiscarded
            // 
            this.olcDiscarded.AspectName = "Discarded";
            this.olcDiscarded.IsEditable = false;
            this.olcDiscarded.Text = "Discarded";
            this.olcDiscarded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olcFailureType
            // 
            this.olcFailureType.AspectName = "FailureTypeDescription";
            this.olcFailureType.Text = "Failure Type";
            this.olcFailureType.Width = 140;
            // 
            // olcGrid
            // 
            this.olcGrid.AspectName = "Failure_Grid";
            this.olcGrid.Text = "Location";
            // 
            // olcRepairStarted
            // 
            this.olcRepairStarted.AspectName = "Repair_DateTime_Start";
            this.olcRepairStarted.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olcRepairStarted.Text = "Repair Start";
            this.olcRepairStarted.Width = 90;
            // 
            // olcRepairCompleted
            // 
            this.olcRepairCompleted.AspectName = "Repair_DateTime_End";
            this.olcRepairCompleted.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olcRepairCompleted.Text = "Repair End";
            this.olcRepairCompleted.Width = 90;
            // 
            // olcRepairBy
            // 
            this.olcRepairBy.AspectName = "Repair_UserName";
            this.olcRepairBy.Text = "Repair By";
            this.olcRepairBy.Width = 70;
            // 
            // olcFinalized
            // 
            this.olcFinalized.AspectName = "Finalize_Date";
            this.olcFinalized.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olcFinalized.Text = "Finalized";
            this.olcFinalized.Width = 90;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "trash");
            // 
            // pnlAssemblies_Control
            // 
            this.pnlAssemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssemblies_Control.Controls.Add(this.btnAssembly_Remove);
            this.pnlAssemblies_Control.Controls.Add(this.lblAssemblies_Qty);
            this.pnlAssemblies_Control.Controls.Add(this.txtAssemblies_Qty);
            this.pnlAssemblies_Control.Controls.Add(this.btnAssembly_Add);
            this.pnlAssemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssemblies_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlAssemblies_Control.Name = "pnlAssemblies_Control";
            this.pnlAssemblies_Control.Size = new System.Drawing.Size(889, 30);
            this.pnlAssemblies_Control.TabIndex = 0;
            // 
            // btnAssembly_Remove
            // 
            this.btnAssembly_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssembly_Remove.Location = new System.Drawing.Point(135, 3);
            this.btnAssembly_Remove.Name = "btnAssembly_Remove";
            this.btnAssembly_Remove.Size = new System.Drawing.Size(126, 23);
            this.btnAssembly_Remove.TabIndex = 3;
            this.btnAssembly_Remove.Text = "&Remove";
            this.btnAssembly_Remove.UseVisualStyleBackColor = false;
            this.btnAssembly_Remove.Click += new System.EventHandler(this.btnAssembly_Remove_Click);
            // 
            // lblAssemblies_Qty
            // 
            this.lblAssemblies_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssemblies_Qty.AutoSize = true;
            this.lblAssemblies_Qty.Location = new System.Drawing.Point(812, 8);
            this.lblAssemblies_Qty.Name = "lblAssemblies_Qty";
            this.lblAssemblies_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblAssemblies_Qty.TabIndex = 1;
            this.lblAssemblies_Qty.Text = "Qty";
            // 
            // txtAssemblies_Qty
            // 
            this.txtAssemblies_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblies_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblies_Qty.Location = new System.Drawing.Point(841, 3);
            this.txtAssemblies_Qty.Name = "txtAssemblies_Qty";
            this.txtAssemblies_Qty.ReadOnly = true;
            this.txtAssemblies_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtAssemblies_Qty.TabIndex = 2;
            this.txtAssemblies_Qty.TabStop = false;
            // 
            // btnAssembly_Add
            // 
            this.btnAssembly_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssembly_Add.Location = new System.Drawing.Point(3, 3);
            this.btnAssembly_Add.Name = "btnAssembly_Add";
            this.btnAssembly_Add.Size = new System.Drawing.Size(126, 23);
            this.btnAssembly_Add.TabIndex = 0;
            this.btnAssembly_Add.Text = "&Add Assembly";
            this.btnAssembly_Add.UseVisualStyleBackColor = false;
            this.btnAssembly_Add.Click += new System.EventHandler(this.btnAssembly_Add_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(12, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete RMA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Location = new System.Drawing.Point(12, 173);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(894, 84);
            this.grpNotes.TabIndex = 1;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.MaxLength = 2048;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(888, 65);
            this.txtNotes.TabIndex = 0;
            // 
            // FormRMA_Modify
            // 
            this.AcceptButton = this.btnModify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(919, 502);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpAssemblyTypes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpRMADetails);
            this.Controls.Add(this.btnModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRMA_Modify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RMA: Modify";
            this.Shown += new System.EventHandler(this.FormRMA_Modify_Shown);
            this.grpRMADetails.ResumeLayout(false);
            this.grpRMADetails.PerformLayout();
            this.pnlPending.ResumeLayout(false);
            this.pnlPending.PerformLayout();
            this.grpAssemblyTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).EndInit();
            this.pnlAssemblies_Control.ResumeLayout(false);
            this.pnlAssemblies_Control.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpRMADetails;
		private System.Windows.Forms.CheckBox chkAPR;
		private System.Windows.Forms.TextBox txtLegacyRMA;
		private System.Windows.Forms.Label lblLegacyRMA;
		private System.Windows.Forms.RadioButton radPONumber;
		private System.Windows.Forms.RadioButton radJobNumber;
		private System.Windows.Forms.TextBox txtJob_PO;
		private System.Windows.Forms.Label lblAssignedTo;
		private System.Windows.Forms.Label lblAsset;
		private System.Windows.Forms.TextBox txtAsset;
		private System.Windows.Forms.Label lblTicketID;
		private System.Windows.Forms.TextBox txtTicketID;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox chkHot;
		private System.Windows.Forms.GroupBox grpAssemblyTypes;
		private System.Windows.Forms.ToolTip toolTip;
		private BrightIdeasSoftware.ObjectListView olvAssemblies;
		private BrightIdeasSoftware.OLVColumn olcAssy_Assembly;
		private BrightIdeasSoftware.OLVColumn olcFailureType;
		private BrightIdeasSoftware.OLVColumn olcGrid;
		private System.Windows.Forms.Panel pnlAssemblies_Control;
		private System.Windows.Forms.Label lblAssemblies_Qty;
		private System.Windows.Forms.TextBox txtAssemblies_Qty;
		private System.Windows.Forms.Button btnAssembly_Add;
		private System.Windows.Forms.CheckBox chkSendEmail;
		private System.Windows.Forms.Button btnAssembly_Remove;
		private BrightIdeasSoftware.OLVColumn olcRepairStarted;
		private BrightIdeasSoftware.OLVColumn olcRepairCompleted;
		private BrightIdeasSoftware.OLVColumn olcRepairBy;
		private BrightIdeasSoftware.OLVColumn olcFinalized;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblRMADetails_RMANumber;
		private System.Windows.Forms.TextBox txtRMANumber;
		private System.Windows.Forms.TextBox txtPendingReason;
		private System.Windows.Forms.CheckBox chkPending;
		private System.Windows.Forms.Panel pnlPending;
		private System.Windows.Forms.RadioButton radPending_Production;
		private System.Windows.Forms.RadioButton radPending_Engineering;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpNotes;
		private System.Windows.Forms.TextBox txtNotes;
		private BrightIdeasSoftware.OLVColumn olcDiscarded;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbTechs;
    }
}