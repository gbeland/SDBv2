namespace SDB.Forms.Shipment
{
	partial class FormList_ShipmentDestinations
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
			this.olvAltDests = new BrightIdeasSoftware.ObjectListView();
			this.olcCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAttention = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAddressType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.olvAltDests)).BeginInit();
			this.pnlContainer.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvAltDests
			// 
			this.olvAltDests.AllColumns.Add(this.olcCompany);
			this.olvAltDests.AllColumns.Add(this.olcAttention);
			this.olvAltDests.AllColumns.Add(this.olcAddress);
			this.olvAltDests.AllColumns.Add(this.olcCity);
			this.olvAltDests.AllColumns.Add(this.olcState);
			this.olvAltDests.AllColumns.Add(this.olvColZip);
			this.olvAltDests.AllColumns.Add(this.olcCountry);
			this.olvAltDests.AllColumns.Add(this.olcAddressType);
			this.olvAltDests.AllColumns.Add(this.olcTelephone);
			this.olvAltDests.AllowColumnReorder = true;
			this.olvAltDests.CellEditUseWholeCell = false;
			this.olvAltDests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCompany,
            this.olcAttention,
            this.olcAddress,
            this.olcCity,
            this.olcState,
            this.olvColZip,
            this.olcCountry,
            this.olcAddressType,
            this.olcTelephone});
			this.olvAltDests.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvAltDests.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvAltDests.EmptyListMsg = "Please wait...";
			this.olvAltDests.FullRowSelect = true;
			this.olvAltDests.GridLines = true;
			this.olvAltDests.Location = new System.Drawing.Point(0, 30);
			this.olvAltDests.MultiSelect = false;
			this.olvAltDests.Name = "olvAltDests";
			this.olvAltDests.SelectAllOnControlA = false;
			this.olvAltDests.ShowCommandMenuOnRightClick = true;
			this.olvAltDests.ShowGroups = false;
			this.olvAltDests.ShowItemCountOnGroups = true;
			this.olvAltDests.Size = new System.Drawing.Size(960, 471);
			this.olvAltDests.SortGroupItemsByPrimaryColumn = false;
			this.olvAltDests.TabIndex = 0;
			this.olvAltDests.UseCellFormatEvents = true;
			this.olvAltDests.UseCompatibleStateImageBehavior = false;
			this.olvAltDests.UseFilterIndicator = true;
			this.olvAltDests.UseFiltering = true;
			this.olvAltDests.View = System.Windows.Forms.View.Details;
			this.olvAltDests.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTechs_MouseDoubleClick);
			// 
			// olcCompany
			// 
			this.olcCompany.AspectName = "Company";
			this.olcCompany.Hideable = false;
			this.olcCompany.IsEditable = false;
			this.olcCompany.Text = "Company";
			this.olcCompany.Width = 200;
			// 
			// olcAttention
			// 
			this.olcAttention.AspectName = "Attention";
			this.olcAttention.IsEditable = false;
			this.olcAttention.Text = "Attention";
			this.olcAttention.Width = 150;
			// 
			// olcAddress
			// 
			this.olcAddress.AspectName = "Address";
			this.olcAddress.Groupable = false;
			this.olcAddress.IsEditable = false;
			this.olcAddress.Text = "Address";
			this.olcAddress.UseFiltering = false;
			this.olcAddress.Width = 200;
			// 
			// olcCity
			// 
			this.olcCity.AspectName = "City";
			this.olcCity.IsEditable = false;
			this.olcCity.Text = "City";
			this.olcCity.Width = 100;
			// 
			// olcState
			// 
			this.olcState.AspectName = "State";
			this.olcState.IsEditable = false;
			this.olcState.Text = "State";
			this.olcState.Width = 45;
			// 
			// olvColZip
			// 
			this.olvColZip.AspectName = "Zip";
			this.olvColZip.Groupable = false;
			this.olvColZip.IsEditable = false;
			this.olvColZip.Text = "Zip";
			this.olvColZip.UseFiltering = false;
			this.olvColZip.Width = 75;
			// 
			// olcCountry
			// 
			this.olcCountry.AspectName = "Country";
			this.olcCountry.IsEditable = false;
			this.olcCountry.Text = "Country";
			this.olcCountry.Width = 100;
			// 
			// olcAddressType
			// 
			this.olcAddressType.AspectName = "AddressType";
			this.olcAddressType.AspectToStringFormat = "{0}";
			this.olcAddressType.Groupable = false;
			this.olcAddressType.IsEditable = false;
			this.olcAddressType.Searchable = false;
			this.olcAddressType.Text = "Address Type";
			this.olcAddressType.Width = 80;
			// 
			// olcTelephone
			// 
			this.olcTelephone.AspectName = "Telephone";
			this.olcTelephone.Text = "Telephone";
			this.olcTelephone.Width = 80;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(897, 531);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(816, 531);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlContainer
			// 
			this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlContainer.Controls.Add(this.olvAltDests);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(960, 501);
			this.pnlContainer.TabIndex = 3;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.lblQty);
			this.pnlControl.Controls.Add(this.txtQty);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(960, 30);
			this.pnlControl.TabIndex = 8;
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(832, 9);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(59, 13);
			this.lblQty.TabIndex = 7;
			this.lblQty.Text = "Addresses:";
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(897, 4);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(60, 22);
			this.txtQty.TabIndex = 8;
			this.txtQty.TabStop = false;
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// FormList_ShipmentDestinations
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(984, 566);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "FormList_ShipmentDestinations";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SDB Shipments: Other Addresses";
			((System.ComponentModel.ISupportInitialize)(this.olvAltDests)).EndInit();
			this.pnlContainer.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvAltDests;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private BrightIdeasSoftware.OLVColumn olcCompany;
		private BrightIdeasSoftware.OLVColumn olcAddress;
		private BrightIdeasSoftware.OLVColumn olcCity;
		private BrightIdeasSoftware.OLVColumn olcState;
		private BrightIdeasSoftware.OLVColumn olcAddressType;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtQty;
		private BrightIdeasSoftware.OLVColumn olvColZip;
		private BrightIdeasSoftware.OLVColumn olcCountry;
		private BrightIdeasSoftware.OLVColumn olcAttention;
		private BrightIdeasSoftware.OLVColumn olcTelephone;
	}
}