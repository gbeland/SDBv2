namespace SDB.Forms.Shipment
{
	partial class FormShipmentPrintOption
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
			this.btnDetail = new System.Windows.Forms.Button();
			this.btnLabel = new System.Windows.Forms.Button();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pnlBorder = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlButtons.SuspendLayout();
			this.pnlBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDetail
			// 
			this.btnDetail.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnDetail.Location = new System.Drawing.Point(0, 0);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(95, 60);
			this.btnDetail.TabIndex = 0;
			this.btnDetail.Text = "&Detail";
			this.btnDetail.UseVisualStyleBackColor = true;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// btnLabel
			// 
			this.btnLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnLabel.Location = new System.Drawing.Point(130, 0);
			this.btnLabel.Name = "btnLabel";
			this.btnLabel.Size = new System.Drawing.Size(95, 60);
			this.btnLabel.TabIndex = 1;
			this.btnLabel.Text = "&Label";
			this.btnLabel.UseVisualStyleBackColor = true;
			this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
			// 
			// pnlButtons
			// 
			this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlButtons.Controls.Add(this.btnLabel);
			this.pnlButtons.Controls.Add(this.btnDetail);
			this.pnlButtons.Location = new System.Drawing.Point(12, 24);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(225, 60);
			this.pnlButtons.TabIndex = 0;
			// 
			// pnlBorder
			// 
			this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlBorder.Controls.Add(this.btnCancel);
			this.pnlBorder.Controls.Add(this.pnlButtons);
			this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBorder.Location = new System.Drawing.Point(0, 0);
			this.pnlBorder.Name = "pnlBorder";
			this.pnlBorder.Size = new System.Drawing.Size(250, 130);
			this.pnlBorder.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(87, 94);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormShipmentPrintOption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(250, 130);
			this.ControlBox = false;
			this.Controls.Add(this.pnlBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(250, 130);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 130);
			this.Name = "FormShipmentPrintOption";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Shipment Print Option";
			this.TopMost = true;
			this.pnlButtons.ResumeLayout(false);
			this.pnlBorder.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDetail;
		private System.Windows.Forms.Button btnLabel;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Panel pnlBorder;
		private System.Windows.Forms.Button btnCancel;
	}
}