namespace SDB.Forms.Admin
{
	partial class FormAdmin_Component_AddEdit
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlComponentEdit = new System.Windows.Forms.Panel();
			this.txtComponentLocation = new System.Windows.Forms.TextBox();
			this.txtComponentDescription = new System.Windows.Forms.TextBox();
			this.numComponentInventoryQty = new System.Windows.Forms.NumericUpDown();
			this.lblComponentInventoryQty = new System.Windows.Forms.Label();
			this.lblComponentCost = new System.Windows.Forms.Label();
			this.lblComponentLocation = new System.Windows.Forms.Label();
			this.lblComponentDescription = new System.Windows.Forms.Label();
			this.numComponentCost = new System.Windows.Forms.NumericUpDown();
			this.txtComponentNumber = new System.Windows.Forms.TextBox();
			this.lblComponentNumber = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnImport = new System.Windows.Forms.Button();
			this.pnlComponentEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numComponentInventoryQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numComponentCost)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(318, 179);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlComponentEdit
			// 
			this.pnlComponentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComponentEdit.Controls.Add(this.btnImport);
			this.pnlComponentEdit.Controls.Add(this.txtComponentLocation);
			this.pnlComponentEdit.Controls.Add(this.txtComponentDescription);
			this.pnlComponentEdit.Controls.Add(this.numComponentInventoryQty);
			this.pnlComponentEdit.Controls.Add(this.lblComponentInventoryQty);
			this.pnlComponentEdit.Controls.Add(this.lblComponentCost);
			this.pnlComponentEdit.Controls.Add(this.lblComponentLocation);
			this.pnlComponentEdit.Controls.Add(this.lblComponentDescription);
			this.pnlComponentEdit.Controls.Add(this.numComponentCost);
			this.pnlComponentEdit.Controls.Add(this.txtComponentNumber);
			this.pnlComponentEdit.Controls.Add(this.lblComponentNumber);
			this.pnlComponentEdit.Location = new System.Drawing.Point(12, 12);
			this.pnlComponentEdit.Name = "pnlComponentEdit";
			this.pnlComponentEdit.Size = new System.Drawing.Size(462, 161);
			this.pnlComponentEdit.TabIndex = 0;
			// 
			// txtComponentLocation
			// 
			this.txtComponentLocation.Location = new System.Drawing.Point(101, 82);
			this.txtComponentLocation.MaxLength = 16;
			this.txtComponentLocation.Name = "txtComponentLocation";
			this.txtComponentLocation.Size = new System.Drawing.Size(71, 20);
			this.txtComponentLocation.TabIndex = 7;
			this.txtComponentLocation.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtComponentDescription
			// 
			this.txtComponentDescription.Location = new System.Drawing.Point(101, 56);
			this.txtComponentDescription.MaxLength = 128;
			this.txtComponentDescription.Name = "txtComponentDescription";
			this.txtComponentDescription.Size = new System.Drawing.Size(359, 20);
			this.txtComponentDescription.TabIndex = 5;
			this.txtComponentDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// numComponentInventoryQty
			// 
			this.numComponentInventoryQty.Location = new System.Drawing.Point(101, 134);
			this.numComponentInventoryQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numComponentInventoryQty.Name = "numComponentInventoryQty";
			this.numComponentInventoryQty.Size = new System.Drawing.Size(71, 20);
			this.numComponentInventoryQty.TabIndex = 11;
			this.numComponentInventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numComponentInventoryQty.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblComponentInventoryQty
			// 
			this.lblComponentInventoryQty.AutoSize = true;
			this.lblComponentInventoryQty.Location = new System.Drawing.Point(25, 136);
			this.lblComponentInventoryQty.Name = "lblComponentInventoryQty";
			this.lblComponentInventoryQty.Size = new System.Drawing.Size(70, 13);
			this.lblComponentInventoryQty.TabIndex = 10;
			this.lblComponentInventoryQty.Text = "Inventory Qty";
			// 
			// lblComponentCost
			// 
			this.lblComponentCost.AutoSize = true;
			this.lblComponentCost.Location = new System.Drawing.Point(67, 110);
			this.lblComponentCost.Name = "lblComponentCost";
			this.lblComponentCost.Size = new System.Drawing.Size(28, 13);
			this.lblComponentCost.TabIndex = 8;
			this.lblComponentCost.Text = "Cost";
			// 
			// lblComponentLocation
			// 
			this.lblComponentLocation.AutoSize = true;
			this.lblComponentLocation.Location = new System.Drawing.Point(47, 85);
			this.lblComponentLocation.Name = "lblComponentLocation";
			this.lblComponentLocation.Size = new System.Drawing.Size(48, 13);
			this.lblComponentLocation.TabIndex = 6;
			this.lblComponentLocation.Text = "Location";
			// 
			// lblComponentDescription
			// 
			this.lblComponentDescription.AutoSize = true;
			this.lblComponentDescription.Location = new System.Drawing.Point(35, 59);
			this.lblComponentDescription.Name = "lblComponentDescription";
			this.lblComponentDescription.Size = new System.Drawing.Size(60, 13);
			this.lblComponentDescription.TabIndex = 4;
			this.lblComponentDescription.Text = "Description";
			// 
			// numComponentCost
			// 
			this.numComponentCost.DecimalPlaces = 3;
			this.numComponentCost.Location = new System.Drawing.Point(101, 108);
			this.numComponentCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.numComponentCost.Name = "numComponentCost";
			this.numComponentCost.Size = new System.Drawing.Size(71, 20);
			this.numComponentCost.TabIndex = 9;
			this.numComponentCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numComponentCost.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// txtComponentNumber
			// 
			this.txtComponentNumber.Location = new System.Drawing.Point(101, 30);
			this.txtComponentNumber.MaxLength = 32;
			this.txtComponentNumber.Name = "txtComponentNumber";
			this.txtComponentNumber.Size = new System.Drawing.Size(128, 20);
			this.txtComponentNumber.TabIndex = 3;
			this.txtComponentNumber.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblComponentNumber
			// 
			this.lblComponentNumber.AutoSize = true;
			this.lblComponentNumber.Location = new System.Drawing.Point(24, 33);
			this.lblComponentNumber.Name = "lblComponentNumber";
			this.lblComponentNumber.Size = new System.Drawing.Size(71, 13);
			this.lblComponentNumber.TabIndex = 2;
			this.lblComponentNumber.Text = "Component #";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(399, 179);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(306, 28);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(153, 23);
			this.btnImport.TabIndex = 13;
			this.btnImport.Text = "Import from Workbench";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// FormComponent_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(486, 214);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlComponentEdit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormComponent_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Component";
			this.pnlComponentEdit.ResumeLayout(false);
			this.pnlComponentEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numComponentInventoryQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numComponentCost)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlComponentEdit;
		private System.Windows.Forms.TextBox txtComponentLocation;
		private System.Windows.Forms.TextBox txtComponentDescription;
		private System.Windows.Forms.NumericUpDown numComponentInventoryQty;
		private System.Windows.Forms.Label lblComponentInventoryQty;
		private System.Windows.Forms.Label lblComponentCost;
		private System.Windows.Forms.Label lblComponentLocation;
		private System.Windows.Forms.Label lblComponentDescription;
		private System.Windows.Forms.NumericUpDown numComponentCost;
		private System.Windows.Forms.TextBox txtComponentNumber;
		private System.Windows.Forms.Label lblComponentNumber;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnImport;
	}
}