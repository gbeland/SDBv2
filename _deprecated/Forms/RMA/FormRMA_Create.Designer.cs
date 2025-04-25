namespace SDB.Forms.RMA
{
	partial class FormRMA_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMA_Create));
            this.grpRMADetails = new System.Windows.Forms.GroupBox();
            this.chkEmail_SendToTech = new System.Windows.Forms.CheckBox();
            this.chkHot = new System.Windows.Forms.CheckBox();
            this.cmbTechs = new System.Windows.Forms.ComboBox();
            this.chkAPR = new System.Windows.Forms.CheckBox();
            this.radRMADetails_PONumber = new System.Windows.Forms.RadioButton();
            this.radRMADetails_JobNumber = new System.Windows.Forms.RadioButton();
            this.txtRMADetails_Job_PO = new System.Windows.Forms.TextBox();
            this.lblRMADetails_AssignedTo = new System.Windows.Forms.Label();
            this.lblRMADetails_Asset = new System.Windows.Forms.Label();
            this.txtRMADetails_Asset = new System.Windows.Forms.TextBox();
            this.lblRMADetails_TicketID = new System.Windows.Forms.Label();
            this.txtRMADetails_TicketID = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAssemblies = new System.Windows.Forms.GroupBox();
            this.olvAssemblyAdd = new BrightIdeasSoftware.ObjectListView();
            this.olcAssyAdd_Assembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAssyAdd_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAssyAdd_Notes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAssyAdd_Grid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDiscarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlAssemblyAdd_Control = new System.Windows.Forms.Panel();
            this.btnAssembly_Remove = new System.Windows.Forms.Button();
            this.lblAssemblyAdd_Qty = new System.Windows.Forms.Label();
            this.txtAssemblyAdd_Qty = new System.Windows.Forms.TextBox();
            this.btnAssembly_Add = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpRMADetails.SuspendLayout();
            this.grpAssemblies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).BeginInit();
            this.pnlAssemblyAdd_Control.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRMADetails
            // 
            this.grpRMADetails.Controls.Add(this.chkEmail_SendToTech);
            this.grpRMADetails.Controls.Add(this.chkHot);
            this.grpRMADetails.Controls.Add(this.cmbTechs);
            this.grpRMADetails.Controls.Add(this.chkAPR);
            this.grpRMADetails.Controls.Add(this.radRMADetails_PONumber);
            this.grpRMADetails.Controls.Add(this.radRMADetails_JobNumber);
            this.grpRMADetails.Controls.Add(this.txtRMADetails_Job_PO);
            this.grpRMADetails.Controls.Add(this.lblRMADetails_AssignedTo);
            this.grpRMADetails.Controls.Add(this.lblRMADetails_Asset);
            this.grpRMADetails.Controls.Add(this.txtRMADetails_Asset);
            this.grpRMADetails.Controls.Add(this.lblRMADetails_TicketID);
            this.grpRMADetails.Controls.Add(this.txtRMADetails_TicketID);
            this.grpRMADetails.Location = new System.Drawing.Point(12, 12);
            this.grpRMADetails.Name = "grpRMADetails";
            this.grpRMADetails.Size = new System.Drawing.Size(895, 109);
            this.grpRMADetails.TabIndex = 0;
            this.grpRMADetails.TabStop = false;
            this.grpRMADetails.Text = "RMA Details";
            // 
            // chkEmail_SendToTech
            // 
            this.chkEmail_SendToTech.AutoSize = true;
            this.chkEmail_SendToTech.Checked = true;
            this.chkEmail_SendToTech.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail_SendToTech.Location = new System.Drawing.Point(419, 83);
            this.chkEmail_SendToTech.Name = "chkEmail_SendToTech";
            this.chkEmail_SendToTech.Size = new System.Drawing.Size(178, 17);
            this.chkEmail_SendToTech.TabIndex = 11;
            this.chkEmail_SendToTech.Text = "Send RMA email to tech/market";
            this.toolTip.SetToolTip(this.chkEmail_SendToTech, "Send the assigned tech an email copy of the RMA.\r\nThe market will be carbon-copie" +
        "d if the market is configured to receive a copy.");
            this.chkEmail_SendToTech.UseVisualStyleBackColor = true;
            // 
            // chkHot
            // 
            this.chkHot.AutoSize = true;
            this.chkHot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkHot.Location = new System.Drawing.Point(183, 83);
            this.chkHot.Name = "chkHot";
            this.chkHot.Size = new System.Drawing.Size(150, 17);
            this.chkHot.TabIndex = 10;
            this.chkHot.Text = "This RMA is a rush (HOT).";
            this.toolTip.SetToolTip(this.chkHot, "RMA will appear at the top of the queue.");
            this.chkHot.UseVisualStyleBackColor = true;
            // 
            // cmbTechs
            // 
            this.cmbTechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechs.FormattingEnabled = true;
            this.cmbTechs.Location = new System.Drawing.Point(416, 40);
            this.cmbTechs.Name = "cmbTechs";
            this.cmbTechs.Size = new System.Drawing.Size(254, 21);
            this.cmbTechs.Sorted = true;
            this.cmbTechs.TabIndex = 8;
            this.cmbTechs.SelectedIndexChanged += new System.EventHandler(this.cmbTechs_SelectedIndexChanged);
            // 
            // chkAPR
            // 
            this.chkAPR.AutoSize = true;
            this.chkAPR.Location = new System.Drawing.Point(9, 83);
            this.chkAPR.Name = "chkAPR";
            this.chkAPR.Size = new System.Drawing.Size(168, 17);
            this.chkAPR.TabIndex = 9;
            this.chkAPR.Text = "Advanced Parts Replacement";
            this.toolTip.SetToolTip(this.chkAPR, "Items on this RMA need to ship before Prismview receives the defective item(s).");
            this.chkAPR.UseVisualStyleBackColor = true;
            // 
            // radRMADetails_PONumber
            // 
            this.radRMADetails_PONumber.AutoSize = true;
            this.radRMADetails_PONumber.Location = new System.Drawing.Point(323, 22);
            this.radRMADetails_PONumber.Name = "radRMADetails_PONumber";
            this.radRMADetails_PONumber.Size = new System.Drawing.Size(50, 17);
            this.radRMADetails_PONumber.TabIndex = 5;
            this.radRMADetails_PONumber.Text = "PO #";
            this.radRMADetails_PONumber.UseVisualStyleBackColor = true;
            this.radRMADetails_PONumber.CheckedChanged += new System.EventHandler(this.radRMADetails_PONumber_CheckedChanged);
            // 
            // radRMADetails_JobNumber
            // 
            this.radRMADetails_JobNumber.AutoSize = true;
            this.radRMADetails_JobNumber.Checked = true;
            this.radRMADetails_JobNumber.Location = new System.Drawing.Point(266, 22);
            this.radRMADetails_JobNumber.Name = "radRMADetails_JobNumber";
            this.radRMADetails_JobNumber.Size = new System.Drawing.Size(52, 17);
            this.radRMADetails_JobNumber.TabIndex = 4;
            this.radRMADetails_JobNumber.TabStop = true;
            this.radRMADetails_JobNumber.Text = "Job #";
            this.radRMADetails_JobNumber.UseVisualStyleBackColor = true;
            // 
            // txtRMADetails_Job_PO
            // 
            this.txtRMADetails_Job_PO.Location = new System.Drawing.Point(266, 40);
            this.txtRMADetails_Job_PO.MaxLength = 20;
            this.txtRMADetails_Job_PO.Name = "txtRMADetails_Job_PO";
            this.txtRMADetails_Job_PO.Size = new System.Drawing.Size(144, 20);
            this.txtRMADetails_Job_PO.TabIndex = 6;
            // 
            // lblRMADetails_AssignedTo
            // 
            this.lblRMADetails_AssignedTo.AutoSize = true;
            this.lblRMADetails_AssignedTo.Location = new System.Drawing.Point(416, 24);
            this.lblRMADetails_AssignedTo.Name = "lblRMADetails_AssignedTo";
            this.lblRMADetails_AssignedTo.Size = new System.Drawing.Size(66, 13);
            this.lblRMADetails_AssignedTo.TabIndex = 7;
            this.lblRMADetails_AssignedTo.Text = "Assigned To";
            // 
            // lblRMADetails_Asset
            // 
            this.lblRMADetails_Asset.AutoSize = true;
            this.lblRMADetails_Asset.Location = new System.Drawing.Point(109, 24);
            this.lblRMADetails_Asset.Name = "lblRMADetails_Asset";
            this.lblRMADetails_Asset.Size = new System.Drawing.Size(33, 13);
            this.lblRMADetails_Asset.TabIndex = 2;
            this.lblRMADetails_Asset.Text = "Asset";
            // 
            // txtRMADetails_Asset
            // 
            this.txtRMADetails_Asset.Location = new System.Drawing.Point(112, 40);
            this.txtRMADetails_Asset.Name = "txtRMADetails_Asset";
            this.txtRMADetails_Asset.ReadOnly = true;
            this.txtRMADetails_Asset.Size = new System.Drawing.Size(148, 20);
            this.txtRMADetails_Asset.TabIndex = 3;
            this.txtRMADetails_Asset.TabStop = false;
            // 
            // lblRMADetails_TicketID
            // 
            this.lblRMADetails_TicketID.AutoSize = true;
            this.lblRMADetails_TicketID.Location = new System.Drawing.Point(3, 24);
            this.lblRMADetails_TicketID.Name = "lblRMADetails_TicketID";
            this.lblRMADetails_TicketID.Size = new System.Drawing.Size(47, 13);
            this.lblRMADetails_TicketID.TabIndex = 0;
            this.lblRMADetails_TicketID.Text = "Ticket #";
            // 
            // txtRMADetails_TicketID
            // 
            this.txtRMADetails_TicketID.Location = new System.Drawing.Point(6, 40);
            this.txtRMADetails_TicketID.Name = "txtRMADetails_TicketID";
            this.txtRMADetails_TicketID.Size = new System.Drawing.Size(100, 20);
            this.txtRMADetails_TicketID.TabIndex = 1;
            this.txtRMADetails_TicketID.Leave += new System.EventHandler(this.txtRMADetails_TicketID_Leave);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(799, 419);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(685, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAssemblies
            // 
            this.grpAssemblies.Controls.Add(this.olvAssemblyAdd);
            this.grpAssemblies.Controls.Add(this.pnlAssemblyAdd_Control);
            this.grpAssemblies.Location = new System.Drawing.Point(12, 217);
            this.grpAssemblies.Name = "grpAssemblies";
            this.grpAssemblies.Size = new System.Drawing.Size(894, 196);
            this.grpAssemblies.TabIndex = 2;
            this.grpAssemblies.TabStop = false;
            this.grpAssemblies.Text = "Assemblies";
            // 
            // olvAssemblyAdd
            // 
            this.olvAssemblyAdd.AllColumns.Add(this.olcAssyAdd_Assembly);
            this.olvAssemblyAdd.AllColumns.Add(this.olcAssyAdd_FailureType);
            this.olvAssemblyAdd.AllColumns.Add(this.olcAssyAdd_Notes);
            this.olvAssemblyAdd.AllColumns.Add(this.olcAssyAdd_Grid);
            this.olvAssemblyAdd.AllColumns.Add(this.olcDiscarded);
            this.olvAssemblyAdd.CellEditUseWholeCell = false;
            this.olvAssemblyAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcAssyAdd_Assembly,
            this.olcAssyAdd_FailureType,
            this.olcAssyAdd_Notes,
            this.olcAssyAdd_Grid,
            this.olcDiscarded});
            this.olvAssemblyAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblyAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssemblyAdd.FullRowSelect = true;
            this.olvAssemblyAdd.GridLines = true;
            this.olvAssemblyAdd.Location = new System.Drawing.Point(3, 46);
            this.olvAssemblyAdd.MultiSelect = false;
            this.olvAssemblyAdd.Name = "olvAssemblyAdd";
            this.olvAssemblyAdd.ShowGroups = false;
            this.olvAssemblyAdd.Size = new System.Drawing.Size(888, 147);
            this.olvAssemblyAdd.SmallImageList = this.imageList1;
            this.olvAssemblyAdd.TabIndex = 1;
            this.olvAssemblyAdd.UseCompatibleStateImageBehavior = false;
            this.olvAssemblyAdd.View = System.Windows.Forms.View.Details;
            // 
            // olcAssyAdd_Assembly
            // 
            this.olcAssyAdd_Assembly.AspectName = "Description";
            this.olcAssyAdd_Assembly.Text = "Assembly";
            this.olcAssyAdd_Assembly.Width = 300;
            // 
            // olcAssyAdd_FailureType
            // 
            this.olcAssyAdd_FailureType.AspectName = "FailureTypeDescription";
            this.olcAssyAdd_FailureType.Text = "Failure Type";
            this.olcAssyAdd_FailureType.Width = 200;
            // 
            // olcAssyAdd_Notes
            // 
            this.olcAssyAdd_Notes.AspectName = "Failure_Notes";
            this.olcAssyAdd_Notes.FillsFreeSpace = true;
            this.olcAssyAdd_Notes.Text = "Failure Notes";
            this.olcAssyAdd_Notes.Width = 230;
            this.olcAssyAdd_Notes.WordWrap = true;
            // 
            // olcAssyAdd_Grid
            // 
            this.olcAssyAdd_Grid.AspectName = "Failure_Grid";
            this.olcAssyAdd_Grid.Text = "Grid Location";
            this.olcAssyAdd_Grid.Width = 80;
            // 
            // olcDiscarded
            // 
            this.olcDiscarded.AspectName = "Discarded";
            this.olcDiscarded.IsEditable = false;
            this.olcDiscarded.Text = "Discarded";
            this.olcDiscarded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "trash");
            // 
            // pnlAssemblyAdd_Control
            // 
            this.pnlAssemblyAdd_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssemblyAdd_Control.Controls.Add(this.btnAssembly_Remove);
            this.pnlAssemblyAdd_Control.Controls.Add(this.lblAssemblyAdd_Qty);
            this.pnlAssemblyAdd_Control.Controls.Add(this.txtAssemblyAdd_Qty);
            this.pnlAssemblyAdd_Control.Controls.Add(this.btnAssembly_Add);
            this.pnlAssemblyAdd_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssemblyAdd_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlAssemblyAdd_Control.Name = "pnlAssemblyAdd_Control";
            this.pnlAssemblyAdd_Control.Size = new System.Drawing.Size(888, 30);
            this.pnlAssemblyAdd_Control.TabIndex = 0;
            // 
            // btnAssembly_Remove
            // 
            this.btnAssembly_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssembly_Remove.Location = new System.Drawing.Point(135, 3);
            this.btnAssembly_Remove.Name = "btnAssembly_Remove";
            this.btnAssembly_Remove.Size = new System.Drawing.Size(126, 23);
            this.btnAssembly_Remove.TabIndex = 1;
            this.btnAssembly_Remove.Text = "Remove";
            this.btnAssembly_Remove.UseVisualStyleBackColor = false;
            this.btnAssembly_Remove.Click += new System.EventHandler(this.btnAssembly_Remove_Click);
            // 
            // lblAssemblyAdd_Qty
            // 
            this.lblAssemblyAdd_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssemblyAdd_Qty.AutoSize = true;
            this.lblAssemblyAdd_Qty.Location = new System.Drawing.Point(811, 8);
            this.lblAssemblyAdd_Qty.Name = "lblAssemblyAdd_Qty";
            this.lblAssemblyAdd_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblAssemblyAdd_Qty.TabIndex = 2;
            this.lblAssemblyAdd_Qty.Text = "Qty";
            // 
            // txtAssemblyAdd_Qty
            // 
            this.txtAssemblyAdd_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblyAdd_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblyAdd_Qty.Location = new System.Drawing.Point(840, 3);
            this.txtAssemblyAdd_Qty.Name = "txtAssemblyAdd_Qty";
            this.txtAssemblyAdd_Qty.ReadOnly = true;
            this.txtAssemblyAdd_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtAssemblyAdd_Qty.TabIndex = 3;
            this.txtAssemblyAdd_Qty.TabStop = false;
            // 
            // btnAssembly_Add
            // 
            this.btnAssembly_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssembly_Add.Location = new System.Drawing.Point(3, 3);
            this.btnAssembly_Add.Name = "btnAssembly_Add";
            this.btnAssembly_Add.Size = new System.Drawing.Size(126, 23);
            this.btnAssembly_Add.TabIndex = 0;
            this.btnAssembly_Add.Text = "Add Assembly";
            this.btnAssembly_Add.UseVisualStyleBackColor = false;
            this.btnAssembly_Add.Click += new System.EventHandler(this.btnAssembly_Add_Click);
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Location = new System.Drawing.Point(12, 127);
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
            // FormRMA_Create
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(919, 454);
            this.Controls.Add(this.grpNotes);
            this.Controls.Add(this.grpAssemblies);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpRMADetails);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRMA_Create";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create RMA";
            this.Shown += new System.EventHandler(this.FormRMA_Create_Shown);
            this.grpRMADetails.ResumeLayout(false);
            this.grpRMADetails.PerformLayout();
            this.grpAssemblies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).EndInit();
            this.pnlAssemblyAdd_Control.ResumeLayout(false);
            this.pnlAssemblyAdd_Control.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpRMADetails;
		private System.Windows.Forms.CheckBox chkAPR;
		private System.Windows.Forms.RadioButton radRMADetails_PONumber;
		private System.Windows.Forms.RadioButton radRMADetails_JobNumber;
		private System.Windows.Forms.TextBox txtRMADetails_Job_PO;
		private System.Windows.Forms.Label lblRMADetails_AssignedTo;
		private System.Windows.Forms.Label lblRMADetails_Asset;
		private System.Windows.Forms.TextBox txtRMADetails_Asset;
		private System.Windows.Forms.Label lblRMADetails_TicketID;
		private System.Windows.Forms.TextBox txtRMADetails_TicketID;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox chkHot;
		private System.Windows.Forms.ComboBox cmbTechs;
		private System.Windows.Forms.GroupBox grpAssemblies;
		private System.Windows.Forms.ToolTip toolTip;
		private BrightIdeasSoftware.ObjectListView olvAssemblyAdd;
		private BrightIdeasSoftware.OLVColumn olcAssyAdd_Assembly;
		private BrightIdeasSoftware.OLVColumn olcAssyAdd_FailureType;
		private BrightIdeasSoftware.OLVColumn olcAssyAdd_Notes;
		private BrightIdeasSoftware.OLVColumn olcAssyAdd_Grid;
		private System.Windows.Forms.Panel pnlAssemblyAdd_Control;
		private System.Windows.Forms.Label lblAssemblyAdd_Qty;
		private System.Windows.Forms.TextBox txtAssemblyAdd_Qty;
		private System.Windows.Forms.Button btnAssembly_Add;
		private System.Windows.Forms.CheckBox chkEmail_SendToTech;
		private System.Windows.Forms.Button btnAssembly_Remove;
		private System.Windows.Forms.GroupBox grpNotes;
		private System.Windows.Forms.TextBox txtNotes;
		private BrightIdeasSoftware.OLVColumn olcDiscarded;
		private System.Windows.Forms.ImageList imageList1;
	}
}