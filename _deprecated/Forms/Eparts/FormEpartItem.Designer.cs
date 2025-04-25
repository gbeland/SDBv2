namespace SDB.Forms.Eparts
{
	partial class FormEpartItem
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.cmbAssembly = new System.Windows.Forms.ComboBox();
            this.timerLookupRma = new System.Windows.Forms.Timer(this.components);
            this.timerLookupTicket = new System.Windows.Forms.Timer(this.components);
            this.pnlShipmentItem = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.pnlShipmentItem.SuspendLayout();
            this.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(433, 166);
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
            this.btnOK.Location = new System.Drawing.Point(514, 166);
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(73, 46);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(78, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Assembly Type";
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
            // 
            // timerLookupTicket
            // 
            this.timerLookupTicket.Interval = 500;
            // 
            // pnlShipmentItem
            // 
            this.pnlShipmentItem.Controls.Add(this.lblQuantity);
            this.pnlShipmentItem.Controls.Add(this.numQty);
            this.pnlShipmentItem.Controls.Add(this.cmbCategory);
            this.pnlShipmentItem.Controls.Add(this.cmbType);
            this.pnlShipmentItem.Controls.Add(this.lblCategory);
            this.pnlShipmentItem.Controls.Add(this.lblType);
            this.pnlShipmentItem.Controls.Add(this.lblAssembly);
            this.pnlShipmentItem.Controls.Add(this.cmbAssembly);
            this.pnlShipmentItem.Location = new System.Drawing.Point(13, 13);
            this.pnlShipmentItem.Name = "pnlShipmentItem";
            this.pnlShipmentItem.Size = new System.Drawing.Size(579, 141);
            this.pnlShipmentItem.TabIndex = 2;
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
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(73, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // FormEpartItem
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(602, 202);
            this.Controls.Add(this.pnlShipmentItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEpartItem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Order Item";
            this.Shown += new System.EventHandler(this.FormShipmentItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.pnlShipmentItem.ResumeLayout(false);
            this.pnlShipmentItem.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.NumericUpDown numQty;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.Timer timerLookupRma;
		private System.Windows.Forms.Timer timerLookupTicket;
		private System.Windows.Forms.Panel pnlShipmentItem;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label lblCategory;
	}
}