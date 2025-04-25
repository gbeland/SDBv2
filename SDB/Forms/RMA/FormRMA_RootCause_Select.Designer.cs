namespace SDB.Forms.RMA
{
	partial class FormRMA_RootCause_Select
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
			this.pnlRootCause = new System.Windows.Forms.Panel();
			this.cmbRootCause = new System.Windows.Forms.ComboBox();
			this.lblRootCause = new System.Windows.Forms.Label();
			this.pnlRootCause.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(275, 91);
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
			this.btnOK.Location = new System.Drawing.Point(356, 91);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlRootCause
			// 
			this.pnlRootCause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlRootCause.Controls.Add(this.cmbRootCause);
			this.pnlRootCause.Controls.Add(this.lblRootCause);
			this.pnlRootCause.Location = new System.Drawing.Point(12, 12);
			this.pnlRootCause.Name = "pnlRootCause";
			this.pnlRootCause.Size = new System.Drawing.Size(419, 73);
			this.pnlRootCause.TabIndex = 0;
			// 
			// cmbRootCause
			// 
			this.cmbRootCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRootCause.FormattingEnabled = true;
			this.cmbRootCause.Location = new System.Drawing.Point(3, 32);
			this.cmbRootCause.Name = "cmbRootCause";
			this.cmbRootCause.Size = new System.Drawing.Size(413, 21);
			this.cmbRootCause.TabIndex = 1;
			// 
			// lblRootCause
			// 
			this.lblRootCause.AutoSize = true;
			this.lblRootCause.Location = new System.Drawing.Point(3, 16);
			this.lblRootCause.Name = "lblRootCause";
			this.lblRootCause.Size = new System.Drawing.Size(63, 13);
			this.lblRootCause.TabIndex = 0;
			this.lblRootCause.Text = "Root Cause";
			// 
			// FormRMA_RootCause_Select
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(443, 126);
			this.Controls.Add(this.pnlRootCause);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_RootCause_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Assembly: Select Root Cause";
			this.pnlRootCause.ResumeLayout(false);
			this.pnlRootCause.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlRootCause;
		private System.Windows.Forms.ComboBox cmbRootCause;
		private System.Windows.Forms.Label lblRootCause;
	}
}