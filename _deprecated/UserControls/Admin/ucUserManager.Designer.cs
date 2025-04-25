namespace SDB.UserControls.Admin
{
    partial class ucUserManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.grpSelectedUser = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.olvUserList = new BrightIdeasSoftware.ObjectListView();
            this.olvColID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColUsername = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColUserGroup = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvApproved = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDisabled = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabUserGroups = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbxAssetOptions = new System.Windows.Forms.CheckBox();
            this.cbxCanEditAdminEmails = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColUserGroupName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grpSelectedUser.SuspendLayout();
            this.grpUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserList)).BeginInit();
            this.tabUserGroups.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabUserGroups);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(949, 604);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.panel1);
            this.tabUsers.Controls.Add(this.groupBox1);
            this.tabUsers.Controls.Add(this.grpSelectedUser);
            this.tabUsers.Controls.Add(this.grpUserList);
            this.tabUsers.Location = new System.Drawing.Point(4, 44);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(941, 556);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 35);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Filter:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(48, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 20);
            this.textBox8.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(9, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(700, 35);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Approve";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Enable";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Disable";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Reset Pin";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // grpSelectedUser
            // 
            this.grpSelectedUser.Controls.Add(this.textBox7);
            this.grpSelectedUser.Controls.Add(this.label6);
            this.grpSelectedUser.Controls.Add(this.textBox6);
            this.grpSelectedUser.Controls.Add(this.label5);
            this.grpSelectedUser.Controls.Add(this.comboBox1);
            this.grpSelectedUser.Controls.Add(this.label4);
            this.grpSelectedUser.Controls.Add(this.textBox5);
            this.grpSelectedUser.Controls.Add(this.label3);
            this.grpSelectedUser.Controls.Add(this.textBox4);
            this.grpSelectedUser.Controls.Add(this.label2);
            this.grpSelectedUser.Controls.Add(this.textBox3);
            this.grpSelectedUser.Controls.Add(this.textBox2);
            this.grpSelectedUser.Controls.Add(this.label1);
            this.grpSelectedUser.Controls.Add(this.textBox1);
            this.grpSelectedUser.Controls.Add(this.lblUsername);
            this.grpSelectedUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSelectedUser.Location = new System.Drawing.Point(721, 6);
            this.grpSelectedUser.Name = "grpSelectedUser";
            this.grpSelectedUser.Size = new System.Drawing.Size(214, 544);
            this.grpSelectedUser.TabIndex = 1;
            this.grpSelectedUser.TabStop = false;
            this.grpSelectedUser.Text = "User";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 119);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(202, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employee ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(202, 20);
            this.textBox6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Group:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 521);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(204, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Login: ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(202, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // grpUserList
            // 
            this.grpUserList.Controls.Add(this.olvUserList);
            this.grpUserList.Location = new System.Drawing.Point(6, 47);
            this.grpUserList.Name = "grpUserList";
            this.grpUserList.Size = new System.Drawing.Size(709, 446);
            this.grpUserList.TabIndex = 0;
            this.grpUserList.TabStop = false;
            this.grpUserList.Text = "User List";
            // 
            // olvUserList
            // 
            this.olvUserList.AllColumns.Add(this.olvColID);
            this.olvUserList.AllColumns.Add(this.olvColUsername);
            this.olvUserList.AllColumns.Add(this.olvColName);
            this.olvUserList.AllColumns.Add(this.olvColUserGroup);
            this.olvUserList.AllColumns.Add(this.olvApproved);
            this.olvUserList.AllColumns.Add(this.olvColDisabled);
            this.olvUserList.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.olvUserList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olvUserList.CellEditUseWholeCell = false;
            this.olvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColID,
            this.olvColUsername,
            this.olvColName,
            this.olvColUserGroup,
            this.olvApproved,
            this.olvColDisabled});
            this.olvUserList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvUserList.EmptyListMsg = "No Users [You really broke something...... >:( ]";
            this.olvUserList.FullRowSelect = true;
            this.olvUserList.GridLines = true;
            this.olvUserList.HasCollapsibleGroups = false;
            this.olvUserList.Location = new System.Drawing.Point(3, 16);
            this.olvUserList.MultiSelect = false;
            this.olvUserList.Name = "olvUserList";
            this.olvUserList.Scrollable = false;
            this.olvUserList.ShowCommandMenuOnRightClick = true;
            this.olvUserList.Size = new System.Drawing.Size(703, 427);
            this.olvUserList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.olvUserList.TabIndex = 5;
            this.olvUserList.UseCompatibleStateImageBehavior = false;
            this.olvUserList.View = System.Windows.Forms.View.Details;
            // 
            // olvColID
            // 
            this.olvColID.AspectName = "ID";
            this.olvColID.IsEditable = false;
            this.olvColID.MaximumWidth = 60;
            this.olvColID.MinimumWidth = 60;
            this.olvColID.Text = "ID";
            // 
            // olvColUsername
            // 
            this.olvColUsername.AspectName = "";
            this.olvColUsername.Groupable = false;
            this.olvColUsername.IsEditable = false;
            this.olvColUsername.MaximumWidth = 150;
            this.olvColUsername.MinimumWidth = 150;
            this.olvColUsername.Text = "Username";
            this.olvColUsername.Width = 150;
            this.olvColUsername.WordWrap = true;
            // 
            // olvColName
            // 
            this.olvColName.AspectName = "FirstLast";
            this.olvColName.IsEditable = false;
            this.olvColName.MaximumWidth = 145;
            this.olvColName.MinimumWidth = 145;
            this.olvColName.Text = "Name";
            this.olvColName.Width = 145;
            this.olvColName.WordWrap = true;
            // 
            // olvColUserGroup
            // 
            this.olvColUserGroup.IsEditable = false;
            this.olvColUserGroup.MaximumWidth = 186;
            this.olvColUserGroup.MinimumWidth = 186;
            this.olvColUserGroup.Text = "UserGroup";
            this.olvColUserGroup.Width = 186;
            this.olvColUserGroup.WordWrap = true;
            // 
            // olvApproved
            // 
            this.olvApproved.IsEditable = false;
            this.olvApproved.MaximumWidth = 60;
            this.olvApproved.MinimumWidth = 60;
            this.olvApproved.Text = "Approved";
            this.olvApproved.WordWrap = true;
            // 
            // olvColDisabled
            // 
            this.olvColDisabled.AspectName = "LoginDisabled";
            this.olvColDisabled.CheckBoxes = true;
            this.olvColDisabled.IsEditable = false;
            this.olvColDisabled.MaximumWidth = 60;
            this.olvColDisabled.MinimumWidth = 60;
            this.olvColDisabled.Text = "Disabled";
            this.olvColDisabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColDisabled.WordWrap = true;
            // 
            // tabUserGroups
            // 
            this.tabUserGroups.Controls.Add(this.groupBox4);
            this.tabUserGroups.Controls.Add(this.groupBox3);
            this.tabUserGroups.Controls.Add(this.groupBox2);
            this.tabUserGroups.Location = new System.Drawing.Point(4, 44);
            this.tabUserGroups.Name = "tabUserGroups";
            this.tabUserGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserGroups.Size = new System.Drawing.Size(941, 556);
            this.tabUserGroups.TabIndex = 1;
            this.tabUserGroups.Text = "User Groups";
            this.tabUserGroups.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(9, 514);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(926, 36);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(286, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 505);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissions";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(643, 486);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.checkBox6);
            this.groupBox5.Controls.Add(this.checkBox7);
            this.groupBox5.Controls.Add(this.checkBox8);
            this.groupBox5.Controls.Add(this.checkBox9);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.cbxAssetOptions);
            this.groupBox5.Controls.Add(this.cbxCanEditAdminEmails);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 176);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Admin";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(131, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Can Edit Admin Emails";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Can Edit Admin Emails";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbxAssetOptions
            // 
            this.cbxAssetOptions.AutoSize = true;
            this.cbxAssetOptions.Location = new System.Drawing.Point(6, 42);
            this.cbxAssetOptions.Name = "cbxAssetOptions";
            this.cbxAssetOptions.Size = new System.Drawing.Size(134, 17);
            this.cbxAssetOptions.TabIndex = 1;
            this.cbxAssetOptions.Text = "Can Edit Asset Options";
            this.toolTip.SetToolTip(this.cbxAssetOptions, "User Group Can Edit Asset Options");
            this.cbxAssetOptions.UseVisualStyleBackColor = true;
            // 
            // cbxCanEditAdminEmails
            // 
            this.cbxCanEditAdminEmails.AutoSize = true;
            this.cbxCanEditAdminEmails.Location = new System.Drawing.Point(6, 19);
            this.cbxCanEditAdminEmails.Name = "cbxCanEditAdminEmails";
            this.cbxCanEditAdminEmails.Size = new System.Drawing.Size(131, 17);
            this.cbxCanEditAdminEmails.TabIndex = 0;
            this.cbxCanEditAdminEmails.Text = "Can Edit Admin Emails";
            this.toolTip.SetToolTip(this.cbxCanEditAdminEmails, "User Group Can Edit Admin Emails");
            this.cbxCanEditAdminEmails.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.objectListView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 508);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Group List:";
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColUserGroupName);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColUserGroupName});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListView1.EmptyListMsg = "No Users [You really broke something...... >:( ]";
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.GridLines = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView1.Location = new System.Drawing.Point(3, 16);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Scrollable = false;
            this.objectListView1.ShowCommandMenuOnRightClick = true;
            this.objectListView1.Size = new System.Drawing.Size(268, 489);
            this.objectListView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.objectListView1.TabIndex = 5;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColUserGroupName
            // 
            this.olvColUserGroupName.AspectName = "LoginDisabled";
            this.olvColUserGroupName.CheckBoxes = true;
            this.olvColUserGroupName.FillsFreeSpace = true;
            this.olvColUserGroupName.IsEditable = false;
            this.olvColUserGroupName.Text = "User Group";
            this.olvColUserGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColUserGroupName.Width = 250;
            this.olvColUserGroupName.WordWrap = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 111);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(131, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Can Edit Admin Emails";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(143, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(131, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Can Edit Admin Emails";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(143, 88);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(131, 17);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Can Edit Admin Emails";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(143, 65);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(131, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "Can Edit Admin Emails";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(143, 42);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(131, 17);
            this.checkBox8.TabIndex = 6;
            this.checkBox8.Text = "Can Edit Admin Emails";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(143, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(131, 17);
            this.checkBox9.TabIndex = 5;
            this.checkBox9.Text = "Can Edit Admin Emails";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // ucUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "ucUserManager";
            this.Size = new System.Drawing.Size(949, 604);
            this.tabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grpSelectedUser.ResumeLayout(false);
            this.grpSelectedUser.PerformLayout();
            this.grpUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvUserList)).EndInit();
            this.tabUserGroups.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabUserGroups;
        private System.Windows.Forms.GroupBox grpSelectedUser;
        private System.Windows.Forms.GroupBox grpUserList;
        private BrightIdeasSoftware.ObjectListView olvUserList;
        private BrightIdeasSoftware.OLVColumn olvColUsername;
        private BrightIdeasSoftware.OLVColumn olvColName;
        private BrightIdeasSoftware.OLVColumn olvColUserGroup;
        private BrightIdeasSoftware.OLVColumn olvApproved;
        private BrightIdeasSoftware.OLVColumn olvColDisabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private BrightIdeasSoftware.OLVColumn olvColID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColUserGroupName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbxCanEditAdminEmails;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbxAssetOptions;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
