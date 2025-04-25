using SDB.UserControls.Shipment;

namespace SDB.Forms.RMA
{
	partial class FormRMA_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMA_Editor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbNotesFlag = new System.Windows.Forms.PictureBox();
            this.txtRMADetails_Notes = new System.Windows.Forms.TextBox();
            this.lblRMADetails_Notes = new System.Windows.Forms.Label();
            this.btnRMATime = new System.Windows.Forms.Button();
            this.txtRMADetails_Duration = new System.Windows.Forms.TextBox();
            this.lblRMADetails_Duration = new System.Windows.Forms.Label();
            this.txtRMADetails_Finalized = new System.Windows.Forms.TextBox();
            this.lblRMADetails_Finalized = new System.Windows.Forms.Label();
            this.txtRMADetails_Completed = new System.Windows.Forms.TextBox();
            this.lblRMADetails_Completed = new System.Windows.Forms.Label();
            this.chkRMA_Hot = new System.Windows.Forms.CheckBox();
            this.chkRMADetails_APR = new System.Windows.Forms.CheckBox();
            this.txtRMADetails_LegacyRMA = new System.Windows.Forms.TextBox();
            this.lblRMADetails_LegacyRMA = new System.Windows.Forms.Label();
            this.radRMADetails_PONumber = new System.Windows.Forms.RadioButton();
            this.radRMADetails_JobNumber = new System.Windows.Forms.RadioButton();
            this.txtRMADetails_Job_PO = new System.Windows.Forms.TextBox();
            this.txtRMADetails_CreationDate = new System.Windows.Forms.TextBox();
            this.lblRMADetails_CreationDate = new System.Windows.Forms.Label();
            this.txtRMADetails_CreatedBy = new System.Windows.Forms.TextBox();
            this.lblRMADetails_CreatedBy = new System.Windows.Forms.Label();
            this.txtRMADetails_AssignedTo = new System.Windows.Forms.TextBox();
            this.lblRMADetails_AssignedTo = new System.Windows.Forms.Label();
            this.lblRMADetails_Asset = new System.Windows.Forms.Label();
            this.txtRMADetails_Asset = new System.Windows.Forms.TextBox();
            this.lblTicket_Number = new System.Windows.Forms.Label();
            this.txtTicket_Number = new System.Windows.Forms.TextBox();
            this.lblRMADetails_RMANumber = new System.Windows.Forms.Label();
            this.txtRMADetails_RMANumber = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblAsset_Pitch = new System.Windows.Forms.Label();
            this.txtAsset_Pitch = new System.Windows.Forms.TextBox();
            this.lblAsset_Matrix = new System.Windows.Forms.Label();
            this.txtAsset_Matrix = new System.Windows.Forms.TextBox();
            this.lblAsset_ControllerHw = new System.Windows.Forms.Label();
            this.txtAsset_ControllerHw = new System.Windows.Forms.TextBox();
            this.lblAsset_SignType = new System.Windows.Forms.Label();
            this.txtAsset_SignType = new System.Windows.Forms.TextBox();
            this.lblAsset_InstallDate = new System.Windows.Forms.Label();
            this.txtAsset_InstallDate = new System.Windows.Forms.TextBox();
            this.lblTicket_OSANotes = new System.Windows.Forms.Label();
            this.txtTicket_OSANotes = new System.Windows.Forms.TextBox();
            this.olvAssemblyAdd = new BrightIdeasSoftware.ObjectListView();
            this.olvColAssyAdd_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssyAdd_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssyAdd_Notes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssyAdd_Grid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssyAdd_Discarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlAssemblyAdd_Control = new System.Windows.Forms.Panel();
            this.lblAssemblyAdd_SelectedAssemblyID = new System.Windows.Forms.Label();
            this.lblAssemblyAdd_Qty = new System.Windows.Forms.Label();
            this.txtAssemblyAdd_Qty = new System.Windows.Forms.TextBox();
            this.tabControl_RMA = new System.Windows.Forms.TabControl();
            this.tabAssemblyTypes = new System.Windows.Forms.TabPage();
            this.tabReceive = new System.Windows.Forms.TabPage();
            this.pnlReceive_Left = new System.Windows.Forms.Panel();
            this.olvReceive_Assemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColReceive_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDiscarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_Receive_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_Receive_User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_AssemblySerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColReceive_BinID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ctxAssemblyReceive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuReceive_Undo = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabRepair = new System.Windows.Forms.TabPage();
            this.pnlRepair_RightSide = new System.Windows.Forms.Panel();
            this.pnlRepair_RepairSection = new System.Windows.Forms.Panel();
            this.pnlRepair_RepairDetail = new System.Windows.Forms.Panel();
            this.btnRepair_SerialNumberSearch = new System.Windows.Forms.Button();
            this.lblRepair_SerialNumber = new System.Windows.Forms.Label();
            this.txtRepair_SerialNumber = new System.Windows.Forms.TextBox();
            this.chkRepair_UnlockAssemblyFromType = new System.Windows.Forms.CheckBox();
            this.btnAssemblyManagement = new System.Windows.Forms.Button();
            this.btnRepair_Save = new System.Windows.Forms.Button();
            this.lblRepair_Assembly = new System.Windows.Forms.Label();
            this.btnRepair_Unfinish = new System.Windows.Forms.Button();
            this.lblRepair_OriginalJobNumber = new System.Windows.Forms.Label();
            this.grpRepair_RepairNotes = new System.Windows.Forms.GroupBox();
            this.txtRepair_Notes = new System.Windows.Forms.TextBox();
            this.txtRepair_OriginalJobNumber = new System.Windows.Forms.TextBox();
            this.grpRepair_RepairTypes = new System.Windows.Forms.GroupBox();
            this.olvRepair_RepairTypes = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepair_RepairType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRepair_RepairType_Control = new System.Windows.Forms.Panel();
            this.btnRepair_RepairType_Remove = new System.Windows.Forms.Button();
            this.btnRepair_RepairType_Add = new System.Windows.Forms.Button();
            this.btnRepair_Finish = new System.Windows.Forms.Button();
            this.txtRepair_LEDBoard_Calibration = new System.Windows.Forms.TextBox();
            this.lblRepair_LEDBoard_Calibration = new System.Windows.Forms.Label();
            this.cmbRepair_Assembly = new System.Windows.Forms.ComboBox();
            this.grpRepair_Components = new System.Windows.Forms.GroupBox();
            this.olvRepair_Components = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepair_Component_PartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepair_Component_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepair_Component_SilkLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRepair_Component_Control = new System.Windows.Forms.Panel();
            this.btnRepair_Component_Remove = new System.Windows.Forms.Button();
            this.lblRepair_Components_Qty = new System.Windows.Forms.Label();
            this.txtRepair_Components_Qty = new System.Windows.Forms.TextBox();
            this.btnRepair_Component_Add = new System.Windows.Forms.Button();
            this.txtRepair_MU = new System.Windows.Forms.TextBox();
            this.lblRepair_MU = new System.Windows.Forms.Label();
            this.pnlRepair_RepairTime = new System.Windows.Forms.Panel();
            this.cmbRepairAction = new System.Windows.Forms.ComboBox();
            this.btnRepair_StartStop = new System.Windows.Forms.Button();
            this.lblRepair_FinalizedBy = new System.Windows.Forms.Label();
            this.txtRepair_DateStarted = new System.Windows.Forms.TextBox();
            this.txtRepair_FinalizedBy = new System.Windows.Forms.TextBox();
            this.lblRepair_DateStarted = new System.Windows.Forms.Label();
            this.lblRepair_DateFinalized = new System.Windows.Forms.Label();
            this.txtRepair_DateCompleted = new System.Windows.Forms.TextBox();
            this.txtRepair_DateFinalized = new System.Windows.Forms.TextBox();
            this.lblRepair_DateCompleted = new System.Windows.Forms.Label();
            this.olvRepair_RepairLog = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepairLog_RepairStart = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepairLog_TimeTaken = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepairLog_UserName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtRepair_RepairTime = new System.Windows.Forms.TextBox();
            this.lblRepair_TechTime = new System.Windows.Forms.Label();
            this.lblRepair_RepairTime = new System.Windows.Forms.Label();
            this.txtRepair_TechTime = new System.Windows.Forms.TextBox();
            this.pnlRepair_FailureSection = new System.Windows.Forms.Panel();
            this.lblRepair_Discarded = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRepair_FailureType = new System.Windows.Forms.Label();
            this.txtRepair_FailureType = new System.Windows.Forms.TextBox();
            this.ctxRepairFailureTypeChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRepairFailureTypeChange = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRepair_FailureNotes = new System.Windows.Forms.TextBox();
            this.txtRepair_GridLocation = new System.Windows.Forms.TextBox();
            this.lblRepair_GridLocation = new System.Windows.Forms.Label();
            this.txtRepair_ReceiveDate = new System.Windows.Forms.TextBox();
            this.lblRepair_ReceiveDate = new System.Windows.Forms.Label();
            this.lblRepair_InventoryLocation = new System.Windows.Forms.Label();
            this.txtRepair_InventoryLocation = new System.Windows.Forms.TextBox();
            this.pnlRepair_AssemblySection = new System.Windows.Forms.Panel();
            this.olvRepair_Assemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColRepair_Assy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRepair_SerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRepair_Assemblies_Control = new System.Windows.Forms.Panel();
            this.lblRepair_SelectedAssemblyID = new System.Windows.Forms.Label();
            this.txtRepair_Assemblies_ReceivedOf = new System.Windows.Forms.Label();
            this.txtRepair_Assemblies_TotalQty = new System.Windows.Forms.TextBox();
            this.txtRepair_Assemblies_ReceivedQty = new System.Windows.Forms.TextBox();
            this.tabShipments = new System.Windows.Forms.TabPage();
            this.ucShipmentList1 = new SDB.UserControls.Shipment.ucShipmentList();
            this.tabAccounting = new System.Windows.Forms.TabPage();
            this.grpAccounting_Components = new System.Windows.Forms.GroupBox();
            this.olvAccounting_Components = new BrightIdeasSoftware.ObjectListView();
            this.olvColAccounting_Components_PartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAccounting_Components_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAccounting_Components_SilkLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAccounting_Components_Control = new System.Windows.Forms.Panel();
            this.chkAccounting_Charged = new System.Windows.Forms.CheckBox();
            this.lblAccounting_TotalCost = new System.Windows.Forms.Label();
            this.txtAccounting_TotalCost = new System.Windows.Forms.TextBox();
            this.lblAccounting_Components_Qty = new System.Windows.Forms.Label();
            this.txtAccounting_Components_Qty = new System.Windows.Forms.TextBox();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.spltSummary = new System.Windows.Forms.SplitContainer();
            this.grpSummary_Assemblies = new System.Windows.Forms.GroupBox();
            this.olvSummary_Assemblies = new BrightIdeasSoftware.ObjectListView();
            this.olvColSummary_Assembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_SerialNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Discarded = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_Grid = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_RepairBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_RepairTypes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_TotalTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_RootCause = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_FinalizedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Assemblies_FinalizedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlSummary_Assemblies_Control = new System.Windows.Forms.Panel();
            this.btnSummary_Assembly_Finalize = new System.Windows.Forms.Button();
            this.lblSummary_Assemblies_Qty = new System.Windows.Forms.Label();
            this.txtSummary_Assemblies_Qty = new System.Windows.Forms.TextBox();
            this.grpSummary_AssemblyRepairNotes = new System.Windows.Forms.GroupBox();
            this.txtSummary_AssemblyRepairNotes = new System.Windows.Forms.TextBox();
            this.grpSummary_Components = new System.Windows.Forms.GroupBox();
            this.olvSummary_Components = new BrightIdeasSoftware.ObjectListView();
            this.olvColSummary_Components_PartNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Components_Component = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColSummary_Components_SilkLabel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlSummary_Components_Control = new System.Windows.Forms.Panel();
            this.lblSummary_Components_Qty = new System.Windows.Forms.Label();
            this.txtSummary_Components_Qty = new System.Windows.Forms.TextBox();
            this.btnRepair_InventoryMove = new System.Windows.Forms.Button();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlJournal_Control = new System.Windows.Forms.Panel();
            this.btnJournal_Add = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.lblKey_Finalized_Desc = new System.Windows.Forms.Label();
            this.lblKey_Finalized = new System.Windows.Forms.Label();
            this.lblKey_Completed_Desc = new System.Windows.Forms.Label();
            this.lblKey_Completed = new System.Windows.Forms.Label();
            this.lblKey_InProgress_Desc = new System.Windows.Forms.Label();
            this.lblKey_InProgress = new System.Windows.Forms.Label();
            this.lblKey_Received_Desc = new System.Windows.Forms.Label();
            this.lblKey_Received = new System.Windows.Forms.Label();
            this.lblKey_NotReceived_Desc = new System.Windows.Forms.Label();
            this.lblKey_NotReceived = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlTopInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxHotDate = new System.Windows.Forms.TextBox();
            this.txtRmaStatus = new System.Windows.Forms.TextBox();
            this.lblRmaStatus = new System.Windows.Forms.Label();
            this.tabControlSide = new System.Windows.Forms.TabControl();
            this.tabAssetDetails = new System.Windows.Forms.TabPage();
            this.tabTicketDetails = new System.Windows.Forms.TabPage();
            this.lblTicket_Symptoms = new System.Windows.Forms.Label();
            this.txtTicket_Symptoms = new System.Windows.Forms.TextBox();
            this.grpJournal = new System.Windows.Forms.GroupBox();
            this.pnlBottomTabs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).BeginInit();
            this.pnlAssemblyAdd_Control.SuspendLayout();
            this.tabControl_RMA.SuspendLayout();
            this.tabAssemblyTypes.SuspendLayout();
            this.tabReceive.SuspendLayout();
            this.pnlReceive_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvReceive_Assemblies)).BeginInit();
            this.ctxAssemblyReceive.SuspendLayout();
            this.pnlReceive_Assemblies_Control.SuspendLayout();
            this.pnlReceive_Right.SuspendLayout();
            this.tabRepair.SuspendLayout();
            this.pnlRepair_RightSide.SuspendLayout();
            this.pnlRepair_RepairSection.SuspendLayout();
            this.pnlRepair_RepairDetail.SuspendLayout();
            this.grpRepair_RepairNotes.SuspendLayout();
            this.grpRepair_RepairTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairTypes)).BeginInit();
            this.pnlRepair_RepairType_Control.SuspendLayout();
            this.grpRepair_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Components)).BeginInit();
            this.pnlRepair_Component_Control.SuspendLayout();
            this.pnlRepair_RepairTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairLog)).BeginInit();
            this.pnlRepair_FailureSection.SuspendLayout();
            this.ctxRepairFailureTypeChange.SuspendLayout();
            this.pnlRepair_AssemblySection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Assemblies)).BeginInit();
            this.pnlRepair_Assemblies_Control.SuspendLayout();
            this.tabShipments.SuspendLayout();
            this.tabAccounting.SuspendLayout();
            this.grpAccounting_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAccounting_Components)).BeginInit();
            this.pnlAccounting_Components_Control.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltSummary)).BeginInit();
            this.spltSummary.Panel1.SuspendLayout();
            this.spltSummary.Panel2.SuspendLayout();
            this.spltSummary.SuspendLayout();
            this.grpSummary_Assemblies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSummary_Assemblies)).BeginInit();
            this.pnlSummary_Assemblies_Control.SuspendLayout();
            this.grpSummary_AssemblyRepairNotes.SuspendLayout();
            this.grpSummary_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSummary_Components)).BeginInit();
            this.pnlSummary_Components_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.pnlJournal_Control.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlKey.SuspendLayout();
            this.pnlTopInfo.SuspendLayout();
            this.tabControlSide.SuspendLayout();
            this.tabAssetDetails.SuspendLayout();
            this.tabTicketDetails.SuspendLayout();
            this.grpJournal.SuspendLayout();
            this.pnlBottomTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbNotesFlag
            // 
            this.pbNotesFlag.BackColor = System.Drawing.Color.Transparent;
            this.pbNotesFlag.Image = global::SDB.Properties.Resources.waving_flag_16x16;
            this.pbNotesFlag.Location = new System.Drawing.Point(47, 139);
            this.pbNotesFlag.Name = "pbNotesFlag";
            this.pbNotesFlag.Size = new System.Drawing.Size(16, 16);
            this.pbNotesFlag.TabIndex = 75;
            this.pbNotesFlag.TabStop = false;
            this.toolTip.SetToolTip(this.pbNotesFlag, "Read the journal and/or notes!");
            this.pbNotesFlag.Visible = false;
            this.pbNotesFlag.Click += new System.EventHandler(this.pbNotesFlag_Click);
            // 
            // txtRMADetails_Notes
            // 
            this.txtRMADetails_Notes.Location = new System.Drawing.Point(9, 155);
            this.txtRMADetails_Notes.Multiline = true;
            this.txtRMADetails_Notes.Name = "txtRMADetails_Notes";
            this.txtRMADetails_Notes.ReadOnly = true;
            this.txtRMADetails_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRMADetails_Notes.Size = new System.Drawing.Size(450, 72);
            this.txtRMADetails_Notes.TabIndex = 29;
            // 
            // lblRMADetails_Notes
            // 
            this.lblRMADetails_Notes.AutoSize = true;
            this.lblRMADetails_Notes.Location = new System.Drawing.Point(6, 139);
            this.lblRMADetails_Notes.Name = "lblRMADetails_Notes";
            this.lblRMADetails_Notes.Size = new System.Drawing.Size(35, 13);
            this.lblRMADetails_Notes.TabIndex = 28;
            this.lblRMADetails_Notes.Text = "Notes";
            // 
            // btnRMATime
            // 
            this.btnRMATime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRMATime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRMATime.Location = new System.Drawing.Point(399, 114);
            this.btnRMATime.Name = "btnRMATime";
            this.btnRMATime.Size = new System.Drawing.Size(64, 23);
            this.btnRMATime.TabIndex = 27;
            this.btnRMATime.Text = "Time...";
            this.toolTip.SetToolTip(this.btnRMATime, "Show RMA Time Analysis");
            this.btnRMATime.UseVisualStyleBackColor = true;
            this.btnRMATime.Click += new System.EventHandler(this.btnRMATime_Click);
            // 
            // txtRMADetails_Duration
            // 
            this.txtRMADetails_Duration.Location = new System.Drawing.Point(247, 116);
            this.txtRMADetails_Duration.Name = "txtRMADetails_Duration";
            this.txtRMADetails_Duration.ReadOnly = true;
            this.txtRMADetails_Duration.Size = new System.Drawing.Size(70, 20);
            this.txtRMADetails_Duration.TabIndex = 24;
            // 
            // lblRMADetails_Duration
            // 
            this.lblRMADetails_Duration.AutoSize = true;
            this.lblRMADetails_Duration.Location = new System.Drawing.Point(244, 100);
            this.lblRMADetails_Duration.Name = "lblRMADetails_Duration";
            this.lblRMADetails_Duration.Size = new System.Drawing.Size(47, 13);
            this.lblRMADetails_Duration.TabIndex = 23;
            this.lblRMADetails_Duration.Text = "Duration";
            // 
            // txtRMADetails_Finalized
            // 
            this.txtRMADetails_Finalized.Location = new System.Drawing.Point(323, 116);
            this.txtRMADetails_Finalized.Name = "txtRMADetails_Finalized";
            this.txtRMADetails_Finalized.ReadOnly = true;
            this.txtRMADetails_Finalized.Size = new System.Drawing.Size(70, 20);
            this.txtRMADetails_Finalized.TabIndex = 26;
            // 
            // lblRMADetails_Finalized
            // 
            this.lblRMADetails_Finalized.AutoSize = true;
            this.lblRMADetails_Finalized.Location = new System.Drawing.Point(320, 100);
            this.lblRMADetails_Finalized.Name = "lblRMADetails_Finalized";
            this.lblRMADetails_Finalized.Size = new System.Drawing.Size(48, 13);
            this.lblRMADetails_Finalized.TabIndex = 25;
            this.lblRMADetails_Finalized.Text = "Finalized";
            // 
            // txtRMADetails_Completed
            // 
            this.txtRMADetails_Completed.Location = new System.Drawing.Point(171, 116);
            this.txtRMADetails_Completed.Name = "txtRMADetails_Completed";
            this.txtRMADetails_Completed.ReadOnly = true;
            this.txtRMADetails_Completed.Size = new System.Drawing.Size(70, 20);
            this.txtRMADetails_Completed.TabIndex = 22;
            // 
            // lblRMADetails_Completed
            // 
            this.lblRMADetails_Completed.AutoSize = true;
            this.lblRMADetails_Completed.Location = new System.Drawing.Point(168, 100);
            this.lblRMADetails_Completed.Name = "lblRMADetails_Completed";
            this.lblRMADetails_Completed.Size = new System.Drawing.Size(57, 13);
            this.lblRMADetails_Completed.TabIndex = 21;
            this.lblRMADetails_Completed.Text = "Completed";
            // 
            // chkRMA_Hot
            // 
            this.chkRMA_Hot.AutoCheck = false;
            this.chkRMA_Hot.AutoSize = true;
            this.chkRMA_Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRMA_Hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRMA_Hot.ForeColor = System.Drawing.Color.Gray;
            this.chkRMA_Hot.Location = new System.Drawing.Point(265, 19);
            this.chkRMA_Hot.Name = "chkRMA_Hot";
            this.chkRMA_Hot.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.chkRMA_Hot.Size = new System.Drawing.Size(66, 26);
            this.chkRMA_Hot.TabIndex = 32;
            this.chkRMA_Hot.Text = "HOT";
            this.toolTip.SetToolTip(this.chkRMA_Hot, "Urgent");
            this.chkRMA_Hot.UseVisualStyleBackColor = true;
            this.chkRMA_Hot.CheckedChanged += new System.EventHandler(this.chkRMA_Hot_CheckedChanged);
            // 
            // chkRMADetails_APR
            // 
            this.chkRMADetails_APR.AutoCheck = false;
            this.chkRMADetails_APR.AutoSize = true;
            this.chkRMADetails_APR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRMADetails_APR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRMADetails_APR.ForeColor = System.Drawing.Color.Gray;
            this.chkRMADetails_APR.Location = new System.Drawing.Point(197, 19);
            this.chkRMADetails_APR.Name = "chkRMADetails_APR";
            this.chkRMADetails_APR.Padding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.chkRMADetails_APR.Size = new System.Drawing.Size(66, 26);
            this.chkRMADetails_APR.TabIndex = 30;
            this.chkRMADetails_APR.Text = "APR";
            this.toolTip.SetToolTip(this.chkRMADetails_APR, "Advanced Parts Replacement");
            this.chkRMADetails_APR.UseVisualStyleBackColor = true;
            this.chkRMADetails_APR.CheckedChanged += new System.EventHandler(this.chkRMADetails_APR_CheckedChanged);
            // 
            // txtRMADetails_LegacyRMA
            // 
            this.txtRMADetails_LegacyRMA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRMADetails_LegacyRMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMADetails_LegacyRMA.Location = new System.Drawing.Point(380, 77);
            this.txtRMADetails_LegacyRMA.Name = "txtRMADetails_LegacyRMA";
            this.txtRMADetails_LegacyRMA.ReadOnly = true;
            this.txtRMADetails_LegacyRMA.Size = new System.Drawing.Size(79, 20);
            this.txtRMADetails_LegacyRMA.TabIndex = 15;
            this.txtRMADetails_LegacyRMA.Click += new System.EventHandler(this.txtRMADetails_LegacyRMA_Click);
            // 
            // lblRMADetails_LegacyRMA
            // 
            this.lblRMADetails_LegacyRMA.AutoSize = true;
            this.lblRMADetails_LegacyRMA.Location = new System.Drawing.Point(377, 61);
            this.lblRMADetails_LegacyRMA.Name = "lblRMADetails_LegacyRMA";
            this.lblRMADetails_LegacyRMA.Size = new System.Drawing.Size(52, 13);
            this.lblRMADetails_LegacyRMA.TabIndex = 14;
            this.lblRMADetails_LegacyRMA.Text = "Legacy #";
            // 
            // radRMADetails_PONumber
            // 
            this.radRMADetails_PONumber.AutoCheck = false;
            this.radRMADetails_PONumber.AutoSize = true;
            this.radRMADetails_PONumber.Location = new System.Drawing.Point(63, 59);
            this.radRMADetails_PONumber.Name = "radRMADetails_PONumber";
            this.radRMADetails_PONumber.Size = new System.Drawing.Size(50, 17);
            this.radRMADetails_PONumber.TabIndex = 10;
            this.radRMADetails_PONumber.Text = "PO #";
            this.radRMADetails_PONumber.UseVisualStyleBackColor = true;
            // 
            // radRMADetails_JobNumber
            // 
            this.radRMADetails_JobNumber.AutoCheck = false;
            this.radRMADetails_JobNumber.AutoSize = true;
            this.radRMADetails_JobNumber.Checked = true;
            this.radRMADetails_JobNumber.Location = new System.Drawing.Point(6, 59);
            this.radRMADetails_JobNumber.Name = "radRMADetails_JobNumber";
            this.radRMADetails_JobNumber.Size = new System.Drawing.Size(52, 17);
            this.radRMADetails_JobNumber.TabIndex = 8;
            this.radRMADetails_JobNumber.TabStop = true;
            this.radRMADetails_JobNumber.Text = "Job #";
            this.radRMADetails_JobNumber.UseVisualStyleBackColor = true;
            // 
            // txtRMADetails_Job_PO
            // 
            this.txtRMADetails_Job_PO.Location = new System.Drawing.Point(6, 77);
            this.txtRMADetails_Job_PO.Name = "txtRMADetails_Job_PO";
            this.txtRMADetails_Job_PO.ReadOnly = true;
            this.txtRMADetails_Job_PO.Size = new System.Drawing.Size(145, 20);
            this.txtRMADetails_Job_PO.TabIndex = 9;
            // 
            // txtRMADetails_CreationDate
            // 
            this.txtRMADetails_CreationDate.Location = new System.Drawing.Point(95, 116);
            this.txtRMADetails_CreationDate.Name = "txtRMADetails_CreationDate";
            this.txtRMADetails_CreationDate.ReadOnly = true;
            this.txtRMADetails_CreationDate.Size = new System.Drawing.Size(70, 20);
            this.txtRMADetails_CreationDate.TabIndex = 20;
            // 
            // lblRMADetails_CreationDate
            // 
            this.lblRMADetails_CreationDate.AutoSize = true;
            this.lblRMADetails_CreationDate.Location = new System.Drawing.Point(92, 100);
            this.lblRMADetails_CreationDate.Name = "lblRMADetails_CreationDate";
            this.lblRMADetails_CreationDate.Size = new System.Drawing.Size(44, 13);
            this.lblRMADetails_CreationDate.TabIndex = 19;
            this.lblRMADetails_CreationDate.Text = "Created";
            // 
            // txtRMADetails_CreatedBy
            // 
            this.txtRMADetails_CreatedBy.Location = new System.Drawing.Point(9, 116);
            this.txtRMADetails_CreatedBy.Name = "txtRMADetails_CreatedBy";
            this.txtRMADetails_CreatedBy.ReadOnly = true;
            this.txtRMADetails_CreatedBy.Size = new System.Drawing.Size(80, 20);
            this.txtRMADetails_CreatedBy.TabIndex = 18;
            // 
            // lblRMADetails_CreatedBy
            // 
            this.lblRMADetails_CreatedBy.AutoSize = true;
            this.lblRMADetails_CreatedBy.Location = new System.Drawing.Point(6, 100);
            this.lblRMADetails_CreatedBy.Name = "lblRMADetails_CreatedBy";
            this.lblRMADetails_CreatedBy.Size = new System.Drawing.Size(58, 13);
            this.lblRMADetails_CreatedBy.TabIndex = 17;
            this.lblRMADetails_CreatedBy.Text = "Created by";
            // 
            // txtRMADetails_AssignedTo
            // 
            this.txtRMADetails_AssignedTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRMADetails_AssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMADetails_AssignedTo.Location = new System.Drawing.Point(157, 77);
            this.txtRMADetails_AssignedTo.Name = "txtRMADetails_AssignedTo";
            this.txtRMADetails_AssignedTo.ReadOnly = true;
            this.txtRMADetails_AssignedTo.Size = new System.Drawing.Size(217, 20);
            this.txtRMADetails_AssignedTo.TabIndex = 12;
            this.txtRMADetails_AssignedTo.Click += new System.EventHandler(this.txtRMADetails_AssignedTo_Click);
            // 
            // lblRMADetails_AssignedTo
            // 
            this.lblRMADetails_AssignedTo.AutoSize = true;
            this.lblRMADetails_AssignedTo.Location = new System.Drawing.Point(157, 61);
            this.lblRMADetails_AssignedTo.Name = "lblRMADetails_AssignedTo";
            this.lblRMADetails_AssignedTo.Size = new System.Drawing.Size(66, 13);
            this.lblRMADetails_AssignedTo.TabIndex = 11;
            this.lblRMADetails_AssignedTo.Text = "Assigned To";
            // 
            // lblRMADetails_Asset
            // 
            this.lblRMADetails_Asset.AutoSize = true;
            this.lblRMADetails_Asset.Location = new System.Drawing.Point(6, 6);
            this.lblRMADetails_Asset.Name = "lblRMADetails_Asset";
            this.lblRMADetails_Asset.Size = new System.Drawing.Size(33, 13);
            this.lblRMADetails_Asset.TabIndex = 5;
            this.lblRMADetails_Asset.Text = "Asset";
            // 
            // txtRMADetails_Asset
            // 
            this.txtRMADetails_Asset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRMADetails_Asset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMADetails_Asset.Location = new System.Drawing.Point(6, 22);
            this.txtRMADetails_Asset.Name = "txtRMADetails_Asset";
            this.txtRMADetails_Asset.ReadOnly = true;
            this.txtRMADetails_Asset.Size = new System.Drawing.Size(179, 23);
            this.txtRMADetails_Asset.TabIndex = 6;
            this.txtRMADetails_Asset.Click += new System.EventHandler(this.txtRMADetails_Asset_Click);
            // 
            // lblTicket_Number
            // 
            this.lblTicket_Number.AutoSize = true;
            this.lblTicket_Number.Location = new System.Drawing.Point(3, 6);
            this.lblTicket_Number.Name = "lblTicket_Number";
            this.lblTicket_Number.Size = new System.Drawing.Size(47, 13);
            this.lblTicket_Number.TabIndex = 2;
            this.lblTicket_Number.Text = "Ticket #";
            // 
            // txtTicket_Number
            // 
            this.txtTicket_Number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTicket_Number.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket_Number.Location = new System.Drawing.Point(70, 2);
            this.txtTicket_Number.Name = "txtTicket_Number";
            this.txtTicket_Number.ReadOnly = true;
            this.txtTicket_Number.Size = new System.Drawing.Size(117, 23);
            this.txtTicket_Number.TabIndex = 3;
            this.txtTicket_Number.Click += new System.EventHandler(this.txtRMADetails_TicketID_Click);
            // 
            // lblRMADetails_RMANumber
            // 
            this.lblRMADetails_RMANumber.AutoSize = true;
            this.lblRMADetails_RMANumber.Location = new System.Drawing.Point(12, 27);
            this.lblRMADetails_RMANumber.Name = "lblRMADetails_RMANumber";
            this.lblRMADetails_RMANumber.Size = new System.Drawing.Size(41, 13);
            this.lblRMADetails_RMANumber.TabIndex = 0;
            this.lblRMADetails_RMANumber.Text = "RMA #";
            // 
            // txtRMADetails_RMANumber
            // 
            this.txtRMADetails_RMANumber.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMADetails_RMANumber.Location = new System.Drawing.Point(59, 16);
            this.txtRMADetails_RMANumber.Name = "txtRMADetails_RMANumber";
            this.txtRMADetails_RMANumber.ReadOnly = true;
            this.txtRMADetails_RMANumber.Size = new System.Drawing.Size(132, 32);
            this.txtRMADetails_RMANumber.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(1072, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify RMA";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblAsset_Pitch
            // 
            this.lblAsset_Pitch.AutoSize = true;
            this.lblAsset_Pitch.Location = new System.Drawing.Point(69, 84);
            this.lblAsset_Pitch.Name = "lblAsset_Pitch";
            this.lblAsset_Pitch.Size = new System.Drawing.Size(31, 13);
            this.lblAsset_Pitch.TabIndex = 4;
            this.lblAsset_Pitch.Text = "Pitch";
            // 
            // txtAsset_Pitch
            // 
            this.txtAsset_Pitch.Location = new System.Drawing.Point(72, 100);
            this.txtAsset_Pitch.Name = "txtAsset_Pitch";
            this.txtAsset_Pitch.ReadOnly = true;
            this.txtAsset_Pitch.Size = new System.Drawing.Size(41, 20);
            this.txtAsset_Pitch.TabIndex = 5;
            this.txtAsset_Pitch.TabStop = false;
            // 
            // lblAsset_Matrix
            // 
            this.lblAsset_Matrix.AutoSize = true;
            this.lblAsset_Matrix.Location = new System.Drawing.Point(6, 84);
            this.lblAsset_Matrix.Name = "lblAsset_Matrix";
            this.lblAsset_Matrix.Size = new System.Drawing.Size(35, 13);
            this.lblAsset_Matrix.TabIndex = 2;
            this.lblAsset_Matrix.Text = "Matrix";
            // 
            // txtAsset_Matrix
            // 
            this.txtAsset_Matrix.Location = new System.Drawing.Point(6, 100);
            this.txtAsset_Matrix.Name = "txtAsset_Matrix";
            this.txtAsset_Matrix.ReadOnly = true;
            this.txtAsset_Matrix.Size = new System.Drawing.Size(60, 20);
            this.txtAsset_Matrix.TabIndex = 3;
            this.txtAsset_Matrix.TabStop = false;
            // 
            // lblAsset_ControllerHw
            // 
            this.lblAsset_ControllerHw.AutoSize = true;
            this.lblAsset_ControllerHw.Location = new System.Drawing.Point(6, 124);
            this.lblAsset_ControllerHw.Name = "lblAsset_ControllerHw";
            this.lblAsset_ControllerHw.Size = new System.Drawing.Size(100, 13);
            this.lblAsset_ControllerHw.TabIndex = 6;
            this.lblAsset_ControllerHw.Text = "Controller Hardware";
            // 
            // txtAsset_ControllerHw
            // 
            this.txtAsset_ControllerHw.Location = new System.Drawing.Point(6, 140);
            this.txtAsset_ControllerHw.Name = "txtAsset_ControllerHw";
            this.txtAsset_ControllerHw.ReadOnly = true;
            this.txtAsset_ControllerHw.Size = new System.Drawing.Size(179, 20);
            this.txtAsset_ControllerHw.TabIndex = 7;
            this.txtAsset_ControllerHw.TabStop = false;
            // 
            // lblAsset_SignType
            // 
            this.lblAsset_SignType.AutoSize = true;
            this.lblAsset_SignType.Location = new System.Drawing.Point(6, 45);
            this.lblAsset_SignType.Name = "lblAsset_SignType";
            this.lblAsset_SignType.Size = new System.Drawing.Size(55, 13);
            this.lblAsset_SignType.TabIndex = 0;
            this.lblAsset_SignType.Text = "Sign Type";
            // 
            // txtAsset_SignType
            // 
            this.txtAsset_SignType.Location = new System.Drawing.Point(6, 61);
            this.txtAsset_SignType.Name = "txtAsset_SignType";
            this.txtAsset_SignType.ReadOnly = true;
            this.txtAsset_SignType.Size = new System.Drawing.Size(179, 20);
            this.txtAsset_SignType.TabIndex = 1;
            this.txtAsset_SignType.TabStop = false;
            // 
            // lblAsset_InstallDate
            // 
            this.lblAsset_InstallDate.AutoSize = true;
            this.lblAsset_InstallDate.Location = new System.Drawing.Point(6, 163);
            this.lblAsset_InstallDate.Name = "lblAsset_InstallDate";
            this.lblAsset_InstallDate.Size = new System.Drawing.Size(60, 13);
            this.lblAsset_InstallDate.TabIndex = 8;
            this.lblAsset_InstallDate.Text = "Install Date";
            // 
            // txtAsset_InstallDate
            // 
            this.txtAsset_InstallDate.Location = new System.Drawing.Point(6, 179);
            this.txtAsset_InstallDate.Name = "txtAsset_InstallDate";
            this.txtAsset_InstallDate.ReadOnly = true;
            this.txtAsset_InstallDate.Size = new System.Drawing.Size(179, 20);
            this.txtAsset_InstallDate.TabIndex = 9;
            this.txtAsset_InstallDate.TabStop = false;
            // 
            // lblTicket_OSANotes
            // 
            this.lblTicket_OSANotes.AutoSize = true;
            this.lblTicket_OSANotes.Location = new System.Drawing.Point(6, 68);
            this.lblTicket_OSANotes.Name = "lblTicket_OSANotes";
            this.lblTicket_OSANotes.Size = new System.Drawing.Size(60, 13);
            this.lblTicket_OSANotes.TabIndex = 0;
            this.lblTicket_OSANotes.Text = "OSA Notes";
            // 
            // txtTicket_OSANotes
            // 
            this.txtTicket_OSANotes.Location = new System.Drawing.Point(6, 84);
            this.txtTicket_OSANotes.Multiline = true;
            this.txtTicket_OSANotes.Name = "txtTicket_OSANotes";
            this.txtTicket_OSANotes.ReadOnly = true;
            this.txtTicket_OSANotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicket_OSANotes.Size = new System.Drawing.Size(181, 138);
            this.txtTicket_OSANotes.TabIndex = 1;
            this.txtTicket_OSANotes.TabStop = false;
            // 
            // olvAssemblyAdd
            // 
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_Description);
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_FailureType);
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_Notes);
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_Grid);
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_Discarded);
            this.olvAssemblyAdd.CellEditUseWholeCell = false;
            this.olvAssemblyAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAssyAdd_Description,
            this.olvColAssyAdd_FailureType,
            this.olvColAssyAdd_Notes,
            this.olvColAssyAdd_Grid,
            this.olvColAssyAdd_Discarded});
            this.olvAssemblyAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblyAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssemblyAdd.FullRowSelect = true;
            this.olvAssemblyAdd.GridLines = true;
            this.olvAssemblyAdd.HideSelection = false;
            this.olvAssemblyAdd.Location = new System.Drawing.Point(3, 33);
            this.olvAssemblyAdd.MultiSelect = false;
            this.olvAssemblyAdd.Name = "olvAssemblyAdd";
            this.olvAssemblyAdd.OverlayText.BorderWidth = 6F;
            this.olvAssemblyAdd.OverlayText.Text = "";
            this.olvAssemblyAdd.OverlayText.TextColor = System.Drawing.Color.Empty;
            this.olvAssemblyAdd.ShowGroups = false;
            this.olvAssemblyAdd.Size = new System.Drawing.Size(1170, 417);
            this.olvAssemblyAdd.SmallImageList = this.imageList1;
            this.olvAssemblyAdd.TabIndex = 0;
            this.olvAssemblyAdd.UseCompatibleStateImageBehavior = false;
            this.olvAssemblyAdd.View = System.Windows.Forms.View.Details;
            this.olvAssemblyAdd.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvAssemblyAdd_FormatRow);
            this.olvAssemblyAdd.SelectedIndexChanged += new System.EventHandler(this.olvAssemblyAdd_SelectedIndexChanged);
            // 
            // olvColAssyAdd_Description
            // 
            this.olvColAssyAdd_Description.AspectName = "Description";
            this.olvColAssyAdd_Description.Text = "Assembly";
            this.olvColAssyAdd_Description.Width = 300;
            // 
            // olvColAssyAdd_FailureType
            // 
            this.olvColAssyAdd_FailureType.AspectName = "FailureTypeDescription";
            this.olvColAssyAdd_FailureType.Text = "Failure Type";
            this.olvColAssyAdd_FailureType.Width = 200;
            // 
            // olvColAssyAdd_Notes
            // 
            this.olvColAssyAdd_Notes.AspectName = "Failure_Notes";
            this.olvColAssyAdd_Notes.Text = "Failure Notes";
            this.olvColAssyAdd_Notes.Width = 230;
            // 
            // olvColAssyAdd_Grid
            // 
            this.olvColAssyAdd_Grid.AspectName = "Failure_Grid";
            this.olvColAssyAdd_Grid.Text = "Grid Location";
            this.olvColAssyAdd_Grid.Width = 75;
            // 
            // olvColAssyAdd_Discarded
            // 
            this.olvColAssyAdd_Discarded.AspectName = "Discarded";
            this.olvColAssyAdd_Discarded.IsEditable = false;
            this.olvColAssyAdd_Discarded.Text = "Discarded";
            this.olvColAssyAdd_Discarded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "trash");
            // 
            // pnlAssemblyAdd_Control
            // 
            this.pnlAssemblyAdd_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssemblyAdd_Control.Controls.Add(this.lblAssemblyAdd_SelectedAssemblyID);
            this.pnlAssemblyAdd_Control.Controls.Add(this.lblAssemblyAdd_Qty);
            this.pnlAssemblyAdd_Control.Controls.Add(this.txtAssemblyAdd_Qty);
            this.pnlAssemblyAdd_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssemblyAdd_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlAssemblyAdd_Control.Name = "pnlAssemblyAdd_Control";
            this.pnlAssemblyAdd_Control.Size = new System.Drawing.Size(1170, 30);
            this.pnlAssemblyAdd_Control.TabIndex = 1;
            // 
            // lblAssemblyAdd_SelectedAssemblyID
            // 
            this.lblAssemblyAdd_SelectedAssemblyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssemblyAdd_SelectedAssemblyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAssemblyAdd_SelectedAssemblyID.Location = new System.Drawing.Point(221, 8);
            this.lblAssemblyAdd_SelectedAssemblyID.Name = "lblAssemblyAdd_SelectedAssemblyID";
            this.lblAssemblyAdd_SelectedAssemblyID.Size = new System.Drawing.Size(54, 13);
            this.lblAssemblyAdd_SelectedAssemblyID.TabIndex = 30;
            // 
            // lblAssemblyAdd_Qty
            // 
            this.lblAssemblyAdd_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssemblyAdd_Qty.AutoSize = true;
            this.lblAssemblyAdd_Qty.Location = new System.Drawing.Point(1093, 8);
            this.lblAssemblyAdd_Qty.Name = "lblAssemblyAdd_Qty";
            this.lblAssemblyAdd_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblAssemblyAdd_Qty.TabIndex = 13;
            this.lblAssemblyAdd_Qty.Text = "Qty";
            // 
            // txtAssemblyAdd_Qty
            // 
            this.txtAssemblyAdd_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssemblyAdd_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblyAdd_Qty.Location = new System.Drawing.Point(1122, 3);
            this.txtAssemblyAdd_Qty.Name = "txtAssemblyAdd_Qty";
            this.txtAssemblyAdd_Qty.ReadOnly = true;
            this.txtAssemblyAdd_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtAssemblyAdd_Qty.TabIndex = 14;
            this.txtAssemblyAdd_Qty.TabStop = false;
            // 
            // tabControl_RMA
            // 
            this.tabControl_RMA.Controls.Add(this.tabAssemblyTypes);
            this.tabControl_RMA.Controls.Add(this.tabReceive);
            this.tabControl_RMA.Controls.Add(this.tabRepair);
            this.tabControl_RMA.Controls.Add(this.tabShipments);
            this.tabControl_RMA.Controls.Add(this.tabAccounting);
            this.tabControl_RMA.Controls.Add(this.tabSummary);
            this.tabControl_RMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_RMA.Location = new System.Drawing.Point(0, 0);
            this.tabControl_RMA.Name = "tabControl_RMA";
            this.tabControl_RMA.SelectedIndex = 0;
            this.tabControl_RMA.Size = new System.Drawing.Size(1184, 479);
            this.tabControl_RMA.TabIndex = 3;
            this.tabControl_RMA.SelectedIndexChanged += new System.EventHandler(this.tabControl_RMA_SelectedIndexChanged);
            // 
            // tabAssemblyTypes
            // 
            this.tabAssemblyTypes.Controls.Add(this.olvAssemblyAdd);
            this.tabAssemblyTypes.Controls.Add(this.pnlAssemblyAdd_Control);
            this.tabAssemblyTypes.Location = new System.Drawing.Point(4, 22);
            this.tabAssemblyTypes.Name = "tabAssemblyTypes";
            this.tabAssemblyTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssemblyTypes.Size = new System.Drawing.Size(1176, 453);
            this.tabAssemblyTypes.TabIndex = 0;
            this.tabAssemblyTypes.Text = "Assemblies";
            this.tabAssemblyTypes.UseVisualStyleBackColor = true;
            // 
            // tabReceive
            // 
            this.tabReceive.Controls.Add(this.pnlReceive_Left);
            this.tabReceive.Controls.Add(this.pnlReceive_Right);
            this.tabReceive.Location = new System.Drawing.Point(4, 22);
            this.tabReceive.Name = "tabReceive";
            this.tabReceive.Size = new System.Drawing.Size(1176, 453);
            this.tabReceive.TabIndex = 2;
            this.tabReceive.Text = "Receive";
            this.tabReceive.UseVisualStyleBackColor = true;
            // 
            // pnlReceive_Left
            // 
            this.pnlReceive_Left.Controls.Add(this.olvReceive_Assemblies);
            this.pnlReceive_Left.Controls.Add(this.pnlReceive_Assemblies_Control);
            this.pnlReceive_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReceive_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlReceive_Left.Name = "pnlReceive_Left";
            this.pnlReceive_Left.Size = new System.Drawing.Size(996, 453);
            this.pnlReceive_Left.TabIndex = 30;
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
            this.olvReceive_Assemblies.ContextMenuStrip = this.ctxAssemblyReceive;
            this.olvReceive_Assemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvReceive_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvReceive_Assemblies.FullRowSelect = true;
            this.olvReceive_Assemblies.GridLines = true;
            this.olvReceive_Assemblies.HideSelection = false;
            this.olvReceive_Assemblies.Location = new System.Drawing.Point(0, 30);
            this.olvReceive_Assemblies.MultiSelect = false;
            this.olvReceive_Assemblies.Name = "olvReceive_Assemblies";
            this.olvReceive_Assemblies.ShowGroups = false;
            this.olvReceive_Assemblies.Size = new System.Drawing.Size(996, 423);
            this.olvReceive_Assemblies.SmallImageList = this.imageList1;
            this.olvReceive_Assemblies.TabIndex = 1;
            this.olvReceive_Assemblies.UnfocusedSelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.olvReceive_Assemblies.UseCompatibleStateImageBehavior = false;
            this.olvReceive_Assemblies.View = System.Windows.Forms.View.Details;
            this.olvReceive_Assemblies.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvReceive_Assemblies_FormatRow);
            this.olvReceive_Assemblies.SelectedIndexChanged += new System.EventHandler(this.olvReceive_Assemblies_SelectedIndexChanged);
            this.olvReceive_Assemblies.Click += new System.EventHandler(this.olvReceive_Assemblies_Click);
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
            // ctxAssemblyReceive
            // 
            this.ctxAssemblyReceive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReceive_Undo});
            this.ctxAssemblyReceive.Name = "ctxAssemblyReceive";
            this.ctxAssemblyReceive.Size = new System.Drawing.Size(147, 26);
            // 
            // mnuReceive_Undo
            // 
            this.mnuReceive_Undo.Name = "mnuReceive_Undo";
            this.mnuReceive_Undo.Size = new System.Drawing.Size(146, 22);
            this.mnuReceive_Undo.Text = "Undo Receive";
            this.mnuReceive_Undo.Click += new System.EventHandler(this.mnuReceive_Undo_Click);
            // 
            // pnlReceive_Assemblies_Control
            // 
            this.pnlReceive_Assemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlReceive_Assemblies_Control.Controls.Add(this.lblReceive_SelectedAssemblyID);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.txtReceive_TotalAssyQty);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.txtReceive_ReceivedQty);
            this.pnlReceive_Assemblies_Control.Controls.Add(this.lblReceive_ReceivedQty);
            this.pnlReceive_Assemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceive_Assemblies_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlReceive_Assemblies_Control.Name = "pnlReceive_Assemblies_Control";
            this.pnlReceive_Assemblies_Control.Size = new System.Drawing.Size(996, 30);
            this.pnlReceive_Assemblies_Control.TabIndex = 2;
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
            this.txtReceive_TotalAssyQty.Location = new System.Drawing.Point(948, 6);
            this.txtReceive_TotalAssyQty.Name = "txtReceive_TotalAssyQty";
            this.txtReceive_TotalAssyQty.ReadOnly = true;
            this.txtReceive_TotalAssyQty.Size = new System.Drawing.Size(42, 20);
            this.txtReceive_TotalAssyQty.TabIndex = 28;
            // 
            // txtReceive_ReceivedQty
            // 
            this.txtReceive_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive_ReceivedQty.Location = new System.Drawing.Point(834, 6);
            this.txtReceive_ReceivedQty.Name = "txtReceive_ReceivedQty";
            this.txtReceive_ReceivedQty.ReadOnly = true;
            this.txtReceive_ReceivedQty.Size = new System.Drawing.Size(42, 20);
            this.txtReceive_ReceivedQty.TabIndex = 26;
            // 
            // lblReceive_ReceivedQty
            // 
            this.lblReceive_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceive_ReceivedQty.AutoSize = true;
            this.lblReceive_ReceivedQty.Location = new System.Drawing.Point(882, 9);
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
            this.pnlReceive_Right.Location = new System.Drawing.Point(996, 0);
            this.pnlReceive_Right.Name = "pnlReceive_Right";
            this.pnlReceive_Right.Size = new System.Drawing.Size(180, 453);
            this.pnlReceive_Right.TabIndex = 33;
            // 
            // btnReceive_DiscardSelected
            // 
            this.btnReceive_DiscardSelected.Location = new System.Drawing.Point(7, 342);
            this.btnReceive_DiscardSelected.Name = "btnReceive_DiscardSelected";
            this.btnReceive_DiscardSelected.Size = new System.Drawing.Size(167, 23);
            this.btnReceive_DiscardSelected.TabIndex = 9;
            this.btnReceive_DiscardSelected.Text = "Change to &Discarded";
            this.toolTip.SetToolTip(this.btnReceive_DiscardSelected, "Mark assembly as discarded and will not be received.");
            this.btnReceive_DiscardSelected.UseVisualStyleBackColor = true;
            this.btnReceive_DiscardSelected.Click += new System.EventHandler(this.btnReceive_DiscardSelected_Click);
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
            this.toolTip.SetToolTip(this.btnReceive_CreateBin, "Creates a new empty bin.");
            this.btnReceive_CreateBin.UseVisualStyleBackColor = false;
            this.btnReceive_CreateBin.Click += new System.EventHandler(this.btnReceive_CreateBin_Click);
            // 
            // btnReceive_SelectBin
            // 
            this.btnReceive_SelectBin.Location = new System.Drawing.Point(7, 96);
            this.btnReceive_SelectBin.Name = "btnReceive_SelectBin";
            this.btnReceive_SelectBin.Size = new System.Drawing.Size(167, 30);
            this.btnReceive_SelectBin.TabIndex = 4;
            this.btnReceive_SelectBin.Text = "&Select Existing Bin";
            this.toolTip.SetToolTip(this.btnReceive_SelectBin, "Select an existing bin by entering or scanning its ID.");
            this.btnReceive_SelectBin.UseVisualStyleBackColor = false;
            this.btnReceive_SelectBin.Click += new System.EventHandler(this.btnReceive_SelectBin_Click);
            // 
            // btnReceive_DeleteBin
            // 
            this.btnReceive_DeleteBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReceive_DeleteBin.Location = new System.Drawing.Point(46, 132);
            this.btnReceive_DeleteBin.Name = "btnReceive_DeleteBin";
            this.btnReceive_DeleteBin.Size = new System.Drawing.Size(90, 23);
            this.btnReceive_DeleteBin.TabIndex = 5;
            this.btnReceive_DeleteBin.Text = "&Delete Bin";
            this.toolTip.SetToolTip(this.btnReceive_DeleteBin, "Deletes currently selected bin. Note that it must be empty.");
            this.btnReceive_DeleteBin.UseVisualStyleBackColor = false;
            this.btnReceive_DeleteBin.Click += new System.EventHandler(this.btnReceive_DeleteBin_Click);
            // 
            // btnReceive_PrintBinLabels_Current
            // 
            this.btnReceive_PrintBinLabels_Current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceive_PrintBinLabels_Current.Location = new System.Drawing.Point(7, 422);
            this.btnReceive_PrintBinLabels_Current.Name = "btnReceive_PrintBinLabels_Current";
            this.btnReceive_PrintBinLabels_Current.Size = new System.Drawing.Size(165, 23);
            this.btnReceive_PrintBinLabels_Current.TabIndex = 11;
            this.btnReceive_PrintBinLabels_Current.Text = "Print Selected &Bin Label";
            this.toolTip.SetToolTip(this.btnReceive_PrintBinLabels_Current, "Prints the currently selected bin label.");
            this.btnReceive_PrintBinLabels_Current.UseVisualStyleBackColor = true;
            this.btnReceive_PrintBinLabels_Current.Click += new System.EventHandler(this.btnReceive_PrintBinLabels_Current_Click);
            // 
            // btnReceive_PrintBinLabels_All
            // 
            this.btnReceive_PrintBinLabels_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReceive_PrintBinLabels_All.Location = new System.Drawing.Point(7, 368);
            this.btnReceive_PrintBinLabels_All.Name = "btnReceive_PrintBinLabels_All";
            this.btnReceive_PrintBinLabels_All.Size = new System.Drawing.Size(165, 48);
            this.btnReceive_PrintBinLabels_All.TabIndex = 10;
            this.btnReceive_PrintBinLabels_All.Text = "Print &All Bin Labels";
            this.toolTip.SetToolTip(this.btnReceive_PrintBinLabels_All, "Prints labels for all bins containing assemblies for this RMA.");
            this.btnReceive_PrintBinLabels_All.UseVisualStyleBackColor = true;
            this.btnReceive_PrintBinLabels_All.Click += new System.EventHandler(this.btnReceive_PrintBinLabels_All_Click);
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
            this.lblReceive_AssemblySerialNumber.Location = new System.Drawing.Point(7, 217);
            this.lblReceive_AssemblySerialNumber.Name = "lblReceive_AssemblySerialNumber";
            this.lblReceive_AssemblySerialNumber.Size = new System.Drawing.Size(90, 13);
            this.lblReceive_AssemblySerialNumber.TabIndex = 6;
            this.lblReceive_AssemblySerialNumber.Text = "Assembly Serial #";
            // 
            // btnReceive_ReceiveSelected
            // 
            this.btnReceive_ReceiveSelected.Enabled = false;
            this.btnReceive_ReceiveSelected.Location = new System.Drawing.Point(7, 259);
            this.btnReceive_ReceiveSelected.Name = "btnReceive_ReceiveSelected";
            this.btnReceive_ReceiveSelected.Size = new System.Drawing.Size(167, 48);
            this.btnReceive_ReceiveSelected.TabIndex = 8;
            this.btnReceive_ReceiveSelected.Text = "&Record and Receive";
            this.toolTip.SetToolTip(this.btnReceive_ReceiveSelected, "Record serial number and receive selected assembly to selected bin.");
            this.btnReceive_ReceiveSelected.UseVisualStyleBackColor = true;
            this.btnReceive_ReceiveSelected.Click += new System.EventHandler(this.btnReceive_Receive_Click);
            // 
            // txtReceive_AssemblySerialNumber
            // 
            this.txtReceive_AssemblySerialNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive_AssemblySerialNumber.Location = new System.Drawing.Point(7, 233);
            this.txtReceive_AssemblySerialNumber.MaxLength = 16;
            this.txtReceive_AssemblySerialNumber.Name = "txtReceive_AssemblySerialNumber";
            this.txtReceive_AssemblySerialNumber.ReadOnly = true;
            this.txtReceive_AssemblySerialNumber.Size = new System.Drawing.Size(167, 20);
            this.txtReceive_AssemblySerialNumber.TabIndex = 7;
            this.txtReceive_AssemblySerialNumber.Enter += new System.EventHandler(this.txtReceive_AssemblySerialNumber_Enter);
            // 
            // tabRepair
            // 
            this.tabRepair.Controls.Add(this.pnlRepair_RightSide);
            this.tabRepair.Controls.Add(this.pnlRepair_AssemblySection);
            this.tabRepair.Location = new System.Drawing.Point(4, 22);
            this.tabRepair.Name = "tabRepair";
            this.tabRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepair.Size = new System.Drawing.Size(1176, 453);
            this.tabRepair.TabIndex = 1;
            this.tabRepair.Text = "Repair";
            this.tabRepair.UseVisualStyleBackColor = true;
            // 
            // pnlRepair_RightSide
            // 
            this.pnlRepair_RightSide.Controls.Add(this.pnlRepair_RepairSection);
            this.pnlRepair_RightSide.Controls.Add(this.pnlRepair_FailureSection);
            this.pnlRepair_RightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepair_RightSide.Location = new System.Drawing.Point(303, 3);
            this.pnlRepair_RightSide.Name = "pnlRepair_RightSide";
            this.pnlRepair_RightSide.Size = new System.Drawing.Size(870, 447);
            this.pnlRepair_RightSide.TabIndex = 10;
            // 
            // pnlRepair_RepairSection
            // 
            this.pnlRepair_RepairSection.AutoScroll = true;
            this.pnlRepair_RepairSection.Controls.Add(this.pnlRepair_RepairDetail);
            this.pnlRepair_RepairSection.Controls.Add(this.pnlRepair_RepairTime);
            this.pnlRepair_RepairSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepair_RepairSection.Location = new System.Drawing.Point(0, 74);
            this.pnlRepair_RepairSection.Name = "pnlRepair_RepairSection";
            this.pnlRepair_RepairSection.Size = new System.Drawing.Size(870, 373);
            this.pnlRepair_RepairSection.TabIndex = 2;
            // 
            // pnlRepair_RepairDetail
            // 
            this.pnlRepair_RepairDetail.Controls.Add(this.btnRepair_SerialNumberSearch);
            this.pnlRepair_RepairDetail.Controls.Add(this.lblRepair_SerialNumber);
            this.pnlRepair_RepairDetail.Controls.Add(this.txtRepair_SerialNumber);
            this.pnlRepair_RepairDetail.Controls.Add(this.chkRepair_UnlockAssemblyFromType);
            this.pnlRepair_RepairDetail.Controls.Add(this.btnAssemblyManagement);
            this.pnlRepair_RepairDetail.Controls.Add(this.btnRepair_Save);
            this.pnlRepair_RepairDetail.Controls.Add(this.lblRepair_Assembly);
            this.pnlRepair_RepairDetail.Controls.Add(this.btnRepair_Unfinish);
            this.pnlRepair_RepairDetail.Controls.Add(this.lblRepair_OriginalJobNumber);
            this.pnlRepair_RepairDetail.Controls.Add(this.grpRepair_RepairNotes);
            this.pnlRepair_RepairDetail.Controls.Add(this.txtRepair_OriginalJobNumber);
            this.pnlRepair_RepairDetail.Controls.Add(this.grpRepair_RepairTypes);
            this.pnlRepair_RepairDetail.Controls.Add(this.btnRepair_Finish);
            this.pnlRepair_RepairDetail.Controls.Add(this.txtRepair_LEDBoard_Calibration);
            this.pnlRepair_RepairDetail.Controls.Add(this.lblRepair_LEDBoard_Calibration);
            this.pnlRepair_RepairDetail.Controls.Add(this.cmbRepair_Assembly);
            this.pnlRepair_RepairDetail.Controls.Add(this.grpRepair_Components);
            this.pnlRepair_RepairDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRepair_RepairDetail.Enabled = false;
            this.pnlRepair_RepairDetail.Location = new System.Drawing.Point(0, 84);
            this.pnlRepair_RepairDetail.Name = "pnlRepair_RepairDetail";
            this.pnlRepair_RepairDetail.Size = new System.Drawing.Size(870, 289);
            this.pnlRepair_RepairDetail.TabIndex = 0;
            // 
            // btnRepair_SerialNumberSearch
            // 
            this.btnRepair_SerialNumberSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepair_SerialNumberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair_SerialNumberSearch.Location = new System.Drawing.Point(180, 56);
            this.btnRepair_SerialNumberSearch.Name = "btnRepair_SerialNumberSearch";
            this.btnRepair_SerialNumberSearch.Size = new System.Drawing.Size(88, 23);
            this.btnRepair_SerialNumberSearch.TabIndex = 16;
            this.btnRepair_SerialNumberSearch.Text = "SN History";
            this.toolTip.SetToolTip(this.btnRepair_SerialNumberSearch, "Lookup this assembly serial number in history.");
            this.btnRepair_SerialNumberSearch.UseVisualStyleBackColor = true;
            this.btnRepair_SerialNumberSearch.Click += new System.EventHandler(this.btnRepair_SerialNumberSearch_Click);
            // 
            // lblRepair_SerialNumber
            // 
            this.lblRepair_SerialNumber.AutoSize = true;
            this.lblRepair_SerialNumber.Location = new System.Drawing.Point(3, 43);
            this.lblRepair_SerialNumber.Name = "lblRepair_SerialNumber";
            this.lblRepair_SerialNumber.Size = new System.Drawing.Size(43, 13);
            this.lblRepair_SerialNumber.TabIndex = 3;
            this.lblRepair_SerialNumber.Text = "Serial #";
            // 
            // txtRepair_SerialNumber
            // 
            this.txtRepair_SerialNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_SerialNumber.Location = new System.Drawing.Point(7, 59);
            this.txtRepair_SerialNumber.MaxLength = 10;
            this.txtRepair_SerialNumber.Name = "txtRepair_SerialNumber";
            this.txtRepair_SerialNumber.ReadOnly = true;
            this.txtRepair_SerialNumber.Size = new System.Drawing.Size(167, 20);
            this.txtRepair_SerialNumber.TabIndex = 4;
            this.txtRepair_SerialNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // chkRepair_UnlockAssemblyFromType
            // 
            this.chkRepair_UnlockAssemblyFromType.AutoSize = true;
            this.chkRepair_UnlockAssemblyFromType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepair_UnlockAssemblyFromType.ForeColor = System.Drawing.Color.Olive;
            this.chkRepair_UnlockAssemblyFromType.Location = new System.Drawing.Point(278, 2);
            this.chkRepair_UnlockAssemblyFromType.Name = "chkRepair_UnlockAssemblyFromType";
            this.chkRepair_UnlockAssemblyFromType.Size = new System.Drawing.Size(145, 17);
            this.chkRepair_UnlockAssemblyFromType.TabIndex = 15;
            this.chkRepair_UnlockAssemblyFromType.Text = "Select any assembly type";
            this.chkRepair_UnlockAssemblyFromType.UseVisualStyleBackColor = true;
            this.chkRepair_UnlockAssemblyFromType.CheckedChanged += new System.EventHandler(this.chkRepair_UnlockAssemblyFromType_CheckedChanged);
            // 
            // btnAssemblyManagement
            // 
            this.btnAssemblyManagement.Location = new System.Drawing.Point(429, 18);
            this.btnAssemblyManagement.Name = "btnAssemblyManagement";
            this.btnAssemblyManagement.Size = new System.Drawing.Size(26, 23);
            this.btnAssemblyManagement.TabIndex = 2;
            this.btnAssemblyManagement.Text = "+";
            this.toolTip.SetToolTip(this.btnAssemblyManagement, "Open Assembly Management");
            this.btnAssemblyManagement.UseVisualStyleBackColor = true;
            this.btnAssemblyManagement.Visible = false;
            this.btnAssemblyManagement.Click += new System.EventHandler(this.btnAssemblyManagement_Click);
            // 
            // btnRepair_Save
            // 
            this.btnRepair_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepair_Save.Enabled = false;
            this.btnRepair_Save.Location = new System.Drawing.Point(735, 209);
            this.btnRepair_Save.Name = "btnRepair_Save";
            this.btnRepair_Save.Size = new System.Drawing.Size(130, 23);
            this.btnRepair_Save.TabIndex = 13;
            this.btnRepair_Save.Text = "Save Changes";
            this.toolTip.SetToolTip(this.btnRepair_Save, "Saves current information but does not mark assembly repair as finished.");
            this.btnRepair_Save.UseVisualStyleBackColor = true;
            this.btnRepair_Save.Click += new System.EventHandler(this.btnRepair_Save_Click);
            // 
            // lblRepair_Assembly
            // 
            this.lblRepair_Assembly.AutoSize = true;
            this.lblRepair_Assembly.Location = new System.Drawing.Point(0, 3);
            this.lblRepair_Assembly.Name = "lblRepair_Assembly";
            this.lblRepair_Assembly.Size = new System.Drawing.Size(51, 13);
            this.lblRepair_Assembly.TabIndex = 0;
            this.lblRepair_Assembly.Text = "Assembly";
            // 
            // btnRepair_Unfinish
            // 
            this.btnRepair_Unfinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepair_Unfinish.Location = new System.Drawing.Point(735, 160);
            this.btnRepair_Unfinish.Name = "btnRepair_Unfinish";
            this.btnRepair_Unfinish.Size = new System.Drawing.Size(130, 23);
            this.btnRepair_Unfinish.TabIndex = 14;
            this.btnRepair_Unfinish.Text = "Unfinish Repair";
            this.toolTip.SetToolTip(this.btnRepair_Unfinish, "\"Unfinishes\" repair on assembly to allow editing.");
            this.btnRepair_Unfinish.UseVisualStyleBackColor = true;
            this.btnRepair_Unfinish.Visible = false;
            this.btnRepair_Unfinish.Click += new System.EventHandler(this.btnRepair_Unfinish_Click);
            // 
            // lblRepair_OriginalJobNumber
            // 
            this.lblRepair_OriginalJobNumber.AutoSize = true;
            this.lblRepair_OriginalJobNumber.Location = new System.Drawing.Point(333, 43);
            this.lblRepair_OriginalJobNumber.Name = "lblRepair_OriginalJobNumber";
            this.lblRepair_OriginalJobNumber.Size = new System.Drawing.Size(72, 13);
            this.lblRepair_OriginalJobNumber.TabIndex = 5;
            this.lblRepair_OriginalJobNumber.Text = "Original Job #";
            // 
            // grpRepair_RepairNotes
            // 
            this.grpRepair_RepairNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRepair_RepairNotes.Controls.Add(this.txtRepair_Notes);
            this.grpRepair_RepairNotes.Location = new System.Drawing.Point(3, 281);
            this.grpRepair_RepairNotes.Name = "grpRepair_RepairNotes";
            this.grpRepair_RepairNotes.Size = new System.Drawing.Size(726, 3);
            this.grpRepair_RepairNotes.TabIndex = 11;
            this.grpRepair_RepairNotes.TabStop = false;
            this.grpRepair_RepairNotes.Text = "Repair Notes";
            // 
            // txtRepair_Notes
            // 
            this.txtRepair_Notes.AcceptsReturn = true;
            this.txtRepair_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRepair_Notes.Location = new System.Drawing.Point(3, 16);
            this.txtRepair_Notes.MaxLength = 65536;
            this.txtRepair_Notes.Multiline = true;
            this.txtRepair_Notes.Name = "txtRepair_Notes";
            this.txtRepair_Notes.ReadOnly = true;
            this.txtRepair_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRepair_Notes.Size = new System.Drawing.Size(720, 0);
            this.txtRepair_Notes.TabIndex = 0;
            // 
            // txtRepair_OriginalJobNumber
            // 
            this.txtRepair_OriginalJobNumber.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_OriginalJobNumber.Location = new System.Drawing.Point(336, 59);
            this.txtRepair_OriginalJobNumber.MaxLength = 16;
            this.txtRepair_OriginalJobNumber.Name = "txtRepair_OriginalJobNumber";
            this.txtRepair_OriginalJobNumber.ReadOnly = true;
            this.txtRepair_OriginalJobNumber.Size = new System.Drawing.Size(167, 20);
            this.txtRepair_OriginalJobNumber.TabIndex = 6;
            this.txtRepair_OriginalJobNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // grpRepair_RepairTypes
            // 
            this.grpRepair_RepairTypes.Controls.Add(this.olvRepair_RepairTypes);
            this.grpRepair_RepairTypes.Controls.Add(this.pnlRepair_RepairType_Control);
            this.grpRepair_RepairTypes.Location = new System.Drawing.Point(3, 85);
            this.grpRepair_RepairTypes.Name = "grpRepair_RepairTypes";
            this.grpRepair_RepairTypes.Size = new System.Drawing.Size(327, 190);
            this.grpRepair_RepairTypes.TabIndex = 9;
            this.grpRepair_RepairTypes.TabStop = false;
            this.grpRepair_RepairTypes.Text = "Repair(s) Made";
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
            this.olvRepair_RepairTypes.Location = new System.Drawing.Point(3, 46);
            this.olvRepair_RepairTypes.MultiSelect = false;
            this.olvRepair_RepairTypes.Name = "olvRepair_RepairTypes";
            this.olvRepair_RepairTypes.SelectAllOnControlA = false;
            this.olvRepair_RepairTypes.ShowGroups = false;
            this.olvRepair_RepairTypes.ShowHeaderInAllViews = false;
            this.olvRepair_RepairTypes.Size = new System.Drawing.Size(321, 141);
            this.olvRepair_RepairTypes.TabIndex = 1;
            this.olvRepair_RepairTypes.UseCompatibleStateImageBehavior = false;
            this.olvRepair_RepairTypes.View = System.Windows.Forms.View.Details;
            // 
            // olvColRepair_RepairType
            // 
            this.olvColRepair_RepairType.AspectName = "Description";
            this.olvColRepair_RepairType.FillsFreeSpace = true;
            this.olvColRepair_RepairType.Text = "Repair Type";
            this.olvColRepair_RepairType.Width = 300;
            // 
            // pnlRepair_RepairType_Control
            // 
            this.pnlRepair_RepairType_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRepair_RepairType_Control.Controls.Add(this.btnRepair_RepairType_Remove);
            this.pnlRepair_RepairType_Control.Controls.Add(this.btnRepair_RepairType_Add);
            this.pnlRepair_RepairType_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_RepairType_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlRepair_RepairType_Control.Name = "pnlRepair_RepairType_Control";
            this.pnlRepair_RepairType_Control.Size = new System.Drawing.Size(321, 30);
            this.pnlRepair_RepairType_Control.TabIndex = 0;
            // 
            // btnRepair_RepairType_Remove
            // 
            this.btnRepair_RepairType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRepair_RepairType_Remove.Enabled = false;
            this.btnRepair_RepairType_Remove.Location = new System.Drawing.Point(104, 3);
            this.btnRepair_RepairType_Remove.Name = "btnRepair_RepairType_Remove";
            this.btnRepair_RepairType_Remove.Size = new System.Drawing.Size(55, 23);
            this.btnRepair_RepairType_Remove.TabIndex = 1;
            this.btnRepair_RepairType_Remove.Text = "Remove";
            this.btnRepair_RepairType_Remove.UseVisualStyleBackColor = false;
            this.btnRepair_RepairType_Remove.Click += new System.EventHandler(this.btnRepair_RepairType_Remove_Click);
            // 
            // btnRepair_RepairType_Add
            // 
            this.btnRepair_RepairType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepair_RepairType_Add.Enabled = false;
            this.btnRepair_RepairType_Add.Location = new System.Drawing.Point(3, 3);
            this.btnRepair_RepairType_Add.Name = "btnRepair_RepairType_Add";
            this.btnRepair_RepairType_Add.Size = new System.Drawing.Size(95, 23);
            this.btnRepair_RepairType_Add.TabIndex = 0;
            this.btnRepair_RepairType_Add.Text = "Add Repair";
            this.btnRepair_RepairType_Add.UseVisualStyleBackColor = false;
            this.btnRepair_RepairType_Add.Click += new System.EventHandler(this.btnRepair_RepairType_Add_Click);
            // 
            // btnRepair_Finish
            // 
            this.btnRepair_Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepair_Finish.Enabled = false;
            this.btnRepair_Finish.Location = new System.Drawing.Point(735, 238);
            this.btnRepair_Finish.Name = "btnRepair_Finish";
            this.btnRepair_Finish.Size = new System.Drawing.Size(130, 46);
            this.btnRepair_Finish.TabIndex = 12;
            this.btnRepair_Finish.Text = "Save/Finish Repair";
            this.toolTip.SetToolTip(this.btnRepair_Finish, "Saves current information and marks assembly repair as finished.");
            this.btnRepair_Finish.UseVisualStyleBackColor = true;
            this.btnRepair_Finish.Click += new System.EventHandler(this.btnRepair_Finish_Click);
            // 
            // txtRepair_LEDBoard_Calibration
            // 
            this.txtRepair_LEDBoard_Calibration.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_LEDBoard_Calibration.Location = new System.Drawing.Point(509, 59);
            this.txtRepair_LEDBoard_Calibration.MaxLength = 24;
            this.txtRepair_LEDBoard_Calibration.Name = "txtRepair_LEDBoard_Calibration";
            this.txtRepair_LEDBoard_Calibration.ReadOnly = true;
            this.txtRepair_LEDBoard_Calibration.Size = new System.Drawing.Size(167, 20);
            this.txtRepair_LEDBoard_Calibration.TabIndex = 8;
            this.txtRepair_LEDBoard_Calibration.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblRepair_LEDBoard_Calibration
            // 
            this.lblRepair_LEDBoard_Calibration.AutoSize = true;
            this.lblRepair_LEDBoard_Calibration.Location = new System.Drawing.Point(506, 43);
            this.lblRepair_LEDBoard_Calibration.Name = "lblRepair_LEDBoard_Calibration";
            this.lblRepair_LEDBoard_Calibration.Size = new System.Drawing.Size(121, 13);
            this.lblRepair_LEDBoard_Calibration.TabIndex = 7;
            this.lblRepair_LEDBoard_Calibration.Text = "LED Board Calibration #";
            // 
            // cmbRepair_Assembly
            // 
            this.cmbRepair_Assembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepair_Assembly.Enabled = false;
            this.cmbRepair_Assembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepair_Assembly.FormattingEnabled = true;
            this.cmbRepair_Assembly.Location = new System.Drawing.Point(3, 19);
            this.cmbRepair_Assembly.Name = "cmbRepair_Assembly";
            this.cmbRepair_Assembly.Size = new System.Drawing.Size(420, 21);
            this.cmbRepair_Assembly.TabIndex = 1;
            // 
            // grpRepair_Components
            // 
            this.grpRepair_Components.Controls.Add(this.olvRepair_Components);
            this.grpRepair_Components.Controls.Add(this.pnlRepair_Component_Control);
            this.grpRepair_Components.Location = new System.Drawing.Point(336, 85);
            this.grpRepair_Components.Name = "grpRepair_Components";
            this.grpRepair_Components.Size = new System.Drawing.Size(529, 190);
            this.grpRepair_Components.TabIndex = 10;
            this.grpRepair_Components.TabStop = false;
            this.grpRepair_Components.Text = "Components Used";
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
            this.olvRepair_Components.Location = new System.Drawing.Point(3, 46);
            this.olvRepair_Components.MultiSelect = false;
            this.olvRepair_Components.Name = "olvRepair_Components";
            this.olvRepair_Components.ShowGroups = false;
            this.olvRepair_Components.Size = new System.Drawing.Size(523, 141);
            this.olvRepair_Components.TabIndex = 1;
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
            this.pnlRepair_Component_Control.Controls.Add(this.btnRepair_Component_Remove);
            this.pnlRepair_Component_Control.Controls.Add(this.lblRepair_Components_Qty);
            this.pnlRepair_Component_Control.Controls.Add(this.txtRepair_Components_Qty);
            this.pnlRepair_Component_Control.Controls.Add(this.btnRepair_Component_Add);
            this.pnlRepair_Component_Control.Controls.Add(this.txtRepair_MU);
            this.pnlRepair_Component_Control.Controls.Add(this.lblRepair_MU);
            this.pnlRepair_Component_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_Component_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlRepair_Component_Control.Name = "pnlRepair_Component_Control";
            this.pnlRepair_Component_Control.Size = new System.Drawing.Size(523, 30);
            this.pnlRepair_Component_Control.TabIndex = 0;
            // 
            // btnRepair_Component_Remove
            // 
            this.btnRepair_Component_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRepair_Component_Remove.Enabled = false;
            this.btnRepair_Component_Remove.Location = new System.Drawing.Point(104, 3);
            this.btnRepair_Component_Remove.Name = "btnRepair_Component_Remove";
            this.btnRepair_Component_Remove.Size = new System.Drawing.Size(56, 23);
            this.btnRepair_Component_Remove.TabIndex = 1;
            this.btnRepair_Component_Remove.Text = "Remove";
            this.btnRepair_Component_Remove.UseVisualStyleBackColor = false;
            this.btnRepair_Component_Remove.Click += new System.EventHandler(this.btnRepair_Component_Remove_Click);
            // 
            // lblRepair_Components_Qty
            // 
            this.lblRepair_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepair_Components_Qty.AutoSize = true;
            this.lblRepair_Components_Qty.Location = new System.Drawing.Point(446, 8);
            this.lblRepair_Components_Qty.Name = "lblRepair_Components_Qty";
            this.lblRepair_Components_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblRepair_Components_Qty.TabIndex = 4;
            this.lblRepair_Components_Qty.Text = "Qty";
            // 
            // txtRepair_Components_Qty
            // 
            this.txtRepair_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_Components_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair_Components_Qty.Location = new System.Drawing.Point(475, 3);
            this.txtRepair_Components_Qty.MaxLength = 8;
            this.txtRepair_Components_Qty.Name = "txtRepair_Components_Qty";
            this.txtRepair_Components_Qty.ReadOnly = true;
            this.txtRepair_Components_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtRepair_Components_Qty.TabIndex = 5;
            this.txtRepair_Components_Qty.TabStop = false;
            // 
            // btnRepair_Component_Add
            // 
            this.btnRepair_Component_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepair_Component_Add.Enabled = false;
            this.btnRepair_Component_Add.Location = new System.Drawing.Point(3, 3);
            this.btnRepair_Component_Add.Name = "btnRepair_Component_Add";
            this.btnRepair_Component_Add.Size = new System.Drawing.Size(95, 23);
            this.btnRepair_Component_Add.TabIndex = 0;
            this.btnRepair_Component_Add.Text = "Add Component";
            this.btnRepair_Component_Add.UseVisualStyleBackColor = false;
            this.btnRepair_Component_Add.Click += new System.EventHandler(this.btnRepair_Component_Add_Click);
            // 
            // txtRepair_MU
            // 
            this.txtRepair_MU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_MU.Location = new System.Drawing.Point(339, 5);
            this.txtRepair_MU.MaxLength = 16;
            this.txtRepair_MU.Name = "txtRepair_MU";
            this.txtRepair_MU.ReadOnly = true;
            this.txtRepair_MU.Size = new System.Drawing.Size(101, 20);
            this.txtRepair_MU.TabIndex = 3;
            this.txtRepair_MU.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblRepair_MU
            // 
            this.lblRepair_MU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepair_MU.AutoSize = true;
            this.lblRepair_MU.Location = new System.Drawing.Point(299, 8);
            this.lblRepair_MU.Name = "lblRepair_MU";
            this.lblRepair_MU.Size = new System.Drawing.Size(34, 13);
            this.lblRepair_MU.TabIndex = 2;
            this.lblRepair_MU.Text = "MU #";
            // 
            // pnlRepair_RepairTime
            // 
            this.pnlRepair_RepairTime.Controls.Add(this.cmbRepairAction);
            this.pnlRepair_RepairTime.Controls.Add(this.btnRepair_StartStop);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_FinalizedBy);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_DateStarted);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_FinalizedBy);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_DateStarted);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_DateFinalized);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_DateCompleted);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_DateFinalized);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_DateCompleted);
            this.pnlRepair_RepairTime.Controls.Add(this.olvRepair_RepairLog);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_RepairTime);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_TechTime);
            this.pnlRepair_RepairTime.Controls.Add(this.lblRepair_RepairTime);
            this.pnlRepair_RepairTime.Controls.Add(this.txtRepair_TechTime);
            this.pnlRepair_RepairTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_RepairTime.Location = new System.Drawing.Point(0, 0);
            this.pnlRepair_RepairTime.Name = "pnlRepair_RepairTime";
            this.pnlRepair_RepairTime.Size = new System.Drawing.Size(870, 84);
            this.pnlRepair_RepairTime.TabIndex = 26;
            // 
            // cmbRepairAction
            // 
            this.cmbRepairAction.DisplayMember = "DisplayMember";
            this.cmbRepairAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepairAction.Enabled = false;
            this.cmbRepairAction.FormattingEnabled = true;
            this.cmbRepairAction.Location = new System.Drawing.Point(7, 56);
            this.cmbRepairAction.Name = "cmbRepairAction";
            this.cmbRepairAction.Size = new System.Drawing.Size(126, 21);
            this.cmbRepairAction.TabIndex = 26;
            // 
            // btnRepair_StartStop
            // 
            this.btnRepair_StartStop.Enabled = false;
            this.btnRepair_StartStop.Location = new System.Drawing.Point(6, 3);
            this.btnRepair_StartStop.Name = "btnRepair_StartStop";
            this.btnRepair_StartStop.Size = new System.Drawing.Size(127, 50);
            this.btnRepair_StartStop.TabIndex = 9;
            this.btnRepair_StartStop.Text = "Start/Stop Repair Session";
            this.btnRepair_StartStop.UseVisualStyleBackColor = true;
            this.btnRepair_StartStop.Click += new System.EventHandler(this.btnRepair_StartStop_Click);
            // 
            // lblRepair_FinalizedBy
            // 
            this.lblRepair_FinalizedBy.AutoSize = true;
            this.lblRepair_FinalizedBy.Location = new System.Drawing.Point(756, 40);
            this.lblRepair_FinalizedBy.Name = "lblRepair_FinalizedBy";
            this.lblRepair_FinalizedBy.Size = new System.Drawing.Size(62, 13);
            this.lblRepair_FinalizedBy.TabIndex = 24;
            this.lblRepair_FinalizedBy.Text = "Finalized by";
            // 
            // txtRepair_DateStarted
            // 
            this.txtRepair_DateStarted.Location = new System.Drawing.Point(547, 19);
            this.txtRepair_DateStarted.Name = "txtRepair_DateStarted";
            this.txtRepair_DateStarted.ReadOnly = true;
            this.txtRepair_DateStarted.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_DateStarted.TabIndex = 13;
            this.txtRepair_DateStarted.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_DateStarted, "Date when assembly repair first started.");
            // 
            // txtRepair_FinalizedBy
            // 
            this.txtRepair_FinalizedBy.Location = new System.Drawing.Point(759, 56);
            this.txtRepair_FinalizedBy.Name = "txtRepair_FinalizedBy";
            this.txtRepair_FinalizedBy.ReadOnly = true;
            this.txtRepair_FinalizedBy.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_FinalizedBy.TabIndex = 25;
            this.txtRepair_FinalizedBy.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_FinalizedBy, "Date when assembly repair was finished.");
            // 
            // lblRepair_DateStarted
            // 
            this.lblRepair_DateStarted.AutoSize = true;
            this.lblRepair_DateStarted.Location = new System.Drawing.Point(544, 3);
            this.lblRepair_DateStarted.Name = "lblRepair_DateStarted";
            this.lblRepair_DateStarted.Size = new System.Drawing.Size(41, 13);
            this.lblRepair_DateStarted.TabIndex = 12;
            this.lblRepair_DateStarted.Text = "Started";
            // 
            // lblRepair_DateFinalized
            // 
            this.lblRepair_DateFinalized.AutoSize = true;
            this.lblRepair_DateFinalized.Location = new System.Drawing.Point(756, 3);
            this.lblRepair_DateFinalized.Name = "lblRepair_DateFinalized";
            this.lblRepair_DateFinalized.Size = new System.Drawing.Size(48, 13);
            this.lblRepair_DateFinalized.TabIndex = 22;
            this.lblRepair_DateFinalized.Text = "Finalized";
            // 
            // txtRepair_DateCompleted
            // 
            this.txtRepair_DateCompleted.Location = new System.Drawing.Point(653, 19);
            this.txtRepair_DateCompleted.Name = "txtRepair_DateCompleted";
            this.txtRepair_DateCompleted.ReadOnly = true;
            this.txtRepair_DateCompleted.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_DateCompleted.TabIndex = 15;
            this.txtRepair_DateCompleted.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_DateCompleted, "Date when assembly repair was finished.");
            // 
            // txtRepair_DateFinalized
            // 
            this.txtRepair_DateFinalized.Location = new System.Drawing.Point(759, 19);
            this.txtRepair_DateFinalized.Name = "txtRepair_DateFinalized";
            this.txtRepair_DateFinalized.ReadOnly = true;
            this.txtRepair_DateFinalized.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_DateFinalized.TabIndex = 23;
            this.txtRepair_DateFinalized.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_DateFinalized, "Date when assembly repair was finished.");
            // 
            // lblRepair_DateCompleted
            // 
            this.lblRepair_DateCompleted.AutoSize = true;
            this.lblRepair_DateCompleted.Location = new System.Drawing.Point(650, 3);
            this.lblRepair_DateCompleted.Name = "lblRepair_DateCompleted";
            this.lblRepair_DateCompleted.Size = new System.Drawing.Size(46, 13);
            this.lblRepair_DateCompleted.TabIndex = 14;
            this.lblRepair_DateCompleted.Text = "Finished";
            // 
            // olvRepair_RepairLog
            // 
            this.olvRepair_RepairLog.AllColumns.Add(this.olvColRepairLog_RepairStart);
            this.olvRepair_RepairLog.AllColumns.Add(this.olvColRepairLog_TimeTaken);
            this.olvRepair_RepairLog.AllColumns.Add(this.olvColRepairLog_UserName);
            this.olvRepair_RepairLog.AllColumns.Add(this.olvColAction);
            this.olvRepair_RepairLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvRepair_RepairLog.CellEditUseWholeCell = false;
            this.olvRepair_RepairLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepairLog_RepairStart,
            this.olvColRepairLog_TimeTaken,
            this.olvColRepairLog_UserName,
            this.olvColAction});
            this.olvRepair_RepairLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRepair_RepairLog.EmptyListMsg = "";
            this.olvRepair_RepairLog.EmptyListMsgFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvRepair_RepairLog.FullRowSelect = true;
            this.olvRepair_RepairLog.GridLines = true;
            this.olvRepair_RepairLog.HasCollapsibleGroups = false;
            this.olvRepair_RepairLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvRepair_RepairLog.Location = new System.Drawing.Point(139, 5);
            this.olvRepair_RepairLog.MultiSelect = false;
            this.olvRepair_RepairLog.Name = "olvRepair_RepairLog";
            this.olvRepair_RepairLog.SelectAllOnControlA = false;
            this.olvRepair_RepairLog.SelectColumnsMenuStaysOpen = false;
            this.olvRepair_RepairLog.SelectColumnsOnRightClick = false;
            this.olvRepair_RepairLog.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvRepair_RepairLog.ShowFilterMenuOnRightClick = false;
            this.olvRepair_RepairLog.ShowGroups = false;
            this.olvRepair_RepairLog.ShowHeaderInAllViews = false;
            this.olvRepair_RepairLog.ShowSortIndicators = false;
            this.olvRepair_RepairLog.Size = new System.Drawing.Size(399, 73);
            this.olvRepair_RepairLog.TabIndex = 21;
            this.olvRepair_RepairLog.TabStop = false;
            this.olvRepair_RepairLog.UseCompatibleStateImageBehavior = false;
            this.olvRepair_RepairLog.UseOverlays = false;
            this.olvRepair_RepairLog.View = System.Windows.Forms.View.Details;
            // 
            // olvColRepairLog_RepairStart
            // 
            this.olvColRepairLog_RepairStart.AspectName = "RepairStart";
            this.olvColRepairLog_RepairStart.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.olvColRepairLog_RepairStart.Text = "Repair Started";
            this.olvColRepairLog_RepairStart.Width = 110;
            // 
            // olvColRepairLog_TimeTaken
            // 
            this.olvColRepairLog_TimeTaken.AspectName = "TimeTaken";
            this.olvColRepairLog_TimeTaken.Text = "Time Taken";
            this.olvColRepairLog_TimeTaken.Width = 80;
            // 
            // olvColRepairLog_UserName
            // 
            this.olvColRepairLog_UserName.AspectName = "UserName";
            this.olvColRepairLog_UserName.Text = "User";
            // 
            // olvColAction
            // 
            this.olvColAction.AspectName = "Action";
            this.olvColAction.FillsFreeSpace = true;
            this.olvColAction.Text = "Action";
            // 
            // txtRepair_RepairTime
            // 
            this.txtRepair_RepairTime.Location = new System.Drawing.Point(653, 56);
            this.txtRepair_RepairTime.Name = "txtRepair_RepairTime";
            this.txtRepair_RepairTime.ReadOnly = true;
            this.txtRepair_RepairTime.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_RepairTime.TabIndex = 17;
            this.txtRepair_RepairTime.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_RepairTime, "The amount of time assembly was in for repair.");
            // 
            // lblRepair_TechTime
            // 
            this.lblRepair_TechTime.AutoSize = true;
            this.lblRepair_TechTime.Location = new System.Drawing.Point(544, 40);
            this.lblRepair_TechTime.Name = "lblRepair_TechTime";
            this.lblRepair_TechTime.Size = new System.Drawing.Size(58, 13);
            this.lblRepair_TechTime.TabIndex = 19;
            this.lblRepair_TechTime.Text = "Tech Time";
            // 
            // lblRepair_RepairTime
            // 
            this.lblRepair_RepairTime.AutoSize = true;
            this.lblRepair_RepairTime.Location = new System.Drawing.Point(650, 40);
            this.lblRepair_RepairTime.Name = "lblRepair_RepairTime";
            this.lblRepair_RepairTime.Size = new System.Drawing.Size(64, 13);
            this.lblRepair_RepairTime.TabIndex = 16;
            this.lblRepair_RepairTime.Text = "Repair Time";
            // 
            // txtRepair_TechTime
            // 
            this.txtRepair_TechTime.Location = new System.Drawing.Point(547, 56);
            this.txtRepair_TechTime.Name = "txtRepair_TechTime";
            this.txtRepair_TechTime.ReadOnly = true;
            this.txtRepair_TechTime.Size = new System.Drawing.Size(100, 20);
            this.txtRepair_TechTime.TabIndex = 20;
            this.txtRepair_TechTime.TabStop = false;
            this.toolTip.SetToolTip(this.txtRepair_TechTime, "The amount of time spent by techs repairing the assembly.");
            // 
            // pnlRepair_FailureSection
            // 
            this.pnlRepair_FailureSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlRepair_FailureSection.Controls.Add(this.lblRepair_Discarded);
            this.pnlRepair_FailureSection.Controls.Add(this.label1);
            this.pnlRepair_FailureSection.Controls.Add(this.lblRepair_FailureType);
            this.pnlRepair_FailureSection.Controls.Add(this.txtRepair_FailureType);
            this.pnlRepair_FailureSection.Controls.Add(this.txtRepair_FailureNotes);
            this.pnlRepair_FailureSection.Controls.Add(this.txtRepair_GridLocation);
            this.pnlRepair_FailureSection.Controls.Add(this.lblRepair_GridLocation);
            this.pnlRepair_FailureSection.Controls.Add(this.txtRepair_ReceiveDate);
            this.pnlRepair_FailureSection.Controls.Add(this.lblRepair_ReceiveDate);
            this.pnlRepair_FailureSection.Controls.Add(this.lblRepair_InventoryLocation);
            this.pnlRepair_FailureSection.Controls.Add(this.txtRepair_InventoryLocation);
            this.pnlRepair_FailureSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_FailureSection.Location = new System.Drawing.Point(0, 0);
            this.pnlRepair_FailureSection.Name = "pnlRepair_FailureSection";
            this.pnlRepair_FailureSection.Size = new System.Drawing.Size(870, 74);
            this.pnlRepair_FailureSection.TabIndex = 1;
            // 
            // lblRepair_Discarded
            // 
            this.lblRepair_Discarded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepair_Discarded.AutoSize = true;
            this.lblRepair_Discarded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRepair_Discarded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepair_Discarded.ForeColor = System.Drawing.Color.Red;
            this.lblRepair_Discarded.Location = new System.Drawing.Point(575, 30);
            this.lblRepair_Discarded.Name = "lblRepair_Discarded";
            this.lblRepair_Discarded.Size = new System.Drawing.Size(96, 16);
            this.lblRepair_Discarded.TabIndex = 11;
            this.lblRepair_Discarded.Text = "DISCARDED";
            this.lblRepair_Discarded.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Failure Notes";
            // 
            // lblRepair_FailureType
            // 
            this.lblRepair_FailureType.AutoSize = true;
            this.lblRepair_FailureType.Location = new System.Drawing.Point(3, 6);
            this.lblRepair_FailureType.Name = "lblRepair_FailureType";
            this.lblRepair_FailureType.Size = new System.Drawing.Size(65, 13);
            this.lblRepair_FailureType.TabIndex = 0;
            this.lblRepair_FailureType.Text = "Failure Type";
            // 
            // txtRepair_FailureType
            // 
            this.txtRepair_FailureType.ContextMenuStrip = this.ctxRepairFailureTypeChange;
            this.txtRepair_FailureType.Location = new System.Drawing.Point(78, 3);
            this.txtRepair_FailureType.Name = "txtRepair_FailureType";
            this.txtRepair_FailureType.ReadOnly = true;
            this.txtRepair_FailureType.Size = new System.Drawing.Size(297, 20);
            this.txtRepair_FailureType.TabIndex = 1;
            this.txtRepair_FailureType.TabStop = false;
            // 
            // ctxRepairFailureTypeChange
            // 
            this.ctxRepairFailureTypeChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepairFailureTypeChange});
            this.ctxRepairFailureTypeChange.Name = "ctxRepairFailureTypeChange";
            this.ctxRepairFailureTypeChange.Size = new System.Drawing.Size(191, 26);
            // 
            // mnuRepairFailureTypeChange
            // 
            this.mnuRepairFailureTypeChange.Name = "mnuRepairFailureTypeChange";
            this.mnuRepairFailureTypeChange.Size = new System.Drawing.Size(190, 22);
            this.mnuRepairFailureTypeChange.Text = "Change Failure Type...";
            this.mnuRepairFailureTypeChange.Click += new System.EventHandler(this.mnuRepairFailureTypeChange_Click);
            // 
            // txtRepair_FailureNotes
            // 
            this.txtRepair_FailureNotes.Location = new System.Drawing.Point(78, 29);
            this.txtRepair_FailureNotes.Multiline = true;
            this.txtRepair_FailureNotes.Name = "txtRepair_FailureNotes";
            this.txtRepair_FailureNotes.ReadOnly = true;
            this.txtRepair_FailureNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRepair_FailureNotes.Size = new System.Drawing.Size(383, 39);
            this.txtRepair_FailureNotes.TabIndex = 2;
            this.txtRepair_FailureNotes.TabStop = false;
            // 
            // txtRepair_GridLocation
            // 
            this.txtRepair_GridLocation.Location = new System.Drawing.Point(413, 3);
            this.txtRepair_GridLocation.Name = "txtRepair_GridLocation";
            this.txtRepair_GridLocation.ReadOnly = true;
            this.txtRepair_GridLocation.Size = new System.Drawing.Size(48, 20);
            this.txtRepair_GridLocation.TabIndex = 4;
            this.txtRepair_GridLocation.TabStop = false;
            this.txtRepair_GridLocation.Text = "WW-55";
            this.toolTip.SetToolTip(this.txtRepair_GridLocation, "Location of assembly on sign.");
            // 
            // lblRepair_GridLocation
            // 
            this.lblRepair_GridLocation.AutoSize = true;
            this.lblRepair_GridLocation.Location = new System.Drawing.Point(381, 6);
            this.lblRepair_GridLocation.Name = "lblRepair_GridLocation";
            this.lblRepair_GridLocation.Size = new System.Drawing.Size(26, 13);
            this.lblRepair_GridLocation.TabIndex = 3;
            this.lblRepair_GridLocation.Text = "Grid";
            // 
            // txtRepair_ReceiveDate
            // 
            this.txtRepair_ReceiveDate.Location = new System.Drawing.Point(542, 3);
            this.txtRepair_ReceiveDate.MaxLength = 256;
            this.txtRepair_ReceiveDate.Name = "txtRepair_ReceiveDate";
            this.txtRepair_ReceiveDate.ReadOnly = true;
            this.txtRepair_ReceiveDate.Size = new System.Drawing.Size(129, 20);
            this.txtRepair_ReceiveDate.TabIndex = 6;
            this.txtRepair_ReceiveDate.TabStop = false;
            this.txtRepair_ReceiveDate.Text = "2011-12-12 by JaredY";
            this.toolTip.SetToolTip(this.txtRepair_ReceiveDate, "When this assembly was received and by whom.");
            // 
            // lblRepair_ReceiveDate
            // 
            this.lblRepair_ReceiveDate.AutoSize = true;
            this.lblRepair_ReceiveDate.Location = new System.Drawing.Point(483, 6);
            this.lblRepair_ReceiveDate.Name = "lblRepair_ReceiveDate";
            this.lblRepair_ReceiveDate.Size = new System.Drawing.Size(53, 13);
            this.lblRepair_ReceiveDate.TabIndex = 5;
            this.lblRepair_ReceiveDate.Text = "Received";
            // 
            // lblRepair_InventoryLocation
            // 
            this.lblRepair_InventoryLocation.AutoSize = true;
            this.lblRepair_InventoryLocation.Location = new System.Drawing.Point(467, 32);
            this.lblRepair_InventoryLocation.Name = "lblRepair_InventoryLocation";
            this.lblRepair_InventoryLocation.Size = new System.Drawing.Size(95, 13);
            this.lblRepair_InventoryLocation.TabIndex = 7;
            this.lblRepair_InventoryLocation.Text = "Inventory Location";
            // 
            // txtRepair_InventoryLocation
            // 
            this.txtRepair_InventoryLocation.Location = new System.Drawing.Point(467, 48);
            this.txtRepair_InventoryLocation.Name = "txtRepair_InventoryLocation";
            this.txtRepair_InventoryLocation.ReadOnly = true;
            this.txtRepair_InventoryLocation.Size = new System.Drawing.Size(204, 20);
            this.txtRepair_InventoryLocation.TabIndex = 8;
            this.txtRepair_InventoryLocation.TabStop = false;
            this.txtRepair_InventoryLocation.Text = "B12345, R1A5, INVENTORY";
            this.toolTip.SetToolTip(this.txtRepair_InventoryLocation, "Box, Zone and Area where assembly is stored.");
            // 
            // pnlRepair_AssemblySection
            // 
            this.pnlRepair_AssemblySection.Controls.Add(this.olvRepair_Assemblies);
            this.pnlRepair_AssemblySection.Controls.Add(this.pnlRepair_Assemblies_Control);
            this.pnlRepair_AssemblySection.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRepair_AssemblySection.Location = new System.Drawing.Point(3, 3);
            this.pnlRepair_AssemblySection.Name = "pnlRepair_AssemblySection";
            this.pnlRepair_AssemblySection.Size = new System.Drawing.Size(300, 447);
            this.pnlRepair_AssemblySection.TabIndex = 3;
            // 
            // olvRepair_Assemblies
            // 
            this.olvRepair_Assemblies.AllColumns.Add(this.olvColRepair_Assy);
            this.olvRepair_Assemblies.AllColumns.Add(this.olvColRepair_SerialNumber);
            this.olvRepair_Assemblies.CellEditUseWholeCell = false;
            this.olvRepair_Assemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRepair_Assy,
            this.olvColRepair_SerialNumber});
            this.olvRepair_Assemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRepair_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRepair_Assemblies.FullRowSelect = true;
            this.olvRepair_Assemblies.GridLines = true;
            this.olvRepair_Assemblies.HideSelection = false;
            this.olvRepair_Assemblies.Location = new System.Drawing.Point(0, 30);
            this.olvRepair_Assemblies.MultiSelect = false;
            this.olvRepair_Assemblies.Name = "olvRepair_Assemblies";
            this.olvRepair_Assemblies.ShowGroups = false;
            this.olvRepair_Assemblies.Size = new System.Drawing.Size(300, 417);
            this.olvRepair_Assemblies.TabIndex = 0;
            this.olvRepair_Assemblies.UseCompatibleStateImageBehavior = false;
            this.olvRepair_Assemblies.View = System.Windows.Forms.View.Details;
            this.olvRepair_Assemblies.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvRepair_Assemblies_FormatRow);
            this.olvRepair_Assemblies.SelectedIndexChanged += new System.EventHandler(this.olvRepair_Assemblies_SelectedIndexChanged);
            // 
            // olvColRepair_Assy
            // 
            this.olvColRepair_Assy.AspectName = "Description";
            this.olvColRepair_Assy.Text = "Assembly";
            this.olvColRepair_Assy.Width = 200;
            // 
            // olvColRepair_SerialNumber
            // 
            this.olvColRepair_SerialNumber.AspectName = "SerialNumber";
            this.olvColRepair_SerialNumber.Text = "S/N";
            this.olvColRepair_SerialNumber.Width = 75;
            // 
            // pnlRepair_Assemblies_Control
            // 
            this.pnlRepair_Assemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRepair_Assemblies_Control.Controls.Add(this.lblRepair_SelectedAssemblyID);
            this.pnlRepair_Assemblies_Control.Controls.Add(this.txtRepair_Assemblies_ReceivedOf);
            this.pnlRepair_Assemblies_Control.Controls.Add(this.txtRepair_Assemblies_TotalQty);
            this.pnlRepair_Assemblies_Control.Controls.Add(this.txtRepair_Assemblies_ReceivedQty);
            this.pnlRepair_Assemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepair_Assemblies_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlRepair_Assemblies_Control.Name = "pnlRepair_Assemblies_Control";
            this.pnlRepair_Assemblies_Control.Size = new System.Drawing.Size(300, 30);
            this.pnlRepair_Assemblies_Control.TabIndex = 1;
            // 
            // lblRepair_SelectedAssemblyID
            // 
            this.lblRepair_SelectedAssemblyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRepair_SelectedAssemblyID.Location = new System.Drawing.Point(3, 7);
            this.lblRepair_SelectedAssemblyID.Name = "lblRepair_SelectedAssemblyID";
            this.lblRepair_SelectedAssemblyID.Size = new System.Drawing.Size(54, 13);
            this.lblRepair_SelectedAssemblyID.TabIndex = 4;
            // 
            // txtRepair_Assemblies_ReceivedOf
            // 
            this.txtRepair_Assemblies_ReceivedOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_Assemblies_ReceivedOf.AutoSize = true;
            this.txtRepair_Assemblies_ReceivedOf.Location = new System.Drawing.Point(200, 7);
            this.txtRepair_Assemblies_ReceivedOf.Name = "txtRepair_Assemblies_ReceivedOf";
            this.txtRepair_Assemblies_ReceivedOf.Size = new System.Drawing.Size(60, 13);
            this.txtRepair_Assemblies_ReceivedOf.TabIndex = 2;
            this.txtRepair_Assemblies_ReceivedOf.Text = "received of";
            // 
            // txtRepair_Assemblies_TotalQty
            // 
            this.txtRepair_Assemblies_TotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_Assemblies_TotalQty.Location = new System.Drawing.Point(260, 4);
            this.txtRepair_Assemblies_TotalQty.Name = "txtRepair_Assemblies_TotalQty";
            this.txtRepair_Assemblies_TotalQty.ReadOnly = true;
            this.txtRepair_Assemblies_TotalQty.Size = new System.Drawing.Size(37, 20);
            this.txtRepair_Assemblies_TotalQty.TabIndex = 1;
            this.txtRepair_Assemblies_TotalQty.TabStop = false;
            this.txtRepair_Assemblies_TotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRepair_Assemblies_ReceivedQty
            // 
            this.txtRepair_Assemblies_ReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepair_Assemblies_ReceivedQty.Location = new System.Drawing.Point(163, 4);
            this.txtRepair_Assemblies_ReceivedQty.Name = "txtRepair_Assemblies_ReceivedQty";
            this.txtRepair_Assemblies_ReceivedQty.ReadOnly = true;
            this.txtRepair_Assemblies_ReceivedQty.Size = new System.Drawing.Size(37, 20);
            this.txtRepair_Assemblies_ReceivedQty.TabIndex = 0;
            this.txtRepair_Assemblies_ReceivedQty.TabStop = false;
            this.txtRepair_Assemblies_ReceivedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabShipments
            // 
            this.tabShipments.Controls.Add(this.ucShipmentList1);
            this.tabShipments.Location = new System.Drawing.Point(4, 22);
            this.tabShipments.Name = "tabShipments";
            this.tabShipments.Size = new System.Drawing.Size(1176, 453);
            this.tabShipments.TabIndex = 5;
            this.tabShipments.Text = "Shipments";
            this.tabShipments.UseVisualStyleBackColor = true;
            // 
            // ucShipmentList1
            // 
            this.ucShipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShipmentList1.Location = new System.Drawing.Point(0, 0);
            this.ucShipmentList1.Name = "ucShipmentList1";
            this.ucShipmentList1.ShowCreateButton = true;
            this.ucShipmentList1.Size = new System.Drawing.Size(1176, 453);
            this.ucShipmentList1.TabIndex = 0;
            this.ucShipmentList1.CreateShipment += new SDB.UserControls.Shipment.ucShipmentList.CreateEvent(this.ucShipmentList1_CreateShipment);
            this.ucShipmentList1.ViewShipment += new SDB.UserControls.Shipment.ucShipmentList.ShipmentEvent(this.ucShipmentList1_ViewShipment);
            this.ucShipmentList1.ViewTracking += new SDB.UserControls.Shipment.ucShipmentList.TrackingEvent(this.ucShipmentList1_ViewTracking);
            // 
            // tabAccounting
            // 
            this.tabAccounting.Controls.Add(this.grpAccounting_Components);
            this.tabAccounting.Location = new System.Drawing.Point(4, 22);
            this.tabAccounting.Name = "tabAccounting";
            this.tabAccounting.Size = new System.Drawing.Size(1176, 453);
            this.tabAccounting.TabIndex = 3;
            this.tabAccounting.Text = "Accounting";
            this.tabAccounting.UseVisualStyleBackColor = true;
            // 
            // grpAccounting_Components
            // 
            this.grpAccounting_Components.Controls.Add(this.olvAccounting_Components);
            this.grpAccounting_Components.Controls.Add(this.pnlAccounting_Components_Control);
            this.grpAccounting_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAccounting_Components.Location = new System.Drawing.Point(0, 0);
            this.grpAccounting_Components.Name = "grpAccounting_Components";
            this.grpAccounting_Components.Size = new System.Drawing.Size(1176, 453);
            this.grpAccounting_Components.TabIndex = 3;
            this.grpAccounting_Components.TabStop = false;
            this.grpAccounting_Components.Text = "All Components Used";
            // 
            // olvAccounting_Components
            // 
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_PartNumber);
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_Description);
            this.olvAccounting_Components.AllColumns.Add(this.olvColAccounting_Components_SilkLabel);
            this.olvAccounting_Components.CellEditUseWholeCell = false;
            this.olvAccounting_Components.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAccounting_Components_PartNumber,
            this.olvColAccounting_Components_Description,
            this.olvColAccounting_Components_SilkLabel});
            this.olvAccounting_Components.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAccounting_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAccounting_Components.FullRowSelect = true;
            this.olvAccounting_Components.GridLines = true;
            this.olvAccounting_Components.HideSelection = false;
            this.olvAccounting_Components.Location = new System.Drawing.Point(3, 46);
            this.olvAccounting_Components.MultiSelect = false;
            this.olvAccounting_Components.Name = "olvAccounting_Components";
            this.olvAccounting_Components.ShowGroups = false;
            this.olvAccounting_Components.Size = new System.Drawing.Size(1170, 404);
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
            // olvColAccounting_Components_Description
            // 
            this.olvColAccounting_Components_Description.AspectName = "Component.Description";
            this.olvColAccounting_Components_Description.Text = "Description";
            this.olvColAccounting_Components_Description.Width = 200;
            // 
            // olvColAccounting_Components_SilkLabel
            // 
            this.olvColAccounting_Components_SilkLabel.AspectName = "SilkscreenID";
            this.olvColAccounting_Components_SilkLabel.Text = "Component ID";
            this.olvColAccounting_Components_SilkLabel.Width = 100;
            // 
            // pnlAccounting_Components_Control
            // 
            this.pnlAccounting_Components_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAccounting_Components_Control.Controls.Add(this.chkAccounting_Charged);
            this.pnlAccounting_Components_Control.Controls.Add(this.lblAccounting_TotalCost);
            this.pnlAccounting_Components_Control.Controls.Add(this.txtAccounting_TotalCost);
            this.pnlAccounting_Components_Control.Controls.Add(this.lblAccounting_Components_Qty);
            this.pnlAccounting_Components_Control.Controls.Add(this.txtAccounting_Components_Qty);
            this.pnlAccounting_Components_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccounting_Components_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlAccounting_Components_Control.Name = "pnlAccounting_Components_Control";
            this.pnlAccounting_Components_Control.Size = new System.Drawing.Size(1170, 30);
            this.pnlAccounting_Components_Control.TabIndex = 1;
            // 
            // chkAccounting_Charged
            // 
            this.chkAccounting_Charged.AutoSize = true;
            this.chkAccounting_Charged.Location = new System.Drawing.Point(3, 9);
            this.chkAccounting_Charged.Name = "chkAccounting_Charged";
            this.chkAccounting_Charged.Size = new System.Drawing.Size(169, 17);
            this.chkAccounting_Charged.TabIndex = 5;
            this.chkAccounting_Charged.Text = "Charged to Warranty/Contract";
            this.toolTip.SetToolTip(this.chkAccounting_Charged, "Check this option when all components have been charged to the Job/PO.");
            this.chkAccounting_Charged.UseVisualStyleBackColor = true;
            this.chkAccounting_Charged.Visible = false;
            this.chkAccounting_Charged.CheckedChanged += new System.EventHandler(this.chkAccounting_Charged_CheckedChanged);
            // 
            // lblAccounting_TotalCost
            // 
            this.lblAccounting_TotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccounting_TotalCost.AutoSize = true;
            this.lblAccounting_TotalCost.Location = new System.Drawing.Point(919, 10);
            this.lblAccounting_TotalCost.Name = "lblAccounting_TotalCost";
            this.lblAccounting_TotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblAccounting_TotalCost.TabIndex = 13;
            this.lblAccounting_TotalCost.Text = "Total Cost";
            // 
            // txtAccounting_TotalCost
            // 
            this.txtAccounting_TotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccounting_TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounting_TotalCost.Location = new System.Drawing.Point(980, 5);
            this.txtAccounting_TotalCost.Name = "txtAccounting_TotalCost";
            this.txtAccounting_TotalCost.ReadOnly = true;
            this.txtAccounting_TotalCost.Size = new System.Drawing.Size(101, 22);
            this.txtAccounting_TotalCost.TabIndex = 14;
            this.txtAccounting_TotalCost.TabStop = false;
            this.txtAccounting_TotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip.SetToolTip(this.txtAccounting_TotalCost, "Total cost of all components.");
            // 
            // lblAccounting_Components_Qty
            // 
            this.lblAccounting_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccounting_Components_Qty.AutoSize = true;
            this.lblAccounting_Components_Qty.Location = new System.Drawing.Point(1087, 10);
            this.lblAccounting_Components_Qty.Name = "lblAccounting_Components_Qty";
            this.lblAccounting_Components_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblAccounting_Components_Qty.TabIndex = 11;
            this.lblAccounting_Components_Qty.Text = "Qty";
            // 
            // txtAccounting_Components_Qty
            // 
            this.txtAccounting_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccounting_Components_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccounting_Components_Qty.Location = new System.Drawing.Point(1116, 5);
            this.txtAccounting_Components_Qty.Name = "txtAccounting_Components_Qty";
            this.txtAccounting_Components_Qty.ReadOnly = true;
            this.txtAccounting_Components_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtAccounting_Components_Qty.TabIndex = 12;
            this.txtAccounting_Components_Qty.TabStop = false;
            this.txtAccounting_Components_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.spltSummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(1176, 453);
            this.tabSummary.TabIndex = 4;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // spltSummary
            // 
            this.spltSummary.BackColor = System.Drawing.Color.Transparent;
            this.spltSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltSummary.Location = new System.Drawing.Point(3, 3);
            this.spltSummary.Name = "spltSummary";
            this.spltSummary.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltSummary.Panel1
            // 
            this.spltSummary.Panel1.Controls.Add(this.grpSummary_Assemblies);
            this.spltSummary.Panel1.Controls.Add(this.grpSummary_AssemblyRepairNotes);
            this.spltSummary.Panel1MinSize = 186;
            // 
            // spltSummary.Panel2
            // 
            this.spltSummary.Panel2.Controls.Add(this.grpSummary_Components);
            this.spltSummary.Panel2MinSize = 0;
            this.spltSummary.Size = new System.Drawing.Size(1170, 447);
            this.spltSummary.SplitterDistance = 280;
            this.spltSummary.TabIndex = 5;
            this.spltSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.spltSummary_Paint);
            // 
            // grpSummary_Assemblies
            // 
            this.grpSummary_Assemblies.Controls.Add(this.olvSummary_Assemblies);
            this.grpSummary_Assemblies.Controls.Add(this.pnlSummary_Assemblies_Control);
            this.grpSummary_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary_Assemblies.Location = new System.Drawing.Point(0, 0);
            this.grpSummary_Assemblies.Name = "grpSummary_Assemblies";
            this.grpSummary_Assemblies.Size = new System.Drawing.Size(1170, 215);
            this.grpSummary_Assemblies.TabIndex = 3;
            this.grpSummary_Assemblies.TabStop = false;
            this.grpSummary_Assemblies.Text = "Assembly Ledger";
            // 
            // olvSummary_Assemblies
            // 
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assembly);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_SerialNumber);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Discarded);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_FailureType);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_Grid);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_RepairBy);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_RepairTypes);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_TotalTime);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_RootCause);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_FinalizedBy);
            this.olvSummary_Assemblies.AllColumns.Add(this.olvColSummary_Assemblies_FinalizedDate);
            this.olvSummary_Assemblies.CellEditUseWholeCell = false;
            this.olvSummary_Assemblies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSummary_Assembly,
            this.olvColSummary_SerialNumber,
            this.olvColSummary_Discarded,
            this.olvColSummary_Assemblies_FailureType,
            this.olvColSummary_Assemblies_RepairBy,
            this.olvColSummary_Assemblies_RepairTypes,
            this.olvColSummary_Assemblies_TotalTime,
            this.olvColSummary_Assemblies_RootCause,
            this.olvColSummary_Assemblies_FinalizedBy,
            this.olvColSummary_Assemblies_FinalizedDate});
            this.olvSummary_Assemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSummary_Assemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvSummary_Assemblies.FullRowSelect = true;
            this.olvSummary_Assemblies.GridLines = true;
            this.olvSummary_Assemblies.HideSelection = false;
            this.olvSummary_Assemblies.Location = new System.Drawing.Point(3, 46);
            this.olvSummary_Assemblies.Name = "olvSummary_Assemblies";
            this.olvSummary_Assemblies.ShowGroups = false;
            this.olvSummary_Assemblies.Size = new System.Drawing.Size(1164, 166);
            this.olvSummary_Assemblies.SmallImageList = this.imageList1;
            this.olvSummary_Assemblies.TabIndex = 0;
            this.olvSummary_Assemblies.UseCompatibleStateImageBehavior = false;
            this.olvSummary_Assemblies.View = System.Windows.Forms.View.Details;
            this.olvSummary_Assemblies.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvSummary_Assemblies_FormatRow);
            this.olvSummary_Assemblies.SelectedIndexChanged += new System.EventHandler(this.olvSummary_Assemblies_SelectedIndexChanged);
            this.olvSummary_Assemblies.DoubleClick += new System.EventHandler(this.olvSummary_Assemblies_DoubleClick);
            // 
            // olvColSummary_Assembly
            // 
            this.olvColSummary_Assembly.AspectName = "Description";
            this.olvColSummary_Assembly.Text = "Assembly";
            this.olvColSummary_Assembly.Width = 200;
            // 
            // olvColSummary_SerialNumber
            // 
            this.olvColSummary_SerialNumber.AspectName = "SerialNumber";
            this.olvColSummary_SerialNumber.Text = "Serial Number";
            this.olvColSummary_SerialNumber.Width = 90;
            // 
            // olvColSummary_Discarded
            // 
            this.olvColSummary_Discarded.AspectName = "Discarded";
            this.olvColSummary_Discarded.IsEditable = false;
            this.olvColSummary_Discarded.Text = "Discarded";
            this.olvColSummary_Discarded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvColSummary_Assemblies_FailureType
            // 
            this.olvColSummary_Assemblies_FailureType.AspectName = "FailureTypeDescription";
            this.olvColSummary_Assemblies_FailureType.Text = "Failure Type";
            this.olvColSummary_Assemblies_FailureType.Width = 160;
            // 
            // olvColSummary_Assemblies_Grid
            // 
            this.olvColSummary_Assemblies_Grid.AspectName = "Failure_Grid";
            this.olvColSummary_Assemblies_Grid.DisplayIndex = 4;
            this.olvColSummary_Assemblies_Grid.IsVisible = false;
            this.olvColSummary_Assemblies_Grid.Text = "Grid";
            this.olvColSummary_Assemblies_Grid.Width = 35;
            // 
            // olvColSummary_Assemblies_RepairBy
            // 
            this.olvColSummary_Assemblies_RepairBy.AspectName = "Repair_UserName";
            this.olvColSummary_Assemblies_RepairBy.Text = "Rep. By";
            this.olvColSummary_Assemblies_RepairBy.ToolTipText = "First user to repair this assembly";
            this.olvColSummary_Assemblies_RepairBy.Width = 65;
            // 
            // olvColSummary_Assemblies_RepairTypes
            // 
            this.olvColSummary_Assemblies_RepairTypes.AspectName = "RepairTypes_AllDescriptions";
            this.olvColSummary_Assemblies_RepairTypes.Text = "Repairs";
            this.olvColSummary_Assemblies_RepairTypes.Width = 200;
            // 
            // olvColSummary_Assemblies_TotalTime
            // 
            this.olvColSummary_Assemblies_TotalTime.AspectName = "Repair_TotalTime";
            this.olvColSummary_Assemblies_TotalTime.Text = "Total Time";
            this.olvColSummary_Assemblies_TotalTime.Width = 90;
            // 
            // olvColSummary_Assemblies_RootCause
            // 
            this.olvColSummary_Assemblies_RootCause.AspectName = "Finalize_RootCauseDescription";
            this.olvColSummary_Assemblies_RootCause.Text = "Root Cause";
            this.olvColSummary_Assemblies_RootCause.Width = 140;
            // 
            // olvColSummary_Assemblies_FinalizedBy
            // 
            this.olvColSummary_Assemblies_FinalizedBy.AspectName = "Finalize_UserName";
            this.olvColSummary_Assemblies_FinalizedBy.Text = "Finalized By";
            this.olvColSummary_Assemblies_FinalizedBy.Width = 70;
            // 
            // olvColSummary_Assemblies_FinalizedDate
            // 
            this.olvColSummary_Assemblies_FinalizedDate.AspectName = "Finalize_Date";
            this.olvColSummary_Assemblies_FinalizedDate.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColSummary_Assemblies_FinalizedDate.Text = "Finalized";
            this.olvColSummary_Assemblies_FinalizedDate.Width = 70;
            // 
            // pnlSummary_Assemblies_Control
            // 
            this.pnlSummary_Assemblies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSummary_Assemblies_Control.Controls.Add(this.btnSummary_Assembly_Finalize);
            this.pnlSummary_Assemblies_Control.Controls.Add(this.lblSummary_Assemblies_Qty);
            this.pnlSummary_Assemblies_Control.Controls.Add(this.txtSummary_Assemblies_Qty);
            this.pnlSummary_Assemblies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary_Assemblies_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlSummary_Assemblies_Control.Name = "pnlSummary_Assemblies_Control";
            this.pnlSummary_Assemblies_Control.Size = new System.Drawing.Size(1164, 30);
            this.pnlSummary_Assemblies_Control.TabIndex = 1;
            // 
            // btnSummary_Assembly_Finalize
            // 
            this.btnSummary_Assembly_Finalize.Enabled = false;
            this.btnSummary_Assembly_Finalize.Location = new System.Drawing.Point(3, 3);
            this.btnSummary_Assembly_Finalize.Name = "btnSummary_Assembly_Finalize";
            this.btnSummary_Assembly_Finalize.Size = new System.Drawing.Size(91, 23);
            this.btnSummary_Assembly_Finalize.TabIndex = 2;
            this.btnSummary_Assembly_Finalize.Text = "Finalize";
            this.toolTip.SetToolTip(this.btnSummary_Assembly_Finalize, "Assign a root cause to the selected assemblies.");
            this.btnSummary_Assembly_Finalize.UseVisualStyleBackColor = true;
            this.btnSummary_Assembly_Finalize.Click += new System.EventHandler(this.btnSummary_Assembly_Finalize_Click);
            // 
            // lblSummary_Assemblies_Qty
            // 
            this.lblSummary_Assemblies_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary_Assemblies_Qty.AutoSize = true;
            this.lblSummary_Assemblies_Qty.Location = new System.Drawing.Point(1087, 8);
            this.lblSummary_Assemblies_Qty.Name = "lblSummary_Assemblies_Qty";
            this.lblSummary_Assemblies_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblSummary_Assemblies_Qty.TabIndex = 13;
            this.lblSummary_Assemblies_Qty.Text = "Qty";
            // 
            // txtSummary_Assemblies_Qty
            // 
            this.txtSummary_Assemblies_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummary_Assemblies_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary_Assemblies_Qty.Location = new System.Drawing.Point(1116, 3);
            this.txtSummary_Assemblies_Qty.Name = "txtSummary_Assemblies_Qty";
            this.txtSummary_Assemblies_Qty.ReadOnly = true;
            this.txtSummary_Assemblies_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtSummary_Assemblies_Qty.TabIndex = 14;
            this.txtSummary_Assemblies_Qty.TabStop = false;
            this.txtSummary_Assemblies_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpSummary_AssemblyRepairNotes
            // 
            this.grpSummary_AssemblyRepairNotes.Controls.Add(this.txtSummary_AssemblyRepairNotes);
            this.grpSummary_AssemblyRepairNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpSummary_AssemblyRepairNotes.Location = new System.Drawing.Point(0, 215);
            this.grpSummary_AssemblyRepairNotes.Name = "grpSummary_AssemblyRepairNotes";
            this.grpSummary_AssemblyRepairNotes.Size = new System.Drawing.Size(1170, 65);
            this.grpSummary_AssemblyRepairNotes.TabIndex = 4;
            this.grpSummary_AssemblyRepairNotes.TabStop = false;
            this.grpSummary_AssemblyRepairNotes.Text = "Repair Notes";
            // 
            // txtSummary_AssemblyRepairNotes
            // 
            this.txtSummary_AssemblyRepairNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSummary_AssemblyRepairNotes.Location = new System.Drawing.Point(3, 16);
            this.txtSummary_AssemblyRepairNotes.Multiline = true;
            this.txtSummary_AssemblyRepairNotes.Name = "txtSummary_AssemblyRepairNotes";
            this.txtSummary_AssemblyRepairNotes.ReadOnly = true;
            this.txtSummary_AssemblyRepairNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary_AssemblyRepairNotes.Size = new System.Drawing.Size(1164, 46);
            this.txtSummary_AssemblyRepairNotes.TabIndex = 0;
            this.txtSummary_AssemblyRepairNotes.TabStop = false;
            // 
            // grpSummary_Components
            // 
            this.grpSummary_Components.Controls.Add(this.olvSummary_Components);
            this.grpSummary_Components.Controls.Add(this.pnlSummary_Components_Control);
            this.grpSummary_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary_Components.Location = new System.Drawing.Point(0, 0);
            this.grpSummary_Components.Name = "grpSummary_Components";
            this.grpSummary_Components.Size = new System.Drawing.Size(1170, 163);
            this.grpSummary_Components.TabIndex = 4;
            this.grpSummary_Components.TabStop = false;
            this.grpSummary_Components.Text = "Components Used";
            // 
            // olvSummary_Components
            // 
            this.olvSummary_Components.AllColumns.Add(this.olvColSummary_Components_PartNumber);
            this.olvSummary_Components.AllColumns.Add(this.olvColSummary_Components_Component);
            this.olvSummary_Components.AllColumns.Add(this.olvColSummary_Components_SilkLabel);
            this.olvSummary_Components.CellEditUseWholeCell = false;
            this.olvSummary_Components.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSummary_Components_PartNumber,
            this.olvColSummary_Components_Component,
            this.olvColSummary_Components_SilkLabel});
            this.olvSummary_Components.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSummary_Components.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvSummary_Components.FullRowSelect = true;
            this.olvSummary_Components.GridLines = true;
            this.olvSummary_Components.HideSelection = false;
            this.olvSummary_Components.Location = new System.Drawing.Point(3, 46);
            this.olvSummary_Components.MultiSelect = false;
            this.olvSummary_Components.Name = "olvSummary_Components";
            this.olvSummary_Components.ShowGroups = false;
            this.olvSummary_Components.Size = new System.Drawing.Size(1164, 114);
            this.olvSummary_Components.TabIndex = 0;
            this.olvSummary_Components.UseCompatibleStateImageBehavior = false;
            this.olvSummary_Components.View = System.Windows.Forms.View.Details;
            // 
            // olvColSummary_Components_PartNumber
            // 
            this.olvColSummary_Components_PartNumber.AspectName = "Component.ComponentNumber";
            this.olvColSummary_Components_PartNumber.Text = "Part #";
            this.olvColSummary_Components_PartNumber.Width = 100;
            // 
            // olvColSummary_Components_Component
            // 
            this.olvColSummary_Components_Component.AspectName = "Component.Description";
            this.olvColSummary_Components_Component.Text = "Component";
            this.olvColSummary_Components_Component.Width = 200;
            // 
            // olvColSummary_Components_SilkLabel
            // 
            this.olvColSummary_Components_SilkLabel.AspectName = "SilkscreenID";
            this.olvColSummary_Components_SilkLabel.Text = "Component ID";
            this.olvColSummary_Components_SilkLabel.Width = 100;
            // 
            // pnlSummary_Components_Control
            // 
            this.pnlSummary_Components_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSummary_Components_Control.Controls.Add(this.lblSummary_Components_Qty);
            this.pnlSummary_Components_Control.Controls.Add(this.txtSummary_Components_Qty);
            this.pnlSummary_Components_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary_Components_Control.Location = new System.Drawing.Point(3, 16);
            this.pnlSummary_Components_Control.Name = "pnlSummary_Components_Control";
            this.pnlSummary_Components_Control.Size = new System.Drawing.Size(1164, 30);
            this.pnlSummary_Components_Control.TabIndex = 1;
            // 
            // lblSummary_Components_Qty
            // 
            this.lblSummary_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary_Components_Qty.AutoSize = true;
            this.lblSummary_Components_Qty.Location = new System.Drawing.Point(1087, 10);
            this.lblSummary_Components_Qty.Name = "lblSummary_Components_Qty";
            this.lblSummary_Components_Qty.Size = new System.Drawing.Size(23, 13);
            this.lblSummary_Components_Qty.TabIndex = 15;
            this.lblSummary_Components_Qty.Text = "Qty";
            // 
            // txtSummary_Components_Qty
            // 
            this.txtSummary_Components_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSummary_Components_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary_Components_Qty.Location = new System.Drawing.Point(1116, 5);
            this.txtSummary_Components_Qty.Name = "txtSummary_Components_Qty";
            this.txtSummary_Components_Qty.ReadOnly = true;
            this.txtSummary_Components_Qty.Size = new System.Drawing.Size(45, 22);
            this.txtSummary_Components_Qty.TabIndex = 16;
            this.txtSummary_Components_Qty.TabStop = false;
            this.txtSummary_Components_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRepair_InventoryMove
            // 
            this.btnRepair_InventoryMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepair_InventoryMove.Location = new System.Drawing.Point(420, 4);
            this.btnRepair_InventoryMove.Name = "btnRepair_InventoryMove";
            this.btnRepair_InventoryMove.Size = new System.Drawing.Size(124, 23);
            this.btnRepair_InventoryMove.TabIndex = 17;
            this.btnRepair_InventoryMove.Text = "Inventory Move";
            this.toolTip.SetToolTip(this.btnRepair_InventoryMove, "Access the RMA Inventory Move form.");
            this.btnRepair_InventoryMove.UseVisualStyleBackColor = true;
            this.btnRepair_InventoryMove.Click += new System.EventHandler(this.btnRepair_InventoryMove_Click);
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
            this.dgvJournal.Size = new System.Drawing.Size(489, 167);
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
            this.pnlJournal_Control.Size = new System.Drawing.Size(489, 30);
            this.pnlJournal_Control.TabIndex = 32;
            // 
            // btnJournal_Add
            // 
            this.btnJournal_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnJournal_Add.Location = new System.Drawing.Point(3, 3);
            this.btnJournal_Add.Name = "btnJournal_Add";
            this.btnJournal_Add.Size = new System.Drawing.Size(100, 23);
            this.btnJournal_Add.TabIndex = 0;
            this.btnJournal_Add.Text = "Add Entry";
            this.toolTip.SetToolTip(this.btnJournal_Add, "Add Ticket Journal Entry");
            this.btnJournal_Add.UseVisualStyleBackColor = false;
            this.btnJournal_Add.Click += new System.EventHandler(this.btnJournal_Add_Click);
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoCheck = false;
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Location = new System.Drawing.Point(241, 8);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 71;
            this.chkSubscribe.Text = "Subscribe";
            this.toolTip.SetToolTip(this.chkSubscribe, "Indicates whether you are subscribed to this item.");
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.Click += new System.EventHandler(this.chkSubscribe_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(160, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Silver;
            this.pnlControl.Controls.Add(this.btnRepair_InventoryMove);
            this.pnlControl.Controls.Add(this.pnlKey);
            this.pnlControl.Controls.Add(this.chkSubscribe);
            this.pnlControl.Controls.Add(this.btnExport);
            this.pnlControl.Controls.Add(this.txtSearch);
            this.pnlControl.Controls.Add(this.btnModify);
            this.pnlControl.Controls.Add(this.btnSearch);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1184, 30);
            this.pnlControl.TabIndex = 20;
            // 
            // pnlKey
            // 
            this.pnlKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKey.Controls.Add(this.lblKey_Finalized_Desc);
            this.pnlKey.Controls.Add(this.lblKey_Finalized);
            this.pnlKey.Controls.Add(this.lblKey_Completed_Desc);
            this.pnlKey.Controls.Add(this.lblKey_Completed);
            this.pnlKey.Controls.Add(this.lblKey_InProgress_Desc);
            this.pnlKey.Controls.Add(this.lblKey_InProgress);
            this.pnlKey.Controls.Add(this.lblKey_Received_Desc);
            this.pnlKey.Controls.Add(this.lblKey_Received);
            this.pnlKey.Controls.Add(this.lblKey_NotReceived_Desc);
            this.pnlKey.Controls.Add(this.lblKey_NotReceived);
            this.pnlKey.Location = new System.Drawing.Point(550, 3);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(377, 26);
            this.pnlKey.TabIndex = 72;
            // 
            // lblKey_Finalized_Desc
            // 
            this.lblKey_Finalized_Desc.AutoSize = true;
            this.lblKey_Finalized_Desc.Location = new System.Drawing.Point(320, 5);
            this.lblKey_Finalized_Desc.Name = "lblKey_Finalized_Desc";
            this.lblKey_Finalized_Desc.Size = new System.Drawing.Size(48, 13);
            this.lblKey_Finalized_Desc.TabIndex = 10;
            this.lblKey_Finalized_Desc.Text = "Finalized";
            // 
            // lblKey_Finalized
            // 
            this.lblKey_Finalized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey_Finalized.Location = new System.Drawing.Point(304, 3);
            this.lblKey_Finalized.Name = "lblKey_Finalized";
            this.lblKey_Finalized.Size = new System.Drawing.Size(16, 16);
            this.lblKey_Finalized.TabIndex = 9;
            // 
            // lblKey_Completed_Desc
            // 
            this.lblKey_Completed_Desc.AutoSize = true;
            this.lblKey_Completed_Desc.Location = new System.Drawing.Point(247, 5);
            this.lblKey_Completed_Desc.Name = "lblKey_Completed_Desc";
            this.lblKey_Completed_Desc.Size = new System.Drawing.Size(57, 13);
            this.lblKey_Completed_Desc.TabIndex = 8;
            this.lblKey_Completed_Desc.Text = "Completed";
            // 
            // lblKey_Completed
            // 
            this.lblKey_Completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey_Completed.Location = new System.Drawing.Point(231, 3);
            this.lblKey_Completed.Name = "lblKey_Completed";
            this.lblKey_Completed.Size = new System.Drawing.Size(16, 16);
            this.lblKey_Completed.TabIndex = 7;
            // 
            // lblKey_InProgress_Desc
            // 
            this.lblKey_InProgress_Desc.AutoSize = true;
            this.lblKey_InProgress_Desc.Location = new System.Drawing.Point(172, 5);
            this.lblKey_InProgress_Desc.Name = "lblKey_InProgress_Desc";
            this.lblKey_InProgress_Desc.Size = new System.Drawing.Size(59, 13);
            this.lblKey_InProgress_Desc.TabIndex = 6;
            this.lblKey_InProgress_Desc.Text = "In progress";
            // 
            // lblKey_InProgress
            // 
            this.lblKey_InProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey_InProgress.Location = new System.Drawing.Point(156, 3);
            this.lblKey_InProgress.Name = "lblKey_InProgress";
            this.lblKey_InProgress.Size = new System.Drawing.Size(16, 16);
            this.lblKey_InProgress.TabIndex = 5;
            // 
            // lblKey_Received_Desc
            // 
            this.lblKey_Received_Desc.AutoSize = true;
            this.lblKey_Received_Desc.Location = new System.Drawing.Point(103, 5);
            this.lblKey_Received_Desc.Name = "lblKey_Received_Desc";
            this.lblKey_Received_Desc.Size = new System.Drawing.Size(53, 13);
            this.lblKey_Received_Desc.TabIndex = 4;
            this.lblKey_Received_Desc.Text = "Received";
            // 
            // lblKey_Received
            // 
            this.lblKey_Received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey_Received.Location = new System.Drawing.Point(87, 3);
            this.lblKey_Received.Name = "lblKey_Received";
            this.lblKey_Received.Size = new System.Drawing.Size(16, 16);
            this.lblKey_Received.TabIndex = 3;
            // 
            // lblKey_NotReceived_Desc
            // 
            this.lblKey_NotReceived_Desc.AutoSize = true;
            this.lblKey_NotReceived_Desc.Location = new System.Drawing.Point(19, 5);
            this.lblKey_NotReceived_Desc.Name = "lblKey_NotReceived_Desc";
            this.lblKey_NotReceived_Desc.Size = new System.Drawing.Size(68, 13);
            this.lblKey_NotReceived_Desc.TabIndex = 2;
            this.lblKey_NotReceived_Desc.Text = "Not received";
            // 
            // lblKey_NotReceived
            // 
            this.lblKey_NotReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKey_NotReceived.Location = new System.Drawing.Point(3, 3);
            this.lblKey_NotReceived.Name = "lblKey_NotReceived";
            this.lblKey_NotReceived.Size = new System.Drawing.Size(16, 16);
            this.lblKey_NotReceived.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(947, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(119, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to file...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pnlTopInfo
            // 
            this.pnlTopInfo.Controls.Add(this.label2);
            this.pnlTopInfo.Controls.Add(this.tbxHotDate);
            this.pnlTopInfo.Controls.Add(this.txtRmaStatus);
            this.pnlTopInfo.Controls.Add(this.lblRmaStatus);
            this.pnlTopInfo.Controls.Add(this.tabControlSide);
            this.pnlTopInfo.Controls.Add(this.grpJournal);
            this.pnlTopInfo.Controls.Add(this.pbNotesFlag);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_Notes);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_Notes);
            this.pnlTopInfo.Controls.Add(this.btnRMATime);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_Duration);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_RMANumber);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_Duration);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_RMANumber);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_Finalized);
            this.pnlTopInfo.Controls.Add(this.chkRMADetails_APR);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_Finalized);
            this.pnlTopInfo.Controls.Add(this.chkRMA_Hot);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_Completed);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_Completed);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_CreationDate);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_LegacyRMA);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_CreationDate);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_CreatedBy);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_LegacyRMA);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_CreatedBy);
            this.pnlTopInfo.Controls.Add(this.radRMADetails_PONumber);
            this.pnlTopInfo.Controls.Add(this.radRMADetails_JobNumber);
            this.pnlTopInfo.Controls.Add(this.lblRMADetails_AssignedTo);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_Job_PO);
            this.pnlTopInfo.Controls.Add(this.txtRMADetails_AssignedTo);
            this.pnlTopInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopInfo.Location = new System.Drawing.Point(0, 30);
            this.pnlTopInfo.Name = "pnlTopInfo";
            this.pnlTopInfo.Size = new System.Drawing.Size(1184, 232);
            this.pnlTopInfo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Hot Date:";
            // 
            // tbxHotDate
            // 
            this.tbxHotDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxHotDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHotDate.Location = new System.Drawing.Point(252, 43);
            this.tbxHotDate.Name = "tbxHotDate";
            this.tbxHotDate.ReadOnly = true;
            this.tbxHotDate.Size = new System.Drawing.Size(122, 20);
            this.tbxHotDate.TabIndex = 81;
            // 
            // txtRmaStatus
            // 
            this.txtRmaStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmaStatus.Location = new System.Drawing.Point(337, 16);
            this.txtRmaStatus.Name = "txtRmaStatus";
            this.txtRmaStatus.ReadOnly = true;
            this.txtRmaStatus.Size = new System.Drawing.Size(122, 26);
            this.txtRmaStatus.TabIndex = 80;
            this.txtRmaStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRmaStatus
            // 
            this.lblRmaStatus.AutoSize = true;
            this.lblRmaStatus.Location = new System.Drawing.Point(334, 3);
            this.lblRmaStatus.Name = "lblRmaStatus";
            this.lblRmaStatus.Size = new System.Drawing.Size(37, 13);
            this.lblRmaStatus.TabIndex = 79;
            this.lblRmaStatus.Text = "Status";
            // 
            // tabControlSide
            // 
            this.tabControlSide.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlSide.Controls.Add(this.tabAssetDetails);
            this.tabControlSide.Controls.Add(this.tabTicketDetails);
            this.tabControlSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlSide.Location = new System.Drawing.Point(964, 0);
            this.tabControlSide.Multiline = true;
            this.tabControlSide.Name = "tabControlSide";
            this.tabControlSide.SelectedIndex = 0;
            this.tabControlSide.Size = new System.Drawing.Size(220, 232);
            this.tabControlSide.TabIndex = 76;
            // 
            // tabAssetDetails
            // 
            this.tabAssetDetails.Controls.Add(this.lblAsset_Pitch);
            this.tabAssetDetails.Controls.Add(this.lblRMADetails_Asset);
            this.tabAssetDetails.Controls.Add(this.txtAsset_Pitch);
            this.tabAssetDetails.Controls.Add(this.txtRMADetails_Asset);
            this.tabAssetDetails.Controls.Add(this.lblAsset_Matrix);
            this.tabAssetDetails.Controls.Add(this.txtAsset_InstallDate);
            this.tabAssetDetails.Controls.Add(this.txtAsset_Matrix);
            this.tabAssetDetails.Controls.Add(this.lblAsset_InstallDate);
            this.tabAssetDetails.Controls.Add(this.lblAsset_ControllerHw);
            this.tabAssetDetails.Controls.Add(this.txtAsset_SignType);
            this.tabAssetDetails.Controls.Add(this.txtAsset_ControllerHw);
            this.tabAssetDetails.Controls.Add(this.lblAsset_SignType);
            this.tabAssetDetails.Location = new System.Drawing.Point(23, 4);
            this.tabAssetDetails.Name = "tabAssetDetails";
            this.tabAssetDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssetDetails.Size = new System.Drawing.Size(193, 224);
            this.tabAssetDetails.TabIndex = 0;
            this.tabAssetDetails.Text = "Asset Details";
            this.tabAssetDetails.UseVisualStyleBackColor = true;
            // 
            // tabTicketDetails
            // 
            this.tabTicketDetails.Controls.Add(this.lblTicket_Symptoms);
            this.tabTicketDetails.Controls.Add(this.txtTicket_Symptoms);
            this.tabTicketDetails.Controls.Add(this.lblTicket_OSANotes);
            this.tabTicketDetails.Controls.Add(this.lblTicket_Number);
            this.tabTicketDetails.Controls.Add(this.txtTicket_OSANotes);
            this.tabTicketDetails.Controls.Add(this.txtTicket_Number);
            this.tabTicketDetails.Location = new System.Drawing.Point(23, 4);
            this.tabTicketDetails.Name = "tabTicketDetails";
            this.tabTicketDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicketDetails.Size = new System.Drawing.Size(193, 224);
            this.tabTicketDetails.TabIndex = 1;
            this.tabTicketDetails.Text = "Ticket Details";
            this.tabTicketDetails.UseVisualStyleBackColor = true;
            // 
            // lblTicket_Symptoms
            // 
            this.lblTicket_Symptoms.AutoSize = true;
            this.lblTicket_Symptoms.Location = new System.Drawing.Point(3, 25);
            this.lblTicket_Symptoms.Name = "lblTicket_Symptoms";
            this.lblTicket_Symptoms.Size = new System.Drawing.Size(61, 13);
            this.lblTicket_Symptoms.TabIndex = 4;
            this.lblTicket_Symptoms.Text = "Symptom(s)";
            // 
            // txtTicket_Symptoms
            // 
            this.txtTicket_Symptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTicket_Symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket_Symptoms.Location = new System.Drawing.Point(6, 41);
            this.txtTicket_Symptoms.Name = "txtTicket_Symptoms";
            this.txtTicket_Symptoms.ReadOnly = true;
            this.txtTicket_Symptoms.Size = new System.Drawing.Size(181, 20);
            this.txtTicket_Symptoms.TabIndex = 5;
            // 
            // grpJournal
            // 
            this.grpJournal.Controls.Add(this.dgvJournal);
            this.grpJournal.Controls.Add(this.pnlJournal_Control);
            this.grpJournal.Location = new System.Drawing.Point(469, 10);
            this.grpJournal.Name = "grpJournal";
            this.grpJournal.Size = new System.Drawing.Size(495, 216);
            this.grpJournal.TabIndex = 77;
            this.grpJournal.TabStop = false;
            this.grpJournal.Text = "Journal";
            // 
            // pnlBottomTabs
            // 
            this.pnlBottomTabs.Controls.Add(this.tabControl_RMA);
            this.pnlBottomTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomTabs.Location = new System.Drawing.Point(0, 262);
            this.pnlBottomTabs.Name = "pnlBottomTabs";
            this.pnlBottomTabs.Size = new System.Drawing.Size(1184, 479);
            this.pnlBottomTabs.TabIndex = 30;
            // 
            // FormRMA_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.pnlBottomTabs);
            this.Controls.Add(this.pnlTopInfo);
            this.Controls.Add(this.pnlControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 1200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 736);
            this.Name = "FormRMA_Editor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RMA Editor";
            this.Activated += new System.EventHandler(this.FormRMA_Editor_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRMAEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormRMAEditor_Load);
            this.Shown += new System.EventHandler(this.FormRMA_Editor_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRMA_Editor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbNotesFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).EndInit();
            this.pnlAssemblyAdd_Control.ResumeLayout(false);
            this.pnlAssemblyAdd_Control.PerformLayout();
            this.tabControl_RMA.ResumeLayout(false);
            this.tabAssemblyTypes.ResumeLayout(false);
            this.tabReceive.ResumeLayout(false);
            this.pnlReceive_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvReceive_Assemblies)).EndInit();
            this.ctxAssemblyReceive.ResumeLayout(false);
            this.pnlReceive_Assemblies_Control.ResumeLayout(false);
            this.pnlReceive_Assemblies_Control.PerformLayout();
            this.pnlReceive_Right.ResumeLayout(false);
            this.pnlReceive_Right.PerformLayout();
            this.tabRepair.ResumeLayout(false);
            this.pnlRepair_RightSide.ResumeLayout(false);
            this.pnlRepair_RepairSection.ResumeLayout(false);
            this.pnlRepair_RepairDetail.ResumeLayout(false);
            this.pnlRepair_RepairDetail.PerformLayout();
            this.grpRepair_RepairNotes.ResumeLayout(false);
            this.grpRepair_RepairNotes.PerformLayout();
            this.grpRepair_RepairTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairTypes)).EndInit();
            this.pnlRepair_RepairType_Control.ResumeLayout(false);
            this.grpRepair_Components.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Components)).EndInit();
            this.pnlRepair_Component_Control.ResumeLayout(false);
            this.pnlRepair_Component_Control.PerformLayout();
            this.pnlRepair_RepairTime.ResumeLayout(false);
            this.pnlRepair_RepairTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_RepairLog)).EndInit();
            this.pnlRepair_FailureSection.ResumeLayout(false);
            this.pnlRepair_FailureSection.PerformLayout();
            this.ctxRepairFailureTypeChange.ResumeLayout(false);
            this.pnlRepair_AssemblySection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvRepair_Assemblies)).EndInit();
            this.pnlRepair_Assemblies_Control.ResumeLayout(false);
            this.pnlRepair_Assemblies_Control.PerformLayout();
            this.tabShipments.ResumeLayout(false);
            this.tabAccounting.ResumeLayout(false);
            this.grpAccounting_Components.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAccounting_Components)).EndInit();
            this.pnlAccounting_Components_Control.ResumeLayout(false);
            this.pnlAccounting_Components_Control.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.spltSummary.Panel1.ResumeLayout(false);
            this.spltSummary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltSummary)).EndInit();
            this.spltSummary.ResumeLayout(false);
            this.grpSummary_Assemblies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSummary_Assemblies)).EndInit();
            this.pnlSummary_Assemblies_Control.ResumeLayout(false);
            this.pnlSummary_Assemblies_Control.PerformLayout();
            this.grpSummary_AssemblyRepairNotes.ResumeLayout(false);
            this.grpSummary_AssemblyRepairNotes.PerformLayout();
            this.grpSummary_Components.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSummary_Components)).EndInit();
            this.pnlSummary_Components_Control.ResumeLayout(false);
            this.pnlSummary_Components_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.pnlJournal_Control.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            this.pnlTopInfo.ResumeLayout(false);
            this.pnlTopInfo.PerformLayout();
            this.tabControlSide.ResumeLayout(false);
            this.tabAssetDetails.ResumeLayout(false);
            this.tabAssetDetails.PerformLayout();
            this.tabTicketDetails.ResumeLayout(false);
            this.tabTicketDetails.PerformLayout();
            this.grpJournal.ResumeLayout(false);
            this.pnlBottomTabs.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblRMADetails_Asset;
		private System.Windows.Forms.TextBox txtRMADetails_Asset;
		private System.Windows.Forms.Label lblTicket_Number;
		private System.Windows.Forms.TextBox txtTicket_Number;
		private System.Windows.Forms.Label lblRMADetails_RMANumber;
		private System.Windows.Forms.TextBox txtRMADetails_RMANumber;
		private System.Windows.Forms.Label lblAsset_InstallDate;
		private System.Windows.Forms.TextBox txtAsset_InstallDate;
		private BrightIdeasSoftware.ObjectListView olvAssemblyAdd;
		private BrightIdeasSoftware.OLVColumn olvColAssyAdd_Description;
		private BrightIdeasSoftware.OLVColumn olvColAssyAdd_FailureType;
		private BrightIdeasSoftware.OLVColumn olvColAssyAdd_Grid;
		private BrightIdeasSoftware.OLVColumn olvColAssyAdd_Notes;
		private System.Windows.Forms.Panel pnlAssemblyAdd_Control;
		private System.Windows.Forms.TextBox txtRMADetails_AssignedTo;
		private System.Windows.Forms.Label lblRMADetails_AssignedTo;
		private System.Windows.Forms.TabControl tabControl_RMA;
		private System.Windows.Forms.TabPage tabAssemblyTypes;
		private System.Windows.Forms.TabPage tabRepair;
		private System.Windows.Forms.Label lblRepair_GridLocation;
		private System.Windows.Forms.TextBox txtRepair_GridLocation;
		private System.Windows.Forms.Label lblRepair_FailureType;
		private System.Windows.Forms.TextBox txtRepair_FailureNotes;
		private BrightIdeasSoftware.ObjectListView olvRepair_Assemblies;
		private System.Windows.Forms.GroupBox grpRepair_Components;
		private BrightIdeasSoftware.ObjectListView olvRepair_Components;
		private BrightIdeasSoftware.OLVColumn olvColRepair_Component_PartNumber;
		private BrightIdeasSoftware.OLVColumn olvColRepair_Component_Description;
		private BrightIdeasSoftware.OLVColumn olvColRepair_Component_SilkLabel;
		private System.Windows.Forms.Panel pnlRepair_Component_Control;
		private System.Windows.Forms.Button btnRepair_Component_Add;
		private BrightIdeasSoftware.ObjectListView olvRepair_RepairTypes;
		private BrightIdeasSoftware.OLVColumn olvColRepair_RepairType;
		private System.Windows.Forms.TextBox txtRepair_Notes;
		private System.Windows.Forms.TextBox txtRMADetails_CreationDate;
		private System.Windows.Forms.Label lblRMADetails_CreationDate;
		private System.Windows.Forms.TextBox txtRMADetails_CreatedBy;
		private System.Windows.Forms.Label lblRMADetails_CreatedBy;
		private System.Windows.Forms.Button btnRepair_StartStop;
		private System.Windows.Forms.TabPage tabReceive;
		private System.Windows.Forms.Button btnReceive_ReceiveSelected;
		private BrightIdeasSoftware.ObjectListView olvReceive_Assemblies;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Description;
		private System.Windows.Forms.Label lblRepair_InventoryLocation;
		private System.Windows.Forms.TextBox txtRepair_InventoryLocation;
		private System.Windows.Forms.Label lblRepair_ReceiveDate;
		private System.Windows.Forms.TextBox txtRepair_ReceiveDate;
		private System.Windows.Forms.Label lblRepair_DateCompleted;
		private System.Windows.Forms.TextBox txtRepair_DateCompleted;
		private System.Windows.Forms.Label lblRepair_DateStarted;
		private System.Windows.Forms.TextBox txtRepair_DateStarted;
		private System.Windows.Forms.TabPage tabAccounting;
		private System.Windows.Forms.GroupBox grpAccounting_Components;
		private BrightIdeasSoftware.ObjectListView olvAccounting_Components;
		private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_PartNumber;
		private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_Description;
		private BrightIdeasSoftware.OLVColumn olvColAccounting_Components_SilkLabel;
		private System.Windows.Forms.Panel pnlAccounting_Components_Control;
		private System.Windows.Forms.Label lblAssemblyAdd_Qty;
		private System.Windows.Forms.TextBox txtAssemblyAdd_Qty;
		private System.Windows.Forms.Label lblAccounting_Components_Qty;
		private System.Windows.Forms.TextBox txtAccounting_Components_Qty;
		private System.Windows.Forms.TextBox txtRMADetails_Job_PO;
		private System.Windows.Forms.CheckBox chkAccounting_Charged;
		private System.Windows.Forms.RadioButton radRMADetails_PONumber;
		private System.Windows.Forms.RadioButton radRMADetails_JobNumber;
		private System.Windows.Forms.Label lblAsset_ControllerHw;
		private System.Windows.Forms.TextBox txtAsset_ControllerHw;
		private System.Windows.Forms.Label lblAsset_SignType;
		private System.Windows.Forms.TextBox txtAsset_SignType;
		private System.Windows.Forms.Label lblTicket_OSANotes;
		private System.Windows.Forms.TextBox txtTicket_OSANotes;
		private System.Windows.Forms.Label lblAsset_Matrix;
		private System.Windows.Forms.TextBox txtAsset_Matrix;
		private System.Windows.Forms.TabPage tabSummary;
		private System.Windows.Forms.GroupBox grpSummary_Components;
		private BrightIdeasSoftware.ObjectListView olvSummary_Components;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Components_PartNumber;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Components_Component;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Components_SilkLabel;
		private System.Windows.Forms.Panel pnlSummary_Components_Control;
		private System.Windows.Forms.Label lblSummary_Components_Qty;
		private System.Windows.Forms.TextBox txtSummary_Components_Qty;
		private System.Windows.Forms.GroupBox grpSummary_Assemblies;
		private BrightIdeasSoftware.ObjectListView olvSummary_Assemblies;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_FailureType;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_Grid;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_RepairTypes;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_RootCause;
		private System.Windows.Forms.Panel pnlSummary_Assemblies_Control;
		private System.Windows.Forms.Label lblSummary_Assemblies_Qty;
		private System.Windows.Forms.TextBox txtSummary_Assemblies_Qty;
		private System.Windows.Forms.Button btnRepair_Finish;
		private System.Windows.Forms.TabPage tabShipments;
		private System.Windows.Forms.Button btnSummary_Assembly_Finalize;
		private System.Windows.Forms.Label lblRepair_MU;
		private System.Windows.Forms.TextBox txtRepair_MU;
		private System.Windows.Forms.Label lblRepair_LEDBoard_Calibration;
		private System.Windows.Forms.TextBox txtRepair_LEDBoard_Calibration;
		private System.Windows.Forms.Label lblRepair_OriginalJobNumber;
		private System.Windows.Forms.TextBox txtRepair_OriginalJobNumber;
		private System.Windows.Forms.CheckBox chkRMADetails_APR;
		private System.Windows.Forms.TextBox txtRMADetails_LegacyRMA;
		private System.Windows.Forms.Label lblRMADetails_LegacyRMA;
		private BrightIdeasSoftware.OLVColumn olvColRepair_Assy;
		private System.Windows.Forms.Label lblRepair_RepairTime;
		private System.Windows.Forms.TextBox txtRepair_RepairTime;
		private System.Windows.Forms.Panel pnlRepair_RepairSection;
		private System.Windows.Forms.Label lblRepair_Assembly;
		private System.Windows.Forms.ComboBox cmbRepair_Assembly;
		private System.Windows.Forms.TextBox txtRepair_FailureType;
		private System.Windows.Forms.Label lblRepair_Components_Qty;
		private System.Windows.Forms.TextBox txtRepair_Components_Qty;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.CheckBox chkRMA_Hot;
		private System.Windows.Forms.GroupBox grpRepair_RepairTypes;
		private System.Windows.Forms.Panel pnlRepair_RepairType_Control;
		private System.Windows.Forms.Button btnRepair_RepairType_Add;
		private System.Windows.Forms.GroupBox grpRepair_RepairNotes;
		private BrightIdeasSoftware.OLVColumn olvColReceive_FailureType;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_Date;
		private BrightIdeasSoftware.OLVColumn olvColReceive_Receive_User;
		private System.Windows.Forms.Button btnRepair_RepairType_Remove;
		private System.Windows.Forms.Button btnRepair_Component_Remove;
		private System.Windows.Forms.Button btnRepair_Unfinish;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.TextBox txtReceive_TotalAssyQty;
		private System.Windows.Forms.Label lblReceive_ReceivedQty;
		private System.Windows.Forms.TextBox txtReceive_ReceivedQty;
		private System.Windows.Forms.TextBox txtRMADetails_Duration;
		private System.Windows.Forms.Label lblRMADetails_Duration;
		private System.Windows.Forms.TextBox txtRMADetails_Finalized;
		private System.Windows.Forms.Label lblRMADetails_Finalized;
		private System.Windows.Forms.TextBox txtRMADetails_Completed;
		private System.Windows.Forms.Label lblRMADetails_Completed;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Panel pnlRepair_FailureSection;
		private System.Windows.Forms.Button btnRMATime;
		private System.Windows.Forms.Label lblAccounting_TotalCost;
		private System.Windows.Forms.TextBox txtAccounting_TotalCost;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assembly;
		private System.Windows.Forms.Panel pnlRepair_RepairDetail;
		private System.Windows.Forms.Button btnRepair_Save;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnAssemblyManagement;
		private System.Windows.Forms.CheckBox chkRepair_UnlockAssemblyFromType;
		private System.Windows.Forms.Label lblRepair_TechTime;
		private System.Windows.Forms.TextBox txtRepair_TechTime;
		private System.Windows.Forms.Panel pnlRepair_AssemblySection;
		private System.Windows.Forms.Panel pnlRepair_Assemblies_Control;
		private System.Windows.Forms.Label txtRepair_Assemblies_ReceivedOf;
		private System.Windows.Forms.TextBox txtRepair_Assemblies_TotalQty;
		private System.Windows.Forms.TextBox txtRepair_Assemblies_ReceivedQty;
		private System.Windows.Forms.Panel pnlReceive_Left;
		private System.Windows.Forms.Panel pnlReceive_Assemblies_Control;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_RepairBy;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_TotalTime;
		private System.Windows.Forms.SplitContainer spltSummary;
		private System.Windows.Forms.Label lblRepair_SelectedAssemblyID;
		private System.Windows.Forms.Label lblReceive_SelectedAssemblyID;
		private System.Windows.Forms.Label lblAssemblyAdd_SelectedAssemblyID;
		private System.Windows.Forms.TextBox txtRMADetails_Notes;
		private System.Windows.Forms.Label lblRMADetails_Notes;
		private BrightIdeasSoftware.ObjectListView olvRepair_RepairLog;
		private BrightIdeasSoftware.OLVColumn olvColRepairLog_RepairStart;
		private BrightIdeasSoftware.OLVColumn olvColRepairLog_TimeTaken;
		private BrightIdeasSoftware.OLVColumn olvColRepairLog_UserName;
		private System.Windows.Forms.GroupBox grpSummary_AssemblyRepairNotes;
		private System.Windows.Forms.TextBox txtSummary_AssemblyRepairNotes;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_FinalizedBy;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Assemblies_FinalizedDate;
		private System.Windows.Forms.Label lblRepair_FinalizedBy;
		private System.Windows.Forms.TextBox txtRepair_FinalizedBy;
		private System.Windows.Forms.Label lblRepair_DateFinalized;
		private System.Windows.Forms.TextBox txtRepair_DateFinalized;
		private System.Windows.Forms.Label lblAsset_Pitch;
		private System.Windows.Forms.TextBox txtAsset_Pitch;
		private ucShipmentList ucShipmentList1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvJournal;
		private System.Windows.Forms.Panel pnlJournal_Control;
		private System.Windows.Forms.Button btnJournal_Add;
		private System.Windows.Forms.CheckBox chkSubscribe;
		private System.Windows.Forms.PictureBox pbNotesFlag;
		private System.Windows.Forms.Label lblRepair_SerialNumber;
		private System.Windows.Forms.TextBox txtRepair_SerialNumber;
		private System.Windows.Forms.Panel pnlRepair_RepairTime;
		private BrightIdeasSoftware.OLVColumn olvColReceive_AssemblySerialNumber;
		private System.Windows.Forms.Panel pnlReceive_Right;
		private System.Windows.Forms.Label lblReceive_AssemblySerialNumber;
		private System.Windows.Forms.TextBox txtReceive_AssemblySerialNumber;
		private BrightIdeasSoftware.OLVColumn olvColReceive_BinID;
		private System.Windows.Forms.Button btnReceive_PrintBinLabels_All;
		private System.Windows.Forms.Label lblReceive_CurrentBinID;
		private System.Windows.Forms.TextBox txtReceive_CurrentBinID;
		private System.Windows.Forms.Button btnReceive_PrintBinLabels_Current;
		private System.Windows.Forms.Button btnReceive_DeleteBin;
		private System.Windows.Forms.Panel pnlTopInfo;
		private System.Windows.Forms.Panel pnlBottomTabs;
		private System.Windows.Forms.Panel pnlKey;
		private System.Windows.Forms.Label lblKey_Finalized_Desc;
		private System.Windows.Forms.Label lblKey_Finalized;
		private System.Windows.Forms.Label lblKey_Completed_Desc;
		private System.Windows.Forms.Label lblKey_Completed;
		private System.Windows.Forms.Label lblKey_InProgress_Desc;
		private System.Windows.Forms.Label lblKey_InProgress;
		private System.Windows.Forms.Label lblKey_Received_Desc;
		private System.Windows.Forms.Label lblKey_Received;
		private System.Windows.Forms.Label lblKey_NotReceived_Desc;
		private System.Windows.Forms.Label lblKey_NotReceived;
		private System.Windows.Forms.Panel pnlRepair_RightSide;
		private BrightIdeasSoftware.OLVColumn olvColRepair_SerialNumber;
		private System.Windows.Forms.ContextMenuStrip ctxAssemblyReceive;
		private System.Windows.Forms.ToolStripMenuItem mnuReceive_Undo;
		private System.Windows.Forms.Button btnReceive_CreateBin;
		private System.Windows.Forms.Button btnReceive_SelectBin;
		private System.Windows.Forms.ContextMenuStrip ctxRepairFailureTypeChange;
		private System.Windows.Forms.ToolStripMenuItem mnuRepairFailureTypeChange;
		private System.Windows.Forms.Label lblReceive_BinAssyQty;
		private System.Windows.Forms.TabControl tabControlSide;
		private System.Windows.Forms.TabPage tabAssetDetails;
		private System.Windows.Forms.TabPage tabTicketDetails;
		private System.Windows.Forms.GroupBox grpJournal;
		private System.Windows.Forms.Button btnRepair_SerialNumberSearch;
		private System.Windows.Forms.Button btnRepair_InventoryMove;
		private System.Windows.Forms.Label lblTicket_Symptoms;
		private System.Windows.Forms.TextBox txtTicket_Symptoms;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
		private BrightIdeasSoftware.OLVColumn olvColSummary_SerialNumber;
		private BrightIdeasSoftware.OLVColumn olvColDiscarded;
		private BrightIdeasSoftware.OLVColumn olvColAssyAdd_Discarded;
		private System.Windows.Forms.Button btnReceive_DiscardSelected;
		private BrightIdeasSoftware.OLVColumn olvColSummary_Discarded;
		private System.Windows.Forms.Label lblRepair_Discarded;
		private System.Windows.Forms.TextBox txtRmaStatus;
		private System.Windows.Forms.Label lblRmaStatus;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbRepairAction;
        private BrightIdeasSoftware.OLVColumn olvColAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxHotDate;
    }
}

