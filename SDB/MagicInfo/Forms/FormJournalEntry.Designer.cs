namespace SDB.MagicInfo.Forms
{
    partial class FormJournalEntry
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
            this.ucJournalEntry1 = new SDB.MagicInfo.UserControls.ucJournalEntry();
            this.SuspendLayout();
            // 
            // ucJournalEntry1
            // 
            this.ucJournalEntry1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ucJournalEntry1.Location = new System.Drawing.Point(0, 0);
            this.ucJournalEntry1.Name = "ucJournalEntry1";
            this.ucJournalEntry1.Size = new System.Drawing.Size(693, 535);
            this.ucJournalEntry1.TabIndex = 0;
            // 
            // FormJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 532);
            this.Controls.Add(this.ucJournalEntry1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormJournalEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Journal";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucJournalEntry ucJournalEntry1;
    }
}