namespace SDB.MagicInfo.Forms
{
    partial class FormMarketEditor
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
            this.ucMarketEditor1 = new SDB.MagicInfo.UserControls.ucMarketEditor();
            this.SuspendLayout();
            // 
            // ucMarketEditor1
            // 
            this.ucMarketEditor1.Location = new System.Drawing.Point(12, 12);
            this.ucMarketEditor1.Name = "ucMarketEditor1";
            this.ucMarketEditor1.Size = new System.Drawing.Size(604, 189);
            this.ucMarketEditor1.TabIndex = 0;
            // 
            // FormMarketEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 203);
            this.Controls.Add(this.ucMarketEditor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMarketEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Market Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private MagicInfo.UserControls.ucMarketEditor ucMarketEditor1;
    }
}