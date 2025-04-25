namespace SDB.Forms.Admin
{
	partial class FormAdmin_PMAs
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
			this.pnlPMAs_Control = new System.Windows.Forms.Panel();
			this.btnPMA_Edit = new System.Windows.Forms.Button();
			this.btnPMA_Remove = new System.Windows.Forms.Button();
			this.btnPMA_Add = new System.Windows.Forms.Button();
			this.pnlPMAs = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).BeginInit();
			this.pnlPMAs_Control.SuspendLayout();
			this.pnlPMAs.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvPMAs
			// 
			this.olvPMAs.AllColumns.Add(this.olvColDescription);
			this.olvPMAs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColDescription});
			this.olvPMAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvPMAs.FullRowSelect = true;
			this.olvPMAs.GridLines = true;
			this.olvPMAs.HasCollapsibleGroups = false;
			this.olvPMAs.Location = new System.Drawing.Point(0, 30);
			this.olvPMAs.MultiSelect = false;
			this.olvPMAs.Name = "olvPMAs";
			this.olvPMAs.SelectAllOnControlA = false;
			this.olvPMAs.SelectColumnsOnRightClick = false;
			this.olvPMAs.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvPMAs.ShowFilterMenuOnRightClick = false;
			this.olvPMAs.ShowGroups = false;
			this.olvPMAs.ShowImagesOnSubItems = true;
			this.olvPMAs.Size = new System.Drawing.Size(520, 281);
			this.olvPMAs.TabIndex = 0;
			this.olvPMAs.UseCompatibleStateImageBehavior = false;
			this.olvPMAs.View = System.Windows.Forms.View.Details;
			this.olvPMAs.SelectedIndexChanged += new System.EventHandler(this.olvPMAs_SelectedIndexChanged);
			this.olvPMAs.DoubleClick += new System.EventHandler(this.olvPMAs_DoubleClick);
			// 
			// olvColDescription
			// 
			this.olvColDescription.AspectName = "Description";
			this.olvColDescription.FillsFreeSpace = true;
			this.olvColDescription.Text = "Description";
			this.olvColDescription.Width = 300;
			// 
			// pnlPMAs_Control
			// 
			this.pnlPMAs_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlPMAs_Control.Controls.Add(this.btnPMA_Edit);
			this.pnlPMAs_Control.Controls.Add(this.btnPMA_Remove);
			this.pnlPMAs_Control.Controls.Add(this.btnPMA_Add);
			this.pnlPMAs_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlPMAs_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlPMAs_Control.Name = "pnlPMAs_Control";
			this.pnlPMAs_Control.Size = new System.Drawing.Size(520, 30);
			this.pnlPMAs_Control.TabIndex = 1;
			// 
			// btnPMA_Edit
			// 
			this.btnPMA_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnPMA_Edit.Location = new System.Drawing.Point(297, 3);
			this.btnPMA_Edit.Name = "btnPMA_Edit";
			this.btnPMA_Edit.Size = new System.Drawing.Size(140, 23);
			this.btnPMA_Edit.TabIndex = 13;
			this.btnPMA_Edit.Text = "Edit PMA";
			this.btnPMA_Edit.UseVisualStyleBackColor = false;
			this.btnPMA_Edit.Click += new System.EventHandler(this.btnPMA_Edit_Click);
			// 
			// btnPMA_Remove
			// 
			this.btnPMA_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnPMA_Remove.Location = new System.Drawing.Point(151, 3);
			this.btnPMA_Remove.Name = "btnPMA_Remove";
			this.btnPMA_Remove.Size = new System.Drawing.Size(140, 23);
			this.btnPMA_Remove.TabIndex = 3;
			this.btnPMA_Remove.Text = "Remove PMA";
			this.btnPMA_Remove.UseVisualStyleBackColor = false;
			this.btnPMA_Remove.Click += new System.EventHandler(this.btnPMA_Remove_Click);
			// 
			// btnPMA_Add
			// 
			this.btnPMA_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnPMA_Add.Location = new System.Drawing.Point(3, 3);
			this.btnPMA_Add.Name = "btnPMA_Add";
			this.btnPMA_Add.Size = new System.Drawing.Size(140, 23);
			this.btnPMA_Add.TabIndex = 2;
			this.btnPMA_Add.Text = "Add PMA";
			this.btnPMA_Add.UseVisualStyleBackColor = false;
			this.btnPMA_Add.Click += new System.EventHandler(this.btnPMA_Add_Click);
			// 
			// pnlPMAs
			// 
			this.pnlPMAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlPMAs.Controls.Add(this.olvPMAs);
			this.pnlPMAs.Controls.Add(this.pnlPMAs_Control);
			this.pnlPMAs.Location = new System.Drawing.Point(12, 12);
			this.pnlPMAs.Name = "pnlPMAs";
			this.pnlPMAs.Size = new System.Drawing.Size(520, 311);
			this.pnlPMAs.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(457, 341);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormPMAs
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(544, 376);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlPMAs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPMAs";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preventive Maintenance Actions";
			this.Load += new System.EventHandler(this.FormPMAs_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvPMAs)).EndInit();
			this.pnlPMAs_Control.ResumeLayout(false);
			this.pnlPMAs.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvPMAs;
		private System.Windows.Forms.Panel pnlPMAs_Control;
		private System.Windows.Forms.Panel pnlPMAs;
		private BrightIdeasSoftware.OLVColumn olvColDescription;
		private System.Windows.Forms.Button btnPMA_Remove;
		private System.Windows.Forms.Button btnPMA_Add;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnPMA_Edit;
	}
}