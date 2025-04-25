namespace SDB.Forms.Ticket
{
	partial class FormTicket_TechLog
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
			this.olvTOSEvents = new BrightIdeasSoftware.ObjectListView();
			this.olcDateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTechName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcArriveDepart = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlPMAs = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.txtTotalTime = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.olvTOSEvents)).BeginInit();
			this.pnlPMAs.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvTOSEvents
			// 
			this.olvTOSEvents.AllColumns.Add(this.olcDateTime);
			this.olvTOSEvents.AllColumns.Add(this.olcTechName);
			this.olvTOSEvents.AllColumns.Add(this.olcArriveDepart);
			this.olvTOSEvents.CheckedAspectName = "";
			this.olvTOSEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDateTime,
            this.olcTechName,
            this.olcArriveDepart});
			this.olvTOSEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvTOSEvents.FullRowSelect = true;
			this.olvTOSEvents.GridLines = true;
			this.olvTOSEvents.HasCollapsibleGroups = false;
			this.olvTOSEvents.Location = new System.Drawing.Point(0, 0);
			this.olvTOSEvents.MultiSelect = false;
			this.olvTOSEvents.Name = "olvTOSEvents";
			this.olvTOSEvents.SelectAllOnControlA = false;
			this.olvTOSEvents.SelectColumnsOnRightClick = false;
			this.olvTOSEvents.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvTOSEvents.ShowFilterMenuOnRightClick = false;
			this.olvTOSEvents.ShowGroups = false;
			this.olvTOSEvents.ShowImagesOnSubItems = true;
			this.olvTOSEvents.Size = new System.Drawing.Size(420, 311);
			this.olvTOSEvents.TabIndex = 0;
			this.olvTOSEvents.UseCompatibleStateImageBehavior = false;
			this.olvTOSEvents.View = System.Windows.Forms.View.Details;
			// 
			// olcDateTime
			// 
			this.olcDateTime.AspectName = "EventDateTime";
			this.olcDateTime.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm:ss}";
			this.olcDateTime.CellPadding = null;
			this.olcDateTime.Text = "Date/Time";
			this.olcDateTime.Width = 130;
			// 
			// olcTechName
			// 
			this.olcTechName.AspectName = "TechName";
			this.olcTechName.CellPadding = null;
			this.olcTechName.Text = "Tech";
			this.olcTechName.Width = 180;
			// 
			// olcArriveDepart
			// 
			this.olcArriveDepart.AspectName = "ArriveDepart";
			this.olcArriveDepart.CellPadding = null;
			this.olcArriveDepart.Text = "Arrive/Depart";
			this.olcArriveDepart.Width = 80;
			// 
			// pnlPMAs
			// 
			this.pnlPMAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPMAs.Controls.Add(this.olvTOSEvents);
			this.pnlPMAs.Location = new System.Drawing.Point(12, 12);
			this.pnlPMAs.Name = "pnlPMAs";
			this.pnlPMAs.Size = new System.Drawing.Size(420, 311);
			this.pnlPMAs.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(357, 341);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.AutoSize = true;
			this.lblTotalTime.Location = new System.Drawing.Point(12, 346);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(114, 13);
			this.lblTotalTime.TabIndex = 1;
			this.lblTotalTime.Text = "Total tech on-site time:";
			// 
			// txtTotalTime
			// 
			this.txtTotalTime.Location = new System.Drawing.Point(132, 343);
			this.txtTotalTime.Name = "txtTotalTime";
			this.txtTotalTime.ReadOnly = true;
			this.txtTotalTime.Size = new System.Drawing.Size(100, 20);
			this.txtTotalTime.TabIndex = 2;
			// 
			// FormTicket_TechLog
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(444, 376);
			this.Controls.Add(this.txtTotalTime);
			this.Controls.Add(this.lblTotalTime);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlPMAs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormTicket_TechLog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Tech Arrival/Departure Log";
			this.Load += new System.EventHandler(this.FormPMAChecklist_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvTOSEvents)).EndInit();
			this.pnlPMAs.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvTOSEvents;
		private System.Windows.Forms.Panel pnlPMAs;
		private System.Windows.Forms.Button btnClose;
		private BrightIdeasSoftware.OLVColumn olcDateTime;
		private BrightIdeasSoftware.OLVColumn olcArriveDepart;
		private BrightIdeasSoftware.OLVColumn olcTechName;
		private System.Windows.Forms.Label lblTotalTime;
		private System.Windows.Forms.TextBox txtTotalTime;
	}
}