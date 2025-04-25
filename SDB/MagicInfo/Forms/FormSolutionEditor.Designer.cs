namespace SDB.MagicInfo.Forms
{
    partial class FormSolutionEditor
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
            this.ucSolutionEditor1 = new SDB.MagicInfo.UserControls.ucSolutionEditor();
            this.SuspendLayout();
            // 
            // ucSolutionEditor1
            // 
            this.ucSolutionEditor1.Location = new System.Drawing.Point(1, -1);
            this.ucSolutionEditor1.Name = "ucSolutionEditor1";
            this.ucSolutionEditor1.Size = new System.Drawing.Size(550, 310);
            this.ucSolutionEditor1.TabIndex = 0;
            // 
            // FormSolutionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 304);
            this.Controls.Add(this.ucSolutionEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSolutionEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Solution Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucSolutionEditor ucSolutionEditor1;
    }
}