namespace SDB.MagicInfo.UserControls
{
    partial class ucSolutionEditor
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
            this.olvSolution = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // olvSolution
            // 
            this.olvSolution.AllColumns.Add(this.olvColumn1);
            this.olvSolution.AllColumns.Add(this.olvColumn2);
            this.olvSolution.AllColumns.Add(this.olvColumn4);
            this.olvSolution.AllowColumnReorder = true;
            this.olvSolution.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.olvSolution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.olvSolution.CausesValidation = false;
            this.olvSolution.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvSolution.CellEditUseWholeCell = false;
            this.olvSolution.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn4});
            this.olvSolution.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvSolution.EmptyListMsg = "";
            this.olvSolution.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvSolution.GridLines = true;
            this.olvSolution.Location = new System.Drawing.Point(0, 0);
            this.olvSolution.Name = "olvSolution";
            this.olvSolution.RowHeight = 48;
            this.olvSolution.SelectAllOnControlA = false;
            this.olvSolution.ShowCommandMenuOnRightClick = true;
            this.olvSolution.ShowGroups = false;
            this.olvSolution.ShowItemToolTips = true;
            this.olvSolution.Size = new System.Drawing.Size(550, 273);
            this.olvSolution.SortGroupItemsByPrimaryColumn = false;
            this.olvSolution.TabIndex = 8;
            this.olvSolution.UseAlternatingBackColors = true;
            this.olvSolution.UseCellFormatEvents = true;
            this.olvSolution.UseCompatibleStateImageBehavior = false;
            this.olvSolution.UseFilterIndicator = true;
            this.olvSolution.UseFiltering = true;
            this.olvSolution.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "ID";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "ID";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Solution";
            this.olvColumn2.CellEditUseWholeCell = true;
            this.olvColumn2.Text = "Solution";
            this.olvColumn2.Width = 422;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Disabled";
            this.olvColumn4.CheckBoxes = true;
            this.olvColumn4.Text = "Disabled";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn4.Width = 62;
            // 
            // ucSolutionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.olvSolution);
            this.Name = "ucSolutionEditor";
            this.Size = new System.Drawing.Size(550, 310);
            ((System.ComponentModel.ISupportInitialize)(this.olvSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private BrightIdeasSoftware.ObjectListView olvSolution;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}
