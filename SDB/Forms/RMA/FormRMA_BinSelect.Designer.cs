namespace SDB.Forms.RMA
{
	partial class FormRMA_BinSelect
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
			this.txtBinIDInput = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.cmbBinList = new System.Windows.Forms.ComboBox();
			this.radList = new System.Windows.Forms.RadioButton();
			this.radScan = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// txtBinIDInput
			// 
			this.txtBinIDInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBinIDInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBinIDInput.Location = new System.Drawing.Point(12, 35);
			this.txtBinIDInput.MaxLength = 7;
			this.txtBinIDInput.Name = "txtBinIDInput";
			this.txtBinIDInput.Size = new System.Drawing.Size(260, 26);
			this.txtBinIDInput.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(116, 132);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(197, 132);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cmbBinList
			// 
			this.cmbBinList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBinList.Enabled = false;
			this.cmbBinList.FormattingEnabled = true;
			this.cmbBinList.Location = new System.Drawing.Point(12, 91);
			this.cmbBinList.Name = "cmbBinList";
			this.cmbBinList.Size = new System.Drawing.Size(260, 21);
			this.cmbBinList.TabIndex = 3;
			// 
			// radList
			// 
			this.radList.AutoCheck = false;
			this.radList.AutoSize = true;
			this.radList.Location = new System.Drawing.Point(12, 68);
			this.radList.Name = "radList";
			this.radList.Size = new System.Drawing.Size(96, 17);
			this.radList.TabIndex = 6;
			this.radList.Text = "Select from list:";
			this.radList.UseVisualStyleBackColor = true;
			this.radList.Click += new System.EventHandler(this.radList_Click);
			// 
			// radScan
			// 
			this.radScan.AutoCheck = false;
			this.radScan.AutoSize = true;
			this.radScan.Checked = true;
			this.radScan.Location = new System.Drawing.Point(12, 12);
			this.radScan.Name = "radScan";
			this.radScan.Size = new System.Drawing.Size(123, 17);
			this.radScan.TabIndex = 7;
			this.radScan.TabStop = true;
			this.radScan.Text = "Enter or scan Bin ID:";
			this.radScan.UseVisualStyleBackColor = true;
			this.radScan.Click += new System.EventHandler(this.radScan_Click);
			// 
			// FormRMA_BinSelect
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(284, 167);
			this.Controls.Add(this.radScan);
			this.Controls.Add(this.radList);
			this.Controls.Add(this.cmbBinList);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtBinIDInput);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_BinSelect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select RMA Bin";
			this.Load += new System.EventHandler(this.FormRMA_BinSelect_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBinIDInput;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ComboBox cmbBinList;
		private System.Windows.Forms.RadioButton radList;
		private System.Windows.Forms.RadioButton radScan;
	}
}