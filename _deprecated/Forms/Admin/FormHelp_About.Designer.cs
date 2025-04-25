namespace SDB.Forms.Admin
{
	sealed partial class FormHelp_About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp_About));
			this.lblProduct = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.pnlInfo = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.pnlInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProduct.Location = new System.Drawing.Point(6, 9);
			this.lblProduct.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lblProduct.MaximumSize = new System.Drawing.Size(0, 17);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(96, 17);
			this.lblProduct.TabIndex = 19;
			this.lblProduct.Text = "Product Name";
			this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.Location = new System.Drawing.Point(6, 34);
			this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(46, 13);
			this.lblVersion.TabIndex = 0;
			this.lblVersion.Text = "Version";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopyright.Location = new System.Drawing.Point(6, 55);
			this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(58, 13);
			this.lblCopyright.TabIndex = 21;
			this.lblCopyright.Text = "Copyright";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCompany.Location = new System.Drawing.Point(6, 76);
			this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.lblCompany.MaximumSize = new System.Drawing.Size(0, 17);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(87, 13);
			this.lblCompany.TabIndex = 22;
			this.lblCompany.Text = "Company Name";
			this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescription.Location = new System.Drawing.Point(6, 98);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDescription.Size = new System.Drawing.Size(377, 72);
			this.txtDescription.TabIndex = 23;
			this.txtDescription.TabStop = false;
			this.txtDescription.Text = "Description";
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(308, 176);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			// 
			// pbLogo
			// 
			this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.Location = new System.Drawing.Point(9, 9);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(390, 196);
			this.pbLogo.TabIndex = 13;
			this.pbLogo.TabStop = false;
			// 
			// pnlInfo
			// 
			this.pnlInfo.Controls.Add(this.txtDescription);
			this.pnlInfo.Controls.Add(this.okButton);
			this.pnlInfo.Controls.Add(this.lblCompany);
			this.pnlInfo.Controls.Add(this.lblCopyright);
			this.pnlInfo.Controls.Add(this.lblVersion);
			this.pnlInfo.Controls.Add(this.lblProduct);
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlInfo.Location = new System.Drawing.Point(9, 205);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(390, 204);
			this.pnlInfo.TabIndex = 14;
			// 
			// FormHelp_About
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 418);
			this.Controls.Add(this.pnlInfo);
			this.Controls.Add(this.pbLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormHelp_About";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.pnlInfo.ResumeLayout(false);
			this.pnlInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.Label lblCompany;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Panel pnlInfo;
	}
}
