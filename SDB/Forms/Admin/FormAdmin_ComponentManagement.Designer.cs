namespace SDB.Forms.Admin
{
	partial class FormAdmin_ComponentManagement
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
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvComponents = new BrightIdeasSoftware.ObjectListView();
			this.olvColComponent_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColComponent_CompNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColComponent_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColComponent_Location = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColComponent_Cost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColComponent_InventoryQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnEnableDisable = new System.Windows.Forms.Button();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblDivider = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvComponents)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.Controls.Add(this.olvComponents);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Controls.Add(this.lblDivider);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(660, 630);
			this.pnlContainer.TabIndex = 4;
			// 
			// olvComponents
			// 
			this.olvComponents.AllColumns.Add(this.olvColComponent_ID);
			this.olvComponents.AllColumns.Add(this.olvColComponent_CompNumber);
			this.olvComponents.AllColumns.Add(this.olvColComponent_Description);
			this.olvComponents.AllColumns.Add(this.olvColComponent_Location);
			this.olvComponents.AllColumns.Add(this.olvColComponent_Cost);
			this.olvComponents.AllColumns.Add(this.olvColComponent_InventoryQty);
			this.olvComponents.CellEditTabChangesRows = true;
			this.olvComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColComponent_ID,
            this.olvColComponent_CompNumber,
            this.olvColComponent_Description,
            this.olvColComponent_Location,
            this.olvColComponent_Cost,
            this.olvColComponent_InventoryQty});
			this.olvComponents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvComponents.EmptyListMsg = "No components defined.";
			this.olvComponents.FullRowSelect = true;
			this.olvComponents.GridLines = true;
			this.olvComponents.HasCollapsibleGroups = false;
			this.olvComponents.HideSelection = false;
			this.olvComponents.Location = new System.Drawing.Point(0, 31);
			this.olvComponents.MultiSelect = false;
			this.olvComponents.Name = "olvComponents";
			this.olvComponents.SelectAllOnControlA = false;
			this.olvComponents.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvComponents.ShowCommandMenuOnRightClick = true;
			this.olvComponents.ShowGroups = false;
			this.olvComponents.ShowItemCountOnGroups = true;
			this.olvComponents.Size = new System.Drawing.Size(660, 599);
			this.olvComponents.SortGroupItemsByPrimaryColumn = false;
			this.olvComponents.TabIndex = 0;
			this.olvComponents.UseCompatibleStateImageBehavior = false;
			this.olvComponents.View = System.Windows.Forms.View.Details;
			this.olvComponents.SelectedIndexChanged += new System.EventHandler(this.olvComponents_SelectedIndexChanged);
			this.olvComponents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvComponents_MouseDoubleClick);
			// 
			// olvColComponent_ID
			// 
			this.olvColComponent_ID.AspectName = "ID";
			this.olvColComponent_ID.Groupable = false;
			this.olvColComponent_ID.IsEditable = false;
			this.olvColComponent_ID.IsVisible = false;
			this.olvColComponent_ID.Searchable = false;
			this.olvColComponent_ID.Sortable = false;
			this.olvColComponent_ID.Text = "ID";
			this.olvColComponent_ID.Width = 0;
			// 
			// olvColComponent_CompNumber
			// 
			this.olvColComponent_CompNumber.AspectName = "ComponentNumber";
			this.olvColComponent_CompNumber.Groupable = false;
			this.olvColComponent_CompNumber.Hideable = false;
			this.olvColComponent_CompNumber.IsEditable = false;
			this.olvColComponent_CompNumber.Text = "Component #";
			this.olvColComponent_CompNumber.Width = 140;
			// 
			// olvColComponent_Description
			// 
			this.olvColComponent_Description.AspectName = "Description";
			this.olvColComponent_Description.FillsFreeSpace = true;
			this.olvColComponent_Description.Groupable = false;
			this.olvColComponent_Description.Hideable = false;
			this.olvColComponent_Description.IsEditable = false;
			this.olvColComponent_Description.Text = "Description";
			this.olvColComponent_Description.Width = 300;
			// 
			// olvColComponent_Location
			// 
			this.olvColComponent_Location.AspectName = "Location";
			this.olvColComponent_Location.Hideable = false;
			this.olvColComponent_Location.IsEditable = false;
			this.olvColComponent_Location.Text = "Location";
			this.olvColComponent_Location.Width = 70;
			// 
			// olvColComponent_Cost
			// 
			this.olvColComponent_Cost.AspectName = "Cost";
			this.olvColComponent_Cost.AspectToStringFormat = "{0:0.000}";
			this.olvColComponent_Cost.AutoCompleteEditor = false;
			this.olvColComponent_Cost.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
			this.olvColComponent_Cost.Groupable = false;
			this.olvColComponent_Cost.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColComponent_Cost.Hideable = false;
			this.olvColComponent_Cost.IsEditable = false;
			this.olvColComponent_Cost.Searchable = false;
			this.olvColComponent_Cost.Text = "Cost";
			this.olvColComponent_Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// olvColComponent_InventoryQty
			// 
			this.olvColComponent_InventoryQty.AspectName = "InventoryQty";
			this.olvColComponent_InventoryQty.AutoCompleteEditor = false;
			this.olvColComponent_InventoryQty.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
			this.olvColComponent_InventoryQty.Groupable = false;
			this.olvColComponent_InventoryQty.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olvColComponent_InventoryQty.Hideable = false;
			this.olvColComponent_InventoryQty.IsEditable = false;
			this.olvColComponent_InventoryQty.Searchable = false;
			this.olvColComponent_InventoryQty.Text = "Inv. Qty";
			this.olvColComponent_InventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnEdit);
			this.pnlControl.Controls.Add(this.btnEnableDisable);
			this.pnlControl.Controls.Add(this.lblQty);
			this.pnlControl.Controls.Add(this.txtQty);
			this.pnlControl.Controls.Add(this.btnDelete);
			this.pnlControl.Controls.Add(this.btnAdd);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 1);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(660, 30);
			this.pnlControl.TabIndex = 9;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Location = new System.Drawing.Point(387, 4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(120, 23);
			this.btnEdit.TabIndex = 12;
			this.btnEdit.Text = "&Edit Component";
			this.toolTip.SetToolTip(this.btnEdit, "Edit selected component.");
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnComponent_Edit_Click);
			// 
			// btnEnableDisable
			// 
			this.btnEnableDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnEnableDisable.Location = new System.Drawing.Point(259, 4);
			this.btnEnableDisable.Name = "btnEnableDisable";
			this.btnEnableDisable.Size = new System.Drawing.Size(120, 23);
			this.btnEnableDisable.TabIndex = 11;
			this.btnEnableDisable.Text = "Disable Component";
			this.toolTip.SetToolTip(this.btnEnableDisable, "Enable or disable selected component.");
			this.btnEnableDisable.UseVisualStyleBackColor = false;
			this.btnEnableDisable.Click += new System.EventHandler(this.btnComponent_EnableDisable_Click);
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(522, 9);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(69, 13);
			this.lblQty.TabIndex = 9;
			this.lblQty.Text = "Components:";
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(597, 4);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(60, 22);
			this.txtQty.TabIndex = 10;
			this.txtQty.TabStop = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDelete.Location = new System.Drawing.Point(131, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete Component";
			this.toolTip.SetToolTip(this.btnDelete, "Delete or disable the selected component.");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnComponent_Delete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAdd.Location = new System.Drawing.Point(3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add Component";
			this.toolTip.SetToolTip(this.btnAdd, "Add a new component to the database.");
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnComponent_Add_Click);
			// 
			// lblDivider
			// 
			this.lblDivider.BackColor = System.Drawing.Color.Black;
			this.lblDivider.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDivider.Location = new System.Drawing.Point(0, 0);
			this.lblDivider.Name = "lblDivider";
			this.lblDivider.Size = new System.Drawing.Size(660, 1);
			this.lblDivider.TabIndex = 11;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(597, 656);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "&Close";
			this.toolTip.SetToolTip(this.btnClose, "Saves all parts changes.");
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormComponentManagement
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(684, 691);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "FormComponentManagement";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Component Management";
			this.Load += new System.EventHandler(this.FormComponentManagement_Load);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvComponents)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvComponents;
		private BrightIdeasSoftware.OLVColumn olvColComponent_CompNumber;
		private System.Windows.Forms.Button btnClose;
		private BrightIdeasSoftware.OLVColumn olvColComponent_Description;
		private BrightIdeasSoftware.OLVColumn olvColComponent_Location;
		private BrightIdeasSoftware.OLVColumn olvColComponent_Cost;
		private BrightIdeasSoftware.OLVColumn olvColComponent_InventoryQty;
		private BrightIdeasSoftware.OLVColumn olvColComponent_ID;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label lblDivider;
		private System.Windows.Forms.Button btnEnableDisable;
		private System.Windows.Forms.Button btnEdit;

	}
}