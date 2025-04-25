namespace SDB.Forms.Assembly
{
	partial class FormAssemblyType_Select
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
			this.lblInfo = new System.Windows.Forms.Label();
			this.numQty = new System.Windows.Forms.NumericUpDown();
			this.cmbAssemblyTypes = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(9, 28);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(179, 13);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.Text = "Select a quantity and assembly type:";
			// 
			// numQty
			// 
			this.numQty.Location = new System.Drawing.Point(12, 56);
			this.numQty.Maximum = new decimal(new int[] {
            9999,
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
			this.numQty.TabIndex = 0;
			this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numQty.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// cmbAssemblyTypes
			// 
			this.cmbAssemblyTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssemblyTypes.FormattingEnabled = true;
			this.cmbAssemblyTypes.Location = new System.Drawing.Point(85, 55);
			this.cmbAssemblyTypes.Name = "cmbAssemblyTypes";
			this.cmbAssemblyTypes.Size = new System.Drawing.Size(437, 21);
			this.cmbAssemblyTypes.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(447, 112);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(366, 112);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormAssemblyType_Select
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(534, 147);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cmbAssemblyTypes);
			this.Controls.Add(this.numQty);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAssemblyType_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select an Assembly Type";
			this.Load += new System.EventHandler(this.FormAssemblyTypeSelector_Load);
			((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numQty;
		private System.Windows.Forms.ComboBox cmbAssemblyTypes;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblInfo;
	}
}