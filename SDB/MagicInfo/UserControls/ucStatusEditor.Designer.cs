namespace SDB.MagicInfo.UserControls
{
    partial class ucStatusEditor
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
            this.olvStatus = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // olvStatus
            // 
            this.olvStatus.AllColumns.Add(this.olvColumn1);
            this.olvStatus.AllColumns.Add(this.olvColumn2);
            this.olvStatus.AllColumns.Add(this.olvColumn3);
            this.olvStatus.AllColumns.Add(this.olvColumn4);
            this.olvStatus.AllowColumnReorder = true;
            this.olvStatus.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.olvStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.olvStatus.CausesValidation = false;
            this.olvStatus.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvStatus.CellEditUseWholeCell = false;
            this.olvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.olvStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvStatus.EmptyListMsg = "";
            this.olvStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvStatus.GridLines = true;
            this.olvStatus.Location = new System.Drawing.Point(0, 0);
            this.olvStatus.Name = "olvStatus";
            this.olvStatus.RowHeight = 48;
            this.olvStatus.SelectAllOnControlA = false;
            this.olvStatus.ShowCommandMenuOnRightClick = true;
            this.olvStatus.ShowGroups = false;
            this.olvStatus.ShowItemToolTips = true;
            this.olvStatus.Size = new System.Drawing.Size(546, 273);
            this.olvStatus.SortGroupItemsByPrimaryColumn = false;
            this.olvStatus.TabIndex = 4;
            this.olvStatus.UseAlternatingBackColors = true;
            this.olvStatus.UseCellFormatEvents = true;
            this.olvStatus.UseCompatibleStateImageBehavior = false;
            this.olvStatus.UseFilterIndicator = true;
            this.olvStatus.UseFiltering = true;
            this.olvStatus.View = System.Windows.Forms.View.Details;
            this.olvStatus.CellEditFinished += new BrightIdeasSoftware.CellEditEventHandler(this.olvStatus_CellEditFinished);
            this.olvStatus.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.olvStatus_CellClick);
            this.olvStatus.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvStatus_FormatCell);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ID";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "ID";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Status";
            this.olvColumn2.CellEditUseWholeCell = true;
            this.olvColumn2.Text = "Status";
            this.olvColumn2.Width = 260;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "StatusColor";
            this.olvColumn3.ButtonSizing = BrightIdeasSoftware.OLVColumn.ButtonSizingMode.CellBounds;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Color";
            this.olvColumn3.Width = 160;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Disabled";
            this.olvColumn4.CheckBoxes = true;
            this.olvColumn4.Text = "Disabled";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Width = 62;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucStatusEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.olvStatus);
            this.Name = "ucStatusEditor";
            this.Size = new System.Drawing.Size(546, 302);
            ((System.ComponentModel.ISupportInitialize)(this.olvStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvStatus;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}
