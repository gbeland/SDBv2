namespace SDB.MagicInfo.UserControls
{
    partial class ucTicketCreation
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIssues = new System.Windows.Forms.ComboBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.ucSpellCheckLarge1 = new SDB.UserControls.General.ucSpellCheckLarge();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.tbxAssetSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAssetName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMarketName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxServerAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxServerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addressComponent1 = new SDB.MagicInfo.Components.AddressComponent();
            this.grpEntry.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(582, 364);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(671, 67);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Ticket Creation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEntry
            // 
            this.grpEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEntry.Controls.Add(this.label1);
            this.grpEntry.Controls.Add(this.cmbIssues);
            this.grpEntry.Controls.Add(this.elementHost1);
            this.grpEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntry.Location = new System.Drawing.Point(345, 70);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(323, 293);
            this.grpEntry.TabIndex = 3;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "Creation Entry";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reported Issue:";
            // 
            // cmbIssues
            // 
            this.cmbIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIssues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIssues.FormattingEnabled = true;
            this.cmbIssues.Location = new System.Drawing.Point(118, 265);
            this.cmbIssues.Name = "cmbIssues";
            this.cmbIssues.Size = new System.Drawing.Size(199, 21);
            this.cmbIssues.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementHost1.Location = new System.Drawing.Point(6, 19);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(311, 240);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.ucSpellCheckLarge1;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.tbxAssetSerial);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.tbxAssetName);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.tbxMarketName);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.tbxCustomerName);
            this.grpInfo.Controls.Add(this.tbxServerAlias);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.tbxServerName);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(10, 70);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(323, 177);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Asset/Server Info";
            // 
            // tbxAssetSerial
            // 
            this.tbxAssetSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAssetSerial.Location = new System.Drawing.Point(84, 149);
            this.tbxAssetSerial.Name = "tbxAssetSerial";
            this.tbxAssetSerial.ReadOnly = true;
            this.tbxAssetSerial.Size = new System.Drawing.Size(233, 20);
            this.tbxAssetSerial.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Asset Name:";
            // 
            // tbxAssetName
            // 
            this.tbxAssetName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxAssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAssetName.Location = new System.Drawing.Point(84, 123);
            this.tbxAssetName.Name = "tbxAssetName";
            this.tbxAssetName.ReadOnly = true;
            this.tbxAssetName.Size = new System.Drawing.Size(233, 20);
            this.tbxAssetName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Asset Serial:";
            // 
            // tbxMarketName
            // 
            this.tbxMarketName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMarketName.Location = new System.Drawing.Point(84, 45);
            this.tbxMarketName.Name = "tbxMarketName";
            this.tbxMarketName.ReadOnly = true;
            this.tbxMarketName.Size = new System.Drawing.Size(233, 20);
            this.tbxMarketName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Market:";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomerName.Location = new System.Drawing.Point(84, 19);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.ReadOnly = true;
            this.tbxCustomerName.Size = new System.Drawing.Size(233, 20);
            this.tbxCustomerName.TabIndex = 28;
            // 
            // tbxServerAlias
            // 
            this.tbxServerAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxServerAlias.Location = new System.Drawing.Point(84, 97);
            this.tbxServerAlias.Name = "tbxServerAlias";
            this.tbxServerAlias.ReadOnly = true;
            this.tbxServerAlias.Size = new System.Drawing.Size(233, 20);
            this.tbxServerAlias.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Server Name:";
            // 
            // tbxServerName
            // 
            this.tbxServerName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxServerName.Location = new System.Drawing.Point(84, 71);
            this.tbxServerName.Name = "tbxServerName";
            this.tbxServerName.ReadOnly = true;
            this.tbxServerName.Size = new System.Drawing.Size(233, 20);
            this.tbxServerName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Server Alias:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(0, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // addressComponent1
            // 
            this.addressComponent1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addressComponent1.Location = new System.Drawing.Point(6, 253);
            this.addressComponent1.Name = "addressComponent1";
            this.addressComponent1.Size = new System.Drawing.Size(327, 110);
            this.addressComponent1.TabIndex = 7;
            // 
            // ucTicketCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.addressComponent1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpEntry);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreate);
            this.Name = "ucTicketCreation";
            this.Size = new System.Drawing.Size(671, 391);
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SDB.UserControls.General.ucSpellCheckLarge ucSpellCheckLarge1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIssues;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox tbxMarketName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxServerAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAssetSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAssetName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private Components.AddressComponent addressComponent1;
    }
}
