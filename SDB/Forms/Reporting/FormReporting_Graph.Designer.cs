namespace SDB.Forms.Reporting
{
	partial class FormReporting_Graph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting_Graph));
			this.zgcGraph = new ZedGraph.ZedGraphControl();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.lblReportTitle = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// zgcGraph
			// 
			this.zgcGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zgcGraph.Location = new System.Drawing.Point(0, 30);
			this.zgcGraph.Name = "zgcGraph";
			this.zgcGraph.ScrollGrace = 0D;
			this.zgcGraph.ScrollMaxX = 0D;
			this.zgcGraph.ScrollMaxY = 0D;
			this.zgcGraph.ScrollMaxY2 = 0D;
			this.zgcGraph.ScrollMinX = 0D;
			this.zgcGraph.ScrollMinY = 0D;
			this.zgcGraph.ScrollMinY2 = 0D;
			this.zgcGraph.Size = new System.Drawing.Size(984, 736);
			this.zgcGraph.TabIndex = 0;
			this.zgcGraph.UseExtendedPrintDialog = true;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.lblReportTitle);
			this.pnlControl.Controls.Add(this.btnPrint);
			this.pnlControl.Controls.Add(this.btnSaveFile);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(984, 30);
			this.pnlControl.TabIndex = 1;
			// 
			// lblReportTitle
			// 
			this.lblReportTitle.AutoSize = true;
			this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReportTitle.Location = new System.Drawing.Point(211, 7);
			this.lblReportTitle.Name = "lblReportTitle";
			this.lblReportTitle.Size = new System.Drawing.Size(0, 16);
			this.lblReportTitle.TabIndex = 13;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(107, 3);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(98, 23);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "&Print...";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Location = new System.Drawing.Point(3, 3);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(98, 23);
			this.btnSaveFile.TabIndex = 0;
			this.btnSaveFile.Text = "Save as file...";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
			// 
			// FormReporting_Graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 766);
			this.Controls.Add(this.zgcGraph);
			this.Controls.Add(this.pnlControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FormReporting_Graph";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports: Graph";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReporting_Graph_FormClosing);
			this.Shown += new System.EventHandler(this.FormReporting_Graph_Shown);
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ZedGraph.ZedGraphControl zgcGraph;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnSaveFile;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label lblReportTitle;
	}
}