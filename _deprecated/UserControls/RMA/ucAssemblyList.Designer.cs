namespace SDB.UserControls.RMA
{
    partial class ucAssemblyList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.olvAssemblyAdd = new BrightIdeasSoftware.ObjectListView();
            this.olvColAssyAdd_Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAssyAdd_FailureType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Assembly List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // olvAssemblyAdd
            // 
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_Description);
            this.olvAssemblyAdd.AllColumns.Add(this.olvColAssyAdd_FailureType);
            this.olvAssemblyAdd.CellEditUseWholeCell = false;
            this.olvAssemblyAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAssyAdd_Description,
            this.olvColAssyAdd_FailureType});
            this.olvAssemblyAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssemblyAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvAssemblyAdd.FullRowSelect = true;
            this.olvAssemblyAdd.GridLines = true;
            this.olvAssemblyAdd.HideSelection = false;
            this.olvAssemblyAdd.Location = new System.Drawing.Point(0, 24);
            this.olvAssemblyAdd.MultiSelect = false;
            this.olvAssemblyAdd.Name = "olvAssemblyAdd";
            this.olvAssemblyAdd.OverlayText.BorderWidth = 6F;
            this.olvAssemblyAdd.OverlayText.Text = "";
            this.olvAssemblyAdd.OverlayText.TextColor = System.Drawing.Color.Empty;
            this.olvAssemblyAdd.ShowGroups = false;
            this.olvAssemblyAdd.Size = new System.Drawing.Size(321, 253);
            this.olvAssemblyAdd.TabIndex = 2;
            this.olvAssemblyAdd.UseCompatibleStateImageBehavior = false;
            this.olvAssemblyAdd.View = System.Windows.Forms.View.Details;
            // 
            // olvColAssyAdd_Description
            // 
            this.olvColAssyAdd_Description.AspectName = "Description";
            this.olvColAssyAdd_Description.Text = "Assembly";
            this.olvColAssyAdd_Description.Width = 170;
            // 
            // olvColAssyAdd_FailureType
            // 
            this.olvColAssyAdd_FailureType.AspectName = "FailureTypeDescription";
            this.olvColAssyAdd_FailureType.Text = "Failure Type";
            this.olvColAssyAdd_FailureType.Width = 145;
            // 
            // ucAssemblyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.olvAssemblyAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucAssemblyList";
            this.Size = new System.Drawing.Size(321, 277);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssemblyAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private BrightIdeasSoftware.ObjectListView olvAssemblyAdd;
        private BrightIdeasSoftware.OLVColumn olvColAssyAdd_Description;
        private BrightIdeasSoftware.OLVColumn olvColAssyAdd_FailureType;
    }
}
