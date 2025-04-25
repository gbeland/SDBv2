namespace MagicInformant
{
    partial class FormMagicInformant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagicInformant));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmiConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxActions = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxAlerts = new System.Windows.Forms.GroupBox();
            this.floAlertList = new System.Windows.Forms.FlowLayoutPanel();
            this.gbxLog = new System.Windows.Forms.GroupBox();
            this.tbxLog = new System.Windows.Forms.RichTextBox();
            this.timerUpdateAlerts = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateLog = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbxActions.SuspendLayout();
            this.gbxAlerts.SuspendLayout();
            this.gbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiConfigure});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmiConfigure
            // 
            this.tmiConfigure.Name = "tmiConfigure";
            this.tmiConfigure.Size = new System.Drawing.Size(72, 20);
            this.tmiConfigure.Text = "Configure";
            this.tmiConfigure.Click += new System.EventHandler(this.tmiConfigure_Click);
            // 
            // gbxActions
            // 
            this.gbxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxActions.Controls.Add(this.btnUpdate);
            this.gbxActions.Location = new System.Drawing.Point(19, 444);
            this.gbxActions.Name = "gbxActions";
            this.gbxActions.Size = new System.Drawing.Size(936, 39);
            this.gbxActions.TabIndex = 2;
            this.gbxActions.TabStop = false;
            this.gbxActions.Text = "Actions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(850, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxAlerts
            // 
            this.gbxAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxAlerts.Controls.Add(this.floAlertList);
            this.gbxAlerts.Location = new System.Drawing.Point(12, 39);
            this.gbxAlerts.Name = "gbxAlerts";
            this.gbxAlerts.Size = new System.Drawing.Size(351, 396);
            this.gbxAlerts.TabIndex = 3;
            this.gbxAlerts.TabStop = false;
            this.gbxAlerts.Text = "Alerts";
            // 
            // floAlertList
            // 
            this.floAlertList.AutoScroll = true;
            this.floAlertList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floAlertList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.floAlertList.Location = new System.Drawing.Point(3, 16);
            this.floAlertList.Name = "floAlertList";
            this.floAlertList.Size = new System.Drawing.Size(345, 377);
            this.floAlertList.TabIndex = 0;
            this.floAlertList.WrapContents = false;
            // 
            // gbxLog
            // 
            this.gbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLog.Controls.Add(this.tbxLog);
            this.gbxLog.Location = new System.Drawing.Point(369, 39);
            this.gbxLog.Name = "gbxLog";
            this.gbxLog.Size = new System.Drawing.Size(586, 399);
            this.gbxLog.TabIndex = 4;
            this.gbxLog.TabStop = false;
            this.gbxLog.Text = "Log";
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLog.Location = new System.Drawing.Point(3, 16);
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(580, 380);
            this.tbxLog.TabIndex = 0;
            this.tbxLog.Text = "";
            // 
            // timerUpdateAlerts
            // 
            this.timerUpdateAlerts.Enabled = true;
            this.timerUpdateAlerts.Interval = 300000;
            this.timerUpdateAlerts.Tick += new System.EventHandler(this.timerUpdateAlerts_Tick);
            // 
            // timerUpdateLog
            // 
            this.timerUpdateLog.Enabled = true;
            this.timerUpdateLog.Interval = 1000;
            this.timerUpdateLog.Tick += new System.EventHandler(this.timerUpdateLog_Tick);
            // 
            // FormMagicInformant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 495);
            this.Controls.Add(this.gbxLog);
            this.Controls.Add(this.gbxAlerts);
            this.Controls.Add(this.gbxActions);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMagicInformant";
            this.Text = "MagicInformant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMagicInformant_FormClosing);
            this.Load += new System.EventHandler(this.FormMagicInformant_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxActions.ResumeLayout(false);
            this.gbxAlerts.ResumeLayout(false);
            this.gbxLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmiConfigure;
        private System.Windows.Forms.GroupBox gbxActions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxAlerts;
        private System.Windows.Forms.GroupBox gbxLog;
        private System.Windows.Forms.Timer timerUpdateAlerts;
        private System.Windows.Forms.RichTextBox tbxLog;
        private System.Windows.Forms.FlowLayoutPanel floAlertList;
        private System.Windows.Forms.Timer timerUpdateLog;
    }
}

