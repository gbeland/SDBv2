namespace SDB.Forms.Asset
{
	partial class FormGeoCodeConfirm
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
			this.pnlZoomed = new System.Windows.Forms.Panel();
			this.wbZoomed = new System.Windows.Forms.WebBrowser();
			this.pnlOverview = new System.Windows.Forms.Panel();
			this.wbOverview = new System.Windows.Forms.WebBrowser();
			this.txtLongitude = new System.Windows.Forms.TextBox();
			this.lblLatitude = new System.Windows.Forms.Label();
			this.txtLatitude = new System.Windows.Forms.TextBox();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.btnNo = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.pnlZoomed.SuspendLayout();
			this.pnlOverview.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlZoomed
			// 
			this.pnlZoomed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlZoomed.Controls.Add(this.wbZoomed);
			this.pnlZoomed.Location = new System.Drawing.Point(178, 78);
			this.pnlZoomed.Name = "pnlZoomed";
			this.pnlZoomed.Size = new System.Drawing.Size(320, 240);
			this.pnlZoomed.TabIndex = 20;
			// 
			// wbZoomed
			// 
			this.wbZoomed.AllowWebBrowserDrop = false;
			this.wbZoomed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbZoomed.IsWebBrowserContextMenuEnabled = false;
			this.wbZoomed.Location = new System.Drawing.Point(0, 0);
			this.wbZoomed.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbZoomed.Name = "wbZoomed";
			this.wbZoomed.ScriptErrorsSuppressed = true;
			this.wbZoomed.ScrollBarsEnabled = false;
			this.wbZoomed.Size = new System.Drawing.Size(318, 238);
			this.wbZoomed.TabIndex = 13;
			this.wbZoomed.TabStop = false;
			this.wbZoomed.WebBrowserShortcutsEnabled = false;
			// 
			// pnlOverview
			// 
			this.pnlOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlOverview.Controls.Add(this.wbOverview);
			this.pnlOverview.Location = new System.Drawing.Point(12, 78);
			this.pnlOverview.Name = "pnlOverview";
			this.pnlOverview.Size = new System.Drawing.Size(160, 120);
			this.pnlOverview.TabIndex = 19;
			// 
			// wbOverview
			// 
			this.wbOverview.AllowWebBrowserDrop = false;
			this.wbOverview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbOverview.IsWebBrowserContextMenuEnabled = false;
			this.wbOverview.Location = new System.Drawing.Point(0, 0);
			this.wbOverview.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbOverview.Name = "wbOverview";
			this.wbOverview.ScriptErrorsSuppressed = true;
			this.wbOverview.ScrollBarsEnabled = false;
			this.wbOverview.Size = new System.Drawing.Size(158, 118);
			this.wbOverview.TabIndex = 12;
			this.wbOverview.TabStop = false;
			this.wbOverview.WebBrowserShortcutsEnabled = false;
			// 
			// txtLongitude
			// 
			this.txtLongitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLongitude.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLongitude.ForeColor = System.Drawing.Color.MediumBlue;
			this.txtLongitude.Location = new System.Drawing.Point(290, 50);
			this.txtLongitude.Name = "txtLongitude";
			this.txtLongitude.ReadOnly = true;
			this.txtLongitude.Size = new System.Drawing.Size(150, 19);
			this.txtLongitude.TabIndex = 18;
			this.txtLongitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblLatitude
			// 
			this.lblLatitude.AutoSize = true;
			this.lblLatitude.Location = new System.Drawing.Point(75, 54);
			this.lblLatitude.Name = "lblLatitude";
			this.lblLatitude.Size = new System.Drawing.Size(51, 13);
			this.lblLatitude.TabIndex = 16;
			this.lblLatitude.Text = "Lat/Long";
			// 
			// txtLatitude
			// 
			this.txtLatitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLatitude.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLatitude.ForeColor = System.Drawing.Color.MediumBlue;
			this.txtLatitude.Location = new System.Drawing.Point(132, 50);
			this.txtLatitude.Name = "txtLatitude";
			this.txtLatitude.ReadOnly = true;
			this.txtLatitude.Size = new System.Drawing.Size(150, 19);
			this.txtLatitude.TabIndex = 17;
			this.txtLatitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblConfirm
			// 
			this.lblConfirm.AutoSize = true;
			this.lblConfirm.Location = new System.Drawing.Point(181, 337);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(152, 13);
			this.lblConfirm.TabIndex = 21;
			this.lblConfirm.Text = "Do you want to use this result?";
			// 
			// btnNo
			// 
			this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnNo.Location = new System.Drawing.Point(260, 366);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 23);
			this.btnNo.TabIndex = 22;
			this.btnNo.Text = "No";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// btnYes
			// 
			this.btnYes.Location = new System.Drawing.Point(179, 366);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(75, 23);
			this.btnYes.TabIndex = 23;
			this.btnYes.Text = "Yes";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(13, 24);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new System.Drawing.Size(485, 20);
			this.txtLocation.TabIndex = 24;
			// 
			// FormGeoCodeConfirm
			// 
			this.AcceptButton = this.btnYes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnNo;
			this.ClientSize = new System.Drawing.Size(514, 409);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.pnlZoomed);
			this.Controls.Add(this.pnlOverview);
			this.Controls.Add(this.txtLongitude);
			this.Controls.Add(this.lblLatitude);
			this.Controls.Add(this.txtLatitude);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGeoCodeConfirm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Geocoding Results";
			this.Shown += new System.EventHandler(this.FormGeoCodeConfirm_Shown);
			this.pnlZoomed.ResumeLayout(false);
			this.pnlOverview.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlZoomed;
		private System.Windows.Forms.WebBrowser wbZoomed;
		private System.Windows.Forms.Panel pnlOverview;
		private System.Windows.Forms.WebBrowser wbOverview;
		private System.Windows.Forms.TextBox txtLongitude;
		private System.Windows.Forms.Label lblLatitude;
		private System.Windows.Forms.TextBox txtLatitude;
		private System.Windows.Forms.Label lblConfirm;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.TextBox txtLocation;
	}
}