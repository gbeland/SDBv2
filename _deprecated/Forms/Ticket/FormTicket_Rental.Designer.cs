using SDB.Classes.Misc;

namespace SDB.Forms.Ticket
{
	partial class FormTicket_Rental
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlTicketRental = new System.Windows.Forms.Panel();
			this.pnlRental = new System.Windows.Forms.Panel();
			this.lblRental_PickupFormat = new System.Windows.Forms.Label();
			this.lblRental_EquipmentFormat = new System.Windows.Forms.Label();
			this.lblRental_ReservationFormat = new System.Windows.Forms.Label();
			this.txtRental_Telephone = new System.Windows.Forms.TextBox();
			this.lblRental_Telephone = new System.Windows.Forms.Label();
			this.txtRental_PrismviewAccount = new System.Windows.Forms.TextBox();
			this.lblRental_PrismviewAccount = new System.Windows.Forms.Label();
			this.olvRentalDivisions = new BrightIdeasSoftware.ObjectListView();
			this.olcName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.colCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.lblRental_Pickup_Valid = new System.Windows.Forms.Label();
			this.lblRental_Equipment_Valid = new System.Windows.Forms.Label();
			this.lblRental_Reservation_Valid = new System.Windows.Forms.Label();
			this.lblRental_RentalDivisions = new System.Windows.Forms.Label();
			this.lblRental_Pickup = new System.Windows.Forms.Label();
			this.txtRental_Pickup = new System.Windows.Forms.TextBox();
			this.lblRental_Equipment = new System.Windows.Forms.Label();
			this.txtRental_Equipment = new System.Windows.Forms.TextBox();
			this.lblRental_Reservation = new System.Windows.Forms.Label();
			this.txtRental_Reservation = new System.Windows.Forms.TextBox();
			this.lblRental_LiftHeight = new System.Windows.Forms.Label();
			this.numRental_LiftHeight = new ClassFixedNumericUpDown();
			this.lblRental_LiftType = new System.Windows.Forms.Label();
			this.cmbRental_LiftType = new System.Windows.Forms.ComboBox();
			this.lblRental_RentalCompany = new System.Windows.Forms.Label();
			this.cmbRental_RentalCompany = new System.Windows.Forms.ComboBox();
			this.lblRental = new System.Windows.Forms.Label();
			this.pnlDetails = new System.Windows.Forms.Panel();
			this.txtDetails_AssignedTech = new System.Windows.Forms.TextBox();
			this.lblDetails_AssignedTech = new System.Windows.Forms.Label();
			this.txtDetails_LiftHeight = new System.Windows.Forms.TextBox();
			this.lblDetails_TicketNumber = new System.Windows.Forms.Label();
			this.txtDetails_LiftType = new System.Windows.Forms.TextBox();
			this.txtDetails_TicketNumber = new System.Windows.Forms.TextBox();
			this.txtDetails_Asset_HAGL = new System.Windows.Forms.TextBox();
			this.lblDetails = new System.Windows.Forms.Label();
			this.lblDetails_Asset_LiftHeight = new System.Windows.Forms.Label();
			this.txtDetails_Asset_AssetName = new System.Windows.Forms.TextBox();
			this.lblDetails_Asset_LiftType = new System.Windows.Forms.Label();
			this.lblDetails_AssetName = new System.Windows.Forms.Label();
			this.lblDetails_Asset_HAGL = new System.Windows.Forms.Label();
			this.pnlTicketRental.SuspendLayout();
			this.pnlRental.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numRental_LiftHeight)).BeginInit();
			this.pnlDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(467, 473);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(100, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Start Rental";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(361, 473);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlTicketRental
			// 
			this.pnlTicketRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTicketRental.Controls.Add(this.pnlRental);
			this.pnlTicketRental.Controls.Add(this.pnlDetails);
			this.pnlTicketRental.Location = new System.Drawing.Point(12, 12);
			this.pnlTicketRental.Name = "pnlTicketRental";
			this.pnlTicketRental.Size = new System.Drawing.Size(555, 455);
			this.pnlTicketRental.TabIndex = 2;
			// 
			// pnlRental
			// 
			this.pnlRental.BackColor = System.Drawing.Color.LightGray;
			this.pnlRental.Controls.Add(this.lblRental_PickupFormat);
			this.pnlRental.Controls.Add(this.lblRental_EquipmentFormat);
			this.pnlRental.Controls.Add(this.lblRental_ReservationFormat);
			this.pnlRental.Controls.Add(this.txtRental_Telephone);
			this.pnlRental.Controls.Add(this.lblRental_Telephone);
			this.pnlRental.Controls.Add(this.txtRental_PrismviewAccount);
			this.pnlRental.Controls.Add(this.lblRental_PrismviewAccount);
			this.pnlRental.Controls.Add(this.olvRentalDivisions);
			this.pnlRental.Controls.Add(this.lblRental_Pickup_Valid);
			this.pnlRental.Controls.Add(this.lblRental_Equipment_Valid);
			this.pnlRental.Controls.Add(this.lblRental_Reservation_Valid);
			this.pnlRental.Controls.Add(this.lblRental_RentalDivisions);
			this.pnlRental.Controls.Add(this.lblRental_Pickup);
			this.pnlRental.Controls.Add(this.txtRental_Pickup);
			this.pnlRental.Controls.Add(this.lblRental_Equipment);
			this.pnlRental.Controls.Add(this.txtRental_Equipment);
			this.pnlRental.Controls.Add(this.lblRental_Reservation);
			this.pnlRental.Controls.Add(this.txtRental_Reservation);
			this.pnlRental.Controls.Add(this.lblRental_LiftHeight);
			this.pnlRental.Controls.Add(this.numRental_LiftHeight);
			this.pnlRental.Controls.Add(this.lblRental_LiftType);
			this.pnlRental.Controls.Add(this.cmbRental_LiftType);
			this.pnlRental.Controls.Add(this.lblRental_RentalCompany);
			this.pnlRental.Controls.Add(this.cmbRental_RentalCompany);
			this.pnlRental.Controls.Add(this.lblRental);
			this.pnlRental.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlRental.Location = new System.Drawing.Point(0, 108);
			this.pnlRental.Name = "pnlRental";
			this.pnlRental.Size = new System.Drawing.Size(555, 347);
			this.pnlRental.TabIndex = 1;
			// 
			// lblRental_PickupFormat
			// 
			this.lblRental_PickupFormat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRental_PickupFormat.Location = new System.Drawing.Point(429, 302);
			this.lblRental_PickupFormat.Name = "lblRental_PickupFormat";
			this.lblRental_PickupFormat.Size = new System.Drawing.Size(100, 17);
			this.lblRental_PickupFormat.TabIndex = 22;
			this.lblRental_PickupFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRental_PickupFormat.Visible = false;
			// 
			// lblRental_EquipmentFormat
			// 
			this.lblRental_EquipmentFormat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRental_EquipmentFormat.Location = new System.Drawing.Point(323, 302);
			this.lblRental_EquipmentFormat.Name = "lblRental_EquipmentFormat";
			this.lblRental_EquipmentFormat.Size = new System.Drawing.Size(100, 17);
			this.lblRental_EquipmentFormat.TabIndex = 20;
			this.lblRental_EquipmentFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRental_EquipmentFormat.Visible = false;
			// 
			// lblRental_ReservationFormat
			// 
			this.lblRental_ReservationFormat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRental_ReservationFormat.Location = new System.Drawing.Point(217, 302);
			this.lblRental_ReservationFormat.Name = "lblRental_ReservationFormat";
			this.lblRental_ReservationFormat.Size = new System.Drawing.Size(100, 17);
			this.lblRental_ReservationFormat.TabIndex = 18;
			this.lblRental_ReservationFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRental_ReservationFormat.Visible = false;
			// 
			// txtRental_Telephone
			// 
			this.txtRental_Telephone.Location = new System.Drawing.Point(109, 47);
			this.txtRental_Telephone.Name = "txtRental_Telephone";
			this.txtRental_Telephone.ReadOnly = true;
			this.txtRental_Telephone.Size = new System.Drawing.Size(125, 20);
			this.txtRental_Telephone.TabIndex = 4;
			// 
			// lblRental_Telephone
			// 
			this.lblRental_Telephone.AutoSize = true;
			this.lblRental_Telephone.Location = new System.Drawing.Point(45, 50);
			this.lblRental_Telephone.Name = "lblRental_Telephone";
			this.lblRental_Telephone.Size = new System.Drawing.Size(58, 13);
			this.lblRental_Telephone.TabIndex = 3;
			this.lblRental_Telephone.Text = "Telephone";
			// 
			// txtRental_YescoAccount
			// 
			this.txtRental_PrismviewAccount.Location = new System.Drawing.Point(354, 47);
			this.txtRental_PrismviewAccount.Name = "txtRental_PrismviewAccount";
			this.txtRental_PrismviewAccount.ReadOnly = true;
			this.txtRental_PrismviewAccount.Size = new System.Drawing.Size(125, 20);
			this.txtRental_PrismviewAccount.TabIndex = 6;
			// 
			// lblRental_YescoAccount
			// 
			this.lblRental_PrismviewAccount.AutoSize = true;
			this.lblRental_PrismviewAccount.Location = new System.Drawing.Point(258, 50);
			this.lblRental_PrismviewAccount.Name = "lblRental_PrismviewAccount";
			this.lblRental_PrismviewAccount.Size = new System.Drawing.Size(90, 13);
			this.lblRental_PrismviewAccount.TabIndex = 5;
			this.lblRental_PrismviewAccount.Text = "Prismview Account #";
			// 
			// olvRentalDivisions
			// 
			this.olvRentalDivisions.AllColumns.Add(this.olcName);
			this.olvRentalDivisions.AllColumns.Add(this.olcAddress);
			this.olvRentalDivisions.AllColumns.Add(this.olcCity);
			this.olvRentalDivisions.AllColumns.Add(this.olcState);
			this.olvRentalDivisions.AllColumns.Add(this.olcTelephone);
			this.olvRentalDivisions.AllColumns.Add(this.olcZip);
			this.olvRentalDivisions.AllColumns.Add(this.colCountry);
			this.olvRentalDivisions.AllowColumnReorder = true;
			this.olvRentalDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.olvRentalDivisions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcName,
            this.olcAddress,
            this.olcCity,
            this.olcState,
            this.olcTelephone});
			this.olvRentalDivisions.FullRowSelect = true;
			this.olvRentalDivisions.GridLines = true;
			this.olvRentalDivisions.Location = new System.Drawing.Point(13, 88);
			this.olvRentalDivisions.MultiSelect = false;
			this.olvRentalDivisions.Name = "olvRentalDivisions";
			this.olvRentalDivisions.SelectAllOnControlA = false;
			this.olvRentalDivisions.ShowGroups = false;
			this.olvRentalDivisions.Size = new System.Drawing.Size(539, 163);
			this.olvRentalDivisions.TabIndex = 7;
			this.olvRentalDivisions.UseCompatibleStateImageBehavior = false;
			this.olvRentalDivisions.View = System.Windows.Forms.View.Details;
			// 
			// olcName
			// 
			this.olcName.AspectName = "Name";
			this.olcName.CellPadding = null;
			this.olcName.Text = "Name";
			this.olcName.Width = 120;
			// 
			// olcAddress
			// 
			this.olcAddress.AspectName = "Address";
			this.olcAddress.CellPadding = null;
			this.olcAddress.Text = "Address";
			this.olcAddress.Width = 120;
			// 
			// olcCity
			// 
			this.olcCity.AspectName = "City";
			this.olcCity.CellPadding = null;
			this.olcCity.Text = "City";
			this.olcCity.Width = 100;
			// 
			// olcState
			// 
			this.olcState.AspectName = "State";
			this.olcState.CellPadding = null;
			this.olcState.Text = "State";
			this.olcState.Width = 50;
			// 
			// olcTelephone
			// 
			this.olcTelephone.AspectName = "Telephone";
			this.olcTelephone.CellPadding = null;
			this.olcTelephone.Text = "Telephone";
			this.olcTelephone.Width = 120;
			// 
			// olcZip
			// 
			this.olcZip.AspectName = "Zip";
			this.olcZip.CellPadding = null;
			this.olcZip.DisplayIndex = 4;
			this.olcZip.IsVisible = false;
			this.olcZip.Text = "Zip";
			this.olcZip.Width = 40;
			// 
			// colCountry
			// 
			this.colCountry.AspectName = "Country";
			this.colCountry.CellPadding = null;
			this.colCountry.DisplayIndex = 5;
			this.colCountry.IsVisible = false;
			this.colCountry.Text = "Country";
			this.colCountry.Width = 100;
			// 
			// lblRental_Pickup_Valid
			// 
			this.lblRental_Pickup_Valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblRental_Pickup_Valid.Location = new System.Drawing.Point(429, 321);
			this.lblRental_Pickup_Valid.Name = "lblRental_Pickup_Valid";
			this.lblRental_Pickup_Valid.Size = new System.Drawing.Size(100, 17);
			this.lblRental_Pickup_Valid.TabIndex = 23;
			this.lblRental_Pickup_Valid.Text = "INVALID";
			this.lblRental_Pickup_Valid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRental_Pickup_Valid.Visible = false;
			// 
			// lblRental_Equipment_Valid
			// 
			this.lblRental_Equipment_Valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblRental_Equipment_Valid.Location = new System.Drawing.Point(323, 321);
			this.lblRental_Equipment_Valid.Name = "lblRental_Equipment_Valid";
			this.lblRental_Equipment_Valid.Size = new System.Drawing.Size(100, 17);
			this.lblRental_Equipment_Valid.TabIndex = 21;
			this.lblRental_Equipment_Valid.Text = "INVALID";
			this.lblRental_Equipment_Valid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRental_Equipment_Valid.Visible = false;
			// 
			// lblRental_Reservation_Valid
			// 
			this.lblRental_Reservation_Valid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblRental_Reservation_Valid.Location = new System.Drawing.Point(217, 321);
			this.lblRental_Reservation_Valid.Name = "lblRental_Reservation_Valid";
			this.lblRental_Reservation_Valid.Size = new System.Drawing.Size(100, 17);
			this.lblRental_Reservation_Valid.TabIndex = 19;
			this.lblRental_Reservation_Valid.Text = "INVALID";
			this.lblRental_Reservation_Valid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRental_Reservation_Valid.Visible = false;
			// 
			// lblRental_RentalDivisions
			// 
			this.lblRental_RentalDivisions.AutoSize = true;
			this.lblRental_RentalDivisions.Location = new System.Drawing.Point(10, 72);
			this.lblRental_RentalDivisions.Name = "lblRental_RentalDivisions";
			this.lblRental_RentalDivisions.Size = new System.Drawing.Size(83, 13);
			this.lblRental_RentalDivisions.TabIndex = 21;
			this.lblRental_RentalDivisions.Text = "Rental Divisions";
			// 
			// lblRental_Pickup
			// 
			this.lblRental_Pickup.AutoSize = true;
			this.lblRental_Pickup.Location = new System.Drawing.Point(426, 262);
			this.lblRental_Pickup.Name = "lblRental_Pickup";
			this.lblRental_Pickup.Size = new System.Drawing.Size(53, 13);
			this.lblRental_Pickup.TabIndex = 16;
			this.lblRental_Pickup.Text = "Pick-up #";
			// 
			// txtRental_Pickup
			// 
			this.txtRental_Pickup.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRental_Pickup.Location = new System.Drawing.Point(429, 279);
			this.txtRental_Pickup.MaxLength = 16;
			this.txtRental_Pickup.Name = "txtRental_Pickup";
			this.txtRental_Pickup.Size = new System.Drawing.Size(100, 20);
			this.txtRental_Pickup.TabIndex = 17;
			this.txtRental_Pickup.TextChanged += new System.EventHandler(this.txtRental_Pickup_TextChanged);
			this.txtRental_Pickup.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblRental_Equipment
			// 
			this.lblRental_Equipment.AutoSize = true;
			this.lblRental_Equipment.Location = new System.Drawing.Point(320, 262);
			this.lblRental_Equipment.Name = "lblRental_Equipment";
			this.lblRental_Equipment.Size = new System.Drawing.Size(67, 13);
			this.lblRental_Equipment.TabIndex = 14;
			this.lblRental_Equipment.Text = "Equipment #";
			// 
			// txtRental_Equipment
			// 
			this.txtRental_Equipment.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRental_Equipment.Location = new System.Drawing.Point(323, 279);
			this.txtRental_Equipment.MaxLength = 16;
			this.txtRental_Equipment.Name = "txtRental_Equipment";
			this.txtRental_Equipment.Size = new System.Drawing.Size(100, 20);
			this.txtRental_Equipment.TabIndex = 15;
			this.txtRental_Equipment.TextChanged += new System.EventHandler(this.txtRental_Equipment_TextChanged);
			this.txtRental_Equipment.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblRental_Reservation
			// 
			this.lblRental_Reservation.AutoSize = true;
			this.lblRental_Reservation.Location = new System.Drawing.Point(214, 262);
			this.lblRental_Reservation.Name = "lblRental_Reservation";
			this.lblRental_Reservation.Size = new System.Drawing.Size(74, 13);
			this.lblRental_Reservation.TabIndex = 12;
			this.lblRental_Reservation.Text = "Reservation #";
			// 
			// txtRental_Reservation
			// 
			this.txtRental_Reservation.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRental_Reservation.Location = new System.Drawing.Point(217, 279);
			this.txtRental_Reservation.MaxLength = 16;
			this.txtRental_Reservation.Name = "txtRental_Reservation";
			this.txtRental_Reservation.Size = new System.Drawing.Size(100, 20);
			this.txtRental_Reservation.TabIndex = 13;
			this.txtRental_Reservation.TextChanged += new System.EventHandler(this.txtRental_Reservation_TextChanged);
			this.txtRental_Reservation.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblRental_LiftHeight
			// 
			this.lblRental_LiftHeight.AutoSize = true;
			this.lblRental_LiftHeight.Location = new System.Drawing.Point(143, 263);
			this.lblRental_LiftHeight.Name = "lblRental_LiftHeight";
			this.lblRental_LiftHeight.Size = new System.Drawing.Size(55, 13);
			this.lblRental_LiftHeight.TabIndex = 10;
			this.lblRental_LiftHeight.Text = "Lift Height";
			// 
			// numRental_LiftHeight
			// 
			this.numRental_LiftHeight.Location = new System.Drawing.Point(146, 279);
			this.numRental_LiftHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numRental_LiftHeight.Name = "numRental_LiftHeight";
			this.numRental_LiftHeight.Size = new System.Drawing.Size(65, 20);
			this.numRental_LiftHeight.TabIndex = 11;
			this.numRental_LiftHeight.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblRental_LiftType
			// 
			this.lblRental_LiftType.AutoSize = true;
			this.lblRental_LiftType.Location = new System.Drawing.Point(10, 262);
			this.lblRental_LiftType.Name = "lblRental_LiftType";
			this.lblRental_LiftType.Size = new System.Drawing.Size(48, 13);
			this.lblRental_LiftType.TabIndex = 8;
			this.lblRental_LiftType.Text = "Lift Type";
			// 
			// cmbRental_LiftType
			// 
			this.cmbRental_LiftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRental_LiftType.FormattingEnabled = true;
			this.cmbRental_LiftType.Location = new System.Drawing.Point(13, 278);
			this.cmbRental_LiftType.Name = "cmbRental_LiftType";
			this.cmbRental_LiftType.Size = new System.Drawing.Size(127, 21);
			this.cmbRental_LiftType.TabIndex = 9;
			this.cmbRental_LiftType.SelectedIndexChanged += new System.EventHandler(this.cmbRental_LiftType_SelectedIndexChanged);
			// 
			// lblRental_RentalCompany
			// 
			this.lblRental_RentalCompany.AutoSize = true;
			this.lblRental_RentalCompany.Location = new System.Drawing.Point(18, 23);
			this.lblRental_RentalCompany.Name = "lblRental_RentalCompany";
			this.lblRental_RentalCompany.Size = new System.Drawing.Size(85, 13);
			this.lblRental_RentalCompany.TabIndex = 1;
			this.lblRental_RentalCompany.Text = "Rental Company";
			// 
			// cmbRental_RentalCompany
			// 
			this.cmbRental_RentalCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRental_RentalCompany.FormattingEnabled = true;
			this.cmbRental_RentalCompany.Location = new System.Drawing.Point(109, 20);
			this.cmbRental_RentalCompany.Name = "cmbRental_RentalCompany";
			this.cmbRental_RentalCompany.Size = new System.Drawing.Size(277, 21);
			this.cmbRental_RentalCompany.TabIndex = 2;
			this.cmbRental_RentalCompany.SelectedIndexChanged += new System.EventHandler(this.cmbRental_RentalCompany_SelectedIndexChanged);
			// 
			// lblRental
			// 
			this.lblRental.BackColor = System.Drawing.Color.DimGray;
			this.lblRental.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblRental.ForeColor = System.Drawing.Color.White;
			this.lblRental.Location = new System.Drawing.Point(0, 0);
			this.lblRental.Name = "lblRental";
			this.lblRental.Size = new System.Drawing.Size(555, 17);
			this.lblRental.TabIndex = 0;
			this.lblRental.Text = "Equipment Rental";
			this.lblRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlDetails
			// 
			this.pnlDetails.BackColor = System.Drawing.Color.LightGray;
			this.pnlDetails.Controls.Add(this.txtDetails_AssignedTech);
			this.pnlDetails.Controls.Add(this.lblDetails_AssignedTech);
			this.pnlDetails.Controls.Add(this.txtDetails_LiftHeight);
			this.pnlDetails.Controls.Add(this.lblDetails_TicketNumber);
			this.pnlDetails.Controls.Add(this.txtDetails_LiftType);
			this.pnlDetails.Controls.Add(this.txtDetails_TicketNumber);
			this.pnlDetails.Controls.Add(this.txtDetails_Asset_HAGL);
			this.pnlDetails.Controls.Add(this.lblDetails);
			this.pnlDetails.Controls.Add(this.lblDetails_Asset_LiftHeight);
			this.pnlDetails.Controls.Add(this.txtDetails_Asset_AssetName);
			this.pnlDetails.Controls.Add(this.lblDetails_Asset_LiftType);
			this.pnlDetails.Controls.Add(this.lblDetails_AssetName);
			this.pnlDetails.Controls.Add(this.lblDetails_Asset_HAGL);
			this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlDetails.Location = new System.Drawing.Point(0, 0);
			this.pnlDetails.Name = "pnlDetails";
			this.pnlDetails.Size = new System.Drawing.Size(555, 108);
			this.pnlDetails.TabIndex = 0;
			// 
			// txtDetails_AssignedTech
			// 
			this.txtDetails_AssignedTech.Location = new System.Drawing.Point(59, 72);
			this.txtDetails_AssignedTech.Name = "txtDetails_AssignedTech";
			this.txtDetails_AssignedTech.ReadOnly = true;
			this.txtDetails_AssignedTech.Size = new System.Drawing.Size(217, 20);
			this.txtDetails_AssignedTech.TabIndex = 6;
			// 
			// lblDetails_AssignedTech
			// 
			this.lblDetails_AssignedTech.AutoSize = true;
			this.lblDetails_AssignedTech.Location = new System.Drawing.Point(20, 75);
			this.lblDetails_AssignedTech.Name = "lblDetails_AssignedTech";
			this.lblDetails_AssignedTech.Size = new System.Drawing.Size(32, 13);
			this.lblDetails_AssignedTech.TabIndex = 5;
			this.lblDetails_AssignedTech.Text = "Tech";
			// 
			// txtDetails_LiftHeight
			// 
			this.txtDetails_LiftHeight.Location = new System.Drawing.Point(433, 72);
			this.txtDetails_LiftHeight.Name = "txtDetails_LiftHeight";
			this.txtDetails_LiftHeight.ReadOnly = true;
			this.txtDetails_LiftHeight.Size = new System.Drawing.Size(100, 20);
			this.txtDetails_LiftHeight.TabIndex = 12;
			// 
			// lblDetails_TicketNumber
			// 
			this.lblDetails_TicketNumber.AutoSize = true;
			this.lblDetails_TicketNumber.Location = new System.Drawing.Point(16, 23);
			this.lblDetails_TicketNumber.Name = "lblDetails_TicketNumber";
			this.lblDetails_TicketNumber.Size = new System.Drawing.Size(37, 13);
			this.lblDetails_TicketNumber.TabIndex = 1;
			this.lblDetails_TicketNumber.Text = "Ticket";
			// 
			// txtDetails_LiftType
			// 
			this.txtDetails_LiftType.Location = new System.Drawing.Point(433, 46);
			this.txtDetails_LiftType.Name = "txtDetails_LiftType";
			this.txtDetails_LiftType.ReadOnly = true;
			this.txtDetails_LiftType.Size = new System.Drawing.Size(100, 20);
			this.txtDetails_LiftType.TabIndex = 10;
			// 
			// txtDetails_TicketNumber
			// 
			this.txtDetails_TicketNumber.Location = new System.Drawing.Point(59, 20);
			this.txtDetails_TicketNumber.Name = "txtDetails_TicketNumber";
			this.txtDetails_TicketNumber.ReadOnly = true;
			this.txtDetails_TicketNumber.Size = new System.Drawing.Size(100, 20);
			this.txtDetails_TicketNumber.TabIndex = 2;
			// 
			// txtDetails_Asset_HAGL
			// 
			this.txtDetails_Asset_HAGL.Location = new System.Drawing.Point(433, 20);
			this.txtDetails_Asset_HAGL.Name = "txtDetails_Asset_HAGL";
			this.txtDetails_Asset_HAGL.ReadOnly = true;
			this.txtDetails_Asset_HAGL.Size = new System.Drawing.Size(100, 20);
			this.txtDetails_Asset_HAGL.TabIndex = 8;
			// 
			// lblDetails
			// 
			this.lblDetails.BackColor = System.Drawing.Color.DimGray;
			this.lblDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDetails.ForeColor = System.Drawing.Color.White;
			this.lblDetails.Location = new System.Drawing.Point(0, 0);
			this.lblDetails.Name = "lblDetails";
			this.lblDetails.Size = new System.Drawing.Size(555, 17);
			this.lblDetails.TabIndex = 0;
			this.lblDetails.Text = "Ticket/Asset Details";
			this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDetails_Asset_LiftHeight
			// 
			this.lblDetails_Asset_LiftHeight.AutoSize = true;
			this.lblDetails_Asset_LiftHeight.Location = new System.Drawing.Point(297, 75);
			this.lblDetails_Asset_LiftHeight.Name = "lblDetails_Asset_LiftHeight";
			this.lblDetails_Asset_LiftHeight.Size = new System.Drawing.Size(130, 13);
			this.lblDetails_Asset_LiftHeight.TabIndex = 11;
			this.lblDetails_Asset_LiftHeight.Text = "Recommended Lift Height";
			// 
			// txtDetails_Asset_AssetName
			// 
			this.txtDetails_Asset_AssetName.Location = new System.Drawing.Point(59, 46);
			this.txtDetails_Asset_AssetName.Name = "txtDetails_Asset_AssetName";
			this.txtDetails_Asset_AssetName.ReadOnly = true;
			this.txtDetails_Asset_AssetName.Size = new System.Drawing.Size(217, 20);
			this.txtDetails_Asset_AssetName.TabIndex = 4;
			// 
			// lblDetails_Asset_LiftType
			// 
			this.lblDetails_Asset_LiftType.AutoSize = true;
			this.lblDetails_Asset_LiftType.Location = new System.Drawing.Point(304, 49);
			this.lblDetails_Asset_LiftType.Name = "lblDetails_Asset_LiftType";
			this.lblDetails_Asset_LiftType.Size = new System.Drawing.Size(123, 13);
			this.lblDetails_Asset_LiftType.TabIndex = 9;
			this.lblDetails_Asset_LiftType.Text = "Recommended Lift Type";
			// 
			// lblDetails_AssetName
			// 
			this.lblDetails_AssetName.AutoSize = true;
			this.lblDetails_AssetName.Location = new System.Drawing.Point(20, 49);
			this.lblDetails_AssetName.Name = "lblDetails_AssetName";
			this.lblDetails_AssetName.Size = new System.Drawing.Size(33, 13);
			this.lblDetails_AssetName.TabIndex = 3;
			this.lblDetails_AssetName.Text = "Asset";
			// 
			// lblDetails_Asset_HAGL
			// 
			this.lblDetails_Asset_HAGL.AutoSize = true;
			this.lblDetails_Asset_HAGL.Location = new System.Drawing.Point(391, 24);
			this.lblDetails_Asset_HAGL.Name = "lblDetails_Asset_HAGL";
			this.lblDetails_Asset_HAGL.Size = new System.Drawing.Size(36, 13);
			this.lblDetails_Asset_HAGL.TabIndex = 7;
			this.lblDetails_Asset_HAGL.Text = "HAGL";
			// 
			// FormTicket_Rental
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(579, 508);
			this.Controls.Add(this.pnlTicketRental);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTicket_Rental";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Equipment Rental";
			this.Load += new System.EventHandler(this.FormTicket_Rental_Load);
			this.pnlTicketRental.ResumeLayout(false);
			this.pnlRental.ResumeLayout(false);
			this.pnlRental.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRentalDivisions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numRental_LiftHeight)).EndInit();
			this.pnlDetails.ResumeLayout(false);
			this.pnlDetails.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlTicketRental;
		private System.Windows.Forms.Panel pnlRental;
		private System.Windows.Forms.Label lblRental_Pickup_Valid;
		private System.Windows.Forms.Label lblRental_Equipment_Valid;
		private System.Windows.Forms.Label lblRental_Reservation_Valid;
		private System.Windows.Forms.Label lblRental_RentalDivisions;
		private System.Windows.Forms.Label lblRental_Pickup;
		private System.Windows.Forms.TextBox txtRental_Pickup;
		private System.Windows.Forms.Label lblRental_Equipment;
		private System.Windows.Forms.TextBox txtRental_Equipment;
		private System.Windows.Forms.Label lblRental_Reservation;
		private System.Windows.Forms.TextBox txtRental_Reservation;
		private System.Windows.Forms.Label lblRental_LiftHeight;
		private ClassFixedNumericUpDown numRental_LiftHeight;
		private System.Windows.Forms.Label lblRental_LiftType;
		private System.Windows.Forms.ComboBox cmbRental_LiftType;
		private System.Windows.Forms.Label lblRental_RentalCompany;
		private System.Windows.Forms.ComboBox cmbRental_RentalCompany;
		private System.Windows.Forms.Label lblRental;
		private System.Windows.Forms.Panel pnlDetails;
		private System.Windows.Forms.TextBox txtDetails_AssignedTech;
		private System.Windows.Forms.Label lblDetails_AssignedTech;
		private System.Windows.Forms.TextBox txtDetails_LiftHeight;
		private System.Windows.Forms.Label lblDetails_TicketNumber;
		private System.Windows.Forms.TextBox txtDetails_LiftType;
		private System.Windows.Forms.TextBox txtDetails_TicketNumber;
		private System.Windows.Forms.TextBox txtDetails_Asset_HAGL;
		private System.Windows.Forms.Label lblDetails;
		private System.Windows.Forms.Label lblDetails_Asset_LiftHeight;
		private System.Windows.Forms.TextBox txtDetails_Asset_AssetName;
		private System.Windows.Forms.Label lblDetails_Asset_LiftType;
		private System.Windows.Forms.Label lblDetails_AssetName;
		private System.Windows.Forms.Label lblDetails_Asset_HAGL;
		private BrightIdeasSoftware.ObjectListView olvRentalDivisions;
		private BrightIdeasSoftware.OLVColumn olcName;
		private BrightIdeasSoftware.OLVColumn olcAddress;
		private BrightIdeasSoftware.OLVColumn olcCity;
		private BrightIdeasSoftware.OLVColumn olcState;
		private BrightIdeasSoftware.OLVColumn olcZip;
		private BrightIdeasSoftware.OLVColumn colCountry;
		private BrightIdeasSoftware.OLVColumn olcTelephone;
		private System.Windows.Forms.TextBox txtRental_Telephone;
		private System.Windows.Forms.Label lblRental_Telephone;
		private System.Windows.Forms.TextBox txtRental_PrismviewAccount;
		private System.Windows.Forms.Label lblRental_PrismviewAccount;
		private System.Windows.Forms.Label lblRental_PickupFormat;
		private System.Windows.Forms.Label lblRental_EquipmentFormat;
		private System.Windows.Forms.Label lblRental_ReservationFormat;
	}
}