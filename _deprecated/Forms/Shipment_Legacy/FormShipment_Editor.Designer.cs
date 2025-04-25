using SDB.Classes.Misc;

namespace SDB.Forms.Shipment
{
	partial class FormShipment_Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipment_Editor));
            this.grpLedger = new System.Windows.Forms.GroupBox();
            this.olvLedger = new BrightIdeasSoftware.ObjectListView();
            this.olvColLedger_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_Quantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_RMA = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_Ticket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_JobNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLedger_SerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlLedger_Control = new System.Windows.Forms.Panel();
            this.lblReadyDate = new System.Windows.Forms.Label();
            this.txtReadyDate = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnLedger_Add = new System.Windows.Forms.Button();
            this.btnLedger_Remove = new System.Windows.Forms.Button();
            this.btnLedger_Edit = new System.Windows.Forms.Button();
            this.lblLedger_ItemQty = new System.Windows.Forms.Label();
            this.txtLedger_ItemQty = new System.Windows.Forms.TextBox();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.Shipmentstabs = new System.Windows.Forms.TabControl();
            this.tabDestination = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectMarket = new System.Windows.Forms.Button();
            this.btnSelectTech = new System.Windows.Forms.Button();
            this.btnOtherAddressLookup = new System.Windows.Forms.Button();
            this.txtDest_Company = new System.Windows.Forms.TextBox();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.lblDest_Company = new System.Windows.Forms.Label();
            this.radAddressTypeResidence = new System.Windows.Forms.RadioButton();
            this.lblDest_Address = new System.Windows.Forms.Label();
            this.radAddressTypeBusiness = new System.Windows.Forms.RadioButton();
            this.lblDest_Attn = new System.Windows.Forms.Label();
            this.txtDest_Telephone = new System.Windows.Forms.TextBox();
            this.lblDest_State = new System.Windows.Forms.Label();
            this.txtDest_Country = new System.Windows.Forms.TextBox();
            this.lblDest_City = new System.Windows.Forms.Label();
            this.txtDest_Zip = new System.Windows.Forms.TextBox();
            this.lblDest_Zip = new System.Windows.Forms.Label();
            this.txtDest_State = new System.Windows.Forms.TextBox();
            this.lblDest_Country = new System.Windows.Forms.Label();
            this.txtDest_City = new System.Windows.Forms.TextBox();
            this.lblDest_Telephone = new System.Windows.Forms.Label();
            this.txtDest_Address = new System.Windows.Forms.TextBox();
            this.txtDest_Attn = new System.Windows.Forms.TextBox();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.lblEpartsEmail = new System.Windows.Forms.Label();
            this.tbxEmailList = new System.Windows.Forms.TextBox();
            this.pbNotesFlag = new System.Windows.Forms.PictureBox();
            this.ePartsCbx = new System.Windows.Forms.CheckBox();
            this.txtPurchaseOrder = new System.Windows.Forms.TextBox();
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblShippingMethod = new System.Windows.Forms.Label();
            this.cmbShippingMethod = new System.Windows.Forms.ComboBox();
            this.txtRequestedDate = new System.Windows.Forms.TextBox();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.lblRequestedDate = new System.Windows.Forms.Label();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.grpJournal = new System.Windows.Forms.GroupBox();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlJournal_Control = new System.Windows.Forms.Panel();
            this.btnJournal_Add = new System.Windows.Forms.Button();
            this.grpFulfillment = new System.Windows.Forms.GroupBox();
            this.pnlShip = new System.Windows.Forms.Panel();
            this.btnViewTracking = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.numWeight = new SDB.Classes.Misc.ClassFixedNumericUpDown();
            this.lblShippedBy = new System.Windows.Forms.Label();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.lblTrackingNumber = new System.Windows.Forms.Label();
            this.numPackages = new SDB.Classes.Misc.ClassFixedNumericUpDown();
            this.txtShippedBy = new System.Windows.Forms.TextBox();
            this.txtShipDate = new System.Windows.Forms.TextBox();
            this.lblPackages = new System.Windows.Forms.Label();
            this.numInsurance = new SDB.Classes.Misc.ClassFixedNumericUpDown();
            this.numTotalCost = new SDB.Classes.Misc.ClassFixedNumericUpDown();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.pnlPick = new System.Windows.Forms.Panel();
            this.btnPick = new System.Windows.Forms.Button();
            this.lblPickedBy = new System.Windows.Forms.Label();
            this.lblPickDate = new System.Windows.Forms.Label();
            this.txtPickedBy = new System.Windows.Forms.TextBox();
            this.txtPickDate = new System.Windows.Forms.TextBox();
            this.pnlTopControl = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoldRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.lblShipmentNumber = new System.Windows.Forms.Label();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.txtShipmentNumber = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.copyJobNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAssemblyList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLedger)).BeginInit();
            this.pnlLedger_Control.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.Shipmentstabs.SuspendLayout();
            this.tabDestination.SuspendLayout();
            this.tabEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesFlag)).BeginInit();
            this.grpJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.pnlJournal_Control.SuspendLayout();
            this.grpFulfillment.SuspendLayout();
            this.pnlShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).BeginInit();
            this.pnlPick.SuspendLayout();
            this.pnlTopControl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cmAssemblyList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLedger
            // 
            this.grpLedger.Controls.Add(this.olvLedger);
            this.grpLedger.Controls.Add(this.pnlLedger_Control);
            this.grpLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLedger.Location = new System.Drawing.Point(0, 440);
            this.grpLedger.Name = "grpLedger";
            this.grpLedger.Size = new System.Drawing.Size(784, 195);
            this.grpLedger.TabIndex = 3;
            this.grpLedger.TabStop = false;
            this.grpLedger.Text = "Ledger";
            // 
            // olvLedger
            // 
            this.olvLedger.AllColumns.Add(this.olvColLedger_ID);
            this.olvLedger.AllColumns.Add(this.olvColLedger_Quantity);
            this.olvLedger.AllColumns.Add(this.olvColLedger_Description);
            this.olvLedger.AllColumns.Add(this.olvColLedger_RMA);
            this.olvLedger.AllColumns.Add(this.olvColLedger_Ticket);
            this.olvLedger.AllColumns.Add(this.olvColLedger_Asset);
            this.olvLedger.AllColumns.Add(this.olvColLedger_JobNumber);
            this.olvLedger.AllColumns.Add(this.olvColLedger_SerialNumber);
            this.olvLedger.AllowColumnReorder = true;
            this.olvLedger.CellEditUseWholeCell = false;
            this.olvLedger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColLedger_ID,
            this.olvColLedger_Quantity,
            this.olvColLedger_Description,
            this.olvColLedger_RMA,
            this.olvColLedger_Ticket,
            this.olvColLedger_Asset,
            this.olvColLedger_JobNumber,
            this.olvColLedger_SerialNumber});
            this.olvLedger.ContextMenuStrip = this.cmAssemblyList;
            this.olvLedger.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvLedger.EmptyListMsg = "No items assigned to shipment.";
            this.olvLedger.FullRowSelect = true;
            this.olvLedger.GridLines = true;
            this.olvLedger.HasCollapsibleGroups = false;
            this.olvLedger.HideSelection = false;
            this.olvLedger.Location = new System.Drawing.Point(3, 46);
            this.olvLedger.MultiSelect = false;
            this.olvLedger.Name = "olvLedger";
            this.olvLedger.ShowGroups = false;
            this.olvLedger.Size = new System.Drawing.Size(778, 146);
            this.olvLedger.TabIndex = 0;
            this.olvLedger.UseCompatibleStateImageBehavior = false;
            this.olvLedger.UseHyperlinks = true;
            this.olvLedger.View = System.Windows.Forms.View.Details;
            this.olvLedger.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvLedger_CellToolTipShowing);
            this.olvLedger.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.olvLedger_HyperlinkClicked);
            this.olvLedger.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvLedger_MouseDoubleClick);
            // 
            // olvColLedger_ID
            // 
            this.olvColLedger_ID.AspectName = "ID";
            this.olvColLedger_ID.Groupable = false;
            this.olvColLedger_ID.IsEditable = false;
            this.olvColLedger_ID.IsVisible = false;
            this.olvColLedger_ID.Searchable = false;
            this.olvColLedger_ID.Text = "ID";
            this.olvColLedger_ID.Width = 0;
            // 
            // olvColLedger_Quantity
            // 
            this.olvColLedger_Quantity.AspectName = "Quantity";
            this.olvColLedger_Quantity.Groupable = false;
            this.olvColLedger_Quantity.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColLedger_Quantity.Text = "Qty";
            this.olvColLedger_Quantity.Width = 50;
            // 
            // olvColLedger_Description
            // 
            this.olvColLedger_Description.AspectName = "Description";
            this.olvColLedger_Description.Groupable = false;
            this.olvColLedger_Description.Text = "Assembly";
            this.olvColLedger_Description.Width = 270;
            // 
            // olvColLedger_RMA
            // 
            this.olvColLedger_RMA.AspectName = "RMA_ID";
            this.olvColLedger_RMA.Hyperlink = true;
            this.olvColLedger_RMA.Text = "RMA";
            this.olvColLedger_RMA.Width = 70;
            // 
            // olvColLedger_Ticket
            // 
            this.olvColLedger_Ticket.AspectName = "Ticket_ID";
            this.olvColLedger_Ticket.Hyperlink = true;
            this.olvColLedger_Ticket.Text = "Ticket";
            this.olvColLedger_Ticket.Width = 70;
            // 
            // olvColLedger_Asset
            // 
            this.olvColLedger_Asset.AspectName = "Asset_Name";
            this.olvColLedger_Asset.Hyperlink = true;
            this.olvColLedger_Asset.Text = "Asset";
            this.olvColLedger_Asset.Width = 100;
            // 
            // olvColLedger_JobNumber
            // 
            this.olvColLedger_JobNumber.AspectName = "Job_Number";
            this.olvColLedger_JobNumber.Text = "Job Number";
            this.olvColLedger_JobNumber.Width = 80;
            // 
            // olvColLedger_SerialNumber
            // 
            this.olvColLedger_SerialNumber.AspectName = "Serial_Number";
            this.olvColLedger_SerialNumber.Text = "Serial Number";
            this.olvColLedger_SerialNumber.Width = 120;
            // 
            // pnlLedger_Control
            // 
            this.pnlLedger_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlLedger_Control.Controls.Add(this.lblReadyDate);
            this.pnlLedger_Control.Controls.Add(this.txtReadyDate);
            this.pnlLedger_Control.Controls.Add(this.btnReady);
            this.pnlLedger_Control.Controls.Add(this.btnLedger_Add);
            this.pnlLedger_Control.Controls.Add(this.btnLedger_Remove);
            this.pnlLedger_Control.Controls.Add(this.btnLedger_Edit);
            this.pnlLedger_Control.Controls.Add(this.lblLedger_ItemQty);
            this.pnlLedger_Control.Controls.Add(this.txtLedger_ItemQty);
            this.pnlLedger_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLedger_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlLedger_Control.Name = "pnlLedger_Control";
            this.pnlLedger_Control.Size = new System.Drawing.Size(778, 30);
            this.pnlLedger_Control.TabIndex = 2;
            // 
            // lblReadyDate
            // 
            this.lblReadyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReadyDate.AutoSize = true;
            this.lblReadyDate.Location = new System.Drawing.Point(356, 8);
            this.lblReadyDate.Name = "lblReadyDate";
            this.lblReadyDate.Size = new System.Drawing.Size(64, 13);
            this.lblReadyDate.TabIndex = 11;
            this.lblReadyDate.Text = "Ready Date";
            // 
            // txtReadyDate
            // 
            this.txtReadyDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReadyDate.Location = new System.Drawing.Point(426, 5);
            this.txtReadyDate.MaxLength = 64;
            this.txtReadyDate.Name = "txtReadyDate";
            this.txtReadyDate.ReadOnly = true;
            this.txtReadyDate.Size = new System.Drawing.Size(116, 20);
            this.txtReadyDate.TabIndex = 12;
            this.txtReadyDate.TabStop = false;
            this.txtReadyDate.Tag = "ReadOnly";
            // 
            // btnReady
            // 
            this.btnReady.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReady.Enabled = false;
            this.btnReady.Location = new System.Drawing.Point(548, 3);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(133, 23);
            this.btnReady.TabIndex = 10;
            this.btnReady.Text = "Mark as Ready to Pick";
            this.toolTip.SetToolTip(this.btnReady, "Marks the shipment as ready to pick.");
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnLedger_Add
            // 
            this.btnLedger_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLedger_Add.Location = new System.Drawing.Point(3, 3);
            this.btnLedger_Add.Name = "btnLedger_Add";
            this.btnLedger_Add.Size = new System.Drawing.Size(92, 23);
            this.btnLedger_Add.TabIndex = 0;
            this.btnLedger_Add.Text = "Add Item";
            this.btnLedger_Add.UseVisualStyleBackColor = false;
            this.btnLedger_Add.Click += new System.EventHandler(this.btnLedger_Add_Click);
            // 
            // btnLedger_Remove
            // 
            this.btnLedger_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLedger_Remove.Location = new System.Drawing.Point(101, 3);
            this.btnLedger_Remove.Name = "btnLedger_Remove";
            this.btnLedger_Remove.Size = new System.Drawing.Size(92, 23);
            this.btnLedger_Remove.TabIndex = 1;
            this.btnLedger_Remove.Text = "Remove Item";
            this.btnLedger_Remove.UseVisualStyleBackColor = false;
            this.btnLedger_Remove.Click += new System.EventHandler(this.btnLedger_Remove_Click);
            // 
            // btnLedger_Edit
            // 
            this.btnLedger_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnLedger_Edit.Location = new System.Drawing.Point(199, 3);
            this.btnLedger_Edit.Name = "btnLedger_Edit";
            this.btnLedger_Edit.Size = new System.Drawing.Size(92, 23);
            this.btnLedger_Edit.TabIndex = 4;
            this.btnLedger_Edit.Text = "Edit Item...";
            this.btnLedger_Edit.UseVisualStyleBackColor = false;
            this.btnLedger_Edit.Click += new System.EventHandler(this.btnLedger_Edit_Click);
            // 
            // lblLedger_ItemQty
            // 
            this.lblLedger_ItemQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLedger_ItemQty.AutoSize = true;
            this.lblLedger_ItemQty.Location = new System.Drawing.Point(687, 8);
            this.lblLedger_ItemQty.Name = "lblLedger_ItemQty";
            this.lblLedger_ItemQty.Size = new System.Drawing.Size(32, 13);
            this.lblLedger_ItemQty.TabIndex = 2;
            this.lblLedger_ItemQty.Text = "Items";
            // 
            // txtLedger_ItemQty
            // 
            this.txtLedger_ItemQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLedger_ItemQty.Location = new System.Drawing.Point(725, 5);
            this.txtLedger_ItemQty.Name = "txtLedger_ItemQty";
            this.txtLedger_ItemQty.ReadOnly = true;
            this.txtLedger_ItemQty.Size = new System.Drawing.Size(50, 20);
            this.txtLedger_ItemQty.TabIndex = 3;
            this.txtLedger_ItemQty.TabStop = false;
            this.txtLedger_ItemQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.Shipmentstabs);
            this.grpRequest.Controls.Add(this.pbNotesFlag);
            this.grpRequest.Controls.Add(this.ePartsCbx);
            this.grpRequest.Controls.Add(this.txtPurchaseOrder);
            this.grpRequest.Controls.Add(this.lblPurchaseOrder);
            this.grpRequest.Controls.Add(this.lblNotes);
            this.grpRequest.Controls.Add(this.txtNotes);
            this.grpRequest.Controls.Add(this.lblShippingMethod);
            this.grpRequest.Controls.Add(this.cmbShippingMethod);
            this.grpRequest.Controls.Add(this.txtRequestedDate);
            this.grpRequest.Controls.Add(this.txtRequestedBy);
            this.grpRequest.Controls.Add(this.lblRequestedDate);
            this.grpRequest.Controls.Add(this.lblRequestedBy);
            this.grpRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpRequest.Location = new System.Drawing.Point(0, 204);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(784, 236);
            this.grpRequest.TabIndex = 2;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Request";
            // 
            // Shipmentstabs
            // 
            this.Shipmentstabs.Controls.Add(this.tabDestination);
            this.Shipmentstabs.Controls.Add(this.tabEmail);
            this.Shipmentstabs.Location = new System.Drawing.Point(14, 32);
            this.Shipmentstabs.Name = "Shipmentstabs";
            this.Shipmentstabs.SelectedIndex = 0;
            this.Shipmentstabs.Size = new System.Drawing.Size(764, 154);
            this.Shipmentstabs.TabIndex = 76;
            // 
            // tabDestination
            // 
            this.tabDestination.Controls.Add(this.btnClear);
            this.tabDestination.Controls.Add(this.btnSelectMarket);
            this.tabDestination.Controls.Add(this.btnSelectTech);
            this.tabDestination.Controls.Add(this.btnOtherAddressLookup);
            this.tabDestination.Controls.Add(this.txtDest_Company);
            this.tabDestination.Controls.Add(this.lblAddressType);
            this.tabDestination.Controls.Add(this.lblDest_Company);
            this.tabDestination.Controls.Add(this.radAddressTypeResidence);
            this.tabDestination.Controls.Add(this.lblDest_Address);
            this.tabDestination.Controls.Add(this.radAddressTypeBusiness);
            this.tabDestination.Controls.Add(this.lblDest_Attn);
            this.tabDestination.Controls.Add(this.txtDest_Telephone);
            this.tabDestination.Controls.Add(this.lblDest_State);
            this.tabDestination.Controls.Add(this.txtDest_Country);
            this.tabDestination.Controls.Add(this.lblDest_City);
            this.tabDestination.Controls.Add(this.txtDest_Zip);
            this.tabDestination.Controls.Add(this.lblDest_Zip);
            this.tabDestination.Controls.Add(this.txtDest_State);
            this.tabDestination.Controls.Add(this.lblDest_Country);
            this.tabDestination.Controls.Add(this.txtDest_City);
            this.tabDestination.Controls.Add(this.lblDest_Telephone);
            this.tabDestination.Controls.Add(this.txtDest_Address);
            this.tabDestination.Controls.Add(this.txtDest_Attn);
            this.tabDestination.Location = new System.Drawing.Point(4, 22);
            this.tabDestination.Name = "tabDestination";
            this.tabDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestination.Size = new System.Drawing.Size(756, 128);
            this.tabDestination.TabIndex = 0;
            this.tabDestination.Text = "Destination";
            this.tabDestination.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(673, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.toolTip.SetToolTip(this.btnClear, "Clear destination fields.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelectMarket
            // 
            this.btnSelectMarket.Location = new System.Drawing.Point(4, 37);
            this.btnSelectMarket.Name = "btnSelectMarket";
            this.btnSelectMarket.Size = new System.Drawing.Size(92, 23);
            this.btnSelectMarket.TabIndex = 24;
            this.btnSelectMarket.Text = "Select Market...";
            this.toolTip.SetToolTip(this.btnSelectMarket, "Select a market and import the shipping address.");
            this.btnSelectMarket.UseVisualStyleBackColor = true;
            this.btnSelectMarket.Click += new System.EventHandler(this.btnSelectMarket_Click);
            // 
            // btnSelectTech
            // 
            this.btnSelectTech.Location = new System.Drawing.Point(4, 9);
            this.btnSelectTech.Name = "btnSelectTech";
            this.btnSelectTech.Size = new System.Drawing.Size(92, 23);
            this.btnSelectTech.TabIndex = 23;
            this.btnSelectTech.Text = "Select Tech...";
            this.toolTip.SetToolTip(this.btnSelectTech, "Select a tech and import the shipping address.");
            this.btnSelectTech.UseVisualStyleBackColor = true;
            this.btnSelectTech.Click += new System.EventHandler(this.btnSelectTech_Click);
            // 
            // btnOtherAddressLookup
            // 
            this.btnOtherAddressLookup.Location = new System.Drawing.Point(4, 65);
            this.btnOtherAddressLookup.Name = "btnOtherAddressLookup";
            this.btnOtherAddressLookup.Size = new System.Drawing.Size(92, 23);
            this.btnOtherAddressLookup.TabIndex = 25;
            this.btnOtherAddressLookup.Text = "Lookup...";
            this.toolTip.SetToolTip(this.btnOtherAddressLookup, "List previously used addresses for shipments.");
            this.btnOtherAddressLookup.UseVisualStyleBackColor = true;
            this.btnOtherAddressLookup.Click += new System.EventHandler(this.btnOtherAddressLookup_Click);
            // 
            // txtDest_Company
            // 
            this.txtDest_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest_Company.Location = new System.Drawing.Point(179, 6);
            this.txtDest_Company.MaxLength = 64;
            this.txtDest_Company.Name = "txtDest_Company";
            this.txtDest_Company.Size = new System.Drawing.Size(250, 20);
            this.txtDest_Company.TabIndex = 27;
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Location = new System.Drawing.Point(673, 23);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(68, 13);
            this.lblAddressType.TabIndex = 42;
            this.lblAddressType.Text = "Address type";
            // 
            // lblDest_Company
            // 
            this.lblDest_Company.AutoSize = true;
            this.lblDest_Company.Location = new System.Drawing.Point(122, 9);
            this.lblDest_Company.Name = "lblDest_Company";
            this.lblDest_Company.Size = new System.Drawing.Size(51, 13);
            this.lblDest_Company.TabIndex = 26;
            this.lblDest_Company.Text = "Company";
            // 
            // radAddressTypeResidence
            // 
            this.radAddressTypeResidence.AutoSize = true;
            this.radAddressTypeResidence.Location = new System.Drawing.Point(676, 58);
            this.radAddressTypeResidence.Name = "radAddressTypeResidence";
            this.radAddressTypeResidence.Size = new System.Drawing.Size(76, 17);
            this.radAddressTypeResidence.TabIndex = 44;
            this.radAddressTypeResidence.Text = "Residence";
            this.radAddressTypeResidence.UseVisualStyleBackColor = true;
            // 
            // lblDest_Address
            // 
            this.lblDest_Address.AutoSize = true;
            this.lblDest_Address.Location = new System.Drawing.Point(128, 32);
            this.lblDest_Address.Name = "lblDest_Address";
            this.lblDest_Address.Size = new System.Drawing.Size(45, 13);
            this.lblDest_Address.TabIndex = 30;
            this.lblDest_Address.Text = "Address";
            // 
            // radAddressTypeBusiness
            // 
            this.radAddressTypeBusiness.AutoSize = true;
            this.radAddressTypeBusiness.Checked = true;
            this.radAddressTypeBusiness.Location = new System.Drawing.Point(676, 38);
            this.radAddressTypeBusiness.Name = "radAddressTypeBusiness";
            this.radAddressTypeBusiness.Size = new System.Drawing.Size(67, 17);
            this.radAddressTypeBusiness.TabIndex = 43;
            this.radAddressTypeBusiness.TabStop = true;
            this.radAddressTypeBusiness.Text = "Business";
            this.radAddressTypeBusiness.UseVisualStyleBackColor = true;
            // 
            // lblDest_Attn
            // 
            this.lblDest_Attn.AutoSize = true;
            this.lblDest_Attn.Location = new System.Drawing.Point(435, 9);
            this.lblDest_Attn.Name = "lblDest_Attn";
            this.lblDest_Attn.Size = new System.Drawing.Size(26, 13);
            this.lblDest_Attn.TabIndex = 28;
            this.lblDest_Attn.Text = "Attn";
            // 
            // txtDest_Telephone
            // 
            this.txtDest_Telephone.Location = new System.Drawing.Point(433, 101);
            this.txtDest_Telephone.MaxLength = 32;
            this.txtDest_Telephone.Name = "txtDest_Telephone";
            this.txtDest_Telephone.Size = new System.Drawing.Size(234, 20);
            this.txtDest_Telephone.TabIndex = 41;
            // 
            // lblDest_State
            // 
            this.lblDest_State.AutoSize = true;
            this.lblDest_State.Location = new System.Drawing.Point(361, 81);
            this.lblDest_State.Name = "lblDest_State";
            this.lblDest_State.Size = new System.Drawing.Size(79, 13);
            this.lblDest_State.TabIndex = 34;
            this.lblDest_State.Text = "State/Province";
            // 
            // txtDest_Country
            // 
            this.txtDest_Country.Location = new System.Drawing.Point(179, 101);
            this.txtDest_Country.MaxLength = 32;
            this.txtDest_Country.Name = "txtDest_Country";
            this.txtDest_Country.Size = new System.Drawing.Size(176, 20);
            this.txtDest_Country.TabIndex = 39;
            // 
            // lblDest_City
            // 
            this.lblDest_City.AutoSize = true;
            this.lblDest_City.Location = new System.Drawing.Point(149, 81);
            this.lblDest_City.Name = "lblDest_City";
            this.lblDest_City.Size = new System.Drawing.Size(24, 13);
            this.lblDest_City.TabIndex = 32;
            this.lblDest_City.Text = "City";
            // 
            // txtDest_Zip
            // 
            this.txtDest_Zip.Location = new System.Drawing.Point(587, 78);
            this.txtDest_Zip.MaxLength = 16;
            this.txtDest_Zip.Name = "txtDest_Zip";
            this.txtDest_Zip.Size = new System.Drawing.Size(80, 20);
            this.txtDest_Zip.TabIndex = 37;
            // 
            // lblDest_Zip
            // 
            this.lblDest_Zip.AutoSize = true;
            this.lblDest_Zip.Location = new System.Drawing.Point(497, 81);
            this.lblDest_Zip.Name = "lblDest_Zip";
            this.lblDest_Zip.Size = new System.Drawing.Size(84, 13);
            this.lblDest_Zip.TabIndex = 36;
            this.lblDest_Zip.Text = "Zip/Postal Code";
            // 
            // txtDest_State
            // 
            this.txtDest_State.Location = new System.Drawing.Point(446, 78);
            this.txtDest_State.MaxLength = 2;
            this.txtDest_State.Name = "txtDest_State";
            this.txtDest_State.Size = new System.Drawing.Size(45, 20);
            this.txtDest_State.TabIndex = 35;
            // 
            // lblDest_Country
            // 
            this.lblDest_Country.AutoSize = true;
            this.lblDest_Country.Location = new System.Drawing.Point(130, 104);
            this.lblDest_Country.Name = "lblDest_Country";
            this.lblDest_Country.Size = new System.Drawing.Size(43, 13);
            this.lblDest_Country.TabIndex = 38;
            this.lblDest_Country.Text = "Country";
            // 
            // txtDest_City
            // 
            this.txtDest_City.Location = new System.Drawing.Point(179, 78);
            this.txtDest_City.MaxLength = 32;
            this.txtDest_City.Name = "txtDest_City";
            this.txtDest_City.Size = new System.Drawing.Size(176, 20);
            this.txtDest_City.TabIndex = 33;
            // 
            // lblDest_Telephone
            // 
            this.lblDest_Telephone.AutoSize = true;
            this.lblDest_Telephone.Location = new System.Drawing.Point(361, 104);
            this.lblDest_Telephone.Name = "lblDest_Telephone";
            this.lblDest_Telephone.Size = new System.Drawing.Size(58, 13);
            this.lblDest_Telephone.TabIndex = 40;
            this.lblDest_Telephone.Text = "Telephone";
            // 
            // txtDest_Address
            // 
            this.txtDest_Address.AcceptsReturn = true;
            this.txtDest_Address.Location = new System.Drawing.Point(179, 29);
            this.txtDest_Address.MaxLength = 192;
            this.txtDest_Address.Multiline = true;
            this.txtDest_Address.Name = "txtDest_Address";
            this.txtDest_Address.Size = new System.Drawing.Size(488, 46);
            this.txtDest_Address.TabIndex = 31;
            // 
            // txtDest_Attn
            // 
            this.txtDest_Attn.Location = new System.Drawing.Point(470, 6);
            this.txtDest_Attn.MaxLength = 32;
            this.txtDest_Attn.Name = "txtDest_Attn";
            this.txtDest_Attn.Size = new System.Drawing.Size(197, 20);
            this.txtDest_Attn.TabIndex = 29;
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.lblEpartsEmail);
            this.tabEmail.Controls.Add(this.tbxEmailList);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(756, 128);
            this.tabEmail.TabIndex = 1;
            this.tabEmail.Text = "Email List";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // lblEpartsEmail
            // 
            this.lblEpartsEmail.AutoSize = true;
            this.lblEpartsEmail.Location = new System.Drawing.Point(3, 4);
            this.lblEpartsEmail.Name = "lblEpartsEmail";
            this.lblEpartsEmail.Size = new System.Drawing.Size(135, 13);
            this.lblEpartsEmail.TabIndex = 77;
            this.lblEpartsEmail.Text = "Email List: (Only For Eparts)";
            // 
            // tbxEmailList
            // 
            this.tbxEmailList.Location = new System.Drawing.Point(3, 20);
            this.tbxEmailList.MaxLength = 300;
            this.tbxEmailList.Multiline = true;
            this.tbxEmailList.Name = "tbxEmailList";
            this.tbxEmailList.ReadOnly = true;
            this.tbxEmailList.Size = new System.Drawing.Size(747, 102);
            this.tbxEmailList.TabIndex = 76;
            // 
            // pbNotesFlag
            // 
            this.pbNotesFlag.BackColor = System.Drawing.Color.Transparent;
            this.pbNotesFlag.Image = global::SDB.Properties.Resources.waving_flag_16x16;
            this.pbNotesFlag.Location = new System.Drawing.Point(353, 213);
            this.pbNotesFlag.Name = "pbNotesFlag";
            this.pbNotesFlag.Size = new System.Drawing.Size(16, 16);
            this.pbNotesFlag.TabIndex = 74;
            this.pbNotesFlag.TabStop = false;
            this.toolTip.SetToolTip(this.pbNotesFlag, "Read the journal and/or notes!");
            this.pbNotesFlag.Visible = false;
            // 
            // ePartsCbx
            // 
            this.ePartsCbx.AutoSize = true;
            this.ePartsCbx.Location = new System.Drawing.Point(637, 13);
            this.ePartsCbx.Name = "ePartsCbx";
            this.ePartsCbx.Size = new System.Drawing.Size(85, 17);
            this.ePartsCbx.TabIndex = 75;
            this.ePartsCbx.Text = "Eparts Order";
            this.ePartsCbx.UseVisualStyleBackColor = true;
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.Location = new System.Drawing.Point(518, 10);
            this.txtPurchaseOrder.MaxLength = 16;
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(101, 20);
            this.txtPurchaseOrder.TabIndex = 5;
            this.txtPurchaseOrder.TabStop = false;
            this.txtPurchaseOrder.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(439, 12);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(81, 13);
            this.lblPurchaseOrder.TabIndex = 4;
            this.lblPurchaseOrder.Text = "Purchase Order";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(340, 189);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(378, 189);
            this.txtNotes.MaxLength = 1024;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(400, 40);
            this.txtNotes.TabIndex = 16;
            this.txtNotes.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblShippingMethod
            // 
            this.lblShippingMethod.AutoSize = true;
            this.lblShippingMethod.Location = new System.Drawing.Point(8, 189);
            this.lblShippingMethod.Name = "lblShippingMethod";
            this.lblShippingMethod.Size = new System.Drawing.Size(87, 13);
            this.lblShippingMethod.TabIndex = 13;
            this.lblShippingMethod.Text = "Shipping Method";
            // 
            // cmbShippingMethod
            // 
            this.cmbShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippingMethod.FormattingEnabled = true;
            this.cmbShippingMethod.Location = new System.Drawing.Point(9, 208);
            this.cmbShippingMethod.Name = "cmbShippingMethod";
            this.cmbShippingMethod.Size = new System.Drawing.Size(259, 21);
            this.cmbShippingMethod.TabIndex = 14;
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.Location = new System.Drawing.Point(321, 9);
            this.txtRequestedDate.MaxLength = 64;
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.ReadOnly = true;
            this.txtRequestedDate.Size = new System.Drawing.Size(116, 20);
            this.txtRequestedDate.TabIndex = 3;
            this.txtRequestedDate.TabStop = false;
            this.txtRequestedDate.Tag = "ReadOnly";
            this.txtRequestedDate.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Location = new System.Drawing.Point(101, 9);
            this.txtRequestedBy.MaxLength = 64;
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.ReadOnly = true;
            this.txtRequestedBy.Size = new System.Drawing.Size(116, 20);
            this.txtRequestedBy.TabIndex = 1;
            this.txtRequestedBy.TabStop = false;
            this.txtRequestedBy.Tag = "ReadOnly";
            this.txtRequestedBy.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblRequestedDate
            // 
            this.lblRequestedDate.AutoSize = true;
            this.lblRequestedDate.Location = new System.Drawing.Point(223, 12);
            this.lblRequestedDate.Name = "lblRequestedDate";
            this.lblRequestedDate.Size = new System.Drawing.Size(85, 13);
            this.lblRequestedDate.TabIndex = 2;
            this.lblRequestedDate.Text = "Requested Date";
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.Location = new System.Drawing.Point(6, 13);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(81, 13);
            this.lblRequestedBy.TabIndex = 0;
            this.lblRequestedBy.Text = "Requested By";
            this.lblRequestedBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpJournal
            // 
            this.grpJournal.Controls.Add(this.dgvJournal);
            this.grpJournal.Controls.Add(this.pnlJournal_Control);
            this.grpJournal.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpJournal.Location = new System.Drawing.Point(0, 40);
            this.grpJournal.Name = "grpJournal";
            this.grpJournal.Size = new System.Drawing.Size(784, 164);
            this.grpJournal.TabIndex = 1;
            this.grpJournal.TabStop = false;
            this.grpJournal.Text = "Journal";
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.AllowUserToOrderColumns = true;
            this.dgvJournal.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvJournal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvJournal.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colDate,
            this.colJournalEntry,
            this.colJournalExpires});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJournal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJournal.Location = new System.Drawing.Point(3, 46);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersVisible = false;
            this.dgvJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvJournal.ShowCellErrors = false;
            this.dgvJournal.ShowCellToolTips = false;
            this.dgvJournal.ShowEditingIcon = false;
            this.dgvJournal.ShowRowErrors = false;
            this.dgvJournal.Size = new System.Drawing.Size(778, 115);
            this.dgvJournal.TabIndex = 33;
            this.dgvJournal.TabStop = false;
            // 
            // colUser
            // 
            this.colUser.Frozen = true;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Width = 70;
            // 
            // colDate
            // 
            this.colDate.Frozen = true;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colJournalEntry
            // 
            this.colJournalEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJournalEntry.HeaderText = "Entry";
            this.colJournalEntry.Name = "colJournalEntry";
            this.colJournalEntry.ReadOnly = true;
            // 
            // colJournalExpires
            // 
            this.colJournalExpires.HeaderText = "Expires";
            this.colJournalExpires.Name = "colJournalExpires";
            this.colJournalExpires.ReadOnly = true;
            this.colJournalExpires.Width = 130;
            // 
            // pnlJournal_Control
            // 
            this.pnlJournal_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlJournal_Control.Controls.Add(this.btnJournal_Add);
            this.pnlJournal_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlJournal_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlJournal_Control.Name = "pnlJournal_Control";
            this.pnlJournal_Control.Size = new System.Drawing.Size(778, 30);
            this.pnlJournal_Control.TabIndex = 32;
            // 
            // btnJournal_Add
            // 
            this.btnJournal_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnJournal_Add.Location = new System.Drawing.Point(3, 3);
            this.btnJournal_Add.Name = "btnJournal_Add";
            this.btnJournal_Add.Size = new System.Drawing.Size(92, 23);
            this.btnJournal_Add.TabIndex = 0;
            this.btnJournal_Add.Text = "Add Entry";
            this.toolTip.SetToolTip(this.btnJournal_Add, "Add journal entry to current shipment.");
            this.btnJournal_Add.UseVisualStyleBackColor = false;
            this.btnJournal_Add.Click += new System.EventHandler(this.btnJournal_Add_Click);
            // 
            // grpFulfillment
            // 
            this.grpFulfillment.Controls.Add(this.pnlShip);
            this.grpFulfillment.Controls.Add(this.pnlPick);
            this.grpFulfillment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFulfillment.Location = new System.Drawing.Point(0, 635);
            this.grpFulfillment.Name = "grpFulfillment";
            this.grpFulfillment.Size = new System.Drawing.Size(784, 127);
            this.grpFulfillment.TabIndex = 4;
            this.grpFulfillment.TabStop = false;
            this.grpFulfillment.Text = "Fulfillment";
            // 
            // pnlShip
            // 
            this.pnlShip.Controls.Add(this.btnViewTracking);
            this.pnlShip.Controls.Add(this.btnShip);
            this.pnlShip.Controls.Add(this.numWeight);
            this.pnlShip.Controls.Add(this.lblShippedBy);
            this.pnlShip.Controls.Add(this.txtTrackingNumber);
            this.pnlShip.Controls.Add(this.lblWeight);
            this.pnlShip.Controls.Add(this.lblShipDate);
            this.pnlShip.Controls.Add(this.lblTrackingNumber);
            this.pnlShip.Controls.Add(this.numPackages);
            this.pnlShip.Controls.Add(this.txtShippedBy);
            this.pnlShip.Controls.Add(this.txtShipDate);
            this.pnlShip.Controls.Add(this.lblPackages);
            this.pnlShip.Controls.Add(this.numInsurance);
            this.pnlShip.Controls.Add(this.numTotalCost);
            this.pnlShip.Controls.Add(this.lblTotalCost);
            this.pnlShip.Controls.Add(this.lblInsurance);
            this.pnlShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShip.Enabled = false;
            this.pnlShip.Location = new System.Drawing.Point(3, 47);
            this.pnlShip.Name = "pnlShip";
            this.pnlShip.Size = new System.Drawing.Size(778, 77);
            this.pnlShip.TabIndex = 1;
            // 
            // btnViewTracking
            // 
            this.btnViewTracking.AutoSize = true;
            this.btnViewTracking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTracking.Location = new System.Drawing.Point(287, 55);
            this.btnViewTracking.Name = "btnViewTracking";
            this.btnViewTracking.Size = new System.Drawing.Size(20, 19);
            this.btnViewTracking.TabIndex = 62;
            this.btnViewTracking.Text = ">";
            this.toolTip.SetToolTip(this.btnViewTracking, "View tracking information.");
            this.btnViewTracking.UseVisualStyleBackColor = true;
            this.btnViewTracking.Click += new System.EventHandler(this.btnViewTracking_Click);
            // 
            // btnShip
            // 
            this.btnShip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShip.Location = new System.Drawing.Point(700, 47);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(75, 23);
            this.btnShip.TabIndex = 14;
            this.btnShip.Text = "Ship";
            this.toolTip.SetToolTip(this.btnShip, "Finalize the shipment. This will close this shipment and mark it as completed.");
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // numWeight
            // 
            this.numWeight.DecimalPlaces = 1;
            this.numWeight.Location = new System.Drawing.Point(252, 30);
            this.numWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(79, 20);
            this.numWeight.TabIndex = 7;
            this.numWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWeight.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // lblShippedBy
            // 
            this.lblShippedBy.AutoSize = true;
            this.lblShippedBy.Location = new System.Drawing.Point(28, 8);
            this.lblShippedBy.Name = "lblShippedBy";
            this.lblShippedBy.Size = new System.Drawing.Size(61, 13);
            this.lblShippedBy.TabIndex = 0;
            this.lblShippedBy.Text = "Shipped By";
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(98, 54);
            this.txtTrackingNumber.MaxLength = 128;
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(183, 20);
            this.txtTrackingNumber.TabIndex = 13;
            this.txtTrackingNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(183, 32);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(63, 13);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight (lbs)";
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.Location = new System.Drawing.Point(220, 8);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(54, 13);
            this.lblShipDate.TabIndex = 2;
            this.lblShipDate.Text = "Ship Date";
            // 
            // lblTrackingNumber
            // 
            this.lblTrackingNumber.AutoSize = true;
            this.lblTrackingNumber.Location = new System.Drawing.Point(3, 57);
            this.lblTrackingNumber.Name = "lblTrackingNumber";
            this.lblTrackingNumber.Size = new System.Drawing.Size(89, 13);
            this.lblTrackingNumber.TabIndex = 12;
            this.lblTrackingNumber.Text = "Tracking Number";
            // 
            // numPackages
            // 
            this.numPackages.Location = new System.Drawing.Point(98, 30);
            this.numPackages.Name = "numPackages";
            this.numPackages.Size = new System.Drawing.Size(79, 20);
            this.numPackages.TabIndex = 5;
            this.numPackages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPackages.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // txtShippedBy
            // 
            this.txtShippedBy.Location = new System.Drawing.Point(98, 5);
            this.txtShippedBy.MaxLength = 64;
            this.txtShippedBy.Name = "txtShippedBy";
            this.txtShippedBy.ReadOnly = true;
            this.txtShippedBy.Size = new System.Drawing.Size(116, 20);
            this.txtShippedBy.TabIndex = 1;
            this.txtShippedBy.TabStop = false;
            this.txtShippedBy.Tag = "ReadOnly";
            this.txtShippedBy.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtShipDate
            // 
            this.txtShipDate.Location = new System.Drawing.Point(280, 6);
            this.txtShipDate.MaxLength = 64;
            this.txtShipDate.Name = "txtShipDate";
            this.txtShipDate.ReadOnly = true;
            this.txtShipDate.Size = new System.Drawing.Size(116, 20);
            this.txtShipDate.TabIndex = 3;
            this.txtShipDate.TabStop = false;
            this.txtShipDate.Tag = "ReadOnly";
            this.txtShipDate.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(37, 32);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(55, 13);
            this.lblPackages.TabIndex = 4;
            this.lblPackages.Text = "Packages";
            // 
            // numInsurance
            // 
            this.numInsurance.DecimalPlaces = 2;
            this.numInsurance.Location = new System.Drawing.Point(543, 30);
            this.numInsurance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numInsurance.Name = "numInsurance";
            this.numInsurance.Size = new System.Drawing.Size(79, 20);
            this.numInsurance.TabIndex = 11;
            this.numInsurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numInsurance.ThousandsSeparator = true;
            this.numInsurance.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // numTotalCost
            // 
            this.numTotalCost.DecimalPlaces = 2;
            this.numTotalCost.Location = new System.Drawing.Point(398, 30);
            this.numTotalCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTotalCost.Name = "numTotalCost";
            this.numTotalCost.Size = new System.Drawing.Size(79, 20);
            this.numTotalCost.TabIndex = 9;
            this.numTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTotalCost.ThousandsSeparator = true;
            this.numTotalCost.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(337, 32);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(483, 32);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(54, 13);
            this.lblInsurance.TabIndex = 10;
            this.lblInsurance.Text = "Insurance";
            // 
            // pnlPick
            // 
            this.pnlPick.Controls.Add(this.btnPick);
            this.pnlPick.Controls.Add(this.lblPickedBy);
            this.pnlPick.Controls.Add(this.lblPickDate);
            this.pnlPick.Controls.Add(this.txtPickedBy);
            this.pnlPick.Controls.Add(this.txtPickDate);
            this.pnlPick.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPick.Enabled = false;
            this.pnlPick.Location = new System.Drawing.Point(3, 16);
            this.pnlPick.Name = "pnlPick";
            this.pnlPick.Size = new System.Drawing.Size(778, 31);
            this.pnlPick.TabIndex = 0;
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.Location = new System.Drawing.Point(700, 5);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 4;
            this.btnPick.Text = "Pick";
            this.toolTip.SetToolTip(this.btnPick, "Start assembling the shipment. This will lock the shipment from being edited unle" +
        "ss canceled.");
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lblPickedBy
            // 
            this.lblPickedBy.AutoSize = true;
            this.lblPickedBy.Location = new System.Drawing.Point(37, 8);
            this.lblPickedBy.Name = "lblPickedBy";
            this.lblPickedBy.Size = new System.Drawing.Size(55, 13);
            this.lblPickedBy.TabIndex = 0;
            this.lblPickedBy.Text = "Picked By";
            // 
            // lblPickDate
            // 
            this.lblPickDate.AutoSize = true;
            this.lblPickDate.Location = new System.Drawing.Point(220, 10);
            this.lblPickDate.Name = "lblPickDate";
            this.lblPickDate.Size = new System.Drawing.Size(54, 13);
            this.lblPickDate.TabIndex = 2;
            this.lblPickDate.Text = "Pick Date";
            // 
            // txtPickedBy
            // 
            this.txtPickedBy.Location = new System.Drawing.Point(98, 7);
            this.txtPickedBy.MaxLength = 64;
            this.txtPickedBy.Name = "txtPickedBy";
            this.txtPickedBy.ReadOnly = true;
            this.txtPickedBy.Size = new System.Drawing.Size(116, 20);
            this.txtPickedBy.TabIndex = 1;
            this.txtPickedBy.TabStop = false;
            this.txtPickedBy.Tag = "ReadOnly";
            this.txtPickedBy.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtPickDate
            // 
            this.txtPickDate.Location = new System.Drawing.Point(280, 7);
            this.txtPickDate.MaxLength = 64;
            this.txtPickDate.Name = "txtPickDate";
            this.txtPickDate.ReadOnly = true;
            this.txtPickDate.Size = new System.Drawing.Size(116, 20);
            this.txtPickDate.TabIndex = 3;
            this.txtPickDate.TabStop = false;
            this.txtPickDate.Tag = "ReadOnly";
            this.txtPickDate.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTopControl.Controls.Add(this.toolStrip1);
            this.pnlTopControl.Controls.Add(this.lblShipmentNumber);
            this.pnlTopControl.Controls.Add(this.chkSubscribe);
            this.pnlTopControl.Controls.Add(this.btnCancel);
            this.pnlTopControl.Controls.Add(this.btnEditSave);
            this.pnlTopControl.Controls.Add(this.txtShipmentNumber);
            this.pnlTopControl.Controls.Add(this.lblStatus);
            this.pnlTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopControl.Location = new System.Drawing.Point(0, 0);
            this.pnlTopControl.Name = "pnlTopControl";
            this.pnlTopControl.Size = new System.Drawing.Size(784, 40);
            this.pnlTopControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(202, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(117, 22);
            this.toolStrip1.TabIndex = 75;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreate,
            this.mnuHoldRelease,
            this.mnuDeleteRestore,
            this.toolStripSeparator3,
            this.mnuExport,
            this.mnuPrint});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(116, 19);
            this.toolStripDropDownButton2.Text = "Shipment Options";
            this.toolStripDropDownButton2.ToolTipText = "Shipment Options";
            // 
            // mnuCreate
            // 
            this.mnuCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuCreate.Name = "mnuCreate";
            this.mnuCreate.ShowShortcutKeys = false;
            this.mnuCreate.Size = new System.Drawing.Size(156, 22);
            this.mnuCreate.Text = "Create";
            this.mnuCreate.ToolTipText = "Add a new asset to the database.";
            this.mnuCreate.Click += new System.EventHandler(this.mnuCreate_Click);
            // 
            // mnuHoldRelease
            // 
            this.mnuHoldRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mnuHoldRelease.Name = "mnuHoldRelease";
            this.mnuHoldRelease.Size = new System.Drawing.Size(156, 22);
            this.mnuHoldRelease.Text = "Hold";
            this.mnuHoldRelease.Click += new System.EventHandler(this.mnuHoldRelease_Click);
            // 
            // mnuDeleteRestore
            // 
            this.mnuDeleteRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mnuDeleteRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuDeleteRestore.Name = "mnuDeleteRestore";
            this.mnuDeleteRestore.ShowShortcutKeys = false;
            this.mnuDeleteRestore.Size = new System.Drawing.Size(156, 22);
            this.mnuDeleteRestore.Text = "Delete";
            this.mnuDeleteRestore.ToolTipText = "Deletes the asset entirely.\r\nWill offer to merge with another asset if any items " +
    "are associated with the asset.\r\nYou cannot delete an asset with attached items (" +
    "tickets, RMAs, shipments).";
            this.mnuDeleteRestore.Click += new System.EventHandler(this.mnuDeleteRestore_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExport.Size = new System.Drawing.Size(156, 22);
            this.mnuExport.Text = "Export...";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(156, 22);
            this.mnuPrint.Text = "Print...";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // lblShipmentNumber
            // 
            this.lblShipmentNumber.AutoSize = true;
            this.lblShipmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentNumber.Location = new System.Drawing.Point(2, 12);
            this.lblShipmentNumber.Name = "lblShipmentNumber";
            this.lblShipmentNumber.Size = new System.Drawing.Size(86, 16);
            this.lblShipmentNumber.TabIndex = 0;
            this.lblShipmentNumber.Text = "SHIPMENT";
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoCheck = false;
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Location = new System.Drawing.Point(326, 13);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 2;
            this.chkSubscribe.Text = "Subscribe";
            this.toolTip.SetToolTip(this.chkSubscribe, "Indicates whether you are subscribed to this item.");
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.Click += new System.EventHandler(this.chkSubscribe_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(501, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.btnCancel, "Cancel editing or creating this shipment.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditSave.Location = new System.Drawing.Point(567, 9);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(60, 23);
            this.btnEditSave.TabIndex = 6;
            this.btnEditSave.Text = "Edit";
            this.toolTip.SetToolTip(this.btnEditSave, "Edit or save this shipment.");
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // txtShipmentNumber
            // 
            this.txtShipmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipmentNumber.Location = new System.Drawing.Point(94, 6);
            this.txtShipmentNumber.MaxLength = 64;
            this.txtShipmentNumber.Name = "txtShipmentNumber";
            this.txtShipmentNumber.ReadOnly = true;
            this.txtShipmentNumber.Size = new System.Drawing.Size(102, 29);
            this.txtShipmentNumber.TabIndex = 1;
            this.txtShipmentNumber.TabStop = false;
            this.txtShipmentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtShipmentNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(633, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(3);
            this.lblStatus.Size = new System.Drawing.Size(151, 40);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyJobNumberToolStripMenuItem
            // 
            this.copyJobNumberToolStripMenuItem.Name = "copyJobNumberToolStripMenuItem";
            this.copyJobNumberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyJobNumberToolStripMenuItem.Text = "Copy Job Number";
            this.copyJobNumberToolStripMenuItem.Click += new System.EventHandler(this.copyJobNumberToolStripMenuItem_Click);
            // 
            // cmAssemblyList
            // 
            this.cmAssemblyList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyJobNumberToolStripMenuItem});
            this.cmAssemblyList.Name = "cmAssemblyList";
            this.cmAssemblyList.Size = new System.Drawing.Size(181, 48);
            // 
            // FormShipment_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.grpLedger);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.grpJournal);
            this.Controls.Add(this.grpFulfillment);
            this.Controls.Add(this.pnlTopControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "FormShipment_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shipment Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShipment_Editor_FormClosing);
            this.Load += new System.EventHandler(this.FormShipment_Editor_Load);
            this.Shown += new System.EventHandler(this.FormShipment_Editor_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormShipment_Editor_KeyDown);
            this.grpLedger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvLedger)).EndInit();
            this.pnlLedger_Control.ResumeLayout(false);
            this.pnlLedger_Control.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.Shipmentstabs.ResumeLayout(false);
            this.tabDestination.ResumeLayout(false);
            this.tabDestination.PerformLayout();
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesFlag)).EndInit();
            this.grpJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.pnlJournal_Control.ResumeLayout(false);
            this.grpFulfillment.ResumeLayout(false);
            this.pnlShip.ResumeLayout(false);
            this.pnlShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).EndInit();
            this.pnlPick.ResumeLayout(false);
            this.pnlPick.PerformLayout();
            this.pnlTopControl.ResumeLayout(false);
            this.pnlTopControl.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmAssemblyList.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpLedger;
		private BrightIdeasSoftware.ObjectListView olvLedger;
		private BrightIdeasSoftware.OLVColumn olvColLedger_ID;
		private BrightIdeasSoftware.OLVColumn olvColLedger_Quantity;
		private BrightIdeasSoftware.OLVColumn olvColLedger_Description;
		private BrightIdeasSoftware.OLVColumn olvColLedger_RMA;
		private BrightIdeasSoftware.OLVColumn olvColLedger_Ticket;
		private BrightIdeasSoftware.OLVColumn olvColLedger_Asset;
		private BrightIdeasSoftware.OLVColumn olvColLedger_JobNumber;
		private BrightIdeasSoftware.OLVColumn olvColLedger_SerialNumber;
		private System.Windows.Forms.Panel pnlLedger_Control;
		private System.Windows.Forms.Button btnReady;
		private System.Windows.Forms.Button btnLedger_Add;
		private System.Windows.Forms.Button btnLedger_Remove;
		private System.Windows.Forms.Button btnLedger_Edit;
		private System.Windows.Forms.Label lblLedger_ItemQty;
		private System.Windows.Forms.TextBox txtLedger_ItemQty;
		private System.Windows.Forms.GroupBox grpRequest;
		private System.Windows.Forms.TextBox txtPurchaseOrder;
		private System.Windows.Forms.Label lblPurchaseOrder;
		private System.Windows.Forms.Label lblNotes;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label lblShippingMethod;
		private System.Windows.Forms.ComboBox cmbShippingMethod;
		private System.Windows.Forms.TextBox txtRequestedDate;
		private System.Windows.Forms.TextBox txtRequestedBy;
		private System.Windows.Forms.Label lblRequestedDate;
		private System.Windows.Forms.Label lblRequestedBy;
		private System.Windows.Forms.GroupBox grpJournal;
		private System.Windows.Forms.DataGridView dgvJournal;
		private System.Windows.Forms.Panel pnlJournal_Control;
		private System.Windows.Forms.Button btnJournal_Add;
		private System.Windows.Forms.GroupBox grpFulfillment;
		private System.Windows.Forms.Panel pnlShip;
		private System.Windows.Forms.Button btnViewTracking;
		private System.Windows.Forms.Button btnShip;
		private ClassFixedNumericUpDown numWeight;
		private System.Windows.Forms.Label lblShippedBy;
		private System.Windows.Forms.TextBox txtTrackingNumber;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.Label lblShipDate;
		private System.Windows.Forms.Label lblTrackingNumber;
		private ClassFixedNumericUpDown numPackages;
		private System.Windows.Forms.TextBox txtShippedBy;
		private System.Windows.Forms.TextBox txtShipDate;
		private System.Windows.Forms.Label lblPackages;
		private ClassFixedNumericUpDown numInsurance;
		private ClassFixedNumericUpDown numTotalCost;
		private System.Windows.Forms.Label lblTotalCost;
		private System.Windows.Forms.Label lblInsurance;
		private System.Windows.Forms.Panel pnlPick;
		private System.Windows.Forms.Button btnPick;
		private System.Windows.Forms.Label lblPickedBy;
		private System.Windows.Forms.Label lblPickDate;
		private System.Windows.Forms.TextBox txtPickedBy;
		private System.Windows.Forms.TextBox txtPickDate;
		private System.Windows.Forms.Panel pnlTopControl;
		private System.Windows.Forms.Button btnEditSave;
		private System.Windows.Forms.TextBox txtShipmentNumber;
		private System.Windows.Forms.Label lblShipmentNumber;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox chkSubscribe;
		private System.Windows.Forms.PictureBox pbNotesFlag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
		private System.Windows.Forms.Label lblReadyDate;
		private System.Windows.Forms.TextBox txtReadyDate;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem mnuCreate;
		private System.Windows.Forms.ToolStripMenuItem mnuHoldRelease;
		private System.Windows.Forms.ToolStripMenuItem mnuDeleteRestore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuExport;
		private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.CheckBox ePartsCbx;
        private System.Windows.Forms.TabControl Shipmentstabs;
        private System.Windows.Forms.TabPage tabDestination;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.Label lblEpartsEmail;
        private System.Windows.Forms.TextBox tbxEmailList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectMarket;
        private System.Windows.Forms.Button btnSelectTech;
        private System.Windows.Forms.Button btnOtherAddressLookup;
        private System.Windows.Forms.TextBox txtDest_Company;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.Label lblDest_Company;
        private System.Windows.Forms.RadioButton radAddressTypeResidence;
        private System.Windows.Forms.Label lblDest_Address;
        private System.Windows.Forms.RadioButton radAddressTypeBusiness;
        private System.Windows.Forms.Label lblDest_Attn;
        private System.Windows.Forms.TextBox txtDest_Telephone;
        private System.Windows.Forms.Label lblDest_State;
        private System.Windows.Forms.TextBox txtDest_Country;
        private System.Windows.Forms.Label lblDest_City;
        private System.Windows.Forms.TextBox txtDest_Zip;
        private System.Windows.Forms.Label lblDest_Zip;
        private System.Windows.Forms.TextBox txtDest_State;
        private System.Windows.Forms.Label lblDest_Country;
        private System.Windows.Forms.TextBox txtDest_City;
        private System.Windows.Forms.Label lblDest_Telephone;
        private System.Windows.Forms.TextBox txtDest_Address;
        private System.Windows.Forms.TextBox txtDest_Attn;
        private System.Windows.Forms.ContextMenuStrip cmAssemblyList;
        private System.Windows.Forms.ToolStripMenuItem copyJobNumberToolStripMenuItem;
    }
}