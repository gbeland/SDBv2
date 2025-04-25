namespace SDB.Forms.Admin
{
	partial class FormAdmin_Salespeople_AddEdit
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
			this.pnlSalesperson_Edit = new System.Windows.Forms.Panel();
			this.lblMobile = new System.Windows.Forms.Label();
			this.lblOffice = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblCSZ = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.txtOffice = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtZip = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.lblLast = new System.Windows.Forms.Label();
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.lblFirst = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlSalesperson_Edit.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(218, 250);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlSalesperson_Edit
			// 
			this.pnlSalesperson_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSalesperson_Edit.Controls.Add(this.lblMobile);
			this.pnlSalesperson_Edit.Controls.Add(this.lblOffice);
			this.pnlSalesperson_Edit.Controls.Add(this.lblEmail);
			this.pnlSalesperson_Edit.Controls.Add(this.lblCountry);
			this.pnlSalesperson_Edit.Controls.Add(this.lblCSZ);
			this.pnlSalesperson_Edit.Controls.Add(this.lblAddress);
			this.pnlSalesperson_Edit.Controls.Add(this.txtMobile);
			this.pnlSalesperson_Edit.Controls.Add(this.txtOffice);
			this.pnlSalesperson_Edit.Controls.Add(this.txtEmail);
			this.pnlSalesperson_Edit.Controls.Add(this.txtCountry);
			this.pnlSalesperson_Edit.Controls.Add(this.txtZip);
			this.pnlSalesperson_Edit.Controls.Add(this.txtState);
			this.pnlSalesperson_Edit.Controls.Add(this.txtCity);
			this.pnlSalesperson_Edit.Controls.Add(this.txtAddress);
			this.pnlSalesperson_Edit.Controls.Add(this.txtLast);
			this.pnlSalesperson_Edit.Controls.Add(this.lblLast);
			this.pnlSalesperson_Edit.Controls.Add(this.txtFirst);
			this.pnlSalesperson_Edit.Controls.Add(this.lblFirst);
			this.pnlSalesperson_Edit.Location = new System.Drawing.Point(12, 12);
			this.pnlSalesperson_Edit.Name = "pnlSalesperson_Edit";
			this.pnlSalesperson_Edit.Size = new System.Drawing.Size(362, 232);
			this.pnlSalesperson_Edit.TabIndex = 0;
			// 
			// lblMobile
			// 
			this.lblMobile.AutoSize = true;
			this.lblMobile.Location = new System.Drawing.Point(13, 200);
			this.lblMobile.Name = "lblMobile";
			this.lblMobile.Size = new System.Drawing.Size(72, 13);
			this.lblMobile.TabIndex = 16;
			this.lblMobile.Text = "Mobile Phone";
			// 
			// lblOffice
			// 
			this.lblOffice.AutoSize = true;
			this.lblOffice.Location = new System.Drawing.Point(16, 174);
			this.lblOffice.Name = "lblOffice";
			this.lblOffice.Size = new System.Drawing.Size(69, 13);
			this.lblOffice.TabIndex = 14;
			this.lblOffice.Text = "Office Phone";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(53, 148);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(32, 13);
			this.lblEmail.TabIndex = 12;
			this.lblEmail.Text = "Email";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(42, 122);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(43, 13);
			this.lblCountry.TabIndex = 10;
			this.lblCountry.Text = "Country";
			// 
			// lblCSZ
			// 
			this.lblCSZ.AutoSize = true;
			this.lblCSZ.Location = new System.Drawing.Point(11, 96);
			this.lblCSZ.Name = "lblCSZ";
			this.lblCSZ.Size = new System.Drawing.Size(74, 13);
			this.lblCSZ.TabIndex = 6;
			this.lblCSZ.Text = "City/State/Zip";
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(40, 70);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(45, 13);
			this.lblAddress.TabIndex = 4;
			this.lblAddress.Text = "Address";
			// 
			// txtMobile
			// 
			this.txtMobile.Location = new System.Drawing.Point(91, 197);
			this.txtMobile.MaxLength = 20;
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(135, 20);
			this.txtMobile.TabIndex = 17;
			this.txtMobile.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtOffice
			// 
			this.txtOffice.Location = new System.Drawing.Point(91, 171);
			this.txtOffice.MaxLength = 20;
			this.txtOffice.Name = "txtOffice";
			this.txtOffice.Size = new System.Drawing.Size(135, 20);
			this.txtOffice.TabIndex = 15;
			this.txtOffice.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(91, 145);
			this.txtEmail.MaxLength = 128;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(259, 20);
			this.txtEmail.TabIndex = 13;
			this.txtEmail.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(91, 119);
			this.txtCountry.MaxLength = 32;
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(135, 20);
			this.txtCountry.TabIndex = 11;
			this.txtCountry.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(287, 93);
			this.txtZip.MaxLength = 15;
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(63, 20);
			this.txtZip.TabIndex = 9;
			this.txtZip.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(232, 93);
			this.txtState.MaxLength = 2;
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(49, 20);
			this.txtState.TabIndex = 8;
			this.txtState.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(91, 93);
			this.txtCity.MaxLength = 30;
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(135, 20);
			this.txtCity.TabIndex = 7;
			this.txtCity.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(91, 67);
			this.txtAddress.MaxLength = 50;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(259, 20);
			this.txtAddress.TabIndex = 5;
			this.txtAddress.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtLast
			// 
			this.txtLast.Location = new System.Drawing.Point(91, 41);
			this.txtLast.MaxLength = 32;
			this.txtLast.Name = "txtLast";
			this.txtLast.Size = new System.Drawing.Size(135, 20);
			this.txtLast.TabIndex = 3;
			this.txtLast.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblLast
			// 
			this.lblLast.AutoSize = true;
			this.lblLast.Location = new System.Drawing.Point(27, 44);
			this.lblLast.Name = "lblLast";
			this.lblLast.Size = new System.Drawing.Size(58, 13);
			this.lblLast.TabIndex = 2;
			this.lblLast.Text = "Last Name";
			// 
			// txtFirst
			// 
			this.txtFirst.Location = new System.Drawing.Point(91, 15);
			this.txtFirst.MaxLength = 32;
			this.txtFirst.Name = "txtFirst";
			this.txtFirst.Size = new System.Drawing.Size(135, 20);
			this.txtFirst.TabIndex = 1;
			this.txtFirst.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblFirst
			// 
			this.lblFirst.AutoSize = true;
			this.lblFirst.Location = new System.Drawing.Point(28, 18);
			this.lblFirst.Name = "lblFirst";
			this.lblFirst.Size = new System.Drawing.Size(57, 13);
			this.lblFirst.TabIndex = 0;
			this.lblFirst.Text = "First Name";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(299, 250);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormSalespeople_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(386, 285);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlSalesperson_Edit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSalespeople_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Salesperson";
			this.pnlSalesperson_Edit.ResumeLayout(false);
			this.pnlSalesperson_Edit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlSalesperson_Edit;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.Label lblFirst;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblMobile;
		private System.Windows.Forms.Label lblOffice;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblCSZ;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.TextBox txtOffice;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtZip;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.Label lblLast;
	}
}