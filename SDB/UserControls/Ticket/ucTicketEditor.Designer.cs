using SDB.Classes.Misc;
using SDB.UserControls.Asset;
using SDB.UserControls.RMA;
using SDB.UserControls.Shipment;

namespace SDB.UserControls.Ticket
{
	partial class TicketEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblAsset_CustomerMarket = new System.Windows.Forms.Label();
            this.txtAsset_CustomerMarket = new System.Windows.Forms.TextBox();
            this.txtInvoiceNotes_LaborWC = new System.Windows.Forms.TextBox();
            this.lblInvoiceNotes_LaborWC = new System.Windows.Forms.Label();
            this.txtInvoiceNotes_PartsWC = new System.Windows.Forms.TextBox();
            this.lblInvoiceNotes_PartsWC = new System.Windows.Forms.Label();
            this.txtAsset_AssetName = new System.Windows.Forms.TextBox();
            this.txtAsset_Panel = new System.Windows.Forms.TextBox();
            this.txtAsset_Location = new System.Windows.Forms.TextBox();
            this.lblAsset_AssetName = new System.Windows.Forms.Label();
            this.lblAsset_Panel = new System.Windows.Forms.Label();
            this.lblAsset_Location = new System.Windows.Forms.Label();
            this.txtTicket_Duration = new System.Windows.Forms.TextBox();
            this.lblTicket_Duration = new System.Windows.Forms.Label();
            this.txtTicket_IssueNumber = new System.Windows.Forms.TextBox();
            this.txtTicket_JobOrderNumber = new System.Windows.Forms.TextBox();
            this.lblTicket_JobOrderNumber = new System.Windows.Forms.Label();
            this.lblTicket_ReceivedDate = new System.Windows.Forms.Label();
            this.lblTicket_IssueNumber = new System.Windows.Forms.Label();
            this.lblOSA = new System.Windows.Forms.Label();
            this.btnOSA_Tech_Log = new System.Windows.Forms.Button();
            this.btnOSA_Checklist = new System.Windows.Forms.Button();
            this.txtOSA_AssignedTech_Location = new System.Windows.Forms.TextBox();
            this.lblOSA_AssignedTech_Location = new System.Windows.Forms.Label();
            this.btnOSA_ChangeTech = new System.Windows.Forms.Button();
            this.txtOSA_AssignedTech = new System.Windows.Forms.TextBox();
            this.lblOSA_Comments = new System.Windows.Forms.Label();
            this.txtOSA_Comments = new System.Windows.Forms.TextBox();
            this.lblOSA_OSAEMailSent = new System.Windows.Forms.Label();
            this.chkOSA_TechOnSite = new System.Windows.Forms.CheckBox();
            this.lblOSA_AssignedTech = new System.Windows.Forms.Label();
            this.btnOSA_View = new System.Windows.Forms.Button();
            this.txtTicket_ReportedType = new System.Windows.Forms.TextBox();
            this.txtTicket_ReportedBy = new System.Windows.Forms.TextBox();
            this.lblTicket_ReportedType = new System.Windows.Forms.Label();
            this.lblTicket_ReportedBy = new System.Windows.Forms.Label();
            this.chkTicket_SendCloseEmail = new System.Windows.Forms.CheckBox();
            this.lblTicket_Status_Show = new System.Windows.Forms.Label();
            this.pnlControl_Top = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuTicket_HoldRelease = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket_Escalate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTicket_CreateOSA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket_SendOSA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket_SendOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket_SendClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTicket_BillableConfirmationEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnRebootCradle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTicket_Reassign = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket_DeleteRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlControl_Bottom = new System.Windows.Forms.Panel();
            this.btnTeamViewer = new System.Windows.Forms.Button();
            this.btnVNC = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabLegacyRMA = new System.Windows.Forms.TabPage();
            this.olvLegacyRMAs = new BrightIdeasSoftware.ObjectListView();
            this.olvColRMA_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMA_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMA_IssuedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMA_IssuedTo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRMA_Closed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRMA_Control = new System.Windows.Forms.Panel();
            this.lblRMAQty = new System.Windows.Forms.Label();
            this.txtRMAQty = new System.Windows.Forms.TextBox();
            this.tabShipments = new System.Windows.Forms.TabPage();
            this.tabRentals = new System.Windows.Forms.TabPage();
            this.txtTicket_Number = new System.Windows.Forms.TextBox();
            this.btnJournal_Add = new System.Windows.Forms.Button();
            this.radInvoiceNotes_Billable = new System.Windows.Forms.RadioButton();
            this.radInvoiceNotes_Covered = new System.Windows.Forms.RadioButton();
            this.txtTicket_ClosedBy = new System.Windows.Forms.TextBox();
            this.txtTicket_OpenedBy = new System.Windows.Forms.TextBox();
            this.txtTicket_CloseDate = new System.Windows.Forms.TextBox();
            this.txtTicket_OpenDate = new System.Windows.Forms.TextBox();
            this.txtTicket_ActiveDuration = new System.Windows.Forms.TextBox();
            this.cmbAsset_TicketHistory = new System.Windows.Forms.ComboBox();
            this.pbRental = new System.Windows.Forms.PictureBox();
            this.pbTechOnSite = new System.Windows.Forms.PictureBox();
            this.btnJournal_ScrollToFirst = new System.Windows.Forms.Button();
            this.pnlAdditional = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabJournal = new System.Windows.Forms.TabPage();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.colJournalUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlJournal_Control = new System.Windows.Forms.Panel();
            this.lblJournal_LastEntryExpiration = new System.Windows.Forms.Label();
            this.tabInvoiceNotes = new System.Windows.Forms.TabPage();
            this.pnlInvoiceNotes = new System.Windows.Forms.Panel();
            this.txtInvoiceNotes = new System.Windows.Forms.RichTextBox();
            this.lblInvoiceNotes = new System.Windows.Forms.Label();
            this.pnlInvoiceNotes_Billable = new System.Windows.Forms.Panel();
            this.pnlInvoiceNotes_Update = new System.Windows.Forms.Panel();
            this.btnInvoiceNotes_Update = new System.Windows.Forms.Button();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.flpTicket_Images = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlImages_Control = new System.Windows.Forms.Panel();
            this.btnImages_AddWebCamImage = new System.Windows.Forms.Button();
            this.btnImages_Add = new System.Windows.Forms.Button();
            this.tabRMA = new System.Windows.Forms.TabPage();
            this.lblTicket_Solution_Notes = new System.Windows.Forms.Label();
            this.lblTicket_Solutions = new System.Windows.Forms.Label();
            this.olvTicket_Solutions = new BrightIdeasSoftware.ObjectListView();
            this.olvColTicket_Solutions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblTicket_ClosedBy = new System.Windows.Forms.Label();
            this.lblTicket_OpenedBy = new System.Windows.Forms.Label();
            this.lblTicket_Symptoms = new System.Windows.Forms.Label();
            this.lblTicket_Number = new System.Windows.Forms.Label();
            this.bgwWebCamGetter = new System.ComponentModel.BackgroundWorker();
            this.pnlSolution_Closure = new System.Windows.Forms.Panel();
            this.btnTicket_CloseReopen = new System.Windows.Forms.Button();
            this.lblSolution_Closure = new System.Windows.Forms.Label();
            this.pnlAssetDetails = new System.Windows.Forms.Panel();
            this.lblAsset_WarrantyContractStatus = new System.Windows.Forms.Label();
            this.lblAsset_ServiceReminder = new System.Windows.Forms.Label();
            this.txtAsset_ServiceReminder = new System.Windows.Forms.TextBox();
            this.lblAssetDetails = new System.Windows.Forms.Label();
            this.lblClosed = new System.Windows.Forms.Label();
            this.pnlOSADetails = new System.Windows.Forms.Panel();
            this.lblPriority_Actual = new System.Windows.Forms.Label();
            this.lbPriority = new System.Windows.Forms.Label();
            this.btnRmaWarning = new System.Windows.Forms.Button();
            this.lblOSADetails = new System.Windows.Forms.Label();
            this.pnlTicketDetails = new System.Windows.Forms.Panel();
            this.lblTicket_Status_Detail = new System.Windows.Forms.Label();
            this.lblTicket_ActiveDuration = new System.Windows.Forms.Label();
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.timerRmaWarningFlasher = new System.Windows.Forms.Timer(this.components);
            this.txtTicket_Symptoms = new SDB.Classes.Misc.ClassFixedTextBox();
            this.miniWarrantyStatus1 = new SDB.UserControls.Asset.MiniWarrantyStatus();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.txtTicket_Solution_Notes = new SDB.UserControls.General.ucSpellCheckSmall();
            this.ticketRentals1 = new SDB.UserControls.Ticket.TicketRentals();
            this.ucRMAList1 = new SDB.UserControls.RMA.RmaList();
            this.ucShipmentList1 = new SDB.UserControls.Shipment.ucShipmentList();
            this.pnlControl_Top.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlControl_Bottom.SuspendLayout();
            this.tabLegacyRMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLegacyRMAs)).BeginInit();
            this.pnlRMA_Control.SuspendLayout();
            this.tabShipments.SuspendLayout();
            this.tabRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTechOnSite)).BeginInit();
            this.pnlAdditional.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.pnlJournal_Control.SuspendLayout();
            this.tabInvoiceNotes.SuspendLayout();
            this.pnlInvoiceNotes.SuspendLayout();
            this.pnlInvoiceNotes_Billable.SuspendLayout();
            this.pnlInvoiceNotes_Update.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.pnlImages_Control.SuspendLayout();
            this.tabRMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTicket_Solutions)).BeginInit();
            this.pnlSolution_Closure.SuspendLayout();
            this.pnlAssetDetails.SuspendLayout();
            this.pnlOSADetails.SuspendLayout();
            this.pnlTicketDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(739, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Ticket...";
            this.toolTip.SetToolTip(this.btnExport, "Exports the current ticket to an HTML file.");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblAsset_CustomerMarket
            // 
            this.lblAsset_CustomerMarket.AutoSize = true;
            this.lblAsset_CustomerMarket.Location = new System.Drawing.Point(3, 130);
            this.lblAsset_CustomerMarket.Name = "lblAsset_CustomerMarket";
            this.lblAsset_CustomerMarket.Size = new System.Drawing.Size(95, 13);
            this.lblAsset_CustomerMarket.TabIndex = 6;
            this.lblAsset_CustomerMarket.Text = "Customer / Market";
            // 
            // txtAsset_CustomerMarket
            // 
            this.txtAsset_CustomerMarket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAsset_CustomerMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset_CustomerMarket.Location = new System.Drawing.Point(5, 146);
            this.txtAsset_CustomerMarket.Name = "txtAsset_CustomerMarket";
            this.txtAsset_CustomerMarket.ReadOnly = true;
            this.txtAsset_CustomerMarket.Size = new System.Drawing.Size(243, 20);
            this.txtAsset_CustomerMarket.TabIndex = 7;
            this.txtAsset_CustomerMarket.TabStop = false;
            this.txtAsset_CustomerMarket.Click += new System.EventHandler(this.txtAsset_Market_Click);
            // 
            // txtInvoiceNotes_LaborWC
            // 
            this.txtInvoiceNotes_LaborWC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNotes_LaborWC.Location = new System.Drawing.Point(429, 6);
            this.txtInvoiceNotes_LaborWC.MaxLength = 20;
            this.txtInvoiceNotes_LaborWC.Name = "txtInvoiceNotes_LaborWC";
            this.txtInvoiceNotes_LaborWC.ReadOnly = true;
            this.txtInvoiceNotes_LaborWC.Size = new System.Drawing.Size(130, 20);
            this.txtInvoiceNotes_LaborWC.TabIndex = 41;
            this.txtInvoiceNotes_LaborWC.TabStop = false;
            // 
            // lblInvoiceNotes_LaborWC
            // 
            this.lblInvoiceNotes_LaborWC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNotes_LaborWC.AutoSize = true;
            this.lblInvoiceNotes_LaborWC.Location = new System.Drawing.Point(363, 9);
            this.lblInvoiceNotes_LaborWC.Name = "lblInvoiceNotes_LaborWC";
            this.lblInvoiceNotes_LaborWC.Size = new System.Drawing.Size(60, 13);
            this.lblInvoiceNotes_LaborWC.TabIndex = 40;
            this.lblInvoiceNotes_LaborWC.Text = "Labor W/C";
            // 
            // txtInvoiceNotes_PartsWC
            // 
            this.txtInvoiceNotes_PartsWC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNotes_PartsWC.Location = new System.Drawing.Point(227, 6);
            this.txtInvoiceNotes_PartsWC.MaxLength = 20;
            this.txtInvoiceNotes_PartsWC.Name = "txtInvoiceNotes_PartsWC";
            this.txtInvoiceNotes_PartsWC.ReadOnly = true;
            this.txtInvoiceNotes_PartsWC.Size = new System.Drawing.Size(130, 20);
            this.txtInvoiceNotes_PartsWC.TabIndex = 39;
            this.txtInvoiceNotes_PartsWC.TabStop = false;
            // 
            // lblInvoiceNotes_PartsWC
            // 
            this.lblInvoiceNotes_PartsWC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceNotes_PartsWC.AutoSize = true;
            this.lblInvoiceNotes_PartsWC.Location = new System.Drawing.Point(164, 9);
            this.lblInvoiceNotes_PartsWC.Name = "lblInvoiceNotes_PartsWC";
            this.lblInvoiceNotes_PartsWC.Size = new System.Drawing.Size(57, 13);
            this.lblInvoiceNotes_PartsWC.TabIndex = 38;
            this.lblInvoiceNotes_PartsWC.Text = "Parts W/C";
            // 
            // txtAsset_AssetName
            // 
            this.txtAsset_AssetName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAsset_AssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset_AssetName.Location = new System.Drawing.Point(6, 37);
            this.txtAsset_AssetName.Name = "txtAsset_AssetName";
            this.txtAsset_AssetName.ReadOnly = true;
            this.txtAsset_AssetName.Size = new System.Drawing.Size(126, 20);
            this.txtAsset_AssetName.TabIndex = 1;
            this.txtAsset_AssetName.TabStop = false;
            this.txtAsset_AssetName.Click += new System.EventHandler(this.txtAsset_AssetName_Click);
            // 
            // txtAsset_Panel
            // 
            this.txtAsset_Panel.Location = new System.Drawing.Point(138, 37);
            this.txtAsset_Panel.Name = "txtAsset_Panel";
            this.txtAsset_Panel.ReadOnly = true;
            this.txtAsset_Panel.Size = new System.Drawing.Size(110, 20);
            this.txtAsset_Panel.TabIndex = 3;
            this.txtAsset_Panel.TabStop = false;
            // 
            // txtAsset_Location
            // 
            this.txtAsset_Location.Location = new System.Drawing.Point(6, 76);
            this.txtAsset_Location.Multiline = true;
            this.txtAsset_Location.Name = "txtAsset_Location";
            this.txtAsset_Location.ReadOnly = true;
            this.txtAsset_Location.Size = new System.Drawing.Size(242, 48);
            this.txtAsset_Location.TabIndex = 5;
            this.txtAsset_Location.TabStop = false;
            // 
            // lblAsset_AssetName
            // 
            this.lblAsset_AssetName.AutoSize = true;
            this.lblAsset_AssetName.Location = new System.Drawing.Point(2, 21);
            this.lblAsset_AssetName.Name = "lblAsset_AssetName";
            this.lblAsset_AssetName.Size = new System.Drawing.Size(33, 13);
            this.lblAsset_AssetName.TabIndex = 0;
            this.lblAsset_AssetName.Text = "Asset";
            // 
            // lblAsset_Panel
            // 
            this.lblAsset_Panel.AutoSize = true;
            this.lblAsset_Panel.Location = new System.Drawing.Point(135, 21);
            this.lblAsset_Panel.Name = "lblAsset_Panel";
            this.lblAsset_Panel.Size = new System.Drawing.Size(34, 13);
            this.lblAsset_Panel.TabIndex = 2;
            this.lblAsset_Panel.Text = "Panel";
            // 
            // lblAsset_Location
            // 
            this.lblAsset_Location.AutoSize = true;
            this.lblAsset_Location.Location = new System.Drawing.Point(2, 60);
            this.lblAsset_Location.Name = "lblAsset_Location";
            this.lblAsset_Location.Size = new System.Drawing.Size(77, 13);
            this.lblAsset_Location.TabIndex = 4;
            this.lblAsset_Location.Text = "Asset Location";
            // 
            // txtTicket_Duration
            // 
            this.txtTicket_Duration.Location = new System.Drawing.Point(64, 169);
            this.txtTicket_Duration.Name = "txtTicket_Duration";
            this.txtTicket_Duration.ReadOnly = true;
            this.txtTicket_Duration.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_Duration.TabIndex = 21;
            this.txtTicket_Duration.TabStop = false;
            this.toolTip.SetToolTip(this.txtTicket_Duration, "How long the ticket was opened.");
            // 
            // lblTicket_Duration
            // 
            this.lblTicket_Duration.AutoSize = true;
            this.lblTicket_Duration.Location = new System.Drawing.Point(11, 172);
            this.lblTicket_Duration.Name = "lblTicket_Duration";
            this.lblTicket_Duration.Size = new System.Drawing.Size(47, 13);
            this.lblTicket_Duration.TabIndex = 20;
            this.lblTicket_Duration.Text = "Duration";
            // 
            // txtTicket_IssueNumber
            // 
            this.txtTicket_IssueNumber.Location = new System.Drawing.Point(197, 71);
            this.txtTicket_IssueNumber.MaxLength = 6;
            this.txtTicket_IssueNumber.Name = "txtTicket_IssueNumber";
            this.txtTicket_IssueNumber.ReadOnly = true;
            this.txtTicket_IssueNumber.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_IssueNumber.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtTicket_IssueNumber, "Customer Issue Number");
            this.txtTicket_IssueNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtTicket_JobOrderNumber
            // 
            this.txtTicket_JobOrderNumber.Location = new System.Drawing.Point(64, 71);
            this.txtTicket_JobOrderNumber.Name = "txtTicket_JobOrderNumber";
            this.txtTicket_JobOrderNumber.ReadOnly = true;
            this.txtTicket_JobOrderNumber.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_JobOrderNumber.TabIndex = 5;
            this.txtTicket_JobOrderNumber.TabStop = false;
            this.toolTip.SetToolTip(this.txtTicket_JobOrderNumber, "Job Order Number\r\n(Asset labor contract/warranty number active at time of ticket " +
        "open.)");
            // 
            // lblTicket_JobOrderNumber
            // 
            this.lblTicket_JobOrderNumber.AutoSize = true;
            this.lblTicket_JobOrderNumber.Location = new System.Drawing.Point(5, 74);
            this.lblTicket_JobOrderNumber.Name = "lblTicket_JobOrderNumber";
            this.lblTicket_JobOrderNumber.Size = new System.Drawing.Size(53, 13);
            this.lblTicket_JobOrderNumber.TabIndex = 4;
            this.lblTicket_JobOrderNumber.Text = "Job Order";
            // 
            // lblTicket_ReceivedDate
            // 
            this.lblTicket_ReceivedDate.AutoSize = true;
            this.lblTicket_ReceivedDate.Location = new System.Drawing.Point(13, 125);
            this.lblTicket_ReceivedDate.Name = "lblTicket_ReceivedDate";
            this.lblTicket_ReceivedDate.Size = new System.Drawing.Size(45, 13);
            this.lblTicket_ReceivedDate.TabIndex = 12;
            this.lblTicket_ReceivedDate.Text = "Opened";
            // 
            // lblTicket_IssueNumber
            // 
            this.lblTicket_IssueNumber.AutoSize = true;
            this.lblTicket_IssueNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket_IssueNumber.Location = new System.Drawing.Point(159, 74);
            this.lblTicket_IssueNumber.Name = "lblTicket_IssueNumber";
            this.lblTicket_IssueNumber.Size = new System.Drawing.Size(32, 13);
            this.lblTicket_IssueNumber.TabIndex = 6;
            this.lblTicket_IssueNumber.Text = "Issue";
            this.lblTicket_IssueNumber.Click += new System.EventHandler(this.lblTicket_IssueNumber_Click);
            // 
            // lblOSA
            // 
            this.lblOSA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOSA.AutoSize = true;
            this.lblOSA.Location = new System.Drawing.Point(83, 199);
            this.lblOSA.Name = "lblOSA";
            this.lblOSA.Size = new System.Drawing.Size(32, 13);
            this.lblOSA.TabIndex = 8;
            this.lblOSA.Text = "OSA:";
            // 
            // btnOSA_Tech_Log
            // 
            this.btnOSA_Tech_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOSA_Tech_Log.Location = new System.Drawing.Point(153, 233);
            this.btnOSA_Tech_Log.Name = "btnOSA_Tech_Log";
            this.btnOSA_Tech_Log.Size = new System.Drawing.Size(60, 23);
            this.btnOSA_Tech_Log.TabIndex = 12;
            this.btnOSA_Tech_Log.Text = "Log";
            this.toolTip.SetToolTip(this.btnOSA_Tech_Log, "View the Tech on-site log.");
            this.btnOSA_Tech_Log.UseVisualStyleBackColor = true;
            this.btnOSA_Tech_Log.Click += new System.EventHandler(this.btnOSA_Tech_Log_Click);
            // 
            // btnOSA_Checklist
            // 
            this.btnOSA_Checklist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOSA_Checklist.Location = new System.Drawing.Point(219, 233);
            this.btnOSA_Checklist.Name = "btnOSA_Checklist";
            this.btnOSA_Checklist.Size = new System.Drawing.Size(60, 23);
            this.btnOSA_Checklist.TabIndex = 13;
            this.btnOSA_Checklist.Text = "Checklist";
            this.toolTip.SetToolTip(this.btnOSA_Checklist, "View the Preventive Maintenance checklist to be performed by techs on-site.");
            this.btnOSA_Checklist.UseVisualStyleBackColor = true;
            this.btnOSA_Checklist.Click += new System.EventHandler(this.btnOSA_TechOnSiteChecklist_Click);
            // 
            // txtOSA_AssignedTech_Location
            // 
            this.txtOSA_AssignedTech_Location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOSA_AssignedTech_Location.Location = new System.Drawing.Point(56, 41);
            this.txtOSA_AssignedTech_Location.Name = "txtOSA_AssignedTech_Location";
            this.txtOSA_AssignedTech_Location.ReadOnly = true;
            this.txtOSA_AssignedTech_Location.Size = new System.Drawing.Size(221, 20);
            this.txtOSA_AssignedTech_Location.TabIndex = 5;
            // 
            // lblOSA_AssignedTech_Location
            // 
            this.lblOSA_AssignedTech_Location.AutoSize = true;
            this.lblOSA_AssignedTech_Location.Location = new System.Drawing.Point(2, 44);
            this.lblOSA_AssignedTech_Location.Name = "lblOSA_AssignedTech_Location";
            this.lblOSA_AssignedTech_Location.Size = new System.Drawing.Size(48, 13);
            this.lblOSA_AssignedTech_Location.TabIndex = 4;
            this.lblOSA_AssignedTech_Location.Text = "Location";
            // 
            // btnOSA_ChangeTech
            // 
            this.btnOSA_ChangeTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOSA_ChangeTech.Location = new System.Drawing.Point(253, 17);
            this.btnOSA_ChangeTech.Name = "btnOSA_ChangeTech";
            this.btnOSA_ChangeTech.Size = new System.Drawing.Size(24, 22);
            this.btnOSA_ChangeTech.TabIndex = 3;
            this.btnOSA_ChangeTech.Text = "...";
            this.toolTip.SetToolTip(this.btnOSA_ChangeTech, "Change Assigned Tech");
            this.btnOSA_ChangeTech.UseVisualStyleBackColor = true;
            this.btnOSA_ChangeTech.Click += new System.EventHandler(this.btnOSA_ChangeTech_Click);
            // 
            // txtOSA_AssignedTech
            // 
            this.txtOSA_AssignedTech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOSA_AssignedTech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOSA_AssignedTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSA_AssignedTech.Location = new System.Drawing.Point(56, 19);
            this.txtOSA_AssignedTech.Name = "txtOSA_AssignedTech";
            this.txtOSA_AssignedTech.ReadOnly = true;
            this.txtOSA_AssignedTech.Size = new System.Drawing.Size(191, 20);
            this.txtOSA_AssignedTech.TabIndex = 2;
            this.txtOSA_AssignedTech.Click += new System.EventHandler(this.txtOSA_AssignedTech_Click);
            // 
            // lblOSA_Comments
            // 
            this.lblOSA_Comments.AutoSize = true;
            this.lblOSA_Comments.Location = new System.Drawing.Point(3, 71);
            this.lblOSA_Comments.Name = "lblOSA_Comments";
            this.lblOSA_Comments.Size = new System.Drawing.Size(81, 13);
            this.lblOSA_Comments.TabIndex = 6;
            this.lblOSA_Comments.Text = "OSA Comments";
            // 
            // txtOSA_Comments
            // 
            this.txtOSA_Comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOSA_Comments.Location = new System.Drawing.Point(3, 87);
            this.txtOSA_Comments.MaxLength = 1024;
            this.txtOSA_Comments.Multiline = true;
            this.txtOSA_Comments.Name = "txtOSA_Comments";
            this.txtOSA_Comments.ReadOnly = true;
            this.txtOSA_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOSA_Comments.Size = new System.Drawing.Size(274, 102);
            this.txtOSA_Comments.TabIndex = 7;
            // 
            // lblOSA_OSAEMailSent
            // 
            this.lblOSA_OSAEMailSent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOSA_OSAEMailSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOSA_OSAEMailSent.Location = new System.Drawing.Point(121, 195);
            this.lblOSA_OSAEMailSent.Name = "lblOSA_OSAEMailSent";
            this.lblOSA_OSAEMailSent.Size = new System.Drawing.Size(90, 17);
            this.lblOSA_OSAEMailSent.TabIndex = 9;
            this.lblOSA_OSAEMailSent.Text = "NOT SENT";
            this.lblOSA_OSAEMailSent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkOSA_TechOnSite
            // 
            this.chkOSA_TechOnSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOSA_TechOnSite.AutoCheck = false;
            this.chkOSA_TechOnSite.AutoSize = true;
            this.chkOSA_TechOnSite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOSA_TechOnSite.Location = new System.Drawing.Point(100, 237);
            this.chkOSA_TechOnSite.Name = "chkOSA_TechOnSite";
            this.chkOSA_TechOnSite.Size = new System.Drawing.Size(47, 18);
            this.chkOSA_TechOnSite.TabIndex = 11;
            this.chkOSA_TechOnSite.Text = "TOS";
            this.toolTip.SetToolTip(this.chkOSA_TechOnSite, "Tech On-Site: Click to mark arrival or departure of Tech.");
            this.chkOSA_TechOnSite.UseVisualStyleBackColor = true;
            this.chkOSA_TechOnSite.Click += new System.EventHandler(this.chkOSA_TechOnSite_Click);
            // 
            // lblOSA_AssignedTech
            // 
            this.lblOSA_AssignedTech.AutoSize = true;
            this.lblOSA_AssignedTech.Location = new System.Drawing.Point(18, 22);
            this.lblOSA_AssignedTech.Name = "lblOSA_AssignedTech";
            this.lblOSA_AssignedTech.Size = new System.Drawing.Size(32, 13);
            this.lblOSA_AssignedTech.TabIndex = 1;
            this.lblOSA_AssignedTech.Text = "Tech";
            // 
            // btnOSA_View
            // 
            this.btnOSA_View.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOSA_View.Location = new System.Drawing.Point(217, 194);
            this.btnOSA_View.Name = "btnOSA_View";
            this.btnOSA_View.Size = new System.Drawing.Size(59, 22);
            this.btnOSA_View.TabIndex = 10;
            this.btnOSA_View.Text = "View";
            this.btnOSA_View.UseVisualStyleBackColor = true;
            this.btnOSA_View.Click += new System.EventHandler(this.btnOSA_View_Click);
            // 
            // txtTicket_ReportedType
            // 
            this.txtTicket_ReportedType.Location = new System.Drawing.Point(64, 97);
            this.txtTicket_ReportedType.Name = "txtTicket_ReportedType";
            this.txtTicket_ReportedType.ReadOnly = true;
            this.txtTicket_ReportedType.Size = new System.Drawing.Size(112, 20);
            this.txtTicket_ReportedType.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtTicket_ReportedType, "Method by which problem was reported.");
            // 
            // txtTicket_ReportedBy
            // 
            this.txtTicket_ReportedBy.Location = new System.Drawing.Point(197, 97);
            this.txtTicket_ReportedBy.MaxLength = 50;
            this.txtTicket_ReportedBy.Name = "txtTicket_ReportedBy";
            this.txtTicket_ReportedBy.ReadOnly = true;
            this.txtTicket_ReportedBy.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_ReportedBy.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtTicket_ReportedBy, "Who reported the problem.");
            // 
            // lblTicket_ReportedType
            // 
            this.lblTicket_ReportedType.AutoSize = true;
            this.lblTicket_ReportedType.Location = new System.Drawing.Point(7, 101);
            this.lblTicket_ReportedType.Name = "lblTicket_ReportedType";
            this.lblTicket_ReportedType.Size = new System.Drawing.Size(51, 13);
            this.lblTicket_ReportedType.TabIndex = 8;
            this.lblTicket_ReportedType.Text = "Reported";
            // 
            // lblTicket_ReportedBy
            // 
            this.lblTicket_ReportedBy.AutoSize = true;
            this.lblTicket_ReportedBy.Location = new System.Drawing.Point(178, 101);
            this.lblTicket_ReportedBy.Name = "lblTicket_ReportedBy";
            this.lblTicket_ReportedBy.Size = new System.Drawing.Size(18, 13);
            this.lblTicket_ReportedBy.TabIndex = 10;
            this.lblTicket_ReportedBy.Text = "by";
            // 
            // chkTicket_SendCloseEmail
            // 
            this.chkTicket_SendCloseEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkTicket_SendCloseEmail.AutoSize = true;
            this.chkTicket_SendCloseEmail.Checked = true;
            this.chkTicket_SendCloseEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTicket_SendCloseEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTicket_SendCloseEmail.Location = new System.Drawing.Point(6, 289);
            this.chkTicket_SendCloseEmail.Name = "chkTicket_SendCloseEmail";
            this.chkTicket_SendCloseEmail.Size = new System.Drawing.Size(132, 18);
            this.chkTicket_SendCloseEmail.TabIndex = 4;
            this.chkTicket_SendCloseEmail.Text = "Send email on closure";
            this.chkTicket_SendCloseEmail.UseVisualStyleBackColor = false;
            this.chkTicket_SendCloseEmail.CheckedChanged += new System.EventHandler(this.chkTicket_SendCloseEmail_CheckedChanged);
            // 
            // lblTicket_Status_Show
            // 
            this.lblTicket_Status_Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicket_Status_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket_Status_Show.Location = new System.Drawing.Point(193, 20);
            this.lblTicket_Status_Show.Name = "lblTicket_Status_Show";
            this.lblTicket_Status_Show.Size = new System.Drawing.Size(93, 26);
            this.lblTicket_Status_Show.TabIndex = 2;
            this.lblTicket_Status_Show.Text = "STATUS";
            this.lblTicket_Status_Show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControl_Top
            // 
            this.pnlControl_Top.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlControl_Top.Controls.Add(this.toolStrip1);
            this.pnlControl_Top.Controls.Add(this.chkSubscribe);
            this.pnlControl_Top.Controls.Add(this.txtSearch);
            this.pnlControl_Top.Controls.Add(this.btnSearch);
            this.pnlControl_Top.Controls.Add(this.btnExport);
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
            this.toolStrip1.Size = new System.Drawing.Size(98, 22);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTicket_HoldRelease,
            this.mnuTicket_Escalate,
            this.toolStripSeparator1,
            this.mnuTicket_CreateOSA,
            this.mnuTicket_SendOSA,
            this.mnuTicket_SendOpen,
            this.mnuTicket_SendClose,
            this.toolStripSeparator3,
            this.tsmiTicket_BillableConfirmationEmail,
            this.mbtnRebootCradle,
            this.toolStripSeparator2,
            this.mnuTicket_Reassign,
            this.deleteTicketToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(97, 19);
            this.toolStripDropDownButton1.Text = "Ticket Options";
            // 
            // mnuTicket_HoldRelease
            // 
            this.mnuTicket_HoldRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mnuTicket_HoldRelease.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuTicket_HoldRelease.Name = "mnuTicket_HoldRelease";
            this.mnuTicket_HoldRelease.ShowShortcutKeys = false;
            this.mnuTicket_HoldRelease.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_HoldRelease.Text = "Hold";
            this.mnuTicket_HoldRelease.Click += new System.EventHandler(this.mnuTicket_HoldRelease_Click);
            // 
            // mnuTicket_Escalate
            // 
            this.mnuTicket_Escalate.Name = "mnuTicket_Escalate";
            this.mnuTicket_Escalate.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_Escalate.Text = "Escalate";
            this.mnuTicket_Escalate.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuTicket_CreateOSA
            // 
            this.mnuTicket_CreateOSA.Name = "mnuTicket_CreateOSA";
            this.mnuTicket_CreateOSA.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_CreateOSA.Text = "Create OSA";
            this.mnuTicket_CreateOSA.Click += new System.EventHandler(this.mnuTicket_CreateOSA_Click);
            // 
            // mnuTicket_SendOSA
            // 
            this.mnuTicket_SendOSA.Name = "mnuTicket_SendOSA";
            this.mnuTicket_SendOSA.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_SendOSA.Text = "Send OSA to Tech";
            this.mnuTicket_SendOSA.ToolTipText = "Send OSA Email to Tech";
            this.mnuTicket_SendOSA.Visible = false;
            this.mnuTicket_SendOSA.Click += new System.EventHandler(this.mnuTicket_SendOSA_Click);
            // 
            // mnuTicket_SendOpen
            // 
            this.mnuTicket_SendOpen.Name = "mnuTicket_SendOpen";
            this.mnuTicket_SendOpen.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_SendOpen.Text = "Send Open to Market";
            this.mnuTicket_SendOpen.ToolTipText = "Send Open Ticket Notification to Market.";
            this.mnuTicket_SendOpen.Click += new System.EventHandler(this.mnuTicket_SendOpen_Click);
            // 
            // mnuTicket_SendClose
            // 
            this.mnuTicket_SendClose.Name = "mnuTicket_SendClose";
            this.mnuTicket_SendClose.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_SendClose.Text = "Send Close to Market";
            this.mnuTicket_SendClose.ToolTipText = "Send Close Ticket Notification to Market.";
            this.mnuTicket_SendClose.Click += new System.EventHandler(this.mnuTicket_SendClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(267, 6);
            // 
            // tsmiTicket_BillableConfirmationEmail
            // 
            this.tsmiTicket_BillableConfirmationEmail.Name = "tsmiTicket_BillableConfirmationEmail";
            this.tsmiTicket_BillableConfirmationEmail.Size = new System.Drawing.Size(270, 22);
            this.tsmiTicket_BillableConfirmationEmail.Text = "Billable Confirmation Email Template";
            this.tsmiTicket_BillableConfirmationEmail.Click += new System.EventHandler(this.tsmiTicket_BillableConfirmationEmail_Click);
            // 
            // mbtnRebootCradle
            // 
            this.mbtnRebootCradle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mbtnRebootCradle.Name = "mbtnRebootCradle";
            this.mbtnRebootCradle.Size = new System.Drawing.Size(270, 22);
            this.mbtnRebootCradle.Text = "Reboot CradlePoint";
            this.mbtnRebootCradle.Click += new System.EventHandler(this.mbtnRebootCradle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuTicket_Reassign
            // 
            this.mnuTicket_Reassign.Name = "mnuTicket_Reassign";
            this.mnuTicket_Reassign.Size = new System.Drawing.Size(270, 22);
            this.mnuTicket_Reassign.Text = "Reassign";
            this.mnuTicket_Reassign.ToolTipText = "Assign ticket to a different asset.";
            this.mnuTicket_Reassign.Visible = false;
            this.mnuTicket_Reassign.Click += new System.EventHandler(this.mnuTicket_Reassign_Click);
            // 
            // deleteTicketToolStripMenuItem
            // 
            this.deleteTicketToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteTicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTicket_DeleteRestore});
            this.deleteTicketToolStripMenuItem.Name = "deleteTicketToolStripMenuItem";
            this.deleteTicketToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.deleteTicketToolStripMenuItem.Text = "Delete Ticket";
            // 
            // mnuTicket_DeleteRestore
            // 
            this.mnuTicket_DeleteRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mnuTicket_DeleteRestore.Name = "mnuTicket_DeleteRestore";
            this.mnuTicket_DeleteRestore.Size = new System.Drawing.Size(142, 22);
            this.mnuTicket_DeleteRestore.Text = "Delete Ticket";
            this.mnuTicket_DeleteRestore.Click += new System.EventHandler(this.mnuTicket_DeleteRestore_Click);
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
            this.pnlControl_Bottom.TabIndex = 6;
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
            this.btnTeamViewer.TabIndex = 3;
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
            this.btnVNC.TabIndex = 2;
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
            this.btnDashboard.TabIndex = 1;
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
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.toolTip.SetToolTip(this.btnNext, "Next ticket (by ticket number).");
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
            this.toolTip.SetToolTip(this.btnPrevious, "Previous ticket (by ticket number).");
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tabLegacyRMA
            // 
            this.tabLegacyRMA.Controls.Add(this.olvLegacyRMAs);
            this.tabLegacyRMA.Controls.Add(this.pnlRMA_Control);
            this.tabLegacyRMA.Location = new System.Drawing.Point(4, 22);
            this.tabLegacyRMA.Name = "tabLegacyRMA";
            this.tabLegacyRMA.Padding = new System.Windows.Forms.Padding(3);
            this.tabLegacyRMA.Size = new System.Drawing.Size(568, 289);
            this.tabLegacyRMA.TabIndex = 6;
            this.tabLegacyRMA.Text = "Legacy RMAs";
            this.toolTip.SetToolTip(this.tabLegacyRMA, "RMAs associated with this ticket.");
            this.tabLegacyRMA.UseVisualStyleBackColor = true;
            // 
            // olvLegacyRMAs
            // 
            this.olvLegacyRMAs.AllColumns.Add(this.olvColRMA_ID);
            this.olvLegacyRMAs.AllColumns.Add(this.olvColRMA_Date);
            this.olvLegacyRMAs.AllColumns.Add(this.olvColRMA_IssuedBy);
            this.olvLegacyRMAs.AllColumns.Add(this.olvColRMA_IssuedTo);
            this.olvLegacyRMAs.AllColumns.Add(this.olvColRMA_Closed);
            this.olvLegacyRMAs.AllowColumnReorder = true;
            this.olvLegacyRMAs.CellEditUseWholeCell = false;
            this.olvLegacyRMAs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRMA_ID,
            this.olvColRMA_Date,
            this.olvColRMA_IssuedBy,
            this.olvColRMA_IssuedTo,
            this.olvColRMA_Closed});
            this.olvLegacyRMAs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLegacyRMAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvLegacyRMAs.EmptyListMsg = "No Legacy RMAs for this ticket.";
            this.olvLegacyRMAs.FullRowSelect = true;
            this.olvLegacyRMAs.GridLines = true;
            this.olvLegacyRMAs.HasCollapsibleGroups = false;
            this.olvLegacyRMAs.Location = new System.Drawing.Point(3, 33);
            this.olvLegacyRMAs.Name = "olvLegacyRMAs";
            this.olvLegacyRMAs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvLegacyRMAs.ShowCommandMenuOnRightClick = true;
            this.olvLegacyRMAs.ShowGroups = false;
            this.olvLegacyRMAs.Size = new System.Drawing.Size(562, 253);
            this.olvLegacyRMAs.TabIndex = 4;
            this.olvLegacyRMAs.UseCellFormatEvents = true;
            this.olvLegacyRMAs.UseCompatibleStateImageBehavior = false;
            this.olvLegacyRMAs.View = System.Windows.Forms.View.Details;
            this.olvLegacyRMAs.DoubleClick += new System.EventHandler(this.olvLegacyRmas_DoubleClick);
            // 
            // olvColRMA_ID
            // 
            this.olvColRMA_ID.AspectName = "ID";
            this.olvColRMA_ID.Groupable = false;
            this.olvColRMA_ID.IsEditable = false;
            this.olvColRMA_ID.Text = "#";
            this.olvColRMA_ID.Width = 50;
            // 
            // olvColRMA_Date
            // 
            this.olvColRMA_Date.AspectName = "IssuedDate";
            this.olvColRMA_Date.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMA_Date.Text = "Issued";
            this.olvColRMA_Date.Width = 70;
            // 
            // olvColRMA_IssuedBy
            // 
            this.olvColRMA_IssuedBy.AspectName = "IssuedBy";
            this.olvColRMA_IssuedBy.Text = "Issued By";
            this.olvColRMA_IssuedBy.Width = 65;
            // 
            // olvColRMA_IssuedTo
            // 
            this.olvColRMA_IssuedTo.AspectName = "Tech_Name";
            this.olvColRMA_IssuedTo.Text = "Issued To";
            this.olvColRMA_IssuedTo.Width = 170;
            // 
            // olvColRMA_Closed
            // 
            this.olvColRMA_Closed.AspectName = "ClosedDate";
            this.olvColRMA_Closed.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColRMA_Closed.Text = "Closed";
            this.olvColRMA_Closed.Width = 70;
            // 
            // pnlRMA_Control
            // 
            this.pnlRMA_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRMA_Control.Controls.Add(this.lblRMAQty);
            this.pnlRMA_Control.Controls.Add(this.txtRMAQty);
            this.pnlRMA_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRMA_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlRMA_Control.Name = "pnlRMA_Control";
            this.pnlRMA_Control.Size = new System.Drawing.Size(562, 30);
            this.pnlRMA_Control.TabIndex = 3;
            // 
            // lblRMAQty
            // 
            this.lblRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRMAQty.AutoSize = true;
            this.lblRMAQty.Location = new System.Drawing.Point(431, 9);
            this.lblRMAQty.Name = "lblRMAQty";
            this.lblRMAQty.Size = new System.Drawing.Size(77, 13);
            this.lblRMAQty.TabIndex = 9;
            this.lblRMAQty.Text = "Legacy RMAs:";
            // 
            // txtRMAQty
            // 
            this.txtRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRMAQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRMAQty.Location = new System.Drawing.Point(514, 4);
            this.txtRMAQty.Name = "txtRMAQty";
            this.txtRMAQty.ReadOnly = true;
            this.txtRMAQty.Size = new System.Drawing.Size(45, 22);
            this.txtRMAQty.TabIndex = 10;
            this.txtRMAQty.TabStop = false;
            this.txtRMAQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabShipments
            // 
            this.tabShipments.Controls.Add(this.ucShipmentList1);
            this.tabShipments.Location = new System.Drawing.Point(4, 22);
            this.tabShipments.Name = "tabShipments";
            this.tabShipments.Padding = new System.Windows.Forms.Padding(3);
            this.tabShipments.Size = new System.Drawing.Size(568, 289);
            this.tabShipments.TabIndex = 5;
            this.tabShipments.Text = "Shipments";
            this.toolTip.SetToolTip(this.tabShipments, "Shipments associated with this ticket.");
            this.tabShipments.UseVisualStyleBackColor = true;
            // 
            // tabRentals
            // 
            this.tabRentals.Controls.Add(this.ticketRentals1);
            this.tabRentals.Location = new System.Drawing.Point(4, 22);
            this.tabRentals.Name = "tabRentals";
            this.tabRentals.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentals.Size = new System.Drawing.Size(568, 289);
            this.tabRentals.TabIndex = 7;
            this.tabRentals.Text = "Rental";
            this.toolTip.SetToolTip(this.tabRentals, "Rental equipment used for this ticket.");
            this.tabRentals.UseVisualStyleBackColor = true;
            // 
            // txtTicket_Number
            // 
            this.txtTicket_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTicket_Number.Location = new System.Drawing.Point(64, 20);
            this.txtTicket_Number.Name = "txtTicket_Number";
            this.txtTicket_Number.ReadOnly = true;
            this.txtTicket_Number.Size = new System.Drawing.Size(123, 26);
            this.txtTicket_Number.TabIndex = 1;
            this.txtTicket_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txtTicket_Number, "Ticket Number");
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
            // radInvoiceNotes_Billable
            // 
            this.radInvoiceNotes_Billable.AutoSize = true;
            this.radInvoiceNotes_Billable.Location = new System.Drawing.Point(76, 7);
            this.radInvoiceNotes_Billable.Name = "radInvoiceNotes_Billable";
            this.radInvoiceNotes_Billable.Size = new System.Drawing.Size(58, 17);
            this.radInvoiceNotes_Billable.TabIndex = 1;
            this.radInvoiceNotes_Billable.Text = "Billable";
            this.toolTip.SetToolTip(this.radInvoiceNotes_Billable, "Billable to customer.");
            this.radInvoiceNotes_Billable.UseVisualStyleBackColor = true;
            this.radInvoiceNotes_Billable.CheckedChanged += new System.EventHandler(this.radInvoiceNotes_Billable_CheckedChanged);
            // 
            // radInvoiceNotes_Covered
            // 
            this.radInvoiceNotes_Covered.AutoSize = true;
            this.radInvoiceNotes_Covered.Checked = true;
            this.radInvoiceNotes_Covered.Location = new System.Drawing.Point(5, 7);
            this.radInvoiceNotes_Covered.Name = "radInvoiceNotes_Covered";
            this.radInvoiceNotes_Covered.Size = new System.Drawing.Size(65, 17);
            this.radInvoiceNotes_Covered.TabIndex = 0;
            this.radInvoiceNotes_Covered.TabStop = true;
            this.radInvoiceNotes_Covered.Text = "Covered";
            this.toolTip.SetToolTip(this.radInvoiceNotes_Covered, "Covered by warranty/contract.");
            this.radInvoiceNotes_Covered.UseVisualStyleBackColor = true;
            this.radInvoiceNotes_Covered.CheckedChanged += new System.EventHandler(this.radInvoiceNotes_Covered_CheckedChanged);
            // 
            // txtTicket_ClosedBy
            // 
            this.txtTicket_ClosedBy.Location = new System.Drawing.Point(197, 146);
            this.txtTicket_ClosedBy.Name = "txtTicket_ClosedBy";
            this.txtTicket_ClosedBy.ReadOnly = true;
            this.txtTicket_ClosedBy.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_ClosedBy.TabIndex = 19;
            this.txtTicket_ClosedBy.TabStop = false;
            this.toolTip.SetToolTip(this.txtTicket_ClosedBy, "Who closed the ticket.");
            // 
            // txtTicket_OpenedBy
            // 
            this.txtTicket_OpenedBy.Location = new System.Drawing.Point(197, 122);
            this.txtTicket_OpenedBy.Name = "txtTicket_OpenedBy";
            this.txtTicket_OpenedBy.ReadOnly = true;
            this.txtTicket_OpenedBy.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_OpenedBy.TabIndex = 15;
            this.txtTicket_OpenedBy.TabStop = false;
            this.toolTip.SetToolTip(this.txtTicket_OpenedBy, "Who opened the ticket.");
            // 
            // txtTicket_CloseDate
            // 
            this.txtTicket_CloseDate.Location = new System.Drawing.Point(64, 145);
            this.txtTicket_CloseDate.Name = "txtTicket_CloseDate";
            this.txtTicket_CloseDate.ReadOnly = true;
            this.txtTicket_CloseDate.Size = new System.Drawing.Size(112, 20);
            this.txtTicket_CloseDate.TabIndex = 17;
            this.toolTip.SetToolTip(this.txtTicket_CloseDate, "Date and time when ticket was closed.");
            // 
            // txtTicket_OpenDate
            // 
            this.txtTicket_OpenDate.Location = new System.Drawing.Point(64, 121);
            this.txtTicket_OpenDate.Name = "txtTicket_OpenDate";
            this.txtTicket_OpenDate.ReadOnly = true;
            this.txtTicket_OpenDate.Size = new System.Drawing.Size(112, 20);
            this.txtTicket_OpenDate.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtTicket_OpenDate, "Date and time when ticket was opened.");
            // 
            // txtTicket_ActiveDuration
            // 
            this.txtTicket_ActiveDuration.Location = new System.Drawing.Point(197, 169);
            this.txtTicket_ActiveDuration.Name = "txtTicket_ActiveDuration";
            this.txtTicket_ActiveDuration.ReadOnly = true;
            this.txtTicket_ActiveDuration.Size = new System.Drawing.Size(89, 20);
            this.txtTicket_ActiveDuration.TabIndex = 23;
            this.txtTicket_ActiveDuration.TabStop = false;
            this.toolTip.SetToolTip(this.txtTicket_ActiveDuration, "How long the ticket was active (instead of on hold).");
            // 
            // cmbAsset_TicketHistory
            // 
            this.cmbAsset_TicketHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsset_TicketHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAsset_TicketHistory.FormattingEnabled = true;
            this.cmbAsset_TicketHistory.Location = new System.Drawing.Point(6, 172);
            this.cmbAsset_TicketHistory.Name = "cmbAsset_TicketHistory";
            this.cmbAsset_TicketHistory.Size = new System.Drawing.Size(242, 21);
            this.cmbAsset_TicketHistory.TabIndex = 9;
            this.cmbAsset_TicketHistory.Tag = "";
            this.toolTip.SetToolTip(this.cmbAsset_TicketHistory, "Asset ticket history");
            this.cmbAsset_TicketHistory.SelectedIndexChanged += new System.EventHandler(this.cmbAsset_TicketHistory_SelectedIndexChanged);
            this.cmbAsset_TicketHistory.Click += new System.EventHandler(this.cmbAsset_TicketHistory_Click);
            // 
            // pbRental
            // 
            this.pbRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbRental.BackColor = System.Drawing.Color.Transparent;
            this.pbRental.Image = global::SDB.Properties.Resources.yesco_truck_32x32_trans;
            this.pbRental.Location = new System.Drawing.Point(32, 237);
            this.pbRental.Name = "pbRental";
            this.pbRental.Size = new System.Drawing.Size(32, 32);
            this.pbRental.TabIndex = 24;
            this.pbRental.TabStop = false;
            this.toolTip.SetToolTip(this.pbRental, "Equipment Rental");
            this.pbRental.Visible = false;
            // 
            // pbTechOnSite
            // 
            this.pbTechOnSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTechOnSite.BackColor = System.Drawing.Color.Transparent;
            this.pbTechOnSite.Image = global::SDB.Properties.Resources.worker_32x32;
            this.pbTechOnSite.Location = new System.Drawing.Point(3, 237);
            this.pbTechOnSite.Name = "pbTechOnSite";
            this.pbTechOnSite.Size = new System.Drawing.Size(32, 32);
            this.pbTechOnSite.TabIndex = 23;
            this.pbTechOnSite.TabStop = false;
            this.toolTip.SetToolTip(this.pbTechOnSite, "Tech On-site");
            this.pbTechOnSite.Visible = false;
            // 
            // btnJournal_ScrollToFirst
            // 
            this.btnJournal_ScrollToFirst.Image = global::SDB.Properties.Resources._16x16_down_dbl_arrow_emb;
            this.btnJournal_ScrollToFirst.Location = new System.Drawing.Point(109, 3);
            this.btnJournal_ScrollToFirst.Name = "btnJournal_ScrollToFirst";
            this.btnJournal_ScrollToFirst.Size = new System.Drawing.Size(130, 23);
            this.btnJournal_ScrollToFirst.TabIndex = 1;
            this.btnJournal_ScrollToFirst.Text = "Scroll to First Entry";
            this.btnJournal_ScrollToFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnJournal_ScrollToFirst, "Scroll to first journal entry.");
            this.btnJournal_ScrollToFirst.UseVisualStyleBackColor = true;
            this.btnJournal_ScrollToFirst.Click += new System.EventHandler(this.btnJournal_ScrollToFirst_Click);
            // 
            // pnlAdditional
            // 
            this.pnlAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdditional.Controls.Add(this.tabControl);
            this.pnlAdditional.Location = new System.Drawing.Point(3, 316);
            this.pnlAdditional.Name = "pnlAdditional";
            this.pnlAdditional.Size = new System.Drawing.Size(576, 315);
            this.pnlAdditional.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabJournal);
            this.tabControl.Controls.Add(this.tabInvoiceNotes);
            this.tabControl.Controls.Add(this.tabImages);
            this.tabControl.Controls.Add(this.tabRentals);
            this.tabControl.Controls.Add(this.tabLegacyRMA);
            this.tabControl.Controls.Add(this.tabRMA);
            this.tabControl.Controls.Add(this.tabShipments);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(576, 315);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabJournal
            // 
            this.tabJournal.Controls.Add(this.dgvJournal);
            this.tabJournal.Controls.Add(this.pnlJournal_Control);
            this.tabJournal.Location = new System.Drawing.Point(4, 22);
            this.tabJournal.Name = "tabJournal";
            this.tabJournal.Padding = new System.Windows.Forms.Padding(3);
            this.tabJournal.Size = new System.Drawing.Size(568, 289);
            this.tabJournal.TabIndex = 8;
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
            this.dgvJournal.BackgroundColor = System.Drawing.Color.LightGray;
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
            this.colJournalUser,
            this.colJournalDate,
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
            this.dgvJournal.Size = new System.Drawing.Size(562, 253);
            this.dgvJournal.TabIndex = 31;
            this.dgvJournal.TabStop = false;
            // 
            // colJournalUser
            // 
            this.colJournalUser.Frozen = true;
            this.colJournalUser.HeaderText = "User";
            this.colJournalUser.Name = "colJournalUser";
            this.colJournalUser.ReadOnly = true;
            this.colJournalUser.Width = 70;
            // 
            // colJournalDate
            // 
            this.colJournalDate.Frozen = true;
            this.colJournalDate.HeaderText = "Date";
            this.colJournalDate.Name = "colJournalDate";
            this.colJournalDate.ReadOnly = true;
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
            this.pnlJournal_Control.Controls.Add(this.btnJournal_ScrollToFirst);
            this.pnlJournal_Control.Controls.Add(this.lblJournal_LastEntryExpiration);
            this.pnlJournal_Control.Controls.Add(this.btnJournal_Add);
            this.pnlJournal_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlJournal_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlJournal_Control.Name = "pnlJournal_Control";
            this.pnlJournal_Control.Size = new System.Drawing.Size(562, 30);
            this.pnlJournal_Control.TabIndex = 30;
            // 
            // lblJournal_LastEntryExpiration
            // 
            this.lblJournal_LastEntryExpiration.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblJournal_LastEntryExpiration.Location = new System.Drawing.Point(245, 0);
            this.lblJournal_LastEntryExpiration.Name = "lblJournal_LastEntryExpiration";
            this.lblJournal_LastEntryExpiration.Size = new System.Drawing.Size(317, 30);
            this.lblJournal_LastEntryExpiration.TabIndex = 2;
            this.lblJournal_LastEntryExpiration.Text = "Last entry expire info.";
            this.lblJournal_LastEntryExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabInvoiceNotes
            // 
            this.tabInvoiceNotes.Controls.Add(this.pnlInvoiceNotes);
            this.tabInvoiceNotes.Location = new System.Drawing.Point(4, 22);
            this.tabInvoiceNotes.Name = "tabInvoiceNotes";
            this.tabInvoiceNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceNotes.Size = new System.Drawing.Size(568, 289);
            this.tabInvoiceNotes.TabIndex = 0;
            this.tabInvoiceNotes.Text = "Invoice Notes";
            this.tabInvoiceNotes.UseVisualStyleBackColor = true;
            // 
            // pnlInvoiceNotes
            // 
            this.pnlInvoiceNotes.BackColor = System.Drawing.Color.LightGray;
            this.pnlInvoiceNotes.Controls.Add(this.txtInvoiceNotes);
            this.pnlInvoiceNotes.Controls.Add(this.lblInvoiceNotes);
            this.pnlInvoiceNotes.Controls.Add(this.pnlInvoiceNotes_Billable);
            this.pnlInvoiceNotes.Controls.Add(this.pnlInvoiceNotes_Update);
            this.pnlInvoiceNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceNotes.Location = new System.Drawing.Point(3, 3);
            this.pnlInvoiceNotes.Name = "pnlInvoiceNotes";
            this.pnlInvoiceNotes.Size = new System.Drawing.Size(562, 283);
            this.pnlInvoiceNotes.TabIndex = 20;
            // 
            // txtInvoiceNotes
            // 
            this.txtInvoiceNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoiceNotes.Location = new System.Drawing.Point(0, 47);
            this.txtInvoiceNotes.Name = "txtInvoiceNotes";
            this.txtInvoiceNotes.Size = new System.Drawing.Size(562, 206);
            this.txtInvoiceNotes.TabIndex = 0;
            this.txtInvoiceNotes.Text = "";
            // 
            // lblInvoiceNotes
            // 
            this.lblInvoiceNotes.AutoEllipsis = true;
            this.lblInvoiceNotes.BackColor = System.Drawing.Color.DimGray;
            this.lblInvoiceNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvoiceNotes.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceNotes.Location = new System.Drawing.Point(0, 30);
            this.lblInvoiceNotes.Name = "lblInvoiceNotes";
            this.lblInvoiceNotes.Size = new System.Drawing.Size(562, 17);
            this.lblInvoiceNotes.TabIndex = 0;
            this.lblInvoiceNotes.Text = "Vendor Invoicing Notes";
            this.lblInvoiceNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInvoiceNotes_Billable
            // 
            this.pnlInvoiceNotes_Billable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlInvoiceNotes_Billable.Controls.Add(this.radInvoiceNotes_Covered);
            this.pnlInvoiceNotes_Billable.Controls.Add(this.radInvoiceNotes_Billable);
            this.pnlInvoiceNotes_Billable.Controls.Add(this.txtInvoiceNotes_LaborWC);
            this.pnlInvoiceNotes_Billable.Controls.Add(this.lblInvoiceNotes_LaborWC);
            this.pnlInvoiceNotes_Billable.Controls.Add(this.txtInvoiceNotes_PartsWC);
            this.pnlInvoiceNotes_Billable.Controls.Add(this.lblInvoiceNotes_PartsWC);
            this.pnlInvoiceNotes_Billable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceNotes_Billable.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoiceNotes_Billable.Name = "pnlInvoiceNotes_Billable";
            this.pnlInvoiceNotes_Billable.Size = new System.Drawing.Size(562, 30);
            this.pnlInvoiceNotes_Billable.TabIndex = 1;
            // 
            // pnlInvoiceNotes_Update
            // 
            this.pnlInvoiceNotes_Update.Controls.Add(this.btnInvoiceNotes_Update);
            this.pnlInvoiceNotes_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInvoiceNotes_Update.Location = new System.Drawing.Point(0, 253);
            this.pnlInvoiceNotes_Update.Name = "pnlInvoiceNotes_Update";
            this.pnlInvoiceNotes_Update.Size = new System.Drawing.Size(562, 30);
            this.pnlInvoiceNotes_Update.TabIndex = 2;
            // 
            // btnInvoiceNotes_Update
            // 
            this.btnInvoiceNotes_Update.Location = new System.Drawing.Point(467, 4);
            this.btnInvoiceNotes_Update.Name = "btnInvoiceNotes_Update";
            this.btnInvoiceNotes_Update.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceNotes_Update.TabIndex = 0;
            this.btnInvoiceNotes_Update.Text = "Update";
            this.btnInvoiceNotes_Update.UseVisualStyleBackColor = true;
            this.btnInvoiceNotes_Update.Click += new System.EventHandler(this.btnInvoiceNotes_Update_Click);
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.flpTicket_Images);
            this.tabImages.Controls.Add(this.pnlImages_Control);
            this.tabImages.Location = new System.Drawing.Point(4, 22);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(568, 289);
            this.tabImages.TabIndex = 10;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // flpTicket_Images
            // 
            this.flpTicket_Images.AutoScroll = true;
            this.flpTicket_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTicket_Images.Location = new System.Drawing.Point(3, 33);
            this.flpTicket_Images.Name = "flpTicket_Images";
            this.flpTicket_Images.Size = new System.Drawing.Size(562, 253);
            this.flpTicket_Images.TabIndex = 0;
            // 
            // pnlImages_Control
            // 
            this.pnlImages_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlImages_Control.Controls.Add(this.btnImages_AddWebCamImage);
            this.pnlImages_Control.Controls.Add(this.btnImages_Add);
            this.pnlImages_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImages_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlImages_Control.Name = "pnlImages_Control";
            this.pnlImages_Control.Size = new System.Drawing.Size(562, 30);
            this.pnlImages_Control.TabIndex = 4;
            // 
            // btnImages_AddWebCamImage
            // 
            this.btnImages_AddWebCamImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImages_AddWebCamImage.Location = new System.Drawing.Point(109, 3);
            this.btnImages_AddWebCamImage.Name = "btnImages_AddWebCamImage";
            this.btnImages_AddWebCamImage.Size = new System.Drawing.Size(170, 23);
            this.btnImages_AddWebCamImage.TabIndex = 1;
            this.btnImages_AddWebCamImage.Text = "Add Current Webcam Image";
            this.btnImages_AddWebCamImage.UseVisualStyleBackColor = false;
            this.btnImages_AddWebCamImage.Visible = false;
            this.btnImages_AddWebCamImage.Click += new System.EventHandler(this.btnImages_AddWebCamImage_Click);
            // 
            // btnImages_Add
            // 
            this.btnImages_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImages_Add.Location = new System.Drawing.Point(3, 3);
            this.btnImages_Add.Name = "btnImages_Add";
            this.btnImages_Add.Size = new System.Drawing.Size(100, 23);
            this.btnImages_Add.TabIndex = 0;
            this.btnImages_Add.Text = "Add Image";
            this.btnImages_Add.UseVisualStyleBackColor = false;
            this.btnImages_Add.Click += new System.EventHandler(this.btnImages_Add_Click);
            // 
            // tabRMA
            // 
            this.tabRMA.Controls.Add(this.ucRMAList1);
            this.tabRMA.Location = new System.Drawing.Point(4, 22);
            this.tabRMA.Name = "tabRMA";
            this.tabRMA.Size = new System.Drawing.Size(568, 289);
            this.tabRMA.TabIndex = 11;
            this.tabRMA.Text = "RMAs";
            this.tabRMA.UseVisualStyleBackColor = true;
            // 
            // lblTicket_Solution_Notes
            // 
            this.lblTicket_Solution_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTicket_Solution_Notes.AutoSize = true;
            this.lblTicket_Solution_Notes.Location = new System.Drawing.Point(3, 173);
            this.lblTicket_Solution_Notes.Name = "lblTicket_Solution_Notes";
            this.lblTicket_Solution_Notes.Size = new System.Drawing.Size(76, 13);
            this.lblTicket_Solution_Notes.TabIndex = 2;
            this.lblTicket_Solution_Notes.Text = "Solution Notes";
            // 
            // lblTicket_Solutions
            // 
            this.lblTicket_Solutions.AutoSize = true;
            this.lblTicket_Solutions.Location = new System.Drawing.Point(3, 19);
            this.lblTicket_Solutions.Name = "lblTicket_Solutions";
            this.lblTicket_Solutions.Size = new System.Drawing.Size(56, 13);
            this.lblTicket_Solutions.TabIndex = 0;
            this.lblTicket_Solutions.Text = "Solution(s)";
            // 
            // olvTicket_Solutions
            // 
            this.olvTicket_Solutions.AllColumns.Add(this.olvColTicket_Solutions);
            this.olvTicket_Solutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvTicket_Solutions.CellEditUseWholeCell = false;
            this.olvTicket_Solutions.CheckBoxes = true;
            this.olvTicket_Solutions.CheckedAspectName = "Selected";
            this.olvTicket_Solutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTicket_Solutions});
            this.olvTicket_Solutions.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTicket_Solutions.GridLines = true;
            this.olvTicket_Solutions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvTicket_Solutions.Location = new System.Drawing.Point(4, 35);
            this.olvTicket_Solutions.Name = "olvTicket_Solutions";
            this.olvTicket_Solutions.SelectAllOnControlA = false;
            this.olvTicket_Solutions.ShowFilterMenuOnRightClick = false;
            this.olvTicket_Solutions.ShowGroups = false;
            this.olvTicket_Solutions.Size = new System.Drawing.Size(244, 135);
            this.olvTicket_Solutions.TabIndex = 1;
            this.olvTicket_Solutions.UseCompatibleStateImageBehavior = false;
            this.olvTicket_Solutions.View = System.Windows.Forms.View.Details;
            // 
            // olvColTicket_Solutions
            // 
            this.olvColTicket_Solutions.AspectName = "Solution";
            this.olvColTicket_Solutions.FillsFreeSpace = true;
            this.olvColTicket_Solutions.Groupable = false;
            this.olvColTicket_Solutions.IsEditable = false;
            this.olvColTicket_Solutions.Searchable = false;
            this.olvColTicket_Solutions.Text = "Solution";
            this.olvColTicket_Solutions.Width = 250;
            // 
            // lblTicket_ClosedBy
            // 
            this.lblTicket_ClosedBy.AutoSize = true;
            this.lblTicket_ClosedBy.Location = new System.Drawing.Point(178, 149);
            this.lblTicket_ClosedBy.Name = "lblTicket_ClosedBy";
            this.lblTicket_ClosedBy.Size = new System.Drawing.Size(18, 13);
            this.lblTicket_ClosedBy.TabIndex = 18;
            this.lblTicket_ClosedBy.Text = "by";
            // 
            // lblTicket_OpenedBy
            // 
            this.lblTicket_OpenedBy.AutoSize = true;
            this.lblTicket_OpenedBy.Location = new System.Drawing.Point(178, 125);
            this.lblTicket_OpenedBy.Name = "lblTicket_OpenedBy";
            this.lblTicket_OpenedBy.Size = new System.Drawing.Size(18, 13);
            this.lblTicket_OpenedBy.TabIndex = 14;
            this.lblTicket_OpenedBy.Text = "by";
            // 
            // lblTicket_Symptoms
            // 
            this.lblTicket_Symptoms.AutoSize = true;
            this.lblTicket_Symptoms.Location = new System.Drawing.Point(7, 194);
            this.lblTicket_Symptoms.Name = "lblTicket_Symptoms";
            this.lblTicket_Symptoms.Size = new System.Drawing.Size(61, 13);
            this.lblTicket_Symptoms.TabIndex = 24;
            this.lblTicket_Symptoms.Text = "Symptom(s)";
            // 
            // lblTicket_Number
            // 
            this.lblTicket_Number.AutoSize = true;
            this.lblTicket_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket_Number.Location = new System.Drawing.Point(7, 28);
            this.lblTicket_Number.Name = "lblTicket_Number";
            this.lblTicket_Number.Size = new System.Drawing.Size(51, 13);
            this.lblTicket_Number.TabIndex = 0;
            this.lblTicket_Number.Text = "TICKET";
            // 
            // bgwWebCamGetter
            // 
            this.bgwWebCamGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwWebCamGetter_DoWork);
            this.bgwWebCamGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwWebCamGetter_RunWorkerCompleted);
            // 
            // pnlSolution_Closure
            // 
            this.pnlSolution_Closure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSolution_Closure.BackColor = System.Drawing.Color.LightGray;
            this.pnlSolution_Closure.Controls.Add(this.elementHost1);
            this.pnlSolution_Closure.Controls.Add(this.btnTicket_CloseReopen);
            this.pnlSolution_Closure.Controls.Add(this.lblSolution_Closure);
            this.pnlSolution_Closure.Controls.Add(this.lblTicket_Solutions);
            this.pnlSolution_Closure.Controls.Add(this.olvTicket_Solutions);
            this.pnlSolution_Closure.Controls.Add(this.lblTicket_Solution_Notes);
            this.pnlSolution_Closure.Controls.Add(this.chkTicket_SendCloseEmail);
            this.pnlSolution_Closure.Location = new System.Drawing.Point(585, 316);
            this.pnlSolution_Closure.Name = "pnlSolution_Closure";
            this.pnlSolution_Closure.Size = new System.Drawing.Size(251, 315);
            this.pnlSolution_Closure.TabIndex = 5;
            // 
            // btnTicket_CloseReopen
            // 
            this.btnTicket_CloseReopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTicket_CloseReopen.Location = new System.Drawing.Point(143, 285);
            this.btnTicket_CloseReopen.Name = "btnTicket_CloseReopen";
            this.btnTicket_CloseReopen.Size = new System.Drawing.Size(105, 23);
            this.btnTicket_CloseReopen.TabIndex = 5;
            this.btnTicket_CloseReopen.Text = "Close Ticket";
            this.btnTicket_CloseReopen.UseVisualStyleBackColor = true;
            this.btnTicket_CloseReopen.Click += new System.EventHandler(this.btnClose_Reopen_Click);
            // 
            // lblSolution_Closure
            // 
            this.lblSolution_Closure.AutoEllipsis = true;
            this.lblSolution_Closure.BackColor = System.Drawing.Color.Black;
            this.lblSolution_Closure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolution_Closure.ForeColor = System.Drawing.Color.White;
            this.lblSolution_Closure.Location = new System.Drawing.Point(0, 0);
            this.lblSolution_Closure.Name = "lblSolution_Closure";
            this.lblSolution_Closure.Size = new System.Drawing.Size(251, 17);
            this.lblSolution_Closure.TabIndex = 0;
            this.lblSolution_Closure.Text = "Solution/Closure";
            this.lblSolution_Closure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAssetDetails
            // 
            this.pnlAssetDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlAssetDetails.Controls.Add(this.cmbAsset_TicketHistory);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_WarrantyContractStatus);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_ServiceReminder);
            this.pnlAssetDetails.Controls.Add(this.txtAsset_ServiceReminder);
            this.pnlAssetDetails.Controls.Add(this.miniWarrantyStatus1);
            this.pnlAssetDetails.Controls.Add(this.lblAssetDetails);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_CustomerMarket);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_Location);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_Panel);
            this.pnlAssetDetails.Controls.Add(this.lblAsset_AssetName);
            this.pnlAssetDetails.Controls.Add(this.txtAsset_Location);
            this.pnlAssetDetails.Controls.Add(this.txtAsset_Panel);
            this.pnlAssetDetails.Controls.Add(this.txtAsset_AssetName);
            this.pnlAssetDetails.Controls.Add(this.txtAsset_CustomerMarket);
            this.pnlAssetDetails.Location = new System.Drawing.Point(585, 36);
            this.pnlAssetDetails.Name = "pnlAssetDetails";
            this.pnlAssetDetails.Size = new System.Drawing.Size(251, 272);
            this.pnlAssetDetails.TabIndex = 3;
            // 
            // lblAsset_WarrantyContractStatus
            // 
            this.lblAsset_WarrantyContractStatus.AutoSize = true;
            this.lblAsset_WarrantyContractStatus.Location = new System.Drawing.Point(3, 199);
            this.lblAsset_WarrantyContractStatus.Name = "lblAsset_WarrantyContractStatus";
            this.lblAsset_WarrantyContractStatus.Size = new System.Drawing.Size(37, 13);
            this.lblAsset_WarrantyContractStatus.TabIndex = 10;
            this.lblAsset_WarrantyContractStatus.Text = "Status";
            // 
            // lblAsset_ServiceReminder
            // 
            this.lblAsset_ServiceReminder.AutoSize = true;
            this.lblAsset_ServiceReminder.Location = new System.Drawing.Point(104, 197);
            this.lblAsset_ServiceReminder.Name = "lblAsset_ServiceReminder";
            this.lblAsset_ServiceReminder.Size = new System.Drawing.Size(91, 13);
            this.lblAsset_ServiceReminder.TabIndex = 12;
            this.lblAsset_ServiceReminder.Text = "Service Reminder";
            // 
            // txtAsset_ServiceReminder
            // 
            this.txtAsset_ServiceReminder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAsset_ServiceReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsset_ServiceReminder.Location = new System.Drawing.Point(107, 215);
            this.txtAsset_ServiceReminder.Multiline = true;
            this.txtAsset_ServiceReminder.Name = "txtAsset_ServiceReminder";
            this.txtAsset_ServiceReminder.ReadOnly = true;
            this.txtAsset_ServiceReminder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAsset_ServiceReminder.Size = new System.Drawing.Size(141, 51);
            this.txtAsset_ServiceReminder.TabIndex = 13;
            this.txtAsset_ServiceReminder.Click += new System.EventHandler(this.txtAsset_ServiceReminder_Click);
            // 
            // lblAssetDetails
            // 
            this.lblAssetDetails.AutoEllipsis = true;
            this.lblAssetDetails.BackColor = System.Drawing.Color.Black;
            this.lblAssetDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssetDetails.ForeColor = System.Drawing.Color.White;
            this.lblAssetDetails.Location = new System.Drawing.Point(0, 0);
            this.lblAssetDetails.Name = "lblAssetDetails";
            this.lblAssetDetails.Size = new System.Drawing.Size(251, 17);
            this.lblAssetDetails.TabIndex = 0;
            this.lblAssetDetails.Text = "Asset Details";
            this.lblAssetDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClosed
            // 
            this.lblClosed.AutoSize = true;
            this.lblClosed.Location = new System.Drawing.Point(19, 149);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(39, 13);
            this.lblClosed.TabIndex = 16;
            this.lblClosed.Text = "Closed";
            // 
            // pnlOSADetails
            // 
            this.pnlOSADetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlOSADetails.Controls.Add(this.lblPriority_Actual);
            this.pnlOSADetails.Controls.Add(this.lbPriority);
            this.pnlOSADetails.Controls.Add(this.btnRmaWarning);
            this.pnlOSADetails.Controls.Add(this.lblOSA);
            this.pnlOSADetails.Controls.Add(this.lblOSADetails);
            this.pnlOSADetails.Controls.Add(this.pbRental);
            this.pnlOSADetails.Controls.Add(this.lblOSA_AssignedTech);
            this.pnlOSADetails.Controls.Add(this.pbTechOnSite);
            this.pnlOSADetails.Controls.Add(this.btnOSA_View);
            this.pnlOSADetails.Controls.Add(this.btnOSA_Tech_Log);
            this.pnlOSADetails.Controls.Add(this.btnOSA_Checklist);
            this.pnlOSADetails.Controls.Add(this.chkOSA_TechOnSite);
            this.pnlOSADetails.Controls.Add(this.lblOSA_OSAEMailSent);
            this.pnlOSADetails.Controls.Add(this.txtOSA_AssignedTech_Location);
            this.pnlOSADetails.Controls.Add(this.txtOSA_Comments);
            this.pnlOSADetails.Controls.Add(this.lblOSA_AssignedTech_Location);
            this.pnlOSADetails.Controls.Add(this.lblOSA_Comments);
            this.pnlOSADetails.Controls.Add(this.btnOSA_ChangeTech);
            this.pnlOSADetails.Controls.Add(this.txtOSA_AssignedTech);
            this.pnlOSADetails.Location = new System.Drawing.Point(299, 36);
            this.pnlOSADetails.Name = "pnlOSADetails";
            this.pnlOSADetails.Size = new System.Drawing.Size(280, 272);
            this.pnlOSADetails.TabIndex = 2;
            // 
            // lblPriority_Actual
            // 
            this.lblPriority_Actual.AutoSize = true;
            this.lblPriority_Actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority_Actual.Location = new System.Drawing.Point(15, 210);
            this.lblPriority_Actual.Name = "lblPriority_Actual";
            this.lblPriority_Actual.Size = new System.Drawing.Size(61, 13);
            this.lblPriority_Actual.TabIndex = 26;
            this.lblPriority_Actual.Text = "NOT SET";
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(18, 192);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(41, 13);
            this.lbPriority.TabIndex = 25;
            this.lbPriority.Text = "Priority:";
            // 
            // btnRmaWarning
            // 
            this.btnRmaWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRmaWarning.BackColor = System.Drawing.SystemColors.Control;
            this.btnRmaWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmaWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmaWarning.ForeColor = System.Drawing.Color.Black;
            this.btnRmaWarning.Location = new System.Drawing.Point(151, 63);
            this.btnRmaWarning.Name = "btnRmaWarning";
            this.btnRmaWarning.Size = new System.Drawing.Size(126, 23);
            this.btnRmaWarning.TabIndex = 14;
            this.btnRmaWarning.Text = "Unreceived RMAs";
            this.btnRmaWarning.UseVisualStyleBackColor = false;
            this.btnRmaWarning.Visible = false;
            this.btnRmaWarning.Click += new System.EventHandler(this.btnRmaWarning_Click);
            // 
            // lblOSADetails
            // 
            this.lblOSADetails.AutoEllipsis = true;
            this.lblOSADetails.BackColor = System.Drawing.Color.Black;
            this.lblOSADetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOSADetails.ForeColor = System.Drawing.Color.White;
            this.lblOSADetails.Location = new System.Drawing.Point(0, 0);
            this.lblOSADetails.Name = "lblOSADetails";
            this.lblOSADetails.Size = new System.Drawing.Size(280, 17);
            this.lblOSADetails.TabIndex = 0;
            this.lblOSADetails.Text = "OSA Details";
            this.lblOSADetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTicketDetails
            // 
            this.pnlTicketDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlTicketDetails.Controls.Add(this.lblTicket_Status_Detail);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_ActiveDuration);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_ActiveDuration);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_CloseDate);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_OpenDate);
            this.pnlTicketDetails.Controls.Add(this.lblClosed);
            this.pnlTicketDetails.Controls.Add(this.lblTicketDetails);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_Number);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_IssueNumber);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_ReportedType);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_ClosedBy);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_JobOrderNumber);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_OpenedBy);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_ReceivedDate);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_JobOrderNumber);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_ClosedBy);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_Duration);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_ReportedBy);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_IssueNumber);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_OpenedBy);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_Number);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_ReportedBy);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_Duration);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_Symptoms);
            this.pnlTicketDetails.Controls.Add(this.txtTicket_Symptoms);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_ReportedType);
            this.pnlTicketDetails.Controls.Add(this.lblTicket_Status_Show);
            this.pnlTicketDetails.Location = new System.Drawing.Point(3, 36);
            this.pnlTicketDetails.Name = "pnlTicketDetails";
            this.pnlTicketDetails.Size = new System.Drawing.Size(290, 272);
            this.pnlTicketDetails.TabIndex = 1;
            // 
            // lblTicket_Status_Detail
            // 
            this.lblTicket_Status_Detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTicket_Status_Detail.Location = new System.Drawing.Point(64, 49);
            this.lblTicket_Status_Detail.Name = "lblTicket_Status_Detail";
            this.lblTicket_Status_Detail.Size = new System.Drawing.Size(222, 21);
            this.lblTicket_Status_Detail.TabIndex = 3;
            this.lblTicket_Status_Detail.Text = "Ticket Status Details";
            this.lblTicket_Status_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTicket_ActiveDuration
            // 
            this.lblTicket_ActiveDuration.AutoSize = true;
            this.lblTicket_ActiveDuration.Location = new System.Drawing.Point(154, 172);
            this.lblTicket_ActiveDuration.Name = "lblTicket_ActiveDuration";
            this.lblTicket_ActiveDuration.Size = new System.Drawing.Size(37, 13);
            this.lblTicket_ActiveDuration.TabIndex = 22;
            this.lblTicket_ActiveDuration.Text = "Active";
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.AutoEllipsis = true;
            this.lblTicketDetails.BackColor = System.Drawing.Color.Black;
            this.lblTicketDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicketDetails.ForeColor = System.Drawing.Color.White;
            this.lblTicketDetails.Location = new System.Drawing.Point(0, 0);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(290, 17);
            this.lblTicketDetails.TabIndex = 1;
            this.lblTicketDetails.Text = "Ticket Details";
            this.lblTicketDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerRmaWarningFlasher
            // 
            this.timerRmaWarningFlasher.Interval = 1500;
            this.timerRmaWarningFlasher.Tick += new System.EventHandler(this.timerRmaWarningFlasher_Tick);
            // 
            // txtTicket_Symptoms
            // 
            this.txtTicket_Symptoms.Location = new System.Drawing.Point(7, 210);
            this.txtTicket_Symptoms.Multiline = true;
            this.txtTicket_Symptoms.Name = "txtTicket_Symptoms";
            this.txtTicket_Symptoms.ReadOnly = true;
            this.txtTicket_Symptoms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicket_Symptoms.Size = new System.Drawing.Size(279, 55);
            this.txtTicket_Symptoms.TabIndex = 25;
            // 
            // miniWarrantyStatus1
            // 
            this.miniWarrantyStatus1.BackColor = System.Drawing.Color.Transparent;
            this.miniWarrantyStatus1.Location = new System.Drawing.Point(6, 212);
            this.miniWarrantyStatus1.Name = "miniWarrantyStatus1";
            this.miniWarrantyStatus1.Size = new System.Drawing.Size(95, 54);
            this.miniWarrantyStatus1.TabIndex = 11;
            // 
            // elementHost1
            // 
            this.elementHost1.AllowDrop = true;
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Location = new System.Drawing.Point(6, 189);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(242, 94);
            this.elementHost1.TabIndex = 6;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.txtTicket_Solution_Notes;
            // 
            // ticketRentals1
            // 
            this.ticketRentals1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketRentals1.Location = new System.Drawing.Point(3, 3);
            this.ticketRentals1.Name = "ticketRentals1";
            this.ticketRentals1.Size = new System.Drawing.Size(562, 283);
            this.ticketRentals1.TabIndex = 0;
            this.ticketRentals1.CreateTicketRental += new SDB.UserControls.Ticket.TicketRentals.CreateTicketRentalEvent(this.ticketRentals1_CreateTicketRental);
            this.ticketRentals1.EndTicketRental += new SDB.UserControls.Ticket.TicketRentals.EndTicketRentalEvent(this.ticketRentals1_EndTicketRental);
            // 
            // ucRMAList1
            // 
            this.ucRMAList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRMAList1.Location = new System.Drawing.Point(0, 0);
            this.ucRMAList1.Name = "ucRMAList1";
            this.ucRMAList1.ShowCreateButton = true;
            this.ucRMAList1.ShowFilter = false;
            this.ucRMAList1.Size = new System.Drawing.Size(568, 289);
            this.ucRMAList1.TabIndex = 0;
            this.ucRMAList1.ViewRMA += new SDB.UserControls.RMA.RmaList.RMAEvent(this.ucRMAList1_ViewRMA);
            this.ucRMAList1.CreateRMA += new SDB.UserControls.RMA.RmaList.CreateEvent(this.ucRMAList1_CreateRMA);
            // 
            // ucShipmentList1
            // 
            this.ucShipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucShipmentList1.Location = new System.Drawing.Point(3, 3);
            this.ucShipmentList1.Name = "ucShipmentList1";
            this.ucShipmentList1.ShowCreateButton = true;
            this.ucShipmentList1.Size = new System.Drawing.Size(562, 283);
            this.ucShipmentList1.TabIndex = 0;
            this.ucShipmentList1.CreateShipment += new SDB.UserControls.Shipment.ucShipmentList.CreateEvent(this.ucShipmentList1_CreateShipment);
            this.ucShipmentList1.ViewShipment += new SDB.UserControls.Shipment.ucShipmentList.ShipmentEvent(this.ucShipmentList1_ViewShipment);
            this.ucShipmentList1.ViewTracking += new SDB.UserControls.Shipment.ucShipmentList.TrackingEvent(this.ucShipmentList1_ViewTracking);
            // 
            // TicketEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTicketDetails);
            this.Controls.Add(this.pnlOSADetails);
            this.Controls.Add(this.pnlAssetDetails);
            this.Controls.Add(this.pnlSolution_Closure);
            this.Controls.Add(this.pnlAdditional);
            this.Controls.Add(this.pnlControl_Bottom);
            this.Controls.Add(this.pnlControl_Top);
            this.Name = "TicketEditor";
            this.Size = new System.Drawing.Size(839, 667);
            this.pnlControl_Top.ResumeLayout(false);
            this.pnlControl_Top.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlControl_Bottom.ResumeLayout(false);
            this.tabLegacyRMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvLegacyRMAs)).EndInit();
            this.pnlRMA_Control.ResumeLayout(false);
            this.pnlRMA_Control.PerformLayout();
            this.tabShipments.ResumeLayout(false);
            this.tabRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTechOnSite)).EndInit();
            this.pnlAdditional.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.pnlJournal_Control.ResumeLayout(false);
            this.tabInvoiceNotes.ResumeLayout(false);
            this.pnlInvoiceNotes.ResumeLayout(false);
            this.pnlInvoiceNotes_Billable.ResumeLayout(false);
            this.pnlInvoiceNotes_Billable.PerformLayout();
            this.pnlInvoiceNotes_Update.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.pnlImages_Control.ResumeLayout(false);
            this.tabRMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTicket_Solutions)).EndInit();
            this.pnlSolution_Closure.ResumeLayout(false);
            this.pnlSolution_Closure.PerformLayout();
            this.pnlAssetDetails.ResumeLayout(false);
            this.pnlAssetDetails.PerformLayout();
            this.pnlOSADetails.ResumeLayout(false);
            this.pnlOSADetails.PerformLayout();
            this.pnlTicketDetails.ResumeLayout(false);
            this.pnlTicketDetails.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.TextBox txtTicket_Duration;
		private System.Windows.Forms.Label lblTicket_Duration;
		private System.Windows.Forms.TextBox txtInvoiceNotes_LaborWC;
		private System.Windows.Forms.Label lblInvoiceNotes_LaborWC;
		private System.Windows.Forms.TextBox txtInvoiceNotes_PartsWC;
		private System.Windows.Forms.Label lblInvoiceNotes_PartsWC;
		private System.Windows.Forms.TextBox txtTicket_IssueNumber;
		private System.Windows.Forms.TextBox txtAsset_AssetName;
		private System.Windows.Forms.TextBox txtAsset_Panel;
		private System.Windows.Forms.TextBox txtTicket_JobOrderNumber;
		private System.Windows.Forms.TextBox txtAsset_Location;
		private System.Windows.Forms.Label lblAsset_AssetName;
		private System.Windows.Forms.Label lblTicket_JobOrderNumber;
		private System.Windows.Forms.Label lblTicket_ReceivedDate;
		private System.Windows.Forms.Label lblAsset_Panel;
		private System.Windows.Forms.Label lblTicket_IssueNumber;
		private System.Windows.Forms.Label lblAsset_Location;
		private System.Windows.Forms.Button btnOSA_ChangeTech;
		private System.Windows.Forms.TextBox txtOSA_AssignedTech;
		private System.Windows.Forms.TextBox txtTicket_ReportedType;
		private System.Windows.Forms.Label lblOSA_Comments;
		private System.Windows.Forms.TextBox txtOSA_Comments;
		private System.Windows.Forms.Label lblOSA_OSAEMailSent;
		private System.Windows.Forms.TextBox txtTicket_ReportedBy;
		private System.Windows.Forms.Label lblTicket_ReportedType;
		private System.Windows.Forms.Label lblTicket_ReportedBy;
		private System.Windows.Forms.CheckBox chkOSA_TechOnSite;
		private System.Windows.Forms.Label lblOSA_AssignedTech;
		private System.Windows.Forms.CheckBox chkTicket_SendCloseEmail;
		private System.Windows.Forms.Button btnOSA_View;
		private ClassFixedTextBox txtTicket_Symptoms;
		private System.Windows.Forms.Label lblTicket_Status_Show;
		private System.Windows.Forms.Panel pnlControl_Top;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlControl_Bottom;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel pnlAdditional;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabInvoiceNotes;
		private System.Windows.Forms.TabPage tabLegacyRMA;
		private System.Windows.Forms.TabPage tabShipments;
		private System.Windows.Forms.TabPage tabRentals;
		private System.Windows.Forms.TextBox txtTicket_Number;
		private System.Windows.Forms.Label lblTicket_Number;
		private System.Windows.Forms.Panel pnlRMA_Control;
		private System.Windows.Forms.Label lblAsset_CustomerMarket;
		private System.Windows.Forms.TextBox txtAsset_CustomerMarket;
		private System.Windows.Forms.TabPage tabJournal;
		private System.Windows.Forms.TextBox txtTicket_ClosedBy;
		private System.Windows.Forms.Label lblTicket_ClosedBy;
		private System.Windows.Forms.TextBox txtTicket_OpenedBy;
		private System.Windows.Forms.Label lblTicket_OpenedBy;
		private System.Windows.Forms.Label lblTicket_Symptoms;
		private System.Windows.Forms.Panel pnlJournal_Control;
		private System.Windows.Forms.Button btnJournal_Add;
		private System.Windows.Forms.Label lblTicket_Solution_Notes;
		private System.Windows.Forms.Label lblTicket_Solutions;
		private BrightIdeasSoftware.ObjectListView olvTicket_Solutions;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Solutions;
		private BrightIdeasSoftware.ObjectListView olvLegacyRMAs;
		private BrightIdeasSoftware.OLVColumn olvColRMA_ID;
		private System.Windows.Forms.TextBox txtOSA_AssignedTech_Location;
		private System.Windows.Forms.Label lblOSA_AssignedTech_Location;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Date;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedBy;
		private System.Windows.Forms.TabPage tabImages;
		private System.Windows.Forms.FlowLayoutPanel flpTicket_Images;
		private System.Windows.Forms.Panel pnlImages_Control;
		private System.Windows.Forms.Button btnImages_Add;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedTo;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Closed;
		private System.Windows.Forms.Label lblRMAQty;
		private System.Windows.Forms.TextBox txtRMAQty;
		private System.Windows.Forms.Button btnImages_AddWebCamImage;
		private System.ComponentModel.BackgroundWorker bgwWebCamGetter;
		private System.Windows.Forms.TabPage tabRMA;
		private RmaList ucRMAList1;
		private System.Windows.Forms.DataGridView dgvJournal;
		private System.Windows.Forms.Button btnOSA_Checklist;
		private System.Windows.Forms.Button btnOSA_Tech_Log;
		private ucShipmentList ucShipmentList1;
		private System.Windows.Forms.PictureBox pbRental;
		private System.Windows.Forms.PictureBox pbTechOnSite;
		private System.Windows.Forms.Label lblOSA;
		private System.Windows.Forms.CheckBox chkSubscribe;
		private System.Windows.Forms.Panel pnlSolution_Closure;
		private System.Windows.Forms.Label lblSolution_Closure;
		private System.Windows.Forms.Panel pnlAssetDetails;
		private System.Windows.Forms.Label lblAssetDetails;
		private System.Windows.Forms.Label lblClosed;
		private System.Windows.Forms.Button btnTicket_CloseReopen;
		private System.Windows.Forms.Panel pnlOSADetails;
		private System.Windows.Forms.Label lblOSADetails;
		private System.Windows.Forms.Panel pnlTicketDetails;
		private System.Windows.Forms.Label lblTicketDetails;
		private System.Windows.Forms.Panel pnlInvoiceNotes;
		private System.Windows.Forms.RichTextBox txtInvoiceNotes;
		private System.Windows.Forms.Label lblInvoiceNotes;
		private System.Windows.Forms.Panel pnlInvoiceNotes_Billable;
		private System.Windows.Forms.RadioButton radInvoiceNotes_Covered;
		private System.Windows.Forms.RadioButton radInvoiceNotes_Billable;
		private TicketRentals ticketRentals1;
		private System.Windows.Forms.TextBox txtTicket_CloseDate;
		private System.Windows.Forms.TextBox txtTicket_OpenDate;
		private System.Windows.Forms.Panel pnlInvoiceNotes_Update;
		private System.Windows.Forms.Button btnInvoiceNotes_Update;
		private System.Windows.Forms.Label lblJournal_LastEntryExpiration;
		private System.Windows.Forms.Label lblTicket_ActiveDuration;
		private System.Windows.Forms.TextBox txtTicket_ActiveDuration;
		private System.Windows.Forms.Button btnTeamViewer;
		private System.Windows.Forms.Button btnVNC;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnRmaWarning;
		private System.Windows.Forms.Timer timerRmaWarningFlasher;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
		private MiniWarrantyStatus miniWarrantyStatus1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_HoldRelease;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_SendOpen;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_SendClose;
		private System.Windows.Forms.TextBox txtAsset_ServiceReminder;
		private System.Windows.Forms.Label lblAsset_WarrantyContractStatus;
		private System.Windows.Forms.Label lblAsset_ServiceReminder;
		private System.Windows.Forms.ComboBox cmbAsset_TicketHistory;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_Escalate;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_CreateOSA;
		private System.Windows.Forms.Label lblTicket_Status_Detail;
		private System.Windows.Forms.Button btnJournal_ScrollToFirst;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuTicket_Reassign;
        private System.Windows.Forms.ToolStripMenuItem tsmiTicket_BillableConfirmationEmail;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTicket_DeleteRestore;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private General.ucSpellCheckSmall txtTicket_Solution_Notes;
        private System.Windows.Forms.ToolStripMenuItem mnuTicket_SendOSA;
        private System.Windows.Forms.Label lblPriority_Actual;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.ToolStripMenuItem mbtnRebootCradle;
    }
}
