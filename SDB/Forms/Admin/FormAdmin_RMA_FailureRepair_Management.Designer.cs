namespace SDB.Forms.Admin
{
	partial class FormAdmin_RMA_FailureRepair_Management
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
			this.btnClose = new System.Windows.Forms.Button();
			this.grpFailureTypes = new System.Windows.Forms.GroupBox();
			this.olvFailureTypes = new BrightIdeasSoftware.ObjectListView();
			this.olvColFailureType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlFailureTypes_Control = new System.Windows.Forms.Panel();
			this.btnFailureType_Remove = new System.Windows.Forms.Button();
			this.btnFailureType_Edit = new System.Windows.Forms.Button();
			this.btnFailureType_Add = new System.Windows.Forms.Button();
			this.grpRepairTypes = new System.Windows.Forms.GroupBox();
			this.olvRepairTypes = new BrightIdeasSoftware.ObjectListView();
			this.olvColRepairType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlRepairTypes_Control = new System.Windows.Forms.Panel();
			this.btnRepairType_Remove = new System.Windows.Forms.Button();
			this.btnRepairType_Edit = new System.Windows.Forms.Button();
			this.btnRepairType_Add = new System.Windows.Forms.Button();
			this.grpRootCauses = new System.Windows.Forms.GroupBox();
			this.olvRootCauses = new BrightIdeasSoftware.ObjectListView();
			this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlRootCauses_Control = new System.Windows.Forms.Panel();
			this.btnRootCause_Remove = new System.Windows.Forms.Button();
			this.btnRootCause_Edit = new System.Windows.Forms.Button();
			this.btnRootCause_Add = new System.Windows.Forms.Button();
			this.grpFailureTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvFailureTypes)).BeginInit();
			this.pnlFailureTypes_Control.SuspendLayout();
			this.grpRepairTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRepairTypes)).BeginInit();
			this.pnlRepairTypes_Control.SuspendLayout();
			this.grpRootCauses.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRootCauses)).BeginInit();
			this.pnlRootCauses_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(907, 671);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// grpFailureTypes
			// 
			this.grpFailureTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grpFailureTypes.Controls.Add(this.olvFailureTypes);
			this.grpFailureTypes.Controls.Add(this.pnlFailureTypes_Control);
			this.grpFailureTypes.Location = new System.Drawing.Point(12, 12);
			this.grpFailureTypes.Name = "grpFailureTypes";
			this.grpFailureTypes.Size = new System.Drawing.Size(320, 650);
			this.grpFailureTypes.TabIndex = 0;
			this.grpFailureTypes.TabStop = false;
			this.grpFailureTypes.Text = "Assembly Failure Types";
			// 
			// olvFailureTypes
			// 
			this.olvFailureTypes.AllColumns.Add(this.olvColFailureType_Description);
			this.olvFailureTypes.CellEditTabChangesRows = true;
			this.olvFailureTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColFailureType_Description});
			this.olvFailureTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvFailureTypes.EmptyListMsg = "No failure types defined.";
			this.olvFailureTypes.FullRowSelect = true;
			this.olvFailureTypes.GridLines = true;
			this.olvFailureTypes.HasCollapsibleGroups = false;
			this.olvFailureTypes.HideSelection = false;
			this.olvFailureTypes.Location = new System.Drawing.Point(3, 46);
			this.olvFailureTypes.MultiSelect = false;
			this.olvFailureTypes.Name = "olvFailureTypes";
			this.olvFailureTypes.SelectAllOnControlA = false;
			this.olvFailureTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvFailureTypes.ShowCommandMenuOnRightClick = true;
			this.olvFailureTypes.ShowGroups = false;
			this.olvFailureTypes.ShowItemCountOnGroups = true;
			this.olvFailureTypes.Size = new System.Drawing.Size(314, 601);
			this.olvFailureTypes.SortGroupItemsByPrimaryColumn = false;
			this.olvFailureTypes.TabIndex = 1;
			this.olvFailureTypes.UseCompatibleStateImageBehavior = false;
			this.olvFailureTypes.View = System.Windows.Forms.View.Details;
			// 
			// olvColFailureType_Description
			// 
			this.olvColFailureType_Description.AspectName = "Description";
			this.olvColFailureType_Description.CellPadding = null;
			this.olvColFailureType_Description.FillsFreeSpace = true;
			this.olvColFailureType_Description.Groupable = false;
			this.olvColFailureType_Description.Hideable = false;
			this.olvColFailureType_Description.IsEditable = false;
			this.olvColFailureType_Description.Text = "Description";
			this.olvColFailureType_Description.Width = 300;
			// 
			// pnlFailureTypes_Control
			// 
			this.pnlFailureTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Remove);
			this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Edit);
			this.pnlFailureTypes_Control.Controls.Add(this.btnFailureType_Add);
			this.pnlFailureTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlFailureTypes_Control.Location = new System.Drawing.Point(3, 16);
			this.pnlFailureTypes_Control.Name = "pnlFailureTypes_Control";
			this.pnlFailureTypes_Control.Size = new System.Drawing.Size(314, 30);
			this.pnlFailureTypes_Control.TabIndex = 0;
			// 
			// btnFailureType_Remove
			// 
			this.btnFailureType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnFailureType_Remove.Location = new System.Drawing.Point(89, 4);
			this.btnFailureType_Remove.Name = "btnFailureType_Remove";
			this.btnFailureType_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnFailureType_Remove.TabIndex = 1;
			this.btnFailureType_Remove.Text = "Remove";
			this.btnFailureType_Remove.UseVisualStyleBackColor = false;
			this.btnFailureType_Remove.Click += new System.EventHandler(this.btnFailureType_Remove_Click);
			// 
			// btnFailureType_Edit
			// 
			this.btnFailureType_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnFailureType_Edit.Location = new System.Drawing.Point(175, 4);
			this.btnFailureType_Edit.Name = "btnFailureType_Edit";
			this.btnFailureType_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnFailureType_Edit.TabIndex = 2;
			this.btnFailureType_Edit.Text = "Edit";
			this.btnFailureType_Edit.UseVisualStyleBackColor = false;
			this.btnFailureType_Edit.Click += new System.EventHandler(this.btnFailureType_Edit_Click);
			// 
			// btnFailureType_Add
			// 
			this.btnFailureType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnFailureType_Add.Location = new System.Drawing.Point(3, 4);
			this.btnFailureType_Add.Name = "btnFailureType_Add";
			this.btnFailureType_Add.Size = new System.Drawing.Size(80, 23);
			this.btnFailureType_Add.TabIndex = 0;
			this.btnFailureType_Add.Text = "Add";
			this.btnFailureType_Add.UseVisualStyleBackColor = false;
			this.btnFailureType_Add.Click += new System.EventHandler(this.btnFailureType_Add_Click);
			// 
			// grpRepairTypes
			// 
			this.grpRepairTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grpRepairTypes.Controls.Add(this.olvRepairTypes);
			this.grpRepairTypes.Controls.Add(this.pnlRepairTypes_Control);
			this.grpRepairTypes.Location = new System.Drawing.Point(338, 12);
			this.grpRepairTypes.Name = "grpRepairTypes";
			this.grpRepairTypes.Size = new System.Drawing.Size(320, 650);
			this.grpRepairTypes.TabIndex = 1;
			this.grpRepairTypes.TabStop = false;
			this.grpRepairTypes.Text = "Assembly Repair Types";
			// 
			// olvRepairTypes
			// 
			this.olvRepairTypes.AllColumns.Add(this.olvColRepairType_Description);
			this.olvRepairTypes.CellEditTabChangesRows = true;
			this.olvRepairTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepairType_Description});
			this.olvRepairTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRepairTypes.EmptyListMsg = "No repair types defined.";
			this.olvRepairTypes.FullRowSelect = true;
			this.olvRepairTypes.GridLines = true;
			this.olvRepairTypes.HasCollapsibleGroups = false;
			this.olvRepairTypes.HideSelection = false;
			this.olvRepairTypes.Location = new System.Drawing.Point(3, 46);
			this.olvRepairTypes.MultiSelect = false;
			this.olvRepairTypes.Name = "olvRepairTypes";
			this.olvRepairTypes.SelectAllOnControlA = false;
			this.olvRepairTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRepairTypes.ShowCommandMenuOnRightClick = true;
			this.olvRepairTypes.ShowGroups = false;
			this.olvRepairTypes.ShowItemCountOnGroups = true;
			this.olvRepairTypes.Size = new System.Drawing.Size(314, 601);
			this.olvRepairTypes.SortGroupItemsByPrimaryColumn = false;
			this.olvRepairTypes.TabIndex = 1;
			this.olvRepairTypes.UseCompatibleStateImageBehavior = false;
			this.olvRepairTypes.View = System.Windows.Forms.View.Details;
			// 
			// olvColRepairType_Description
			// 
			this.olvColRepairType_Description.AspectName = "Description";
			this.olvColRepairType_Description.CellPadding = null;
			this.olvColRepairType_Description.FillsFreeSpace = true;
			this.olvColRepairType_Description.Groupable = false;
			this.olvColRepairType_Description.Hideable = false;
			this.olvColRepairType_Description.IsEditable = false;
			this.olvColRepairType_Description.Text = "Description";
			this.olvColRepairType_Description.Width = 300;
			// 
			// pnlRepairTypes_Control
			// 
			this.pnlRepairTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Remove);
			this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Edit);
			this.pnlRepairTypes_Control.Controls.Add(this.btnRepairType_Add);
			this.pnlRepairTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRepairTypes_Control.Location = new System.Drawing.Point(3, 16);
			this.pnlRepairTypes_Control.Name = "pnlRepairTypes_Control";
			this.pnlRepairTypes_Control.Size = new System.Drawing.Size(314, 30);
			this.pnlRepairTypes_Control.TabIndex = 0;
			// 
			// btnRepairType_Remove
			// 
			this.btnRepairType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRepairType_Remove.Location = new System.Drawing.Point(89, 4);
			this.btnRepairType_Remove.Name = "btnRepairType_Remove";
			this.btnRepairType_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnRepairType_Remove.TabIndex = 1;
			this.btnRepairType_Remove.Text = "Remove";
			this.btnRepairType_Remove.UseVisualStyleBackColor = false;
			this.btnRepairType_Remove.Click += new System.EventHandler(this.btnRepairType_Remove_Click);
			// 
			// btnRepairType_Edit
			// 
			this.btnRepairType_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnRepairType_Edit.Location = new System.Drawing.Point(175, 4);
			this.btnRepairType_Edit.Name = "btnRepairType_Edit";
			this.btnRepairType_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnRepairType_Edit.TabIndex = 2;
			this.btnRepairType_Edit.Text = "Edit";
			this.btnRepairType_Edit.UseVisualStyleBackColor = false;
			this.btnRepairType_Edit.Click += new System.EventHandler(this.btnRepairType_Edit_Click);
			// 
			// btnRepairType_Add
			// 
			this.btnRepairType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRepairType_Add.Location = new System.Drawing.Point(3, 4);
			this.btnRepairType_Add.Name = "btnRepairType_Add";
			this.btnRepairType_Add.Size = new System.Drawing.Size(80, 23);
			this.btnRepairType_Add.TabIndex = 0;
			this.btnRepairType_Add.Text = "Add";
			this.btnRepairType_Add.UseVisualStyleBackColor = false;
			this.btnRepairType_Add.Click += new System.EventHandler(this.btnRepairTypes_Add_Click);
			// 
			// grpRootCauses
			// 
			this.grpRootCauses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grpRootCauses.Controls.Add(this.olvRootCauses);
			this.grpRootCauses.Controls.Add(this.pnlRootCauses_Control);
			this.grpRootCauses.Location = new System.Drawing.Point(664, 12);
			this.grpRootCauses.Name = "grpRootCauses";
			this.grpRootCauses.Size = new System.Drawing.Size(320, 650);
			this.grpRootCauses.TabIndex = 2;
			this.grpRootCauses.TabStop = false;
			this.grpRootCauses.Text = "Root Causes";
			// 
			// olvRootCauses
			// 
			this.olvRootCauses.AllColumns.Add(this.olvColumn1);
			this.olvRootCauses.CellEditTabChangesRows = true;
			this.olvRootCauses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
			this.olvRootCauses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRootCauses.EmptyListMsg = "No root causes defined.";
			this.olvRootCauses.FullRowSelect = true;
			this.olvRootCauses.GridLines = true;
			this.olvRootCauses.HasCollapsibleGroups = false;
			this.olvRootCauses.HideSelection = false;
			this.olvRootCauses.Location = new System.Drawing.Point(3, 46);
			this.olvRootCauses.MultiSelect = false;
			this.olvRootCauses.Name = "olvRootCauses";
			this.olvRootCauses.SelectAllOnControlA = false;
			this.olvRootCauses.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRootCauses.ShowCommandMenuOnRightClick = true;
			this.olvRootCauses.ShowGroups = false;
			this.olvRootCauses.ShowItemCountOnGroups = true;
			this.olvRootCauses.Size = new System.Drawing.Size(314, 601);
			this.olvRootCauses.SortGroupItemsByPrimaryColumn = false;
			this.olvRootCauses.TabIndex = 1;
			this.olvRootCauses.UseCompatibleStateImageBehavior = false;
			this.olvRootCauses.View = System.Windows.Forms.View.Details;
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "Description";
			this.olvColumn1.CellPadding = null;
			this.olvColumn1.FillsFreeSpace = true;
			this.olvColumn1.Groupable = false;
			this.olvColumn1.Hideable = false;
			this.olvColumn1.IsEditable = false;
			this.olvColumn1.Text = "Description";
			this.olvColumn1.Width = 300;
			// 
			// pnlRootCauses_Control
			// 
			this.pnlRootCauses_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Remove);
			this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Edit);
			this.pnlRootCauses_Control.Controls.Add(this.btnRootCause_Add);
			this.pnlRootCauses_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRootCauses_Control.Location = new System.Drawing.Point(3, 16);
			this.pnlRootCauses_Control.Name = "pnlRootCauses_Control";
			this.pnlRootCauses_Control.Size = new System.Drawing.Size(314, 30);
			this.pnlRootCauses_Control.TabIndex = 0;
			// 
			// btnRootCause_Remove
			// 
			this.btnRootCause_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRootCause_Remove.Location = new System.Drawing.Point(89, 4);
			this.btnRootCause_Remove.Name = "btnRootCause_Remove";
			this.btnRootCause_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnRootCause_Remove.TabIndex = 1;
			this.btnRootCause_Remove.Text = "Remove";
			this.btnRootCause_Remove.UseVisualStyleBackColor = false;
			this.btnRootCause_Remove.Click += new System.EventHandler(this.btnRootCause_Remove_Click);
			// 
			// btnRootCause_Edit
			// 
			this.btnRootCause_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnRootCause_Edit.Location = new System.Drawing.Point(175, 4);
			this.btnRootCause_Edit.Name = "btnRootCause_Edit";
			this.btnRootCause_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnRootCause_Edit.TabIndex = 2;
			this.btnRootCause_Edit.Text = "Edit";
			this.btnRootCause_Edit.UseVisualStyleBackColor = false;
			this.btnRootCause_Edit.Click += new System.EventHandler(this.btnRootCause_Edit_Click);
			// 
			// btnRootCause_Add
			// 
			this.btnRootCause_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRootCause_Add.Location = new System.Drawing.Point(3, 4);
			this.btnRootCause_Add.Name = "btnRootCause_Add";
			this.btnRootCause_Add.Size = new System.Drawing.Size(80, 23);
			this.btnRootCause_Add.TabIndex = 0;
			this.btnRootCause_Add.Text = "Add";
			this.btnRootCause_Add.UseVisualStyleBackColor = false;
			this.btnRootCause_Add.Click += new System.EventHandler(this.btnRootCause_Add_Click);
			// 
			// FormRMA_FailureRepair_Management
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(994, 706);
			this.Controls.Add(this.grpRootCauses);
			this.Controls.Add(this.grpRepairTypes);
			this.Controls.Add(this.grpFailureTypes);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1010, 2000);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1010, 300);
			this.Name = "FormRMA_FailureRepair_Management";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA: Failure and Repair Type Management";
			this.grpFailureTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvFailureTypes)).EndInit();
			this.pnlFailureTypes_Control.ResumeLayout(false);
			this.grpRepairTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRepairTypes)).EndInit();
			this.pnlRepairTypes_Control.ResumeLayout(false);
			this.grpRootCauses.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRootCauses)).EndInit();
			this.pnlRootCauses_Control.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox grpFailureTypes;
		private System.Windows.Forms.GroupBox grpRepairTypes;
		private System.Windows.Forms.Panel pnlFailureTypes_Control;
		private System.Windows.Forms.Button btnFailureType_Add;
		private BrightIdeasSoftware.ObjectListView olvFailureTypes;
		private BrightIdeasSoftware.OLVColumn olvColFailureType_Description;
		private BrightIdeasSoftware.ObjectListView olvRepairTypes;
		private BrightIdeasSoftware.OLVColumn olvColRepairType_Description;
		private System.Windows.Forms.Panel pnlRepairTypes_Control;
		private System.Windows.Forms.Button btnRepairType_Add;
		private System.Windows.Forms.Button btnFailureType_Remove;
		private System.Windows.Forms.Button btnFailureType_Edit;
		private System.Windows.Forms.Button btnRepairType_Remove;
		private System.Windows.Forms.Button btnRepairType_Edit;
		private System.Windows.Forms.GroupBox grpRootCauses;
		private BrightIdeasSoftware.ObjectListView olvRootCauses;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private System.Windows.Forms.Panel pnlRootCauses_Control;
		private System.Windows.Forms.Button btnRootCause_Remove;
		private System.Windows.Forms.Button btnRootCause_Edit;
		private System.Windows.Forms.Button btnRootCause_Add;
	}
}