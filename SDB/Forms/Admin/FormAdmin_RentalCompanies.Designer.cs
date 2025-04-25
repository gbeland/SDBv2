namespace SDB.Forms.Admin
{
	partial class FormAdmin_RentalCompanies
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRentalCompanies = new System.Windows.Forms.TabPage();
            this.pnlRentalCompany_Editor = new System.Windows.Forms.Panel();
            this.btnRentalDivision_Delete = new System.Windows.Forms.Button();
            this.lblDivisionEditHelp = new System.Windows.Forms.Label();
            this.btnRentalDivision_Add = new System.Windows.Forms.Button();
            this.btnRentalCompany_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnRentalCompany_Editor_Save = new System.Windows.Forms.Button();
            this.olvRentalDivisions = new BrightIdeasSoftware.ObjectListView();
            this.olcDivisionName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDivisionTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlNumberFormats = new System.Windows.Forms.Panel();
            this.lblFormat_PickupNumber = new System.Windows.Forms.Label();
            this.lblNumberFormatHelp = new System.Windows.Forms.Label();
            this.lblFormat_EquipmentNumber = new System.Windows.Forms.Label();
            this.lblReservationNumber = new System.Windows.Forms.Label();
            this.lblFormat_ReservationNumber = new System.Windows.Forms.Label();
            this.txtFormat_ReservationNumber = new System.Windows.Forms.TextBox();
            this.chkUse_PickupNumber = new System.Windows.Forms.CheckBox();
            this.chkUse_ReservationNumber = new System.Windows.Forms.CheckBox();
            this.txtFormat_PickupNumber = new System.Windows.Forms.TextBox();
            this.lblEquipmentNumber = new System.Windows.Forms.Label();
            this.lblPickupNumber = new System.Windows.Forms.Label();
            this.txtFormat_EquipmentNumber = new System.Windows.Forms.TextBox();
            this.chkUse_EquipmentNumber = new System.Windows.Forms.CheckBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtRentalCompany_Name = new System.Windows.Forms.TextBox();
            this.lblRentalCompany_Name = new System.Windows.Forms.Label();
            this.olvRentalCompanies = new BrightIdeasSoftware.ObjectListView();
            this.olcRentalCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAccount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlRentalCompanies_Control = new System.Windows.Forms.Panel();
            this.btnRentalCompany_Delete = new System.Windows.Forms.Button();
            this.btnRentalCompany_Edit = new System.Windows.Forms.Button();
            this.btnRentalCompany_Add = new System.Windows.Forms.Button();
            this.tabLiftTypes = new System.Windows.Forms.TabPage();
            this.pnlLiftType_Editor = new System.Windows.Forms.Panel();
            this.txtLiftType_Description = new System.Windows.Forms.TextBox();
            this.lblLiftType_Description = new System.Windows.Forms.Label();
            this.btnLiftType_Editor_Cancel = new System.Windows.Forms.Button();
            this.btnLiftType_Editor_Save = new System.Windows.Forms.Button();
            this.olvLiftTypes = new BrightIdeasSoftware.ObjectListView();
            this.olcLiftType_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlLiftTypes_Control = new System.Windows.Forms.Panel();
            this.btnLiftType_Delete = new System.Windows.Forms.Button();
            this.btnLiftType_Edit = new System.Windows.Forms.Button();
            this.btnLiftType_Add = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRentalCompanies.SuspendLayout();
            this.pnlRentalCompany_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).BeginInit();
            this.pnlNumberFormats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).BeginInit();
            this.pnlRentalCompanies_Control.SuspendLayout();
            this.tabLiftTypes.SuspendLayout();
            this.pnlLiftType_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLiftTypes)).BeginInit();
            this.pnlLiftTypes_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRentalCompanies);
            this.tabControl1.Controls.Add(this.tabLiftTypes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRentalCompanies
            // 
            this.tabRentalCompanies.Controls.Add(this.pnlRentalCompany_Editor);
            this.tabRentalCompanies.Controls.Add(this.olvRentalCompanies);
            this.tabRentalCompanies.Controls.Add(this.pnlRentalCompanies_Control);
            this.tabRentalCompanies.Location = new System.Drawing.Point(4, 22);
            this.tabRentalCompanies.Name = "tabRentalCompanies";
            this.tabRentalCompanies.Padding = new System.Windows.Forms.Padding(3);
            this.tabRentalCompanies.Size = new System.Drawing.Size(781, 404);
            this.tabRentalCompanies.TabIndex = 0;
            this.tabRentalCompanies.Text = "Rental Companies";
            this.tabRentalCompanies.UseVisualStyleBackColor = true;
            // 
            // pnlRentalCompany_Editor
            // 
            this.pnlRentalCompany_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalDivision_Delete);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblDivisionEditHelp);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalDivision_Add);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalCompany_Editor_Cancel);
            this.pnlRentalCompany_Editor.Controls.Add(this.btnRentalCompany_Editor_Save);
            this.pnlRentalCompany_Editor.Controls.Add(this.olvRentalDivisions);
            this.pnlRentalCompany_Editor.Controls.Add(this.pnlNumberFormats);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtTelephoneNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblTelephoneNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtAccountNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblAccountNumber);
            this.pnlRentalCompany_Editor.Controls.Add(this.txtRentalCompany_Name);
            this.pnlRentalCompany_Editor.Controls.Add(this.lblRentalCompany_Name);
            this.pnlRentalCompany_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentalCompany_Editor.Location = new System.Drawing.Point(3, 33);
            this.pnlRentalCompany_Editor.Name = "pnlRentalCompany_Editor";
            this.pnlRentalCompany_Editor.Size = new System.Drawing.Size(775, 368);
            this.pnlRentalCompany_Editor.TabIndex = 1;
            this.pnlRentalCompany_Editor.Visible = false;
            // 
            // btnRentalDivision_Delete
            // 
            this.btnRentalDivision_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentalDivision_Delete.Location = new System.Drawing.Point(109, 98);
            this.btnRentalDivision_Delete.Name = "btnRentalDivision_Delete";
            this.btnRentalDivision_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnRentalDivision_Delete.TabIndex = 8;
            this.btnRentalDivision_Delete.Text = "Delete Division";
            this.btnRentalDivision_Delete.UseVisualStyleBackColor = false;
            this.btnRentalDivision_Delete.Click += new System.EventHandler(this.btnRentalDivision_Delete_Click);
            // 
            // lblDivisionEditHelp
            // 
            this.lblDivisionEditHelp.AutoSize = true;
            this.lblDivisionEditHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisionEditHelp.Location = new System.Drawing.Point(12, 342);
            this.lblDivisionEditHelp.Name = "lblDivisionEditHelp";
            this.lblDivisionEditHelp.Size = new System.Drawing.Size(250, 13);
            this.lblDivisionEditHelp.TabIndex = 12;
            this.lblDivisionEditHelp.Text = "Double-click or press F2 to edit Division information.";
            // 
            // btnRentalDivision_Add
            // 
            this.btnRentalDivision_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRentalDivision_Add.Location = new System.Drawing.Point(3, 98);
            this.btnRentalDivision_Add.Name = "btnRentalDivision_Add";
            this.btnRentalDivision_Add.Size = new System.Drawing.Size(100, 23);
            this.btnRentalDivision_Add.TabIndex = 7;
            this.btnRentalDivision_Add.Text = "Add Division";
            this.btnRentalDivision_Add.UseVisualStyleBackColor = false;
            this.btnRentalDivision_Add.Click += new System.EventHandler(this.btnRentalDivision_Add_Click);
            // 
            // btnRentalCompany_Editor_Cancel
            // 
            this.btnRentalCompany_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentalCompany_Editor_Cancel.Location = new System.Drawing.Point(566, 342);
            this.btnRentalCompany_Editor_Cancel.Name = "btnRentalCompany_Editor_Cancel";
            this.btnRentalCompany_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Editor_Cancel.TabIndex = 11;
            this.btnRentalCompany_Editor_Cancel.Text = "Cancel";
            this.btnRentalCompany_Editor_Cancel.UseVisualStyleBackColor = true;
            this.btnRentalCompany_Editor_Cancel.Click += new System.EventHandler(this.btnRentalCompany_Editor_Cancel_Click);
            // 
            // btnRentalCompany_Editor_Save
            // 
            this.btnRentalCompany_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentalCompany_Editor_Save.Location = new System.Drawing.Point(672, 342);
            this.btnRentalCompany_Editor_Save.Name = "btnRentalCompany_Editor_Save";
            this.btnRentalCompany_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Editor_Save.TabIndex = 10;
            this.btnRentalCompany_Editor_Save.Text = "Save";
            this.btnRentalCompany_Editor_Save.UseVisualStyleBackColor = true;
            this.btnRentalCompany_Editor_Save.Click += new System.EventHandler(this.btnRentalCompany_Editor_Save_Click);
            // 
            // olvRentalDivisions
            // 
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionName);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionAddress);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionCity);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionState);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionZip);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionCountry);
            this.olvRentalDivisions.AllColumns.Add(this.olcDivisionTelephone);
            this.olvRentalDivisions.AllowColumnReorder = true;
            this.olvRentalDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvRentalDivisions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvRentalDivisions.CellEditUseWholeCell = false;
            this.olvRentalDivisions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDivisionName,
            this.olcDivisionAddress,
            this.olcDivisionCity,
            this.olcDivisionState,
            this.olcDivisionZip,
            this.olcDivisionCountry,
            this.olcDivisionTelephone});
            this.olvRentalDivisions.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRentalDivisions.EmptyListMsg = "No divisions.";
            this.olvRentalDivisions.FullRowSelect = true;
            this.olvRentalDivisions.GridLines = true;
            this.olvRentalDivisions.HideSelection = false;
            this.olvRentalDivisions.Location = new System.Drawing.Point(3, 127);
            this.olvRentalDivisions.MultiSelect = false;
            this.olvRentalDivisions.Name = "olvRentalDivisions";
            this.olvRentalDivisions.SelectAllOnControlA = false;
            this.olvRentalDivisions.ShowGroups = false;
            this.olvRentalDivisions.Size = new System.Drawing.Size(769, 209);
            this.olvRentalDivisions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvRentalDivisions.TabIndex = 9;
            this.olvRentalDivisions.UseCompatibleStateImageBehavior = false;
            this.olvRentalDivisions.UseOverlays = false;
            this.olvRentalDivisions.View = System.Windows.Forms.View.Details;
            // 
            // olcDivisionName
            // 
            this.olcDivisionName.AspectName = "Name";
            this.olcDivisionName.Text = "Division";
            this.olcDivisionName.Width = 150;
            // 
            // olcDivisionAddress
            // 
            this.olcDivisionAddress.AspectName = "Address";
            this.olcDivisionAddress.Text = "Address";
            this.olcDivisionAddress.Width = 140;
            // 
            // olcDivisionCity
            // 
            this.olcDivisionCity.AspectName = "City";
            this.olcDivisionCity.Text = "City";
            this.olcDivisionCity.Width = 100;
            // 
            // olcDivisionState
            // 
            this.olcDivisionState.AspectName = "State";
            this.olcDivisionState.Text = "State";
            // 
            // olcDivisionZip
            // 
            this.olcDivisionZip.AspectName = "Zip";
            this.olcDivisionZip.Text = "Zip";
            this.olcDivisionZip.Width = 75;
            // 
            // olcDivisionCountry
            // 
            this.olcDivisionCountry.AspectName = "Country";
            this.olcDivisionCountry.Text = "Country";
            this.olcDivisionCountry.Width = 100;
            // 
            // olcDivisionTelephone
            // 
            this.olcDivisionTelephone.AspectName = "Telephone";
            this.olcDivisionTelephone.Text = "Telephone";
            this.olcDivisionTelephone.Width = 100;
            // 
            // pnlNumberFormats
            // 
            this.pnlNumberFormats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNumberFormats.Controls.Add(this.lblFormat_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.lblNumberFormatHelp);
            this.pnlNumberFormats.Controls.Add(this.lblFormat_EquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.lblReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.lblFormat_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_ReservationNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_PickupNumber);
            this.pnlNumberFormats.Controls.Add(this.lblEquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.lblPickupNumber);
            this.pnlNumberFormats.Controls.Add(this.txtFormat_EquipmentNumber);
            this.pnlNumberFormats.Controls.Add(this.chkUse_EquipmentNumber);
            this.pnlNumberFormats.Location = new System.Drawing.Point(282, 6);
            this.pnlNumberFormats.Name = "pnlNumberFormats";
            this.pnlNumberFormats.Size = new System.Drawing.Size(490, 98);
            this.pnlNumberFormats.TabIndex = 6;
            // 
            // lblFormat_PickupNumber
            // 
            this.lblFormat_PickupNumber.AutoSize = true;
            this.lblFormat_PickupNumber.Enabled = false;
            this.lblFormat_PickupNumber.Location = new System.Drawing.Point(248, 42);
            this.lblFormat_PickupNumber.Name = "lblFormat_PickupNumber";
            this.lblFormat_PickupNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_PickupNumber.TabIndex = 10;
            this.lblFormat_PickupNumber.Text = "Format";
            // 
            // lblNumberFormatHelp
            // 
            this.lblNumberFormatHelp.AutoSize = true;
            this.lblNumberFormatHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumberFormatHelp.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberFormatHelp.Location = new System.Drawing.Point(379, 0);
            this.lblNumberFormatHelp.Name = "lblNumberFormatHelp";
            this.lblNumberFormatHelp.Size = new System.Drawing.Size(109, 91);
            this.lblNumberFormatHelp.TabIndex = 12;
            this.lblNumberFormatHelp.Text = "# = Number\r\nX = Letter\r\n* = Any Character\r\n. = Period\r\n- = Hyphen\r\n? = No Validat" +
    "ion\r\nSpaces as-is.";
            // 
            // lblFormat_EquipmentNumber
            // 
            this.lblFormat_EquipmentNumber.AutoSize = true;
            this.lblFormat_EquipmentNumber.Enabled = false;
            this.lblFormat_EquipmentNumber.Location = new System.Drawing.Point(124, 42);
            this.lblFormat_EquipmentNumber.Name = "lblFormat_EquipmentNumber";
            this.lblFormat_EquipmentNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_EquipmentNumber.TabIndex = 6;
            this.lblFormat_EquipmentNumber.Text = "Format";
            // 
            // lblReservationNumber
            // 
            this.lblReservationNumber.AutoSize = true;
            this.lblReservationNumber.Location = new System.Drawing.Point(3, 6);
            this.lblReservationNumber.Name = "lblReservationNumber";
            this.lblReservationNumber.Size = new System.Drawing.Size(104, 13);
            this.lblReservationNumber.TabIndex = 0;
            this.lblReservationNumber.Text = "Reservation Number";
            // 
            // lblFormat_ReservationNumber
            // 
            this.lblFormat_ReservationNumber.AutoSize = true;
            this.lblFormat_ReservationNumber.Enabled = false;
            this.lblFormat_ReservationNumber.Location = new System.Drawing.Point(3, 42);
            this.lblFormat_ReservationNumber.Name = "lblFormat_ReservationNumber";
            this.lblFormat_ReservationNumber.Size = new System.Drawing.Size(39, 13);
            this.lblFormat_ReservationNumber.TabIndex = 2;
            this.lblFormat_ReservationNumber.Text = "Format";
            // 
            // txtFormat_ReservationNumber
            // 
            this.txtFormat_ReservationNumber.Enabled = false;
            this.txtFormat_ReservationNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_ReservationNumber.Location = new System.Drawing.Point(3, 58);
            this.txtFormat_ReservationNumber.MaxLength = 16;
            this.txtFormat_ReservationNumber.Name = "txtFormat_ReservationNumber";
            this.txtFormat_ReservationNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_ReservationNumber.TabIndex = 3;
            this.txtFormat_ReservationNumber.TextChanged += new System.EventHandler(this.txtFormat_ReservationNumber_TextChanged);
            this.txtFormat_ReservationNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // chkUse_PickupNumber
            // 
            this.chkUse_PickupNumber.AutoSize = true;
            this.chkUse_PickupNumber.Location = new System.Drawing.Point(251, 22);
            this.chkUse_PickupNumber.Name = "chkUse_PickupNumber";
            this.chkUse_PickupNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_PickupNumber.TabIndex = 9;
            this.chkUse_PickupNumber.Text = "Use";
            this.chkUse_PickupNumber.UseVisualStyleBackColor = true;
            this.chkUse_PickupNumber.CheckedChanged += new System.EventHandler(this.chkUse_PickupNumber_CheckedChanged);
            // 
            // chkUse_ReservationNumber
            // 
            this.chkUse_ReservationNumber.AutoSize = true;
            this.chkUse_ReservationNumber.Location = new System.Drawing.Point(6, 22);
            this.chkUse_ReservationNumber.Name = "chkUse_ReservationNumber";
            this.chkUse_ReservationNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_ReservationNumber.TabIndex = 1;
            this.chkUse_ReservationNumber.Text = "Use";
            this.chkUse_ReservationNumber.UseVisualStyleBackColor = true;
            this.chkUse_ReservationNumber.CheckedChanged += new System.EventHandler(this.chkUse_ReservationNumber_CheckedChanged);
            // 
            // txtFormat_PickupNumber
            // 
            this.txtFormat_PickupNumber.Enabled = false;
            this.txtFormat_PickupNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_PickupNumber.Location = new System.Drawing.Point(251, 58);
            this.txtFormat_PickupNumber.MaxLength = 16;
            this.txtFormat_PickupNumber.Name = "txtFormat_PickupNumber";
            this.txtFormat_PickupNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_PickupNumber.TabIndex = 11;
            this.txtFormat_PickupNumber.TextChanged += new System.EventHandler(this.txtFormat_PickupNumber_TextChanged);
            this.txtFormat_PickupNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblEquipmentNumber
            // 
            this.lblEquipmentNumber.AutoSize = true;
            this.lblEquipmentNumber.Location = new System.Drawing.Point(124, 6);
            this.lblEquipmentNumber.Name = "lblEquipmentNumber";
            this.lblEquipmentNumber.Size = new System.Drawing.Size(97, 13);
            this.lblEquipmentNumber.TabIndex = 4;
            this.lblEquipmentNumber.Text = "Equipment Number";
            // 
            // lblPickupNumber
            // 
            this.lblPickupNumber.AutoSize = true;
            this.lblPickupNumber.Location = new System.Drawing.Point(248, 6);
            this.lblPickupNumber.Name = "lblPickupNumber";
            this.lblPickupNumber.Size = new System.Drawing.Size(83, 13);
            this.lblPickupNumber.TabIndex = 8;
            this.lblPickupNumber.Text = "Pick-up Number";
            // 
            // txtFormat_EquipmentNumber
            // 
            this.txtFormat_EquipmentNumber.Enabled = false;
            this.txtFormat_EquipmentNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormat_EquipmentNumber.Location = new System.Drawing.Point(127, 58);
            this.txtFormat_EquipmentNumber.MaxLength = 16;
            this.txtFormat_EquipmentNumber.Name = "txtFormat_EquipmentNumber";
            this.txtFormat_EquipmentNumber.Size = new System.Drawing.Size(118, 23);
            this.txtFormat_EquipmentNumber.TabIndex = 7;
            this.txtFormat_EquipmentNumber.TextChanged += new System.EventHandler(this.txtFormat_EquipmentNumber_TextChanged);
            this.txtFormat_EquipmentNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // chkUse_EquipmentNumber
            // 
            this.chkUse_EquipmentNumber.AutoSize = true;
            this.chkUse_EquipmentNumber.Location = new System.Drawing.Point(127, 22);
            this.chkUse_EquipmentNumber.Name = "chkUse_EquipmentNumber";
            this.chkUse_EquipmentNumber.Size = new System.Drawing.Size(45, 17);
            this.chkUse_EquipmentNumber.TabIndex = 5;
            this.chkUse_EquipmentNumber.Text = "Use";
            this.chkUse_EquipmentNumber.UseVisualStyleBackColor = true;
            this.chkUse_EquipmentNumber.CheckedChanged += new System.EventHandler(this.chkUse_EquipmentNumber_CheckedChanged);
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(142, 58);
            this.txtTelephoneNumber.MaxLength = 20;
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(116, 20);
            this.txtTelephoneNumber.TabIndex = 5;
            this.txtTelephoneNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(12, 61);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(124, 13);
            this.lblTelephoneNumber.TabIndex = 4;
            this.lblTelephoneNumber.Text = "Main Telephone Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(142, 32);
            this.txtAccountNumber.MaxLength = 20;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(116, 20);
            this.txtAccountNumber.TabIndex = 3;
            this.txtAccountNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 35);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(107, 13);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "Account #";
            // 
            // txtRentalCompany_Name
            // 
            this.txtRentalCompany_Name.Location = new System.Drawing.Point(69, 6);
            this.txtRentalCompany_Name.MaxLength = 45;
            this.txtRentalCompany_Name.Name = "txtRentalCompany_Name";
            this.txtRentalCompany_Name.Size = new System.Drawing.Size(189, 20);
            this.txtRentalCompany_Name.TabIndex = 1;
            this.txtRentalCompany_Name.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblRentalCompany_Name
            // 
            this.lblRentalCompany_Name.AutoSize = true;
            this.lblRentalCompany_Name.Location = new System.Drawing.Point(12, 9);
            this.lblRentalCompany_Name.Name = "lblRentalCompany_Name";
            this.lblRentalCompany_Name.Size = new System.Drawing.Size(51, 13);
            this.lblRentalCompany_Name.TabIndex = 0;
            this.lblRentalCompany_Name.Text = "Company";
            // 
            // olvRentalCompanies
            // 
            this.olvRentalCompanies.AllColumns.Add(this.olcRentalCompany);
            this.olvRentalCompanies.AllColumns.Add(this.olcAccount);
            this.olvRentalCompanies.AllColumns.Add(this.olcTelephone);
            this.olvRentalCompanies.AllowColumnReorder = true;
            this.olvRentalCompanies.CellEditUseWholeCell = false;
            this.olvRentalCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcRentalCompany,
            this.olcAccount,
            this.olcTelephone});
            this.olvRentalCompanies.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRentalCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvRentalCompanies.EmptyListMsg = "No rental companies.";
            this.olvRentalCompanies.FullRowSelect = true;
            this.olvRentalCompanies.GridLines = true;
            this.olvRentalCompanies.HideSelection = false;
            this.olvRentalCompanies.Location = new System.Drawing.Point(3, 33);
            this.olvRentalCompanies.MultiSelect = false;
            this.olvRentalCompanies.Name = "olvRentalCompanies";
            this.olvRentalCompanies.SelectAllOnControlA = false;
            this.olvRentalCompanies.ShowGroups = false;
            this.olvRentalCompanies.Size = new System.Drawing.Size(775, 368);
            this.olvRentalCompanies.TabIndex = 0;
            this.olvRentalCompanies.UseCompatibleStateImageBehavior = false;
            this.olvRentalCompanies.UseOverlays = false;
            this.olvRentalCompanies.View = System.Windows.Forms.View.Details;
            this.olvRentalCompanies.SelectionChanged += new System.EventHandler(this.olvRentalCompanies_SelectionChanged);
            this.olvRentalCompanies.DoubleClick += new System.EventHandler(this.olvRentalCompanies_DoubleClick);
            // 
            // olcRentalCompany
            // 
            this.olcRentalCompany.AspectName = "Company";
            this.olcRentalCompany.Text = "Rental Company";
            this.olcRentalCompany.Width = 300;
            // 
            // olcAccount
            // 
            this.olcAccount.AspectName = "AccountNumber";
            this.olcAccount.Text = "Account";
            this.olcAccount.Width = 100;
            // 
            // olcTelephone
            // 
            this.olcTelephone.AspectName = "Telephone";
            this.olcTelephone.Text = "Telephone";
            this.olcTelephone.Width = 100;
            // 
            // pnlRentalCompanies_Control
            // 
            this.pnlRentalCompanies_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Delete);
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Edit);
            this.pnlRentalCompanies_Control.Controls.Add(this.btnRentalCompany_Add);
            this.pnlRentalCompanies_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRentalCompanies_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlRentalCompanies_Control.Name = "pnlRentalCompanies_Control";
            this.pnlRentalCompanies_Control.Size = new System.Drawing.Size(775, 30);
            this.pnlRentalCompanies_Control.TabIndex = 0;
            // 
            // btnRentalCompany_Delete
            // 
            this.btnRentalCompany_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRentalCompany_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnRentalCompany_Delete.Name = "btnRentalCompany_Delete";
            this.btnRentalCompany_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Delete.TabIndex = 1;
            this.btnRentalCompany_Delete.Text = "Delete Company";
            this.btnRentalCompany_Delete.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Delete.Click += new System.EventHandler(this.btnRentalCompany_Delete_Click);
            // 
            // btnRentalCompany_Edit
            // 
            this.btnRentalCompany_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnRentalCompany_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnRentalCompany_Edit.Name = "btnRentalCompany_Edit";
            this.btnRentalCompany_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Edit.TabIndex = 2;
            this.btnRentalCompany_Edit.Text = "Edit Company";
            this.btnRentalCompany_Edit.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Edit.Click += new System.EventHandler(this.btnRentalCompany_Edit_Click);
            // 
            // btnRentalCompany_Add
            // 
            this.btnRentalCompany_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRentalCompany_Add.Location = new System.Drawing.Point(3, 4);
            this.btnRentalCompany_Add.Name = "btnRentalCompany_Add";
            this.btnRentalCompany_Add.Size = new System.Drawing.Size(100, 23);
            this.btnRentalCompany_Add.TabIndex = 0;
            this.btnRentalCompany_Add.Text = "Add Company";
            this.btnRentalCompany_Add.UseVisualStyleBackColor = false;
            this.btnRentalCompany_Add.Click += new System.EventHandler(this.btnRentalCompany_Add_Click);
            // 
            // tabLiftTypes
            // 
            this.tabLiftTypes.Controls.Add(this.pnlLiftType_Editor);
            this.tabLiftTypes.Controls.Add(this.olvLiftTypes);
            this.tabLiftTypes.Controls.Add(this.pnlLiftTypes_Control);
            this.tabLiftTypes.Location = new System.Drawing.Point(4, 22);
            this.tabLiftTypes.Name = "tabLiftTypes";
            this.tabLiftTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabLiftTypes.Size = new System.Drawing.Size(781, 404);
            this.tabLiftTypes.TabIndex = 1;
            this.tabLiftTypes.Text = "Lift Types";
            this.tabLiftTypes.UseVisualStyleBackColor = true;
            // 
            // pnlLiftType_Editor
            // 
            this.pnlLiftType_Editor.BackColor = System.Drawing.Color.LightGray;
            this.pnlLiftType_Editor.Controls.Add(this.txtLiftType_Description);
            this.pnlLiftType_Editor.Controls.Add(this.lblLiftType_Description);
            this.pnlLiftType_Editor.Controls.Add(this.btnLiftType_Editor_Cancel);
            this.pnlLiftType_Editor.Controls.Add(this.btnLiftType_Editor_Save);
            this.pnlLiftType_Editor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLiftType_Editor.Location = new System.Drawing.Point(3, 301);
            this.pnlLiftType_Editor.Name = "pnlLiftType_Editor";
            this.pnlLiftType_Editor.Size = new System.Drawing.Size(775, 100);
            this.pnlLiftType_Editor.TabIndex = 2;
            this.pnlLiftType_Editor.Visible = false;
            // 
            // txtLiftType_Description
            // 
            this.txtLiftType_Description.Location = new System.Drawing.Point(94, 22);
            this.txtLiftType_Description.MaxLength = 32;
            this.txtLiftType_Description.Name = "txtLiftType_Description";
            this.txtLiftType_Description.Size = new System.Drawing.Size(189, 20);
            this.txtLiftType_Description.TabIndex = 1;
            this.txtLiftType_Description.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblLiftType_Description
            // 
            this.lblLiftType_Description.AutoSize = true;
            this.lblLiftType_Description.Location = new System.Drawing.Point(28, 25);
            this.lblLiftType_Description.Name = "lblLiftType_Description";
            this.lblLiftType_Description.Size = new System.Drawing.Size(60, 13);
            this.lblLiftType_Description.TabIndex = 0;
            this.lblLiftType_Description.Text = "Description";
            // 
            // btnLiftType_Editor_Cancel
            // 
            this.btnLiftType_Editor_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiftType_Editor_Cancel.Location = new System.Drawing.Point(566, 74);
            this.btnLiftType_Editor_Cancel.Name = "btnLiftType_Editor_Cancel";
            this.btnLiftType_Editor_Cancel.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Editor_Cancel.TabIndex = 3;
            this.btnLiftType_Editor_Cancel.Text = "Cancel";
            this.btnLiftType_Editor_Cancel.UseVisualStyleBackColor = true;
            this.btnLiftType_Editor_Cancel.Click += new System.EventHandler(this.btnLiftType_Editor_Cancel_Click);
            // 
            // btnLiftType_Editor_Save
            // 
            this.btnLiftType_Editor_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiftType_Editor_Save.Location = new System.Drawing.Point(672, 74);
            this.btnLiftType_Editor_Save.Name = "btnLiftType_Editor_Save";
            this.btnLiftType_Editor_Save.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Editor_Save.TabIndex = 2;
            this.btnLiftType_Editor_Save.Text = "Save";
            this.btnLiftType_Editor_Save.UseVisualStyleBackColor = true;
            this.btnLiftType_Editor_Save.Click += new System.EventHandler(this.btnLiftType_Editor_Save_Click);
            // 
            // olvLiftTypes
            // 
            this.olvLiftTypes.AllColumns.Add(this.olcLiftType_Description);
            this.olvLiftTypes.AllowColumnReorder = true;
            this.olvLiftTypes.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvLiftTypes.CellEditUseWholeCell = false;
            this.olvLiftTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcLiftType_Description});
            this.olvLiftTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvLiftTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvLiftTypes.EmptyListMsg = "No lift types.";
            this.olvLiftTypes.FullRowSelect = true;
            this.olvLiftTypes.GridLines = true;
            this.olvLiftTypes.HideSelection = false;
            this.olvLiftTypes.Location = new System.Drawing.Point(3, 33);
            this.olvLiftTypes.MultiSelect = false;
            this.olvLiftTypes.Name = "olvLiftTypes";
            this.olvLiftTypes.SelectAllOnControlA = false;
            this.olvLiftTypes.ShowGroups = false;
            this.olvLiftTypes.Size = new System.Drawing.Size(775, 368);
            this.olvLiftTypes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvLiftTypes.TabIndex = 1;
            this.olvLiftTypes.UseCompatibleStateImageBehavior = false;
            this.olvLiftTypes.UseOverlays = false;
            this.olvLiftTypes.View = System.Windows.Forms.View.Details;
            this.olvLiftTypes.SelectedIndexChanged += new System.EventHandler(this.olvLiftTypes_SelectedIndexChanged);
            this.olvLiftTypes.DoubleClick += new System.EventHandler(this.olvLiftTypes_DoubleClick);
            // 
            // olcLiftType_Description
            // 
            this.olcLiftType_Description.AspectName = "Description";
            this.olcLiftType_Description.Text = "Description";
            this.olcLiftType_Description.Width = 300;
            // 
            // pnlLiftTypes_Control
            // 
            this.pnlLiftTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Delete);
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Edit);
            this.pnlLiftTypes_Control.Controls.Add(this.btnLiftType_Add);
            this.pnlLiftTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLiftTypes_Control.Location = new System.Drawing.Point(3, 3);
            this.pnlLiftTypes_Control.Name = "pnlLiftTypes_Control";
            this.pnlLiftTypes_Control.Size = new System.Drawing.Size(775, 30);
            this.pnlLiftTypes_Control.TabIndex = 0;
            // 
            // btnLiftType_Delete
            // 
            this.btnLiftType_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLiftType_Delete.Location = new System.Drawing.Point(109, 4);
            this.btnLiftType_Delete.Name = "btnLiftType_Delete";
            this.btnLiftType_Delete.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Delete.TabIndex = 1;
            this.btnLiftType_Delete.Text = "Delete Lift Type";
            this.btnLiftType_Delete.UseVisualStyleBackColor = false;
            this.btnLiftType_Delete.Click += new System.EventHandler(this.btnLiftType_Delete_Click);
            // 
            // btnLiftType_Edit
            // 
            this.btnLiftType_Edit.BackColor = System.Drawing.SystemColors.Control;
            this.btnLiftType_Edit.Location = new System.Drawing.Point(215, 4);
            this.btnLiftType_Edit.Name = "btnLiftType_Edit";
            this.btnLiftType_Edit.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Edit.TabIndex = 2;
            this.btnLiftType_Edit.Text = "Edit Lift Type";
            this.btnLiftType_Edit.UseVisualStyleBackColor = false;
            this.btnLiftType_Edit.Click += new System.EventHandler(this.btnLiftType_Edit_Click);
            // 
            // btnLiftType_Add
            // 
            this.btnLiftType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLiftType_Add.Location = new System.Drawing.Point(3, 4);
            this.btnLiftType_Add.Name = "btnLiftType_Add";
            this.btnLiftType_Add.Size = new System.Drawing.Size(100, 23);
            this.btnLiftType_Add.TabIndex = 0;
            this.btnLiftType_Add.Text = "Add Lift Type";
            this.btnLiftType_Add.UseVisualStyleBackColor = false;
            this.btnLiftType_Add.Click += new System.EventHandler(this.btnLiftType_Add_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(701, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAdmin_RentalCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(813, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin_RentalCompanies";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rental Companies / Settings";
            this.Load += new System.EventHandler(this.FormAdmin_RentalCompanies_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRentalCompanies.ResumeLayout(false);
            this.pnlRentalCompany_Editor.ResumeLayout(false);
            this.pnlRentalCompany_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).EndInit();
            this.pnlNumberFormats.ResumeLayout(false);
            this.pnlNumberFormats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).EndInit();
            this.pnlRentalCompanies_Control.ResumeLayout(false);
            this.tabLiftTypes.ResumeLayout(false);
            this.pnlLiftType_Editor.ResumeLayout(false);
            this.pnlLiftType_Editor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvLiftTypes)).EndInit();
            this.pnlLiftTypes_Control.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabRentalCompanies;
		private System.Windows.Forms.TabPage tabLiftTypes;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlRentalCompany_Editor;
		private BrightIdeasSoftware.ObjectListView olvRentalCompanies;
		private System.Windows.Forms.Panel pnlRentalCompanies_Control;
		private System.Windows.Forms.Button btnRentalCompany_Delete;
		private System.Windows.Forms.Button btnRentalCompany_Edit;
		private System.Windows.Forms.Button btnRentalCompany_Add;
		private BrightIdeasSoftware.OLVColumn olcRentalCompany;
		private BrightIdeasSoftware.OLVColumn olcAccount;
		private BrightIdeasSoftware.OLVColumn olcTelephone;
		private System.Windows.Forms.CheckBox chkUse_PickupNumber;
		private System.Windows.Forms.TextBox txtFormat_PickupNumber;
		private System.Windows.Forms.Label lblPickupNumber;
		private System.Windows.Forms.CheckBox chkUse_EquipmentNumber;
		private System.Windows.Forms.TextBox txtFormat_EquipmentNumber;
		private System.Windows.Forms.Label lblEquipmentNumber;
		private System.Windows.Forms.CheckBox chkUse_ReservationNumber;
		private System.Windows.Forms.TextBox txtFormat_ReservationNumber;
		private System.Windows.Forms.Label lblReservationNumber;
		private System.Windows.Forms.TextBox txtTelephoneNumber;
		private System.Windows.Forms.Label lblTelephoneNumber;
		private System.Windows.Forms.TextBox txtAccountNumber;
		private System.Windows.Forms.Label lblAccountNumber;
		private System.Windows.Forms.TextBox txtRentalCompany_Name;
		private System.Windows.Forms.Label lblRentalCompany_Name;
		private System.Windows.Forms.Panel pnlNumberFormats;
		private System.Windows.Forms.Label lblNumberFormatHelp;
		private System.Windows.Forms.Label lblFormat_PickupNumber;
		private System.Windows.Forms.Label lblFormat_EquipmentNumber;
		private System.Windows.Forms.Label lblFormat_ReservationNumber;
		private BrightIdeasSoftware.ObjectListView olvRentalDivisions;
		private BrightIdeasSoftware.OLVColumn olcDivisionName;
		private BrightIdeasSoftware.OLVColumn olcDivisionAddress;
		private BrightIdeasSoftware.OLVColumn olcDivisionCity;
		private BrightIdeasSoftware.OLVColumn olcDivisionState;
		private BrightIdeasSoftware.OLVColumn olcDivisionZip;
		private BrightIdeasSoftware.OLVColumn olcDivisionCountry;
		private BrightIdeasSoftware.OLVColumn olcDivisionTelephone;
		private System.Windows.Forms.Button btnRentalCompany_Editor_Save;
		private System.Windows.Forms.Button btnRentalCompany_Editor_Cancel;
		private System.Windows.Forms.Label lblDivisionEditHelp;
		private System.Windows.Forms.Button btnRentalDivision_Delete;
		private System.Windows.Forms.Button btnRentalDivision_Add;
		private BrightIdeasSoftware.ObjectListView olvLiftTypes;
		private BrightIdeasSoftware.OLVColumn olcLiftType_Description;
		private System.Windows.Forms.Panel pnlLiftTypes_Control;
		private System.Windows.Forms.Button btnLiftType_Delete;
		private System.Windows.Forms.Button btnLiftType_Edit;
		private System.Windows.Forms.Button btnLiftType_Add;
		private System.Windows.Forms.Panel pnlLiftType_Editor;
		private System.Windows.Forms.TextBox txtLiftType_Description;
		private System.Windows.Forms.Label lblLiftType_Description;
		private System.Windows.Forms.Button btnLiftType_Editor_Cancel;
		private System.Windows.Forms.Button btnLiftType_Editor_Save;
	}
}