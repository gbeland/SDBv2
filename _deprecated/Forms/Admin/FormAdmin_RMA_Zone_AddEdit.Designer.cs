namespace SDB.Forms.Admin
{
	partial class FormAdmin_RMA_Zone_AddEdit
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
			this.pnlZone = new System.Windows.Forms.Panel();
			this.txtZone = new System.Windows.Forms.TextBox();
			this.lblZoneDescription = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlZone.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlZone
			// 
			this.pnlZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlZone.Controls.Add(this.txtZone);
			this.pnlZone.Controls.Add(this.lblZoneDescription);
			this.pnlZone.Location = new System.Drawing.Point(12, 12);
			this.pnlZone.Name = "pnlZone";
			this.pnlZone.Size = new System.Drawing.Size(298, 53);
			this.pnlZone.TabIndex = 0;
			// 
			// txtZone
			// 
			this.txtZone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtZone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtZone.Location = new System.Drawing.Point(79, 16);
			this.txtZone.MaxLength = 16;
			this.txtZone.Name = "txtZone";
			this.txtZone.Size = new System.Drawing.Size(200, 26);
			this.txtZone.TabIndex = 1;
			this.txtZone.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblZoneDescription
			// 
			this.lblZoneDescription.AutoSize = true;
			this.lblZoneDescription.Location = new System.Drawing.Point(13, 19);
			this.lblZoneDescription.Name = "lblZoneDescription";
			this.lblZoneDescription.Size = new System.Drawing.Size(60, 13);
			this.lblZoneDescription.TabIndex = 0;
			this.lblZoneDescription.Text = "Description";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(154, 71);
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
			this.btnOK.Location = new System.Drawing.Point(235, 71);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormAdmin_RMA_Zone_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(322, 106);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlZone);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_RMA_Zone_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit RMA Zone";
			this.pnlZone.ResumeLayout(false);
			this.pnlZone.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlZone;
		private System.Windows.Forms.TextBox txtZone;
		private System.Windows.Forms.Label lblZoneDescription;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}