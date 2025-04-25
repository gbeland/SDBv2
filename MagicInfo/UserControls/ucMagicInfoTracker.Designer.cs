namespace SDB.MagicInfo.UserControls
{
    partial class ucMagicInfoTracker
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
            this.lblTicketQty = new System.Windows.Forms.Label();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.cmbTrackerFilter = new System.Windows.Forms.ComboBox();
            this.lblTrackerFilter = new System.Windows.Forms.Label();
            this.olvTickets = new BrightIdeasSoftware.ObjectListView();
            this.olcTicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcServer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAsset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcUser = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcEntry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcIssue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcExpiration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketQty
            // 
            this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketQty.AutoSize = true;
            this.lblTicketQty.Location = new System.Drawing.Point(899, 9);
            this.lblTicketQty.Name = "lblTicketQty";
            this.lblTicketQty.Size = new System.Drawing.Size(45, 13);
            this.lblTicketQty.TabIndex = 4;
            this.lblTicketQty.Text = "Tickets:";
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketQty.Location = new System.Drawing.Point(950, 4);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.ReadOnly = true;
            this.txtTicketQty.Size = new System.Drawing.Size(45, 22);
            this.txtTicketQty.TabIndex = 5;
            this.txtTicketQty.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlControl.Controls.Add(this.cmbTrackerFilter);
            this.pnlControl.Controls.Add(this.lblTrackerFilter);
            this.pnlControl.Controls.Add(this.lblTicketQty);
            this.pnlControl.Controls.Add(this.txtTicketQty);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(998, 30);
            this.pnlControl.TabIndex = 2;
            // 
            // cmbTrackerFilter
            // 
            this.cmbTrackerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrackerFilter.FormattingEnabled = true;
            this.cmbTrackerFilter.Location = new System.Drawing.Point(82, 4);
            this.cmbTrackerFilter.Name = "cmbTrackerFilter";
            this.cmbTrackerFilter.Size = new System.Drawing.Size(147, 21);
            this.cmbTrackerFilter.TabIndex = 7;
            this.cmbTrackerFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTrackerFilter_SelectedIndexChanged);
            // 
            // lblTrackerFilter
            // 
            this.lblTrackerFilter.AutoSize = true;
            this.lblTrackerFilter.Location = new System.Drawing.Point(3, 9);
            this.lblTrackerFilter.Name = "lblTrackerFilter";
            this.lblTrackerFilter.Size = new System.Drawing.Size(72, 13);
            this.lblTrackerFilter.TabIndex = 6;
            this.lblTrackerFilter.Text = "Tracker Filter:";
            // 
            // olvTickets
            // 
            this.olvTickets.AllColumns.Add(this.olcTicketID);
            this.olvTickets.AllColumns.Add(this.olcServer);
            this.olvTickets.AllColumns.Add(this.olcAsset);
            this.olvTickets.AllColumns.Add(this.olcUser);
            this.olvTickets.AllColumns.Add(this.olcEntry);
            this.olvTickets.AllColumns.Add(this.olcIssue);
            this.olvTickets.AllColumns.Add(this.olcStatus);
            this.olvTickets.AllColumns.Add(this.olcExpiration);
            this.olvTickets.AllowColumnReorder = true;
            this.olvTickets.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.olvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvTickets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.olvTickets.CausesValidation = false;
            this.olvTickets.CellEditUseWholeCell = false;
            this.olvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcTicketID,
            this.olcServer,
            this.olcAsset,
            this.olcUser,
            this.olcEntry,
            this.olcIssue,
            this.olcStatus,
            this.olcExpiration});
            this.olvTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTickets.EmptyListMsg = "";
            this.olvTickets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTickets.GridLines = true;
            this.olvTickets.Location = new System.Drawing.Point(0, 25);
            this.olvTickets.Name = "olvTickets";
            this.olvTickets.RowHeight = 48;
            this.olvTickets.SelectAllOnControlA = false;
            this.olvTickets.ShowCommandMenuOnRightClick = true;
            this.olvTickets.ShowGroups = false;
            this.olvTickets.ShowItemToolTips = true;
            this.olvTickets.Size = new System.Drawing.Size(998, 593);
            this.olvTickets.SortGroupItemsByPrimaryColumn = false;
            this.olvTickets.TabIndex = 3;
            this.olvTickets.UseAlternatingBackColors = true;
            this.olvTickets.UseCellFormatEvents = true;
            this.olvTickets.UseCompatibleStateImageBehavior = false;
            this.olvTickets.UseFilterIndicator = true;
            this.olvTickets.UseFiltering = true;
            this.olvTickets.View = System.Windows.Forms.View.Details;
            this.olvTickets.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvTickets_CellClick);
            this.olvTickets.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvTickets_FormatCell);
            // 
            // olcTicketID
            // 
            this.olcTicketID.AspectName = "ID";
            this.olcTicketID.AspectToStringFormat = "{0:000000}";
            this.olcTicketID.Text = "Ticket";
            this.olcTicketID.Width = 75;
            // 
            // olcServer
            // 
            this.olcServer.AspectName = "ServerNameText";
            this.olcServer.Text = "Server";
            this.olcServer.Width = 75;
            // 
            // olcAsset
            // 
            this.olcAsset.AspectName = "AssetNameText";
            this.olcAsset.Text = "Asset";
            this.olcAsset.Width = 75;
            // 
            // olcUser
            // 
            this.olcUser.AspectName = "ReportedByUserName";
            this.olcUser.Text = "By";
            this.olcUser.Width = 75;
            // 
            // olcEntry
            // 
            this.olcEntry.AspectName = "LastJournalEntryText";
            this.olcEntry.FillsFreeSpace = true;
            this.olcEntry.Text = "Entry";
            this.olcEntry.Width = 400;
            this.olcEntry.WordWrap = true;
            // 
            // olcIssue
            // 
            this.olcIssue.AspectName = "IssueText";
            this.olcIssue.Text = "Issue";
            this.olcIssue.Width = 100;
            // 
            // olcStatus
            // 
            this.olcStatus.AspectName = "TicketStatus.Status";
            this.olcStatus.Text = "Status";
            this.olcStatus.Width = 100;
            // 
            // olcExpiration
            // 
            this.olcExpiration.AspectName = "LastJournalEntry.ExpireDate";
            this.olcExpiration.Text = "Expire";
            this.olcExpiration.Width = 100;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 60000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // ucMagicInfoTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.olvTickets);
            this.Name = "ucMagicInfoTracker";
            this.Size = new System.Drawing.Size(998, 618);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTicketQty;
        private System.Windows.Forms.TextBox txtTicketQty;
        private System.Windows.Forms.Panel pnlControl;
        private BrightIdeasSoftware.ObjectListView olvTickets;
        private BrightIdeasSoftware.OLVColumn olcTicketID;
        private BrightIdeasSoftware.OLVColumn olcServer;
        private BrightIdeasSoftware.OLVColumn olcAsset;
        private BrightIdeasSoftware.OLVColumn olcUser;
        private BrightIdeasSoftware.OLVColumn olcEntry;
        private BrightIdeasSoftware.OLVColumn olcIssue;
        private BrightIdeasSoftware.OLVColumn olcStatus;
        private BrightIdeasSoftware.OLVColumn olcExpiration;
        private System.Windows.Forms.ComboBox cmbTrackerFilter;
        private System.Windows.Forms.Label lblTrackerFilter;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}
