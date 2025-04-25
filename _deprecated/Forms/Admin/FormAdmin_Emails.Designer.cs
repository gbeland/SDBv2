namespace SDB.Forms.Admin
{
	partial class FormAdmin_Emails
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
			this.olvAdminEmails = new BrightIdeasSoftware.ObjectListView();
			this.olvColName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlCameraTypes = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvAdminEmails)).BeginInit();
			this.pnlControl.SuspendLayout();
			this.pnlCameraTypes.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvAdminEmails
			// 
			this.olvAdminEmails.AllColumns.Add(this.olvColName);
			this.olvAdminEmails.AllColumns.Add(this.olvColEmail);
			this.olvAdminEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColName,
            this.olvColEmail});
			this.olvAdminEmails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvAdminEmails.FullRowSelect = true;
			this.olvAdminEmails.GridLines = true;
			this.olvAdminEmails.HasCollapsibleGroups = false;
			this.olvAdminEmails.Location = new System.Drawing.Point(0, 30);
			this.olvAdminEmails.MultiSelect = false;
			this.olvAdminEmails.Name = "olvAdminEmails";
			this.olvAdminEmails.SelectAllOnControlA = false;
			this.olvAdminEmails.SelectColumnsOnRightClick = false;
			this.olvAdminEmails.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvAdminEmails.ShowFilterMenuOnRightClick = false;
			this.olvAdminEmails.ShowGroups = false;
			this.olvAdminEmails.ShowImagesOnSubItems = true;
			this.olvAdminEmails.Size = new System.Drawing.Size(670, 200);
			this.olvAdminEmails.TabIndex = 0;
			this.olvAdminEmails.UseCompatibleStateImageBehavior = false;
			this.olvAdminEmails.View = System.Windows.Forms.View.Details;
			this.olvAdminEmails.SelectedIndexChanged += new System.EventHandler(this.olvAdminEmails_SelectedIndexChanged);
			this.olvAdminEmails.DoubleClick += new System.EventHandler(this.olvAdminEmails_DoubleClick);
			// 
			// olvColName
			// 
			this.olvColName.AspectName = "Name";
			this.olvColName.CellPadding = null;
			this.olvColName.Text = "Name";
			this.olvColName.Width = 180;
			// 
			// olvColEmail
			// 
			this.olvColEmail.AspectName = "Email";
			this.olvColEmail.CellPadding = null;
			this.olvColEmail.FillsFreeSpace = true;
			this.olvColEmail.Text = "Email Address";
			this.olvColEmail.Width = 410;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnEdit);
			this.pnlControl.Controls.Add(this.btnRemove);
			this.pnlControl.Controls.Add(this.btnAdd);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(670, 30);
			this.pnlControl.TabIndex = 1;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Location = new System.Drawing.Point(175, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(80, 23);
			this.btnEdit.TabIndex = 13;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRemove.Location = new System.Drawing.Point(89, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(80, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlCameraTypes
			// 
			this.pnlCameraTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCameraTypes.Controls.Add(this.olvAdminEmails);
			this.pnlCameraTypes.Controls.Add(this.pnlControl);
			this.pnlCameraTypes.Location = new System.Drawing.Point(12, 12);
			this.pnlCameraTypes.Name = "pnlCameraTypes";
			this.pnlCameraTypes.Size = new System.Drawing.Size(670, 230);
			this.pnlCameraTypes.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(607, 260);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormAdmin_Emails
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(694, 295);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlCameraTypes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAdmin_Emails";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Administrative Email Addresses";
			this.Load += new System.EventHandler(this.FormAdminEmails_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvAdminEmails)).EndInit();
			this.pnlControl.ResumeLayout(false);
			this.pnlCameraTypes.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvAdminEmails;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Panel pnlCameraTypes;
		private BrightIdeasSoftware.OLVColumn olvColName;
		private BrightIdeasSoftware.OLVColumn olvColEmail;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEdit;
	}
}