namespace SDB.UserControls.Ticket
{
	partial class TicketRentals
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
			this.olvRentals = new BrightIdeasSoftware.ObjectListView();
			this.olcRentalCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcLiftType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcLiftHeight = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcReservation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEquipment = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcPickUp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcStart = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEnd = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnDeleteRental = new System.Windows.Forms.Button();
			this.btnEndRental = new System.Windows.Forms.Button();
			this.btnNewRental = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvRentals)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvRentals
			// 
			this.olvRentals.AllColumns.Add(this.olcRentalCompany);
			this.olvRentals.AllColumns.Add(this.olcLiftType);
			this.olvRentals.AllColumns.Add(this.olcLiftHeight);
			this.olvRentals.AllColumns.Add(this.olcReservation);
			this.olvRentals.AllColumns.Add(this.olcEquipment);
			this.olvRentals.AllColumns.Add(this.olcPickUp);
			this.olvRentals.AllColumns.Add(this.olcStart);
			this.olvRentals.AllColumns.Add(this.olcEnd);
			this.olvRentals.AllowColumnReorder = true;
			this.olvRentals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcRentalCompany,
            this.olcLiftType,
            this.olcLiftHeight,
            this.olcReservation,
            this.olcEquipment,
            this.olcPickUp,
            this.olcStart,
            this.olcEnd});
			this.olvRentals.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvRentals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRentals.EmptyListMsg = "No rentals for this item.";
			this.olvRentals.FullRowSelect = true;
			this.olvRentals.GridLines = true;
			this.olvRentals.HasCollapsibleGroups = false;
			this.olvRentals.Location = new System.Drawing.Point(0, 30);
			this.olvRentals.Name = "olvRentals";
			this.olvRentals.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRentals.ShowCommandMenuOnRightClick = true;
			this.olvRentals.ShowGroups = false;
			this.olvRentals.Size = new System.Drawing.Size(569, 255);
			this.olvRentals.TabIndex = 9;
			this.olvRentals.UseCompatibleStateImageBehavior = false;
			this.olvRentals.UseHyperlinks = true;
			this.olvRentals.View = System.Windows.Forms.View.Details;
			// 
			// olcRentalCompany
			// 
			this.olcRentalCompany.AspectName = "Rental_Company_Name";
			this.olcRentalCompany.CellPadding = null;
			this.olcRentalCompany.Text = "Company";
			this.olcRentalCompany.ToolTipText = "Rental Company Name";
			this.olcRentalCompany.Width = 100;
			// 
			// olcLiftType
			// 
			this.olcLiftType.AspectName = "Lift_Type_Desc";
			this.olcLiftType.CellPadding = null;
			this.olcLiftType.Text = "Type";
			this.olcLiftType.ToolTipText = "Lift Type";
			this.olcLiftType.Width = 70;
			// 
			// olcLiftHeight
			// 
			this.olcLiftHeight.AspectName = "Lift_Height";
			this.olcLiftHeight.CellPadding = null;
			this.olcLiftHeight.Text = "Ht.";
			this.olcLiftHeight.ToolTipText = "Lift Height (ft.)";
			this.olcLiftHeight.Width = 35;
			// 
			// olcReservation
			// 
			this.olcReservation.AspectName = "Reservation_Number";
			this.olcReservation.CellPadding = null;
			this.olcReservation.Text = "Res. #";
			this.olcReservation.ToolTipText = "Reservation Number";
			this.olcReservation.Width = 68;
			// 
			// olcEquipment
			// 
			this.olcEquipment.AspectName = "Equipment_Number";
			this.olcEquipment.CellPadding = null;
			this.olcEquipment.Text = "Equip. #";
			this.olcEquipment.ToolTipText = "Equipment Number";
			this.olcEquipment.Width = 68;
			// 
			// olcPickUp
			// 
			this.olcPickUp.AspectName = "PickUp_Number";
			this.olcPickUp.CellPadding = null;
			this.olcPickUp.Text = "Pick-up #";
			this.olcPickUp.ToolTipText = "Pick-up Number";
			this.olcPickUp.Width = 68;
			// 
			// olcStart
			// 
			this.olcStart.AspectName = "Reservation_Start";
			this.olcStart.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcStart.CellPadding = null;
			this.olcStart.Text = "Start";
			this.olcStart.ToolTipText = "Reservation start time";
			this.olcStart.Width = 70;
			// 
			// olcEnd
			// 
			this.olcEnd.AspectName = "Reservation_End";
			this.olcEnd.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcEnd.CellPadding = null;
			this.olcEnd.Text = "End";
			this.olcEnd.ToolTipText = "Reservation end time";
			this.olcEnd.Width = 70;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnDeleteRental);
			this.pnlControl.Controls.Add(this.btnEndRental);
			this.pnlControl.Controls.Add(this.btnNewRental);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(569, 30);
			this.pnlControl.TabIndex = 8;
			// 
			// btnDeleteRental
			// 
			this.btnDeleteRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDeleteRental.Location = new System.Drawing.Point(243, 3);
			this.btnDeleteRental.Name = "btnDeleteRental";
			this.btnDeleteRental.Size = new System.Drawing.Size(114, 23);
			this.btnDeleteRental.TabIndex = 12;
			this.btnDeleteRental.Text = "Delete Rental";
			this.btnDeleteRental.UseVisualStyleBackColor = false;
			this.btnDeleteRental.Visible = false;
			this.btnDeleteRental.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEndRental
			// 
			this.btnEndRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnEndRental.Location = new System.Drawing.Point(123, 3);
			this.btnEndRental.Name = "btnEndRental";
			this.btnEndRental.Size = new System.Drawing.Size(114, 23);
			this.btnEndRental.TabIndex = 11;
			this.btnEndRental.Text = "End Rental";
			this.btnEndRental.UseVisualStyleBackColor = false;
			this.btnEndRental.Click += new System.EventHandler(this.btnEndRental_Click);
			// 
			// btnNewRental
			// 
			this.btnNewRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnNewRental.Location = new System.Drawing.Point(3, 3);
			this.btnNewRental.Name = "btnNewRental";
			this.btnNewRental.Size = new System.Drawing.Size(114, 23);
			this.btnNewRental.TabIndex = 0;
			this.btnNewRental.Text = "New Rental";
			this.btnNewRental.UseVisualStyleBackColor = false;
			this.btnNewRental.Click += new System.EventHandler(this.btnNewRental_Click);
			// 
			// TicketRentals
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.olvRentals);
			this.Controls.Add(this.pnlControl);
			this.Name = "TicketRentals";
			this.Size = new System.Drawing.Size(569, 285);
			((System.ComponentModel.ISupportInitialize)(this.olvRentals)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvRentals;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnNewRental;
		private System.Windows.Forms.Button btnEndRental;
		private BrightIdeasSoftware.OLVColumn olcRentalCompany;
		private BrightIdeasSoftware.OLVColumn olcLiftType;
		private BrightIdeasSoftware.OLVColumn olcLiftHeight;
		private BrightIdeasSoftware.OLVColumn olcReservation;
		private BrightIdeasSoftware.OLVColumn olcEquipment;
		private BrightIdeasSoftware.OLVColumn olcPickUp;
		private BrightIdeasSoftware.OLVColumn olcStart;
		private BrightIdeasSoftware.OLVColumn olcEnd;
		private System.Windows.Forms.Button btnDeleteRental;

	}
}
