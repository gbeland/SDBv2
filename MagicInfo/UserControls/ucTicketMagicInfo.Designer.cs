namespace SDB.MagicInfo.UserControls
{
    partial class ucTicketMagicInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ticketJournalComponent1 = new SDB.MagicInfo.Components.TicketJournalComponent();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cblSolutions = new System.Windows.Forms.CheckedListBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.confidentialComponent1 = new SDB.MagicInfo.Components.ConfidentialComponent();
            this.actionsComponent1 = new SDB.MagicInfo.Components.ActionsComponent();
            this.ticketInfoComponent1 = new SDB.MagicInfo.Components.TicketInfoComponent();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(153, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ticketJournalComponent1);
            this.groupBox1.Controls.Add(this.btnCloseTicket);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Location = new System.Drawing.Point(0, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal";
            // 
            // ticketJournalComponent1
            // 
            this.ticketJournalComponent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketJournalComponent1.AutoScroll = true;
            this.ticketJournalComponent1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ticketJournalComponent1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ticketJournalComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ticketJournalComponent1.Location = new System.Drawing.Point(4, 48);
            this.ticketJournalComponent1.Name = "ticketJournalComponent1";
            this.ticketJournalComponent1.Size = new System.Drawing.Size(743, 240);
            this.ticketJournalComponent1.TabIndex = 5;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTicket.Location = new System.Drawing.Point(917, 268);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTicket.TabIndex = 4;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.BtnCloseTicket_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.cblSolutions);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(753, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 246);
            this.panel6.TabIndex = 2;
            // 
            // cblSolutions
            // 
            this.cblSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cblSolutions.FormattingEnabled = true;
            this.cblSolutions.Location = new System.Drawing.Point(3, 34);
            this.cblSolutions.Name = "cblSolutions";
            this.cblSolutions.Size = new System.Drawing.Size(236, 214);
            this.cblSolutions.Sorted = true;
            this.cblSolutions.TabIndex = 1;
            this.cblSolutions.ThreeDCheckBoxes = true;
            this.cblSolutions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblSolutions_ItemCheck);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(236, 29);
            this.panel9.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Solutions";
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel11.Controls.Add(this.btnAddEntry);
            this.panel11.Location = new System.Drawing.Point(3, 16);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(744, 29);
            this.panel11.TabIndex = 1;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(5, 3);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(75, 23);
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.confidentialComponent1);
            this.flowLayoutPanel1.Controls.Add(this.actionsComponent1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(242, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 327);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // confidentialComponent1
            // 
            this.confidentialComponent1.Location = new System.Drawing.Point(3, 3);
            this.confidentialComponent1.Name = "confidentialComponent1";
            this.confidentialComponent1.Size = new System.Drawing.Size(530, 318);
            this.confidentialComponent1.TabIndex = 0;
            // 
            // actionsComponent1
            // 
            this.actionsComponent1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.actionsComponent1.Location = new System.Drawing.Point(536, 0);
            this.actionsComponent1.Margin = new System.Windows.Forms.Padding(0);
            this.actionsComponent1.Name = "actionsComponent1";
            this.actionsComponent1.Padding = new System.Windows.Forms.Padding(5);
            this.actionsComponent1.Size = new System.Drawing.Size(198, 321);
            this.actionsComponent1.TabIndex = 1;
            this.actionsComponent1.OpenServerEvent += new SDB.MagicInfo.Components.ActionsComponent.OpenServer(this.actionsComponent1_OpenServerEvent);
            // 
            // ticketInfoComponent1
            // 
            this.ticketInfoComponent1.Location = new System.Drawing.Point(0, 35);
            this.ticketInfoComponent1.Name = "ticketInfoComponent1";
            this.ticketInfoComponent1.Size = new System.Drawing.Size(236, 321);
            this.ticketInfoComponent1.TabIndex = 10;
            // 
            // ucTicketMagicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ticketInfoComponent1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucTicketMagicInfo";
            this.Size = new System.Drawing.Size(998, 664);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private Components.TicketInfoComponent ticketInfoComponent1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Components.ConfidentialComponent confidentialComponent1;
        private Components.ActionsComponent actionsComponent1;
        private Components.TicketJournalComponent ticketJournalComponent1;
        private System.Windows.Forms.CheckedListBox cblSolutions;
    }
}
