namespace SDB.Forms.Admin
{
	partial class FormAdmin_ShipmentMethods
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
			this.grpSymptoms = new System.Windows.Forms.GroupBox();
			this.olvShipmentMethods = new BrightIdeasSoftware.ObjectListView();
			this.olcDisplayIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAbbreviation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcDefault = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlSymptoms_Control = new System.Windows.Forms.Panel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.grpSymptoms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvShipmentMethods)).BeginInit();
			this.pnlSymptoms_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpSymptoms
			// 
			this.grpSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpSymptoms.Controls.Add(this.olvShipmentMethods);
			this.grpSymptoms.Controls.Add(this.pnlSymptoms_Control);
			this.grpSymptoms.Location = new System.Drawing.Point(12, 12);
			this.grpSymptoms.Name = "grpSymptoms";
			this.grpSymptoms.Size = new System.Drawing.Size(461, 423);
			this.grpSymptoms.TabIndex = 0;
			this.grpSymptoms.TabStop = false;
			this.grpSymptoms.Text = "Shipment Methods";
			// 
			// olvShipmentMethods
			// 
			this.olvShipmentMethods.AllColumns.Add(this.olcDisplayIndex);
			this.olvShipmentMethods.AllColumns.Add(this.olcDescription);
			this.olvShipmentMethods.AllColumns.Add(this.olcAbbreviation);
			this.olvShipmentMethods.AllColumns.Add(this.olcDefault);
			this.olvShipmentMethods.CellEditUseWholeCell = false;
			this.olvShipmentMethods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcDisplayIndex,
            this.olcDescription,
            this.olcAbbreviation,
            this.olcDefault});
			this.olvShipmentMethods.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvShipmentMethods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvShipmentMethods.EmptyListMsg = "No Shipment Methods Defined";
			this.olvShipmentMethods.FullRowSelect = true;
			this.olvShipmentMethods.GridLines = true;
			this.olvShipmentMethods.HideSelection = false;
			this.olvShipmentMethods.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvShipmentMethods.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvShipmentMethods.Location = new System.Drawing.Point(3, 46);
			this.olvShipmentMethods.MultiSelect = false;
			this.olvShipmentMethods.Name = "olvShipmentMethods";
			this.olvShipmentMethods.SelectAllOnControlA = false;
			this.olvShipmentMethods.ShowGroups = false;
			this.olvShipmentMethods.Size = new System.Drawing.Size(455, 374);
			this.olvShipmentMethods.TabIndex = 1;
			this.olvShipmentMethods.UseCompatibleStateImageBehavior = false;
			this.olvShipmentMethods.View = System.Windows.Forms.View.Details;
			this.olvShipmentMethods.SelectedIndexChanged += new System.EventHandler(this.olvShipmentMethods_SelectedIndexChanged);
			this.olvShipmentMethods.DoubleClick += new System.EventHandler(this.olvShipmentMethods_DoubleClick);
			// 
			// olcDisplayIndex
			// 
			this.olcDisplayIndex.AspectName = "DisplayIndex";
			this.olcDisplayIndex.Groupable = false;
			this.olcDisplayIndex.Text = "#";
			this.olcDisplayIndex.Width = 25;
			// 
			// olcDescription
			// 
			this.olcDescription.AspectName = "Description";
			this.olcDescription.FillsFreeSpace = true;
			this.olcDescription.Groupable = false;
			this.olcDescription.Text = "Shipment Method";
			this.olcDescription.Width = 240;
			// 
			// olcAbbreviation
			// 
			this.olcAbbreviation.AspectName = "Abbreviation";
			this.olcAbbreviation.Text = "Abv.";
			this.olcAbbreviation.Width = 80;
			// 
			// olcDefault
			// 
			this.olcDefault.AspectName = "Default";
			this.olcDefault.CheckBoxes = true;
			this.olcDefault.Groupable = false;
			this.olcDefault.Sortable = false;
			this.olcDefault.Text = "Default";
			// 
			// pnlSymptoms_Control
			// 
			this.pnlSymptoms_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlSymptoms_Control.Controls.Add(this.btnEdit);
			this.pnlSymptoms_Control.Controls.Add(this.btnMoveUp);
			this.pnlSymptoms_Control.Controls.Add(this.btnDefault);
			this.pnlSymptoms_Control.Controls.Add(this.btnRemove);
			this.pnlSymptoms_Control.Controls.Add(this.btnAdd);
			this.pnlSymptoms_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSymptoms_Control.Location = new System.Drawing.Point(3, 16);
			this.pnlSymptoms_Control.Name = "pnlSymptoms_Control";
			this.pnlSymptoms_Control.Size = new System.Drawing.Size(455, 30);
			this.pnlSymptoms_Control.TabIndex = 0;
			// 
			// btnEdit
			// 
			this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
			this.btnEdit.Location = new System.Drawing.Point(177, 4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(80, 23);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnMoveUp.Location = new System.Drawing.Point(372, 4);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(80, 23);
			this.btnMoveUp.TabIndex = 3;
			this.btnMoveUp.Text = "Move Up";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnDefault
			// 
			this.btnDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnDefault.Location = new System.Drawing.Point(284, 4);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(80, 23);
			this.btnDefault.TabIndex = 2;
			this.btnDefault.Text = "Set Default";
			this.btnDefault.UseVisualStyleBackColor = false;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRemove.Location = new System.Drawing.Point(91, 4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(80, 23);
			this.btnRemove.TabIndex = 1;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnAdd.Location = new System.Drawing.Point(3, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(398, 441);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormAdmin_ShipmentMethods
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(484, 476);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.grpSymptoms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 2000);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "FormAdmin_ShipmentMethods";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Shipment Methods";
			this.Load += new System.EventHandler(this.FormShipmentMethods_Load);
			this.grpSymptoms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvShipmentMethods)).EndInit();
			this.pnlSymptoms_Control.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpSymptoms;
		private BrightIdeasSoftware.ObjectListView olvShipmentMethods;
		private System.Windows.Forms.Panel pnlSymptoms_Control;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private BrightIdeasSoftware.OLVColumn olcDisplayIndex;
		private BrightIdeasSoftware.OLVColumn olcDescription;
		private BrightIdeasSoftware.OLVColumn olcDefault;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnDefault;
		private BrightIdeasSoftware.OLVColumn olcAbbreviation;
		private System.Windows.Forms.Button btnEdit;
	}
}