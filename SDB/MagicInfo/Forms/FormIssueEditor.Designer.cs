namespace SDB.MagicInfo.Forms
{
    partial class FormIssueEditor
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
            this.ucIssueEditor1 = new SDB.MagicInfo.UserControls.ucIssueEditor();
            this.SuspendLayout();
            // 
            // ucIssueEditor1
            // 
            this.ucIssueEditor1.Location = new System.Drawing.Point(2, 0);
            this.ucIssueEditor1.Name = "ucIssueEditor1";
            this.ucIssueEditor1.Size = new System.Drawing.Size(551, 330);
            this.ucIssueEditor1.TabIndex = 0;
            // 
            // FormIssueEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 329);
            this.Controls.Add(this.ucIssueEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIssueEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucIssueEditor ucIssueEditor1;
    }
}