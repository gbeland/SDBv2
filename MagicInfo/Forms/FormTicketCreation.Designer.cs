namespace SDB.MagicInfo.Forms
{
    partial class FormTicketCreation
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
            this.ucTicketCreation1 = new SDB.MagicInfo.UserControls.ucTicketCreation();
            this.SuspendLayout();
            // 
            // ucTicketCreation1
            // 
            this.ucTicketCreation1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ucTicketCreation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTicketCreation1.Location = new System.Drawing.Point(0, 0);
            this.ucTicketCreation1.Name = "ucTicketCreation1";
            this.ucTicketCreation1.Size = new System.Drawing.Size(775, 381);
            this.ucTicketCreation1.TabIndex = 0;
            // 
            // FormTicketCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 381);
            this.Controls.Add(this.ucTicketCreation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTicketCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ticket Creation";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucTicketCreation ucTicketCreation1;
    }
}