namespace SDB.Forms.Admin
{
	partial class FormHelp_ChangeLog
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
			this.rtbChangeLog = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbChangeLog
			// 
			this.rtbChangeLog.BackColor = System.Drawing.Color.Gainsboro;
			this.rtbChangeLog.DetectUrls = false;
			this.rtbChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbChangeLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbChangeLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rtbChangeLog.Location = new System.Drawing.Point(0, 0);
			this.rtbChangeLog.Name = "rtbChangeLog";
			this.rtbChangeLog.ReadOnly = true;
			this.rtbChangeLog.Size = new System.Drawing.Size(784, 566);
			this.rtbChangeLog.TabIndex = 0;
			this.rtbChangeLog.TabStop = false;
			this.rtbChangeLog.Text = "";
			this.rtbChangeLog.WordWrap = false;
			// 
			// FormHelp_ChangeLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 566);
			this.Controls.Add(this.rtbChangeLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "FormHelp_ChangeLog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SDB Change Log";
			this.Load += new System.EventHandler(this.FormHelp_ChangeLog_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbChangeLog;
	}
}