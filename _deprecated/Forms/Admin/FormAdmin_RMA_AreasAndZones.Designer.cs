namespace SDB.Forms.Admin
{
	partial class FormAdmin_Rma_Zones
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
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlZones = new System.Windows.Forms.Panel();
			this.olvRmaZones = new BrightIdeasSoftware.ObjectListView();
			this.olcZone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcDefault = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlZoneControl = new System.Windows.Forms.Panel();
			this.btnRmaZone_SetDefault = new System.Windows.Forms.Button();
			this.btnRmaZone_PrintLabel = new System.Windows.Forms.Button();
			this.btnRmaZone_Edit = new System.Windows.Forms.Button();
			this.btnRmaZone_Remove = new System.Windows.Forms.Button();
			this.btnRmaZone_Add = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pnlAreas = new System.Windows.Forms.Panel();
			this.olvRmaAreas = new BrightIdeasSoftware.ObjectListView();
			this.olcAreaName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlAreaControl = new System.Windows.Forms.Panel();
			this.btnRMAArea_Edit = new System.Windows.Forms.Button();
			this.btnRMAArea_Remove = new System.Windows.Forms.Button();
			this.btnRMAArea_Add = new System.Windows.Forms.Button();
			this.lblAreaInfo = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlZones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRmaZones)).BeginInit();
			this.pnlZoneControl.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlTop.SuspendLayout();
			this.pnlAreas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRmaAreas)).BeginInit();
			this.pnlAreaControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(657, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pnlZones
			// 
			this.pnlZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlZones.Controls.Add(this.olvRmaZones);
			this.pnlZones.Controls.Add(this.pnlZoneControl);
			this.pnlZones.Controls.Add(this.label1);
			this.pnlZones.Location = new System.Drawing.Point(334, 12);
			this.pnlZones.Name = "pnlZones";
			this.pnlZones.Size = new System.Drawing.Size(398, 413);
			this.pnlZones.TabIndex = 5;
			// 
			// olvRmaZones
			// 
			this.olvRmaZones.AllColumns.Add(this.olcZone);
			this.olvRmaZones.AllColumns.Add(this.olcDefault);
			this.olvRmaZones.CellEditTabChangesRows = true;
			this.olvRmaZones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcZone,
            this.olcDefault});
			this.olvRmaZones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRmaZones.EmptyListMsg = "No RMA zones defined.";
			this.olvRmaZones.FullRowSelect = true;
			this.olvRmaZones.GridLines = true;
			this.olvRmaZones.HasCollapsibleGroups = false;
			this.olvRmaZones.HideSelection = false;
			this.olvRmaZones.Location = new System.Drawing.Point(0, 43);
			this.olvRmaZones.Name = "olvRmaZones";
			this.olvRmaZones.SelectAllOnControlA = false;
			this.olvRmaZones.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRmaZones.ShowCommandMenuOnRightClick = true;
			this.olvRmaZones.ShowGroups = false;
			this.olvRmaZones.ShowItemCountOnGroups = true;
			this.olvRmaZones.Size = new System.Drawing.Size(398, 370);
			this.olvRmaZones.SortGroupItemsByPrimaryColumn = false;
			this.olvRmaZones.TabIndex = 1;
			this.olvRmaZones.UseCompatibleStateImageBehavior = false;
			this.olvRmaZones.View = System.Windows.Forms.View.Details;
			this.olvRmaZones.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvRmaZones_FormatRow);
			this.olvRmaZones.SelectedIndexChanged += new System.EventHandler(this.olvRmaZones_SelectedIndexChanged);
			this.olvRmaZones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvRmaZones_MouseDoubleClick);
			// 
			// olcZone
			// 
			this.olcZone.AspectName = "ZoneName";
			this.olcZone.CellPadding = null;
			this.olcZone.FillsFreeSpace = true;
			this.olcZone.Groupable = false;
			this.olcZone.Hideable = false;
			this.olcZone.IsEditable = false;
			this.olcZone.Text = "Zone";
			this.olcZone.Width = 300;
			// 
			// olcDefault
			// 
			this.olcDefault.AspectName = "IsDefault";
			this.olcDefault.CellPadding = null;
			this.olcDefault.Text = "Default";
			// 
			// pnlZoneControl
			// 
			this.pnlZoneControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlZoneControl.Controls.Add(this.btnRmaZone_SetDefault);
			this.pnlZoneControl.Controls.Add(this.btnRmaZone_PrintLabel);
			this.pnlZoneControl.Controls.Add(this.btnRmaZone_Edit);
			this.pnlZoneControl.Controls.Add(this.btnRmaZone_Remove);
			this.pnlZoneControl.Controls.Add(this.btnRmaZone_Add);
			this.pnlZoneControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlZoneControl.Location = new System.Drawing.Point(0, 13);
			this.pnlZoneControl.Name = "pnlZoneControl";
			this.pnlZoneControl.Size = new System.Drawing.Size(398, 30);
			this.pnlZoneControl.TabIndex = 6;
			// 
			// btnRmaZone_SetDefault
			// 
			this.btnRmaZone_SetDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRmaZone_SetDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnRmaZone_SetDefault.Location = new System.Drawing.Point(245, 4);
			this.btnRmaZone_SetDefault.Name = "btnRmaZone_SetDefault";
			this.btnRmaZone_SetDefault.Size = new System.Drawing.Size(70, 23);
			this.btnRmaZone_SetDefault.TabIndex = 4;
			this.btnRmaZone_SetDefault.Text = "Set Default";
			this.btnRmaZone_SetDefault.UseVisualStyleBackColor = false;
			this.btnRmaZone_SetDefault.Click += new System.EventHandler(this.btnRmaZone_SetDefault_Click);
			// 
			// btnRmaZone_PrintLabel
			// 
			this.btnRmaZone_PrintLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRmaZone_PrintLabel.BackColor = System.Drawing.SystemColors.Control;
			this.btnRmaZone_PrintLabel.Location = new System.Drawing.Point(321, 4);
			this.btnRmaZone_PrintLabel.Name = "btnRmaZone_PrintLabel";
			this.btnRmaZone_PrintLabel.Size = new System.Drawing.Size(74, 23);
			this.btnRmaZone_PrintLabel.TabIndex = 3;
			this.btnRmaZone_PrintLabel.Text = "Print Label";
			this.toolTip1.SetToolTip(this.btnRmaZone_PrintLabel, "Print labels for selected zones.");
			this.btnRmaZone_PrintLabel.UseVisualStyleBackColor = false;
			this.btnRmaZone_PrintLabel.Click += new System.EventHandler(this.btnRmaZone_PrintLabel_Click);
			// 
			// btnRmaZone_Edit
			// 
			this.btnRmaZone_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnRmaZone_Edit.Location = new System.Drawing.Point(159, 4);
			this.btnRmaZone_Edit.Name = "btnRmaZone_Edit";
			this.btnRmaZone_Edit.Size = new System.Drawing.Size(70, 23);
			this.btnRmaZone_Edit.TabIndex = 2;
			this.btnRmaZone_Edit.Text = "Edit";
			this.btnRmaZone_Edit.UseVisualStyleBackColor = false;
			this.btnRmaZone_Edit.Click += new System.EventHandler(this.btnRmaZone_Edit_Click);
			// 
			// btnRmaZone_Remove
			// 
			this.btnRmaZone_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRmaZone_Remove.Location = new System.Drawing.Point(81, 4);
			this.btnRmaZone_Remove.Name = "btnRmaZone_Remove";
			this.btnRmaZone_Remove.Size = new System.Drawing.Size(70, 23);
			this.btnRmaZone_Remove.TabIndex = 1;
			this.btnRmaZone_Remove.Text = "Remove";
			this.btnRmaZone_Remove.UseVisualStyleBackColor = false;
			this.btnRmaZone_Remove.Click += new System.EventHandler(this.btnRMAZone_Remove_Click);
			// 
			// btnRmaZone_Add
			// 
			this.btnRmaZone_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRmaZone_Add.Location = new System.Drawing.Point(3, 4);
			this.btnRmaZone_Add.Name = "btnRmaZone_Add";
			this.btnRmaZone_Add.Size = new System.Drawing.Size(70, 23);
			this.btnRmaZone_Add.TabIndex = 0;
			this.btnRmaZone_Add.Text = "Add";
			this.btnRmaZone_Add.UseVisualStyleBackColor = false;
			this.btnRmaZone_Add.Click += new System.EventHandler(this.btnRMAZone_Add_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(398, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zones are specific locations within an area.";
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.btnClose);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 436);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(744, 30);
			this.pnlBottom.TabIndex = 6;
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.pnlAreas);
			this.pnlTop.Controls.Add(this.pnlZones);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(744, 436);
			this.pnlTop.TabIndex = 0;
			// 
			// pnlAreas
			// 
			this.pnlAreas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlAreas.Controls.Add(this.olvRmaAreas);
			this.pnlAreas.Controls.Add(this.pnlAreaControl);
			this.pnlAreas.Controls.Add(this.lblAreaInfo);
			this.pnlAreas.Location = new System.Drawing.Point(12, 12);
			this.pnlAreas.Name = "pnlAreas";
			this.pnlAreas.Size = new System.Drawing.Size(316, 413);
			this.pnlAreas.TabIndex = 6;
			// 
			// olvRmaAreas
			// 
			this.olvRmaAreas.AllColumns.Add(this.olcAreaName);
			this.olvRmaAreas.CellEditTabChangesRows = true;
			this.olvRmaAreas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcAreaName});
			this.olvRmaAreas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRmaAreas.EmptyListMsg = "No RMA zones defined.";
			this.olvRmaAreas.FullRowSelect = true;
			this.olvRmaAreas.GridLines = true;
			this.olvRmaAreas.HasCollapsibleGroups = false;
			this.olvRmaAreas.HideSelection = false;
			this.olvRmaAreas.Location = new System.Drawing.Point(0, 43);
			this.olvRmaAreas.MultiSelect = false;
			this.olvRmaAreas.Name = "olvRmaAreas";
			this.olvRmaAreas.SelectAllOnControlA = false;
			this.olvRmaAreas.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRmaAreas.ShowCommandMenuOnRightClick = true;
			this.olvRmaAreas.ShowGroups = false;
			this.olvRmaAreas.ShowItemCountOnGroups = true;
			this.olvRmaAreas.Size = new System.Drawing.Size(316, 370);
			this.olvRmaAreas.SortGroupItemsByPrimaryColumn = false;
			this.olvRmaAreas.TabIndex = 1;
			this.olvRmaAreas.UseCompatibleStateImageBehavior = false;
			this.olvRmaAreas.View = System.Windows.Forms.View.Details;
			this.olvRmaAreas.SelectedIndexChanged += new System.EventHandler(this.olvRMAAreas_SelectedIndexChanged);
			this.olvRmaAreas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvRmaAreas_MouseDoubleClick);
			// 
			// olcAreaName
			// 
			this.olcAreaName.AspectName = "AreaName";
			this.olcAreaName.CellPadding = null;
			this.olcAreaName.FillsFreeSpace = true;
			this.olcAreaName.Groupable = false;
			this.olcAreaName.Hideable = false;
			this.olcAreaName.IsEditable = false;
			this.olcAreaName.Text = "Area";
			this.olcAreaName.Width = 300;
			// 
			// pnlAreaControl
			// 
			this.pnlAreaControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlAreaControl.Controls.Add(this.btnRMAArea_Edit);
			this.pnlAreaControl.Controls.Add(this.btnRMAArea_Remove);
			this.pnlAreaControl.Controls.Add(this.btnRMAArea_Add);
			this.pnlAreaControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlAreaControl.Location = new System.Drawing.Point(0, 13);
			this.pnlAreaControl.Name = "pnlAreaControl";
			this.pnlAreaControl.Size = new System.Drawing.Size(316, 30);
			this.pnlAreaControl.TabIndex = 6;
			// 
			// btnRMAArea_Edit
			// 
			this.btnRMAArea_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnRMAArea_Edit.Location = new System.Drawing.Point(159, 4);
			this.btnRMAArea_Edit.Name = "btnRMAArea_Edit";
			this.btnRMAArea_Edit.Size = new System.Drawing.Size(70, 23);
			this.btnRMAArea_Edit.TabIndex = 2;
			this.btnRMAArea_Edit.Text = "Edit";
			this.btnRMAArea_Edit.UseVisualStyleBackColor = false;
			this.btnRMAArea_Edit.Click += new System.EventHandler(this.btnRMAArea_Edit_Click);
			// 
			// btnRMAArea_Remove
			// 
			this.btnRMAArea_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRMAArea_Remove.Location = new System.Drawing.Point(81, 4);
			this.btnRMAArea_Remove.Name = "btnRMAArea_Remove";
			this.btnRMAArea_Remove.Size = new System.Drawing.Size(70, 23);
			this.btnRMAArea_Remove.TabIndex = 1;
			this.btnRMAArea_Remove.Text = "Remove";
			this.btnRMAArea_Remove.UseVisualStyleBackColor = false;
			this.btnRMAArea_Remove.Click += new System.EventHandler(this.btnRMAArea_Remove_Click);
			// 
			// btnRMAArea_Add
			// 
			this.btnRMAArea_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRMAArea_Add.Location = new System.Drawing.Point(3, 4);
			this.btnRMAArea_Add.Name = "btnRMAArea_Add";
			this.btnRMAArea_Add.Size = new System.Drawing.Size(70, 23);
			this.btnRMAArea_Add.TabIndex = 0;
			this.btnRMAArea_Add.Text = "Add";
			this.btnRMAArea_Add.UseVisualStyleBackColor = false;
			this.btnRMAArea_Add.Click += new System.EventHandler(this.btnRMAArea_Add_Click);
			// 
			// lblAreaInfo
			// 
			this.lblAreaInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblAreaInfo.Location = new System.Drawing.Point(0, 0);
			this.lblAreaInfo.Name = "lblAreaInfo";
			this.lblAreaInfo.Size = new System.Drawing.Size(316, 13);
			this.lblAreaInfo.TabIndex = 0;
			this.lblAreaInfo.Text = "Areas are sections of the RMA storage and repair facility.";
			// 
			// FormAdmin_Rma_Zones
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(744, 466);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximumSize = new System.Drawing.Size(760, 1024);
			this.MinimumSize = new System.Drawing.Size(760, 300);
			this.Name = "FormAdmin_Rma_Zones";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Areas and Zones";
			this.Load += new System.EventHandler(this.FormAdmin_Rma_Zones_Load);
			this.pnlZones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRmaZones)).EndInit();
			this.pnlZoneControl.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlTop.ResumeLayout(false);
			this.pnlAreas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRmaAreas)).EndInit();
			this.pnlAreaControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel pnlZones;
		private System.Windows.Forms.Panel pnlZoneControl;
		private System.Windows.Forms.Button btnRmaZone_Remove;
		private System.Windows.Forms.Button btnRmaZone_Add;
		private System.Windows.Forms.Button btnRmaZone_Edit;
		private BrightIdeasSoftware.ObjectListView olvRmaZones;
		private BrightIdeasSoftware.OLVColumn olcZone;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlAreas;
		private BrightIdeasSoftware.ObjectListView olvRmaAreas;
		private BrightIdeasSoftware.OLVColumn olcAreaName;
		private System.Windows.Forms.Panel pnlAreaControl;
		private System.Windows.Forms.Button btnRMAArea_Edit;
		private System.Windows.Forms.Button btnRMAArea_Remove;
		private System.Windows.Forms.Button btnRMAArea_Add;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAreaInfo;
		private System.Windows.Forms.Button btnRmaZone_PrintLabel;
		private System.Windows.Forms.ToolTip toolTip1;
		private BrightIdeasSoftware.OLVColumn olcDefault;
		private System.Windows.Forms.Button btnRmaZone_SetDefault;
	}
}