namespace SDB.Forms.Asset
{
	partial class FormAsset_SparePartAddEdit
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
			this.lblAssembly = new System.Windows.Forms.Label();
			this.cmbAssembly = new System.Windows.Forms.ComboBox();
			this.lblAssemblyType = new System.Windows.Forms.Label();
			this.cmbAssemblyType = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.numQuantity = new System.Windows.Forms.NumericUpDown();
			this.numExpected = new System.Windows.Forms.NumericUpDown();
			this.lblExpected = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numExpected)).BeginInit();
			this.SuspendLayout();
			// 
			// lblAssembly
			// 
			this.lblAssembly.AutoSize = true;
			this.lblAssembly.Location = new System.Drawing.Point(9, 65);
			this.lblAssembly.Name = "lblAssembly";
			this.lblAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblAssembly.TabIndex = 17;
			this.lblAssembly.Text = "Assembly";
			// 
			// cmbAssembly
			// 
			this.cmbAssembly.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssembly.FormattingEnabled = true;
			this.cmbAssembly.Location = new System.Drawing.Point(12, 81);
			this.cmbAssembly.Name = "cmbAssembly";
			this.cmbAssembly.Size = new System.Drawing.Size(500, 21);
			this.cmbAssembly.TabIndex = 18;
			this.cmbAssembly.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAssembly_DrawItem);
			// 
			// lblAssemblyType
			// 
			this.lblAssemblyType.AutoSize = true;
			this.lblAssemblyType.Location = new System.Drawing.Point(9, 25);
			this.lblAssemblyType.Name = "lblAssemblyType";
			this.lblAssemblyType.Size = new System.Drawing.Size(78, 13);
			this.lblAssemblyType.TabIndex = 15;
			this.lblAssemblyType.Text = "Assembly Type";
			// 
			// cmbAssemblyType
			// 
			this.cmbAssemblyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssemblyType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssemblyType.FormattingEnabled = true;
			this.cmbAssemblyType.Location = new System.Drawing.Point(12, 41);
			this.cmbAssemblyType.Name = "cmbAssemblyType";
			this.cmbAssemblyType.Size = new System.Drawing.Size(500, 21);
			this.cmbAssemblyType.TabIndex = 16;
			this.cmbAssemblyType.SelectedIndexChanged += new System.EventHandler(this.cmbAssemblyType_SelectedIndexChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(443, 130);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 19;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(362, 130);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(9, 114);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(46, 13);
			this.lblQuantity.TabIndex = 21;
			this.lblQuantity.Text = "Quantity";
			// 
			// numQuantity
			// 
			this.numQuantity.Location = new System.Drawing.Point(12, 130);
			this.numQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numQuantity.Name = "numQuantity";
			this.numQuantity.Size = new System.Drawing.Size(75, 20);
			this.numQuantity.TabIndex = 22;
			this.numQuantity.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// numExpected
			// 
			this.numExpected.Location = new System.Drawing.Point(109, 130);
			this.numExpected.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numExpected.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numExpected.Name = "numExpected";
			this.numExpected.Size = new System.Drawing.Size(75, 20);
			this.numExpected.TabIndex = 24;
			this.numExpected.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numExpected.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblExpected
			// 
			this.lblExpected.AutoSize = true;
			this.lblExpected.Location = new System.Drawing.Point(106, 114);
			this.lblExpected.Name = "lblExpected";
			this.lblExpected.Size = new System.Drawing.Size(52, 13);
			this.lblExpected.TabIndex = 23;
			this.lblExpected.Text = "Expected";
			// 
			// FormAsset_SparePartAddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(530, 165);
			this.Controls.Add(this.numExpected);
			this.Controls.Add(this.lblExpected);
			this.Controls.Add(this.numQuantity);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblAssembly);
			this.Controls.Add(this.cmbAssembly);
			this.Controls.Add(this.lblAssemblyType);
			this.Controls.Add(this.cmbAssemblyType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAsset_SparePartAddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configure Spare Part";
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numExpected)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.Label lblAssemblyType;
		private System.Windows.Forms.ComboBox cmbAssemblyType;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.NumericUpDown numQuantity;
		private System.Windows.Forms.NumericUpDown numExpected;
		private System.Windows.Forms.Label lblExpected;
	}
}