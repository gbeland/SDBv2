namespace SDB.Forms.Reporting
{
	partial class FormReporting_RMA
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting_RMA));
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvRMAs = new BrightIdeasSoftware.ObjectListView();
			this.olvColRMA_Number = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Hot = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_APR = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_HasComputer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Created = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_CreatedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_IssuedTo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Received = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_TicketNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Asset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Panel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Assemblies = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_ReceivedQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_RepairStartedQty = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_FirstReceived = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Completed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Finalized = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_IsPending = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_PendingType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_PendingReason = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_AssemblyFailureTypes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_AssemblyRepairTypes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_AssemblyRootCauses = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.lblReportTitle = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.lblRMAQty = new System.Windows.Forms.Label();
			this.txtRMAQty = new System.Windows.Forms.TextBox();
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRMAs)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Controls.Add(this.olvRMAs);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(1184, 762);
			this.pnlContainer.TabIndex = 1;
			// 
			// olvRMAs
			// 
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Number);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Hot);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_APR);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_HasComputer);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Created);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_CreatedBy);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_IssuedTo);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Received);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_TicketNumber);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Asset);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Panel);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Assemblies);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_ReceivedQty);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_RepairStartedQty);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_FirstReceived);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Completed);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_Finalized);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_IsPending);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_PendingType);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_PendingReason);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_AssemblyFailureTypes);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_AssemblyRepairTypes);
			this.olvRMAs.AllColumns.Add(this.olvColRMA_AssemblyRootCauses);
			this.olvRMAs.CellEditUseWholeCell = false;
			this.olvRMAs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRMA_Number,
            this.olvColRMA_Hot,
            this.olvColRMA_APR,
            this.olvColRMA_HasComputer,
            this.olvColRMA_Created,
            this.olvColRMA_CreatedBy,
            this.olvColRMA_IssuedTo,
            this.olvColRMA_Received,
            this.olvColRMA_TicketNumber,
            this.olvColRMA_Asset,
            this.olvColRMA_Panel,
            this.olvColRMA_Assemblies,
            this.olvColRMA_ReceivedQty,
            this.olvColRMA_RepairStartedQty,
            this.olvColRMA_FirstReceived,
            this.olvColRMA_Completed,
            this.olvColRMA_Finalized,
            this.olvColRMA_IsPending,
            this.olvColRMA_AssemblyFailureTypes,
            this.olvColRMA_AssemblyRepairTypes,
            this.olvColRMA_AssemblyRootCauses});
			this.olvRMAs.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvRMAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRMAs.EmptyListMsg = "No RMAs found.";
			this.olvRMAs.FullRowSelect = true;
			this.olvRMAs.GridLines = true;
			this.olvRMAs.HideSelection = false;
			this.olvRMAs.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvRMAs.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvRMAs.Location = new System.Drawing.Point(0, 30);
			this.olvRMAs.MultiSelect = false;
			this.olvRMAs.Name = "olvRMAs";
			this.olvRMAs.ShowCommandMenuOnRightClick = true;
			this.olvRMAs.ShowGroups = false;
			this.olvRMAs.ShowItemCountOnGroups = true;
			this.olvRMAs.Size = new System.Drawing.Size(1184, 732);
			this.olvRMAs.SortGroupItemsByPrimaryColumn = false;
			this.olvRMAs.TabIndex = 4;
			this.olvRMAs.UseCompatibleStateImageBehavior = false;
			this.olvRMAs.UseFilterIndicator = true;
			this.olvRMAs.UseFiltering = true;
			this.olvRMAs.View = System.Windows.Forms.View.Details;
			this.olvRMAs.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvRMAs_FormatRow);
			this.olvRMAs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvRMAs_MouseDoubleClick);
			// 
			// olvColRMA_Number
			// 
			this.olvColRMA_Number.AspectName = "ID";
			this.olvColRMA_Number.Text = "RMA";
			this.olvColRMA_Number.UseFiltering = false;
			// 
			// olvColRMA_Hot
			// 
			this.olvColRMA_Hot.AspectName = "IsHot";
			this.olvColRMA_Hot.Text = "Hot";
			this.olvColRMA_Hot.Width = 40;
			// 
			// olvColRMA_APR
			// 
			this.olvColRMA_APR.AspectName = "IsAPR";
			this.olvColRMA_APR.Text = "APR";
			this.olvColRMA_APR.Width = 40;
			// 
			// olvColRMA_HasComputer
			// 
			this.olvColRMA_HasComputer.AspectName = "HasComputer";
			this.olvColRMA_HasComputer.Text = "Comp";
			this.olvColRMA_HasComputer.Width = 40;
			// 
			// olvColRMA_Created
			// 
			this.olvColRMA_Created.AspectName = "Creation_Date";
			this.olvColRMA_Created.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Created.Text = "Created";
			this.olvColRMA_Created.Width = 70;
			// 
			// olvColRMA_CreatedBy
			// 
			this.olvColRMA_CreatedBy.AspectName = "Creation_UserName";
			this.olvColRMA_CreatedBy.Text = "By";
			this.olvColRMA_CreatedBy.Width = 65;
			// 
			// olvColRMA_IssuedTo
			// 
			this.olvColRMA_IssuedTo.AspectName = "Tech.Name";
			this.olvColRMA_IssuedTo.Text = "Issued To";
			this.olvColRMA_IssuedTo.Width = 140;
			// 
			// olvColRMA_Received
			// 
			this.olvColRMA_Received.AspectName = "FirstAssemblyReceived";
			this.olvColRMA_Received.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Received.Text = "Received";
			this.olvColRMA_Received.Width = 70;
			// 
			// olvColRMA_TicketNumber
			// 
			this.olvColRMA_TicketNumber.AspectName = "TicketID";
			this.olvColRMA_TicketNumber.Text = "Ticket";
			this.olvColRMA_TicketNumber.Width = 50;
			// 
			// olvColRMA_Asset
			// 
			this.olvColRMA_Asset.AspectName = "Asset.AssetName";
			this.olvColRMA_Asset.Text = "Asset";
			this.olvColRMA_Asset.Width = 150;
			// 
			// olvColRMA_Panel
			// 
			this.olvColRMA_Panel.AspectName = "Asset.Panel";
			this.olvColRMA_Panel.Text = "Panel";
			this.olvColRMA_Panel.Width = 75;
			// 
			// olvColRMA_Assemblies
			// 
			this.olvColRMA_Assemblies.AspectName = "AssemblyQty";
			this.olvColRMA_Assemblies.Text = "#Asy";
			this.olvColRMA_Assemblies.ToolTipText = "Total Assemblies";
			this.olvColRMA_Assemblies.Width = 50;
			// 
			// olvColRMA_ReceivedQty
			// 
			this.olvColRMA_ReceivedQty.AspectName = "Assemblies_ReceivedOrDiscarded_Qty";
			this.olvColRMA_ReceivedQty.Text = "#Rcv";
			this.olvColRMA_ReceivedQty.ToolTipText = "Assemblies Received/Discarded";
			this.olvColRMA_ReceivedQty.Width = 50;
			// 
			// olvColRMA_RepairStartedQty
			// 
			this.olvColRMA_RepairStartedQty.AspectName = "Assemblies_RepairStarted_Qty";
			this.olvColRMA_RepairStartedQty.Text = "#Rep";
			this.olvColRMA_RepairStartedQty.ToolTipText = "Assemblies with Repair Started";
			this.olvColRMA_RepairStartedQty.Width = 50;
			// 
			// olvColRMA_FirstReceived
			// 
			this.olvColRMA_FirstReceived.AspectName = "FirstAssemblyReceived";
			this.olvColRMA_FirstReceived.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_FirstReceived.Text = "Received";
			this.olvColRMA_FirstReceived.ToolTipText = "First assembly received date.";
			this.olvColRMA_FirstReceived.Width = 70;
			// 
			// olvColRMA_Completed
			// 
			this.olvColRMA_Completed.AspectName = "Completed_Date";
			this.olvColRMA_Completed.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Completed.Text = "Completed";
			this.olvColRMA_Completed.Width = 70;
			// 
			// olvColRMA_Finalized
			// 
			this.olvColRMA_Finalized.AspectName = "Finalized_Date";
			this.olvColRMA_Finalized.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Finalized.Text = "Finalized";
			this.olvColRMA_Finalized.Width = 70;
			// 
			// olvColRMA_IsPending
			// 
			this.olvColRMA_IsPending.AspectName = "IsPending";
			this.olvColRMA_IsPending.Text = "Pending";
			this.olvColRMA_IsPending.Width = 40;
			// 
			// olvColRMA_PendingType
			// 
			this.olvColRMA_PendingType.AspectName = "Pending_Type";
			this.olvColRMA_PendingType.IsVisible = false;
			this.olvColRMA_PendingType.Text = "Pending Type";
			// 
			// olvColRMA_PendingReason
			// 
			this.olvColRMA_PendingReason.AspectName = "Pending_Reason";
			this.olvColRMA_PendingReason.IsVisible = false;
			this.olvColRMA_PendingReason.Text = "Pending Reason";
			this.olvColRMA_PendingReason.UseFiltering = false;
			this.olvColRMA_PendingReason.Width = 150;
			// 
			// olvColRMA_AssemblyFailureTypes
			// 
			this.olvColRMA_AssemblyFailureTypes.AspectName = "AssemblyFailureTypes";
			this.olvColRMA_AssemblyFailureTypes.Text = "Failure Types";
			this.olvColRMA_AssemblyFailureTypes.Width = 250;
			// 
			// olvColRMA_AssemblyRepairTypes
			// 
			this.olvColRMA_AssemblyRepairTypes.AspectName = "AssemblyRepairTypes";
			this.olvColRMA_AssemblyRepairTypes.Text = "Repair Types";
			this.olvColRMA_AssemblyRepairTypes.Width = 250;
			// 
			// olvColRMA_AssemblyRootCauses
			// 
			this.olvColRMA_AssemblyRootCauses.AspectName = "AssemblyRootCauses";
			this.olvColRMA_AssemblyRootCauses.Text = "Root Causes";
			this.olvColRMA_AssemblyRootCauses.Width = 250;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.lblReportTitle);
			this.pnlControl.Controls.Add(this.btnPrint);
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Controls.Add(this.lblRMAQty);
			this.pnlControl.Controls.Add(this.txtRMAQty);
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
			this.lblReportTitle.TabIndex = 15;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrint.Location = new System.Drawing.Point(109, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 14;
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
			this.btnExport.TabIndex = 13;
			this.btnExport.Text = "&Export to file...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// lblRMAQty
			// 
			this.lblRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRMAQty.AutoSize = true;
			this.lblRMAQty.Location = new System.Drawing.Point(1070, 9);
			this.lblRMAQty.Name = "lblRMAQty";
			this.lblRMAQty.Size = new System.Drawing.Size(39, 13);
			this.lblRMAQty.TabIndex = 7;
			this.lblRMAQty.Text = "RMAs:";
			// 
			// txtRMAQty
			// 
			this.txtRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRMAQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAQty.Location = new System.Drawing.Point(1121, 4);
			this.txtRMAQty.Name = "txtRMAQty";
			this.txtRMAQty.ReadOnly = true;
			this.txtRMAQty.Size = new System.Drawing.Size(60, 22);
			this.txtRMAQty.TabIndex = 8;
			this.txtRMAQty.TabStop = false;
			// 
			// FormReporting_RMA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 762);
			this.Controls.Add(this.pnlContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FormReporting_RMA";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reports: RMA";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporting_RMA_FormClosing);
			this.Shown += new System.EventHandler(this.FormReporting_RMA_Shown);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRMAs)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvRMAs;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Number;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblRMAQty;
		private System.Windows.Forms.TextBox txtRMAQty;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Hot;
		private BrightIdeasSoftware.OLVColumn olvColRMA_APR;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Created;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedTo;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Received;
		private BrightIdeasSoftware.OLVColumn olvColRMA_TicketNumber;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Asset;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Assemblies;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Completed;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Finalized;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;
		private BrightIdeasSoftware.OLVColumn olvColRMA_HasComputer;
		private BrightIdeasSoftware.OLVColumn olvColRMA_CreatedBy;
		private BrightIdeasSoftware.OLVColumn olvColRMA_ReceivedQty;
		private BrightIdeasSoftware.OLVColumn olvColRMA_RepairStartedQty;
		private BrightIdeasSoftware.OLVColumn olvColRMA_FirstReceived;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IsPending;
		private BrightIdeasSoftware.OLVColumn olvColRMA_PendingType;
		private BrightIdeasSoftware.OLVColumn olvColRMA_PendingReason;
		private BrightIdeasSoftware.OLVColumn olvColRMA_AssemblyFailureTypes;
		private BrightIdeasSoftware.OLVColumn olvColRMA_AssemblyRepairTypes;
		private BrightIdeasSoftware.OLVColumn olvColRMA_AssemblyRootCauses;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Panel;
		private System.Windows.Forms.Label lblReportTitle;

	}
}