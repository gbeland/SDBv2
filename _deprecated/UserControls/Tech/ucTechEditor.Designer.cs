using SDB.Classes.Misc;
using SDB.UserControls.Asset;
using SDB.UserControls.RMA;
using SDB.UserControls.Shipment;

namespace SDB.UserControls.Tech
{
	partial class TechEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechEditor));
			this.pnlInfo = new System.Windows.Forms.Panel();
			this.btnRmaWarning = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTechInfo = new System.Windows.Forms.Label();
			this.grpEmail = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.grpRates = new System.Windows.Forms.GroupBox();
			this.numRates_Emergency = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numRates_AfterHours = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.numRates_Standard = new SDB.Classes.Misc.ClassFixedNumericUpDown();
			this.lblRates_Standard = new System.Windows.Forms.Label();
			this.lblRates_Emergency = new System.Windows.Forms.Label();
			this.lblRates_AfterHours = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtTelephone = new System.Windows.Forms.TextBox();
			this.grpShipping = new System.Windows.Forms.GroupBox();
			this.txtShip_Country = new System.Windows.Forms.TextBox();
			this.txtShip_Address = new System.Windows.Forms.TextBox();
			this.txtShip_Zip = new System.Windows.Forms.TextBox();
			this.lblShip_Country = new System.Windows.Forms.Label();
			this.txtShip_State = new System.Windows.Forms.TextBox();
			this.lblShip_Zip = new System.Windows.Forms.Label();
			this.lblShip_Address = new System.Windows.Forms.Label();
			this.lblShip_State = new System.Windows.Forms.Label();
			this.txtShip_City = new System.Windows.Forms.TextBox();
			this.lblShip_City = new System.Windows.Forms.Label();
			this.grpMailing = new System.Windows.Forms.GroupBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.chkShipToMailingAddress = new System.Windows.Forms.CheckBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblState = new System.Windows.Forms.Label();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.lblFax = new System.Windows.Forms.Label();
			this.lblTelephone = new System.Windows.Forms.Label();
			this.pnlTechContacts = new System.Windows.Forms.Panel();
			this.lblTechContacts = new System.Windows.Forms.Label();
			this.txtContact3_Name = new System.Windows.Forms.TextBox();
			this.lblContact3_Telephone = new System.Windows.Forms.Label();
			this.txtContact2_Name = new System.Windows.Forms.TextBox();
			this.lblContact3_Name = new System.Windows.Forms.Label();
			this.lblContact2_Telephone = new System.Windows.Forms.Label();
			this.txtContact3_Telephone = new System.Windows.Forms.TextBox();
			this.txtContact1_Name = new System.Windows.Forms.TextBox();
			this.lblContact2_Name = new System.Windows.Forms.Label();
			this.lblContact1_Telephone = new System.Windows.Forms.Label();
			this.txtContact2_Telephone = new System.Windows.Forms.TextBox();
			this.lblContact1_Name = new System.Windows.Forms.Label();
			this.txtContact1_Telephone = new System.Windows.Forms.TextBox();
			this.pnlAdditional = new System.Windows.Forms.Panel();
			this.tabAdditionalInfo = new System.Windows.Forms.TabControl();
			this.tabNotes = new System.Windows.Forms.TabPage();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.tabAssets = new System.Windows.Forms.TabPage();
			this.ucAssetList1 = new SDB.UserControls.Asset.ucAssetList();
			this.tabTickets = new System.Windows.Forms.TabPage();
			this.olvTickets = new BrightIdeasSoftware.ObjectListView();
			this.olvColTickets_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_AssetLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Symptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Solutions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Panel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTickets_Issue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlTickets_Control = new System.Windows.Forms.Panel();
			this.lblTicketQty = new System.Windows.Forms.Label();
			this.txtTicketQty = new System.Windows.Forms.TextBox();
			this.lblTickets_View = new System.Windows.Forms.Label();
			this.radTickets_Closed = new System.Windows.Forms.RadioButton();
			this.radTickets_Open = new System.Windows.Forms.RadioButton();
			this.tabLegacyRMA = new System.Windows.Forms.TabPage();
			this.olvLegacyRMAs = new BrightIdeasSoftware.ObjectListView();
			this.olvColRMA_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_IssuedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_IssuedTo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Closed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlRMA_Control = new System.Windows.Forms.Panel();
			this.lblLegacyRMAQty = new System.Windows.Forms.Label();
			this.txtLegacyRMAQty = new System.Windows.Forms.TextBox();
			this.tabRMA = new System.Windows.Forms.TabPage();
			this.ucRMAList1 = new SDB.UserControls.RMA.RmaList();
			this.pnlRmaDetail = new System.Windows.Forms.Panel();
			this.lblRmaAssembliesUnit = new System.Windows.Forms.Label();
			this.txtRmaAssembliesAverageDaysToFirstReceive = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRmaAssembliesPercentage = new System.Windows.Forms.TextBox();
			this.lblRmaAssembliesOf = new System.Windows.Forms.Label();
			this.txtRmaAssembliesReceived = new System.Windows.Forms.TextBox();
			this.lblRmaAssembliesReceived = new System.Windows.Forms.Label();
			this.txtRmaAssembliesTotal = new System.Windows.Forms.TextBox();
			this.tabShipments = new System.Windows.Forms.TabPage();
			this.ucShipmentList1 = new SDB.UserControls.Shipment.ucShipmentList();
			this.pnlControl_Top = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEditSave = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.pnlControl_Bottom = new System.Windows.Forms.Panel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.timerRmaWarningFlasher = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuAddNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlInfo.SuspendLayout();
			this.grpEmail.SuspendLayout();
			this.grpRates.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRates_Emergency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRates_AfterHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRates_Standard)).BeginInit();
			this.grpShipping.SuspendLayout();
			this.grpMailing.SuspendLayout();
			this.pnlTechContacts.SuspendLayout();
			this.pnlAdditional.SuspendLayout();
			this.tabAdditionalInfo.SuspendLayout();
			this.tabNotes.SuspendLayout();
			this.tabAssets.SuspendLayout();
			this.tabTickets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
			this.pnlTickets_Control.SuspendLayout();
			this.tabLegacyRMA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvLegacyRMAs)).BeginInit();
			this.pnlRMA_Control.SuspendLayout();
			this.tabRMA.SuspendLayout();
			this.pnlRmaDetail.SuspendLayout();
			this.tabShipments.SuspendLayout();
			this.pnlControl_Top.SuspendLayout();
			this.pnlControl_Bottom.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlInfo
			// 
			this.pnlInfo.BackColor = System.Drawing.Color.LightGray;
			this.pnlInfo.Controls.Add(this.btnRmaWarning);
			this.pnlInfo.Controls.Add(this.label1);
			this.pnlInfo.Controls.Add(this.lblTechInfo);
			this.pnlInfo.Controls.Add(this.grpEmail);
			this.pnlInfo.Controls.Add(this.grpRates);
			this.pnlInfo.Controls.Add(this.cmbStatus);
			this.pnlInfo.Controls.Add(this.lblStatus);
			this.pnlInfo.Controls.Add(this.txtFax);
			this.pnlInfo.Controls.Add(this.txtTelephone);
			this.pnlInfo.Controls.Add(this.grpShipping);
			this.pnlInfo.Controls.Add(this.grpMailing);
			this.pnlInfo.Controls.Add(this.txtCompanyName);
			this.pnlInfo.Controls.Add(this.lblFax);
			this.pnlInfo.Controls.Add(this.lblTelephone);
			this.pnlInfo.Location = new System.Drawing.Point(3, 36);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(833, 268);
			this.pnlInfo.TabIndex = 1;
			// 
			// btnRmaWarning
			// 
			this.btnRmaWarning.BackColor = System.Drawing.Color.Red;
			this.btnRmaWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRmaWarning.ForeColor = System.Drawing.Color.White;
			this.btnRmaWarning.Location = new System.Drawing.Point(633, 23);
			this.btnRmaWarning.Name = "btnRmaWarning";
			this.btnRmaWarning.Size = new System.Drawing.Size(178, 23);
			this.btnRmaWarning.TabIndex = 12;
			this.btnRmaWarning.Text = "Unreceived RMA Warning";
			this.btnRmaWarning.UseVisualStyleBackColor = false;
			this.btnRmaWarning.Visible = false;
			this.btnRmaWarning.Click += new System.EventHandler(this.btnRmaWarning_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "TECH";
			this.toolTip.SetToolTip(this.label1, "Company Name");
			// 
			// lblTechInfo
			// 
			this.lblTechInfo.AutoEllipsis = true;
			this.lblTechInfo.BackColor = System.Drawing.Color.Black;
			this.lblTechInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTechInfo.ForeColor = System.Drawing.Color.White;
			this.lblTechInfo.Location = new System.Drawing.Point(0, 0);
			this.lblTechInfo.Name = "lblTechInfo";
			this.lblTechInfo.Size = new System.Drawing.Size(833, 17);
			this.lblTechInfo.TabIndex = 0;
			this.lblTechInfo.Text = "ASC/Tech Information";
			this.lblTechInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grpEmail
			// 
			this.grpEmail.Controls.Add(this.txtEmail);
			this.grpEmail.Location = new System.Drawing.Point(20, 191);
			this.grpEmail.Name = "grpEmail";
			this.grpEmail.Size = new System.Drawing.Size(400, 74);
			this.grpEmail.TabIndex = 8;
			this.grpEmail.TabStop = false;
			this.grpEmail.Text = "Email Address(es)";
			// 
			// txtEmail
			// 
			this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEmail.Location = new System.Drawing.Point(3, 16);
			this.txtEmail.MaxLength = 300;
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(394, 55);
			this.txtEmail.TabIndex = 0;
			this.toolTip.SetToolTip(this.txtEmail, "Separate email addresses with a comma (,).");
			this.txtEmail.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// grpRates
			// 
			this.grpRates.Controls.Add(this.numRates_Emergency);
			this.grpRates.Controls.Add(this.numRates_AfterHours);
			this.grpRates.Controls.Add(this.numRates_Standard);
			this.grpRates.Controls.Add(this.lblRates_Standard);
			this.grpRates.Controls.Add(this.lblRates_Emergency);
			this.grpRates.Controls.Add(this.lblRates_AfterHours);
			this.grpRates.Location = new System.Drawing.Point(426, 191);
			this.grpRates.Name = "grpRates";
			this.grpRates.Size = new System.Drawing.Size(385, 74);
			this.grpRates.TabIndex = 11;
			this.grpRates.TabStop = false;
			this.grpRates.Text = "Rates (per hour)";
			// 
			// numRates_Emergency
			// 
			this.numRates_Emergency.DecimalPlaces = 2;
			this.numRates_Emergency.Enabled = false;
			this.numRates_Emergency.Location = new System.Drawing.Point(197, 32);
			this.numRates_Emergency.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numRates_Emergency.Name = "numRates_Emergency";
			this.numRates_Emergency.Size = new System.Drawing.Size(66, 20);
			this.numRates_Emergency.TabIndex = 5;
			this.numRates_Emergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRates_Emergency.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numRates_AfterHours
			// 
			this.numRates_AfterHours.DecimalPlaces = 2;
			this.numRates_AfterHours.Enabled = false;
			this.numRates_AfterHours.Location = new System.Drawing.Point(105, 32);
			this.numRates_AfterHours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numRates_AfterHours.Name = "numRates_AfterHours";
			this.numRates_AfterHours.Size = new System.Drawing.Size(66, 20);
			this.numRates_AfterHours.TabIndex = 3;
			this.numRates_AfterHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRates_AfterHours.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numRates_Standard
			// 
			this.numRates_Standard.DecimalPlaces = 2;
			this.numRates_Standard.Enabled = false;
			this.numRates_Standard.Location = new System.Drawing.Point(9, 32);
			this.numRates_Standard.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numRates_Standard.Name = "numRates_Standard";
			this.numRates_Standard.Size = new System.Drawing.Size(66, 20);
			this.numRates_Standard.TabIndex = 1;
			this.numRates_Standard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRates_Standard.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblRates_Standard
			// 
			this.lblRates_Standard.AutoSize = true;
			this.lblRates_Standard.Location = new System.Drawing.Point(6, 16);
			this.lblRates_Standard.Name = "lblRates_Standard";
			this.lblRates_Standard.Size = new System.Drawing.Size(50, 13);
			this.lblRates_Standard.TabIndex = 0;
			this.lblRates_Standard.Text = "Standard";
			// 
			// lblRates_Emergency
			// 
			this.lblRates_Emergency.AutoSize = true;
			this.lblRates_Emergency.Location = new System.Drawing.Point(194, 16);
			this.lblRates_Emergency.Name = "lblRates_Emergency";
			this.lblRates_Emergency.Size = new System.Drawing.Size(60, 13);
			this.lblRates_Emergency.TabIndex = 4;
			this.lblRates_Emergency.Text = "Emergency";
			// 
			// lblRates_AfterHours
			// 
			this.lblRates_AfterHours.AutoSize = true;
			this.lblRates_AfterHours.Location = new System.Drawing.Point(102, 16);
			this.lblRates_AfterHours.Name = "lblRates_AfterHours";
			this.lblRates_AfterHours.Size = new System.Drawing.Size(60, 13);
			this.lblRates_AfterHours.TabIndex = 2;
			this.lblRates_AfterHours.Text = "After Hours";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.Enabled = false;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(495, 165);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(233, 21);
			this.cmbStatus.TabIndex = 10;
			this.cmbStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbStatus_DrawItem);
			this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(452, 168);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 9;
			this.lblStatus.Text = "Status";
			// 
			// txtFax
			// 
			this.txtFax.Location = new System.Drawing.Point(278, 165);
			this.txtFax.MaxLength = 20;
			this.txtFax.Name = "txtFax";
			this.txtFax.ReadOnly = true;
			this.txtFax.Size = new System.Drawing.Size(134, 20);
			this.txtFax.TabIndex = 7;
			this.txtFax.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtTelephone
			// 
			this.txtTelephone.Location = new System.Drawing.Point(103, 165);
			this.txtTelephone.MaxLength = 20;
			this.txtTelephone.Name = "txtTelephone";
			this.txtTelephone.ReadOnly = true;
			this.txtTelephone.Size = new System.Drawing.Size(134, 20);
			this.txtTelephone.TabIndex = 5;
			this.txtTelephone.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// grpShipping
			// 
			this.grpShipping.Controls.Add(this.txtShip_Country);
			this.grpShipping.Controls.Add(this.txtShip_Address);
			this.grpShipping.Controls.Add(this.txtShip_Zip);
			this.grpShipping.Controls.Add(this.lblShip_Country);
			this.grpShipping.Controls.Add(this.txtShip_State);
			this.grpShipping.Controls.Add(this.lblShip_Zip);
			this.grpShipping.Controls.Add(this.lblShip_Address);
			this.grpShipping.Controls.Add(this.lblShip_State);
			this.grpShipping.Controls.Add(this.txtShip_City);
			this.grpShipping.Controls.Add(this.lblShip_City);
			this.grpShipping.Enabled = false;
			this.grpShipping.Location = new System.Drawing.Point(426, 52);
			this.grpShipping.Name = "grpShipping";
			this.grpShipping.Size = new System.Drawing.Size(385, 107);
			this.grpShipping.TabIndex = 3;
			this.grpShipping.TabStop = false;
			this.grpShipping.Text = "Shipping Address";
			// 
			// txtShip_Country
			// 
			this.txtShip_Country.Location = new System.Drawing.Point(69, 83);
			this.txtShip_Country.MaxLength = 40;
			this.txtShip_Country.Name = "txtShip_Country";
			this.txtShip_Country.ReadOnly = true;
			this.txtShip_Country.Size = new System.Drawing.Size(134, 20);
			this.txtShip_Country.TabIndex = 9;
			this.txtShip_Country.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtShip_Address
			// 
			this.txtShip_Address.AcceptsReturn = true;
			this.txtShip_Address.Location = new System.Drawing.Point(69, 15);
			this.txtShip_Address.MaxLength = 192;
			this.txtShip_Address.Multiline = true;
			this.txtShip_Address.Name = "txtShip_Address";
			this.txtShip_Address.ReadOnly = true;
			this.txtShip_Address.Size = new System.Drawing.Size(309, 46);
			this.txtShip_Address.TabIndex = 1;
			this.txtShip_Address.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtShip_Zip
			// 
			this.txtShip_Zip.Location = new System.Drawing.Point(315, 62);
			this.txtShip_Zip.MaxLength = 10;
			this.txtShip_Zip.Name = "txtShip_Zip";
			this.txtShip_Zip.ReadOnly = true;
			this.txtShip_Zip.Size = new System.Drawing.Size(63, 20);
			this.txtShip_Zip.TabIndex = 7;
			this.txtShip_Zip.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblShip_Country
			// 
			this.lblShip_Country.AutoSize = true;
			this.lblShip_Country.Location = new System.Drawing.Point(20, 89);
			this.lblShip_Country.Name = "lblShip_Country";
			this.lblShip_Country.Size = new System.Drawing.Size(43, 13);
			this.lblShip_Country.TabIndex = 8;
			this.lblShip_Country.Text = "Country";
			// 
			// txtShip_State
			// 
			this.txtShip_State.Location = new System.Drawing.Point(247, 62);
			this.txtShip_State.MaxLength = 3;
			this.txtShip_State.Name = "txtShip_State";
			this.txtShip_State.ReadOnly = true;
			this.txtShip_State.Size = new System.Drawing.Size(34, 20);
			this.txtShip_State.TabIndex = 5;
			this.txtShip_State.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblShip_Zip
			// 
			this.lblShip_Zip.AutoSize = true;
			this.lblShip_Zip.Location = new System.Drawing.Point(290, 66);
			this.lblShip_Zip.Name = "lblShip_Zip";
			this.lblShip_Zip.Size = new System.Drawing.Size(22, 13);
			this.lblShip_Zip.TabIndex = 6;
			this.lblShip_Zip.Text = "Zip";
			// 
			// lblShip_Address
			// 
			this.lblShip_Address.AutoSize = true;
			this.lblShip_Address.Location = new System.Drawing.Point(18, 18);
			this.lblShip_Address.Name = "lblShip_Address";
			this.lblShip_Address.Size = new System.Drawing.Size(45, 13);
			this.lblShip_Address.TabIndex = 0;
			this.lblShip_Address.Text = "Address";
			// 
			// lblShip_State
			// 
			this.lblShip_State.AutoSize = true;
			this.lblShip_State.Location = new System.Drawing.Point(209, 66);
			this.lblShip_State.Name = "lblShip_State";
			this.lblShip_State.Size = new System.Drawing.Size(32, 13);
			this.lblShip_State.TabIndex = 4;
			this.lblShip_State.Text = "State";
			// 
			// txtShip_City
			// 
			this.txtShip_City.Location = new System.Drawing.Point(69, 62);
			this.txtShip_City.MaxLength = 40;
			this.txtShip_City.Name = "txtShip_City";
			this.txtShip_City.ReadOnly = true;
			this.txtShip_City.Size = new System.Drawing.Size(134, 20);
			this.txtShip_City.TabIndex = 3;
			this.txtShip_City.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblShip_City
			// 
			this.lblShip_City.AutoSize = true;
			this.lblShip_City.Location = new System.Drawing.Point(39, 66);
			this.lblShip_City.Name = "lblShip_City";
			this.lblShip_City.Size = new System.Drawing.Size(24, 13);
			this.lblShip_City.TabIndex = 2;
			this.lblShip_City.Text = "City";
			// 
			// grpMailing
			// 
			this.grpMailing.Controls.Add(this.txtCountry);
			this.grpMailing.Controls.Add(this.txtZip);
			this.grpMailing.Controls.Add(this.txtState);
			this.grpMailing.Controls.Add(this.lblAddress);
			this.grpMailing.Controls.Add(this.txtCity);
			this.grpMailing.Controls.Add(this.chkShipToMailingAddress);
			this.grpMailing.Controls.Add(this.lblCity);
			this.grpMailing.Controls.Add(this.txtAddress);
			this.grpMailing.Controls.Add(this.lblState);
			this.grpMailing.Controls.Add(this.lblZip);
			this.grpMailing.Controls.Add(this.lblCountry);
			this.grpMailing.Location = new System.Drawing.Point(20, 52);
			this.grpMailing.Name = "grpMailing";
			this.grpMailing.Size = new System.Drawing.Size(400, 107);
			this.grpMailing.TabIndex = 3;
			this.grpMailing.TabStop = false;
			this.grpMailing.Text = "Mailing Address";
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(83, 83);
			this.txtCountry.MaxLength = 40;
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.ReadOnly = true;
			this.txtCountry.Size = new System.Drawing.Size(134, 20);
			this.txtCountry.TabIndex = 9;
			this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
			this.txtCountry.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(329, 62);
			this.txtZip.MaxLength = 10;
			this.txtZip.Name = "txtZip";
			this.txtZip.ReadOnly = true;
			this.txtZip.Size = new System.Drawing.Size(63, 20);
			this.txtZip.TabIndex = 7;
			this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
			this.txtZip.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(261, 62);
			this.txtState.MaxLength = 3;
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(34, 20);
			this.txtState.TabIndex = 5;
			this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
			this.txtState.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(32, 18);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(45, 13);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "Address";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(83, 62);
			this.txtCity.MaxLength = 40;
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(134, 20);
			this.txtCity.TabIndex = 3;
			this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
			this.txtCity.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// chkShipToMailingAddress
			// 
			this.chkShipToMailingAddress.AutoSize = true;
			this.chkShipToMailingAddress.Checked = true;
			this.chkShipToMailingAddress.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShipToMailingAddress.Enabled = false;
			this.chkShipToMailingAddress.Location = new System.Drawing.Point(226, 88);
			this.chkShipToMailingAddress.Name = "chkShipToMailingAddress";
			this.chkShipToMailingAddress.Size = new System.Drawing.Size(136, 17);
			this.chkShipToMailingAddress.TabIndex = 10;
			this.chkShipToMailingAddress.Text = "Ship to Mailing Address";
			this.toolTip.SetToolTip(this.chkShipToMailingAddress, "Use the mailing address as the shipping address.");
			this.chkShipToMailingAddress.UseVisualStyleBackColor = true;
			this.chkShipToMailingAddress.CheckedChanged += new System.EventHandler(this.chkShipToMailingAddress_CheckedChanged);
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(53, 66);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(24, 13);
			this.lblCity.TabIndex = 2;
			this.lblCity.Text = "City";
			// 
			// txtAddress
			// 
			this.txtAddress.AcceptsReturn = true;
			this.txtAddress.Location = new System.Drawing.Point(83, 15);
			this.txtAddress.MaxLength = 192;
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ReadOnly = true;
			this.txtAddress.Size = new System.Drawing.Size(309, 46);
			this.txtAddress.TabIndex = 1;
			this.txtAddress.WordWrap = false;
			this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
			this.txtAddress.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(223, 66);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(32, 13);
			this.lblState.TabIndex = 4;
			this.lblState.Text = "State";
			// 
			// lblZip
			// 
			this.lblZip.AutoSize = true;
			this.lblZip.Location = new System.Drawing.Point(304, 66);
			this.lblZip.Name = "lblZip";
			this.lblZip.Size = new System.Drawing.Size(22, 13);
			this.lblZip.TabIndex = 6;
			this.lblZip.Text = "Zip";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(34, 89);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(43, 13);
			this.lblCountry.TabIndex = 8;
			this.lblCountry.Text = "Country";
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCompanyName.Location = new System.Drawing.Point(62, 20);
			this.txtCompanyName.MaxLength = 30;
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.ReadOnly = true;
			this.txtCompanyName.Size = new System.Drawing.Size(352, 26);
			this.txtCompanyName.TabIndex = 2;
			this.toolTip.SetToolTip(this.txtCompanyName, "Company Name");
			this.txtCompanyName.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblFax
			// 
			this.lblFax.AutoSize = true;
			this.lblFax.Location = new System.Drawing.Point(248, 168);
			this.lblFax.Name = "lblFax";
			this.lblFax.Size = new System.Drawing.Size(24, 13);
			this.lblFax.TabIndex = 6;
			this.lblFax.Text = "Fax";
			// 
			// lblTelephone
			// 
			this.lblTelephone.AutoSize = true;
			this.lblTelephone.Location = new System.Drawing.Point(39, 168);
			this.lblTelephone.Name = "lblTelephone";
			this.lblTelephone.Size = new System.Drawing.Size(58, 13);
			this.lblTelephone.TabIndex = 4;
			this.lblTelephone.Text = "Telephone";
			// 
			// pnlTechContacts
			// 
			this.pnlTechContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTechContacts.BackColor = System.Drawing.Color.LightGray;
			this.pnlTechContacts.Controls.Add(this.lblTechContacts);
			this.pnlTechContacts.Controls.Add(this.txtContact3_Name);
			this.pnlTechContacts.Controls.Add(this.lblContact3_Telephone);
			this.pnlTechContacts.Controls.Add(this.txtContact2_Name);
			this.pnlTechContacts.Controls.Add(this.lblContact3_Name);
			this.pnlTechContacts.Controls.Add(this.lblContact2_Telephone);
			this.pnlTechContacts.Controls.Add(this.txtContact3_Telephone);
			this.pnlTechContacts.Controls.Add(this.txtContact1_Name);
			this.pnlTechContacts.Controls.Add(this.lblContact2_Name);
			this.pnlTechContacts.Controls.Add(this.lblContact1_Telephone);
			this.pnlTechContacts.Controls.Add(this.txtContact2_Telephone);
			this.pnlTechContacts.Controls.Add(this.lblContact1_Name);
			this.pnlTechContacts.Controls.Add(this.txtContact1_Telephone);
			this.pnlTechContacts.Location = new System.Drawing.Point(3, 310);
			this.pnlTechContacts.Name = "pnlTechContacts";
			this.pnlTechContacts.Size = new System.Drawing.Size(232, 315);
			this.pnlTechContacts.TabIndex = 2;
			// 
			// lblTechContacts
			// 
			this.lblTechContacts.AutoEllipsis = true;
			this.lblTechContacts.BackColor = System.Drawing.Color.Black;
			this.lblTechContacts.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTechContacts.ForeColor = System.Drawing.Color.White;
			this.lblTechContacts.Location = new System.Drawing.Point(0, 0);
			this.lblTechContacts.Name = "lblTechContacts";
			this.lblTechContacts.Size = new System.Drawing.Size(232, 17);
			this.lblTechContacts.TabIndex = 13;
			this.lblTechContacts.Text = "ASC/Tech Contacts";
			this.lblTechContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtContact3_Name
			// 
			this.txtContact3_Name.Location = new System.Drawing.Point(80, 169);
			this.txtContact3_Name.MaxLength = 30;
			this.txtContact3_Name.Name = "txtContact3_Name";
			this.txtContact3_Name.ReadOnly = true;
			this.txtContact3_Name.Size = new System.Drawing.Size(134, 20);
			this.txtContact3_Name.TabIndex = 9;
			this.txtContact3_Name.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblContact3_Telephone
			// 
			this.lblContact3_Telephone.AutoSize = true;
			this.lblContact3_Telephone.Location = new System.Drawing.Point(16, 198);
			this.lblContact3_Telephone.Name = "lblContact3_Telephone";
			this.lblContact3_Telephone.Size = new System.Drawing.Size(58, 13);
			this.lblContact3_Telephone.TabIndex = 10;
			this.lblContact3_Telephone.Text = "Telephone";
			// 
			// txtContact2_Name
			// 
			this.txtContact2_Name.Location = new System.Drawing.Point(80, 105);
			this.txtContact2_Name.MaxLength = 30;
			this.txtContact2_Name.Name = "txtContact2_Name";
			this.txtContact2_Name.ReadOnly = true;
			this.txtContact2_Name.Size = new System.Drawing.Size(134, 20);
			this.txtContact2_Name.TabIndex = 5;
			this.txtContact2_Name.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblContact3_Name
			// 
			this.lblContact3_Name.AutoSize = true;
			this.lblContact3_Name.Location = new System.Drawing.Point(16, 172);
			this.lblContact3_Name.Name = "lblContact3_Name";
			this.lblContact3_Name.Size = new System.Drawing.Size(35, 13);
			this.lblContact3_Name.TabIndex = 8;
			this.lblContact3_Name.Text = "Name";
			// 
			// lblContact2_Telephone
			// 
			this.lblContact2_Telephone.AutoSize = true;
			this.lblContact2_Telephone.Location = new System.Drawing.Point(16, 134);
			this.lblContact2_Telephone.Name = "lblContact2_Telephone";
			this.lblContact2_Telephone.Size = new System.Drawing.Size(58, 13);
			this.lblContact2_Telephone.TabIndex = 6;
			this.lblContact2_Telephone.Text = "Telephone";
			// 
			// txtContact3_Telephone
			// 
			this.txtContact3_Telephone.Location = new System.Drawing.Point(80, 195);
			this.txtContact3_Telephone.MaxLength = 20;
			this.txtContact3_Telephone.Name = "txtContact3_Telephone";
			this.txtContact3_Telephone.ReadOnly = true;
			this.txtContact3_Telephone.Size = new System.Drawing.Size(134, 20);
			this.txtContact3_Telephone.TabIndex = 11;
			this.txtContact3_Telephone.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtContact1_Name
			// 
			this.txtContact1_Name.Location = new System.Drawing.Point(80, 41);
			this.txtContact1_Name.MaxLength = 30;
			this.txtContact1_Name.Name = "txtContact1_Name";
			this.txtContact1_Name.ReadOnly = true;
			this.txtContact1_Name.Size = new System.Drawing.Size(134, 20);
			this.txtContact1_Name.TabIndex = 1;
			this.txtContact1_Name.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblContact2_Name
			// 
			this.lblContact2_Name.AutoSize = true;
			this.lblContact2_Name.Location = new System.Drawing.Point(16, 108);
			this.lblContact2_Name.Name = "lblContact2_Name";
			this.lblContact2_Name.Size = new System.Drawing.Size(35, 13);
			this.lblContact2_Name.TabIndex = 4;
			this.lblContact2_Name.Text = "Name";
			// 
			// lblContact1_Telephone
			// 
			this.lblContact1_Telephone.AutoSize = true;
			this.lblContact1_Telephone.Location = new System.Drawing.Point(16, 70);
			this.lblContact1_Telephone.Name = "lblContact1_Telephone";
			this.lblContact1_Telephone.Size = new System.Drawing.Size(58, 13);
			this.lblContact1_Telephone.TabIndex = 2;
			this.lblContact1_Telephone.Text = "Telephone";
			// 
			// txtContact2_Telephone
			// 
			this.txtContact2_Telephone.Location = new System.Drawing.Point(80, 131);
			this.txtContact2_Telephone.MaxLength = 20;
			this.txtContact2_Telephone.Name = "txtContact2_Telephone";
			this.txtContact2_Telephone.ReadOnly = true;
			this.txtContact2_Telephone.Size = new System.Drawing.Size(134, 20);
			this.txtContact2_Telephone.TabIndex = 7;
			this.txtContact2_Telephone.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblContact1_Name
			// 
			this.lblContact1_Name.AutoSize = true;
			this.lblContact1_Name.Location = new System.Drawing.Point(16, 44);
			this.lblContact1_Name.Name = "lblContact1_Name";
			this.lblContact1_Name.Size = new System.Drawing.Size(35, 13);
			this.lblContact1_Name.TabIndex = 0;
			this.lblContact1_Name.Text = "Name";
			// 
			// txtContact1_Telephone
			// 
			this.txtContact1_Telephone.Location = new System.Drawing.Point(80, 67);
			this.txtContact1_Telephone.MaxLength = 20;
			this.txtContact1_Telephone.Name = "txtContact1_Telephone";
			this.txtContact1_Telephone.ReadOnly = true;
			this.txtContact1_Telephone.Size = new System.Drawing.Size(134, 20);
			this.txtContact1_Telephone.TabIndex = 3;
			this.txtContact1_Telephone.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// pnlAdditional
			// 
			this.pnlAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAdditional.Controls.Add(this.tabAdditionalInfo);
			this.pnlAdditional.Location = new System.Drawing.Point(251, 310);
			this.pnlAdditional.Name = "pnlAdditional";
			this.pnlAdditional.Size = new System.Drawing.Size(585, 315);
			this.pnlAdditional.TabIndex = 3;
			// 
			// tabAdditionalInfo
			// 
			this.tabAdditionalInfo.Controls.Add(this.tabNotes);
			this.tabAdditionalInfo.Controls.Add(this.tabAssets);
			this.tabAdditionalInfo.Controls.Add(this.tabTickets);
			this.tabAdditionalInfo.Controls.Add(this.tabLegacyRMA);
			this.tabAdditionalInfo.Controls.Add(this.tabRMA);
			this.tabAdditionalInfo.Controls.Add(this.tabShipments);
			this.tabAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabAdditionalInfo.Location = new System.Drawing.Point(0, 0);
			this.tabAdditionalInfo.Name = "tabAdditionalInfo";
			this.tabAdditionalInfo.SelectedIndex = 0;
			this.tabAdditionalInfo.Size = new System.Drawing.Size(585, 315);
			this.tabAdditionalInfo.TabIndex = 2;
			this.tabAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this.tabAdditionalInfo_SelectedIndexChanged);
			// 
			// tabNotes
			// 
			this.tabNotes.Controls.Add(this.txtNotes);
			this.tabNotes.Location = new System.Drawing.Point(4, 22);
			this.tabNotes.Name = "tabNotes";
			this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
			this.tabNotes.Size = new System.Drawing.Size(577, 289);
			this.tabNotes.TabIndex = 0;
			this.tabNotes.Text = "Notes";
			this.tabNotes.UseVisualStyleBackColor = true;
			// 
			// txtNotes
			// 
			this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNotes.Location = new System.Drawing.Point(3, 3);
			this.txtNotes.MaxLength = 1024;
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ReadOnly = true;
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(571, 283);
			this.txtNotes.TabIndex = 2;
			// 
			// tabAssets
			// 
			this.tabAssets.Controls.Add(this.ucAssetList1);
			this.tabAssets.Location = new System.Drawing.Point(4, 22);
			this.tabAssets.Name = "tabAssets";
			this.tabAssets.Padding = new System.Windows.Forms.Padding(3);
			this.tabAssets.Size = new System.Drawing.Size(577, 289);
			this.tabAssets.TabIndex = 1;
			this.tabAssets.Text = "Assigned Assets";
			this.tabAssets.UseVisualStyleBackColor = true;
			// 
			// ucAssetList1
			// 
			this.ucAssetList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucAssetList1.EmptyListMessage = "No assets assigned to this tech.";
			this.ucAssetList1.Location = new System.Drawing.Point(3, 3);
			this.ucAssetList1.Name = "ucAssetList1";
			this.ucAssetList1.Size = new System.Drawing.Size(571, 283);
			this.ucAssetList1.TabIndex = 0;
			this.ucAssetList1.ViewAsset += new SDB.UserControls.Asset.ucAssetList.AssetEvent(this.ucAssetList1_ViewAsset);
			// 
			// tabTickets
			// 
			this.tabTickets.Controls.Add(this.olvTickets);
			this.tabTickets.Controls.Add(this.pnlTickets_Control);
			this.tabTickets.Location = new System.Drawing.Point(4, 22);
			this.tabTickets.Name = "tabTickets";
			this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
			this.tabTickets.Size = new System.Drawing.Size(577, 289);
			this.tabTickets.TabIndex = 2;
			this.tabTickets.Text = "Tickets";
			this.tabTickets.UseVisualStyleBackColor = true;
			// 
			// olvTickets
			// 
			this.olvTickets.AllColumns.Add(this.olvColTickets_ID);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Date);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Asset);
			this.olvTickets.AllColumns.Add(this.olvColTickets_AssetLocation);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Symptoms);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Solutions);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Panel);
			this.olvTickets.AllColumns.Add(this.olvColTickets_Issue);
			this.olvTickets.AllowColumnReorder = true;
			this.olvTickets.CellEditUseWholeCell = false;
			this.olvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTickets_ID,
            this.olvColTickets_Date,
            this.olvColTickets_Asset,
            this.olvColTickets_AssetLocation,
            this.olvColTickets_Symptoms,
            this.olvColTickets_Solutions});
			this.olvTickets.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvTickets.EmptyListMsg = "No tickets.";
			this.olvTickets.FullRowSelect = true;
			this.olvTickets.GridLines = true;
			this.olvTickets.HasCollapsibleGroups = false;
			this.olvTickets.Location = new System.Drawing.Point(3, 33);
			this.olvTickets.MultiSelect = false;
			this.olvTickets.Name = "olvTickets";
			this.olvTickets.ShowCommandMenuOnRightClick = true;
			this.olvTickets.ShowGroups = false;
			this.olvTickets.Size = new System.Drawing.Size(571, 253);
			this.olvTickets.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.olvTickets.TabIndex = 2;
			this.olvTickets.UseCompatibleStateImageBehavior = false;
			this.olvTickets.View = System.Windows.Forms.View.Details;
			this.olvTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTickets_MouseDoubleClick);
			// 
			// olvColTickets_ID
			// 
			this.olvColTickets_ID.AspectName = "ID";
			this.olvColTickets_ID.Groupable = false;
			this.olvColTickets_ID.IsEditable = false;
			this.olvColTickets_ID.Text = "Ticket";
			this.olvColTickets_ID.Width = 45;
			// 
			// olvColTickets_Date
			// 
			this.olvColTickets_Date.AspectName = "OpenDateTime";
			this.olvColTickets_Date.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColTickets_Date.IsEditable = false;
			this.olvColTickets_Date.Text = "Date";
			this.olvColTickets_Date.Width = 70;
			// 
			// olvColTickets_Asset
			// 
			this.olvColTickets_Asset.AspectName = "ExtraProperties.AssetName";
			this.olvColTickets_Asset.IsEditable = false;
			this.olvColTickets_Asset.Text = "Asset";
			this.olvColTickets_Asset.Width = 70;
			// 
			// olvColTickets_AssetLocation
			// 
			this.olvColTickets_AssetLocation.AspectName = "ExtraProperties.AssetLocation";
			this.olvColTickets_AssetLocation.Text = "Location";
			this.olvColTickets_AssetLocation.Width = 140;
			// 
			// olvColTickets_Symptoms
			// 
			this.olvColTickets_Symptoms.AspectName = "ExtraProperties.Symptoms";
			this.olvColTickets_Symptoms.IsEditable = false;
			this.olvColTickets_Symptoms.Text = "Symptom(s)";
			this.olvColTickets_Symptoms.Width = 150;
			// 
			// olvColTickets_Solutions
			// 
			this.olvColTickets_Solutions.AspectName = "ExtraProperties.Solutions";
			this.olvColTickets_Solutions.Text = "Solution(s)";
			this.olvColTickets_Solutions.Width = 150;
			// 
			// olvColTickets_Panel
			// 
			this.olvColTickets_Panel.AspectName = "ExtraProperties.AssetPanel";
			this.olvColTickets_Panel.DisplayIndex = 6;
			this.olvColTickets_Panel.IsEditable = false;
			this.olvColTickets_Panel.IsVisible = false;
			this.olvColTickets_Panel.Text = "Panel";
			this.olvColTickets_Panel.Width = 80;
			// 
			// olvColTickets_Issue
			// 
			this.olvColTickets_Issue.AspectName = "CustomerIssueNumber";
			this.olvColTickets_Issue.DisplayIndex = 7;
			this.olvColTickets_Issue.Groupable = false;
			this.olvColTickets_Issue.IsEditable = false;
			this.olvColTickets_Issue.IsVisible = false;
			this.olvColTickets_Issue.Text = "Issue";
			this.olvColTickets_Issue.Width = 50;
			// 
			// pnlTickets_Control
			// 
			this.pnlTickets_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlTickets_Control.Controls.Add(this.lblTicketQty);
			this.pnlTickets_Control.Controls.Add(this.txtTicketQty);
			this.pnlTickets_Control.Controls.Add(this.lblTickets_View);
			this.pnlTickets_Control.Controls.Add(this.radTickets_Closed);
			this.pnlTickets_Control.Controls.Add(this.radTickets_Open);
			this.pnlTickets_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTickets_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlTickets_Control.Name = "pnlTickets_Control";
			this.pnlTickets_Control.Size = new System.Drawing.Size(571, 30);
			this.pnlTickets_Control.TabIndex = 1;
			// 
			// lblTicketQty
			// 
			this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTicketQty.AutoSize = true;
			this.lblTicketQty.Location = new System.Drawing.Point(472, 7);
			this.lblTicketQty.Name = "lblTicketQty";
			this.lblTicketQty.Size = new System.Drawing.Size(45, 13);
			this.lblTicketQty.TabIndex = 5;
			this.lblTicketQty.Text = "Tickets:";
			// 
			// txtTicketQty
			// 
			this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTicketQty.Location = new System.Drawing.Point(523, 2);
			this.txtTicketQty.Name = "txtTicketQty";
			this.txtTicketQty.ReadOnly = true;
			this.txtTicketQty.Size = new System.Drawing.Size(45, 22);
			this.txtTicketQty.TabIndex = 6;
			this.txtTicketQty.TabStop = false;
			this.txtTicketQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblTickets_View
			// 
			this.lblTickets_View.AutoSize = true;
			this.lblTickets_View.Location = new System.Drawing.Point(3, 7);
			this.lblTickets_View.Name = "lblTickets_View";
			this.lblTickets_View.Size = new System.Drawing.Size(33, 13);
			this.lblTickets_View.TabIndex = 0;
			this.lblTickets_View.Text = "View:";
			// 
			// radTickets_Closed
			// 
			this.radTickets_Closed.AutoSize = true;
			this.radTickets_Closed.Location = new System.Drawing.Point(99, 5);
			this.radTickets_Closed.Name = "radTickets_Closed";
			this.radTickets_Closed.Size = new System.Drawing.Size(138, 17);
			this.radTickets_Closed.TabIndex = 3;
			this.radTickets_Closed.Text = "Closed Within One Year";
			this.radTickets_Closed.UseVisualStyleBackColor = true;
			// 
			// radTickets_Open
			// 
			this.radTickets_Open.AutoSize = true;
			this.radTickets_Open.Checked = true;
			this.radTickets_Open.Location = new System.Drawing.Point(42, 5);
			this.radTickets_Open.Name = "radTickets_Open";
			this.radTickets_Open.Size = new System.Drawing.Size(51, 17);
			this.radTickets_Open.TabIndex = 2;
			this.radTickets_Open.TabStop = true;
			this.radTickets_Open.Text = "Open";
			this.radTickets_Open.UseVisualStyleBackColor = true;
			this.radTickets_Open.CheckedChanged += new System.EventHandler(this.radTickets_Open_CheckedChanged);
			// 
			// tabLegacyRMA
			// 
			this.tabLegacyRMA.Controls.Add(this.olvLegacyRMAs);
			this.tabLegacyRMA.Controls.Add(this.pnlRMA_Control);
			this.tabLegacyRMA.Location = new System.Drawing.Point(4, 22);
			this.tabLegacyRMA.Name = "tabLegacyRMA";
			this.tabLegacyRMA.Padding = new System.Windows.Forms.Padding(3);
			this.tabLegacyRMA.Size = new System.Drawing.Size(577, 289);
			this.tabLegacyRMA.TabIndex = 4;
			this.tabLegacyRMA.Text = "Legacy RMAs";
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
			this.olvLegacyRMAs.EmptyListMsg = "No Legacy RMAs for this tech.";
			this.olvLegacyRMAs.FullRowSelect = true;
			this.olvLegacyRMAs.GridLines = true;
			this.olvLegacyRMAs.HasCollapsibleGroups = false;
			this.olvLegacyRMAs.Location = new System.Drawing.Point(3, 33);
			this.olvLegacyRMAs.Name = "olvLegacyRMAs";
			this.olvLegacyRMAs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvLegacyRMAs.ShowCommandMenuOnRightClick = true;
			this.olvLegacyRMAs.ShowGroups = false;
			this.olvLegacyRMAs.Size = new System.Drawing.Size(571, 253);
			this.olvLegacyRMAs.TabIndex = 6;
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
			this.pnlRMA_Control.Controls.Add(this.lblLegacyRMAQty);
			this.pnlRMA_Control.Controls.Add(this.txtLegacyRMAQty);
			this.pnlRMA_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRMA_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlRMA_Control.Name = "pnlRMA_Control";
			this.pnlRMA_Control.Size = new System.Drawing.Size(571, 30);
			this.pnlRMA_Control.TabIndex = 5;
			// 
			// lblLegacyRMAQty
			// 
			this.lblLegacyRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLegacyRMAQty.AutoSize = true;
			this.lblLegacyRMAQty.Location = new System.Drawing.Point(440, 9);
			this.lblLegacyRMAQty.Name = "lblLegacyRMAQty";
			this.lblLegacyRMAQty.Size = new System.Drawing.Size(77, 13);
			this.lblLegacyRMAQty.TabIndex = 9;
			this.lblLegacyRMAQty.Text = "Legacy RMAs:";
			// 
			// txtLegacyRMAQty
			// 
			this.txtLegacyRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLegacyRMAQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLegacyRMAQty.Location = new System.Drawing.Point(523, 4);
			this.txtLegacyRMAQty.Name = "txtLegacyRMAQty";
			this.txtLegacyRMAQty.ReadOnly = true;
			this.txtLegacyRMAQty.Size = new System.Drawing.Size(45, 22);
			this.txtLegacyRMAQty.TabIndex = 10;
			this.txtLegacyRMAQty.TabStop = false;
			this.txtLegacyRMAQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tabRMA
			// 
			this.tabRMA.Controls.Add(this.ucRMAList1);
			this.tabRMA.Controls.Add(this.pnlRmaDetail);
			this.tabRMA.Location = new System.Drawing.Point(4, 22);
			this.tabRMA.Name = "tabRMA";
			this.tabRMA.Size = new System.Drawing.Size(577, 289);
			this.tabRMA.TabIndex = 5;
			this.tabRMA.Text = "RMAs";
			this.tabRMA.UseVisualStyleBackColor = true;
			// 
			// ucRMAList1
			// 
			this.ucRMAList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucRMAList1.Location = new System.Drawing.Point(0, 27);
			this.ucRMAList1.Name = "ucRMAList1";
			this.ucRMAList1.ShowCreateButton = false;
			this.ucRMAList1.ShowFilter = true;
			this.ucRMAList1.Size = new System.Drawing.Size(577, 262);
			this.ucRMAList1.TabIndex = 0;
			this.ucRMAList1.ViewRMA += new SDB.UserControls.RMA.RmaList.RMAEvent(this.ucRMAList1_ViewRMA);
			// 
			// pnlRmaDetail
			// 
			this.pnlRmaDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlRmaDetail.Controls.Add(this.lblRmaAssembliesUnit);
			this.pnlRmaDetail.Controls.Add(this.txtRmaAssembliesAverageDaysToFirstReceive);
			this.pnlRmaDetail.Controls.Add(this.label2);
			this.pnlRmaDetail.Controls.Add(this.txtRmaAssembliesPercentage);
			this.pnlRmaDetail.Controls.Add(this.lblRmaAssembliesOf);
			this.pnlRmaDetail.Controls.Add(this.txtRmaAssembliesReceived);
			this.pnlRmaDetail.Controls.Add(this.lblRmaAssembliesReceived);
			this.pnlRmaDetail.Controls.Add(this.txtRmaAssembliesTotal);
			this.pnlRmaDetail.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRmaDetail.Location = new System.Drawing.Point(0, 0);
			this.pnlRmaDetail.Name = "pnlRmaDetail";
			this.pnlRmaDetail.Size = new System.Drawing.Size(577, 27);
			this.pnlRmaDetail.TabIndex = 1;
			// 
			// lblRmaAssembliesUnit
			// 
			this.lblRmaAssembliesUnit.AutoSize = true;
			this.lblRmaAssembliesUnit.Location = new System.Drawing.Point(230, 7);
			this.lblRmaAssembliesUnit.Name = "lblRmaAssembliesUnit";
			this.lblRmaAssembliesUnit.Size = new System.Drawing.Size(61, 13);
			this.lblRmaAssembliesUnit.TabIndex = 8;
			this.lblRmaAssembliesUnit.Text = "assemblies.";
			// 
			// txtRmaAssembliesAverageDaysToFirstReceive
			// 
			this.txtRmaAssembliesAverageDaysToFirstReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRmaAssembliesAverageDaysToFirstReceive.Location = new System.Drawing.Point(507, 4);
			this.txtRmaAssembliesAverageDaysToFirstReceive.Name = "txtRmaAssembliesAverageDaysToFirstReceive";
			this.txtRmaAssembliesAverageDaysToFirstReceive.ReadOnly = true;
			this.txtRmaAssembliesAverageDaysToFirstReceive.Size = new System.Drawing.Size(67, 20);
			this.txtRmaAssembliesAverageDaysToFirstReceive.TabIndex = 7;
			this.txtRmaAssembliesAverageDaysToFirstReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(333, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Average days to receive first assy:";
			// 
			// txtRmaAssembliesPercentage
			// 
			this.txtRmaAssembliesPercentage.Location = new System.Drawing.Point(176, 4);
			this.txtRmaAssembliesPercentage.Name = "txtRmaAssembliesPercentage";
			this.txtRmaAssembliesPercentage.ReadOnly = true;
			this.txtRmaAssembliesPercentage.Size = new System.Drawing.Size(48, 20);
			this.txtRmaAssembliesPercentage.TabIndex = 5;
			this.txtRmaAssembliesPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRmaAssembliesOf
			// 
			this.lblRmaAssembliesOf.AutoSize = true;
			this.lblRmaAssembliesOf.Location = new System.Drawing.Point(108, 7);
			this.lblRmaAssembliesOf.Name = "lblRmaAssembliesOf";
			this.lblRmaAssembliesOf.Size = new System.Drawing.Size(16, 13);
			this.lblRmaAssembliesOf.TabIndex = 4;
			this.lblRmaAssembliesOf.Text = "of";
			// 
			// txtRmaAssembliesReceived
			// 
			this.txtRmaAssembliesReceived.Location = new System.Drawing.Point(62, 4);
			this.txtRmaAssembliesReceived.Name = "txtRmaAssembliesReceived";
			this.txtRmaAssembliesReceived.ReadOnly = true;
			this.txtRmaAssembliesReceived.Size = new System.Drawing.Size(40, 20);
			this.txtRmaAssembliesReceived.TabIndex = 3;
			this.txtRmaAssembliesReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRmaAssembliesReceived
			// 
			this.lblRmaAssembliesReceived.AutoSize = true;
			this.lblRmaAssembliesReceived.Location = new System.Drawing.Point(3, 7);
			this.lblRmaAssembliesReceived.Name = "lblRmaAssembliesReceived";
			this.lblRmaAssembliesReceived.Size = new System.Drawing.Size(53, 13);
			this.lblRmaAssembliesReceived.TabIndex = 2;
			this.lblRmaAssembliesReceived.Text = "Received";
			// 
			// txtRmaAssembliesTotal
			// 
			this.txtRmaAssembliesTotal.Location = new System.Drawing.Point(130, 4);
			this.txtRmaAssembliesTotal.Name = "txtRmaAssembliesTotal";
			this.txtRmaAssembliesTotal.ReadOnly = true;
			this.txtRmaAssembliesTotal.Size = new System.Drawing.Size(40, 20);
			this.txtRmaAssembliesTotal.TabIndex = 1;
			this.txtRmaAssembliesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tabShipments
			// 
			this.tabShipments.Controls.Add(this.ucShipmentList1);
			this.tabShipments.Location = new System.Drawing.Point(4, 22);
			this.tabShipments.Name = "tabShipments";
			this.tabShipments.Padding = new System.Windows.Forms.Padding(3);
			this.tabShipments.Size = new System.Drawing.Size(577, 289);
			this.tabShipments.TabIndex = 3;
			this.tabShipments.Text = "Shipments";
			this.tabShipments.UseVisualStyleBackColor = true;
			// 
			// ucShipmentList1
			// 
			this.ucShipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucShipmentList1.Location = new System.Drawing.Point(3, 3);
			this.ucShipmentList1.Name = "ucShipmentList1";
			this.ucShipmentList1.ShowCreateButton = true;
			this.ucShipmentList1.Size = new System.Drawing.Size(571, 283);
			this.ucShipmentList1.TabIndex = 0;
			this.ucShipmentList1.CreateShipment += new SDB.UserControls.Shipment.ucShipmentList.CreateEvent(this.ucShipmentList_CreateShipment);
			this.ucShipmentList1.ViewShipment += new SDB.UserControls.Shipment.ucShipmentList.ShipmentEvent(this.ucShipmentList_ViewShipment);
			this.ucShipmentList1.ViewTracking += new SDB.UserControls.Shipment.ucShipmentList.TrackingEvent(this.ucShipmentList_ViewTracking);
			// 
			// pnlControl_Top
			// 
			this.pnlControl_Top.BackColor = System.Drawing.Color.LightBlue;
			this.pnlControl_Top.Controls.Add(this.toolStrip1);
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
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(636, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(97, 23);
			this.btnCancel.TabIndex = 4;
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
			this.btnEditSave.TabIndex = 5;
			this.btnEditSave.Text = "Edit Tech";
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
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(674, 3);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 3;
			this.btnNext.Text = ">";
			this.toolTip.SetToolTip(this.btnNext, "Next tech (alphabetically by name).");
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(90, 3);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(75, 23);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "<";
			this.toolTip.SetToolTip(this.btnPrevious, "Previous tech (alphabetically by name).");
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// pnlControl_Bottom
			// 
			this.pnlControl_Bottom.BackColor = System.Drawing.Color.Silver;
			this.pnlControl_Bottom.Controls.Add(this.btnNext);
			this.pnlControl_Bottom.Controls.Add(this.btnPrevious);
			this.pnlControl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlControl_Bottom.Location = new System.Drawing.Point(0, 637);
			this.pnlControl_Bottom.Name = "pnlControl_Bottom";
			this.pnlControl_Bottom.Size = new System.Drawing.Size(839, 30);
			this.pnlControl_Bottom.TabIndex = 4;
			// 
			// timerRmaWarningFlasher
			// 
			this.timerRmaWarningFlasher.Interval = 750;
			this.timerRmaWarningFlasher.Tick += new System.EventHandler(this.timerRmaWarningFlasher_Tick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(317, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(123, 22);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddNew,
            this.mnuDelete});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(91, 19);
			this.toolStripDropDownButton1.Text = "Tech Options";
			// 
			// mnuAddNew
			// 
			this.mnuAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.mnuAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuAddNew.Name = "mnuAddNew";
			this.mnuAddNew.ShowShortcutKeys = false;
			this.mnuAddNew.Size = new System.Drawing.Size(152, 22);
			this.mnuAddNew.Text = "Add New Tech";
			this.mnuAddNew.ToolTipText = "Add a new asset to the database.";
			this.mnuAddNew.Click += new System.EventHandler(this.mnuAddNew_Click);
			// 
			// mnuDelete
			// 
			this.mnuDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.mnuDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuDelete.Name = "mnuDelete";
			this.mnuDelete.ShowShortcutKeys = false;
			this.mnuDelete.Size = new System.Drawing.Size(152, 22);
			this.mnuDelete.Text = "Delete Tech";
			this.mnuDelete.ToolTipText = "Deletes the asset entirely.\r\nWill offer to merge with another asset if any items " +
    "are associated with the asset.\r\nYou cannot delete an asset with attached items (" +
    "tickets, RMAs, shipments).";
			this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
			// 
			// TechEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlControl_Bottom);
			this.Controls.Add(this.pnlControl_Top);
			this.Controls.Add(this.pnlAdditional);
			this.Controls.Add(this.pnlTechContacts);
			this.Controls.Add(this.pnlInfo);
			this.Name = "TechEditor";
			this.Size = new System.Drawing.Size(839, 667);
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.grpEmail.ResumeLayout(false);
			this.grpEmail.PerformLayout();
			this.grpRates.ResumeLayout(false);
			this.grpRates.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numRates_Emergency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRates_AfterHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRates_Standard)).EndInit();
			this.grpShipping.ResumeLayout(false);
			this.grpShipping.PerformLayout();
			this.grpMailing.ResumeLayout(false);
			this.grpMailing.PerformLayout();
			this.pnlTechContacts.ResumeLayout(false);
			this.pnlTechContacts.PerformLayout();
			this.pnlAdditional.ResumeLayout(false);
			this.tabAdditionalInfo.ResumeLayout(false);
			this.tabNotes.ResumeLayout(false);
			this.tabNotes.PerformLayout();
			this.tabAssets.ResumeLayout(false);
			this.tabTickets.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
			this.pnlTickets_Control.ResumeLayout(false);
			this.pnlTickets_Control.PerformLayout();
			this.tabLegacyRMA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvLegacyRMAs)).EndInit();
			this.pnlRMA_Control.ResumeLayout(false);
			this.pnlRMA_Control.PerformLayout();
			this.tabRMA.ResumeLayout(false);
			this.pnlRmaDetail.ResumeLayout(false);
			this.pnlRmaDetail.PerformLayout();
			this.tabShipments.ResumeLayout(false);
			this.pnlControl_Top.ResumeLayout(false);
			this.pnlControl_Top.PerformLayout();
			this.pnlControl_Bottom.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtFax;
		private System.Windows.Forms.TextBox txtTelephone;
		private System.Windows.Forms.GroupBox grpShipping;
		private System.Windows.Forms.TextBox txtShip_Country;
		private System.Windows.Forms.TextBox txtShip_Address;
		private System.Windows.Forms.TextBox txtShip_Zip;
		private System.Windows.Forms.Label lblShip_Country;
		private System.Windows.Forms.TextBox txtShip_State;
		private System.Windows.Forms.Label lblShip_Zip;
		private System.Windows.Forms.Label lblShip_Address;
		private System.Windows.Forms.Label lblShip_State;
		private System.Windows.Forms.TextBox txtShip_City;
		private System.Windows.Forms.Label lblShip_City;
		private System.Windows.Forms.GroupBox grpMailing;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.CheckBox chkShipToMailingAddress;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.Label lblFax;
		private System.Windows.Forms.Label lblTelephone;
		private System.Windows.Forms.Panel pnlTechContacts;
		private System.Windows.Forms.Panel pnlAdditional;
		private System.Windows.Forms.Panel pnlControl_Top;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel pnlControl_Bottom;
		private System.Windows.Forms.Button btnEditSave;
		private System.Windows.Forms.TextBox txtContact3_Name;
		private System.Windows.Forms.Label lblContact3_Telephone;
		private System.Windows.Forms.Label lblContact3_Name;
		private System.Windows.Forms.TextBox txtContact3_Telephone;
		private System.Windows.Forms.TextBox txtContact2_Name;
		private System.Windows.Forms.Label lblContact2_Telephone;
		private System.Windows.Forms.Label lblContact2_Name;
		private System.Windows.Forms.TextBox txtContact2_Telephone;
		private System.Windows.Forms.TextBox txtContact1_Name;
		private System.Windows.Forms.Label lblContact1_Telephone;
		private System.Windows.Forms.Label lblContact1_Name;
		private System.Windows.Forms.TextBox txtContact1_Telephone;
		private System.Windows.Forms.TabControl tabAdditionalInfo;
		private System.Windows.Forms.TabPage tabNotes;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.TabPage tabAssets;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TabPage tabTickets;
		private System.Windows.Forms.Panel pnlTickets_Control;
		private System.Windows.Forms.Label lblTicketQty;
		private System.Windows.Forms.TextBox txtTicketQty;
		private System.Windows.Forms.Label lblTickets_View;
		private System.Windows.Forms.RadioButton radTickets_Closed;
		private System.Windows.Forms.RadioButton radTickets_Open;
		private BrightIdeasSoftware.ObjectListView olvTickets;
		private BrightIdeasSoftware.OLVColumn olvColTickets_ID;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Date;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Issue;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Asset;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Panel;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Symptoms;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TabPage tabShipments;
		private System.Windows.Forms.TabPage tabLegacyRMA;
		private BrightIdeasSoftware.OLVColumn olvColTickets_Solutions;
		private BrightIdeasSoftware.ObjectListView olvLegacyRMAs;
		private BrightIdeasSoftware.OLVColumn olvColRMA_ID;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Date;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedBy;
		private System.Windows.Forms.Panel pnlRMA_Control;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedTo;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Closed;
		private System.Windows.Forms.Label lblLegacyRMAQty;
		private System.Windows.Forms.TextBox txtLegacyRMAQty;
		private System.Windows.Forms.TabPage tabRMA;
		private RmaList ucRMAList1;
		private System.Windows.Forms.Label lblRates_Standard;
		private System.Windows.Forms.GroupBox grpRates;
		private ClassFixedNumericUpDown numRates_Emergency;
		private ClassFixedNumericUpDown numRates_AfterHours;
		private ClassFixedNumericUpDown numRates_Standard;
		private System.Windows.Forms.Label lblRates_Emergency;
		private System.Windows.Forms.Label lblRates_AfterHours;
		private System.Windows.Forms.GroupBox grpEmail;
		private ucShipmentList ucShipmentList1;
		private System.Windows.Forms.Label lblTechInfo;
		private System.Windows.Forms.Label lblTechContacts;
		private BrightIdeasSoftware.OLVColumn olvColTickets_AssetLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlRmaDetail;
		private System.Windows.Forms.TextBox txtRmaAssembliesAverageDaysToFirstReceive;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRmaAssembliesPercentage;
		private System.Windows.Forms.Label lblRmaAssembliesOf;
		private System.Windows.Forms.TextBox txtRmaAssembliesReceived;
		private System.Windows.Forms.Label lblRmaAssembliesReceived;
		private System.Windows.Forms.TextBox txtRmaAssembliesTotal;
		private System.Windows.Forms.Label lblRmaAssembliesUnit;
		private System.Windows.Forms.Button btnRmaWarning;
		private System.Windows.Forms.Timer timerRmaWarningFlasher;
		private ucAssetList ucAssetList1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem mnuAddNew;
		private System.Windows.Forms.ToolStripMenuItem mnuDelete;
	}
}
