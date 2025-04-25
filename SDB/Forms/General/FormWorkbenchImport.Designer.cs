namespace SDB.Forms.General
{
	partial class FormWorkbenchImport
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
			this.olvWorkbenchItems = new BrightIdeasSoftware.ObjectListView();
			this.olvColCatalogNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColUnitCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColPartComp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnFilter = new System.Windows.Forms.Button();
			this.txtFilter = new System.Windows.Forms.TextBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.timerDelay = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvWorkbenchItems)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(436, 627);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(517, 627);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.Controls.Add(this.olvWorkbenchItems);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(580, 609);
			this.pnlContainer.TabIndex = 0;
			// 
			// olvWorkbenchItems
			// 
			this.olvWorkbenchItems.AllColumns.Add(this.olvColCatalogNumber);
			this.olvWorkbenchItems.AllColumns.Add(this.olvColCategory);
			this.olvWorkbenchItems.AllColumns.Add(this.olvColDescription);
			this.olvWorkbenchItems.AllColumns.Add(this.olvColUnitCost);
			this.olvWorkbenchItems.AllColumns.Add(this.olvColPartComp);
			this.olvWorkbenchItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColCatalogNumber,
            this.olvColCategory,
            this.olvColDescription,
            this.olvColUnitCost,
            this.olvColPartComp});
			this.olvWorkbenchItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvWorkbenchItems.EmptyListMsg = "No Workbench items to import.";
			this.olvWorkbenchItems.FullRowSelect = true;
			this.olvWorkbenchItems.GridLines = true;
			this.olvWorkbenchItems.Location = new System.Drawing.Point(0, 30);
			this.olvWorkbenchItems.MultiSelect = false;
			this.olvWorkbenchItems.Name = "olvWorkbenchItems";
			this.olvWorkbenchItems.OwnerDraw = true;
			this.olvWorkbenchItems.ShowFilterMenuOnRightClick = false;
			this.olvWorkbenchItems.ShowGroups = false;
			this.olvWorkbenchItems.Size = new System.Drawing.Size(580, 579);
			this.olvWorkbenchItems.TabIndex = 0;
			this.olvWorkbenchItems.UseCompatibleStateImageBehavior = false;
			this.olvWorkbenchItems.UseFiltering = true;
			this.olvWorkbenchItems.View = System.Windows.Forms.View.Details;
			this.olvWorkbenchItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvWorkbenchItems_MouseDoubleClick);
			// 
			// olvColCatalogNumber
			// 
			this.olvColCatalogNumber.AspectName = "CatalogNumber";
			this.olvColCatalogNumber.Text = "Catalog #";
			this.olvColCatalogNumber.Width = 100;
			// 
			// olvColCategory
			// 
			this.olvColCategory.AspectName = "Category";
			this.olvColCategory.Text = "Category";
			this.olvColCategory.Width = 120;
			// 
			// olvColDescription
			// 
			this.olvColDescription.AspectName = "Description";
			this.olvColDescription.Text = "Description";
			this.olvColDescription.Width = 232;
			// 
			// olvColUnitCost
			// 
			this.olvColUnitCost.AspectName = "UnitCost";
			this.olvColUnitCost.AspectToStringFormat = "{0:0.00}";
			this.olvColUnitCost.Searchable = false;
			this.olvColUnitCost.Text = "Unit Cost";
			// 
			// olvColPartComp
			// 
			this.olvColPartComp.AspectName = "PartComponent";
			this.olvColPartComp.Searchable = false;
			this.olvColPartComp.Text = "P/C";
			this.olvColPartComp.Width = 32;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnFilter);
			this.pnlControl.Controls.Add(this.txtFilter);
			this.pnlControl.Controls.Add(this.lblQty);
			this.pnlControl.Controls.Add(this.txtQty);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(580, 30);
			this.pnlControl.TabIndex = 0;
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(143, 3);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(54, 23);
			this.btnFilter.TabIndex = 1;
			this.btnFilter.Text = "Filter";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Visible = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// txtFilter
			// 
			this.txtFilter.Location = new System.Drawing.Point(3, 5);
			this.txtFilter.MaxLength = 32;
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.Size = new System.Drawing.Size(134, 20);
			this.txtFilter.TabIndex = 0;
			this.toolTip.SetToolTip(this.txtFilter, "Enter text to filter list.");
			this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(436, 8);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(35, 13);
			this.lblQty.TabIndex = 2;
			this.lblQty.Text = "Items:";
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Location = new System.Drawing.Point(477, 5);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(100, 20);
			this.txtQty.TabIndex = 3;
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// timerDelay
			// 
			this.timerDelay.Interval = 500;
			this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
			// 
			// FormWorkbenchImport
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(604, 662);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(620, 300);
			this.Name = "FormWorkbenchImport";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Assembly/Component: Workbench Import";
			this.Load += new System.EventHandler(this.FormWorkbenchImport_Load);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvWorkbenchItems)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Panel pnlControl;
		private BrightIdeasSoftware.ObjectListView olvWorkbenchItems;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtQty;
		private BrightIdeasSoftware.OLVColumn olvColCatalogNumber;
		private BrightIdeasSoftware.OLVColumn olvColCategory;
		private BrightIdeasSoftware.OLVColumn olvColDescription;
		private BrightIdeasSoftware.OLVColumn olvColUnitCost;
		private BrightIdeasSoftware.OLVColumn olvColPartComp;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.TextBox txtFilter;
		private System.Windows.Forms.Timer timerDelay;
		private System.Windows.Forms.ToolTip toolTip;
	}
}