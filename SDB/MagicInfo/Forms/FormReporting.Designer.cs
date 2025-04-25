namespace SDB.MagicInfo.Forms
{
    partial class FormReporting
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
            this.btnExport = new System.Windows.Forms.Button();
            this.tabsReportData = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cblAssetSelect = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.cblServerSelect = new System.Windows.Forms.CheckedListBox();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.gbxDateRange = new System.Windows.Forms.GroupBox();
            this.cbxAlltime = new System.Windows.Forms.CheckBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.tabMarket = new System.Windows.Forms.TabPage();
            this.tabsReportData.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxServer.SuspendLayout();
            this.gbxDateRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(478, 328);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tabsReportData
            // 
            this.tabsReportData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsReportData.Controls.Add(this.tabTickets);
            this.tabsReportData.Controls.Add(this.tabServer);
            this.tabsReportData.Controls.Add(this.tabAsset);
            this.tabsReportData.Controls.Add(this.tabMarket);
            this.tabsReportData.Location = new System.Drawing.Point(12, 12);
            this.tabsReportData.Name = "tabsReportData";
            this.tabsReportData.SelectedIndex = 0;
            this.tabsReportData.Size = new System.Drawing.Size(545, 314);
            this.tabsReportData.TabIndex = 1;
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.groupBox1);
            this.tabTickets.Controls.Add(this.gbxServer);
            this.tabTickets.Controls.Add(this.gbxDateRange);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(537, 288);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "Ticket Data";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cblAssetSelect);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(183, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 190);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset Select:";
            // 
            // cblAssetSelect
            // 
            this.cblAssetSelect.FormattingEnabled = true;
            this.cblAssetSelect.Location = new System.Drawing.Point(6, 15);
            this.cblAssetSelect.Name = "cblAssetSelect";
            this.cblAssetSelect.ScrollAlwaysVisible = true;
            this.cblAssetSelect.Size = new System.Drawing.Size(156, 139);
            this.cblAssetSelect.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // gbxServer
            // 
            this.gbxServer.Controls.Add(this.cblServerSelect);
            this.gbxServer.Controls.Add(this.cbxSelectAll);
            this.gbxServer.Location = new System.Drawing.Point(6, 94);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Size = new System.Drawing.Size(171, 190);
            this.gbxServer.TabIndex = 21;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = "Server Select:";
            // 
            // cblServerSelect
            // 
            this.cblServerSelect.FormattingEnabled = true;
            this.cblServerSelect.Location = new System.Drawing.Point(9, 15);
            this.cblServerSelect.Name = "cblServerSelect";
            this.cblServerSelect.ScrollAlwaysVisible = true;
            this.cblServerSelect.Size = new System.Drawing.Size(156, 139);
            this.cblServerSelect.TabIndex = 24;
            this.cblServerSelect.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblServerSelect_ItemCheck);
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.Location = new System.Drawing.Point(9, 167);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbxSelectAll.TabIndex = 23;
            this.cbxSelectAll.Text = "Select All";
            this.cbxSelectAll.UseVisualStyleBackColor = true;
            this.cbxSelectAll.CheckStateChanged += new System.EventHandler(this.cbxSelectAll_CheckStateChanged);
            // 
            // gbxDateRange
            // 
            this.gbxDateRange.Controls.Add(this.cbxAlltime);
            this.gbxDateRange.Controls.Add(this.dtpFromDate);
            this.gbxDateRange.Controls.Add(this.dtpToDate);
            this.gbxDateRange.Controls.Add(this.lblFromDate);
            this.gbxDateRange.Controls.Add(this.label2);
            this.gbxDateRange.Location = new System.Drawing.Point(6, 6);
            this.gbxDateRange.Name = "gbxDateRange";
            this.gbxDateRange.Size = new System.Drawing.Size(525, 82);
            this.gbxDateRange.TabIndex = 20;
            this.gbxDateRange.TabStop = false;
            this.gbxDateRange.Text = "Date Range:";
            // 
            // cbxAlltime
            // 
            this.cbxAlltime.AutoSize = true;
            this.cbxAlltime.Location = new System.Drawing.Point(278, 45);
            this.cbxAlltime.Name = "cbxAlltime";
            this.cbxAlltime.Size = new System.Drawing.Size(165, 17);
            this.cbxAlltime.TabIndex = 24;
            this.cbxAlltime.Text = "Since The Beginning Of Time";
            this.cbxAlltime.UseVisualStyleBackColor = true;
            this.cbxAlltime.CheckedChanged += new System.EventHandler(this.cbxAlltime_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(9, 42);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(126, 20);
            this.dtpFromDate.TabIndex = 16;
            this.dtpFromDate.Value = new System.DateTime(2018, 10, 3, 0, 0, 0, 0);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(141, 42);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(126, 20);
            this.dtpToDate.TabIndex = 19;
            this.dtpToDate.Value = new System.DateTime(2018, 10, 3, 0, 0, 0, 0);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(6, 26);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 17;
            this.lblFromDate.Text = "From Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "To Date:";
            // 
            // tabServer
            // 
            this.tabServer.Location = new System.Drawing.Point(4, 22);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(537, 288);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "Server Data";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // tabAsset
            // 
            this.tabAsset.Location = new System.Drawing.Point(4, 22);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsset.Size = new System.Drawing.Size(537, 288);
            this.tabAsset.TabIndex = 2;
            this.tabAsset.Text = "Asset Data";
            this.tabAsset.UseVisualStyleBackColor = true;
            // 
            // tabMarket
            // 
            this.tabMarket.Location = new System.Drawing.Point(4, 22);
            this.tabMarket.Name = "tabMarket";
            this.tabMarket.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarket.Size = new System.Drawing.Size(537, 288);
            this.tabMarket.TabIndex = 3;
            this.tabMarket.Text = "Market Data";
            this.tabMarket.UseVisualStyleBackColor = true;
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.tabsReportData);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormReporting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.ServerList_VisibleChanged);
            this.tabsReportData.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxServer.ResumeLayout(false);
            this.gbxServer.PerformLayout();
            this.gbxDateRange.ResumeLayout(false);
            this.gbxDateRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TabControl tabsReportData;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabPage tabAsset;
        private System.Windows.Forms.TabPage tabMarket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private System.Windows.Forms.GroupBox gbxDateRange;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox cblServerSelect;
        private System.Windows.Forms.CheckedListBox cblAssetSelect;
        private System.Windows.Forms.CheckBox cbxAlltime;
    }
}