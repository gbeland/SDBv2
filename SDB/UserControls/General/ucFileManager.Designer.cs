namespace SDB.UserControls.General
{
	partial class ucFileManager
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
			this.pnlFiles = new System.Windows.Forms.Panel();
			this.olvFiles = new BrightIdeasSoftware.ObjectListView();
			this.olvColFiles_Thumbnail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColFiles_Date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColFiles_Filename = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColFiles_User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlFiles_Control = new System.Windows.Forms.Panel();
			this.lblFilesQty = new System.Windows.Forms.Label();
			this.txtFilesQty = new System.Windows.Forms.TextBox();
			this.btnFiles_Delete = new System.Windows.Forms.Button();
			this.btnFiles_Add = new System.Windows.Forms.Button();
			this.pnlFiles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvFiles)).BeginInit();
			this.pnlFiles_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFiles
			// 
			this.pnlFiles.Controls.Add(this.olvFiles);
			this.pnlFiles.Controls.Add(this.pnlFiles_Control);
			this.pnlFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFiles.Location = new System.Drawing.Point(0, 0);
			this.pnlFiles.Name = "pnlFiles";
			this.pnlFiles.Size = new System.Drawing.Size(620, 300);
			this.pnlFiles.TabIndex = 0;
			// 
			// olvFiles
			// 
			this.olvFiles.AllColumns.Add(this.olvColFiles_Thumbnail);
			this.olvFiles.AllColumns.Add(this.olvColFiles_Date);
			this.olvFiles.AllColumns.Add(this.olvColFiles_Filename);
			this.olvFiles.AllColumns.Add(this.olvColFiles_User);
			this.olvFiles.CellEditUseWholeCell = false;
			this.olvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColFiles_Thumbnail,
            this.olvColFiles_Date,
            this.olvColFiles_Filename,
            this.olvColFiles_User});
			this.olvFiles.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvFiles.EmptyListMsg = "No files.";
			this.olvFiles.FullRowSelect = true;
			this.olvFiles.GridLines = true;
			this.olvFiles.HasCollapsibleGroups = false;
			this.olvFiles.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvFiles.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvFiles.Location = new System.Drawing.Point(0, 30);
			this.olvFiles.Name = "olvFiles";
			this.olvFiles.RowHeight = 60;
			this.olvFiles.ShowGroups = false;
			this.olvFiles.Size = new System.Drawing.Size(620, 270);
			this.olvFiles.TabIndex = 0;
			this.olvFiles.UseCompatibleStateImageBehavior = false;
			this.olvFiles.UseOverlays = false;
			this.olvFiles.View = System.Windows.Forms.View.Details;
			// 
			// olvColFiles_Thumbnail
			// 
			this.olvColFiles_Thumbnail.Text = "Preview";
			this.olvColFiles_Thumbnail.Width = 120;
			// 
			// olvColFiles_Date
			// 
			this.olvColFiles_Date.Text = "Date";
			this.olvColFiles_Date.Width = 90;
			// 
			// olvColFiles_Filename
			// 
			this.olvColFiles_Filename.FillsFreeSpace = true;
			this.olvColFiles_Filename.Text = "Filename";
			this.olvColFiles_Filename.Width = 280;
			// 
			// olvColFiles_User
			// 
			this.olvColFiles_User.Text = "User";
			this.olvColFiles_User.Width = 65;
			// 
			// pnlFiles_Control
			// 
			this.pnlFiles_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlFiles_Control.Controls.Add(this.lblFilesQty);
			this.pnlFiles_Control.Controls.Add(this.txtFilesQty);
			this.pnlFiles_Control.Controls.Add(this.btnFiles_Delete);
			this.pnlFiles_Control.Controls.Add(this.btnFiles_Add);
			this.pnlFiles_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlFiles_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlFiles_Control.Name = "pnlFiles_Control";
			this.pnlFiles_Control.Size = new System.Drawing.Size(620, 30);
			this.pnlFiles_Control.TabIndex = 0;
			// 
			// lblFilesQty
			// 
			this.lblFilesQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblFilesQty.AutoSize = true;
			this.lblFilesQty.Location = new System.Drawing.Point(520, 9);
			this.lblFilesQty.Name = "lblFilesQty";
			this.lblFilesQty.Size = new System.Drawing.Size(31, 13);
			this.lblFilesQty.TabIndex = 9;
			this.lblFilesQty.Text = "Files:";
			// 
			// txtFilesQty
			// 
			this.txtFilesQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilesQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilesQty.Location = new System.Drawing.Point(557, 4);
			this.txtFilesQty.Name = "txtFilesQty";
			this.txtFilesQty.ReadOnly = true;
			this.txtFilesQty.Size = new System.Drawing.Size(60, 22);
			this.txtFilesQty.TabIndex = 10;
			this.txtFilesQty.TabStop = false;
			// 
			// btnFiles_Delete
			// 
			this.btnFiles_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnFiles_Delete.Location = new System.Drawing.Point(131, 4);
			this.btnFiles_Delete.Name = "btnFiles_Delete";
			this.btnFiles_Delete.Size = new System.Drawing.Size(120, 23);
			this.btnFiles_Delete.TabIndex = 3;
			this.btnFiles_Delete.Text = "Delete File";
			this.btnFiles_Delete.UseVisualStyleBackColor = false;
			// 
			// btnFiles_Add
			// 
			this.btnFiles_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnFiles_Add.Location = new System.Drawing.Point(3, 4);
			this.btnFiles_Add.Name = "btnFiles_Add";
			this.btnFiles_Add.Size = new System.Drawing.Size(120, 23);
			this.btnFiles_Add.TabIndex = 2;
			this.btnFiles_Add.Text = "Add File";
			this.btnFiles_Add.UseVisualStyleBackColor = false;
			// 
			// ucFileManager
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlFiles);
			this.Name = "ucFileManager";
			this.Size = new System.Drawing.Size(620, 300);
			this.pnlFiles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvFiles)).EndInit();
			this.pnlFiles_Control.ResumeLayout(false);
			this.pnlFiles_Control.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlFiles;
		private System.Windows.Forms.Panel pnlFiles_Control;
		private BrightIdeasSoftware.ObjectListView olvFiles;
		private BrightIdeasSoftware.OLVColumn olvColFiles_Thumbnail;
		private BrightIdeasSoftware.OLVColumn olvColFiles_Date;
		private BrightIdeasSoftware.OLVColumn olvColFiles_Filename;
		private BrightIdeasSoftware.OLVColumn olvColFiles_User;
		private System.Windows.Forms.Button btnFiles_Delete;
		private System.Windows.Forms.Button btnFiles_Add;
		private System.Windows.Forms.Label lblFilesQty;
		private System.Windows.Forms.TextBox txtFilesQty;
	}
}
