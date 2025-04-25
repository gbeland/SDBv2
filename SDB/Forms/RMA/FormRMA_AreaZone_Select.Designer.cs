namespace SDB.Forms.RMA
{
	partial class FormRMA_AreaZone_Select
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlZone = new System.Windows.Forms.Panel();
			this.cmbZone = new System.Windows.Forms.ComboBox();
			this.lblZone = new System.Windows.Forms.Label();
			this.cmbArea = new System.Windows.Forms.ComboBox();
			this.lblArea = new System.Windows.Forms.Label();
			this.pnlArea = new System.Windows.Forms.Panel();
			this.pnlZone.SuspendLayout();
			this.pnlArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(275, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(356, 120);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// pnlZone
			// 
			this.pnlZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlZone.Controls.Add(this.cmbZone);
			this.pnlZone.Controls.Add(this.lblZone);
			this.pnlZone.Location = new System.Drawing.Point(12, 63);
			this.pnlZone.Name = "pnlZone";
			this.pnlZone.Size = new System.Drawing.Size(419, 43);
			this.pnlZone.TabIndex = 0;
			// 
			// cmbZone
			// 
			this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZone.FormattingEnabled = true;
			this.cmbZone.Location = new System.Drawing.Point(3, 16);
			this.cmbZone.Name = "cmbZone";
			this.cmbZone.Size = new System.Drawing.Size(413, 21);
			this.cmbZone.TabIndex = 1;
			this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
			// 
			// lblZone
			// 
			this.lblZone.AutoSize = true;
			this.lblZone.Location = new System.Drawing.Point(3, 0);
			this.lblZone.Name = "lblZone";
			this.lblZone.Size = new System.Drawing.Size(59, 13);
			this.lblZone.TabIndex = 0;
			this.lblZone.Text = "RMA Zone";
			// 
			// cmbArea
			// 
			this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbArea.FormattingEnabled = true;
			this.cmbArea.Location = new System.Drawing.Point(3, 16);
			this.cmbArea.Name = "cmbArea";
			this.cmbArea.Size = new System.Drawing.Size(413, 21);
			this.cmbArea.TabIndex = 3;
			this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
			// 
			// lblArea
			// 
			this.lblArea.AutoSize = true;
			this.lblArea.Location = new System.Drawing.Point(3, 0);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(56, 13);
			this.lblArea.TabIndex = 2;
			this.lblArea.Text = "RMA Area";
			// 
			// pnlArea
			// 
			this.pnlArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlArea.Controls.Add(this.cmbArea);
			this.pnlArea.Controls.Add(this.lblArea);
			this.pnlArea.Location = new System.Drawing.Point(12, 12);
			this.pnlArea.Name = "pnlArea";
			this.pnlArea.Size = new System.Drawing.Size(419, 45);
			this.pnlArea.TabIndex = 3;
			// 
			// FormRMA_AreaZone_Select
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(443, 155);
			this.Controls.Add(this.pnlArea);
			this.Controls.Add(this.pnlZone);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_AreaZone_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select RMA Area/Zone";
			this.Load += new System.EventHandler(this.FormRMA_AreaZone_Select_Load);
			this.pnlZone.ResumeLayout(false);
			this.pnlZone.PerformLayout();
			this.pnlArea.ResumeLayout(false);
			this.pnlArea.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlZone;
		private System.Windows.Forms.ComboBox cmbZone;
		private System.Windows.Forms.Label lblZone;
		private System.Windows.Forms.ComboBox cmbArea;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.Panel pnlArea;
	}
}