namespace SDB.Forms.Admin
{
    partial class FormAdmin_AssetTags
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
            this.pnlCameraTypes_Control = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCameraType_Edit = new System.Windows.Forms.Button();
            this.btnCameraType_Remove = new System.Windows.Forms.Button();
            this.btnCameraType_Add = new System.Windows.Forms.Button();
            this.olvTags = new BrightIdeasSoftware.ObjectListView();
            this.olvColTags = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColDesciption = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlCameraTypes_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTags)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCameraTypes_Control
            // 
            this.pnlCameraTypes_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCameraTypes_Control.Controls.Add(this.btnClose);
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Edit);
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Remove);
            this.pnlCameraTypes_Control.Controls.Add(this.btnCameraType_Add);
            this.pnlCameraTypes_Control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCameraTypes_Control.Location = new System.Drawing.Point(0, 345);
            this.pnlCameraTypes_Control.Name = "pnlCameraTypes_Control";
            this.pnlCameraTypes_Control.Size = new System.Drawing.Size(466, 37);
            this.pnlCameraTypes_Control.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(379, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // olvTags
            // 
            this.olvTags.AllColumns.Add(this.olvColTags);
            this.olvTags.AllColumns.Add(this.olvColDesciption);
            this.olvTags.CellEditUseWholeCell = false;
            this.olvTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColTags,
            this.olvColDesciption});
            this.olvTags.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTags.FullRowSelect = true;
            this.olvTags.GridLines = true;
            this.olvTags.HasCollapsibleGroups = false;
            this.olvTags.Location = new System.Drawing.Point(0, 0);
            this.olvTags.MultiSelect = false;
            this.olvTags.Name = "olvTags";
            this.olvTags.SelectAllOnControlA = false;
            this.olvTags.SelectColumnsOnRightClick = false;
            this.olvTags.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvTags.ShowFilterMenuOnRightClick = false;
            this.olvTags.ShowGroups = false;
            this.olvTags.ShowImagesOnSubItems = true;
            this.olvTags.Size = new System.Drawing.Size(466, 345);
            this.olvTags.TabIndex = 6;
            this.olvTags.UseCompatibleStateImageBehavior = false;
            this.olvTags.View = System.Windows.Forms.View.Details;
            // 
            // olvColTags
            // 
            this.olvColTags.AspectName = "Tag";
            this.olvColTags.Text = "Tags";
            this.olvColTags.Width = 105;
            // 
            // olvColDesciption
            // 
            this.olvColDesciption.AspectName = "Description";
            this.olvColDesciption.Text = "Description";
            this.olvColDesciption.Width = 352;
            // 
            // FormAdmin_AssetTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 382);
            this.Controls.Add(this.olvTags);
            this.Controls.Add(this.pnlCameraTypes_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin_AssetTags";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Customer Category Tags";
            this.Load += new System.EventHandler(this.FormAdmin_AssetTags_Load);
            this.pnlCameraTypes_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvTags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCameraTypes_Control;
        private System.Windows.Forms.Button btnCameraType_Edit;
        private System.Windows.Forms.Button btnCameraType_Remove;
        private System.Windows.Forms.Button btnCameraType_Add;
        private System.Windows.Forms.Button btnClose;
        private BrightIdeasSoftware.ObjectListView olvTags;
        private BrightIdeasSoftware.OLVColumn olvColTags;
        private BrightIdeasSoftware.OLVColumn olvColDesciption;
    }
}