namespace SDB.Forms.Admin
{
	partial class FormAdmin_SymptomsSolutions
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
			this.pnlSymptoms = new System.Windows.Forms.Panel();
			this.olvSymptoms = new BrightIdeasSoftware.ObjectListView();
			this.olcSymptom_Symptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcSymptom_IsVisible = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlSymptoms_Control = new System.Windows.Forms.Panel();
			this.btnSymptoms_Edit = new System.Windows.Forms.Button();
			this.btnSymptoms_Remove = new System.Windows.Forms.Button();
			this.btnSymptoms_Add = new System.Windows.Forms.Button();
			this.lblOwnershipInformation = new System.Windows.Forms.Label();
			this.pnlSolutions = new System.Windows.Forms.Panel();
			this.olvSolutions = new BrightIdeasSoftware.ObjectListView();
			this.olvColSolutions_Solution = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColSolutions_RequiresParts = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlSolutions_Control = new System.Windows.Forms.Panel();
			this.btnSolutions_Edit = new System.Windows.Forms.Button();
			this.btnSolutions_Remove = new System.Windows.Forms.Button();
			this.btnSolutions_Add = new System.Windows.Forms.Button();
			this.lblSolutions = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlSymptoms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).BeginInit();
			this.pnlSymptoms_Control.SuspendLayout();
			this.pnlSolutions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvSolutions)).BeginInit();
			this.pnlSolutions_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSymptoms
			// 
			this.pnlSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlSymptoms.Controls.Add(this.olvSymptoms);
			this.pnlSymptoms.Controls.Add(this.pnlSymptoms_Control);
			this.pnlSymptoms.Controls.Add(this.lblOwnershipInformation);
			this.pnlSymptoms.Location = new System.Drawing.Point(12, 12);
			this.pnlSymptoms.Name = "pnlSymptoms";
			this.pnlSymptoms.Size = new System.Drawing.Size(300, 613);
			this.pnlSymptoms.TabIndex = 0;
			this.pnlSymptoms.Text = "Symptoms";
			// 
			// olvSymptoms
			// 
			this.olvSymptoms.AllColumns.Add(this.olcSymptom_Symptom);
			this.olvSymptoms.AllColumns.Add(this.olcSymptom_IsVisible);
			this.olvSymptoms.CellEditUseWholeCell = false;
			this.olvSymptoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcSymptom_Symptom,
            this.olcSymptom_IsVisible});
			this.olvSymptoms.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSymptoms.EmptyListMsg = "No Symptoms Defined";
			this.olvSymptoms.FullRowSelect = true;
			this.olvSymptoms.GridLines = true;
			this.olvSymptoms.HideSelection = false;
			this.olvSymptoms.Location = new System.Drawing.Point(0, 47);
			this.olvSymptoms.MultiSelect = false;
			this.olvSymptoms.Name = "olvSymptoms";
			this.olvSymptoms.SelectAllOnControlA = false;
			this.olvSymptoms.ShowGroups = false;
			this.olvSymptoms.Size = new System.Drawing.Size(300, 566);
			this.olvSymptoms.TabIndex = 2;
			this.olvSymptoms.UseCompatibleStateImageBehavior = false;
			this.olvSymptoms.View = System.Windows.Forms.View.Details;
			this.olvSymptoms.DoubleClick += new System.EventHandler(this.olvSymptoms_DoubleClick);
			// 
			// olcSymptom_Symptom
			// 
			this.olcSymptom_Symptom.AspectName = "Symptom";
			this.olcSymptom_Symptom.FillsFreeSpace = true;
			this.olcSymptom_Symptom.Groupable = false;
			this.olcSymptom_Symptom.IsEditable = false;
			this.olcSymptom_Symptom.Text = "Symptom";
			this.olcSymptom_Symptom.Width = 200;
			// 
			// olcSymptom_IsVisible
			// 
			this.olcSymptom_IsVisible.AspectName = "IsVisible";
			this.olcSymptom_IsVisible.CheckBoxes = true;
			this.olcSymptom_IsVisible.IsEditable = false;
			this.olcSymptom_IsVisible.Text = "Is Visible";
			this.olcSymptom_IsVisible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcSymptom_IsVisible.ToolTipText = "Is visible on camera check";
			this.olcSymptom_IsVisible.Width = 90;
			// 
			// pnlSymptoms_Control
			// 
			this.pnlSymptoms_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlSymptoms_Control.Controls.Add(this.btnSymptoms_Edit);
			this.pnlSymptoms_Control.Controls.Add(this.btnSymptoms_Remove);
			this.pnlSymptoms_Control.Controls.Add(this.btnSymptoms_Add);
			this.pnlSymptoms_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSymptoms_Control.Location = new System.Drawing.Point(0, 17);
			this.pnlSymptoms_Control.Name = "pnlSymptoms_Control";
			this.pnlSymptoms_Control.Size = new System.Drawing.Size(300, 30);
			this.pnlSymptoms_Control.TabIndex = 1;
			// 
			// btnSymptoms_Edit
			// 
			this.btnSymptoms_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnSymptoms_Edit.Location = new System.Drawing.Point(179, 4);
			this.btnSymptoms_Edit.Name = "btnSymptoms_Edit";
			this.btnSymptoms_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnSymptoms_Edit.TabIndex = 2;
			this.btnSymptoms_Edit.Text = "Edit";
			this.toolTip1.SetToolTip(this.btnSymptoms_Edit, "Edit selected Symptom");
			this.btnSymptoms_Edit.UseVisualStyleBackColor = false;
			this.btnSymptoms_Edit.Click += new System.EventHandler(this.btnSymptoms_Edit_Click);
			// 
			// btnSymptoms_Remove
			// 
			this.btnSymptoms_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnSymptoms_Remove.Location = new System.Drawing.Point(91, 4);
			this.btnSymptoms_Remove.Name = "btnSymptoms_Remove";
			this.btnSymptoms_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnSymptoms_Remove.TabIndex = 1;
			this.btnSymptoms_Remove.Text = "Remove";
			this.toolTip1.SetToolTip(this.btnSymptoms_Remove, "Remove selected Symptom");
			this.btnSymptoms_Remove.UseVisualStyleBackColor = false;
			this.btnSymptoms_Remove.Click += new System.EventHandler(this.btnSymptoms_Remove_Click);
			// 
			// btnSymptoms_Add
			// 
			this.btnSymptoms_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSymptoms_Add.Location = new System.Drawing.Point(3, 4);
			this.btnSymptoms_Add.Name = "btnSymptoms_Add";
			this.btnSymptoms_Add.Size = new System.Drawing.Size(80, 23);
			this.btnSymptoms_Add.TabIndex = 0;
			this.btnSymptoms_Add.Text = "Add";
			this.toolTip1.SetToolTip(this.btnSymptoms_Add, "Add Symptom");
			this.btnSymptoms_Add.UseVisualStyleBackColor = false;
			this.btnSymptoms_Add.Click += new System.EventHandler(this.btnSymptoms_Add_Click);
			// 
			// lblOwnershipInformation
			// 
			this.lblOwnershipInformation.AutoEllipsis = true;
			this.lblOwnershipInformation.BackColor = System.Drawing.Color.Black;
			this.lblOwnershipInformation.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblOwnershipInformation.ForeColor = System.Drawing.Color.White;
			this.lblOwnershipInformation.Location = new System.Drawing.Point(0, 0);
			this.lblOwnershipInformation.Name = "lblOwnershipInformation";
			this.lblOwnershipInformation.Size = new System.Drawing.Size(300, 17);
			this.lblOwnershipInformation.TabIndex = 0;
			this.lblOwnershipInformation.Text = "Symptoms";
			this.lblOwnershipInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlSolutions
			// 
			this.pnlSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSolutions.Controls.Add(this.olvSolutions);
			this.pnlSolutions.Controls.Add(this.pnlSolutions_Control);
			this.pnlSolutions.Controls.Add(this.lblSolutions);
			this.pnlSolutions.Location = new System.Drawing.Point(323, 12);
			this.pnlSolutions.Name = "pnlSolutions";
			this.pnlSolutions.Size = new System.Drawing.Size(300, 613);
			this.pnlSolutions.TabIndex = 1;
			this.pnlSolutions.Text = "Solutions";
			// 
			// olvSolutions
			// 
			this.olvSolutions.AllColumns.Add(this.olvColSolutions_Solution);
			this.olvSolutions.AllColumns.Add(this.olvColSolutions_RequiresParts);
			this.olvSolutions.CellEditUseWholeCell = false;
			this.olvSolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSolutions_Solution,
            this.olvColSolutions_RequiresParts});
			this.olvSolutions.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSolutions.EmptyListMsg = "No Solutions Defined";
			this.olvSolutions.FullRowSelect = true;
			this.olvSolutions.GridLines = true;
			this.olvSolutions.HideSelection = false;
			this.olvSolutions.Location = new System.Drawing.Point(0, 47);
			this.olvSolutions.MultiSelect = false;
			this.olvSolutions.Name = "olvSolutions";
			this.olvSolutions.SelectAllOnControlA = false;
			this.olvSolutions.ShowGroups = false;
			this.olvSolutions.Size = new System.Drawing.Size(300, 566);
			this.olvSolutions.TabIndex = 2;
			this.olvSolutions.UseCompatibleStateImageBehavior = false;
			this.olvSolutions.UseOverlays = false;
			this.olvSolutions.View = System.Windows.Forms.View.Details;
			this.olvSolutions.DoubleClick += new System.EventHandler(this.olvSolutions_DoubleClick);
			// 
			// olvColSolutions_Solution
			// 
			this.olvColSolutions_Solution.AspectName = "Solution";
			this.olvColSolutions_Solution.FillsFreeSpace = true;
			this.olvColSolutions_Solution.Groupable = false;
			this.olvColSolutions_Solution.IsEditable = false;
			this.olvColSolutions_Solution.Text = "Solution";
			this.olvColSolutions_Solution.Width = 200;
			// 
			// olvColSolutions_RequiresParts
			// 
			this.olvColSolutions_RequiresParts.AspectName = "RequiresParts";
			this.olvColSolutions_RequiresParts.CheckBoxes = true;
			this.olvColSolutions_RequiresParts.Groupable = false;
			this.olvColSolutions_RequiresParts.IsEditable = false;
			this.olvColSolutions_RequiresParts.Text = "Requires Parts";
			this.olvColSolutions_RequiresParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olvColSolutions_RequiresParts.Width = 90;
			// 
			// pnlSolutions_Control
			// 
			this.pnlSolutions_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Edit);
			this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Remove);
			this.pnlSolutions_Control.Controls.Add(this.btnSolutions_Add);
			this.pnlSolutions_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSolutions_Control.Location = new System.Drawing.Point(0, 17);
			this.pnlSolutions_Control.Name = "pnlSolutions_Control";
			this.pnlSolutions_Control.Size = new System.Drawing.Size(300, 30);
			this.pnlSolutions_Control.TabIndex = 1;
			// 
			// btnSolutions_Edit
			// 
			this.btnSolutions_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnSolutions_Edit.Location = new System.Drawing.Point(179, 4);
			this.btnSolutions_Edit.Name = "btnSolutions_Edit";
			this.btnSolutions_Edit.Size = new System.Drawing.Size(80, 23);
			this.btnSolutions_Edit.TabIndex = 2;
			this.btnSolutions_Edit.Text = "Edit";
			this.toolTip1.SetToolTip(this.btnSolutions_Edit, "Edit selected Solution");
			this.btnSolutions_Edit.UseVisualStyleBackColor = false;
			this.btnSolutions_Edit.Click += new System.EventHandler(this.btnSolutions_Edit_Click);
			// 
			// btnSolutions_Remove
			// 
			this.btnSolutions_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnSolutions_Remove.Location = new System.Drawing.Point(91, 4);
			this.btnSolutions_Remove.Name = "btnSolutions_Remove";
			this.btnSolutions_Remove.Size = new System.Drawing.Size(80, 23);
			this.btnSolutions_Remove.TabIndex = 1;
			this.btnSolutions_Remove.Text = "Remove";
			this.toolTip1.SetToolTip(this.btnSolutions_Remove, "Remove selected Solution");
			this.btnSolutions_Remove.UseVisualStyleBackColor = false;
			this.btnSolutions_Remove.Click += new System.EventHandler(this.btnSolutions_Remove_Click);
			// 
			// btnSolutions_Add
			// 
			this.btnSolutions_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSolutions_Add.Location = new System.Drawing.Point(3, 4);
			this.btnSolutions_Add.Name = "btnSolutions_Add";
			this.btnSolutions_Add.Size = new System.Drawing.Size(80, 23);
			this.btnSolutions_Add.TabIndex = 0;
			this.btnSolutions_Add.Text = "Add";
			this.toolTip1.SetToolTip(this.btnSolutions_Add, "Add Solution");
			this.btnSolutions_Add.UseVisualStyleBackColor = false;
			this.btnSolutions_Add.Click += new System.EventHandler(this.btnSolutions_Add_Click);
			// 
			// lblSolutions
			// 
			this.lblSolutions.AutoEllipsis = true;
			this.lblSolutions.BackColor = System.Drawing.Color.Black;
			this.lblSolutions.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblSolutions.ForeColor = System.Drawing.Color.White;
			this.lblSolutions.Location = new System.Drawing.Point(0, 0);
			this.lblSolutions.Name = "lblSolutions";
			this.lblSolutions.Size = new System.Drawing.Size(300, 17);
			this.lblSolutions.TabIndex = 0;
			this.lblSolutions.Text = "Solutions";
			this.lblSolutions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(547, 631);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormAdmin_SymptomsSolutions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(634, 666);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlSymptoms);
			this.Controls.Add(this.pnlSolutions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(650, 300);
			this.Name = "FormAdmin_SymptomsSolutions";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Symptoms and Solutions";
			this.Load += new System.EventHandler(this.FormSymptomsSolutions_Load);
			this.ResizeEnd += new System.EventHandler(this.FormAdmin_SymptomsSolutions_ResizeEnd);
			this.pnlSymptoms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).EndInit();
			this.pnlSymptoms_Control.ResumeLayout(false);
			this.pnlSolutions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvSolutions)).EndInit();
			this.pnlSolutions_Control.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlSymptoms;
		private BrightIdeasSoftware.ObjectListView olvSymptoms;
		private System.Windows.Forms.Panel pnlSymptoms_Control;
		private System.Windows.Forms.Button btnSymptoms_Remove;
		private System.Windows.Forms.Button btnSymptoms_Add;
		private System.Windows.Forms.Panel pnlSolutions;
		private BrightIdeasSoftware.ObjectListView olvSolutions;
		private System.Windows.Forms.Panel pnlSolutions_Control;
		private System.Windows.Forms.Button btnSolutions_Remove;
		private System.Windows.Forms.Button btnSolutions_Add;
		private System.Windows.Forms.Button btnClose;
		private BrightIdeasSoftware.OLVColumn olcSymptom_Symptom;
		private BrightIdeasSoftware.OLVColumn olvColSolutions_Solution;
		private BrightIdeasSoftware.OLVColumn olvColSolutions_RequiresParts;
		private BrightIdeasSoftware.OLVColumn olcSymptom_IsVisible;
		private System.Windows.Forms.Label lblOwnershipInformation;
		private System.Windows.Forms.Label lblSolutions;
		private System.Windows.Forms.Button btnSymptoms_Edit;
		private System.Windows.Forms.Button btnSolutions_Edit;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}