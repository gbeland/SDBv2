namespace SDB.Forms.Admin
{
	partial class FormAdmin_AssemblyManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_AssemblyManagement));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.olvAssemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColAssembly_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_AssyNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly_Location = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColInventoryQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAssembly_Control = new System.Windows.Forms.Panel();
            this.txtAssemblies_OfType = new System.Windows.Forms.TextBox();
            this.lblAssemblies_OfType = new System.Windows.Forms.Label();
            this.btnAssembly_Edit = new System.Windows.Forms.Button();
            this.btnAssembly_EnableDisable = new System.Windows.Forms.Button();
            this.lblAssembly_Qty = new System.Windows.Forms.Label();
            this.txtAssembly_Qty = new System.Windows.Forms.TextBox();
            this.btnAssembly_Delete = new System.Windows.Forms.Button();
            this.btnAssembly_Add = new System.Windows.Forms.Button();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.olvTypes = new BrightIdeasSoftware.ObjectListView();
            this.olcType_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_SerialNumberFormat = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_IsComputer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcType_AllowDiscard = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcCustomsDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTariffCode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTypes_Control = new System.Windows.Forms.Panel();
            this.txtTypes_OfCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAssemblyType_Bottom = new System.Windows.Forms.Panel();
            this.pnlAssemblyType_BottomLeft = new System.Windows.Forms.Panel();
            this.btnType_Edit = new System.Windows.Forms.Button();
            this.btnType_Delete = new System.Windows.Forms.Button();
            this.btnType_Add = new System.Windows.Forms.Button();
            this.pnlType_BottomRight = new System.Windows.Forms.Panel();
            this.lblType_Qty = new System.Windows.Forms.Label();
            this.txtType_Qty = new System.Windows.Forms.TextBox();
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.olvCategories = new BrightIdeasSoftware.ObjectListView();
            this.olcCategory_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcCategory_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlCategory_Control = new System.Windows.Forms.Panel();
            this.pnlAssemblyCategory_Bottom = new System.Windows.Forms.Panel();
            this.pnlAssemblyCategory_BottomLeft = new System.Windows.Forms.Panel();
            this.btnCategory_Edit = new System.Windows.Forms.Button();
            this.btnCategory_Delete = new System.Windows.Forms.Button();
            this.btnCategory_Add = new System.Windows.Forms.Button();
            this.pnlAssemblyCategory_BottomRight = new System.Windows.Forms.Panel();
            this.lblCategory_Qty = new System.Windows.Forms.Label();
            this.txtCategory_Qty = new System.Windows.Forms.TextBox();
            this.lblAssemblyCategories = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).BeginInit();
            this.pnlAssembly_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTypes)).BeginInit();
            this.pnlTypes_Control.SuspendLayout();
            this.pnlAssemblyType_Bottom.SuspendLayout();
            this.pnlAssemblyType_BottomLeft.SuspendLayout();
            this.pnlType_BottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCategories)).BeginInit();
            this.pnlCategory_Control.SuspendLayout();
            this.pnlAssemblyCategory_Bottom.SuspendLayout();
            this.pnlAssemblyCategory_BottomLeft.SuspendLayout();
            this.pnlAssemblyCategory_BottomRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.olvAssemblies);
            this.pnlContainer.Controls.Add(this.pnlAssembly_Control);
            this.pnlContainer.Controls.Add(this.lblDivider1);
            this.pnlContainer.Controls.Add(this.olvTypes);
            this.pnlContainer.Controls.Add(this.pnlTypes_Control);
            this.pnlContainer.Controls.Add(this.lblDivider2);
            this.pnlContainer.Controls.Add(this.olvCategories);
            this.pnlContainer.Controls.Add(this.pnlCategory_Control);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(860, 805);
            this.pnlContainer.TabIndex = 4;
            // 
            // olvAssemblies
            // 
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_ID);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_AssyNumber);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_Description);
            this.olvAssemblies.AllColumns.Add(this.olvColAssembly_Location);
            this.olvAssemblies.AllColumns.Add(this.olvColCost);
            this.olvAssemblies.AllColumns.Add(this.olvColInventoryQty);
            this.olvAssemblies.CellEditTabChangesRows = true;
            this.olvAssemblies.CellEditUseWholeCell = false;
            this.olvAssemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAssembly_ID,
            this.olvColAssembly_AssyNumber,
            this.olvColAssembly_Description,
            this.olvColAssembly_Location,
            this.olvColCost,
            this.olvColInventoryQty});
            this.olvAssemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssemblies.EmptyListMsg = "No type selected.";
            this.olvAssemblies.FullRowSelect = true;
            this.olvAssemblies.GridLines = true;
            this.olvAssemblies.HasCollapsibleGroups = false;
            this.olvAssemblies.HideSelection = false;
            this.olvAssemblies.Location = new System.Drawing.Point(0, 552);
            this.olvAssemblies.MultiSelect = false;
            this.olvAssemblies.Name = "olvAssemblies";
            this.olvAssemblies.SelectAllOnControlA = false;
            this.olvAssemblies.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvAssemblies.ShowCommandMenuOnRightClick = true;
            this.olvAssemblies.ShowGroups = false;
            this.olvAssemblies.ShowItemCountOnGroups = true;
            this.olvAssemblies.Size = new System.Drawing.Size(860, 253);
            this.olvAssemblies.SortGroupItemsByPrimaryColumn = false;
            this.olvAssemblies.TabIndex = 0;
            this.olvAssemblies.UseCompatibleStateImageBehavior = false;
            this.olvAssemblies.View = System.Windows.Forms.View.Details;
            this.olvAssemblies.SelectedIndexChanged += new System.EventHandler(this.olvAssemblies_SelectedIndexChanged);
            this.olvAssemblies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvAssemblies_MouseDoubleClick);
            // 
            // olvColAssembly_ID
            // 
            this.olvColAssembly_ID.AspectName = "ID";
            this.olvColAssembly_ID.Groupable = false;
            this.olvColAssembly_ID.IsEditable = false;
            this.olvColAssembly_ID.IsVisible = false;
            this.olvColAssembly_ID.Searchable = false;
            this.olvColAssembly_ID.Sortable = false;
            this.olvColAssembly_ID.Text = "ID";
            this.olvColAssembly_ID.Width = 0;
            // 
            // olvColAssembly_AssyNumber
            // 
            this.olvColAssembly_AssyNumber.AspectName = "AssemblyNumber";
            this.olvColAssembly_AssyNumber.Groupable = false;
            this.olvColAssembly_AssyNumber.Hideable = false;
            this.olvColAssembly_AssyNumber.IsEditable = false;
            this.olvColAssembly_AssyNumber.Text = "Assembly #";
            this.olvColAssembly_AssyNumber.Width = 140;
            // 
            // olvColAssembly_Description
            // 
            this.olvColAssembly_Description.AspectName = "Description";
            this.olvColAssembly_Description.FillsFreeSpace = true;
            this.olvColAssembly_Description.Groupable = false;
            this.olvColAssembly_Description.Hideable = false;
            this.olvColAssembly_Description.IsEditable = false;
            this.olvColAssembly_Description.Text = "Description";
            this.olvColAssembly_Description.Width = 300;
            // 
            // olvColAssembly_Location
            // 
            this.olvColAssembly_Location.AspectName = "Location";
            this.olvColAssembly_Location.Hideable = false;
            this.olvColAssembly_Location.IsEditable = false;
            this.olvColAssembly_Location.Text = "Location";
            this.olvColAssembly_Location.Width = 70;
            // 
            // olvColCost
            // 
            this.olvColCost.AspectName = "Cost";
            this.olvColCost.AspectToStringFormat = "{0:0.00}";
            this.olvColCost.AutoCompleteEditor = false;
            this.olvColCost.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColCost.Groupable = false;
            this.olvColCost.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColCost.Hideable = false;
            this.olvColCost.IsEditable = false;
            this.olvColCost.Searchable = false;
            this.olvColCost.Text = "Cost";
            this.olvColCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // olvColInventoryQty
            // 
            this.olvColInventoryQty.AspectName = "InventoryQty";
            this.olvColInventoryQty.AutoCompleteEditor = false;
            this.olvColInventoryQty.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColInventoryQty.Groupable = false;
            this.olvColInventoryQty.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColInventoryQty.Hideable = false;
            this.olvColInventoryQty.IsEditable = false;
            this.olvColInventoryQty.Searchable = false;
            this.olvColInventoryQty.Text = "Inv. Qty";
            this.olvColInventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlAssembly_Control
            // 
            this.pnlAssembly_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssembly_Control.Controls.Add(this.txtAssemblies_OfType);
            this.pnlAssembly_Control.Controls.Add(this.lblAssemblies_OfType);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Edit);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_EnableDisable);
            this.pnlAssembly_Control.Controls.Add(this.lblAssembly_Qty);
            this.pnlAssembly_Control.Controls.Add(this.txtAssembly_Qty);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Delete);
            this.pnlAssembly_Control.Controls.Add(this.btnAssembly_Add);
            this.pnlAssembly_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssembly_Control.Location = new System.Drawing.Point(0, 502);
            this.pnlAssembly_Control.Name = "pnlAssembly_Control";
            this.pnlAssembly_Control.Size = new System.Drawing.Size(860, 50);
            this.pnlAssembly_Control.TabIndex = 9;
            // 
            // txtAssemblies_OfType
            // 
            this.txtAssemblies_OfType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAssemblies_OfType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAssemblies_OfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblies_OfType.Location = new System.Drawing.Point(125, 6);
            this.txtAssemblies_OfType.Name = "txtAssemblies_OfType";
            this.txtAssemblies_OfType.ReadOnly = true;
            this.txtAssemblies_OfType.Size = new System.Drawing.Size(532, 13);
            this.txtAssemblies_OfType.TabIndex = 14;
            this.txtAssemblies_OfType.TabStop = false;
            this.txtAssemblies_OfType.Text = "(None Selected)";
            // 
            // lblAssemblies_OfType
            // 
            this.lblAssemblies_OfType.AutoSize = true;
            this.lblAssemblies_OfType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblies_OfType.Location = new System.Drawing.Point(3, 6);
            this.lblAssemblies_OfType.Name = "lblAssemblies_OfType";
            this.lblAssemblies_OfType.Size = new System.Drawing.Size(73, 13);
            this.lblAssemblies_OfType.TabIndex = 13;
            this.lblAssemblies_OfType.Text = "Assemblies:";
            // 
            // btnAssembly_Edit
            // 
            this.btnAssembly_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssembly_Edit.Location = new System.Drawing.Point(387, 22);
            this.btnAssembly_Edit.Name = "btnAssembly_Edit";
            this.btnAssembly_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Edit.TabIndex = 12;
            this.btnAssembly_Edit.Text = "Edit Assembly";
            this.toolTip1.SetToolTip(this.btnAssembly_Edit, "Edit selected assembly.");
            this.btnAssembly_Edit.UseVisualStyleBackColor = false;
            this.btnAssembly_Edit.Click += new System.EventHandler(this.btnAssembly_Edit_Click);
            // 
            // btnAssembly_EnableDisable
            // 
            this.btnAssembly_EnableDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAssembly_EnableDisable.Location = new System.Drawing.Point(259, 22);
            this.btnAssembly_EnableDisable.Name = "btnAssembly_EnableDisable";
            this.btnAssembly_EnableDisable.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_EnableDisable.TabIndex = 11;
            this.btnAssembly_EnableDisable.Text = "Disable Assembly";
            this.toolTip1.SetToolTip(this.btnAssembly_EnableDisable, "Enable or disable selected assembly.");
            this.btnAssembly_EnableDisable.UseVisualStyleBackColor = false;
            this.btnAssembly_EnableDisable.Click += new System.EventHandler(this.btnAssembly_EnableDisable_Click);
            // 
            // lblAssembly_Qty
            // 
            this.lblAssembly_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssembly_Qty.AutoSize = true;
            this.lblAssembly_Qty.Location = new System.Drawing.Point(729, 27);
            this.lblAssembly_Qty.Name = "lblAssembly_Qty";
            this.lblAssembly_Qty.Size = new System.Drawing.Size(62, 13);
            this.lblAssembly_Qty.TabIndex = 9;
            this.lblAssembly_Qty.Text = "Assemblies:";
            // 
            // txtAssembly_Qty
            // 
            this.txtAssembly_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssembly_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssembly_Qty.Location = new System.Drawing.Point(797, 22);
            this.txtAssembly_Qty.Name = "txtAssembly_Qty";
            this.txtAssembly_Qty.ReadOnly = true;
            this.txtAssembly_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtAssembly_Qty.TabIndex = 10;
            this.txtAssembly_Qty.TabStop = false;
            // 
            // btnAssembly_Delete
            // 
            this.btnAssembly_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssembly_Delete.Location = new System.Drawing.Point(131, 22);
            this.btnAssembly_Delete.Name = "btnAssembly_Delete";
            this.btnAssembly_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Delete.TabIndex = 1;
            this.btnAssembly_Delete.Text = "Delete Assembly";
            this.toolTip1.SetToolTip(this.btnAssembly_Delete, "Delete or merge the selected assembly.");
            this.btnAssembly_Delete.UseVisualStyleBackColor = false;
            this.btnAssembly_Delete.Click += new System.EventHandler(this.btnAssembly_Delete_Click);
            // 
            // btnAssembly_Add
            // 
            this.btnAssembly_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssembly_Add.Location = new System.Drawing.Point(3, 22);
            this.btnAssembly_Add.Name = "btnAssembly_Add";
            this.btnAssembly_Add.Size = new System.Drawing.Size(120, 23);
            this.btnAssembly_Add.TabIndex = 0;
            this.btnAssembly_Add.Text = "Add &Assembly";
            this.toolTip1.SetToolTip(this.btnAssembly_Add, "Add a new assembly.");
            this.btnAssembly_Add.UseVisualStyleBackColor = false;
            this.btnAssembly_Add.Click += new System.EventHandler(this.btnAssembly_Add_Click);
            // 
            // lblDivider1
            // 
            this.lblDivider1.BackColor = System.Drawing.Color.Black;
            this.lblDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider1.Location = new System.Drawing.Point(0, 501);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Size = new System.Drawing.Size(860, 1);
            this.lblDivider1.TabIndex = 11;
            // 
            // olvTypes
            // 
            this.olvTypes.AllColumns.Add(this.olcType_ID);
            this.olvTypes.AllColumns.Add(this.olcType_Description);
            this.olvTypes.AllColumns.Add(this.olcType_SerialNumberFormat);
            this.olvTypes.AllColumns.Add(this.olcType_IsComputer);
            this.olvTypes.AllColumns.Add(this.olcType_AllowDiscard);
            this.olvTypes.AllColumns.Add(this.olcCustomsDescription);
            this.olvTypes.AllColumns.Add(this.olcTariffCode);
            this.olvTypes.CellEditTabChangesRows = true;
            this.olvTypes.CellEditUseWholeCell = false;
            this.olvTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcType_ID,
            this.olcType_Description,
            this.olcType_SerialNumberFormat,
            this.olcType_IsComputer,
            this.olcType_AllowDiscard,
            this.olcCustomsDescription,
            this.olcTariffCode});
            this.olvTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvTypes.EmptyListMsg = "No category selected.";
            this.olvTypes.FullRowSelect = true;
            this.olvTypes.GridLines = true;
            this.olvTypes.HasCollapsibleGroups = false;
            this.olvTypes.HideSelection = false;
            this.olvTypes.Location = new System.Drawing.Point(0, 301);
            this.olvTypes.MultiSelect = false;
            this.olvTypes.Name = "olvTypes";
            this.olvTypes.SelectAllOnControlA = false;
            this.olvTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvTypes.ShowCommandMenuOnRightClick = true;
            this.olvTypes.ShowGroups = false;
            this.olvTypes.ShowItemCountOnGroups = true;
            this.olvTypes.Size = new System.Drawing.Size(860, 200);
            this.olvTypes.SmallImageList = this.imageList1;
            this.olvTypes.SortGroupItemsByPrimaryColumn = false;
            this.olvTypes.TabIndex = 10;
            this.olvTypes.UseCompatibleStateImageBehavior = false;
            this.olvTypes.View = System.Windows.Forms.View.Details;
            this.olvTypes.SelectedIndexChanged += new System.EventHandler(this.olvTypes_SelectedIndexChanged);
            this.olvTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTypes_MouseDoubleClick);
            // 
            // olcType_ID
            // 
            this.olcType_ID.AspectName = "ID";
            this.olcType_ID.Groupable = false;
            this.olcType_ID.IsEditable = false;
            this.olcType_ID.IsVisible = false;
            this.olcType_ID.Searchable = false;
            this.olcType_ID.Sortable = false;
            this.olcType_ID.Text = "ID";
            this.olcType_ID.Width = 0;
            // 
            // olcType_Description
            // 
            this.olcType_Description.AspectName = "Description";
            this.olcType_Description.FillsFreeSpace = true;
            this.olcType_Description.Groupable = false;
            this.olcType_Description.Hideable = false;
            this.olcType_Description.IsEditable = false;
            this.olcType_Description.Text = "Description";
            this.olcType_Description.Width = 380;
            // 
            // olcType_SerialNumberFormat
            // 
            this.olcType_SerialNumberFormat.AspectName = "SerialNumberFormat";
            this.olcType_SerialNumberFormat.Text = "SN Format";
            this.olcType_SerialNumberFormat.Width = 100;
            // 
            // olcType_IsComputer
            // 
            this.olcType_IsComputer.AspectName = "NeedsPrep";
            this.olcType_IsComputer.IsEditable = false;
            this.olcType_IsComputer.Text = "Req. Prep";
            this.olcType_IsComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcType_IsComputer.ToolTipText = "Requires preparation before shipping.";
            this.olcType_IsComputer.Width = 68;
            // 
            // olcType_AllowDiscard
            // 
            this.olcType_AllowDiscard.AspectName = "AllowDiscard";
            this.olcType_AllowDiscard.IsEditable = false;
            this.olcType_AllowDiscard.Text = "Discardable";
            this.olcType_AllowDiscard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcType_AllowDiscard.ToolTipText = "Is allowed to be discarded when creating RMA.";
            this.olcType_AllowDiscard.Width = 68;
            // 
            // olcCustomsDescription
            // 
            this.olcCustomsDescription.AspectName = "CustomsDescription";
            this.olcCustomsDescription.Text = "Customs Description";
            this.olcCustomsDescription.ToolTipText = "Brief description for customs purposes during import/export.";
            this.olcCustomsDescription.Width = 150;
            // 
            // olcTariffCode
            // 
            this.olcTariffCode.AspectName = "TariffCode";
            this.olcTariffCode.Text = "Tariff Code";
            this.olcTariffCode.ToolTipText = "Harmonized tariff code for import/export during shipping.";
            this.olcTariffCode.Width = 70;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "computer");
            this.imageList1.Images.SetKeyName(1, "trash");
            // 
            // pnlTypes_Control
            // 
            this.pnlTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTypes_Control.Controls.Add(this.txtTypes_OfCategory);
            this.pnlTypes_Control.Controls.Add(this.label2);
            this.pnlTypes_Control.Controls.Add(this.pnlAssemblyType_Bottom);
            this.pnlTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTypes_Control.Location = new System.Drawing.Point(0, 251);
            this.pnlTypes_Control.Name = "pnlTypes_Control";
            this.pnlTypes_Control.Size = new System.Drawing.Size(860, 50);
            this.pnlTypes_Control.TabIndex = 8;
            // 
            // txtTypes_OfCategory
            // 
            this.txtTypes_OfCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTypes_OfCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypes_OfCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypes_OfCategory.Location = new System.Drawing.Point(125, 6);
            this.txtTypes_OfCategory.Name = "txtTypes_OfCategory";
            this.txtTypes_OfCategory.ReadOnly = true;
            this.txtTypes_OfCategory.Size = new System.Drawing.Size(532, 13);
            this.txtTypes_OfCategory.TabIndex = 15;
            this.txtTypes_OfCategory.TabStop = false;
            this.txtTypes_OfCategory.Text = "(None Selected)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Types:";
            // 
            // pnlAssemblyType_Bottom
            // 
            this.pnlAssemblyType_Bottom.Controls.Add(this.pnlAssemblyType_BottomLeft);
            this.pnlAssemblyType_Bottom.Controls.Add(this.pnlType_BottomRight);
            this.pnlAssemblyType_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssemblyType_Bottom.Location = new System.Drawing.Point(0, 20);
            this.pnlAssemblyType_Bottom.Name = "pnlAssemblyType_Bottom";
            this.pnlAssemblyType_Bottom.Size = new System.Drawing.Size(860, 30);
            this.pnlAssemblyType_Bottom.TabIndex = 11;
            // 
            // pnlAssemblyType_BottomLeft
            // 
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Edit);
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Delete);
            this.pnlAssemblyType_BottomLeft.Controls.Add(this.btnType_Add);
            this.pnlAssemblyType_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssemblyType_BottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlAssemblyType_BottomLeft.Name = "pnlAssemblyType_BottomLeft";
            this.pnlAssemblyType_BottomLeft.Size = new System.Drawing.Size(720, 30);
            this.pnlAssemblyType_BottomLeft.TabIndex = 9;
            // 
            // btnType_Edit
            // 
            this.btnType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnType_Edit.Location = new System.Drawing.Point(259, 4);
            this.btnType_Edit.Name = "btnType_Edit";
            this.btnType_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnType_Edit.TabIndex = 2;
            this.btnType_Edit.Text = "Edit Type";
            this.toolTip1.SetToolTip(this.btnType_Edit, "Edit selected assembly type.");
            this.btnType_Edit.UseVisualStyleBackColor = false;
            this.btnType_Edit.Click += new System.EventHandler(this.btnTypes_Edit_Click);
            // 
            // btnType_Delete
            // 
            this.btnType_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnType_Delete.Location = new System.Drawing.Point(131, 4);
            this.btnType_Delete.Name = "btnType_Delete";
            this.btnType_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnType_Delete.TabIndex = 1;
            this.btnType_Delete.Text = "Delete Type";
            this.toolTip1.SetToolTip(this.btnType_Delete, "Delete the selected assembly type.");
            this.btnType_Delete.UseVisualStyleBackColor = false;
            this.btnType_Delete.Click += new System.EventHandler(this.btnTypes_Delete_Click);
            // 
            // btnType_Add
            // 
            this.btnType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnType_Add.Name = "btnType_Add";
            this.btnType_Add.Size = new System.Drawing.Size(120, 23);
            this.btnType_Add.TabIndex = 0;
            this.btnType_Add.Text = "Add &Type";
            this.toolTip1.SetToolTip(this.btnType_Add, "Add a new assembly type.");
            this.btnType_Add.UseVisualStyleBackColor = false;
            this.btnType_Add.Click += new System.EventHandler(this.btnTypes_Add_Click);
            // 
            // pnlType_BottomRight
            // 
            this.pnlType_BottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlType_BottomRight.Controls.Add(this.lblType_Qty);
            this.pnlType_BottomRight.Controls.Add(this.txtType_Qty);
            this.pnlType_BottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlType_BottomRight.Location = new System.Drawing.Point(720, 0);
            this.pnlType_BottomRight.Name = "pnlType_BottomRight";
            this.pnlType_BottomRight.Size = new System.Drawing.Size(140, 30);
            this.pnlType_BottomRight.TabIndex = 10;
            // 
            // lblType_Qty
            // 
            this.lblType_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType_Qty.AutoSize = true;
            this.lblType_Qty.Location = new System.Drawing.Point(32, 9);
            this.lblType_Qty.Name = "lblType_Qty";
            this.lblType_Qty.Size = new System.Drawing.Size(39, 13);
            this.lblType_Qty.TabIndex = 7;
            this.lblType_Qty.Text = "Types:";
            // 
            // txtType_Qty
            // 
            this.txtType_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtType_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType_Qty.Location = new System.Drawing.Point(77, 4);
            this.txtType_Qty.Name = "txtType_Qty";
            this.txtType_Qty.ReadOnly = true;
            this.txtType_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtType_Qty.TabIndex = 8;
            this.txtType_Qty.TabStop = false;
            // 
            // lblDivider2
            // 
            this.lblDivider2.BackColor = System.Drawing.Color.Black;
            this.lblDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider2.Location = new System.Drawing.Point(0, 250);
            this.lblDivider2.Name = "lblDivider2";
            this.lblDivider2.Size = new System.Drawing.Size(860, 1);
            this.lblDivider2.TabIndex = 12;
            // 
            // olvCategories
            // 
            this.olvCategories.AllColumns.Add(this.olcCategory_ID);
            this.olvCategories.AllColumns.Add(this.olcCategory_Description);
            this.olvCategories.CellEditUseWholeCell = false;
            this.olvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCategory_ID,
            this.olcCategory_Description});
            this.olvCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvCategories.EmptyListMsg = "No categories defined.";
            this.olvCategories.FullRowSelect = true;
            this.olvCategories.GridLines = true;
            this.olvCategories.HasCollapsibleGroups = false;
            this.olvCategories.HideSelection = false;
            this.olvCategories.Location = new System.Drawing.Point(0, 50);
            this.olvCategories.MultiSelect = false;
            this.olvCategories.Name = "olvCategories";
            this.olvCategories.SelectAllOnControlA = false;
            this.olvCategories.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvCategories.ShowCommandMenuOnRightClick = true;
            this.olvCategories.ShowGroups = false;
            this.olvCategories.ShowItemCountOnGroups = true;
            this.olvCategories.Size = new System.Drawing.Size(860, 200);
            this.olvCategories.SortGroupItemsByPrimaryColumn = false;
            this.olvCategories.TabIndex = 0;
            this.olvCategories.UseCompatibleStateImageBehavior = false;
            this.olvCategories.View = System.Windows.Forms.View.Details;
            this.olvCategories.SelectedIndexChanged += new System.EventHandler(this.olvCategories_SelectedIndexChanged);
            this.olvCategories.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvCategories_MouseDoubleClick);
            // 
            // olcCategory_ID
            // 
            this.olcCategory_ID.AspectName = "ID";
            this.olcCategory_ID.Groupable = false;
            this.olcCategory_ID.IsEditable = false;
            this.olcCategory_ID.IsVisible = false;
            this.olcCategory_ID.Sortable = false;
            this.olcCategory_ID.Width = 0;
            // 
            // olcCategory_Description
            // 
            this.olcCategory_Description.AspectName = "Description";
            this.olcCategory_Description.Text = "Description";
            this.olcCategory_Description.Width = 380;
            // 
            // pnlCategory_Control
            // 
            this.pnlCategory_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCategory_Control.Controls.Add(this.pnlAssemblyCategory_Bottom);
            this.pnlCategory_Control.Controls.Add(this.lblAssemblyCategories);
            this.pnlCategory_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory_Control.Name = "pnlCategory_Control";
            this.pnlCategory_Control.Size = new System.Drawing.Size(860, 50);
            this.pnlCategory_Control.TabIndex = 11;
            // 
            // pnlAssemblyCategory_Bottom
            // 
            this.pnlAssemblyCategory_Bottom.Controls.Add(this.pnlAssemblyCategory_BottomLeft);
            this.pnlAssemblyCategory_Bottom.Controls.Add(this.pnlAssemblyCategory_BottomRight);
            this.pnlAssemblyCategory_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAssemblyCategory_Bottom.Location = new System.Drawing.Point(0, 20);
            this.pnlAssemblyCategory_Bottom.Name = "pnlAssemblyCategory_Bottom";
            this.pnlAssemblyCategory_Bottom.Size = new System.Drawing.Size(860, 30);
            this.pnlAssemblyCategory_Bottom.TabIndex = 15;
            // 
            // pnlAssemblyCategory_BottomLeft
            // 
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Edit);
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Delete);
            this.pnlAssemblyCategory_BottomLeft.Controls.Add(this.btnCategory_Add);
            this.pnlAssemblyCategory_BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAssemblyCategory_BottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlAssemblyCategory_BottomLeft.Name = "pnlAssemblyCategory_BottomLeft";
            this.pnlAssemblyCategory_BottomLeft.Size = new System.Drawing.Size(720, 30);
            this.pnlAssemblyCategory_BottomLeft.TabIndex = 9;
            // 
            // btnCategory_Edit
            // 
            this.btnCategory_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnCategory_Edit.Location = new System.Drawing.Point(259, 4);
            this.btnCategory_Edit.Name = "btnCategory_Edit";
            this.btnCategory_Edit.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Edit.TabIndex = 2;
            this.btnCategory_Edit.Text = "Edit Category";
            this.toolTip1.SetToolTip(this.btnCategory_Edit, "Edit selected assembly type.");
            this.btnCategory_Edit.UseVisualStyleBackColor = false;
            this.btnCategory_Edit.Click += new System.EventHandler(this.btnCategory_Edit_Click);
            // 
            // btnCategory_Delete
            // 
            this.btnCategory_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCategory_Delete.Location = new System.Drawing.Point(131, 4);
            this.btnCategory_Delete.Name = "btnCategory_Delete";
            this.btnCategory_Delete.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Delete.TabIndex = 1;
            this.btnCategory_Delete.Text = "Delete Category";
            this.toolTip1.SetToolTip(this.btnCategory_Delete, "Delete the selected assembly type.");
            this.btnCategory_Delete.UseVisualStyleBackColor = false;
            this.btnCategory_Delete.Click += new System.EventHandler(this.btnCategory_Delete_Click);
            // 
            // btnCategory_Add
            // 
            this.btnCategory_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCategory_Add.Location = new System.Drawing.Point(3, 4);
            this.btnCategory_Add.Name = "btnCategory_Add";
            this.btnCategory_Add.Size = new System.Drawing.Size(120, 23);
            this.btnCategory_Add.TabIndex = 0;
            this.btnCategory_Add.Text = "Add &Category";
            this.toolTip1.SetToolTip(this.btnCategory_Add, "Add a new assembly type.");
            this.btnCategory_Add.UseVisualStyleBackColor = false;
            this.btnCategory_Add.Click += new System.EventHandler(this.btnCategory_Add_Click);
            // 
            // pnlAssemblyCategory_BottomRight
            // 
            this.pnlAssemblyCategory_BottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssemblyCategory_BottomRight.Controls.Add(this.lblCategory_Qty);
            this.pnlAssemblyCategory_BottomRight.Controls.Add(this.txtCategory_Qty);
            this.pnlAssemblyCategory_BottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAssemblyCategory_BottomRight.Location = new System.Drawing.Point(720, 0);
            this.pnlAssemblyCategory_BottomRight.Name = "pnlAssemblyCategory_BottomRight";
            this.pnlAssemblyCategory_BottomRight.Size = new System.Drawing.Size(140, 30);
            this.pnlAssemblyCategory_BottomRight.TabIndex = 10;
            // 
            // lblCategory_Qty
            // 
            this.lblCategory_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory_Qty.AutoSize = true;
            this.lblCategory_Qty.Location = new System.Drawing.Point(11, 9);
            this.lblCategory_Qty.Name = "lblCategory_Qty";
            this.lblCategory_Qty.Size = new System.Drawing.Size(60, 13);
            this.lblCategory_Qty.TabIndex = 7;
            this.lblCategory_Qty.Text = "Categories:";
            // 
            // txtCategory_Qty
            // 
            this.txtCategory_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory_Qty.Location = new System.Drawing.Point(77, 4);
            this.txtCategory_Qty.Name = "txtCategory_Qty";
            this.txtCategory_Qty.ReadOnly = true;
            this.txtCategory_Qty.Size = new System.Drawing.Size(60, 22);
            this.txtCategory_Qty.TabIndex = 8;
            this.txtCategory_Qty.TabStop = false;
            // 
            // lblAssemblyCategories
            // 
            this.lblAssemblyCategories.AutoSize = true;
            this.lblAssemblyCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssemblyCategories.Location = new System.Drawing.Point(3, 6);
            this.lblAssemblyCategories.Name = "lblAssemblyCategories";
            this.lblAssemblyCategories.Size = new System.Drawing.Size(71, 13);
            this.lblAssemblyCategories.TabIndex = 14;
            this.lblAssemblyCategories.Text = "Categories:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(797, 831);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.toolTip1.SetToolTip(this.btnClose, "Saves all parts changes.");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAdmin_AssemblyManagement
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(884, 866);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 680);
            this.Name = "FormAdmin_AssemblyManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assembly Management";
            this.Load += new System.EventHandler(this.FormPartsManagement_Load);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblies)).EndInit();
            this.pnlAssembly_Control.ResumeLayout(false);
            this.pnlAssembly_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTypes)).EndInit();
            this.pnlTypes_Control.ResumeLayout(false);
            this.pnlTypes_Control.PerformLayout();
            this.pnlAssemblyType_Bottom.ResumeLayout(false);
            this.pnlAssemblyType_BottomLeft.ResumeLayout(false);
            this.pnlType_BottomRight.ResumeLayout(false);
            this.pnlType_BottomRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvCategories)).EndInit();
            this.pnlCategory_Control.ResumeLayout(false);
            this.pnlCategory_Control.PerformLayout();
            this.pnlAssemblyCategory_Bottom.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomLeft.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomRight.ResumeLayout(false);
            this.pnlAssemblyCategory_BottomRight.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvAssemblies;
		private BrightIdeasSoftware.OLVColumn olvColAssembly_AssyNumber;
		private System.Windows.Forms.Panel pnlTypes_Control;
		private System.Windows.Forms.Panel pnlAssemblyType_BottomLeft;
		private System.Windows.Forms.Button btnClose;
		private BrightIdeasSoftware.OLVColumn olvColAssembly_Description;
		private BrightIdeasSoftware.OLVColumn olvColAssembly_Location;
		private BrightIdeasSoftware.OLVColumn olvColCost;
		private BrightIdeasSoftware.OLVColumn olvColInventoryQty;
		private System.Windows.Forms.Button btnType_Delete;
		private System.Windows.Forms.Button btnType_Add;
		private BrightIdeasSoftware.OLVColumn olvColAssembly_ID;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel pnlAssembly_Control;
		private System.Windows.Forms.Button btnAssembly_Delete;
		private System.Windows.Forms.Button btnAssembly_Add;
		private System.Windows.Forms.Panel pnlType_BottomRight;
		private System.Windows.Forms.Label lblType_Qty;
		private System.Windows.Forms.TextBox txtType_Qty;
		private BrightIdeasSoftware.ObjectListView olvTypes;
		private BrightIdeasSoftware.OLVColumn olcType_ID;
		private BrightIdeasSoftware.OLVColumn olcType_Description;
		private System.Windows.Forms.Label lblAssembly_Qty;
		private System.Windows.Forms.TextBox txtAssembly_Qty;
		private System.Windows.Forms.Label lblDivider1;
		private System.Windows.Forms.Button btnAssembly_EnableDisable;
		private System.Windows.Forms.Button btnAssembly_Edit;
		private System.Windows.Forms.Button btnType_Edit;
		private System.Windows.Forms.TextBox txtAssemblies_OfType;
		private System.Windows.Forms.Label lblAssemblies_OfType;
		private BrightIdeasSoftware.OLVColumn olcType_IsComputer;
		private BrightIdeasSoftware.OLVColumn olcType_SerialNumberFormat;
		private System.Windows.Forms.Panel pnlAssemblyType_Bottom;
		private BrightIdeasSoftware.ObjectListView olvCategories;
		private System.Windows.Forms.Panel pnlCategory_Control;
		private System.Windows.Forms.Label lblAssemblyCategories;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTypes_OfCategory;
		private System.Windows.Forms.Panel pnlAssemblyCategory_Bottom;
		private System.Windows.Forms.Panel pnlAssemblyCategory_BottomLeft;
		private System.Windows.Forms.Button btnCategory_Edit;
		private System.Windows.Forms.Button btnCategory_Delete;
		private System.Windows.Forms.Button btnCategory_Add;
		private System.Windows.Forms.Panel pnlAssemblyCategory_BottomRight;
		private System.Windows.Forms.Label lblCategory_Qty;
		private System.Windows.Forms.TextBox txtCategory_Qty;
		private System.Windows.Forms.Label lblDivider2;
		private BrightIdeasSoftware.OLVColumn olcCategory_ID;
		private BrightIdeasSoftware.OLVColumn olcCategory_Description;
		private BrightIdeasSoftware.OLVColumn olcType_AllowDiscard;
		private System.Windows.Forms.ImageList imageList1;
		private BrightIdeasSoftware.OLVColumn olcCustomsDescription;
		private BrightIdeasSoftware.OLVColumn olcTariffCode;

	}
}