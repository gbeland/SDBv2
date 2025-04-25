namespace SDB.MagicInfo.Components
{
    partial class VerificationComponent
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
            this.grpVerifcation = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpVerifcation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVerifcation
            // 
            this.grpVerifcation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpVerifcation.Controls.Add(this.button1);
            this.grpVerifcation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVerifcation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerifcation.Location = new System.Drawing.Point(0, 0);
            this.grpVerifcation.Name = "grpVerifcation";
            this.grpVerifcation.Size = new System.Drawing.Size(210, 327);
            this.grpVerifcation.TabIndex = 0;
            this.grpVerifcation.TabStop = false;
            this.grpVerifcation.Text = "Verification Info";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(129, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VerificationComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpVerifcation);
            this.Name = "VerificationComponent";
            this.Size = new System.Drawing.Size(210, 327);
            this.grpVerifcation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerifcation;
        private System.Windows.Forms.Button button1;
    }
}
