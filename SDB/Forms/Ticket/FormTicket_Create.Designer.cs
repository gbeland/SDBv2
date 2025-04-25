using SDB.UserControls.Asset;

namespace SDB.Forms.Ticket
{
    partial class FormTicket_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket_Create));
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.txtReportedBy = new System.Windows.Forms.TextBox();
            this.lblReportedType = new System.Windows.Forms.Label();
            this.lblReportedBy = new System.Windows.Forms.Label();
            this.pnlSymptoms = new System.Windows.Forms.Panel();
            this.olvSymptoms = new BrightIdeasSoftware.ObjectListView();
            this.olvColSymptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.lblSymptomsDivider = new System.Windows.Forms.Label();
            this.pnlSymptoms_Other = new System.Windows.Forms.Panel();
            this.txtSymptoms_Other = new System.Windows.Forms.TextBox();
            this.lblSymptoms_Other = new System.Windows.Forms.Label();
            this.pnlAssetDetails = new System.Windows.Forms.Panel();
            this.txtAssetNotes = new System.Windows.Forms.TextBox();
            this.lblAssetNotes = new System.Windows.Forms.Label();
            this.txtAssetServiceReminder = new System.Windows.Forms.TextBox();
            this.lblAssetServiceReminder = new System.Windows.Forms.Label();
            this.lblAssetDetails = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtMarket = new System.Windows.Forms.TextBox();
            this.lblMarket = new System.Windows.Forms.Label();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.txtPanel = new System.Windows.Forms.TextBox();
            this.txtAssetLocation = new System.Windows.Forms.TextBox();
            this.lblAsset = new System.Windows.Forms.Label();
            this.lblPanel = new System.Windows.Forms.Label();
            this.lblAssetLocation = new System.Windows.Forms.Label();
            this.dtpDateReceived = new System.Windows.Forms.DateTimePicker();
            this.txtIssueNum = new System.Windows.Forms.TextBox();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.lblIssueNumber = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTicketImage_Webcam = new System.Windows.Forms.Button();
            this.btnTicketImage_File = new System.Windows.Forms.Button();
            this.chkEmail_SendOpen = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.lblOpenTicketImage = new System.Windows.Forms.Label();
            this.btnTicketImage_Clear = new System.Windows.Forms.Button();
            this.lblCameraError = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMarketNotes = new System.Windows.Forms.Panel();
            this.txtMarketNotes = new System.Windows.Forms.TextBox();
            this.lblMarketNotes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOSAPriority = new System.Windows.Forms.GroupBox();
            this.radCritical = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.cmbTechList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSendOSA = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOsaNote = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCameraProcessing = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.ucWarrantyStatus = new SDB.UserControls.Asset.WarrantyStatus();
            this.pnlSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).BeginInit();
            this.pnlSymptoms_Other.SuspendLayout();
            this.pnlAssetDetails.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMarketNotes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpOSAPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(87, 71);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(204, 21);
            this.cmbReportType.TabIndex = 6;
            this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
            // 
            // txtReportedBy
            // 
            this.txtReportedBy.Location = new System.Drawing.Point(87, 98);
            this.txtReportedBy.MaxLength = 50;
            this.txtReportedBy.Name = "txtReportedBy";
            this.txtReportedBy.Size = new System.Drawing.Size(204, 20);
            this.txtReportedBy.TabIndex = 8;
            // 
            // lblReportedType
            // 
            this.lblReportedType.AutoSize = true;
            this.lblReportedType.Location = new System.Drawing.Point(3, 74);
            this.lblReportedType.Name = "lblReportedType";
            this.lblReportedType.Size = new System.Drawing.Size(78, 13);
            this.lblReportedType.TabIndex = 5;
            this.lblReportedType.Text = "Reported Type";
            // 
            // lblReportedBy
            // 
            this.lblReportedBy.AutoSize = true;
            this.lblReportedBy.Location = new System.Drawing.Point(15, 101);
            this.lblReportedBy.Name = "lblReportedBy";
            this.lblReportedBy.Size = new System.Drawing.Size(66, 13);
            this.lblReportedBy.TabIndex = 7;
            this.lblReportedBy.Text = "Reported By";
            // 
            // pnlSymptoms
            // 
            this.pnlSymptoms.BackColor = System.Drawing.Color.LightGray;
            this.pnlSymptoms.Controls.Add(this.olvSymptoms);
            this.pnlSymptoms.Controls.Add(this.lblSymptoms);
            this.pnlSymptoms.Controls.Add(this.lblSymptomsDivider);
            this.pnlSymptoms.Controls.Add(this.pnlSymptoms_Other);
            this.pnlSymptoms.Location = new System.Drawing.Point(322, 173);
            this.pnlSymptoms.Name = "pnlSymptoms";
            this.pnlSymptoms.Size = new System.Drawing.Size(304, 515);
            this.pnlSymptoms.TabIndex = 2;
            this.pnlSymptoms.Text = "Symptoms";
            // 
            // olvSymptoms
            // 
            this.olvSymptoms.AllColumns.Add(this.olvColSymptom);
            this.olvSymptoms.CellEditUseWholeCell = false;
            this.olvSymptoms.CheckBoxes = true;
            this.olvSymptoms.CheckedAspectName = "Selected";
            this.olvSymptoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSymptom});
            this.olvSymptoms.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvSymptoms.EmptyListMsg = "No selectable symptoms.";
            this.olvSymptoms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvSymptoms.Location = new System.Drawing.Point(0, 17);
            this.olvSymptoms.MultiSelect = false;
            this.olvSymptoms.Name = "olvSymptoms";
            this.olvSymptoms.SelectAllOnControlA = false;
            this.olvSymptoms.ShowFilterMenuOnRightClick = false;
            this.olvSymptoms.ShowGroups = false;
            this.olvSymptoms.Size = new System.Drawing.Size(304, 463);
            this.olvSymptoms.TabIndex = 1;
            this.olvSymptoms.UseCompatibleStateImageBehavior = false;
            this.olvSymptoms.View = System.Windows.Forms.View.Details;
            this.olvSymptoms.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.olvSymptoms_ItemChecked);
            // 
            // olvColSymptom
            // 
            this.olvColSymptom.AspectName = "Symptom";
            this.olvColSymptom.FillsFreeSpace = true;
            this.olvColSymptom.Groupable = false;
            this.olvColSymptom.Text = "Symptom";
            this.olvColSymptom.Width = 200;
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoEllipsis = true;
            this.lblSymptoms.BackColor = System.Drawing.Color.Black;
            this.lblSymptoms.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSymptoms.ForeColor = System.Drawing.Color.White;
            this.lblSymptoms.Location = new System.Drawing.Point(0, 0);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(304, 17);
            this.lblSymptoms.TabIndex = 0;
            this.lblSymptoms.Text = "Symptom(s)";
            this.lblSymptoms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSymptomsDivider
            // 
            this.lblSymptomsDivider.BackColor = System.Drawing.Color.Black;
            this.lblSymptomsDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSymptomsDivider.Location = new System.Drawing.Point(0, 480);
            this.lblSymptomsDivider.Name = "lblSymptomsDivider";
            this.lblSymptomsDivider.Size = new System.Drawing.Size(304, 1);
            this.lblSymptomsDivider.TabIndex = 2;
            // 
            // pnlSymptoms_Other
            // 
            this.pnlSymptoms_Other.Controls.Add(this.txtSymptoms_Other);
            this.pnlSymptoms_Other.Controls.Add(this.lblSymptoms_Other);
            this.pnlSymptoms_Other.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSymptoms_Other.Location = new System.Drawing.Point(0, 481);
            this.pnlSymptoms_Other.Name = "pnlSymptoms_Other";
            this.pnlSymptoms_Other.Size = new System.Drawing.Size(304, 34);
            this.pnlSymptoms_Other.TabIndex = 2;
            this.pnlSymptoms_Other.Visible = false;
            // 
            // txtSymptoms_Other
            // 
            this.txtSymptoms_Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSymptoms_Other.Location = new System.Drawing.Point(36, 0);
            this.txtSymptoms_Other.MaxLength = 80;
            this.txtSymptoms_Other.Multiline = true;
            this.txtSymptoms_Other.Name = "txtSymptoms_Other";
            this.txtSymptoms_Other.Size = new System.Drawing.Size(268, 34);
            this.txtSymptoms_Other.TabIndex = 1;
            // 
            // lblSymptoms_Other
            // 
            this.lblSymptoms_Other.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSymptoms_Other.Location = new System.Drawing.Point(0, 0);
            this.lblSymptoms_Other.Name = "lblSymptoms_Other";
            this.lblSymptoms_Other.Size = new System.Drawing.Size(36, 34);
            this.lblSymptoms_Other.TabIndex = 0;
            this.lblSymptoms_Other.Text = "Other:";
            this.lblSymptoms_Other.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAssetDetails
            // 
            this.pnlAssetDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlAssetDetails.Controls.Add(this.txtAssetNotes);
            this.pnlAssetDetails.Controls.Add(this.lblAssetNotes);
            this.pnlAssetDetails.Controls.Add(this.txtAssetServiceReminder);
            this.pnlAssetDetails.Controls.Add(this.lblAssetServiceReminder);
            this.pnlAssetDetails.Controls.Add(this.lblAssetDetails);
            this.pnlAssetDetails.Controls.Add(this.txtCustomer);
            this.pnlAssetDetails.Controls.Add(this.lblCustomer);
            this.pnlAssetDetails.Controls.Add(this.txtMarket);
            this.pnlAssetDetails.Controls.Add(this.lblMarket);
            this.pnlAssetDetails.Controls.Add(this.ucWarrantyStatus);
            this.pnlAssetDetails.Controls.Add(this.txtAsset);
            this.pnlAssetDetails.Controls.Add(this.txtPanel);
            this.pnlAssetDetails.Controls.Add(this.txtAssetLocation);
            this.pnlAssetDetails.Controls.Add(this.lblAsset);
            this.pnlAssetDetails.Controls.Add(this.lblPanel);
            this.pnlAssetDetails.Controls.Add(this.lblAssetLocation);
            this.pnlAssetDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlAssetDetails.Name = "pnlAssetDetails";
            this.pnlAssetDetails.Size = new System.Drawing.Size(304, 676);
            this.pnlAssetDetails.TabIndex = 0;
            // 
            // txtAssetNotes
            // 
            this.txtAssetNotes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAssetNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssetNotes.Location = new System.Drawing.Point(10, 354);
            this.txtAssetNotes.Multiline = true;
            this.txtAssetNotes.Name = "txtAssetNotes";
            this.txtAssetNotes.ReadOnly = true;
            this.txtAssetNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAssetNotes.Size = new System.Drawing.Size(287, 233);
            this.txtAssetNotes.TabIndex = 15;
            this.txtAssetNotes.TabStop = false;
            // 
            // lblAssetNotes
            // 
            this.lblAssetNotes.AutoSize = true;
            this.lblAssetNotes.Location = new System.Drawing.Point(7, 338);
            this.lblAssetNotes.Name = "lblAssetNotes";
            this.lblAssetNotes.Size = new System.Drawing.Size(64, 13);
            this.lblAssetNotes.TabIndex = 14;
            this.lblAssetNotes.Text = "Asset Notes";
            // 
            // txtAssetServiceReminder
            // 
            this.txtAssetServiceReminder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAssetServiceReminder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssetServiceReminder.Location = new System.Drawing.Point(65, 176);
            this.txtAssetServiceReminder.Multiline = true;
            this.txtAssetServiceReminder.Name = "txtAssetServiceReminder";
            this.txtAssetServiceReminder.ReadOnly = true;
            this.txtAssetServiceReminder.Size = new System.Drawing.Size(232, 130);
            this.txtAssetServiceReminder.TabIndex = 12;
            this.txtAssetServiceReminder.TabStop = false;
            // 
            // lblAssetServiceReminder
            // 
            this.lblAssetServiceReminder.AutoSize = true;
            this.lblAssetServiceReminder.Location = new System.Drawing.Point(7, 179);
            this.lblAssetServiceReminder.Name = "lblAssetServiceReminder";
            this.lblAssetServiceReminder.Size = new System.Drawing.Size(52, 26);
            this.lblAssetServiceReminder.TabIndex = 11;
            this.lblAssetServiceReminder.Text = "Service\r\nReminder";
            this.lblAssetServiceReminder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAssetDetails
            // 
            this.lblAssetDetails.AutoEllipsis = true;
            this.lblAssetDetails.BackColor = System.Drawing.Color.Black;
            this.lblAssetDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssetDetails.ForeColor = System.Drawing.Color.White;
            this.lblAssetDetails.Location = new System.Drawing.Point(0, 0);
            this.lblAssetDetails.Name = "lblAssetDetails";
            this.lblAssetDetails.Size = new System.Drawing.Size(304, 17);
            this.lblAssetDetails.TabIndex = 0;
            this.lblAssetDetails.Text = "Asset Details";
            this.lblAssetDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Location = new System.Drawing.Point(65, 50);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(232, 20);
            this.txtCustomer.TabIndex = 4;
            this.txtCustomer.TabStop = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(8, 53);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer";
            // 
            // txtMarket
            // 
            this.txtMarket.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMarket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarket.Location = new System.Drawing.Point(65, 74);
            this.txtMarket.Name = "txtMarket";
            this.txtMarket.ReadOnly = true;
            this.txtMarket.Size = new System.Drawing.Size(232, 20);
            this.txtMarket.TabIndex = 6;
            this.txtMarket.TabStop = false;
            // 
            // lblMarket
            // 
            this.lblMarket.AutoSize = true;
            this.lblMarket.Location = new System.Drawing.Point(19, 77);
            this.lblMarket.Name = "lblMarket";
            this.lblMarket.Size = new System.Drawing.Size(40, 13);
            this.lblMarket.TabIndex = 5;
            this.lblMarket.Text = "Market";
            // 
            // txtAsset
            // 
            this.txtAsset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset.Location = new System.Drawing.Point(65, 20);
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.ReadOnly = true;
            this.txtAsset.Size = new System.Drawing.Size(232, 26);
            this.txtAsset.TabIndex = 2;
            this.txtAsset.TabStop = false;
            // 
            // txtPanel
            // 
            this.txtPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPanel.Location = new System.Drawing.Point(65, 98);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.ReadOnly = true;
            this.txtPanel.Size = new System.Drawing.Size(232, 20);
            this.txtPanel.TabIndex = 8;
            this.txtPanel.TabStop = false;
            // 
            // txtAssetLocation
            // 
            this.txtAssetLocation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtAssetLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssetLocation.Location = new System.Drawing.Point(65, 122);
            this.txtAssetLocation.Multiline = true;
            this.txtAssetLocation.Name = "txtAssetLocation";
            this.txtAssetLocation.ReadOnly = true;
            this.txtAssetLocation.Size = new System.Drawing.Size(232, 48);
            this.txtAssetLocation.TabIndex = 10;
            this.txtAssetLocation.TabStop = false;
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsset.Location = new System.Drawing.Point(12, 28);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(47, 13);
            this.lblAsset.TabIndex = 1;
            this.lblAsset.Text = "ASSET";
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Location = new System.Drawing.Point(25, 101);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(34, 13);
            this.lblPanel.TabIndex = 7;
            this.lblPanel.Text = "Panel";
            // 
            // lblAssetLocation
            // 
            this.lblAssetLocation.AutoSize = true;
            this.lblAssetLocation.Location = new System.Drawing.Point(11, 125);
            this.lblAssetLocation.Name = "lblAssetLocation";
            this.lblAssetLocation.Size = new System.Drawing.Size(48, 13);
            this.lblAssetLocation.TabIndex = 9;
            this.lblAssetLocation.Text = "Location";
            // 
            // dtpDateReceived
            // 
            this.dtpDateReceived.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDateReceived.Enabled = false;
            this.dtpDateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReceived.Location = new System.Drawing.Point(6, 36);
            this.dtpDateReceived.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtpDateReceived.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateReceived.Name = "dtpDateReceived";
            this.dtpDateReceived.Size = new System.Drawing.Size(141, 20);
            this.dtpDateReceived.TabIndex = 2;
            // 
            // txtIssueNum
            // 
            this.txtIssueNum.Location = new System.Drawing.Point(153, 36);
            this.txtIssueNum.MaxLength = 6;
            this.txtIssueNum.Name = "txtIssueNum";
            this.txtIssueNum.Size = new System.Drawing.Size(135, 20);
            this.txtIssueNum.TabIndex = 4;
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.AutoSize = true;
            this.lblDateOpened.Location = new System.Drawing.Point(3, 20);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(74, 13);
            this.lblDateOpened.TabIndex = 1;
            this.lblDateOpened.Text = "Date Opened:";
            // 
            // lblIssueNumber
            // 
            this.lblIssueNumber.AutoSize = true;
            this.lblIssueNumber.Location = new System.Drawing.Point(150, 20);
            this.lblIssueNumber.Name = "lblIssueNumber";
            this.lblIssueNumber.Size = new System.Drawing.Size(122, 13);
            this.lblIssueNumber.TabIndex = 3;
            this.lblIssueNumber.Text = "Customer Issue Number:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(850, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnTicketImage_Webcam
            // 
            this.btnTicketImage_Webcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTicketImage_Webcam.Location = new System.Drawing.Point(6, 20);
            this.btnTicketImage_Webcam.Name = "btnTicketImage_Webcam";
            this.btnTicketImage_Webcam.Size = new System.Drawing.Size(82, 25);
            this.btnTicketImage_Webcam.TabIndex = 1;
            this.btnTicketImage_Webcam.Text = "Webcam";
            this.toolTip1.SetToolTip(this.btnTicketImage_Webcam, "Attach an image from the webcam (if applicable).");
            this.btnTicketImage_Webcam.UseVisualStyleBackColor = false;
            this.btnTicketImage_Webcam.Click += new System.EventHandler(this.btnTicketImage_Webcam_Click);
            // 
            // btnTicketImage_File
            // 
            this.btnTicketImage_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTicketImage_File.Location = new System.Drawing.Point(94, 20);
            this.btnTicketImage_File.Name = "btnTicketImage_File";
            this.btnTicketImage_File.Size = new System.Drawing.Size(82, 25);
            this.btnTicketImage_File.TabIndex = 2;
            this.btnTicketImage_File.Text = "File";
            this.toolTip1.SetToolTip(this.btnTicketImage_File, "Attach an image from a file.");
            this.btnTicketImage_File.UseVisualStyleBackColor = false;
            this.btnTicketImage_File.Click += new System.EventHandler(this.btnTicketImage_File_Click);
            // 
            // chkEmail_SendOpen
            // 
            this.chkEmail_SendOpen.AutoSize = true;
            this.chkEmail_SendOpen.Checked = true;
            this.chkEmail_SendOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail_SendOpen.ForeColor = System.Drawing.Color.Black;
            this.chkEmail_SendOpen.Location = new System.Drawing.Point(87, 125);
            this.chkEmail_SendOpen.Name = "chkEmail_SendOpen";
            this.chkEmail_SendOpen.Size = new System.Drawing.Size(158, 17);
            this.chkEmail_SendOpen.TabIndex = 9;
            this.chkEmail_SendOpen.Text = "Send OPEN email to market";
            this.chkEmail_SendOpen.UseVisualStyleBackColor = true;
            this.chkEmail_SendOpen.CheckedChanged += new System.EventHandler(this.chkEmail_SendOpen_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(747, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.BackColor = System.Drawing.Color.LightGray;
            this.pnlImage.Controls.Add(this.lblOpenTicketImage);
            this.pnlImage.Controls.Add(this.btnTicketImage_Clear);
            this.pnlImage.Controls.Add(this.lblCameraError);
            this.pnlImage.Controls.Add(this.lblCameraProcessing);
            this.pnlImage.Controls.Add(this.btnTicketImage_Webcam);
            this.pnlImage.Controls.Add(this.btnTicketImage_File);
            this.pnlImage.Controls.Add(this.pbImage);
            this.pnlImage.Location = new System.Drawing.Point(632, 466);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(304, 222);
            this.pnlImage.TabIndex = 4;
            this.pnlImage.Text = "Open Ticket Image";
            // 
            // lblOpenTicketImage
            // 
            this.lblOpenTicketImage.AutoEllipsis = true;
            this.lblOpenTicketImage.BackColor = System.Drawing.Color.Black;
            this.lblOpenTicketImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOpenTicketImage.ForeColor = System.Drawing.Color.White;
            this.lblOpenTicketImage.Location = new System.Drawing.Point(0, 0);
            this.lblOpenTicketImage.Name = "lblOpenTicketImage";
            this.lblOpenTicketImage.Size = new System.Drawing.Size(304, 17);
            this.lblOpenTicketImage.TabIndex = 0;
            this.lblOpenTicketImage.Text = "Open Ticket Image";
            this.lblOpenTicketImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTicketImage_Clear
            // 
            this.btnTicketImage_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTicketImage_Clear.Location = new System.Drawing.Point(216, 20);
            this.btnTicketImage_Clear.Name = "btnTicketImage_Clear";
            this.btnTicketImage_Clear.Size = new System.Drawing.Size(82, 25);
            this.btnTicketImage_Clear.TabIndex = 3;
            this.btnTicketImage_Clear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnTicketImage_Clear, "Remove image.");
            this.btnTicketImage_Clear.UseVisualStyleBackColor = false;
            this.btnTicketImage_Clear.Click += new System.EventHandler(this.btnTicketImage_Clear_Click);
            // 
            // lblCameraError
            // 
            this.lblCameraError.AutoSize = true;
            this.lblCameraError.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCameraError.Location = new System.Drawing.Point(62, 126);
            this.lblCameraError.Name = "lblCameraError";
            this.lblCameraError.Size = new System.Drawing.Size(180, 15);
            this.lblCameraError.TabIndex = 5;
            this.lblCameraError.Text = "Error acquiring camera image.";
            this.lblCameraError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCameraError.Visible = false;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnlDetails.Controls.Add(this.lblTicketDetails);
            this.pnlDetails.Controls.Add(this.chkEmail_SendOpen);
            this.pnlDetails.Controls.Add(this.lblDateOpened);
            this.pnlDetails.Controls.Add(this.dtpDateReceived);
            this.pnlDetails.Controls.Add(this.lblIssueNumber);
            this.pnlDetails.Controls.Add(this.cmbReportType);
            this.pnlDetails.Controls.Add(this.txtReportedBy);
            this.pnlDetails.Controls.Add(this.txtIssueNum);
            this.pnlDetails.Controls.Add(this.lblReportedType);
            this.pnlDetails.Controls.Add(this.lblReportedBy);
            this.pnlDetails.Location = new System.Drawing.Point(322, 12);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(304, 155);
            this.pnlDetails.TabIndex = 1;
            this.pnlDetails.Text = "Ticket Details";
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.AutoEllipsis = true;
            this.lblTicketDetails.BackColor = System.Drawing.Color.Black;
            this.lblTicketDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicketDetails.ForeColor = System.Drawing.Color.White;
            this.lblTicketDetails.Location = new System.Drawing.Point(0, 0);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(304, 17);
            this.lblTicketDetails.TabIndex = 0;
            this.lblTicketDetails.Text = "Ticket Details";
            this.lblTicketDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Silver;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnCreate);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 694);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(950, 32);
            this.pnlBottom.TabIndex = 5;
            // 
            // pnlMarketNotes
            // 
            this.pnlMarketNotes.Controls.Add(this.txtMarketNotes);
            this.pnlMarketNotes.Controls.Add(this.lblMarketNotes);
            this.pnlMarketNotes.Location = new System.Drawing.Point(632, 314);
            this.pnlMarketNotes.Name = "pnlMarketNotes";
            this.pnlMarketNotes.Size = new System.Drawing.Size(304, 146);
            this.pnlMarketNotes.TabIndex = 6;
            // 
            // txtMarketNotes
            // 
            this.txtMarketNotes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtMarketNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarketNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarketNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketNotes.Location = new System.Drawing.Point(0, 17);
            this.txtMarketNotes.MaxLength = 1024;
            this.txtMarketNotes.Multiline = true;
            this.txtMarketNotes.Name = "txtMarketNotes";
            this.txtMarketNotes.ReadOnly = true;
            this.txtMarketNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMarketNotes.Size = new System.Drawing.Size(304, 129);
            this.txtMarketNotes.TabIndex = 6;
            // 
            // lblMarketNotes
            // 
            this.lblMarketNotes.AutoEllipsis = true;
            this.lblMarketNotes.BackColor = System.Drawing.Color.Black;
            this.lblMarketNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMarketNotes.ForeColor = System.Drawing.Color.White;
            this.lblMarketNotes.Location = new System.Drawing.Point(0, 0);
            this.lblMarketNotes.Name = "lblMarketNotes";
            this.lblMarketNotes.Size = new System.Drawing.Size(304, 17);
            this.lblMarketNotes.TabIndex = 1;
            this.lblMarketNotes.Text = "Market Notes";
            this.lblMarketNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.grpOSAPriority);
            this.panel1.Controls.Add(this.cmbTechList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxSendOSA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtbOsaNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(634, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 296);
            this.panel1.TabIndex = 10;
            this.panel1.Text = "Ticket Details";
            // 
            // grpOSAPriority
            // 
            this.grpOSAPriority.Controls.Add(this.radCritical);
            this.grpOSAPriority.Controls.Add(this.radNormal);
            this.grpOSAPriority.Controls.Add(this.radHigh);
            this.grpOSAPriority.Location = new System.Drawing.Point(7, 89);
            this.grpOSAPriority.Name = "grpOSAPriority";
            this.grpOSAPriority.Size = new System.Drawing.Size(286, 88);
            this.grpOSAPriority.TabIndex = 10;
            this.grpOSAPriority.TabStop = false;
            this.grpOSAPriority.Text = "OSA Priority";
            // 
            // radCritical
            // 
            this.radCritical.AutoSize = true;
            this.radCritical.Location = new System.Drawing.Point(32, 18);
            this.radCritical.Name = "radCritical";
            this.radCritical.Size = new System.Drawing.Size(247, 17);
            this.radCritical.TabIndex = 7;
            this.radCritical.TabStop = true;
            this.radCritical.Text = "Critical (4 HOURS OR LESS / >50% OUTAGE)";
            this.radCritical.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(34, 64);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(172, 17);
            this.radNormal.TabIndex = 9;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal (24 HOURS / NO O.T.)";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Location = new System.Drawing.Point(34, 41);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(195, 17);
            this.radHigh.TabIndex = 8;
            this.radHigh.TabStop = true;
            this.radHigh.Text = "High (12 HOURS / >10% OUTAGE)";
            this.radHigh.UseVisualStyleBackColor = true;
            // 
            // cmbTechList
            // 
            this.cmbTechList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechList.Enabled = false;
            this.cmbTechList.FormattingEnabled = true;
            this.cmbTechList.Location = new System.Drawing.Point(7, 62);
            this.cmbTechList.Name = "cmbTechList";
            this.cmbTechList.Size = new System.Drawing.Size(286, 21);
            this.cmbTechList.Sorted = true;
            this.cmbTechList.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Tech";
            // 
            // cbxSendOSA
            // 
            this.cbxSendOSA.AutoSize = true;
            this.cbxSendOSA.Location = new System.Drawing.Point(7, 26);
            this.cbxSendOSA.Name = "cbxSendOSA";
            this.cbxSendOSA.Size = new System.Drawing.Size(76, 17);
            this.cbxSendOSA.TabIndex = 4;
            this.cbxSendOSA.Text = "Send OSA";
            this.cbxSendOSA.UseVisualStyleBackColor = true;
            this.cbxSendOSA.CheckedChanged += new System.EventHandler(this.cbxSendOSA_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OSA Note:";
            // 
            // rtbOsaNote
            // 
            this.rtbOsaNote.Location = new System.Drawing.Point(3, 196);
            this.rtbOsaNote.Name = "rtbOsaNote";
            this.rtbOsaNote.ReadOnly = true;
            this.rtbOsaNote.Size = new System.Drawing.Size(298, 97);
            this.rtbOsaNote.TabIndex = 1;
            this.rtbOsaNote.Text = "";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OSA Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCameraProcessing
            // 
            this.lblCameraProcessing.BackColor = System.Drawing.Color.Transparent;
            this.lblCameraProcessing.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraProcessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCameraProcessing.Image = ((System.Drawing.Image)(resources.GetObject("lblCameraProcessing.Image")));
            this.lblCameraProcessing.Location = new System.Drawing.Point(82, 113);
            this.lblCameraProcessing.Name = "lblCameraProcessing";
            this.lblCameraProcessing.Size = new System.Drawing.Size(140, 41);
            this.lblCameraProcessing.TabIndex = 4;
            this.lblCameraProcessing.Text = "Getting Camera Image";
            this.lblCameraProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCameraProcessing.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(6, 50);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(292, 166);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 24;
            this.pbImage.TabStop = false;
            // 
            // ucWarrantyStatus
            // 
            this.ucWarrantyStatus.BackColor = System.Drawing.Color.Transparent;
            this.ucWarrantyStatus.Location = new System.Drawing.Point(41, 603);
            this.ucWarrantyStatus.Name = "ucWarrantyStatus";
            this.ucWarrantyStatus.Size = new System.Drawing.Size(223, 57);
            this.ucWarrantyStatus.TabIndex = 16;
            // 
            // FormTicket_Create
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(950, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMarketNotes);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlSymptoms);
            this.Controls.Add(this.pnlAssetDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTicket_Create";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Ticket";
            this.Load += new System.EventHandler(this.FormTicket_Create_Load);
            this.Shown += new System.EventHandler(this.FormTicket_Create_Shown);
            this.pnlSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).EndInit();
            this.pnlSymptoms_Other.ResumeLayout(false);
            this.pnlSymptoms_Other.PerformLayout();
            this.pnlAssetDetails.ResumeLayout(false);
            this.pnlAssetDetails.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMarketNotes.ResumeLayout(false);
            this.pnlMarketNotes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpOSAPriority.ResumeLayout(false);
            this.grpOSAPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Panel pnlDetails;
		private System.Windows.Forms.Panel pnlSymptoms;
		private System.Windows.Forms.Panel pnlAssetDetails;
		private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.TextBox txtReportedBy;
        private System.Windows.Forms.Label lblReportedType;
		private System.Windows.Forms.Label lblReportedBy;
		private System.Windows.Forms.TextBox txtIssueNum;
        private System.Windows.Forms.TextBox txtAsset;
		private System.Windows.Forms.TextBox txtPanel;
        private System.Windows.Forms.TextBox txtAssetLocation;
		private System.Windows.Forms.Label lblAsset;
		private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.Label lblIssueNumber;
		private System.Windows.Forms.Label lblAssetLocation;
		private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTicketImage_Webcam;
        private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btnTicketImage_File;
		private System.Windows.Forms.CheckBox chkEmail_SendOpen;
		private System.Windows.Forms.Button btnCancel;
		private WarrantyStatus ucWarrantyStatus;
		private System.Windows.Forms.DateTimePicker dtpDateReceived;
		private System.Windows.Forms.Label lblCameraProcessing;
		private BrightIdeasSoftware.ObjectListView olvSymptoms;
		private BrightIdeasSoftware.OLVColumn olvColSymptom;
		private System.Windows.Forms.Panel pnlSymptoms_Other;
		private System.Windows.Forms.Label lblSymptoms_Other;
		private System.Windows.Forms.TextBox txtSymptoms_Other;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.Label lblCustomer;
		private System.Windows.Forms.TextBox txtMarket;
		private System.Windows.Forms.Label lblMarket;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblSymptomsDivider;
		private System.Windows.Forms.Label lblCameraError;
		private System.Windows.Forms.Button btnTicketImage_Clear;
		private System.Windows.Forms.Label lblAssetDetails;
		private System.Windows.Forms.Label lblSymptoms;
		private System.Windows.Forms.Label lblOpenTicketImage;
		private System.Windows.Forms.Label lblTicketDetails;
		private System.Windows.Forms.TextBox txtAssetServiceReminder;
		private System.Windows.Forms.Label lblAssetServiceReminder;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.TextBox txtAssetNotes;
		private System.Windows.Forms.Label lblAssetNotes;
        private System.Windows.Forms.Panel pnlMarketNotes;
        private System.Windows.Forms.TextBox txtMarketNotes;
        private System.Windows.Forms.Label lblMarketNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxSendOSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbOsaNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTechList;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.RadioButton radCritical;
        private System.Windows.Forms.GroupBox grpOSAPriority;
    }
}