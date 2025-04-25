namespace SDB.Forms.RMA
{
	partial class FormRMA_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMA_List));
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
            this.olvColRMAList_MostRecentRepairUser = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Completed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_Finalized = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_PendingReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMAList_PendingType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlViewControl = new System.Windows.Forms.Panel();
            this.radRMAList_Unshipped = new System.Windows.Forms.RadioButton();
            this.radRMAList_Deleted = new System.Windows.Forms.RadioButton();
            this.radRMAList_Expired = new System.Windows.Forms.RadioButton();
            this.radRMAList_UnshippedAPR = new System.Windows.Forms.RadioButton();
            this.radRMAList_Pending = new System.Windows.Forms.RadioButton();
            this.radRMAList_InProgress = new System.Windows.Forms.RadioButton();
            this.radRMAList_Received = new System.Windows.Forms.RadioButton();
            this.lblRMAList_View = new System.Windows.Forms.Label();
            this.radRMAList_Review = new System.Windows.Forms.RadioButton();
            this.radRMAList_Unreceived = new System.Windows.Forms.RadioButton();
            this.radRMAList_Closed = new System.Windows.Forms.RadioButton();
            this.txtRMAList_Qty = new System.Windows.Forms.TextBox();
            this.lblRMAList_Qty = new System.Windows.Forms.Label();
            this.tabControlRMA = new System.Windows.Forms.TabControl();
            this.tabRMA_Search = new System.Windows.Forms.TabPage();
            this.pnlRMA_Search = new System.Windows.Forms.Panel();
            this.chkIncludeDeleted = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearch_AssemblyType = new System.Windows.Forms.ComboBox();
            this.radSearch_AssemblyType = new System.Windows.Forms.RadioButton();
            this.lblSearch_AssemblyType = new System.Windows.Forms.Label();
            this.lblSearch_Search = new System.Windows.Forms.Label();
            this.chkSearch_AllMarkets = new System.Windows.Forms.CheckBox();
            this.radSearch_Tech = new System.Windows.Forms.RadioButton();
            this.lblSearch_Issued = new System.Windows.Forms.Label();
            this.radSearch_RMANumber = new System.Windows.Forms.RadioButton();
            this.lblSearch_AssignedTo = new System.Windows.Forms.Label();
            this.radSearch_Customer = new System.Windows.Forms.RadioButton();
            this.cmbSearch_Market = new System.Windows.Forms.ComboBox();
            this.radSearch_Asset = new System.Windows.Forms.RadioButton();
            this.cmbSearch_Asset = new System.Windows.Forms.ComboBox();
            this.cmbSearch_Customer = new System.Windows.Forms.ComboBox();
            this.cmbSearch_Tech = new System.Windows.Forms.ComboBox();
            this.radSearch_DateRange = new System.Windows.Forms.RadioButton();
            this.txtSearch_Ticket = new System.Windows.Forms.TextBox();
            this.txtSearch_RMANumber = new System.Windows.Forms.TextBox();
            this.pnlSearch_DateRange = new System.Windows.Forms.Panel();
            this.dtpSearch_From = new System.Windows.Forms.DateTimePicker();
            this.lblSearch_DateRangeThrough = new System.Windows.Forms.Label();
            this.dtpSearch_To = new System.Windows.Forms.DateTimePicker();
            this.radSearch_Ticket = new System.Windows.Forms.RadioButton();
            this.tabRMA_List = new System.Windows.Forms.TabPage();
            this.btnCreateNewRMA = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbPage = new System.Windows.Forms.ComboBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.pnlTopControls = new System.Windows.Forms.Panel();
            this.flpRmaKey = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottomControls = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPageMax = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvRMAList)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlViewControl.SuspendLayout();
            this.tabControlRMA.SuspendLayout();
            this.tabRMA_Search.SuspendLayout();
            this.pnlRMA_Search.SuspendLayout();
            this.pnlSearch_DateRange.SuspendLayout();
            this.tabRMA_List.SuspendLayout();
            this.pnlTopControls.SuspendLayout();
            this.pnlBottomControls.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();
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
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_MostRecentRepairUser);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Completed);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_Finalized);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_PendingReason);
            this.olvRMAList.AllColumns.Add(this.olvColRMAList_PendingType);
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
            this.olvRMAList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRMAList.EmptyListMsg = "No RMAs matching specified critera";
            this.olvRMAList.FullRowSelect = true;
            this.olvRMAList.GridLines = true;
            this.olvRMAList.HasCollapsibleGroups = false;
            this.olvRMAList.Location = new System.Drawing.Point(3, 33);
            this.olvRMAList.MultiSelect = false;
            this.olvRMAList.Name = "olvRMAList";
            this.olvRMAList.SelectAllOnControlA = false;
            this.olvRMAList.ShowCommandMenuOnRightClick = true;
            this.olvRMAList.ShowFilterMenuOnRightClick = false;
            this.olvRMAList.ShowGroups = false;
            this.olvRMAList.ShowImagesOnSubItems = true;
            this.olvRMAList.Size = new System.Drawing.Size(1075, 527);
            this.olvRMAList.SmallImageList = this.imageList16x16;
            this.olvRMAList.TabIndex = 0;
            this.olvRMAList.UseCompatibleStateImageBehavior = false;
            this.olvRMAList.UseSubItemCheckBoxes = true;
            this.olvRMAList.View = System.Windows.Forms.View.Details;
            this.olvRMAList.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvRMAList_CellToolTipShowing);
            this.olvRMAList.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvRMAList_FormatRow);
            this.olvRMAList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvRMAList_MouseDoubleClick);
            // 
            // olvColRMAList_Number
            // 
            this.olvColRMAList_Number.AspectName = "ID";
            this.olvColRMAList_Number.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColRMAList_Number.Text = "RMA";
            this.olvColRMAList_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.olvColRMAList_HasNonSystemJournalEntries.Width = 40;
            // 
            // olvColRMAList_Created
            // 
            this.olvColRMAList_Created.AspectName = "Creation_Date";
            this.olvColRMAList_Created.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMAList_Created.IsEditable = false;
            this.olvColRMAList_Created.Text = "Created";
            this.olvColRMAList_Created.Width = 70;
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
            // olvColRMAList_MostRecentRepairUser
            // 
            this.olvColRMAList_MostRecentRepairUser.AspectName = "MostRecentRepair_UserName";
            this.olvColRMAList_MostRecentRepairUser.DisplayIndex = 12;
            this.olvColRMAList_MostRecentRepairUser.IsVisible = false;
            this.olvColRMAList_MostRecentRepairUser.Text = "Last Repaired By";
            this.olvColRMAList_MostRecentRepairUser.ToolTipText = "Last Repaired By";
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
            // olvColRMAList_PendingReason
            // 
            this.olvColRMAList_PendingReason.AspectName = "Pending_Reason";
            this.olvColRMAList_PendingReason.IsVisible = false;
            this.olvColRMAList_PendingReason.Text = "Pending Reason";
            this.olvColRMAList_PendingReason.Width = 200;
            // 
            // olvColRMAList_PendingType
            // 
            this.olvColRMAList_PendingType.AspectName = "Pending_Type";
            this.olvColRMAList_PendingType.IsVisible = false;
            this.olvColRMAList_PendingType.Text = "Pending Type";
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "fire");
            this.imageList16x16.Images.SetKeyName(1, "star");
            this.imageList16x16.Images.SetKeyName(2, "computer");
            this.imageList16x16.Images.SetKeyName(3, "flag");
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlControl.Controls.Add(this.btnExport);
            this.pnlControl.Controls.Add(this.pnlViewControl);
            this.pnlControl.Controls.Add(this.txtRMAList_Qty);
            this.pnlControl.Controls.Add(this.lblRMAList_Qty);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(3, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1075, 30);
            this.pnlControl.TabIndex = 1;
            // 
            // pnlViewControl
            // 
            this.pnlViewControl.Controls.Add(this.radRMAList_Unshipped);
            this.pnlViewControl.Controls.Add(this.radRMAList_Deleted);
            this.pnlViewControl.Controls.Add(this.radRMAList_Expired);
            this.pnlViewControl.Controls.Add(this.radRMAList_UnshippedAPR);
            this.pnlViewControl.Controls.Add(this.radRMAList_Pending);
            this.pnlViewControl.Controls.Add(this.radRMAList_InProgress);
            this.pnlViewControl.Controls.Add(this.radRMAList_Received);
            this.pnlViewControl.Controls.Add(this.lblRMAList_View);
            this.pnlViewControl.Controls.Add(this.radRMAList_Review);
            this.pnlViewControl.Controls.Add(this.radRMAList_Unreceived);
            this.pnlViewControl.Controls.Add(this.radRMAList_Closed);
            this.pnlViewControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlViewControl.Location = new System.Drawing.Point(0, 0);
            this.pnlViewControl.Name = "pnlViewControl";
            this.pnlViewControl.Size = new System.Drawing.Size(816, 30);
            this.pnlViewControl.TabIndex = 7;
            // 
            // radRMAList_Unshipped
            // 
            this.radRMAList_Unshipped.AutoCheck = false;
            this.radRMAList_Unshipped.AutoSize = true;
            this.radRMAList_Unshipped.Location = new System.Drawing.Point(542, 7);
            this.radRMAList_Unshipped.Name = "radRMAList_Unshipped";
            this.radRMAList_Unshipped.Size = new System.Drawing.Size(76, 17);
            this.radRMAList_Unshipped.TabIndex = 13;
            this.radRMAList_Unshipped.Text = "Unshipped";
            this.toolTip.SetToolTip(this.radRMAList_Unshipped, "Show finalized, but unshipped RMAs.");
            this.radRMAList_Unshipped.UseVisualStyleBackColor = true;
            this.radRMAList_Unshipped.Click += new System.EventHandler(this.radRMAList_Unshipped_Click);
            // 
            // radRMAList_Deleted
            // 
            this.radRMAList_Deleted.AutoCheck = false;
            this.radRMAList_Deleted.AutoSize = true;
            this.radRMAList_Deleted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radRMAList_Deleted.Location = new System.Drawing.Point(751, 7);
            this.radRMAList_Deleted.Name = "radRMAList_Deleted";
            this.radRMAList_Deleted.Size = new System.Drawing.Size(62, 17);
            this.radRMAList_Deleted.TabIndex = 12;
            this.radRMAList_Deleted.Text = "Deleted";
            this.toolTip.SetToolTip(this.radRMAList_Deleted, "Show deleted RMAs.");
            this.radRMAList_Deleted.UseVisualStyleBackColor = true;
            this.radRMAList_Deleted.Click += new System.EventHandler(this.radRMAList_Deleted_Click);
            // 
            // radRMAList_Expired
            // 
            this.radRMAList_Expired.AutoCheck = false;
            this.radRMAList_Expired.AutoSize = true;
            this.radRMAList_Expired.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radRMAList_Expired.Location = new System.Drawing.Point(685, 7);
            this.radRMAList_Expired.Name = "radRMAList_Expired";
            this.radRMAList_Expired.Size = new System.Drawing.Size(60, 17);
            this.radRMAList_Expired.TabIndex = 11;
            this.radRMAList_Expired.Text = "Expired";
            this.toolTip.SetToolTip(this.radRMAList_Expired, "Show expired (unreceived after 90 days) RMAs.");
            this.radRMAList_Expired.UseVisualStyleBackColor = true;
            this.radRMAList_Expired.Click += new System.EventHandler(this.radRMAList_Expired_Click);
            // 
            // radRMAList_UnshippedAPR
            // 
            this.radRMAList_UnshippedAPR.AutoCheck = false;
            this.radRMAList_UnshippedAPR.AutoSize = true;
            this.radRMAList_UnshippedAPR.Location = new System.Drawing.Point(137, 7);
            this.radRMAList_UnshippedAPR.Name = "radRMAList_UnshippedAPR";
            this.radRMAList_UnshippedAPR.Size = new System.Drawing.Size(101, 17);
            this.radRMAList_UnshippedAPR.TabIndex = 10;
            this.radRMAList_UnshippedAPR.Text = "Unshipped APR";
            this.toolTip.SetToolTip(this.radRMAList_UnshippedAPR, "Show RMAs which are Advanced Parts Request, but do not yet have at least one ship" +
        "ment.");
            this.radRMAList_UnshippedAPR.UseVisualStyleBackColor = true;
            this.radRMAList_UnshippedAPR.Click += new System.EventHandler(this.radRMAList_UnshippedAPR_Click);
            // 
            // radRMAList_Pending
            // 
            this.radRMAList_Pending.AutoCheck = false;
            this.radRMAList_Pending.AutoSize = true;
            this.radRMAList_Pending.Location = new System.Drawing.Point(405, 7);
            this.radRMAList_Pending.Name = "radRMAList_Pending";
            this.radRMAList_Pending.Size = new System.Drawing.Size(64, 17);
            this.radRMAList_Pending.TabIndex = 9;
            this.radRMAList_Pending.Text = "Pending";
            this.toolTip.SetToolTip(this.radRMAList_Pending, "Show RMAs which cannot be completed yet.");
            this.radRMAList_Pending.UseVisualStyleBackColor = true;
            this.radRMAList_Pending.Click += new System.EventHandler(this.radRMAList_Pending_Click);
            // 
            // radRMAList_InProgress
            // 
            this.radRMAList_InProgress.AutoCheck = false;
            this.radRMAList_InProgress.AutoSize = true;
            this.radRMAList_InProgress.Location = new System.Drawing.Point(321, 7);
            this.radRMAList_InProgress.Name = "radRMAList_InProgress";
            this.radRMAList_InProgress.Size = new System.Drawing.Size(78, 17);
            this.radRMAList_InProgress.TabIndex = 8;
            this.radRMAList_InProgress.Text = "In Progress";
            this.toolTip.SetToolTip(this.radRMAList_InProgress, "Show RMAs for which repairs have started on at least one assembly.");
            this.radRMAList_InProgress.UseVisualStyleBackColor = true;
            this.radRMAList_InProgress.Click += new System.EventHandler(this.radRMAList_InProgress_Click);
            // 
            // radRMAList_Received
            // 
            this.radRMAList_Received.AutoCheck = false;
            this.radRMAList_Received.AutoSize = true;
            this.radRMAList_Received.Location = new System.Drawing.Point(244, 7);
            this.radRMAList_Received.Name = "radRMAList_Received";
            this.radRMAList_Received.Size = new System.Drawing.Size(71, 17);
            this.radRMAList_Received.TabIndex = 7;
            this.radRMAList_Received.Text = "Received";
            this.toolTip.SetToolTip(this.radRMAList_Received, "Show RMAs for which at least one assembly has been received.");
            this.radRMAList_Received.UseVisualStyleBackColor = true;
            this.radRMAList_Received.Click += new System.EventHandler(this.radRMAList_Received_Click);
            // 
            // lblRMAList_View
            // 
            this.lblRMAList_View.AutoSize = true;
            this.lblRMAList_View.Location = new System.Drawing.Point(12, 9);
            this.lblRMAList_View.Name = "lblRMAList_View";
            this.lblRMAList_View.Size = new System.Drawing.Size(33, 13);
            this.lblRMAList_View.TabIndex = 2;
            this.lblRMAList_View.Text = "View:";
            // 
            // radRMAList_Review
            // 
            this.radRMAList_Review.AutoCheck = false;
            this.radRMAList_Review.AutoSize = true;
            this.radRMAList_Review.Location = new System.Drawing.Point(475, 7);
            this.radRMAList_Review.Name = "radRMAList_Review";
            this.radRMAList_Review.Size = new System.Drawing.Size(61, 17);
            this.radRMAList_Review.TabIndex = 6;
            this.radRMAList_Review.Text = "Review";
            this.toolTip.SetToolTip(this.radRMAList_Review, "Show RMAs that require root-cause assignment but are otherwise completed.");
            this.radRMAList_Review.UseVisualStyleBackColor = true;
            this.radRMAList_Review.Click += new System.EventHandler(this.radRMAList_Review_Click);
            // 
            // radRMAList_Unreceived
            // 
            this.radRMAList_Unreceived.AutoCheck = false;
            this.radRMAList_Unreceived.AutoSize = true;
            this.radRMAList_Unreceived.Location = new System.Drawing.Point(51, 7);
            this.radRMAList_Unreceived.Name = "radRMAList_Unreceived";
            this.radRMAList_Unreceived.Size = new System.Drawing.Size(80, 17);
            this.radRMAList_Unreceived.TabIndex = 1;
            this.radRMAList_Unreceived.Text = "Unreceived";
            this.toolTip.SetToolTip(this.radRMAList_Unreceived, "Show RMAs for which no assemblies have been received. (Or repairs are completed s" +
        "o far, but more assemblies are yet to be received.)");
            this.radRMAList_Unreceived.UseVisualStyleBackColor = true;
            this.radRMAList_Unreceived.Click += new System.EventHandler(this.radRMAList_Unreceived_Click);
            // 
            // radRMAList_Closed
            // 
            this.radRMAList_Closed.AutoCheck = false;
            this.radRMAList_Closed.AutoSize = true;
            this.radRMAList_Closed.Location = new System.Drawing.Point(622, 7);
            this.radRMAList_Closed.Name = "radRMAList_Closed";
            this.radRMAList_Closed.Size = new System.Drawing.Size(57, 17);
            this.radRMAList_Closed.TabIndex = 3;
            this.radRMAList_Closed.Text = "Closed";
            this.toolTip.SetToolTip(this.radRMAList_Closed, "Show closed (finalized) RMAs that have shipped.");
            this.radRMAList_Closed.UseVisualStyleBackColor = true;
            this.radRMAList_Closed.Click += new System.EventHandler(this.radRMAList_Closed_Click);
            // 
            // txtRMAList_Qty
            // 
            this.txtRMAList_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRMAList_Qty.Location = new System.Drawing.Point(1030, 5);
            this.txtRMAList_Qty.Name = "txtRMAList_Qty";
            this.txtRMAList_Qty.ReadOnly = true;
            this.txtRMAList_Qty.Size = new System.Drawing.Size(42, 20);
            this.txtRMAList_Qty.TabIndex = 5;
            this.txtRMAList_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRMAList_Qty
            // 
            this.lblRMAList_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRMAList_Qty.AutoSize = true;
            this.lblRMAList_Qty.Location = new System.Drawing.Point(985, 9);
            this.lblRMAList_Qty.Name = "lblRMAList_Qty";
            this.lblRMAList_Qty.Size = new System.Drawing.Size(39, 13);
            this.lblRMAList_Qty.TabIndex = 4;
            this.lblRMAList_Qty.Text = "RMAs:";
            // 
            // tabControlRMA
            // 
            this.tabControlRMA.Controls.Add(this.tabRMA_Search);
            this.tabControlRMA.Controls.Add(this.tabRMA_List);
            this.tabControlRMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRMA.Location = new System.Drawing.Point(0, 33);
            this.tabControlRMA.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlRMA.Name = "tabControlRMA";
            this.tabControlRMA.SelectedIndex = 0;
            this.tabControlRMA.Size = new System.Drawing.Size(1089, 589);
            this.tabControlRMA.TabIndex = 0;
            this.tabControlRMA.SelectedIndexChanged += new System.EventHandler(this.tabControlRMA_SelectedIndexChanged);
            // 
            // tabRMA_Search
            // 
            this.tabRMA_Search.Controls.Add(this.pnlRMA_Search);
            this.tabRMA_Search.Location = new System.Drawing.Point(4, 22);
            this.tabRMA_Search.Name = "tabRMA_Search";
            this.tabRMA_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMA_Search.Size = new System.Drawing.Size(936, 563);
            this.tabRMA_Search.TabIndex = 0;
            this.tabRMA_Search.Text = "Search";
            this.tabRMA_Search.UseVisualStyleBackColor = true;
            // 
            // pnlRMA_Search
            // 
            this.pnlRMA_Search.Controls.Add(this.chkIncludeDeleted);
            this.pnlRMA_Search.Controls.Add(this.btnSearch);
            this.pnlRMA_Search.Controls.Add(this.cmbSearch_AssemblyType);
            this.pnlRMA_Search.Controls.Add(this.radSearch_AssemblyType);
            this.pnlRMA_Search.Controls.Add(this.lblSearch_AssemblyType);
            this.pnlRMA_Search.Controls.Add(this.lblSearch_Search);
            this.pnlRMA_Search.Controls.Add(this.chkSearch_AllMarkets);
            this.pnlRMA_Search.Controls.Add(this.radSearch_Tech);
            this.pnlRMA_Search.Controls.Add(this.lblSearch_Issued);
            this.pnlRMA_Search.Controls.Add(this.radSearch_RMANumber);
            this.pnlRMA_Search.Controls.Add(this.lblSearch_AssignedTo);
            this.pnlRMA_Search.Controls.Add(this.radSearch_Customer);
            this.pnlRMA_Search.Controls.Add(this.cmbSearch_Market);
            this.pnlRMA_Search.Controls.Add(this.radSearch_Asset);
            this.pnlRMA_Search.Controls.Add(this.cmbSearch_Asset);
            this.pnlRMA_Search.Controls.Add(this.cmbSearch_Customer);
            this.pnlRMA_Search.Controls.Add(this.cmbSearch_Tech);
            this.pnlRMA_Search.Controls.Add(this.radSearch_DateRange);
            this.pnlRMA_Search.Controls.Add(this.txtSearch_Ticket);
            this.pnlRMA_Search.Controls.Add(this.txtSearch_RMANumber);
            this.pnlRMA_Search.Controls.Add(this.pnlSearch_DateRange);
            this.pnlRMA_Search.Controls.Add(this.radSearch_Ticket);
            this.pnlRMA_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRMA_Search.Location = new System.Drawing.Point(3, 3);
            this.pnlRMA_Search.Name = "pnlRMA_Search";
            this.pnlRMA_Search.Size = new System.Drawing.Size(930, 557);
            this.pnlRMA_Search.TabIndex = 1;
            // 
            // chkIncludeDeleted
            // 
            this.chkIncludeDeleted.AutoSize = true;
            this.chkIncludeDeleted.Location = new System.Drawing.Point(13, 502);
            this.chkIncludeDeleted.Name = "chkIncludeDeleted";
            this.chkIncludeDeleted.Size = new System.Drawing.Size(101, 17);
            this.chkIncludeDeleted.TabIndex = 20;
            this.chkIncludeDeleted.Text = "Include Deleted";
            this.chkIncludeDeleted.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(815, 496);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 45);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearch_AssemblyType
            // 
            this.cmbSearch_AssemblyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_AssemblyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_AssemblyType.FormattingEnabled = true;
            this.cmbSearch_AssemblyType.Location = new System.Drawing.Point(170, 315);
            this.cmbSearch_AssemblyType.Name = "cmbSearch_AssemblyType";
            this.cmbSearch_AssemblyType.Size = new System.Drawing.Size(308, 24);
            this.cmbSearch_AssemblyType.Sorted = true;
            this.cmbSearch_AssemblyType.TabIndex = 16;
            this.cmbSearch_AssemblyType.Visible = false;
            // 
            // radSearch_AssemblyType
            // 
            this.radSearch_AssemblyType.AutoSize = true;
            this.radSearch_AssemblyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_AssemblyType.Location = new System.Drawing.Point(22, 316);
            this.radSearch_AssemblyType.Name = "radSearch_AssemblyType";
            this.radSearch_AssemblyType.Size = new System.Drawing.Size(121, 20);
            this.radSearch_AssemblyType.TabIndex = 15;
            this.radSearch_AssemblyType.Text = "Assembly Type";
            this.radSearch_AssemblyType.UseVisualStyleBackColor = true;
            // 
            // lblSearch_AssemblyType
            // 
            this.lblSearch_AssemblyType.AutoSize = true;
            this.lblSearch_AssemblyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_AssemblyType.Location = new System.Drawing.Point(10, 291);
            this.lblSearch_AssemblyType.Name = "lblSearch_AssemblyType";
            this.lblSearch_AssemblyType.Size = new System.Drawing.Size(161, 16);
            this.lblSearch_AssemblyType.TabIndex = 14;
            this.lblSearch_AssemblyType.Text = "Contains Assembly Type:";
            // 
            // lblSearch_Search
            // 
            this.lblSearch_Search.AutoSize = true;
            this.lblSearch_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_Search.Location = new System.Drawing.Point(3, 9);
            this.lblSearch_Search.Name = "lblSearch_Search";
            this.lblSearch_Search.Size = new System.Drawing.Size(72, 16);
            this.lblSearch_Search.TabIndex = 0;
            this.lblSearch_Search.Text = "Search by:";
            // 
            // chkSearch_AllMarkets
            // 
            this.chkSearch_AllMarkets.AutoSize = true;
            this.chkSearch_AllMarkets.Location = new System.Drawing.Point(486, 215);
            this.chkSearch_AllMarkets.Name = "chkSearch_AllMarkets";
            this.chkSearch_AllMarkets.Size = new System.Drawing.Size(78, 17);
            this.chkSearch_AllMarkets.TabIndex = 12;
            this.chkSearch_AllMarkets.Text = "All Markets";
            this.chkSearch_AllMarkets.UseVisualStyleBackColor = true;
            this.chkSearch_AllMarkets.Visible = false;
            this.chkSearch_AllMarkets.CheckedChanged += new System.EventHandler(this.chkSearch_AllMarkets_CheckedChanged);
            // 
            // radSearch_Tech
            // 
            this.radSearch_Tech.AutoSize = true;
            this.radSearch_Tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Tech.Location = new System.Drawing.Point(22, 182);
            this.radSearch_Tech.Name = "radSearch_Tech";
            this.radSearch_Tech.Size = new System.Drawing.Size(144, 20);
            this.radSearch_Tech.TabIndex = 8;
            this.radSearch_Tech.Text = "Tech/Subcontractor";
            this.radSearch_Tech.UseVisualStyleBackColor = true;
            this.radSearch_Tech.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // lblSearch_Issued
            // 
            this.lblSearch_Issued.AutoSize = true;
            this.lblSearch_Issued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_Issued.Location = new System.Drawing.Point(10, 370);
            this.lblSearch_Issued.Name = "lblSearch_Issued";
            this.lblSearch_Issued.Size = new System.Drawing.Size(51, 16);
            this.lblSearch_Issued.TabIndex = 17;
            this.lblSearch_Issued.Text = "Issued:";
            // 
            // radSearch_RMANumber
            // 
            this.radSearch_RMANumber.AutoSize = true;
            this.radSearch_RMANumber.Checked = true;
            this.radSearch_RMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_RMANumber.Location = new System.Drawing.Point(22, 36);
            this.radSearch_RMANumber.Name = "radSearch_RMANumber";
            this.radSearch_RMANumber.Size = new System.Drawing.Size(107, 20);
            this.radSearch_RMANumber.TabIndex = 1;
            this.radSearch_RMANumber.TabStop = true;
            this.radSearch_RMANumber.Text = "RMA Number";
            this.radSearch_RMANumber.UseVisualStyleBackColor = true;
            this.radSearch_RMANumber.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // lblSearch_AssignedTo
            // 
            this.lblSearch_AssignedTo.AutoSize = true;
            this.lblSearch_AssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_AssignedTo.Location = new System.Drawing.Point(10, 148);
            this.lblSearch_AssignedTo.Name = "lblSearch_AssignedTo";
            this.lblSearch_AssignedTo.Size = new System.Drawing.Size(82, 16);
            this.lblSearch_AssignedTo.TabIndex = 7;
            this.lblSearch_AssignedTo.Text = "Assigned to:";
            // 
            // radSearch_Customer
            // 
            this.radSearch_Customer.AutoSize = true;
            this.radSearch_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Customer.Location = new System.Drawing.Point(22, 212);
            this.radSearch_Customer.Name = "radSearch_Customer";
            this.radSearch_Customer.Size = new System.Drawing.Size(128, 20);
            this.radSearch_Customer.TabIndex = 10;
            this.radSearch_Customer.Text = "Customer/Market";
            this.radSearch_Customer.UseVisualStyleBackColor = true;
            this.radSearch_Customer.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // cmbSearch_Market
            // 
            this.cmbSearch_Market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Market.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Market.FormattingEnabled = true;
            this.cmbSearch_Market.Location = new System.Drawing.Point(196, 241);
            this.cmbSearch_Market.Name = "cmbSearch_Market";
            this.cmbSearch_Market.Size = new System.Drawing.Size(284, 24);
            this.cmbSearch_Market.Sorted = true;
            this.cmbSearch_Market.TabIndex = 13;
            this.cmbSearch_Market.Visible = false;
            this.cmbSearch_Market.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Market.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // radSearch_Asset
            // 
            this.radSearch_Asset.AutoSize = true;
            this.radSearch_Asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Asset.Location = new System.Drawing.Point(22, 90);
            this.radSearch_Asset.Name = "radSearch_Asset";
            this.radSearch_Asset.Size = new System.Drawing.Size(60, 20);
            this.radSearch_Asset.TabIndex = 5;
            this.radSearch_Asset.Text = "Asset";
            this.radSearch_Asset.UseVisualStyleBackColor = true;
            this.radSearch_Asset.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // cmbSearch_Asset
            // 
            this.cmbSearch_Asset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Asset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Asset.FormattingEnabled = true;
            this.cmbSearch_Asset.Location = new System.Drawing.Point(172, 91);
            this.cmbSearch_Asset.Name = "cmbSearch_Asset";
            this.cmbSearch_Asset.Size = new System.Drawing.Size(308, 24);
            this.cmbSearch_Asset.TabIndex = 6;
            this.cmbSearch_Asset.Visible = false;
            this.cmbSearch_Asset.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Asset.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // cmbSearch_Customer
            // 
            this.cmbSearch_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Customer.FormattingEnabled = true;
            this.cmbSearch_Customer.Location = new System.Drawing.Point(172, 211);
            this.cmbSearch_Customer.Name = "cmbSearch_Customer";
            this.cmbSearch_Customer.Size = new System.Drawing.Size(308, 24);
            this.cmbSearch_Customer.Sorted = true;
            this.cmbSearch_Customer.TabIndex = 11;
            this.cmbSearch_Customer.Visible = false;
            this.cmbSearch_Customer.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_Customer_SelectedIndexChanged);
            this.cmbSearch_Customer.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Customer.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // cmbSearch_Tech
            // 
            this.cmbSearch_Tech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch_Tech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch_Tech.FormattingEnabled = true;
            this.cmbSearch_Tech.Location = new System.Drawing.Point(172, 181);
            this.cmbSearch_Tech.Name = "cmbSearch_Tech";
            this.cmbSearch_Tech.Size = new System.Drawing.Size(308, 24);
            this.cmbSearch_Tech.Sorted = true;
            this.cmbSearch_Tech.TabIndex = 9;
            this.cmbSearch_Tech.Visible = false;
            this.cmbSearch_Tech.Enter += new System.EventHandler(this.Search_Enter);
            this.cmbSearch_Tech.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // radSearch_DateRange
            // 
            this.radSearch_DateRange.AutoSize = true;
            this.radSearch_DateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_DateRange.Location = new System.Drawing.Point(22, 389);
            this.radSearch_DateRange.Name = "radSearch_DateRange";
            this.radSearch_DateRange.Size = new System.Drawing.Size(99, 20);
            this.radSearch_DateRange.TabIndex = 18;
            this.radSearch_DateRange.Text = "Date Range";
            this.radSearch_DateRange.UseVisualStyleBackColor = true;
            this.radSearch_DateRange.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // txtSearch_Ticket
            // 
            this.txtSearch_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_Ticket.Location = new System.Drawing.Point(172, 63);
            this.txtSearch_Ticket.Name = "txtSearch_Ticket";
            this.txtSearch_Ticket.Size = new System.Drawing.Size(139, 22);
            this.txtSearch_Ticket.TabIndex = 4;
            this.txtSearch_Ticket.Visible = false;
            this.txtSearch_Ticket.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_Ticket.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // txtSearch_RMANumber
            // 
            this.txtSearch_RMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_RMANumber.Location = new System.Drawing.Point(172, 35);
            this.txtSearch_RMANumber.Name = "txtSearch_RMANumber";
            this.txtSearch_RMANumber.Size = new System.Drawing.Size(139, 22);
            this.txtSearch_RMANumber.TabIndex = 2;
            this.txtSearch_RMANumber.Visible = false;
            this.txtSearch_RMANumber.Enter += new System.EventHandler(this.Search_Enter);
            this.txtSearch_RMANumber.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // pnlSearch_DateRange
            // 
            this.pnlSearch_DateRange.Controls.Add(this.dtpSearch_From);
            this.pnlSearch_DateRange.Controls.Add(this.lblSearch_DateRangeThrough);
            this.pnlSearch_DateRange.Controls.Add(this.dtpSearch_To);
            this.pnlSearch_DateRange.Location = new System.Drawing.Point(172, 386);
            this.pnlSearch_DateRange.Name = "pnlSearch_DateRange";
            this.pnlSearch_DateRange.Size = new System.Drawing.Size(276, 30);
            this.pnlSearch_DateRange.TabIndex = 19;
            this.pnlSearch_DateRange.Visible = false;
            // 
            // dtpSearch_From
            // 
            this.dtpSearch_From.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_From.Location = new System.Drawing.Point(3, 3);
            this.dtpSearch_From.Name = "dtpSearch_From";
            this.dtpSearch_From.Size = new System.Drawing.Size(98, 22);
            this.dtpSearch_From.TabIndex = 0;
            this.dtpSearch_From.Enter += new System.EventHandler(this.Search_Enter);
            this.dtpSearch_From.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // lblSearch_DateRangeThrough
            // 
            this.lblSearch_DateRangeThrough.AutoSize = true;
            this.lblSearch_DateRangeThrough.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_DateRangeThrough.Location = new System.Drawing.Point(109, 6);
            this.lblSearch_DateRangeThrough.Name = "lblSearch_DateRangeThrough";
            this.lblSearch_DateRangeThrough.Size = new System.Drawing.Size(52, 16);
            this.lblSearch_DateRangeThrough.TabIndex = 1;
            this.lblSearch_DateRangeThrough.Text = "through";
            // 
            // dtpSearch_To
            // 
            this.dtpSearch_To.CustomFormat = "yyyy-MM-dd";
            this.dtpSearch_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearch_To.Location = new System.Drawing.Point(170, 2);
            this.dtpSearch_To.Name = "dtpSearch_To";
            this.dtpSearch_To.Size = new System.Drawing.Size(98, 22);
            this.dtpSearch_To.TabIndex = 2;
            this.dtpSearch_To.Enter += new System.EventHandler(this.Search_Enter);
            this.dtpSearch_To.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // radSearch_Ticket
            // 
            this.radSearch_Ticket.AutoSize = true;
            this.radSearch_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch_Ticket.Location = new System.Drawing.Point(22, 64);
            this.radSearch_Ticket.Name = "radSearch_Ticket";
            this.radSearch_Ticket.Size = new System.Drawing.Size(114, 20);
            this.radSearch_Ticket.TabIndex = 3;
            this.radSearch_Ticket.Text = "Ticket Number";
            this.radSearch_Ticket.UseVisualStyleBackColor = true;
            this.radSearch_Ticket.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // tabRMA_List
            // 
            this.tabRMA_List.Controls.Add(this.olvRMAList);
            this.tabRMA_List.Controls.Add(this.pnlControl);
            this.tabRMA_List.Location = new System.Drawing.Point(4, 22);
            this.tabRMA_List.Name = "tabRMA_List";
            this.tabRMA_List.Padding = new System.Windows.Forms.Padding(3);
            this.tabRMA_List.Size = new System.Drawing.Size(1081, 563);
            this.tabRMA_List.TabIndex = 1;
            this.tabRMA_List.Text = "List";
            this.tabRMA_List.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewRMA
            // 
            this.btnCreateNewRMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateNewRMA.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreateNewRMA.Location = new System.Drawing.Point(971, 5);
            this.btnCreateNewRMA.Name = "btnCreateNewRMA";
            this.btnCreateNewRMA.Size = new System.Drawing.Size(108, 23);
            this.btnCreateNewRMA.TabIndex = 4;
            this.btnCreateNewRMA.Text = "Create New RMA";
            this.btnCreateNewRMA.UseVisualStyleBackColor = false;
            this.btnCreateNewRMA.Click += new System.EventHandler(this.btnCreateNewRMA_Click);
            // 
            // cmbPage
            // 
            this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPage.FormattingEnabled = true;
            this.cmbPage.Location = new System.Drawing.Point(179, 7);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(50, 21);
            this.cmbPage.TabIndex = 13;
            this.toolTip.SetToolTip(this.cmbPage, "Select page");
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
            this.toolTip.SetToolTip(this.btnLast, "Last page");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(289, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.toolTip.SetToolTip(this.btnNext, "Next page");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFirst.Location = new System.Drawing.Point(5, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 23);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "|<";
            this.toolTip.SetToolTip(this.btnFirst, "First page");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.Location = new System.Drawing.Point(63, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(50, 23);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "<";
            this.toolTip.SetToolTip(this.btnPrevious, "Previous page");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Location = new System.Drawing.Point(10, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh (F5)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1019, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMove
            // 
            this.btnMove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMove.Location = new System.Drawing.Point(881, 5);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 23);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move Items";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // pnlTopControls
            // 
            this.pnlTopControls.Controls.Add(this.flpRmaKey);
            this.pnlTopControls.Controls.Add(this.btnMove);
            this.pnlTopControls.Controls.Add(this.btnRefresh);
            this.pnlTopControls.Controls.Add(this.btnCreateNewRMA);
            this.pnlTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopControls.Location = new System.Drawing.Point(0, 0);
            this.pnlTopControls.Name = "pnlTopControls";
            this.pnlTopControls.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlTopControls.Size = new System.Drawing.Size(1089, 33);
            this.pnlTopControls.TabIndex = 7;
            // 
            // flpRmaKey
            // 
            this.flpRmaKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRmaKey.Location = new System.Drawing.Point(118, 5);
            this.flpRmaKey.Name = "flpRmaKey";
            this.flpRmaKey.Size = new System.Drawing.Size(763, 23);
            this.flpRmaKey.TabIndex = 0;
            // 
            // pnlBottomControls
            // 
            this.pnlBottomControls.Controls.Add(this.pnlPagination);
            this.pnlBottomControls.Controls.Add(this.btnClose);
            this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomControls.Location = new System.Drawing.Point(0, 622);
            this.pnlBottomControls.Name = "pnlBottomControls";
            this.pnlBottomControls.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlBottomControls.Size = new System.Drawing.Size(1089, 40);
            this.pnlBottomControls.TabIndex = 8;
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
            this.pnlPagination.Location = new System.Drawing.Point(344, 4);
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
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(904, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormRMA_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1089, 662);
            this.Controls.Add(this.tabControlRMA);
            this.Controls.Add(this.pnlBottomControls);
            this.Controls.Add(this.pnlTopControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(960, 500);
            this.Name = "FormRMA_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RMA List";
            this.Activated += new System.EventHandler(this.FormRMA_List_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRMAList_FormClosing);
            this.Load += new System.EventHandler(this.FormRMAList_Load);
            this.Shown += new System.EventHandler(this.FormRMAList_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRMA_List_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.olvRMAList)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlViewControl.ResumeLayout(false);
            this.pnlViewControl.PerformLayout();
            this.tabControlRMA.ResumeLayout(false);
            this.tabRMA_Search.ResumeLayout(false);
            this.pnlRMA_Search.ResumeLayout(false);
            this.pnlRMA_Search.PerformLayout();
            this.pnlSearch_DateRange.ResumeLayout(false);
            this.pnlSearch_DateRange.PerformLayout();
            this.tabRMA_List.ResumeLayout(false);
            this.pnlTopControls.ResumeLayout(false);
            this.pnlBottomControls.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvRMAList;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Number;
		private System.Windows.Forms.Panel pnlControl;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Created;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_TicketNumber;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Asset;
		private System.Windows.Forms.TextBox txtRMAList_Qty;
		private System.Windows.Forms.Label lblRMAList_Qty;
		private System.Windows.Forms.RadioButton radRMAList_Closed;
		private System.Windows.Forms.Label lblRMAList_View;
		private System.Windows.Forms.RadioButton radRMAList_Unreceived;
		private System.Windows.Forms.RadioButton radRMAList_Review;
		private System.Windows.Forms.Panel pnlViewControl;
		private System.Windows.Forms.TabControl tabControlRMA;
		private System.Windows.Forms.TabPage tabRMA_Search;
		private System.Windows.Forms.TabPage tabRMA_List;
		private System.Windows.Forms.Label lblSearch_Issued;
		private System.Windows.Forms.Label lblSearch_AssignedTo;
		private System.Windows.Forms.ComboBox cmbSearch_Market;
		private System.Windows.Forms.ComboBox cmbSearch_Asset;
		private System.Windows.Forms.ComboBox cmbSearch_Tech;
		private System.Windows.Forms.TextBox txtSearch_Ticket;
		private System.Windows.Forms.Panel pnlSearch_DateRange;
		private System.Windows.Forms.DateTimePicker dtpSearch_From;
		private System.Windows.Forms.Label lblSearch_DateRangeThrough;
		private System.Windows.Forms.DateTimePicker dtpSearch_To;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RadioButton radSearch_Ticket;
		private System.Windows.Forms.TextBox txtSearch_RMANumber;
		private System.Windows.Forms.RadioButton radSearch_DateRange;
		private System.Windows.Forms.ComboBox cmbSearch_Customer;
		private System.Windows.Forms.Label lblSearch_Search;
		private System.Windows.Forms.RadioButton radSearch_Asset;
		private System.Windows.Forms.RadioButton radSearch_Customer;
		private System.Windows.Forms.RadioButton radSearch_RMANumber;
		private System.Windows.Forms.RadioButton radSearch_Tech;
		private System.Windows.Forms.RadioButton radRMAList_Received;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Hot;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_APR;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Received;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Assemblies;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Completed;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_Finalized;
		private System.Windows.Forms.ImageList imageList16x16;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnCreateNewRMA;
		private System.Windows.Forms.CheckBox chkSearch_AllMarkets;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_IssuedTo;
		private System.Windows.Forms.RadioButton radRMAList_Pending;
		private System.Windows.Forms.RadioButton radRMAList_InProgress;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_PendingReason;
		private System.Windows.Forms.RadioButton radRMAList_UnshippedAPR;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_PendingType;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_HasComputer;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_MostRecentRepairUser;
		private System.Windows.Forms.Panel pnlRMA_Search;
		private System.Windows.Forms.Button btnRefresh;
		private BrightIdeasSoftware.OLVColumn olvColRMAList_HasNonSystemJournalEntries;
		private System.Windows.Forms.RadioButton radRMAList_Deleted;
		private System.Windows.Forms.RadioButton radRMAList_Expired;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.RadioButton radRMAList_Unshipped;
		private System.Windows.Forms.ComboBox cmbSearch_AssemblyType;
		private System.Windows.Forms.RadioButton radSearch_AssemblyType;
		private System.Windows.Forms.Label lblSearch_AssemblyType;
		private System.Windows.Forms.Button btnMove;
		private System.Windows.Forms.CheckBox chkIncludeDeleted;
		private System.Windows.Forms.Panel pnlTopControls;
		private System.Windows.Forms.FlowLayoutPanel flpRmaKey;
		private System.Windows.Forms.Panel pnlBottomControls;
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