namespace SDB.Forms
{
	partial class FormReporting_Ticket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting_Ticket));
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvTR = new BrightIdeasSoftware.ObjectListView();
			this.olvColTicket_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Open = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Close = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Issue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_OSANotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Symptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Solutions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColCustomer_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColMarket_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColAsset_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColAsset_Panel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColAsset_Location = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTech_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_TechOnSite = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_TechArrivedDuration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Symptom_Other = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColTicket_Solution_Notes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.lblReportTitle = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.olcTicket_ReportedType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvTR)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Controls.Add(this.olvTR);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(1184, 762);
			this.pnlContainer.TabIndex = 1;
			// 
			// olvTR
			// 
			this.olvTR.AllColumns.Add(this.olvColTicket_ID);
			this.olvTR.AllColumns.Add(this.olvColTicket_Open);
			this.olvTR.AllColumns.Add(this.olvColTicket_Close);
			this.olvTR.AllColumns.Add(this.olvColTicket_Duration);
			this.olvTR.AllColumns.Add(this.olvColTicket_Issue);
			this.olvTR.AllColumns.Add(this.olcTicket_ReportedType);
			this.olvTR.AllColumns.Add(this.olvColTicket_OSANotes);
			this.olvTR.AllColumns.Add(this.olvColTicket_Symptoms);
			this.olvTR.AllColumns.Add(this.olvColTicket_Solutions);
			this.olvTR.AllColumns.Add(this.olvColCustomer_Name);
			this.olvTR.AllColumns.Add(this.olvColMarket_Name);
			this.olvTR.AllColumns.Add(this.olvColAsset_Asset);
			this.olvTR.AllColumns.Add(this.olvColAsset_Panel);
			this.olvTR.AllColumns.Add(this.olvColAsset_Location);
			this.olvTR.AllColumns.Add(this.olvColTech_Name);
			this.olvTR.AllColumns.Add(this.olvColTicket_TechOnSite);
			this.olvTR.AllColumns.Add(this.olvColTicket_TechArrivedDuration);
			this.olvTR.AllColumns.Add(this.olvColTicket_Status);
			this.olvTR.AllColumns.Add(this.olvColTicket_Symptom_Other);
			this.olvTR.AllColumns.Add(this.olvColTicket_Solution_Notes);
			this.olvTR.AllowColumnReorder = true;
			this.olvTR.CellEditUseWholeCell = false;
			this.olvTR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTicket_ID,
            this.olvColTicket_Open,
            this.olvColTicket_Close,
            this.olvColTicket_Duration,
            this.olvColTicket_Issue,
            this.olcTicket_ReportedType,
            this.olvColTicket_OSANotes,
            this.olvColTicket_Symptoms,
            this.olvColTicket_Solutions,
            this.olvColCustomer_Name,
            this.olvColMarket_Name,
            this.olvColAsset_Asset,
            this.olvColAsset_Panel,
            this.olvColAsset_Location,
            this.olvColTech_Name,
            this.olvColTicket_TechOnSite,
            this.olvColTicket_TechArrivedDuration,
            this.olvColTicket_Status});
			this.olvTR.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvTR.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvTR.EmptyListMsg = "Report empty.";
			this.olvTR.FullRowSelect = true;
			this.olvTR.GridLines = true;
			this.olvTR.HideSelection = false;
			this.olvTR.Location = new System.Drawing.Point(0, 30);
			this.olvTR.MultiSelect = false;
			this.olvTR.Name = "olvTR";
			this.olvTR.RowHeight = 40;
			this.olvTR.ShowCommandMenuOnRightClick = true;
			this.olvTR.ShowGroups = false;
			this.olvTR.ShowItemCountOnGroups = true;
			this.olvTR.Size = new System.Drawing.Size(1184, 732);
			this.olvTR.SortGroupItemsByPrimaryColumn = false;
			this.olvTR.TabIndex = 4;
			this.olvTR.UseCompatibleStateImageBehavior = false;
			this.olvTR.UseFilterIndicator = true;
			this.olvTR.UseFiltering = true;
			this.olvTR.View = System.Windows.Forms.View.Details;
			this.olvTR.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.OlvTr_FormatRow);
			this.olvTR.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTRs_MouseDoubleClick);
			// 
			// olvColTicket_ID
			// 
			this.olvColTicket_ID.AspectName = "Ticket.ID";
			this.olvColTicket_ID.Groupable = false;
			this.olvColTicket_ID.Text = "Ticket";
			this.olvColTicket_ID.UseFiltering = false;
			this.olvColTicket_ID.Width = 50;
			// 
			// olvColTicket_Open
			// 
			this.olvColTicket_Open.AspectName = "Ticket.OpenDT";
			this.olvColTicket_Open.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olvColTicket_Open.Groupable = false;
			this.olvColTicket_Open.Text = "Opened";
			this.olvColTicket_Open.Width = 100;
			// 
			// olvColTicket_Close
			// 
			this.olvColTicket_Close.AspectName = "Ticket.CloseDT";
			this.olvColTicket_Close.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olvColTicket_Close.Groupable = false;
			this.olvColTicket_Close.Text = "Closed";
			this.olvColTicket_Close.Width = 100;
			// 
			// olvColTicket_Duration
			// 
			this.olvColTicket_Duration.AspectName = "Ticket.Duration";
			this.olvColTicket_Duration.Groupable = false;
			this.olvColTicket_Duration.Text = "Duration";
			this.olvColTicket_Duration.UseFiltering = false;
			this.olvColTicket_Duration.Width = 100;
			// 
			// olvColTicket_Issue
			// 
			this.olvColTicket_Issue.AspectName = "Ticket.Issue";
			this.olvColTicket_Issue.Groupable = false;
			this.olvColTicket_Issue.Text = "Issue";
			this.olvColTicket_Issue.UseFiltering = false;
			this.olvColTicket_Issue.Width = 50;
			// 
			// olvColTicket_OSANotes
			// 
			this.olvColTicket_OSANotes.AspectName = "Ticket.OSA_Notes";
			this.olvColTicket_OSANotes.Groupable = false;
			this.olvColTicket_OSANotes.Text = "OSA Notes";
			this.olvColTicket_OSANotes.UseFiltering = false;
			this.olvColTicket_OSANotes.Width = 250;
			this.olvColTicket_OSANotes.WordWrap = true;
			// 
			// olvColTicket_Symptoms
			// 
			this.olvColTicket_Symptoms.AspectName = "Ticket.Symptoms";
			this.olvColTicket_Symptoms.Text = "Symptoms";
			this.olvColTicket_Symptoms.Width = 190;
			this.olvColTicket_Symptoms.WordWrap = true;
			// 
			// olvColTicket_Solutions
			// 
			this.olvColTicket_Solutions.AspectName = "Ticket.Solutions";
			this.olvColTicket_Solutions.Text = "Solutions";
			this.olvColTicket_Solutions.Width = 190;
			this.olvColTicket_Solutions.WordWrap = true;
			// 
			// olvColCustomer_Name
			// 
			this.olvColCustomer_Name.AspectName = "Customer.Name";
			this.olvColCustomer_Name.Text = "Customer";
			this.olvColCustomer_Name.Width = 170;
			// 
			// olvColMarket_Name
			// 
			this.olvColMarket_Name.AspectName = "Market.Name";
			this.olvColMarket_Name.Text = "Market";
			this.olvColMarket_Name.Width = 170;
			// 
			// olvColAsset_Asset
			// 
			this.olvColAsset_Asset.AspectName = "Asset.Asset";
			this.olvColAsset_Asset.Text = "Asset";
			this.olvColAsset_Asset.Width = 80;
			// 
			// olvColAsset_Panel
			// 
			this.olvColAsset_Panel.AspectName = "Asset.Panel";
			this.olvColAsset_Panel.Text = "Panel";
			this.olvColAsset_Panel.Width = 70;
			// 
			// olvColAsset_Location
			// 
			this.olvColAsset_Location.AspectName = "Asset.Location";
			this.olvColAsset_Location.Groupable = false;
			this.olvColAsset_Location.Text = "Location";
			this.olvColAsset_Location.UseFiltering = false;
			this.olvColAsset_Location.Width = 170;
			// 
			// olvColTech_Name
			// 
			this.olvColTech_Name.AspectName = "Tech.Name";
			this.olvColTech_Name.Text = "Tech";
			this.olvColTech_Name.Width = 170;
			// 
			// olvColTicket_TechOnSite
			// 
			this.olvColTicket_TechOnSite.AspectName = "Ticket.FirstTechArrivedDT";
			this.olvColTicket_TechOnSite.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olvColTicket_TechOnSite.Text = "TOS";
			this.olvColTicket_TechOnSite.ToolTipText = "Tech on site";
			this.olvColTicket_TechOnSite.Width = 100;
			// 
			// olvColTicket_TechArrivedDuration
			// 
			this.olvColTicket_TechArrivedDuration.AspectName = "Ticket.TechArrivedDuration";
			this.olvColTicket_TechArrivedDuration.Text = "TOS Dur";
			this.olvColTicket_TechArrivedDuration.ToolTipText = "Time between ticket open and tech on site.";
			this.olvColTicket_TechArrivedDuration.UseFiltering = false;
			this.olvColTicket_TechArrivedDuration.Width = 100;
			// 
			// olvColTicket_Status
			// 
			this.olvColTicket_Status.AspectName = "Ticket.Status";
			this.olvColTicket_Status.Text = "Status";
			this.olvColTicket_Status.Width = 70;
			// 
			// olvColTicket_Symptom_Other
			// 
			this.olvColTicket_Symptom_Other.AspectName = "Ticket.Symptom_Other";
			this.olvColTicket_Symptom_Other.DisplayIndex = 15;
			this.olvColTicket_Symptom_Other.Groupable = false;
			this.olvColTicket_Symptom_Other.IsVisible = false;
			this.olvColTicket_Symptom_Other.Text = "Symptom: Other";
			this.olvColTicket_Symptom_Other.Width = 190;
			this.olvColTicket_Symptom_Other.WordWrap = true;
			// 
			// olvColTicket_Solution_Notes
			// 
			this.olvColTicket_Solution_Notes.AspectName = "Ticket.Solution_Notes";
			this.olvColTicket_Solution_Notes.DisplayIndex = 16;
			this.olvColTicket_Solution_Notes.Groupable = false;
			this.olvColTicket_Solution_Notes.IsVisible = false;
			this.olvColTicket_Solution_Notes.Text = "Solution: Notes";
			this.olvColTicket_Solution_Notes.UseFiltering = false;
			this.olvColTicket_Solution_Notes.Width = 200;
			this.olvColTicket_Solution_Notes.WordWrap = true;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.lblReportTitle);
			this.pnlControl.Controls.Add(this.btnPrint);
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Controls.Add(this.lblQty);
			this.pnlControl.Controls.Add(this.txtQty);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(1184, 30);
			this.pnlControl.TabIndex = 7;
			// 
			// lblReportTitle
			// 
			this.lblReportTitle.AutoSize = true;
			this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReportTitle.Location = new System.Drawing.Point(190, 7);
			this.lblReportTitle.Name = "lblReportTitle";
			this.lblReportTitle.Size = new System.Drawing.Size(0, 16);
			this.lblReportTitle.TabIndex = 13;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrint.Location = new System.Drawing.Point(109, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 12;
			this.btnPrint.Text = "&Print...";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExport.Location = new System.Drawing.Point(3, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(100, 23);
			this.btnExport.TabIndex = 11;
			this.btnExport.Text = "&Export to file...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(1070, 9);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(35, 13);
			this.lblQty.TabIndex = 7;
			this.lblQty.Text = "Items:";
			// 
			// txtQty
			// 
			this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(1121, 4);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(60, 22);
			this.txtQty.TabIndex = 8;
			this.txtQty.TabStop = false;
			this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// olcTicket_ReportedType
			// 
			this.olcTicket_ReportedType.AspectName = "Ticket.ReportedType";
			this.olcTicket_ReportedType.Text = "Reported";
			this.olcTicket_ReportedType.ToolTipText = "Reported Type";
			// 
			// FormReporting_Ticket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 762);
			this.Controls.Add(this.pnlContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FormReporting_Ticket";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reports: Tickets";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporting_Ticket_FormClosing);
			this.Shown += new System.EventHandler(this.FormReporting_Ticket_Shown);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvTR)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvTR;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtQty;
		private BrightIdeasSoftware.OLVColumn olvColTicket_ID;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Open;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Close;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Issue;
		private BrightIdeasSoftware.OLVColumn olvColTicket_OSANotes;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Symptoms;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Symptom_Other;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Solutions;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Solution_Notes;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Status;
		private BrightIdeasSoftware.OLVColumn olvColAsset_Asset;
		private BrightIdeasSoftware.OLVColumn olvColAsset_Panel;
		private BrightIdeasSoftware.OLVColumn olvColAsset_Location;
		private BrightIdeasSoftware.OLVColumn olvColTech_Name;
		private BrightIdeasSoftware.OLVColumn olvColCustomer_Name;
		private BrightIdeasSoftware.OLVColumn olvColMarket_Name;
		private BrightIdeasSoftware.OLVColumn olvColTicket_Duration;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;
		private BrightIdeasSoftware.OLVColumn olvColTicket_TechOnSite;
		private BrightIdeasSoftware.OLVColumn olvColTicket_TechArrivedDuration;
		private System.Windows.Forms.Label lblReportTitle;
		private BrightIdeasSoftware.OLVColumn olcTicket_ReportedType;

	}
}