namespace SDB.Forms.RMA
{
    partial class FormRMA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabsRMA = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.olvRMAList = new BrightIdeasSoftware.ObjectListView();
            this.olvColRMAList_Number = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Hot = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_APR = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_HasComputer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_HasNonSystemJournalEntries = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Created = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_IssuedTo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Received = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_TicketNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Assemblies = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Completed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Finalized = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRMAListControls = new System.Windows.Forms.Panel();
            this.lblRMAList_View = new System.Windows.Forms.Label();
            this.pnlRMAStatusKey = new System.Windows.Forms.Panel();
            this.txtRMAList_Qty = new System.Windows.Forms.TextBox();
            this.lblRMAList_Qty = new System.Windows.Forms.Label();
            this.tabRMA = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucRMADetails1 = new SDB.UserControls.ucRMADetails();
            this.ucAssemblyList1 = new SDB.UserControls.RMA.ucAssemblyList();
            this.ucRMATimeBreakdown1 = new SDB.UserControls.RMA.ucRMATimeBreakdown();
            this.ucAssetInfo1 = new SDB.UserControls.RMA.ucAssetInfo();
            this.tabsRMAInfo = new System.Windows.Forms.TabControl();
            this.tabRecieve = new System.Windows.Forms.TabPage();
            this.olvReceive_Assemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColReceive_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDiscarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_Receive_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_Receive_User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_AssemblySerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_BinID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlReceive_Assemblies_Control = new System.Windows.Forms.Panel();
            this.lblReceive_SelectedAssemblyID = new System.Windows.Forms.Label();
            this.txtReceive_TotalAssyQty = new System.Windows.Forms.TextBox();
            this.txtReceive_ReceivedQty = new System.Windows.Forms.TextBox();
            this.lblReceive_ReceivedQty = new System.Windows.Forms.Label();
            this.pnlReceive_Right = new System.Windows.Forms.Panel();
            this.btnReceive_DiscardSelected = new System.Windows.Forms.Button();
            this.lblReceive_BinAssyQty = new System.Windows.Forms.Label();
            this.btnReceive_CreateBin = new System.Windows.Forms.Button();
            this.btnReceive_SelectBin = new System.Windows.Forms.Button();
            this.btnReceive_DeleteBin = new System.Windows.Forms.Button();
            this.btnReceive_PrintBinLabels_Current = new System.Windows.Forms.Button();
            this.btnReceive_PrintBinLabels_All = new System.Windows.Forms.Button();
            this.lblReceive_CurrentBinID = new System.Windows.Forms.Label();
            this.txtReceive_CurrentBinID = new System.Windows.Forms.TextBox();
            this.lblReceive_AssemblySerialNumber = new System.Windows.Forms.Label();
            this.btnReceive_ReceiveSelected = new System.Windows.Forms.Button();
            this.txtReceive_AssemblySerialNumber = new System.Windows.Forms.TextBox();
            this.tabRMARepair = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAssemblyInfo = new System.Windows.Forms.TabPage();
            this.tbxAssemblyStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepair_InventoryLocation = new System.Windows.Forms.TextBox();
            this.lblRepair_InventoryLocation = new System.Windows.Forms.Label();
            this.txtRepair_LEDBoard_Calibration = new System.Windows.Forms.TextBox();
            this.lblRepair_LEDBoard_Calibration = new System.Windows.Forms.Label();
            this.txtRepair_OriginalJobNumber = new System.Windows.Forms.TextBox();
            this.lblRepair_OriginalJobNumber = new System.Windows.Forms.Label();
            this.txtRepair_SerialNumber = new System.Windows.Forms.TextBox();
            this.lblRepair_SerialNumber = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRepair_FailureType = new System.Windows.Forms.Label();
            this.txtRepair_FailureType = new System.Windows.Forms.TextBox();
            this.tabRepairInfo = new System.Windows.Forms.TabPage();
            this.olvRepair_RepairTypes = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepair_RepairType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabComponentInfo = new System.Windows.Forms.TabPage();
            this.olvRepair_Components = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepair_Component_PartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepair_Component_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepair_Component_SilkLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRepair_Component_Control = new System.Windows.Forms.Panel();
            this.lblRepair_Components_Qty = new System.Windows.Forms.Label();
            this.txtRepair_Components_Qty = new System.Windows.Forms.TextBox();
            this.txtRepair_MU = new System.Windows.Forms.TextBox();
            this.lblRepair_MU = new System.Windows.Forms.Label();
            this.grpJournal = new System.Windows.Forms.GroupBox();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assembly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlJournal_Control = new System.Windows.Forms.Panel();
            this.btnJournal_Add = new System.Windows.Forms.Button();
            this.tabRMAShipments = new System.Windows.Forms.TabPage();
            this.ucShipmentList1 = new SDB.UserControls.Shipment.ucShipmentList();
            this.tabRMAAccounting = new System.Windows.Forms.TabPage();
            this.grpAccounting_Components = new System.Windows.Forms.GroupBox();
            this.olvAccounting_Components = new BrightIdeasSoftware.ObjectListView();
            this.olvColAccounting_Components_PartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAccounting_Components_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAccounting_Components_SilkLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAccounting_Components_Control = new System.Windows.Forms.Panel();
            this.lblAccounting_TotalCost = new System.Windows.Forms.Label();
            this.txtAccounting_TotalCost = new System.Windows.Forms.TextBox();
            this.lblAccounting_Components_Qty = new System.Windows.Forms.Label();
            this.txtAccounting_Components_Qty = new System.Windows.Forms.TextBox();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.gbxAction = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxRMAStatusView = new System.Windows.Forms.ComboBox();
            this.tabsRMA.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRMAList)).BeginInit();
            this.pnlRMAListControls.SuspendLayout();
            this.tabRMA.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabsRMAInfo.SuspendLayout();
            this.tabRecieve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvReceive_Assemblies)).BeginInit();
            this.pnlReceive_Assemblies_Control.SuspendLayout();
            this.pnlReceive_Right.SuspendLayout();
            this.tabRMARepair.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAssemblyInfo.SuspendLayout();
            this.tabRepairInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairTypes)).BeginInit();
            this.tabComponentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Components)).BeginInit();
            this.pnlRepair_Component_Control.SuspendLayout();
            this.grpJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.pnlJournal_Control.SuspendLayout();
            this.tabRMAShipments.SuspendLayout();
            this.tabRMAAccounting.SuspendLayout();
            this.grpAccounting_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAccounting_Components)).BeginInit();
            this.pnlAccounting_Components_Control.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsRMA
            // 
            this.tabsRMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsRMA.Controls.Add(this.tabList);
            this.tabsRMA.Controls.Add(this.tabRMA);
            this.tabsRMA.Location = new System.Drawing.Point(4, 27);
            this.tabsRMA.Name = "tabsRMA";
            this.tabsRMA.SelectedIndex = 0;
            this.tabsRMA.Size = new System.Drawing.Size(1195, 603);
            this.tabsRMA.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.olvRMAList);
            this.tabList.Controls.Add(this.pnlRMAListControls);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(1187, 577);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "RMA List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // olvRMAList
            // 
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Number);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Hot);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_APR);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_HasComputer);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_HasNonSystemJournalEntries);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Created);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_IssuedTo);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Received);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_TicketNumber);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Asset);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Assemblies);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Completed);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Finalized);
            this.olvRMAList.AllowColumnReorder = true;
            this.olvRMAList.CellEditUseWholeCell = false;
            this.olvRMAList.CheckedAspectName = "";
            this.olvRMAList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRMAList_Number,
            this.olvColRMAList_Hot,
            this.olvColRMAList_APR,
            this.olvColRMAList_HasComputer,
            this.olvColRMAList_HasNonSystemJournalEntries,
            this.olvColRMAList_Created,
            this.olvColRMAList_IssuedTo,
            this.olvColRMAList_Received,
            this.olvColRMAList_TicketNumber,
            this.olvColRMAList_Asset,
            this.olvColRMAList_Assemblies,
            this.olvColRMAList_Completed,
            this.olvColRMAList_Finalized});
            this.olvRMAList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRMAList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvRMAList.EmptyListMsg = "No RMAs matching specified critera";
            this.olvRMAList.FullRowSelect = true;
            this.olvRMAList.GridLines = true;
            this.olvRMAList.HasCollapsibleGroups = false;
            this.olvRMAList.Location = new System.Drawing.Point(3, 53);
            this.olvRMAList.MultiSelect = false;
            this.olvRMAList.Name = "olvRMAList";
            this.olvRMAList.SelectAllOnControlA = false;
            this.olvRMAList.ShowCommandMenuOnRightClick = true;
            this.olvRMAList.ShowFilterMenuOnRightClick = false;
            this.olvRMAList.ShowGroups = false;
            this.olvRMAList.ShowImagesOnSubItems = true;
            this.olvRMAList.Size = new System.Drawing.Size(1181, 521);
            this.olvRMAList.TabIndex = 1;
            this.olvRMAList.UseCompatibleStateImageBehavior = false;
            this.olvRMAList.UseSubItemCheckBoxes = true;
            this.olvRMAList.View = System.Windows.Forms.View.Details;
            // 
            // olvColRMAList_Number
            // 
            this.olvColRMAList_Number.AspectName = "ID";
            this.olvColRMAList_Number.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColRMAList_Number.Text = "RMA";
            this.olvColRMAList_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColRMAList_Number.Width = 97;
            // 
            // olvColRMAList_Hot
            // 
            this.olvColRMAList_Hot.AspectName = "IsHot";
            this.olvColRMAList_Hot.AspectToStringFormat = "";
            this.olvColRMAList_Hot.AutoCompleteEditor = false;
            this.olvColRMAList_Hot.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColRMAList_Hot.HeaderImageKey = "(none)";
            this.olvColRMAList_Hot.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_Hot.ImageAspectName = "";
            this.olvColRMAList_Hot.IsEditable = false;
            this.olvColRMAList_Hot.MaximumWidth = 40;
            this.olvColRMAList_Hot.MinimumWidth = 40;
            this.olvColRMAList_Hot.Searchable = false;
            this.olvColRMAList_Hot.Text = "Hot";
            this.olvColRMAList_Hot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_Hot.ToolTipText = "RMA has been promoted in priority.";
            this.olvColRMAList_Hot.Width = 40;
            // 
            // olvColRMAList_APR
            // 
            this.olvColRMAList_APR.AspectName = "IsAPR";
            this.olvColRMAList_APR.AutoCompleteEditor = false;
            this.olvColRMAList_APR.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColRMAList_APR.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_APR.IsEditable = false;
            this.olvColRMAList_APR.MaximumWidth = 40;
            this.olvColRMAList_APR.MinimumWidth = 40;
            this.olvColRMAList_APR.Searchable = false;
            this.olvColRMAList_APR.Text = "APR";
            this.olvColRMAList_APR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_APR.ToolTipText = "Advanced Parts Replacement";
            this.olvColRMAList_APR.Width = 40;
            // 
            // olvColRMAList_HasComputer
            // 
            this.olvColRMAList_HasComputer.AspectName = "HasComputer";
            this.olvColRMAList_HasComputer.AutoCompleteEditor = false;
            this.olvColRMAList_HasComputer.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColRMAList_HasComputer.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_HasComputer.IsEditable = false;
            this.olvColRMAList_HasComputer.MaximumWidth = 40;
            this.olvColRMAList_HasComputer.MinimumWidth = 40;
            this.olvColRMAList_HasComputer.Searchable = false;
            this.olvColRMAList_HasComputer.Text = "Comp";
            this.olvColRMAList_HasComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_HasComputer.ToolTipText = "Contains an item requiring prep, such as a computer.";
            this.olvColRMAList_HasComputer.Width = 40;
            // 
            // olvColRMAList_HasNonSystemJournalEntries
            // 
            this.olvColRMAList_HasNonSystemJournalEntries.AspectName = "HasNonSystemJournalEntries";
            this.olvColRMAList_HasNonSystemJournalEntries.AutoCompleteEditor = false;
            this.olvColRMAList_HasNonSystemJournalEntries.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColRMAList_HasNonSystemJournalEntries.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_HasNonSystemJournalEntries.IsEditable = false;
            this.olvColRMAList_HasNonSystemJournalEntries.MaximumWidth = 40;
            this.olvColRMAList_HasNonSystemJournalEntries.MinimumWidth = 40;
            this.olvColRMAList_HasNonSystemJournalEntries.Searchable = false;
            this.olvColRMAList_HasNonSystemJournalEntries.Text = "Jrnl";
            this.olvColRMAList_HasNonSystemJournalEntries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRMAList_HasNonSystemJournalEntries.ToolTipText = "Has (non-system) journal entries or notes.";
            this.olvColRMAList_HasNonSystemJournalEntries.Width = 272;
            // 
            // olvColRMAList_Created
            // 
            this.olvColRMAList_Created.AspectName = "Creation_Date";
            this.olvColRMAList_Created.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMAList_Created.IsEditable = false;
            this.olvColRMAList_Created.Text = "Created";
            this.olvColRMAList_Created.Width = 84;
            // 
            // olvColRMAList_IssuedTo
            // 
            this.olvColRMAList_IssuedTo.AspectName = "TechName";
            this.olvColRMAList_IssuedTo.Text = "Issued To";
            this.olvColRMAList_IssuedTo.Width = 140;
            // 
            // olvColRMAList_Received
            // 
            this.olvColRMAList_Received.AspectName = "FirstAssemblyReceived";
            this.olvColRMAList_Received.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMAList_Received.IsEditable = false;
            this.olvColRMAList_Received.Text = "Received";
            this.olvColRMAList_Received.Width = 70;
            // 
            // olvColRMAList_TicketNumber
            // 
            this.olvColRMAList_TicketNumber.AspectName = "TicketID";
            this.olvColRMAList_TicketNumber.IsEditable = false;
            this.olvColRMAList_TicketNumber.Text = "Ticket";
            this.olvColRMAList_TicketNumber.Width = 50;
            // 
            // olvColRMAList_Asset
            // 
            this.olvColRMAList_Asset.AspectName = "AssetName";
            this.olvColRMAList_Asset.IsEditable = false;
            this.olvColRMAList_Asset.Text = "Asset";
            this.olvColRMAList_Asset.Width = 150;
            // 
            // olvColRMAList_Assemblies
            // 
            this.olvColRMAList_Assemblies.AspectName = "AssemblyQty";
            this.olvColRMAList_Assemblies.IsEditable = false;
            this.olvColRMAList_Assemblies.Text = "Assys.";
            this.olvColRMAList_Assemblies.Width = 50;
            // 
            // olvColRMAList_Completed
            // 
            this.olvColRMAList_Completed.AspectName = "Completed_Date";
            this.olvColRMAList_Completed.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMAList_Completed.IsEditable = false;
            this.olvColRMAList_Completed.Text = "Completed";
            this.olvColRMAList_Completed.Width = 70;
            // 
            // olvColRMAList_Finalized
            // 
            this.olvColRMAList_Finalized.AspectName = "Finalized_Date";
            this.olvColRMAList_Finalized.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMAList_Finalized.IsEditable = false;
            this.olvColRMAList_Finalized.Text = "Finalized";
            this.olvColRMAList_Finalized.Width = 70;
            // 
            // pnlRMAListControls
            // 
            this.pnlRMAListControls.BackColor = System.Drawing.Color.Silver;
            this.pnlRMAListControls.Controls.Add(this.cbxRMAStatusView);
            this.pnlRMAListControls.Controls.Add(this.lblRMAList_View);
            this.pnlRMAListControls.Controls.Add(this.pnlRMAStatusKey);
            this.pnlRMAListControls.Controls.Add(this.txtRMAList_Qty);
            this.pnlRMAListControls.Controls.Add(this.lblRMAList_Qty);
            this.pnlRMAListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRMAListControls.Location = new System.Drawing.Point(3, 3);
            this.pnlRMAListControls.Name = "pnlRMAListControls";
            this.pnlRMAListControls.Size = new System.Drawing.Size(1181, 49);
            this.pnlRMAListControls.TabIndex = 0;
            // 
            // lblRMAList_View
            // 
            this.lblRMAList_View.AutoSize = true;
            this.lblRMAList_View.Location = new System.Drawing.Point(3, 8);
            this.lblRMAList_View.Name = "lblRMAList_View";
            this.lblRMAList_View.Size = new System.Drawing.Size(33, 13);
            this.lblRMAList_View.TabIndex = 19;
            this.lblRMAList_View.Text = "View:";
            // 
            // pnlRMAStatusKey
            // 
            this.pnlRMAStatusKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRMAStatusKey.Location = new System.Drawing.Point(0, 29);
            this.pnlRMAStatusKey.Name = "pnlRMAStatusKey";
            this.pnlRMAStatusKey.Size = new System.Drawing.Size(1181, 20);
            this.pnlRMAStatusKey.TabIndex = 17;
            // 
            // txtRMAList_Qty
            // 
            this.txtRMAList_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRMAList_Qty.Location = new System.Drawing.Point(1136, 3);
            this.txtRMAList_Qty.Name = "txtRMAList_Qty";
            this.txtRMAList_Qty.ReadOnly = true;
            this.txtRMAList_Qty.Size = new System.Drawing.Size(42, 20);
            this.txtRMAList_Qty.TabIndex = 16;
            this.txtRMAList_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRMAList_Qty
            // 
            this.lblRMAList_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRMAList_Qty.AutoSize = true;
            this.lblRMAList_Qty.Location = new System.Drawing.Point(1091, 8);
            this.lblRMAList_Qty.Name = "lblRMAList_Qty";
            this.lblRMAList_Qty.Size = new System.Drawing.Size(39, 13);
            this.lblRMAList_Qty.TabIndex = 15;
            this.lblRMAList_Qty.Text = "RMAs:";
            // 
            // tabRMA
            // 
            this.tabRMA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabRMA.Controls.Add(this.flowLayoutPanel2);
            this.tabRMA.Controls.Add(this.tabsRMAInfo);
            this.tabRMA.Location = new System.Drawing.Point(4, 22);
            this.tabRMA.Name = "tabRMA";
            this.tabRMA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMA.Size = new System.Drawing.Size(1187, 577);
            this.tabRMA.TabIndex = 1;
            this.tabRMA.Text = "RMA Info";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ucRMADetails1);
            this.flowLayoutPanel2.Controls.Add(this.ucAssemblyList1);
            this.flowLayoutPanel2.Controls.Add(this.ucRMATimeBreakdown1);
            this.flowLayoutPanel2.Controls.Add(this.ucAssetInfo1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1181, 296);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // ucRMADetails1
            // 
            this.ucRMADetails1.BackColor = System.Drawing.Color.LightGray;
            this.ucRMADetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucRMADetails1.Location = new System.Drawing.Point(3, 3);
            this.ucRMADetails1.Name = "ucRMADetails1";
            this.ucRMADetails1.Size = new System.Drawing.Size(266, 286);
            this.ucRMADetails1.TabIndex = 1;
            // 
            // ucAssemblyList1
            // 
            this.ucAssemblyList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAssemblyList1.Location = new System.Drawing.Point(275, 3);
            this.ucAssemblyList1.Name = "ucAssemblyList1";
            this.ucAssemblyList1.Size = new System.Drawing.Size(326, 286);
            this.ucAssemblyList1.TabIndex = 3;
            // 
            // ucRMATimeBreakdown1
            // 
            this.ucRMATimeBreakdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucRMATimeBreakdown1.Location = new System.Drawing.Point(607, 3);
            this.ucRMATimeBreakdown1.Name = "ucRMATimeBreakdown1";
            this.ucRMATimeBreakdown1.Size = new System.Drawing.Size(260, 286);
            this.ucRMATimeBreakdown1.TabIndex = 2;
            // 
            // ucAssetInfo1
            // 
            this.ucAssetInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucAssetInfo1.Location = new System.Drawing.Point(873, 3);
            this.ucAssetInfo1.Name = "ucAssetInfo1";
            this.ucAssetInfo1.Size = new System.Drawing.Size(301, 286);
            this.ucAssetInfo1.TabIndex = 4;
            // 
            // tabsRMAInfo
            // 
            this.tabsRMAInfo.Controls.Add(this.tabRecieve);
            this.tabsRMAInfo.Controls.Add(this.tabRMARepair);
            this.tabsRMAInfo.Controls.Add(this.tabRMAShipments);
            this.tabsRMAInfo.Controls.Add(this.tabRMAAccounting);
            this.tabsRMAInfo.Controls.Add(this.tabOverview);
            this.tabsRMAInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabsRMAInfo.Location = new System.Drawing.Point(3, 300);
            this.tabsRMAInfo.Name = "tabsRMAInfo";
            this.tabsRMAInfo.SelectedIndex = 0;
            this.tabsRMAInfo.Size = new System.Drawing.Size(1181, 274);
            this.tabsRMAInfo.TabIndex = 0;
            // 
            // tabRecieve
            // 
            this.tabRecieve.Controls.Add(this.olvReceive_Assemblies);
            this.tabRecieve.Controls.Add(this.pnlReceive_Assemblies_Control);
            this.tabRecieve.Controls.Add(this.pnlReceive_Right);
            this.tabRecieve.Location = new System.Drawing.Point(4, 22);
            this.tabRecieve.Name = "tabRecieve";
            this.tabRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecieve.Size = new System.Drawing.Size(1173, 248);
            this.tabRecieve.TabIndex = 4;
            this.tabRecieve.Text = "Receive";
            this.tabRecieve.UseVisualStyleBackColor = true;
            // 
            // olvReceive_Assemblies
            // 
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_Description);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_FailureType);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColDiscarded);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_Receive_Date);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_Receive_User);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_AssemblySerialNumber);
            this.olvReceive_Assemblies.AllColumns.Add(this.olvColReceive_BinID);
            this.olvReceive_Assemblies.CellEditUseWholeCell = false;
            this.olvReceive_Assemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColReceive_Description,
            this.olvColReceive_FailureType,
            this.olvColDiscarded,
            this.olvColReceive_Receive_Date,
            this.olvColReceive_Receive_User,
            this.olvColReceive_AssemblySerialNumber,
            this.olvColReceive_BinID});
            this.olvReceive_Assemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvReceive_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvReceive_Assemblies.FullRowSelect = true;
            this.olvReceive_Assemblies.GridLines = true;
            this.olvReceive_Assemblies.HideSelection = false;
            this.olvReceive_Assemblies.Location = new System.Drawing.Point(3, 33);
            this.olvReceive_Assemblies.MultiSelect = false;
            this.olvReceive_Assemblies.Name = "olvReceive_Assemblies";
            this.olvReceive_Assemblies.ShowGroups = false;
            this.olvReceive_Assemblies.Size = new System.Drawing.Size(803, 212);
            this.olvReceive_Assemblies.TabIndex = 36;
            this.olvReceive_Assemblies.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.olvReceive_Assemblies.UseCompatibleStateImageBehavior = false;
            this.olvReceive_Assemblies.View = System.Windows.Forms.View.Details;
            // 
            // olvColReceive_Description
            // 
            this.olvColReceive_Description.AspectName = "Description";
            this.olvColReceive_Description.IsEditable = false;
            this.olvColReceive_Description.Text = "Assembly";
            this.olvColReceive_Description.Width = 260;
            // 
            // olvColReceive_FailureType
            // 
            this.olvColReceive_FailureType.AspectName = "FailureTypeDescription";
            this.olvColReceive_FailureType.IsEditable = false;
            this.olvColReceive_FailureType.Text = "Failure Type";
            this.olvColReceive_FailureType.Width = 180;
            // 
            // olvColDiscarded
            // 
            this.olvColDiscarded.AspectName = "Discarded";
            this.olvColDiscarded.IsEditable = false;
            this.olvColDiscarded.Text = "Discarded";
            this.olvColDiscarded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColReceive_Receive_Date
            // 
            this.olvColReceive_Receive_Date.AspectName = "Receive_Date";
            this.olvColReceive_Receive_Date.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColReceive_Receive_Date.IsEditable = false;
            this.olvColReceive_Receive_Date.Text = "Received";
            this.olvColReceive_Receive_Date.Width = 70;
            // 
            // olvColReceive_Receive_User
            // 
            this.olvColReceive_Receive_User.AspectName = "Receive_UserName";
            this.olvColReceive_Receive_User.IsEditable = false;
            this.olvColReceive_Receive_User.Text = "By";
            this.olvColReceive_Receive_User.Width = 65;
            // 
            // olvColReceive_AssemblySerialNumber
            // 
            this.olvColReceive_AssemblySerialNumber.AspectName = "SerialNumber";
            this.olvColReceive_AssemblySerialNumber.IsEditable = false;
            this.olvColReceive_AssemblySerialNumber.Text = "Serial Number";
            this.olvColReceive_AssemblySerialNumber.Width = 90;
            // 
            // olvColReceive_BinID
            // 
            this.olvColReceive_BinID.AspectName = "AssignedBinID";
            this.olvColReceive_BinID.IsEditable = false;
            this.olvColReceive_BinID.Text = "Bin";
            this.olvColReceive_BinID.Width = 75;
            // 
            // pnlReceive_Assemblies_Control
            // 
            this.pnlReceive_Assemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlReceive_Assemblies_Control.Controls.Add(this.lblReceive_SelectedAssemblyID);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.txtReceive_TotalAssyQty);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.txtReceive_ReceivedQty);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.lblReceive_ReceivedQty);
            this.pnlReceive_Assemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceive_Assemblies_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlReceive_Assemblies_Control.Name = "pnlReceive_Assemblies_Control";
            this.pnlReceive_Assemblies_Control.Size = new System.Drawing.Size(803, 30);
            this.pnlReceive_Assemblies_Control.TabIndex = 35;
            // 
            // lblReceive_SelectedAssemblyID
            // 
            this.lblReceive_SelectedAssemblyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReceive_SelectedAssemblyID.Location = new System.Drawing.Point(3, 8);
            this.lblReceive_SelectedAssemblyID.Name = "lblReceive_SelectedAssemblyID";
            this.lblReceive_SelectedAssemblyID.Size = new System.Drawing.Size(54, 13);
            this.lblReceive_SelectedAssemblyID.TabIndex = 29;
            // 
            // txtReceive_TotalAssyQty
            // 
            this.txtReceive_TotalAssyQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive_TotalAssyQty.Location = new System.Drawing.Point(755, 6);
            this.txtReceive_TotalAssyQty.Name = "txtReceive_TotalAssyQty";
            this.txtReceive_TotalAssyQty.ReadOnly = true;
            this.txtReceive_TotalAssyQty.Size = new System.Drawing.Size(42, 20);
            this.txtReceive_TotalAssyQty.TabIndex = 28;
            // 
            // txtReceive_ReceivedQty
            // 
            this.txtReceive_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive_ReceivedQty.Location = new System.Drawing.Point(641, 6);
            this.txtReceive_ReceivedQty.Name = "txtReceive_ReceivedQty";
            this.txtReceive_ReceivedQty.ReadOnly = true;
            this.txtReceive_ReceivedQty.Size = new System.Drawing.Size(42, 20);
            this.txtReceive_ReceivedQty.TabIndex = 26;
            // 
            // lblReceive_ReceivedQty
            // 
            this.lblReceive_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceive_ReceivedQty.AutoSize = true;
            this.lblReceive_ReceivedQty.Location = new System.Drawing.Point(689, 9);
            this.lblReceive_ReceivedQty.Name = "lblReceive_ReceivedQty";
            this.lblReceive_ReceivedQty.Size = new System.Drawing.Size(60, 13);
            this.lblReceive_ReceivedQty.TabIndex = 27;
            this.lblReceive_ReceivedQty.Text = "received of";
            // 
            // pnlReceive_Right
            // 
            this.pnlReceive_Right.Controls.Add(this.btnReceive_DiscardSelected);
            this.pnlReceive_Right.Controls.Add(this.lblReceive_BinAssyQty);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_CreateBin);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_SelectBin);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_DeleteBin);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_PrintBinLabels_Current);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_PrintBinLabels_All);
            this.pnlReceive_Right.Controls.Add(this.lblReceive_CurrentBinID);
            this.pnlReceive_Right.Controls.Add(this.txtReceive_CurrentBinID);
            this.pnlReceive_Right.Controls.Add(this.lblReceive_AssemblySerialNumber);
            this.pnlReceive_Right.Controls.Add(this.btnReceive_ReceiveSelected);
            this.pnlReceive_Right.Controls.Add(this.txtReceive_AssemblySerialNumber);
            this.pnlReceive_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReceive_Right.Location = new System.Drawing.Point(806, 3);
            this.pnlReceive_Right.Name = "pnlReceive_Right";
            this.pnlReceive_Right.Size = new System.Drawing.Size(364, 242);
            this.pnlReceive_Right.TabIndex = 34;
            // 
            // btnReceive_DiscardSelected
            // 
            this.btnReceive_DiscardSelected.Location = new System.Drawing.Point(7, 342);
            this.btnReceive_DiscardSelected.Name = "btnReceive_DiscardSelected";
            this.btnReceive_DiscardSelected.Size = new System.Drawing.Size(167, 23);
            this.btnReceive_DiscardSelected.TabIndex = 9;
            this.btnReceive_DiscardSelected.Text = "Change to &Discarded";
            this.btnReceive_DiscardSelected.UseVisualStyleBackColor = true;
            // 
            // lblReceive_BinAssyQty
            // 
            this.lblReceive_BinAssyQty.Location = new System.Drawing.Point(107, 6);
            this.lblReceive_BinAssyQty.Name = "lblReceive_BinAssyQty";
            this.lblReceive_BinAssyQty.Size = new System.Drawing.Size(67, 13);
            this.lblReceive_BinAssyQty.TabIndex = 1;
            this.lblReceive_BinAssyQty.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReceive_CreateBin
            // 
            this.btnReceive_CreateBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReceive_CreateBin.Location = new System.Drawing.Point(7, 60);
            this.btnReceive_CreateBin.Name = "btnReceive_CreateBin";
            this.btnReceive_CreateBin.Size = new System.Drawing.Size(167, 30);
            this.btnReceive_CreateBin.TabIndex = 3;
            this.btnReceive_CreateBin.Text = "&Create New Bin";
            this.btnReceive_CreateBin.UseVisualStyleBackColor = false;
            // 
            // btnReceive_SelectBin
            // 
            this.btnReceive_SelectBin.Location = new System.Drawing.Point(7, 96);
            this.btnReceive_SelectBin.Name = "btnReceive_SelectBin";
            this.btnReceive_SelectBin.Size = new System.Drawing.Size(167, 30);
            this.btnReceive_SelectBin.TabIndex = 4;
            this.btnReceive_SelectBin.Text = "&Select Existing Bin";
            this.btnReceive_SelectBin.UseVisualStyleBackColor = false;
            // 
            // btnReceive_DeleteBin
            // 
            this.btnReceive_DeleteBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReceive_DeleteBin.Location = new System.Drawing.Point(46, 132);
            this.btnReceive_DeleteBin.Name = "btnReceive_DeleteBin";
            this.btnReceive_DeleteBin.Size = new System.Drawing.Size(90, 23);
            this.btnReceive_DeleteBin.TabIndex = 5;
            this.btnReceive_DeleteBin.Text = "&Delete Bin";
            this.btnReceive_DeleteBin.UseVisualStyleBackColor = false;
            // 
            // btnReceive_PrintBinLabels_Current
            // 
            this.btnReceive_PrintBinLabels_Current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceive_PrintBinLabels_Current.Location = new System.Drawing.Point(183, 162);
            this.btnReceive_PrintBinLabels_Current.Name = "btnReceive_PrintBinLabels_Current";
            this.btnReceive_PrintBinLabels_Current.Size = new System.Drawing.Size(165, 23);
            this.btnReceive_PrintBinLabels_Current.TabIndex = 11;
            this.btnReceive_PrintBinLabels_Current.Text = "Print Selected &Bin Label";
            this.btnReceive_PrintBinLabels_Current.UseVisualStyleBackColor = true;
            // 
            // btnReceive_PrintBinLabels_All
            // 
            this.btnReceive_PrintBinLabels_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceive_PrintBinLabels_All.Location = new System.Drawing.Point(182, 108);
            this.btnReceive_PrintBinLabels_All.Name = "btnReceive_PrintBinLabels_All";
            this.btnReceive_PrintBinLabels_All.Size = new System.Drawing.Size(165, 48);
            this.btnReceive_PrintBinLabels_All.TabIndex = 10;
            this.btnReceive_PrintBinLabels_All.Text = "Print &All Bin Labels";
            this.btnReceive_PrintBinLabels_All.UseVisualStyleBackColor = true;
            // 
            // lblReceive_CurrentBinID
            // 
            this.lblReceive_CurrentBinID.AutoSize = true;
            this.lblReceive_CurrentBinID.Location = new System.Drawing.Point(7, 6);
            this.lblReceive_CurrentBinID.Name = "lblReceive_CurrentBinID";
            this.lblReceive_CurrentBinID.Size = new System.Drawing.Size(67, 13);
            this.lblReceive_CurrentBinID.TabIndex = 0;
            this.lblReceive_CurrentBinID.Text = "Selected Bin";
            // 
            // txtReceive_CurrentBinID
            // 
            this.txtReceive_CurrentBinID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive_CurrentBinID.Location = new System.Drawing.Point(7, 22);
            this.txtReceive_CurrentBinID.MaxLength = 10;
            this.txtReceive_CurrentBinID.Name = "txtReceive_CurrentBinID";
            this.txtReceive_CurrentBinID.ReadOnly = true;
            this.txtReceive_CurrentBinID.Size = new System.Drawing.Size(167, 32);
            this.txtReceive_CurrentBinID.TabIndex = 2;
            this.txtReceive_CurrentBinID.Text = "NONE";
            this.txtReceive_CurrentBinID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReceive_AssemblySerialNumber
            // 
            this.lblReceive_AssemblySerialNumber.AutoSize = true;
            this.lblReceive_AssemblySerialNumber.Location = new System.Drawing.Point(180, 6);
            this.lblReceive_AssemblySerialNumber.Name = "lblReceive_AssemblySerialNumber";
            this.lblReceive_AssemblySerialNumber.Size = new System.Drawing.Size(90, 13);
            this.lblReceive_AssemblySerialNumber.TabIndex = 6;
            this.lblReceive_AssemblySerialNumber.Text = "Assembly Serial #";
            // 
            // btnReceive_ReceiveSelected
            // 
            this.btnReceive_ReceiveSelected.Enabled = false;
            this.btnReceive_ReceiveSelected.Location = new System.Drawing.Point(180, 48);
            this.btnReceive_ReceiveSelected.Name = "btnReceive_ReceiveSelected";
            this.btnReceive_ReceiveSelected.Size = new System.Drawing.Size(167, 48);
            this.btnReceive_ReceiveSelected.TabIndex = 8;
            this.btnReceive_ReceiveSelected.Text = "&Record and Receive";
            this.btnReceive_ReceiveSelected.UseVisualStyleBackColor = true;
            // 
            // txtReceive_AssemblySerialNumber
            // 
            this.txtReceive_AssemblySerialNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive_AssemblySerialNumber.Location = new System.Drawing.Point(180, 22);
            this.txtReceive_AssemblySerialNumber.MaxLength = 16;
            this.txtReceive_AssemblySerialNumber.Name = "txtReceive_AssemblySerialNumber";
            this.txtReceive_AssemblySerialNumber.ReadOnly = true;
            this.txtReceive_AssemblySerialNumber.Size = new System.Drawing.Size(167, 20);
            this.txtReceive_AssemblySerialNumber.TabIndex = 7;
            // 
            // tabRMARepair
            // 
            this.tabRMARepair.Controls.Add(this.tabControl1);
            this.tabRMARepair.Controls.Add(this.grpJournal);
            this.tabRMARepair.Location = new System.Drawing.Point(4, 22);
            this.tabRMARepair.Name = "tabRMARepair";
            this.tabRMARepair.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMARepair.Size = new System.Drawing.Size(1173, 248);
            this.tabRMARepair.TabIndex = 0;
            this.tabRMARepair.Text = "Repair Info";
            this.tabRMARepair.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAssemblyInfo);
            this.tabControl1.Controls.Add(this.tabRepairInfo);
            this.tabControl1.Controls.Add(this.tabComponentInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(698, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 242);
            this.tabControl1.TabIndex = 79;
            // 
            // tabAssemblyInfo
            // 
            this.tabAssemblyInfo.Controls.Add(this.tbxAssemblyStatus);
            this.tabAssemblyInfo.Controls.Add(this.label1);
            this.tabAssemblyInfo.Controls.Add(this.txtRepair_InventoryLocation);
            this.tabAssemblyInfo.Controls.Add(this.lblRepair_InventoryLocation);
            this.tabAssemblyInfo.Controls.Add(this.txtRepair_LEDBoard_Calibration);
            this.tabAssemblyInfo.Controls.Add(this.lblRepair_LEDBoard_Calibration);
            this.tabAssemblyInfo.Controls.Add(this.txtRepair_OriginalJobNumber);
            this.tabAssemblyInfo.Controls.Add(this.lblRepair_OriginalJobNumber);
            this.tabAssemblyInfo.Controls.Add(this.txtRepair_SerialNumber);
            this.tabAssemblyInfo.Controls.Add(this.lblRepair_SerialNumber);
            this.tabAssemblyInfo.Controls.Add(this.BtnUpdate);
            this.tabAssemblyInfo.Controls.Add(this.lblAssembly);
            this.tabAssemblyInfo.Controls.Add(this.textBox2);
            this.tabAssemblyInfo.Controls.Add(this.lblRepair_FailureType);
            this.tabAssemblyInfo.Controls.Add(this.txtRepair_FailureType);
            this.tabAssemblyInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAssemblyInfo.Name = "tabAssemblyInfo";
            this.tabAssemblyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssemblyInfo.Size = new System.Drawing.Size(464, 216);
            this.tabAssemblyInfo.TabIndex = 0;
            this.tabAssemblyInfo.Text = "Assembly Info";
            this.tabAssemblyInfo.UseVisualStyleBackColor = true;
            // 
            // tbxAssemblyStatus
            // 
            this.tbxAssemblyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAssemblyStatus.Location = new System.Drawing.Point(104, 178);
            this.tbxAssemblyStatus.Name = "tbxAssemblyStatus";
            this.tbxAssemblyStatus.ReadOnly = true;
            this.tbxAssemblyStatus.Size = new System.Drawing.Size(297, 32);
            this.tbxAssemblyStatus.TabIndex = 31;
            this.tbxAssemblyStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Status:";
            // 
            // txtRepair_InventoryLocation
            // 
            this.txtRepair_InventoryLocation.Location = new System.Drawing.Point(104, 155);
            this.txtRepair_InventoryLocation.Name = "txtRepair_InventoryLocation";
            this.txtRepair_InventoryLocation.ReadOnly = true;
            this.txtRepair_InventoryLocation.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_InventoryLocation.TabIndex = 29;
            this.txtRepair_InventoryLocation.TabStop = false;
            // 
            // lblRepair_InventoryLocation
            // 
            this.lblRepair_InventoryLocation.AutoSize = true;
            this.lblRepair_InventoryLocation.Location = new System.Drawing.Point(0, 155);
            this.lblRepair_InventoryLocation.Name = "lblRepair_InventoryLocation";
            this.lblRepair_InventoryLocation.Size = new System.Drawing.Size(98, 13);
            this.lblRepair_InventoryLocation.TabIndex = 28;
            this.lblRepair_InventoryLocation.Text = "Inventory Location:";
            // 
            // txtRepair_LEDBoard_Calibration
            // 
            this.txtRepair_LEDBoard_Calibration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_LEDBoard_Calibration.Location = new System.Drawing.Point(104, 125);
            this.txtRepair_LEDBoard_Calibration.MaxLength = 24;
            this.txtRepair_LEDBoard_Calibration.Name = "txtRepair_LEDBoard_Calibration";
            this.txtRepair_LEDBoard_Calibration.ReadOnly = true;
            this.txtRepair_LEDBoard_Calibration.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_LEDBoard_Calibration.TabIndex = 27;
            // 
            // lblRepair_LEDBoard_Calibration
            // 
            this.lblRepair_LEDBoard_Calibration.AutoSize = true;
            this.lblRepair_LEDBoard_Calibration.Location = new System.Drawing.Point(15, 127);
            this.lblRepair_LEDBoard_Calibration.Name = "lblRepair_LEDBoard_Calibration";
            this.lblRepair_LEDBoard_Calibration.Size = new System.Drawing.Size(83, 13);
            this.lblRepair_LEDBoard_Calibration.TabIndex = 26;
            this.lblRepair_LEDBoard_Calibration.Text = "LED Calibration:";
            // 
            // txtRepair_OriginalJobNumber
            // 
            this.txtRepair_OriginalJobNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_OriginalJobNumber.Location = new System.Drawing.Point(104, 96);
            this.txtRepair_OriginalJobNumber.MaxLength = 16;
            this.txtRepair_OriginalJobNumber.Name = "txtRepair_OriginalJobNumber";
            this.txtRepair_OriginalJobNumber.ReadOnly = true;
            this.txtRepair_OriginalJobNumber.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_OriginalJobNumber.TabIndex = 25;
            // 
            // lblRepair_OriginalJobNumber
            // 
            this.lblRepair_OriginalJobNumber.AutoSize = true;
            this.lblRepair_OriginalJobNumber.Location = new System.Drawing.Point(71, 96);
            this.lblRepair_OriginalJobNumber.Name = "lblRepair_OriginalJobNumber";
            this.lblRepair_OriginalJobNumber.Size = new System.Drawing.Size(27, 13);
            this.lblRepair_OriginalJobNumber.TabIndex = 24;
            this.lblRepair_OriginalJobNumber.Text = "Job:";
            // 
            // txtRepair_SerialNumber
            // 
            this.txtRepair_SerialNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_SerialNumber.Location = new System.Drawing.Point(104, 67);
            this.txtRepair_SerialNumber.MaxLength = 10;
            this.txtRepair_SerialNumber.Name = "txtRepair_SerialNumber";
            this.txtRepair_SerialNumber.ReadOnly = true;
            this.txtRepair_SerialNumber.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_SerialNumber.TabIndex = 23;
            // 
            // lblRepair_SerialNumber
            // 
            this.lblRepair_SerialNumber.AutoSize = true;
            this.lblRepair_SerialNumber.Location = new System.Drawing.Point(62, 67);
            this.lblRepair_SerialNumber.Name = "lblRepair_SerialNumber";
            this.lblRepair_SerialNumber.Size = new System.Drawing.Size(36, 13);
            this.lblRepair_SerialNumber.TabIndex = 22;
            this.lblRepair_SerialNumber.Text = "Serial:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(404, -5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(61, 45);
            this.BtnUpdate.TabIndex = 21;
            this.BtnUpdate.Text = "Update\r\nAssembly";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Location = new System.Drawing.Point(-1, 11);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(99, 13);
            this.lblAssembly.TabIndex = 19;
            this.lblAssembly.Text = "Selected Assembly:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(297, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TabStop = false;
            // 
            // lblRepair_FailureType
            // 
            this.lblRepair_FailureType.AutoSize = true;
            this.lblRepair_FailureType.Location = new System.Drawing.Point(30, 38);
            this.lblRepair_FailureType.Name = "lblRepair_FailureType";
            this.lblRepair_FailureType.Size = new System.Drawing.Size(68, 13);
            this.lblRepair_FailureType.TabIndex = 17;
            this.lblRepair_FailureType.Text = "Failure Type:";
            // 
            // txtRepair_FailureType
            // 
            this.txtRepair_FailureType.Location = new System.Drawing.Point(104, 35);
            this.txtRepair_FailureType.Name = "txtRepair_FailureType";
            this.txtRepair_FailureType.ReadOnly = true;
            this.txtRepair_FailureType.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_FailureType.TabIndex = 18;
            this.txtRepair_FailureType.TabStop = false;
            // 
            // tabRepairInfo
            // 
            this.tabRepairInfo.Controls.Add(this.olvRepair_RepairTypes);
            this.tabRepairInfo.Location = new System.Drawing.Point(4, 22);
            this.tabRepairInfo.Name = "tabRepairInfo";
            this.tabRepairInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepairInfo.Size = new System.Drawing.Size(464, 216);
            this.tabRepairInfo.TabIndex = 1;
            this.tabRepairInfo.Text = "Repair Info";
            this.tabRepairInfo.UseVisualStyleBackColor = true;
            // 
            // olvRepair_RepairTypes
            // 
            this.olvRepair_RepairTypes.AllColumns.Add(this.olvColRepair_RepairType);
            this.olvRepair_RepairTypes.CellEditUseWholeCell = false;
            this.olvRepair_RepairTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepair_RepairType});
            this.olvRepair_RepairTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRepair_RepairTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRepair_RepairTypes.FullRowSelect = true;
            this.olvRepair_RepairTypes.GridLines = true;
            this.olvRepair_RepairTypes.Location = new System.Drawing.Point(3, 3);
            this.olvRepair_RepairTypes.MultiSelect = false;
            this.olvRepair_RepairTypes.Name = "olvRepair_RepairTypes";
            this.olvRepair_RepairTypes.SelectAllOnControlA = false;
            this.olvRepair_RepairTypes.ShowGroups = false;
            this.olvRepair_RepairTypes.ShowHeaderInAllViews = false;
            this.olvRepair_RepairTypes.Size = new System.Drawing.Size(458, 210);
            this.olvRepair_RepairTypes.TabIndex = 2;
            this.olvRepair_RepairTypes.UseCompatibleStateImageBehavior = false;
            this.olvRepair_RepairTypes.View = System.Windows.Forms.View.Details;
            // 
            // olvColRepair_RepairType
            // 
            this.olvColRepair_RepairType.AspectName = "Description";
            this.olvColRepair_RepairType.FillsFreeSpace = true;
            this.olvColRepair_RepairType.Text = "Repairs Made:";
            this.olvColRepair_RepairType.Width = 350;
            // 
            // tabComponentInfo
            // 
            this.tabComponentInfo.Controls.Add(this.olvRepair_Components);
            this.tabComponentInfo.Controls.Add(this.pnlRepair_Component_Control);
            this.tabComponentInfo.Location = new System.Drawing.Point(4, 22);
            this.tabComponentInfo.Name = "tabComponentInfo";
            this.tabComponentInfo.Size = new System.Drawing.Size(464, 216);
            this.tabComponentInfo.TabIndex = 2;
            this.tabComponentInfo.Text = "Component Info";
            this.tabComponentInfo.UseVisualStyleBackColor = true;
            // 
            // olvRepair_Components
            // 
            this.olvRepair_Components.AllColumns.Add(this.olvColRepair_Component_PartNumber);
            this.olvRepair_Components.AllColumns.Add(this.olvColRepair_Component_Description);
            this.olvRepair_Components.AllColumns.Add(this.olvColRepair_Component_SilkLabel);
            this.olvRepair_Components.CellEditUseWholeCell = false;
            this.olvRepair_Components.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepair_Component_PartNumber,
            this.olvColRepair_Component_Description,
            this.olvColRepair_Component_SilkLabel});
            this.olvRepair_Components.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRepair_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRepair_Components.FullRowSelect = true;
            this.olvRepair_Components.GridLines = true;
            this.olvRepair_Components.Location = new System.Drawing.Point(0, 30);
            this.olvRepair_Components.MultiSelect = false;
            this.olvRepair_Components.Name = "olvRepair_Components";
            this.olvRepair_Components.ShowGroups = false;
            this.olvRepair_Components.Size = new System.Drawing.Size(464, 186);
            this.olvRepair_Components.TabIndex = 2;
            this.olvRepair_Components.UseCompatibleStateImageBehavior = false;
            this.olvRepair_Components.View = System.Windows.Forms.View.Details;
            // 
            // olvColRepair_Component_PartNumber
            // 
            this.olvColRepair_Component_PartNumber.AspectName = "Component.ComponentNumber";
            this.olvColRepair_Component_PartNumber.Text = "Component #";
            this.olvColRepair_Component_PartNumber.Width = 100;
            // 
            // olvColRepair_Component_Description
            // 
            this.olvColRepair_Component_Description.AspectName = "Component.Description";
            this.olvColRepair_Component_Description.Text = "Description";
            this.olvColRepair_Component_Description.Width = 200;
            // 
            // olvColRepair_Component_SilkLabel
            // 
            this.olvColRepair_Component_SilkLabel.AspectName = "SilkscreenID";
            this.olvColRepair_Component_SilkLabel.Text = "Silkscreen ID";
            this.olvColRepair_Component_SilkLabel.Width = 100;
            // 
            // pnlRepair_Component_Control
            // 
            this.pnlRepair_Component_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRepair_Component_Control.Controls.Add(this.lblRepair_Components_Qty);
            this.pnlRepair_Component_Control.Controls.Add(this.txtRepair_Components_Qty);
            this.pnlRepair_Component_Control.Controls.Add(this.txtRepair_MU);
            this.pnlRepair_Component_Control.Controls.Add(this.lblRepair_MU);
            this.pnlRepair_Component_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_Component_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlRepair_Component_Control.Name = "pnlRepair_Component_Control";
            this.pnlRepair_Component_Control.Size = new System.Drawing.Size(464, 30);
            this.pnlRepair_Component_Control.TabIndex = 1;
            // 
            // lblRepair_Components_Qty
            // 
            this.lblRepair_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepair_Components_Qty.AutoSize = true;
            this.lblRepair_Components_Qty.Location = new System.Drawing.Point(387, 8);
            this.lblRepair_Components_Qty.Name = "lblRepair_Components_Qty";
            this.lblRepair_Components_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblRepair_Components_Qty.TabIndex = 4;
            this.lblRepair_Components_Qty.Text = "Qty";
            // 
            // txtRepair_Components_Qty
            // 
            this.txtRepair_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_Components_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_Components_Qty.Location = new System.Drawing.Point(416, 3);
            this.txtRepair_Components_Qty.MaxLength = 8;
            this.txtRepair_Components_Qty.Name = "txtRepair_Components_Qty";
            this.txtRepair_Components_Qty.ReadOnly = true;
            this.txtRepair_Components_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtRepair_Components_Qty.TabIndex = 5;
            this.txtRepair_Components_Qty.TabStop = false;
            // 
            // txtRepair_MU
            // 
            this.txtRepair_MU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_MU.Location = new System.Drawing.Point(280, 5);
            this.txtRepair_MU.MaxLength = 16;
            this.txtRepair_MU.Name = "txtRepair_MU";
            this.txtRepair_MU.ReadOnly = true;
            this.txtRepair_MU.Size = new System.Drawing.Size(101, 20);
            this.txtRepair_MU.TabIndex = 3;
            // 
            // lblRepair_MU
            // 
            this.lblRepair_MU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepair_MU.AutoSize = true;
            this.lblRepair_MU.Location = new System.Drawing.Point(240, 8);
            this.lblRepair_MU.Name = "lblRepair_MU";
            this.lblRepair_MU.Size = new System.Drawing.Size(34, 13);
            this.lblRepair_MU.TabIndex = 2;
            this.lblRepair_MU.Text = "MU #";
            // 
            // grpJournal
            // 
            this.grpJournal.Controls.Add(this.dgvJournal);
            this.grpJournal.Controls.Add(this.pnlJournal_Control);
            this.grpJournal.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpJournal.Location = new System.Drawing.Point(3, 3);
            this.grpJournal.Name = "grpJournal";
            this.grpJournal.Size = new System.Drawing.Size(689, 242);
            this.grpJournal.TabIndex = 78;
            this.grpJournal.TabStop = false;
            this.grpJournal.Text = "Journal";
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.AllowUserToOrderColumns = true;
            this.dgvJournal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvJournal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colDate,
            this.Assembly,
            this.colJournalEntry,
            this.colJournalExpires});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvJournal.Size = new System.Drawing.Size(683, 193);
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
            // Assembly
            // 
            this.Assembly.HeaderText = "Assembly";
            this.Assembly.Name = "Assembly";
            this.Assembly.ReadOnly = true;
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
            this.colJournalExpires.HeaderText = "Status";
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
            this.pnlJournal_Control.Size = new System.Drawing.Size(683, 30);
            this.pnlJournal_Control.TabIndex = 32;
            // 
            // btnJournal_Add
            // 
            this.btnJournal_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnJournal_Add.Location = new System.Drawing.Point(3, 3);
            this.btnJournal_Add.Name = "btnJournal_Add";
            this.btnJournal_Add.Size = new System.Drawing.Size(100, 23);
            this.btnJournal_Add.TabIndex = 0;
            this.btnJournal_Add.Text = "Update";
            this.btnJournal_Add.UseVisualStyleBackColor = false;
            // 
            // tabRMAShipments
            // 
            this.tabRMAShipments.Controls.Add(this.ucShipmentList1);
            this.tabRMAShipments.Location = new System.Drawing.Point(4, 22);
            this.tabRMAShipments.Name = "tabRMAShipments";
            this.tabRMAShipments.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMAShipments.Size = new System.Drawing.Size(1173, 248);
            this.tabRMAShipments.TabIndex = 1;
            this.tabRMAShipments.Text = "Shipments";
            this.tabRMAShipments.UseVisualStyleBackColor = true;
            // 
            // ucShipmentList1
            // 
            this.ucShipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShipmentList1.Location = new System.Drawing.Point(3, 3);
            this.ucShipmentList1.Name = "ucShipmentList1";
            this.ucShipmentList1.ShowCreateButton = true;
            this.ucShipmentList1.Size = new System.Drawing.Size(1167, 242);
            this.ucShipmentList1.TabIndex = 1;
            // 
            // tabRMAAccounting
            // 
            this.tabRMAAccounting.Controls.Add(this.grpAccounting_Components);
            this.tabRMAAccounting.Location = new System.Drawing.Point(4, 22);
            this.tabRMAAccounting.Name = "tabRMAAccounting";
            this.tabRMAAccounting.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMAAccounting.Size = new System.Drawing.Size(1173, 248);
            this.tabRMAAccounting.TabIndex = 2;
            this.tabRMAAccounting.Text = "Accounting";
            this.tabRMAAccounting.UseVisualStyleBackColor = true;
            // 
            // grpAccounting_Components
            // 
            this.grpAccounting_Components.Controls.Add(this.olvAccounting_Components);
            this.grpAccounting_Components.Controls.Add(this.pnlAccounting_Components_Control);
            this.grpAccounting_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAccounting_Components.Location = new System.Drawing.Point(3, 3);
            this.grpAccounting_Components.Name = "grpAccounting_Components";
            this.grpAccounting_Components.Size = new System.Drawing.Size(1167, 242);
            this.grpAccounting_Components.TabIndex = 4;
            this.grpAccounting_Components.TabStop = false;
            this.grpAccounting_Components.Text = "All Components Used";
            // 
            // olvAccounting_Components
            // 
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_PartNumber);
            this.olvAccounting_Components.AllColumns.Add(this.olvColAssembly);
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_Description);
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_SilkLabel);
            this.olvAccounting_Components.AllColumns.Add(this.olvColCost);
            this.olvAccounting_Components.CellEditUseWholeCell = false;
            this.olvAccounting_Components.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAccounting_Components_PartNumber,
            this.olvColAssembly,
            this.olvColAccounting_Components_Description,
            this.olvColAccounting_Components_SilkLabel,
            this.olvColCost});
            this.olvAccounting_Components.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAccounting_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAccounting_Components.FullRowSelect = true;
            this.olvAccounting_Components.GridLines = true;
            this.olvAccounting_Components.HideSelection = false;
            this.olvAccounting_Components.Location = new System.Drawing.Point(3, 46);
            this.olvAccounting_Components.MultiSelect = false;
            this.olvAccounting_Components.Name = "olvAccounting_Components";
            this.olvAccounting_Components.ShowGroups = false;
            this.olvAccounting_Components.Size = new System.Drawing.Size(1161, 193);
            this.olvAccounting_Components.TabIndex = 0;
            this.olvAccounting_Components.UseCompatibleStateImageBehavior = false;
            this.olvAccounting_Components.View = System.Windows.Forms.View.Details;
            // 
            // olvColAccounting_Components_PartNumber
            // 
            this.olvColAccounting_Components_PartNumber.AspectName = "Component.ComponentNumber";
            this.olvColAccounting_Components_PartNumber.Text = "Component #";
            this.olvColAccounting_Components_PartNumber.Width = 100;
            // 
            // olvColAssembly
            // 
            this.olvColAssembly.Text = "Assembly";
            this.olvColAssembly.Width = 256;
            // 
            // olvColAccounting_Components_Description
            // 
            this.olvColAccounting_Components_Description.AspectName = "Component.Description";
            this.olvColAccounting_Components_Description.Text = "Description";
            this.olvColAccounting_Components_Description.Width = 402;
            // 
            // olvColAccounting_Components_SilkLabel
            // 
            this.olvColAccounting_Components_SilkLabel.AspectName = "SilkscreenID";
            this.olvColAccounting_Components_SilkLabel.Text = "Component ID";
            this.olvColAccounting_Components_SilkLabel.Width = 144;
            // 
            // olvColCost
            // 
            this.olvColCost.Text = "Cost";
            this.olvColCost.Width = 252;
            // 
            // pnlAccounting_Components_Control
            // 
            this.pnlAccounting_Components_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAccounting_Components_Control.Controls.Add(this.lblAccounting_TotalCost);
            this.pnlAccounting_Components_Control.Controls.Add(this.txtAccounting_TotalCost);
            this.pnlAccounting_Components_Control.Controls.Add(this.lblAccounting_Components_Qty);
            this.pnlAccounting_Components_Control.Controls.Add(this.txtAccounting_Components_Qty);
            this.pnlAccounting_Components_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccounting_Components_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlAccounting_Components_Control.Name = "pnlAccounting_Components_Control";
            this.pnlAccounting_Components_Control.Size = new System.Drawing.Size(1161, 30);
            this.pnlAccounting_Components_Control.TabIndex = 1;
            // 
            // lblAccounting_TotalCost
            // 
            this.lblAccounting_TotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccounting_TotalCost.AutoSize = true;
            this.lblAccounting_TotalCost.Location = new System.Drawing.Point(910, 10);
            this.lblAccounting_TotalCost.Name = "lblAccounting_TotalCost";
            this.lblAccounting_TotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblAccounting_TotalCost.TabIndex = 13;
            this.lblAccounting_TotalCost.Text = "Total Cost";
            // 
            // txtAccounting_TotalCost
            // 
            this.txtAccounting_TotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccounting_TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounting_TotalCost.Location = new System.Drawing.Point(971, 5);
            this.txtAccounting_TotalCost.Name = "txtAccounting_TotalCost";
            this.txtAccounting_TotalCost.ReadOnly = true;
            this.txtAccounting_TotalCost.Size = new System.Drawing.Size(101, 22);
            this.txtAccounting_TotalCost.TabIndex = 14;
            this.txtAccounting_TotalCost.TabStop = false;
            this.txtAccounting_TotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccounting_Components_Qty
            // 
            this.lblAccounting_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccounting_Components_Qty.AutoSize = true;
            this.lblAccounting_Components_Qty.Location = new System.Drawing.Point(1078, 10);
            this.lblAccounting_Components_Qty.Name = "lblAccounting_Components_Qty";
            this.lblAccounting_Components_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblAccounting_Components_Qty.TabIndex = 11;
            this.lblAccounting_Components_Qty.Text = "Qty";
            // 
            // txtAccounting_Components_Qty
            // 
            this.txtAccounting_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccounting_Components_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounting_Components_Qty.Location = new System.Drawing.Point(1107, 5);
            this.txtAccounting_Components_Qty.Name = "txtAccounting_Components_Qty";
            this.txtAccounting_Components_Qty.ReadOnly = true;
            this.txtAccounting_Components_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtAccounting_Components_Qty.TabIndex = 12;
            this.txtAccounting_Components_Qty.TabStop = false;
            this.txtAccounting_Components_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabOverview
            // 
            this.tabOverview.Location = new System.Drawing.Point(4, 22);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1173, 248);
            this.tabOverview.TabIndex = 3;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.textBox1);
            this.gbxSearch.Location = new System.Drawing.Point(1205, 49);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(217, 334);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(205, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh (F5)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(205, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(3, 61);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(205, 23);
            this.btnMove.TabIndex = 29;
            this.btnMove.Text = "Move Items";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // gbxAction
            // 
            this.gbxAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAction.Controls.Add(this.flowLayoutPanel1);
            this.gbxAction.Location = new System.Drawing.Point(1205, 396);
            this.gbxAction.Name = "gbxAction";
            this.gbxAction.Size = new System.Drawing.Size(217, 234);
            this.gbxAction.TabIndex = 3;
            this.gbxAction.TabStop = false;
            this.gbxAction.Text = "Actions";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.btnExport);
            this.flowLayoutPanel1.Controls.Add(this.btnMove);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 215);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Modify RMA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxRMAStatusView
            // 
            this.cbxRMAStatusView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRMAStatusView.FormattingEnabled = true;
            this.cbxRMAStatusView.Location = new System.Drawing.Point(42, 5);
            this.cbxRMAStatusView.Name = "cbxRMAStatusView";
            this.cbxRMAStatusView.Size = new System.Drawing.Size(127, 21);
            this.cbxRMAStatusView.TabIndex = 20;
            // 
            // FormRMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 636);
            this.Controls.Add(this.gbxAction);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.tabsRMA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRMA";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RMA";
            this.tabsRMA.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRMAList)).EndInit();
            this.pnlRMAListControls.ResumeLayout(false);
            this.pnlRMAListControls.PerformLayout();
            this.tabRMA.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabsRMAInfo.ResumeLayout(false);
            this.tabRecieve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvReceive_Assemblies)).EndInit();
            this.pnlReceive_Assemblies_Control.ResumeLayout(false);
            this.pnlReceive_Assemblies_Control.PerformLayout();
            this.pnlReceive_Right.ResumeLayout(false);
            this.pnlReceive_Right.PerformLayout();
            this.tabRMARepair.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAssemblyInfo.ResumeLayout(false);
            this.tabAssemblyInfo.PerformLayout();
            this.tabRepairInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairTypes)).EndInit();
            this.tabComponentInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Components)).EndInit();
            this.pnlRepair_Component_Control.ResumeLayout(false);
            this.pnlRepair_Component_Control.PerformLayout();
            this.grpJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.pnlJournal_Control.ResumeLayout(false);
            this.tabRMAShipments.ResumeLayout(false);
            this.tabRMAAccounting.ResumeLayout(false);
            this.grpAccounting_Components.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAccounting_Components)).EndInit();
            this.pnlAccounting_Components_Control.ResumeLayout(false);
            this.pnlAccounting_Components_Control.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsRMA;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlRMAListControls;
        private BrightIdeasSoftware.ObjectListView olvRMAList;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Number;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Hot;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_APR;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_HasComputer;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_HasNonSystemJournalEntries;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Created;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_IssuedTo;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Received;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_TicketNumber;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Asset;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Assemblies;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Completed;
        private BrightIdeasSoftware.OLVColumn olvColRMAList_Finalized;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnlRMAStatusKey;
        private System.Windows.Forms.TextBox txtRMAList_Qty;
        private System.Windows.Forms.Label lblRMAList_Qty;
        private System.Windows.Forms.Label lblRMAList_View;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox gbxAction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabRMA;
        private System.Windows.Forms.TabControl tabsRMAInfo;
        private System.Windows.Forms.TabPage tabRMARepair;
        private System.Windows.Forms.TabPage tabRMAShipments;
        private System.Windows.Forms.TabPage tabRMAAccounting;
        private UserControls.ucRMADetails ucRMADetails1;
        private UserControls.RMA.ucRMATimeBreakdown ucRMATimeBreakdown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private UserControls.RMA.ucAssemblyList ucAssemblyList1;
        private System.Windows.Forms.Button button1;
        private UserControls.RMA.ucAssetInfo ucAssetInfo1;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabPage tabRecieve;
        private System.Windows.Forms.Panel pnlReceive_Right;
        private System.Windows.Forms.Button btnReceive_DiscardSelected;
        private System.Windows.Forms.Label lblReceive_BinAssyQty;
        private System.Windows.Forms.Button btnReceive_CreateBin;
        private System.Windows.Forms.Button btnReceive_SelectBin;
        private System.Windows.Forms.Button btnReceive_DeleteBin;
        private System.Windows.Forms.Button btnReceive_PrintBinLabels_Current;
        private System.Windows.Forms.Button btnReceive_PrintBinLabels_All;
        private System.Windows.Forms.Label lblReceive_CurrentBinID;
        private System.Windows.Forms.TextBox txtReceive_CurrentBinID;
        private System.Windows.Forms.Label lblReceive_AssemblySerialNumber;
        private System.Windows.Forms.Button btnReceive_ReceiveSelected;
        private System.Windows.Forms.TextBox txtReceive_AssemblySerialNumber;
        private System.Windows.Forms.Panel pnlReceive_Assemblies_Control;
        private System.Windows.Forms.Label lblReceive_SelectedAssemblyID;
        private System.Windows.Forms.TextBox txtReceive_TotalAssyQty;
        private System.Windows.Forms.TextBox txtReceive_ReceivedQty;
        private System.Windows.Forms.Label lblReceive_ReceivedQty;
        private BrightIdeasSoftware.ObjectListView olvReceive_Assemblies;
        private BrightIdeasSoftware.OLVColumn olvColReceive_Description;
        private BrightIdeasSoftware.OLVColumn olvColReceive_FailureType;
        private BrightIdeasSoftware.OLVColumn olvColDiscarded;
        private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_Date;
        private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_User;
        private BrightIdeasSoftware.OLVColumn olvColReceive_AssemblySerialNumber;
        private BrightIdeasSoftware.OLVColumn olvColReceive_BinID;
        private System.Windows.Forms.GroupBox grpJournal;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.Panel pnlJournal_Control;
        private System.Windows.Forms.Button btnJournal_Add;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAssemblyInfo;
        private System.Windows.Forms.TextBox tbxAssemblyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepair_InventoryLocation;
        private System.Windows.Forms.Label lblRepair_InventoryLocation;
        private System.Windows.Forms.TextBox txtRepair_LEDBoard_Calibration;
        private System.Windows.Forms.Label lblRepair_LEDBoard_Calibration;
        private System.Windows.Forms.TextBox txtRepair_OriginalJobNumber;
        private System.Windows.Forms.Label lblRepair_OriginalJobNumber;
        private System.Windows.Forms.TextBox txtRepair_SerialNumber;
        private System.Windows.Forms.Label lblRepair_SerialNumber;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label lblAssembly;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRepair_FailureType;
        private System.Windows.Forms.TextBox txtRepair_FailureType;
        private System.Windows.Forms.TabPage tabRepairInfo;
        private System.Windows.Forms.TabPage tabComponentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assembly;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
        private UserControls.Shipment.ucShipmentList ucShipmentList1;
        private BrightIdeasSoftware.ObjectListView olvRepair_RepairTypes;
        private BrightIdeasSoftware.OLVColumn olvColRepair_RepairType;
        private System.Windows.Forms.Panel pnlRepair_Component_Control;
        private System.Windows.Forms.Label lblRepair_Components_Qty;
        private System.Windows.Forms.TextBox txtRepair_Components_Qty;
        private System.Windows.Forms.TextBox txtRepair_MU;
        private System.Windows.Forms.Label lblRepair_MU;
        private BrightIdeasSoftware.ObjectListView olvRepair_Components;
        private BrightIdeasSoftware.OLVColumn olvColRepair_Component_PartNumber;
        private BrightIdeasSoftware.OLVColumn olvColRepair_Component_Description;
        private BrightIdeasSoftware.OLVColumn olvColRepair_Component_SilkLabel;
        private System.Windows.Forms.GroupBox grpAccounting_Components;
        private BrightIdeasSoftware.ObjectListView olvAccounting_Components;
        private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_PartNumber;
        private BrightIdeasSoftware.OLVColumn olvColAssembly;
        private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_Description;
        private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_SilkLabel;
        private BrightIdeasSoftware.OLVColumn olvColCost;
        private System.Windows.Forms.Panel pnlAccounting_Components_Control;
        private System.Windows.Forms.Label lblAccounting_TotalCost;
        private System.Windows.Forms.TextBox txtAccounting_TotalCost;
        private System.Windows.Forms.Label lblAccounting_Components_Qty;
        private System.Windows.Forms.TextBox txtAccounting_Components_Qty;
        private System.Windows.Forms.ComboBox cbxRMAStatusView;
    }
}