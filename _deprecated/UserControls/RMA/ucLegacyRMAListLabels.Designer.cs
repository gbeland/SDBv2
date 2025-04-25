namespace SDB.UserControls.RMA
{
	partial class ucLegacyRMAListLabels
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
			this.lblGrayYellow = new System.Windows.Forms.Label();
			this.lblWhiteRed = new System.Windows.Forms.Label();
			this.lblWhiteGray = new System.Windows.Forms.Label();
			this.lblWhiteBlack = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblGrayYellow
			// 
			this.lblGrayYellow.AutoSize = true;
			this.lblGrayYellow.BackColor = System.Drawing.Color.LightSlateGray;
			this.lblGrayYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrayYellow.ForeColor = System.Drawing.Color.Yellow;
			this.lblGrayYellow.Location = new System.Drawing.Point(3, 17);
			this.lblGrayYellow.Name = "lblGrayYellow";
			this.lblGrayYellow.Size = new System.Drawing.Size(84, 13);
			this.lblGrayYellow.TabIndex = 0;
			this.lblGrayYellow.Text = "Over 15 Days";
			// 
			// lblWhiteRed
			// 
			this.lblWhiteRed.AutoSize = true;
			this.lblWhiteRed.BackColor = System.Drawing.Color.White;
			this.lblWhiteRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhiteRed.ForeColor = System.Drawing.Color.Red;
			this.lblWhiteRed.Location = new System.Drawing.Point(3, 34);
			this.lblWhiteRed.Name = "lblWhiteRed";
			this.lblWhiteRed.Size = new System.Drawing.Size(84, 13);
			this.lblWhiteRed.TabIndex = 1;
			this.lblWhiteRed.Text = "Over 30 Days";
			// 
			// lblWhiteGray
			// 
			this.lblWhiteGray.AutoSize = true;
			this.lblWhiteGray.BackColor = System.Drawing.Color.White;
			this.lblWhiteGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhiteGray.ForeColor = System.Drawing.Color.Gray;
			this.lblWhiteGray.Location = new System.Drawing.Point(3, 51);
			this.lblWhiteGray.Name = "lblWhiteGray";
			this.lblWhiteGray.Size = new System.Drawing.Size(45, 13);
			this.lblWhiteGray.TabIndex = 2;
			this.lblWhiteGray.Text = "Closed";
			// 
			// lblWhiteBlack
			// 
			this.lblWhiteBlack.AutoSize = true;
			this.lblWhiteBlack.BackColor = System.Drawing.Color.White;
			this.lblWhiteBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWhiteBlack.ForeColor = System.Drawing.Color.Black;
			this.lblWhiteBlack.Location = new System.Drawing.Point(3, 0);
			this.lblWhiteBlack.Name = "lblWhiteBlack";
			this.lblWhiteBlack.Size = new System.Drawing.Size(37, 13);
			this.lblWhiteBlack.TabIndex = 3;
			this.lblWhiteBlack.Text = "Open";
			// 
			// UserControl_RMAListLabels
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblWhiteBlack);
			this.Controls.Add(this.lblWhiteGray);
			this.Controls.Add(this.lblWhiteRed);
			this.Controls.Add(this.lblGrayYellow);
			this.Name = "UserControl_RMAListLabels";
			this.Size = new System.Drawing.Size(102, 67);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblGrayYellow;
		private System.Windows.Forms.Label lblWhiteRed;
		private System.Windows.Forms.Label lblWhiteGray;
		private System.Windows.Forms.Label lblWhiteBlack;
	}
}
