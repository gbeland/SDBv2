using SDB.Classes.Misc;

namespace SDB.Forms.Asset
{
    partial class FormAsset_Warranty
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
            this.lblDateClearInfo = new System.Windows.Forms.Label();
            this.lblAsset = new System.Windows.Forms.Label();
            this.txtAsset = new System.Windows.Forms.TextBox();
            this.lblReleaseNumber = new System.Windows.Forms.Label();
            this.txtReleaseNumber = new System.Windows.Forms.TextBox();
            this.txtPartsWarrantyNumber = new System.Windows.Forms.TextBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtLaborWarrantyNumber = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblInstallDate = new System.Windows.Forms.Label();
            this.lblShippingDate = new System.Windows.Forms.Label();
            this.chkLaborContractIsMonitoring = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtPartsContractNumber = new System.Windows.Forms.TextBox();
            this.txtLaborContractNumber = new System.Windows.Forms.TextBox();
            this.pnlLaborContract = new System.Windows.Forms.Panel();
            this.lblLaborContractDuration = new System.Windows.Forms.Label();
            this.lblLaborContractExpires = new System.Windows.Forms.Label();
            this.lblLaborContractStarts = new System.Windows.Forms.Label();
            this.lblLaborContractNumber = new System.Windows.Forms.Label();
            this.ndtpLaborContractExpires = new SDB.Classes.Misc.NullableDateTimePicker();
            this.ndtpLaborContractStarts = new SDB.Classes.Misc.NullableDateTimePicker();
            this.pnlPartsContract = new System.Windows.Forms.Panel();
            this.lblPartsContractDuration = new System.Windows.Forms.Label();
            this.lblPartsContractExpires = new System.Windows.Forms.Label();
            this.lblPartsContractStarts = new System.Windows.Forms.Label();
            this.lblPartsContractNumber = new System.Windows.Forms.Label();
            this.ndtpPartsContractExpires = new SDB.Classes.Misc.NullableDateTimePicker();
            this.ndtpPartsContractStarts = new SDB.Classes.Misc.NullableDateTimePicker();
            this.pnlLaborWarranty = new System.Windows.Forms.Panel();
            this.lblLaborWarrantyDuration = new System.Windows.Forms.Label();
            this.lblLaborWarrantyNumber = new System.Windows.Forms.Label();
            this.lblLaborWarrantyExpire = new System.Windows.Forms.Label();
            this.lblLaborWarrantyStarts = new System.Windows.Forms.Label();
            this.ndtpLaborWarrantyExpires = new SDB.Classes.Misc.NullableDateTimePicker();
            this.ndtpLaborWarrantyStarts = new SDB.Classes.Misc.NullableDateTimePicker();
            this.pnlPartsWarranty = new System.Windows.Forms.Panel();
            this.lblPartsWarrantyDuration = new System.Windows.Forms.Label();
            this.lblPartsWarrantyNumber = new System.Windows.Forms.Label();
            this.ndtpPartsWarrantyExpires = new SDB.Classes.Misc.NullableDateTimePicker();
            this.lblPartsWarrantyExpires = new System.Windows.Forms.Label();
            this.ndtpPartsWarrantyStarts = new SDB.Classes.Misc.NullableDateTimePicker();
            this.lblPartsWarrantyStarts = new System.Windows.Forms.Label();
            this.pnlWarranty = new System.Windows.Forms.Panel();
            this.pnlContract = new System.Windows.Forms.Panel();
            this.pnlLabor = new System.Windows.Forms.Panel();
            this.pnlParts = new System.Windows.Forms.Panel();
            this.lblPanel = new System.Windows.Forms.Label();
            this.txtPanel = new System.Windows.Forms.TextBox();
            this.cbxBillToMarket = new System.Windows.Forms.CheckBox();
            this.pnlLaborContract.SuspendLayout();
            this.pnlPartsContract.SuspendLayout();
            this.pnlLaborWarranty.SuspendLayout();
            this.pnlPartsWarranty.SuspendLayout();
            this.pnlWarranty.SuspendLayout();
            this.pnlContract.SuspendLayout();
            this.pnlLabor.SuspendLayout();
            this.pnlParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateClearInfo
            // 
            this.lblDateClearInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateClearInfo.AutoSize = true;
            this.lblDateClearInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateClearInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDateClearInfo.Location = new System.Drawing.Point(12, 376);
            this.lblDateClearInfo.Name = "lblDateClearInfo";
            this.lblDateClearInfo.Size = new System.Drawing.Size(162, 13);
            this.lblDateClearInfo.TabIndex = 12;
            this.lblDateClearInfo.Text = "Press delete on a date to clear it.";
            // 
            // lblAsset
            // 
            this.lblAsset.AutoSize = true;
            this.lblAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsset.Location = new System.Drawing.Point(71, 16);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(33, 13);
            this.lblAsset.TabIndex = 0;
            this.lblAsset.Text = "Asset";
            this.lblAsset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAsset
            // 
            this.txtAsset.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsset.Location = new System.Drawing.Point(110, 11);
            this.txtAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAsset.MaxLength = 20;
            this.txtAsset.Name = "txtAsset";
            this.txtAsset.ReadOnly = true;
            this.txtAsset.Size = new System.Drawing.Size(316, 19);
            this.txtAsset.TabIndex = 1;
            this.txtAsset.TabStop = false;
            // 
            // lblReleaseNumber
            // 
            this.lblReleaseNumber.AutoSize = true;
            this.lblReleaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseNumber.Location = new System.Drawing.Point(492, 16);
            this.lblReleaseNumber.Name = "lblReleaseNumber";
            this.lblReleaseNumber.Size = new System.Drawing.Size(86, 13);
            this.lblReleaseNumber.TabIndex = 4;
            this.lblReleaseNumber.Text = "Release Number";
            this.lblReleaseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReleaseNumber
            // 
            this.txtReleaseNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.txtReleaseNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReleaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseNumber.Location = new System.Drawing.Point(584, 11);
            this.txtReleaseNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReleaseNumber.MaxLength = 10;
            this.txtReleaseNumber.Name = "txtReleaseNumber";
            this.txtReleaseNumber.ReadOnly = true;
            this.txtReleaseNumber.Size = new System.Drawing.Size(126, 19);
            this.txtReleaseNumber.TabIndex = 5;
            this.txtReleaseNumber.TabStop = false;
            // 
            // txtPartsWarrantyNumber
            // 
            this.txtPartsWarrantyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartsWarrantyNumber.Location = new System.Drawing.Point(141, 7);
            this.txtPartsWarrantyNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartsWarrantyNumber.MaxLength = 20;
            this.txtPartsWarrantyNumber.Name = "txtPartsWarrantyNumber";
            this.txtPartsWarrantyNumber.Size = new System.Drawing.Size(155, 22);
            this.txtPartsWarrantyNumber.TabIndex = 1;
            this.txtPartsWarrantyNumber.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // lblParts
            // 
            this.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(0, 0);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(316, 36);
            this.lblParts.TabIndex = 3;
            this.lblParts.Text = "Parts";
            this.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLaborWarrantyNumber
            // 
            this.txtLaborWarrantyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaborWarrantyNumber.Location = new System.Drawing.Point(141, 7);
            this.txtLaborWarrantyNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaborWarrantyNumber.MaxLength = 20;
            this.txtLaborWarrantyNumber.Name = "txtLaborWarrantyNumber";
            this.txtLaborWarrantyNumber.Size = new System.Drawing.Size(155, 22);
            this.txtLaborWarrantyNumber.TabIndex = 1;
            this.txtLaborWarrantyNumber.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // lblLabor
            // 
            this.lblLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabor.Location = new System.Drawing.Point(0, 0);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(316, 36);
            this.lblLabor.TabIndex = 0;
            this.lblLabor.Text = "Labor";
            this.lblLabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstallDate
            // 
            this.lblInstallDate.AutoSize = true;
            this.lblInstallDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstallDate.Location = new System.Drawing.Point(25, 76);
            this.lblInstallDate.Name = "lblInstallDate";
            this.lblInstallDate.Size = new System.Drawing.Size(66, 13);
            this.lblInstallDate.TabIndex = 7;
            this.lblInstallDate.Text = "(Install Date)";
            this.lblInstallDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShippingDate
            // 
            this.lblShippingDate.AutoSize = true;
            this.lblShippingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShippingDate.Location = new System.Drawing.Point(25, 76);
            this.lblShippingDate.Name = "lblShippingDate";
            this.lblShippingDate.Size = new System.Drawing.Size(80, 13);
            this.lblShippingDate.TabIndex = 7;
            this.lblShippingDate.Text = "(Shipping Date)";
            this.lblShippingDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLaborContractIsMonitoring
            // 
            this.chkLaborContractIsMonitoring.AutoSize = true;
            this.chkLaborContractIsMonitoring.Location = new System.Drawing.Point(18, 78);
            this.chkLaborContractIsMonitoring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkLaborContractIsMonitoring.Name = "chkLaborContractIsMonitoring";
            this.chkLaborContractIsMonitoring.Size = new System.Drawing.Size(197, 17);
            this.chkLaborContractIsMonitoring.TabIndex = 7;
            this.chkLaborContractIsMonitoring.Text = "Labor Contract is for Monitoring Only";
            this.chkLaborContractIsMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(596, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(677, 366);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save/Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWarranty
            // 
            this.lblWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarranty.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(0, 0);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(85, 120);
            this.lblWarranty.TabIndex = 9;
            this.lblWarranty.Text = "Warranty";
            this.lblWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContract
            // 
            this.lblContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContract.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(0, 0);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(85, 120);
            this.lblContract.TabIndex = 10;
            this.lblContract.Text = "Contract";
            this.lblContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPartsContractNumber
            // 
            this.txtPartsContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartsContractNumber.Location = new System.Drawing.Point(141, 7);
            this.txtPartsContractNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPartsContractNumber.MaxLength = 20;
            this.txtPartsContractNumber.Name = "txtPartsContractNumber";
            this.txtPartsContractNumber.Size = new System.Drawing.Size(155, 22);
            this.txtPartsContractNumber.TabIndex = 1;
            this.txtPartsContractNumber.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // txtLaborContractNumber
            // 
            this.txtLaborContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaborContractNumber.Location = new System.Drawing.Point(141, 7);
            this.txtLaborContractNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaborContractNumber.MaxLength = 20;
            this.txtLaborContractNumber.Name = "txtLaborContractNumber";
            this.txtLaborContractNumber.Size = new System.Drawing.Size(155, 22);
            this.txtLaborContractNumber.TabIndex = 1;
            this.txtLaborContractNumber.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // pnlLaborContract
            // 
            this.pnlLaborContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(208)))), ((int)(((byte)(224)))));
            this.pnlLaborContract.Controls.Add(this.cbxBillToMarket);
            this.pnlLaborContract.Controls.Add(this.lblLaborContractDuration);
            this.pnlLaborContract.Controls.Add(this.lblLaborContractExpires);
            this.pnlLaborContract.Controls.Add(this.lblLaborContractStarts);
            this.pnlLaborContract.Controls.Add(this.chkLaborContractIsMonitoring);
            this.pnlLaborContract.Controls.Add(this.lblLaborContractNumber);
            this.pnlLaborContract.Controls.Add(this.ndtpLaborContractExpires);
            this.pnlLaborContract.Controls.Add(this.txtLaborContractNumber);
            this.pnlLaborContract.Controls.Add(this.ndtpLaborContractStarts);
            this.pnlLaborContract.Location = new System.Drawing.Point(88, 0);
            this.pnlLaborContract.Name = "pnlLaborContract";
            this.pnlLaborContract.Size = new System.Drawing.Size(316, 119);
            this.pnlLaborContract.TabIndex = 0;
            // 
            // lblLaborContractDuration
            // 
            this.lblLaborContractDuration.AutoSize = true;
            this.lblLaborContractDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLaborContractDuration.Location = new System.Drawing.Point(249, 60);
            this.lblLaborContractDuration.Name = "lblLaborContractDuration";
            this.lblLaborContractDuration.Size = new System.Drawing.Size(47, 13);
            this.lblLaborContractDuration.TabIndex = 6;
            this.lblLaborContractDuration.Text = "Duration";
            // 
            // lblLaborContractExpires
            // 
            this.lblLaborContractExpires.AutoSize = true;
            this.lblLaborContractExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborContractExpires.Location = new System.Drawing.Point(141, 38);
            this.lblLaborContractExpires.Name = "lblLaborContractExpires";
            this.lblLaborContractExpires.Size = new System.Drawing.Size(41, 13);
            this.lblLaborContractExpires.TabIndex = 4;
            this.lblLaborContractExpires.Text = "Expires";
            this.lblLaborContractExpires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaborContractStarts
            // 
            this.lblLaborContractStarts.AutoSize = true;
            this.lblLaborContractStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborContractStarts.Location = new System.Drawing.Point(25, 38);
            this.lblLaborContractStarts.Name = "lblLaborContractStarts";
            this.lblLaborContractStarts.Size = new System.Drawing.Size(34, 13);
            this.lblLaborContractStarts.TabIndex = 2;
            this.lblLaborContractStarts.Text = "Starts";
            this.lblLaborContractStarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaborContractNumber
            // 
            this.lblLaborContractNumber.AutoSize = true;
            this.lblLaborContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborContractNumber.Location = new System.Drawing.Point(15, 12);
            this.lblLaborContractNumber.Name = "lblLaborContractNumber";
            this.lblLaborContractNumber.Size = new System.Drawing.Size(117, 13);
            this.lblLaborContractNumber.TabIndex = 0;
            this.lblLaborContractNumber.Text = "Labor Contract Number";
            this.lblLaborContractNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndtpLaborContractExpires
            // 
            this.ndtpLaborContractExpires.CustomFormat = " ";
            this.ndtpLaborContractExpires.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpLaborContractExpires.Location = new System.Drawing.Point(141, 54);
            this.ndtpLaborContractExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpLaborContractExpires.Name = "ndtpLaborContractExpires";
            this.ndtpLaborContractExpires.Size = new System.Drawing.Size(100, 20);
            this.ndtpLaborContractExpires.TabIndex = 5;
            this.ndtpLaborContractExpires.Value = null;
            this.ndtpLaborContractExpires.ValueChanged += new System.EventHandler(this.ndtpLaborContractExpires_ValueChanged);
            this.ndtpLaborContractExpires.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // ndtpLaborContractStarts
            // 
            this.ndtpLaborContractStarts.CustomFormat = " ";
            this.ndtpLaborContractStarts.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpLaborContractStarts.Location = new System.Drawing.Point(25, 54);
            this.ndtpLaborContractStarts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpLaborContractStarts.Name = "ndtpLaborContractStarts";
            this.ndtpLaborContractStarts.Size = new System.Drawing.Size(100, 20);
            this.ndtpLaborContractStarts.TabIndex = 3;
            this.ndtpLaborContractStarts.Value = null;
            this.ndtpLaborContractStarts.ValueChanged += new System.EventHandler(this.ndtpLaborContractStarts_ValueChanged);
            this.ndtpLaborContractStarts.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // pnlPartsContract
            // 
            this.pnlPartsContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPartsContract.Controls.Add(this.lblPartsContractDuration);
            this.pnlPartsContract.Controls.Add(this.lblPartsContractExpires);
            this.pnlPartsContract.Controls.Add(this.lblPartsContractStarts);
            this.pnlPartsContract.Controls.Add(this.lblPartsContractNumber);
            this.pnlPartsContract.Controls.Add(this.ndtpPartsContractExpires);
            this.pnlPartsContract.Controls.Add(this.txtPartsContractNumber);
            this.pnlPartsContract.Controls.Add(this.ndtpPartsContractStarts);
            this.pnlPartsContract.Location = new System.Drawing.Point(404, 0);
            this.pnlPartsContract.Name = "pnlPartsContract";
            this.pnlPartsContract.Size = new System.Drawing.Size(316, 119);
            this.pnlPartsContract.TabIndex = 1;
            // 
            // lblPartsContractDuration
            // 
            this.lblPartsContractDuration.AutoSize = true;
            this.lblPartsContractDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartsContractDuration.Location = new System.Drawing.Point(249, 60);
            this.lblPartsContractDuration.Name = "lblPartsContractDuration";
            this.lblPartsContractDuration.Size = new System.Drawing.Size(47, 13);
            this.lblPartsContractDuration.TabIndex = 6;
            this.lblPartsContractDuration.Text = "Duration";
            // 
            // lblPartsContractExpires
            // 
            this.lblPartsContractExpires.AutoSize = true;
            this.lblPartsContractExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsContractExpires.Location = new System.Drawing.Point(141, 38);
            this.lblPartsContractExpires.Name = "lblPartsContractExpires";
            this.lblPartsContractExpires.Size = new System.Drawing.Size(41, 13);
            this.lblPartsContractExpires.TabIndex = 4;
            this.lblPartsContractExpires.Text = "Expires";
            this.lblPartsContractExpires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartsContractStarts
            // 
            this.lblPartsContractStarts.AutoSize = true;
            this.lblPartsContractStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsContractStarts.Location = new System.Drawing.Point(25, 38);
            this.lblPartsContractStarts.Name = "lblPartsContractStarts";
            this.lblPartsContractStarts.Size = new System.Drawing.Size(34, 13);
            this.lblPartsContractStarts.TabIndex = 2;
            this.lblPartsContractStarts.Text = "Starts";
            this.lblPartsContractStarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartsContractNumber
            // 
            this.lblPartsContractNumber.AutoSize = true;
            this.lblPartsContractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsContractNumber.Location = new System.Drawing.Point(15, 12);
            this.lblPartsContractNumber.Name = "lblPartsContractNumber";
            this.lblPartsContractNumber.Size = new System.Drawing.Size(114, 13);
            this.lblPartsContractNumber.TabIndex = 0;
            this.lblPartsContractNumber.Text = "Parts Contract Number";
            this.lblPartsContractNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndtpPartsContractExpires
            // 
            this.ndtpPartsContractExpires.CustomFormat = " ";
            this.ndtpPartsContractExpires.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpPartsContractExpires.Location = new System.Drawing.Point(141, 54);
            this.ndtpPartsContractExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpPartsContractExpires.Name = "ndtpPartsContractExpires";
            this.ndtpPartsContractExpires.Size = new System.Drawing.Size(100, 20);
            this.ndtpPartsContractExpires.TabIndex = 5;
            this.ndtpPartsContractExpires.Value = null;
            this.ndtpPartsContractExpires.ValueChanged += new System.EventHandler(this.ndtpPartsContractExpires_ValueChanged);
            this.ndtpPartsContractExpires.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // ndtpPartsContractStarts
            // 
            this.ndtpPartsContractStarts.CustomFormat = " ";
            this.ndtpPartsContractStarts.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpPartsContractStarts.Location = new System.Drawing.Point(25, 54);
            this.ndtpPartsContractStarts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpPartsContractStarts.Name = "ndtpPartsContractStarts";
            this.ndtpPartsContractStarts.Size = new System.Drawing.Size(100, 20);
            this.ndtpPartsContractStarts.TabIndex = 3;
            this.ndtpPartsContractStarts.Value = null;
            this.ndtpPartsContractStarts.ValueChanged += new System.EventHandler(this.ndtpPartsContractStarts_ValueChanged);
            this.ndtpPartsContractStarts.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // pnlLaborWarranty
            // 
            this.pnlLaborWarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.pnlLaborWarranty.Controls.Add(this.lblLaborWarrantyDuration);
            this.pnlLaborWarranty.Controls.Add(this.lblLaborWarrantyNumber);
            this.pnlLaborWarranty.Controls.Add(this.lblLaborWarrantyExpire);
            this.pnlLaborWarranty.Controls.Add(this.lblLaborWarrantyStarts);
            this.pnlLaborWarranty.Controls.Add(this.txtLaborWarrantyNumber);
            this.pnlLaborWarranty.Controls.Add(this.ndtpLaborWarrantyExpires);
            this.pnlLaborWarranty.Controls.Add(this.ndtpLaborWarrantyStarts);
            this.pnlLaborWarranty.Controls.Add(this.lblInstallDate);
            this.pnlLaborWarranty.Location = new System.Drawing.Point(88, 0);
            this.pnlLaborWarranty.Name = "pnlLaborWarranty";
            this.pnlLaborWarranty.Size = new System.Drawing.Size(316, 120);
            this.pnlLaborWarranty.TabIndex = 0;
            // 
            // lblLaborWarrantyDuration
            // 
            this.lblLaborWarrantyDuration.AutoSize = true;
            this.lblLaborWarrantyDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLaborWarrantyDuration.Location = new System.Drawing.Point(249, 60);
            this.lblLaborWarrantyDuration.Name = "lblLaborWarrantyDuration";
            this.lblLaborWarrantyDuration.Size = new System.Drawing.Size(47, 13);
            this.lblLaborWarrantyDuration.TabIndex = 6;
            this.lblLaborWarrantyDuration.Text = "Duration";
            // 
            // lblLaborWarrantyNumber
            // 
            this.lblLaborWarrantyNumber.AutoSize = true;
            this.lblLaborWarrantyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborWarrantyNumber.Location = new System.Drawing.Point(15, 12);
            this.lblLaborWarrantyNumber.Name = "lblLaborWarrantyNumber";
            this.lblLaborWarrantyNumber.Size = new System.Drawing.Size(120, 13);
            this.lblLaborWarrantyNumber.TabIndex = 0;
            this.lblLaborWarrantyNumber.Text = "Labor Warranty Number";
            this.lblLaborWarrantyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaborWarrantyExpire
            // 
            this.lblLaborWarrantyExpire.AutoSize = true;
            this.lblLaborWarrantyExpire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborWarrantyExpire.Location = new System.Drawing.Point(141, 38);
            this.lblLaborWarrantyExpire.Name = "lblLaborWarrantyExpire";
            this.lblLaborWarrantyExpire.Size = new System.Drawing.Size(41, 13);
            this.lblLaborWarrantyExpire.TabIndex = 4;
            this.lblLaborWarrantyExpire.Text = "Expires";
            this.lblLaborWarrantyExpire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaborWarrantyStarts
            // 
            this.lblLaborWarrantyStarts.AutoSize = true;
            this.lblLaborWarrantyStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborWarrantyStarts.Location = new System.Drawing.Point(25, 38);
            this.lblLaborWarrantyStarts.Name = "lblLaborWarrantyStarts";
            this.lblLaborWarrantyStarts.Size = new System.Drawing.Size(34, 13);
            this.lblLaborWarrantyStarts.TabIndex = 2;
            this.lblLaborWarrantyStarts.Text = "Starts";
            this.lblLaborWarrantyStarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndtpLaborWarrantyExpires
            // 
            this.ndtpLaborWarrantyExpires.CustomFormat = " ";
            this.ndtpLaborWarrantyExpires.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpLaborWarrantyExpires.Location = new System.Drawing.Point(141, 54);
            this.ndtpLaborWarrantyExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpLaborWarrantyExpires.Name = "ndtpLaborWarrantyExpires";
            this.ndtpLaborWarrantyExpires.Size = new System.Drawing.Size(100, 20);
            this.ndtpLaborWarrantyExpires.TabIndex = 5;
            this.ndtpLaborWarrantyExpires.Value = null;
            this.ndtpLaborWarrantyExpires.ValueChanged += new System.EventHandler(this.ndtpLaborWarrantyExpires_ValueChanged);
            this.ndtpLaborWarrantyExpires.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // ndtpLaborWarrantyStarts
            // 
            this.ndtpLaborWarrantyStarts.CustomFormat = " ";
            this.ndtpLaborWarrantyStarts.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpLaborWarrantyStarts.Location = new System.Drawing.Point(25, 54);
            this.ndtpLaborWarrantyStarts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpLaborWarrantyStarts.Name = "ndtpLaborWarrantyStarts";
            this.ndtpLaborWarrantyStarts.Size = new System.Drawing.Size(100, 20);
            this.ndtpLaborWarrantyStarts.TabIndex = 3;
            this.ndtpLaborWarrantyStarts.Value = null;
            this.ndtpLaborWarrantyStarts.ValueChanged += new System.EventHandler(this.ndtpLaborWarrantyStarts_ValueChanged);
            this.ndtpLaborWarrantyStarts.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // pnlPartsWarranty
            // 
            this.pnlPartsWarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPartsWarranty.Controls.Add(this.lblPartsWarrantyDuration);
            this.pnlPartsWarranty.Controls.Add(this.lblPartsWarrantyNumber);
            this.pnlPartsWarranty.Controls.Add(this.ndtpPartsWarrantyExpires);
            this.pnlPartsWarranty.Controls.Add(this.lblPartsWarrantyExpires);
            this.pnlPartsWarranty.Controls.Add(this.ndtpPartsWarrantyStarts);
            this.pnlPartsWarranty.Controls.Add(this.lblPartsWarrantyStarts);
            this.pnlPartsWarranty.Controls.Add(this.txtPartsWarrantyNumber);
            this.pnlPartsWarranty.Controls.Add(this.lblShippingDate);
            this.pnlPartsWarranty.Location = new System.Drawing.Point(404, 0);
            this.pnlPartsWarranty.Name = "pnlPartsWarranty";
            this.pnlPartsWarranty.Size = new System.Drawing.Size(316, 120);
            this.pnlPartsWarranty.TabIndex = 1;
            // 
            // lblPartsWarrantyDuration
            // 
            this.lblPartsWarrantyDuration.AutoSize = true;
            this.lblPartsWarrantyDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPartsWarrantyDuration.Location = new System.Drawing.Point(249, 60);
            this.lblPartsWarrantyDuration.Name = "lblPartsWarrantyDuration";
            this.lblPartsWarrantyDuration.Size = new System.Drawing.Size(47, 13);
            this.lblPartsWarrantyDuration.TabIndex = 6;
            this.lblPartsWarrantyDuration.Text = "Duration";
            // 
            // lblPartsWarrantyNumber
            // 
            this.lblPartsWarrantyNumber.AutoSize = true;
            this.lblPartsWarrantyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsWarrantyNumber.Location = new System.Drawing.Point(15, 12);
            this.lblPartsWarrantyNumber.Name = "lblPartsWarrantyNumber";
            this.lblPartsWarrantyNumber.Size = new System.Drawing.Size(117, 13);
            this.lblPartsWarrantyNumber.TabIndex = 0;
            this.lblPartsWarrantyNumber.Text = "Parts Warranty Number";
            this.lblPartsWarrantyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndtpPartsWarrantyExpires
            // 
            this.ndtpPartsWarrantyExpires.CustomFormat = " ";
            this.ndtpPartsWarrantyExpires.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpPartsWarrantyExpires.Location = new System.Drawing.Point(141, 54);
            this.ndtpPartsWarrantyExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpPartsWarrantyExpires.Name = "ndtpPartsWarrantyExpires";
            this.ndtpPartsWarrantyExpires.Size = new System.Drawing.Size(100, 20);
            this.ndtpPartsWarrantyExpires.TabIndex = 5;
            this.ndtpPartsWarrantyExpires.Value = null;
            this.ndtpPartsWarrantyExpires.ValueChanged += new System.EventHandler(this.ndtpPartsWarrantyExpires_ValueChanged);
            this.ndtpPartsWarrantyExpires.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // lblPartsWarrantyExpires
            // 
            this.lblPartsWarrantyExpires.AutoSize = true;
            this.lblPartsWarrantyExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsWarrantyExpires.Location = new System.Drawing.Point(141, 38);
            this.lblPartsWarrantyExpires.Name = "lblPartsWarrantyExpires";
            this.lblPartsWarrantyExpires.Size = new System.Drawing.Size(41, 13);
            this.lblPartsWarrantyExpires.TabIndex = 4;
            this.lblPartsWarrantyExpires.Text = "Expires";
            this.lblPartsWarrantyExpires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ndtpPartsWarrantyStarts
            // 
            this.ndtpPartsWarrantyStarts.CustomFormat = " ";
            this.ndtpPartsWarrantyStarts.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndtpPartsWarrantyStarts.Location = new System.Drawing.Point(25, 54);
            this.ndtpPartsWarrantyStarts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ndtpPartsWarrantyStarts.Name = "ndtpPartsWarrantyStarts";
            this.ndtpPartsWarrantyStarts.Size = new System.Drawing.Size(100, 20);
            this.ndtpPartsWarrantyStarts.TabIndex = 3;
            this.ndtpPartsWarrantyStarts.Value = null;
            this.ndtpPartsWarrantyStarts.ValueChanged += new System.EventHandler(this.ndtpPartsWarrantyStarts_ValueChanged);
            this.ndtpPartsWarrantyStarts.Enter += new System.EventHandler(this.ndtp_Enter);
            // 
            // lblPartsWarrantyStarts
            // 
            this.lblPartsWarrantyStarts.AutoSize = true;
            this.lblPartsWarrantyStarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsWarrantyStarts.Location = new System.Drawing.Point(25, 38);
            this.lblPartsWarrantyStarts.Name = "lblPartsWarrantyStarts";
            this.lblPartsWarrantyStarts.Size = new System.Drawing.Size(34, 13);
            this.lblPartsWarrantyStarts.TabIndex = 2;
            this.lblPartsWarrantyStarts.Text = "Starts";
            this.lblPartsWarrantyStarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWarranty
            // 
            this.pnlWarranty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlWarranty.Controls.Add(this.lblWarranty);
            this.pnlWarranty.Controls.Add(this.pnlLaborWarranty);
            this.pnlWarranty.Controls.Add(this.pnlPartsWarranty);
            this.pnlWarranty.Location = new System.Drawing.Point(22, 111);
            this.pnlWarranty.Name = "pnlWarranty";
            this.pnlWarranty.Size = new System.Drawing.Size(720, 120);
            this.pnlWarranty.TabIndex = 6;
            // 
            // pnlContract
            // 
            this.pnlContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlContract.Controls.Add(this.lblContract);
            this.pnlContract.Controls.Add(this.pnlLaborContract);
            this.pnlContract.Controls.Add(this.pnlPartsContract);
            this.pnlContract.Location = new System.Drawing.Point(22, 231);
            this.pnlContract.Name = "pnlContract";
            this.pnlContract.Size = new System.Drawing.Size(720, 120);
            this.pnlContract.TabIndex = 7;
            // 
            // pnlLabor
            // 
            this.pnlLabor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlLabor.Controls.Add(this.lblLabor);
            this.pnlLabor.Location = new System.Drawing.Point(110, 72);
            this.pnlLabor.Name = "pnlLabor";
            this.pnlLabor.Size = new System.Drawing.Size(316, 279);
            this.pnlLabor.TabIndex = 8;
            // 
            // pnlParts
            // 
            this.pnlParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlParts.Controls.Add(this.lblParts);
            this.pnlParts.Location = new System.Drawing.Point(426, 72);
            this.pnlParts.Name = "pnlParts";
            this.pnlParts.Size = new System.Drawing.Size(316, 279);
            this.pnlParts.TabIndex = 9;
            // 
            // lblPanel
            // 
            this.lblPanel.AutoSize = true;
            this.lblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel.Location = new System.Drawing.Point(71, 40);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(34, 13);
            this.lblPanel.TabIndex = 2;
            this.lblPanel.Text = "Panel";
            this.lblPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPanel
            // 
            this.txtPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanel.Location = new System.Drawing.Point(110, 35);
            this.txtPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPanel.MaxLength = 20;
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.ReadOnly = true;
            this.txtPanel.Size = new System.Drawing.Size(316, 19);
            this.txtPanel.TabIndex = 3;
            this.txtPanel.TabStop = false;
            // 
            // cbxBillToMarket
            // 
            this.cbxBillToMarket.AutoSize = true;
            this.cbxBillToMarket.Location = new System.Drawing.Point(18, 99);
            this.cbxBillToMarket.Name = "cbxBillToMarket";
            this.cbxBillToMarket.Size = new System.Drawing.Size(124, 17);
            this.cbxBillToMarket.TabIndex = 31;
            this.cbxBillToMarket.Text = "Tech Bills To Market";
            this.cbxBillToMarket.UseVisualStyleBackColor = true;
            // 
            // FormAsset_Warranty
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(764, 398);
            this.Controls.Add(this.pnlWarranty);
            this.Controls.Add(this.pnlContract);
            this.Controls.Add(this.pnlLabor);
            this.Controls.Add(this.pnlParts);
            this.Controls.Add(this.lblAsset);
            this.Controls.Add(this.txtAsset);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblReleaseNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReleaseNumber);
            this.Controls.Add(this.lblDateClearInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAsset_Warranty";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asset Warranty Info";
            this.Load += new System.EventHandler(this.frmWarranty_Load);
            this.pnlLaborContract.ResumeLayout(false);
            this.pnlLaborContract.PerformLayout();
            this.pnlPartsContract.ResumeLayout(false);
            this.pnlPartsContract.PerformLayout();
            this.pnlLaborWarranty.ResumeLayout(false);
            this.pnlLaborWarranty.PerformLayout();
            this.pnlPartsWarranty.ResumeLayout(false);
            this.pnlPartsWarranty.PerformLayout();
            this.pnlWarranty.ResumeLayout(false);
            this.pnlContract.ResumeLayout(false);
            this.pnlLabor.ResumeLayout(false);
            this.pnlParts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lblInstallDate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblShippingDate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblAsset;
		private System.Windows.Forms.TextBox txtAsset;
		private System.Windows.Forms.Label lblReleaseNumber;
		private System.Windows.Forms.TextBox txtReleaseNumber;
		private System.Windows.Forms.TextBox txtPartsWarrantyNumber;
		private System.Windows.Forms.Label lblParts;
		private System.Windows.Forms.TextBox txtLaborWarrantyNumber;
		private System.Windows.Forms.Label lblLabor;
		private NullableDateTimePicker ndtpPartsWarrantyExpires;
		private NullableDateTimePicker ndtpLaborWarrantyExpires;
		private NullableDateTimePicker ndtpPartsWarrantyStarts;
		private NullableDateTimePicker ndtpLaborWarrantyStarts;
		private NullableDateTimePicker ndtpPartsContractExpires;
		private NullableDateTimePicker ndtpLaborContractExpires;
		private NullableDateTimePicker ndtpPartsContractStarts;
		private NullableDateTimePicker ndtpLaborContractStarts;
		private System.Windows.Forms.Label lblDateClearInfo;
		private System.Windows.Forms.CheckBox chkLaborContractIsMonitoring;
		private System.Windows.Forms.Label lblWarranty;
		private System.Windows.Forms.Label lblContract;
		private System.Windows.Forms.TextBox txtPartsContractNumber;
		private System.Windows.Forms.TextBox txtLaborContractNumber;
		private System.Windows.Forms.Panel pnlLaborContract;
		private System.Windows.Forms.Panel pnlPartsContract;
		private System.Windows.Forms.Panel pnlLaborWarranty;
		private System.Windows.Forms.Label lblLaborWarrantyExpire;
		private System.Windows.Forms.Label lblLaborWarrantyStarts;
		private System.Windows.Forms.Panel pnlPartsWarranty;
		private System.Windows.Forms.Label lblPartsWarrantyExpires;
		private System.Windows.Forms.Label lblPartsWarrantyStarts;
		private System.Windows.Forms.Label lblLaborContractNumber;
		private System.Windows.Forms.Label lblPartsContractNumber;
		private System.Windows.Forms.Label lblLaborWarrantyNumber;
		private System.Windows.Forms.Label lblPartsWarrantyNumber;
		private System.Windows.Forms.Panel pnlWarranty;
		private System.Windows.Forms.Panel pnlContract;
		private System.Windows.Forms.Panel pnlLabor;
		private System.Windows.Forms.Panel pnlParts;
		private System.Windows.Forms.Label lblLaborContractDuration;
		private System.Windows.Forms.Label lblLaborContractExpires;
		private System.Windows.Forms.Label lblLaborContractStarts;
		private System.Windows.Forms.Label lblPartsContractDuration;
		private System.Windows.Forms.Label lblPartsContractExpires;
		private System.Windows.Forms.Label lblPartsContractStarts;
		private System.Windows.Forms.Label lblLaborWarrantyDuration;
		private System.Windows.Forms.Label lblPartsWarrantyDuration;
		private System.Windows.Forms.Label lblPanel;
		private System.Windows.Forms.TextBox txtPanel;
        private System.Windows.Forms.CheckBox cbxBillToMarket;
    }
}