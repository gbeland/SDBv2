using SDB.Classes.Asset;
using SDB.Classes.Misc;
using SDB.UserControls.RMA;
using SDB.UserControls.Shipment;

namespace SDB.UserControls.Asset
{
	partial class AssetEditor
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
			System.Windows.Forms.PictureBox pbMonitoring_PVMLogo;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetEditor));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			SDB.Classes.Asset.ClassAsset.ClassIbom classIbom1 = new SDB.Classes.Asset.ClassAsset.ClassIbom();
			this.pnlControl_Bottom = new System.Windows.Forms.Panel();
			this.btnTeamViewer = new System.Windows.Forms.Button();
			this.btnVNC = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.pnlControl_Top = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuAddNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRetire = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.chkSubscribe = new System.Windows.Forms.CheckBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEditSave = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.lblAsset_Pitch = new System.Windows.Forms.Label();
			this.cmbAsset_FacingDirection = new System.Windows.Forms.ComboBox();
			this.lblAsset_CabinetType = new System.Windows.Forms.Label();
			this.lblAsset_ChipType = new System.Windows.Forms.Label();
			this.btnAsset_GeoCode = new System.Windows.Forms.Button();
			this.txtLongitude = new System.Windows.Forms.TextBox();
			this.txtLatitude = new System.Windows.Forms.TextBox();
			this.lblLatitude = new System.Windows.Forms.Label();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtAsset_SerialNumber = new System.Windows.Forms.TextBox();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblLocation = new System.Windows.Forms.Label();
			this.lblAsset_HAGL = new System.Windows.Forms.Label();
			this.lblAsset_SerialNumber = new System.Windows.Forms.Label();
			this.lblMatrix = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.lblInterfaceType = new System.Windows.Forms.Label();
			this.btnAsset_SelectMarket = new System.Windows.Forms.Button();
			this.txtAsset_Release = new System.Windows.Forms.TextBox();
			this.txtAsset_AssetName = new System.Windows.Forms.TextBox();
			this.txtAsset_Panel = new System.Windows.Forms.TextBox();
			this.lblAsset_InstalledDateTime = new System.Windows.Forms.Label();
			this.lblAsset_ShippedDateTime = new System.Windows.Forms.Label();
			this.lblAsset_Release = new System.Windows.Forms.Label();
			this.lblAsset_Panel = new System.Windows.Forms.Label();
			this.lblAsset_AssetName = new System.Windows.Forms.Label();
			this.txtAsset_Market = new System.Windows.Forms.TextBox();
			this.lblAsset_Market = new System.Windows.Forms.Label();
			this.txtAsset_Customer = new System.Windows.Forms.TextBox();
			this.lblAsset_Customer = new System.Windows.Forms.Label();
			this.pnlAdditional = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNotes = new System.Windows.Forms.TabPage();
			this.pnlGeneralNotes = new System.Windows.Forms.Panel();
			this.txtGeneralNotes = new System.Windows.Forms.TextBox();
			this.lblGeneralNotes = new System.Windows.Forms.Label();
			this.tabTicketHistory = new System.Windows.Forms.TabPage();
			this.olvTicketHistory = new BrightIdeasSoftware.ObjectListView();
			this.olcTicketHistory_TicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTicketHistory_OpenDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTicketHistory_IssueNum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTicketHistory_Symptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTicketHistory_Solutions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlTicketHistory_Control = new System.Windows.Forms.Panel();
			this.btnSetServiceReminder = new System.Windows.Forms.Button();
			this.btnCreateTicket = new System.Windows.Forms.Button();
			this.lblTicketHistory_TicketQty = new System.Windows.Forms.Label();
			this.txtTicketHistory_TicketQty = new System.Windows.Forms.TextBox();
			this.tabNetwork = new System.Windows.Forms.TabPage();
			this.pnlNetwork = new System.Windows.Forms.Panel();
			this.pnlCradlepoint = new System.Windows.Forms.Panel();
			this.cbxIsCradlepoint = new System.Windows.Forms.CheckBox();
			this.tbxCradlepointEmail = new System.Windows.Forms.TextBox();
			this.lblResetEmail = new System.Windows.Forms.Label();
			this.tbxCradlepointMAC = new System.Windows.Forms.TextBox();
			this.lblCpMAC = new System.Windows.Forms.Label();
			this.lblCradlepoint = new System.Windows.Forms.Label();
			this.pnlNetwork_System = new System.Windows.Forms.Panel();
			this.chkNetwork_SystemSsl = new System.Windows.Forms.CheckBox();
			this.txtNetwork_SystemPassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_SystemPassword = new System.Windows.Forms.Label();
			this.lblNetwork_System = new System.Windows.Forms.Label();
			this.numNetwork_SystemPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_SystemPort = new System.Windows.Forms.Label();
			this.pnlNetwork_Player = new System.Windows.Forms.Panel();
			this.chkNetwork_PlayerSsl = new System.Windows.Forms.CheckBox();
			this.txtNetwork_PlayerPassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_PlayerPassword = new System.Windows.Forms.Label();
			this.lblNetwork_PlayerPort = new System.Windows.Forms.Label();
			this.numNetwork_PlayerPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_Player = new System.Windows.Forms.Label();
			this.pnlNetwork_Remote = new System.Windows.Forms.Panel();
			this.cbxUseRealVNC = new System.Windows.Forms.CheckBox();
			this.txtNetwork_TeamviewerPassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_TeamviewerPassword = new System.Windows.Forms.Label();
			this.numNetwork_RemoteVncWebPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_TeamviewerID = new System.Windows.Forms.Label();
			this.txtNetwork_TeamviewerID = new System.Windows.Forms.TextBox();
			this.numNetwork_RemoteVncPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_Remote = new System.Windows.Forms.Label();
			this.lblNetwork_RemoteVncPort = new System.Windows.Forms.Label();
			this.txtNetwork_RemoteVncPassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_RemoteVncPassword = new System.Windows.Forms.Label();
			this.lblNetwork_RemoteVncWebPort = new System.Windows.Forms.Label();
			this.pnlNetwork_MiniGoose = new System.Windows.Forms.Panel();
			this.numNetwork_MiniGoosePort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_MiniGoose = new System.Windows.Forms.Label();
			this.txtNetwork_MiniGooseLan = new System.Windows.Forms.TextBox();
			this.txtNetwork_MiniGoosePassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_MiniGooseLan = new System.Windows.Forms.Label();
			this.lblNetwork_MiniGoosePassword = new System.Windows.Forms.Label();
			this.lblNetwork_MiniGoosePort = new System.Windows.Forms.Label();
			this.pnlNetwork_IBoot = new System.Windows.Forms.Panel();
			this.numNetwork_IBootPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_IBoot = new System.Windows.Forms.Label();
			this.txtNetwork_IBootLan = new System.Windows.Forms.TextBox();
			this.txtNetwork_IBootPassword = new System.Windows.Forms.TextBox();
			this.lblNetwork_IBootLan = new System.Windows.Forms.Label();
			this.lblNetwork_IBootPassword = new System.Windows.Forms.Label();
			this.lblNetwork_IBootPort = new System.Windows.Forms.Label();
			this.pnlNetwork_Camera = new System.Windows.Forms.Panel();
			this.lblNetwork_CameraAssembly = new System.Windows.Forms.Label();
			this.lblNetwork_Camera = new System.Windows.Forms.Label();
			this.txtNetwork_WebcamTypeAssemblyDesc = new System.Windows.Forms.TextBox();
			this.cmbNetwork_WebcamType = new System.Windows.Forms.ComboBox();
			this.lblNetwork_CameraLan = new System.Windows.Forms.Label();
			this.lblNetwork_CameraTypeImage = new System.Windows.Forms.Label();
			this.lblNetwork_CameraPort = new System.Windows.Forms.Label();
			this.numNetwork_CameraPort = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblNetwork_CameraChannel = new System.Windows.Forms.Label();
			this.txtNetwork_CameraUser = new System.Windows.Forms.TextBox();
			this.lblNetwork_CameraPassword = new System.Windows.Forms.Label();
			this.lblNetwork_CameraUser = new System.Windows.Forms.Label();
			this.txtNetwork_CameraPassword = new System.Windows.Forms.TextBox();
			this.numNetwork_CameraChannel = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.txtNetwork_CameraLan = new System.Windows.Forms.TextBox();
			this.pnlNetwork_Server = new System.Windows.Forms.Panel();
			this.lblNetwork_Server = new System.Windows.Forms.Label();
			this.txtNetwork_ServerLan = new System.Windows.Forms.TextBox();
			this.lblNetwork_ServerLan = new System.Windows.Forms.Label();
			this.txtNetwork_ServerMask = new System.Windows.Forms.TextBox();
			this.lblNetwork_ServerMask = new System.Windows.Forms.Label();
			this.txtNetwork_ServerGateway = new System.Windows.Forms.TextBox();
			this.lblNetwork_ServerGateway = new System.Windows.Forms.Label();
			this.chkNetwork_UseLAN = new System.Windows.Forms.CheckBox();
			this.lblNetwork_Installed = new System.Windows.Forms.Label();
			this.txtNetwork_ISP = new System.Windows.Forms.TextBox();
			this.lblNetwork_WAN = new System.Windows.Forms.Label();
			this.chkNetwork_CameraInstalled = new System.Windows.Forms.CheckBox();
			this.chkNetwork_IBootInstalled = new System.Windows.Forms.CheckBox();
			this.chkNetwork_MiniGooseInstalled = new System.Windows.Forms.CheckBox();
			this.lblNetwork_Router = new System.Windows.Forms.Label();
			this.txtNetwork_WAN = new System.Windows.Forms.TextBox();
			this.lblNetwork_ISP = new System.Windows.Forms.Label();
			this.txtNetwork_Router = new System.Windows.Forms.TextBox();
			this.tabRMA = new System.Windows.Forms.TabPage();
			this.lblLegacyRMACount = new System.Windows.Forms.Label();
			this.tbxLegacyRMACount = new System.Windows.Forms.TextBox();
			this.radRMA = new System.Windows.Forms.RadioButton();
			this.ucRMAList1 = new SDB.UserControls.RMA.RmaList();
			this.tabDocuments = new System.Windows.Forms.TabPage();
			this.olvDocuments = new BrightIdeasSoftware.ObjectListView();
			this.olvDocumentsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvUserColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlDocumentsControl = new System.Windows.Forms.Panel();
			this.btnAddDocument = new System.Windows.Forms.Button();
			this.btnRemoveDocument = new System.Windows.Forms.Button();
			this.btnChangeDocument = new System.Windows.Forms.Button();
			this.tabMonitoring = new System.Windows.Forms.TabPage();
			this.pnlMonitoringControl = new System.Windows.Forms.Panel();
			this.lblMonitoring_CameraCheckInterval = new System.Windows.Forms.Label();
			this.numMonitoring_CameraCheckInterval = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblMonitoring_CameraCheckInterval_Unit = new System.Windows.Forms.Label();
			this.txtMonitoring_BlackoutSchedule = new System.Windows.Forms.TextBox();
			this.lblMonitoringControl = new System.Windows.Forms.Label();
			this.lblMonitoring_HoldTimeSeconds = new System.Windows.Forms.Label();
			this.lblMonitoring_ShowWebcamStatus = new System.Windows.Forms.Label();
			this.lblMonitoring_StuckImageThreshold = new System.Windows.Forms.Label();
			this.lblMonitoring_ShowDataStatus = new System.Windows.Forms.Label();
			this.btnMonitoring_BlackoutSchedule = new System.Windows.Forms.Button();
			this.lblMonitoring_Interval = new System.Windows.Forms.Label();
			this.pnlMonitoring_WebcamMode = new System.Windows.Forms.Panel();
			this.radMonitoring_WebcamMode_Forced = new System.Windows.Forms.RadioButton();
			this.radMonitoring_WebcamMode_Disabled = new System.Windows.Forms.RadioButton();
			this.radMonitoring_WebcamMode_Auto = new System.Windows.Forms.RadioButton();
			this.pnlMonitoring_DataMode = new System.Windows.Forms.Panel();
			this.radMonitoring_DataMode_Forced = new System.Windows.Forms.RadioButton();
			this.radMonitoring_DataMode_Disabled = new System.Windows.Forms.RadioButton();
			this.radMonitoring_DataMode_Auto = new System.Windows.Forms.RadioButton();
			this.lblMonitoring_Webcam = new System.Windows.Forms.Label();
			this.numMonitoring_HoldTime = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numMonitoring_Interval = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblMonitoring_IntervalMinutes = new System.Windows.Forms.Label();
			this.lblMonitoring_Data = new System.Windows.Forms.Label();
			this.lblMonitoring_Status = new System.Windows.Forms.Label();
			this.lblMonitoring_Mode = new System.Windows.Forms.Label();
			this.tabShipments = new System.Windows.Forms.TabPage();
			this.ucShipmentList1 = new SDB.UserControls.Shipment.ucShipmentList();
			this.tabJournal = new System.Windows.Forms.TabPage();
			this.dgvJournal = new System.Windows.Forms.DataGridView();
			this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlJournal_Control = new System.Windows.Forms.Panel();
			this.btnJournal_Add = new System.Windows.Forms.Button();
			this.tabIBom = new System.Windows.Forms.TabPage();
			this.ucAsset_IBOM1 = new SDB.UserControls.Asset.ucAsset_IBOM();
			this.tabAssignedTechs = new System.Windows.Forms.TabPage();
			this.olvAssignedTechs = new BrightIdeasSoftware.ObjectListView();
			this.olvColTechPriority = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTechName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTechAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.colColTechCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTechState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTechTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTechStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlAssignedTechs_Control = new System.Windows.Forms.Panel();
			this.btnAssignedTechs_MoveUp = new System.Windows.Forms.Button();
			this.btnAssignedTechs_Cancel = new System.Windows.Forms.Button();
			this.btnAssignedTechs_Save = new System.Windows.Forms.Button();
			this.btnAssignedTechs_Assign = new System.Windows.Forms.Button();
			this.tabSpareParts = new System.Windows.Forms.TabPage();
			this.ucAssetSpareParts1 = new SDB.UserControls.Asset.ucAssetSpareParts();
			this.tabSystemBackups = new System.Windows.Forms.TabPage();
			this.ucAssetSystemBackup1 = new SDB.UserControls.Asset.ucAssetSystemBackup();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.cmbAsset_CabinetType = new System.Windows.Forms.ComboBox();
			this.cmbAsset_OutputMethod = new System.Windows.Forms.ComboBox();
			this.chkIndoor = new System.Windows.Forms.CheckBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnAsset_ViewLatLongMap = new System.Windows.Forms.Button();
			this.txtAsset_CustomerTag = new System.Windows.Forms.TextBox();
			this.txtAsset_AssignedSsr = new System.Windows.Forms.TextBox();
			this.cmbAsset_ControllerHardware = new System.Windows.Forms.ComboBox();
			this.cmbAsset_ControllerSoftware = new System.Windows.Forms.ComboBox();
			this.cmbAsset_ControllerConnection = new System.Windows.Forms.ComboBox();
			this.cmbAsset_LiftType = new System.Windows.Forms.ComboBox();
			this.lblAccessNotes = new System.Windows.Forms.Label();
			this.cmbAsset_ClientConnection = new System.Windows.Forms.ComboBox();
			this.numAsset_FaceQty = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_MatrixY = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_MatrixX = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_Pitch = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_HAGL = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_InterfaceQty = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numAsset_LiftHeight = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.ndtpAsset_InstallDateTime = new SDB.Classes.Misc.NullableDateTimePicker();
			this.ndtpAsset_ShippedDateTime = new SDB.Classes.Misc.NullableDateTimePicker();
			this.cmbChipType = new System.Windows.Forms.ComboBox();
			this.cmbInterfaceType = new System.Windows.Forms.ComboBox();
			this.cmbPlayerSoftware = new System.Windows.Forms.ComboBox();
			this.pnlPhysical = new System.Windows.Forms.Panel();
			this.lblPlayerSoftware = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAsset_ControllerConnection = new System.Windows.Forms.Label();
			this.lblAsset_ControllerSoftware = new System.Windows.Forms.Label();
			this.lblAsset_ControllerHardware = new System.Windows.Forms.Label();
			this.lblOutputType = new System.Windows.Forms.Label();
			this.lblInterfaceQty = new System.Windows.Forms.Label();
			this.lblAsset_FaceQty = new System.Windows.Forms.Label();
			this.lblMatrixX = new System.Windows.Forms.Label();
			this.lblAsset_SharesLocation = new System.Windows.Forms.Label();
			this.pnlOwnershipInformation = new System.Windows.Forms.Panel();
			this.cbxIsPMC = new System.Windows.Forms.CheckBox();
			this.chkManagedByMedia = new System.Windows.Forms.CheckBox();
			this.lblAsset_AssignedSsr = new System.Windows.Forms.Label();
			this.lblAsset_CustomerTag = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblOwnershipInformation = new System.Windows.Forms.Label();
			this.ucWarrantyStatus1 = new SDB.UserControls.Asset.WarrantyStatus();
			this.pnlGeographic = new System.Windows.Forms.Panel();
			this.lblLongitude = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblFacing = new System.Windows.Forms.Label();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.assetLinker1 = new SDB.UserControls.Asset.AssetLinker();
			this.tabPhysGeo = new System.Windows.Forms.TabControl();
			this.tabPhysical = new System.Windows.Forms.TabPage();
			this.tabGeograpic = new System.Windows.Forms.TabPage();
			this.tabAccess = new System.Windows.Forms.TabPage();
			this.txtAccessNotes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAsset_LiftType = new System.Windows.Forms.Label();
			pbMonitoring_PVMLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(pbMonitoring_PVMLogo)).BeginInit();
			this.pnlControl_Bottom.SuspendLayout();
			this.pnlControl_Top.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.pnlAdditional.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabNotes.SuspendLayout();
			this.pnlGeneralNotes.SuspendLayout();
			this.tabTicketHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvTicketHistory)).BeginInit();
			this.pnlTicketHistory_Control.SuspendLayout();
			this.tabNetwork.SuspendLayout();
			this.pnlNetwork.SuspendLayout();
			this.pnlCradlepoint.SuspendLayout();
			this.pnlNetwork_System.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_SystemPort)).BeginInit();
			this.pnlNetwork_Player.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_PlayerPort)).BeginInit();
			this.pnlNetwork_Remote.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_RemoteVncWebPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_RemoteVncPort)).BeginInit();
			this.pnlNetwork_MiniGoose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_MiniGoosePort)).BeginInit();
			this.pnlNetwork_IBoot.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_IBootPort)).BeginInit();
			this.pnlNetwork_Camera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_CameraPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_CameraChannel)).BeginInit();
			this.pnlNetwork_Server.SuspendLayout();
			this.tabRMA.SuspendLayout();
			this.tabDocuments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvDocuments)).BeginInit();
			this.pnlDocumentsControl.SuspendLayout();
			this.tabMonitoring.SuspendLayout();
			this.pnlMonitoringControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_CameraCheckInterval)).BeginInit();
			this.pnlMonitoring_WebcamMode.SuspendLayout();
			this.pnlMonitoring_DataMode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_HoldTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_Interval)).BeginInit();
			this.tabShipments.SuspendLayout();
			this.tabJournal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
			this.pnlJournal_Control.SuspendLayout();
			this.tabIBom.SuspendLayout();
			this.tabAssignedTechs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvAssignedTechs)).BeginInit();
			this.pnlAssignedTechs_Control.SuspendLayout();
			this.tabSpareParts.SuspendLayout();
			this.tabSystemBackups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_FaceQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_MatrixY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_MatrixX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_Pitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_HAGL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_InterfaceQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_LiftHeight)).BeginInit();
			this.pnlPhysical.SuspendLayout();
			this.pnlOwnershipInformation.SuspendLayout();
			this.pnlGeographic.SuspendLayout();
			this.tabPhysGeo.SuspendLayout();
			this.tabPhysical.SuspendLayout();
			this.tabGeograpic.SuspendLayout();
			this.tabAccess.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbMonitoring_PVMLogo
			// 
			pbMonitoring_PVMLogo.Image = global::SDB.Properties.Resources.pvm3logo_32x32;
			pbMonitoring_PVMLogo.Location = new System.Drawing.Point(3, 20);
			pbMonitoring_PVMLogo.Name = "pbMonitoring_PVMLogo";
			pbMonitoring_PVMLogo.Size = new System.Drawing.Size(32, 32);
			pbMonitoring_PVMLogo.TabIndex = 10;
			pbMonitoring_PVMLogo.TabStop = false;
			// 
			// pnlControl_Bottom
			// 
			this.pnlControl_Bottom.BackColor = System.Drawing.Color.Silver;
			this.pnlControl_Bottom.Controls.Add(this.btnTeamViewer);
			this.pnlControl_Bottom.Controls.Add(this.btnVNC);
			this.pnlControl_Bottom.Controls.Add(this.btnDashboard);
			this.pnlControl_Bottom.Controls.Add(this.btnNext);
			this.pnlControl_Bottom.Controls.Add(this.btnPrevious);
			this.pnlControl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlControl_Bottom.Location = new System.Drawing.Point(0, 637);
			this.pnlControl_Bottom.Name = "pnlControl_Bottom";
			this.pnlControl_Bottom.Size = new System.Drawing.Size(839, 30);
			this.pnlControl_Bottom.TabIndex = 4;
			// 
			// btnTeamViewer
			// 
			this.btnTeamViewer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTeamViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnTeamViewer.Enabled = false;
			this.btnTeamViewer.Image = global::SDB.Properties.Resources.teamviewer_icon_16x16;
			this.btnTeamViewer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTeamViewer.Location = new System.Drawing.Point(487, 2);
			this.btnTeamViewer.Name = "btnTeamViewer";
			this.btnTeamViewer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.btnTeamViewer.Size = new System.Drawing.Size(120, 27);
			this.btnTeamViewer.TabIndex = 53;
			this.btnTeamViewer.Text = "TeamViewer";
			this.btnTeamViewer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTeamViewer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnTeamViewer, "Connect to the asset using TeamViewer (if applicable).");
			this.btnTeamViewer.UseVisualStyleBackColor = true;
			this.btnTeamViewer.Click += new System.EventHandler(this.btnTeamViewer_Click);
			// 
			// btnVNC
			// 
			this.btnVNC.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnVNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnVNC.Enabled = false;
			this.btnVNC.Image = global::SDB.Properties.Resources.vnc_icon_16x16;
			this.btnVNC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVNC.Location = new System.Drawing.Point(359, 2);
			this.btnVNC.Name = "btnVNC";
			this.btnVNC.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.btnVNC.Size = new System.Drawing.Size(120, 27);
			this.btnVNC.TabIndex = 52;
			this.btnVNC.Text = "VNC";
			this.btnVNC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnVNC, "Connect to the asset using VNC (if applicable).");
			this.btnVNC.UseVisualStyleBackColor = true;
			this.btnVNC.Click += new System.EventHandler(this.btnVNC_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDashboard.Image = global::SDB.Properties.Resources.program_icon_16x16;
			this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDashboard.Location = new System.Drawing.Point(231, 2);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.btnDashboard.Size = new System.Drawing.Size(120, 27);
			this.btnDashboard.TabIndex = 2;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.btnDashboard, "Launch Dashboard with the current asset selected in the default browser.");
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(674, 3);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = ">";
			this.toolTip.SetToolTip(this.btnNext, "Next asset (alphabetically by name).");
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(90, 3);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(75, 23);
			this.btnPrevious.TabIndex = 0;
			this.btnPrevious.Text = "<";
			this.toolTip.SetToolTip(this.btnPrevious, "Previous asset (alphabetically by name).");
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// pnlControl_Top
			// 
			this.pnlControl_Top.BackColor = System.Drawing.Color.LightBlue;
			this.pnlControl_Top.Controls.Add(this.toolStrip1);
			this.pnlControl_Top.Controls.Add(this.chkSubscribe);
			this.pnlControl_Top.Controls.Add(this.btnCancel);
			this.pnlControl_Top.Controls.Add(this.btnEditSave);
			this.pnlControl_Top.Controls.Add(this.txtSearch);
			this.pnlControl_Top.Controls.Add(this.btnSearch);
			this.pnlControl_Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl_Top.Location = new System.Drawing.Point(0, 0);
			this.pnlControl_Top.Name = "pnlControl_Top";
			this.pnlControl_Top.Size = new System.Drawing.Size(839, 30);
			this.pnlControl_Top.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(317, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(94, 22);
			this.toolStrip1.TabIndex = 7;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNew,
            this.mnuRetire,
            this.mnuDelete});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(93, 19);
			this.toolStripDropDownButton1.Text = "Asset Options";
			// 
			// mnuAddNew
			// 
			this.mnuAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.mnuAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuAddNew.Name = "mnuAddNew";
			this.mnuAddNew.ShowShortcutKeys = false;
			this.mnuAddNew.Size = new System.Drawing.Size(147, 22);
			this.mnuAddNew.Text = "Add New Asset";
			this.mnuAddNew.ToolTipText = "Add a new asset to the database.";
			this.mnuAddNew.Click += new System.EventHandler(this.mnuAddNew_Click);
			// 
			// mnuRetire
			// 
			this.mnuRetire.BackColor = System.Drawing.Color.Silver;
			this.mnuRetire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuRetire.Name = "mnuRetire";
			this.mnuRetire.ShowShortcutKeys = false;
			this.mnuRetire.Size = new System.Drawing.Size(147, 22);
			this.mnuRetire.Text = "Retire Asset";
			this.mnuRetire.ToolTipText = "Retires the asset.\r\nThe asset cannot be used for new tickets, RMAs, or shipments," +
    " but remains in the system for historical reasons.";
			this.mnuRetire.Click += new System.EventHandler(this.mnuRetire_Click);
			// 
			// mnuDelete
			// 
			this.mnuDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.mnuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuDelete.Name = "mnuDelete";
			this.mnuDelete.ShowShortcutKeys = false;
			this.mnuDelete.Size = new System.Drawing.Size(147, 22);
			this.mnuDelete.Text = "Delete Asset";
			this.mnuDelete.ToolTipText = "Deletes the asset entirely.\r\nWill offer to merge with another asset if any items " +
    "are associated with the asset.\r\nYou cannot delete an asset with attached items (" +
    "tickets, RMAs, shipments).";
			this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
			// 
			// chkSubscribe
			// 
			this.chkSubscribe.AutoCheck = false;
			this.chkSubscribe.AutoSize = true;
			this.chkSubscribe.Location = new System.Drawing.Point(241, 7);
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
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(636, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEditSave
			// 
			this.btnEditSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditSave.Location = new System.Drawing.Point(739, 3);
			this.btnEditSave.Name = "btnEditSave";
			this.btnEditSave.Size = new System.Drawing.Size(97, 23);
			this.btnEditSave.TabIndex = 6;
			this.btnEditSave.Text = "Edit Asset";
			this.btnEditSave.UseVisualStyleBackColor = true;
			this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(3, 5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(151, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(160, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(3, 139);
			this.txtCountry.MaxLength = 40;
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.ReadOnly = true;
			this.txtCountry.Size = new System.Drawing.Size(165, 20);
			this.txtCountry.TabIndex = 13;
			this.toolTip.SetToolTip(this.txtCountry, "Country where this asset is located.");
			this.txtCountry.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAsset_Pitch
			// 
			this.lblAsset_Pitch.AutoSize = true;
			this.lblAsset_Pitch.Location = new System.Drawing.Point(181, 44);
			this.lblAsset_Pitch.Name = "lblAsset_Pitch";
			this.lblAsset_Pitch.Size = new System.Drawing.Size(56, 13);
			this.lblAsset_Pitch.TabIndex = 10;
			this.lblAsset_Pitch.Text = "Pitch (mm)";
			// 
			// cmbAsset_FacingDirection
			// 
			this.cmbAsset_FacingDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_FacingDirection.Enabled = false;
			this.cmbAsset_FacingDirection.FormattingEnabled = true;
			this.cmbAsset_FacingDirection.Items.AddRange(new object[] {
            "",
            "N",
            "NE",
            "E",
            "SE",
            "S",
            "SW",
            "W",
            "NW"});
			this.cmbAsset_FacingDirection.Location = new System.Drawing.Point(347, 21);
			this.cmbAsset_FacingDirection.Name = "cmbAsset_FacingDirection";
			this.cmbAsset_FacingDirection.Size = new System.Drawing.Size(49, 21);
			this.cmbAsset_FacingDirection.TabIndex = 3;
			this.toolTip.SetToolTip(this.cmbAsset_FacingDirection, "Direction sign is facing.\r\n(For multi-face signs, direction is of primary or firs" +
        "t face.)");
			// 
			// lblAsset_CabinetType
			// 
			this.lblAsset_CabinetType.AutoSize = true;
			this.lblAsset_CabinetType.Location = new System.Drawing.Point(3, 83);
			this.lblAsset_CabinetType.Name = "lblAsset_CabinetType";
			this.lblAsset_CabinetType.Size = new System.Drawing.Size(70, 13);
			this.lblAsset_CabinetType.TabIndex = 12;
			this.lblAsset_CabinetType.Text = "Cabinet Type";
			// 
			// lblAsset_ChipType
			// 
			this.lblAsset_ChipType.AutoSize = true;
			this.lblAsset_ChipType.Location = new System.Drawing.Point(181, 5);
			this.lblAsset_ChipType.Name = "lblAsset_ChipType";
			this.lblAsset_ChipType.Size = new System.Drawing.Size(55, 13);
			this.lblAsset_ChipType.TabIndex = 4;
			this.lblAsset_ChipType.Text = "Chip Type";
			// 
			// btnAsset_GeoCode
			// 
			this.btnAsset_GeoCode.AutoSize = true;
			this.btnAsset_GeoCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAsset_GeoCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsset_GeoCode.Location = new System.Drawing.Point(368, 141);
			this.btnAsset_GeoCode.Name = "btnAsset_GeoCode";
			this.btnAsset_GeoCode.Size = new System.Drawing.Size(20, 19);
			this.btnAsset_GeoCode.TabIndex = 19;
			this.btnAsset_GeoCode.Text = "A";
			this.toolTip.SetToolTip(this.btnAsset_GeoCode, "Attempt to auto-populate latitude and longitude.");
			this.btnAsset_GeoCode.UseVisualStyleBackColor = true;
			this.btnAsset_GeoCode.Visible = false;
			this.btnAsset_GeoCode.Click += new System.EventHandler(this.btnAsset_GeoCode_Click);
			// 
			// txtLongitude
			// 
			this.txtLongitude.Location = new System.Drawing.Point(260, 139);
			this.txtLongitude.MaxLength = 15;
			this.txtLongitude.Name = "txtLongitude";
			this.txtLongitude.ReadOnly = true;
			this.txtLongitude.Size = new System.Drawing.Size(80, 20);
			this.txtLongitude.TabIndex = 17;
			this.toolTip.SetToolTip(this.txtLongitude, "Longitude");
			this.txtLongitude.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtLongitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_NumbersOnly_KeyPress);
			// 
			// txtLatitude
			// 
			this.txtLatitude.Location = new System.Drawing.Point(174, 139);
			this.txtLatitude.MaxLength = 15;
			this.txtLatitude.Name = "txtLatitude";
			this.txtLatitude.ReadOnly = true;
			this.txtLatitude.Size = new System.Drawing.Size(80, 20);
			this.txtLatitude.TabIndex = 15;
			this.toolTip.SetToolTip(this.txtLatitude, "Latitude");
			this.txtLatitude.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_NumbersOnly_KeyPress);
			// 
			// lblLatitude
			// 
			this.lblLatitude.AutoSize = true;
			this.lblLatitude.Location = new System.Drawing.Point(171, 123);
			this.lblLatitude.Name = "lblLatitude";
			this.lblLatitude.Size = new System.Drawing.Size(45, 13);
			this.lblLatitude.TabIndex = 14;
			this.lblLatitude.Text = "Latitude";
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(233, 100);
			this.txtState.MaxLength = 3;
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(32, 20);
			this.txtState.TabIndex = 9;
			this.toolTip.SetToolTip(this.txtState, "State/Province where this asset is located.");
			this.txtState.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtAsset_SerialNumber
			// 
			this.txtAsset_SerialNumber.Location = new System.Drawing.Point(67, 121);
			this.txtAsset_SerialNumber.MaxLength = 40;
			this.txtAsset_SerialNumber.Name = "txtAsset_SerialNumber";
			this.txtAsset_SerialNumber.ReadOnly = true;
			this.txtAsset_SerialNumber.Size = new System.Drawing.Size(194, 20);
			this.txtAsset_SerialNumber.TabIndex = 11;
			this.toolTip.SetToolTip(this.txtAsset_SerialNumber, "Serial number of the display, found on the back of the cabinet.");
			this.txtAsset_SerialNumber.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(3, 22);
			this.txtLocation.MaxLength = 50;
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new System.Drawing.Size(338, 20);
			this.txtLocation.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtLocation, "Description of location where this asset is located.\r\n(Cross streets or customer-" +
        "specified description.)");
			this.txtLocation.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(3, 84);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(24, 13);
			this.lblCity.TabIndex = 6;
			this.lblCity.Text = "City";
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(3, 6);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(48, 13);
			this.lblLocation.TabIndex = 0;
			this.lblLocation.Text = "Location";
			// 
			// lblAsset_HAGL
			// 
			this.lblAsset_HAGL.AutoSize = true;
			this.lblAsset_HAGL.Location = new System.Drawing.Point(3, 123);
			this.lblAsset_HAGL.Name = "lblAsset_HAGL";
			this.lblAsset_HAGL.Size = new System.Drawing.Size(51, 13);
			this.lblAsset_HAGL.TabIndex = 28;
			this.lblAsset_HAGL.Text = "HAGL (ft)";
			// 
			// lblAsset_SerialNumber
			// 
			this.lblAsset_SerialNumber.AutoSize = true;
			this.lblAsset_SerialNumber.Location = new System.Drawing.Point(28, 124);
			this.lblAsset_SerialNumber.Name = "lblAsset_SerialNumber";
			this.lblAsset_SerialNumber.Size = new System.Drawing.Size(33, 13);
			this.lblAsset_SerialNumber.TabIndex = 10;
			this.lblAsset_SerialNumber.Text = "Serial";
			// 
			// lblMatrix
			// 
			this.lblMatrix.AutoSize = true;
			this.lblMatrix.Location = new System.Drawing.Point(3, 44);
			this.lblMatrix.Name = "lblMatrix";
			this.lblMatrix.Size = new System.Drawing.Size(62, 13);
			this.lblMatrix.TabIndex = 6;
			this.lblMatrix.Text = "Matrix WxH";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(3, 100);
			this.txtCity.MaxLength = 40;
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(224, 20);
			this.txtCity.TabIndex = 7;
			this.toolTip.SetToolTip(this.txtCity, "City where this asset is located.");
			this.txtCity.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblInterfaceType
			// 
			this.lblInterfaceType.AutoSize = true;
			this.lblInterfaceType.Location = new System.Drawing.Point(3, 5);
			this.lblInterfaceType.Name = "lblInterfaceType";
			this.lblInterfaceType.Size = new System.Drawing.Size(76, 13);
			this.lblInterfaceType.TabIndex = 0;
			this.lblInterfaceType.Text = "Interface Type";
			// 
			// btnAsset_SelectMarket
			// 
			this.btnAsset_SelectMarket.Location = new System.Drawing.Point(235, 49);
			this.btnAsset_SelectMarket.Name = "btnAsset_SelectMarket";
			this.btnAsset_SelectMarket.Size = new System.Drawing.Size(26, 23);
			this.btnAsset_SelectMarket.TabIndex = 5;
			this.btnAsset_SelectMarket.Text = "...";
			this.toolTip.SetToolTip(this.btnAsset_SelectMarket, "Select Customer and Market");
			this.btnAsset_SelectMarket.UseVisualStyleBackColor = true;
			this.btnAsset_SelectMarket.Visible = false;
			this.btnAsset_SelectMarket.Click += new System.EventHandler(this.btnAsset_SelectMarket_Click);
			// 
			// txtAsset_Release
			// 
			this.txtAsset_Release.Location = new System.Drawing.Point(283, 144);
			this.txtAsset_Release.MaxLength = 20;
			this.txtAsset_Release.Name = "txtAsset_Release";
			this.txtAsset_Release.ReadOnly = true;
			this.txtAsset_Release.Size = new System.Drawing.Size(123, 20);
			this.txtAsset_Release.TabIndex = 19;
			this.toolTip.SetToolTip(this.txtAsset_Release, "Production release number.");
			this.txtAsset_Release.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtAsset_AssetName
			// 
			this.txtAsset_AssetName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAsset_AssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAsset_AssetName.Location = new System.Drawing.Point(67, 20);
			this.txtAsset_AssetName.MaxLength = 20;
			this.txtAsset_AssetName.Name = "txtAsset_AssetName";
			this.txtAsset_AssetName.ReadOnly = true;
			this.txtAsset_AssetName.Size = new System.Drawing.Size(194, 26);
			this.txtAsset_AssetName.TabIndex = 2;
			this.toolTip.SetToolTip(this.txtAsset_AssetName, "Prismview-assigned asset name/number.");
			this.txtAsset_AssetName.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtAsset_Panel
			// 
			this.txtAsset_Panel.Location = new System.Drawing.Point(67, 97);
			this.txtAsset_Panel.MaxLength = 30;
			this.txtAsset_Panel.Name = "txtAsset_Panel";
			this.txtAsset_Panel.ReadOnly = true;
			this.txtAsset_Panel.Size = new System.Drawing.Size(194, 20);
			this.txtAsset_Panel.TabIndex = 9;
			this.toolTip.SetToolTip(this.txtAsset_Panel, "Customer-designated panel number for this asset.");
			this.txtAsset_Panel.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAsset_InstalledDateTime
			// 
			this.lblAsset_InstalledDateTime.AutoSize = true;
			this.lblAsset_InstalledDateTime.Location = new System.Drawing.Point(235, 183);
			this.lblAsset_InstalledDateTime.Name = "lblAsset_InstalledDateTime";
			this.lblAsset_InstalledDateTime.Size = new System.Drawing.Size(46, 13);
			this.lblAsset_InstalledDateTime.TabIndex = 22;
			this.lblAsset_InstalledDateTime.Text = "Installed";
			// 
			// lblAsset_ShippedDateTime
			// 
			this.lblAsset_ShippedDateTime.AutoSize = true;
			this.lblAsset_ShippedDateTime.Location = new System.Drawing.Point(235, 167);
			this.lblAsset_ShippedDateTime.Name = "lblAsset_ShippedDateTime";
			this.lblAsset_ShippedDateTime.Size = new System.Drawing.Size(46, 13);
			this.lblAsset_ShippedDateTime.TabIndex = 20;
			this.lblAsset_ShippedDateTime.Text = "Shipped";
			// 
			// lblAsset_Release
			// 
			this.lblAsset_Release.AutoSize = true;
			this.lblAsset_Release.Location = new System.Drawing.Point(232, 148);
			this.lblAsset_Release.Name = "lblAsset_Release";
			this.lblAsset_Release.Size = new System.Drawing.Size(46, 13);
			this.lblAsset_Release.TabIndex = 18;
			this.lblAsset_Release.Text = "Release";
			// 
			// lblAsset_Panel
			// 
			this.lblAsset_Panel.AutoSize = true;
			this.lblAsset_Panel.Location = new System.Drawing.Point(27, 100);
			this.lblAsset_Panel.Name = "lblAsset_Panel";
			this.lblAsset_Panel.Size = new System.Drawing.Size(34, 13);
			this.lblAsset_Panel.TabIndex = 8;
			this.lblAsset_Panel.Text = "Panel";
			// 
			// lblAsset_AssetName
			// 
			this.lblAsset_AssetName.AutoSize = true;
			this.lblAsset_AssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAsset_AssetName.Location = new System.Drawing.Point(14, 28);
			this.lblAsset_AssetName.Name = "lblAsset_AssetName";
			this.lblAsset_AssetName.Size = new System.Drawing.Size(47, 13);
			this.lblAsset_AssetName.TabIndex = 1;
			this.lblAsset_AssetName.Text = "ASSET";
			// 
			// txtAsset_Market
			// 
			this.txtAsset_Market.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtAsset_Market.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAsset_Market.Location = new System.Drawing.Point(67, 74);
			this.txtAsset_Market.MaxLength = 45;
			this.txtAsset_Market.Name = "txtAsset_Market";
			this.txtAsset_Market.ReadOnly = true;
			this.txtAsset_Market.Size = new System.Drawing.Size(194, 20);
			this.txtAsset_Market.TabIndex = 7;
			this.txtAsset_Market.Click += new System.EventHandler(this.txtAsset_Market_Click);
			this.txtAsset_Market.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAsset_Market
			// 
			this.lblAsset_Market.AutoSize = true;
			this.lblAsset_Market.Location = new System.Drawing.Point(21, 77);
			this.lblAsset_Market.Name = "lblAsset_Market";
			this.lblAsset_Market.Size = new System.Drawing.Size(40, 13);
			this.lblAsset_Market.TabIndex = 6;
			this.lblAsset_Market.Text = "Market";
			// 
			// txtAsset_Customer
			// 
			this.txtAsset_Customer.Location = new System.Drawing.Point(67, 51);
			this.txtAsset_Customer.MaxLength = 64;
			this.txtAsset_Customer.Name = "txtAsset_Customer";
			this.txtAsset_Customer.ReadOnly = true;
			this.txtAsset_Customer.Size = new System.Drawing.Size(161, 20);
			this.txtAsset_Customer.TabIndex = 4;
			this.txtAsset_Customer.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAsset_Customer
			// 
			this.lblAsset_Customer.AutoSize = true;
			this.lblAsset_Customer.Location = new System.Drawing.Point(10, 54);
			this.lblAsset_Customer.Name = "lblAsset_Customer";
			this.lblAsset_Customer.Size = new System.Drawing.Size(51, 13);
			this.lblAsset_Customer.TabIndex = 3;
			this.lblAsset_Customer.Text = "Customer";
			// 
			// pnlAdditional
			// 
			this.pnlAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAdditional.Controls.Add(this.tabControl);
			this.pnlAdditional.Location = new System.Drawing.Point(3, 297);
			this.pnlAdditional.Name = "pnlAdditional";
			this.pnlAdditional.Size = new System.Drawing.Size(833, 328);
			this.pnlAdditional.TabIndex = 3;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabNotes);
			this.tabControl.Controls.Add(this.tabTicketHistory);
			this.tabControl.Controls.Add(this.tabNetwork);
			this.tabControl.Controls.Add(this.tabRMA);
			this.tabControl.Controls.Add(this.tabDocuments);
			this.tabControl.Controls.Add(this.tabMonitoring);
			this.tabControl.Controls.Add(this.tabShipments);
			this.tabControl.Controls.Add(this.tabJournal);
			this.tabControl.Controls.Add(this.tabIBom);
			this.tabControl.Controls.Add(this.tabAssignedTechs);
			this.tabControl.Controls.Add(this.tabSpareParts);
			this.tabControl.Controls.Add(this.tabSystemBackups);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(833, 328);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabNotes
			// 
			this.tabNotes.Controls.Add(this.pnlGeneralNotes);
			this.tabNotes.Location = new System.Drawing.Point(4, 22);
			this.tabNotes.Name = "tabNotes";
			this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
			this.tabNotes.Size = new System.Drawing.Size(825, 302);
			this.tabNotes.TabIndex = 0;
			this.tabNotes.Text = "Notes";
			this.tabNotes.UseVisualStyleBackColor = true;
			// 
			// pnlGeneralNotes
			// 
			this.pnlGeneralNotes.Controls.Add(this.txtGeneralNotes);
			this.pnlGeneralNotes.Controls.Add(this.lblGeneralNotes);
			this.pnlGeneralNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGeneralNotes.Location = new System.Drawing.Point(3, 3);
			this.pnlGeneralNotes.Name = "pnlGeneralNotes";
			this.pnlGeneralNotes.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.pnlGeneralNotes.Size = new System.Drawing.Size(819, 296);
			this.pnlGeneralNotes.TabIndex = 7;
			// 
			// txtGeneralNotes
			// 
			this.txtGeneralNotes.AcceptsReturn = true;
			this.txtGeneralNotes.AcceptsTab = true;
			this.txtGeneralNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGeneralNotes.Location = new System.Drawing.Point(0, 13);
			this.txtGeneralNotes.MaxLength = 4096;
			this.txtGeneralNotes.Multiline = true;
			this.txtGeneralNotes.Name = "txtGeneralNotes";
			this.txtGeneralNotes.ReadOnly = true;
			this.txtGeneralNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtGeneralNotes.Size = new System.Drawing.Size(815, 283);
			this.txtGeneralNotes.TabIndex = 1;
			// 
			// lblGeneralNotes
			// 
			this.lblGeneralNotes.AutoSize = true;
			this.lblGeneralNotes.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblGeneralNotes.Location = new System.Drawing.Point(0, 0);
			this.lblGeneralNotes.Name = "lblGeneralNotes";
			this.lblGeneralNotes.Size = new System.Drawing.Size(104, 13);
			this.lblGeneralNotes.TabIndex = 0;
			this.lblGeneralNotes.Text = "General Asset Notes";
			this.toolTip.SetToolTip(this.lblGeneralNotes, "General notes about the asset for service department internal use.");
			// 
			// tabTicketHistory
			// 
			this.tabTicketHistory.Controls.Add(this.olvTicketHistory);
			this.tabTicketHistory.Controls.Add(this.pnlTicketHistory_Control);
			this.tabTicketHistory.Location = new System.Drawing.Point(4, 22);
			this.tabTicketHistory.Name = "tabTicketHistory";
			this.tabTicketHistory.Padding = new System.Windows.Forms.Padding(3);
			this.tabTicketHistory.Size = new System.Drawing.Size(825, 302);
			this.tabTicketHistory.TabIndex = 2;
			this.tabTicketHistory.Text = "Tickets";
			this.tabTicketHistory.UseVisualStyleBackColor = true;
			// 
			// olvTicketHistory
			// 
			this.olvTicketHistory.AllColumns.Add(this.olcTicketHistory_TicketID);
			this.olvTicketHistory.AllColumns.Add(this.olcTicketHistory_OpenDateTime);
			this.olvTicketHistory.AllColumns.Add(this.olcTicketHistory_IssueNum);
			this.olvTicketHistory.AllColumns.Add(this.olcTicketHistory_Symptoms);
			this.olvTicketHistory.AllColumns.Add(this.olcTicketHistory_Solutions);
			this.olvTicketHistory.AllowColumnReorder = true;
			this.olvTicketHistory.CellEditUseWholeCell = false;
			this.olvTicketHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcTicketHistory_TicketID,
            this.olcTicketHistory_OpenDateTime,
            this.olcTicketHistory_IssueNum,
            this.olcTicketHistory_Symptoms,
            this.olcTicketHistory_Solutions});
			this.olvTicketHistory.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvTicketHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvTicketHistory.EmptyListMsg = "No ticket history.";
			this.olvTicketHistory.FullRowSelect = true;
			this.olvTicketHistory.GridLines = true;
			this.olvTicketHistory.HasCollapsibleGroups = false;
			this.olvTicketHistory.HideSelection = false;
			this.olvTicketHistory.Location = new System.Drawing.Point(3, 33);
			this.olvTicketHistory.Name = "olvTicketHistory";
			this.olvTicketHistory.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvTicketHistory.ShowCommandMenuOnRightClick = true;
			this.olvTicketHistory.ShowGroups = false;
			this.olvTicketHistory.Size = new System.Drawing.Size(819, 266);
			this.olvTicketHistory.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.olvTicketHistory.TabIndex = 1;
			this.olvTicketHistory.UseCompatibleStateImageBehavior = false;
			this.olvTicketHistory.View = System.Windows.Forms.View.Details;
			this.olvTicketHistory.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvTicketHistory_FormatRow);
			this.olvTicketHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTicketHistory_MouseDoubleClick);
			// 
			// olcTicketHistory_TicketID
			// 
			this.olcTicketHistory_TicketID.AspectName = "ID";
			this.olcTicketHistory_TicketID.Groupable = false;
			this.olcTicketHistory_TicketID.IsEditable = false;
			this.olcTicketHistory_TicketID.Text = "#";
			this.olcTicketHistory_TicketID.Width = 50;
			// 
			// olcTicketHistory_OpenDateTime
			// 
			this.olcTicketHistory_OpenDateTime.AspectName = "OpenDateTime";
			this.olcTicketHistory_OpenDateTime.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcTicketHistory_OpenDateTime.IsEditable = false;
			this.olcTicketHistory_OpenDateTime.Text = "Date";
			this.olcTicketHistory_OpenDateTime.Width = 70;
			// 
			// olcTicketHistory_IssueNum
			// 
			this.olcTicketHistory_IssueNum.AspectName = "CustomerIssueNumber";
			this.olcTicketHistory_IssueNum.Groupable = false;
			this.olcTicketHistory_IssueNum.IsEditable = false;
			this.olcTicketHistory_IssueNum.Text = "Issue";
			this.olcTicketHistory_IssueNum.Width = 50;
			// 
			// olcTicketHistory_Symptoms
			// 
			this.olcTicketHistory_Symptoms.AspectName = "ExtraProperties.Symptoms";
			this.olcTicketHistory_Symptoms.IsEditable = false;
			this.olcTicketHistory_Symptoms.Text = "Symptom(s)";
			this.olcTicketHistory_Symptoms.Width = 300;
			// 
			// olcTicketHistory_Solutions
			// 
			this.olcTicketHistory_Solutions.AspectName = "ExtraProperties.Solutions";
			this.olcTicketHistory_Solutions.Text = "Solution(s)";
			this.olcTicketHistory_Solutions.Width = 300;
			// 
			// pnlTicketHistory_Control
			// 
			this.pnlTicketHistory_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlTicketHistory_Control.Controls.Add(this.btnSetServiceReminder);
			this.pnlTicketHistory_Control.Controls.Add(this.btnCreateTicket);
			this.pnlTicketHistory_Control.Controls.Add(this.lblTicketHistory_TicketQty);
			this.pnlTicketHistory_Control.Controls.Add(this.txtTicketHistory_TicketQty);
			this.pnlTicketHistory_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTicketHistory_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlTicketHistory_Control.Name = "pnlTicketHistory_Control";
			this.pnlTicketHistory_Control.Size = new System.Drawing.Size(819, 30);
			this.pnlTicketHistory_Control.TabIndex = 0;
			// 
			// btnSetServiceReminder
			// 
			this.btnSetServiceReminder.Location = new System.Drawing.Point(109, 3);
			this.btnSetServiceReminder.Name = "btnSetServiceReminder";
			this.btnSetServiceReminder.Size = new System.Drawing.Size(131, 23);
			this.btnSetServiceReminder.TabIndex = 1;
			this.btnSetServiceReminder.Text = "Set Service Reminder";
			this.toolTip.SetToolTip(this.btnSetServiceReminder, "Set service reminder that appears when a user opens a ticket for this asset.");
			this.btnSetServiceReminder.UseVisualStyleBackColor = true;
			this.btnSetServiceReminder.Click += new System.EventHandler(this.btnSetServiceReminder_Click);
			// 
			// btnCreateTicket
			// 
			this.btnCreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreateTicket.Location = new System.Drawing.Point(3, 3);
			this.btnCreateTicket.Name = "btnCreateTicket";
			this.btnCreateTicket.Size = new System.Drawing.Size(100, 23);
			this.btnCreateTicket.TabIndex = 0;
			this.btnCreateTicket.Text = "Create Ticket";
			this.toolTip.SetToolTip(this.btnCreateTicket, "Open a ticket for this asset.");
			this.btnCreateTicket.UseVisualStyleBackColor = false;
			this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
			// 
			// lblTicketHistory_TicketQty
			// 
			this.lblTicketHistory_TicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTicketHistory_TicketQty.AutoSize = true;
			this.lblTicketHistory_TicketQty.Location = new System.Drawing.Point(720, 9);
			this.lblTicketHistory_TicketQty.Name = "lblTicketHistory_TicketQty";
			this.lblTicketHistory_TicketQty.Size = new System.Drawing.Size(45, 13);
			this.lblTicketHistory_TicketQty.TabIndex = 2;
			this.lblTicketHistory_TicketQty.Text = "Tickets:";
			// 
			// txtTicketHistory_TicketQty
			// 
			this.txtTicketHistory_TicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTicketHistory_TicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTicketHistory_TicketQty.Location = new System.Drawing.Point(771, 4);
			this.txtTicketHistory_TicketQty.Name = "txtTicketHistory_TicketQty";
			this.txtTicketHistory_TicketQty.ReadOnly = true;
			this.txtTicketHistory_TicketQty.Size = new System.Drawing.Size(45, 22);
			this.txtTicketHistory_TicketQty.TabIndex = 3;
			this.txtTicketHistory_TicketQty.TabStop = false;
			this.txtTicketHistory_TicketQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tabNetwork
			// 
			this.tabNetwork.AutoScroll = true;
			this.tabNetwork.Controls.Add(this.pnlNetwork);
			this.tabNetwork.Location = new System.Drawing.Point(4, 22);
			this.tabNetwork.Name = "tabNetwork";
			this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
			this.tabNetwork.Size = new System.Drawing.Size(825, 302);
			this.tabNetwork.TabIndex = 3;
			this.tabNetwork.Text = "Network";
			this.toolTip.SetToolTip(this.tabNetwork, "Network Configuration");
			this.tabNetwork.UseVisualStyleBackColor = true;
			// 
			// pnlNetwork
			// 
			this.pnlNetwork.Controls.Add(this.pnlCradlepoint);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_System);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_Player);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_Remote);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_MiniGoose);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_IBoot);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_Camera);
			this.pnlNetwork.Controls.Add(this.pnlNetwork_Server);
			this.pnlNetwork.Controls.Add(this.lblNetwork_Installed);
			this.pnlNetwork.Controls.Add(this.txtNetwork_ISP);
			this.pnlNetwork.Controls.Add(this.lblNetwork_WAN);
			this.pnlNetwork.Controls.Add(this.chkNetwork_CameraInstalled);
			this.pnlNetwork.Controls.Add(this.chkNetwork_IBootInstalled);
			this.pnlNetwork.Controls.Add(this.chkNetwork_MiniGooseInstalled);
			this.pnlNetwork.Controls.Add(this.lblNetwork_Router);
			this.pnlNetwork.Controls.Add(this.txtNetwork_WAN);
			this.pnlNetwork.Controls.Add(this.lblNetwork_ISP);
			this.pnlNetwork.Controls.Add(this.txtNetwork_Router);
			this.pnlNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlNetwork.Location = new System.Drawing.Point(3, 3);
			this.pnlNetwork.Name = "pnlNetwork";
			this.pnlNetwork.Size = new System.Drawing.Size(819, 296);
			this.pnlNetwork.TabIndex = 0;
			// 
			// pnlCradlepoint
			// 
			this.pnlCradlepoint.BackColor = System.Drawing.Color.LightGray;
			this.pnlCradlepoint.Controls.Add(this.cbxIsCradlepoint);
			this.pnlCradlepoint.Controls.Add(this.tbxCradlepointEmail);
			this.pnlCradlepoint.Controls.Add(this.lblResetEmail);
			this.pnlCradlepoint.Controls.Add(this.tbxCradlepointMAC);
			this.pnlCradlepoint.Controls.Add(this.lblCpMAC);
			this.pnlCradlepoint.Controls.Add(this.lblCradlepoint);
			this.pnlCradlepoint.Location = new System.Drawing.Point(3, 83);
			this.pnlCradlepoint.Name = "pnlCradlepoint";
			this.pnlCradlepoint.Size = new System.Drawing.Size(300, 93);
			this.pnlCradlepoint.TabIndex = 19;
			// 
			// cbxIsCradlepoint
			// 
			this.cbxIsCradlepoint.AutoSize = true;
			this.cbxIsCradlepoint.Location = new System.Drawing.Point(79, 20);
			this.cbxIsCradlepoint.Name = "cbxIsCradlepoint";
			this.cbxIsCradlepoint.Size = new System.Drawing.Size(101, 17);
			this.cbxIsCradlepoint.TabIndex = 5;
			this.cbxIsCradlepoint.Text = "Has Cradlepoint";
			this.cbxIsCradlepoint.UseVisualStyleBackColor = true;
			// 
			// tbxCradlepointEmail
			// 
			this.tbxCradlepointEmail.Location = new System.Drawing.Point(79, 66);
			this.tbxCradlepointEmail.Name = "tbxCradlepointEmail";
			this.tbxCradlepointEmail.ReadOnly = true;
			this.tbxCradlepointEmail.Size = new System.Drawing.Size(213, 20);
			this.tbxCradlepointEmail.TabIndex = 4;
			// 
			// lblResetEmail
			// 
			this.lblResetEmail.AutoSize = true;
			this.lblResetEmail.Location = new System.Drawing.Point(7, 69);
			this.lblResetEmail.Name = "lblResetEmail";
			this.lblResetEmail.Size = new System.Drawing.Size(66, 13);
			this.lblResetEmail.TabIndex = 3;
			this.lblResetEmail.Text = "Reset Email:";
			// 
			// tbxCradlepointMAC
			// 
			this.tbxCradlepointMAC.Location = new System.Drawing.Point(79, 42);
			this.tbxCradlepointMAC.Name = "tbxCradlepointMAC";
			this.tbxCradlepointMAC.ReadOnly = true;
			this.tbxCradlepointMAC.Size = new System.Drawing.Size(213, 20);
			this.tbxCradlepointMAC.TabIndex = 2;
			// 
			// lblCpMAC
			// 
			this.lblCpMAC.AutoSize = true;
			this.lblCpMAC.Location = new System.Drawing.Point(15, 45);
			this.lblCpMAC.Name = "lblCpMAC";
			this.lblCpMAC.Size = new System.Drawing.Size(33, 13);
			this.lblCpMAC.TabIndex = 1;
			this.lblCpMAC.Text = "MAC:";
			// 
			// lblCradlepoint
			// 
			this.lblCradlepoint.AutoEllipsis = true;
			this.lblCradlepoint.BackColor = System.Drawing.Color.DimGray;
			this.lblCradlepoint.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCradlepoint.ForeColor = System.Drawing.Color.White;
			this.lblCradlepoint.Location = new System.Drawing.Point(0, 0);
			this.lblCradlepoint.Name = "lblCradlepoint";
			this.lblCradlepoint.Size = new System.Drawing.Size(300, 17);
			this.lblCradlepoint.TabIndex = 0;
			this.lblCradlepoint.Text = "CradlePoint Info";
			this.lblCradlepoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlNetwork_System
			// 
			this.pnlNetwork_System.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_System.Controls.Add(this.chkNetwork_SystemSsl);
			this.pnlNetwork_System.Controls.Add(this.txtNetwork_SystemPassword);
			this.pnlNetwork_System.Controls.Add(this.lblNetwork_SystemPassword);
			this.pnlNetwork_System.Controls.Add(this.lblNetwork_System);
			this.pnlNetwork_System.Controls.Add(this.numNetwork_SystemPort);
			this.pnlNetwork_System.Controls.Add(this.lblNetwork_SystemPort);
			this.pnlNetwork_System.Location = new System.Drawing.Point(307, 136);
			this.pnlNetwork_System.Name = "pnlNetwork_System";
			this.pnlNetwork_System.Size = new System.Drawing.Size(192, 72);
			this.pnlNetwork_System.TabIndex = 9;
			// 
			// chkNetwork_SystemSsl
			// 
			this.chkNetwork_SystemSsl.AutoSize = true;
			this.chkNetwork_SystemSsl.Checked = true;
			this.chkNetwork_SystemSsl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNetwork_SystemSsl.Location = new System.Drawing.Point(124, 22);
			this.chkNetwork_SystemSsl.Name = "chkNetwork_SystemSsl";
			this.chkNetwork_SystemSsl.Size = new System.Drawing.Size(46, 17);
			this.chkNetwork_SystemSsl.TabIndex = 2;
			this.chkNetwork_SystemSsl.Text = "SSL";
			this.toolTip.SetToolTip(this.chkNetwork_SystemSsl, "Use SSL (HTTPS)");
			this.chkNetwork_SystemSsl.UseVisualStyleBackColor = true;
			// 
			// txtNetwork_SystemPassword
			// 
			this.txtNetwork_SystemPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_SystemPassword.Location = new System.Drawing.Point(63, 45);
			this.txtNetwork_SystemPassword.MaxLength = 16;
			this.txtNetwork_SystemPassword.Name = "txtNetwork_SystemPassword";
			this.txtNetwork_SystemPassword.ReadOnly = true;
			this.txtNetwork_SystemPassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_SystemPassword.TabIndex = 4;
			this.toolTip.SetToolTip(this.txtNetwork_SystemPassword, "Prismview System\'s password.");
			// 
			// lblNetwork_SystemPassword
			// 
			this.lblNetwork_SystemPassword.AutoSize = true;
			this.lblNetwork_SystemPassword.Location = new System.Drawing.Point(4, 47);
			this.lblNetwork_SystemPassword.Name = "lblNetwork_SystemPassword";
			this.lblNetwork_SystemPassword.Size = new System.Drawing.Size(53, 13);
			this.lblNetwork_SystemPassword.TabIndex = 3;
			this.lblNetwork_SystemPassword.Text = "Password";
			// 
			// lblNetwork_System
			// 
			this.lblNetwork_System.AutoEllipsis = true;
			this.lblNetwork_System.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_System.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_System.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_System.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_System.Name = "lblNetwork_System";
			this.lblNetwork_System.Size = new System.Drawing.Size(192, 17);
			this.lblNetwork_System.TabIndex = 0;
			this.lblNetwork_System.Text = "Prismview System";
			this.lblNetwork_System.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numNetwork_SystemPort
			// 
			this.numNetwork_SystemPort.Cursor = System.Windows.Forms.Cursors.Hand;
			this.numNetwork_SystemPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numNetwork_SystemPort.Location = new System.Drawing.Point(63, 20);
			this.numNetwork_SystemPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_SystemPort.Name = "numNetwork_SystemPort";
			this.numNetwork_SystemPort.ReadOnly = true;
			this.numNetwork_SystemPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_SystemPort.TabIndex = 1;
			this.toolTip.SetToolTip(this.numNetwork_SystemPort, "HTTP port of the PrismView System/Server. For example: 38381");
			this.numNetwork_SystemPort.Value = new decimal(new int[] {
            38381,
            0,
            0,
            0});
			this.numNetwork_SystemPort.Click += new System.EventHandler(this.numNetwork_ServerPort_Click);
			this.numNetwork_SystemPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_SystemPort
			// 
			this.lblNetwork_SystemPort.AutoSize = true;
			this.lblNetwork_SystemPort.Location = new System.Drawing.Point(31, 23);
			this.lblNetwork_SystemPort.Name = "lblNetwork_SystemPort";
			this.lblNetwork_SystemPort.Size = new System.Drawing.Size(26, 13);
			this.lblNetwork_SystemPort.TabIndex = 0;
			this.lblNetwork_SystemPort.Text = "Port";
			// 
			// pnlNetwork_Player
			// 
			this.pnlNetwork_Player.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_Player.Controls.Add(this.chkNetwork_PlayerSsl);
			this.pnlNetwork_Player.Controls.Add(this.txtNetwork_PlayerPassword);
			this.pnlNetwork_Player.Controls.Add(this.lblNetwork_PlayerPassword);
			this.pnlNetwork_Player.Controls.Add(this.lblNetwork_PlayerPort);
			this.pnlNetwork_Player.Controls.Add(this.numNetwork_PlayerPort);
			this.pnlNetwork_Player.Controls.Add(this.lblNetwork_Player);
			this.pnlNetwork_Player.Location = new System.Drawing.Point(307, 215);
			this.pnlNetwork_Player.Name = "pnlNetwork_Player";
			this.pnlNetwork_Player.Size = new System.Drawing.Size(188, 76);
			this.pnlNetwork_Player.TabIndex = 10;
			// 
			// chkNetwork_PlayerSsl
			// 
			this.chkNetwork_PlayerSsl.AutoSize = true;
			this.chkNetwork_PlayerSsl.Checked = true;
			this.chkNetwork_PlayerSsl.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNetwork_PlayerSsl.Location = new System.Drawing.Point(124, 20);
			this.chkNetwork_PlayerSsl.Name = "chkNetwork_PlayerSsl";
			this.chkNetwork_PlayerSsl.Size = new System.Drawing.Size(46, 17);
			this.chkNetwork_PlayerSsl.TabIndex = 2;
			this.chkNetwork_PlayerSsl.Text = "SSL";
			this.toolTip.SetToolTip(this.chkNetwork_PlayerSsl, "Use SSL (HTTPS)");
			this.chkNetwork_PlayerSsl.UseVisualStyleBackColor = true;
			// 
			// txtNetwork_PlayerPassword
			// 
			this.txtNetwork_PlayerPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_PlayerPassword.Location = new System.Drawing.Point(63, 43);
			this.txtNetwork_PlayerPassword.MaxLength = 16;
			this.txtNetwork_PlayerPassword.Name = "txtNetwork_PlayerPassword";
			this.txtNetwork_PlayerPassword.ReadOnly = true;
			this.txtNetwork_PlayerPassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_PlayerPassword.TabIndex = 4;
			this.toolTip.SetToolTip(this.txtNetwork_PlayerPassword, "Prismview Player\'s password.");
			this.txtNetwork_PlayerPassword.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_PlayerPassword
			// 
			this.lblNetwork_PlayerPassword.AutoSize = true;
			this.lblNetwork_PlayerPassword.Location = new System.Drawing.Point(4, 45);
			this.lblNetwork_PlayerPassword.Name = "lblNetwork_PlayerPassword";
			this.lblNetwork_PlayerPassword.Size = new System.Drawing.Size(53, 13);
			this.lblNetwork_PlayerPassword.TabIndex = 3;
			this.lblNetwork_PlayerPassword.Text = "Password";
			// 
			// lblNetwork_PlayerPort
			// 
			this.lblNetwork_PlayerPort.AutoSize = true;
			this.lblNetwork_PlayerPort.Location = new System.Drawing.Point(31, 21);
			this.lblNetwork_PlayerPort.Name = "lblNetwork_PlayerPort";
			this.lblNetwork_PlayerPort.Size = new System.Drawing.Size(26, 13);
			this.lblNetwork_PlayerPort.TabIndex = 0;
			this.lblNetwork_PlayerPort.Text = "Port";
			// 
			// numNetwork_PlayerPort
			// 
			this.numNetwork_PlayerPort.Location = new System.Drawing.Point(63, 19);
			this.numNetwork_PlayerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_PlayerPort.Name = "numNetwork_PlayerPort";
			this.numNetwork_PlayerPort.ReadOnly = true;
			this.numNetwork_PlayerPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_PlayerPort.TabIndex = 1;
			this.toolTip.SetToolTip(this.numNetwork_PlayerPort, "Prismview Player HTTP port, for example, 38382.");
			this.numNetwork_PlayerPort.Value = new decimal(new int[] {
            38382,
            0,
            0,
            0});
			this.numNetwork_PlayerPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_Player
			// 
			this.lblNetwork_Player.AutoEllipsis = true;
			this.lblNetwork_Player.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_Player.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_Player.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_Player.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_Player.Name = "lblNetwork_Player";
			this.lblNetwork_Player.Size = new System.Drawing.Size(188, 17);
			this.lblNetwork_Player.TabIndex = 0;
			this.lblNetwork_Player.Text = "Prismview Player";
			this.lblNetwork_Player.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlNetwork_Remote
			// 
			this.pnlNetwork_Remote.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_Remote.Controls.Add(this.cbxUseRealVNC);
			this.pnlNetwork_Remote.Controls.Add(this.txtNetwork_TeamviewerPassword);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_TeamviewerPassword);
			this.pnlNetwork_Remote.Controls.Add(this.numNetwork_RemoteVncWebPort);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_TeamviewerID);
			this.pnlNetwork_Remote.Controls.Add(this.txtNetwork_TeamviewerID);
			this.pnlNetwork_Remote.Controls.Add(this.numNetwork_RemoteVncPort);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_Remote);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_RemoteVncPort);
			this.pnlNetwork_Remote.Controls.Add(this.txtNetwork_RemoteVncPassword);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_RemoteVncPassword);
			this.pnlNetwork_Remote.Controls.Add(this.lblNetwork_RemoteVncWebPort);
			this.pnlNetwork_Remote.Location = new System.Drawing.Point(4, 179);
			this.pnlNetwork_Remote.Name = "pnlNetwork_Remote";
			this.pnlNetwork_Remote.Size = new System.Drawing.Size(300, 112);
			this.pnlNetwork_Remote.TabIndex = 8;
			// 
			// cbxUseRealVNC
			// 
			this.cbxUseRealVNC.AutoSize = true;
			this.cbxUseRealVNC.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cbxUseRealVNC.Location = new System.Drawing.Point(206, 25);
			this.cbxUseRealVNC.Name = "cbxUseRealVNC";
			this.cbxUseRealVNC.Size = new System.Drawing.Size(80, 31);
			this.cbxUseRealVNC.TabIndex = 18;
			this.cbxUseRealVNC.Text = "Use Real VNC";
			this.cbxUseRealVNC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cbxUseRealVNC.UseVisualStyleBackColor = true;
			// 
			// txtNetwork_TeamviewerPassword
			// 
			this.txtNetwork_TeamviewerPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_TeamviewerPassword.Location = new System.Drawing.Point(5, 77);
			this.txtNetwork_TeamviewerPassword.MaxLength = 16;
			this.txtNetwork_TeamviewerPassword.Name = "txtNetwork_TeamviewerPassword";
			this.txtNetwork_TeamviewerPassword.ReadOnly = true;
			this.txtNetwork_TeamviewerPassword.Size = new System.Drawing.Size(112, 20);
			this.txtNetwork_TeamviewerPassword.TabIndex = 17;
			// 
			// lblNetwork_TeamviewerPassword
			// 
			this.lblNetwork_TeamviewerPassword.AutoSize = true;
			this.lblNetwork_TeamviewerPassword.Location = new System.Drawing.Point(3, 63);
			this.lblNetwork_TeamviewerPassword.Name = "lblNetwork_TeamviewerPassword";
			this.lblNetwork_TeamviewerPassword.Size = new System.Drawing.Size(114, 13);
			this.lblNetwork_TeamviewerPassword.TabIndex = 4;
			this.lblNetwork_TeamviewerPassword.Text = "Teamviewer Password";
			// 
			// numNetwork_RemoteVncWebPort
			// 
			this.numNetwork_RemoteVncWebPort.Cursor = System.Windows.Forms.Cursors.Hand;
			this.numNetwork_RemoteVncWebPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numNetwork_RemoteVncWebPort.Location = new System.Drawing.Point(126, 38);
			this.numNetwork_RemoteVncWebPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_RemoteVncWebPort.Name = "numNetwork_RemoteVncWebPort";
			this.numNetwork_RemoteVncWebPort.ReadOnly = true;
			this.numNetwork_RemoteVncWebPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_RemoteVncWebPort.TabIndex = 13;
			this.toolTip.SetToolTip(this.numNetwork_RemoteVncWebPort, "VNC port used by VNC server for web access using Java. For example: 5800.");
			this.numNetwork_RemoteVncWebPort.Value = new decimal(new int[] {
            5800,
            0,
            0,
            0});
			this.numNetwork_RemoteVncWebPort.Click += new System.EventHandler(this.numNetwork_ServerVNCWebPort_Click);
			this.numNetwork_RemoteVncWebPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_TeamviewerID
			// 
			this.lblNetwork_TeamviewerID.AutoSize = true;
			this.lblNetwork_TeamviewerID.Location = new System.Drawing.Point(3, 22);
			this.lblNetwork_TeamviewerID.Name = "lblNetwork_TeamviewerID";
			this.lblNetwork_TeamviewerID.Size = new System.Drawing.Size(79, 13);
			this.lblNetwork_TeamviewerID.TabIndex = 2;
			this.lblNetwork_TeamviewerID.Text = "Teamviewer ID";
			// 
			// txtNetwork_TeamviewerID
			// 
			this.txtNetwork_TeamviewerID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtNetwork_TeamviewerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_TeamviewerID.Location = new System.Drawing.Point(4, 36);
			this.txtNetwork_TeamviewerID.MaxLength = 10;
			this.txtNetwork_TeamviewerID.Name = "txtNetwork_TeamviewerID";
			this.txtNetwork_TeamviewerID.ReadOnly = true;
			this.txtNetwork_TeamviewerID.Size = new System.Drawing.Size(113, 20);
			this.txtNetwork_TeamviewerID.TabIndex = 3;
			this.txtNetwork_TeamviewerID.Click += new System.EventHandler(this.txtNetwork_TeamviewerID_Click);
			// 
			// numNetwork_RemoteVncPort
			// 
			this.numNetwork_RemoteVncPort.Cursor = System.Windows.Forms.Cursors.Hand;
			this.numNetwork_RemoteVncPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numNetwork_RemoteVncPort.Location = new System.Drawing.Point(126, 81);
			this.numNetwork_RemoteVncPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_RemoteVncPort.Name = "numNetwork_RemoteVncPort";
			this.numNetwork_RemoteVncPort.ReadOnly = true;
			this.numNetwork_RemoteVncPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_RemoteVncPort.TabIndex = 10;
			this.toolTip.SetToolTip(this.numNetwork_RemoteVncPort, "VNC port used by VNC server. For example: 5900.");
			this.numNetwork_RemoteVncPort.Value = new decimal(new int[] {
            5900,
            0,
            0,
            0});
			this.numNetwork_RemoteVncPort.Click += new System.EventHandler(this.numNetwork_ServerVNCPort_Click);
			this.numNetwork_RemoteVncPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_Remote
			// 
			this.lblNetwork_Remote.AutoEllipsis = true;
			this.lblNetwork_Remote.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_Remote.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_Remote.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_Remote.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_Remote.Name = "lblNetwork_Remote";
			this.lblNetwork_Remote.Size = new System.Drawing.Size(300, 17);
			this.lblNetwork_Remote.TabIndex = 0;
			this.lblNetwork_Remote.Text = "Remote Access";
			this.lblNetwork_Remote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNetwork_RemoteVncPort
			// 
			this.lblNetwork_RemoteVncPort.AutoSize = true;
			this.lblNetwork_RemoteVncPort.Location = new System.Drawing.Point(123, 65);
			this.lblNetwork_RemoteVncPort.Name = "lblNetwork_RemoteVncPort";
			this.lblNetwork_RemoteVncPort.Size = new System.Drawing.Size(51, 13);
			this.lblNetwork_RemoteVncPort.TabIndex = 9;
			this.lblNetwork_RemoteVncPort.Text = "VNC Port";
			// 
			// txtNetwork_RemoteVncPassword
			// 
			this.txtNetwork_RemoteVncPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_RemoteVncPassword.Location = new System.Drawing.Point(195, 81);
			this.txtNetwork_RemoteVncPassword.MaxLength = 16;
			this.txtNetwork_RemoteVncPassword.Name = "txtNetwork_RemoteVncPassword";
			this.txtNetwork_RemoteVncPassword.ReadOnly = true;
			this.txtNetwork_RemoteVncPassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_RemoteVncPassword.TabIndex = 16;
			this.toolTip.SetToolTip(this.txtNetwork_RemoteVncPassword, "Password to connect using VNC.");
			this.txtNetwork_RemoteVncPassword.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_RemoteVncPassword
			// 
			this.lblNetwork_RemoteVncPassword.AutoSize = true;
			this.lblNetwork_RemoteVncPassword.Location = new System.Drawing.Point(193, 65);
			this.lblNetwork_RemoteVncPassword.Name = "lblNetwork_RemoteVncPassword";
			this.lblNetwork_RemoteVncPassword.Size = new System.Drawing.Size(78, 13);
			this.lblNetwork_RemoteVncPassword.TabIndex = 15;
			this.lblNetwork_RemoteVncPassword.Text = "VNC Password";
			// 
			// lblNetwork_RemoteVncWebPort
			// 
			this.lblNetwork_RemoteVncWebPort.AutoSize = true;
			this.lblNetwork_RemoteVncWebPort.Location = new System.Drawing.Point(123, 22);
			this.lblNetwork_RemoteVncWebPort.Name = "lblNetwork_RemoteVncWebPort";
			this.lblNetwork_RemoteVncWebPort.Size = new System.Drawing.Size(77, 13);
			this.lblNetwork_RemoteVncWebPort.TabIndex = 12;
			this.lblNetwork_RemoteVncWebPort.Text = "VNC Web Port";
			// 
			// pnlNetwork_MiniGoose
			// 
			this.pnlNetwork_MiniGoose.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_MiniGoose.Controls.Add(this.numNetwork_MiniGoosePort);
			this.pnlNetwork_MiniGoose.Controls.Add(this.lblNetwork_MiniGoose);
			this.pnlNetwork_MiniGoose.Controls.Add(this.txtNetwork_MiniGooseLan);
			this.pnlNetwork_MiniGoose.Controls.Add(this.txtNetwork_MiniGoosePassword);
			this.pnlNetwork_MiniGoose.Controls.Add(this.lblNetwork_MiniGooseLan);
			this.pnlNetwork_MiniGoose.Controls.Add(this.lblNetwork_MiniGoosePassword);
			this.pnlNetwork_MiniGoose.Controls.Add(this.lblNetwork_MiniGoosePort);
			this.pnlNetwork_MiniGoose.Enabled = false;
			this.pnlNetwork_MiniGoose.Location = new System.Drawing.Point(504, 228);
			this.pnlNetwork_MiniGoose.Name = "pnlNetwork_MiniGoose";
			this.pnlNetwork_MiniGoose.Size = new System.Drawing.Size(310, 66);
			this.pnlNetwork_MiniGoose.TabIndex = 17;
			// 
			// numNetwork_MiniGoosePort
			// 
			this.numNetwork_MiniGoosePort.Location = new System.Drawing.Point(70, 43);
			this.numNetwork_MiniGoosePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_MiniGoosePort.Name = "numNetwork_MiniGoosePort";
			this.numNetwork_MiniGoosePort.ReadOnly = true;
			this.numNetwork_MiniGoosePort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_MiniGoosePort.TabIndex = 4;
			this.toolTip.SetToolTip(this.numNetwork_MiniGoosePort, "MiniGoose HTTP port number.");
			this.numNetwork_MiniGoosePort.Value = new decimal(new int[] {
            38385,
            0,
            0,
            0});
			this.numNetwork_MiniGoosePort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_MiniGoose
			// 
			this.lblNetwork_MiniGoose.AutoEllipsis = true;
			this.lblNetwork_MiniGoose.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_MiniGoose.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_MiniGoose.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_MiniGoose.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_MiniGoose.Name = "lblNetwork_MiniGoose";
			this.lblNetwork_MiniGoose.Size = new System.Drawing.Size(310, 17);
			this.lblNetwork_MiniGoose.TabIndex = 0;
			this.lblNetwork_MiniGoose.Text = "MiniGoose";
			this.lblNetwork_MiniGoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNetwork_MiniGooseLan
			// 
			this.txtNetwork_MiniGooseLan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtNetwork_MiniGooseLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_MiniGooseLan.Location = new System.Drawing.Point(70, 20);
			this.txtNetwork_MiniGooseLan.MaxLength = 15;
			this.txtNetwork_MiniGooseLan.Name = "txtNetwork_MiniGooseLan";
			this.txtNetwork_MiniGooseLan.ReadOnly = true;
			this.txtNetwork_MiniGooseLan.Size = new System.Drawing.Size(231, 20);
			this.txtNetwork_MiniGooseLan.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtNetwork_MiniGooseLan, "MiniGoose LAN IP address.");
			this.txtNetwork_MiniGooseLan.Click += new System.EventHandler(this.txtNetwork_MiniGooseLan_Click);
			this.txtNetwork_MiniGooseLan.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtNetwork_MiniGoosePassword
			// 
			this.txtNetwork_MiniGoosePassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_MiniGoosePassword.Location = new System.Drawing.Point(205, 43);
			this.txtNetwork_MiniGoosePassword.MaxLength = 16;
			this.txtNetwork_MiniGoosePassword.Name = "txtNetwork_MiniGoosePassword";
			this.txtNetwork_MiniGoosePassword.ReadOnly = true;
			this.txtNetwork_MiniGoosePassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_MiniGoosePassword.TabIndex = 6;
			this.toolTip.SetToolTip(this.txtNetwork_MiniGoosePassword, "Password to access MiniGoose administration.");
			this.txtNetwork_MiniGoosePassword.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_MiniGooseLan
			// 
			this.lblNetwork_MiniGooseLan.AutoSize = true;
			this.lblNetwork_MiniGooseLan.Location = new System.Drawing.Point(23, 23);
			this.lblNetwork_MiniGooseLan.Name = "lblNetwork_MiniGooseLan";
			this.lblNetwork_MiniGooseLan.Size = new System.Drawing.Size(41, 13);
			this.lblNetwork_MiniGooseLan.TabIndex = 0;
			this.lblNetwork_MiniGooseLan.Text = "LAN IP";
			// 
			// lblNetwork_MiniGoosePassword
			// 
			this.lblNetwork_MiniGoosePassword.AutoSize = true;
			this.lblNetwork_MiniGoosePassword.Location = new System.Drawing.Point(146, 45);
			this.lblNetwork_MiniGoosePassword.Name = "lblNetwork_MiniGoosePassword";
			this.lblNetwork_MiniGoosePassword.Size = new System.Drawing.Size(53, 13);
			this.lblNetwork_MiniGoosePassword.TabIndex = 5;
			this.lblNetwork_MiniGoosePassword.Text = "Password";
			// 
			// lblNetwork_MiniGoosePort
			// 
			this.lblNetwork_MiniGoosePort.AutoSize = true;
			this.lblNetwork_MiniGoosePort.Location = new System.Drawing.Point(6, 45);
			this.lblNetwork_MiniGoosePort.Name = "lblNetwork_MiniGoosePort";
			this.lblNetwork_MiniGoosePort.Size = new System.Drawing.Size(58, 13);
			this.lblNetwork_MiniGoosePort.TabIndex = 3;
			this.lblNetwork_MiniGoosePort.Text = "HTTP Port";
			// 
			// pnlNetwork_IBoot
			// 
			this.pnlNetwork_IBoot.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_IBoot.Controls.Add(this.numNetwork_IBootPort);
			this.pnlNetwork_IBoot.Controls.Add(this.lblNetwork_IBoot);
			this.pnlNetwork_IBoot.Controls.Add(this.txtNetwork_IBootLan);
			this.pnlNetwork_IBoot.Controls.Add(this.txtNetwork_IBootPassword);
			this.pnlNetwork_IBoot.Controls.Add(this.lblNetwork_IBootLan);
			this.pnlNetwork_IBoot.Controls.Add(this.lblNetwork_IBootPassword);
			this.pnlNetwork_IBoot.Controls.Add(this.lblNetwork_IBootPort);
			this.pnlNetwork_IBoot.Enabled = false;
			this.pnlNetwork_IBoot.Location = new System.Drawing.Point(504, 159);
			this.pnlNetwork_IBoot.Name = "pnlNetwork_IBoot";
			this.pnlNetwork_IBoot.Size = new System.Drawing.Size(310, 66);
			this.pnlNetwork_IBoot.TabIndex = 16;
			// 
			// numNetwork_IBootPort
			// 
			this.numNetwork_IBootPort.Location = new System.Drawing.Point(70, 43);
			this.numNetwork_IBootPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_IBootPort.Name = "numNetwork_IBootPort";
			this.numNetwork_IBootPort.ReadOnly = true;
			this.numNetwork_IBootPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_IBootPort.TabIndex = 4;
			this.toolTip.SetToolTip(this.numNetwork_IBootPort, "IBoot HTTP port number.");
			this.numNetwork_IBootPort.Value = new decimal(new int[] {
            38384,
            0,
            0,
            0});
			this.numNetwork_IBootPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_IBoot
			// 
			this.lblNetwork_IBoot.AutoEllipsis = true;
			this.lblNetwork_IBoot.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_IBoot.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_IBoot.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_IBoot.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_IBoot.Name = "lblNetwork_IBoot";
			this.lblNetwork_IBoot.Size = new System.Drawing.Size(310, 17);
			this.lblNetwork_IBoot.TabIndex = 0;
			this.lblNetwork_IBoot.Text = "IBoot";
			this.lblNetwork_IBoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNetwork_IBootLan
			// 
			this.txtNetwork_IBootLan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtNetwork_IBootLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_IBootLan.Location = new System.Drawing.Point(70, 20);
			this.txtNetwork_IBootLan.MaxLength = 15;
			this.txtNetwork_IBootLan.Name = "txtNetwork_IBootLan";
			this.txtNetwork_IBootLan.ReadOnly = true;
			this.txtNetwork_IBootLan.Size = new System.Drawing.Size(231, 20);
			this.txtNetwork_IBootLan.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtNetwork_IBootLan, "IBoot LAN IP address.");
			this.txtNetwork_IBootLan.Click += new System.EventHandler(this.txtNetwork_IBootLan_Click);
			this.txtNetwork_IBootLan.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtNetwork_IBootPassword
			// 
			this.txtNetwork_IBootPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_IBootPassword.Location = new System.Drawing.Point(205, 43);
			this.txtNetwork_IBootPassword.MaxLength = 16;
			this.txtNetwork_IBootPassword.Name = "txtNetwork_IBootPassword";
			this.txtNetwork_IBootPassword.ReadOnly = true;
			this.txtNetwork_IBootPassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_IBootPassword.TabIndex = 6;
			this.toolTip.SetToolTip(this.txtNetwork_IBootPassword, "Password to access IBoot administration.");
			this.txtNetwork_IBootPassword.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_IBootLan
			// 
			this.lblNetwork_IBootLan.AutoSize = true;
			this.lblNetwork_IBootLan.Location = new System.Drawing.Point(23, 23);
			this.lblNetwork_IBootLan.Name = "lblNetwork_IBootLan";
			this.lblNetwork_IBootLan.Size = new System.Drawing.Size(41, 13);
			this.lblNetwork_IBootLan.TabIndex = 0;
			this.lblNetwork_IBootLan.Text = "LAN IP";
			// 
			// lblNetwork_IBootPassword
			// 
			this.lblNetwork_IBootPassword.AutoSize = true;
			this.lblNetwork_IBootPassword.Location = new System.Drawing.Point(146, 45);
			this.lblNetwork_IBootPassword.Name = "lblNetwork_IBootPassword";
			this.lblNetwork_IBootPassword.Size = new System.Drawing.Size(53, 13);
			this.lblNetwork_IBootPassword.TabIndex = 5;
			this.lblNetwork_IBootPassword.Text = "Password";
			// 
			// lblNetwork_IBootPort
			// 
			this.lblNetwork_IBootPort.AutoSize = true;
			this.lblNetwork_IBootPort.Location = new System.Drawing.Point(6, 45);
			this.lblNetwork_IBootPort.Name = "lblNetwork_IBootPort";
			this.lblNetwork_IBootPort.Size = new System.Drawing.Size(58, 13);
			this.lblNetwork_IBootPort.TabIndex = 3;
			this.lblNetwork_IBootPort.Text = "HTTP Port";
			// 
			// pnlNetwork_Camera
			// 
			this.pnlNetwork_Camera.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraAssembly);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_Camera);
			this.pnlNetwork_Camera.Controls.Add(this.txtNetwork_WebcamTypeAssemblyDesc);
			this.pnlNetwork_Camera.Controls.Add(this.cmbNetwork_WebcamType);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraLan);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraTypeImage);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraPort);
			this.pnlNetwork_Camera.Controls.Add(this.numNetwork_CameraPort);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraChannel);
			this.pnlNetwork_Camera.Controls.Add(this.txtNetwork_CameraUser);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraPassword);
			this.pnlNetwork_Camera.Controls.Add(this.lblNetwork_CameraUser);
			this.pnlNetwork_Camera.Controls.Add(this.txtNetwork_CameraPassword);
			this.pnlNetwork_Camera.Controls.Add(this.numNetwork_CameraChannel);
			this.pnlNetwork_Camera.Controls.Add(this.txtNetwork_CameraLan);
			this.pnlNetwork_Camera.Enabled = false;
			this.pnlNetwork_Camera.Location = new System.Drawing.Point(504, 20);
			this.pnlNetwork_Camera.Name = "pnlNetwork_Camera";
			this.pnlNetwork_Camera.Size = new System.Drawing.Size(310, 136);
			this.pnlNetwork_Camera.TabIndex = 15;
			// 
			// lblNetwork_CameraAssembly
			// 
			this.lblNetwork_CameraAssembly.AutoSize = true;
			this.lblNetwork_CameraAssembly.Location = new System.Drawing.Point(13, 116);
			this.lblNetwork_CameraAssembly.Name = "lblNetwork_CameraAssembly";
			this.lblNetwork_CameraAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblNetwork_CameraAssembly.TabIndex = 13;
			this.lblNetwork_CameraAssembly.Text = "Assembly";
			// 
			// lblNetwork_Camera
			// 
			this.lblNetwork_Camera.AutoEllipsis = true;
			this.lblNetwork_Camera.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_Camera.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_Camera.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_Camera.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_Camera.Name = "lblNetwork_Camera";
			this.lblNetwork_Camera.Size = new System.Drawing.Size(310, 17);
			this.lblNetwork_Camera.TabIndex = 0;
			this.lblNetwork_Camera.Text = "Camera";
			this.lblNetwork_Camera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNetwork_WebcamTypeAssemblyDesc
			// 
			this.txtNetwork_WebcamTypeAssemblyDesc.Location = new System.Drawing.Point(70, 113);
			this.txtNetwork_WebcamTypeAssemblyDesc.MaxLength = 15;
			this.txtNetwork_WebcamTypeAssemblyDesc.Name = "txtNetwork_WebcamTypeAssemblyDesc";
			this.txtNetwork_WebcamTypeAssemblyDesc.ReadOnly = true;
			this.txtNetwork_WebcamTypeAssemblyDesc.Size = new System.Drawing.Size(231, 20);
			this.txtNetwork_WebcamTypeAssemblyDesc.TabIndex = 14;
			// 
			// cmbNetwork_WebcamType
			// 
			this.cmbNetwork_WebcamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNetwork_WebcamType.Enabled = false;
			this.cmbNetwork_WebcamType.FormattingEnabled = true;
			this.cmbNetwork_WebcamType.Location = new System.Drawing.Point(70, 89);
			this.cmbNetwork_WebcamType.Name = "cmbNetwork_WebcamType";
			this.cmbNetwork_WebcamType.Size = new System.Drawing.Size(231, 21);
			this.cmbNetwork_WebcamType.TabIndex = 12;
			this.toolTip.SetToolTip(this.cmbNetwork_WebcamType, "Select the camera type used for normal image viewing.");
			// 
			// lblNetwork_CameraLan
			// 
			this.lblNetwork_CameraLan.AutoSize = true;
			this.lblNetwork_CameraLan.Location = new System.Drawing.Point(23, 23);
			this.lblNetwork_CameraLan.Name = "lblNetwork_CameraLan";
			this.lblNetwork_CameraLan.Size = new System.Drawing.Size(41, 13);
			this.lblNetwork_CameraLan.TabIndex = 0;
			this.lblNetwork_CameraLan.Text = "LAN IP";
			// 
			// lblNetwork_CameraTypeImage
			// 
			this.lblNetwork_CameraTypeImage.AutoSize = true;
			this.lblNetwork_CameraTypeImage.Location = new System.Drawing.Point(33, 92);
			this.lblNetwork_CameraTypeImage.Name = "lblNetwork_CameraTypeImage";
			this.lblNetwork_CameraTypeImage.Size = new System.Drawing.Size(31, 13);
			this.lblNetwork_CameraTypeImage.TabIndex = 11;
			this.lblNetwork_CameraTypeImage.Text = "Type";
			// 
			// lblNetwork_CameraPort
			// 
			this.lblNetwork_CameraPort.AutoSize = true;
			this.lblNetwork_CameraPort.Location = new System.Drawing.Point(6, 45);
			this.lblNetwork_CameraPort.Name = "lblNetwork_CameraPort";
			this.lblNetwork_CameraPort.Size = new System.Drawing.Size(58, 13);
			this.lblNetwork_CameraPort.TabIndex = 3;
			this.lblNetwork_CameraPort.Text = "HTTP Port";
			// 
			// numNetwork_CameraPort
			// 
			this.numNetwork_CameraPort.Location = new System.Drawing.Point(70, 43);
			this.numNetwork_CameraPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numNetwork_CameraPort.Name = "numNetwork_CameraPort";
			this.numNetwork_CameraPort.ReadOnly = true;
			this.numNetwork_CameraPort.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_CameraPort.TabIndex = 4;
			this.toolTip.SetToolTip(this.numNetwork_CameraPort, "Camera HTTP port.");
			this.numNetwork_CameraPort.Value = new decimal(new int[] {
            38383,
            0,
            0,
            0});
			this.numNetwork_CameraPort.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblNetwork_CameraChannel
			// 
			this.lblNetwork_CameraChannel.AutoSize = true;
			this.lblNetwork_CameraChannel.Location = new System.Drawing.Point(194, 45);
			this.lblNetwork_CameraChannel.Name = "lblNetwork_CameraChannel";
			this.lblNetwork_CameraChannel.Size = new System.Drawing.Size(46, 13);
			this.lblNetwork_CameraChannel.TabIndex = 5;
			this.lblNetwork_CameraChannel.Text = "Channel";
			// 
			// txtNetwork_CameraUser
			// 
			this.txtNetwork_CameraUser.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_CameraUser.Location = new System.Drawing.Point(70, 66);
			this.txtNetwork_CameraUser.MaxLength = 16;
			this.txtNetwork_CameraUser.Name = "txtNetwork_CameraUser";
			this.txtNetwork_CameraUser.ReadOnly = true;
			this.txtNetwork_CameraUser.Size = new System.Drawing.Size(70, 20);
			this.txtNetwork_CameraUser.TabIndex = 8;
			this.toolTip.SetToolTip(this.txtNetwork_CameraUser, "Username to access camera server administration.");
			this.txtNetwork_CameraUser.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_CameraPassword
			// 
			this.lblNetwork_CameraPassword.AutoSize = true;
			this.lblNetwork_CameraPassword.Location = new System.Drawing.Point(146, 68);
			this.lblNetwork_CameraPassword.Name = "lblNetwork_CameraPassword";
			this.lblNetwork_CameraPassword.Size = new System.Drawing.Size(53, 13);
			this.lblNetwork_CameraPassword.TabIndex = 9;
			this.lblNetwork_CameraPassword.Text = "Password";
			// 
			// lblNetwork_CameraUser
			// 
			this.lblNetwork_CameraUser.AutoSize = true;
			this.lblNetwork_CameraUser.Location = new System.Drawing.Point(35, 68);
			this.lblNetwork_CameraUser.Name = "lblNetwork_CameraUser";
			this.lblNetwork_CameraUser.Size = new System.Drawing.Size(29, 13);
			this.lblNetwork_CameraUser.TabIndex = 7;
			this.lblNetwork_CameraUser.Text = "User";
			// 
			// txtNetwork_CameraPassword
			// 
			this.txtNetwork_CameraPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_CameraPassword.Location = new System.Drawing.Point(205, 66);
			this.txtNetwork_CameraPassword.MaxLength = 16;
			this.txtNetwork_CameraPassword.Name = "txtNetwork_CameraPassword";
			this.txtNetwork_CameraPassword.ReadOnly = true;
			this.txtNetwork_CameraPassword.Size = new System.Drawing.Size(96, 20);
			this.txtNetwork_CameraPassword.TabIndex = 10;
			this.toolTip.SetToolTip(this.txtNetwork_CameraPassword, "Password to access camera server administration.");
			this.txtNetwork_CameraPassword.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// numNetwork_CameraChannel
			// 
			this.numNetwork_CameraChannel.Location = new System.Drawing.Point(246, 43);
			this.numNetwork_CameraChannel.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numNetwork_CameraChannel.Name = "numNetwork_CameraChannel";
			this.numNetwork_CameraChannel.ReadOnly = true;
			this.numNetwork_CameraChannel.Size = new System.Drawing.Size(55, 20);
			this.numNetwork_CameraChannel.TabIndex = 6;
			this.toolTip.SetToolTip(this.numNetwork_CameraChannel, "Camera channel. (Use 999 for quad view.)");
			this.numNetwork_CameraChannel.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// txtNetwork_CameraLan
			// 
			this.txtNetwork_CameraLan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtNetwork_CameraLan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNetwork_CameraLan.Location = new System.Drawing.Point(70, 20);
			this.txtNetwork_CameraLan.MaxLength = 15;
			this.txtNetwork_CameraLan.Name = "txtNetwork_CameraLan";
			this.txtNetwork_CameraLan.ReadOnly = true;
			this.txtNetwork_CameraLan.Size = new System.Drawing.Size(231, 20);
			this.txtNetwork_CameraLan.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtNetwork_CameraLan, "Local area network (private) IP address for the camera or camera server. For exam" +
        "ple: 192.168.1.100");
			this.txtNetwork_CameraLan.Click += new System.EventHandler(this.txtNetwork_CameraLan_Click);
			this.txtNetwork_CameraLan.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// pnlNetwork_Server
			// 
			this.pnlNetwork_Server.BackColor = System.Drawing.Color.LightGray;
			this.pnlNetwork_Server.Controls.Add(this.lblNetwork_Server);
			this.pnlNetwork_Server.Controls.Add(this.txtNetwork_ServerLan);
			this.pnlNetwork_Server.Controls.Add(this.lblNetwork_ServerLan);
			this.pnlNetwork_Server.Controls.Add(this.txtNetwork_ServerMask);
			this.pnlNetwork_Server.Controls.Add(this.lblNetwork_ServerMask);
			this.pnlNetwork_Server.Controls.Add(this.txtNetwork_ServerGateway);
			this.pnlNetwork_Server.Controls.Add(this.lblNetwork_ServerGateway);
			this.pnlNetwork_Server.Controls.Add(this.chkNetwork_UseLAN);
			this.pnlNetwork_Server.Location = new System.Drawing.Point(307, 18);
			this.pnlNetwork_Server.Name = "pnlNetwork_Server";
			this.pnlNetwork_Server.Size = new System.Drawing.Size(192, 115);
			this.pnlNetwork_Server.TabIndex = 7;
			// 
			// lblNetwork_Server
			// 
			this.lblNetwork_Server.AutoEllipsis = true;
			this.lblNetwork_Server.BackColor = System.Drawing.Color.DimGray;
			this.lblNetwork_Server.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblNetwork_Server.ForeColor = System.Drawing.Color.White;
			this.lblNetwork_Server.Location = new System.Drawing.Point(0, 0);
			this.lblNetwork_Server.Name = "lblNetwork_Server";
			this.lblNetwork_Server.Size = new System.Drawing.Size(192, 17);
			this.lblNetwork_Server.TabIndex = 0;
			this.lblNetwork_Server.Text = "Server";
			this.lblNetwork_Server.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNetwork_ServerLan
			// 
			this.txtNetwork_ServerLan.Location = new System.Drawing.Point(58, 20);
			this.txtNetwork_ServerLan.MaxLength = 15;
			this.txtNetwork_ServerLan.Name = "txtNetwork_ServerLan";
			this.txtNetwork_ServerLan.ReadOnly = true;
			this.txtNetwork_ServerLan.Size = new System.Drawing.Size(128, 20);
			this.txtNetwork_ServerLan.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtNetwork_ServerLan, "Local area network (private) IP address. This is the computer/server address. For" +
        " example: 192.168.1.50");
			this.txtNetwork_ServerLan.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_ServerLan
			// 
			this.lblNetwork_ServerLan.AutoSize = true;
			this.lblNetwork_ServerLan.Location = new System.Drawing.Point(11, 23);
			this.lblNetwork_ServerLan.Name = "lblNetwork_ServerLan";
			this.lblNetwork_ServerLan.Size = new System.Drawing.Size(41, 13);
			this.lblNetwork_ServerLan.TabIndex = 0;
			this.lblNetwork_ServerLan.Text = "LAN IP";
			// 
			// txtNetwork_ServerMask
			// 
			this.txtNetwork_ServerMask.Location = new System.Drawing.Point(58, 69);
			this.txtNetwork_ServerMask.MaxLength = 15;
			this.txtNetwork_ServerMask.Name = "txtNetwork_ServerMask";
			this.txtNetwork_ServerMask.ReadOnly = true;
			this.txtNetwork_ServerMask.Size = new System.Drawing.Size(128, 20);
			this.txtNetwork_ServerMask.TabIndex = 5;
			this.toolTip.SetToolTip(this.txtNetwork_ServerMask, "Subnet mask for the local area network. For example: 255.255.255.0");
			this.txtNetwork_ServerMask.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_ServerMask
			// 
			this.lblNetwork_ServerMask.AutoSize = true;
			this.lblNetwork_ServerMask.Location = new System.Drawing.Point(19, 69);
			this.lblNetwork_ServerMask.Name = "lblNetwork_ServerMask";
			this.lblNetwork_ServerMask.Size = new System.Drawing.Size(33, 13);
			this.lblNetwork_ServerMask.TabIndex = 4;
			this.lblNetwork_ServerMask.Text = "Mask";
			// 
			// txtNetwork_ServerGateway
			// 
			this.txtNetwork_ServerGateway.Location = new System.Drawing.Point(58, 44);
			this.txtNetwork_ServerGateway.MaxLength = 15;
			this.txtNetwork_ServerGateway.Name = "txtNetwork_ServerGateway";
			this.txtNetwork_ServerGateway.ReadOnly = true;
			this.txtNetwork_ServerGateway.Size = new System.Drawing.Size(128, 20);
			this.txtNetwork_ServerGateway.TabIndex = 3;
			this.toolTip.SetToolTip(this.txtNetwork_ServerGateway, "Local area network (private) gateway address. This is the address on the local si" +
        "de of the router. For example: 192.168.1.1");
			this.txtNetwork_ServerGateway.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_ServerGateway
			// 
			this.lblNetwork_ServerGateway.AutoSize = true;
			this.lblNetwork_ServerGateway.Location = new System.Drawing.Point(3, 47);
			this.lblNetwork_ServerGateway.Name = "lblNetwork_ServerGateway";
			this.lblNetwork_ServerGateway.Size = new System.Drawing.Size(49, 13);
			this.lblNetwork_ServerGateway.TabIndex = 2;
			this.lblNetwork_ServerGateway.Text = "Gateway";
			// 
			// chkNetwork_UseLAN
			// 
			this.chkNetwork_UseLAN.AutoSize = true;
			this.chkNetwork_UseLAN.Location = new System.Drawing.Point(1, 90);
			this.chkNetwork_UseLAN.Name = "chkNetwork_UseLAN";
			this.chkNetwork_UseLAN.Size = new System.Drawing.Size(189, 17);
			this.chkNetwork_UseLAN.TabIndex = 6;
			this.chkNetwork_UseLAN.Text = "Connect directly to LAN addresses";
			this.toolTip.SetToolTip(this.chkNetwork_UseLAN, resources.GetString("chkNetwork_UseLAN.ToolTip"));
			this.chkNetwork_UseLAN.UseVisualStyleBackColor = true;
			// 
			// lblNetwork_Installed
			// 
			this.lblNetwork_Installed.AutoSize = true;
			this.lblNetwork_Installed.Location = new System.Drawing.Point(503, 4);
			this.lblNetwork_Installed.Name = "lblNetwork_Installed";
			this.lblNetwork_Installed.Size = new System.Drawing.Size(49, 13);
			this.lblNetwork_Installed.TabIndex = 11;
			this.lblNetwork_Installed.Text = "Installed:";
			// 
			// txtNetwork_ISP
			// 
			this.txtNetwork_ISP.Location = new System.Drawing.Point(59, 8);
			this.txtNetwork_ISP.MaxLength = 255;
			this.txtNetwork_ISP.Name = "txtNetwork_ISP";
			this.txtNetwork_ISP.ReadOnly = true;
			this.txtNetwork_ISP.Size = new System.Drawing.Size(242, 20);
			this.txtNetwork_ISP.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtNetwork_ISP, "Internet service provider (ISP) name, service type. For example: AT&T wireless");
			this.txtNetwork_ISP.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_WAN
			// 
			this.lblNetwork_WAN.AutoSize = true;
			this.lblNetwork_WAN.Location = new System.Drawing.Point(7, 36);
			this.lblNetwork_WAN.Name = "lblNetwork_WAN";
			this.lblNetwork_WAN.Size = new System.Drawing.Size(46, 13);
			this.lblNetwork_WAN.TabIndex = 4;
			this.lblNetwork_WAN.Text = "WAN IP";
			// 
			// chkNetwork_CameraInstalled
			// 
			this.chkNetwork_CameraInstalled.AutoSize = true;
			this.chkNetwork_CameraInstalled.Location = new System.Drawing.Point(577, 3);
			this.chkNetwork_CameraInstalled.Name = "chkNetwork_CameraInstalled";
			this.chkNetwork_CameraInstalled.Size = new System.Drawing.Size(62, 17);
			this.chkNetwork_CameraInstalled.TabIndex = 12;
			this.chkNetwork_CameraInstalled.Text = "Camera";
			this.chkNetwork_CameraInstalled.UseVisualStyleBackColor = true;
			this.chkNetwork_CameraInstalled.CheckedChanged += new System.EventHandler(this.chkNetwork_CameraInstalled_CheckedChanged);
			// 
			// chkNetwork_IBootInstalled
			// 
			this.chkNetwork_IBootInstalled.AutoSize = true;
			this.chkNetwork_IBootInstalled.Location = new System.Drawing.Point(664, 3);
			this.chkNetwork_IBootInstalled.Name = "chkNetwork_IBootInstalled";
			this.chkNetwork_IBootInstalled.Size = new System.Drawing.Size(51, 17);
			this.chkNetwork_IBootInstalled.TabIndex = 13;
			this.chkNetwork_IBootInstalled.Text = "IBoot";
			this.chkNetwork_IBootInstalled.UseVisualStyleBackColor = true;
			this.chkNetwork_IBootInstalled.CheckedChanged += new System.EventHandler(this.chkNetwork_IBootInstalled_CheckedChanged);
			// 
			// chkNetwork_MiniGooseInstalled
			// 
			this.chkNetwork_MiniGooseInstalled.AutoSize = true;
			this.chkNetwork_MiniGooseInstalled.Location = new System.Drawing.Point(740, 3);
			this.chkNetwork_MiniGooseInstalled.Name = "chkNetwork_MiniGooseInstalled";
			this.chkNetwork_MiniGooseInstalled.Size = new System.Drawing.Size(76, 17);
			this.chkNetwork_MiniGooseInstalled.TabIndex = 14;
			this.chkNetwork_MiniGooseInstalled.Text = "MiniGoose";
			this.chkNetwork_MiniGooseInstalled.UseVisualStyleBackColor = true;
			this.chkNetwork_MiniGooseInstalled.CheckedChanged += new System.EventHandler(this.chkNetwork_MiniGooseInstalled_CheckedChanged);
			// 
			// lblNetwork_Router
			// 
			this.lblNetwork_Router.AutoSize = true;
			this.lblNetwork_Router.Location = new System.Drawing.Point(8, 65);
			this.lblNetwork_Router.Name = "lblNetwork_Router";
			this.lblNetwork_Router.Size = new System.Drawing.Size(39, 13);
			this.lblNetwork_Router.TabIndex = 2;
			this.lblNetwork_Router.Text = "Router";
			// 
			// txtNetwork_WAN
			// 
			this.txtNetwork_WAN.Location = new System.Drawing.Point(59, 33);
			this.txtNetwork_WAN.MaxLength = 255;
			this.txtNetwork_WAN.Name = "txtNetwork_WAN";
			this.txtNetwork_WAN.ReadOnly = true;
			this.txtNetwork_WAN.Size = new System.Drawing.Size(242, 20);
			this.txtNetwork_WAN.TabIndex = 5;
			this.toolTip.SetToolTip(this.txtNetwork_WAN, "Wide area network (public) IP address. For example: 67.82.143.56");
			this.txtNetwork_WAN.DoubleClick += new System.EventHandler(this.txtNetwork_WAN_DoubleClick);
			this.txtNetwork_WAN.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblNetwork_ISP
			// 
			this.lblNetwork_ISP.AutoSize = true;
			this.lblNetwork_ISP.Location = new System.Drawing.Point(29, 11);
			this.lblNetwork_ISP.Name = "lblNetwork_ISP";
			this.lblNetwork_ISP.Size = new System.Drawing.Size(24, 13);
			this.lblNetwork_ISP.TabIndex = 0;
			this.lblNetwork_ISP.Text = "ISP";
			// 
			// txtNetwork_Router
			// 
			this.txtNetwork_Router.Location = new System.Drawing.Point(59, 59);
			this.txtNetwork_Router.MaxLength = 255;
			this.txtNetwork_Router.Name = "txtNetwork_Router";
			this.txtNetwork_Router.ReadOnly = true;
			this.txtNetwork_Router.Size = new System.Drawing.Size(242, 20);
			this.txtNetwork_Router.TabIndex = 3;
			this.toolTip.SetToolTip(this.txtNetwork_Router, "Router type and model. For example: Linksys WRT54G");
			this.txtNetwork_Router.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// tabRMA
			// 
			this.tabRMA.Controls.Add(this.lblLegacyRMACount);
			this.tabRMA.Controls.Add(this.tbxLegacyRMACount);
			this.tabRMA.Controls.Add(this.radRMA);
			this.tabRMA.Controls.Add(this.ucRMAList1);
			this.tabRMA.Location = new System.Drawing.Point(4, 22);
			this.tabRMA.Name = "tabRMA";
			this.tabRMA.Size = new System.Drawing.Size(825, 302);
			this.tabRMA.TabIndex = 7;
			this.tabRMA.Text = "RMAs";
			this.tabRMA.UseVisualStyleBackColor = true;
			// 
			// radRMA
			// 
			this.radRMA.AutoSize = true;
			this.radRMA.Checked = true;
			this.radRMA.Location = new System.Drawing.Point(3, 7);
			this.radRMA.Name = "radRMA";
			this.radRMA.Size = new System.Drawing.Size(49, 17);
			this.radRMA.TabIndex = 8;
			this.radRMA.TabStop = true;
			this.radRMA.Text = "RMA";
			this.radRMA.UseVisualStyleBackColor = true;
			this.radRMA.Click += new System.EventHandler(this.rBtnRMA_Click);
			// 
			// ucRMAList1
			// 
			this.ucRMAList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucRMAList1.Location = new System.Drawing.Point(0, 0);
			this.ucRMAList1.Name = "ucRMAList1";
			this.ucRMAList1.ShowCreateButton = false;
			this.ucRMAList1.ShowFilter = false;
			this.ucRMAList1.Size = new System.Drawing.Size(825, 302);
			this.ucRMAList1.TabIndex = 0;
			this.ucRMAList1.ViewRMA += new SDB.UserControls.RMA.RmaList.RMAEvent(this.ucRMAList1_ViewRMA);
			// 
			// tabDocuments
			// 
			this.tabDocuments.Controls.Add(this.olvDocuments);
			this.tabDocuments.Controls.Add(this.pnlDocumentsControl);
			this.tabDocuments.Location = new System.Drawing.Point(4, 22);
			this.tabDocuments.Name = "tabDocuments";
			this.tabDocuments.Padding = new System.Windows.Forms.Padding(3);
			this.tabDocuments.Size = new System.Drawing.Size(825, 302);
			this.tabDocuments.TabIndex = 13;
			this.tabDocuments.Text = "Documents";
			this.tabDocuments.UseVisualStyleBackColor = true;
			// 
			// olvDocuments
			// 
			this.olvDocuments.AllColumns.Add(this.olvDocumentsColumn);
			this.olvDocuments.AllColumns.Add(this.olvDateColumn);
			this.olvDocuments.AllColumns.Add(this.olvUserColumn);
			this.olvDocuments.AllowColumnReorder = true;
			this.olvDocuments.BackColor = System.Drawing.SystemColors.Window;
			this.olvDocuments.CellEditUseWholeCell = false;
			this.olvDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvDocumentsColumn,
            this.olvDateColumn,
            this.olvUserColumn});
			this.olvDocuments.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvDocuments.EmptyListMsg = "No Asset Documents";
			this.olvDocuments.FullRowSelect = true;
			this.olvDocuments.HasCollapsibleGroups = false;
			this.olvDocuments.HideSelection = false;
			this.olvDocuments.Location = new System.Drawing.Point(3, 3);
			this.olvDocuments.Name = "olvDocuments";
			this.olvDocuments.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvDocuments.ShowCommandMenuOnRightClick = true;
			this.olvDocuments.ShowGroups = false;
			this.olvDocuments.Size = new System.Drawing.Size(819, 266);
			this.olvDocuments.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.olvDocuments.TabIndex = 2;
			this.olvDocuments.UseCompatibleStateImageBehavior = false;
			this.olvDocuments.View = System.Windows.Forms.View.Details;
			this.olvDocuments.DoubleClick += new System.EventHandler(this.olvDocuments_DoubleClick);
			// 
			// olvDocumentsColumn
			// 
			this.olvDocumentsColumn.AspectName = "Name";
			this.olvDocumentsColumn.FillsFreeSpace = true;
			this.olvDocumentsColumn.Groupable = false;
			this.olvDocumentsColumn.Hideable = false;
			this.olvDocumentsColumn.IsEditable = false;
			this.olvDocumentsColumn.MaximumWidth = 414;
			this.olvDocumentsColumn.MinimumWidth = 414;
			this.olvDocumentsColumn.Text = "Document";
			this.olvDocumentsColumn.Width = 414;
			// 
			// olvDateColumn
			// 
			this.olvDateColumn.AspectName = "DateString";
			this.olvDateColumn.MaximumWidth = 200;
			this.olvDateColumn.MinimumWidth = 200;
			this.olvDateColumn.Text = "Date";
			this.olvDateColumn.Width = 200;
			// 
			// olvUserColumn
			// 
			this.olvUserColumn.AspectName = "UserFirstL";
			this.olvUserColumn.MaximumWidth = 200;
			this.olvUserColumn.MinimumWidth = 200;
			this.olvUserColumn.Text = "User";
			this.olvUserColumn.Width = 200;
			// 
			// pnlDocumentsControl
			// 
			this.pnlDocumentsControl.Controls.Add(this.btnAddDocument);
			this.pnlDocumentsControl.Controls.Add(this.btnRemoveDocument);
			this.pnlDocumentsControl.Controls.Add(this.btnChangeDocument);
			this.pnlDocumentsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlDocumentsControl.Location = new System.Drawing.Point(3, 269);
			this.pnlDocumentsControl.Name = "pnlDocumentsControl";
			this.pnlDocumentsControl.Size = new System.Drawing.Size(819, 30);
			this.pnlDocumentsControl.TabIndex = 6;
			// 
			// btnAddDocument
			// 
			this.btnAddDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAddDocument.Location = new System.Drawing.Point(223, 4);
			this.btnAddDocument.Name = "btnAddDocument";
			this.btnAddDocument.Size = new System.Drawing.Size(120, 23);
			this.btnAddDocument.TabIndex = 3;
			this.btnAddDocument.Text = "Add Document";
			this.btnAddDocument.UseVisualStyleBackColor = true;
			this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
			// 
			// btnRemoveDocument
			// 
			this.btnRemoveDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnRemoveDocument.Location = new System.Drawing.Point(475, 4);
			this.btnRemoveDocument.Name = "btnRemoveDocument";
			this.btnRemoveDocument.Size = new System.Drawing.Size(120, 23);
			this.btnRemoveDocument.TabIndex = 5;
			this.btnRemoveDocument.Text = "Remove Document";
			this.btnRemoveDocument.UseVisualStyleBackColor = true;
			this.btnRemoveDocument.Click += new System.EventHandler(this.btnRemoveDocument_Click);
			// 
			// btnChangeDocument
			// 
			this.btnChangeDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnChangeDocument.Location = new System.Drawing.Point(349, 4);
			this.btnChangeDocument.Name = "btnChangeDocument";
			this.btnChangeDocument.Size = new System.Drawing.Size(120, 23);
			this.btnChangeDocument.TabIndex = 4;
			this.btnChangeDocument.Text = "Change Document";
			this.btnChangeDocument.UseVisualStyleBackColor = true;
			this.btnChangeDocument.Click += new System.EventHandler(this.btnChangeDocument_Click);
			// 
			// tabMonitoring
			// 
			this.tabMonitoring.Controls.Add(this.pnlMonitoringControl);
			this.tabMonitoring.Location = new System.Drawing.Point(4, 22);
			this.tabMonitoring.Name = "tabMonitoring";
			this.tabMonitoring.Size = new System.Drawing.Size(825, 302);
			this.tabMonitoring.TabIndex = 4;
			this.tabMonitoring.Text = "Monitoring";
			this.tabMonitoring.UseVisualStyleBackColor = true;
			// 
			// pnlMonitoringControl
			// 
			this.pnlMonitoringControl.BackColor = System.Drawing.Color.LightGray;
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_CameraCheckInterval);
			this.pnlMonitoringControl.Controls.Add(this.numMonitoring_CameraCheckInterval);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_CameraCheckInterval_Unit);
			this.pnlMonitoringControl.Controls.Add(this.txtMonitoring_BlackoutSchedule);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoringControl);
			this.pnlMonitoringControl.Controls.Add(pbMonitoring_PVMLogo);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_HoldTimeSeconds);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_ShowWebcamStatus);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_StuckImageThreshold);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_ShowDataStatus);
			this.pnlMonitoringControl.Controls.Add(this.btnMonitoring_BlackoutSchedule);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_Interval);
			this.pnlMonitoringControl.Controls.Add(this.pnlMonitoring_WebcamMode);
			this.pnlMonitoringControl.Controls.Add(this.pnlMonitoring_DataMode);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_Webcam);
			this.pnlMonitoringControl.Controls.Add(this.numMonitoring_HoldTime);
			this.pnlMonitoringControl.Controls.Add(this.numMonitoring_Interval);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_IntervalMinutes);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_Data);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_Status);
			this.pnlMonitoringControl.Controls.Add(this.lblMonitoring_Mode);
			this.pnlMonitoringControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMonitoringControl.Location = new System.Drawing.Point(0, 0);
			this.pnlMonitoringControl.Name = "pnlMonitoringControl";
			this.pnlMonitoringControl.Size = new System.Drawing.Size(825, 302);
			this.pnlMonitoringControl.TabIndex = 0;
			// 
			// lblMonitoring_CameraCheckInterval
			// 
			this.lblMonitoring_CameraCheckInterval.AutoSize = true;
			this.lblMonitoring_CameraCheckInterval.Location = new System.Drawing.Point(530, 66);
			this.lblMonitoring_CameraCheckInterval.Name = "lblMonitoring_CameraCheckInterval";
			this.lblMonitoring_CameraCheckInterval.Size = new System.Drawing.Size(114, 13);
			this.lblMonitoring_CameraCheckInterval.TabIndex = 44;
			this.lblMonitoring_CameraCheckInterval.Text = "Camera Check interval";
			// 
			// numMonitoring_CameraCheckInterval
			// 
			this.numMonitoring_CameraCheckInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numMonitoring_CameraCheckInterval.Location = new System.Drawing.Point(651, 64);
			this.numMonitoring_CameraCheckInterval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
			this.numMonitoring_CameraCheckInterval.Name = "numMonitoring_CameraCheckInterval";
			this.numMonitoring_CameraCheckInterval.Size = new System.Drawing.Size(50, 20);
			this.numMonitoring_CameraCheckInterval.TabIndex = 45;
			this.numMonitoring_CameraCheckInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.numMonitoring_CameraCheckInterval, "How frequently the camera images should be manually inspected. (0= N/A)");
			this.numMonitoring_CameraCheckInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// lblMonitoring_CameraCheckInterval_Unit
			// 
			this.lblMonitoring_CameraCheckInterval_Unit.AutoSize = true;
			this.lblMonitoring_CameraCheckInterval_Unit.Location = new System.Drawing.Point(707, 66);
			this.lblMonitoring_CameraCheckInterval_Unit.Name = "lblMonitoring_CameraCheckInterval_Unit";
			this.lblMonitoring_CameraCheckInterval_Unit.Size = new System.Drawing.Size(43, 13);
			this.lblMonitoring_CameraCheckInterval_Unit.TabIndex = 46;
			this.lblMonitoring_CameraCheckInterval_Unit.Text = "minutes";
			// 
			// txtMonitoring_BlackoutSchedule
			// 
			this.txtMonitoring_BlackoutSchedule.Location = new System.Drawing.Point(117, 184);
			this.txtMonitoring_BlackoutSchedule.Multiline = true;
			this.txtMonitoring_BlackoutSchedule.Name = "txtMonitoring_BlackoutSchedule";
			this.txtMonitoring_BlackoutSchedule.ReadOnly = true;
			this.txtMonitoring_BlackoutSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMonitoring_BlackoutSchedule.ShortcutsEnabled = false;
			this.txtMonitoring_BlackoutSchedule.Size = new System.Drawing.Size(158, 103);
			this.txtMonitoring_BlackoutSchedule.TabIndex = 40;
			// 
			// lblMonitoringControl
			// 
			this.lblMonitoringControl.AutoEllipsis = true;
			this.lblMonitoringControl.BackColor = System.Drawing.Color.DimGray;
			this.lblMonitoringControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblMonitoringControl.ForeColor = System.Drawing.Color.White;
			this.lblMonitoringControl.Location = new System.Drawing.Point(0, 0);
			this.lblMonitoringControl.Name = "lblMonitoringControl";
			this.lblMonitoringControl.Size = new System.Drawing.Size(825, 17);
			this.lblMonitoringControl.TabIndex = 39;
			this.lblMonitoringControl.Text = "Monitoring Control";
			this.lblMonitoringControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMonitoring_HoldTimeSeconds
			// 
			this.lblMonitoring_HoldTimeSeconds.AutoSize = true;
			this.lblMonitoring_HoldTimeSeconds.Location = new System.Drawing.Point(291, 124);
			this.lblMonitoring_HoldTimeSeconds.Name = "lblMonitoring_HoldTimeSeconds";
			this.lblMonitoring_HoldTimeSeconds.Size = new System.Drawing.Size(47, 13);
			this.lblMonitoring_HoldTimeSeconds.TabIndex = 38;
			this.lblMonitoring_HoldTimeSeconds.Text = "seconds";
			// 
			// lblMonitoring_ShowWebcamStatus
			// 
			this.lblMonitoring_ShowWebcamStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMonitoring_ShowWebcamStatus.Location = new System.Drawing.Point(313, 61);
			this.lblMonitoring_ShowWebcamStatus.Name = "lblMonitoring_ShowWebcamStatus";
			this.lblMonitoring_ShowWebcamStatus.Size = new System.Drawing.Size(138, 23);
			this.lblMonitoring_ShowWebcamStatus.TabIndex = 7;
			this.lblMonitoring_ShowWebcamStatus.Text = "Webcam Status";
			this.lblMonitoring_ShowWebcamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMonitoring_StuckImageThreshold
			// 
			this.lblMonitoring_StuckImageThreshold.AutoSize = true;
			this.lblMonitoring_StuckImageThreshold.Location = new System.Drawing.Point(117, 124);
			this.lblMonitoring_StuckImageThreshold.Name = "lblMonitoring_StuckImageThreshold";
			this.lblMonitoring_StuckImageThreshold.Size = new System.Drawing.Size(112, 13);
			this.lblMonitoring_StuckImageThreshold.TabIndex = 13;
			this.lblMonitoring_StuckImageThreshold.Text = "Stuck image threshold";
			// 
			// lblMonitoring_ShowDataStatus
			// 
			this.lblMonitoring_ShowDataStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblMonitoring_ShowDataStatus.Location = new System.Drawing.Point(313, 36);
			this.lblMonitoring_ShowDataStatus.Name = "lblMonitoring_ShowDataStatus";
			this.lblMonitoring_ShowDataStatus.Size = new System.Drawing.Size(138, 23);
			this.lblMonitoring_ShowDataStatus.TabIndex = 4;
			this.lblMonitoring_ShowDataStatus.Text = "Data Status";
			this.lblMonitoring_ShowDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMonitoring_BlackoutSchedule
			// 
			this.btnMonitoring_BlackoutSchedule.Location = new System.Drawing.Point(117, 155);
			this.btnMonitoring_BlackoutSchedule.Name = "btnMonitoring_BlackoutSchedule";
			this.btnMonitoring_BlackoutSchedule.Size = new System.Drawing.Size(158, 23);
			this.btnMonitoring_BlackoutSchedule.TabIndex = 36;
			this.btnMonitoring_BlackoutSchedule.Text = "Blackout Schedule";
			this.toolTip.SetToolTip(this.btnMonitoring_BlackoutSchedule, "Create or edit a blackout schedule to suppress certain monitoring alerts. (All ti" +
        "mes are local.)");
			this.btnMonitoring_BlackoutSchedule.UseVisualStyleBackColor = true;
			this.btnMonitoring_BlackoutSchedule.Click += new System.EventHandler(this.btnMonitoring_BlackoutSchedule_Click);
			// 
			// lblMonitoring_Interval
			// 
			this.lblMonitoring_Interval.AutoSize = true;
			this.lblMonitoring_Interval.Location = new System.Drawing.Point(114, 98);
			this.lblMonitoring_Interval.Name = "lblMonitoring_Interval";
			this.lblMonitoring_Interval.Size = new System.Drawing.Size(115, 13);
			this.lblMonitoring_Interval.TabIndex = 10;
			this.lblMonitoring_Interval.Text = "Data collection interval";
			// 
			// pnlMonitoring_WebcamMode
			// 
			this.pnlMonitoring_WebcamMode.Controls.Add(this.radMonitoring_WebcamMode_Forced);
			this.pnlMonitoring_WebcamMode.Controls.Add(this.radMonitoring_WebcamMode_Disabled);
			this.pnlMonitoring_WebcamMode.Controls.Add(this.radMonitoring_WebcamMode_Auto);
			this.pnlMonitoring_WebcamMode.Location = new System.Drawing.Point(117, 61);
			this.pnlMonitoring_WebcamMode.Name = "pnlMonitoring_WebcamMode";
			this.pnlMonitoring_WebcamMode.Size = new System.Drawing.Size(190, 23);
			this.pnlMonitoring_WebcamMode.TabIndex = 6;
			// 
			// radMonitoring_WebcamMode_Forced
			// 
			this.radMonitoring_WebcamMode_Forced.AutoSize = true;
			this.radMonitoring_WebcamMode_Forced.Location = new System.Drawing.Point(128, 3);
			this.radMonitoring_WebcamMode_Forced.Name = "radMonitoring_WebcamMode_Forced";
			this.radMonitoring_WebcamMode_Forced.Size = new System.Drawing.Size(58, 17);
			this.radMonitoring_WebcamMode_Forced.TabIndex = 2;
			this.radMonitoring_WebcamMode_Forced.Text = "Forced";
			this.toolTip.SetToolTip(this.radMonitoring_WebcamMode_Forced, "Setting webcam to Forced will make it appear on camera checks.");
			this.radMonitoring_WebcamMode_Forced.UseVisualStyleBackColor = true;
			this.radMonitoring_WebcamMode_Forced.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			this.radMonitoring_WebcamMode_Forced.Click += new System.EventHandler(this.radMonitoring_WebcamMode_Forced_Click);
			// 
			// radMonitoring_WebcamMode_Disabled
			// 
			this.radMonitoring_WebcamMode_Disabled.AutoSize = true;
			this.radMonitoring_WebcamMode_Disabled.Checked = true;
			this.radMonitoring_WebcamMode_Disabled.Location = new System.Drawing.Point(3, 3);
			this.radMonitoring_WebcamMode_Disabled.Name = "radMonitoring_WebcamMode_Disabled";
			this.radMonitoring_WebcamMode_Disabled.Size = new System.Drawing.Size(66, 17);
			this.radMonitoring_WebcamMode_Disabled.TabIndex = 0;
			this.radMonitoring_WebcamMode_Disabled.TabStop = true;
			this.radMonitoring_WebcamMode_Disabled.Text = "Disabled";
			this.toolTip.SetToolTip(this.radMonitoring_WebcamMode_Disabled, "Setting webcam to disabled will clear all images for this asset on next maintenan" +
        "ce.");
			this.radMonitoring_WebcamMode_Disabled.UseVisualStyleBackColor = true;
			this.radMonitoring_WebcamMode_Disabled.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			// 
			// radMonitoring_WebcamMode_Auto
			// 
			this.radMonitoring_WebcamMode_Auto.AutoSize = true;
			this.radMonitoring_WebcamMode_Auto.Location = new System.Drawing.Point(75, 3);
			this.radMonitoring_WebcamMode_Auto.Name = "radMonitoring_WebcamMode_Auto";
			this.radMonitoring_WebcamMode_Auto.Size = new System.Drawing.Size(47, 17);
			this.radMonitoring_WebcamMode_Auto.TabIndex = 1;
			this.radMonitoring_WebcamMode_Auto.Text = "Auto";
			this.radMonitoring_WebcamMode_Auto.UseVisualStyleBackColor = true;
			this.radMonitoring_WebcamMode_Auto.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			this.radMonitoring_WebcamMode_Auto.Click += new System.EventHandler(this.radMonitoring_WebcamMode_Auto_Click);
			// 
			// pnlMonitoring_DataMode
			// 
			this.pnlMonitoring_DataMode.Controls.Add(this.radMonitoring_DataMode_Forced);
			this.pnlMonitoring_DataMode.Controls.Add(this.radMonitoring_DataMode_Disabled);
			this.pnlMonitoring_DataMode.Controls.Add(this.radMonitoring_DataMode_Auto);
			this.pnlMonitoring_DataMode.Location = new System.Drawing.Point(117, 36);
			this.pnlMonitoring_DataMode.Name = "pnlMonitoring_DataMode";
			this.pnlMonitoring_DataMode.Size = new System.Drawing.Size(190, 23);
			this.pnlMonitoring_DataMode.TabIndex = 3;
			// 
			// radMonitoring_DataMode_Forced
			// 
			this.radMonitoring_DataMode_Forced.AutoSize = true;
			this.radMonitoring_DataMode_Forced.Location = new System.Drawing.Point(128, 3);
			this.radMonitoring_DataMode_Forced.Name = "radMonitoring_DataMode_Forced";
			this.radMonitoring_DataMode_Forced.Size = new System.Drawing.Size(58, 17);
			this.radMonitoring_DataMode_Forced.TabIndex = 2;
			this.radMonitoring_DataMode_Forced.Text = "Forced";
			this.radMonitoring_DataMode_Forced.UseVisualStyleBackColor = true;
			this.radMonitoring_DataMode_Forced.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			this.radMonitoring_DataMode_Forced.Click += new System.EventHandler(this.radMonitoring_DataMode_Forced_Click);
			// 
			// radMonitoring_DataMode_Disabled
			// 
			this.radMonitoring_DataMode_Disabled.AutoSize = true;
			this.radMonitoring_DataMode_Disabled.Checked = true;
			this.radMonitoring_DataMode_Disabled.Location = new System.Drawing.Point(3, 3);
			this.radMonitoring_DataMode_Disabled.Name = "radMonitoring_DataMode_Disabled";
			this.radMonitoring_DataMode_Disabled.Size = new System.Drawing.Size(66, 17);
			this.radMonitoring_DataMode_Disabled.TabIndex = 0;
			this.radMonitoring_DataMode_Disabled.TabStop = true;
			this.radMonitoring_DataMode_Disabled.Text = "Disabled";
			this.toolTip.SetToolTip(this.radMonitoring_DataMode_Disabled, "Setting data to disabled will clear all data for this asset on next maintenance.");
			this.radMonitoring_DataMode_Disabled.UseVisualStyleBackColor = true;
			this.radMonitoring_DataMode_Disabled.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			// 
			// radMonitoring_DataMode_Auto
			// 
			this.radMonitoring_DataMode_Auto.AutoSize = true;
			this.radMonitoring_DataMode_Auto.Location = new System.Drawing.Point(75, 3);
			this.radMonitoring_DataMode_Auto.Name = "radMonitoring_DataMode_Auto";
			this.radMonitoring_DataMode_Auto.Size = new System.Drawing.Size(47, 17);
			this.radMonitoring_DataMode_Auto.TabIndex = 1;
			this.radMonitoring_DataMode_Auto.Text = "Auto";
			this.radMonitoring_DataMode_Auto.UseVisualStyleBackColor = true;
			this.radMonitoring_DataMode_Auto.CheckedChanged += new System.EventHandler(this.radMonitoring_Mode_CheckedChanged);
			this.radMonitoring_DataMode_Auto.Click += new System.EventHandler(this.radMonitoring_DataMode_Auto_Click);
			// 
			// lblMonitoring_Webcam
			// 
			this.lblMonitoring_Webcam.AutoSize = true;
			this.lblMonitoring_Webcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonitoring_Webcam.Location = new System.Drawing.Point(55, 66);
			this.lblMonitoring_Webcam.Name = "lblMonitoring_Webcam";
			this.lblMonitoring_Webcam.Size = new System.Drawing.Size(56, 13);
			this.lblMonitoring_Webcam.TabIndex = 5;
			this.lblMonitoring_Webcam.Text = "Webcam";
			// 
			// numMonitoring_HoldTime
			// 
			this.numMonitoring_HoldTime.Location = new System.Drawing.Point(235, 122);
			this.numMonitoring_HoldTime.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
			this.numMonitoring_HoldTime.Name = "numMonitoring_HoldTime";
			this.numMonitoring_HoldTime.Size = new System.Drawing.Size(50, 20);
			this.numMonitoring_HoldTime.TabIndex = 37;
			this.numMonitoring_HoldTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.numMonitoring_HoldTime, "Number of seconds the sign holds images. Use 0 when not-applicable (variable or a" +
        "nimation).");
			// 
			// numMonitoring_Interval
			// 
			this.numMonitoring_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numMonitoring_Interval.Location = new System.Drawing.Point(235, 96);
			this.numMonitoring_Interval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numMonitoring_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numMonitoring_Interval.Name = "numMonitoring_Interval";
			this.numMonitoring_Interval.Size = new System.Drawing.Size(50, 20);
			this.numMonitoring_Interval.TabIndex = 11;
			this.numMonitoring_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.numMonitoring_Interval, "Monitoring data collection (data and camera image) interval in minutes.");
			this.numMonitoring_Interval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numMonitoring_Interval.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblMonitoring_IntervalMinutes
			// 
			this.lblMonitoring_IntervalMinutes.AutoSize = true;
			this.lblMonitoring_IntervalMinutes.Location = new System.Drawing.Point(291, 98);
			this.lblMonitoring_IntervalMinutes.Name = "lblMonitoring_IntervalMinutes";
			this.lblMonitoring_IntervalMinutes.Size = new System.Drawing.Size(43, 13);
			this.lblMonitoring_IntervalMinutes.TabIndex = 12;
			this.lblMonitoring_IntervalMinutes.Text = "minutes";
			// 
			// lblMonitoring_Data
			// 
			this.lblMonitoring_Data.AutoSize = true;
			this.lblMonitoring_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonitoring_Data.Location = new System.Drawing.Point(77, 41);
			this.lblMonitoring_Data.Name = "lblMonitoring_Data";
			this.lblMonitoring_Data.Size = new System.Drawing.Size(34, 13);
			this.lblMonitoring_Data.TabIndex = 2;
			this.lblMonitoring_Data.Text = "Data";
			// 
			// lblMonitoring_Status
			// 
			this.lblMonitoring_Status.BackColor = System.Drawing.Color.LightGray;
			this.lblMonitoring_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonitoring_Status.Location = new System.Drawing.Point(313, 20);
			this.lblMonitoring_Status.Name = "lblMonitoring_Status";
			this.lblMonitoring_Status.Size = new System.Drawing.Size(138, 13);
			this.lblMonitoring_Status.TabIndex = 1;
			this.lblMonitoring_Status.Text = "Status";
			this.lblMonitoring_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMonitoring_Mode
			// 
			this.lblMonitoring_Mode.BackColor = System.Drawing.Color.LightGray;
			this.lblMonitoring_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonitoring_Mode.Location = new System.Drawing.Point(117, 20);
			this.lblMonitoring_Mode.Name = "lblMonitoring_Mode";
			this.lblMonitoring_Mode.Size = new System.Drawing.Size(190, 13);
			this.lblMonitoring_Mode.TabIndex = 0;
			this.lblMonitoring_Mode.Text = "Mode";
			this.lblMonitoring_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabShipments
			// 
			this.tabShipments.Controls.Add(this.ucShipmentList1);
			this.tabShipments.Location = new System.Drawing.Point(4, 22);
			this.tabShipments.Name = "tabShipments";
			this.tabShipments.Padding = new System.Windows.Forms.Padding(3);
			this.tabShipments.Size = new System.Drawing.Size(825, 302);
			this.tabShipments.TabIndex = 5;
			this.tabShipments.Text = "Shipments";
			this.tabShipments.UseVisualStyleBackColor = true;
			// 
			// ucShipmentList1
			// 
			this.ucShipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucShipmentList1.Location = new System.Drawing.Point(3, 3);
			this.ucShipmentList1.Name = "ucShipmentList1";
			this.ucShipmentList1.ShowCreateButton = false;
			this.ucShipmentList1.Size = new System.Drawing.Size(819, 296);
			this.ucShipmentList1.TabIndex = 0;
			this.ucShipmentList1.CreateShipment += new SDB.UserControls.Shipment.ucShipmentList.CreateEvent(this.ucShipmentList_CreateShipment);
			this.ucShipmentList1.ViewShipment += new SDB.UserControls.Shipment.ucShipmentList.ShipmentEvent(this.ucShipmentList_ViewShipment);
			this.ucShipmentList1.ViewTracking += new SDB.UserControls.Shipment.ucShipmentList.TrackingEvent(this.ucShipmentList_ViewTracking);
			// 
			// tabJournal
			// 
			this.tabJournal.Controls.Add(this.dgvJournal);
			this.tabJournal.Controls.Add(this.pnlJournal_Control);
			this.tabJournal.Location = new System.Drawing.Point(4, 22);
			this.tabJournal.Name = "tabJournal";
			this.tabJournal.Padding = new System.Windows.Forms.Padding(3);
			this.tabJournal.Size = new System.Drawing.Size(825, 302);
			this.tabJournal.TabIndex = 9;
			this.tabJournal.Text = "Journal";
			this.tabJournal.UseVisualStyleBackColor = true;
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
			this.dgvJournal.Location = new System.Drawing.Point(3, 33);
			this.dgvJournal.Name = "dgvJournal";
			this.dgvJournal.ReadOnly = true;
			this.dgvJournal.RowHeadersVisible = false;
			this.dgvJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvJournal.ShowCellErrors = false;
			this.dgvJournal.ShowCellToolTips = false;
			this.dgvJournal.ShowEditingIcon = false;
			this.dgvJournal.ShowRowErrors = false;
			this.dgvJournal.Size = new System.Drawing.Size(819, 266);
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
			this.pnlJournal_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlJournal_Control.Name = "pnlJournal_Control";
			this.pnlJournal_Control.Size = new System.Drawing.Size(819, 30);
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
			this.toolTip.SetToolTip(this.btnJournal_Add, "Add Asset Journal Entry");
			this.btnJournal_Add.UseVisualStyleBackColor = false;
			this.btnJournal_Add.Click += new System.EventHandler(this.btnJournal_Add_Click);
			// 
			// tabIBom
			// 
			this.tabIBom.Controls.Add(this.ucAsset_IBOM1);
			this.tabIBom.Location = new System.Drawing.Point(4, 22);
			this.tabIBom.Name = "tabIBom";
			this.tabIBom.Padding = new System.Windows.Forms.Padding(3);
			this.tabIBom.Size = new System.Drawing.Size(825, 302);
			this.tabIBom.TabIndex = 8;
			this.tabIBom.Text = "iBOM";
			this.tabIBom.UseVisualStyleBackColor = true;
			// 
			// ucAsset_IBOM1
			// 
			this.ucAsset_IBOM1.Dock = System.Windows.Forms.DockStyle.Fill;
			classIbom1.Asset_ID = 0;
			classIbom1.Interface_Assembly_ID = null;
			classIbom1.Interface_EpromType = "";
			classIbom1.Interface_EpromVersion = "";
			classIbom1.LED_Assembly = "";
			classIbom1.LED_Calibration = "";
			classIbom1.LED_JobNumber = "";
			classIbom1.PS_Assembly = "";
			classIbom1.PS_BlueVoltage = new decimal(new int[] {
            5,
            0,
            0,
            0});
			classIbom1.PS_GreenVoltage = new decimal(new int[] {
            5,
            0,
            0,
            0});
			classIbom1.PS_LogicVoltage = new decimal(new int[] {
            5,
            0,
            0,
            0});
			classIbom1.PS_RedVoltage = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.ucAsset_IBOM1.IBOM = classIbom1;
			this.ucAsset_IBOM1.Location = new System.Drawing.Point(3, 3);
			this.ucAsset_IBOM1.Name = "ucAsset_IBOM1";
			this.ucAsset_IBOM1.Size = new System.Drawing.Size(819, 296);
			this.ucAsset_IBOM1.TabIndex = 0;
			// 
			// tabAssignedTechs
			// 
			this.tabAssignedTechs.Controls.Add(this.olvAssignedTechs);
			this.tabAssignedTechs.Controls.Add(this.pnlAssignedTechs_Control);
			this.tabAssignedTechs.Location = new System.Drawing.Point(4, 22);
			this.tabAssignedTechs.Name = "tabAssignedTechs";
			this.tabAssignedTechs.Padding = new System.Windows.Forms.Padding(3);
			this.tabAssignedTechs.Size = new System.Drawing.Size(825, 302);
			this.tabAssignedTechs.TabIndex = 1;
			this.tabAssignedTechs.Text = "Assigned Techs";
			this.tabAssignedTechs.UseVisualStyleBackColor = true;
			// 
			// olvAssignedTechs
			// 
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechPriority);
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechName);
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechAddress);
			this.olvAssignedTechs.AllColumns.Add(this.colColTechCity);
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechState);
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechTelephone);
			this.olvAssignedTechs.AllColumns.Add(this.olvColTechStatus);
			this.olvAssignedTechs.AllowColumnReorder = true;
			this.olvAssignedTechs.CellEditUseWholeCell = false;
			this.olvAssignedTechs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTechPriority,
            this.olvColTechName,
            this.olvColTechAddress,
            this.colColTechCity,
            this.olvColTechState,
            this.olvColTechTelephone,
            this.olvColTechStatus});
			this.olvAssignedTechs.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvAssignedTechs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvAssignedTechs.EmptyListMsg = "No techs are assigned to this asset.";
			this.olvAssignedTechs.FullRowSelect = true;
			this.olvAssignedTechs.GridLines = true;
			this.olvAssignedTechs.HasCollapsibleGroups = false;
			this.olvAssignedTechs.HideSelection = false;
			this.olvAssignedTechs.Location = new System.Drawing.Point(3, 33);
			this.olvAssignedTechs.Name = "olvAssignedTechs";
			this.olvAssignedTechs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvAssignedTechs.ShowCommandMenuOnRightClick = true;
			this.olvAssignedTechs.ShowGroups = false;
			this.olvAssignedTechs.Size = new System.Drawing.Size(819, 266);
			this.olvAssignedTechs.TabIndex = 0;
			this.olvAssignedTechs.UseCellFormatEvents = true;
			this.olvAssignedTechs.UseCompatibleStateImageBehavior = false;
			this.olvAssignedTechs.View = System.Windows.Forms.View.Details;
			this.olvAssignedTechs.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.olvAssignedTechs_BeforeSorting);
			this.olvAssignedTechs.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvAssignedTechs_FormatCell);
			this.olvAssignedTechs.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.olvAssignedTechs_ItemsChanged);
			this.olvAssignedTechs.SelectedIndexChanged += new System.EventHandler(this.olvAssignedTechs_SelectedIndexChanged);
			this.olvAssignedTechs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvAssignedTechs_MouseDoubleClick);
			// 
			// olvColTechPriority
			// 
			this.olvColTechPriority.AspectName = "Priority";
			this.olvColTechPriority.Text = "#";
			this.olvColTechPriority.ToolTipText = "Priority";
			this.olvColTechPriority.Width = 20;
			// 
			// olvColTechName
			// 
			this.olvColTechName.AspectName = "TechName";
			this.olvColTechName.Groupable = false;
			this.olvColTechName.IsEditable = false;
			this.olvColTechName.Text = "Tech Name";
			this.olvColTechName.Width = 170;
			// 
			// olvColTechAddress
			// 
			this.olvColTechAddress.AspectName = "Address";
			this.olvColTechAddress.Text = "Address";
			this.olvColTechAddress.Width = 160;
			// 
			// colColTechCity
			// 
			this.colColTechCity.AspectName = "City";
			this.colColTechCity.Text = "City";
			this.colColTechCity.Width = 90;
			// 
			// olvColTechState
			// 
			this.olvColTechState.AspectName = "State";
			this.olvColTechState.Text = "State";
			this.olvColTechState.Width = 40;
			// 
			// olvColTechTelephone
			// 
			this.olvColTechTelephone.AspectName = "Telephone";
			this.olvColTechTelephone.Text = "Telephone";
			this.olvColTechTelephone.Width = 80;
			// 
			// olvColTechStatus
			// 
			this.olvColTechStatus.AspectName = "TechStatus";
			this.olvColTechStatus.Text = "Status";
			// 
			// pnlAssignedTechs_Control
			// 
			this.pnlAssignedTechs_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlAssignedTechs_Control.Controls.Add(this.btnAssignedTechs_MoveUp);
			this.pnlAssignedTechs_Control.Controls.Add(this.btnAssignedTechs_Cancel);
			this.pnlAssignedTechs_Control.Controls.Add(this.btnAssignedTechs_Save);
			this.pnlAssignedTechs_Control.Controls.Add(this.btnAssignedTechs_Assign);
			this.pnlAssignedTechs_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAssignedTechs_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlAssignedTechs_Control.Name = "pnlAssignedTechs_Control";
			this.pnlAssignedTechs_Control.Size = new System.Drawing.Size(819, 30);
			this.pnlAssignedTechs_Control.TabIndex = 2;
			// 
			// btnAssignedTechs_MoveUp
			// 
			this.btnAssignedTechs_MoveUp.Enabled = false;
			this.btnAssignedTechs_MoveUp.Location = new System.Drawing.Point(162, 4);
			this.btnAssignedTechs_MoveUp.Name = "btnAssignedTechs_MoveUp";
			this.btnAssignedTechs_MoveUp.Size = new System.Drawing.Size(68, 23);
			this.btnAssignedTechs_MoveUp.TabIndex = 14;
			this.btnAssignedTechs_MoveUp.Text = "Move Up";
			this.btnAssignedTechs_MoveUp.UseVisualStyleBackColor = true;
			this.btnAssignedTechs_MoveUp.Visible = false;
			this.btnAssignedTechs_MoveUp.Click += new System.EventHandler(this.btnAssignedTechs_MoveUp_Click);
			// 
			// btnAssignedTechs_Cancel
			// 
			this.btnAssignedTechs_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAssignedTechs_Cancel.AutoSize = true;
			this.btnAssignedTechs_Cancel.Location = new System.Drawing.Point(690, 3);
			this.btnAssignedTechs_Cancel.Name = "btnAssignedTechs_Cancel";
			this.btnAssignedTechs_Cancel.Size = new System.Drawing.Size(60, 23);
			this.btnAssignedTechs_Cancel.TabIndex = 13;
			this.btnAssignedTechs_Cancel.Text = "Cancel";
			this.btnAssignedTechs_Cancel.UseVisualStyleBackColor = true;
			this.btnAssignedTechs_Cancel.Visible = false;
			this.btnAssignedTechs_Cancel.Click += new System.EventHandler(this.btnAssignedTechs_Cancel_Click);
			// 
			// btnAssignedTechs_Save
			// 
			this.btnAssignedTechs_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAssignedTechs_Save.AutoSize = true;
			this.btnAssignedTechs_Save.Location = new System.Drawing.Point(756, 3);
			this.btnAssignedTechs_Save.Name = "btnAssignedTechs_Save";
			this.btnAssignedTechs_Save.Size = new System.Drawing.Size(60, 23);
			this.btnAssignedTechs_Save.TabIndex = 12;
			this.btnAssignedTechs_Save.Text = "Save";
			this.btnAssignedTechs_Save.UseVisualStyleBackColor = true;
			this.btnAssignedTechs_Save.Visible = false;
			this.btnAssignedTechs_Save.Click += new System.EventHandler(this.btnAssignedTechs_Save_Click);
			// 
			// btnAssignedTechs_Assign
			// 
			this.btnAssignedTechs_Assign.Location = new System.Drawing.Point(4, 4);
			this.btnAssignedTechs_Assign.Name = "btnAssignedTechs_Assign";
			this.btnAssignedTechs_Assign.Size = new System.Drawing.Size(152, 23);
			this.btnAssignedTechs_Assign.TabIndex = 11;
			this.btnAssignedTechs_Assign.Text = "Change Assigned Techs";
			this.btnAssignedTechs_Assign.UseVisualStyleBackColor = true;
			this.btnAssignedTechs_Assign.Click += new System.EventHandler(this.btnAssignedTechs_Assign_Click);
			// 
			// tabSpareParts
			// 
			this.tabSpareParts.Controls.Add(this.ucAssetSpareParts1);
			this.tabSpareParts.Location = new System.Drawing.Point(4, 22);
			this.tabSpareParts.Name = "tabSpareParts";
			this.tabSpareParts.Padding = new System.Windows.Forms.Padding(3);
			this.tabSpareParts.Size = new System.Drawing.Size(825, 302);
			this.tabSpareParts.TabIndex = 10;
			this.tabSpareParts.Text = "Spare Parts";
			this.tabSpareParts.UseVisualStyleBackColor = true;
			// 
			// ucAssetSpareParts1
			// 
			this.ucAssetSpareParts1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucAssetSpareParts1.Location = new System.Drawing.Point(3, 3);
			this.ucAssetSpareParts1.Name = "ucAssetSpareParts1";
			this.ucAssetSpareParts1.Size = new System.Drawing.Size(819, 296);
			this.ucAssetSpareParts1.TabIndex = 0;
			// 
			// tabSystemBackups
			// 
			this.tabSystemBackups.Controls.Add(this.ucAssetSystemBackup1);
			this.tabSystemBackups.Location = new System.Drawing.Point(4, 22);
			this.tabSystemBackups.Name = "tabSystemBackups";
			this.tabSystemBackups.Padding = new System.Windows.Forms.Padding(3);
			this.tabSystemBackups.Size = new System.Drawing.Size(825, 302);
			this.tabSystemBackups.TabIndex = 11;
			this.tabSystemBackups.Text = "System Backups";
			this.tabSystemBackups.UseVisualStyleBackColor = true;
			// 
			// ucAssetSystemBackup1
			// 
			this.ucAssetSystemBackup1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucAssetSystemBackup1.Location = new System.Drawing.Point(3, 3);
			this.ucAssetSystemBackup1.Name = "ucAssetSystemBackup1";
			this.ucAssetSystemBackup1.Size = new System.Drawing.Size(819, 296);
			this.ucAssetSystemBackup1.TabIndex = 0;
			// 
			// cmbAsset_CabinetType
			// 
			this.cmbAsset_CabinetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_CabinetType.Enabled = false;
			this.cmbAsset_CabinetType.FormattingEnabled = true;
			this.cmbAsset_CabinetType.Location = new System.Drawing.Point(6, 99);
			this.cmbAsset_CabinetType.Name = "cmbAsset_CabinetType";
			this.cmbAsset_CabinetType.Size = new System.Drawing.Size(162, 21);
			this.cmbAsset_CabinetType.TabIndex = 13;
			this.toolTip.SetToolTip(this.cmbAsset_CabinetType, "Physical description of sign. For example: Rear-service Unibody");
			// 
			// cmbAsset_OutputMethod
			// 
			this.cmbAsset_OutputMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_OutputMethod.Enabled = false;
			this.cmbAsset_OutputMethod.FormattingEnabled = true;
			this.cmbAsset_OutputMethod.Location = new System.Drawing.Point(245, 137);
			this.cmbAsset_OutputMethod.Name = "cmbAsset_OutputMethod";
			this.cmbAsset_OutputMethod.Size = new System.Drawing.Size(149, 21);
			this.cmbAsset_OutputMethod.TabIndex = 27;
			this.toolTip.SetToolTip(this.cmbAsset_OutputMethod, "Header output method such as Serial, Native DVI, PDriver, etc.");
			// 
			// chkIndoor
			// 
			this.chkIndoor.AutoSize = true;
			this.chkIndoor.Location = new System.Drawing.Point(81, 139);
			this.chkIndoor.Name = "chkIndoor";
			this.chkIndoor.Size = new System.Drawing.Size(56, 17);
			this.chkIndoor.TabIndex = 30;
			this.chkIndoor.Text = "Indoor";
			this.toolTip.SetToolTip(this.chkIndoor, "Indicates asset is indoor type.");
			this.chkIndoor.UseVisualStyleBackColor = true;
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(271, 100);
			this.txtZip.MaxLength = 10;
			this.txtZip.Name = "txtZip";
			this.txtZip.ReadOnly = true;
			this.txtZip.Size = new System.Drawing.Size(70, 20);
			this.txtZip.TabIndex = 11;
			this.toolTip.SetToolTip(this.txtZip, "Zip Code (for internet service, etc.)");
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(3, 61);
			this.txtAddress.MaxLength = 64;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(338, 20);
			this.txtAddress.TabIndex = 5;
			this.toolTip.SetToolTip(this.txtAddress, "Address where this asset is located.\r\n(Use proper address for best geocoding resu" +
        "lts.)");
			// 
			// btnAsset_ViewLatLongMap
			// 
			this.btnAsset_ViewLatLongMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAsset_ViewLatLongMap.Enabled = false;
			this.btnAsset_ViewLatLongMap.FlatAppearance.BorderSize = 0;
			this.btnAsset_ViewLatLongMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAsset_ViewLatLongMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsset_ViewLatLongMap.Image = global::SDB.Properties.Resources.map_icon;
			this.btnAsset_ViewLatLongMap.Location = new System.Drawing.Point(346, 142);
			this.btnAsset_ViewLatLongMap.Name = "btnAsset_ViewLatLongMap";
			this.btnAsset_ViewLatLongMap.Size = new System.Drawing.Size(16, 16);
			this.btnAsset_ViewLatLongMap.TabIndex = 18;
			this.toolTip.SetToolTip(this.btnAsset_ViewLatLongMap, "View location on map.");
			this.btnAsset_ViewLatLongMap.UseVisualStyleBackColor = true;
			this.btnAsset_ViewLatLongMap.Click += new System.EventHandler(this.btnAsset_ViewLatLongMap_Click);
			// 
			// txtAsset_CustomerTag
			// 
			this.txtAsset_CustomerTag.Location = new System.Drawing.Point(87, 145);
			this.txtAsset_CustomerTag.MaxLength = 40;
			this.txtAsset_CustomerTag.Name = "txtAsset_CustomerTag";
			this.txtAsset_CustomerTag.ReadOnly = true;
			this.txtAsset_CustomerTag.Size = new System.Drawing.Size(122, 20);
			this.txtAsset_CustomerTag.TabIndex = 25;
			this.toolTip.SetToolTip(this.txtAsset_CustomerTag, "The Customer Tag Assigned to this Asset");
			// 
			// txtAsset_AssignedSsr
			// 
			this.txtAsset_AssignedSsr.Location = new System.Drawing.Point(87, 168);
			this.txtAsset_AssignedSsr.MaxLength = 40;
			this.txtAsset_AssignedSsr.Name = "txtAsset_AssignedSsr";
			this.txtAsset_AssignedSsr.ReadOnly = true;
			this.txtAsset_AssignedSsr.Size = new System.Drawing.Size(122, 20);
			this.txtAsset_AssignedSsr.TabIndex = 27;
			this.toolTip.SetToolTip(this.txtAsset_AssignedSsr, "The Customer Tag Assigned to this Asset");
			// 
			// cmbAsset_ControllerHardware
			// 
			this.cmbAsset_ControllerHardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_ControllerHardware.Enabled = false;
			this.cmbAsset_ControllerHardware.FormattingEnabled = true;
			this.cmbAsset_ControllerHardware.Location = new System.Drawing.Point(245, 20);
			this.cmbAsset_ControllerHardware.Name = "cmbAsset_ControllerHardware";
			this.cmbAsset_ControllerHardware.Size = new System.Drawing.Size(149, 21);
			this.cmbAsset_ControllerHardware.TabIndex = 21;
			this.toolTip.SetToolTip(this.cmbAsset_ControllerHardware, "Type of hardware serving as sign controller. (Computer type, controller card, etc" +
        ".)");
			// 
			// cmbAsset_ControllerSoftware
			// 
			this.cmbAsset_ControllerSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_ControllerSoftware.Enabled = false;
			this.cmbAsset_ControllerSoftware.FormattingEnabled = true;
			this.cmbAsset_ControllerSoftware.Location = new System.Drawing.Point(245, 59);
			this.cmbAsset_ControllerSoftware.Name = "cmbAsset_ControllerSoftware";
			this.cmbAsset_ControllerSoftware.Size = new System.Drawing.Size(149, 21);
			this.cmbAsset_ControllerSoftware.TabIndex = 23;
			this.toolTip.SetToolTip(this.cmbAsset_ControllerSoftware, "Software used to control sign. (System, Matrix, Broker, Embedded, etc.)");
			// 
			// cmbAsset_ControllerConnection
			// 
			this.cmbAsset_ControllerConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_ControllerConnection.Enabled = false;
			this.cmbAsset_ControllerConnection.FormattingEnabled = true;
			this.cmbAsset_ControllerConnection.Location = new System.Drawing.Point(245, 98);
			this.cmbAsset_ControllerConnection.Name = "cmbAsset_ControllerConnection";
			this.cmbAsset_ControllerConnection.Size = new System.Drawing.Size(149, 21);
			this.cmbAsset_ControllerConnection.TabIndex = 25;
			this.toolTip.SetToolTip(this.cmbAsset_ControllerConnection, "Connection method between controller and sign. (Direct, Fiber, Wireless, etc.)");
			// 
			// cmbAsset_LiftType
			// 
			this.cmbAsset_LiftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_LiftType.Enabled = false;
			this.cmbAsset_LiftType.FormattingEnabled = true;
			this.cmbAsset_LiftType.Location = new System.Drawing.Point(6, 19);
			this.cmbAsset_LiftType.Name = "cmbAsset_LiftType";
			this.cmbAsset_LiftType.Size = new System.Drawing.Size(162, 21);
			this.cmbAsset_LiftType.TabIndex = 21;
			this.toolTip.SetToolTip(this.cmbAsset_LiftType, "Type of lift required to service asset.");
			// 
			// lblAccessNotes
			// 
			this.lblAccessNotes.AutoSize = true;
			this.lblAccessNotes.Location = new System.Drawing.Point(6, 43);
			this.lblAccessNotes.Name = "lblAccessNotes";
			this.lblAccessNotes.Size = new System.Drawing.Size(138, 13);
			this.lblAccessNotes.TabIndex = 24;
			this.lblAccessNotes.Text = "Access Notes (sent to ASC)";
			this.toolTip.SetToolTip(this.lblAccessNotes, "Physical- or security-related instructions for accessing the property and/or comp" +
        "onents of the asset.");
			// 
			// cmbAsset_ClientConnection
			// 
			this.cmbAsset_ClientConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset_ClientConnection.Enabled = false;
			this.cmbAsset_ClientConnection.FormattingEnabled = true;
			this.cmbAsset_ClientConnection.Location = new System.Drawing.Point(244, 180);
			this.cmbAsset_ClientConnection.Name = "cmbAsset_ClientConnection";
			this.cmbAsset_ClientConnection.Size = new System.Drawing.Size(149, 21);
			this.cmbAsset_ClientConnection.TabIndex = 32;
			this.toolTip.SetToolTip(this.cmbAsset_ClientConnection, "Connection method between controller and sign. (Direct, Fiber, Wireless, etc.)");
			// 
			// numAsset_FaceQty
			// 
			this.numAsset_FaceQty.Location = new System.Drawing.Point(184, 100);
			this.numAsset_FaceQty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numAsset_FaceQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numAsset_FaceQty.Name = "numAsset_FaceQty";
			this.numAsset_FaceQty.ReadOnly = true;
			this.numAsset_FaceQty.Size = new System.Drawing.Size(50, 20);
			this.numAsset_FaceQty.TabIndex = 15;
			this.toolTip.SetToolTip(this.numAsset_FaceQty, "Number of faces (does not apply to back-to-back assets). A master/slave setup wou" +
        "ld be 2, for example.");
			this.numAsset_FaceQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numAsset_FaceQty.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_MatrixY
			// 
			this.numAsset_MatrixY.Location = new System.Drawing.Point(80, 60);
			this.numAsset_MatrixY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numAsset_MatrixY.Name = "numAsset_MatrixY";
			this.numAsset_MatrixY.ReadOnly = true;
			this.numAsset_MatrixY.Size = new System.Drawing.Size(56, 20);
			this.numAsset_MatrixY.TabIndex = 9;
			this.toolTip.SetToolTip(this.numAsset_MatrixY, "Number of pixels high.");
			this.numAsset_MatrixY.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_MatrixX
			// 
			this.numAsset_MatrixX.Location = new System.Drawing.Point(6, 60);
			this.numAsset_MatrixX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numAsset_MatrixX.Name = "numAsset_MatrixX";
			this.numAsset_MatrixX.ReadOnly = true;
			this.numAsset_MatrixX.Size = new System.Drawing.Size(56, 20);
			this.numAsset_MatrixX.TabIndex = 7;
			this.toolTip.SetToolTip(this.numAsset_MatrixX, "Number of pixels wide.");
			this.numAsset_MatrixX.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_Pitch
			// 
			this.numAsset_Pitch.Location = new System.Drawing.Point(184, 60);
			this.numAsset_Pitch.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numAsset_Pitch.Name = "numAsset_Pitch";
			this.numAsset_Pitch.ReadOnly = true;
			this.numAsset_Pitch.Size = new System.Drawing.Size(50, 20);
			this.numAsset_Pitch.TabIndex = 11;
			this.toolTip.SetToolTip(this.numAsset_Pitch, "Distance between pixels, center to center, in millimeters.");
			this.numAsset_Pitch.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_HAGL
			// 
			this.numAsset_HAGL.Location = new System.Drawing.Point(6, 138);
			this.numAsset_HAGL.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numAsset_HAGL.Name = "numAsset_HAGL";
			this.numAsset_HAGL.ReadOnly = true;
			this.numAsset_HAGL.Size = new System.Drawing.Size(50, 20);
			this.numAsset_HAGL.TabIndex = 29;
			this.toolTip.SetToolTip(this.numAsset_HAGL, "Height above ground level (HAGL).");
			this.numAsset_HAGL.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_InterfaceQty
			// 
			this.numAsset_InterfaceQty.Location = new System.Drawing.Point(124, 22);
			this.numAsset_InterfaceQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numAsset_InterfaceQty.Name = "numAsset_InterfaceQty";
			this.numAsset_InterfaceQty.ReadOnly = true;
			this.numAsset_InterfaceQty.Size = new System.Drawing.Size(44, 20);
			this.numAsset_InterfaceQty.TabIndex = 3;
			this.toolTip.SetToolTip(this.numAsset_InterfaceQty, "Number of interfaces in the display.");
			this.numAsset_InterfaceQty.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numAsset_LiftHeight
			// 
			this.numAsset_LiftHeight.Location = new System.Drawing.Point(184, 20);
			this.numAsset_LiftHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numAsset_LiftHeight.Name = "numAsset_LiftHeight";
			this.numAsset_LiftHeight.ReadOnly = true;
			this.numAsset_LiftHeight.Size = new System.Drawing.Size(50, 20);
			this.numAsset_LiftHeight.TabIndex = 23;
			this.toolTip.SetToolTip(this.numAsset_LiftHeight, "Height of lift required to service asset.");
			// 
			// ndtpAsset_InstallDateTime
			// 
			this.ndtpAsset_InstallDateTime.CustomFormat = " ";
			this.ndtpAsset_InstallDateTime.Enabled = false;
			this.ndtpAsset_InstallDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpAsset_InstallDateTime.Location = new System.Drawing.Point(283, 183);
			this.ndtpAsset_InstallDateTime.Name = "ndtpAsset_InstallDateTime";
			this.ndtpAsset_InstallDateTime.Size = new System.Drawing.Size(123, 20);
			this.ndtpAsset_InstallDateTime.TabIndex = 23;
			this.toolTip.SetToolTip(this.ndtpAsset_InstallDateTime, "Date this asset was installed. (Start of the labor warranty.)");
			this.ndtpAsset_InstallDateTime.Value = null;
			// 
			// ndtpAsset_ShippedDateTime
			// 
			this.ndtpAsset_ShippedDateTime.CustomFormat = " ";
			this.ndtpAsset_ShippedDateTime.Enabled = false;
			this.ndtpAsset_ShippedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpAsset_ShippedDateTime.Location = new System.Drawing.Point(283, 164);
			this.ndtpAsset_ShippedDateTime.Name = "ndtpAsset_ShippedDateTime";
			this.ndtpAsset_ShippedDateTime.Size = new System.Drawing.Size(123, 20);
			this.ndtpAsset_ShippedDateTime.TabIndex = 21;
			this.toolTip.SetToolTip(this.ndtpAsset_ShippedDateTime, "Date this asset was shipped. (Start of the parts warranty.)");
			this.ndtpAsset_ShippedDateTime.Value = null;
			// 
			// cmbChipType
			// 
			this.cmbChipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbChipType.Enabled = false;
			this.cmbChipType.FormattingEnabled = true;
			this.cmbChipType.Items.AddRange(new object[] {
            "ST",
            "TI",
            "Gen 6",
            "Gen 7 ",
            "Gen 8"});
			this.cmbChipType.Location = new System.Drawing.Point(184, 21);
			this.cmbChipType.Name = "cmbChipType";
			this.cmbChipType.Size = new System.Drawing.Size(50, 21);
			this.cmbChipType.TabIndex = 33;
			this.toolTip.SetToolTip(this.cmbChipType, "Type of hardware serving as sign controller. (Computer type, controller card, etc" +
        ".)");
			// 
			// cmbInterfaceType
			// 
			this.cmbInterfaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInterfaceType.Enabled = false;
			this.cmbInterfaceType.FormattingEnabled = true;
			this.cmbInterfaceType.Items.AddRange(new object[] {
            "Y4D",
            "Y4DVIX8",
            "Y5DVIX8",
            "Y6DVIX8",
            "Y7DVIX16E",
            "Y7DVIX16S",
            "Legacy"});
			this.cmbInterfaceType.Location = new System.Drawing.Point(6, 20);
			this.cmbInterfaceType.Name = "cmbInterfaceType";
			this.cmbInterfaceType.Size = new System.Drawing.Size(95, 21);
			this.cmbInterfaceType.TabIndex = 34;
			this.toolTip.SetToolTip(this.cmbInterfaceType, "Type of hardware serving as sign controller. (Computer type, controller card, etc" +
        ".)");
			// 
			// cmbPlayerSoftware
			// 
			this.cmbPlayerSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPlayerSoftware.Enabled = false;
			this.cmbPlayerSoftware.FormattingEnabled = true;
			this.cmbPlayerSoftware.Location = new System.Drawing.Point(6, 180);
			this.cmbPlayerSoftware.Name = "cmbPlayerSoftware";
			this.cmbPlayerSoftware.Size = new System.Drawing.Size(149, 21);
			this.cmbPlayerSoftware.TabIndex = 36;
			this.toolTip.SetToolTip(this.cmbPlayerSoftware, "Connection method between controller and sign. (Direct, Fiber, Wireless, etc.)");
			// 
			// pnlPhysical
			// 
			this.pnlPhysical.BackColor = System.Drawing.Color.LightGray;
			this.pnlPhysical.Controls.Add(this.lblPlayerSoftware);
			this.pnlPhysical.Controls.Add(this.cmbPlayerSoftware);
			this.pnlPhysical.Controls.Add(this.cmbInterfaceType);
			this.pnlPhysical.Controls.Add(this.cmbChipType);
			this.pnlPhysical.Controls.Add(this.label2);
			this.pnlPhysical.Controls.Add(this.cmbAsset_ClientConnection);
			this.pnlPhysical.Controls.Add(this.lblAsset_ControllerConnection);
			this.pnlPhysical.Controls.Add(this.lblAsset_ControllerSoftware);
			this.pnlPhysical.Controls.Add(this.lblAsset_ControllerHardware);
			this.pnlPhysical.Controls.Add(this.lblOutputType);
			this.pnlPhysical.Controls.Add(this.lblInterfaceQty);
			this.pnlPhysical.Controls.Add(this.chkIndoor);
			this.pnlPhysical.Controls.Add(this.cmbAsset_ControllerConnection);
			this.pnlPhysical.Controls.Add(this.cmbAsset_ControllerSoftware);
			this.pnlPhysical.Controls.Add(this.cmbAsset_ControllerHardware);
			this.pnlPhysical.Controls.Add(this.cmbAsset_OutputMethod);
			this.pnlPhysical.Controls.Add(this.lblAsset_FaceQty);
			this.pnlPhysical.Controls.Add(this.numAsset_FaceQty);
			this.pnlPhysical.Controls.Add(this.cmbAsset_CabinetType);
			this.pnlPhysical.Controls.Add(this.lblMatrixX);
			this.pnlPhysical.Controls.Add(this.numAsset_MatrixY);
			this.pnlPhysical.Controls.Add(this.numAsset_MatrixX);
			this.pnlPhysical.Controls.Add(this.numAsset_Pitch);
			this.pnlPhysical.Controls.Add(this.lblInterfaceType);
			this.pnlPhysical.Controls.Add(this.lblAsset_Pitch);
			this.pnlPhysical.Controls.Add(this.lblMatrix);
			this.pnlPhysical.Controls.Add(this.lblAsset_CabinetType);
			this.pnlPhysical.Controls.Add(this.lblAsset_HAGL);
			this.pnlPhysical.Controls.Add(this.lblAsset_ChipType);
			this.pnlPhysical.Controls.Add(this.numAsset_HAGL);
			this.pnlPhysical.Controls.Add(this.numAsset_InterfaceQty);
			this.pnlPhysical.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPhysical.Location = new System.Drawing.Point(3, 3);
			this.pnlPhysical.Name = "pnlPhysical";
			this.pnlPhysical.Size = new System.Drawing.Size(399, 223);
			this.pnlPhysical.TabIndex = 2;
			// 
			// lblPlayerSoftware
			// 
			this.lblPlayerSoftware.AutoSize = true;
			this.lblPlayerSoftware.Location = new System.Drawing.Point(3, 165);
			this.lblPlayerSoftware.Name = "lblPlayerSoftware";
			this.lblPlayerSoftware.Size = new System.Drawing.Size(81, 13);
			this.lblPlayerSoftware.TabIndex = 35;
			this.lblPlayerSoftware.Text = "Player Software";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(241, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 31;
			this.label2.Text = "Client Connection";
			// 
			// lblAsset_ControllerConnection
			// 
			this.lblAsset_ControllerConnection.AutoSize = true;
			this.lblAsset_ControllerConnection.Location = new System.Drawing.Point(242, 83);
			this.lblAsset_ControllerConnection.Name = "lblAsset_ControllerConnection";
			this.lblAsset_ControllerConnection.Size = new System.Drawing.Size(108, 13);
			this.lblAsset_ControllerConnection.TabIndex = 24;
			this.lblAsset_ControllerConnection.Text = "Controller Connection";
			// 
			// lblAsset_ControllerSoftware
			// 
			this.lblAsset_ControllerSoftware.AutoSize = true;
			this.lblAsset_ControllerSoftware.Location = new System.Drawing.Point(242, 44);
			this.lblAsset_ControllerSoftware.Name = "lblAsset_ControllerSoftware";
			this.lblAsset_ControllerSoftware.Size = new System.Drawing.Size(96, 13);
			this.lblAsset_ControllerSoftware.TabIndex = 22;
			this.lblAsset_ControllerSoftware.Text = "Controller Software";
			// 
			// lblAsset_ControllerHardware
			// 
			this.lblAsset_ControllerHardware.AutoSize = true;
			this.lblAsset_ControllerHardware.Location = new System.Drawing.Point(242, 5);
			this.lblAsset_ControllerHardware.Name = "lblAsset_ControllerHardware";
			this.lblAsset_ControllerHardware.Size = new System.Drawing.Size(100, 13);
			this.lblAsset_ControllerHardware.TabIndex = 20;
			this.lblAsset_ControllerHardware.Text = "Controller Hardware";
			// 
			// lblOutputType
			// 
			this.lblOutputType.AutoSize = true;
			this.lblOutputType.Location = new System.Drawing.Point(242, 122);
			this.lblOutputType.Name = "lblOutputType";
			this.lblOutputType.Size = new System.Drawing.Size(104, 13);
			this.lblOutputType.TabIndex = 26;
			this.lblOutputType.Text = "Header Output Type";
			// 
			// lblInterfaceQty
			// 
			this.lblInterfaceQty.AutoSize = true;
			this.lblInterfaceQty.Location = new System.Drawing.Point(107, 5);
			this.lblInterfaceQty.Name = "lblInterfaceQty";
			this.lblInterfaceQty.Size = new System.Drawing.Size(68, 13);
			this.lblInterfaceQty.TabIndex = 2;
			this.lblInterfaceQty.Text = "Interface Qty";
			// 
			// lblAsset_FaceQty
			// 
			this.lblAsset_FaceQty.AutoSize = true;
			this.lblAsset_FaceQty.Location = new System.Drawing.Point(181, 83);
			this.lblAsset_FaceQty.Name = "lblAsset_FaceQty";
			this.lblAsset_FaceQty.Size = new System.Drawing.Size(50, 13);
			this.lblAsset_FaceQty.TabIndex = 14;
			this.lblAsset_FaceQty.Text = "Face Qty";
			// 
			// lblMatrixX
			// 
			this.lblMatrixX.AutoSize = true;
			this.lblMatrixX.Location = new System.Drawing.Point(65, 62);
			this.lblMatrixX.Name = "lblMatrixX";
			this.lblMatrixX.Size = new System.Drawing.Size(12, 13);
			this.lblMatrixX.TabIndex = 8;
			this.lblMatrixX.Text = "x";
			this.lblMatrixX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAsset_SharesLocation
			// 
			this.lblAsset_SharesLocation.AutoSize = true;
			this.lblAsset_SharesLocation.Location = new System.Drawing.Point(3, 162);
			this.lblAsset_SharesLocation.Name = "lblAsset_SharesLocation";
			this.lblAsset_SharesLocation.Size = new System.Drawing.Size(109, 13);
			this.lblAsset_SharesLocation.TabIndex = 20;
			this.lblAsset_SharesLocation.Text = "Shares Location With";
			this.lblAsset_SharesLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pnlOwnershipInformation
			// 
			this.pnlOwnershipInformation.BackColor = System.Drawing.Color.LightGray;
			this.pnlOwnershipInformation.Controls.Add(this.cbxIsPMC);
			this.pnlOwnershipInformation.Controls.Add(this.chkManagedByMedia);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_AssignedSsr);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_AssignedSsr);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_CustomerTag);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_CustomerTag);
			this.pnlOwnershipInformation.Controls.Add(this.lblStatus);
			this.pnlOwnershipInformation.Controls.Add(this.btnAsset_SelectMarket);
			this.pnlOwnershipInformation.Controls.Add(this.lblOwnershipInformation);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_Customer);
			this.pnlOwnershipInformation.Controls.Add(this.ndtpAsset_InstallDateTime);
			this.pnlOwnershipInformation.Controls.Add(this.ucWarrantyStatus1);
			this.pnlOwnershipInformation.Controls.Add(this.ndtpAsset_ShippedDateTime);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_Customer);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_Release);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_Market);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_Market);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_AssetName);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_AssetName);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_Panel);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_Panel);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_InstalledDateTime);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_ShippedDateTime);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_Release);
			this.pnlOwnershipInformation.Controls.Add(this.txtAsset_SerialNumber);
			this.pnlOwnershipInformation.Controls.Add(this.lblAsset_SerialNumber);
			this.pnlOwnershipInformation.Location = new System.Drawing.Point(3, 36);
			this.pnlOwnershipInformation.Name = "pnlOwnershipInformation";
			this.pnlOwnershipInformation.Size = new System.Drawing.Size(413, 255);
			this.pnlOwnershipInformation.TabIndex = 1;
			// 
			// cbxIsPMC
			// 
			this.cbxIsPMC.AutoSize = true;
			this.cbxIsPMC.Enabled = false;
			this.cbxIsPMC.Location = new System.Drawing.Point(309, 85);
			this.cbxIsPMC.Name = "cbxIsPMC";
			this.cbxIsPMC.Size = new System.Drawing.Size(78, 17);
			this.cbxIsPMC.TabIndex = 29;
			this.cbxIsPMC.Text = "PMC Asset";
			this.cbxIsPMC.UseVisualStyleBackColor = true;
			// 
			// chkManagedByMedia
			// 
			this.chkManagedByMedia.AutoSize = true;
			this.chkManagedByMedia.Enabled = false;
			this.chkManagedByMedia.Location = new System.Drawing.Point(309, 107);
			this.chkManagedByMedia.Name = "chkManagedByMedia";
			this.chkManagedByMedia.Size = new System.Drawing.Size(97, 30);
			this.chkManagedByMedia.TabIndex = 28;
			this.chkManagedByMedia.Text = "Managed By \r\nCreative Group";
			this.chkManagedByMedia.UseVisualStyleBackColor = true;
			// 
			// lblAsset_AssignedSsr
			// 
			this.lblAsset_AssignedSsr.AutoSize = true;
			this.lblAsset_AssignedSsr.Location = new System.Drawing.Point(10, 167);
			this.lblAsset_AssignedSsr.Name = "lblAsset_AssignedSsr";
			this.lblAsset_AssignedSsr.Size = new System.Drawing.Size(75, 13);
			this.lblAsset_AssignedSsr.TabIndex = 26;
			this.lblAsset_AssignedSsr.Text = "Assigned SSR";
			// 
			// lblAsset_CustomerTag
			// 
			this.lblAsset_CustomerTag.AutoSize = true;
			this.lblAsset_CustomerTag.Location = new System.Drawing.Point(4, 147);
			this.lblAsset_CustomerTag.Name = "lblAsset_CustomerTag";
			this.lblAsset_CustomerTag.Size = new System.Drawing.Size(86, 13);
			this.lblAsset_CustomerTag.TabIndex = 24;
			this.lblAsset_CustomerTag.Text = "Display Category";
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.ForeColor = System.Drawing.Color.Silver;
			this.lblStatus.Location = new System.Drawing.Point(267, 227);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(136, 21);
			this.lblStatus.TabIndex = 17;
			this.lblStatus.Text = "STATUS";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatus.Click += new System.EventHandler(this.lblAsset_OpenTickets_Click);
			// 
			// lblOwnershipInformation
			// 
			this.lblOwnershipInformation.AutoEllipsis = true;
			this.lblOwnershipInformation.BackColor = System.Drawing.Color.Black;
			this.lblOwnershipInformation.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblOwnershipInformation.ForeColor = System.Drawing.Color.White;
			this.lblOwnershipInformation.Location = new System.Drawing.Point(0, 0);
			this.lblOwnershipInformation.Name = "lblOwnershipInformation";
			this.lblOwnershipInformation.Size = new System.Drawing.Size(413, 17);
			this.lblOwnershipInformation.TabIndex = 0;
			this.lblOwnershipInformation.Text = "Ownership Information";
			this.lblOwnershipInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ucWarrantyStatus1
			// 
			this.ucWarrantyStatus1.BackColor = System.Drawing.Color.Transparent;
			this.ucWarrantyStatus1.Location = new System.Drawing.Point(7, 194);
			this.ucWarrantyStatus1.Name = "ucWarrantyStatus1";
			this.ucWarrantyStatus1.Size = new System.Drawing.Size(240, 57);
			this.ucWarrantyStatus1.TabIndex = 16;
			this.ucWarrantyStatus1.Click += new System.EventHandler(this.ucWarrantyStatus1_Click);
			// 
			// pnlGeographic
			// 
			this.pnlGeographic.BackColor = System.Drawing.Color.LightGray;
			this.pnlGeographic.Controls.Add(this.lblLongitude);
			this.pnlGeographic.Controls.Add(this.lblAddress);
			this.pnlGeographic.Controls.Add(this.txtAddress);
			this.pnlGeographic.Controls.Add(this.lblFacing);
			this.pnlGeographic.Controls.Add(this.txtZip);
			this.pnlGeographic.Controls.Add(this.lblZip);
			this.pnlGeographic.Controls.Add(this.lblState);
			this.pnlGeographic.Controls.Add(this.lblCountry);
			this.pnlGeographic.Controls.Add(this.assetLinker1);
			this.pnlGeographic.Controls.Add(this.lblAsset_SharesLocation);
			this.pnlGeographic.Controls.Add(this.txtLocation);
			this.pnlGeographic.Controls.Add(this.lblLatitude);
			this.pnlGeographic.Controls.Add(this.txtLatitude);
			this.pnlGeographic.Controls.Add(this.txtLongitude);
			this.pnlGeographic.Controls.Add(this.btnAsset_ViewLatLongMap);
			this.pnlGeographic.Controls.Add(this.btnAsset_GeoCode);
			this.pnlGeographic.Controls.Add(this.txtState);
			this.pnlGeographic.Controls.Add(this.lblCity);
			this.pnlGeographic.Controls.Add(this.lblLocation);
			this.pnlGeographic.Controls.Add(this.cmbAsset_FacingDirection);
			this.pnlGeographic.Controls.Add(this.txtCity);
			this.pnlGeographic.Controls.Add(this.txtCountry);
			this.pnlGeographic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGeographic.Location = new System.Drawing.Point(3, 3);
			this.pnlGeographic.Name = "pnlGeographic";
			this.pnlGeographic.Size = new System.Drawing.Size(399, 223);
			this.pnlGeographic.TabIndex = 5;
			// 
			// lblLongitude
			// 
			this.lblLongitude.AutoSize = true;
			this.lblLongitude.Location = new System.Drawing.Point(257, 123);
			this.lblLongitude.Name = "lblLongitude";
			this.lblLongitude.Size = new System.Drawing.Size(54, 13);
			this.lblLongitude.TabIndex = 16;
			this.lblLongitude.Text = "Longitude";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(3, 45);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(45, 13);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
			// 
			// lblFacing
			// 
			this.lblFacing.AutoSize = true;
			this.lblFacing.Location = new System.Drawing.Point(344, 5);
			this.lblFacing.Name = "lblFacing";
			this.lblFacing.Size = new System.Drawing.Size(39, 13);
			this.lblFacing.TabIndex = 2;
			this.lblFacing.Text = "Facing";
			// 
			// lblZip
			// 
			this.lblZip.AutoSize = true;
			this.lblZip.Location = new System.Drawing.Point(268, 84);
			this.lblZip.Name = "lblZip";
			this.lblZip.Size = new System.Drawing.Size(72, 13);
			this.lblZip.TabIndex = 10;
			this.lblZip.Text = "Zip/Postcode";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(230, 84);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(32, 13);
			this.lblState.TabIndex = 8;
			this.lblState.Text = "State";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(3, 123);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(43, 13);
			this.lblCountry.TabIndex = 12;
			this.lblCountry.Text = "Country";
			// 
			// assetLinker1
			// 
			this.assetLinker1.Location = new System.Drawing.Point(3, 176);
			this.assetLinker1.Name = "assetLinker1";
			this.assetLinker1.Size = new System.Drawing.Size(337, 39);
			this.assetLinker1.TabIndex = 21;
			this.assetLinker1.AssetClicked += new SDB.UserControls.Asset.AssetLinker.AssetEvent(this.assetLinker1_AssetClicked);
			// 
			// tabPhysGeo
			// 
			this.tabPhysGeo.Controls.Add(this.tabPhysical);
			this.tabPhysGeo.Controls.Add(this.tabGeograpic);
			this.tabPhysGeo.Controls.Add(this.tabAccess);
			this.tabPhysGeo.Location = new System.Drawing.Point(423, 36);
			this.tabPhysGeo.Multiline = true;
			this.tabPhysGeo.Name = "tabPhysGeo";
			this.tabPhysGeo.SelectedIndex = 0;
			this.tabPhysGeo.Size = new System.Drawing.Size(413, 255);
			this.tabPhysGeo.TabIndex = 2;
			// 
			// tabPhysical
			// 
			this.tabPhysical.Controls.Add(this.pnlPhysical);
			this.tabPhysical.Location = new System.Drawing.Point(4, 22);
			this.tabPhysical.Name = "tabPhysical";
			this.tabPhysical.Padding = new System.Windows.Forms.Padding(3);
			this.tabPhysical.Size = new System.Drawing.Size(405, 229);
			this.tabPhysical.TabIndex = 0;
			this.tabPhysical.Text = "Physical Specifications";
			this.tabPhysical.UseVisualStyleBackColor = true;
			// 
			// tabGeograpic
			// 
			this.tabGeograpic.Controls.Add(this.pnlGeographic);
			this.tabGeograpic.Location = new System.Drawing.Point(4, 22);
			this.tabGeograpic.Name = "tabGeograpic";
			this.tabGeograpic.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeograpic.Size = new System.Drawing.Size(405, 229);
			this.tabGeograpic.TabIndex = 1;
			this.tabGeograpic.Text = "Geographic Location";
			this.tabGeograpic.UseVisualStyleBackColor = true;
			// 
			// tabAccess
			// 
			this.tabAccess.Controls.Add(this.txtAccessNotes);
			this.tabAccess.Controls.Add(this.lblAccessNotes);
			this.tabAccess.Controls.Add(this.label1);
			this.tabAccess.Controls.Add(this.cmbAsset_LiftType);
			this.tabAccess.Controls.Add(this.lblAsset_LiftType);
			this.tabAccess.Controls.Add(this.numAsset_LiftHeight);
			this.tabAccess.Location = new System.Drawing.Point(4, 22);
			this.tabAccess.Name = "tabAccess";
			this.tabAccess.Padding = new System.Windows.Forms.Padding(3);
			this.tabAccess.Size = new System.Drawing.Size(405, 229);
			this.tabAccess.TabIndex = 2;
			this.tabAccess.Text = "Access Information";
			this.tabAccess.UseVisualStyleBackColor = true;
			// 
			// txtAccessNotes
			// 
			this.txtAccessNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txtAccessNotes.Location = new System.Drawing.Point(3, 59);
			this.txtAccessNotes.MaxLength = 2048;
			this.txtAccessNotes.Multiline = true;
			this.txtAccessNotes.Name = "txtAccessNotes";
			this.txtAccessNotes.ReadOnly = true;
			this.txtAccessNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtAccessNotes.Size = new System.Drawing.Size(399, 167);
			this.txtAccessNotes.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(181, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Lift Height";
			// 
			// lblAsset_LiftType
			// 
			this.lblAsset_LiftType.AutoSize = true;
			this.lblAsset_LiftType.Location = new System.Drawing.Point(3, 3);
			this.lblAsset_LiftType.Name = "lblAsset_LiftType";
			this.lblAsset_LiftType.Size = new System.Drawing.Size(48, 13);
			this.lblAsset_LiftType.TabIndex = 20;
			this.lblAsset_LiftType.Text = "Lift Type";
			// 
			// AssetEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.tabPhysGeo);
			this.Controls.Add(this.pnlOwnershipInformation);
			this.Controls.Add(this.pnlAdditional);
			this.Controls.Add(this.pnlControl_Bottom);
			this.Controls.Add(this.pnlControl_Top);
			this.Name = "AssetEditor";
			this.Size = new System.Drawing.Size(839, 667);
			((System.ComponentModel.ISupportInitialize)(pbMonitoring_PVMLogo)).EndInit();
			this.pnlControl_Bottom.ResumeLayout(false);
			this.pnlControl_Top.ResumeLayout(false);
			this.pnlControl_Top.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.pnlAdditional.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabNotes.ResumeLayout(false);
			this.pnlGeneralNotes.ResumeLayout(false);
			this.pnlGeneralNotes.PerformLayout();
			this.tabTicketHistory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvTicketHistory)).EndInit();
			this.pnlTicketHistory_Control.ResumeLayout(false);
			this.pnlTicketHistory_Control.PerformLayout();
			this.tabNetwork.ResumeLayout(false);
			this.pnlNetwork.ResumeLayout(false);
			this.pnlNetwork.PerformLayout();
			this.pnlCradlepoint.ResumeLayout(false);
			this.pnlCradlepoint.PerformLayout();
			this.pnlNetwork_System.ResumeLayout(false);
			this.pnlNetwork_System.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_SystemPort)).EndInit();
			this.pnlNetwork_Player.ResumeLayout(false);
			this.pnlNetwork_Player.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_PlayerPort)).EndInit();
			this.pnlNetwork_Remote.ResumeLayout(false);
			this.pnlNetwork_Remote.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_RemoteVncWebPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_RemoteVncPort)).EndInit();
			this.pnlNetwork_MiniGoose.ResumeLayout(false);
			this.pnlNetwork_MiniGoose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_MiniGoosePort)).EndInit();
			this.pnlNetwork_IBoot.ResumeLayout(false);
			this.pnlNetwork_IBoot.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_IBootPort)).EndInit();
			this.pnlNetwork_Camera.ResumeLayout(false);
			this.pnlNetwork_Camera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_CameraPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numNetwork_CameraChannel)).EndInit();
			this.pnlNetwork_Server.ResumeLayout(false);
			this.pnlNetwork_Server.PerformLayout();
			this.tabRMA.ResumeLayout(false);
			this.tabRMA.PerformLayout();
			this.tabDocuments.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvDocuments)).EndInit();
			this.pnlDocumentsControl.ResumeLayout(false);
			this.tabMonitoring.ResumeLayout(false);
			this.pnlMonitoringControl.ResumeLayout(false);
			this.pnlMonitoringControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_CameraCheckInterval)).EndInit();
			this.pnlMonitoring_WebcamMode.ResumeLayout(false);
			this.pnlMonitoring_WebcamMode.PerformLayout();
			this.pnlMonitoring_DataMode.ResumeLayout(false);
			this.pnlMonitoring_DataMode.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_HoldTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMonitoring_Interval)).EndInit();
			this.tabShipments.ResumeLayout(false);
			this.tabJournal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
			this.pnlJournal_Control.ResumeLayout(false);
			this.tabIBom.ResumeLayout(false);
			this.tabAssignedTechs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvAssignedTechs)).EndInit();
			this.pnlAssignedTechs_Control.ResumeLayout(false);
			this.pnlAssignedTechs_Control.PerformLayout();
			this.tabSpareParts.ResumeLayout(false);
			this.tabSystemBackups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numAsset_FaceQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_MatrixY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_MatrixX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_Pitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_HAGL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_InterfaceQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAsset_LiftHeight)).EndInit();
			this.pnlPhysical.ResumeLayout(false);
			this.pnlPhysical.PerformLayout();
			this.pnlOwnershipInformation.ResumeLayout(false);
			this.pnlOwnershipInformation.PerformLayout();
			this.pnlGeographic.ResumeLayout(false);
			this.pnlGeographic.PerformLayout();
			this.tabPhysGeo.ResumeLayout(false);
			this.tabPhysical.ResumeLayout(false);
			this.tabGeograpic.ResumeLayout(false);
			this.tabAccess.ResumeLayout(false);
			this.tabAccess.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControl_Bottom;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Panel pnlControl_Top;
		private System.Windows.Forms.Button btnEditSave;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlAdditional;
		private System.Windows.Forms.Label lblAsset_Customer;
		private WarrantyStatus ucWarrantyStatus1;
		private System.Windows.Forms.TextBox txtLongitude;
		private System.Windows.Forms.TextBox txtLatitude;
		private System.Windows.Forms.Label lblLatitude;
		private ClassFixedNumericUpDown numAsset_InterfaceQty;
		private ClassFixedNumericUpDown numAsset_HAGL;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtAsset_SerialNumber;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label lblAsset_HAGL;
		private System.Windows.Forms.Label lblAsset_SerialNumber;
		private System.Windows.Forms.Label lblMatrix;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblInterfaceType;
		private System.Windows.Forms.TextBox txtAsset_Release;
		private System.Windows.Forms.TextBox txtAsset_AssetName;
		private System.Windows.Forms.TextBox txtAsset_Panel;
		private System.Windows.Forms.Label lblAsset_InstalledDateTime;
		private System.Windows.Forms.Label lblAsset_ShippedDateTime;
		private System.Windows.Forms.Label lblAsset_Release;
		private System.Windows.Forms.Label lblAsset_Panel;
		private System.Windows.Forms.Label lblAsset_AssetName;
		private System.Windows.Forms.TextBox txtAsset_Market;
		private System.Windows.Forms.Label lblAsset_Market;
		private System.Windows.Forms.TextBox txtAsset_Customer;
		private System.Windows.Forms.ToolTip toolTip;
		private NullableDateTimePicker ndtpAsset_InstallDateTime;
		private NullableDateTimePicker ndtpAsset_ShippedDateTime;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnAsset_ViewLatLongMap;
		private System.Windows.Forms.Button btnAsset_SelectMarket;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAsset_GeoCode;
		private System.Windows.Forms.Label lblAsset_CabinetType;
		private System.Windows.Forms.Label lblAsset_ChipType;
		private System.Windows.Forms.ComboBox cmbAsset_FacingDirection;
		private System.Windows.Forms.Label lblAsset_Pitch;
		private ClassFixedNumericUpDown numAsset_Pitch;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.CheckBox chkSubscribe;
		private System.Windows.Forms.Panel pnlPhysical;
		private System.Windows.Forms.Panel pnlOwnershipInformation;
		private System.Windows.Forms.Label lblOwnershipInformation;
		private System.Windows.Forms.Button btnVNC;
		private System.Windows.Forms.ComboBox cmbAsset_CabinetType;
		private System.Windows.Forms.Label lblMatrixX;
		private ClassFixedNumericUpDown numAsset_MatrixY;
		private ClassFixedNumericUpDown numAsset_MatrixX;
		private System.Windows.Forms.Label lblAsset_FaceQty;
		private ClassFixedNumericUpDown numAsset_FaceQty;
		private System.Windows.Forms.ComboBox cmbAsset_OutputMethod;
		private System.Windows.Forms.Label lblAsset_SharesLocation;
		private AssetLinker assetLinker1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnTeamViewer;
		private System.Windows.Forms.CheckBox chkIndoor;
		private System.Windows.Forms.Panel pnlGeographic;
		private System.Windows.Forms.Label lblInterfaceQty;
		private System.Windows.Forms.Label lblOutputType;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblFacing;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TabControl tabPhysGeo;
		private System.Windows.Forms.TabPage tabPhysical;
		private System.Windows.Forms.TabPage tabGeograpic;
		private System.Windows.Forms.Label lblLongitude;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem mnuAddNew;
		private System.Windows.Forms.ToolStripMenuItem mnuRetire;
		private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.TextBox txtAsset_AssignedSsr;
        private System.Windows.Forms.Label lblAsset_AssignedSsr;
        private System.Windows.Forms.TextBox txtAsset_CustomerTag;
        private System.Windows.Forms.Label lblAsset_CustomerTag;
        private System.Windows.Forms.CheckBox chkManagedByMedia;
		private System.Windows.Forms.Label lblAsset_ControllerConnection;
		private System.Windows.Forms.Label lblAsset_ControllerSoftware;
		private System.Windows.Forms.Label lblAsset_ControllerHardware;
		private System.Windows.Forms.ComboBox cmbAsset_ControllerConnection;
		private System.Windows.Forms.ComboBox cmbAsset_ControllerSoftware;
		private System.Windows.Forms.ComboBox cmbAsset_ControllerHardware;
		private System.Windows.Forms.TabPage tabAccess;
		private System.Windows.Forms.TextBox txtAccessNotes;
		private System.Windows.Forms.Label lblAccessNotes;
		private System.Windows.Forms.Label label1;
		private ClassFixedNumericUpDown numAsset_LiftHeight;
		private System.Windows.Forms.ComboBox cmbAsset_LiftType;
		private System.Windows.Forms.Label lblAsset_LiftType;
        private System.Windows.Forms.CheckBox cbxIsPMC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAsset_ClientConnection;
        private System.Windows.Forms.ComboBox cmbChipType;
        private System.Windows.Forms.ComboBox cmbInterfaceType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.Panel pnlGeneralNotes;
        private System.Windows.Forms.TextBox txtGeneralNotes;
        private System.Windows.Forms.Label lblGeneralNotes;
        private System.Windows.Forms.TabPage tabTicketHistory;
        private BrightIdeasSoftware.ObjectListView olvTicketHistory;
        private BrightIdeasSoftware.OLVColumn olcTicketHistory_TicketID;
        private BrightIdeasSoftware.OLVColumn olcTicketHistory_OpenDateTime;
        private BrightIdeasSoftware.OLVColumn olcTicketHistory_IssueNum;
        private BrightIdeasSoftware.OLVColumn olcTicketHistory_Symptoms;
        private BrightIdeasSoftware.OLVColumn olcTicketHistory_Solutions;
        private System.Windows.Forms.Panel pnlTicketHistory_Control;
        private System.Windows.Forms.Button btnSetServiceReminder;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Label lblTicketHistory_TicketQty;
        private System.Windows.Forms.TextBox txtTicketHistory_TicketQty;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.Panel pnlNetwork;
        private System.Windows.Forms.Panel pnlNetwork_System;
        private System.Windows.Forms.CheckBox chkNetwork_SystemSsl;
        private System.Windows.Forms.TextBox txtNetwork_SystemPassword;
        private System.Windows.Forms.Label lblNetwork_SystemPassword;
        private System.Windows.Forms.Label lblNetwork_System;
        private ClassFixedNumericUpDown numNetwork_SystemPort;
        private System.Windows.Forms.Label lblNetwork_SystemPort;
        private System.Windows.Forms.Panel pnlNetwork_Player;
        private System.Windows.Forms.CheckBox chkNetwork_PlayerSsl;
        private System.Windows.Forms.TextBox txtNetwork_PlayerPassword;
        private System.Windows.Forms.Label lblNetwork_PlayerPassword;
        private System.Windows.Forms.Label lblNetwork_PlayerPort;
        private ClassFixedNumericUpDown numNetwork_PlayerPort;
        private System.Windows.Forms.Label lblNetwork_Player;
        private System.Windows.Forms.Panel pnlNetwork_Remote;
        private System.Windows.Forms.TextBox txtNetwork_TeamviewerPassword;
        private System.Windows.Forms.Label lblNetwork_TeamviewerPassword;
        private ClassFixedNumericUpDown numNetwork_RemoteVncWebPort;
        private System.Windows.Forms.Label lblNetwork_TeamviewerID;
        private System.Windows.Forms.TextBox txtNetwork_TeamviewerID;
        private ClassFixedNumericUpDown numNetwork_RemoteVncPort;
        private System.Windows.Forms.Label lblNetwork_Remote;
        private System.Windows.Forms.Label lblNetwork_RemoteVncPort;
        private System.Windows.Forms.TextBox txtNetwork_RemoteVncPassword;
        private System.Windows.Forms.Label lblNetwork_RemoteVncPassword;
        private System.Windows.Forms.Label lblNetwork_RemoteVncWebPort;
        private System.Windows.Forms.Panel pnlNetwork_MiniGoose;
        private ClassFixedNumericUpDown numNetwork_MiniGoosePort;
        private System.Windows.Forms.Label lblNetwork_MiniGoose;
        private System.Windows.Forms.TextBox txtNetwork_MiniGooseLan;
        private System.Windows.Forms.TextBox txtNetwork_MiniGoosePassword;
        private System.Windows.Forms.Label lblNetwork_MiniGooseLan;
        private System.Windows.Forms.Label lblNetwork_MiniGoosePassword;
        private System.Windows.Forms.Label lblNetwork_MiniGoosePort;
        private System.Windows.Forms.Panel pnlNetwork_IBoot;
        private ClassFixedNumericUpDown numNetwork_IBootPort;
        private System.Windows.Forms.Label lblNetwork_IBoot;
        private System.Windows.Forms.TextBox txtNetwork_IBootLan;
        private System.Windows.Forms.TextBox txtNetwork_IBootPassword;
        private System.Windows.Forms.Label lblNetwork_IBootLan;
        private System.Windows.Forms.Label lblNetwork_IBootPassword;
        private System.Windows.Forms.Label lblNetwork_IBootPort;
        private System.Windows.Forms.Panel pnlNetwork_Camera;
        private System.Windows.Forms.Label lblNetwork_CameraAssembly;
        private System.Windows.Forms.Label lblNetwork_Camera;
        private System.Windows.Forms.TextBox txtNetwork_WebcamTypeAssemblyDesc;
        private System.Windows.Forms.ComboBox cmbNetwork_WebcamType;
        private System.Windows.Forms.Label lblNetwork_CameraLan;
        private System.Windows.Forms.Label lblNetwork_CameraTypeImage;
        private System.Windows.Forms.Label lblNetwork_CameraPort;
        private ClassFixedNumericUpDown numNetwork_CameraPort;
        private System.Windows.Forms.Label lblNetwork_CameraChannel;
        private System.Windows.Forms.TextBox txtNetwork_CameraUser;
        private System.Windows.Forms.Label lblNetwork_CameraPassword;
        private System.Windows.Forms.Label lblNetwork_CameraUser;
        private System.Windows.Forms.TextBox txtNetwork_CameraPassword;
        private ClassFixedNumericUpDown numNetwork_CameraChannel;
        private System.Windows.Forms.TextBox txtNetwork_CameraLan;
        private System.Windows.Forms.Panel pnlNetwork_Server;
        private System.Windows.Forms.Label lblNetwork_Server;
        private System.Windows.Forms.TextBox txtNetwork_ServerLan;
        private System.Windows.Forms.Label lblNetwork_ServerLan;
        private System.Windows.Forms.TextBox txtNetwork_ServerMask;
        private System.Windows.Forms.Label lblNetwork_ServerMask;
        private System.Windows.Forms.TextBox txtNetwork_ServerGateway;
        private System.Windows.Forms.Label lblNetwork_ServerGateway;
        private System.Windows.Forms.Label lblNetwork_Installed;
        private System.Windows.Forms.TextBox txtNetwork_ISP;
        private System.Windows.Forms.CheckBox chkNetwork_UseLAN;
        private System.Windows.Forms.Label lblNetwork_WAN;
        private System.Windows.Forms.CheckBox chkNetwork_CameraInstalled;
        private System.Windows.Forms.CheckBox chkNetwork_IBootInstalled;
        private System.Windows.Forms.CheckBox chkNetwork_MiniGooseInstalled;
        private System.Windows.Forms.Label lblNetwork_Router;
        private System.Windows.Forms.TextBox txtNetwork_WAN;
        private System.Windows.Forms.Label lblNetwork_ISP;
        private System.Windows.Forms.TextBox txtNetwork_Router;
        private System.Windows.Forms.TabPage tabRMA;
        private System.Windows.Forms.Label lblLegacyRMACount;
        private System.Windows.Forms.TextBox tbxLegacyRMACount;
        private System.Windows.Forms.RadioButton radRMA;
        private RmaList ucRMAList1;
        private System.Windows.Forms.TabPage tabDocuments;
        private BrightIdeasSoftware.ObjectListView olvDocuments;
        private BrightIdeasSoftware.OLVColumn olvDocumentsColumn;
        private BrightIdeasSoftware.OLVColumn olvDateColumn;
        private BrightIdeasSoftware.OLVColumn olvUserColumn;
        private System.Windows.Forms.Panel pnlDocumentsControl;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.Button btnRemoveDocument;
        private System.Windows.Forms.Button btnChangeDocument;
        private System.Windows.Forms.TabPage tabMonitoring;
        private System.Windows.Forms.Panel pnlMonitoringControl;
        private System.Windows.Forms.Label lblMonitoring_CameraCheckInterval;
        private ClassFixedNumericUpDown numMonitoring_CameraCheckInterval;
        private System.Windows.Forms.Label lblMonitoring_CameraCheckInterval_Unit;
        private System.Windows.Forms.TextBox txtMonitoring_BlackoutSchedule;
        private System.Windows.Forms.Label lblMonitoringControl;
        private System.Windows.Forms.Label lblMonitoring_HoldTimeSeconds;
        private System.Windows.Forms.Label lblMonitoring_ShowWebcamStatus;
        private System.Windows.Forms.Label lblMonitoring_StuckImageThreshold;
        private System.Windows.Forms.Label lblMonitoring_ShowDataStatus;
        private System.Windows.Forms.Button btnMonitoring_BlackoutSchedule;
        private System.Windows.Forms.Label lblMonitoring_Interval;
        private System.Windows.Forms.Panel pnlMonitoring_WebcamMode;
        private System.Windows.Forms.RadioButton radMonitoring_WebcamMode_Forced;
        private System.Windows.Forms.RadioButton radMonitoring_WebcamMode_Disabled;
        private System.Windows.Forms.RadioButton radMonitoring_WebcamMode_Auto;
        private System.Windows.Forms.Panel pnlMonitoring_DataMode;
        private System.Windows.Forms.RadioButton radMonitoring_DataMode_Forced;
        private System.Windows.Forms.RadioButton radMonitoring_DataMode_Disabled;
        private System.Windows.Forms.RadioButton radMonitoring_DataMode_Auto;
        private System.Windows.Forms.Label lblMonitoring_Webcam;
        private ClassFixedNumericUpDown numMonitoring_HoldTime;
        private ClassFixedNumericUpDown numMonitoring_Interval;
        private System.Windows.Forms.Label lblMonitoring_IntervalMinutes;
        private System.Windows.Forms.Label lblMonitoring_Data;
        private System.Windows.Forms.Label lblMonitoring_Status;
        private System.Windows.Forms.Label lblMonitoring_Mode;
        private System.Windows.Forms.TabPage tabShipments;
        private ucShipmentList ucShipmentList1;
        private System.Windows.Forms.TabPage tabJournal;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
        private System.Windows.Forms.Panel pnlJournal_Control;
        private System.Windows.Forms.Button btnJournal_Add;
        private System.Windows.Forms.TabPage tabIBom;
        private ucAsset_IBOM ucAsset_IBOM1;
        private System.Windows.Forms.TabPage tabAssignedTechs;
        private BrightIdeasSoftware.ObjectListView olvAssignedTechs;
        private BrightIdeasSoftware.OLVColumn olvColTechPriority;
        private BrightIdeasSoftware.OLVColumn olvColTechName;
        private BrightIdeasSoftware.OLVColumn olvColTechAddress;
        private BrightIdeasSoftware.OLVColumn colColTechCity;
        private BrightIdeasSoftware.OLVColumn olvColTechState;
        private BrightIdeasSoftware.OLVColumn olvColTechTelephone;
        private BrightIdeasSoftware.OLVColumn olvColTechStatus;
        private System.Windows.Forms.Panel pnlAssignedTechs_Control;
        private System.Windows.Forms.Button btnAssignedTechs_MoveUp;
        private System.Windows.Forms.Button btnAssignedTechs_Cancel;
        private System.Windows.Forms.Button btnAssignedTechs_Save;
        private System.Windows.Forms.Button btnAssignedTechs_Assign;
        private System.Windows.Forms.TabPage tabSpareParts;
        private ucAssetSpareParts ucAssetSpareParts1;
        private System.Windows.Forms.TabPage tabSystemBackups;
        private ucAssetSystemBackup ucAssetSystemBackup1;
        private System.Windows.Forms.CheckBox cbxUseRealVNC;
        private System.Windows.Forms.Panel pnlCradlepoint;
        private System.Windows.Forms.TextBox tbxCradlepointEmail;
        private System.Windows.Forms.Label lblResetEmail;
        private System.Windows.Forms.TextBox tbxCradlepointMAC;
        private System.Windows.Forms.Label lblCpMAC;
        private System.Windows.Forms.Label lblCradlepoint;
        private System.Windows.Forms.CheckBox cbxIsCradlepoint;
        private System.Windows.Forms.Label lblPlayerSoftware;
        private System.Windows.Forms.ComboBox cmbPlayerSoftware;
    }
}
