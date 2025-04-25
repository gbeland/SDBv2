using SDB.Classes.Misc;

namespace SDB.Forms.General
{
    partial class FormUpdateCheck
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
			System.Windows.Forms.Label lblTitle;
			System.Windows.Forms.Label lblDivider;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateCheck));
			this.rtfStatus = new System.Windows.Forms.RichTextBox();
			this.bgwCheck = new System.ComponentModel.BackgroundWorker();
			this.progressBar = new ClassProgressBarCol();
			lblTitle = new System.Windows.Forms.Label();
			lblDivider = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.BackColor = System.Drawing.Color.Black;
			lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			lblTitle.ForeColor = System.Drawing.Color.White;
			lblTitle.Location = new System.Drawing.Point(0, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new System.Drawing.Size(344, 18);
			lblTitle.TabIndex = 2;
			lblTitle.Text = "Prismview Service Database Launcher";
			lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDivider
			// 
			lblDivider.BackColor = System.Drawing.Color.DimGray;
			lblDivider.Dock = System.Windows.Forms.DockStyle.Top;
			lblDivider.Location = new System.Drawing.Point(0, 18);
			lblDivider.Name = "lblDivider";
			lblDivider.Size = new System.Drawing.Size(344, 1);
			lblDivider.TabIndex = 3;
			// 
			// rtfStatus
			// 
			this.rtfStatus.BackColor = System.Drawing.Color.Black;
			this.rtfStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtfStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtfStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtfStatus.ForeColor = System.Drawing.Color.LawnGreen;
			this.rtfStatus.Location = new System.Drawing.Point(0, 19);
			this.rtfStatus.Name = "rtfStatus";
			this.rtfStatus.ReadOnly = true;
			this.rtfStatus.Size = new System.Drawing.Size(344, 185);
			this.rtfStatus.TabIndex = 0;
			this.rtfStatus.Text = "";
			// 
			// bgwCheck
			// 
			this.bgwCheck.WorkerReportsProgress = true;
			this.bgwCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheck_DoWork);
			this.bgwCheck.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCheck_ProgressChanged);
			this.bgwCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheck_RunWorkerCompleted);
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.progressBar.ForeColor = System.Drawing.Color.LawnGreen;
			this.progressBar.Location = new System.Drawing.Point(0, 204);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(344, 12);
			this.progressBar.TabIndex = 4;
			// 
			// FormUpdateCheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 216);
			this.Controls.Add(this.rtfStatus);
			this.Controls.Add(lblDivider);
			this.Controls.Add(lblTitle);
			this.Controls.Add(this.progressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormUpdateCheck";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Check";
			this.Load += new System.EventHandler(this.frmUpdateCheck_Load);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.RichTextBox rtfStatus;
        private System.ComponentModel.BackgroundWorker bgwCheck;
		private ClassProgressBarCol progressBar;
    }
}