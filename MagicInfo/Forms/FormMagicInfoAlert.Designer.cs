namespace SDB.MagicInfo.Forms
{
    partial class FormMagicInfoAlert
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
            this.floAlertList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // floAlertList
            // 
            this.floAlertList.AutoSize = true;
            this.floAlertList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.floAlertList.Location = new System.Drawing.Point(24, 12);
            this.floAlertList.Name = "floAlertList";
            this.floAlertList.Size = new System.Drawing.Size(465, 443);
            this.floAlertList.TabIndex = 0;
            this.floAlertList.WrapContents = false;
            // 
            // FormMagicInfoAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(522, 467);
            this.Controls.Add(this.floAlertList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMagicInfoAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MagicInfo Alerts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMagicInfoAlert_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormMagicInfoAlert_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMagicInfoAlert_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel floAlertList;
    }
}