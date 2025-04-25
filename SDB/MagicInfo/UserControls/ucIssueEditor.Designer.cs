namespace SDB.MagicInfo.UserControls
{
    partial class ucIssueEditor
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.olvIssue = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // olvIssue
            // 
            this.olvIssue.AllColumns.Add(this.olvColumn1);
            this.olvIssue.AllColumns.Add(this.olvColumn2);
            this.olvIssue.AllColumns.Add(this.olvColumn3);
            this.olvIssue.AllColumns.Add(this.olvColumn4);
            this.olvIssue.AllowColumnReorder = true;
            this.olvIssue.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.olvIssue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.olvIssue.CausesValidation = false;
            this.olvIssue.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvIssue.CellEditUseWholeCell = false;
            this.olvIssue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.olvIssue.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvIssue.EmptyListMsg = "";
            this.olvIssue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvIssue.GridLines = true;
            this.olvIssue.Location = new System.Drawing.Point(0, 0);
            this.olvIssue.Name = "olvIssue";
            this.olvIssue.RowHeight = 48;
            this.olvIssue.SelectAllOnControlA = false;
            this.olvIssue.ShowCommandMenuOnRightClick = true;
            this.olvIssue.ShowGroups = false;
            this.olvIssue.ShowItemToolTips = true;
            this.olvIssue.Size = new System.Drawing.Size(551, 273);
            this.olvIssue.SortGroupItemsByPrimaryColumn = false;
            this.olvIssue.TabIndex = 12;
            this.olvIssue.UseAlternatingBackColors = true;
            this.olvIssue.UseCellFormatEvents = true;
            this.olvIssue.UseCompatibleStateImageBehavior = false;
            this.olvIssue.UseFilterIndicator = true;
            this.olvIssue.UseFiltering = true;
            this.olvIssue.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ID";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "ID";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Issue";
            this.olvColumn2.CellEditUseWholeCell = true;
            this.olvColumn2.Text = "Issue";
            this.olvColumn2.Width = 364;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Disabled";
            this.olvColumn4.CheckBoxes = true;
            this.olvColumn4.Text = "Disabled";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Width = 62;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "AlertFlag";
            this.olvColumn3.CheckBoxes = true;
            this.olvColumn3.Text = "Alert Flag";
            // 
            // ucIssueEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.olvIssue);
            this.Name = "ucIssueEditor";
            this.Size = new System.Drawing.Size(551, 330);
            ((System.ComponentModel.ISupportInitialize)(this.olvIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private BrightIdeasSoftware.ObjectListView olvIssue;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
    }
}
