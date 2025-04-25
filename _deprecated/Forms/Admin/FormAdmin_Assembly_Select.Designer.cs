namespace SDB.Forms.Admin
{
	partial class FormAdmin_Assembly_Select
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
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlAssembly = new System.Windows.Forms.Panel();
			this.cmbAssembly = new System.Windows.Forms.ComboBox();
			this.lblAssembly = new System.Windows.Forms.Label();
			this.pnlAssembly.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(366, 91);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(447, 91);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlAssembly
			// 
			this.pnlAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAssembly.Controls.Add(this.cmbAssembly);
			this.pnlAssembly.Controls.Add(this.lblAssembly);
			this.pnlAssembly.Location = new System.Drawing.Point(12, 12);
			this.pnlAssembly.Name = "pnlAssembly";
			this.pnlAssembly.Size = new System.Drawing.Size(510, 73);
			this.pnlAssembly.TabIndex = 0;
			// 
			// cmbAssembly
			// 
			this.cmbAssembly.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssembly.FormattingEnabled = true;
			this.cmbAssembly.Location = new System.Drawing.Point(3, 32);
			this.cmbAssembly.Name = "cmbAssembly";
			this.cmbAssembly.Size = new System.Drawing.Size(504, 21);
			this.cmbAssembly.TabIndex = 1;
			this.cmbAssembly.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAssembly_DrawItem);
			// 
			// lblAssembly
			// 
			this.lblAssembly.AutoSize = true;
			this.lblAssembly.Location = new System.Drawing.Point(3, 16);
			this.lblAssembly.Name = "lblAssembly";
			this.lblAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblAssembly.TabIndex = 0;
			this.lblAssembly.Text = "Assembly";
			// 
			// FormAssembly_Select
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(534, 126);
			this.Controls.Add(this.pnlAssembly);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAssembly_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Assembly";
			this.pnlAssembly.ResumeLayout(false);
			this.pnlAssembly.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.Label lblAssembly;
	}
}