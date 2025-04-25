namespace SDB.UserControls.Asset
{
	partial class ucAssetSystemBackup
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
			this.olvSystemBackups = new BrightIdeasSoftware.ObjectListView();
			this.olcDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcSystemVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnRestoreBackup = new System.Windows.Forms.Button();
			this.btnDeleteBackup = new System.Windows.Forms.Button();
			this.btnCreateBackup = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btnSaveAs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvSystemBackups)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvSystemBackups
			// 
			this.olvSystemBackups.AllColumns.Add(this.olcDate);
			this.olvSystemBackups.AllColumns.Add(this.olcSystemVersion);
			this.olvSystemBackups.AllColumns.Add(this.olcNotes);
			this.olvSystemBackups.AllowColumnReorder = true;
			this.olvSystemBackups.CellEditUseWholeCell = false;
			this.olvSystemBackups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDate,
            this.olcSystemVersion,
            this.olcNotes});
			this.olvSystemBackups.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSystemBackups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSystemBackups.EmptyListMsg = "No system backups for this asset.";
			this.olvSystemBackups.FullRowSelect = true;
			this.olvSystemBackups.GridLines = true;
			this.olvSystemBackups.HasCollapsibleGroups = false;
			this.olvSystemBackups.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.olvSystemBackups.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.olvSystemBackups.Location = new System.Drawing.Point(0, 30);
			this.olvSystemBackups.MultiSelect = false;
			this.olvSystemBackups.Name = "olvSystemBackups";
			this.olvSystemBackups.SelectAllOnControlA = false;
			this.olvSystemBackups.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvSystemBackups.ShowCommandMenuOnRightClick = true;
			this.olvSystemBackups.ShowGroups = false;
			this.olvSystemBackups.Size = new System.Drawing.Size(825, 272);
			this.olvSystemBackups.TabIndex = 1;
			this.olvSystemBackups.UseCompatibleStateImageBehavior = false;
			this.olvSystemBackups.View = System.Windows.Forms.View.Details;
			// 
			// olcDate
			// 
			this.olcDate.AspectName = "BackupDate";
			this.olcDate.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm:ss}";
			this.olcDate.IsEditable = false;
			this.olcDate.Text = "Backup Date";
			this.olcDate.Width = 150;
			// 
			// olcSystemVersion
			// 
			this.olcSystemVersion.AspectName = "SystemVersion";
			this.olcSystemVersion.IsEditable = false;
			this.olcSystemVersion.Text = "System Version";
			this.olcSystemVersion.Width = 100;
			// 
			// olcNotes
			// 
			this.olcNotes.AspectName = "Notes";
			this.olcNotes.Groupable = false;
			this.olcNotes.IsEditable = false;
			this.olcNotes.Text = "Notes";
			this.olcNotes.Width = 600;
			this.olcNotes.WordWrap = true;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnSaveAs);
			this.pnlControl.Controls.Add(this.btnRestoreBackup);
			this.pnlControl.Controls.Add(this.btnDeleteBackup);
			this.pnlControl.Controls.Add(this.btnCreateBackup);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(825, 30);
			this.pnlControl.TabIndex = 0;
			// 
			// btnRestoreBackup
			// 
			this.btnRestoreBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRestoreBackup.Location = new System.Drawing.Point(235, 3);
			this.btnRestoreBackup.Name = "btnRestoreBackup";
			this.btnRestoreBackup.Size = new System.Drawing.Size(110, 23);
			this.btnRestoreBackup.TabIndex = 2;
			this.btnRestoreBackup.Text = "Restore";
			this.toolTip.SetToolTip(this.btnRestoreBackup, "Restores the selected System Backup.");
			this.btnRestoreBackup.UseVisualStyleBackColor = false;
			this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
			// 
			// btnDeleteBackup
			// 
			this.btnDeleteBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDeleteBackup.Location = new System.Drawing.Point(712, 3);
			this.btnDeleteBackup.Name = "btnDeleteBackup";
			this.btnDeleteBackup.Size = new System.Drawing.Size(110, 23);
			this.btnDeleteBackup.TabIndex = 3;
			this.btnDeleteBackup.Text = "Delete Backup";
			this.toolTip.SetToolTip(this.btnDeleteBackup, "Deletes the selected System Backup.");
			this.btnDeleteBackup.UseVisualStyleBackColor = false;
			this.btnDeleteBackup.Click += new System.EventHandler(this.btnDeleteBackup_Click);
			// 
			// btnCreateBackup
			// 
			this.btnCreateBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreateBackup.Location = new System.Drawing.Point(3, 3);
			this.btnCreateBackup.Name = "btnCreateBackup";
			this.btnCreateBackup.Size = new System.Drawing.Size(110, 23);
			this.btnCreateBackup.TabIndex = 0;
			this.btnCreateBackup.Text = "Create Backup";
			this.toolTip.SetToolTip(this.btnCreateBackup, "Creates a System Backup.");
			this.btnCreateBackup.UseVisualStyleBackColor = false;
			this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
			// 
			// btnSaveAs
			// 
			this.btnSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSaveAs.Location = new System.Drawing.Point(119, 3);
			this.btnSaveAs.Name = "btnSaveAs";
			this.btnSaveAs.Size = new System.Drawing.Size(110, 23);
			this.btnSaveAs.TabIndex = 1;
			this.btnSaveAs.Text = "Save As...";
			this.toolTip.SetToolTip(this.btnSaveAs, "Saves backup data as a zip file.");
			this.btnSaveAs.UseVisualStyleBackColor = false;
			this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
			// 
			// ucAssetSystemBackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.olvSystemBackups);
			this.Controls.Add(this.pnlControl);
			this.Name = "ucAssetSystemBackup";
			this.Size = new System.Drawing.Size(825, 302);
			((System.ComponentModel.ISupportInitialize)(this.olvSystemBackups)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvSystemBackups;
		private BrightIdeasSoftware.OLVColumn olcDate;
		private BrightIdeasSoftware.OLVColumn olcSystemVersion;
		private BrightIdeasSoftware.OLVColumn olcNotes;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnRestoreBackup;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnDeleteBackup;
		private System.Windows.Forms.Button btnCreateBackup;
		private System.Windows.Forms.Button btnSaveAs;


	}
}
