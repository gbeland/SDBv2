namespace SDB.Forms.Admin
{
	sealed partial class FormAdmin_Email_AddEdit
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
			this.pnlAdminEmail_Edit = new System.Windows.Forms.Panel();
			this.txtAdminEmail_Name = new System.Windows.Forms.TextBox();
			this.lblAdminEmail_Name = new System.Windows.Forms.Label();
			this.txtAdminEmail_EmailAddress = new System.Windows.Forms.TextBox();
			this.lblAdminEmail_EmailAddress = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlAdminEmail_Edit.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(526, 179);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlAdminEmail_Edit
			// 
			this.pnlAdminEmail_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAdminEmail_Edit.Controls.Add(this.txtAdminEmail_Name);
			this.pnlAdminEmail_Edit.Controls.Add(this.lblAdminEmail_Name);
			this.pnlAdminEmail_Edit.Controls.Add(this.txtAdminEmail_EmailAddress);
			this.pnlAdminEmail_Edit.Controls.Add(this.lblAdminEmail_EmailAddress);
			this.pnlAdminEmail_Edit.Location = new System.Drawing.Point(12, 12);
			this.pnlAdminEmail_Edit.Name = "pnlAdminEmail_Edit";
			this.pnlAdminEmail_Edit.Size = new System.Drawing.Size(670, 161);
			this.pnlAdminEmail_Edit.TabIndex = 0;
			// 
			// txtAdminEmail_Name
			// 
			this.txtAdminEmail_Name.Location = new System.Drawing.Point(80, 15);
			this.txtAdminEmail_Name.MaxLength = 32;
			this.txtAdminEmail_Name.Name = "txtAdminEmail_Name";
			this.txtAdminEmail_Name.Size = new System.Drawing.Size(179, 20);
			this.txtAdminEmail_Name.TabIndex = 1;
			this.txtAdminEmail_Name.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAdminEmail_Name
			// 
			this.lblAdminEmail_Name.AutoSize = true;
			this.lblAdminEmail_Name.Location = new System.Drawing.Point(17, 18);
			this.lblAdminEmail_Name.Name = "lblAdminEmail_Name";
			this.lblAdminEmail_Name.Size = new System.Drawing.Size(35, 13);
			this.lblAdminEmail_Name.TabIndex = 0;
			this.lblAdminEmail_Name.Text = "Name";
			// 
			// txtAdminEmail_EmailAddress
			// 
			this.txtAdminEmail_EmailAddress.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdminEmail_EmailAddress.Location = new System.Drawing.Point(80, 41);
			this.txtAdminEmail_EmailAddress.MaxLength = 128;
			this.txtAdminEmail_EmailAddress.Name = "txtAdminEmail_EmailAddress";
			this.txtAdminEmail_EmailAddress.Size = new System.Drawing.Size(312, 20);
			this.txtAdminEmail_EmailAddress.TabIndex = 3;
			this.txtAdminEmail_EmailAddress.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAdminEmail_EmailAddress
			// 
			this.lblAdminEmail_EmailAddress.AutoSize = true;
			this.lblAdminEmail_EmailAddress.Location = new System.Drawing.Point(17, 44);
			this.lblAdminEmail_EmailAddress.Name = "lblAdminEmail_EmailAddress";
			this.lblAdminEmail_EmailAddress.Size = new System.Drawing.Size(32, 13);
			this.lblAdminEmail_EmailAddress.TabIndex = 2;
			this.lblAdminEmail_EmailAddress.Text = "Email";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(607, 179);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormAdminEmail_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(694, 214);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlAdminEmail_Edit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdminEmail_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Admin Email";
			this.pnlAdminEmail_Edit.ResumeLayout(false);
			this.pnlAdminEmail_Edit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlAdminEmail_Edit;
		private System.Windows.Forms.TextBox txtAdminEmail_Name;
		private System.Windows.Forms.Label lblAdminEmail_Name;
		private System.Windows.Forms.TextBox txtAdminEmail_EmailAddress;
		private System.Windows.Forms.Label lblAdminEmail_EmailAddress;
		private System.Windows.Forms.Button btnOK;
	}
}