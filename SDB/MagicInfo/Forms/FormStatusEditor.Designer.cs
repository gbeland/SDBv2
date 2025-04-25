namespace SDB.MagicInfo.Forms
{
    partial class FormStatusEditor
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
            this.ucStatusEditor1 = new SDB.MagicInfo.UserControls.ucStatusEditor();
            this.SuspendLayout();
            // 
            // ucStatusEditor1
            // 
            this.ucStatusEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatusEditor1.Location = new System.Drawing.Point(0, 0);
            this.ucStatusEditor1.Name = "ucStatusEditor1";
            this.ucStatusEditor1.Size = new System.Drawing.Size(553, 300);
            this.ucStatusEditor1.TabIndex = 0;
            // 
            // FormStatusEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 300);
            this.Controls.Add(this.ucStatusEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStatusEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Status List";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucStatusEditor ucStatusEditor1;
    }
}