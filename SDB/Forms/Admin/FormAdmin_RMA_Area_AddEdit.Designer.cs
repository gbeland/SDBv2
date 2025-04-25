namespace SDB.Forms.Admin
{
	partial class FormAdmin_RMA_Area_AddEdit
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
			this.pnlArea = new System.Windows.Forms.Panel();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.lblAreaDescription = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlArea
			// 
			this.pnlArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlArea.Controls.Add(this.txtArea);
			this.pnlArea.Controls.Add(this.lblAreaDescription);
			this.pnlArea.Location = new System.Drawing.Point(12, 12);
			this.pnlArea.Name = "pnlArea";
			this.pnlArea.Size = new System.Drawing.Size(298, 53);
			this.pnlArea.TabIndex = 0;
			// 
			// txtArea
			// 
			this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtArea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtArea.Location = new System.Drawing.Point(79, 16);
			this.txtArea.MaxLength = 16;
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(200, 26);
			this.txtArea.TabIndex = 1;
			this.txtArea.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAreaDescription
			// 
			this.lblAreaDescription.AutoSize = true;
			this.lblAreaDescription.Location = new System.Drawing.Point(13, 19);
			this.lblAreaDescription.Name = "lblAreaDescription";
			this.lblAreaDescription.Size = new System.Drawing.Size(60, 13);
			this.lblAreaDescription.TabIndex = 0;
			this.lblAreaDescription.Text = "Description";
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
			// FormAdmin_RMA_Area_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(322, 106);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlArea);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_RMA_Area_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit RMA Area";
			this.pnlArea.ResumeLayout(false);
			this.pnlArea.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlArea;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label lblAreaDescription;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}