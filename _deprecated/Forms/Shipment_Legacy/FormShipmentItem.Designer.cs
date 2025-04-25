namespace SDB.Forms.Shipment
{
	partial class FormShipmentItem
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
			System.Windows.Forms.TextBox txtInfo;
			this.lblQuantity = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.numQty = new System.Windows.Forms.NumericUpDown();
			this.txtRMA = new System.Windows.Forms.TextBox();
			this.lblRMA = new System.Windows.Forms.Label();
			this.lblTicket = new System.Windows.Forms.Label();
			this.txtTicket = new System.Windows.Forms.TextBox();
			this.lblAsset = new System.Windows.Forms.Label();
			this.lblType = new System.Windows.Forms.Label();
			this.cmbAsset = new System.Windows.Forms.ComboBox();
			this.chkCustomJobNumber = new System.Windows.Forms.CheckBox();
			this.txtJobNumber = new System.Windows.Forms.TextBox();
			this.lblJobNumber = new System.Windows.Forms.Label();
			this.lblAssembly = new System.Windows.Forms.Label();
			this.cmbAssembly = new System.Windows.Forms.ComboBox();
			this.timerLookupRma = new System.Windows.Forms.Timer(this.components);
			this.timerLookupTicket = new System.Windows.Forms.Timer(this.components);
			this.txtSerialNumber = new System.Windows.Forms.TextBox();
			this.lblSerialNumber = new System.Windows.Forms.Label();
			this.pnlAssociatedObjects = new System.Windows.Forms.Panel();
			this.pnlShipmentItem = new System.Windows.Forms.Panel();
			this.lblCategory = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			txtInfo = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
			this.pnlAssociatedObjects.SuspendLayout();
			this.pnlShipmentItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtInfo
			// 
			txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtInfo.Dock = System.Windows.Forms.DockStyle.Top;
			txtInfo.Location = new System.Drawing.Point(10, 10);
			txtInfo.Multiline = true;
			txtInfo.Name = "txtInfo";
			txtInfo.ReadOnly = true;
			txtInfo.Size = new System.Drawing.Size(582, 74);
			txtInfo.TabIndex = 0;
			txtInfo.TabStop = false;
			txtInfo.Text = "Specify the related service items that this shipment inventory item belongs to.\r\n" +
    "\r\nThe asset is required.\r\n\r\nBy entering an RMA or Ticket number, the correspondi" +
    "ng asset will be auto-populated.";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(3, 86);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(46, 13);
			this.lblQuantity.TabIndex = 4;
			this.lblQuantity.Text = "Quantity";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(433, 399);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(514, 399);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Location = new System.Drawing.Point(76, 62);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(500, 21);
			this.cmbType.TabIndex = 3;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
			// 
			// numQty
			// 
			this.numQty.Location = new System.Drawing.Point(3, 102);
			this.numQty.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numQty.Name = "numQty";
			this.numQty.Size = new System.Drawing.Size(67, 20);
			this.numQty.TabIndex = 5;
			this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numQty.Enter += new System.EventHandler(this.NumUpDown_Enter);
			// 
			// txtRMA
			// 
			this.txtRMA.Location = new System.Drawing.Point(3, 17);
			this.txtRMA.Name = "txtRMA";
			this.txtRMA.Size = new System.Drawing.Size(100, 20);
			this.txtRMA.TabIndex = 1;
			this.txtRMA.TextChanged += new System.EventHandler(this.txtRMA_TextChanged);
			this.txtRMA.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblRMA
			// 
			this.lblRMA.AutoSize = true;
			this.lblRMA.Location = new System.Drawing.Point(3, 1);
			this.lblRMA.Name = "lblRMA";
			this.lblRMA.Size = new System.Drawing.Size(31, 13);
			this.lblRMA.TabIndex = 0;
			this.lblRMA.Text = "RMA";
			// 
			// lblTicket
			// 
			this.lblTicket.AutoSize = true;
			this.lblTicket.Location = new System.Drawing.Point(106, 1);
			this.lblTicket.Name = "lblTicket";
			this.lblTicket.Size = new System.Drawing.Size(37, 13);
			this.lblTicket.TabIndex = 2;
			this.lblTicket.Text = "Ticket";
			// 
			// txtTicket
			// 
			this.txtTicket.Location = new System.Drawing.Point(109, 17);
			this.txtTicket.Name = "txtTicket";
			this.txtTicket.Size = new System.Drawing.Size(100, 20);
			this.txtTicket.TabIndex = 3;
			this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged);
			this.txtTicket.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAsset
			// 
			this.lblAsset.AutoSize = true;
			this.lblAsset.Location = new System.Drawing.Point(215, 1);
			this.lblAsset.Name = "lblAsset";
			this.lblAsset.Size = new System.Drawing.Size(33, 13);
			this.lblAsset.TabIndex = 4;
			this.lblAsset.Text = "Asset";
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(73, 46);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(78, 13);
			this.lblType.TabIndex = 2;
			this.lblType.Text = "Assembly Type";
			// 
			// cmbAsset
			// 
			this.cmbAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsset.FormattingEnabled = true;
			this.cmbAsset.Location = new System.Drawing.Point(218, 17);
			this.cmbAsset.Name = "cmbAsset";
			this.cmbAsset.Size = new System.Drawing.Size(358, 21);
			this.cmbAsset.TabIndex = 5;
			this.cmbAsset.SelectedIndexChanged += new System.EventHandler(this.cmbAsset_SelectedIndexChanged);
			// 
			// chkCustomJobNumber
			// 
			this.chkCustomJobNumber.AutoSize = true;
			this.chkCustomJobNumber.Location = new System.Drawing.Point(324, 59);
			this.chkCustomJobNumber.Name = "chkCustomJobNumber";
			this.chkCustomJobNumber.Size = new System.Drawing.Size(119, 17);
			this.chkCustomJobNumber.TabIndex = 8;
			this.chkCustomJobNumber.Text = "Custom job number.";
			this.chkCustomJobNumber.UseVisualStyleBackColor = true;
			this.chkCustomJobNumber.CheckedChanged += new System.EventHandler(this.chkCustomJobNumber_CheckedChanged);
			// 
			// txtJobNumber
			// 
			this.txtJobNumber.Enabled = false;
			this.txtJobNumber.Location = new System.Drawing.Point(218, 57);
			this.txtJobNumber.MaxLength = 20;
			this.txtJobNumber.Name = "txtJobNumber";
			this.txtJobNumber.Size = new System.Drawing.Size(100, 20);
			this.txtJobNumber.TabIndex = 7;
			this.txtJobNumber.TextChanged += new System.EventHandler(this.txtJobNumber_TextChanged);
			// 
			// lblJobNumber
			// 
			this.lblJobNumber.AutoSize = true;
			this.lblJobNumber.Enabled = false;
			this.lblJobNumber.Location = new System.Drawing.Point(215, 41);
			this.lblJobNumber.Name = "lblJobNumber";
			this.lblJobNumber.Size = new System.Drawing.Size(64, 13);
			this.lblJobNumber.TabIndex = 6;
			this.lblJobNumber.Text = "Job Number";
			// 
			// lblAssembly
			// 
			this.lblAssembly.AutoSize = true;
			this.lblAssembly.Location = new System.Drawing.Point(73, 86);
			this.lblAssembly.Name = "lblAssembly";
			this.lblAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblAssembly.TabIndex = 6;
			this.lblAssembly.Text = "Assembly";
			// 
			// cmbAssembly
			// 
			this.cmbAssembly.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssembly.FormattingEnabled = true;
			this.cmbAssembly.Location = new System.Drawing.Point(76, 102);
			this.cmbAssembly.Name = "cmbAssembly";
			this.cmbAssembly.Size = new System.Drawing.Size(500, 21);
			this.cmbAssembly.TabIndex = 7;
			this.cmbAssembly.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAssembly_DrawItem);
			this.cmbAssembly.SelectedIndexChanged += new System.EventHandler(this.cmbAssembly_SelectedIndexChanged);
			// 
			// timerLookupRma
			// 
			this.timerLookupRma.Interval = 500;
			this.timerLookupRma.Tick += new System.EventHandler(this.timerLookupRma_Tick);
			// 
			// timerLookupTicket
			// 
			this.timerLookupTicket.Interval = 500;
			this.timerLookupTicket.Tick += new System.EventHandler(this.timerLookupTicket_Tick);
			// 
			// txtSerialNumber
			// 
			this.txtSerialNumber.Location = new System.Drawing.Point(76, 142);
			this.txtSerialNumber.MaxLength = 1000;
			this.txtSerialNumber.Multiline = true;
			this.txtSerialNumber.Name = "txtSerialNumber";
			this.txtSerialNumber.Size = new System.Drawing.Size(500, 64);
			this.txtSerialNumber.TabIndex = 9;
			this.txtSerialNumber.TextChanged += new System.EventHandler(this.txtSerialNumber_TextChanged);
			// 
			// lblSerialNumber
			// 
			this.lblSerialNumber.AutoSize = true;
			this.lblSerialNumber.Location = new System.Drawing.Point(73, 126);
			this.lblSerialNumber.Name = "lblSerialNumber";
			this.lblSerialNumber.Size = new System.Drawing.Size(268, 13);
			this.lblSerialNumber.TabIndex = 8;
			this.lblSerialNumber.Text = "Serial Number (separate multiple numbers with commas)";
			// 
			// pnlAssociatedObjects
			// 
			this.pnlAssociatedObjects.Controls.Add(this.lblRMA);
			this.pnlAssociatedObjects.Controls.Add(this.txtRMA);
			this.pnlAssociatedObjects.Controls.Add(this.txtTicket);
			this.pnlAssociatedObjects.Controls.Add(this.lblTicket);
			this.pnlAssociatedObjects.Controls.Add(this.lblAsset);
			this.pnlAssociatedObjects.Controls.Add(this.cmbAsset);
			this.pnlAssociatedObjects.Controls.Add(this.lblJobNumber);
			this.pnlAssociatedObjects.Controls.Add(this.chkCustomJobNumber);
			this.pnlAssociatedObjects.Controls.Add(this.txtJobNumber);
			this.pnlAssociatedObjects.Location = new System.Drawing.Point(10, 90);
			this.pnlAssociatedObjects.Name = "pnlAssociatedObjects";
			this.pnlAssociatedObjects.Size = new System.Drawing.Size(579, 82);
			this.pnlAssociatedObjects.TabIndex = 1;
			// 
			// pnlShipmentItem
			// 
			this.pnlShipmentItem.Controls.Add(this.lblQuantity);
			this.pnlShipmentItem.Controls.Add(this.numQty);
			this.pnlShipmentItem.Controls.Add(this.lblSerialNumber);
			this.pnlShipmentItem.Controls.Add(this.cmbCategory);
			this.pnlShipmentItem.Controls.Add(this.cmbType);
			this.pnlShipmentItem.Controls.Add(this.lblCategory);
			this.pnlShipmentItem.Controls.Add(this.txtSerialNumber);
			this.pnlShipmentItem.Controls.Add(this.lblType);
			this.pnlShipmentItem.Controls.Add(this.lblAssembly);
			this.pnlShipmentItem.Controls.Add(this.cmbAssembly);
			this.pnlShipmentItem.Location = new System.Drawing.Point(10, 178);
			this.pnlShipmentItem.Name = "pnlShipmentItem";
			this.pnlShipmentItem.Size = new System.Drawing.Size(579, 209);
			this.pnlShipmentItem.TabIndex = 2;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(73, 6);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(49, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category";
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(76, 22);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(500, 21);
			this.cmbCategory.TabIndex = 1;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
			// 
			// FormShipmentItem
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(602, 435);
			this.Controls.Add(this.pnlShipmentItem);
			this.Controls.Add(this.pnlAssociatedObjects);
			this.Controls.Add(txtInfo);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormShipmentItem";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add/Edit Shipment Item";
			this.Shown += new System.EventHandler(this.FormShipmentItem_Shown);
			((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
			this.pnlAssociatedObjects.ResumeLayout(false);
			this.pnlAssociatedObjects.PerformLayout();
			this.pnlShipmentItem.ResumeLayout(false);
			this.pnlShipmentItem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.NumericUpDown numQty;
		private System.Windows.Forms.TextBox txtRMA;
		private System.Windows.Forms.Label lblRMA;
		private System.Windows.Forms.Label lblTicket;
		private System.Windows.Forms.TextBox txtTicket;
		private System.Windows.Forms.Label lblAsset;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.ComboBox cmbAsset;
		private System.Windows.Forms.CheckBox chkCustomJobNumber;
		private System.Windows.Forms.TextBox txtJobNumber;
		private System.Windows.Forms.Label lblJobNumber;
		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.Timer timerLookupRma;
		private System.Windows.Forms.Timer timerLookupTicket;
		private System.Windows.Forms.TextBox txtSerialNumber;
		private System.Windows.Forms.Label lblSerialNumber;
		private System.Windows.Forms.Panel pnlAssociatedObjects;
		private System.Windows.Forms.Panel pnlShipmentItem;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblCategory;
	}
}