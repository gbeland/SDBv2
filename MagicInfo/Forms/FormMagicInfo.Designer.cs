namespace SDB.MagicInfo.Forms
{
    partial class FormMagicInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagicInfo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solutionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucMagicInfoTracker1 = new SDB.MagicInfo.UserControls.ucMagicInfoTracker();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.ticketLFD1 = new SDB.MagicInfo.UserControls.ucTicketMagicInfo();
            this.tabAsset = new System.Windows.Forms.TabPage();
            this.ucAssetMagicInfo1 = new SDB.MagicInfo.UserControls.ucAssetMagicInfo();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.AlertCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.AlertFlasher = new System.Windows.Forms.Timer(this.components);
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabAsset.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusListToolStripMenuItem,
            this.issueListToolStripMenuItem,
            this.solutionListToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // statusListToolStripMenuItem
            // 
            this.statusListToolStripMenuItem.Name = "statusListToolStripMenuItem";
            this.statusListToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.statusListToolStripMenuItem.Text = "Status List";
            this.statusListToolStripMenuItem.Click += new System.EventHandler(this.statusListToolStripMenuItem_Click);
            // 
            // issueListToolStripMenuItem
            // 
            this.issueListToolStripMenuItem.Name = "issueListToolStripMenuItem";
            this.issueListToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.issueListToolStripMenuItem.Text = "Issue List";
            this.issueListToolStripMenuItem.Click += new System.EventHandler(this.issueListToolStripMenuItem_Click);
            // 
            // solutionListToolStripMenuItem
            // 
            this.solutionListToolStripMenuItem.Name = "solutionListToolStripMenuItem";
            this.solutionListToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.solutionListToolStripMenuItem.Text = "Solution List";
            this.solutionListToolStripMenuItem.Click += new System.EventHandler(this.solutionListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabTickets);
            this.tabControl.Controls.Add(this.tabAsset);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1090, 656);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucMagicInfoTracker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 630);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Tracker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucMagicInfoTracker1
            // 
            this.ucMagicInfoTracker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMagicInfoTracker1.Location = new System.Drawing.Point(3, 3);
            this.ucMagicInfoTracker1.Name = "ucMagicInfoTracker1";
            this.ucMagicInfoTracker1.Size = new System.Drawing.Size(1076, 624);
            this.ucMagicInfoTracker1.TabIndex = 0;
            this.ucMagicInfoTracker1.TicketLoadEvent += new SDB.MagicInfo.UserControls.ucMagicInfoTracker.LoadTicket(this.Load_TicketEvent);
            this.ucMagicInfoTracker1.ServerLoadEvent += new SDB.MagicInfo.UserControls.ucMagicInfoTracker.LoadServer(this.Load_ServerEvent);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.ticketLFD1);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(1082, 630);
            this.tabTickets.TabIndex = 1;
            this.tabTickets.Text = "Ticket";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // ticketLFD1
            // 
            this.ticketLFD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketLFD1.Location = new System.Drawing.Point(3, 3);
            this.ticketLFD1.Name = "ticketLFD1";
            this.ticketLFD1.Size = new System.Drawing.Size(1076, 624);
            this.ticketLFD1.TabIndex = 0;
            // 
            // tabAsset
            // 
            this.tabAsset.Controls.Add(this.ucAssetMagicInfo1);
            this.tabAsset.Location = new System.Drawing.Point(4, 22);
            this.tabAsset.Name = "tabAsset";
            this.tabAsset.Size = new System.Drawing.Size(1082, 630);
            this.tabAsset.TabIndex = 2;
            this.tabAsset.Text = "Asset";
            this.tabAsset.UseVisualStyleBackColor = true;
            // 
            // ucAssetMagicInfo1
            // 
            this.ucAssetMagicInfo1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ucAssetMagicInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAssetMagicInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucAssetMagicInfo1.Name = "ucAssetMagicInfo1";
            this.ucAssetMagicInfo1.Size = new System.Drawing.Size(1082, 630);
            this.ucAssetMagicInfo1.TabIndex = 0;
            this.ucAssetMagicInfo1.TicketLoadEvent += new SDB.MagicInfo.UserControls.ucAssetMagicInfo.LoadTicket(this.Load_TicketEvent);
            // 
            // btnAlerts
            // 
            this.btnAlerts.BackColor = System.Drawing.Color.Silver;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Location = new System.Drawing.Point(1008, 1);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Size = new System.Drawing.Size(75, 23);
            this.btnAlerts.TabIndex = 3;
            this.btnAlerts.Text = "Alerts [0]";
            this.btnAlerts.UseVisualStyleBackColor = false;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            // 
            // AlertCheckTimer
            // 
            this.AlertCheckTimer.Interval = 600000;
            this.AlertCheckTimer.Tick += new System.EventHandler(this.AlertCheckTimer_Tick);
            // 
            // AlertFlasher
            // 
            this.AlertFlasher.Interval = 500;
            this.AlertFlasher.Tick += new System.EventHandler(this.AlertFlasher_Tick);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // FormMagicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 680);
            this.Controls.Add(this.btnAlerts);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMagicInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Samsung Service Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMagicInfo_FormClosing);
            this.Shown += new System.EventHandler(this.FormMagicInfo_Shown);
            this.VisibleChanged += new System.EventHandler(this.FormMagicInfo_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMagicInfo_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabAsset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabAsset;
        private MagicInfo.UserControls.ucAssetMagicInfo assetLFD1;
        private MagicInfo.UserControls.ucTicketMagicInfo ticketLFD1;
        private MagicInfo.UserControls.ucAssetMagicInfo ucAssetMagicInfo1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.ucMagicInfoTracker ucMagicInfoTracker1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solutionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Timer AlertCheckTimer;
        private System.Windows.Forms.Timer AlertFlasher;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}