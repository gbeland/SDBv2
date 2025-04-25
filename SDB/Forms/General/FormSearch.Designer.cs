namespace SDB.Forms.General
{
	partial class FormSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.lblAssets = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTickets = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lblTechs = new System.Windows.Forms.Label();
            this.dgvTechs = new System.Windows.Forms.DataGridView();
            this.lblAssetCount = new System.Windows.Forms.Label();
            this.lblTicketCount = new System.Windows.Forms.Label();
            this.lblTechsCount = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTechStatus = new System.Windows.Forms.Panel();
            this.lblTechsBorder = new System.Windows.Forms.Label();
            this.pnlTicketStatus = new System.Windows.Forms.Panel();
            this.lblTicketsBorder = new System.Windows.Forms.Label();
            this.pnlAssetStatus = new System.Windows.Forms.Panel();
            this.lblAssetsBorder = new System.Windows.Forms.Label();
            this.colTechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechContact1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechContact2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTechContact3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketOpenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketCloseDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketTimeOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketSymptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketTech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTicketReported = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetFacing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetLaborWC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetPartsWC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetLaborContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetPartsContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetMatrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssetPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechs)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTechStatus.SuspendLayout();
            this.pnlTicketStatus.SuspendLayout();
            this.pnlAssetStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.AllowUserToDeleteRows = false;
            this.dgvAssets.AllowUserToResizeRows = false;
            this.dgvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssets.CausesValidation = false;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssetName,
            this.colAssetPanel,
            this.colAssetLocation,
            this.colAssetFacing,
            this.colAssetCity,
            this.colAssetState,
            this.colAssetRelease,
            this.colAssetSerial,
            this.colAssetLaborWC,
            this.colAssetPartsWC,
            this.colAssetLaborContract,
            this.colAssetPartsContract,
            this.colAssetMatrix,
            this.colAssetPitch});
            this.dgvAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAssets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAssets.Location = new System.Drawing.Point(0, 22);
            this.dgvAssets.MinimumSize = new System.Drawing.Size(1000, 40);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowHeadersWidth = 20;
            this.dgvAssets.ShowCellErrors = false;
            this.dgvAssets.ShowCellToolTips = false;
            this.dgvAssets.ShowEditingIcon = false;
            this.dgvAssets.ShowRowErrors = false;
            this.dgvAssets.Size = new System.Drawing.Size(1398, 40);
            this.dgvAssets.TabIndex = 0;
            this.dgvAssets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellDoubleClick);
            // 
            // lblAssets
            // 
            this.lblAssets.AutoSize = true;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.Location = new System.Drawing.Point(3, 3);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(59, 16);
            this.lblAssets.TabIndex = 1;
            this.lblAssets.Text = "Assets:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1335, 733);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(3, 3);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(63, 16);
            this.lblTickets.TabIndex = 5;
            this.lblTickets.Text = "Tickets:";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AllowUserToResizeRows = false;
            this.dgvTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTickets.CausesValidation = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTicketNumber,
            this.colTicketIssue,
            this.colTicketAsset,
            this.colTicketPanel,
            this.colTicketOpenDT,
            this.colTicketCloseDT,
            this.colTicketTimeOpen,
            this.colTicketSymptoms,
            this.colTicketSolution,
            this.colTicketTech,
            this.colTicketReported});
            this.dgvTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTickets.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTickets.Location = new System.Drawing.Point(0, 84);
            this.dgvTickets.MinimumSize = new System.Drawing.Size(1000, 40);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.RowHeadersWidth = 20;
            this.dgvTickets.ShowCellErrors = false;
            this.dgvTickets.ShowCellToolTips = false;
            this.dgvTickets.ShowEditingIcon = false;
            this.dgvTickets.ShowRowErrors = false;
            this.dgvTickets.Size = new System.Drawing.Size(1398, 40);
            this.dgvTickets.TabIndex = 4;
            this.dgvTickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellDoubleClick);
            // 
            // lblTechs
            // 
            this.lblTechs.AutoSize = true;
            this.lblTechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechs.Location = new System.Drawing.Point(3, 3);
            this.lblTechs.Name = "lblTechs";
            this.lblTechs.Size = new System.Drawing.Size(55, 16);
            this.lblTechs.TabIndex = 7;
            this.lblTechs.Text = "Techs:";
            // 
            // dgvTechs
            // 
            this.dgvTechs.AllowUserToAddRows = false;
            this.dgvTechs.AllowUserToDeleteRows = false;
            this.dgvTechs.AllowUserToResizeRows = false;
            this.dgvTechs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTechs.CausesValidation = false;
            this.dgvTechs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTechName,
            this.colTechAddress,
            this.colCity,
            this.colTechState,
            this.colTechZip,
            this.colTechPhone,
            this.colTechContact1,
            this.colTechContact2,
            this.colTechContact3});
            this.dgvTechs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTechs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTechs.Location = new System.Drawing.Point(0, 146);
            this.dgvTechs.MinimumSize = new System.Drawing.Size(1000, 40);
            this.dgvTechs.MultiSelect = false;
            this.dgvTechs.Name = "dgvTechs";
            this.dgvTechs.ReadOnly = true;
            this.dgvTechs.RowHeadersVisible = false;
            this.dgvTechs.RowHeadersWidth = 20;
            this.dgvTechs.ShowCellErrors = false;
            this.dgvTechs.ShowCellToolTips = false;
            this.dgvTechs.ShowEditingIcon = false;
            this.dgvTechs.ShowRowErrors = false;
            this.dgvTechs.Size = new System.Drawing.Size(1398, 40);
            this.dgvTechs.TabIndex = 6;
            this.dgvTechs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechs_CellDoubleClick);
            // 
            // lblAssetCount
            // 
            this.lblAssetCount.AutoSize = true;
            this.lblAssetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetCount.Location = new System.Drawing.Point(64, 3);
            this.lblAssetCount.Name = "lblAssetCount";
            this.lblAssetCount.Size = new System.Drawing.Size(15, 16);
            this.lblAssetCount.TabIndex = 8;
            this.lblAssetCount.Text = "0";
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.AutoSize = true;
            this.lblTicketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCount.Location = new System.Drawing.Point(68, 3);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(15, 16);
            this.lblTicketCount.TabIndex = 9;
            this.lblTicketCount.Text = "0";
            // 
            // lblTechsCount
            // 
            this.lblTechsCount.AutoSize = true;
            this.lblTechsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechsCount.Location = new System.Drawing.Point(60, 3);
            this.lblTechsCount.Name = "lblTechsCount";
            this.lblTechsCount.Size = new System.Drawing.Size(15, 16);
            this.lblTechsCount.TabIndex = 10;
            this.lblTechsCount.Text = "0";
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.dgvTechs);
            this.pnlMain.Controls.Add(this.pnlTechStatus);
            this.pnlMain.Controls.Add(this.dgvTickets);
            this.pnlMain.Controls.Add(this.pnlTicketStatus);
            this.pnlMain.Controls.Add(this.dgvAssets);
            this.pnlMain.Controls.Add(this.pnlAssetStatus);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1398, 705);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlTechStatus
            // 
            this.pnlTechStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTechStatus.Controls.Add(this.lblTechsBorder);
            this.pnlTechStatus.Controls.Add(this.lblTechs);
            this.pnlTechStatus.Controls.Add(this.lblTechsCount);
            this.pnlTechStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTechStatus.Location = new System.Drawing.Point(0, 124);
            this.pnlTechStatus.MinimumSize = new System.Drawing.Size(1000, 22);
            this.pnlTechStatus.Name = "pnlTechStatus";
            this.pnlTechStatus.Size = new System.Drawing.Size(1398, 22);
            this.pnlTechStatus.TabIndex = 13;
            // 
            // lblTechsBorder
            // 
            this.lblTechsBorder.BackColor = System.Drawing.Color.Black;
            this.lblTechsBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTechsBorder.Location = new System.Drawing.Point(0, 0);
            this.lblTechsBorder.Name = "lblTechsBorder";
            this.lblTechsBorder.Size = new System.Drawing.Size(1398, 2);
            this.lblTechsBorder.TabIndex = 11;
            // 
            // pnlTicketStatus
            // 
            this.pnlTicketStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTicketStatus.Controls.Add(this.lblTicketsBorder);
            this.pnlTicketStatus.Controls.Add(this.lblTickets);
            this.pnlTicketStatus.Controls.Add(this.lblTicketCount);
            this.pnlTicketStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTicketStatus.Location = new System.Drawing.Point(0, 62);
            this.pnlTicketStatus.MinimumSize = new System.Drawing.Size(1000, 22);
            this.pnlTicketStatus.Name = "pnlTicketStatus";
            this.pnlTicketStatus.Size = new System.Drawing.Size(1398, 22);
            this.pnlTicketStatus.TabIndex = 12;
            // 
            // lblTicketsBorder
            // 
            this.lblTicketsBorder.BackColor = System.Drawing.Color.Black;
            this.lblTicketsBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicketsBorder.Location = new System.Drawing.Point(0, 0);
            this.lblTicketsBorder.Name = "lblTicketsBorder";
            this.lblTicketsBorder.Size = new System.Drawing.Size(1398, 2);
            this.lblTicketsBorder.TabIndex = 10;
            // 
            // pnlAssetStatus
            // 
            this.pnlAssetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssetStatus.Controls.Add(this.lblAssetsBorder);
            this.pnlAssetStatus.Controls.Add(this.lblAssets);
            this.pnlAssetStatus.Controls.Add(this.lblAssetCount);
            this.pnlAssetStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssetStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlAssetStatus.MinimumSize = new System.Drawing.Size(1000, 22);
            this.pnlAssetStatus.Name = "pnlAssetStatus";
            this.pnlAssetStatus.Size = new System.Drawing.Size(1398, 22);
            this.pnlAssetStatus.TabIndex = 11;
            // 
            // lblAssetsBorder
            // 
            this.lblAssetsBorder.BackColor = System.Drawing.Color.Black;
            this.lblAssetsBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssetsBorder.Location = new System.Drawing.Point(0, 0);
            this.lblAssetsBorder.Name = "lblAssetsBorder";
            this.lblAssetsBorder.Size = new System.Drawing.Size(1398, 2);
            this.lblAssetsBorder.TabIndex = 9;
            // 
            // colTechName
            // 
            this.colTechName.HeaderText = "Name";
            this.colTechName.Name = "colTechName";
            this.colTechName.ReadOnly = true;
            this.colTechName.Width = 180;
            // 
            // colTechAddress
            // 
            this.colTechAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTechAddress.HeaderText = "Address";
            this.colTechAddress.Name = "colTechAddress";
            this.colTechAddress.ReadOnly = true;
            // 
            // colCity
            // 
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            this.colCity.ReadOnly = true;
            this.colCity.Width = 110;
            // 
            // colTechState
            // 
            this.colTechState.HeaderText = "State";
            this.colTechState.Name = "colTechState";
            this.colTechState.ReadOnly = true;
            this.colTechState.Width = 50;
            // 
            // colTechZip
            // 
            this.colTechZip.HeaderText = "Zip";
            this.colTechZip.Name = "colTechZip";
            this.colTechZip.ReadOnly = true;
            this.colTechZip.Width = 80;
            // 
            // colTechPhone
            // 
            this.colTechPhone.HeaderText = "Phone";
            this.colTechPhone.Name = "colTechPhone";
            this.colTechPhone.ReadOnly = true;
            this.colTechPhone.Width = 120;
            // 
            // colTechContact1
            // 
            this.colTechContact1.HeaderText = "Contact 1";
            this.colTechContact1.Name = "colTechContact1";
            this.colTechContact1.ReadOnly = true;
            // 
            // colTechContact2
            // 
            this.colTechContact2.HeaderText = "Contact 2";
            this.colTechContact2.Name = "colTechContact2";
            this.colTechContact2.ReadOnly = true;
            // 
            // colTechContact3
            // 
            this.colTechContact3.HeaderText = "Contact 3";
            this.colTechContact3.Name = "colTechContact3";
            this.colTechContact3.ReadOnly = true;
            // 
            // colTicketNumber
            // 
            this.colTicketNumber.HeaderText = "Ticket";
            this.colTicketNumber.Name = "colTicketNumber";
            this.colTicketNumber.ReadOnly = true;
            this.colTicketNumber.Width = 50;
            // 
            // colTicketIssue
            // 
            this.colTicketIssue.HeaderText = "Issue";
            this.colTicketIssue.Name = "colTicketIssue";
            this.colTicketIssue.ReadOnly = true;
            this.colTicketIssue.Width = 50;
            // 
            // colTicketAsset
            // 
            this.colTicketAsset.HeaderText = "Asset";
            this.colTicketAsset.Name = "colTicketAsset";
            this.colTicketAsset.ReadOnly = true;
            this.colTicketAsset.Width = 70;
            // 
            // colTicketPanel
            // 
            this.colTicketPanel.HeaderText = "Panel";
            this.colTicketPanel.Name = "colTicketPanel";
            this.colTicketPanel.ReadOnly = true;
            this.colTicketPanel.Width = 70;
            // 
            // colTicketOpenDT
            // 
            this.colTicketOpenDT.HeaderText = "Open";
            this.colTicketOpenDT.Name = "colTicketOpenDT";
            this.colTicketOpenDT.ReadOnly = true;
            this.colTicketOpenDT.Width = 110;
            // 
            // colTicketCloseDT
            // 
            this.colTicketCloseDT.HeaderText = "Close";
            this.colTicketCloseDT.Name = "colTicketCloseDT";
            this.colTicketCloseDT.ReadOnly = true;
            this.colTicketCloseDT.Width = 110;
            // 
            // colTicketTimeOpen
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTicketTimeOpen.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTicketTimeOpen.HeaderText = "Time Open";
            this.colTicketTimeOpen.Name = "colTicketTimeOpen";
            this.colTicketTimeOpen.ReadOnly = true;
            this.colTicketTimeOpen.Width = 90;
            // 
            // colTicketSymptoms
            // 
            this.colTicketSymptoms.HeaderText = "Symptoms";
            this.colTicketSymptoms.Name = "colTicketSymptoms";
            this.colTicketSymptoms.ReadOnly = true;
            this.colTicketSymptoms.Width = 120;
            // 
            // colTicketSolution
            // 
            this.colTicketSolution.HeaderText = "Solution";
            this.colTicketSolution.Name = "colTicketSolution";
            this.colTicketSolution.ReadOnly = true;
            this.colTicketSolution.Width = 120;
            // 
            // colTicketTech
            // 
            this.colTicketTech.HeaderText = "Tech";
            this.colTicketTech.Name = "colTicketTech";
            this.colTicketTech.ReadOnly = true;
            // 
            // colTicketReported
            // 
            this.colTicketReported.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTicketReported.HeaderText = "Reported";
            this.colTicketReported.Name = "colTicketReported";
            this.colTicketReported.ReadOnly = true;
            // 
            // colAssetName
            // 
            this.colAssetName.HeaderText = "Asset";
            this.colAssetName.Name = "colAssetName";
            this.colAssetName.ReadOnly = true;
            this.colAssetName.Width = 110;
            // 
            // colAssetPanel
            // 
            this.colAssetPanel.HeaderText = "Panel";
            this.colAssetPanel.Name = "colAssetPanel";
            this.colAssetPanel.ReadOnly = true;
            // 
            // colAssetLocation
            // 
            this.colAssetLocation.HeaderText = "Location";
            this.colAssetLocation.Name = "colAssetLocation";
            this.colAssetLocation.ReadOnly = true;
            this.colAssetLocation.Width = 220;
            // 
            // colAssetFacing
            // 
            this.colAssetFacing.HeaderText = "Facing";
            this.colAssetFacing.Name = "colAssetFacing";
            this.colAssetFacing.ReadOnly = true;
            this.colAssetFacing.Width = 50;
            // 
            // colAssetCity
            // 
            this.colAssetCity.HeaderText = "City";
            this.colAssetCity.Name = "colAssetCity";
            this.colAssetCity.ReadOnly = true;
            this.colAssetCity.Width = 120;
            // 
            // colAssetState
            // 
            this.colAssetState.HeaderText = "State";
            this.colAssetState.Name = "colAssetState";
            this.colAssetState.ReadOnly = true;
            this.colAssetState.Width = 40;
            // 
            // colAssetRelease
            // 
            this.colAssetRelease.HeaderText = "Release";
            this.colAssetRelease.Name = "colAssetRelease";
            this.colAssetRelease.ReadOnly = true;
            this.colAssetRelease.Width = 80;
            // 
            // colAssetSerial
            // 
            this.colAssetSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAssetSerial.HeaderText = "Serial";
            this.colAssetSerial.Name = "colAssetSerial";
            this.colAssetSerial.ReadOnly = true;
            // 
            // colAssetLaborWC
            // 
            this.colAssetLaborWC.HeaderText = "Labor Warranty";
            this.colAssetLaborWC.Name = "colAssetLaborWC";
            this.colAssetLaborWC.ReadOnly = true;
            this.colAssetLaborWC.Width = 80;
            // 
            // colAssetPartsWC
            // 
            this.colAssetPartsWC.HeaderText = "Parts Warranty";
            this.colAssetPartsWC.Name = "colAssetPartsWC";
            this.colAssetPartsWC.ReadOnly = true;
            this.colAssetPartsWC.Width = 80;
            // 
            // colAssetLaborContract
            // 
            this.colAssetLaborContract.HeaderText = "Labor Contract";
            this.colAssetLaborContract.Name = "colAssetLaborContract";
            this.colAssetLaborContract.ReadOnly = true;
            // 
            // colAssetPartsContract
            // 
            this.colAssetPartsContract.HeaderText = "Parts Contract";
            this.colAssetPartsContract.Name = "colAssetPartsContract";
            this.colAssetPartsContract.ReadOnly = true;
            // 
            // colAssetMatrix
            // 
            this.colAssetMatrix.HeaderText = "Matrix";
            this.colAssetMatrix.Name = "colAssetMatrix";
            this.colAssetMatrix.ReadOnly = true;
            this.colAssetMatrix.Width = 70;
            // 
            // colAssetPitch
            // 
            this.colAssetPitch.HeaderText = "Pitch";
            this.colAssetPitch.Name = "colAssetPitch";
            this.colAssetPitch.ReadOnly = true;
            this.colAssetPitch.Width = 60;
            // 
            // FormSearch
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1422, 762);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2048, 2048);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FormSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SDB: Search Results";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResizeEnd += new System.EventHandler(this.FormSearch_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechs)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlTechStatus.ResumeLayout(false);
            this.pnlTechStatus.PerformLayout();
            this.pnlTicketStatus.ResumeLayout(false);
            this.pnlTicketStatus.PerformLayout();
            this.pnlAssetStatus.ResumeLayout(false);
            this.pnlAssetStatus.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAssets;
		private System.Windows.Forms.Label lblAssets;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblTickets;
		private System.Windows.Forms.DataGridView dgvTickets;
		private System.Windows.Forms.Label lblTechs;
		private System.Windows.Forms.DataGridView dgvTechs;
		private System.Windows.Forms.Label lblAssetCount;
		private System.Windows.Forms.Label lblTicketCount;
		private System.Windows.Forms.Label lblTechsCount;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlTechStatus;
		private System.Windows.Forms.Panel pnlTicketStatus;
		private System.Windows.Forms.Panel pnlAssetStatus;
		private System.Windows.Forms.Label lblTechsBorder;
		private System.Windows.Forms.Label lblTicketsBorder;
		private System.Windows.Forms.Label lblAssetsBorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketOpenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketCloseDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketTimeOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketSymptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTicketReported;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechContact1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechContact2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTechContact3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetFacing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetLaborWC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetPartsWC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetLaborContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetPartsContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssetPitch;
    }
}