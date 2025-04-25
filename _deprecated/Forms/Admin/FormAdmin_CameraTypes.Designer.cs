namespace SDB.Forms.Admin
{
	partial class FormAdmin_CameraTypes
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
			this.olvCameraTypes = new BrightIdeasSoftware.ObjectListView();
			this.olvColDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlCameraTypes_Control = new System.Windows.Forms.Panel();
			this.btnCameraType_Edit = new System.Windows.Forms.Button();
			this.btnCameraType_Remove = new System.Windows.Forms.Button();
			this.btnCameraType_Add = new System.Windows.Forms.Button();
			this.pnlCameraTypes = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvCameraTypes)).BeginInit();
			this.pnlCameraTypes_Control.SuspendLayout();
			this.pnlCameraTypes.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvCameraTypes
			// 
			this.olvCameraTypes.AllColumns.Add(this.olvColDescription);
			this.olvCameraTypes.CellEditUseWholeCell = false;
			this.olvCameraTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDescription});
			this.olvCameraTypes.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvCameraTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvCameraTypes.FullRowSelect = true;
			this.olvCameraTypes.GridLines = true;
			this.olvCameraTypes.HasCollapsibleGroups = false;
			this.olvCameraTypes.Location = new System.Drawing.Point(0, 30);
			this.olvCameraTypes.MultiSelect = false;
			this.olvCameraTypes.Name = "olvCameraTypes";
			this.olvCameraTypes.SelectAllOnControlA = false;
			this.olvCameraTypes.SelectColumnsOnRightClick = false;
			this.olvCameraTypes.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvCameraTypes.ShowFilterMenuOnRightClick = false;
			this.olvCameraTypes.ShowGroups = false;
			this.olvCameraTypes.ShowImagesOnSubItems = true;
			this.olvCameraTypes.Size = new System.Drawing.Size(310, 311);
			this.olvCameraTypes.TabIndex = 1;
			this.olvCameraTypes.UseCompatibleStateImageBehavior = false;
			this.olvCameraTypes.View = System.Windows.Forms.View.Details;
			this.olvCameraTypes.SelectedIndexChanged += new System.EventHandler(this.olvCameraTypes_SelectedIndexChanged);
			this.olvCameraTypes.DoubleClick += new System.EventHandler(this.olvCameraTypes_DoubleClick);
			// 
			// olvColDescription
			// 
			this.olvColDescription.AspectName = "Description";
			this.olvColDescription.Text = "Description";
			this.olvColDescription.Width = 280;
			// 
			// pnlCameraTypes_Control
			// 
			this.pnlCameraTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Edit);
			this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Remove);
			this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Add);
			this.pnlCameraTypes_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlCameraTypes_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlCameraTypes_Control.Name = "pnlCameraTypes_Control";
			this.pnlCameraTypes_Control.Size = new System.Drawing.Size(310, 30);
			this.pnlCameraTypes_Control.TabIndex = 0;
			// 
			// btnCameraType_Edit
			// 
			this.btnCameraType_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnCameraType_Edit.Location = new System.Drawing.Point(175, 3);
			this.btnCameraType_Edit.Name = "btnCameraType_Edit";
			this.btnCameraType_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnCameraType_Edit.TabIndex = 2;
			this.btnCameraType_Edit.Text = "Edit";
			this.btnCameraType_Edit.UseVisualStyleBackColor = false;
			this.btnCameraType_Edit.Click += new System.EventHandler(this.btnCameraType_Edit_Click);
			// 
			// btnCameraType_Remove
			// 
			this.btnCameraType_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCameraType_Remove.Location = new System.Drawing.Point(89, 3);
			this.btnCameraType_Remove.Name = "btnCameraType_Remove";
			this.btnCameraType_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnCameraType_Remove.TabIndex = 1;
			this.btnCameraType_Remove.Text = "Remove";
			this.btnCameraType_Remove.UseVisualStyleBackColor = false;
			this.btnCameraType_Remove.Click += new System.EventHandler(this.btnCameraType_Remove_Click);
			// 
			// btnCameraType_Add
			// 
			this.btnCameraType_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCameraType_Add.Location = new System.Drawing.Point(3, 3);
			this.btnCameraType_Add.Name = "btnCameraType_Add";
			this.btnCameraType_Add.Size = new System.Drawing.Size(80, 23);
			this.btnCameraType_Add.TabIndex = 0;
			this.btnCameraType_Add.Text = "Add";
			this.btnCameraType_Add.UseVisualStyleBackColor = false;
			this.btnCameraType_Add.Click += new System.EventHandler(this.btnCameraType_Add_Click);
			// 
			// pnlCameraTypes
			// 
			this.pnlCameraTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCameraTypes.Controls.Add(this.olvCameraTypes);
			this.pnlCameraTypes.Controls.Add(this.pnlCameraTypes_Control);
			this.pnlCameraTypes.Location = new System.Drawing.Point(12, 12);
			this.pnlCameraTypes.Name = "pnlCameraTypes";
			this.pnlCameraTypes.Size = new System.Drawing.Size(310, 341);
			this.pnlCameraTypes.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(247, 371);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormAdmin_CameraTypes
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(334, 406);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlCameraTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximumSize = new System.Drawing.Size(1024, 2000);
			this.MinimumSize = new System.Drawing.Size(340, 300);
			this.Name = "FormAdmin_CameraTypes";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Camera Types";
			this.Load += new System.EventHandler(this.FormCameraTypes_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvCameraTypes)).EndInit();
			this.pnlCameraTypes_Control.ResumeLayout(false);
			this.pnlCameraTypes.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvCameraTypes;
		private System.Windows.Forms.Panel pnlCameraTypes_Control;
		private System.Windows.Forms.Panel pnlCameraTypes;
		private BrightIdeasSoftware.OLVColumn olvColDescription;
		private System.Windows.Forms.Button btnCameraType_Remove;
		private System.Windows.Forms.Button btnCameraType_Add;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCameraType_Edit;
	}
}