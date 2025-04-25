namespace SDB.MagicInfo.Forms
{
    partial class FormServerEditor
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
            this.ucServerEditor1 = new SDB.MagicInfo.UserControls.ucServerEditor();
            this.SuspendLayout();
            // 
            // ucServerEditor1
            // 
            this.ucServerEditor1.Location = new System.Drawing.Point(12, 12);
            this.ucServerEditor1.Name = "ucServerEditor1";
            this.ucServerEditor1.Size = new System.Drawing.Size(559, 329);
            this.ucServerEditor1.TabIndex = 0;
            // 
            // FormServerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 342);
            this.Controls.Add(this.ucServerEditor1);
            this.Name = "FormServerEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormServerEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private MagicInfo.UserControls.ucServerEditor ucServerEditor1;
    }
}