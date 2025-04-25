namespace SDB.Forms.Admin
{
    partial class FormAdmin_Users
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
            this.lblModifyUser_SelectUser = new System.Windows.Forms.Label();
            this.cmbModifyUser_SelectUser = new System.Windows.Forms.ComboBox();
            this.radModifyUser_DisableLogin = new System.Windows.Forms.CheckBox();
            this.radModifyUser_UserType_Moderator = new System.Windows.Forms.RadioButton();
            this.radModifyUser_UserType_Administrator = new System.Windows.Forms.RadioButton();
            this.radModifyUser_UserType_Standard = new System.Windows.Forms.RadioButton();
            this.lblModifyUser_UserType = new System.Windows.Forms.Label();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.txtModifyUser_Password_Confirm = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Password_Confirm = new System.Windows.Forms.Label();
            this.txtModifyUser_Password = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Password = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_Moderator = new System.Windows.Forms.RadioButton();
            this.txtCreateUser_Password_Confirm = new System.Windows.Forms.TextBox();
            this.lblCreateUser_Password_Confirm = new System.Windows.Forms.Label();
            this.txtCreateUser_Password = new System.Windows.Forms.TextBox();
            this.lblCreateUser_Password = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_Administrator = new System.Windows.Forms.RadioButton();
            this.radCreateUser_UserType_Standard = new System.Windows.Forms.RadioButton();
            this.lblCreateUser_UserType = new System.Windows.Forms.Label();
            this.txtCreateUser_Email = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtCreateUser_LastName = new System.Windows.Forms.TextBox();
            this.txtCreateUser_FirstName = new System.Windows.Forms.TextBox();
            this.txtCreateUser_Login = new System.Windows.Forms.TextBox();
            this.lblCreateUser_Email = new System.Windows.Forms.Label();
            this.lblCreateUser_LastName = new System.Windows.Forms.Label();
            this.lblCreateUser_Login = new System.Windows.Forms.Label();
            this.lblCreateUser_FirstName = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlUser_Modify = new System.Windows.Forms.Panel();
            this.txtModifyUser_Pin_Confirm = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Pin_Confirm = new System.Windows.Forms.Label();
            this.txtModifyUser_Pin = new System.Windows.Forms.TextBox();
            this.lblModifyUser_Pin = new System.Windows.Forms.Label();
            this.lblUser_Modify = new System.Windows.Forms.Label();
            this.pnlUser_Create = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser_Create = new System.Windows.Forms.Label();
            this.radCreateUser_UserType_SSR = new System.Windows.Forms.RadioButton();
            this.radModifyUser_UserType_SSR = new System.Windows.Forms.RadioButton();
            this.pnlUser_Modify.SuspendLayout();
            this.pnlUser_Create.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifyUser_SelectUser
            // 
            this.lblModifyUser_SelectUser.AutoSize = true;
            this.lblModifyUser_SelectUser.Location = new System.Drawing.Point(42, 34);
            this.lblModifyUser_SelectUser.Name = "lblModifyUser_SelectUser";
            this.lblModifyUser_SelectUser.Size = new System.Drawing.Size(63, 13);
            this.lblModifyUser_SelectUser.TabIndex = 0;
            this.lblModifyUser_SelectUser.Text = "Select user:";
            // 
            // cmbModifyUser_SelectUser
            // 
            this.cmbModifyUser_SelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyUser_SelectUser.FormattingEnabled = true;
            this.cmbModifyUser_SelectUser.Location = new System.Drawing.Point(111, 31);
            this.cmbModifyUser_SelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModifyUser_SelectUser.Name = "cmbModifyUser_SelectUser";
            this.cmbModifyUser_SelectUser.Size = new System.Drawing.Size(163, 21);
            this.cmbModifyUser_SelectUser.TabIndex = 1;
            this.cmbModifyUser_SelectUser.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // radModifyUser_DisableLogin
            // 
            this.radModifyUser_DisableLogin.AutoSize = true;
            this.radModifyUser_DisableLogin.Location = new System.Drawing.Point(280, 27);
            this.radModifyUser_DisableLogin.Name = "radModifyUser_DisableLogin";
            this.radModifyUser_DisableLogin.Size = new System.Drawing.Size(67, 30);
            this.radModifyUser_DisableLogin.TabIndex = 2;
            this.radModifyUser_DisableLogin.Text = "Login\r\nDisabled";
            this.radModifyUser_DisableLogin.UseVisualStyleBackColor = true;
            // 
            // radModifyUser_UserType_Moderator
            // 
            this.radModifyUser_UserType_Moderator.AutoSize = true;
            this.radModifyUser_UserType_Moderator.Location = new System.Drawing.Point(111, 150);
            this.radModifyUser_UserType_Moderator.Name = "radModifyUser_UserType_Moderator";
            this.radModifyUser_UserType_Moderator.Size = new System.Drawing.Size(73, 17);
            this.radModifyUser_UserType_Moderator.TabIndex = 13;
            this.radModifyUser_UserType_Moderator.Text = "Moderator";
            this.radModifyUser_UserType_Moderator.UseVisualStyleBackColor = true;
            // 
            // radModifyUser_UserType_Administrator
            // 
            this.radModifyUser_UserType_Administrator.AutoSize = true;
            this.radModifyUser_UserType_Administrator.Location = new System.Drawing.Point(243, 150);
            this.radModifyUser_UserType_Administrator.Name = "radModifyUser_UserType_Administrator";
            this.radModifyUser_UserType_Administrator.Size = new System.Drawing.Size(85, 17);
            this.radModifyUser_UserType_Administrator.TabIndex = 14;
            this.radModifyUser_UserType_Administrator.Text = "Administrator";
            this.radModifyUser_UserType_Administrator.UseVisualStyleBackColor = true;
            // 
            // radModifyUser_UserType_Standard
            // 
            this.radModifyUser_UserType_Standard.AutoSize = true;
            this.radModifyUser_UserType_Standard.Checked = true;
            this.radModifyUser_UserType_Standard.Location = new System.Drawing.Point(45, 150);
            this.radModifyUser_UserType_Standard.Name = "radModifyUser_UserType_Standard";
            this.radModifyUser_UserType_Standard.Size = new System.Drawing.Size(68, 17);
            this.radModifyUser_UserType_Standard.TabIndex = 12;
            this.radModifyUser_UserType_Standard.TabStop = true;
            this.radModifyUser_UserType_Standard.Text = "Standard";
            this.radModifyUser_UserType_Standard.UseVisualStyleBackColor = true;
            // 
            // lblModifyUser_UserType
            // 
            this.lblModifyUser_UserType.AutoSize = true;
            this.lblModifyUser_UserType.Location = new System.Drawing.Point(11, 150);
            this.lblModifyUser_UserType.Name = "lblModifyUser_UserType";
            this.lblModifyUser_UserType.Size = new System.Drawing.Size(34, 13);
            this.lblModifyUser_UserType.TabIndex = 11;
            this.lblModifyUser_UserType.Text = "Type:";
            this.lblModifyUser_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.AutoSize = true;
            this.btnModifyUser.Location = new System.Drawing.Point(239, 172);
            this.btnModifyUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(120, 23);
            this.btnModifyUser.TabIndex = 15;
            this.btnModifyUser.Text = "Modify User";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnUser_Modify_Click);
            // 
            // txtModifyUser_Password_Confirm
            // 
            this.txtModifyUser_Password_Confirm.Location = new System.Drawing.Point(111, 80);
            this.txtModifyUser_Password_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Password_Confirm.MaxLength = 50;
            this.txtModifyUser_Password_Confirm.Name = "txtModifyUser_Password_Confirm";
            this.txtModifyUser_Password_Confirm.PasswordChar = '*';
            this.txtModifyUser_Password_Confirm.Size = new System.Drawing.Size(163, 20);
            this.txtModifyUser_Password_Confirm.TabIndex = 6;
            this.txtModifyUser_Password_Confirm.UseSystemPasswordChar = true;
            this.txtModifyUser_Password_Confirm.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblModifyUser_Password_Confirm
            // 
            this.lblModifyUser_Password_Confirm.AutoSize = true;
            this.lblModifyUser_Password_Confirm.Location = new System.Drawing.Point(11, 83);
            this.lblModifyUser_Password_Confirm.Name = "lblModifyUser_Password_Confirm";
            this.lblModifyUser_Password_Confirm.Size = new System.Drawing.Size(94, 13);
            this.lblModifyUser_Password_Confirm.TabIndex = 5;
            this.lblModifyUser_Password_Confirm.Text = "Confirm Password:";
            this.lblModifyUser_Password_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyUser_Password
            // 
            this.txtModifyUser_Password.Location = new System.Drawing.Point(111, 56);
            this.txtModifyUser_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Password.MaxLength = 50;
            this.txtModifyUser_Password.Name = "txtModifyUser_Password";
            this.txtModifyUser_Password.PasswordChar = '*';
            this.txtModifyUser_Password.Size = new System.Drawing.Size(163, 20);
            this.txtModifyUser_Password.TabIndex = 4;
            this.txtModifyUser_Password.UseSystemPasswordChar = true;
            this.txtModifyUser_Password.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblModifyUser_Password
            // 
            this.lblModifyUser_Password.AutoSize = true;
            this.lblModifyUser_Password.Location = new System.Drawing.Point(24, 59);
            this.lblModifyUser_Password.Name = "lblModifyUser_Password";
            this.lblModifyUser_Password.Size = new System.Drawing.Size(81, 13);
            this.lblModifyUser_Password.TabIndex = 3;
            this.lblModifyUser_Password.Text = "New Password:";
            this.lblModifyUser_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radCreateUser_UserType_Moderator
            // 
            this.radCreateUser_UserType_Moderator.AutoSize = true;
            this.radCreateUser_UserType_Moderator.Location = new System.Drawing.Point(119, 179);
            this.radCreateUser_UserType_Moderator.Name = "radCreateUser_UserType_Moderator";
            this.radCreateUser_UserType_Moderator.Size = new System.Drawing.Size(73, 17);
            this.radCreateUser_UserType_Moderator.TabIndex = 19;
            this.radCreateUser_UserType_Moderator.Text = "Moderator";
            this.radCreateUser_UserType_Moderator.UseVisualStyleBackColor = true;
            // 
            // txtCreateUser_Password_Confirm
            // 
            this.txtCreateUser_Password_Confirm.Location = new System.Drawing.Point(111, 142);
            this.txtCreateUser_Password_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Password_Confirm.MaxLength = 50;
            this.txtCreateUser_Password_Confirm.Name = "txtCreateUser_Password_Confirm";
            this.txtCreateUser_Password_Confirm.PasswordChar = '*';
            this.txtCreateUser_Password_Confirm.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Password_Confirm.TabIndex = 12;
            this.txtCreateUser_Password_Confirm.UseSystemPasswordChar = true;
            this.txtCreateUser_Password_Confirm.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblCreateUser_Password_Confirm
            // 
            this.lblCreateUser_Password_Confirm.AutoSize = true;
            this.lblCreateUser_Password_Confirm.Location = new System.Drawing.Point(11, 145);
            this.lblCreateUser_Password_Confirm.Name = "lblCreateUser_Password_Confirm";
            this.lblCreateUser_Password_Confirm.Size = new System.Drawing.Size(94, 13);
            this.lblCreateUser_Password_Confirm.TabIndex = 11;
            this.lblCreateUser_Password_Confirm.Text = "Confirm Password:";
            this.lblCreateUser_Password_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCreateUser_Password
            // 
            this.txtCreateUser_Password.Location = new System.Drawing.Point(111, 118);
            this.txtCreateUser_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Password.MaxLength = 50;
            this.txtCreateUser_Password.Name = "txtCreateUser_Password";
            this.txtCreateUser_Password.PasswordChar = '*';
            this.txtCreateUser_Password.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Password.TabIndex = 10;
            this.txtCreateUser_Password.UseSystemPasswordChar = true;
            this.txtCreateUser_Password.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblCreateUser_Password
            // 
            this.lblCreateUser_Password.AutoSize = true;
            this.lblCreateUser_Password.Location = new System.Drawing.Point(49, 121);
            this.lblCreateUser_Password.Name = "lblCreateUser_Password";
            this.lblCreateUser_Password.Size = new System.Drawing.Size(56, 13);
            this.lblCreateUser_Password.TabIndex = 9;
            this.lblCreateUser_Password.Text = "Password:";
            this.lblCreateUser_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radCreateUser_UserType_Administrator
            // 
            this.radCreateUser_UserType_Administrator.AutoSize = true;
            this.radCreateUser_UserType_Administrator.Location = new System.Drawing.Point(251, 179);
            this.radCreateUser_UserType_Administrator.Name = "radCreateUser_UserType_Administrator";
            this.radCreateUser_UserType_Administrator.Size = new System.Drawing.Size(85, 17);
            this.radCreateUser_UserType_Administrator.TabIndex = 20;
            this.radCreateUser_UserType_Administrator.Text = "Administrator";
            this.radCreateUser_UserType_Administrator.UseVisualStyleBackColor = true;
            // 
            // radCreateUser_UserType_Standard
            // 
            this.radCreateUser_UserType_Standard.AutoSize = true;
            this.radCreateUser_UserType_Standard.Checked = true;
            this.radCreateUser_UserType_Standard.Location = new System.Drawing.Point(45, 179);
            this.radCreateUser_UserType_Standard.Name = "radCreateUser_UserType_Standard";
            this.radCreateUser_UserType_Standard.Size = new System.Drawing.Size(68, 17);
            this.radCreateUser_UserType_Standard.TabIndex = 18;
            this.radCreateUser_UserType_Standard.TabStop = true;
            this.radCreateUser_UserType_Standard.Text = "Standard";
            this.radCreateUser_UserType_Standard.UseVisualStyleBackColor = true;
            // 
            // lblCreateUser_UserType
            // 
            this.lblCreateUser_UserType.AutoSize = true;
            this.lblCreateUser_UserType.Location = new System.Drawing.Point(11, 179);
            this.lblCreateUser_UserType.Name = "lblCreateUser_UserType";
            this.lblCreateUser_UserType.Size = new System.Drawing.Size(34, 13);
            this.lblCreateUser_UserType.TabIndex = 17;
            this.lblCreateUser_UserType.Text = "Type:";
            this.lblCreateUser_UserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCreateUser_Email
            // 
            this.txtCreateUser_Email.Location = new System.Drawing.Point(111, 94);
            this.txtCreateUser_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Email.MaxLength = 35;
            this.txtCreateUser_Email.Name = "txtCreateUser_Email";
            this.txtCreateUser_Email.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Email.TabIndex = 8;
            this.txtCreateUser_Email.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.AutoSize = true;
            this.btnCreateUser.Location = new System.Drawing.Point(239, 237);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(120, 23);
            this.btnCreateUser.TabIndex = 21;
            this.btnCreateUser.Text = "Create New User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnUser_New_Click);
            // 
            // txtCreateUser_LastName
            // 
            this.txtCreateUser_LastName.Location = new System.Drawing.Point(111, 69);
            this.txtCreateUser_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_LastName.MaxLength = 20;
            this.txtCreateUser_LastName.Name = "txtCreateUser_LastName";
            this.txtCreateUser_LastName.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_LastName.TabIndex = 6;
            this.txtCreateUser_LastName.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtCreateUser_FirstName
            // 
            this.txtCreateUser_FirstName.Location = new System.Drawing.Point(111, 44);
            this.txtCreateUser_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_FirstName.MaxLength = 20;
            this.txtCreateUser_FirstName.Name = "txtCreateUser_FirstName";
            this.txtCreateUser_FirstName.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_FirstName.TabIndex = 4;
            this.txtCreateUser_FirstName.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtCreateUser_Login
            // 
            this.txtCreateUser_Login.Location = new System.Drawing.Point(111, 19);
            this.txtCreateUser_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreateUser_Login.MaxLength = 20;
            this.txtCreateUser_Login.Name = "txtCreateUser_Login";
            this.txtCreateUser_Login.Size = new System.Drawing.Size(163, 20);
            this.txtCreateUser_Login.TabIndex = 2;
            this.txtCreateUser_Login.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblCreateUser_Email
            // 
            this.lblCreateUser_Email.AutoSize = true;
            this.lblCreateUser_Email.Location = new System.Drawing.Point(66, 97);
            this.lblCreateUser_Email.Name = "lblCreateUser_Email";
            this.lblCreateUser_Email.Size = new System.Drawing.Size(39, 13);
            this.lblCreateUser_Email.TabIndex = 7;
            this.lblCreateUser_Email.Text = "E-Mail:";
            this.lblCreateUser_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_LastName
            // 
            this.lblCreateUser_LastName.AutoSize = true;
            this.lblCreateUser_LastName.Location = new System.Drawing.Point(44, 72);
            this.lblCreateUser_LastName.Name = "lblCreateUser_LastName";
            this.lblCreateUser_LastName.Size = new System.Drawing.Size(61, 13);
            this.lblCreateUser_LastName.TabIndex = 5;
            this.lblCreateUser_LastName.Text = "Last Name:";
            this.lblCreateUser_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_Login
            // 
            this.lblCreateUser_Login.AutoSize = true;
            this.lblCreateUser_Login.Location = new System.Drawing.Point(44, 22);
            this.lblCreateUser_Login.Name = "lblCreateUser_Login";
            this.lblCreateUser_Login.Size = new System.Drawing.Size(61, 13);
            this.lblCreateUser_Login.TabIndex = 1;
            this.lblCreateUser_Login.Text = "User Login:";
            this.lblCreateUser_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreateUser_FirstName
            // 
            this.lblCreateUser_FirstName.AutoSize = true;
            this.lblCreateUser_FirstName.Location = new System.Drawing.Point(45, 47);
            this.lblCreateUser_FirstName.Name = "lblCreateUser_FirstName";
            this.lblCreateUser_FirstName.Size = new System.Drawing.Size(60, 13);
            this.lblCreateUser_FirstName.TabIndex = 3;
            this.lblCreateUser_FirstName.Text = "First Name:";
            this.lblCreateUser_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(311, 513);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlUser_Modify
            // 
            this.pnlUser_Modify.BackColor = System.Drawing.Color.LightGray;
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_SSR);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Pin_Confirm);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Pin_Confirm);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Pin);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Pin);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_DisableLogin);
            this.pnlUser_Modify.Controls.Add(this.lblUser_Modify);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Moderator);
            this.pnlUser_Modify.Controls.Add(this.cmbModifyUser_SelectUser);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Administrator);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_SelectUser);
            this.pnlUser_Modify.Controls.Add(this.radModifyUser_UserType_Standard);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Password);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_UserType);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Password);
            this.pnlUser_Modify.Controls.Add(this.btnModifyUser);
            this.pnlUser_Modify.Controls.Add(this.lblModifyUser_Password_Confirm);
            this.pnlUser_Modify.Controls.Add(this.txtModifyUser_Password_Confirm);
            this.pnlUser_Modify.Location = new System.Drawing.Point(12, 12);
            this.pnlUser_Modify.Name = "pnlUser_Modify";
            this.pnlUser_Modify.Size = new System.Drawing.Size(373, 210);
            this.pnlUser_Modify.TabIndex = 0;
            this.pnlUser_Modify.Enter += new System.EventHandler(this.pnlUser_Modify_Enter);
            // 
            // txtModifyUser_Pin_Confirm
            // 
            this.txtModifyUser_Pin_Confirm.Location = new System.Drawing.Point(111, 128);
            this.txtModifyUser_Pin_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Pin_Confirm.MaxLength = 50;
            this.txtModifyUser_Pin_Confirm.Name = "txtModifyUser_Pin_Confirm";
            this.txtModifyUser_Pin_Confirm.PasswordChar = '*';
            this.txtModifyUser_Pin_Confirm.Size = new System.Drawing.Size(83, 20);
            this.txtModifyUser_Pin_Confirm.TabIndex = 10;
            this.txtModifyUser_Pin_Confirm.UseSystemPasswordChar = true;
            this.txtModifyUser_Pin_Confirm.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblModifyUser_Pin_Confirm
            // 
            this.lblModifyUser_Pin_Confirm.AutoSize = true;
            this.lblModifyUser_Pin_Confirm.Location = new System.Drawing.Point(39, 131);
            this.lblModifyUser_Pin_Confirm.Name = "lblModifyUser_Pin_Confirm";
            this.lblModifyUser_Pin_Confirm.Size = new System.Drawing.Size(66, 13);
            this.lblModifyUser_Pin_Confirm.TabIndex = 9;
            this.lblModifyUser_Pin_Confirm.Text = "Confirm PIN:";
            this.lblModifyUser_Pin_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModifyUser_Pin
            // 
            this.txtModifyUser_Pin.Location = new System.Drawing.Point(111, 104);
            this.txtModifyUser_Pin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifyUser_Pin.MaxLength = 50;
            this.txtModifyUser_Pin.Name = "txtModifyUser_Pin";
            this.txtModifyUser_Pin.PasswordChar = '*';
            this.txtModifyUser_Pin.Size = new System.Drawing.Size(83, 20);
            this.txtModifyUser_Pin.TabIndex = 8;
            this.txtModifyUser_Pin.UseSystemPasswordChar = true;
            this.txtModifyUser_Pin.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblModifyUser_Pin
            // 
            this.lblModifyUser_Pin.AutoSize = true;
            this.lblModifyUser_Pin.Location = new System.Drawing.Point(52, 107);
            this.lblModifyUser_Pin.Name = "lblModifyUser_Pin";
            this.lblModifyUser_Pin.Size = new System.Drawing.Size(53, 13);
            this.lblModifyUser_Pin.TabIndex = 7;
            this.lblModifyUser_Pin.Text = "New PIN:";
            this.lblModifyUser_Pin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser_Modify
            // 
            this.lblUser_Modify.AutoEllipsis = true;
            this.lblUser_Modify.BackColor = System.Drawing.Color.Black;
            this.lblUser_Modify.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Modify.ForeColor = System.Drawing.Color.White;
            this.lblUser_Modify.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Modify.Name = "lblUser_Modify";
            this.lblUser_Modify.Size = new System.Drawing.Size(373, 17);
            this.lblUser_Modify.TabIndex = 0;
            this.lblUser_Modify.Text = "Modify User";
            this.lblUser_Modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUser_Create
            // 
            this.pnlUser_Create.BackColor = System.Drawing.Color.LightGray;
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_SSR);
            this.pnlUser_Create.Controls.Add(this.label1);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Moderator);
            this.pnlUser_Create.Controls.Add(this.lblUser_Create);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Password_Confirm);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Login);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Password_Confirm);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_FirstName);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Password);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Login);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Password);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_LastName);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Administrator);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_Email);
            this.pnlUser_Create.Controls.Add(this.radCreateUser_UserType_Standard);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_FirstName);
            this.pnlUser_Create.Controls.Add(this.lblCreateUser_UserType);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_LastName);
            this.pnlUser_Create.Controls.Add(this.txtCreateUser_Email);
            this.pnlUser_Create.Controls.Add(this.btnCreateUser);
            this.pnlUser_Create.Location = new System.Drawing.Point(12, 228);
            this.pnlUser_Create.Name = "pnlUser_Create";
            this.pnlUser_Create.Size = new System.Drawing.Size(373, 272);
            this.pnlUser_Create.TabIndex = 1;
            this.pnlUser_Create.Enter += new System.EventHandler(this.pnlUser_Create_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(280, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "(Employee #)";
            // 
            // lblUser_Create
            // 
            this.lblUser_Create.AutoEllipsis = true;
            this.lblUser_Create.BackColor = System.Drawing.Color.Black;
            this.lblUser_Create.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser_Create.ForeColor = System.Drawing.Color.White;
            this.lblUser_Create.Location = new System.Drawing.Point(0, 0);
            this.lblUser_Create.Name = "lblUser_Create";
            this.lblUser_Create.Size = new System.Drawing.Size(373, 17);
            this.lblUser_Create.TabIndex = 0;
            this.lblUser_Create.Text = "Create User";
            this.lblUser_Create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radCreateUser_UserType_SSR
            // 
            this.radCreateUser_UserType_SSR.AutoSize = true;
            this.radCreateUser_UserType_SSR.Location = new System.Drawing.Point(198, 179);
            this.radCreateUser_UserType_SSR.Name = "radCreateUser_UserType_SSR";
            this.radCreateUser_UserType_SSR.Size = new System.Drawing.Size(47, 17);
            this.radCreateUser_UserType_SSR.TabIndex = 23;
            this.radCreateUser_UserType_SSR.Text = "SSR";
            this.radCreateUser_UserType_SSR.UseVisualStyleBackColor = true;
            // 
            // radModifyUser_UserType_SSR
            // 
            this.radModifyUser_UserType_SSR.AutoSize = true;
            this.radModifyUser_UserType_SSR.Location = new System.Drawing.Point(190, 150);
            this.radModifyUser_UserType_SSR.Name = "radModifyUser_UserType_SSR";
            this.radModifyUser_UserType_SSR.Size = new System.Drawing.Size(47, 17);
            this.radModifyUser_UserType_SSR.TabIndex = 24;
            this.radModifyUser_UserType_SSR.Text = "SSR";
            this.radModifyUser_UserType_SSR.UseVisualStyleBackColor = true;
            // 
            // FormAdmin_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(398, 547);
            this.Controls.Add(this.pnlUser_Create);
            this.Controls.Add(this.pnlUser_Modify);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Administration";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.pnlUser_Modify.ResumeLayout(false);
            this.pnlUser_Modify.PerformLayout();
            this.pnlUser_Create.ResumeLayout(false);
            this.pnlUser_Create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lblModifyUser_SelectUser;
		private System.Windows.Forms.ComboBox cmbModifyUser_SelectUser;
		private System.Windows.Forms.TextBox txtModifyUser_Password_Confirm;
		private System.Windows.Forms.Label lblModifyUser_Password_Confirm;
		private System.Windows.Forms.TextBox txtModifyUser_Password;
		private System.Windows.Forms.Label lblModifyUser_Password;
		private System.Windows.Forms.Button btnModifyUser;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.RadioButton radCreateUser_UserType_Administrator;
		private System.Windows.Forms.RadioButton radCreateUser_UserType_Standard;
		private System.Windows.Forms.Label lblCreateUser_UserType;
		private System.Windows.Forms.TextBox txtCreateUser_Email;
		private System.Windows.Forms.Button btnCreateUser;
		private System.Windows.Forms.TextBox txtCreateUser_LastName;
		private System.Windows.Forms.TextBox txtCreateUser_FirstName;
		private System.Windows.Forms.TextBox txtCreateUser_Login;
		private System.Windows.Forms.Label lblCreateUser_Email;
		private System.Windows.Forms.Label lblCreateUser_LastName;
		private System.Windows.Forms.Label lblCreateUser_Login;
		private System.Windows.Forms.Label lblCreateUser_FirstName;
		private System.Windows.Forms.TextBox txtCreateUser_Password_Confirm;
		private System.Windows.Forms.Label lblCreateUser_Password_Confirm;
		private System.Windows.Forms.TextBox txtCreateUser_Password;
		private System.Windows.Forms.Label lblCreateUser_Password;
		private System.Windows.Forms.RadioButton radModifyUser_UserType_Administrator;
		private System.Windows.Forms.RadioButton radModifyUser_UserType_Standard;
		private System.Windows.Forms.Label lblModifyUser_UserType;
		private System.Windows.Forms.RadioButton radModifyUser_UserType_Moderator;
		private System.Windows.Forms.RadioButton radCreateUser_UserType_Moderator;
		private System.Windows.Forms.CheckBox radModifyUser_DisableLogin;
		private System.Windows.Forms.Panel pnlUser_Create;
		private System.Windows.Forms.Label lblUser_Create;
		private System.Windows.Forms.Panel pnlUser_Modify;
		private System.Windows.Forms.Label lblUser_Modify;
		private System.Windows.Forms.TextBox txtModifyUser_Pin_Confirm;
		private System.Windows.Forms.Label lblModifyUser_Pin_Confirm;
		private System.Windows.Forms.TextBox txtModifyUser_Pin;
		private System.Windows.Forms.Label lblModifyUser_Pin;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radCreateUser_UserType_SSR;
        private System.Windows.Forms.RadioButton radModifyUser_UserType_SSR;
    }
}