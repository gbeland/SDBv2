using SDB.UserControls.RMA;

namespace SDB.Forms.RMA
{
	partial class FormLegacyRMAManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLegacyRMAManagement));
			this.tabRMA = new System.Windows.Forms.TabControl();
			this.tabRMACreate = new System.Windows.Forms.TabPage();
			this.lblRMACreate_AssignTo = new System.Windows.Forms.Label();
			this.lblRMACreate = new System.Windows.Forms.Label();
			this.btnRMACreate_Reset = new System.Windows.Forms.Button();
			this.grpRMACreate = new System.Windows.Forms.GroupBox();
			this.txtRMACreate_CustomerWorkOrder = new System.Windows.Forms.TextBox();
			this.lblRMACreate_CustomerWorkOrder = new System.Windows.Forms.Label();
			this.txtRMACreate_TicketNumber = new System.Windows.Forms.TextBox();
			this.lblRMACreate_TicketNumber = new System.Windows.Forms.Label();
			this.txtRMACreate_JobNumber = new System.Windows.Forms.TextBox();
			this.cmbRMACreate_DisplayName = new System.Windows.Forms.ComboBox();
			this.chkRMACreate_RiskKit = new System.Windows.Forms.CheckBox();
			this.chkRMACreate_APR = new System.Windows.Forms.CheckBox();
			this.ucRMAPartLineEditor_Create5 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Create4 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Create3 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Create2 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Create1 = new ucLegacyRMAPartLineEditor();
			this.pnlRMACreateSidebar = new System.Windows.Forms.Panel();
			this.txtRMACreate_CustomerRequests = new System.Windows.Forms.TextBox();
			this.txtRMACreate_YescoNotes = new System.Windows.Forms.TextBox();
			this.lblRMACreate_YescoNotes = new System.Windows.Forms.Label();
			this.lblRMACreate_CustomerRequests = new System.Windows.Forms.Label();
			this.dtpRMACreate_DateIssued = new System.Windows.Forms.DateTimePicker();
			this.btnRMACreate_Create = new System.Windows.Forms.Button();
			this.txtRMACreate_Tracking = new System.Windows.Forms.TextBox();
			this.txtRMACreate_AuthBy = new System.Windows.Forms.TextBox();
			this.txtRMACreate_PO = new System.Windows.Forms.TextBox();
			this.lblRMACreate_Tracking = new System.Windows.Forms.Label();
			this.lblRMACreate_DateIssued = new System.Windows.Forms.Label();
			this.lblRMACreate_AuthBy = new System.Windows.Forms.Label();
			this.lblRMACreate_PO = new System.Windows.Forms.Label();
			this.lblRMACreate_JobNumber = new System.Windows.Forms.Label();
			this.lblRMACreate_DisplayName = new System.Windows.Forms.Label();
			this.btnRMACreate_SelectTech = new System.Windows.Forms.Button();
			this.cmbRMACreate_TechSelection = new System.Windows.Forms.ComboBox();
			this.tabRMAEdit = new System.Windows.Forms.TabPage();
			this.btnRMAEdit_ApprovalRequired = new System.Windows.Forms.Button();
			this.lblRMAEdit_AssignedTech = new System.Windows.Forms.Label();
			this.cmbRMAEdit_AssignedTech = new System.Windows.Forms.ComboBox();
			this.btnRMAEdit_PrintScreen = new System.Windows.Forms.Button();
			this.btnRMAEdit_Find = new System.Windows.Forms.Button();
			this.txtRMAEdit_RMANumber = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_RMAEdit = new System.Windows.Forms.Label();
			this.grpRMAEdit = new System.Windows.Forms.GroupBox();
			this.txtRMAEdit_CustomerWorkOrder = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_CustomerWorkOrder = new System.Windows.Forms.Label();
			this.txtRMAEdit_TicketNumber = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_TicketNumber = new System.Windows.Forms.Label();
			this.txtRMAEdit_JobNumber = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_Completed = new System.Windows.Forms.Label();
			this.chkRMAEdit_RiskKit = new System.Windows.Forms.CheckBox();
			this.chkRMAEdit_APR = new System.Windows.Forms.CheckBox();
			this.ucRMAPartLineEditor_Edit1 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Edit2 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Edit3 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Edit4 = new ucLegacyRMAPartLineEditor();
			this.ucRMAPartLineEditor_Edit5 = new ucLegacyRMAPartLineEditor();
			this.lblRMAEdit_JobNumber = new System.Windows.Forms.Label();
			this.txtRMAEdit_DisplayName = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_DisplayName = new System.Windows.Forms.Label();
			this.pnlRMAEdit_Sidebar = new System.Windows.Forms.Panel();
			this.txtRMAEdit_CustomerRequests = new System.Windows.Forms.TextBox();
			this.txtRMAEdit_YescoNotes = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_YescoNotes = new System.Windows.Forms.Label();
			this.dtpRMAEdit_DateIssued = new System.Windows.Forms.DateTimePicker();
			this.btnRMAEdit_Update = new System.Windows.Forms.Button();
			this.txtRMAEdit_Tracking = new System.Windows.Forms.TextBox();
			this.txtRMAEdit_AuthBy = new System.Windows.Forms.TextBox();
			this.txtRMAEdit_PO = new System.Windows.Forms.TextBox();
			this.lblRMAEdit_CustomerRequests = new System.Windows.Forms.Label();
			this.lblRMAEdit_Tracking = new System.Windows.Forms.Label();
			this.lblRMAEdit_DateIssued = new System.Windows.Forms.Label();
			this.lblRMAEdit_AuthBy = new System.Windows.Forms.Label();
			this.lblRMAEdit_PO = new System.Windows.Forms.Label();
			this.tabRMAJobLog = new System.Windows.Forms.TabPage();
			this.txtRMAJobLog_CustomerWorkOrder = new System.Windows.Forms.TextBox();
			this.lblRMAJobLog_TicketNumber = new System.Windows.Forms.Label();
			this.txtRMAJobLog_TicketNumber = new System.Windows.Forms.TextBox();
			this.txtRMAJobLog_CustomerRequests = new System.Windows.Forms.TextBox();
			this.txtRMAJobLog_YescoNotes = new System.Windows.Forms.TextBox();
			this.lblRMAJobLog_CustomerRequests = new System.Windows.Forms.Label();
			this.btnRMAJobLog_CreateShipper = new System.Windows.Forms.Button();
			this.lblRMAJobLog_NoReturnApproval = new System.Windows.Forms.Label();
			this.lblRMAJobLog_JobNumber = new System.Windows.Forms.Label();
			this.txtRMAJobLog_JobNumber = new System.Windows.Forms.TextBox();
			this.txtRMAJobLog_DisplayName = new System.Windows.Forms.TextBox();
			this.lblRMAJobLog_DisplayName = new System.Windows.Forms.Label();
			this.btnRMAJobLog_PrintScreen = new System.Windows.Forms.Button();
			this.btnRMAJobLog_EnterBottom = new System.Windows.Forms.Button();
			this.btnRMAJobLog_EnterTop = new System.Windows.Forms.Button();
			this.lblRMAJobLog_YescoNotes = new System.Windows.Forms.Label();
			this.pnlRMAJobLog_Header = new System.Windows.Forms.Panel();
			this.txtRMAJobLog_WorkOrders = new System.Windows.Forms.TextBox();
			this.lblRMAJobLogShow_PurchaseOrder = new System.Windows.Forms.Label();
			this.lblRMAJobLogShow_RMANumber = new System.Windows.Forms.Label();
			this.lblRMAJobLog_WorkOrders = new System.Windows.Forms.Label();
			this.lblRMAJobLog_PurchaseOrder = new System.Windows.Forms.Label();
			this.lblRMAJobLog_RMANumber = new System.Windows.Forms.Label();
			this.pnlRMAJobLog_Completed = new System.Windows.Forms.Panel();
			this.radRMAJobLog_CompletedNo = new System.Windows.Forms.RadioButton();
			this.radRMAJobLog_CompletedYes = new System.Windows.Forms.RadioButton();
			this.lblRMAJobLog_Completed = new System.Windows.Forms.Label();
			this.ucRMAJobLogLine5 = new ucLegacyRMAJobLogLine();
			this.ucRMAJobLogLine4 = new ucLegacyRMAJobLogLine();
			this.ucRMAJobLogLine3 = new ucLegacyRMAJobLogLine();
			this.ucRMAJobLogLine2 = new ucLegacyRMAJobLogLine();
			this.ucRMAJobLogLine1 = new ucLegacyRMAJobLogLine();
			this.tabRMADetail = new System.Windows.Forms.TabPage();
			this.btnRMADetail_PrintScreen = new System.Windows.Forms.Button();
			this.txtRMADetail_CustomerRequests = new System.Windows.Forms.TextBox();
			this.txtRMADetail_YescoNotes = new System.Windows.Forms.TextBox();
			this.lblRMADetail_CustomerRequests = new System.Windows.Forms.Label();
			this.btnRMADetail_CreatePDF = new System.Windows.Forms.Button();
			this.lblRMADetail_YescoNotes = new System.Windows.Forms.Label();
			this.pnlRMADetail_Header = new System.Windows.Forms.Panel();
			this.lblRMADetail_Show_CustomerWorkOrder = new System.Windows.Forms.Label();
			this.lblRMADetail_CustomerWorkOrder = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_TicketNumber = new System.Windows.Forms.Label();
			this.lblRMADetail_TicketNumber = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_APR = new System.Windows.Forms.Label();
			this.lblRMADetail_APR = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_ShippingTelNum = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_ShippingStateCity = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_ShippingRoad = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_ShippingName = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_AddressTelNum = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_AddressStateCity = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_AddressRoad = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_AddressName = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_DateIssued = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_IssuedBy = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_PurchaseOrder = new System.Windows.Forms.Label();
			this.lblRMADetail_Show_RMANum = new System.Windows.Forms.Label();
			this.lblRMADetail_ShipToAddress = new System.Windows.Forms.Label();
			this.lblRMADetail_CustomerAddress = new System.Windows.Forms.Label();
			this.lblRMADetail_PurchaseOrder = new System.Windows.Forms.Label();
			this.lblRMADetail_Issuer = new System.Windows.Forms.Label();
			this.lblRMADetail_RMANumber = new System.Windows.Forms.Label();
			this.lblRMADetail_IssueDate = new System.Windows.Forms.Label();
			this.ucRMADetail_Part5 = new ucLegacyRMAPartDetail();
			this.ucRMADetail_Part4 = new ucLegacyRMAPartDetail();
			this.ucRMADetail_Part3 = new ucLegacyRMAPartDetail();
			this.ucRMADetail_Part2 = new ucLegacyRMAPartDetail();
			this.ucRMADetail_Part1 = new ucLegacyRMAPartDetail();
			this.tabRMAMasterList = new System.Windows.Forms.TabPage();
			this.btnRMAMasterList_Export = new System.Windows.Forms.Button();
			this.lblRMAMasterList_SubHeader = new System.Windows.Forms.Label();
			this.lblRMAMasterList_Header = new System.Windows.Forms.Label();
			this.btnRMAMaster_Detail = new System.Windows.Forms.Button();
			this.btnRMAMaster_Edit = new System.Windows.Forms.Button();
			this.btnRMAMaster_JobLog = new System.Windows.Forms.Button();
			this.lblRMAMaster_Selected = new System.Windows.Forms.Label();
			this.ucRMAMaster_ListLabels3 = new ucLegacyRMAListLabels();
			this.lstRMAMaster = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabRMAUnreceived = new System.Windows.Forms.TabPage();
			this.btnRMAUnreceived_Export = new System.Windows.Forms.Button();
			this.lblRMAUnreceived_SubHeader = new System.Windows.Forms.Label();
			this.lblRMAUnreceived_Header = new System.Windows.Forms.Label();
			this.btnRMAUnreceived_Detail = new System.Windows.Forms.Button();
			this.btnRMAUnreceived_Edit = new System.Windows.Forms.Button();
			this.btnRMAUnreceived_JobLog = new System.Windows.Forms.Button();
			this.lblRMAUnreceived_Tech = new System.Windows.Forms.Label();
			this.lblRMAUnreceived_Selected = new System.Windows.Forms.Label();
			this.ucRMAUnreceived_ListLabels1 = new ucLegacyRMAListLabels();
			this.lstvRMAUnreceived = new System.Windows.Forms.ListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabRMAUnfinished = new System.Windows.Forms.TabPage();
			this.btnRMAUnfinished_Export = new System.Windows.Forms.Button();
			this.lblRMAUnfinished_SubHeader = new System.Windows.Forms.Label();
			this.lblRMAUnfinished_Header = new System.Windows.Forms.Label();
			this.btnRMAUnfinished_Detail = new System.Windows.Forms.Button();
			this.btnRMAUnfinished_Edit = new System.Windows.Forms.Button();
			this.btnRMAUnfinished_JobLog = new System.Windows.Forms.Button();
			this.lblRMAUnfinished_Selected = new System.Windows.Forms.Label();
			this.ucRMAUnfinished_ListLabels2 = new ucLegacyRMAListLabels();
			this.lstvRMAUnfinished = new System.Windows.Forms.ListView();
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabRMATechs = new System.Windows.Forms.TabPage();
			this.btnRMATechs_Export = new System.Windows.Forms.Button();
			this.lblRMATechs_Header = new System.Windows.Forms.Label();
			this.lstvRMATechs = new System.Windows.Forms.ListView();
			this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmbRMATechs = new System.Windows.Forms.ComboBox();
			this.lblRMATechs_Select = new System.Windows.Forms.Label();
			this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.tabRMA.SuspendLayout();
			this.tabRMACreate.SuspendLayout();
			this.grpRMACreate.SuspendLayout();
			this.pnlRMACreateSidebar.SuspendLayout();
			this.tabRMAEdit.SuspendLayout();
			this.grpRMAEdit.SuspendLayout();
			this.pnlRMAEdit_Sidebar.SuspendLayout();
			this.tabRMAJobLog.SuspendLayout();
			this.pnlRMAJobLog_Header.SuspendLayout();
			this.pnlRMAJobLog_Completed.SuspendLayout();
			this.tabRMADetail.SuspendLayout();
			this.pnlRMADetail_Header.SuspendLayout();
			this.tabRMAMasterList.SuspendLayout();
			this.tabRMAUnreceived.SuspendLayout();
			this.tabRMAUnfinished.SuspendLayout();
			this.tabRMATechs.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabRMA
			// 
			this.tabRMA.Controls.Add(this.tabRMACreate);
			this.tabRMA.Controls.Add(this.tabRMAEdit);
			this.tabRMA.Controls.Add(this.tabRMAJobLog);
			this.tabRMA.Controls.Add(this.tabRMADetail);
			this.tabRMA.Controls.Add(this.tabRMAMasterList);
			this.tabRMA.Controls.Add(this.tabRMAUnreceived);
			this.tabRMA.Controls.Add(this.tabRMAUnfinished);
			this.tabRMA.Controls.Add(this.tabRMATechs);
			this.tabRMA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabRMA.Location = new System.Drawing.Point(0, 0);
			this.tabRMA.Name = "tabRMA";
			this.tabRMA.SelectedIndex = 0;
			this.tabRMA.Size = new System.Drawing.Size(1070, 708);
			this.tabRMA.TabIndex = 16;
			this.tabRMA.TabStop = false;
			this.tabRMA.Tag = "Original Location 2,27";
			this.tabRMA.SelectedIndexChanged += new System.EventHandler(this.tabRMA_SelectedIndexChanged);
			// 
			// tabRMACreate
			// 
			this.tabRMACreate.Controls.Add(this.lblRMACreate_AssignTo);
			this.tabRMACreate.Controls.Add(this.lblRMACreate);
			this.tabRMACreate.Controls.Add(this.btnRMACreate_Reset);
			this.tabRMACreate.Controls.Add(this.grpRMACreate);
			this.tabRMACreate.Controls.Add(this.btnRMACreate_SelectTech);
			this.tabRMACreate.Controls.Add(this.cmbRMACreate_TechSelection);
			this.tabRMACreate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabRMACreate.Location = new System.Drawing.Point(4, 22);
			this.tabRMACreate.Name = "tabRMACreate";
			this.tabRMACreate.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMACreate.Size = new System.Drawing.Size(1062, 682);
			this.tabRMACreate.TabIndex = 1;
			this.tabRMACreate.Text = "Create RMA";
			this.tabRMACreate.UseVisualStyleBackColor = true;
			// 
			// lblRMACreate_AssignTo
			// 
			this.lblRMACreate_AssignTo.AutoSize = true;
			this.lblRMACreate_AssignTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_AssignTo.Location = new System.Drawing.Point(141, 8);
			this.lblRMACreate_AssignTo.Name = "lblRMACreate_AssignTo";
			this.lblRMACreate_AssignTo.Size = new System.Drawing.Size(69, 16);
			this.lblRMACreate_AssignTo.TabIndex = 1;
			this.lblRMACreate_AssignTo.Text = "Assign to:";
			this.lblRMACreate_AssignTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate
			// 
			this.lblRMACreate.AutoSize = true;
			this.lblRMACreate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate.Location = new System.Drawing.Point(4, 3);
			this.lblRMACreate.Name = "lblRMACreate";
			this.lblRMACreate.Size = new System.Drawing.Size(119, 22);
			this.lblRMACreate.TabIndex = 0;
			this.lblRMACreate.Text = "Create RMA";
			this.lblRMACreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRMACreate_Reset
			// 
			this.btnRMACreate_Reset.Location = new System.Drawing.Point(572, 4);
			this.btnRMACreate_Reset.Name = "btnRMACreate_Reset";
			this.btnRMACreate_Reset.Size = new System.Drawing.Size(89, 24);
			this.btnRMACreate_Reset.TabIndex = 4;
			this.btnRMACreate_Reset.Text = "Reset";
			this.btnRMACreate_Reset.UseVisualStyleBackColor = true;
			this.btnRMACreate_Reset.Click += new System.EventHandler(this.btnRMACreate_Reset_Click);
			// 
			// grpRMACreate
			// 
			this.grpRMACreate.Controls.Add(this.txtRMACreate_CustomerWorkOrder);
			this.grpRMACreate.Controls.Add(this.lblRMACreate_CustomerWorkOrder);
			this.grpRMACreate.Controls.Add(this.txtRMACreate_TicketNumber);
			this.grpRMACreate.Controls.Add(this.lblRMACreate_TicketNumber);
			this.grpRMACreate.Controls.Add(this.txtRMACreate_JobNumber);
			this.grpRMACreate.Controls.Add(this.cmbRMACreate_DisplayName);
			this.grpRMACreate.Controls.Add(this.chkRMACreate_RiskKit);
			this.grpRMACreate.Controls.Add(this.chkRMACreate_APR);
			this.grpRMACreate.Controls.Add(this.ucRMAPartLineEditor_Create5);
			this.grpRMACreate.Controls.Add(this.ucRMAPartLineEditor_Create4);
			this.grpRMACreate.Controls.Add(this.ucRMAPartLineEditor_Create3);
			this.grpRMACreate.Controls.Add(this.ucRMAPartLineEditor_Create2);
			this.grpRMACreate.Controls.Add(this.ucRMAPartLineEditor_Create1);
			this.grpRMACreate.Controls.Add(this.pnlRMACreateSidebar);
			this.grpRMACreate.Controls.Add(this.lblRMACreate_JobNumber);
			this.grpRMACreate.Controls.Add(this.lblRMACreate_DisplayName);
			this.grpRMACreate.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpRMACreate.Location = new System.Drawing.Point(3, 51);
			this.grpRMACreate.Name = "grpRMACreate";
			this.grpRMACreate.Size = new System.Drawing.Size(1056, 628);
			this.grpRMACreate.TabIndex = 6;
			this.grpRMACreate.TabStop = false;
			this.grpRMACreate.Text = "Details";
			this.grpRMACreate.Visible = false;
			// 
			// txtRMACreate_CustomerWorkOrder
			// 
			this.txtRMACreate_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_CustomerWorkOrder.Location = new System.Drawing.Point(450, 41);
			this.txtRMACreate_CustomerWorkOrder.MaxLength = 6;
			this.txtRMACreate_CustomerWorkOrder.Name = "txtRMACreate_CustomerWorkOrder";
			this.txtRMACreate_CustomerWorkOrder.Size = new System.Drawing.Size(108, 22);
			this.txtRMACreate_CustomerWorkOrder.TabIndex = 7;
			// 
			// lblRMACreate_CustomerWorkOrder
			// 
			this.lblRMACreate_CustomerWorkOrder.AutoSize = true;
			this.lblRMACreate_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_CustomerWorkOrder.Location = new System.Drawing.Point(447, 22);
			this.lblRMACreate_CustomerWorkOrder.Name = "lblRMACreate_CustomerWorkOrder";
			this.lblRMACreate_CustomerWorkOrder.Size = new System.Drawing.Size(102, 16);
			this.lblRMACreate_CustomerWorkOrder.TabIndex = 6;
			this.lblRMACreate_CustomerWorkOrder.Text = "Customer WO#";
			this.lblRMACreate_CustomerWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMACreate_TicketNumber
			// 
			this.txtRMACreate_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_TicketNumber.Location = new System.Drawing.Point(336, 41);
			this.txtRMACreate_TicketNumber.MaxLength = 6;
			this.txtRMACreate_TicketNumber.Name = "txtRMACreate_TicketNumber";
			this.txtRMACreate_TicketNumber.Size = new System.Drawing.Size(108, 22);
			this.txtRMACreate_TicketNumber.TabIndex = 5;
			// 
			// lblRMACreate_TicketNumber
			// 
			this.lblRMACreate_TicketNumber.AutoSize = true;
			this.lblRMACreate_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_TicketNumber.Location = new System.Drawing.Point(333, 22);
			this.lblRMACreate_TicketNumber.Name = "lblRMACreate_TicketNumber";
			this.lblRMACreate_TicketNumber.Size = new System.Drawing.Size(100, 16);
			this.lblRMACreate_TicketNumber.TabIndex = 4;
			this.lblRMACreate_TicketNumber.Text = "Ticket Number";
			this.lblRMACreate_TicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMACreate_JobNumber
			// 
			this.txtRMACreate_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_JobNumber.Location = new System.Drawing.Point(222, 41);
			this.txtRMACreate_JobNumber.MaxLength = 10;
			this.txtRMACreate_JobNumber.Name = "txtRMACreate_JobNumber";
			this.txtRMACreate_JobNumber.Size = new System.Drawing.Size(108, 22);
			this.txtRMACreate_JobNumber.TabIndex = 3;
			// 
			// cmbRMACreate_DisplayName
			// 
			this.cmbRMACreate_DisplayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRMACreate_DisplayName.FormattingEnabled = true;
			this.cmbRMACreate_DisplayName.Location = new System.Drawing.Point(6, 41);
			this.cmbRMACreate_DisplayName.Name = "cmbRMACreate_DisplayName";
			this.cmbRMACreate_DisplayName.Size = new System.Drawing.Size(210, 24);
			this.cmbRMACreate_DisplayName.TabIndex = 1;
			this.cmbRMACreate_DisplayName.SelectedIndexChanged += new System.EventHandler(this.cmbRMACreate_DisplayName_SelectedIndexChanged);
			// 
			// chkRMACreate_RiskKit
			// 
			this.chkRMACreate_RiskKit.AutoSize = true;
			this.chkRMACreate_RiskKit.Location = new System.Drawing.Point(824, 43);
			this.chkRMACreate_RiskKit.Name = "chkRMACreate_RiskKit";
			this.chkRMACreate_RiskKit.Size = new System.Drawing.Size(73, 20);
			this.chkRMACreate_RiskKit.TabIndex = 11;
			this.chkRMACreate_RiskKit.Text = "Risk Kit";
			this.chkRMACreate_RiskKit.UseVisualStyleBackColor = true;
			this.chkRMACreate_RiskKit.CheckedChanged += new System.EventHandler(this.chkRMACreate_RiskKit_CheckedChanged);
			// 
			// chkRMACreate_APR
			// 
			this.chkRMACreate_APR.AutoSize = true;
			this.chkRMACreate_APR.Location = new System.Drawing.Point(824, 23);
			this.chkRMACreate_APR.Name = "chkRMACreate_APR";
			this.chkRMACreate_APR.Size = new System.Drawing.Size(54, 20);
			this.chkRMACreate_APR.TabIndex = 10;
			this.chkRMACreate_APR.Text = "APR";
			this.chkRMACreate_APR.UseVisualStyleBackColor = true;
			this.chkRMACreate_APR.CheckedChanged += new System.EventHandler(this.chkRMACreate_APR_CheckedChanged);
			// 
			// ucRMAPartLineEditor_Create5
			// 
			this.ucRMAPartLineEditor_Create5.Location = new System.Drawing.Point(2, 529);
			this.ucRMAPartLineEditor_Create5.Name = "ucRMAPartLineEditor_Create5";
			this.ucRMAPartLineEditor_Create5.Priority = null;
			this.ucRMAPartLineEditor_Create5.Problem = null;
			this.ucRMAPartLineEditor_Create5.Qty = 0;
			this.ucRMAPartLineEditor_Create5.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Create5.TabIndex = 16;
			// 
			// ucRMAPartLineEditor_Create4
			// 
			this.ucRMAPartLineEditor_Create4.Location = new System.Drawing.Point(2, 414);
			this.ucRMAPartLineEditor_Create4.Name = "ucRMAPartLineEditor_Create4";
			this.ucRMAPartLineEditor_Create4.Priority = null;
			this.ucRMAPartLineEditor_Create4.Problem = null;
			this.ucRMAPartLineEditor_Create4.Qty = 0;
			this.ucRMAPartLineEditor_Create4.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Create4.TabIndex = 15;
			// 
			// ucRMAPartLineEditor_Create3
			// 
			this.ucRMAPartLineEditor_Create3.Location = new System.Drawing.Point(2, 299);
			this.ucRMAPartLineEditor_Create3.Name = "ucRMAPartLineEditor_Create3";
			this.ucRMAPartLineEditor_Create3.Priority = null;
			this.ucRMAPartLineEditor_Create3.Problem = null;
			this.ucRMAPartLineEditor_Create3.Qty = 0;
			this.ucRMAPartLineEditor_Create3.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Create3.TabIndex = 14;
			// 
			// ucRMAPartLineEditor_Create2
			// 
			this.ucRMAPartLineEditor_Create2.Location = new System.Drawing.Point(2, 184);
			this.ucRMAPartLineEditor_Create2.Name = "ucRMAPartLineEditor_Create2";
			this.ucRMAPartLineEditor_Create2.Priority = null;
			this.ucRMAPartLineEditor_Create2.Problem = null;
			this.ucRMAPartLineEditor_Create2.Qty = 0;
			this.ucRMAPartLineEditor_Create2.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Create2.TabIndex = 13;
			// 
			// ucRMAPartLineEditor_Create1
			// 
			this.ucRMAPartLineEditor_Create1.Location = new System.Drawing.Point(2, 69);
			this.ucRMAPartLineEditor_Create1.Name = "ucRMAPartLineEditor_Create1";
			this.ucRMAPartLineEditor_Create1.Priority = null;
			this.ucRMAPartLineEditor_Create1.Problem = null;
			this.ucRMAPartLineEditor_Create1.Qty = 0;
			this.ucRMAPartLineEditor_Create1.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Create1.TabIndex = 12;
			// 
			// pnlRMACreateSidebar
			// 
			this.pnlRMACreateSidebar.Controls.Add(this.txtRMACreate_CustomerRequests);
			this.pnlRMACreateSidebar.Controls.Add(this.txtRMACreate_YescoNotes);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_YescoNotes);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_CustomerRequests);
			this.pnlRMACreateSidebar.Controls.Add(this.dtpRMACreate_DateIssued);
			this.pnlRMACreateSidebar.Controls.Add(this.btnRMACreate_Create);
			this.pnlRMACreateSidebar.Controls.Add(this.txtRMACreate_Tracking);
			this.pnlRMACreateSidebar.Controls.Add(this.txtRMACreate_AuthBy);
			this.pnlRMACreateSidebar.Controls.Add(this.txtRMACreate_PO);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_Tracking);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_DateIssued);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_AuthBy);
			this.pnlRMACreateSidebar.Controls.Add(this.lblRMACreate_PO);
			this.pnlRMACreateSidebar.Location = new System.Drawing.Point(900, 24);
			this.pnlRMACreateSidebar.Name = "pnlRMACreateSidebar";
			this.pnlRMACreateSidebar.Size = new System.Drawing.Size(155, 594);
			this.pnlRMACreateSidebar.TabIndex = 13;
			// 
			// txtRMACreate_CustomerRequests
			// 
			this.txtRMACreate_CustomerRequests.AcceptsReturn = true;
			this.txtRMACreate_CustomerRequests.Location = new System.Drawing.Point(3, 399);
			this.txtRMACreate_CustomerRequests.MaxLength = 200;
			this.txtRMACreate_CustomerRequests.Multiline = true;
			this.txtRMACreate_CustomerRequests.Name = "txtRMACreate_CustomerRequests";
			this.txtRMACreate_CustomerRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMACreate_CustomerRequests.Size = new System.Drawing.Size(149, 162);
			this.txtRMACreate_CustomerRequests.TabIndex = 19;
			// 
			// txtRMACreate_YescoNotes
			// 
			this.txtRMACreate_YescoNotes.AcceptsReturn = true;
			this.txtRMACreate_YescoNotes.Location = new System.Drawing.Point(3, 214);
			this.txtRMACreate_YescoNotes.MaxLength = 150;
			this.txtRMACreate_YescoNotes.Multiline = true;
			this.txtRMACreate_YescoNotes.Name = "txtRMACreate_YescoNotes";
			this.txtRMACreate_YescoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMACreate_YescoNotes.Size = new System.Drawing.Size(149, 162);
			this.txtRMACreate_YescoNotes.TabIndex = 18;
			// 
			// lblRMACreate_YescoNotes
			// 
			this.lblRMACreate_YescoNotes.AutoSize = true;
			this.lblRMACreate_YescoNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_YescoNotes.Location = new System.Drawing.Point(0, 195);
			this.lblRMACreate_YescoNotes.Name = "lblRMACreate_YescoNotes";
			this.lblRMACreate_YescoNotes.Size = new System.Drawing.Size(87, 16);
			this.lblRMACreate_YescoNotes.TabIndex = 17;
			this.lblRMACreate_YescoNotes.Tag = "rmanote";
			this.lblRMACreate_YescoNotes.Text = "Yesco Notes:";
			this.lblRMACreate_YescoNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_CustomerRequests
			// 
			this.lblRMACreate_CustomerRequests.AutoSize = true;
			this.lblRMACreate_CustomerRequests.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_CustomerRequests.Location = new System.Drawing.Point(2, 380);
			this.lblRMACreate_CustomerRequests.Name = "lblRMACreate_CustomerRequests";
			this.lblRMACreate_CustomerRequests.Size = new System.Drawing.Size(133, 16);
			this.lblRMACreate_CustomerRequests.TabIndex = 16;
			this.lblRMACreate_CustomerRequests.Tag = "specialreq";
			this.lblRMACreate_CustomerRequests.Text = "Customer Requests:";
			this.lblRMACreate_CustomerRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpRMACreate_DateIssued
			// 
			this.dtpRMACreate_DateIssued.CustomFormat = "yyyy-MM-dd";
			this.dtpRMACreate_DateIssued.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRMACreate_DateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRMACreate_DateIssued.Location = new System.Drawing.Point(3, 92);
			this.dtpRMACreate_DateIssued.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.dtpRMACreate_DateIssued.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.dtpRMACreate_DateIssued.Name = "dtpRMACreate_DateIssued";
			this.dtpRMACreate_DateIssued.Size = new System.Drawing.Size(147, 22);
			this.dtpRMACreate_DateIssued.TabIndex = 5;
			this.dtpRMACreate_DateIssued.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.dtpRMACreate_DateIssued.Enter += new System.EventHandler(this.dtpRMACreate_DateIssued_Enter);
			// 
			// btnRMACreate_Create
			// 
			this.btnRMACreate_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRMACreate_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRMACreate_Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnRMACreate_Create.Location = new System.Drawing.Point(6, 567);
			this.btnRMACreate_Create.Name = "btnRMACreate_Create";
			this.btnRMACreate_Create.Size = new System.Drawing.Size(146, 23);
			this.btnRMACreate_Create.TabIndex = 12;
			this.btnRMACreate_Create.Text = "Create RMA";
			this.btnRMACreate_Create.UseVisualStyleBackColor = false;
			this.btnRMACreate_Create.Click += new System.EventHandler(this.btnRMACreate_Create_Click);
			// 
			// txtRMACreate_Tracking
			// 
			this.txtRMACreate_Tracking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_Tracking.Location = new System.Drawing.Point(3, 130);
			this.txtRMACreate_Tracking.MaxLength = 40;
			this.txtRMACreate_Tracking.Name = "txtRMACreate_Tracking";
			this.txtRMACreate_Tracking.Size = new System.Drawing.Size(147, 22);
			this.txtRMACreate_Tracking.TabIndex = 7;
			// 
			// txtRMACreate_AuthBy
			// 
			this.txtRMACreate_AuthBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_AuthBy.Location = new System.Drawing.Point(3, 54);
			this.txtRMACreate_AuthBy.MaxLength = 20;
			this.txtRMACreate_AuthBy.Name = "txtRMACreate_AuthBy";
			this.txtRMACreate_AuthBy.Size = new System.Drawing.Size(147, 22);
			this.txtRMACreate_AuthBy.TabIndex = 3;
			// 
			// txtRMACreate_PO
			// 
			this.txtRMACreate_PO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMACreate_PO.Location = new System.Drawing.Point(3, 16);
			this.txtRMACreate_PO.MaxLength = 10;
			this.txtRMACreate_PO.Name = "txtRMACreate_PO";
			this.txtRMACreate_PO.Size = new System.Drawing.Size(147, 22);
			this.txtRMACreate_PO.TabIndex = 1;
			// 
			// lblRMACreate_Tracking
			// 
			this.lblRMACreate_Tracking.AutoSize = true;
			this.lblRMACreate_Tracking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_Tracking.Location = new System.Drawing.Point(3, 114);
			this.lblRMACreate_Tracking.Name = "lblRMACreate_Tracking";
			this.lblRMACreate_Tracking.Size = new System.Drawing.Size(77, 16);
			this.lblRMACreate_Tracking.TabIndex = 6;
			this.lblRMACreate_Tracking.Text = "Tracking #:";
			this.lblRMACreate_Tracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_DateIssued
			// 
			this.lblRMACreate_DateIssued.AutoSize = true;
			this.lblRMACreate_DateIssued.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_DateIssued.Location = new System.Drawing.Point(3, 76);
			this.lblRMACreate_DateIssued.Name = "lblRMACreate_DateIssued";
			this.lblRMACreate_DateIssued.Size = new System.Drawing.Size(118, 16);
			this.lblRMACreate_DateIssued.TabIndex = 4;
			this.lblRMACreate_DateIssued.Text = "Date RMA Issued:";
			this.lblRMACreate_DateIssued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_AuthBy
			// 
			this.lblRMACreate_AuthBy.AutoSize = true;
			this.lblRMACreate_AuthBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_AuthBy.Location = new System.Drawing.Point(3, 38);
			this.lblRMACreate_AuthBy.Name = "lblRMACreate_AuthBy";
			this.lblRMACreate_AuthBy.Size = new System.Drawing.Size(140, 16);
			this.lblRMACreate_AuthBy.TabIndex = 2;
			this.lblRMACreate_AuthBy.Text = "Auth by (Supervisor):";
			this.lblRMACreate_AuthBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_PO
			// 
			this.lblRMACreate_PO.AutoSize = true;
			this.lblRMACreate_PO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_PO.Location = new System.Drawing.Point(3, 0);
			this.lblRMACreate_PO.Name = "lblRMACreate_PO";
			this.lblRMACreate_PO.Size = new System.Drawing.Size(42, 16);
			this.lblRMACreate_PO.TabIndex = 0;
			this.lblRMACreate_PO.Text = "PO #:";
			this.lblRMACreate_PO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_JobNumber
			// 
			this.lblRMACreate_JobNumber.AutoSize = true;
			this.lblRMACreate_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_JobNumber.Location = new System.Drawing.Point(219, 22);
			this.lblRMACreate_JobNumber.Name = "lblRMACreate_JobNumber";
			this.lblRMACreate_JobNumber.Size = new System.Drawing.Size(85, 16);
			this.lblRMACreate_JobNumber.TabIndex = 2;
			this.lblRMACreate_JobNumber.Text = "Job Number";
			this.lblRMACreate_JobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMACreate_DisplayName
			// 
			this.lblRMACreate_DisplayName.AutoSize = true;
			this.lblRMACreate_DisplayName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMACreate_DisplayName.Location = new System.Drawing.Point(3, 22);
			this.lblRMACreate_DisplayName.Name = "lblRMACreate_DisplayName";
			this.lblRMACreate_DisplayName.Size = new System.Drawing.Size(95, 16);
			this.lblRMACreate_DisplayName.TabIndex = 0;
			this.lblRMACreate_DisplayName.Text = "Display Name";
			this.lblRMACreate_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRMACreate_SelectTech
			// 
			this.btnRMACreate_SelectTech.Location = new System.Drawing.Point(477, 4);
			this.btnRMACreate_SelectTech.Name = "btnRMACreate_SelectTech";
			this.btnRMACreate_SelectTech.Size = new System.Drawing.Size(89, 24);
			this.btnRMACreate_SelectTech.TabIndex = 3;
			this.btnRMACreate_SelectTech.Text = "Select";
			this.btnRMACreate_SelectTech.UseVisualStyleBackColor = true;
			this.btnRMACreate_SelectTech.Click += new System.EventHandler(this.btnRMACreate_SelectTech_Click);
			// 
			// cmbRMACreate_TechSelection
			// 
			this.cmbRMACreate_TechSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRMACreate_TechSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRMACreate_TechSelection.DropDownHeight = 250;
			this.cmbRMACreate_TechSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRMACreate_TechSelection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRMACreate_TechSelection.FormattingEnabled = true;
			this.cmbRMACreate_TechSelection.IntegralHeight = false;
			this.cmbRMACreate_TechSelection.Location = new System.Drawing.Point(216, 5);
			this.cmbRMACreate_TechSelection.Name = "cmbRMACreate_TechSelection";
			this.cmbRMACreate_TechSelection.Size = new System.Drawing.Size(255, 24);
			this.cmbRMACreate_TechSelection.TabIndex = 2;
			this.cmbRMACreate_TechSelection.SelectedIndexChanged += new System.EventHandler(this.cmbRMACreateTechSelection_SelectedIndexChanged);
			// 
			// tabRMAEdit
			// 
			this.tabRMAEdit.Controls.Add(this.btnRMAEdit_ApprovalRequired);
			this.tabRMAEdit.Controls.Add(this.lblRMAEdit_AssignedTech);
			this.tabRMAEdit.Controls.Add(this.cmbRMAEdit_AssignedTech);
			this.tabRMAEdit.Controls.Add(this.btnRMAEdit_PrintScreen);
			this.tabRMAEdit.Controls.Add(this.btnRMAEdit_Find);
			this.tabRMAEdit.Controls.Add(this.txtRMAEdit_RMANumber);
			this.tabRMAEdit.Controls.Add(this.lblRMAEdit_RMAEdit);
			this.tabRMAEdit.Controls.Add(this.grpRMAEdit);
			this.tabRMAEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabRMAEdit.Location = new System.Drawing.Point(4, 22);
			this.tabRMAEdit.Name = "tabRMAEdit";
			this.tabRMAEdit.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAEdit.Size = new System.Drawing.Size(1062, 682);
			this.tabRMAEdit.TabIndex = 2;
			this.tabRMAEdit.Text = "Edit/View RMA";
			this.tabRMAEdit.UseVisualStyleBackColor = true;
			// 
			// btnRMAEdit_ApprovalRequired
			// 
			this.btnRMAEdit_ApprovalRequired.BackColor = System.Drawing.Color.Red;
			this.btnRMAEdit_ApprovalRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAEdit_ApprovalRequired.ForeColor = System.Drawing.Color.White;
			this.btnRMAEdit_ApprovalRequired.Location = new System.Drawing.Point(594, 9);
			this.btnRMAEdit_ApprovalRequired.Name = "btnRMAEdit_ApprovalRequired";
			this.btnRMAEdit_ApprovalRequired.Size = new System.Drawing.Size(164, 23);
			this.btnRMAEdit_ApprovalRequired.TabIndex = 14;
			this.btnRMAEdit_ApprovalRequired.Text = "NR Approval Required";
			this.btnRMAEdit_ApprovalRequired.UseVisualStyleBackColor = false;
			this.btnRMAEdit_ApprovalRequired.Visible = false;
			this.btnRMAEdit_ApprovalRequired.Click += new System.EventHandler(this.btnRMAEdit_ApprovalRequired_Click);
			// 
			// lblRMAEdit_AssignedTech
			// 
			this.lblRMAEdit_AssignedTech.AutoSize = true;
			this.lblRMAEdit_AssignedTech.Location = new System.Drawing.Point(243, 12);
			this.lblRMAEdit_AssignedTech.Name = "lblRMAEdit_AssignedTech";
			this.lblRMAEdit_AssignedTech.Size = new System.Drawing.Size(83, 16);
			this.lblRMAEdit_AssignedTech.TabIndex = 3;
			this.lblRMAEdit_AssignedTech.Text = "Assigned To:";
			// 
			// cmbRMAEdit_AssignedTech
			// 
			this.cmbRMAEdit_AssignedTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRMAEdit_AssignedTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRMAEdit_AssignedTech.DropDownHeight = 250;
			this.cmbRMAEdit_AssignedTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRMAEdit_AssignedTech.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRMAEdit_AssignedTech.FormattingEnabled = true;
			this.cmbRMAEdit_AssignedTech.IntegralHeight = false;
			this.cmbRMAEdit_AssignedTech.Location = new System.Drawing.Point(333, 9);
			this.cmbRMAEdit_AssignedTech.Name = "cmbRMAEdit_AssignedTech";
			this.cmbRMAEdit_AssignedTech.Size = new System.Drawing.Size(255, 24);
			this.cmbRMAEdit_AssignedTech.TabIndex = 4;
			// 
			// btnRMAEdit_PrintScreen
			// 
			this.btnRMAEdit_PrintScreen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAEdit_PrintScreen.Location = new System.Drawing.Point(969, 2);
			this.btnRMAEdit_PrintScreen.Name = "btnRMAEdit_PrintScreen";
			this.btnRMAEdit_PrintScreen.Size = new System.Drawing.Size(92, 23);
			this.btnRMAEdit_PrintScreen.TabIndex = 13;
			this.btnRMAEdit_PrintScreen.Text = "Print Screen";
			this.btnRMAEdit_PrintScreen.UseVisualStyleBackColor = true;
			this.btnRMAEdit_PrintScreen.Click += new System.EventHandler(this.btnRMA_PrintScreen_Click);
			// 
			// btnRMAEdit_Find
			// 
			this.btnRMAEdit_Find.Location = new System.Drawing.Point(158, 9);
			this.btnRMAEdit_Find.Name = "btnRMAEdit_Find";
			this.btnRMAEdit_Find.Size = new System.Drawing.Size(77, 22);
			this.btnRMAEdit_Find.TabIndex = 2;
			this.btnRMAEdit_Find.Text = "Find RMA";
			this.btnRMAEdit_Find.UseVisualStyleBackColor = true;
			this.btnRMAEdit_Find.Click += new System.EventHandler(this.btnRMAEdit_Find_Click);
			// 
			// txtRMAEdit_RMANumber
			// 
			this.txtRMAEdit_RMANumber.Location = new System.Drawing.Point(79, 9);
			this.txtRMAEdit_RMANumber.MaxLength = 8;
			this.txtRMAEdit_RMANumber.Name = "txtRMAEdit_RMANumber";
			this.txtRMAEdit_RMANumber.Size = new System.Drawing.Size(73, 22);
			this.txtRMAEdit_RMANumber.TabIndex = 1;
			this.txtRMAEdit_RMANumber.TextChanged += new System.EventHandler(this.txtRMAEdit_TextChanged);
			// 
			// lblRMAEdit_RMAEdit
			// 
			this.lblRMAEdit_RMAEdit.AutoSize = true;
			this.lblRMAEdit_RMAEdit.Location = new System.Drawing.Point(12, 12);
			this.lblRMAEdit_RMAEdit.Name = "lblRMAEdit_RMAEdit";
			this.lblRMAEdit_RMAEdit.Size = new System.Drawing.Size(68, 16);
			this.lblRMAEdit_RMAEdit.TabIndex = 0;
			this.lblRMAEdit_RMAEdit.Text = "Edit RMA:";
			// 
			// grpRMAEdit
			// 
			this.grpRMAEdit.Controls.Add(this.txtRMAEdit_CustomerWorkOrder);
			this.grpRMAEdit.Controls.Add(this.lblRMAEdit_CustomerWorkOrder);
			this.grpRMAEdit.Controls.Add(this.txtRMAEdit_TicketNumber);
			this.grpRMAEdit.Controls.Add(this.lblRMAEdit_TicketNumber);
			this.grpRMAEdit.Controls.Add(this.txtRMAEdit_JobNumber);
			this.grpRMAEdit.Controls.Add(this.lblRMAEdit_Completed);
			this.grpRMAEdit.Controls.Add(this.chkRMAEdit_RiskKit);
			this.grpRMAEdit.Controls.Add(this.chkRMAEdit_APR);
			this.grpRMAEdit.Controls.Add(this.ucRMAPartLineEditor_Edit1);
			this.grpRMAEdit.Controls.Add(this.ucRMAPartLineEditor_Edit2);
			this.grpRMAEdit.Controls.Add(this.ucRMAPartLineEditor_Edit3);
			this.grpRMAEdit.Controls.Add(this.ucRMAPartLineEditor_Edit4);
			this.grpRMAEdit.Controls.Add(this.ucRMAPartLineEditor_Edit5);
			this.grpRMAEdit.Controls.Add(this.lblRMAEdit_JobNumber);
			this.grpRMAEdit.Controls.Add(this.txtRMAEdit_DisplayName);
			this.grpRMAEdit.Controls.Add(this.lblRMAEdit_DisplayName);
			this.grpRMAEdit.Controls.Add(this.pnlRMAEdit_Sidebar);
			this.grpRMAEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.grpRMAEdit.Location = new System.Drawing.Point(3, 52);
			this.grpRMAEdit.Name = "grpRMAEdit";
			this.grpRMAEdit.Size = new System.Drawing.Size(1056, 627);
			this.grpRMAEdit.TabIndex = 0;
			this.grpRMAEdit.TabStop = false;
			this.grpRMAEdit.Text = "Details";
			// 
			// txtRMAEdit_CustomerWorkOrder
			// 
			this.txtRMAEdit_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_CustomerWorkOrder.Location = new System.Drawing.Point(453, 40);
			this.txtRMAEdit_CustomerWorkOrder.MaxLength = 6;
			this.txtRMAEdit_CustomerWorkOrder.Name = "txtRMAEdit_CustomerWorkOrder";
			this.txtRMAEdit_CustomerWorkOrder.Size = new System.Drawing.Size(108, 22);
			this.txtRMAEdit_CustomerWorkOrder.TabIndex = 7;
			// 
			// lblRMAEdit_CustomerWorkOrder
			// 
			this.lblRMAEdit_CustomerWorkOrder.AutoSize = true;
			this.lblRMAEdit_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_CustomerWorkOrder.Location = new System.Drawing.Point(450, 21);
			this.lblRMAEdit_CustomerWorkOrder.Name = "lblRMAEdit_CustomerWorkOrder";
			this.lblRMAEdit_CustomerWorkOrder.Size = new System.Drawing.Size(102, 16);
			this.lblRMAEdit_CustomerWorkOrder.TabIndex = 6;
			this.lblRMAEdit_CustomerWorkOrder.Text = "Customer WO#";
			this.lblRMAEdit_CustomerWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMAEdit_TicketNumber
			// 
			this.txtRMAEdit_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_TicketNumber.Location = new System.Drawing.Point(339, 40);
			this.txtRMAEdit_TicketNumber.MaxLength = 6;
			this.txtRMAEdit_TicketNumber.Name = "txtRMAEdit_TicketNumber";
			this.txtRMAEdit_TicketNumber.Size = new System.Drawing.Size(108, 22);
			this.txtRMAEdit_TicketNumber.TabIndex = 5;
			this.txtRMAEdit_TicketNumber.DoubleClick += new System.EventHandler(this.txtRMAEdit_TicketNumber_DoubleClick);
			// 
			// lblRMAEdit_TicketNumber
			// 
			this.lblRMAEdit_TicketNumber.AutoSize = true;
			this.lblRMAEdit_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_TicketNumber.Location = new System.Drawing.Point(336, 21);
			this.lblRMAEdit_TicketNumber.Name = "lblRMAEdit_TicketNumber";
			this.lblRMAEdit_TicketNumber.Size = new System.Drawing.Size(100, 16);
			this.lblRMAEdit_TicketNumber.TabIndex = 4;
			this.lblRMAEdit_TicketNumber.Text = "Ticket Number";
			this.lblRMAEdit_TicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMAEdit_JobNumber
			// 
			this.txtRMAEdit_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_JobNumber.Location = new System.Drawing.Point(225, 41);
			this.txtRMAEdit_JobNumber.MaxLength = 10;
			this.txtRMAEdit_JobNumber.Name = "txtRMAEdit_JobNumber";
			this.txtRMAEdit_JobNumber.Size = new System.Drawing.Size(108, 22);
			this.txtRMAEdit_JobNumber.TabIndex = 3;
			// 
			// lblRMAEdit_Completed
			// 
			this.lblRMAEdit_Completed.BackColor = System.Drawing.Color.LawnGreen;
			this.lblRMAEdit_Completed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_Completed.Location = new System.Drawing.Point(8, 18);
			this.lblRMAEdit_Completed.Name = "lblRMAEdit_Completed";
			this.lblRMAEdit_Completed.Size = new System.Drawing.Size(110, 20);
			this.lblRMAEdit_Completed.TabIndex = 0;
			this.lblRMAEdit_Completed.Text = "CLOSED";
			this.lblRMAEdit_Completed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRMAEdit_Completed.Visible = false;
			// 
			// chkRMAEdit_RiskKit
			// 
			this.chkRMAEdit_RiskKit.AutoSize = true;
			this.chkRMAEdit_RiskKit.Location = new System.Drawing.Point(824, 43);
			this.chkRMAEdit_RiskKit.Name = "chkRMAEdit_RiskKit";
			this.chkRMAEdit_RiskKit.Size = new System.Drawing.Size(73, 20);
			this.chkRMAEdit_RiskKit.TabIndex = 11;
			this.chkRMAEdit_RiskKit.Text = "Risk Kit";
			this.chkRMAEdit_RiskKit.UseVisualStyleBackColor = true;
			this.chkRMAEdit_RiskKit.CheckedChanged += new System.EventHandler(this.chkRMAEdit_RiskKit_CheckedChanged);
			// 
			// chkRMAEdit_APR
			// 
			this.chkRMAEdit_APR.AutoSize = true;
			this.chkRMAEdit_APR.Location = new System.Drawing.Point(824, 23);
			this.chkRMAEdit_APR.Name = "chkRMAEdit_APR";
			this.chkRMAEdit_APR.Size = new System.Drawing.Size(54, 20);
			this.chkRMAEdit_APR.TabIndex = 10;
			this.chkRMAEdit_APR.Text = "APR";
			this.chkRMAEdit_APR.UseVisualStyleBackColor = true;
			this.chkRMAEdit_APR.CheckedChanged += new System.EventHandler(this.chkRMAEdit_APR_CheckedChanged);
			// 
			// ucRMAPartLineEditor_Edit1
			// 
			this.ucRMAPartLineEditor_Edit1.Location = new System.Drawing.Point(2, 69);
			this.ucRMAPartLineEditor_Edit1.Name = "ucRMAPartLineEditor_Edit1";
			this.ucRMAPartLineEditor_Edit1.Priority = null;
			this.ucRMAPartLineEditor_Edit1.Problem = null;
			this.ucRMAPartLineEditor_Edit1.Qty = 0;
			this.ucRMAPartLineEditor_Edit1.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Edit1.TabIndex = 8;
			// 
			// ucRMAPartLineEditor_Edit2
			// 
			this.ucRMAPartLineEditor_Edit2.Location = new System.Drawing.Point(2, 184);
			this.ucRMAPartLineEditor_Edit2.Name = "ucRMAPartLineEditor_Edit2";
			this.ucRMAPartLineEditor_Edit2.Priority = null;
			this.ucRMAPartLineEditor_Edit2.Problem = null;
			this.ucRMAPartLineEditor_Edit2.Qty = 0;
			this.ucRMAPartLineEditor_Edit2.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Edit2.TabIndex = 9;
			// 
			// ucRMAPartLineEditor_Edit3
			// 
			this.ucRMAPartLineEditor_Edit3.Location = new System.Drawing.Point(2, 299);
			this.ucRMAPartLineEditor_Edit3.Name = "ucRMAPartLineEditor_Edit3";
			this.ucRMAPartLineEditor_Edit3.Priority = null;
			this.ucRMAPartLineEditor_Edit3.Problem = null;
			this.ucRMAPartLineEditor_Edit3.Qty = 0;
			this.ucRMAPartLineEditor_Edit3.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Edit3.TabIndex = 10;
			// 
			// ucRMAPartLineEditor_Edit4
			// 
			this.ucRMAPartLineEditor_Edit4.Location = new System.Drawing.Point(2, 414);
			this.ucRMAPartLineEditor_Edit4.Name = "ucRMAPartLineEditor_Edit4";
			this.ucRMAPartLineEditor_Edit4.Priority = null;
			this.ucRMAPartLineEditor_Edit4.Problem = null;
			this.ucRMAPartLineEditor_Edit4.Qty = 0;
			this.ucRMAPartLineEditor_Edit4.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Edit4.TabIndex = 11;
			// 
			// ucRMAPartLineEditor_Edit5
			// 
			this.ucRMAPartLineEditor_Edit5.Location = new System.Drawing.Point(2, 529);
			this.ucRMAPartLineEditor_Edit5.Name = "ucRMAPartLineEditor_Edit5";
			this.ucRMAPartLineEditor_Edit5.Priority = null;
			this.ucRMAPartLineEditor_Edit5.Problem = null;
			this.ucRMAPartLineEditor_Edit5.Qty = 0;
			this.ucRMAPartLineEditor_Edit5.Size = new System.Drawing.Size(895, 88);
			this.ucRMAPartLineEditor_Edit5.TabIndex = 12;
			// 
			// lblRMAEdit_JobNumber
			// 
			this.lblRMAEdit_JobNumber.AutoSize = true;
			this.lblRMAEdit_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_JobNumber.Location = new System.Drawing.Point(222, 21);
			this.lblRMAEdit_JobNumber.Name = "lblRMAEdit_JobNumber";
			this.lblRMAEdit_JobNumber.Size = new System.Drawing.Size(85, 16);
			this.lblRMAEdit_JobNumber.TabIndex = 2;
			this.lblRMAEdit_JobNumber.Text = "Job Number";
			this.lblRMAEdit_JobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMAEdit_DisplayName
			// 
			this.txtRMAEdit_DisplayName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_DisplayName.Location = new System.Drawing.Point(9, 41);
			this.txtRMAEdit_DisplayName.MaxLength = 100;
			this.txtRMAEdit_DisplayName.Name = "txtRMAEdit_DisplayName";
			this.txtRMAEdit_DisplayName.ReadOnly = true;
			this.txtRMAEdit_DisplayName.Size = new System.Drawing.Size(210, 22);
			this.txtRMAEdit_DisplayName.TabIndex = 1;
			this.txtRMAEdit_DisplayName.TabStop = false;
			// 
			// lblRMAEdit_DisplayName
			// 
			this.lblRMAEdit_DisplayName.AutoSize = true;
			this.lblRMAEdit_DisplayName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_DisplayName.Location = new System.Drawing.Point(6, 22);
			this.lblRMAEdit_DisplayName.Name = "lblRMAEdit_DisplayName";
			this.lblRMAEdit_DisplayName.Size = new System.Drawing.Size(95, 16);
			this.lblRMAEdit_DisplayName.TabIndex = 0;
			this.lblRMAEdit_DisplayName.Text = "Display Name";
			this.lblRMAEdit_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlRMAEdit_Sidebar
			// 
			this.pnlRMAEdit_Sidebar.Controls.Add(this.txtRMAEdit_CustomerRequests);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.txtRMAEdit_YescoNotes);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_YescoNotes);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.dtpRMAEdit_DateIssued);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.btnRMAEdit_Update);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.txtRMAEdit_Tracking);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.txtRMAEdit_AuthBy);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.txtRMAEdit_PO);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_CustomerRequests);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_Tracking);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_DateIssued);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_AuthBy);
			this.pnlRMAEdit_Sidebar.Controls.Add(this.lblRMAEdit_PO);
			this.pnlRMAEdit_Sidebar.Location = new System.Drawing.Point(900, 24);
			this.pnlRMAEdit_Sidebar.Name = "pnlRMAEdit_Sidebar";
			this.pnlRMAEdit_Sidebar.Size = new System.Drawing.Size(155, 594);
			this.pnlRMAEdit_Sidebar.TabIndex = 13;
			// 
			// txtRMAEdit_CustomerRequests
			// 
			this.txtRMAEdit_CustomerRequests.AcceptsReturn = true;
			this.txtRMAEdit_CustomerRequests.Location = new System.Drawing.Point(3, 399);
			this.txtRMAEdit_CustomerRequests.MaxLength = 200;
			this.txtRMAEdit_CustomerRequests.Multiline = true;
			this.txtRMAEdit_CustomerRequests.Name = "txtRMAEdit_CustomerRequests";
			this.txtRMAEdit_CustomerRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMAEdit_CustomerRequests.Size = new System.Drawing.Size(149, 162);
			this.txtRMAEdit_CustomerRequests.TabIndex = 15;
			// 
			// txtRMAEdit_YescoNotes
			// 
			this.txtRMAEdit_YescoNotes.AcceptsReturn = true;
			this.txtRMAEdit_YescoNotes.Location = new System.Drawing.Point(3, 214);
			this.txtRMAEdit_YescoNotes.MaxLength = 150;
			this.txtRMAEdit_YescoNotes.Multiline = true;
			this.txtRMAEdit_YescoNotes.Name = "txtRMAEdit_YescoNotes";
			this.txtRMAEdit_YescoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMAEdit_YescoNotes.Size = new System.Drawing.Size(149, 162);
			this.txtRMAEdit_YescoNotes.TabIndex = 14;
			// 
			// lblRMAEdit_YescoNotes
			// 
			this.lblRMAEdit_YescoNotes.AutoSize = true;
			this.lblRMAEdit_YescoNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_YescoNotes.Location = new System.Drawing.Point(0, 195);
			this.lblRMAEdit_YescoNotes.Name = "lblRMAEdit_YescoNotes";
			this.lblRMAEdit_YescoNotes.Size = new System.Drawing.Size(87, 16);
			this.lblRMAEdit_YescoNotes.TabIndex = 13;
			this.lblRMAEdit_YescoNotes.Tag = "rmanote";
			this.lblRMAEdit_YescoNotes.Text = "Yesco Notes:";
			this.lblRMAEdit_YescoNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtpRMAEdit_DateIssued
			// 
			this.dtpRMAEdit_DateIssued.CustomFormat = "yyyy-MM-dd";
			this.dtpRMAEdit_DateIssued.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRMAEdit_DateIssued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRMAEdit_DateIssued.Location = new System.Drawing.Point(3, 92);
			this.dtpRMAEdit_DateIssued.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.dtpRMAEdit_DateIssued.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.dtpRMAEdit_DateIssued.Name = "dtpRMAEdit_DateIssued";
			this.dtpRMAEdit_DateIssued.Size = new System.Drawing.Size(147, 22);
			this.dtpRMAEdit_DateIssued.TabIndex = 5;
			this.dtpRMAEdit_DateIssued.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			// 
			// btnRMAEdit_Update
			// 
			this.btnRMAEdit_Update.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAEdit_Update.Location = new System.Drawing.Point(3, 567);
			this.btnRMAEdit_Update.Name = "btnRMAEdit_Update";
			this.btnRMAEdit_Update.Size = new System.Drawing.Size(149, 27);
			this.btnRMAEdit_Update.TabIndex = 12;
			this.btnRMAEdit_Update.Text = "Update RMA";
			this.btnRMAEdit_Update.UseVisualStyleBackColor = true;
			this.btnRMAEdit_Update.Click += new System.EventHandler(this.btnRMAEdit_Update_Click);
			// 
			// txtRMAEdit_Tracking
			// 
			this.txtRMAEdit_Tracking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_Tracking.Location = new System.Drawing.Point(3, 130);
			this.txtRMAEdit_Tracking.MaxLength = 40;
			this.txtRMAEdit_Tracking.Name = "txtRMAEdit_Tracking";
			this.txtRMAEdit_Tracking.Size = new System.Drawing.Size(147, 22);
			this.txtRMAEdit_Tracking.TabIndex = 7;
			// 
			// txtRMAEdit_AuthBy
			// 
			this.txtRMAEdit_AuthBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_AuthBy.Location = new System.Drawing.Point(3, 54);
			this.txtRMAEdit_AuthBy.MaxLength = 20;
			this.txtRMAEdit_AuthBy.Name = "txtRMAEdit_AuthBy";
			this.txtRMAEdit_AuthBy.Size = new System.Drawing.Size(147, 22);
			this.txtRMAEdit_AuthBy.TabIndex = 3;
			// 
			// txtRMAEdit_PO
			// 
			this.txtRMAEdit_PO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAEdit_PO.Location = new System.Drawing.Point(3, 16);
			this.txtRMAEdit_PO.MaxLength = 10;
			this.txtRMAEdit_PO.Name = "txtRMAEdit_PO";
			this.txtRMAEdit_PO.Size = new System.Drawing.Size(147, 22);
			this.txtRMAEdit_PO.TabIndex = 1;
			// 
			// lblRMAEdit_CustomerRequests
			// 
			this.lblRMAEdit_CustomerRequests.AutoSize = true;
			this.lblRMAEdit_CustomerRequests.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_CustomerRequests.Location = new System.Drawing.Point(2, 380);
			this.lblRMAEdit_CustomerRequests.Name = "lblRMAEdit_CustomerRequests";
			this.lblRMAEdit_CustomerRequests.Size = new System.Drawing.Size(133, 16);
			this.lblRMAEdit_CustomerRequests.TabIndex = 10;
			this.lblRMAEdit_CustomerRequests.Tag = "specialreq";
			this.lblRMAEdit_CustomerRequests.Text = "Customer Requests:";
			this.lblRMAEdit_CustomerRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMAEdit_Tracking
			// 
			this.lblRMAEdit_Tracking.AutoSize = true;
			this.lblRMAEdit_Tracking.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_Tracking.Location = new System.Drawing.Point(3, 114);
			this.lblRMAEdit_Tracking.Name = "lblRMAEdit_Tracking";
			this.lblRMAEdit_Tracking.Size = new System.Drawing.Size(77, 16);
			this.lblRMAEdit_Tracking.TabIndex = 6;
			this.lblRMAEdit_Tracking.Text = "Tracking #:";
			this.lblRMAEdit_Tracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMAEdit_DateIssued
			// 
			this.lblRMAEdit_DateIssued.AutoSize = true;
			this.lblRMAEdit_DateIssued.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_DateIssued.Location = new System.Drawing.Point(3, 76);
			this.lblRMAEdit_DateIssued.Name = "lblRMAEdit_DateIssued";
			this.lblRMAEdit_DateIssued.Size = new System.Drawing.Size(118, 16);
			this.lblRMAEdit_DateIssued.TabIndex = 4;
			this.lblRMAEdit_DateIssued.Text = "Date RMA Issued:";
			this.lblRMAEdit_DateIssued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMAEdit_AuthBy
			// 
			this.lblRMAEdit_AuthBy.AutoSize = true;
			this.lblRMAEdit_AuthBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_AuthBy.Location = new System.Drawing.Point(3, 38);
			this.lblRMAEdit_AuthBy.Name = "lblRMAEdit_AuthBy";
			this.lblRMAEdit_AuthBy.Size = new System.Drawing.Size(140, 16);
			this.lblRMAEdit_AuthBy.TabIndex = 2;
			this.lblRMAEdit_AuthBy.Text = "Auth by (Supervisor):";
			this.lblRMAEdit_AuthBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMAEdit_PO
			// 
			this.lblRMAEdit_PO.AutoSize = true;
			this.lblRMAEdit_PO.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAEdit_PO.Location = new System.Drawing.Point(3, 0);
			this.lblRMAEdit_PO.Name = "lblRMAEdit_PO";
			this.lblRMAEdit_PO.Size = new System.Drawing.Size(42, 16);
			this.lblRMAEdit_PO.TabIndex = 0;
			this.lblRMAEdit_PO.Text = "PO #:";
			this.lblRMAEdit_PO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabRMAJobLog
			// 
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_CustomerWorkOrder);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_TicketNumber);
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_TicketNumber);
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_CustomerRequests);
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_YescoNotes);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_CustomerRequests);
			this.tabRMAJobLog.Controls.Add(this.btnRMAJobLog_CreateShipper);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_NoReturnApproval);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_JobNumber);
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_JobNumber);
			this.tabRMAJobLog.Controls.Add(this.txtRMAJobLog_DisplayName);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_DisplayName);
			this.tabRMAJobLog.Controls.Add(this.btnRMAJobLog_PrintScreen);
			this.tabRMAJobLog.Controls.Add(this.btnRMAJobLog_EnterBottom);
			this.tabRMAJobLog.Controls.Add(this.btnRMAJobLog_EnterTop);
			this.tabRMAJobLog.Controls.Add(this.lblRMAJobLog_YescoNotes);
			this.tabRMAJobLog.Controls.Add(this.pnlRMAJobLog_Header);
			this.tabRMAJobLog.Controls.Add(this.pnlRMAJobLog_Completed);
			this.tabRMAJobLog.Controls.Add(this.ucRMAJobLogLine5);
			this.tabRMAJobLog.Controls.Add(this.ucRMAJobLogLine4);
			this.tabRMAJobLog.Controls.Add(this.ucRMAJobLogLine3);
			this.tabRMAJobLog.Controls.Add(this.ucRMAJobLogLine2);
			this.tabRMAJobLog.Controls.Add(this.ucRMAJobLogLine1);
			this.tabRMAJobLog.Location = new System.Drawing.Point(4, 22);
			this.tabRMAJobLog.Name = "tabRMAJobLog";
			this.tabRMAJobLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAJobLog.Size = new System.Drawing.Size(1062, 682);
			this.tabRMAJobLog.TabIndex = 6;
			this.tabRMAJobLog.Text = "Job Log";
			this.tabRMAJobLog.UseVisualStyleBackColor = true;
			// 
			// txtRMAJobLog_CustomerWorkOrder
			// 
			this.txtRMAJobLog_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAJobLog_CustomerWorkOrder.Location = new System.Drawing.Point(529, 644);
			this.txtRMAJobLog_CustomerWorkOrder.MaxLength = 10;
			this.txtRMAJobLog_CustomerWorkOrder.Name = "txtRMAJobLog_CustomerWorkOrder";
			this.txtRMAJobLog_CustomerWorkOrder.ReadOnly = true;
			this.txtRMAJobLog_CustomerWorkOrder.Size = new System.Drawing.Size(66, 20);
			this.txtRMAJobLog_CustomerWorkOrder.TabIndex = 22;
			this.txtRMAJobLog_CustomerWorkOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRMAJobLog_TicketNumber
			// 
			this.lblRMAJobLog_TicketNumber.AutoSize = true;
			this.lblRMAJobLog_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_TicketNumber.Location = new System.Drawing.Point(311, 7);
			this.lblRMAJobLog_TicketNumber.Name = "lblRMAJobLog_TicketNumber";
			this.lblRMAJobLog_TicketNumber.Size = new System.Drawing.Size(46, 16);
			this.lblRMAJobLog_TicketNumber.TabIndex = 20;
			this.lblRMAJobLog_TicketNumber.Text = "Ticket";
			this.lblRMAJobLog_TicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMAJobLog_TicketNumber
			// 
			this.txtRMAJobLog_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAJobLog_TicketNumber.Location = new System.Drawing.Point(363, 4);
			this.txtRMAJobLog_TicketNumber.MaxLength = 10;
			this.txtRMAJobLog_TicketNumber.Name = "txtRMAJobLog_TicketNumber";
			this.txtRMAJobLog_TicketNumber.ReadOnly = true;
			this.txtRMAJobLog_TicketNumber.Size = new System.Drawing.Size(80, 22);
			this.txtRMAJobLog_TicketNumber.TabIndex = 21;
			this.txtRMAJobLog_TicketNumber.DoubleClick += new System.EventHandler(this.txtRMAJobLog_TicketNumber_DoubleClick);
			// 
			// txtRMAJobLog_CustomerRequests
			// 
			this.txtRMAJobLog_CustomerRequests.AcceptsReturn = true;
			this.txtRMAJobLog_CustomerRequests.Location = new System.Drawing.Point(601, 610);
			this.txtRMAJobLog_CustomerRequests.MaxLength = 200;
			this.txtRMAJobLog_CustomerRequests.Multiline = true;
			this.txtRMAJobLog_CustomerRequests.Name = "txtRMAJobLog_CustomerRequests";
			this.txtRMAJobLog_CustomerRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMAJobLog_CustomerRequests.Size = new System.Drawing.Size(460, 69);
			this.txtRMAJobLog_CustomerRequests.TabIndex = 11;
			// 
			// txtRMAJobLog_YescoNotes
			// 
			this.txtRMAJobLog_YescoNotes.AcceptsReturn = true;
			this.txtRMAJobLog_YescoNotes.Location = new System.Drawing.Point(57, 610);
			this.txtRMAJobLog_YescoNotes.MaxLength = 150;
			this.txtRMAJobLog_YescoNotes.Multiline = true;
			this.txtRMAJobLog_YescoNotes.Name = "txtRMAJobLog_YescoNotes";
			this.txtRMAJobLog_YescoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMAJobLog_YescoNotes.Size = new System.Drawing.Size(460, 69);
			this.txtRMAJobLog_YescoNotes.TabIndex = 9;
			// 
			// lblRMAJobLog_CustomerRequests
			// 
			this.lblRMAJobLog_CustomerRequests.AutoSize = true;
			this.lblRMAJobLog_CustomerRequests.Location = new System.Drawing.Point(540, 610);
			this.lblRMAJobLog_CustomerRequests.Name = "lblRMAJobLog_CustomerRequests";
			this.lblRMAJobLog_CustomerRequests.Size = new System.Drawing.Size(55, 26);
			this.lblRMAJobLog_CustomerRequests.TabIndex = 10;
			this.lblRMAJobLog_CustomerRequests.Text = "Customer\r\nRequests:";
			// 
			// btnRMAJobLog_CreateShipper
			// 
			this.btnRMAJobLog_CreateShipper.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAJobLog_CreateShipper.Location = new System.Drawing.Point(925, 33);
			this.btnRMAJobLog_CreateShipper.Name = "btnRMAJobLog_CreateShipper";
			this.btnRMAJobLog_CreateShipper.Size = new System.Drawing.Size(136, 23);
			this.btnRMAJobLog_CreateShipper.TabIndex = 13;
			this.btnRMAJobLog_CreateShipper.Text = "Create Shipment";
			this.btnRMAJobLog_CreateShipper.UseVisualStyleBackColor = true;
			this.btnRMAJobLog_CreateShipper.Click += new System.EventHandler(this.btnRMAJobLog_CreateShipper_Click);
			// 
			// lblRMAJobLog_NoReturnApproval
			// 
			this.lblRMAJobLog_NoReturnApproval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRMAJobLog_NoReturnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_NoReturnApproval.Location = new System.Drawing.Point(925, 516);
			this.lblRMAJobLog_NoReturnApproval.Name = "lblRMAJobLog_NoReturnApproval";
			this.lblRMAJobLog_NoReturnApproval.Size = new System.Drawing.Size(136, 42);
			this.lblRMAJobLog_NoReturnApproval.TabIndex = 18;
			this.lblRMAJobLog_NoReturnApproval.Text = "NR Approval Status";
			this.lblRMAJobLog_NoReturnApproval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRMAJobLog_NoReturnApproval.Visible = false;
			// 
			// lblRMAJobLog_JobNumber
			// 
			this.lblRMAJobLog_JobNumber.AutoSize = true;
			this.lblRMAJobLog_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_JobNumber.Location = new System.Drawing.Point(178, 7);
			this.lblRMAJobLog_JobNumber.Name = "lblRMAJobLog_JobNumber";
			this.lblRMAJobLog_JobNumber.Size = new System.Drawing.Size(31, 16);
			this.lblRMAJobLog_JobNumber.TabIndex = 0;
			this.lblRMAJobLog_JobNumber.Text = "Job";
			this.lblRMAJobLog_JobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRMAJobLog_JobNumber
			// 
			this.txtRMAJobLog_JobNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAJobLog_JobNumber.Location = new System.Drawing.Point(215, 4);
			this.txtRMAJobLog_JobNumber.MaxLength = 10;
			this.txtRMAJobLog_JobNumber.Name = "txtRMAJobLog_JobNumber";
			this.txtRMAJobLog_JobNumber.ReadOnly = true;
			this.txtRMAJobLog_JobNumber.Size = new System.Drawing.Size(90, 22);
			this.txtRMAJobLog_JobNumber.TabIndex = 1;
			// 
			// txtRMAJobLog_DisplayName
			// 
			this.txtRMAJobLog_DisplayName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAJobLog_DisplayName.Location = new System.Drawing.Point(505, 4);
			this.txtRMAJobLog_DisplayName.MaxLength = 100;
			this.txtRMAJobLog_DisplayName.Name = "txtRMAJobLog_DisplayName";
			this.txtRMAJobLog_DisplayName.ReadOnly = true;
			this.txtRMAJobLog_DisplayName.Size = new System.Drawing.Size(235, 22);
			this.txtRMAJobLog_DisplayName.TabIndex = 2;
			// 
			// lblRMAJobLog_DisplayName
			// 
			this.lblRMAJobLog_DisplayName.AutoSize = true;
			this.lblRMAJobLog_DisplayName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_DisplayName.Location = new System.Drawing.Point(449, 7);
			this.lblRMAJobLog_DisplayName.Name = "lblRMAJobLog_DisplayName";
			this.lblRMAJobLog_DisplayName.Size = new System.Drawing.Size(54, 16);
			this.lblRMAJobLog_DisplayName.TabIndex = 1;
			this.lblRMAJobLog_DisplayName.Text = "Display";
			this.lblRMAJobLog_DisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRMAJobLog_PrintScreen
			// 
			this.btnRMAJobLog_PrintScreen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAJobLog_PrintScreen.Location = new System.Drawing.Point(969, 2);
			this.btnRMAJobLog_PrintScreen.Name = "btnRMAJobLog_PrintScreen";
			this.btnRMAJobLog_PrintScreen.Size = new System.Drawing.Size(92, 23);
			this.btnRMAJobLog_PrintScreen.TabIndex = 17;
			this.btnRMAJobLog_PrintScreen.Text = "Print Screen";
			this.btnRMAJobLog_PrintScreen.UseVisualStyleBackColor = true;
			this.btnRMAJobLog_PrintScreen.Click += new System.EventHandler(this.btnRMA_PrintScreen_Click);
			// 
			// btnRMAJobLog_EnterBottom
			// 
			this.btnRMAJobLog_EnterBottom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAJobLog_EnterBottom.Location = new System.Drawing.Point(925, 565);
			this.btnRMAJobLog_EnterBottom.Name = "btnRMAJobLog_EnterBottom";
			this.btnRMAJobLog_EnterBottom.Size = new System.Drawing.Size(136, 44);
			this.btnRMAJobLog_EnterBottom.TabIndex = 19;
			this.btnRMAJobLog_EnterBottom.Text = "Enter Information";
			this.btnRMAJobLog_EnterBottom.UseVisualStyleBackColor = true;
			this.btnRMAJobLog_EnterBottom.Click += new System.EventHandler(this.btnRMAJobLog_EnterBottom_Click);
			// 
			// btnRMAJobLog_EnterTop
			// 
			this.btnRMAJobLog_EnterTop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAJobLog_EnterTop.Location = new System.Drawing.Point(764, 29);
			this.btnRMAJobLog_EnterTop.Name = "btnRMAJobLog_EnterTop";
			this.btnRMAJobLog_EnterTop.Size = new System.Drawing.Size(155, 30);
			this.btnRMAJobLog_EnterTop.TabIndex = 12;
			this.btnRMAJobLog_EnterTop.Text = "Enter Information";
			this.btnRMAJobLog_EnterTop.UseVisualStyleBackColor = true;
			this.btnRMAJobLog_EnterTop.Click += new System.EventHandler(this.btnRMAJobLog_EnterTop_Click);
			// 
			// lblRMAJobLog_YescoNotes
			// 
			this.lblRMAJobLog_YescoNotes.AutoSize = true;
			this.lblRMAJobLog_YescoNotes.Location = new System.Drawing.Point(13, 612);
			this.lblRMAJobLog_YescoNotes.Name = "lblRMAJobLog_YescoNotes";
			this.lblRMAJobLog_YescoNotes.Size = new System.Drawing.Size(38, 26);
			this.lblRMAJobLog_YescoNotes.TabIndex = 8;
			this.lblRMAJobLog_YescoNotes.Text = "Yesco\r\nNotes:";
			// 
			// pnlRMAJobLog_Header
			// 
			this.pnlRMAJobLog_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlRMAJobLog_Header.Controls.Add(this.txtRMAJobLog_WorkOrders);
			this.pnlRMAJobLog_Header.Controls.Add(this.lblRMAJobLogShow_PurchaseOrder);
			this.pnlRMAJobLog_Header.Controls.Add(this.lblRMAJobLogShow_RMANumber);
			this.pnlRMAJobLog_Header.Controls.Add(this.lblRMAJobLog_WorkOrders);
			this.pnlRMAJobLog_Header.Controls.Add(this.lblRMAJobLog_PurchaseOrder);
			this.pnlRMAJobLog_Header.Controls.Add(this.lblRMAJobLog_RMANumber);
			this.pnlRMAJobLog_Header.Location = new System.Drawing.Point(6, 28);
			this.pnlRMAJobLog_Header.Name = "pnlRMAJobLog_Header";
			this.pnlRMAJobLog_Header.Size = new System.Drawing.Size(734, 30);
			this.pnlRMAJobLog_Header.TabIndex = 3;
			// 
			// txtRMAJobLog_WorkOrders
			// 
			this.txtRMAJobLog_WorkOrders.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAJobLog_WorkOrders.Location = new System.Drawing.Point(301, 4);
			this.txtRMAJobLog_WorkOrders.MaxLength = 255;
			this.txtRMAJobLog_WorkOrders.Name = "txtRMAJobLog_WorkOrders";
			this.txtRMAJobLog_WorkOrders.Size = new System.Drawing.Size(428, 20);
			this.txtRMAJobLog_WorkOrders.TabIndex = 5;
			// 
			// lblRMAJobLogShow_PurchaseOrder
			// 
			this.lblRMAJobLogShow_PurchaseOrder.BackColor = System.Drawing.Color.Transparent;
			this.lblRMAJobLogShow_PurchaseOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLogShow_PurchaseOrder.ForeColor = System.Drawing.Color.Navy;
			this.lblRMAJobLogShow_PurchaseOrder.Location = new System.Drawing.Point(149, 5);
			this.lblRMAJobLogShow_PurchaseOrder.Name = "lblRMAJobLogShow_PurchaseOrder";
			this.lblRMAJobLogShow_PurchaseOrder.Size = new System.Drawing.Size(70, 18);
			this.lblRMAJobLogShow_PurchaseOrder.TabIndex = 3;
			// 
			// lblRMAJobLogShow_RMANumber
			// 
			this.lblRMAJobLogShow_RMANumber.BackColor = System.Drawing.Color.Transparent;
			this.lblRMAJobLogShow_RMANumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLogShow_RMANumber.ForeColor = System.Drawing.Color.Navy;
			this.lblRMAJobLogShow_RMANumber.Location = new System.Drawing.Point(57, 5);
			this.lblRMAJobLogShow_RMANumber.Name = "lblRMAJobLogShow_RMANumber";
			this.lblRMAJobLogShow_RMANumber.Size = new System.Drawing.Size(50, 18);
			this.lblRMAJobLogShow_RMANumber.TabIndex = 1;
			// 
			// lblRMAJobLog_WorkOrders
			// 
			this.lblRMAJobLog_WorkOrders.AutoSize = true;
			this.lblRMAJobLog_WorkOrders.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_WorkOrders.Location = new System.Drawing.Point(219, 6);
			this.lblRMAJobLog_WorkOrders.Name = "lblRMAJobLog_WorkOrders";
			this.lblRMAJobLog_WorkOrders.Size = new System.Drawing.Size(84, 15);
			this.lblRMAJobLog_WorkOrders.TabIndex = 4;
			this.lblRMAJobLog_WorkOrders.Text = "Work Orders:";
			// 
			// lblRMAJobLog_PurchaseOrder
			// 
			this.lblRMAJobLog_PurchaseOrder.AutoSize = true;
			this.lblRMAJobLog_PurchaseOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_PurchaseOrder.Location = new System.Drawing.Point(107, 5);
			this.lblRMAJobLog_PurchaseOrder.Name = "lblRMAJobLog_PurchaseOrder";
			this.lblRMAJobLog_PurchaseOrder.Size = new System.Drawing.Size(42, 16);
			this.lblRMAJobLog_PurchaseOrder.TabIndex = 2;
			this.lblRMAJobLog_PurchaseOrder.Text = "PO #:";
			// 
			// lblRMAJobLog_RMANumber
			// 
			this.lblRMAJobLog_RMANumber.AutoSize = true;
			this.lblRMAJobLog_RMANumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAJobLog_RMANumber.Location = new System.Drawing.Point(5, 5);
			this.lblRMAJobLog_RMANumber.Name = "lblRMAJobLog_RMANumber";
			this.lblRMAJobLog_RMANumber.Size = new System.Drawing.Size(52, 16);
			this.lblRMAJobLog_RMANumber.TabIndex = 0;
			this.lblRMAJobLog_RMANumber.Text = "RMA #:";
			// 
			// pnlRMAJobLog_Completed
			// 
			this.pnlRMAJobLog_Completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlRMAJobLog_Completed.Controls.Add(this.radRMAJobLog_CompletedNo);
			this.pnlRMAJobLog_Completed.Controls.Add(this.radRMAJobLog_CompletedYes);
			this.pnlRMAJobLog_Completed.Controls.Add(this.lblRMAJobLog_Completed);
			this.pnlRMAJobLog_Completed.Location = new System.Drawing.Point(6, 2);
			this.pnlRMAJobLog_Completed.Name = "pnlRMAJobLog_Completed";
			this.pnlRMAJobLog_Completed.Size = new System.Drawing.Size(166, 24);
			this.pnlRMAJobLog_Completed.TabIndex = 2;
			this.pnlRMAJobLog_Completed.Enter += new System.EventHandler(this.pnlRMAJobLog_Completed_Enter);
			// 
			// radRMAJobLog_CompletedNo
			// 
			this.radRMAJobLog_CompletedNo.AutoSize = true;
			this.radRMAJobLog_CompletedNo.Location = new System.Drawing.Point(122, 2);
			this.radRMAJobLog_CompletedNo.Name = "radRMAJobLog_CompletedNo";
			this.radRMAJobLog_CompletedNo.Size = new System.Drawing.Size(39, 17);
			this.radRMAJobLog_CompletedNo.TabIndex = 2;
			this.radRMAJobLog_CompletedNo.TabStop = true;
			this.radRMAJobLog_CompletedNo.Text = "No";
			this.radRMAJobLog_CompletedNo.UseVisualStyleBackColor = true;
			// 
			// radRMAJobLog_CompletedYes
			// 
			this.radRMAJobLog_CompletedYes.AutoSize = true;
			this.radRMAJobLog_CompletedYes.Location = new System.Drawing.Point(73, 2);
			this.radRMAJobLog_CompletedYes.Name = "radRMAJobLog_CompletedYes";
			this.radRMAJobLog_CompletedYes.Size = new System.Drawing.Size(43, 17);
			this.radRMAJobLog_CompletedYes.TabIndex = 1;
			this.radRMAJobLog_CompletedYes.TabStop = true;
			this.radRMAJobLog_CompletedYes.Text = "Yes";
			this.radRMAJobLog_CompletedYes.UseVisualStyleBackColor = true;
			this.radRMAJobLog_CompletedYes.CheckedChanged += new System.EventHandler(this.radRMAJobLog_CompletedYes_CheckedChanged);
			// 
			// lblRMAJobLog_Completed
			// 
			this.lblRMAJobLog_Completed.AutoSize = true;
			this.lblRMAJobLog_Completed.Location = new System.Drawing.Point(4, 4);
			this.lblRMAJobLog_Completed.Name = "lblRMAJobLog_Completed";
			this.lblRMAJobLog_Completed.Size = new System.Drawing.Size(63, 13);
			this.lblRMAJobLog_Completed.TabIndex = 0;
			this.lblRMAJobLog_Completed.Text = "Completed?";
			// 
			// ucRMAJobLogLine5
			// 
			this.ucRMAJobLogLine5.Location = new System.Drawing.Point(14, 500);
			this.ucRMAJobLogLine5.Name = "ucRMAJobLogLine5";
			this.ucRMAJobLogLine5.Size = new System.Drawing.Size(905, 109);
			this.ucRMAJobLogLine5.TabIndex = 7;
			// 
			// ucRMAJobLogLine4
			// 
			this.ucRMAJobLogLine4.Location = new System.Drawing.Point(14, 391);
			this.ucRMAJobLogLine4.Name = "ucRMAJobLogLine4";
			this.ucRMAJobLogLine4.Size = new System.Drawing.Size(905, 109);
			this.ucRMAJobLogLine4.TabIndex = 6;
			// 
			// ucRMAJobLogLine3
			// 
			this.ucRMAJobLogLine3.Location = new System.Drawing.Point(14, 282);
			this.ucRMAJobLogLine3.Name = "ucRMAJobLogLine3";
			this.ucRMAJobLogLine3.Size = new System.Drawing.Size(905, 109);
			this.ucRMAJobLogLine3.TabIndex = 5;
			// 
			// ucRMAJobLogLine2
			// 
			this.ucRMAJobLogLine2.Location = new System.Drawing.Point(14, 173);
			this.ucRMAJobLogLine2.Name = "ucRMAJobLogLine2";
			this.ucRMAJobLogLine2.Size = new System.Drawing.Size(905, 109);
			this.ucRMAJobLogLine2.TabIndex = 4;
			// 
			// ucRMAJobLogLine1
			// 
			this.ucRMAJobLogLine1.Location = new System.Drawing.Point(14, 64);
			this.ucRMAJobLogLine1.Name = "ucRMAJobLogLine1";
			this.ucRMAJobLogLine1.Size = new System.Drawing.Size(905, 109);
			this.ucRMAJobLogLine1.TabIndex = 3;
			// 
			// tabRMADetail
			// 
			this.tabRMADetail.Controls.Add(this.btnRMADetail_PrintScreen);
			this.tabRMADetail.Controls.Add(this.txtRMADetail_CustomerRequests);
			this.tabRMADetail.Controls.Add(this.txtRMADetail_YescoNotes);
			this.tabRMADetail.Controls.Add(this.lblRMADetail_CustomerRequests);
			this.tabRMADetail.Controls.Add(this.btnRMADetail_CreatePDF);
			this.tabRMADetail.Controls.Add(this.lblRMADetail_YescoNotes);
			this.tabRMADetail.Controls.Add(this.pnlRMADetail_Header);
			this.tabRMADetail.Controls.Add(this.ucRMADetail_Part5);
			this.tabRMADetail.Controls.Add(this.ucRMADetail_Part4);
			this.tabRMADetail.Controls.Add(this.ucRMADetail_Part3);
			this.tabRMADetail.Controls.Add(this.ucRMADetail_Part2);
			this.tabRMADetail.Controls.Add(this.ucRMADetail_Part1);
			this.tabRMADetail.Location = new System.Drawing.Point(4, 22);
			this.tabRMADetail.Name = "tabRMADetail";
			this.tabRMADetail.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMADetail.Size = new System.Drawing.Size(1062, 682);
			this.tabRMADetail.TabIndex = 7;
			this.tabRMADetail.Text = "Detail";
			this.tabRMADetail.UseVisualStyleBackColor = true;
			// 
			// btnRMADetail_PrintScreen
			// 
			this.btnRMADetail_PrintScreen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMADetail_PrintScreen.Location = new System.Drawing.Point(969, 2);
			this.btnRMADetail_PrintScreen.Name = "btnRMADetail_PrintScreen";
			this.btnRMADetail_PrintScreen.Size = new System.Drawing.Size(92, 23);
			this.btnRMADetail_PrintScreen.TabIndex = 23;
			this.btnRMADetail_PrintScreen.Text = "Print Screen";
			this.btnRMADetail_PrintScreen.UseVisualStyleBackColor = true;
			this.btnRMADetail_PrintScreen.Click += new System.EventHandler(this.btnRMA_PrintScreen_Click);
			// 
			// txtRMADetail_CustomerRequests
			// 
			this.txtRMADetail_CustomerRequests.AcceptsReturn = true;
			this.txtRMADetail_CustomerRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtRMADetail_CustomerRequests.ForeColor = System.Drawing.Color.Navy;
			this.txtRMADetail_CustomerRequests.Location = new System.Drawing.Point(601, 601);
			this.txtRMADetail_CustomerRequests.MaxLength = 200;
			this.txtRMADetail_CustomerRequests.Multiline = true;
			this.txtRMADetail_CustomerRequests.Name = "txtRMADetail_CustomerRequests";
			this.txtRMADetail_CustomerRequests.ReadOnly = true;
			this.txtRMADetail_CustomerRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMADetail_CustomerRequests.Size = new System.Drawing.Size(460, 78);
			this.txtRMADetail_CustomerRequests.TabIndex = 22;
			this.txtRMADetail_CustomerRequests.TabStop = false;
			// 
			// txtRMADetail_YescoNotes
			// 
			this.txtRMADetail_YescoNotes.AcceptsReturn = true;
			this.txtRMADetail_YescoNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtRMADetail_YescoNotes.ForeColor = System.Drawing.Color.Navy;
			this.txtRMADetail_YescoNotes.Location = new System.Drawing.Point(41, 601);
			this.txtRMADetail_YescoNotes.MaxLength = 150;
			this.txtRMADetail_YescoNotes.Multiline = true;
			this.txtRMADetail_YescoNotes.Name = "txtRMADetail_YescoNotes";
			this.txtRMADetail_YescoNotes.ReadOnly = true;
			this.txtRMADetail_YescoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRMADetail_YescoNotes.Size = new System.Drawing.Size(460, 78);
			this.txtRMADetail_YescoNotes.TabIndex = 21;
			this.txtRMADetail_YescoNotes.TabStop = false;
			// 
			// lblRMADetail_CustomerRequests
			// 
			this.lblRMADetail_CustomerRequests.AutoSize = true;
			this.lblRMADetail_CustomerRequests.Location = new System.Drawing.Point(547, 601);
			this.lblRMADetail_CustomerRequests.Name = "lblRMADetail_CustomerRequests";
			this.lblRMADetail_CustomerRequests.Size = new System.Drawing.Size(55, 26);
			this.lblRMADetail_CustomerRequests.TabIndex = 18;
			this.lblRMADetail_CustomerRequests.Text = "Customer\r\nRequests:";
			this.lblRMADetail_CustomerRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRMADetail_CreatePDF
			// 
			this.btnRMADetail_CreatePDF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMADetail_CreatePDF.Location = new System.Drawing.Point(969, 27);
			this.btnRMADetail_CreatePDF.Name = "btnRMADetail_CreatePDF";
			this.btnRMADetail_CreatePDF.Size = new System.Drawing.Size(92, 23);
			this.btnRMADetail_CreatePDF.TabIndex = 17;
			this.btnRMADetail_CreatePDF.Text = "Create PDF";
			this.btnRMADetail_CreatePDF.UseVisualStyleBackColor = true;
			this.btnRMADetail_CreatePDF.Click += new System.EventHandler(this.btnRMADetail_CreatePDF_Click);
			// 
			// lblRMADetail_YescoNotes
			// 
			this.lblRMADetail_YescoNotes.AutoSize = true;
			this.lblRMADetail_YescoNotes.Location = new System.Drawing.Point(3, 601);
			this.lblRMADetail_YescoNotes.Name = "lblRMADetail_YescoNotes";
			this.lblRMADetail_YescoNotes.Size = new System.Drawing.Size(38, 26);
			this.lblRMADetail_YescoNotes.TabIndex = 8;
			this.lblRMADetail_YescoNotes.Text = "Yesco\r\nNotes:";
			this.lblRMADetail_YescoNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlRMADetail_Header
			// 
			this.pnlRMADetail_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_CustomerWorkOrder);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_CustomerWorkOrder);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_TicketNumber);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_TicketNumber);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_APR);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_APR);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_ShippingTelNum);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_ShippingStateCity);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_ShippingRoad);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_ShippingName);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_AddressTelNum);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_AddressStateCity);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_AddressRoad);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_AddressName);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_DateIssued);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_IssuedBy);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_PurchaseOrder);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Show_RMANum);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_ShipToAddress);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_CustomerAddress);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_PurchaseOrder);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_Issuer);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_RMANumber);
			this.pnlRMADetail_Header.Controls.Add(this.lblRMADetail_IssueDate);
			this.pnlRMADetail_Header.Location = new System.Drawing.Point(6, 29);
			this.pnlRMADetail_Header.Name = "pnlRMADetail_Header";
			this.pnlRMADetail_Header.Size = new System.Drawing.Size(872, 109);
			this.pnlRMADetail_Header.TabIndex = 2;
			// 
			// lblRMADetail_Show_CustomerWorkOrder
			// 
			this.lblRMADetail_Show_CustomerWorkOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_CustomerWorkOrder.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_CustomerWorkOrder.Location = new System.Drawing.Point(193, 66);
			this.lblRMADetail_Show_CustomerWorkOrder.Name = "lblRMADetail_Show_CustomerWorkOrder";
			this.lblRMADetail_Show_CustomerWorkOrder.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_CustomerWorkOrder.TabIndex = 24;
			this.lblRMADetail_Show_CustomerWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_CustomerWorkOrder
			// 
			this.lblRMADetail_CustomerWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_CustomerWorkOrder.Location = new System.Drawing.Point(193, 43);
			this.lblRMADetail_CustomerWorkOrder.Name = "lblRMADetail_CustomerWorkOrder";
			this.lblRMADetail_CustomerWorkOrder.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_CustomerWorkOrder.TabIndex = 23;
			this.lblRMADetail_CustomerWorkOrder.Text = "Cust. WO#";
			this.lblRMADetail_CustomerWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_TicketNumber
			// 
			this.lblRMADetail_Show_TicketNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_TicketNumber.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_TicketNumber.Location = new System.Drawing.Point(290, 66);
			this.lblRMADetail_Show_TicketNumber.Name = "lblRMADetail_Show_TicketNumber";
			this.lblRMADetail_Show_TicketNumber.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_TicketNumber.TabIndex = 22;
			this.lblRMADetail_Show_TicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_TicketNumber
			// 
			this.lblRMADetail_TicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_TicketNumber.Location = new System.Drawing.Point(290, 43);
			this.lblRMADetail_TicketNumber.Name = "lblRMADetail_TicketNumber";
			this.lblRMADetail_TicketNumber.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_TicketNumber.TabIndex = 21;
			this.lblRMADetail_TicketNumber.Text = "Ticket#";
			this.lblRMADetail_TicketNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_APR
			// 
			this.lblRMADetail_Show_APR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_APR.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_APR.Location = new System.Drawing.Point(1, 66);
			this.lblRMADetail_Show_APR.Name = "lblRMADetail_Show_APR";
			this.lblRMADetail_Show_APR.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_APR.TabIndex = 20;
			this.lblRMADetail_Show_APR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_APR
			// 
			this.lblRMADetail_APR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_APR.Location = new System.Drawing.Point(-1, 43);
			this.lblRMADetail_APR.Name = "lblRMADetail_APR";
			this.lblRMADetail_APR.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_APR.TabIndex = 19;
			this.lblRMADetail_APR.Text = "APR Type";
			this.lblRMADetail_APR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_ShippingTelNum
			// 
			this.lblRMADetail_Show_ShippingTelNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_ShippingTelNum.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_ShippingTelNum.Location = new System.Drawing.Point(606, 83);
			this.lblRMADetail_Show_ShippingTelNum.Name = "lblRMADetail_Show_ShippingTelNum";
			this.lblRMADetail_Show_ShippingTelNum.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_ShippingTelNum.TabIndex = 18;
			this.lblRMADetail_Show_ShippingTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_ShippingStateCity
			// 
			this.lblRMADetail_Show_ShippingStateCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_ShippingStateCity.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_ShippingStateCity.Location = new System.Drawing.Point(606, 63);
			this.lblRMADetail_Show_ShippingStateCity.Name = "lblRMADetail_Show_ShippingStateCity";
			this.lblRMADetail_Show_ShippingStateCity.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_ShippingStateCity.TabIndex = 17;
			this.lblRMADetail_Show_ShippingStateCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_ShippingRoad
			// 
			this.lblRMADetail_Show_ShippingRoad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_ShippingRoad.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_ShippingRoad.Location = new System.Drawing.Point(606, 43);
			this.lblRMADetail_Show_ShippingRoad.Name = "lblRMADetail_Show_ShippingRoad";
			this.lblRMADetail_Show_ShippingRoad.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_ShippingRoad.TabIndex = 16;
			this.lblRMADetail_Show_ShippingRoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_ShippingName
			// 
			this.lblRMADetail_Show_ShippingName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_ShippingName.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_ShippingName.Location = new System.Drawing.Point(606, 23);
			this.lblRMADetail_Show_ShippingName.Name = "lblRMADetail_Show_ShippingName";
			this.lblRMADetail_Show_ShippingName.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_ShippingName.TabIndex = 15;
			this.lblRMADetail_Show_ShippingName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_AddressTelNum
			// 
			this.lblRMADetail_Show_AddressTelNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_AddressTelNum.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_AddressTelNum.Location = new System.Drawing.Point(390, 83);
			this.lblRMADetail_Show_AddressTelNum.Name = "lblRMADetail_Show_AddressTelNum";
			this.lblRMADetail_Show_AddressTelNum.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_AddressTelNum.TabIndex = 14;
			this.lblRMADetail_Show_AddressTelNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_AddressStateCity
			// 
			this.lblRMADetail_Show_AddressStateCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_AddressStateCity.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_AddressStateCity.Location = new System.Drawing.Point(390, 63);
			this.lblRMADetail_Show_AddressStateCity.Name = "lblRMADetail_Show_AddressStateCity";
			this.lblRMADetail_Show_AddressStateCity.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_AddressStateCity.TabIndex = 13;
			this.lblRMADetail_Show_AddressStateCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_AddressRoad
			// 
			this.lblRMADetail_Show_AddressRoad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_AddressRoad.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_AddressRoad.Location = new System.Drawing.Point(390, 43);
			this.lblRMADetail_Show_AddressRoad.Name = "lblRMADetail_Show_AddressRoad";
			this.lblRMADetail_Show_AddressRoad.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_AddressRoad.TabIndex = 12;
			this.lblRMADetail_Show_AddressRoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_AddressName
			// 
			this.lblRMADetail_Show_AddressName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_AddressName.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_AddressName.Location = new System.Drawing.Point(390, 23);
			this.lblRMADetail_Show_AddressName.Name = "lblRMADetail_Show_AddressName";
			this.lblRMADetail_Show_AddressName.Size = new System.Drawing.Size(210, 20);
			this.lblRMADetail_Show_AddressName.TabIndex = 11;
			this.lblRMADetail_Show_AddressName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRMADetail_Show_DateIssued
			// 
			this.lblRMADetail_Show_DateIssued.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_DateIssued.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_DateIssued.Location = new System.Drawing.Point(96, 23);
			this.lblRMADetail_Show_DateIssued.Name = "lblRMADetail_Show_DateIssued";
			this.lblRMADetail_Show_DateIssued.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_DateIssued.TabIndex = 10;
			this.lblRMADetail_Show_DateIssued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_IssuedBy
			// 
			this.lblRMADetail_Show_IssuedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_IssuedBy.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_IssuedBy.Location = new System.Drawing.Point(193, 23);
			this.lblRMADetail_Show_IssuedBy.Name = "lblRMADetail_Show_IssuedBy";
			this.lblRMADetail_Show_IssuedBy.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_IssuedBy.TabIndex = 9;
			this.lblRMADetail_Show_IssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_PurchaseOrder
			// 
			this.lblRMADetail_Show_PurchaseOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_PurchaseOrder.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_PurchaseOrder.Location = new System.Drawing.Point(290, 23);
			this.lblRMADetail_Show_PurchaseOrder.Name = "lblRMADetail_Show_PurchaseOrder";
			this.lblRMADetail_Show_PurchaseOrder.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_PurchaseOrder.TabIndex = 8;
			this.lblRMADetail_Show_PurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Show_RMANum
			// 
			this.lblRMADetail_Show_RMANum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Show_RMANum.ForeColor = System.Drawing.Color.Navy;
			this.lblRMADetail_Show_RMANum.Location = new System.Drawing.Point(-1, 23);
			this.lblRMADetail_Show_RMANum.Name = "lblRMADetail_Show_RMANum";
			this.lblRMADetail_Show_RMANum.Size = new System.Drawing.Size(91, 20);
			this.lblRMADetail_Show_RMANum.TabIndex = 0;
			this.lblRMADetail_Show_RMANum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_ShipToAddress
			// 
			this.lblRMADetail_ShipToAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_ShipToAddress.Location = new System.Drawing.Point(595, 0);
			this.lblRMADetail_ShipToAddress.Name = "lblRMADetail_ShipToAddress";
			this.lblRMADetail_ShipToAddress.Size = new System.Drawing.Size(122, 23);
			this.lblRMADetail_ShipToAddress.TabIndex = 5;
			this.lblRMADetail_ShipToAddress.Text = "Ship to Address";
			this.lblRMADetail_ShipToAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_CustomerAddress
			// 
			this.lblRMADetail_CustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_CustomerAddress.Location = new System.Drawing.Point(387, 0);
			this.lblRMADetail_CustomerAddress.Name = "lblRMADetail_CustomerAddress";
			this.lblRMADetail_CustomerAddress.Size = new System.Drawing.Size(122, 23);
			this.lblRMADetail_CustomerAddress.TabIndex = 4;
			this.lblRMADetail_CustomerAddress.Text = "Customer Address";
			this.lblRMADetail_CustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_PurchaseOrder
			// 
			this.lblRMADetail_PurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_PurchaseOrder.Location = new System.Drawing.Point(290, 0);
			this.lblRMADetail_PurchaseOrder.Name = "lblRMADetail_PurchaseOrder";
			this.lblRMADetail_PurchaseOrder.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_PurchaseOrder.TabIndex = 3;
			this.lblRMADetail_PurchaseOrder.Text = "PO#";
			this.lblRMADetail_PurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_Issuer
			// 
			this.lblRMADetail_Issuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_Issuer.Location = new System.Drawing.Point(193, 0);
			this.lblRMADetail_Issuer.Name = "lblRMADetail_Issuer";
			this.lblRMADetail_Issuer.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_Issuer.TabIndex = 2;
			this.lblRMADetail_Issuer.Text = "Issued By";
			this.lblRMADetail_Issuer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_RMANumber
			// 
			this.lblRMADetail_RMANumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_RMANumber.Location = new System.Drawing.Point(-1, 0);
			this.lblRMADetail_RMANumber.Name = "lblRMADetail_RMANumber";
			this.lblRMADetail_RMANumber.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_RMANumber.TabIndex = 0;
			this.lblRMADetail_RMANumber.Text = "RMA#";
			this.lblRMADetail_RMANumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRMADetail_IssueDate
			// 
			this.lblRMADetail_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMADetail_IssueDate.Location = new System.Drawing.Point(96, 0);
			this.lblRMADetail_IssueDate.Name = "lblRMADetail_IssueDate";
			this.lblRMADetail_IssueDate.Size = new System.Drawing.Size(91, 23);
			this.lblRMADetail_IssueDate.TabIndex = 1;
			this.lblRMADetail_IssueDate.Text = "Date Issued";
			this.lblRMADetail_IssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucRMADetail_Part5
			// 
			this.ucRMADetail_Part5.BackColor = System.Drawing.Color.Transparent;
			this.ucRMADetail_Part5.Location = new System.Drawing.Point(3, 507);
			this.ucRMADetail_Part5.Name = "ucRMADetail_Part5";
			this.ucRMADetail_Part5.Size = new System.Drawing.Size(1058, 89);
			this.ucRMADetail_Part5.TabIndex = 28;
			// 
			// ucRMADetail_Part4
			// 
			this.ucRMADetail_Part4.BackColor = System.Drawing.Color.Transparent;
			this.ucRMADetail_Part4.Location = new System.Drawing.Point(3, 416);
			this.ucRMADetail_Part4.Name = "ucRMADetail_Part4";
			this.ucRMADetail_Part4.Size = new System.Drawing.Size(1058, 89);
			this.ucRMADetail_Part4.TabIndex = 27;
			// 
			// ucRMADetail_Part3
			// 
			this.ucRMADetail_Part3.BackColor = System.Drawing.Color.Transparent;
			this.ucRMADetail_Part3.Location = new System.Drawing.Point(3, 325);
			this.ucRMADetail_Part3.Name = "ucRMADetail_Part3";
			this.ucRMADetail_Part3.Size = new System.Drawing.Size(1058, 89);
			this.ucRMADetail_Part3.TabIndex = 26;
			// 
			// ucRMADetail_Part2
			// 
			this.ucRMADetail_Part2.BackColor = System.Drawing.Color.Transparent;
			this.ucRMADetail_Part2.Location = new System.Drawing.Point(3, 234);
			this.ucRMADetail_Part2.Name = "ucRMADetail_Part2";
			this.ucRMADetail_Part2.Size = new System.Drawing.Size(1058, 89);
			this.ucRMADetail_Part2.TabIndex = 25;
			// 
			// ucRMADetail_Part1
			// 
			this.ucRMADetail_Part1.BackColor = System.Drawing.Color.Transparent;
			this.ucRMADetail_Part1.Location = new System.Drawing.Point(3, 143);
			this.ucRMADetail_Part1.Name = "ucRMADetail_Part1";
			this.ucRMADetail_Part1.Size = new System.Drawing.Size(1058, 89);
			this.ucRMADetail_Part1.TabIndex = 24;
			// 
			// tabRMAMasterList
			// 
			this.tabRMAMasterList.Controls.Add(this.btnRMAMasterList_Export);
			this.tabRMAMasterList.Controls.Add(this.lblRMAMasterList_SubHeader);
			this.tabRMAMasterList.Controls.Add(this.lblRMAMasterList_Header);
			this.tabRMAMasterList.Controls.Add(this.btnRMAMaster_Detail);
			this.tabRMAMasterList.Controls.Add(this.btnRMAMaster_Edit);
			this.tabRMAMasterList.Controls.Add(this.btnRMAMaster_JobLog);
			this.tabRMAMasterList.Controls.Add(this.lblRMAMaster_Selected);
			this.tabRMAMasterList.Controls.Add(this.ucRMAMaster_ListLabels3);
			this.tabRMAMasterList.Controls.Add(this.lstRMAMaster);
			this.tabRMAMasterList.Location = new System.Drawing.Point(4, 22);
			this.tabRMAMasterList.Name = "tabRMAMasterList";
			this.tabRMAMasterList.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAMasterList.Size = new System.Drawing.Size(1062, 682);
			this.tabRMAMasterList.TabIndex = 5;
			this.tabRMAMasterList.Text = "Master List";
			this.tabRMAMasterList.UseVisualStyleBackColor = true;
			// 
			// btnRMAMasterList_Export
			// 
			this.btnRMAMasterList_Export.Location = new System.Drawing.Point(834, 570);
			this.btnRMAMasterList_Export.Name = "btnRMAMasterList_Export";
			this.btnRMAMasterList_Export.Size = new System.Drawing.Size(75, 23);
			this.btnRMAMasterList_Export.TabIndex = 22;
			this.btnRMAMasterList_Export.Text = "Export";
			this.btnRMAMasterList_Export.UseVisualStyleBackColor = true;
			this.btnRMAMasterList_Export.Click += new System.EventHandler(this.btnRMA_ExportMaster_Click);
			// 
			// lblRMAMasterList_SubHeader
			// 
			this.lblRMAMasterList_SubHeader.AutoSize = true;
			this.lblRMAMasterList_SubHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAMasterList_SubHeader.Location = new System.Drawing.Point(513, 37);
			this.lblRMAMasterList_SubHeader.Name = "lblRMAMasterList_SubHeader";
			this.lblRMAMasterList_SubHeader.Size = new System.Drawing.Size(62, 16);
			this.lblRMAMasterList_SubHeader.TabIndex = 20;
			this.lblRMAMasterList_SubHeader.Text = "All RMAs";
			// 
			// lblRMAMasterList_Header
			// 
			this.lblRMAMasterList_Header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAMasterList_Header.Location = new System.Drawing.Point(426, 18);
			this.lblRMAMasterList_Header.Name = "lblRMAMasterList_Header";
			this.lblRMAMasterList_Header.Size = new System.Drawing.Size(237, 22);
			this.lblRMAMasterList_Header.TabIndex = 7;
			this.lblRMAMasterList_Header.Text = "Master List";
			this.lblRMAMasterList_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRMAMaster_Detail
			// 
			this.btnRMAMaster_Detail.Location = new System.Drawing.Point(588, 55);
			this.btnRMAMaster_Detail.Name = "btnRMAMaster_Detail";
			this.btnRMAMaster_Detail.Size = new System.Drawing.Size(75, 23);
			this.btnRMAMaster_Detail.TabIndex = 6;
			this.btnRMAMaster_Detail.Text = "Detail";
			this.btnRMAMaster_Detail.UseVisualStyleBackColor = true;
			this.btnRMAMaster_Detail.Click += new System.EventHandler(this.btnRMAMaster_Detail_Click);
			// 
			// btnRMAMaster_Edit
			// 
			this.btnRMAMaster_Edit.Location = new System.Drawing.Point(507, 55);
			this.btnRMAMaster_Edit.Name = "btnRMAMaster_Edit";
			this.btnRMAMaster_Edit.Size = new System.Drawing.Size(75, 23);
			this.btnRMAMaster_Edit.TabIndex = 5;
			this.btnRMAMaster_Edit.Text = "Edit";
			this.btnRMAMaster_Edit.UseVisualStyleBackColor = true;
			this.btnRMAMaster_Edit.Click += new System.EventHandler(this.btnRMAMaster_Edit_Click);
			// 
			// btnRMAMaster_JobLog
			// 
			this.btnRMAMaster_JobLog.Location = new System.Drawing.Point(426, 55);
			this.btnRMAMaster_JobLog.Name = "btnRMAMaster_JobLog";
			this.btnRMAMaster_JobLog.Size = new System.Drawing.Size(75, 23);
			this.btnRMAMaster_JobLog.TabIndex = 4;
			this.btnRMAMaster_JobLog.Text = "Job Log";
			this.btnRMAMaster_JobLog.UseVisualStyleBackColor = true;
			this.btnRMAMaster_JobLog.Click += new System.EventHandler(this.btnRMAMaster_Job_Click);
			// 
			// lblRMAMaster_Selected
			// 
			this.lblRMAMaster_Selected.Location = new System.Drawing.Point(267, 81);
			this.lblRMAMaster_Selected.Name = "lblRMAMaster_Selected";
			this.lblRMAMaster_Selected.Size = new System.Drawing.Size(559, 23);
			this.lblRMAMaster_Selected.TabIndex = 2;
			this.lblRMAMaster_Selected.Text = "Selected RMA:";
			this.lblRMAMaster_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ucRMAMaster_ListLabels3
			// 
			this.ucRMAMaster_ListLabels3.BackColor = System.Drawing.Color.Transparent;
			this.ucRMAMaster_ListLabels3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRMAMaster_ListLabels3.Location = new System.Drawing.Point(834, 110);
			this.ucRMAMaster_ListLabels3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.ucRMAMaster_ListLabels3.Name = "ucRMAMaster_ListLabels3";
			this.ucRMAMaster_ListLabels3.Size = new System.Drawing.Size(102, 86);
			this.ucRMAMaster_ListLabels3.TabIndex = 21;
			// 
			// lstRMAMaster
			// 
			this.lstRMAMaster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lstRMAMaster.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstRMAMaster.FullRowSelect = true;
			this.lstRMAMaster.GridLines = true;
			this.lstRMAMaster.HideSelection = false;
			this.lstRMAMaster.Location = new System.Drawing.Point(267, 110);
			this.lstRMAMaster.MultiSelect = false;
			this.lstRMAMaster.Name = "lstRMAMaster";
			this.lstRMAMaster.Size = new System.Drawing.Size(559, 483);
			this.lstRMAMaster.TabIndex = 0;
			this.lstRMAMaster.UseCompatibleStateImageBehavior = false;
			this.lstRMAMaster.View = System.Windows.Forms.View.Details;
			this.lstRMAMaster.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRMAViewer_Click);
			this.lstRMAMaster.SelectedIndexChanged += new System.EventHandler(this.lstRMAMaster_SelectedIndexChanged);
			this.lstRMAMaster.DoubleClick += new System.EventHandler(this.lstRMAMaster_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "RMA #";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader1.Width = 84;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Date Issued";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 117;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Branch";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 220;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Open/Closed";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 112;
			// 
			// tabRMAUnreceived
			// 
			this.tabRMAUnreceived.Controls.Add(this.btnRMAUnreceived_Export);
			this.tabRMAUnreceived.Controls.Add(this.lblRMAUnreceived_SubHeader);
			this.tabRMAUnreceived.Controls.Add(this.lblRMAUnreceived_Header);
			this.tabRMAUnreceived.Controls.Add(this.btnRMAUnreceived_Detail);
			this.tabRMAUnreceived.Controls.Add(this.btnRMAUnreceived_Edit);
			this.tabRMAUnreceived.Controls.Add(this.btnRMAUnreceived_JobLog);
			this.tabRMAUnreceived.Controls.Add(this.lblRMAUnreceived_Tech);
			this.tabRMAUnreceived.Controls.Add(this.lblRMAUnreceived_Selected);
			this.tabRMAUnreceived.Controls.Add(this.ucRMAUnreceived_ListLabels1);
			this.tabRMAUnreceived.Controls.Add(this.lstvRMAUnreceived);
			this.tabRMAUnreceived.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabRMAUnreceived.Location = new System.Drawing.Point(4, 22);
			this.tabRMAUnreceived.Name = "tabRMAUnreceived";
			this.tabRMAUnreceived.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAUnreceived.Size = new System.Drawing.Size(1062, 682);
			this.tabRMAUnreceived.TabIndex = 3;
			this.tabRMAUnreceived.Text = "Unreceived";
			this.tabRMAUnreceived.UseVisualStyleBackColor = true;
			// 
			// btnRMAUnreceived_Export
			// 
			this.btnRMAUnreceived_Export.Location = new System.Drawing.Point(814, 570);
			this.btnRMAUnreceived_Export.Name = "btnRMAUnreceived_Export";
			this.btnRMAUnreceived_Export.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnreceived_Export.TabIndex = 20;
			this.btnRMAUnreceived_Export.Text = "Export";
			this.btnRMAUnreceived_Export.UseVisualStyleBackColor = true;
			this.btnRMAUnreceived_Export.Click += new System.EventHandler(this.btnRMA_ExportUnreceived_Click);
			// 
			// lblRMAUnreceived_SubHeader
			// 
			this.lblRMAUnreceived_SubHeader.AutoSize = true;
			this.lblRMAUnreceived_SubHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnreceived_SubHeader.Location = new System.Drawing.Point(449, 37);
			this.lblRMAUnreceived_SubHeader.Name = "lblRMAUnreceived_SubHeader";
			this.lblRMAUnreceived_SubHeader.Size = new System.Drawing.Size(177, 16);
			this.lblRMAUnreceived_SubHeader.TabIndex = 18;
			this.lblRMAUnreceived_SubHeader.Text = "No parts have been received.";
			// 
			// lblRMAUnreceived_Header
			// 
			this.lblRMAUnreceived_Header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnreceived_Header.Location = new System.Drawing.Point(419, 18);
			this.lblRMAUnreceived_Header.Name = "lblRMAUnreceived_Header";
			this.lblRMAUnreceived_Header.Size = new System.Drawing.Size(237, 22);
			this.lblRMAUnreceived_Header.TabIndex = 17;
			this.lblRMAUnreceived_Header.Text = "Unreceived RMAs";
			this.lblRMAUnreceived_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRMAUnreceived_Detail
			// 
			this.btnRMAUnreceived_Detail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnreceived_Detail.Location = new System.Drawing.Point(581, 55);
			this.btnRMAUnreceived_Detail.Name = "btnRMAUnreceived_Detail";
			this.btnRMAUnreceived_Detail.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnreceived_Detail.TabIndex = 16;
			this.btnRMAUnreceived_Detail.Text = "Detail";
			this.btnRMAUnreceived_Detail.UseVisualStyleBackColor = true;
			this.btnRMAUnreceived_Detail.Click += new System.EventHandler(this.btnRMAUnreceivedDetail_Click);
			// 
			// btnRMAUnreceived_Edit
			// 
			this.btnRMAUnreceived_Edit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnreceived_Edit.Location = new System.Drawing.Point(500, 55);
			this.btnRMAUnreceived_Edit.Name = "btnRMAUnreceived_Edit";
			this.btnRMAUnreceived_Edit.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnreceived_Edit.TabIndex = 15;
			this.btnRMAUnreceived_Edit.Text = "Edit";
			this.btnRMAUnreceived_Edit.UseVisualStyleBackColor = true;
			this.btnRMAUnreceived_Edit.Click += new System.EventHandler(this.btnRMAUnreceivedEdit_Click);
			// 
			// btnRMAUnreceived_JobLog
			// 
			this.btnRMAUnreceived_JobLog.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnreceived_JobLog.Location = new System.Drawing.Point(419, 55);
			this.btnRMAUnreceived_JobLog.Name = "btnRMAUnreceived_JobLog";
			this.btnRMAUnreceived_JobLog.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnreceived_JobLog.TabIndex = 14;
			this.btnRMAUnreceived_JobLog.Text = "Job Log";
			this.btnRMAUnreceived_JobLog.UseVisualStyleBackColor = true;
			this.btnRMAUnreceived_JobLog.Click += new System.EventHandler(this.btnRMAUnreceivedJobLog_Click);
			// 
			// lblRMAUnreceived_Tech
			// 
			this.lblRMAUnreceived_Tech.AutoSize = true;
			this.lblRMAUnreceived_Tech.Location = new System.Drawing.Point(747, 67);
			this.lblRMAUnreceived_Tech.Name = "lblRMAUnreceived_Tech";
			this.lblRMAUnreceived_Tech.Size = new System.Drawing.Size(0, 16);
			this.lblRMAUnreceived_Tech.TabIndex = 7;
			this.lblRMAUnreceived_Tech.Visible = false;
			// 
			// lblRMAUnreceived_Selected
			// 
			this.lblRMAUnreceived_Selected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnreceived_Selected.Location = new System.Drawing.Point(276, 81);
			this.lblRMAUnreceived_Selected.Name = "lblRMAUnreceived_Selected";
			this.lblRMAUnreceived_Selected.Size = new System.Drawing.Size(527, 23);
			this.lblRMAUnreceived_Selected.TabIndex = 5;
			this.lblRMAUnreceived_Selected.Text = "Selected RMA:";
			this.lblRMAUnreceived_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ucRMAUnreceived_ListLabels1
			// 
			this.ucRMAUnreceived_ListLabels1.BackColor = System.Drawing.Color.Transparent;
			this.ucRMAUnreceived_ListLabels1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRMAUnreceived_ListLabels1.Location = new System.Drawing.Point(814, 110);
			this.ucRMAUnreceived_ListLabels1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ucRMAUnreceived_ListLabels1.Name = "ucRMAUnreceived_ListLabels1";
			this.ucRMAUnreceived_ListLabels1.Size = new System.Drawing.Size(102, 86);
			this.ucRMAUnreceived_ListLabels1.TabIndex = 19;
			// 
			// lstvRMAUnreceived
			// 
			this.lstvRMAUnreceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.lstvRMAUnreceived.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstvRMAUnreceived.FullRowSelect = true;
			this.lstvRMAUnreceived.GridLines = true;
			this.lstvRMAUnreceived.HideSelection = false;
			this.lstvRMAUnreceived.Location = new System.Drawing.Point(276, 110);
			this.lstvRMAUnreceived.MultiSelect = false;
			this.lstvRMAUnreceived.Name = "lstvRMAUnreceived";
			this.lstvRMAUnreceived.Size = new System.Drawing.Size(527, 483);
			this.lstvRMAUnreceived.TabIndex = 4;
			this.lstvRMAUnreceived.UseCompatibleStateImageBehavior = false;
			this.lstvRMAUnreceived.View = System.Windows.Forms.View.Details;
			this.lstvRMAUnreceived.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRMAViewer_Click);
			this.lstvRMAUnreceived.SelectedIndexChanged += new System.EventHandler(this.lstRMAUnreceived_SelectedIndexChanged);
			this.lstvRMAUnreceived.DoubleClick += new System.EventHandler(this.lstRMAUnreceived_DoubleClick);
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "RMA #";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 84;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Date Issued";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 117;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Branch";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 300;
			// 
			// tabRMAUnfinished
			// 
			this.tabRMAUnfinished.Controls.Add(this.btnRMAUnfinished_Export);
			this.tabRMAUnfinished.Controls.Add(this.lblRMAUnfinished_SubHeader);
			this.tabRMAUnfinished.Controls.Add(this.lblRMAUnfinished_Header);
			this.tabRMAUnfinished.Controls.Add(this.btnRMAUnfinished_Detail);
			this.tabRMAUnfinished.Controls.Add(this.btnRMAUnfinished_Edit);
			this.tabRMAUnfinished.Controls.Add(this.btnRMAUnfinished_JobLog);
			this.tabRMAUnfinished.Controls.Add(this.lblRMAUnfinished_Selected);
			this.tabRMAUnfinished.Controls.Add(this.ucRMAUnfinished_ListLabels2);
			this.tabRMAUnfinished.Controls.Add(this.lstvRMAUnfinished);
			this.tabRMAUnfinished.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabRMAUnfinished.Location = new System.Drawing.Point(4, 22);
			this.tabRMAUnfinished.Name = "tabRMAUnfinished";
			this.tabRMAUnfinished.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAUnfinished.Size = new System.Drawing.Size(1062, 682);
			this.tabRMAUnfinished.TabIndex = 4;
			this.tabRMAUnfinished.Text = "Unfinished";
			this.tabRMAUnfinished.UseVisualStyleBackColor = true;
			// 
			// btnRMAUnfinished_Export
			// 
			this.btnRMAUnfinished_Export.Location = new System.Drawing.Point(814, 569);
			this.btnRMAUnfinished_Export.Name = "btnRMAUnfinished_Export";
			this.btnRMAUnfinished_Export.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnfinished_Export.TabIndex = 21;
			this.btnRMAUnfinished_Export.Text = "Export";
			this.btnRMAUnfinished_Export.UseVisualStyleBackColor = true;
			this.btnRMAUnfinished_Export.Click += new System.EventHandler(this.btnRMA_ExportUnfinished_Click);
			// 
			// lblRMAUnfinished_SubHeader
			// 
			this.lblRMAUnfinished_SubHeader.AutoSize = true;
			this.lblRMAUnfinished_SubHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnfinished_SubHeader.Location = new System.Drawing.Point(410, 37);
			this.lblRMAUnfinished_SubHeader.Name = "lblRMAUnfinished_SubHeader";
			this.lblRMAUnfinished_SubHeader.Size = new System.Drawing.Size(255, 16);
			this.lblRMAUnfinished_SubHeader.TabIndex = 19;
			this.lblRMAUnfinished_SubHeader.Text = "Some or all parts received, RMA still open.";
			// 
			// lblRMAUnfinished_Header
			// 
			this.lblRMAUnfinished_Header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnfinished_Header.Location = new System.Drawing.Point(419, 18);
			this.lblRMAUnfinished_Header.Name = "lblRMAUnfinished_Header";
			this.lblRMAUnfinished_Header.Size = new System.Drawing.Size(237, 22);
			this.lblRMAUnfinished_Header.TabIndex = 14;
			this.lblRMAUnfinished_Header.Text = "Unfinished RMAs";
			this.lblRMAUnfinished_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRMAUnfinished_Detail
			// 
			this.btnRMAUnfinished_Detail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnfinished_Detail.Location = new System.Drawing.Point(581, 55);
			this.btnRMAUnfinished_Detail.Name = "btnRMAUnfinished_Detail";
			this.btnRMAUnfinished_Detail.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnfinished_Detail.TabIndex = 13;
			this.btnRMAUnfinished_Detail.Text = "Detail";
			this.btnRMAUnfinished_Detail.UseVisualStyleBackColor = true;
			this.btnRMAUnfinished_Detail.Click += new System.EventHandler(this.btnRMAUnfinishedDetail_Click);
			// 
			// btnRMAUnfinished_Edit
			// 
			this.btnRMAUnfinished_Edit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnfinished_Edit.Location = new System.Drawing.Point(500, 55);
			this.btnRMAUnfinished_Edit.Name = "btnRMAUnfinished_Edit";
			this.btnRMAUnfinished_Edit.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnfinished_Edit.TabIndex = 12;
			this.btnRMAUnfinished_Edit.Text = "Edit";
			this.btnRMAUnfinished_Edit.UseVisualStyleBackColor = true;
			this.btnRMAUnfinished_Edit.Click += new System.EventHandler(this.btnRMAUnfinishedEdit_Click);
			// 
			// btnRMAUnfinished_JobLog
			// 
			this.btnRMAUnfinished_JobLog.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRMAUnfinished_JobLog.Location = new System.Drawing.Point(419, 55);
			this.btnRMAUnfinished_JobLog.Name = "btnRMAUnfinished_JobLog";
			this.btnRMAUnfinished_JobLog.Size = new System.Drawing.Size(75, 23);
			this.btnRMAUnfinished_JobLog.TabIndex = 11;
			this.btnRMAUnfinished_JobLog.Text = "Job Log";
			this.btnRMAUnfinished_JobLog.UseVisualStyleBackColor = true;
			this.btnRMAUnfinished_JobLog.Click += new System.EventHandler(this.btnRMAUnfinishedJobLog_Click);
			// 
			// lblRMAUnfinished_Selected
			// 
			this.lblRMAUnfinished_Selected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMAUnfinished_Selected.Location = new System.Drawing.Point(276, 81);
			this.lblRMAUnfinished_Selected.Name = "lblRMAUnfinished_Selected";
			this.lblRMAUnfinished_Selected.Size = new System.Drawing.Size(527, 23);
			this.lblRMAUnfinished_Selected.TabIndex = 9;
			this.lblRMAUnfinished_Selected.Text = "Selected RMA:";
			this.lblRMAUnfinished_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ucRMAUnfinished_ListLabels2
			// 
			this.ucRMAUnfinished_ListLabels2.BackColor = System.Drawing.Color.Transparent;
			this.ucRMAUnfinished_ListLabels2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRMAUnfinished_ListLabels2.Location = new System.Drawing.Point(814, 110);
			this.ucRMAUnfinished_ListLabels2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.ucRMAUnfinished_ListLabels2.Name = "ucRMAUnfinished_ListLabels2";
			this.ucRMAUnfinished_ListLabels2.Size = new System.Drawing.Size(102, 86);
			this.ucRMAUnfinished_ListLabels2.TabIndex = 20;
			// 
			// lstvRMAUnfinished
			// 
			this.lstvRMAUnfinished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
			this.lstvRMAUnfinished.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstvRMAUnfinished.FullRowSelect = true;
			this.lstvRMAUnfinished.GridLines = true;
			this.lstvRMAUnfinished.HideSelection = false;
			this.lstvRMAUnfinished.Location = new System.Drawing.Point(276, 110);
			this.lstvRMAUnfinished.MultiSelect = false;
			this.lstvRMAUnfinished.Name = "lstvRMAUnfinished";
			this.lstvRMAUnfinished.Size = new System.Drawing.Size(527, 483);
			this.lstvRMAUnfinished.TabIndex = 8;
			this.lstvRMAUnfinished.UseCompatibleStateImageBehavior = false;
			this.lstvRMAUnfinished.View = System.Windows.Forms.View.Details;
			this.lstvRMAUnfinished.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRMAViewer_Click);
			this.lstvRMAUnfinished.SelectedIndexChanged += new System.EventHandler(this.lstRMAUnfinished_SelectedIndexChanged);
			this.lstvRMAUnfinished.DoubleClick += new System.EventHandler(this.lstRMAUnfinished_DoubleClick);
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "RMA #";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader11.Width = 84;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Date Issued";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader12.Width = 117;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Branch";
			this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader13.Width = 300;
			// 
			// tabRMATechs
			// 
			this.tabRMATechs.Controls.Add(this.btnRMATechs_Export);
			this.tabRMATechs.Controls.Add(this.lblRMATechs_Header);
			this.tabRMATechs.Controls.Add(this.lstvRMATechs);
			this.tabRMATechs.Controls.Add(this.cmbRMATechs);
			this.tabRMATechs.Controls.Add(this.lblRMATechs_Select);
			this.tabRMATechs.Location = new System.Drawing.Point(4, 22);
			this.tabRMATechs.Name = "tabRMATechs";
			this.tabRMATechs.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMATechs.Size = new System.Drawing.Size(1062, 682);
			this.tabRMATechs.TabIndex = 8;
			this.tabRMATechs.Text = "Techs RMAs";
			this.tabRMATechs.UseVisualStyleBackColor = true;
			// 
			// btnRMATechs_Export
			// 
			this.btnRMATechs_Export.Location = new System.Drawing.Point(729, 552);
			this.btnRMATechs_Export.Name = "btnRMATechs_Export";
			this.btnRMATechs_Export.Size = new System.Drawing.Size(75, 23);
			this.btnRMATechs_Export.TabIndex = 23;
			this.btnRMATechs_Export.Text = "Export";
			this.btnRMATechs_Export.UseVisualStyleBackColor = true;
			this.btnRMATechs_Export.Click += new System.EventHandler(this.btnRMA_ExportByTech_Click);
			// 
			// lblRMATechs_Header
			// 
			this.lblRMATechs_Header.AutoSize = true;
			this.lblRMATechs_Header.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRMATechs_Header.Location = new System.Drawing.Point(480, 11);
			this.lblRMATechs_Header.Name = "lblRMATechs_Header";
			this.lblRMATechs_Header.Size = new System.Drawing.Size(104, 19);
			this.lblRMATechs_Header.TabIndex = 4;
			this.lblRMATechs_Header.Text = "Techs RMAs";
			// 
			// lstvRMATechs
			// 
			this.lstvRMATechs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader26});
			this.lstvRMATechs.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstvRMATechs.FullRowSelect = true;
			this.lstvRMATechs.GridLines = true;
			this.lstvRMATechs.HideSelection = false;
			this.lstvRMATechs.Location = new System.Drawing.Point(342, 92);
			this.lstvRMATechs.MultiSelect = false;
			this.lstvRMATechs.Name = "lstvRMATechs";
			this.lstvRMATechs.Size = new System.Drawing.Size(381, 483);
			this.lstvRMATechs.TabIndex = 3;
			this.lstvRMATechs.UseCompatibleStateImageBehavior = false;
			this.lstvRMATechs.View = System.Windows.Forms.View.Details;
			this.lstvRMATechs.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstRMAViewer_Click);
			this.lstvRMATechs.DoubleClick += new System.EventHandler(this.lstvRMATechs_DoubleClick);
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "RMA #";
			this.columnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader23.Width = 110;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "Date Issued";
			this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader24.Width = 120;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "Open/Closed";
			this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader26.Width = 120;
			// 
			// cmbRMATechs
			// 
			this.cmbRMATechs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRMATechs.FormattingEnabled = true;
			this.cmbRMATechs.Location = new System.Drawing.Point(414, 65);
			this.cmbRMATechs.Name = "cmbRMATechs";
			this.cmbRMATechs.Size = new System.Drawing.Size(237, 21);
			this.cmbRMATechs.TabIndex = 1;
			this.cmbRMATechs.SelectedIndexChanged += new System.EventHandler(this.cmbRMAbyTechTechs_SelectedIndexChanged);
			// 
			// lblRMATechs_Select
			// 
			this.lblRMATechs_Select.AutoSize = true;
			this.lblRMATechs_Select.Location = new System.Drawing.Point(411, 47);
			this.lblRMATechs_Select.Name = "lblRMATechs_Select";
			this.lblRMATechs_Select.Size = new System.Drawing.Size(65, 13);
			this.lblRMATechs_Select.TabIndex = 0;
			this.lblRMATechs_Select.Text = "Select Tech";
			// 
			// printPreviewDialog
			// 
			this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog.Enabled = true;
			this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
			this.printPreviewDialog.Name = "printPreviewDialog";
			this.printPreviewDialog.Visible = false;
			// 
			// FormLegacyRMAManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 708);
			this.Controls.Add(this.tabRMA);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1080, 740);
			this.Name = "FormLegacyRMAManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Legacy RMAs";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRMAManagement_FormClosing);
			this.Load += new System.EventHandler(this.FormRMAManagement_Load);
			this.Shown += new System.EventHandler(this.FormRMAManagement_Shown);
			this.tabRMA.ResumeLayout(false);
			this.tabRMACreate.ResumeLayout(false);
			this.tabRMACreate.PerformLayout();
			this.grpRMACreate.ResumeLayout(false);
			this.grpRMACreate.PerformLayout();
			this.pnlRMACreateSidebar.ResumeLayout(false);
			this.pnlRMACreateSidebar.PerformLayout();
			this.tabRMAEdit.ResumeLayout(false);
			this.tabRMAEdit.PerformLayout();
			this.grpRMAEdit.ResumeLayout(false);
			this.grpRMAEdit.PerformLayout();
			this.pnlRMAEdit_Sidebar.ResumeLayout(false);
			this.pnlRMAEdit_Sidebar.PerformLayout();
			this.tabRMAJobLog.ResumeLayout(false);
			this.tabRMAJobLog.PerformLayout();
			this.pnlRMAJobLog_Header.ResumeLayout(false);
			this.pnlRMAJobLog_Header.PerformLayout();
			this.pnlRMAJobLog_Completed.ResumeLayout(false);
			this.pnlRMAJobLog_Completed.PerformLayout();
			this.tabRMADetail.ResumeLayout(false);
			this.tabRMADetail.PerformLayout();
			this.pnlRMADetail_Header.ResumeLayout(false);
			this.tabRMAMasterList.ResumeLayout(false);
			this.tabRMAMasterList.PerformLayout();
			this.tabRMAUnreceived.ResumeLayout(false);
			this.tabRMAUnreceived.PerformLayout();
			this.tabRMAUnfinished.ResumeLayout(false);
			this.tabRMAUnfinished.PerformLayout();
			this.tabRMATechs.ResumeLayout(false);
			this.tabRMATechs.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabRMA;
		private System.Windows.Forms.TabPage tabRMACreate;
		private System.Windows.Forms.Label lblRMACreate_AssignTo;
		private System.Windows.Forms.Label lblRMACreate;
		private System.Windows.Forms.Button btnRMACreate_Reset;
		private System.Windows.Forms.GroupBox grpRMACreate;
		private System.Windows.Forms.TextBox txtRMACreate_CustomerWorkOrder;
		private System.Windows.Forms.Label lblRMACreate_CustomerWorkOrder;
		private System.Windows.Forms.TextBox txtRMACreate_TicketNumber;
		private System.Windows.Forms.Label lblRMACreate_TicketNumber;
		private System.Windows.Forms.TextBox txtRMACreate_JobNumber;
		private System.Windows.Forms.ComboBox cmbRMACreate_DisplayName;
		private System.Windows.Forms.CheckBox chkRMACreate_RiskKit;
		private System.Windows.Forms.CheckBox chkRMACreate_APR;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Create5;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Create4;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Create3;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Create2;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Create1;
		private System.Windows.Forms.Panel pnlRMACreateSidebar;
		private System.Windows.Forms.TextBox txtRMACreate_CustomerRequests;
		private System.Windows.Forms.TextBox txtRMACreate_YescoNotes;
		private System.Windows.Forms.Label lblRMACreate_YescoNotes;
		private System.Windows.Forms.Label lblRMACreate_CustomerRequests;
		private System.Windows.Forms.DateTimePicker dtpRMACreate_DateIssued;
		private System.Windows.Forms.Button btnRMACreate_Create;
		private System.Windows.Forms.TextBox txtRMACreate_Tracking;
		private System.Windows.Forms.TextBox txtRMACreate_AuthBy;
		private System.Windows.Forms.TextBox txtRMACreate_PO;
		private System.Windows.Forms.Label lblRMACreate_Tracking;
		private System.Windows.Forms.Label lblRMACreate_DateIssued;
		private System.Windows.Forms.Label lblRMACreate_AuthBy;
		private System.Windows.Forms.Label lblRMACreate_PO;
		private System.Windows.Forms.Label lblRMACreate_JobNumber;
		private System.Windows.Forms.Label lblRMACreate_DisplayName;
		private System.Windows.Forms.Button btnRMACreate_SelectTech;
		private System.Windows.Forms.ComboBox cmbRMACreate_TechSelection;
		private System.Windows.Forms.TabPage tabRMAEdit;
		private System.Windows.Forms.Button btnRMAEdit_ApprovalRequired;
		private System.Windows.Forms.Label lblRMAEdit_AssignedTech;
		private System.Windows.Forms.ComboBox cmbRMAEdit_AssignedTech;
		private System.Windows.Forms.Button btnRMAEdit_PrintScreen;
		private System.Windows.Forms.Button btnRMAEdit_Find;
		private System.Windows.Forms.TextBox txtRMAEdit_RMANumber;
		private System.Windows.Forms.Label lblRMAEdit_RMAEdit;
		private System.Windows.Forms.GroupBox grpRMAEdit;
		private System.Windows.Forms.TextBox txtRMAEdit_CustomerWorkOrder;
		private System.Windows.Forms.Label lblRMAEdit_CustomerWorkOrder;
		private System.Windows.Forms.TextBox txtRMAEdit_TicketNumber;
		private System.Windows.Forms.Label lblRMAEdit_TicketNumber;
		private System.Windows.Forms.TextBox txtRMAEdit_JobNumber;
		private System.Windows.Forms.Label lblRMAEdit_Completed;
		private System.Windows.Forms.CheckBox chkRMAEdit_RiskKit;
		private System.Windows.Forms.CheckBox chkRMAEdit_APR;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Edit1;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Edit2;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Edit3;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Edit4;
		private ucLegacyRMAPartLineEditor ucRMAPartLineEditor_Edit5;
		private System.Windows.Forms.Label lblRMAEdit_JobNumber;
		private System.Windows.Forms.TextBox txtRMAEdit_DisplayName;
		private System.Windows.Forms.Label lblRMAEdit_DisplayName;
		private System.Windows.Forms.Panel pnlRMAEdit_Sidebar;
		private System.Windows.Forms.TextBox txtRMAEdit_CustomerRequests;
		private System.Windows.Forms.TextBox txtRMAEdit_YescoNotes;
		private System.Windows.Forms.Label lblRMAEdit_YescoNotes;
		private System.Windows.Forms.DateTimePicker dtpRMAEdit_DateIssued;
		private System.Windows.Forms.Button btnRMAEdit_Update;
		private System.Windows.Forms.TextBox txtRMAEdit_Tracking;
		private System.Windows.Forms.TextBox txtRMAEdit_AuthBy;
		private System.Windows.Forms.TextBox txtRMAEdit_PO;
		private System.Windows.Forms.Label lblRMAEdit_CustomerRequests;
		private System.Windows.Forms.Label lblRMAEdit_Tracking;
		private System.Windows.Forms.Label lblRMAEdit_DateIssued;
		private System.Windows.Forms.Label lblRMAEdit_AuthBy;
		private System.Windows.Forms.Label lblRMAEdit_PO;
		private System.Windows.Forms.TabPage tabRMAJobLog;
		private System.Windows.Forms.TextBox txtRMAJobLog_CustomerWorkOrder;
		private System.Windows.Forms.Label lblRMAJobLog_TicketNumber;
		private System.Windows.Forms.TextBox txtRMAJobLog_TicketNumber;
		private System.Windows.Forms.TextBox txtRMAJobLog_CustomerRequests;
		private System.Windows.Forms.TextBox txtRMAJobLog_YescoNotes;
		private System.Windows.Forms.Label lblRMAJobLog_CustomerRequests;
		private System.Windows.Forms.Button btnRMAJobLog_CreateShipper;
		private System.Windows.Forms.Label lblRMAJobLog_NoReturnApproval;
		private System.Windows.Forms.Label lblRMAJobLog_JobNumber;
		private System.Windows.Forms.TextBox txtRMAJobLog_JobNumber;
		private System.Windows.Forms.TextBox txtRMAJobLog_DisplayName;
		private System.Windows.Forms.Label lblRMAJobLog_DisplayName;
		private System.Windows.Forms.Button btnRMAJobLog_PrintScreen;
		private System.Windows.Forms.Button btnRMAJobLog_EnterBottom;
		private System.Windows.Forms.Button btnRMAJobLog_EnterTop;
		private System.Windows.Forms.Label lblRMAJobLog_YescoNotes;
		private System.Windows.Forms.Panel pnlRMAJobLog_Header;
		private System.Windows.Forms.TextBox txtRMAJobLog_WorkOrders;
		private System.Windows.Forms.Label lblRMAJobLogShow_PurchaseOrder;
		private System.Windows.Forms.Label lblRMAJobLogShow_RMANumber;
		private System.Windows.Forms.Label lblRMAJobLog_WorkOrders;
		private System.Windows.Forms.Label lblRMAJobLog_PurchaseOrder;
		private System.Windows.Forms.Label lblRMAJobLog_RMANumber;
		private System.Windows.Forms.Panel pnlRMAJobLog_Completed;
		private System.Windows.Forms.RadioButton radRMAJobLog_CompletedNo;
		private System.Windows.Forms.RadioButton radRMAJobLog_CompletedYes;
		private System.Windows.Forms.Label lblRMAJobLog_Completed;
		private ucLegacyRMAJobLogLine ucRMAJobLogLine5;
		private ucLegacyRMAJobLogLine ucRMAJobLogLine4;
		private ucLegacyRMAJobLogLine ucRMAJobLogLine3;
		private ucLegacyRMAJobLogLine ucRMAJobLogLine2;
		private ucLegacyRMAJobLogLine ucRMAJobLogLine1;
		private System.Windows.Forms.TabPage tabRMADetail;
		private System.Windows.Forms.Button btnRMADetail_PrintScreen;
		private System.Windows.Forms.TextBox txtRMADetail_CustomerRequests;
		private System.Windows.Forms.TextBox txtRMADetail_YescoNotes;
		private System.Windows.Forms.Label lblRMADetail_CustomerRequests;
		private System.Windows.Forms.Button btnRMADetail_CreatePDF;
		private System.Windows.Forms.Label lblRMADetail_YescoNotes;
		private System.Windows.Forms.Panel pnlRMADetail_Header;
		private System.Windows.Forms.Label lblRMADetail_Show_CustomerWorkOrder;
		private System.Windows.Forms.Label lblRMADetail_CustomerWorkOrder;
		private System.Windows.Forms.Label lblRMADetail_Show_TicketNumber;
		private System.Windows.Forms.Label lblRMADetail_TicketNumber;
		private System.Windows.Forms.Label lblRMADetail_Show_APR;
		private System.Windows.Forms.Label lblRMADetail_APR;
		private System.Windows.Forms.Label lblRMADetail_Show_ShippingTelNum;
		private System.Windows.Forms.Label lblRMADetail_Show_ShippingStateCity;
		private System.Windows.Forms.Label lblRMADetail_Show_ShippingRoad;
		private System.Windows.Forms.Label lblRMADetail_Show_ShippingName;
		private System.Windows.Forms.Label lblRMADetail_Show_AddressTelNum;
		private System.Windows.Forms.Label lblRMADetail_Show_AddressStateCity;
		private System.Windows.Forms.Label lblRMADetail_Show_AddressRoad;
		private System.Windows.Forms.Label lblRMADetail_Show_AddressName;
		private System.Windows.Forms.Label lblRMADetail_Show_DateIssued;
		private System.Windows.Forms.Label lblRMADetail_Show_IssuedBy;
		private System.Windows.Forms.Label lblRMADetail_Show_PurchaseOrder;
		private System.Windows.Forms.Label lblRMADetail_Show_RMANum;
		private System.Windows.Forms.Label lblRMADetail_ShipToAddress;
		private System.Windows.Forms.Label lblRMADetail_CustomerAddress;
		private System.Windows.Forms.Label lblRMADetail_PurchaseOrder;
		private System.Windows.Forms.Label lblRMADetail_Issuer;
		private System.Windows.Forms.Label lblRMADetail_RMANumber;
		private System.Windows.Forms.Label lblRMADetail_IssueDate;
		private ucLegacyRMAPartDetail ucRMADetail_Part5;
		private ucLegacyRMAPartDetail ucRMADetail_Part4;
		private ucLegacyRMAPartDetail ucRMADetail_Part3;
		private ucLegacyRMAPartDetail ucRMADetail_Part2;
		private ucLegacyRMAPartDetail ucRMADetail_Part1;
		private System.Windows.Forms.TabPage tabRMAMasterList;
		private System.Windows.Forms.Button btnRMAMasterList_Export;
		private System.Windows.Forms.Label lblRMAMasterList_SubHeader;
		private System.Windows.Forms.Label lblRMAMasterList_Header;
		private System.Windows.Forms.Button btnRMAMaster_Detail;
		private System.Windows.Forms.Button btnRMAMaster_Edit;
		private System.Windows.Forms.Button btnRMAMaster_JobLog;
		private System.Windows.Forms.Label lblRMAMaster_Selected;
		private ucLegacyRMAListLabels ucRMAMaster_ListLabels3;
		private System.Windows.Forms.ListView lstRMAMaster;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TabPage tabRMAUnreceived;
		private System.Windows.Forms.Button btnRMAUnreceived_Export;
		private System.Windows.Forms.Label lblRMAUnreceived_SubHeader;
		private System.Windows.Forms.Label lblRMAUnreceived_Header;
		private System.Windows.Forms.Button btnRMAUnreceived_Detail;
		private System.Windows.Forms.Button btnRMAUnreceived_Edit;
		private System.Windows.Forms.Button btnRMAUnreceived_JobLog;
		private System.Windows.Forms.Label lblRMAUnreceived_Tech;
		private System.Windows.Forms.Label lblRMAUnreceived_Selected;
		private ucLegacyRMAListLabels ucRMAUnreceived_ListLabels1;
		private System.Windows.Forms.ListView lstvRMAUnreceived;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.TabPage tabRMAUnfinished;
		private System.Windows.Forms.Button btnRMAUnfinished_Export;
		private System.Windows.Forms.Label lblRMAUnfinished_SubHeader;
		private System.Windows.Forms.Label lblRMAUnfinished_Header;
		private System.Windows.Forms.Button btnRMAUnfinished_Detail;
		private System.Windows.Forms.Button btnRMAUnfinished_Edit;
		private System.Windows.Forms.Button btnRMAUnfinished_JobLog;
		private System.Windows.Forms.Label lblRMAUnfinished_Selected;
		private ucLegacyRMAListLabels ucRMAUnfinished_ListLabels2;
		private System.Windows.Forms.ListView lstvRMAUnfinished;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.TabPage tabRMATechs;
		private System.Windows.Forms.Button btnRMATechs_Export;
		private System.Windows.Forms.Label lblRMATechs_Header;
		private System.Windows.Forms.ListView lstvRMATechs;
		private System.Windows.Forms.ColumnHeader columnHeader23;
		private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ComboBox cmbRMATechs;
		private System.Windows.Forms.Label lblRMATechs_Select;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
		private System.Drawing.Printing.PrintDocument printDocument;
	}
}