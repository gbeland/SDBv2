namespace SDB.Forms.Shipment
{
	partial class FormShipment_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipment_List));
            this.tabShipping = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.cmbSearch_AssemblyType = new System.Windows.Forms.ComboBox();
            this.radSearch_AssemblyType = new System.Windows.Forms.RadioButton();
            this.txtSearch_Other = new System.Windows.Forms.TextBox();
            this.radSearch_Other = new System.Windows.Forms.RadioButton();
            this.chkSearch_AllMarkets = new System.Windows.Forms.CheckBox();
            this.cmbSearch_Market = new System.Windows.Forms.ComboBox();
            this.cmbSearch_Asset = new System.Windows.Forms.ComboBox();
            this.cmbSearch_Tech = new System.Windows.Forms.ComboBox();
            this.txtSearch_JobNumber = new System.Windows.Forms.TextBox();
            this.txtSearch_Shipment = new System.Windows.Forms.TextBox();
            this.pnlSearch_DateRange = new System.Windows.Forms.Panel();
            this.chkDateRange_Shipped = new System.Windows.Forms.CheckBox();
            this.chkDateRange_Requested = new System.Windows.Forms.CheckBox();
            this.dtpSearch_From = new System.Windows.Forms.DateTimePicker();
            this.lblSearch_DateRangeThrough = new System.Windows.Forms.Label();
            this.dtpSearch_To = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radSearch_JobNumber = new System.Windows.Forms.RadioButton();
            this.txtSearch_RMANumber = new System.Windows.Forms.TextBox();
            this.radSearch_ShipmentNumber = new System.Windows.Forms.RadioButton();
            this.radSearch_DateRange = new System.Windows.Forms.RadioButton();
            this.cmbSearch_Customer = new System.Windows.Forms.ComboBox();
            this.lblList_Search = new System.Windows.Forms.Label();
            this.radSearch_Asset = new System.Windows.Forms.RadioButton();
            this.radSearch_Customer = new System.Windows.Forms.RadioButton();
            this.radSearch_RMANumber = new System.Windows.Forms.RadioButton();
            this.radSearch_Tech = new System.Windows.Forms.RadioButton();
            this.tabList = new System.Windows.Forms.TabPage();
            this.olvShippingResultsList = new BrightIdeasSoftware.ObjectListView();
            this.olvColShipmentID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColHasComputer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReadJournal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRequestDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReadyDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDestination = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColShipMethod = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColItems = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPicked = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColShipped = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTracking = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.pnlList_Control = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkAutoRefresh = new System.Windows.Forms.CheckBox();
            this.radList_Picked = new System.Windows.Forms.RadioButton();
            this.radList_OnHold = new System.Windows.Forms.RadioButton();
            this.radList_Ready = new System.Windows.Forms.RadioButton();
            this.lblList_Show = new System.Windows.Forms.Label();
            this.radList_Requested = new System.Windows.Forms.RadioButton();
            this.radList_Shipped = new System.Windows.Forms.RadioButton();
            this.txtShipmentsQty = new System.Windows.Forms.TextBox();
            this.lblShipmentsQty = new System.Windows.Forms.Label();
            this.radList_Deleted = new System.Windows.Forms.RadioButton();
            this.btnList_Refresh = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlControl_Bottom = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPageMax = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.cmbPage = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.timerAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.tabShipping.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.pnlSearch_DateRange.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvShippingResultsList)).BeginInit();
            this.pnlList_Control.SuspendLayout();
            this.pnlControl_Bottom.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShipping
            // 
            this.tabShipping.Controls.Add(this.tabSearch);
            this.tabShipping.Controls.Add(this.tabList);
            this.tabShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabShipping.Location = new System.Drawing.Point(0, 0);
            this.tabShipping.Name = "tabShipping";
            this.tabShipping.SelectedIndex = 0;
            this.tabShipping.Size = new System.Drawing.Size(984, 732);
            this.tabShipping.TabIndex = 1;
            this.tabShipping.SelectedIndexChanged += new System.EventHandler(this.tabShipping_SelectedIndexChanged);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.cmbSearch_AssemblyType);
            this.tabSearch.Controls.Add(this.radSearch_AssemblyType);
            this.tabSearch.Controls.Add(this.txtSearch_Other);
            this.tabSearch.Controls.Add(this.radSearch_Other);
            this.tabSearch.Controls.Add(this.chkSearch_AllMarkets);
            this.tabSearch.Controls.Add(this.cmbSearch_Market);
            this.tabSearch.Controls.Add(this.cmbSearch_Asset);
            this.tabSearch.Controls.Add(this.cmbSearch_Tech);
            this.tabSearch.Controls.Add(this.txtSearch_JobNumber);
            this.tabSearch.Controls.Add(this.txtSearch_Shipment);
            this.tabSearch.Controls.Add(this.pnlSearch_DateRange);
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.radSearch_JobNumber);
            this.tabSearch.Controls.Add(this.txtSearch_RMANumber);
            this.tabSearch.Controls.Add(this.radSearch_ShipmentNumber);
            this.tabSearch.Controls.Add(this.radSearch_DateRange);
            this.tabSearch.Controls.Add(this.cmbSearch_Customer);
            this.tabSearch.Controls.Add(this.lblList_Search);
            this.tabSearch.Controls.Add(this.radSearch_Asset);
            this.tabSearch.Controls.Add(this.radSearch_Customer);
            this.tabSearch.Controls.Add(this.radSearch_RMANumber);
            this.tabSearch.Controls.Add(this.radSearch_Tech);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(976, 706);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // cmbSearch_AssemblyType
            // 
            this.cmbSearch_AssemblyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_AssemblyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_AssemblyType.FormattingEnabled = true;
            this.cmbSearch_AssemblyType.Location = new System.Drawing.Point(177, 350);
            this.cmbSearch_AssemblyType.Name = "cmbSearch_AssemblyType";
            this.cmbSearch_AssemblyType.Size = new System.Drawing.Size(369, 24);
            this.cmbSearch_AssemblyType.Sorted = true;
            this.cmbSearch_AssemblyType.TabIndex = 21;
            this.cmbSearch_AssemblyType.Visible = false;
            // 
            // radSearch_AssemblyType
            // 
            this.radSearch_AssemblyType.AutoSize = true;
            this.radSearch_AssemblyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_AssemblyType.Location = new System.Drawing.Point(27, 351);
            this.radSearch_AssemblyType.Name = "radSearch_AssemblyType";
            this.radSearch_AssemblyType.Size = new System.Drawing.Size(121, 20);
            this.radSearch_AssemblyType.TabIndex = 20;
            this.radSearch_AssemblyType.Text = "Assembly Type";
            this.toolTip.SetToolTip(this.radSearch_AssemblyType, "Finds shipments that contain the specified assembly type.");
            this.radSearch_AssemblyType.UseVisualStyleBackColor = true;
            this.radSearch_AssemblyType.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // txtSearch_Other
            // 
            this.txtSearch_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_Other.Location = new System.Drawing.Point(177, 301);
            this.txtSearch_Other.Name = "txtSearch_Other";
            this.txtSearch_Other.Size = new System.Drawing.Size(369, 22);
            this.txtSearch_Other.TabIndex = 16;
            this.txtSearch_Other.Visible = false;
            this.txtSearch_Other.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_Other.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // radSearch_Other
            // 
            this.radSearch_Other.AutoSize = true;
            this.radSearch_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Other.Location = new System.Drawing.Point(27, 301);
            this.radSearch_Other.Name = "radSearch_Other";
            this.radSearch_Other.Size = new System.Drawing.Size(108, 20);
            this.radSearch_Other.TabIndex = 15;
            this.radSearch_Other.Text = "Other Ship To";
            this.radSearch_Other.UseVisualStyleBackColor = true;
            this.radSearch_Other.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // chkSearch_AllMarkets
            // 
            this.chkSearch_AllMarkets.AutoSize = true;
            this.chkSearch_AllMarkets.Location = new System.Drawing.Point(552, 231);
            this.chkSearch_AllMarkets.Name = "chkSearch_AllMarkets";
            this.chkSearch_AllMarkets.Size = new System.Drawing.Size(78, 17);
            this.chkSearch_AllMarkets.TabIndex = 13;
            this.chkSearch_AllMarkets.Text = "All Markets";
            this.chkSearch_AllMarkets.UseVisualStyleBackColor = true;
            this.chkSearch_AllMarkets.Visible = false;
            this.chkSearch_AllMarkets.CheckedChanged += new System.EventHandler(this.chkSearch_AllMarkets_CheckedChanged);
            // 
            // cmbSearch_Market
            // 
            this.cmbSearch_Market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Market.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Market.FormattingEnabled = true;
            this.cmbSearch_Market.Location = new System.Drawing.Point(201, 257);
            this.cmbSearch_Market.Name = "cmbSearch_Market";
            this.cmbSearch_Market.Size = new System.Drawing.Size(345, 24);
            this.cmbSearch_Market.Sorted = true;
            this.cmbSearch_Market.TabIndex = 14;
            this.cmbSearch_Market.Visible = false;
            this.cmbSearch_Market.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Market.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // cmbSearch_Asset
            // 
            this.cmbSearch_Asset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Asset.FormattingEnabled = true;
            this.cmbSearch_Asset.Location = new System.Drawing.Point(177, 167);
            this.cmbSearch_Asset.Name = "cmbSearch_Asset";
            this.cmbSearch_Asset.Size = new System.Drawing.Size(369, 24);
            this.cmbSearch_Asset.Sorted = true;
            this.cmbSearch_Asset.TabIndex = 8;
            this.cmbSearch_Asset.Visible = false;
            this.cmbSearch_Asset.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Asset.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // cmbSearch_Tech
            // 
            this.cmbSearch_Tech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Tech.FormattingEnabled = true;
            this.cmbSearch_Tech.Location = new System.Drawing.Point(177, 197);
            this.cmbSearch_Tech.Name = "cmbSearch_Tech";
            this.cmbSearch_Tech.Size = new System.Drawing.Size(369, 24);
            this.cmbSearch_Tech.Sorted = true;
            this.cmbSearch_Tech.TabIndex = 10;
            this.cmbSearch_Tech.Visible = false;
            this.cmbSearch_Tech.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Tech.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // txtSearch_JobNumber
            // 
            this.txtSearch_JobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_JobNumber.Location = new System.Drawing.Point(177, 79);
            this.txtSearch_JobNumber.Name = "txtSearch_JobNumber";
            this.txtSearch_JobNumber.Size = new System.Drawing.Size(139, 22);
            this.txtSearch_JobNumber.TabIndex = 4;
            this.txtSearch_JobNumber.Visible = false;
            this.txtSearch_JobNumber.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_JobNumber.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // txtSearch_Shipment
            // 
            this.txtSearch_Shipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_Shipment.Location = new System.Drawing.Point(177, 51);
            this.txtSearch_Shipment.Name = "txtSearch_Shipment";
            this.txtSearch_Shipment.Size = new System.Drawing.Size(139, 22);
            this.txtSearch_Shipment.TabIndex = 2;
            this.txtSearch_Shipment.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_Shipment.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // pnlSearch_DateRange
            // 
            this.pnlSearch_DateRange.Controls.Add(this.chkDateRange_Shipped);
            this.pnlSearch_DateRange.Controls.Add(this.chkDateRange_Requested);
            this.pnlSearch_DateRange.Controls.Add(this.dtpSearch_From);
            this.pnlSearch_DateRange.Controls.Add(this.lblSearch_DateRangeThrough);
            this.pnlSearch_DateRange.Controls.Add(this.dtpSearch_To);
            this.pnlSearch_DateRange.Location = new System.Drawing.Point(177, 402);
            this.pnlSearch_DateRange.Name = "pnlSearch_DateRange";
            this.pnlSearch_DateRange.Size = new System.Drawing.Size(369, 55);
            this.pnlSearch_DateRange.TabIndex = 18;
            this.pnlSearch_DateRange.Visible = false;
            // 
            // chkDateRange_Shipped
            // 
            this.chkDateRange_Shipped.AutoSize = true;
            this.chkDateRange_Shipped.Checked = true;
            this.chkDateRange_Shipped.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateRange_Shipped.Location = new System.Drawing.Point(87, 6);
            this.chkDateRange_Shipped.Name = "chkDateRange_Shipped";
            this.chkDateRange_Shipped.Size = new System.Drawing.Size(65, 17);
            this.chkDateRange_Shipped.TabIndex = 1;
            this.chkDateRange_Shipped.Text = "Shipped";
            this.chkDateRange_Shipped.UseVisualStyleBackColor = true;
            this.chkDateRange_Shipped.CheckedChanged += new System.EventHandler(this.chkDateRange_Shipped_CheckedChanged);
            // 
            // chkDateRange_Requested
            // 
            this.chkDateRange_Requested.AutoSize = true;
            this.chkDateRange_Requested.Checked = true;
            this.chkDateRange_Requested.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateRange_Requested.Location = new System.Drawing.Point(3, 6);
            this.chkDateRange_Requested.Name = "chkDateRange_Requested";
            this.chkDateRange_Requested.Size = new System.Drawing.Size(78, 17);
            this.chkDateRange_Requested.TabIndex = 0;
            this.chkDateRange_Requested.Text = "Requested";
            this.chkDateRange_Requested.UseVisualStyleBackColor = true;
            this.chkDateRange_Requested.CheckedChanged += new System.EventHandler(this.chkDateRange_Requested_CheckedChanged);
            // 
            // dtpSearch_From
            // 
            this.dtpSearch_From.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_From.Location = new System.Drawing.Point(3, 29);
            this.dtpSearch_From.Name = "dtpSearch_From";
            this.dtpSearch_From.Size = new System.Drawing.Size(98, 22);
            this.dtpSearch_From.TabIndex = 2;
            this.dtpSearch_From.Enter += new System.EventHandler(this.Search_Enter);
            this.dtpSearch_From.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // lblSearch_DateRangeThrough
            // 
            this.lblSearch_DateRangeThrough.AutoSize = true;
            this.lblSearch_DateRangeThrough.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_DateRangeThrough.Location = new System.Drawing.Point(110, 34);
            this.lblSearch_DateRangeThrough.Name = "lblSearch_DateRangeThrough";
            this.lblSearch_DateRangeThrough.Size = new System.Drawing.Size(52, 16);
            this.lblSearch_DateRangeThrough.TabIndex = 3;
            this.lblSearch_DateRangeThrough.Text = "through";
            // 
            // dtpSearch_To
            // 
            this.dtpSearch_To.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_To.Location = new System.Drawing.Point(168, 29);
            this.dtpSearch_To.Name = "dtpSearch_To";
            this.dtpSearch_To.Size = new System.Drawing.Size(98, 22);
            this.dtpSearch_To.TabIndex = 4;
            this.dtpSearch_To.Enter += new System.EventHandler(this.Search_Enter);
            this.dtpSearch_To.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 407);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 45);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radSearch_JobNumber
            // 
            this.radSearch_JobNumber.AutoSize = true;
            this.radSearch_JobNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_JobNumber.Location = new System.Drawing.Point(27, 80);
            this.radSearch_JobNumber.Name = "radSearch_JobNumber";
            this.radSearch_JobNumber.Size = new System.Drawing.Size(100, 20);
            this.radSearch_JobNumber.TabIndex = 3;
            this.radSearch_JobNumber.Text = "Job Number";
            this.radSearch_JobNumber.UseVisualStyleBackColor = true;
            this.radSearch_JobNumber.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // txtSearch_RMANumber
            // 
            this.txtSearch_RMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_RMANumber.Location = new System.Drawing.Point(177, 107);
            this.txtSearch_RMANumber.Name = "txtSearch_RMANumber";
            this.txtSearch_RMANumber.Size = new System.Drawing.Size(139, 22);
            this.txtSearch_RMANumber.TabIndex = 6;
            this.txtSearch_RMANumber.Visible = false;
            this.txtSearch_RMANumber.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_RMANumber.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // radSearch_ShipmentNumber
            // 
            this.radSearch_ShipmentNumber.AutoSize = true;
            this.radSearch_ShipmentNumber.Checked = true;
            this.radSearch_ShipmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_ShipmentNumber.Location = new System.Drawing.Point(27, 51);
            this.radSearch_ShipmentNumber.Name = "radSearch_ShipmentNumber";
            this.radSearch_ShipmentNumber.Size = new System.Drawing.Size(133, 20);
            this.radSearch_ShipmentNumber.TabIndex = 1;
            this.radSearch_ShipmentNumber.TabStop = true;
            this.radSearch_ShipmentNumber.Text = "Shipment Number";
            this.radSearch_ShipmentNumber.UseVisualStyleBackColor = true;
            this.radSearch_ShipmentNumber.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // radSearch_DateRange
            // 
            this.radSearch_DateRange.AutoSize = true;
            this.radSearch_DateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_DateRange.Location = new System.Drawing.Point(27, 405);
            this.radSearch_DateRange.Name = "radSearch_DateRange";
            this.radSearch_DateRange.Size = new System.Drawing.Size(99, 20);
            this.radSearch_DateRange.TabIndex = 17;
            this.radSearch_DateRange.Text = "Date Range";
            this.radSearch_DateRange.UseVisualStyleBackColor = true;
            this.radSearch_DateRange.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // cmbSearch_Customer
            // 
            this.cmbSearch_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Customer.FormattingEnabled = true;
            this.cmbSearch_Customer.Location = new System.Drawing.Point(177, 227);
            this.cmbSearch_Customer.Name = "cmbSearch_Customer";
            this.cmbSearch_Customer.Size = new System.Drawing.Size(369, 24);
            this.cmbSearch_Customer.Sorted = true;
            this.cmbSearch_Customer.TabIndex = 12;
            this.cmbSearch_Customer.Visible = false;
            this.cmbSearch_Customer.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_Customer_SelectedIndexChanged);
            this.cmbSearch_Customer.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Customer.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // lblList_Search
            // 
            this.lblList_Search.AutoSize = true;
            this.lblList_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList_Search.Location = new System.Drawing.Point(6, 13);
            this.lblList_Search.Name = "lblList_Search";
            this.lblList_Search.Size = new System.Drawing.Size(72, 16);
            this.lblList_Search.TabIndex = 0;
            this.lblList_Search.Text = "Search by:";
            // 
            // radSearch_Asset
            // 
            this.radSearch_Asset.AutoSize = true;
            this.radSearch_Asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Asset.Location = new System.Drawing.Point(27, 168);
            this.radSearch_Asset.Name = "radSearch_Asset";
            this.radSearch_Asset.Size = new System.Drawing.Size(60, 20);
            this.radSearch_Asset.TabIndex = 7;
            this.radSearch_Asset.Text = "Asset";
            this.radSearch_Asset.UseVisualStyleBackColor = true;
            this.radSearch_Asset.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // radSearch_Customer
            // 
            this.radSearch_Customer.AutoSize = true;
            this.radSearch_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Customer.Location = new System.Drawing.Point(27, 228);
            this.radSearch_Customer.Name = "radSearch_Customer";
            this.radSearch_Customer.Size = new System.Drawing.Size(128, 20);
            this.radSearch_Customer.TabIndex = 11;
            this.radSearch_Customer.Text = "Customer/Market";
            this.radSearch_Customer.UseVisualStyleBackColor = true;
            this.radSearch_Customer.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // radSearch_RMANumber
            // 
            this.radSearch_RMANumber.AutoSize = true;
            this.radSearch_RMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_RMANumber.Location = new System.Drawing.Point(27, 108);
            this.radSearch_RMANumber.Name = "radSearch_RMANumber";
            this.radSearch_RMANumber.Size = new System.Drawing.Size(107, 20);
            this.radSearch_RMANumber.TabIndex = 5;
            this.radSearch_RMANumber.Text = "RMA Number";
            this.radSearch_RMANumber.UseVisualStyleBackColor = true;
            this.radSearch_RMANumber.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // radSearch_Tech
            // 
            this.radSearch_Tech.AutoSize = true;
            this.radSearch_Tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Tech.Location = new System.Drawing.Point(27, 198);
            this.radSearch_Tech.Name = "radSearch_Tech";
            this.radSearch_Tech.Size = new System.Drawing.Size(144, 20);
            this.radSearch_Tech.TabIndex = 9;
            this.radSearch_Tech.Text = "Tech/Subcontractor";
            this.radSearch_Tech.UseVisualStyleBackColor = true;
            this.radSearch_Tech.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.olvShippingResultsList);
            this.tabList.Controls.Add(this.pnlList_Control);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Size = new System.Drawing.Size(976, 706);
            this.tabList.TabIndex = 2;
            this.tabList.Text = "List/Results";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // olvShippingResultsList
            // 
            this.olvShippingResultsList.AllColumns.Add(this.olvColShipmentID);
            this.olvShippingResultsList.AllColumns.Add(this.olvColHasComputer);
            this.olvShippingResultsList.AllColumns.Add(this.olvColReadJournal);
            this.olvShippingResultsList.AllColumns.Add(this.olvColRequestDate);
            this.olvShippingResultsList.AllColumns.Add(this.olvColReadyDate);
            this.olvShippingResultsList.AllColumns.Add(this.olvColDestination);
            this.olvShippingResultsList.AllColumns.Add(this.olvColShipMethod);
            this.olvShippingResultsList.AllColumns.Add(this.olvColItems);
            this.olvShippingResultsList.AllColumns.Add(this.olvColPicked);
            this.olvShippingResultsList.AllColumns.Add(this.olvColShipped);
            this.olvShippingResultsList.AllColumns.Add(this.olvColTracking);
            this.olvShippingResultsList.AllowColumnReorder = true;
            this.olvShippingResultsList.CellEditUseWholeCell = false;
            this.olvShippingResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColShipmentID,
            this.olvColHasComputer,
            this.olvColReadJournal,
            this.olvColRequestDate,
            this.olvColReadyDate,
            this.olvColDestination,
            this.olvColShipMethod,
            this.olvColItems,
            this.olvColPicked,
            this.olvColShipped,
            this.olvColTracking});
            this.olvShippingResultsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvShippingResultsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvShippingResultsList.EmptyListMsg = "No shipments matching specified criteria.";
            this.olvShippingResultsList.FullRowSelect = true;
            this.olvShippingResultsList.GridLines = true;
            this.olvShippingResultsList.Location = new System.Drawing.Point(0, 30);
            this.olvShippingResultsList.MultiSelect = false;
            this.olvShippingResultsList.Name = "olvShippingResultsList";
            this.olvShippingResultsList.ShowGroups = false;
            this.olvShippingResultsList.Size = new System.Drawing.Size(976, 676);
            this.olvShippingResultsList.SmallImageList = this.imageList16x16;
            this.olvShippingResultsList.TabIndex = 3;
            this.olvShippingResultsList.UseCompatibleStateImageBehavior = false;
            this.olvShippingResultsList.UseFilterIndicator = true;
            this.olvShippingResultsList.UseFiltering = true;
            this.olvShippingResultsList.UseHyperlinks = true;
            this.olvShippingResultsList.View = System.Windows.Forms.View.Details;
            this.olvShippingResultsList.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvShippingResultsList_FormatRow);
            this.olvShippingResultsList.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.olvShippingResultsList_HyperlinkClicked);
            this.olvShippingResultsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvShippingResultsList_MouseDoubleClick);
            // 
            // olvColShipmentID
            // 
            this.olvColShipmentID.AspectName = "ID";
            this.olvColShipmentID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColShipmentID.Text = "#";
            this.olvColShipmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColShipmentID.UseFiltering = false;
            this.olvColShipmentID.Width = 50;
            // 
            // olvColHasComputer
            // 
            this.olvColHasComputer.AspectName = "HasComputer";
            this.olvColHasComputer.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColHasComputer.Searchable = false;
            this.olvColHasComputer.Text = "Comp";
            this.olvColHasComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColHasComputer.ToolTipText = "Contains an item requiring prep, such as a computer.";
            this.olvColHasComputer.Width = 40;
            // 
            // olvColReadJournal
            // 
            this.olvColReadJournal.AspectName = "HasNonSystemJournalEntries";
            this.olvColReadJournal.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColReadJournal.Searchable = false;
            this.olvColReadJournal.Text = "Jrnl";
            this.olvColReadJournal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColReadJournal.ToolTipText = "Has (non-system) journal entries or notes.";
            this.olvColReadJournal.Width = 40;
            // 
            // olvColRequestDate
            // 
            this.olvColRequestDate.AspectName = "Requested_Date";
            this.olvColRequestDate.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.olvColRequestDate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColRequestDate.Text = "Requested";
            this.olvColRequestDate.Width = 100;
            // 
            // olvColReadyDate
            // 
            this.olvColReadyDate.AspectName = "ReadyDate";
            this.olvColReadyDate.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.olvColReadyDate.Text = "Ready Date";
            this.olvColReadyDate.Width = 100;
            // 
            // olvColDestination
            // 
            this.olvColDestination.AspectName = "Destination.Company";
            this.olvColDestination.Text = "Destination";
            this.olvColDestination.Width = 140;
            // 
            // olvColShipMethod
            // 
            this.olvColShipMethod.AspectName = "ShipMethod_Name";
            this.olvColShipMethod.Text = "Method";
            this.olvColShipMethod.Width = 120;
            // 
            // olvColItems
            // 
            this.olvColItems.AspectName = "InventoryQty";
            this.olvColItems.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColItems.Text = "Items";
            this.olvColItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColItems.Width = 40;
            // 
            // olvColPicked
            // 
            this.olvColPicked.AspectName = "Picked_Date";
            this.olvColPicked.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.olvColPicked.Text = "Picked";
            this.olvColPicked.Width = 100;
            // 
            // olvColShipped
            // 
            this.olvColShipped.AspectName = "Fulfilled_Date";
            this.olvColShipped.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.olvColShipped.Text = "Shipped";
            this.olvColShipped.Width = 100;
            // 
            // olvColTracking
            // 
            this.olvColTracking.AspectName = "Tracking";
            this.olvColTracking.Hyperlink = true;
            this.olvColTracking.Text = "Tracking";
            this.olvColTracking.UseFiltering = false;
            this.olvColTracking.Width = 140;
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "computer");
            this.imageList16x16.Images.SetKeyName(1, "fire");
            this.imageList16x16.Images.SetKeyName(2, "star");
            this.imageList16x16.Images.SetKeyName(3, "flag");
            // 
            // pnlList_Control
            // 
            this.pnlList_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlList_Control.Controls.Add(this.btnExport);
            this.pnlList_Control.Controls.Add(this.btnCreate);
            this.pnlList_Control.Controls.Add(this.chkAutoRefresh);
            this.pnlList_Control.Controls.Add(this.radList_Picked);
            this.pnlList_Control.Controls.Add(this.radList_OnHold);
            this.pnlList_Control.Controls.Add(this.radList_Ready);
            this.pnlList_Control.Controls.Add(this.lblList_Show);
            this.pnlList_Control.Controls.Add(this.radList_Requested);
            this.pnlList_Control.Controls.Add(this.radList_Shipped);
            this.pnlList_Control.Controls.Add(this.txtShipmentsQty);
            this.pnlList_Control.Controls.Add(this.lblShipmentsQty);
            this.pnlList_Control.Controls.Add(this.radList_Deleted);
            this.pnlList_Control.Controls.Add(this.btnList_Refresh);
            this.pnlList_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlList_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlList_Control.Name = "pnlList_Control";
            this.pnlList_Control.Size = new System.Drawing.Size(976, 30);
            this.pnlList_Control.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.Location = new System.Drawing.Point(842, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(48, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkAutoRefresh
            // 
            this.chkAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoRefresh.AutoSize = true;
            this.chkAutoRefresh.Location = new System.Drawing.Point(607, 8);
            this.chkAutoRefresh.Name = "chkAutoRefresh";
            this.chkAutoRefresh.Size = new System.Drawing.Size(88, 17);
            this.chkAutoRefresh.TabIndex = 7;
            this.chkAutoRefresh.Text = "Auto Refresh";
            this.toolTip.SetToolTip(this.chkAutoRefresh, "Enables automatic refreshes every 5 minutes.");
            this.chkAutoRefresh.UseVisualStyleBackColor = true;
            this.chkAutoRefresh.CheckedChanged += new System.EventHandler(this.chkAutoRefresh_CheckedChanged);
            // 
            // radList_Picked
            // 
            this.radList_Picked.AutoCheck = false;
            this.radList_Picked.AutoSize = true;
            this.radList_Picked.BackColor = System.Drawing.Color.Transparent;
            this.radList_Picked.Location = new System.Drawing.Point(261, 7);
            this.radList_Picked.Name = "radList_Picked";
            this.radList_Picked.Size = new System.Drawing.Size(58, 17);
            this.radList_Picked.TabIndex = 4;
            this.radList_Picked.Text = "Picked";
            this.radList_Picked.UseVisualStyleBackColor = false;
            this.radList_Picked.Click += new System.EventHandler(this.radList_Picked_Click);
            // 
            // radList_OnHold
            // 
            this.radList_OnHold.AutoCheck = false;
            this.radList_OnHold.AutoSize = true;
            this.radList_OnHold.Location = new System.Drawing.Point(129, 7);
            this.radList_OnHold.Name = "radList_OnHold";
            this.radList_OnHold.Size = new System.Drawing.Size(64, 17);
            this.radList_OnHold.TabIndex = 2;
            this.radList_OnHold.TabStop = true;
            this.radList_OnHold.Text = "On Hold";
            this.radList_OnHold.UseVisualStyleBackColor = true;
            this.radList_OnHold.Click += new System.EventHandler(this.radList_OnHold_Click);
            // 
            // radList_Ready
            // 
            this.radList_Ready.AutoCheck = false;
            this.radList_Ready.AutoSize = true;
            this.radList_Ready.Location = new System.Drawing.Point(199, 7);
            this.radList_Ready.Name = "radList_Ready";
            this.radList_Ready.Size = new System.Drawing.Size(56, 17);
            this.radList_Ready.TabIndex = 3;
            this.radList_Ready.TabStop = true;
            this.radList_Ready.Text = "Ready";
            this.radList_Ready.UseVisualStyleBackColor = true;
            this.radList_Ready.Click += new System.EventHandler(this.radList_Ready_Click);
            // 
            // lblList_Show
            // 
            this.lblList_Show.AutoSize = true;
            this.lblList_Show.Location = new System.Drawing.Point(3, 9);
            this.lblList_Show.Name = "lblList_Show";
            this.lblList_Show.Size = new System.Drawing.Size(37, 13);
            this.lblList_Show.TabIndex = 0;
            this.lblList_Show.Text = "Show:";
            // 
            // radList_Requested
            // 
            this.radList_Requested.AutoCheck = false;
            this.radList_Requested.AutoSize = true;
            this.radList_Requested.BackColor = System.Drawing.Color.Transparent;
            this.radList_Requested.Checked = true;
            this.radList_Requested.Location = new System.Drawing.Point(46, 7);
            this.radList_Requested.Name = "radList_Requested";
            this.radList_Requested.Size = new System.Drawing.Size(77, 17);
            this.radList_Requested.TabIndex = 1;
            this.radList_Requested.TabStop = true;
            this.radList_Requested.Text = "Requested";
            this.radList_Requested.UseVisualStyleBackColor = false;
            this.radList_Requested.Click += new System.EventHandler(this.radList_Requested_Click);
            // 
            // radList_Shipped
            // 
            this.radList_Shipped.AutoCheck = false;
            this.radList_Shipped.AutoSize = true;
            this.radList_Shipped.BackColor = System.Drawing.Color.Transparent;
            this.radList_Shipped.Location = new System.Drawing.Point(325, 7);
            this.radList_Shipped.Name = "radList_Shipped";
            this.radList_Shipped.Size = new System.Drawing.Size(64, 17);
            this.radList_Shipped.TabIndex = 5;
            this.radList_Shipped.Text = "Shipped";
            this.radList_Shipped.UseVisualStyleBackColor = false;
            this.radList_Shipped.Click += new System.EventHandler(this.radList_Shipped_Click);
            // 
            // txtShipmentsQty
            // 
            this.txtShipmentsQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShipmentsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShipmentsQty.Location = new System.Drawing.Point(928, 4);
            this.txtShipmentsQty.Name = "txtShipmentsQty";
            this.txtShipmentsQty.ReadOnly = true;
            this.txtShipmentsQty.Size = new System.Drawing.Size(45, 22);
            this.txtShipmentsQty.TabIndex = 11;
            this.txtShipmentsQty.TabStop = false;
            this.txtShipmentsQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShipmentsQty
            // 
            this.lblShipmentsQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShipmentsQty.AutoSize = true;
            this.lblShipmentsQty.Location = new System.Drawing.Point(896, 9);
            this.lblShipmentsQty.Name = "lblShipmentsQty";
            this.lblShipmentsQty.Size = new System.Drawing.Size(26, 13);
            this.lblShipmentsQty.TabIndex = 10;
            this.lblShipmentsQty.Text = "Qty:";
            // 
            // radList_Deleted
            // 
            this.radList_Deleted.AutoCheck = false;
            this.radList_Deleted.AutoSize = true;
            this.radList_Deleted.Location = new System.Drawing.Point(395, 7);
            this.radList_Deleted.Name = "radList_Deleted";
            this.radList_Deleted.Size = new System.Drawing.Size(62, 17);
            this.radList_Deleted.TabIndex = 6;
            this.radList_Deleted.TabStop = true;
            this.radList_Deleted.Text = "Deleted";
            this.radList_Deleted.UseVisualStyleBackColor = true;
            this.radList_Deleted.Click += new System.EventHandler(this.radList_Deleted_Click);
            // 
            // btnList_Refresh
            // 
            this.btnList_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList_Refresh.Location = new System.Drawing.Point(782, 4);
            this.btnList_Refresh.Name = "btnList_Refresh";
            this.btnList_Refresh.Size = new System.Drawing.Size(54, 23);
            this.btnList_Refresh.TabIndex = 8;
            this.btnList_Refresh.Text = "Refresh";
            this.btnList_Refresh.UseVisualStyleBackColor = true;
            this.btnList_Refresh.Click += new System.EventHandler(this.btnList_Refresh_Click);
            // 
            // pnlControl_Bottom
            // 
            this.pnlControl_Bottom.BackColor = System.Drawing.Color.Silver;
            this.pnlControl_Bottom.Controls.Add(this.pnlPagination);
            this.pnlControl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl_Bottom.Location = new System.Drawing.Point(0, 732);
            this.pnlControl_Bottom.Name = "pnlControl_Bottom";
            this.pnlControl_Bottom.Size = new System.Drawing.Size(984, 30);
            this.pnlControl_Bottom.TabIndex = 3;
            // 
            // pnlPagination
            // 
            this.pnlPagination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlPagination.Controls.Add(this.lblPageMax);
            this.pnlPagination.Controls.Add(this.lblPage);
            this.pnlPagination.Controls.Add(this.cmbPage);
            this.pnlPagination.Controls.Add(this.btnLast);
            this.pnlPagination.Controls.Add(this.btnNext);
            this.pnlPagination.Controls.Add(this.btnFirst);
            this.pnlPagination.Controls.Add(this.btnPrevious);
            this.pnlPagination.Location = new System.Drawing.Point(292, -1);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(400, 33);
            this.pnlPagination.TabIndex = 14;
            this.pnlPagination.Visible = false;
            // 
            // lblPageMax
            // 
            this.lblPageMax.AutoSize = true;
            this.lblPageMax.Location = new System.Drawing.Point(235, 10);
            this.lblPageMax.Name = "lblPageMax";
            this.lblPageMax.Size = new System.Drawing.Size(25, 13);
            this.lblPageMax.TabIndex = 15;
            this.lblPageMax.Text = "of 0";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(141, 10);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(32, 13);
            this.lblPage.TabIndex = 14;
            this.lblPage.Text = "Page";
            // 
            // cmbPage
            // 
            this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPage.FormattingEnabled = true;
            this.cmbPage.Location = new System.Drawing.Point(179, 7);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(50, 21);
            this.cmbPage.TabIndex = 13;
            this.cmbPage.SelectedIndexChanged += new System.EventHandler(this.cmbPage_SelectedIndexChanged);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLast.Location = new System.Drawing.Point(347, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(289, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFirst.Location = new System.Drawing.Point(5, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 23);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.Location = new System.Drawing.Point(63, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // timerAutoRefresh
            // 
            this.timerAutoRefresh.Interval = 300000;
            this.timerAutoRefresh.Tick += new System.EventHandler(this.timerAutoRefresh_Tick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(701, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormShipment_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.tabShipping);
            this.Controls.Add(this.pnlControl_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 2000);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FormShipment_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shipment List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShipment_List_FormClosing);
            this.Load += new System.EventHandler(this.FormShipment_List_Load);
            this.Shown += new System.EventHandler(this.FormShipment_List_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormShipment_List_KeyDown);
            this.tabShipping.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.pnlSearch_DateRange.ResumeLayout(false);
            this.pnlSearch_DateRange.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvShippingResultsList)).EndInit();
            this.pnlList_Control.ResumeLayout(false);
            this.pnlList_Control.PerformLayout();
            this.pnlControl_Bottom.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabShipping;
		private System.Windows.Forms.TabPage tabList;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel pnlList_Control;
		private System.Windows.Forms.RadioButton radList_Shipped;
		private System.Windows.Forms.RadioButton radList_Requested;
		private System.Windows.Forms.Label lblList_Show;
		private System.Windows.Forms.TabPage tabSearch;
		private System.Windows.Forms.Label lblList_Search;
		private System.Windows.Forms.RadioButton radSearch_Asset;
		private System.Windows.Forms.RadioButton radSearch_RMANumber;
		private System.Windows.Forms.RadioButton radSearch_Customer;
		private System.Windows.Forms.RadioButton radSearch_Tech;
		private System.Windows.Forms.DateTimePicker dtpSearch_To;
		private System.Windows.Forms.Label lblSearch_DateRangeThrough;
		private System.Windows.Forms.RadioButton radSearch_ShipmentNumber;
		private System.Windows.Forms.RadioButton radSearch_DateRange;
		private System.Windows.Forms.DateTimePicker dtpSearch_From;
		private System.Windows.Forms.ComboBox cmbSearch_Customer;
		private System.Windows.Forms.RadioButton radSearch_JobNumber;
		private System.Windows.Forms.TextBox txtSearch_RMANumber;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlSearch_DateRange;
		private System.Windows.Forms.TextBox txtSearch_JobNumber;
		private System.Windows.Forms.TextBox txtSearch_Shipment;
		private System.Windows.Forms.ComboBox cmbSearch_Asset;
		private System.Windows.Forms.ComboBox cmbSearch_Tech;
		private System.Windows.Forms.ComboBox cmbSearch_Market;
		private BrightIdeasSoftware.ObjectListView olvShippingResultsList;
		private BrightIdeasSoftware.OLVColumn olvColShipmentID;
		private BrightIdeasSoftware.OLVColumn olvColRequestDate;
		private BrightIdeasSoftware.OLVColumn olvColShipMethod;
		private BrightIdeasSoftware.OLVColumn olvColItems;
		private BrightIdeasSoftware.OLVColumn olvColPicked;
		private BrightIdeasSoftware.OLVColumn olvColShipped;
		private BrightIdeasSoftware.OLVColumn olvColDestination;
		private System.Windows.Forms.TextBox txtShipmentsQty;
		private System.Windows.Forms.Label lblShipmentsQty;
		private System.Windows.Forms.Panel pnlControl_Bottom;
		private BrightIdeasSoftware.OLVColumn olvColTracking;
		private System.Windows.Forms.CheckBox chkSearch_AllMarkets;
		private System.Windows.Forms.CheckBox chkDateRange_Shipped;
		private System.Windows.Forms.CheckBox chkDateRange_Requested;
		private System.Windows.Forms.TextBox txtSearch_Other;
		private System.Windows.Forms.RadioButton radSearch_Other;
		private System.Windows.Forms.ComboBox cmbSearch_AssemblyType;
		private System.Windows.Forms.RadioButton radSearch_AssemblyType;
		private BrightIdeasSoftware.OLVColumn olvColHasComputer;
		private System.Windows.Forms.RadioButton radList_Deleted;
		private System.Windows.Forms.RadioButton radList_Ready;
		private System.Windows.Forms.Button btnList_Refresh;
		private System.Windows.Forms.RadioButton radList_OnHold;
		private System.Windows.Forms.RadioButton radList_Picked;
		private System.Windows.Forms.CheckBox chkAutoRefresh;
		private System.Windows.Forms.Timer timerAutoRefresh;
		private BrightIdeasSoftware.OLVColumn olvColReadJournal;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ImageList imageList16x16;
		private BrightIdeasSoftware.OLVColumn olvColReadyDate;
		private System.Windows.Forms.Panel pnlPagination;
		private System.Windows.Forms.Label lblPageMax;
		private System.Windows.Forms.Label lblPage;
		private System.Windows.Forms.ComboBox cmbPage;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnExport;
    }
}