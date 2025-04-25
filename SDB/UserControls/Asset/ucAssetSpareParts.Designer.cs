namespace SDB.UserControls.Asset
{
	partial class ucAssetSpareParts
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.olvSpareParts = new BrightIdeasSoftware.ObjectListView();
			this.olcAssemblyDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcExpected = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnDecrement = new System.Windows.Forms.Button();
			this.btnIncrement = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.olvSpareParts)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvSpareParts
			// 
			this.olvSpareParts.AllColumns.Add(this.olcAssemblyDescription);
			this.olvSpareParts.AllColumns.Add(this.olcQuantity);
			this.olvSpareParts.AllColumns.Add(this.olcExpected);
			this.olvSpareParts.AllowColumnReorder = true;
			this.olvSpareParts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcAssemblyDescription,
            this.olcQuantity,
            this.olcExpected});
			this.olvSpareParts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSpareParts.EmptyListMsg = "No spare parts defined for this asset.";
			this.olvSpareParts.FullRowSelect = true;
			this.olvSpareParts.GridLines = true;
			this.olvSpareParts.HasCollapsibleGroups = false;
			this.olvSpareParts.Location = new System.Drawing.Point(0, 30);
			this.olvSpareParts.Name = "olvSpareParts";
			this.olvSpareParts.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvSpareParts.ShowCommandMenuOnRightClick = true;
			this.olvSpareParts.ShowGroups = false;
			this.olvSpareParts.Size = new System.Drawing.Size(443, 155);
			this.olvSpareParts.TabIndex = 8;
			this.olvSpareParts.UseCompatibleStateImageBehavior = false;
			this.olvSpareParts.View = System.Windows.Forms.View.Details;
			this.olvSpareParts.DoubleClick += new System.EventHandler(this.olvSpareParts_DoubleClick);
			// 
			// olcAssemblyDescription
			// 
			this.olcAssemblyDescription.AspectName = "Assembly.DisplayMember";
			this.olcAssemblyDescription.CellPadding = null;
			this.olcAssemblyDescription.FillsFreeSpace = true;
			this.olcAssemblyDescription.Text = "Assembly";
			this.olcAssemblyDescription.Width = 300;
			// 
			// olcQuantity
			// 
			this.olcQuantity.AspectName = "Quantity";
			this.olcQuantity.CellPadding = null;
			this.olcQuantity.Text = "Qty";
			// 
			// olcExpected
			// 
			this.olcExpected.AspectName = "Expected";
			this.olcExpected.CellPadding = null;
			this.olcExpected.Text = "Expected";
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnDecrement);
			this.pnlControl.Controls.Add(this.btnIncrement);
			this.pnlControl.Controls.Add(this.btnEdit);
			this.pnlControl.Controls.Add(this.btnDelete);
			this.pnlControl.Controls.Add(this.btnAdd);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(443, 30);
			this.pnlControl.TabIndex = 7;
			// 
			// btnDecrement
			// 
			this.btnDecrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnDecrement.Location = new System.Drawing.Point(335, 3);
			this.btnDecrement.Name = "btnDecrement";
			this.btnDecrement.Size = new System.Drawing.Size(27, 23);
			this.btnDecrement.TabIndex = 15;
			this.btnDecrement.Text = "—";
			this.toolTip.SetToolTip(this.btnDecrement, "Decrease selected spare quantity.");
			this.btnDecrement.UseVisualStyleBackColor = false;
			this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
			// 
			// btnIncrement
			// 
			this.btnIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnIncrement.Location = new System.Drawing.Point(302, 3);
			this.btnIncrement.Name = "btnIncrement";
			this.btnIncrement.Size = new System.Drawing.Size(27, 23);
			this.btnIncrement.TabIndex = 14;
			this.btnIncrement.Text = "+";
			this.toolTip.SetToolTip(this.btnIncrement, "Increase selected spare quantity.");
			this.btnIncrement.UseVisualStyleBackColor = false;
			this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Location = new System.Drawing.Point(175, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(80, 23);
			this.btnEdit.TabIndex = 13;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDelete.Location = new System.Drawing.Point(89, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(80, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ucAssetSpareParts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.olvSpareParts);
			this.Controls.Add(this.pnlControl);
			this.Name = "ucAssetSpareParts";
			this.Size = new System.Drawing.Size(443, 185);
			((System.ComponentModel.ISupportInitialize)(this.olvSpareParts)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvSpareParts;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private BrightIdeasSoftware.OLVColumn olcAssemblyDescription;
		private BrightIdeasSoftware.OLVColumn olcQuantity;
		private BrightIdeasSoftware.OLVColumn olcExpected;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDecrement;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnIncrement;
	}
}
