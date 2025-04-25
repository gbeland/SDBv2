namespace SDB.Forms.Admin
{
    partial class FormAdmin_MarketConfig
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
			this.cmbCustomer_Select = new System.Windows.Forms.ComboBox();
			this.lstEmail = new System.Windows.Forms.ListView();
			this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnEmail_New = new System.Windows.Forms.Button();
			this.btnEmail_Update = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail_New = new System.Windows.Forms.Label();
			this.btnMarket_New = new System.Windows.Forms.Button();
			this.lblMarket_ID = new System.Windows.Forms.Label();
			this.txtMarket_ID = new System.Windows.Forms.TextBox();
			this.btnMarket_Save = new System.Windows.Forms.Button();
			this.txtMarket_Name = new System.Windows.Forms.TextBox();
			this.btnCustomer_New = new System.Windows.Forms.Button();
			this.txtCustomer_ID = new System.Windows.Forms.TextBox();
			this.lblCustomer_ID = new System.Windows.Forms.Label();
			this.txtCustomer_Name = new System.Windows.Forms.TextBox();
			this.btnCustomer_Save = new System.Windows.Forms.Button();
			this.chkSubscribe_Customer = new System.Windows.Forms.CheckBox();
			this.btnCustomer_Delete = new System.Windows.Forms.Button();
			this.pnlMarket_Email = new System.Windows.Forms.Panel();
			this.grpEmailAddresses = new System.Windows.Forms.GroupBox();
			this.btnEmail_Delete = new System.Windows.Forms.Button();
			this.pnlMarketEmailOptions = new System.Windows.Forms.Panel();
			this.chkMarket_EmailRmaCreated = new System.Windows.Forms.CheckBox();
			this.lblMarket_EmailReceives = new System.Windows.Forms.Label();
			this.chkMarket_EmailTechOnSite = new System.Windows.Forms.CheckBox();
			this.chkMarket_EmailClosed = new System.Windows.Forms.CheckBox();
			this.chkMarket_EmailOpen = new System.Windows.Forms.CheckBox();
			this.btnMarket_Delete = new System.Windows.Forms.Button();
			this.pnlMarket_Bottom = new System.Windows.Forms.Panel();
			this.lblMarket_Name = new System.Windows.Forms.Label();
			this.chkSubscribe_Market = new System.Windows.Forms.CheckBox();
			this.cmbMarket_SalesRep = new System.Windows.Forms.ComboBox();
			this.lblMarket_SalesRep = new System.Windows.Forms.Label();
			this.txtMarket_Telephone = new System.Windows.Forms.TextBox();
			this.txtMarket_Country = new System.Windows.Forms.TextBox();
			this.lblMarket_Telephone = new System.Windows.Forms.Label();
			this.lblMarket_Country = new System.Windows.Forms.Label();
			this.lblMarket_Notes = new System.Windows.Forms.Label();
			this.txtMarket_Notes = new System.Windows.Forms.TextBox();
			this.txtMarket_Address = new System.Windows.Forms.TextBox();
			this.txtMarket_City = new System.Windows.Forms.TextBox();
			this.lblMarket_Contact3 = new System.Windows.Forms.Label();
			this.lblMarket_Address = new System.Windows.Forms.Label();
			this.lblMarket_CSZ = new System.Windows.Forms.Label();
			this.txtMarket_Contact3_Number = new System.Windows.Forms.TextBox();
			this.txtMarket_State = new System.Windows.Forms.TextBox();
			this.txtMarket_Zip = new System.Windows.Forms.TextBox();
			this.txtMarket_Contact2_Number = new System.Windows.Forms.TextBox();
			this.txtMarket_Contact1_Name = new System.Windows.Forms.TextBox();
			this.lblMarket_Contact1 = new System.Windows.Forms.Label();
			this.txtMarket_Contact3_Position = new System.Windows.Forms.TextBox();
			this.txtMarket_Contact1_Position = new System.Windows.Forms.TextBox();
			this.txtMarket_Contact3_Name = new System.Windows.Forms.TextBox();
			this.lblMarket_Positions = new System.Windows.Forms.Label();
			this.lblMarket_Names = new System.Windows.Forms.Label();
			this.txtMarket_Contact2_Name = new System.Windows.Forms.TextBox();
			this.lblMarket_Numbers = new System.Windows.Forms.Label();
			this.lblMarket_Contact2 = new System.Windows.Forms.Label();
			this.txtMarket_Contact1_Number = new System.Windows.Forms.TextBox();
			this.txtMarket_Contact2_Position = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.chkCustomerFreeze = new System.Windows.Forms.CheckBox();
			this.pnlMarkets = new System.Windows.Forms.Panel();
			this.olvMarkets = new BrightIdeasSoftware.ObjectListView();
			this.olvColMarkets_Prefix = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColMarkets_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColMarkets_AssetQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlMarkets_Control = new System.Windows.Forms.Panel();
			this.pnlMarketsNew = new System.Windows.Forms.Panel();
			this.lblMarkets = new System.Windows.Forms.Label();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlCustomer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCustomer = new System.Windows.Forms.Label();
			this.pnlMarket_Email.SuspendLayout();
			this.grpEmailAddresses.SuspendLayout();
			this.pnlMarketEmailOptions.SuspendLayout();
			this.pnlMarket_Bottom.SuspendLayout();
			this.pnlMarkets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvMarkets)).BeginInit();
			this.pnlMarkets_Control.SuspendLayout();
			this.pnlMarketsNew.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlCustomer.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbCustomer_Select
			// 
			this.cmbCustomer_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCustomer_Select.FormattingEnabled = true;
			this.cmbCustomer_Select.Location = new System.Drawing.Point(12, 16);
			this.cmbCustomer_Select.Name = "cmbCustomer_Select";
			this.cmbCustomer_Select.Size = new System.Drawing.Size(288, 21);
			this.cmbCustomer_Select.TabIndex = 0;
			this.cmbCustomer_Select.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_Select_SelectedIndexChanged);
			// 
			// lstEmail
			// 
			this.lstEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstEmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEmail});
			this.lstEmail.FullRowSelect = true;
			this.lstEmail.HideSelection = false;
			this.lstEmail.Location = new System.Drawing.Point(6, 17);
			this.lstEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lstEmail.Name = "lstEmail";
			this.lstEmail.Size = new System.Drawing.Size(259, 125);
			this.lstEmail.TabIndex = 0;
			this.lstEmail.UseCompatibleStateImageBehavior = false;
			this.lstEmail.View = System.Windows.Forms.View.Details;
			this.lstEmail.SelectedIndexChanged += new System.EventHandler(this.lstEmail_SelectedIndexChanged);
			// 
			// colEmail
			// 
			this.colEmail.Text = "Address";
			this.colEmail.Width = 250;
			// 
			// btnEmail_New
			// 
			this.btnEmail_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmail_New.AutoSize = true;
			this.btnEmail_New.Enabled = false;
			this.btnEmail_New.Location = new System.Drawing.Point(273, 17);
			this.btnEmail_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEmail_New.Name = "btnEmail_New";
			this.btnEmail_New.Size = new System.Drawing.Size(50, 23);
			this.btnEmail_New.TabIndex = 1;
			this.btnEmail_New.Text = "New";
			this.btnEmail_New.UseVisualStyleBackColor = true;
			this.btnEmail_New.Click += new System.EventHandler(this.btnEmail_New_Click);
			// 
			// btnEmail_Update
			// 
			this.btnEmail_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmail_Update.AutoSize = true;
			this.btnEmail_Update.Enabled = false;
			this.btnEmail_Update.Location = new System.Drawing.Point(271, 157);
			this.btnEmail_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEmail_Update.Name = "btnEmail_Update";
			this.btnEmail_Update.Size = new System.Drawing.Size(52, 23);
			this.btnEmail_Update.TabIndex = 5;
			this.btnEmail_Update.Text = "Update";
			this.toolTip.SetToolTip(this.btnEmail_Update, "Be sure to Save the market details below when modifying or adding email addresses" +
        ".");
			this.btnEmail_Update.UseVisualStyleBackColor = true;
			this.btnEmail_Update.Click += new System.EventHandler(this.btnEmail_Update_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtEmail.Location = new System.Drawing.Point(6, 159);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEmail.MaxLength = 70;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(259, 20);
			this.txtEmail.TabIndex = 4;
			this.toolTip.SetToolTip(this.txtEmail, "Be sure to Save the market details below when modifying or adding email addresses" +
        ".");
			this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
			// 
			// lblEmail_New
			// 
			this.lblEmail_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblEmail_New.AutoSize = true;
			this.lblEmail_New.Location = new System.Drawing.Point(3, 144);
			this.lblEmail_New.Name = "lblEmail_New";
			this.lblEmail_New.Size = new System.Drawing.Size(77, 13);
			this.lblEmail_New.TabIndex = 3;
			this.lblEmail_New.Text = "E-Mail Address";
			// 
			// btnMarket_New
			// 
			this.btnMarket_New.AutoSize = true;
			this.btnMarket_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnMarket_New.Enabled = false;
			this.btnMarket_New.Location = new System.Drawing.Point(12, 3);
			this.btnMarket_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMarket_New.Name = "btnMarket_New";
			this.btnMarket_New.Size = new System.Drawing.Size(75, 23);
			this.btnMarket_New.TabIndex = 0;
			this.btnMarket_New.Text = "New Market";
			this.btnMarket_New.UseVisualStyleBackColor = false;
			this.btnMarket_New.Click += new System.EventHandler(this.btnMarket_New_Click);
			// 
			// lblMarket_ID
			// 
			this.lblMarket_ID.AutoSize = true;
			this.lblMarket_ID.Location = new System.Drawing.Point(67, 7);
			this.lblMarket_ID.Name = "lblMarket_ID";
			this.lblMarket_ID.Size = new System.Drawing.Size(18, 13);
			this.lblMarket_ID.TabIndex = 0;
			this.lblMarket_ID.Text = "ID";
			// 
			// txtMarket_ID
			// 
			this.txtMarket_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMarket_ID.Location = new System.Drawing.Point(91, 4);
			this.txtMarket_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_ID.MaxLength = 16;
			this.txtMarket_ID.Name = "txtMarket_ID";
			this.txtMarket_ID.Size = new System.Drawing.Size(56, 20);
			this.txtMarket_ID.TabIndex = 1;
			this.txtMarket_ID.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_ID.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// btnMarket_Save
			// 
			this.btnMarket_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMarket_Save.Location = new System.Drawing.Point(606, 185);
			this.btnMarket_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMarket_Save.Name = "btnMarket_Save";
			this.btnMarket_Save.Size = new System.Drawing.Size(106, 42);
			this.btnMarket_Save.TabIndex = 34;
			this.btnMarket_Save.Text = "Save Market";
			this.btnMarket_Save.UseVisualStyleBackColor = true;
			this.btnMarket_Save.Click += new System.EventHandler(this.btnMarket_Save_Click);
			// 
			// txtMarket_Name
			// 
			this.txtMarket_Name.Location = new System.Drawing.Point(91, 28);
			this.txtMarket_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Name.MaxLength = 45;
			this.txtMarket_Name.Name = "txtMarket_Name";
			this.txtMarket_Name.Size = new System.Drawing.Size(262, 20);
			this.txtMarket_Name.TabIndex = 5;
			this.txtMarket_Name.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Name.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// btnCustomer_New
			// 
			this.btnCustomer_New.AutoSize = true;
			this.btnCustomer_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCustomer_New.Location = new System.Drawing.Point(306, 15);
			this.btnCustomer_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCustomer_New.Name = "btnCustomer_New";
			this.btnCustomer_New.Size = new System.Drawing.Size(86, 23);
			this.btnCustomer_New.TabIndex = 1;
			this.btnCustomer_New.Text = "New Customer";
			this.btnCustomer_New.UseVisualStyleBackColor = false;
			this.btnCustomer_New.Click += new System.EventHandler(this.btnCustomer_New_Click);
			// 
			// txtCustomer_ID
			// 
			this.txtCustomer_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCustomer_ID.Location = new System.Drawing.Point(12, 54);
			this.txtCustomer_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCustomer_ID.MaxLength = 3;
			this.txtCustomer_ID.Name = "txtCustomer_ID";
			this.txtCustomer_ID.Size = new System.Drawing.Size(56, 20);
			this.txtCustomer_ID.TabIndex = 4;
			this.toolTip.SetToolTip(this.txtCustomer_ID, "Customer ID / Abbreviation");
			this.txtCustomer_ID.Enter += new System.EventHandler(this.Customer_TextEnter);
			this.txtCustomer_ID.Leave += new System.EventHandler(this.Customer_TextLeave);
			// 
			// lblCustomer_ID
			// 
			this.lblCustomer_ID.AutoSize = true;
			this.lblCustomer_ID.Location = new System.Drawing.Point(9, 39);
			this.lblCustomer_ID.Name = "lblCustomer_ID";
			this.lblCustomer_ID.Size = new System.Drawing.Size(18, 13);
			this.lblCustomer_ID.TabIndex = 3;
			this.lblCustomer_ID.Text = "ID";
			// 
			// txtCustomer_Name
			// 
			this.txtCustomer_Name.Location = new System.Drawing.Point(74, 54);
			this.txtCustomer_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCustomer_Name.MaxLength = 70;
			this.txtCustomer_Name.Name = "txtCustomer_Name";
			this.txtCustomer_Name.Size = new System.Drawing.Size(227, 20);
			this.txtCustomer_Name.TabIndex = 6;
			this.txtCustomer_Name.Enter += new System.EventHandler(this.Customer_TextEnter);
			this.txtCustomer_Name.Leave += new System.EventHandler(this.Customer_TextLeave);
			// 
			// btnCustomer_Save
			// 
			this.btnCustomer_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCustomer_Save.AutoSize = true;
			this.btnCustomer_Save.Enabled = false;
			this.btnCustomer_Save.Location = new System.Drawing.Point(623, 75);
			this.btnCustomer_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCustomer_Save.Name = "btnCustomer_Save";
			this.btnCustomer_Save.Size = new System.Drawing.Size(89, 23);
			this.btnCustomer_Save.TabIndex = 9;
			this.btnCustomer_Save.Text = "Save Customer";
			this.btnCustomer_Save.UseVisualStyleBackColor = true;
			this.btnCustomer_Save.Click += new System.EventHandler(this.btnCustomer_Save_Click);
			// 
			// chkSubscribe_Customer
			// 
			this.chkSubscribe_Customer.AutoCheck = false;
			this.chkSubscribe_Customer.AutoSize = true;
			this.chkSubscribe_Customer.Location = new System.Drawing.Point(12, 82);
			this.chkSubscribe_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkSubscribe_Customer.Name = "chkSubscribe_Customer";
			this.chkSubscribe_Customer.Size = new System.Drawing.Size(73, 17);
			this.chkSubscribe_Customer.TabIndex = 7;
			this.chkSubscribe_Customer.Text = "Subscribe";
			this.toolTip.SetToolTip(this.chkSubscribe_Customer, "Indicates whether you are subscribed to this item.");
			this.chkSubscribe_Customer.UseVisualStyleBackColor = true;
			this.chkSubscribe_Customer.Click += new System.EventHandler(this.chkSubscribe_Customer_Click);
			// 
			// btnCustomer_Delete
			// 
			this.btnCustomer_Delete.AutoSize = true;
			this.btnCustomer_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCustomer_Delete.Enabled = false;
			this.btnCustomer_Delete.Location = new System.Drawing.Point(398, 14);
			this.btnCustomer_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCustomer_Delete.Name = "btnCustomer_Delete";
			this.btnCustomer_Delete.Size = new System.Drawing.Size(95, 23);
			this.btnCustomer_Delete.TabIndex = 2;
			this.btnCustomer_Delete.Text = "Delete Customer";
			this.btnCustomer_Delete.UseVisualStyleBackColor = false;
			this.btnCustomer_Delete.Click += new System.EventHandler(this.btnCustomer_Delete_Click);
			// 
			// pnlMarket_Email
			// 
			this.pnlMarket_Email.Controls.Add(this.grpEmailAddresses);
			this.pnlMarket_Email.Controls.Add(this.pnlMarketEmailOptions);
			this.pnlMarket_Email.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlMarket_Email.Enabled = false;
			this.pnlMarket_Email.Location = new System.Drawing.Point(395, 13);
			this.pnlMarket_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMarket_Email.Name = "pnlMarket_Email";
			this.pnlMarket_Email.Size = new System.Drawing.Size(329, 227);
			this.pnlMarket_Email.TabIndex = 1;
			// 
			// grpEmailAddresses
			// 
			this.grpEmailAddresses.Controls.Add(this.btnEmail_Delete);
			this.grpEmailAddresses.Controls.Add(this.btnEmail_Update);
			this.grpEmailAddresses.Controls.Add(this.lblEmail_New);
			this.grpEmailAddresses.Controls.Add(this.lstEmail);
			this.grpEmailAddresses.Controls.Add(this.txtEmail);
			this.grpEmailAddresses.Controls.Add(this.btnEmail_New);
			this.grpEmailAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpEmailAddresses.Location = new System.Drawing.Point(0, 0);
			this.grpEmailAddresses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpEmailAddresses.Name = "grpEmailAddresses";
			this.grpEmailAddresses.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grpEmailAddresses.Size = new System.Drawing.Size(329, 185);
			this.grpEmailAddresses.TabIndex = 0;
			this.grpEmailAddresses.TabStop = false;
			this.grpEmailAddresses.Text = "Market Email Addresses";
			// 
			// btnEmail_Delete
			// 
			this.btnEmail_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEmail_Delete.AutoSize = true;
			this.btnEmail_Delete.Enabled = false;
			this.btnEmail_Delete.Location = new System.Drawing.Point(273, 99);
			this.btnEmail_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEmail_Delete.Name = "btnEmail_Delete";
			this.btnEmail_Delete.Size = new System.Drawing.Size(50, 23);
			this.btnEmail_Delete.TabIndex = 2;
			this.btnEmail_Delete.Text = "Delete";
			this.btnEmail_Delete.UseVisualStyleBackColor = true;
			this.btnEmail_Delete.Click += new System.EventHandler(this.btnEmail_Delete_Click);
			// 
			// pnlMarketEmailOptions
			// 
			this.pnlMarketEmailOptions.Controls.Add(this.chkMarket_EmailRmaCreated);
			this.pnlMarketEmailOptions.Controls.Add(this.lblMarket_EmailReceives);
			this.pnlMarketEmailOptions.Controls.Add(this.chkMarket_EmailTechOnSite);
			this.pnlMarketEmailOptions.Controls.Add(this.chkMarket_EmailClosed);
			this.pnlMarketEmailOptions.Controls.Add(this.chkMarket_EmailOpen);
			this.pnlMarketEmailOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlMarketEmailOptions.Location = new System.Drawing.Point(0, 185);
			this.pnlMarketEmailOptions.Name = "pnlMarketEmailOptions";
			this.pnlMarketEmailOptions.Size = new System.Drawing.Size(329, 42);
			this.pnlMarketEmailOptions.TabIndex = 1;
			// 
			// chkMarket_EmailRmaCreated
			// 
			this.chkMarket_EmailRmaCreated.AutoSize = true;
			this.chkMarket_EmailRmaCreated.Location = new System.Drawing.Point(211, 23);
			this.chkMarket_EmailRmaCreated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkMarket_EmailRmaCreated.Name = "chkMarket_EmailRmaCreated";
			this.chkMarket_EmailRmaCreated.Size = new System.Drawing.Size(99, 17);
			this.chkMarket_EmailRmaCreated.TabIndex = 6;
			this.chkMarket_EmailRmaCreated.Text = "RMA is created";
			this.chkMarket_EmailRmaCreated.UseVisualStyleBackColor = true;
			// 
			// lblMarket_EmailReceives
			// 
			this.lblMarket_EmailReceives.AutoSize = true;
			this.lblMarket_EmailReceives.Location = new System.Drawing.Point(3, 3);
			this.lblMarket_EmailReceives.Name = "lblMarket_EmailReceives";
			this.lblMarket_EmailReceives.Size = new System.Drawing.Size(91, 13);
			this.lblMarket_EmailReceives.TabIndex = 2;
			this.lblMarket_EmailReceives.Text = "Send email when:";
			// 
			// chkMarket_EmailTechOnSite
			// 
			this.chkMarket_EmailTechOnSite.AutoSize = true;
			this.chkMarket_EmailTechOnSite.Location = new System.Drawing.Point(211, 2);
			this.chkMarket_EmailTechOnSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkMarket_EmailTechOnSite.Name = "chkMarket_EmailTechOnSite";
			this.chkMarket_EmailTechOnSite.Size = new System.Drawing.Size(119, 17);
			this.chkMarket_EmailTechOnSite.TabIndex = 5;
			this.chkMarket_EmailTechOnSite.Text = "Tech arrives on site";
			this.chkMarket_EmailTechOnSite.UseVisualStyleBackColor = true;
			// 
			// chkMarket_EmailClosed
			// 
			this.chkMarket_EmailClosed.AutoSize = true;
			this.chkMarket_EmailClosed.Location = new System.Drawing.Point(100, 23);
			this.chkMarket_EmailClosed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkMarket_EmailClosed.Name = "chkMarket_EmailClosed";
			this.chkMarket_EmailClosed.Size = new System.Drawing.Size(100, 17);
			this.chkMarket_EmailClosed.TabIndex = 4;
			this.chkMarket_EmailClosed.Text = "Ticket is closed";
			this.chkMarket_EmailClosed.UseVisualStyleBackColor = true;
			// 
			// chkMarket_EmailOpen
			// 
			this.chkMarket_EmailOpen.AutoSize = true;
			this.chkMarket_EmailOpen.Location = new System.Drawing.Point(100, 2);
			this.chkMarket_EmailOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkMarket_EmailOpen.Name = "chkMarket_EmailOpen";
			this.chkMarket_EmailOpen.Size = new System.Drawing.Size(105, 17);
			this.chkMarket_EmailOpen.TabIndex = 3;
			this.chkMarket_EmailOpen.Text = "Ticket is opened";
			this.chkMarket_EmailOpen.UseVisualStyleBackColor = true;
			// 
			// btnMarket_Delete
			// 
			this.btnMarket_Delete.AutoSize = true;
			this.btnMarket_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnMarket_Delete.Enabled = false;
			this.btnMarket_Delete.Location = new System.Drawing.Point(93, 3);
			this.btnMarket_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMarket_Delete.Name = "btnMarket_Delete";
			this.btnMarket_Delete.Size = new System.Drawing.Size(84, 23);
			this.btnMarket_Delete.TabIndex = 1;
			this.btnMarket_Delete.Text = "Delete Market";
			this.btnMarket_Delete.UseVisualStyleBackColor = false;
			this.btnMarket_Delete.Click += new System.EventHandler(this.btnMarket_Delete_Click);
			// 
			// pnlMarket_Bottom
			// 
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Name);
			this.pnlMarket_Bottom.Controls.Add(this.chkSubscribe_Market);
			this.pnlMarket_Bottom.Controls.Add(this.cmbMarket_SalesRep);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_SalesRep);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Telephone);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Country);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Telephone);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Country);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Notes);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_ID);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Notes);
			this.pnlMarket_Bottom.Controls.Add(this.btnMarket_Save);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Name);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_ID);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Address);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_City);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Contact3);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Address);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_CSZ);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact3_Number);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_State);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Zip);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact2_Number);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact1_Name);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Contact1);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact3_Position);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact1_Position);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact3_Name);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Positions);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Names);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact2_Name);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Numbers);
			this.pnlMarket_Bottom.Controls.Add(this.lblMarket_Contact2);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact1_Number);
			this.pnlMarket_Bottom.Controls.Add(this.txtMarket_Contact2_Position);
			this.pnlMarket_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlMarket_Bottom.Enabled = false;
			this.pnlMarket_Bottom.Location = new System.Drawing.Point(0, 240);
			this.pnlMarket_Bottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMarket_Bottom.Name = "pnlMarket_Bottom";
			this.pnlMarket_Bottom.Size = new System.Drawing.Size(724, 232);
			this.pnlMarket_Bottom.TabIndex = 2;
			// 
			// lblMarket_Name
			// 
			this.lblMarket_Name.AutoSize = true;
			this.lblMarket_Name.Location = new System.Drawing.Point(50, 31);
			this.lblMarket_Name.Name = "lblMarket_Name";
			this.lblMarket_Name.Size = new System.Drawing.Size(35, 13);
			this.lblMarket_Name.TabIndex = 4;
			this.lblMarket_Name.Text = "Name";
			// 
			// chkSubscribe_Market
			// 
			this.chkSubscribe_Market.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkSubscribe_Market.AutoCheck = false;
			this.chkSubscribe_Market.AutoSize = true;
			this.chkSubscribe_Market.Location = new System.Drawing.Point(527, 195);
			this.chkSubscribe_Market.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkSubscribe_Market.Name = "chkSubscribe_Market";
			this.chkSubscribe_Market.Size = new System.Drawing.Size(73, 17);
			this.chkSubscribe_Market.TabIndex = 33;
			this.chkSubscribe_Market.Text = "Subscribe";
			this.toolTip.SetToolTip(this.chkSubscribe_Market, "Indicates whether you are subscribed to this item.");
			this.chkSubscribe_Market.UseVisualStyleBackColor = true;
			this.chkSubscribe_Market.Click += new System.EventHandler(this.chkSubscribe_Market_Click);
			// 
			// cmbMarket_SalesRep
			// 
			this.cmbMarket_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbMarket_SalesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMarket_SalesRep.FormattingEnabled = true;
			this.cmbMarket_SalesRep.Location = new System.Drawing.Point(267, 4);
			this.cmbMarket_SalesRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbMarket_SalesRep.Name = "cmbMarket_SalesRep";
			this.cmbMarket_SalesRep.Size = new System.Drawing.Size(159, 21);
			this.cmbMarket_SalesRep.TabIndex = 3;
			// 
			// lblMarket_SalesRep
			// 
			this.lblMarket_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMarket_SalesRep.AutoSize = true;
			this.lblMarket_SalesRep.Location = new System.Drawing.Point(153, 7);
			this.lblMarket_SalesRep.Name = "lblMarket_SalesRep";
			this.lblMarket_SalesRep.Size = new System.Drawing.Size(108, 13);
			this.lblMarket_SalesRep.TabIndex = 2;
			this.lblMarket_SalesRep.Text = "Sales Representative";
			// 
			// txtMarket_Telephone
			// 
			this.txtMarket_Telephone.Location = new System.Drawing.Point(355, 125);
			this.txtMarket_Telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Telephone.MaxLength = 32;
			this.txtMarket_Telephone.Name = "txtMarket_Telephone";
			this.txtMarket_Telephone.Size = new System.Drawing.Size(129, 20);
			this.txtMarket_Telephone.TabIndex = 15;
			// 
			// txtMarket_Country
			// 
			this.txtMarket_Country.Location = new System.Drawing.Point(91, 125);
			this.txtMarket_Country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Country.MaxLength = 32;
			this.txtMarket_Country.Name = "txtMarket_Country";
			this.txtMarket_Country.Size = new System.Drawing.Size(150, 20);
			this.txtMarket_Country.TabIndex = 13;
			// 
			// lblMarket_Telephone
			// 
			this.lblMarket_Telephone.AutoSize = true;
			this.lblMarket_Telephone.Location = new System.Drawing.Point(291, 128);
			this.lblMarket_Telephone.Name = "lblMarket_Telephone";
			this.lblMarket_Telephone.Size = new System.Drawing.Size(58, 13);
			this.lblMarket_Telephone.TabIndex = 14;
			this.lblMarket_Telephone.Text = "Telephone";
			// 
			// lblMarket_Country
			// 
			this.lblMarket_Country.AutoSize = true;
			this.lblMarket_Country.Location = new System.Drawing.Point(42, 128);
			this.lblMarket_Country.Name = "lblMarket_Country";
			this.lblMarket_Country.Size = new System.Drawing.Size(43, 13);
			this.lblMarket_Country.TabIndex = 12;
			this.lblMarket_Country.Text = "Country";
			// 
			// lblMarket_Notes
			// 
			this.lblMarket_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMarket_Notes.AutoSize = true;
			this.lblMarket_Notes.Location = new System.Drawing.Point(453, 13);
			this.lblMarket_Notes.Name = "lblMarket_Notes";
			this.lblMarket_Notes.Size = new System.Drawing.Size(35, 13);
			this.lblMarket_Notes.TabIndex = 16;
			this.lblMarket_Notes.Text = "Notes";
			// 
			// txtMarket_Notes
			// 
			this.txtMarket_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarket_Notes.Location = new System.Drawing.Point(456, 28);
			this.txtMarket_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Notes.MaxLength = 1024;
			this.txtMarket_Notes.Multiline = true;
			this.txtMarket_Notes.Name = "txtMarket_Notes";
			this.txtMarket_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMarket_Notes.Size = new System.Drawing.Size(256, 67);
			this.txtMarket_Notes.TabIndex = 17;
			this.txtMarket_Notes.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Notes.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Address
			// 
			this.txtMarket_Address.AcceptsReturn = true;
			this.txtMarket_Address.Location = new System.Drawing.Point(91, 52);
			this.txtMarket_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Address.MaxLength = 192;
			this.txtMarket_Address.Multiline = true;
			this.txtMarket_Address.Name = "txtMarket_Address";
			this.txtMarket_Address.Size = new System.Drawing.Size(262, 46);
			this.txtMarket_Address.TabIndex = 7;
			this.txtMarket_Address.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Address.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_City
			// 
			this.txtMarket_City.Location = new System.Drawing.Point(91, 102);
			this.txtMarket_City.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_City.MaxLength = 40;
			this.txtMarket_City.Name = "txtMarket_City";
			this.txtMarket_City.Size = new System.Drawing.Size(161, 20);
			this.txtMarket_City.TabIndex = 9;
			this.txtMarket_City.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_City.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// lblMarket_Contact3
			// 
			this.lblMarket_Contact3.AutoSize = true;
			this.lblMarket_Contact3.Location = new System.Drawing.Point(34, 211);
			this.lblMarket_Contact3.Name = "lblMarket_Contact3";
			this.lblMarket_Contact3.Size = new System.Drawing.Size(53, 13);
			this.lblMarket_Contact3.TabIndex = 29;
			this.lblMarket_Contact3.Text = "Contact 3";
			// 
			// lblMarket_Address
			// 
			this.lblMarket_Address.AutoSize = true;
			this.lblMarket_Address.Location = new System.Drawing.Point(40, 55);
			this.lblMarket_Address.Name = "lblMarket_Address";
			this.lblMarket_Address.Size = new System.Drawing.Size(45, 13);
			this.lblMarket_Address.TabIndex = 6;
			this.lblMarket_Address.Text = "Address";
			// 
			// lblMarket_CSZ
			// 
			this.lblMarket_CSZ.AutoSize = true;
			this.lblMarket_CSZ.Location = new System.Drawing.Point(9, 105);
			this.lblMarket_CSZ.Name = "lblMarket_CSZ";
			this.lblMarket_CSZ.Size = new System.Drawing.Size(76, 13);
			this.lblMarket_CSZ.TabIndex = 8;
			this.lblMarket_CSZ.Text = "City, State, Zip";
			// 
			// txtMarket_Contact3_Number
			// 
			this.txtMarket_Contact3_Number.Location = new System.Drawing.Point(357, 208);
			this.txtMarket_Contact3_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact3_Number.MaxLength = 45;
			this.txtMarket_Contact3_Number.Name = "txtMarket_Contact3_Number";
			this.txtMarket_Contact3_Number.Size = new System.Drawing.Size(129, 20);
			this.txtMarket_Contact3_Number.TabIndex = 32;
			this.txtMarket_Contact3_Number.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact3_Number.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_State
			// 
			this.txtMarket_State.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMarket_State.Location = new System.Drawing.Point(258, 102);
			this.txtMarket_State.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_State.MaxLength = 3;
			this.txtMarket_State.Name = "txtMarket_State";
			this.txtMarket_State.Size = new System.Drawing.Size(35, 20);
			this.txtMarket_State.TabIndex = 10;
			this.txtMarket_State.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_State.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Zip
			// 
			this.txtMarket_Zip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMarket_Zip.Location = new System.Drawing.Point(299, 102);
			this.txtMarket_Zip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Zip.MaxLength = 10;
			this.txtMarket_Zip.Name = "txtMarket_Zip";
			this.txtMarket_Zip.Size = new System.Drawing.Size(54, 20);
			this.txtMarket_Zip.TabIndex = 11;
			this.txtMarket_Zip.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Zip.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Contact2_Number
			// 
			this.txtMarket_Contact2_Number.Location = new System.Drawing.Point(357, 188);
			this.txtMarket_Contact2_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact2_Number.MaxLength = 45;
			this.txtMarket_Contact2_Number.Name = "txtMarket_Contact2_Number";
			this.txtMarket_Contact2_Number.Size = new System.Drawing.Size(129, 20);
			this.txtMarket_Contact2_Number.TabIndex = 28;
			this.txtMarket_Contact2_Number.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact2_Number.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Contact1_Name
			// 
			this.txtMarket_Contact1_Name.Location = new System.Drawing.Point(93, 168);
			this.txtMarket_Contact1_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact1_Name.MaxLength = 45;
			this.txtMarket_Contact1_Name.Name = "txtMarket_Contact1_Name";
			this.txtMarket_Contact1_Name.Size = new System.Drawing.Size(150, 20);
			this.txtMarket_Contact1_Name.TabIndex = 22;
			this.txtMarket_Contact1_Name.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact1_Name.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// lblMarket_Contact1
			// 
			this.lblMarket_Contact1.AutoSize = true;
			this.lblMarket_Contact1.Location = new System.Drawing.Point(34, 171);
			this.lblMarket_Contact1.Name = "lblMarket_Contact1";
			this.lblMarket_Contact1.Size = new System.Drawing.Size(53, 13);
			this.lblMarket_Contact1.TabIndex = 21;
			this.lblMarket_Contact1.Text = "Contact 1";
			// 
			// txtMarket_Contact3_Position
			// 
			this.txtMarket_Contact3_Position.Location = new System.Drawing.Point(248, 208);
			this.txtMarket_Contact3_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact3_Position.MaxLength = 32;
			this.txtMarket_Contact3_Position.Name = "txtMarket_Contact3_Position";
			this.txtMarket_Contact3_Position.Size = new System.Drawing.Size(105, 20);
			this.txtMarket_Contact3_Position.TabIndex = 31;
			this.txtMarket_Contact3_Position.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact3_Position.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Contact1_Position
			// 
			this.txtMarket_Contact1_Position.Location = new System.Drawing.Point(248, 168);
			this.txtMarket_Contact1_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact1_Position.MaxLength = 32;
			this.txtMarket_Contact1_Position.Name = "txtMarket_Contact1_Position";
			this.txtMarket_Contact1_Position.Size = new System.Drawing.Size(105, 20);
			this.txtMarket_Contact1_Position.TabIndex = 23;
			this.txtMarket_Contact1_Position.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact1_Position.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Contact3_Name
			// 
			this.txtMarket_Contact3_Name.Location = new System.Drawing.Point(93, 208);
			this.txtMarket_Contact3_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact3_Name.MaxLength = 45;
			this.txtMarket_Contact3_Name.Name = "txtMarket_Contact3_Name";
			this.txtMarket_Contact3_Name.Size = new System.Drawing.Size(150, 20);
			this.txtMarket_Contact3_Name.TabIndex = 30;
			this.txtMarket_Contact3_Name.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact3_Name.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// lblMarket_Positions
			// 
			this.lblMarket_Positions.AutoSize = true;
			this.lblMarket_Positions.Location = new System.Drawing.Point(245, 152);
			this.lblMarket_Positions.Name = "lblMarket_Positions";
			this.lblMarket_Positions.Size = new System.Drawing.Size(44, 13);
			this.lblMarket_Positions.TabIndex = 19;
			this.lblMarket_Positions.Text = "Position";
			// 
			// lblMarket_Names
			// 
			this.lblMarket_Names.AutoSize = true;
			this.lblMarket_Names.Location = new System.Drawing.Point(90, 152);
			this.lblMarket_Names.Name = "lblMarket_Names";
			this.lblMarket_Names.Size = new System.Drawing.Size(35, 13);
			this.lblMarket_Names.TabIndex = 18;
			this.lblMarket_Names.Text = "Name";
			// 
			// txtMarket_Contact2_Name
			// 
			this.txtMarket_Contact2_Name.Location = new System.Drawing.Point(93, 188);
			this.txtMarket_Contact2_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact2_Name.MaxLength = 45;
			this.txtMarket_Contact2_Name.Name = "txtMarket_Contact2_Name";
			this.txtMarket_Contact2_Name.Size = new System.Drawing.Size(150, 20);
			this.txtMarket_Contact2_Name.TabIndex = 26;
			this.txtMarket_Contact2_Name.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact2_Name.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// lblMarket_Numbers
			// 
			this.lblMarket_Numbers.AutoSize = true;
			this.lblMarket_Numbers.Location = new System.Drawing.Point(354, 152);
			this.lblMarket_Numbers.Name = "lblMarket_Numbers";
			this.lblMarket_Numbers.Size = new System.Drawing.Size(44, 13);
			this.lblMarket_Numbers.TabIndex = 20;
			this.lblMarket_Numbers.Text = "Number";
			// 
			// lblMarket_Contact2
			// 
			this.lblMarket_Contact2.AutoSize = true;
			this.lblMarket_Contact2.Location = new System.Drawing.Point(34, 191);
			this.lblMarket_Contact2.Name = "lblMarket_Contact2";
			this.lblMarket_Contact2.Size = new System.Drawing.Size(53, 13);
			this.lblMarket_Contact2.TabIndex = 25;
			this.lblMarket_Contact2.Text = "Contact 2";
			// 
			// txtMarket_Contact1_Number
			// 
			this.txtMarket_Contact1_Number.Location = new System.Drawing.Point(357, 168);
			this.txtMarket_Contact1_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact1_Number.MaxLength = 45;
			this.txtMarket_Contact1_Number.Name = "txtMarket_Contact1_Number";
			this.txtMarket_Contact1_Number.Size = new System.Drawing.Size(129, 20);
			this.txtMarket_Contact1_Number.TabIndex = 24;
			this.txtMarket_Contact1_Number.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact1_Number.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// txtMarket_Contact2_Position
			// 
			this.txtMarket_Contact2_Position.Location = new System.Drawing.Point(248, 188);
			this.txtMarket_Contact2_Position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMarket_Contact2_Position.MaxLength = 32;
			this.txtMarket_Contact2_Position.Name = "txtMarket_Contact2_Position";
			this.txtMarket_Contact2_Position.Size = new System.Drawing.Size(105, 20);
			this.txtMarket_Contact2_Position.TabIndex = 27;
			this.txtMarket_Contact2_Position.Enter += new System.EventHandler(this.Market_TextEnter);
			this.txtMarket_Contact2_Position.Leave += new System.EventHandler(this.Market_TextLeave);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSize = true;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(607, 4);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(105, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// chkCustomerFreeze
			// 
			this.chkCustomerFreeze.AutoSize = true;
			this.chkCustomerFreeze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.chkCustomerFreeze.ForeColor = System.Drawing.Color.Red;
			this.chkCustomerFreeze.Location = new System.Drawing.Point(91, 82);
			this.chkCustomerFreeze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkCustomerFreeze.Name = "chkCustomerFreeze";
			this.chkCustomerFreeze.Size = new System.Drawing.Size(58, 17);
			this.chkCustomerFreeze.TabIndex = 8;
			this.chkCustomerFreeze.Text = "Freeze";
			this.toolTip.SetToolTip(this.chkCustomerFreeze, "Prevents tickets from being created for assets owned by this customer.");
			this.chkCustomerFreeze.UseVisualStyleBackColor = false;
			// 
			// pnlMarkets
			// 
			this.pnlMarkets.Controls.Add(this.olvMarkets);
			this.pnlMarkets.Controls.Add(this.pnlMarkets_Control);
			this.pnlMarkets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMarkets.Enabled = false;
			this.pnlMarkets.Location = new System.Drawing.Point(0, 13);
			this.pnlMarkets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMarkets.Name = "pnlMarkets";
			this.pnlMarkets.Size = new System.Drawing.Size(395, 227);
			this.pnlMarkets.TabIndex = 0;
			// 
			// olvMarkets
			// 
			this.olvMarkets.AllColumns.Add(this.olvColMarkets_Prefix);
			this.olvMarkets.AllColumns.Add(this.olvColMarkets_Name);
			this.olvMarkets.AllColumns.Add(this.olvColMarkets_AssetQty);
			this.olvMarkets.CellEditUseWholeCell = false;
			this.olvMarkets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColMarkets_Prefix,
            this.olvColMarkets_Name,
            this.olvColMarkets_AssetQty});
			this.olvMarkets.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvMarkets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvMarkets.FullRowSelect = true;
			this.olvMarkets.GridLines = true;
			this.olvMarkets.Location = new System.Drawing.Point(0, 30);
			this.olvMarkets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.olvMarkets.MultiSelect = false;
			this.olvMarkets.Name = "olvMarkets";
			this.olvMarkets.SelectAllOnControlA = false;
			this.olvMarkets.ShowGroups = false;
			this.olvMarkets.Size = new System.Drawing.Size(395, 197);
			this.olvMarkets.TabIndex = 1;
			this.olvMarkets.UseCompatibleStateImageBehavior = false;
			this.olvMarkets.View = System.Windows.Forms.View.Details;
			this.olvMarkets.SelectedIndexChanged += new System.EventHandler(this.olvMarkets_SelectedIndexChanged);
			// 
			// olvColMarkets_Prefix
			// 
			this.olvColMarkets_Prefix.AspectName = "Prefix";
			this.olvColMarkets_Prefix.Text = "Prefix";
			// 
			// olvColMarkets_Name
			// 
			this.olvColMarkets_Name.AspectName = "Name";
			this.olvColMarkets_Name.FillsFreeSpace = true;
			this.olvColMarkets_Name.Text = "Name";
			this.olvColMarkets_Name.Width = 220;
			// 
			// olvColMarkets_AssetQty
			// 
			this.olvColMarkets_AssetQty.AspectName = "AssetQty";
			this.olvColMarkets_AssetQty.Text = "Assets";
			// 
			// pnlMarkets_Control
			// 
			this.pnlMarkets_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlMarkets_Control.Controls.Add(this.btnMarket_New);
			this.pnlMarkets_Control.Controls.Add(this.btnMarket_Delete);
			this.pnlMarkets_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMarkets_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlMarkets_Control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlMarkets_Control.Name = "pnlMarkets_Control";
			this.pnlMarkets_Control.Size = new System.Drawing.Size(395, 30);
			this.pnlMarkets_Control.TabIndex = 0;
			// 
			// pnlMarketsNew
			// 
			this.pnlMarketsNew.Controls.Add(this.pnlMarkets);
			this.pnlMarketsNew.Controls.Add(this.pnlMarket_Email);
			this.pnlMarketsNew.Controls.Add(this.pnlMarket_Bottom);
			this.pnlMarketsNew.Controls.Add(this.lblMarkets);
			this.pnlMarketsNew.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMarketsNew.Location = new System.Drawing.Point(0, 106);
			this.pnlMarketsNew.Name = "pnlMarketsNew";
			this.pnlMarketsNew.Size = new System.Drawing.Size(724, 472);
			this.pnlMarketsNew.TabIndex = 1;
			// 
			// lblMarkets
			// 
			this.lblMarkets.BackColor = System.Drawing.Color.Black;
			this.lblMarkets.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarkets.ForeColor = System.Drawing.Color.White;
			this.lblMarkets.Location = new System.Drawing.Point(0, 0);
			this.lblMarkets.Name = "lblMarkets";
			this.lblMarkets.Size = new System.Drawing.Size(724, 13);
			this.lblMarkets.TabIndex = 4;
			this.lblMarkets.Text = "Markets";
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.btnClose);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 578);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(724, 30);
			this.pnlBottom.TabIndex = 2;
			// 
			// pnlCustomer
			// 
			this.pnlCustomer.Controls.Add(this.label1);
			this.pnlCustomer.Controls.Add(this.chkCustomerFreeze);
			this.pnlCustomer.Controls.Add(this.lblCustomer);
			this.pnlCustomer.Controls.Add(this.chkSubscribe_Customer);
			this.pnlCustomer.Controls.Add(this.cmbCustomer_Select);
			this.pnlCustomer.Controls.Add(this.btnCustomer_Delete);
			this.pnlCustomer.Controls.Add(this.txtCustomer_Name);
			this.pnlCustomer.Controls.Add(this.txtCustomer_ID);
			this.pnlCustomer.Controls.Add(this.btnCustomer_Save);
			this.pnlCustomer.Controls.Add(this.btnCustomer_New);
			this.pnlCustomer.Controls.Add(this.lblCustomer_ID);
			this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
			this.pnlCustomer.Name = "pnlCustomer";
			this.pnlCustomer.Size = new System.Drawing.Size(724, 106);
			this.pnlCustomer.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Customer Name";
			// 
			// lblCustomer
			// 
			this.lblCustomer.BackColor = System.Drawing.Color.Black;
			this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomer.ForeColor = System.Drawing.Color.White;
			this.lblCustomer.Location = new System.Drawing.Point(0, 0);
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Size = new System.Drawing.Size(724, 13);
			this.lblCustomer.TabIndex = 6;
			this.lblCustomer.Text = "Customer";
			// 
			// FormAdmin_MarketConfig
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(724, 608);
			this.Controls.Add(this.pnlMarketsNew);
			this.Controls.Add(this.pnlCustomer);
			this.Controls.Add(this.pnlBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormAdmin_MarketConfig";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Customer and Market Configuration";
			this.Load += new System.EventHandler(this.FormMarketConfig_Load);
			this.pnlMarket_Email.ResumeLayout(false);
			this.grpEmailAddresses.ResumeLayout(false);
			this.grpEmailAddresses.PerformLayout();
			this.pnlMarketEmailOptions.ResumeLayout(false);
			this.pnlMarketEmailOptions.PerformLayout();
			this.pnlMarket_Bottom.ResumeLayout(false);
			this.pnlMarket_Bottom.PerformLayout();
			this.pnlMarkets.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvMarkets)).EndInit();
			this.pnlMarkets_Control.ResumeLayout(false);
			this.pnlMarkets_Control.PerformLayout();
			this.pnlMarketsNew.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			this.pnlCustomer.ResumeLayout(false);
			this.pnlCustomer.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.ComboBox cmbCustomer_Select;
        private System.Windows.Forms.Button btnCustomer_Save;
        private System.Windows.Forms.TextBox txtCustomer_Name;
		private System.Windows.Forms.TextBox txtCustomer_ID;
		private System.Windows.Forms.Label lblCustomer_ID;
		private System.Windows.Forms.Button btnCustomer_New;
        private System.Windows.Forms.Button btnMarket_Save;
		private System.Windows.Forms.TextBox txtMarket_Name;
		private System.Windows.Forms.Button btnMarket_New;
        private System.Windows.Forms.Button btnEmail_Update;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail_New;
        private System.Windows.Forms.Button btnEmail_New;
        private System.Windows.Forms.Label lblMarket_ID;
		private System.Windows.Forms.TextBox txtMarket_ID;
		private System.Windows.Forms.ListView lstEmail;
		private System.Windows.Forms.ColumnHeader colEmail;
		private System.Windows.Forms.Button btnCustomer_Delete;
		private System.Windows.Forms.GroupBox grpEmailAddresses;
		private System.Windows.Forms.Label lblMarket_Contact3;
		private System.Windows.Forms.TextBox txtMarket_Contact3_Number;
		private System.Windows.Forms.TextBox txtMarket_Contact2_Number;
		private System.Windows.Forms.TextBox txtMarket_Contact3_Position;
		private System.Windows.Forms.TextBox txtMarket_Contact3_Name;
		private System.Windows.Forms.Label lblMarket_Names;
		private System.Windows.Forms.Label lblMarket_Numbers;
		private System.Windows.Forms.TextBox txtMarket_Contact1_Number;
		private System.Windows.Forms.TextBox txtMarket_Contact2_Position;
		private System.Windows.Forms.Label lblMarket_Contact2;
		private System.Windows.Forms.TextBox txtMarket_Contact2_Name;
		private System.Windows.Forms.Label lblMarket_Positions;
		private System.Windows.Forms.TextBox txtMarket_Contact1_Position;
		private System.Windows.Forms.Label lblMarket_Contact1;
		private System.Windows.Forms.TextBox txtMarket_Contact1_Name;
		private System.Windows.Forms.TextBox txtMarket_Zip;
		private System.Windows.Forms.TextBox txtMarket_State;
		private System.Windows.Forms.Label lblMarket_CSZ;
		private System.Windows.Forms.Label lblMarket_Address;
		private System.Windows.Forms.TextBox txtMarket_City;
		private System.Windows.Forms.TextBox txtMarket_Address;
		private System.Windows.Forms.Button btnMarket_Delete;
		private System.Windows.Forms.Button btnEmail_Delete;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.CheckBox chkMarket_EmailTechOnSite;
		private System.Windows.Forms.CheckBox chkMarket_EmailClosed;
		private System.Windows.Forms.CheckBox chkMarket_EmailOpen;
		private System.Windows.Forms.Label lblMarket_EmailReceives;
		private System.Windows.Forms.Label lblMarket_Notes;
		private System.Windows.Forms.TextBox txtMarket_Notes;
		private System.Windows.Forms.Panel pnlMarket_Email;
		private System.Windows.Forms.Panel pnlMarket_Bottom;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TextBox txtMarket_Telephone;
		private System.Windows.Forms.TextBox txtMarket_Country;
		private System.Windows.Forms.Label lblMarket_Telephone;
		private System.Windows.Forms.Label lblMarket_Country;
		private System.Windows.Forms.Panel pnlMarkets;
		private System.Windows.Forms.Panel pnlMarkets_Control;
		private BrightIdeasSoftware.ObjectListView olvMarkets;
		private BrightIdeasSoftware.OLVColumn olvColMarkets_Prefix;
		private BrightIdeasSoftware.OLVColumn olvColMarkets_Name;
		private BrightIdeasSoftware.OLVColumn olvColMarkets_AssetQty;
		private System.Windows.Forms.ComboBox cmbMarket_SalesRep;
		private System.Windows.Forms.Label lblMarket_SalesRep;
		private System.Windows.Forms.CheckBox chkSubscribe_Customer;
		private System.Windows.Forms.CheckBox chkSubscribe_Market;
		private System.Windows.Forms.CheckBox chkCustomerFreeze;
		private System.Windows.Forms.Panel pnlMarketsNew;
		private System.Windows.Forms.Label lblMarkets;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlCustomer;
		private System.Windows.Forms.Label lblCustomer;
		private System.Windows.Forms.Panel pnlMarketEmailOptions;
		private System.Windows.Forms.CheckBox chkMarket_EmailRmaCreated;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblMarket_Name;
    }
}