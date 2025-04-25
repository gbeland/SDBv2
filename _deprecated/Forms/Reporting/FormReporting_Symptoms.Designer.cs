namespace SDB.Forms.Reporting
{
	partial class FormReporting_Symptoms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting_Symptoms));
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.olvSymptoms = new BrightIdeasSoftware.ObjectListView();
			this.olvColSymptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.lblReportTitle = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.pnlContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Controls.Add(this.olvSymptoms);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(634, 562);
			this.pnlContainer.TabIndex = 1;
			// 
			// olvSymptoms
			// 
			this.olvSymptoms.AllColumns.Add(this.olvColSymptom);
			this.olvSymptoms.AllColumns.Add(this.olvColCount);
			this.olvSymptoms.CellEditUseWholeCell = false;
			this.olvSymptoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSymptom,
            this.olvColCount});
			this.olvSymptoms.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSymptoms.EmptyListMsg = "";
			this.olvSymptoms.FullRowSelect = true;
			this.olvSymptoms.GridLines = true;
			this.olvSymptoms.HideSelection = false;
			this.olvSymptoms.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.olvSymptoms.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.olvSymptoms.Location = new System.Drawing.Point(0, 30);
			this.olvSymptoms.MultiSelect = false;
			this.olvSymptoms.Name = "olvSymptoms";
			this.olvSymptoms.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvSymptoms.ShowCommandMenuOnRightClick = true;
			this.olvSymptoms.ShowGroups = false;
			this.olvSymptoms.ShowItemCountOnGroups = true;
			this.olvSymptoms.Size = new System.Drawing.Size(634, 532);
			this.olvSymptoms.SortGroupItemsByPrimaryColumn = false;
			this.olvSymptoms.TabIndex = 4;
			this.olvSymptoms.UseCellFormatEvents = true;
			this.olvSymptoms.UseCompatibleStateImageBehavior = false;
			this.olvSymptoms.UseFilterIndicator = true;
			this.olvSymptoms.UseFiltering = true;
			this.olvSymptoms.View = System.Windows.Forms.View.Details;
			// 
			// olvColSymptom
			// 
			this.olvColSymptom.AspectName = "Symptom.Symptom";
			this.olvColSymptom.Text = "Symptom";
			this.olvColSymptom.Width = 350;
			// 
			// olvColCount
			// 
			this.olvColCount.AspectName = "Quantity";
			this.olvColCount.Text = "Count";
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.lblReportTitle);
			this.pnlControl.Controls.Add(this.btnPrint);
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(634, 30);
			this.pnlControl.TabIndex = 10;
			// 
			// lblReportTitle
			// 
			this.lblReportTitle.AutoSize = true;
			this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReportTitle.Location = new System.Drawing.Point(190, 7);
			this.lblReportTitle.Name = "lblReportTitle";
			this.lblReportTitle.Size = new System.Drawing.Size(0, 16);
			this.lblReportTitle.TabIndex = 12;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrint.Location = new System.Drawing.Point(109, 4);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 10;
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
			this.btnExport.TabIndex = 9;
			this.btnExport.Text = "&Export to file...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// FormReporting_Symptoms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 562);
			this.Controls.Add(this.pnlContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReporting_Symptoms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reports: Symptoms";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporting_Symptoms_FormClosing);
			this.Shown += new System.EventHandler(this.FormReporting_Symptoms_Shown);
			this.pnlContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContainer;
		private BrightIdeasSoftware.ObjectListView olvSymptoms;
		private BrightIdeasSoftware.OLVColumn olvColSymptom;
		private BrightIdeasSoftware.OLVColumn olvColCount;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Label lblReportTitle;

	}
}