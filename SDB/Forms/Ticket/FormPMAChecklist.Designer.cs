namespace SDB.Forms.Ticket
{
	partial class FormPMAChecklist
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
			this.olvPMAs = new BrightIdeasSoftware.ObjectListView();
			this.olvColDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlPMAs = new System.Windows.Forms.Panel();
			this.btnSaveClose = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).BeginInit();
			this.pnlPMAs.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvPMAs
			// 
			this.olvPMAs.AllColumns.Add(this.olvColDescription);
			this.olvPMAs.CheckBoxes = true;
			this.olvPMAs.CheckedAspectName = "Completed";
			this.olvPMAs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDescription});
			this.olvPMAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvPMAs.FullRowSelect = true;
			this.olvPMAs.GridLines = true;
			this.olvPMAs.HasCollapsibleGroups = false;
			this.olvPMAs.Location = new System.Drawing.Point(0, 0);
			this.olvPMAs.MultiSelect = false;
			this.olvPMAs.Name = "olvPMAs";
			this.olvPMAs.SelectAllOnControlA = false;
			this.olvPMAs.SelectColumnsOnRightClick = false;
			this.olvPMAs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvPMAs.ShowFilterMenuOnRightClick = false;
			this.olvPMAs.ShowGroups = false;
			this.olvPMAs.ShowImagesOnSubItems = true;
			this.olvPMAs.Size = new System.Drawing.Size(520, 311);
			this.olvPMAs.TabIndex = 0;
			this.olvPMAs.UseCompatibleStateImageBehavior = false;
			this.olvPMAs.View = System.Windows.Forms.View.Details;
			// 
			// olvColDescription
			// 
			this.olvColDescription.AspectName = "Description";
			this.olvColDescription.FillsFreeSpace = true;
			this.olvColDescription.Text = "Description";
			this.olvColDescription.Width = 300;
			// 
			// pnlPMAs
			// 
			this.pnlPMAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPMAs.Controls.Add(this.olvPMAs);
			this.pnlPMAs.Location = new System.Drawing.Point(12, 12);
			this.pnlPMAs.Name = "pnlPMAs";
			this.pnlPMAs.Size = new System.Drawing.Size(520, 311);
			this.pnlPMAs.TabIndex = 2;
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSaveClose.Location = new System.Drawing.Point(457, 341);
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(75, 23);
			this.btnSaveClose.TabIndex = 3;
			this.btnSaveClose.Text = "Save/Close";
			this.btnSaveClose.UseVisualStyleBackColor = true;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(376, 341);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormPMAChecklist
			// 
			this.AcceptButton = this.btnSaveClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(544, 376);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveClose);
			this.Controls.Add(this.pnlPMAs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPMAChecklist";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preventive Maintenance Checklist";
			this.Load += new System.EventHandler(this.FormPMAChecklist_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).EndInit();
			this.pnlPMAs.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvPMAs;
		private System.Windows.Forms.Panel pnlPMAs;
		private BrightIdeasSoftware.OLVColumn olvColDescription;
		private System.Windows.Forms.Button btnSaveClose;
		private System.Windows.Forms.Button btnCancel;
	}
}