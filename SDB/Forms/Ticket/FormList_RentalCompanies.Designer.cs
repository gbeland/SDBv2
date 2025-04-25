namespace SDB.Forms.Ticket
{
	partial class FormList_RentalCompanies
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
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvRentalCompanies = new BrightIdeasSoftware.ObjectListView();
			this.olcCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAccountNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcUseReservation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcFormatReservation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcUseEquipment = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcFormatEquipment = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcUsePickup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcFormatPickup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.lblRentalCompanyQty = new System.Windows.Forms.Label();
			this.txtRentalCompanyQty = new System.Windows.Forms.TextBox();
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(872, 527);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.Controls.Add(this.olvRentalCompanies);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(960, 501);
			this.pnlContainer.TabIndex = 5;
			// 
			// olvRentalCompanies
			// 
			this.olvRentalCompanies.AllColumns.Add(this.olcCompany);
			this.olvRentalCompanies.AllColumns.Add(this.olcAccountNumber);
			this.olvRentalCompanies.AllColumns.Add(this.olcTelephone);
			this.olvRentalCompanies.AllColumns.Add(this.olcUseReservation);
			this.olvRentalCompanies.AllColumns.Add(this.olcFormatReservation);
			this.olvRentalCompanies.AllColumns.Add(this.olcUseEquipment);
			this.olvRentalCompanies.AllColumns.Add(this.olcFormatEquipment);
			this.olvRentalCompanies.AllColumns.Add(this.olcUsePickup);
			this.olvRentalCompanies.AllColumns.Add(this.olcFormatPickup);
			this.olvRentalCompanies.AllowColumnReorder = true;
			this.olvRentalCompanies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCompany,
            this.olcAccountNumber,
            this.olcTelephone,
            this.olcUseReservation,
            this.olcFormatReservation,
            this.olcUseEquipment,
            this.olcFormatEquipment,
            this.olcUsePickup,
            this.olcFormatPickup});
			this.olvRentalCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRentalCompanies.EmptyListMsg = "Please wait...";
			this.olvRentalCompanies.FullRowSelect = true;
			this.olvRentalCompanies.GridLines = true;
			this.olvRentalCompanies.HeaderUsesThemes = false;
			this.olvRentalCompanies.HeaderWordWrap = true;
			this.olvRentalCompanies.Location = new System.Drawing.Point(0, 30);
			this.olvRentalCompanies.MultiSelect = false;
			this.olvRentalCompanies.Name = "olvRentalCompanies";
			this.olvRentalCompanies.OwnerDraw = true;
			this.olvRentalCompanies.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRentalCompanies.ShowCommandMenuOnRightClick = true;
			this.olvRentalCompanies.ShowGroups = false;
			this.olvRentalCompanies.ShowItemCountOnGroups = true;
			this.olvRentalCompanies.Size = new System.Drawing.Size(960, 471);
			this.olvRentalCompanies.SortGroupItemsByPrimaryColumn = false;
			this.olvRentalCompanies.TabIndex = 0;
			this.olvRentalCompanies.UseCellFormatEvents = true;
			this.olvRentalCompanies.UseCompatibleStateImageBehavior = false;
			this.olvRentalCompanies.UseFilterIndicator = true;
			this.olvRentalCompanies.View = System.Windows.Forms.View.Details;
			this.olvRentalCompanies.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvRentalCompanies_FormatCell);
			// 
			// olcCompany
			// 
			this.olcCompany.AspectName = "Company";
			this.olcCompany.CellPadding = null;
			this.olcCompany.Groupable = false;
			this.olcCompany.Hideable = false;
			this.olcCompany.IsEditable = false;
			this.olcCompany.Text = "Rental Company";
			this.olcCompany.Width = 180;
			// 
			// olcYescoAccount
			// 
			this.olcAccountNumber.AspectName = "AccountNumber";
			this.olcAccountNumber.CellPadding = null;
			this.olcAccountNumber.Groupable = false;
			this.olcAccountNumber.IsEditable = false;
			this.olcAccountNumber.Text = "Account Number";
			this.olcAccountNumber.Width = 100;
			// 
			// olcTelephone
			// 
			this.olcTelephone.AspectName = "Telephone";
			this.olcTelephone.CellPadding = null;
			this.olcTelephone.IsEditable = false;
			this.olcTelephone.Text = "Telephone";
			this.olcTelephone.Width = 100;
			// 
			// olcUseReservation
			// 
			this.olcUseReservation.AspectName = "UsesReservationNumber";
			this.olcUseReservation.CellPadding = null;
			this.olcUseReservation.CheckBoxes = true;
			this.olcUseReservation.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcUseReservation.IsEditable = false;
			this.olcUseReservation.Text = "Use";
			this.olcUseReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcUseReservation.ToolTipText = "Use Reservation Number";
			// 
			// olcFormatReservation
			// 
			this.olcFormatReservation.AspectName = "ReservationNumber_Format";
			this.olcFormatReservation.CellPadding = null;
			this.olcFormatReservation.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatReservation.Text = "Reservation Format";
			this.olcFormatReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatReservation.ToolTipText = "Reservation Number Format";
			this.olcFormatReservation.Width = 100;
			// 
			// olcUseEquipment
			// 
			this.olcUseEquipment.AspectName = "UsesEquipmentNumber";
			this.olcUseEquipment.CellPadding = null;
			this.olcUseEquipment.CheckBoxes = true;
			this.olcUseEquipment.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcUseEquipment.IsEditable = false;
			this.olcUseEquipment.Text = "Use";
			this.olcUseEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcUseEquipment.ToolTipText = "Use Equipment Number";
			// 
			// olcFormatEquipment
			// 
			this.olcFormatEquipment.AspectName = "EquipmentNumber_Format";
			this.olcFormatEquipment.CellPadding = null;
			this.olcFormatEquipment.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatEquipment.Text = "Equipment Format";
			this.olcFormatEquipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatEquipment.ToolTipText = "Equipment Number Format";
			this.olcFormatEquipment.Width = 100;
			// 
			// olcUsePickup
			// 
			this.olcUsePickup.AspectName = "UsesPickupNumber";
			this.olcUsePickup.CellPadding = null;
			this.olcUsePickup.CheckBoxes = true;
			this.olcUsePickup.Text = "Use";
			this.olcUsePickup.ToolTipText = "Use Pickup Number";
			// 
			// olcFormatPickup
			// 
			this.olcFormatPickup.AspectName = "PickupNumber_Format";
			this.olcFormatPickup.CellPadding = null;
			this.olcFormatPickup.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatPickup.IsEditable = false;
			this.olcFormatPickup.Text = "Pickup Format";
			this.olcFormatPickup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.olcFormatPickup.ToolTipText = "Pickup Number Format";
			this.olcFormatPickup.Width = 100;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnPrint);
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Controls.Add(this.lblRentalCompanyQty);
			this.pnlControl.Controls.Add(this.txtRentalCompanyQty);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(960, 30);
			this.pnlControl.TabIndex = 8;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrint.Location = new System.Drawing.Point(109, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 12;
			this.btnPrint.Text = "&Print...";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExport.Location = new System.Drawing.Point(3, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(100, 23);
			this.btnExport.TabIndex = 11;
			this.btnExport.Text = "&Export to file...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// lblRentalCompanyQty
			// 
			this.lblRentalCompanyQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRentalCompanyQty.AutoSize = true;
			this.lblRentalCompanyQty.Location = new System.Drawing.Point(795, 9);
			this.lblRentalCompanyQty.Name = "lblRentalCompanyQty";
			this.lblRentalCompanyQty.Size = new System.Drawing.Size(96, 13);
			this.lblRentalCompanyQty.TabIndex = 7;
			this.lblRentalCompanyQty.Text = "Rental Companies:";
			// 
			// txtRentalCompanyQty
			// 
			this.txtRentalCompanyQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRentalCompanyQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRentalCompanyQty.Location = new System.Drawing.Point(897, 4);
			this.txtRentalCompanyQty.Name = "txtRentalCompanyQty";
			this.txtRentalCompanyQty.ReadOnly = true;
			this.txtRentalCompanyQty.Size = new System.Drawing.Size(60, 22);
			this.txtRentalCompanyQty.TabIndex = 8;
			this.txtRentalCompanyQty.TabStop = false;
			this.txtRentalCompanyQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// FormList_RentalCompanies
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(984, 562);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.btnClose);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "FormList_RentalCompanies";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SDB Rental Companies";
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRentalCompanies)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvRentalCompanies;
		private BrightIdeasSoftware.OLVColumn olcCompany;
		private BrightIdeasSoftware.OLVColumn olcAccountNumber;
		private BrightIdeasSoftware.OLVColumn olcTelephone;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblRentalCompanyQty;
		private System.Windows.Forms.TextBox txtRentalCompanyQty;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;
		private BrightIdeasSoftware.OLVColumn olcUseReservation;
		private BrightIdeasSoftware.OLVColumn olcFormatReservation;
		private BrightIdeasSoftware.OLVColumn olcUseEquipment;
		private BrightIdeasSoftware.OLVColumn olcFormatEquipment;
		private BrightIdeasSoftware.OLVColumn olcUsePickup;
		private BrightIdeasSoftware.OLVColumn olcFormatPickup;
	}
}