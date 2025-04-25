namespace SDB.UserControls.Ticket
{
	partial class TicketTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketTracker));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlShowMode = new System.Windows.Forms.Panel();
            this.lblList_Show = new System.Windows.Forms.Label();
            this.radOpen = new System.Windows.Forms.RadioButton();
            this.radOnHold = new System.Windows.Forms.RadioButton();
            this.radClosed = new System.Windows.Forms.RadioButton();
            this.lblTicketQty = new System.Windows.Forms.Label();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.olvTickets = new BrightIdeasSoftware.ObjectListView();
            this.olcTicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcAsset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTechOnSite = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcRentalActive = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcLastUpdate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcLastUpdateBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcExpiration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcTech = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcSymptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDisplayCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcUpdated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcOpenDuration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiExportTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportTracker = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlControl.SuspendLayout();
            this.pnlShowMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.LightBlue;
            this.pnlControl.Controls.Add(this.pnlShowMode);
            this.pnlControl.Controls.Add(this.lblTicketQty);
            this.pnlControl.Controls.Add(this.txtTicketQty);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(742, 30);
            this.pnlControl.TabIndex = 0;
            // 
            // pnlShowMode
            // 
            this.pnlShowMode.BackColor = System.Drawing.SystemColors.Window;
            this.pnlShowMode.Controls.Add(this.lblList_Show);
            this.pnlShowMode.Controls.Add(this.radOpen);
            this.pnlShowMode.Controls.Add(this.radOnHold);
            this.pnlShowMode.Controls.Add(this.radClosed);
            this.pnlShowMode.Location = new System.Drawing.Point(3, 3);
            this.pnlShowMode.Name = "pnlShowMode";
            this.pnlShowMode.Size = new System.Drawing.Size(284, 25);
            this.pnlShowMode.TabIndex = 6;
            // 
            // lblList_Show
            // 
            this.lblList_Show.AutoSize = true;
            this.lblList_Show.Location = new System.Drawing.Point(3, 6);
            this.lblList_Show.Name = "lblList_Show";
            this.lblList_Show.Size = new System.Drawing.Size(37, 13);
            this.lblList_Show.TabIndex = 0;
            this.lblList_Show.Text = "Show:";
            // 
            // radOpen
            // 
            this.radOpen.AutoCheck = false;
            this.radOpen.AutoSize = true;
            this.radOpen.BackColor = System.Drawing.Color.Transparent;
            this.radOpen.Checked = true;
            this.radOpen.Location = new System.Drawing.Point(46, 4);
            this.radOpen.Name = "radOpen";
            this.radOpen.Size = new System.Drawing.Size(51, 17);
            this.radOpen.TabIndex = 1;
            this.radOpen.TabStop = true;
            this.radOpen.Text = "Open";
            this.radOpen.UseVisualStyleBackColor = false;
            this.radOpen.Click += new System.EventHandler(this.radOpen_Click);
            // 
            // radOnHold
            // 
            this.radOnHold.AutoCheck = false;
            this.radOnHold.AutoSize = true;
            this.radOnHold.Location = new System.Drawing.Point(105, 4);
            this.radOnHold.Name = "radOnHold";
            this.radOnHold.Size = new System.Drawing.Size(64, 17);
            this.radOnHold.TabIndex = 2;
            this.radOnHold.TabStop = true;
            this.radOnHold.Text = "On Hold";
            this.radOnHold.UseVisualStyleBackColor = true;
            this.radOnHold.Click += new System.EventHandler(this.radOnHold_Click);
            // 
            // radClosed
            // 
            this.radClosed.AutoCheck = false;
            this.radClosed.AutoSize = true;
            this.radClosed.BackColor = System.Drawing.Color.Transparent;
            this.radClosed.Location = new System.Drawing.Point(175, 4);
            this.radClosed.Name = "radClosed";
            this.radClosed.Size = new System.Drawing.Size(102, 17);
            this.radClosed.TabIndex = 3;
            this.radClosed.Text = "Recently Closed";
            this.radClosed.UseVisualStyleBackColor = false;
            this.radClosed.Click += new System.EventHandler(this.radClosed_Click);
            // 
            // lblTicketQty
            // 
            this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketQty.AutoSize = true;
            this.lblTicketQty.Location = new System.Drawing.Point(643, 9);
            this.lblTicketQty.Name = "lblTicketQty";
            this.lblTicketQty.Size = new System.Drawing.Size(45, 13);
            this.lblTicketQty.TabIndex = 4;
            this.lblTicketQty.Text = "Tickets:";
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketQty.Location = new System.Drawing.Point(694, 4);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.ReadOnly = true;
            this.txtTicketQty.Size = new System.Drawing.Size(45, 22);
            this.txtTicketQty.TabIndex = 5;
            this.txtTicketQty.TabStop = false;
            // 
            // olvTickets
            // 
            this.olvTickets.AllColumns.Add(this.olcTicketID);
            this.olvTickets.AllColumns.Add(this.olcAsset);
            this.olvTickets.AllColumns.Add(this.olcTechOnSite);
            this.olvTickets.AllColumns.Add(this.olcRentalActive);
            this.olvTickets.AllColumns.Add(this.olcLastUpdate);
            this.olvTickets.AllColumns.Add(this.olcLastUpdateBy);
            this.olvTickets.AllColumns.Add(this.olcExpiration);
            this.olvTickets.AllColumns.Add(this.olcTech);
            this.olvTickets.AllColumns.Add(this.olcSymptoms);
            this.olvTickets.AllColumns.Add(this.olcDisplayCategory);
            this.olvTickets.AllColumns.Add(this.olcUpdated);
            this.olvTickets.AllColumns.Add(this.olcOpenDuration);
            this.olvTickets.AllowColumnReorder = true;
            this.olvTickets.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvTickets.CausesValidation = false;
            this.olvTickets.CellEditUseWholeCell = false;
            this.olvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcTicketID,
            this.olcAsset,
            this.olcTechOnSite,
            this.olcRentalActive,
            this.olcLastUpdate,
            this.olcLastUpdateBy,
            this.olcExpiration,
            this.olcTech,
            this.olcSymptoms,
            this.olcDisplayCategory});
            this.olvTickets.ContextMenuStrip = this.contextMenuStrip1;
            this.olvTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTickets.EmptyListMsg = "";
            this.olvTickets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTickets.GridLines = true;
            this.olvTickets.Location = new System.Drawing.Point(0, 30);
            this.olvTickets.Name = "olvTickets";
            this.olvTickets.RowHeight = 48;
            this.olvTickets.SelectAllOnControlA = false;
            this.olvTickets.ShowCommandMenuOnRightClick = true;
            this.olvTickets.ShowGroups = false;
            this.olvTickets.ShowItemToolTips = true;
            this.olvTickets.Size = new System.Drawing.Size(742, 524);
            this.olvTickets.SmallImageList = this.imageList1;
            this.olvTickets.SortGroupItemsByPrimaryColumn = false;
            this.olvTickets.TabIndex = 1;
            this.olvTickets.UseAlternatingBackColors = true;
            this.olvTickets.UseCellFormatEvents = true;
            this.olvTickets.UseCompatibleStateImageBehavior = false;
            this.olvTickets.UseFilterIndicator = true;
            this.olvTickets.UseFiltering = true;
            this.olvTickets.View = System.Windows.Forms.View.Details;
            this.olvTickets.BeforeCreatingGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.olvTickets_BeforeCreatingGroups);
            this.olvTickets.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvTickets_CellClick);
            this.olvTickets.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvTickets_CellToolTipShowing);
            this.olvTickets.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvTickets_FormatCell);
            // 
            // olcTicketID
            // 
            this.olcTicketID.AspectName = "ID";
            this.olcTicketID.Groupable = false;
            this.olcTicketID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcTicketID.Hideable = false;
            this.olcTicketID.Text = "Ticket";
            this.olcTicketID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcTicketID.ToolTipText = "Ticket ID";
            this.olcTicketID.Width = 55;
            // 
            // olcAsset
            // 
            this.olcAsset.AspectName = "ExtraProperties.AssetName";
            this.olcAsset.Text = "Asset";
            this.olcAsset.ToolTipText = "Asset Name";
            this.olcAsset.Width = 75;
            this.olcAsset.WordWrap = true;
            // 
            // olcTechOnSite
            // 
            this.olcTechOnSite.AspectName = "IsTechOnSite";
            this.olcTechOnSite.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcTechOnSite.Text = "T";
            this.olcTechOnSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcTechOnSite.ToolTipText = "Tech On-Site";
            this.olcTechOnSite.Width = 32;
            // 
            // olcRentalActive
            // 
            this.olcRentalActive.AspectName = "IsRentalActive";
            this.olcRentalActive.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcRentalActive.Text = "R";
            this.olcRentalActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcRentalActive.ToolTipText = "Rental Active";
            this.olcRentalActive.Width = 32;
            // 
            // olcLastUpdate
            // 
            this.olcLastUpdate.AspectName = "GetLastNote";
            this.olcLastUpdate.CellVerticalAlignment = System.Drawing.StringAlignment.Near;
            this.olcLastUpdate.Text = "Last Update";
            this.olcLastUpdate.ToolTipText = "Last Journal Update";
            this.olcLastUpdate.Width = 321;
            this.olcLastUpdate.WordWrap = true;
            // 
            // olcLastUpdateBy
            // 
            this.olcLastUpdateBy.AspectName = "ExtraProperties.Journal.LastUserEntry.User_Name";
            this.olcLastUpdateBy.Text = "By";
            // 
            // olcExpiration
            // 
            this.olcExpiration.AspectName = "ExtraProperties.Journal.LastUserEntry.SoftExpireDateTime";
            this.olcExpiration.Groupable = false;
            this.olcExpiration.Text = "Expire";
            this.olcExpiration.ToolTipText = "When the most recent journal entry expires.";
            // 
            // olcTech
            // 
            this.olcTech.AspectName = "ExtraProperties.AssignedTechName";
            this.olcTech.Text = "Tech";
            this.olcTech.ToolTipText = "Tech Name";
            this.olcTech.Width = 80;
            this.olcTech.WordWrap = true;
            // 
            // olcSymptoms
            // 
            this.olcSymptoms.AspectName = "ExtraProperties.Symptoms";
            this.olcSymptoms.Text = "Symptoms";
            this.olcSymptoms.ToolTipText = "Symptoms";
            this.olcSymptoms.Width = 98;
            this.olcSymptoms.WordWrap = true;
            // 
            // olcDisplayCategory
            // 
            this.olcDisplayCategory.AspectName = "ExtraProperties.CustomerAssetTag";
            this.olcDisplayCategory.Groupable = false;
            this.olcDisplayCategory.Text = "Display Category";
            this.olcDisplayCategory.Width = 152;
            this.olcDisplayCategory.WordWrap = true;
            // 
            // olcUpdated
            // 
            this.olcUpdated.AspectName = "ExtraProperties.Journal.LastUserEntry.JournalDateTime";
            this.olcUpdated.DisplayIndex = 9;
            this.olcUpdated.Groupable = false;
            this.olcUpdated.IsVisible = false;
            this.olcUpdated.Text = "Updated";
            this.olcUpdated.ToolTipText = "Last Updated";
            this.olcUpdated.Width = 75;
            this.olcUpdated.WordWrap = true;
            // 
            // olcOpenDuration
            // 
            this.olcOpenDuration.AspectName = "Duration";
            this.olcOpenDuration.DisplayIndex = 10;
            this.olcOpenDuration.Groupable = false;
            this.olcOpenDuration.IsVisible = false;
            this.olcOpenDuration.Text = "Open For";
            this.olcOpenDuration.ToolTipText = "Ticket Open Duration";
            this.olcOpenDuration.Width = 75;
            this.olcOpenDuration.WordWrap = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportTracker,
            this.tsmiImportTracker});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // tsmiExportTracker
            // 
            this.tsmiExportTracker.Name = "tsmiExportTracker";
            this.tsmiExportTracker.Size = new System.Drawing.Size(189, 22);
            this.tsmiExportTracker.Text = "E&xport Tracker State...";
            this.tsmiExportTracker.Click += new System.EventHandler(this.tsmiExportTracker_Click);
            // 
            // tsmiImportTracker
            // 
            this.tsmiImportTracker.Name = "tsmiImportTracker";
            this.tsmiImportTracker.Size = new System.Drawing.Size(189, 22);
            this.tsmiImportTracker.Text = "I&mport Tracker State...";
            this.tsmiImportTracker.Click += new System.EventHandler(this.tsmiImportTracker_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rental");
            this.imageList1.Images.SetKeyName(1, "tech");
            // 
            // TicketTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvTickets);
            this.Controls.Add(this.pnlControl);
            this.Name = "TicketTracker";
            this.Size = new System.Drawing.Size(742, 554);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlShowMode.ResumeLayout(false);
            this.pnlShowMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlControl;
		private BrightIdeasSoftware.ObjectListView olvTickets;
		private System.Windows.Forms.RadioButton radClosed;
		private System.Windows.Forms.RadioButton radOnHold;
		private System.Windows.Forms.Label lblList_Show;
		private System.Windows.Forms.RadioButton radOpen;
		private System.Windows.Forms.Label lblTicketQty;
		private System.Windows.Forms.TextBox txtTicketQty;
		private BrightIdeasSoftware.OLVColumn olcTicketID;
		private BrightIdeasSoftware.OLVColumn olcOpenDuration;
		private BrightIdeasSoftware.OLVColumn olcAsset;
		private BrightIdeasSoftware.OLVColumn olcLastUpdate;
		private BrightIdeasSoftware.OLVColumn olcUpdated;
		private BrightIdeasSoftware.OLVColumn olcExpiration;
		private BrightIdeasSoftware.OLVColumn olcTech;
		private BrightIdeasSoftware.OLVColumn olcSymptoms;
		private BrightIdeasSoftware.OLVColumn olcTechOnSite;
		private BrightIdeasSoftware.OLVColumn olcRentalActive;
		private BrightIdeasSoftware.OLVColumn olcLastUpdateBy;
		private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn olcDisplayCategory;
		private System.Windows.Forms.Panel pnlShowMode;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiExportTracker;
		private System.Windows.Forms.ToolStripMenuItem tsmiImportTracker;
	}
}
