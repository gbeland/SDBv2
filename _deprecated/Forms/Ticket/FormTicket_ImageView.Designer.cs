namespace SDB.Forms.Ticket
{
	partial class FormTicket_ImageView
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
			this.components = new System.ComponentModel.Container();
			this.pbTicketImage = new System.Windows.Forms.PictureBox();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbTicketImage)).BeginInit();
			this.pnlMain.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbTicketImage
			// 
			this.pbTicketImage.BackColor = System.Drawing.Color.Black;
			this.pbTicketImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbTicketImage.Location = new System.Drawing.Point(0, 30);
			this.pbTicketImage.Name = "pbTicketImage";
			this.pbTicketImage.Size = new System.Drawing.Size(484, 352);
			this.pbTicketImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTicketImage.TabIndex = 0;
			this.pbTicketImage.TabStop = false;
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.pbTicketImage);
			this.pnlMain.Controls.Add(this.pnlControl);
			this.pnlMain.Controls.Add(this.pnlBottom);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(484, 462);
			this.pnlMain.TabIndex = 1;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnDelete);
			this.pnlControl.Controls.Add(this.btnSave);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(484, 30);
			this.pnlControl.TabIndex = 0;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnDelete.Location = new System.Drawing.Point(109, 4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete Image";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save to file...";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.txtDescription);
			this.pnlBottom.Controls.Add(this.txtDate);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 382);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(484, 80);
			this.pnlBottom.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new System.Drawing.Point(0, 23);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(484, 57);
			this.txtDescription.TabIndex = 2;
			this.txtDescription.TabStop = false;
			// 
			// txtDate
			// 
			this.txtDate.BackColor = System.Drawing.Color.Silver;
			this.txtDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtDate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDate.Location = new System.Drawing.Point(0, 0);
			this.txtDate.Name = "txtDate";
			this.txtDate.ReadOnly = true;
			this.txtDate.Size = new System.Drawing.Size(484, 23);
			this.txtDate.TabIndex = 3;
			this.txtDate.TabStop = false;
			this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// FormTicket_ImageView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 462);
			this.Controls.Add(this.pnlMain);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(350, 350);
			this.Name = "FormTicket_ImageView";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ticket: View Image";
			((System.ComponentModel.ISupportInitialize)(this.pbTicketImage)).EndInit();
			this.pnlMain.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbTicketImage;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}