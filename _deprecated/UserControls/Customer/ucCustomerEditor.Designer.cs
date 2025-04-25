using SDB.Classes;

namespace SDB.UserControls
{
	partial class CustomerEditor
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
            this.pnlCustomerInfo = new System.Windows.Forms.Panel();
            this.cmbCustomerStanding = new System.Windows.Forms.ComboBox();
            this.lblCustomerTag = new System.Windows.Forms.Label();
            this.lblCustomerStanding = new System.Windows.Forms.Label();
            this.cmbCustomerTag = new System.Windows.Forms.ComboBox();
            this.lblCustomerSSR = new System.Windows.Forms.Label();
            this.cmbCustomerSSR = new System.Windows.Forms.ComboBox();
            this.btnMarketList = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.cmbCustomerSalesperson = new System.Windows.Forms.ComboBox();
            this.pnlTechContacts = new System.Windows.Forms.Panel();
            this.txtMarketNumber_3 = new System.Windows.Forms.TextBox();
            this.lblMarketNumber_3 = new System.Windows.Forms.Label();
            this.txtMarketPosition_3 = new System.Windows.Forms.TextBox();
            this.lblMarketPosition_3 = new System.Windows.Forms.Label();
            this.txtMarketName_3 = new System.Windows.Forms.TextBox();
            this.lblMarketName_3 = new System.Windows.Forms.Label();
            this.txtMarketNumber_2 = new System.Windows.Forms.TextBox();
            this.lblMarketNumber_2 = new System.Windows.Forms.Label();
            this.txtMarketPosition_2 = new System.Windows.Forms.TextBox();
            this.lblMarketPosition_2 = new System.Windows.Forms.Label();
            this.txtMarketName_2 = new System.Windows.Forms.TextBox();
            this.lblMarketName_2 = new System.Windows.Forms.Label();
            this.txtMarketNumber_1 = new System.Windows.Forms.TextBox();
            this.lblMarketNumber_1 = new System.Windows.Forms.Label();
            this.txtMarketPosition_1 = new System.Windows.Forms.TextBox();
            this.lblMarketPosition_1 = new System.Windows.Forms.Label();
            this.txtMarketName_1 = new System.Windows.Forms.TextBox();
            this.lblMarketName_1 = new System.Windows.Forms.Label();
            this.lblTechContacts = new System.Windows.Forms.Label();
            this.pnlControl_Top = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCustomerOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddCustomerTag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMarketOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddMarket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditMarket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.chkSubscribe = new System.Windows.Forms.CheckBox();
            this.pnlControl_Bottom = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAdditional = new System.Windows.Forms.Panel();
            this.tabAdditionalInfo = new System.Windows.Forms.TabControl();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.txtMarketNotes = new System.Windows.Forms.TextBox();
            this.tabAssets = new System.Windows.Forms.TabPage();
            this.ucAssetList1 = new SDB.UserControls.ucAssetList();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.olvTickets = new BrightIdeasSoftware.ObjectListView();
            this.olvColTickets_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTickets_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTickets_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTickets_AssetLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTickets_Symptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTickets_Solutions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlTickets_Control = new System.Windows.Forms.Panel();
            this.radClosedTickets = new System.Windows.Forms.RadioButton();
            this.radOpenTickets = new System.Windows.Forms.RadioButton();
            this.lblTicketQty = new System.Windows.Forms.Label();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pnlMarketInfo = new System.Windows.Forms.Panel();
            this.grpSalesperson = new System.Windows.Forms.GroupBox();
            this.lblSalespersonPhone = new System.Windows.Forms.Label();
            this.txtSalespersonPhone = new System.Windows.Forms.TextBox();
            this.lblSalespersonEmail = new System.Windows.Forms.Label();
            this.txtSalespersonEmail = new System.Windows.Forms.TextBox();
            this.grpMarketAddress = new System.Windows.Forms.GroupBox();
            this.txtMarketPhone = new System.Windows.Forms.TextBox();
            this.lblMarketPhone = new System.Windows.Forms.Label();
            this.txtMarketCountry = new System.Windows.Forms.TextBox();
            this.lblMarketCountry = new System.Windows.Forms.Label();
            this.txtMarketZip = new System.Windows.Forms.TextBox();
            this.lblMarketZip = new System.Windows.Forms.Label();
            this.txtMarketState = new System.Windows.Forms.TextBox();
            this.lblMarketState = new System.Windows.Forms.Label();
            this.txtMarketCity = new System.Windows.Forms.TextBox();
            this.lblMarketCity = new System.Windows.Forms.Label();
            this.txtMarketStreet = new System.Windows.Forms.TextBox();
            this.lblMarketStreet = new System.Windows.Forms.Label();
            this.grpMarketEmailOptions = new System.Windows.Forms.GroupBox();
            this.chkRMACreated = new System.Windows.Forms.CheckBox();
            this.chkTechOnsite = new System.Windows.Forms.CheckBox();
            this.chkTicketIsClosed = new System.Windows.Forms.CheckBox();
            this.chkTicketIsOpen = new System.Windows.Forms.CheckBox();
            this.grpMarketEmails = new System.Windows.Forms.GroupBox();
            this.txtMarketEmails = new System.Windows.Forms.TextBox();
            this.grpMarket = new System.Windows.Forms.GroupBox();
            this.lblMarketId = new System.Windows.Forms.Label();
            this.txtMarketId = new System.Windows.Forms.TextBox();
            this.lblMarketName = new System.Windows.Forms.Label();
            this.txtMarketName = new System.Windows.Forms.TextBox();
            this.lblMarketInformation = new System.Windows.Forms.Label();
            this.pnlCustomerInfo.SuspendLayout();
            this.pnlTechContacts.SuspendLayout();
            this.pnlControl_Top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAdditional.SuspendLayout();
            this.tabAdditionalInfo.SuspendLayout();
            this.tabNotes.SuspendLayout();
            this.tabAssets.SuspendLayout();
            this.tabTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
            this.pnlTickets_Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMarketInfo.SuspendLayout();
            this.grpSalesperson.SuspendLayout();
            this.grpMarketAddress.SuspendLayout();
            this.grpMarketEmailOptions.SuspendLayout();
            this.grpMarketEmails.SuspendLayout();
            this.grpMarket.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomerInfo
            // 
            this.pnlCustomerInfo.BackColor = System.Drawing.Color.LightGray;
            this.pnlCustomerInfo.Controls.Add(this.cmbCustomerStanding);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerTag);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerStanding);
            this.pnlCustomerInfo.Controls.Add(this.cmbCustomerTag);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerSSR);
            this.pnlCustomerInfo.Controls.Add(this.cmbCustomerSSR);
            this.pnlCustomerInfo.Controls.Add(this.btnMarketList);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerId);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerId);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.txtCustomerName);
            this.pnlCustomerInfo.Controls.Add(this.lblCustomerInfo);
            this.pnlCustomerInfo.Location = new System.Drawing.Point(6, 39);
            this.pnlCustomerInfo.Name = "pnlCustomerInfo";
            this.pnlCustomerInfo.Size = new System.Drawing.Size(229, 268);
            this.pnlCustomerInfo.TabIndex = 1;
            // 
            // cmbCustomerStanding
            // 
            this.cmbCustomerStanding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerStanding.Enabled = false;
            this.cmbCustomerStanding.FormattingEnabled = true;
            this.cmbCustomerStanding.Items.AddRange(new object[] {
            "Good",
            "Frozen"});
            this.cmbCustomerStanding.Location = new System.Drawing.Point(9, 203);
            this.cmbCustomerStanding.Name = "cmbCustomerStanding";
            this.cmbCustomerStanding.Size = new System.Drawing.Size(198, 21);
            this.cmbCustomerStanding.TabIndex = 22;
            // 
            // lblCustomerTag
            // 
            this.lblCustomerTag.AutoSize = true;
            this.lblCustomerTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTag.Location = new System.Drawing.Point(6, 144);
            this.lblCustomerTag.Name = "lblCustomerTag";
            this.lblCustomerTag.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerTag.TabIndex = 23;
            this.lblCustomerTag.Text = "Customer Category";
            // 
            // lblCustomerStanding
            // 
            this.lblCustomerStanding.AutoSize = true;
            this.lblCustomerStanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerStanding.Location = new System.Drawing.Point(6, 187);
            this.lblCustomerStanding.Name = "lblCustomerStanding";
            this.lblCustomerStanding.Size = new System.Drawing.Size(49, 13);
            this.lblCustomerStanding.TabIndex = 21;
            this.lblCustomerStanding.Text = "Standing";
            // 
            // cmbCustomerTag
            // 
            this.cmbCustomerTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerTag.Enabled = false;
            this.cmbCustomerTag.FormattingEnabled = true;
            this.cmbCustomerTag.Location = new System.Drawing.Point(9, 160);
            this.cmbCustomerTag.Name = "cmbCustomerTag";
            this.cmbCustomerTag.Size = new System.Drawing.Size(198, 21);
            this.cmbCustomerTag.TabIndex = 22;
            // 
            // lblCustomerSSR
            // 
            this.lblCustomerSSR.AutoSize = true;
            this.lblCustomerSSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerSSR.Location = new System.Drawing.Point(6, 106);
            this.lblCustomerSSR.Name = "lblCustomerSSR";
            this.lblCustomerSSR.Size = new System.Drawing.Size(158, 13);
            this.lblCustomerSSR.TabIndex = 21;
            this.lblCustomerSSR.Text = "Service Support Representative";
            // 
            // cmbCustomerSSR
            // 
            this.cmbCustomerSSR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerSSR.Enabled = false;
            this.cmbCustomerSSR.FormattingEnabled = true;
            this.cmbCustomerSSR.Location = new System.Drawing.Point(9, 122);
            this.cmbCustomerSSR.Name = "cmbCustomerSSR";
            this.cmbCustomerSSR.Size = new System.Drawing.Size(198, 21);
            this.cmbCustomerSSR.TabIndex = 20;
            // 
            // btnMarketList
            // 
            this.btnMarketList.Location = new System.Drawing.Point(9, 233);
            this.btnMarketList.Name = "btnMarketList";
            this.btnMarketList.Size = new System.Drawing.Size(198, 29);
            this.btnMarketList.TabIndex = 17;
            this.btnMarketList.Text = "Market List";
            this.btnMarketList.UseVisualStyleBackColor = true;
            this.btnMarketList.Click += new System.EventHandler(this.btnMarketList_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(27, 46);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(19, 13);
            this.lblCustomerId.TabIndex = 16;
            this.lblCustomerId.Text = "Id:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(55, 46);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(152, 20);
            this.txtCustomerId.TabIndex = 15;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(6, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 14;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(55, 20);
            this.txtCustomerName.MaxLength = 64;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(152, 20);
            this.txtCustomerName.TabIndex = 13;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoEllipsis = true;
            this.lblCustomerInfo.BackColor = System.Drawing.Color.Black;
            this.lblCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.White;
            this.lblCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(229, 17);
            this.lblCustomerInfo.TabIndex = 12;
            this.lblCustomerInfo.Text = "Customer Information";
            this.lblCustomerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCustomerSalesperson
            // 
            this.cmbCustomerSalesperson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerSalesperson.Enabled = false;
            this.cmbCustomerSalesperson.FormattingEnabled = true;
            this.cmbCustomerSalesperson.Location = new System.Drawing.Point(6, 16);
            this.cmbCustomerSalesperson.Name = "cmbCustomerSalesperson";
            this.cmbCustomerSalesperson.Size = new System.Drawing.Size(269, 21);
            this.cmbCustomerSalesperson.TabIndex = 18;
            // 
            // pnlTechContacts
            // 
            this.pnlTechContacts.BackColor = System.Drawing.Color.LightGray;
            this.pnlTechContacts.Controls.Add(this.txtMarketNumber_3);
            this.pnlTechContacts.Controls.Add(this.lblMarketNumber_3);
            this.pnlTechContacts.Controls.Add(this.txtMarketPosition_3);
            this.pnlTechContacts.Controls.Add(this.lblMarketPosition_3);
            this.pnlTechContacts.Controls.Add(this.txtMarketName_3);
            this.pnlTechContacts.Controls.Add(this.lblMarketName_3);
            this.pnlTechContacts.Controls.Add(this.txtMarketNumber_2);
            this.pnlTechContacts.Controls.Add(this.lblMarketNumber_2);
            this.pnlTechContacts.Controls.Add(this.txtMarketPosition_2);
            this.pnlTechContacts.Controls.Add(this.lblMarketPosition_2);
            this.pnlTechContacts.Controls.Add(this.txtMarketName_2);
            this.pnlTechContacts.Controls.Add(this.lblMarketName_2);
            this.pnlTechContacts.Controls.Add(this.txtMarketNumber_1);
            this.pnlTechContacts.Controls.Add(this.lblMarketNumber_1);
            this.pnlTechContacts.Controls.Add(this.txtMarketPosition_1);
            this.pnlTechContacts.Controls.Add(this.lblMarketPosition_1);
            this.pnlTechContacts.Controls.Add(this.txtMarketName_1);
            this.pnlTechContacts.Controls.Add(this.lblMarketName_1);
            this.pnlTechContacts.Controls.Add(this.lblTechContacts);
            this.pnlTechContacts.Location = new System.Drawing.Point(3, 310);
            this.pnlTechContacts.Name = "pnlTechContacts";
            this.pnlTechContacts.Size = new System.Drawing.Size(232, 324);
            this.pnlTechContacts.TabIndex = 2;
            // 
            // txtMarketNumber_3
            // 
            this.txtMarketNumber_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketNumber_3.Location = new System.Drawing.Point(59, 283);
            this.txtMarketNumber_3.MaxLength = 45;
            this.txtMarketNumber_3.Name = "txtMarketNumber_3";
            this.txtMarketNumber_3.ReadOnly = true;
            this.txtMarketNumber_3.Size = new System.Drawing.Size(167, 20);
            this.txtMarketNumber_3.TabIndex = 31;
            // 
            // lblMarketNumber_3
            // 
            this.lblMarketNumber_3.AutoSize = true;
            this.lblMarketNumber_3.Location = new System.Drawing.Point(9, 286);
            this.lblMarketNumber_3.Name = "lblMarketNumber_3";
            this.lblMarketNumber_3.Size = new System.Drawing.Size(44, 13);
            this.lblMarketNumber_3.TabIndex = 30;
            this.lblMarketNumber_3.Text = "Number";
            // 
            // txtMarketPosition_3
            // 
            this.txtMarketPosition_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketPosition_3.Location = new System.Drawing.Point(59, 260);
            this.txtMarketPosition_3.MaxLength = 32;
            this.txtMarketPosition_3.Name = "txtMarketPosition_3";
            this.txtMarketPosition_3.ReadOnly = true;
            this.txtMarketPosition_3.Size = new System.Drawing.Size(167, 20);
            this.txtMarketPosition_3.TabIndex = 29;
            // 
            // lblMarketPosition_3
            // 
            this.lblMarketPosition_3.AutoSize = true;
            this.lblMarketPosition_3.Location = new System.Drawing.Point(9, 263);
            this.lblMarketPosition_3.Name = "lblMarketPosition_3";
            this.lblMarketPosition_3.Size = new System.Drawing.Size(44, 13);
            this.lblMarketPosition_3.TabIndex = 28;
            this.lblMarketPosition_3.Text = "Position";
            // 
            // txtMarketName_3
            // 
            this.txtMarketName_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketName_3.Location = new System.Drawing.Point(59, 238);
            this.txtMarketName_3.MaxLength = 45;
            this.txtMarketName_3.Name = "txtMarketName_3";
            this.txtMarketName_3.ReadOnly = true;
            this.txtMarketName_3.Size = new System.Drawing.Size(167, 20);
            this.txtMarketName_3.TabIndex = 27;
            // 
            // lblMarketName_3
            // 
            this.lblMarketName_3.AutoSize = true;
            this.lblMarketName_3.Location = new System.Drawing.Point(9, 241);
            this.lblMarketName_3.Name = "lblMarketName_3";
            this.lblMarketName_3.Size = new System.Drawing.Size(35, 13);
            this.lblMarketName_3.TabIndex = 26;
            this.lblMarketName_3.Text = "Name";
            // 
            // txtMarketNumber_2
            // 
            this.txtMarketNumber_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketNumber_2.Location = new System.Drawing.Point(59, 179);
            this.txtMarketNumber_2.MaxLength = 45;
            this.txtMarketNumber_2.Name = "txtMarketNumber_2";
            this.txtMarketNumber_2.ReadOnly = true;
            this.txtMarketNumber_2.Size = new System.Drawing.Size(167, 20);
            this.txtMarketNumber_2.TabIndex = 25;
            // 
            // lblMarketNumber_2
            // 
            this.lblMarketNumber_2.AutoSize = true;
            this.lblMarketNumber_2.Location = new System.Drawing.Point(9, 182);
            this.lblMarketNumber_2.Name = "lblMarketNumber_2";
            this.lblMarketNumber_2.Size = new System.Drawing.Size(44, 13);
            this.lblMarketNumber_2.TabIndex = 24;
            this.lblMarketNumber_2.Text = "Number";
            // 
            // txtMarketPosition_2
            // 
            this.txtMarketPosition_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketPosition_2.Location = new System.Drawing.Point(59, 156);
            this.txtMarketPosition_2.MaxLength = 32;
            this.txtMarketPosition_2.Name = "txtMarketPosition_2";
            this.txtMarketPosition_2.ReadOnly = true;
            this.txtMarketPosition_2.Size = new System.Drawing.Size(167, 20);
            this.txtMarketPosition_2.TabIndex = 23;
            // 
            // lblMarketPosition_2
            // 
            this.lblMarketPosition_2.AutoSize = true;
            this.lblMarketPosition_2.Location = new System.Drawing.Point(9, 159);
            this.lblMarketPosition_2.Name = "lblMarketPosition_2";
            this.lblMarketPosition_2.Size = new System.Drawing.Size(44, 13);
            this.lblMarketPosition_2.TabIndex = 22;
            this.lblMarketPosition_2.Text = "Position";
            // 
            // txtMarketName_2
            // 
            this.txtMarketName_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketName_2.Location = new System.Drawing.Point(59, 134);
            this.txtMarketName_2.MaxLength = 45;
            this.txtMarketName_2.Name = "txtMarketName_2";
            this.txtMarketName_2.ReadOnly = true;
            this.txtMarketName_2.Size = new System.Drawing.Size(167, 20);
            this.txtMarketName_2.TabIndex = 21;
            // 
            // lblMarketName_2
            // 
            this.lblMarketName_2.AutoSize = true;
            this.lblMarketName_2.Location = new System.Drawing.Point(9, 137);
            this.lblMarketName_2.Name = "lblMarketName_2";
            this.lblMarketName_2.Size = new System.Drawing.Size(35, 13);
            this.lblMarketName_2.TabIndex = 20;
            this.lblMarketName_2.Text = "Name";
            // 
            // txtMarketNumber_1
            // 
            this.txtMarketNumber_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketNumber_1.Location = new System.Drawing.Point(59, 80);
            this.txtMarketNumber_1.MaxLength = 45;
            this.txtMarketNumber_1.Name = "txtMarketNumber_1";
            this.txtMarketNumber_1.ReadOnly = true;
            this.txtMarketNumber_1.Size = new System.Drawing.Size(167, 20);
            this.txtMarketNumber_1.TabIndex = 19;
            // 
            // lblMarketNumber_1
            // 
            this.lblMarketNumber_1.AutoSize = true;
            this.lblMarketNumber_1.Location = new System.Drawing.Point(9, 83);
            this.lblMarketNumber_1.Name = "lblMarketNumber_1";
            this.lblMarketNumber_1.Size = new System.Drawing.Size(44, 13);
            this.lblMarketNumber_1.TabIndex = 18;
            this.lblMarketNumber_1.Text = "Number";
            // 
            // txtMarketPosition_1
            // 
            this.txtMarketPosition_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketPosition_1.Location = new System.Drawing.Point(59, 57);
            this.txtMarketPosition_1.MaxLength = 32;
            this.txtMarketPosition_1.Name = "txtMarketPosition_1";
            this.txtMarketPosition_1.ReadOnly = true;
            this.txtMarketPosition_1.Size = new System.Drawing.Size(167, 20);
            this.txtMarketPosition_1.TabIndex = 17;
            // 
            // lblMarketPosition_1
            // 
            this.lblMarketPosition_1.AutoSize = true;
            this.lblMarketPosition_1.Location = new System.Drawing.Point(9, 60);
            this.lblMarketPosition_1.Name = "lblMarketPosition_1";
            this.lblMarketPosition_1.Size = new System.Drawing.Size(44, 13);
            this.lblMarketPosition_1.TabIndex = 16;
            this.lblMarketPosition_1.Text = "Position";
            // 
            // txtMarketName_1
            // 
            this.txtMarketName_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketName_1.Location = new System.Drawing.Point(59, 35);
            this.txtMarketName_1.MaxLength = 45;
            this.txtMarketName_1.Name = "txtMarketName_1";
            this.txtMarketName_1.ReadOnly = true;
            this.txtMarketName_1.Size = new System.Drawing.Size(167, 20);
            this.txtMarketName_1.TabIndex = 15;
            // 
            // lblMarketName_1
            // 
            this.lblMarketName_1.AutoSize = true;
            this.lblMarketName_1.Location = new System.Drawing.Point(9, 38);
            this.lblMarketName_1.Name = "lblMarketName_1";
            this.lblMarketName_1.Size = new System.Drawing.Size(35, 13);
            this.lblMarketName_1.TabIndex = 14;
            this.lblMarketName_1.Text = "Name";
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
            this.lblTechContacts.Text = "Contacts";
            this.lblTechContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControl_Top
            // 
            this.pnlControl_Top.BackColor = System.Drawing.Color.Silver;
            this.pnlControl_Top.Controls.Add(this.btnSave);
            this.pnlControl_Top.Controls.Add(this.btnCancel);
            this.pnlControl_Top.Controls.Add(this.menuStrip1);
            this.pnlControl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlControl_Top.Name = "pnlControl_Top";
            this.pnlControl_Top.Size = new System.Drawing.Size(839, 36);
            this.pnlControl_Top.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(736, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 26);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(633, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCustomerOptions,
            this.tsmiMarketOptions});
            this.menuStrip1.Location = new System.Drawing.Point(6, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(225, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCustomerOptions
            // 
            this.tsmiCustomerOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiCustomerOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddCustomer,
            this.tsmiEditCustomer,
            this.tsmiAddCustomerTag});
            this.tsmiCustomerOptions.Name = "tsmiCustomerOptions";
            this.tsmiCustomerOptions.Size = new System.Drawing.Size(116, 20);
            this.tsmiCustomerOptions.Text = "Customer Options";
            this.tsmiCustomerOptions.Click += new System.EventHandler(this.customerOptionsToolStripMenuItem_Click);
            // 
            // tsmiAddCustomer
            // 
            this.tsmiAddCustomer.Name = "tsmiAddCustomer";
            this.tsmiAddCustomer.Size = new System.Drawing.Size(174, 22);
            this.tsmiAddCustomer.Text = "Add Customer";
            this.tsmiAddCustomer.Click += new System.EventHandler(this.tsmiAddCustomer_Click);
            // 
            // tsmiEditCustomer
            // 
            this.tsmiEditCustomer.Name = "tsmiEditCustomer";
            this.tsmiEditCustomer.Size = new System.Drawing.Size(174, 22);
            this.tsmiEditCustomer.Text = "Edit Customer";
            this.tsmiEditCustomer.Click += new System.EventHandler(this.tsmiEditCustomer_Click);
            // 
            // tsmiAddCustomerTag
            // 
            this.tsmiAddCustomerTag.Name = "tsmiAddCustomerTag";
            this.tsmiAddCustomerTag.Size = new System.Drawing.Size(202, 22);
            this.tsmiAddCustomerTag.Text = "Add Customer Category";
            this.tsmiAddCustomerTag.Click += new System.EventHandler(this.tsmiAddCustomerTag_Click);
            // 
            // tsmiMarketOptions
            // 
            this.tsmiMarketOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddMarket,
            this.tsmiEditMarket,
            this.tsmiChangeCustomer,
            this.tsmiAdd});
            this.tsmiMarketOptions.Name = "tsmiMarketOptions";
            this.tsmiMarketOptions.Size = new System.Drawing.Size(101, 20);
            this.tsmiMarketOptions.Text = "Market Options";
            this.tsmiMarketOptions.Click += new System.EventHandler(this.tsmiMarketOptions_Click);
            // 
            // tsmiAddMarket
            // 
            this.tsmiAddMarket.Name = "tsmiAddMarket";
            this.tsmiAddMarket.Size = new System.Drawing.Size(194, 22);
            this.tsmiAddMarket.Text = "Add Market";
            this.tsmiAddMarket.Click += new System.EventHandler(this.tsmiAddMarket_Click);
            // 
            // tsmiEditMarket
            // 
            this.tsmiEditMarket.Name = "tsmiEditMarket";
            this.tsmiEditMarket.Size = new System.Drawing.Size(194, 22);
            this.tsmiEditMarket.Text = "Edit Market";
            this.tsmiEditMarket.Click += new System.EventHandler(this.tsmiEditMarket_Click);
            // 
            // tsmiChangeCustomer
            // 
            this.tsmiChangeCustomer.Name = "tsmiChangeCustomer";
            this.tsmiChangeCustomer.Size = new System.Drawing.Size(194, 22);
            this.tsmiChangeCustomer.Text = "Reassign Market";
            this.tsmiChangeCustomer.Click += new System.EventHandler(this.tsmiChangeCustomer_Click);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(194, 22);
            this.tsmiAdd.Text = "Edit Automated Emails";
            this.tsmiAdd.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.AutoSize = true;
            this.chkSubscribe.Location = new System.Drawing.Point(34, 69);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(73, 17);
            this.chkSubscribe.TabIndex = 6;
            this.chkSubscribe.Text = "Subscribe";
            this.chkSubscribe.UseVisualStyleBackColor = true;
            this.chkSubscribe.Click += new System.EventHandler(this.chkSubscribe_CheckedChanged);
            // 
            // pnlControl_Bottom
            // 
            this.pnlControl_Bottom.BackColor = System.Drawing.Color.Silver;
            this.pnlControl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl_Bottom.Location = new System.Drawing.Point(0, 637);
            this.pnlControl_Bottom.Name = "pnlControl_Bottom";
            this.pnlControl_Bottom.Size = new System.Drawing.Size(839, 30);
            this.pnlControl_Bottom.TabIndex = 4;
            // 
            // pnlAdditional
            // 
            this.pnlAdditional.Controls.Add(this.tabAdditionalInfo);
            this.pnlAdditional.Location = new System.Drawing.Point(241, 310);
            this.pnlAdditional.Name = "pnlAdditional";
            this.pnlAdditional.Size = new System.Drawing.Size(595, 315);
            this.pnlAdditional.TabIndex = 3;
            // 
            // tabAdditionalInfo
            // 
            this.tabAdditionalInfo.Controls.Add(this.tabNotes);
            this.tabAdditionalInfo.Controls.Add(this.tabAssets);
            this.tabAdditionalInfo.Controls.Add(this.tabTickets);
            this.tabAdditionalInfo.Controls.Add(this.tabPage1);
            this.tabAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            this.tabAdditionalInfo.Name = "tabAdditionalInfo";
            this.tabAdditionalInfo.SelectedIndex = 0;
            this.tabAdditionalInfo.Size = new System.Drawing.Size(595, 321);
            this.tabAdditionalInfo.TabIndex = 2;
            this.tabAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this.tabAdditionalInfo_SelectedIndexChanged);
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.txtMarketNotes);
            this.tabNotes.Location = new System.Drawing.Point(4, 22);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotes.Size = new System.Drawing.Size(587, 295);
            this.tabNotes.TabIndex = 0;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // txtMarketNotes
            // 
            this.txtMarketNotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMarketNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarketNotes.Location = new System.Drawing.Point(3, 3);
            this.txtMarketNotes.MaxLength = 65530;
            this.txtMarketNotes.Multiline = true;
            this.txtMarketNotes.Name = "txtMarketNotes";
            this.txtMarketNotes.ReadOnly = true;
            this.txtMarketNotes.Size = new System.Drawing.Size(581, 289);
            this.txtMarketNotes.TabIndex = 3;
            // 
            // tabAssets
            // 
            this.tabAssets.Controls.Add(this.ucAssetList1);
            this.tabAssets.Location = new System.Drawing.Point(4, 22);
            this.tabAssets.Name = "tabAssets";
            this.tabAssets.Padding = new System.Windows.Forms.Padding(3);
            this.tabAssets.Size = new System.Drawing.Size(587, 295);
            this.tabAssets.TabIndex = 1;
            this.tabAssets.Text = "Assets";
            this.tabAssets.UseVisualStyleBackColor = true;
            // 
            // ucAssetList1
            // 
            this.ucAssetList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssetList1.EmptyListMessage = "No Assets";
            this.ucAssetList1.Location = new System.Drawing.Point(3, 3);
            this.ucAssetList1.Name = "ucAssetList1";
            this.ucAssetList1.Size = new System.Drawing.Size(581, 289);
            this.ucAssetList1.TabIndex = 1;
            this.ucAssetList1.ViewAsset += new SDB.UserControls.ucAssetList.AssetEvent(this.ucAssetList1_ViewAsset);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.olvTickets);
            this.tabTickets.Controls.Add(this.pnlTickets_Control);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(587, 295);
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
            this.olvTickets.Size = new System.Drawing.Size(581, 259);
            this.olvTickets.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvTickets.TabIndex = 4;
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
            this.olvColTickets_Date.AspectName = "OpenDT";
            this.olvColTickets_Date.AspectToStringFormat = "{0:yyyy-MM-dd}";
            this.olvColTickets_Date.IsEditable = false;
            this.olvColTickets_Date.Text = "Date";
            this.olvColTickets_Date.Width = 70;
            // 
            // olvColTickets_Asset
            // 
            this.olvColTickets_Asset.AspectName = "AssetName";
            this.olvColTickets_Asset.IsEditable = false;
            this.olvColTickets_Asset.Text = "Asset";
            this.olvColTickets_Asset.Width = 70;
            // 
            // olvColTickets_AssetLocation
            // 
            this.olvColTickets_AssetLocation.AspectName = "AssetLocation";
            this.olvColTickets_AssetLocation.Text = "Location";
            this.olvColTickets_AssetLocation.Width = 140;
            // 
            // olvColTickets_Symptoms
            // 
            this.olvColTickets_Symptoms.AspectName = "Symptoms";
            this.olvColTickets_Symptoms.IsEditable = false;
            this.olvColTickets_Symptoms.Text = "Symptom(s)";
            this.olvColTickets_Symptoms.Width = 150;
            // 
            // olvColTickets_Solutions
            // 
            this.olvColTickets_Solutions.AspectName = "Solutions";
            this.olvColTickets_Solutions.Text = "Solution(s)";
            this.olvColTickets_Solutions.Width = 150;
            // 
            // pnlTickets_Control
            // 
            this.pnlTickets_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTickets_Control.Controls.Add(this.radClosedTickets);
            this.pnlTickets_Control.Controls.Add(this.radOpenTickets);
            this.pnlTickets_Control.Controls.Add(this.lblTicketQty);
            this.pnlTickets_Control.Controls.Add(this.txtTicketQty);
            this.pnlTickets_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTickets_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlTickets_Control.Name = "pnlTickets_Control";
            this.pnlTickets_Control.Size = new System.Drawing.Size(581, 30);
            this.pnlTickets_Control.TabIndex = 3;
            // 
            // radClosedTickets
            // 
            this.radClosedTickets.AutoSize = true;
            this.radClosedTickets.Location = new System.Drawing.Point(98, 5);
            this.radClosedTickets.Name = "radClosedTickets";
            this.radClosedTickets.Size = new System.Drawing.Size(157, 17);
            this.radClosedTickets.TabIndex = 8;
            this.radClosedTickets.TabStop = true;
            this.radClosedTickets.Text = "Ticket Closed Within 1 Year";
            this.radClosedTickets.UseVisualStyleBackColor = true;
            this.radClosedTickets.Click += new System.EventHandler(this.radClosedTickets_Click);
            // 
            // radOpenTickets
            // 
            this.radOpenTickets.AutoSize = true;
            this.radOpenTickets.Checked = true;
            this.radOpenTickets.Location = new System.Drawing.Point(3, 5);
            this.radOpenTickets.Name = "radOpenTickets";
            this.radOpenTickets.Size = new System.Drawing.Size(89, 17);
            this.radOpenTickets.TabIndex = 7;
            this.radOpenTickets.TabStop = true;
            this.radOpenTickets.Text = "Open Tickets";
            this.radOpenTickets.UseVisualStyleBackColor = true;
            this.radOpenTickets.Click += new System.EventHandler(this.radOpenTickets_Click);
            // 
            // lblTicketQty
            // 
            this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketQty.AutoSize = true;
            this.lblTicketQty.Location = new System.Drawing.Point(482, 7);
            this.lblTicketQty.Name = "lblTicketQty";
            this.lblTicketQty.Size = new System.Drawing.Size(45, 13);
            this.lblTicketQty.TabIndex = 5;
            this.lblTicketQty.Text = "Tickets:";
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketQty.Location = new System.Drawing.Point(533, 2);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.ReadOnly = true;
            this.txtTicketQty.Size = new System.Drawing.Size(45, 22);
            this.txtTicketQty.TabIndex = 6;
            this.txtTicketQty.TabStop = false;
            this.txtTicketQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.lblProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(587, 295);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Contract Info";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(217, 124);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(123, 26);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "In Progress";
            // 
            // pnlMarketInfo
            // 
            this.pnlMarketInfo.BackColor = System.Drawing.Color.LightGray;
            this.pnlMarketInfo.Controls.Add(this.grpSalesperson);
            this.pnlMarketInfo.Controls.Add(this.grpMarketAddress);
            this.pnlMarketInfo.Controls.Add(this.grpMarketEmailOptions);
            this.pnlMarketInfo.Controls.Add(this.grpMarketEmails);
            this.pnlMarketInfo.Controls.Add(this.grpMarket);
            this.pnlMarketInfo.Controls.Add(this.lblMarketInformation);
            this.pnlMarketInfo.Location = new System.Drawing.Point(241, 39);
            this.pnlMarketInfo.Name = "pnlMarketInfo";
            this.pnlMarketInfo.Size = new System.Drawing.Size(592, 268);
            this.pnlMarketInfo.TabIndex = 13;
            // 
            // grpSalesperson
            // 
            this.grpSalesperson.Controls.Add(this.lblSalespersonPhone);
            this.grpSalesperson.Controls.Add(this.txtSalespersonPhone);
            this.grpSalesperson.Controls.Add(this.lblSalespersonEmail);
            this.grpSalesperson.Controls.Add(this.txtSalespersonEmail);
            this.grpSalesperson.Controls.Add(this.cmbCustomerSalesperson);
            this.grpSalesperson.Location = new System.Drawing.Point(306, 176);
            this.grpSalesperson.Name = "grpSalesperson";
            this.grpSalesperson.Size = new System.Drawing.Size(283, 86);
            this.grpSalesperson.TabIndex = 17;
            this.grpSalesperson.TabStop = false;
            this.grpSalesperson.Text = "Sales Person";
            // 
            // lblSalespersonPhone
            // 
            this.lblSalespersonPhone.AutoSize = true;
            this.lblSalespersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalespersonPhone.Location = new System.Drawing.Point(6, 65);
            this.lblSalespersonPhone.Name = "lblSalespersonPhone";
            this.lblSalespersonPhone.Size = new System.Drawing.Size(38, 13);
            this.lblSalespersonPhone.TabIndex = 24;
            this.lblSalespersonPhone.Text = "Phone";
            // 
            // txtSalespersonPhone
            // 
            this.txtSalespersonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalespersonPhone.Location = new System.Drawing.Point(55, 62);
            this.txtSalespersonPhone.Name = "txtSalespersonPhone";
            this.txtSalespersonPhone.ReadOnly = true;
            this.txtSalespersonPhone.Size = new System.Drawing.Size(220, 20);
            this.txtSalespersonPhone.TabIndex = 23;
            // 
            // lblSalespersonEmail
            // 
            this.lblSalespersonEmail.AutoSize = true;
            this.lblSalespersonEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalespersonEmail.Location = new System.Drawing.Point(6, 43);
            this.lblSalespersonEmail.Name = "lblSalespersonEmail";
            this.lblSalespersonEmail.Size = new System.Drawing.Size(32, 13);
            this.lblSalespersonEmail.TabIndex = 22;
            this.lblSalespersonEmail.Text = "Email";
            // 
            // txtSalespersonEmail
            // 
            this.txtSalespersonEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalespersonEmail.Location = new System.Drawing.Point(55, 40);
            this.txtSalespersonEmail.Name = "txtSalespersonEmail";
            this.txtSalespersonEmail.ReadOnly = true;
            this.txtSalespersonEmail.Size = new System.Drawing.Size(220, 20);
            this.txtSalespersonEmail.TabIndex = 21;
            // 
            // grpMarketAddress
            // 
            this.grpMarketAddress.BackColor = System.Drawing.Color.LightGray;
            this.grpMarketAddress.Controls.Add(this.txtMarketPhone);
            this.grpMarketAddress.Controls.Add(this.lblMarketPhone);
            this.grpMarketAddress.Controls.Add(this.txtMarketCountry);
            this.grpMarketAddress.Controls.Add(this.lblMarketCountry);
            this.grpMarketAddress.Controls.Add(this.txtMarketZip);
            this.grpMarketAddress.Controls.Add(this.lblMarketZip);
            this.grpMarketAddress.Controls.Add(this.txtMarketState);
            this.grpMarketAddress.Controls.Add(this.lblMarketState);
            this.grpMarketAddress.Controls.Add(this.txtMarketCity);
            this.grpMarketAddress.Controls.Add(this.lblMarketCity);
            this.grpMarketAddress.Controls.Add(this.txtMarketStreet);
            this.grpMarketAddress.Controls.Add(this.lblMarketStreet);
            this.grpMarketAddress.Location = new System.Drawing.Point(306, 23);
            this.grpMarketAddress.Name = "grpMarketAddress";
            this.grpMarketAddress.Size = new System.Drawing.Size(283, 153);
            this.grpMarketAddress.TabIndex = 16;
            this.grpMarketAddress.TabStop = false;
            this.grpMarketAddress.Text = "Address";
            // 
            // txtMarketPhone
            // 
            this.txtMarketPhone.Location = new System.Drawing.Point(46, 127);
            this.txtMarketPhone.MaxLength = 32;
            this.txtMarketPhone.Multiline = true;
            this.txtMarketPhone.Name = "txtMarketPhone";
            this.txtMarketPhone.ReadOnly = true;
            this.txtMarketPhone.Size = new System.Drawing.Size(231, 20);
            this.txtMarketPhone.TabIndex = 11;
            // 
            // lblMarketPhone
            // 
            this.lblMarketPhone.AutoSize = true;
            this.lblMarketPhone.Location = new System.Drawing.Point(5, 127);
            this.lblMarketPhone.Name = "lblMarketPhone";
            this.lblMarketPhone.Size = new System.Drawing.Size(38, 13);
            this.lblMarketPhone.TabIndex = 10;
            this.lblMarketPhone.Text = "Phone";
            // 
            // txtMarketCountry
            // 
            this.txtMarketCountry.Location = new System.Drawing.Point(195, 102);
            this.txtMarketCountry.MaxLength = 40;
            this.txtMarketCountry.Multiline = true;
            this.txtMarketCountry.Name = "txtMarketCountry";
            this.txtMarketCountry.ReadOnly = true;
            this.txtMarketCountry.Size = new System.Drawing.Size(82, 20);
            this.txtMarketCountry.TabIndex = 9;
            // 
            // lblMarketCountry
            // 
            this.lblMarketCountry.AutoSize = true;
            this.lblMarketCountry.Location = new System.Drawing.Point(146, 105);
            this.lblMarketCountry.Name = "lblMarketCountry";
            this.lblMarketCountry.Size = new System.Drawing.Size(43, 13);
            this.lblMarketCountry.TabIndex = 8;
            this.lblMarketCountry.Text = "Country";
            // 
            // txtMarketZip
            // 
            this.txtMarketZip.Location = new System.Drawing.Point(46, 102);
            this.txtMarketZip.MaxLength = 10;
            this.txtMarketZip.Multiline = true;
            this.txtMarketZip.Name = "txtMarketZip";
            this.txtMarketZip.ReadOnly = true;
            this.txtMarketZip.Size = new System.Drawing.Size(94, 20);
            this.txtMarketZip.TabIndex = 7;
            // 
            // lblMarketZip
            // 
            this.lblMarketZip.AutoSize = true;
            this.lblMarketZip.Location = new System.Drawing.Point(7, 105);
            this.lblMarketZip.Name = "lblMarketZip";
            this.lblMarketZip.Size = new System.Drawing.Size(22, 13);
            this.lblMarketZip.TabIndex = 6;
            this.lblMarketZip.Text = "Zip";
            // 
            // txtMarketState
            // 
            this.txtMarketState.Location = new System.Drawing.Point(195, 80);
            this.txtMarketState.MaxLength = 3;
            this.txtMarketState.Multiline = true;
            this.txtMarketState.Name = "txtMarketState";
            this.txtMarketState.ReadOnly = true;
            this.txtMarketState.Size = new System.Drawing.Size(82, 20);
            this.txtMarketState.TabIndex = 5;
            // 
            // lblMarketState
            // 
            this.lblMarketState.AutoSize = true;
            this.lblMarketState.Location = new System.Drawing.Point(146, 83);
            this.lblMarketState.Name = "lblMarketState";
            this.lblMarketState.Size = new System.Drawing.Size(32, 13);
            this.lblMarketState.TabIndex = 4;
            this.lblMarketState.Text = "State";
            // 
            // txtMarketCity
            // 
            this.txtMarketCity.Location = new System.Drawing.Point(46, 80);
            this.txtMarketCity.MaxLength = 40;
            this.txtMarketCity.Multiline = true;
            this.txtMarketCity.Name = "txtMarketCity";
            this.txtMarketCity.ReadOnly = true;
            this.txtMarketCity.Size = new System.Drawing.Size(94, 20);
            this.txtMarketCity.TabIndex = 3;
            // 
            // lblMarketCity
            // 
            this.lblMarketCity.AutoSize = true;
            this.lblMarketCity.Location = new System.Drawing.Point(7, 83);
            this.lblMarketCity.Name = "lblMarketCity";
            this.lblMarketCity.Size = new System.Drawing.Size(24, 13);
            this.lblMarketCity.TabIndex = 2;
            this.lblMarketCity.Text = "City";
            // 
            // txtMarketStreet
            // 
            this.txtMarketStreet.Location = new System.Drawing.Point(46, 17);
            this.txtMarketStreet.MaxLength = 192;
            this.txtMarketStreet.Multiline = true;
            this.txtMarketStreet.Name = "txtMarketStreet";
            this.txtMarketStreet.ReadOnly = true;
            this.txtMarketStreet.Size = new System.Drawing.Size(231, 61);
            this.txtMarketStreet.TabIndex = 1;
            // 
            // lblMarketStreet
            // 
            this.lblMarketStreet.AutoSize = true;
            this.lblMarketStreet.Location = new System.Drawing.Point(7, 20);
            this.lblMarketStreet.Name = "lblMarketStreet";
            this.lblMarketStreet.Size = new System.Drawing.Size(35, 13);
            this.lblMarketStreet.TabIndex = 0;
            this.lblMarketStreet.Text = "Street";
            // 
            // grpMarketEmailOptions
            // 
            this.grpMarketEmailOptions.Controls.Add(this.chkRMACreated);
            this.grpMarketEmailOptions.Controls.Add(this.chkTechOnsite);
            this.grpMarketEmailOptions.Controls.Add(this.chkTicketIsClosed);
            this.grpMarketEmailOptions.Controls.Add(this.chkTicketIsOpen);
            this.grpMarketEmailOptions.Location = new System.Drawing.Point(7, 116);
            this.grpMarketEmailOptions.Name = "grpMarketEmailOptions";
            this.grpMarketEmailOptions.Size = new System.Drawing.Size(293, 73);
            this.grpMarketEmailOptions.TabIndex = 15;
            this.grpMarketEmailOptions.TabStop = false;
            this.grpMarketEmailOptions.Text = "When to send emails";
            // 
            // chkRMACreated
            // 
            this.chkRMACreated.AutoSize = true;
            this.chkRMACreated.Checked = true;
            this.chkRMACreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRMACreated.Enabled = false;
            this.chkRMACreated.Location = new System.Drawing.Point(123, 43);
            this.chkRMACreated.Name = "chkRMACreated";
            this.chkRMACreated.Size = new System.Drawing.Size(99, 17);
            this.chkRMACreated.TabIndex = 3;
            this.chkRMACreated.Text = "RMA is created";
            this.chkRMACreated.UseVisualStyleBackColor = true;
            // 
            // chkTechOnsite
            // 
            this.chkTechOnsite.AutoSize = true;
            this.chkTechOnsite.Checked = true;
            this.chkTechOnsite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTechOnsite.Enabled = false;
            this.chkTechOnsite.Location = new System.Drawing.Point(123, 20);
            this.chkTechOnsite.Name = "chkTechOnsite";
            this.chkTechOnsite.Size = new System.Drawing.Size(120, 17);
            this.chkTechOnsite.TabIndex = 2;
            this.chkTechOnsite.Text = "Tech arrived on site";
            this.chkTechOnsite.UseVisualStyleBackColor = true;
            // 
            // chkTicketIsClosed
            // 
            this.chkTicketIsClosed.AutoSize = true;
            this.chkTicketIsClosed.Checked = true;
            this.chkTicketIsClosed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTicketIsClosed.Enabled = false;
            this.chkTicketIsClosed.Location = new System.Drawing.Point(10, 43);
            this.chkTicketIsClosed.Name = "chkTicketIsClosed";
            this.chkTicketIsClosed.Size = new System.Drawing.Size(100, 17);
            this.chkTicketIsClosed.TabIndex = 1;
            this.chkTicketIsClosed.Text = "Ticket is closed";
            this.chkTicketIsClosed.UseVisualStyleBackColor = true;
            // 
            // chkTicketIsOpen
            // 
            this.chkTicketIsOpen.AutoSize = true;
            this.chkTicketIsOpen.Checked = true;
            this.chkTicketIsOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTicketIsOpen.Enabled = false;
            this.chkTicketIsOpen.Location = new System.Drawing.Point(11, 20);
            this.chkTicketIsOpen.Name = "chkTicketIsOpen";
            this.chkTicketIsOpen.Size = new System.Drawing.Size(105, 17);
            this.chkTicketIsOpen.TabIndex = 0;
            this.chkTicketIsOpen.Text = "Ticket is opened";
            this.chkTicketIsOpen.UseVisualStyleBackColor = true;
            // 
            // grpMarketEmails
            // 
            this.grpMarketEmails.Controls.Add(this.txtMarketEmails);
            this.grpMarketEmails.Location = new System.Drawing.Point(4, 190);
            this.grpMarketEmails.Name = "grpMarketEmails";
            this.grpMarketEmails.Size = new System.Drawing.Size(296, 75);
            this.grpMarketEmails.TabIndex = 14;
            this.grpMarketEmails.TabStop = false;
            this.grpMarketEmails.Text = "Market Emails";
            // 
            // txtMarketEmails
            // 
            this.txtMarketEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarketEmails.Location = new System.Drawing.Point(3, 16);
            this.txtMarketEmails.MaxLength = 1024;
            this.txtMarketEmails.Multiline = true;
            this.txtMarketEmails.Name = "txtMarketEmails";
            this.txtMarketEmails.ReadOnly = true;
            this.txtMarketEmails.Size = new System.Drawing.Size(290, 56);
            this.txtMarketEmails.TabIndex = 2;
            this.txtMarketEmails.DoubleClick += new System.EventHandler(this.Market_Email_DoubleClick);
            // 
            // grpMarket
            // 
            this.grpMarket.Controls.Add(this.lblMarketId);
            this.grpMarket.Controls.Add(this.chkSubscribe);
            this.grpMarket.Controls.Add(this.txtMarketId);
            this.grpMarket.Controls.Add(this.lblMarketName);
            this.grpMarket.Controls.Add(this.txtMarketName);
            this.grpMarket.Location = new System.Drawing.Point(4, 20);
            this.grpMarket.Name = "grpMarket";
            this.grpMarket.Size = new System.Drawing.Size(296, 90);
            this.grpMarket.TabIndex = 13;
            this.grpMarket.TabStop = false;
            this.grpMarket.Text = "Market";
            // 
            // lblMarketId
            // 
            this.lblMarketId.AutoSize = true;
            this.lblMarketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketId.Location = new System.Drawing.Point(31, 43);
            this.lblMarketId.Name = "lblMarketId";
            this.lblMarketId.Size = new System.Drawing.Size(19, 13);
            this.lblMarketId.TabIndex = 20;
            this.lblMarketId.Text = "Id:";
            // 
            // txtMarketId
            // 
            this.txtMarketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketId.Location = new System.Drawing.Point(59, 43);
            this.txtMarketId.MaxLength = 16;
            this.txtMarketId.Name = "txtMarketId";
            this.txtMarketId.ReadOnly = true;
            this.txtMarketId.Size = new System.Drawing.Size(216, 20);
            this.txtMarketId.TabIndex = 19;
            // 
            // lblMarketName
            // 
            this.lblMarketName.AutoSize = true;
            this.lblMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketName.Location = new System.Drawing.Point(10, 20);
            this.lblMarketName.Name = "lblMarketName";
            this.lblMarketName.Size = new System.Drawing.Size(38, 13);
            this.lblMarketName.TabIndex = 18;
            this.lblMarketName.Text = "Name:";
            // 
            // txtMarketName
            // 
            this.txtMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketName.Location = new System.Drawing.Point(59, 17);
            this.txtMarketName.MaxLength = 45;
            this.txtMarketName.Name = "txtMarketName";
            this.txtMarketName.ReadOnly = true;
            this.txtMarketName.Size = new System.Drawing.Size(216, 20);
            this.txtMarketName.TabIndex = 17;
            // 
            // lblMarketInformation
            // 
            this.lblMarketInformation.AutoEllipsis = true;
            this.lblMarketInformation.BackColor = System.Drawing.Color.Black;
            this.lblMarketInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMarketInformation.ForeColor = System.Drawing.Color.White;
            this.lblMarketInformation.Location = new System.Drawing.Point(0, 0);
            this.lblMarketInformation.Name = "lblMarketInformation";
            this.lblMarketInformation.Size = new System.Drawing.Size(592, 17);
            this.lblMarketInformation.TabIndex = 12;
            this.lblMarketInformation.Text = "Market Information";
            this.lblMarketInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomerEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlMarketInfo);
            this.Controls.Add(this.pnlControl_Bottom);
            this.Controls.Add(this.pnlControl_Top);
            this.Controls.Add(this.pnlAdditional);
            this.Controls.Add(this.pnlTechContacts);
            this.Controls.Add(this.pnlCustomerInfo);
            this.Name = "CustomerEditor";
            this.Size = new System.Drawing.Size(839, 667);
            this.pnlCustomerInfo.ResumeLayout(false);
            this.pnlCustomerInfo.PerformLayout();
            this.pnlTechContacts.ResumeLayout(false);
            this.pnlTechContacts.PerformLayout();
            this.pnlControl_Top.ResumeLayout(false);
            this.pnlControl_Top.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdditional.ResumeLayout(false);
            this.tabAdditionalInfo.ResumeLayout(false);
            this.tabNotes.ResumeLayout(false);
            this.tabNotes.PerformLayout();
            this.tabAssets.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
            this.pnlTickets_Control.ResumeLayout(false);
            this.pnlTickets_Control.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlMarketInfo.ResumeLayout(false);
            this.grpSalesperson.ResumeLayout(false);
            this.grpSalesperson.PerformLayout();
            this.grpMarketAddress.ResumeLayout(false);
            this.grpMarketAddress.PerformLayout();
            this.grpMarketEmailOptions.ResumeLayout(false);
            this.grpMarketEmailOptions.PerformLayout();
            this.grpMarketEmails.ResumeLayout(false);
            this.grpMarketEmails.PerformLayout();
            this.grpMarket.ResumeLayout(false);
            this.grpMarket.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlCustomerInfo;
		private System.Windows.Forms.Panel pnlTechContacts;
		private System.Windows.Forms.Panel pnlControl_Top;
		private System.Windows.Forms.Panel pnlControl_Bottom;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblCustomerInfo;
		private System.Windows.Forms.Label lblTechContacts;
        private System.Windows.Forms.Panel pnlAdditional;
        private System.Windows.Forms.TabControl tabAdditionalInfo;
        private System.Windows.Forms.Panel pnlMarketInfo;
        private System.Windows.Forms.Label lblMarketInformation;
        private System.Windows.Forms.TabPage tabNotes;
        private System.Windows.Forms.TabPage tabAssets;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerTag;
        private System.Windows.Forms.ComboBox cmbCustomerTag;
        private System.Windows.Forms.Label lblCustomerSSR;
        private System.Windows.Forms.ComboBox cmbCustomerSSR;
        private System.Windows.Forms.ComboBox cmbCustomerSalesperson;
        private System.Windows.Forms.Button btnMarketList;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtMarketNotes;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.GroupBox grpMarketAddress;
        private System.Windows.Forms.TextBox txtMarketCountry;
        private System.Windows.Forms.Label lblMarketCountry;
        private System.Windows.Forms.TextBox txtMarketZip;
        private System.Windows.Forms.Label lblMarketZip;
        private System.Windows.Forms.TextBox txtMarketState;
        private System.Windows.Forms.Label lblMarketState;
        private System.Windows.Forms.TextBox txtMarketCity;
        private System.Windows.Forms.Label lblMarketCity;
        private System.Windows.Forms.TextBox txtMarketStreet;
        private System.Windows.Forms.Label lblMarketStreet;
        private System.Windows.Forms.GroupBox grpMarketEmailOptions;
        private System.Windows.Forms.CheckBox chkRMACreated;
        private System.Windows.Forms.CheckBox chkTechOnsite;
        private System.Windows.Forms.CheckBox chkTicketIsClosed;
        private System.Windows.Forms.CheckBox chkTicketIsOpen;
        private System.Windows.Forms.GroupBox grpMarketEmails;
        private System.Windows.Forms.TextBox txtMarketEmails;
        private System.Windows.Forms.GroupBox grpMarket;
        private System.Windows.Forms.Label lblCustomerStanding;
        private System.Windows.Forms.Label lblMarketId;
        private System.Windows.Forms.TextBox txtMarketId;
        private System.Windows.Forms.Label lblMarketName;
        private System.Windows.Forms.TextBox txtMarketName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomerOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditCustomer;
        private System.Windows.Forms.TextBox txtMarketPhone;
        private System.Windows.Forms.Label lblMarketPhone;
        private System.Windows.Forms.ComboBox cmbCustomerStanding;
        private ucAssetList ucAssetList1;
        private System.Windows.Forms.TextBox txtMarketPosition_1;
        private System.Windows.Forms.Label lblMarketPosition_1;
        private System.Windows.Forms.TextBox txtMarketName_1;
        private System.Windows.Forms.Label lblMarketName_1;
        private BrightIdeasSoftware.ObjectListView olvTickets;
        private BrightIdeasSoftware.OLVColumn olvColTickets_ID;
        private BrightIdeasSoftware.OLVColumn olvColTickets_Date;
        private BrightIdeasSoftware.OLVColumn olvColTickets_Asset;
        private BrightIdeasSoftware.OLVColumn olvColTickets_AssetLocation;
        private BrightIdeasSoftware.OLVColumn olvColTickets_Symptoms;
        private BrightIdeasSoftware.OLVColumn olvColTickets_Solutions;
        private System.Windows.Forms.Panel pnlTickets_Control;
        private System.Windows.Forms.Label lblTicketQty;
        private System.Windows.Forms.TextBox txtTicketQty;
        private System.Windows.Forms.TextBox txtMarketNumber_3;
        private System.Windows.Forms.Label lblMarketNumber_3;
        private System.Windows.Forms.TextBox txtMarketPosition_3;
        private System.Windows.Forms.Label lblMarketPosition_3;
        private System.Windows.Forms.TextBox txtMarketName_3;
        private System.Windows.Forms.Label lblMarketName_3;
        private System.Windows.Forms.TextBox txtMarketNumber_2;
        private System.Windows.Forms.Label lblMarketNumber_2;
        private System.Windows.Forms.TextBox txtMarketPosition_2;
        private System.Windows.Forms.Label lblMarketPosition_2;
        private System.Windows.Forms.TextBox txtMarketName_2;
        private System.Windows.Forms.Label lblMarketName_2;
        private System.Windows.Forms.TextBox txtMarketNumber_1;
        private System.Windows.Forms.Label lblMarketNumber_1;
        private System.Windows.Forms.CheckBox chkSubscribe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiMarketOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddMarket;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditMarket;
        private System.Windows.Forms.GroupBox grpSalesperson;
        private System.Windows.Forms.Label lblSalespersonPhone;
        private System.Windows.Forms.TextBox txtSalespersonPhone;
        private System.Windows.Forms.Label lblSalespersonEmail;
        private System.Windows.Forms.TextBox txtSalespersonEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddCustomerTag;
        private System.Windows.Forms.RadioButton radClosedTickets;
        private System.Windows.Forms.RadioButton radOpenTickets;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblProgress;
    }
}
