namespace SDB.Forms.Admin
{
	partial class FormAdmin_User_Details
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
			this.txtUser_Email = new System.Windows.Forms.TextBox();
			this.btnUser_Update = new System.Windows.Forms.Button();
			this.txtUser_LastName = new System.Windows.Forms.TextBox();
			this.txtUser_FirstName = new System.Windows.Forms.TextBox();
			this.txtUser_Login = new System.Windows.Forms.TextBox();
			this.lblUser_Email = new System.Windows.Forms.Label();
			this.lblUser_LastName = new System.Windows.Forms.Label();
			this.lblUser_Login = new System.Windows.Forms.Label();
			this.lblUser_FirstName = new System.Windows.Forms.Label();
			this.btnPassword_Change = new System.Windows.Forms.Button();
			this.txtPassword_Confirm = new System.Windows.Forms.TextBox();
			this.txtPassword_New = new System.Windows.Forms.TextBox();
			this.txtPassword_Current = new System.Windows.Forms.TextBox();
			this.lblPassword_Confirm = new System.Windows.Forms.Label();
			this.lblPassword_Current = new System.Windows.Forms.Label();
			this.lblPassword_New = new System.Windows.Forms.Label();
			this.txtPin_New = new System.Windows.Forms.TextBox();
			this.lblPin_New = new System.Windows.Forms.Label();
			this.btnPin_Change = new System.Windows.Forms.Button();
			this.txtPin_Confirm = new System.Windows.Forms.TextBox();
			this.lblPin_Confirm = new System.Windows.Forms.Label();
			this.pnlPin = new System.Windows.Forms.Panel();
			this.lblPin = new System.Windows.Forms.Label();
			this.pnlPassword = new System.Windows.Forms.Panel();
			this.lblPassword = new System.Windows.Forms.Label();
			this.pnlUserDetails = new System.Windows.Forms.Panel();
			this.lblUserDetails = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlPin.SuspendLayout();
			this.pnlPassword.SuspendLayout();
			this.pnlUserDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUser_Email
			// 
			this.txtUser_Email.Location = new System.Drawing.Point(111, 94);
			this.txtUser_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUser_Email.MaxLength = 35;
			this.txtUser_Email.Name = "txtUser_Email";
			this.txtUser_Email.Size = new System.Drawing.Size(163, 20);
			this.txtUser_Email.TabIndex = 7;
			this.txtUser_Email.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// btnUser_Update
			// 
			this.btnUser_Update.AutoSize = true;
			this.btnUser_Update.Location = new System.Drawing.Point(164, 118);
			this.btnUser_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUser_Update.Name = "btnUser_Update";
			this.btnUser_Update.Size = new System.Drawing.Size(110, 23);
			this.btnUser_Update.TabIndex = 8;
			this.btnUser_Update.Text = "Update";
			this.btnUser_Update.UseVisualStyleBackColor = true;
			this.btnUser_Update.Click += new System.EventHandler(this.btnUser_Update_Click);
			// 
			// txtUser_LastName
			// 
			this.txtUser_LastName.Location = new System.Drawing.Point(111, 69);
			this.txtUser_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUser_LastName.MaxLength = 20;
			this.txtUser_LastName.Name = "txtUser_LastName";
			this.txtUser_LastName.Size = new System.Drawing.Size(163, 20);
			this.txtUser_LastName.TabIndex = 5;
			this.txtUser_LastName.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtUser_FirstName
			// 
			this.txtUser_FirstName.Location = new System.Drawing.Point(111, 44);
			this.txtUser_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUser_FirstName.MaxLength = 20;
			this.txtUser_FirstName.Name = "txtUser_FirstName";
			this.txtUser_FirstName.Size = new System.Drawing.Size(163, 20);
			this.txtUser_FirstName.TabIndex = 3;
			this.txtUser_FirstName.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtUser_Login
			// 
			this.txtUser_Login.Location = new System.Drawing.Point(111, 19);
			this.txtUser_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUser_Login.MaxLength = 10;
			this.txtUser_Login.Name = "txtUser_Login";
			this.txtUser_Login.ReadOnly = true;
			this.txtUser_Login.Size = new System.Drawing.Size(163, 20);
			this.txtUser_Login.TabIndex = 1;
			this.txtUser_Login.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblUser_Email
			// 
			this.lblUser_Email.AutoSize = true;
			this.lblUser_Email.Location = new System.Drawing.Point(66, 97);
			this.lblUser_Email.Name = "lblUser_Email";
			this.lblUser_Email.Size = new System.Drawing.Size(39, 13);
			this.lblUser_Email.TabIndex = 6;
			this.lblUser_Email.Text = "E-Mail:";
			this.lblUser_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUser_LastName
			// 
			this.lblUser_LastName.AutoSize = true;
			this.lblUser_LastName.Location = new System.Drawing.Point(44, 72);
			this.lblUser_LastName.Name = "lblUser_LastName";
			this.lblUser_LastName.Size = new System.Drawing.Size(61, 13);
			this.lblUser_LastName.TabIndex = 4;
			this.lblUser_LastName.Text = "Last Name:";
			this.lblUser_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUser_Login
			// 
			this.lblUser_Login.AutoSize = true;
			this.lblUser_Login.Location = new System.Drawing.Point(44, 22);
			this.lblUser_Login.Name = "lblUser_Login";
			this.lblUser_Login.Size = new System.Drawing.Size(61, 13);
			this.lblUser_Login.TabIndex = 0;
			this.lblUser_Login.Text = "User Login:";
			this.lblUser_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUser_FirstName
			// 
			this.lblUser_FirstName.AutoSize = true;
			this.lblUser_FirstName.Location = new System.Drawing.Point(45, 47);
			this.lblUser_FirstName.Name = "lblUser_FirstName";
			this.lblUser_FirstName.Size = new System.Drawing.Size(60, 13);
			this.lblUser_FirstName.TabIndex = 2;
			this.lblUser_FirstName.Text = "First Name:";
			this.lblUser_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPassword_Change
			// 
			this.btnPassword_Change.AutoSize = true;
			this.btnPassword_Change.Location = new System.Drawing.Point(164, 93);
			this.btnPassword_Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPassword_Change.Name = "btnPassword_Change";
			this.btnPassword_Change.Size = new System.Drawing.Size(110, 23);
			this.btnPassword_Change.TabIndex = 6;
			this.btnPassword_Change.Text = "Change Password";
			this.btnPassword_Change.UseVisualStyleBackColor = true;
			this.btnPassword_Change.Click += new System.EventHandler(this.btnPassword_Change_Click);
			// 
			// txtPassword_Confirm
			// 
			this.txtPassword_Confirm.Location = new System.Drawing.Point(111, 69);
			this.txtPassword_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword_Confirm.MaxLength = 64;
			this.txtPassword_Confirm.Name = "txtPassword_Confirm";
			this.txtPassword_Confirm.Size = new System.Drawing.Size(163, 20);
			this.txtPassword_Confirm.TabIndex = 5;
			this.txtPassword_Confirm.UseSystemPasswordChar = true;
			this.txtPassword_Confirm.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtPassword_New
			// 
			this.txtPassword_New.Location = new System.Drawing.Point(111, 44);
			this.txtPassword_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword_New.MaxLength = 64;
			this.txtPassword_New.Name = "txtPassword_New";
			this.txtPassword_New.Size = new System.Drawing.Size(163, 20);
			this.txtPassword_New.TabIndex = 3;
			this.txtPassword_New.UseSystemPasswordChar = true;
			this.txtPassword_New.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// txtPassword_Current
			// 
			this.txtPassword_Current.Location = new System.Drawing.Point(111, 19);
			this.txtPassword_Current.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPassword_Current.MaxLength = 64;
			this.txtPassword_Current.Name = "txtPassword_Current";
			this.txtPassword_Current.Size = new System.Drawing.Size(163, 20);
			this.txtPassword_Current.TabIndex = 1;
			this.txtPassword_Current.UseSystemPasswordChar = true;
			this.txtPassword_Current.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblPassword_Confirm
			// 
			this.lblPassword_Confirm.AutoSize = true;
			this.lblPassword_Confirm.Location = new System.Drawing.Point(11, 72);
			this.lblPassword_Confirm.Name = "lblPassword_Confirm";
			this.lblPassword_Confirm.Size = new System.Drawing.Size(94, 13);
			this.lblPassword_Confirm.TabIndex = 4;
			this.lblPassword_Confirm.Text = "Confirm Password:";
			this.lblPassword_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPassword_Current
			// 
			this.lblPassword_Current.AutoSize = true;
			this.lblPassword_Current.Location = new System.Drawing.Point(12, 22);
			this.lblPassword_Current.Name = "lblPassword_Current";
			this.lblPassword_Current.Size = new System.Drawing.Size(93, 13);
			this.lblPassword_Current.TabIndex = 0;
			this.lblPassword_Current.Text = "Current Password:";
			this.lblPassword_Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPassword_New
			// 
			this.lblPassword_New.AutoSize = true;
			this.lblPassword_New.Location = new System.Drawing.Point(24, 47);
			this.lblPassword_New.Name = "lblPassword_New";
			this.lblPassword_New.Size = new System.Drawing.Size(81, 13);
			this.lblPassword_New.TabIndex = 2;
			this.lblPassword_New.Text = "New Password:";
			this.lblPassword_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPin_New
			// 
			this.txtPin_New.Location = new System.Drawing.Point(111, 22);
			this.txtPin_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPin_New.MaxLength = 64;
			this.txtPin_New.Name = "txtPin_New";
			this.txtPin_New.Size = new System.Drawing.Size(83, 20);
			this.txtPin_New.TabIndex = 3;
			this.txtPin_New.UseSystemPasswordChar = true;
			this.txtPin_New.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblPin_New
			// 
			this.lblPin_New.AutoSize = true;
			this.lblPin_New.Location = new System.Drawing.Point(52, 25);
			this.lblPin_New.Name = "lblPin_New";
			this.lblPin_New.Size = new System.Drawing.Size(53, 13);
			this.lblPin_New.TabIndex = 2;
			this.lblPin_New.Text = "New PIN:";
			this.lblPin_New.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPin_Change
			// 
			this.btnPin_Change.AutoSize = true;
			this.btnPin_Change.Location = new System.Drawing.Point(164, 91);
			this.btnPin_Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPin_Change.Name = "btnPin_Change";
			this.btnPin_Change.Size = new System.Drawing.Size(110, 23);
			this.btnPin_Change.TabIndex = 6;
			this.btnPin_Change.Text = "Change PIN";
			this.btnPin_Change.UseVisualStyleBackColor = true;
			this.btnPin_Change.Click += new System.EventHandler(this.btnPin_Change_Click);
			// 
			// txtPin_Confirm
			// 
			this.txtPin_Confirm.Location = new System.Drawing.Point(111, 46);
			this.txtPin_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPin_Confirm.MaxLength = 64;
			this.txtPin_Confirm.Name = "txtPin_Confirm";
			this.txtPin_Confirm.Size = new System.Drawing.Size(83, 20);
			this.txtPin_Confirm.TabIndex = 5;
			this.txtPin_Confirm.UseSystemPasswordChar = true;
			this.txtPin_Confirm.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblPin_Confirm
			// 
			this.lblPin_Confirm.AutoSize = true;
			this.lblPin_Confirm.Location = new System.Drawing.Point(39, 49);
			this.lblPin_Confirm.Name = "lblPin_Confirm";
			this.lblPin_Confirm.Size = new System.Drawing.Size(66, 13);
			this.lblPin_Confirm.TabIndex = 4;
			this.lblPin_Confirm.Text = "Confirm PIN:";
			this.lblPin_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlPin
			// 
			this.pnlPin.BackColor = System.Drawing.Color.LightGray;
			this.pnlPin.Controls.Add(this.txtPin_New);
			this.pnlPin.Controls.Add(this.lblPin);
			this.pnlPin.Controls.Add(this.lblPin_New);
			this.pnlPin.Controls.Add(this.btnPin_Change);
			this.pnlPin.Controls.Add(this.txtPin_Confirm);
			this.pnlPin.Controls.Add(this.lblPin_Confirm);
			this.pnlPin.Location = new System.Drawing.Point(12, 291);
			this.pnlPin.Name = "pnlPin";
			this.pnlPin.Size = new System.Drawing.Size(293, 120);
			this.pnlPin.TabIndex = 7;
			this.pnlPin.Enter += new System.EventHandler(this.pnlPin_Enter);
			// 
			// lblPin
			// 
			this.lblPin.AutoEllipsis = true;
			this.lblPin.BackColor = System.Drawing.Color.Black;
			this.lblPin.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPin.ForeColor = System.Drawing.Color.White;
			this.lblPin.Location = new System.Drawing.Point(0, 0);
			this.lblPin.Name = "lblPin";
			this.lblPin.Size = new System.Drawing.Size(293, 17);
			this.lblPin.TabIndex = 0;
			this.lblPin.Text = "Change PIN";
			this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlPassword
			// 
			this.pnlPassword.BackColor = System.Drawing.Color.LightGray;
			this.pnlPassword.Controls.Add(this.btnPassword_Change);
			this.pnlPassword.Controls.Add(this.lblPassword);
			this.pnlPassword.Controls.Add(this.txtPassword_Confirm);
			this.pnlPassword.Controls.Add(this.txtPassword_Current);
			this.pnlPassword.Controls.Add(this.txtPassword_New);
			this.pnlPassword.Controls.Add(this.lblPassword_New);
			this.pnlPassword.Controls.Add(this.lblPassword_Current);
			this.pnlPassword.Controls.Add(this.lblPassword_Confirm);
			this.pnlPassword.Location = new System.Drawing.Point(12, 163);
			this.pnlPassword.Name = "pnlPassword";
			this.pnlPassword.Size = new System.Drawing.Size(293, 122);
			this.pnlPassword.TabIndex = 6;
			this.pnlPassword.Enter += new System.EventHandler(this.pnlPassword_Enter);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoEllipsis = true;
			this.lblPassword.BackColor = System.Drawing.Color.Black;
			this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPassword.ForeColor = System.Drawing.Color.White;
			this.lblPassword.Location = new System.Drawing.Point(0, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(293, 17);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Change Password";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlUserDetails
			// 
			this.pnlUserDetails.BackColor = System.Drawing.Color.LightGray;
			this.pnlUserDetails.Controls.Add(this.btnUser_Update);
			this.pnlUserDetails.Controls.Add(this.txtUser_Email);
			this.pnlUserDetails.Controls.Add(this.lblUserDetails);
			this.pnlUserDetails.Controls.Add(this.txtUser_Login);
			this.pnlUserDetails.Controls.Add(this.txtUser_LastName);
			this.pnlUserDetails.Controls.Add(this.lblUser_FirstName);
			this.pnlUserDetails.Controls.Add(this.txtUser_FirstName);
			this.pnlUserDetails.Controls.Add(this.lblUser_Login);
			this.pnlUserDetails.Controls.Add(this.lblUser_LastName);
			this.pnlUserDetails.Controls.Add(this.lblUser_Email);
			this.pnlUserDetails.Location = new System.Drawing.Point(12, 12);
			this.pnlUserDetails.Name = "pnlUserDetails";
			this.pnlUserDetails.Size = new System.Drawing.Size(293, 145);
			this.pnlUserDetails.TabIndex = 5;
			this.pnlUserDetails.Enter += new System.EventHandler(this.pnlUserDetails_Enter);
			// 
			// lblUserDetails
			// 
			this.lblUserDetails.AutoEllipsis = true;
			this.lblUserDetails.BackColor = System.Drawing.Color.Black;
			this.lblUserDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblUserDetails.ForeColor = System.Drawing.Color.White;
			this.lblUserDetails.Location = new System.Drawing.Point(0, 0);
			this.lblUserDetails.Name = "lblUserDetails";
			this.lblUserDetails.Size = new System.Drawing.Size(293, 17);
			this.lblUserDetails.TabIndex = 0;
			this.lblUserDetails.Text = "User Details";
			this.lblUserDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(232, 424);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormAdmin_User_Details
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(319, 459);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlPin);
			this.Controls.Add(this.pnlPassword);
			this.Controls.Add(this.pnlUserDetails);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_User_Details";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "User Details";
			this.Load += new System.EventHandler(this.FormUser_Details_Load);
			this.pnlPin.ResumeLayout(false);
			this.pnlPin.PerformLayout();
			this.pnlPassword.ResumeLayout(false);
			this.pnlPassword.PerformLayout();
			this.pnlUserDetails.ResumeLayout(false);
			this.pnlUserDetails.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtUser_Email;
		private System.Windows.Forms.Button btnUser_Update;
		private System.Windows.Forms.TextBox txtUser_LastName;
		private System.Windows.Forms.TextBox txtUser_FirstName;
		private System.Windows.Forms.TextBox txtUser_Login;
		private System.Windows.Forms.Label lblUser_Email;
		private System.Windows.Forms.Label lblUser_LastName;
		private System.Windows.Forms.Label lblUser_Login;
		private System.Windows.Forms.Label lblUser_FirstName;
		private System.Windows.Forms.Button btnPassword_Change;
		private System.Windows.Forms.TextBox txtPassword_Confirm;
		private System.Windows.Forms.TextBox txtPassword_New;
		private System.Windows.Forms.TextBox txtPassword_Current;
		private System.Windows.Forms.Label lblPassword_Confirm;
		private System.Windows.Forms.Label lblPassword_Current;
		private System.Windows.Forms.Label lblPassword_New;
		private System.Windows.Forms.TextBox txtPin_New;
		private System.Windows.Forms.Label lblPin_New;
		private System.Windows.Forms.Button btnPin_Change;
		private System.Windows.Forms.TextBox txtPin_Confirm;
		private System.Windows.Forms.Label lblPin_Confirm;
		private System.Windows.Forms.Panel pnlPin;
		private System.Windows.Forms.Label lblPin;
		private System.Windows.Forms.Panel pnlPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Panel pnlUserDetails;
		private System.Windows.Forms.Label lblUserDetails;
		private System.Windows.Forms.Button btnClose;
	}
}