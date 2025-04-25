namespace SDB.Forms.Ticket
{
    partial class FormTicketPriority
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
            this.grpOSAPriority = new System.Windows.Forms.GroupBox();
            this.radCritical = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grpOSAPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOSAPriority
            // 
            this.grpOSAPriority.Controls.Add(this.radCritical);
            this.grpOSAPriority.Controls.Add(this.radNormal);
            this.grpOSAPriority.Controls.Add(this.radHigh);
            this.grpOSAPriority.Location = new System.Drawing.Point(12, 12);
            this.grpOSAPriority.Name = "grpOSAPriority";
            this.grpOSAPriority.Size = new System.Drawing.Size(286, 88);
            this.grpOSAPriority.TabIndex = 11;
            this.grpOSAPriority.TabStop = false;
            this.grpOSAPriority.Text = "OSA Priority";
            // 
            // radCritical
            // 
            this.radCritical.AutoSize = true;
            this.radCritical.Location = new System.Drawing.Point(32, 18);
            this.radCritical.Name = "radCritical";
            this.radCritical.Size = new System.Drawing.Size(247, 17);
            this.radCritical.TabIndex = 7;
            this.radCritical.TabStop = true;
            this.radCritical.Text = "Critical (4 HOURS OR LESS / >50% OUTAGE)";
            this.radCritical.UseVisualStyleBackColor = true;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(34, 64);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(172, 17);
            this.radNormal.TabIndex = 9;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal (24 HOURS / NO O.T.)";
            this.radNormal.UseVisualStyleBackColor = true;
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Location = new System.Drawing.Point(34, 41);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(195, 17);
            this.radHigh.TabIndex = 8;
            this.radHigh.TabStop = true;
            this.radHigh.Text = "High (12 HOURS / >10% OUTAGE)";
            this.radHigh.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTicketPriority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpOSAPriority);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTicketPriority";
            this.Text = "OSA Priority";
            this.grpOSAPriority.ResumeLayout(false);
            this.grpOSAPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOSAPriority;
        private System.Windows.Forms.RadioButton radCritical;
        private System.Windows.Forms.RadioButton radNormal;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.Button button1;
    }
}