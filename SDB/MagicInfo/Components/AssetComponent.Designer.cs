namespace SDB.MagicInfo.Components
{
    partial class AssetComponent
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cbxIgnoreAlerts = new System.Windows.Forms.CheckBox();
            this.cmbMarketList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSerial = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxFirmware = new System.Windows.Forms.TextBox();
            this.tbxAlias = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxMAC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblInstallDate = new System.Windows.Forms.Label();
            this.tbxContractNumber = new System.Windows.Forms.TextBox();
            this.lblContractNumber = new System.Windows.Forms.Label();
            this.dtpInstallDate = new System.Windows.Forms.DateTimePicker();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpInfo.Controls.Add(this.dtpInstallDate);
            this.grpInfo.Controls.Add(this.tbxContractNumber);
            this.grpInfo.Controls.Add(this.lblContractNumber);
            this.grpInfo.Controls.Add(this.lblInstallDate);
            this.grpInfo.Controls.Add(this.cbxIgnoreAlerts);
            this.grpInfo.Controls.Add(this.cmbMarketList);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.tbxSerial);
            this.grpInfo.Controls.Add(this.tbxModel);
            this.grpInfo.Controls.Add(this.tbxFirmware);
            this.grpInfo.Controls.Add(this.tbxAlias);
            this.grpInfo.Controls.Add(this.tbxName);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label10);
            this.grpInfo.Controls.Add(this.label13);
            this.grpInfo.Controls.Add(this.tbxIP);
            this.grpInfo.Controls.Add(this.label12);
            this.grpInfo.Controls.Add(this.tbxMAC);
            this.grpInfo.Controls.Add(this.label11);
            this.grpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(0, 0);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(0);
            this.grpInfo.Size = new System.Drawing.Size(633, 161);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Asset Information";
            // 
            // cbxIgnoreAlerts
            // 
            this.cbxIgnoreAlerts.AutoSize = true;
            this.cbxIgnoreAlerts.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxIgnoreAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIgnoreAlerts.Location = new System.Drawing.Point(555, 62);
            this.cbxIgnoreAlerts.Name = "cbxIgnoreAlerts";
            this.cbxIgnoreAlerts.Size = new System.Drawing.Size(70, 31);
            this.cbxIgnoreAlerts.TabIndex = 23;
            this.cbxIgnoreAlerts.Text = "Ignore Alerts";
            this.cbxIgnoreAlerts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbxIgnoreAlerts.UseVisualStyleBackColor = true;
            // 
            // cmbMarketList
            // 
            this.cmbMarketList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarketList.FormattingEnabled = true;
            this.cmbMarketList.Location = new System.Drawing.Point(386, 74);
            this.cmbMarketList.Name = "cmbMarketList";
            this.cmbMarketList.Size = new System.Drawing.Size(163, 21);
            this.cmbMarketList.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Assigned Market:";
            // 
            // tbxSerial
            // 
            this.tbxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSerial.Location = new System.Drawing.Point(94, 128);
            this.tbxSerial.Name = "tbxSerial";
            this.tbxSerial.Size = new System.Drawing.Size(176, 20);
            this.tbxSerial.TabIndex = 20;
            // 
            // tbxModel
            // 
            this.tbxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxModel.Location = new System.Drawing.Point(94, 102);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(176, 20);
            this.tbxModel.TabIndex = 19;
            // 
            // tbxFirmware
            // 
            this.tbxFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirmware.Location = new System.Drawing.Point(94, 76);
            this.tbxFirmware.Name = "tbxFirmware";
            this.tbxFirmware.Size = new System.Drawing.Size(176, 20);
            this.tbxFirmware.TabIndex = 18;
            // 
            // tbxAlias
            // 
            this.tbxAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAlias.Location = new System.Drawing.Point(94, 50);
            this.tbxAlias.Name = "tbxAlias";
            this.tbxAlias.Size = new System.Drawing.Size(176, 20);
            this.tbxAlias.TabIndex = 17;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(94, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(176, 20);
            this.tbxName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Serial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Model Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Firmware:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Alias:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Name:";
            // 
            // tbxIP
            // 
            this.tbxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIP.Location = new System.Drawing.Point(386, 50);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(163, 20);
            this.tbxIP.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "IP:";
            // 
            // tbxMAC
            // 
            this.tbxMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMAC.Location = new System.Drawing.Point(386, 24);
            this.tbxMAC.Name = "tbxMAC";
            this.tbxMAC.Size = new System.Drawing.Size(163, 20);
            this.tbxMAC.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(288, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "MAC Address:";
            // 
            // lblInstallDate
            // 
            this.lblInstallDate.AutoSize = true;
            this.lblInstallDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallDate.Location = new System.Drawing.Point(288, 102);
            this.lblInstallDate.Name = "lblInstallDate";
            this.lblInstallDate.Size = new System.Drawing.Size(37, 13);
            this.lblInstallDate.TabIndex = 24;
            this.lblInstallDate.Text = "Install:";
            // 
            // tbxContractNumber
            // 
            this.tbxContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContractNumber.Location = new System.Drawing.Point(386, 125);
            this.tbxContractNumber.Name = "tbxContractNumber";
            this.tbxContractNumber.Size = new System.Drawing.Size(163, 20);
            this.tbxContractNumber.TabIndex = 27;
            // 
            // lblContractNumber
            // 
            this.lblContractNumber.AutoSize = true;
            this.lblContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractNumber.Location = new System.Drawing.Point(288, 128);
            this.lblContractNumber.Name = "lblContractNumber";
            this.lblContractNumber.Size = new System.Drawing.Size(90, 13);
            this.lblContractNumber.TabIndex = 26;
            this.lblContractNumber.Text = "Contract Number:";
            // 
            // dtpInstallDate
            // 
            this.dtpInstallDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInstallDate.CustomFormat = "yyyy-MM-dd";
            this.dtpInstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInstallDate.Location = new System.Drawing.Point(386, 102);
            this.dtpInstallDate.Name = "dtpInstallDate";
            this.dtpInstallDate.Size = new System.Drawing.Size(163, 20);
            this.dtpInstallDate.TabIndex = 28;
            this.dtpInstallDate.Value = new System.DateTime(2018, 12, 5, 0, 0, 0, 0);
            // 
            // AssetComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpInfo);
            this.Name = "AssetComponent";
            this.Size = new System.Drawing.Size(633, 161);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbxSerial;
        public System.Windows.Forms.TextBox tbxModel;
        public System.Windows.Forms.TextBox tbxFirmware;
        public System.Windows.Forms.TextBox tbxAlias;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.TextBox tbxIP;
        public System.Windows.Forms.TextBox tbxMAC;
        public System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.ComboBox cmbMarketList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxIgnoreAlerts;
        public System.Windows.Forms.TextBox tbxContractNumber;
        private System.Windows.Forms.Label lblContractNumber;
        private System.Windows.Forms.Label lblInstallDate;
        private System.Windows.Forms.DateTimePicker dtpInstallDate;
    }
}
