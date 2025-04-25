namespace SDB.Forms.RMA
{
	partial class FormLegacyRMANoReturnApproval
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
			this.btnApprove = new System.Windows.Forms.Button();
			this.btnDeny = new System.Windows.Forms.Button();
			this.lblShow_RMA = new System.Windows.Forms.Label();
			this.txtNoReturnReason = new System.Windows.Forms.TextBox();
			this.lblSubHeader = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblHelp = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnApprove
			// 
			this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnApprove.FlatAppearance.BorderSize = 0;
			this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnApprove.Location = new System.Drawing.Point(298, 263);
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.Size = new System.Drawing.Size(75, 23);
			this.btnApprove.TabIndex = 0;
			this.btnApprove.Text = "Approve";
			this.btnApprove.UseVisualStyleBackColor = true;
			this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
			// 
			// btnDeny
			// 
			this.btnDeny.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDeny.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDeny.FlatAppearance.BorderSize = 0;
			this.btnDeny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeny.Location = new System.Drawing.Point(65, 263);
			this.btnDeny.Name = "btnDeny";
			this.btnDeny.Size = new System.Drawing.Size(75, 23);
			this.btnDeny.TabIndex = 1;
			this.btnDeny.Text = "Deny";
			this.btnDeny.UseVisualStyleBackColor = true;
			this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
			// 
			// lblShow_RMA
			// 
			this.lblShow_RMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblShow_RMA.Location = new System.Drawing.Point(12, 22);
			this.lblShow_RMA.Name = "lblShow_RMA";
			this.lblShow_RMA.Size = new System.Drawing.Size(412, 23);
			this.lblShow_RMA.TabIndex = 2;
			this.lblShow_RMA.Text = "RMA";
			this.lblShow_RMA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNoReturnReason
			// 
			this.txtNoReturnReason.BackColor = System.Drawing.Color.White;
			this.txtNoReturnReason.ForeColor = System.Drawing.Color.Black;
			this.txtNoReturnReason.Location = new System.Drawing.Point(12, 84);
			this.txtNoReturnReason.MaxLength = 256;
			this.txtNoReturnReason.Multiline = true;
			this.txtNoReturnReason.Name = "txtNoReturnReason";
			this.txtNoReturnReason.ReadOnly = true;
			this.txtNoReturnReason.Size = new System.Drawing.Size(412, 116);
			this.txtNoReturnReason.TabIndex = 3;
			// 
			// lblSubHeader
			// 
			this.lblSubHeader.Location = new System.Drawing.Point(12, 55);
			this.lblSubHeader.Name = "lblSubHeader";
			this.lblSubHeader.Size = new System.Drawing.Size(412, 26);
			this.lblSubHeader.TabIndex = 4;
			this.lblSubHeader.Text = "One or more parts for this RMA are marked as No Return, for the following reason:" +
				"";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(52, 258);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 32);
			this.label1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(285, 258);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 32);
			this.label2.TabIndex = 6;
			// 
			// lblHelp
			// 
			this.lblHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblHelp.ForeColor = System.Drawing.Color.Green;
			this.lblHelp.Location = new System.Drawing.Point(12, 239);
			this.lblHelp.Name = "lblHelp";
			this.lblHelp.Size = new System.Drawing.Size(412, 17);
			this.lblHelp.TabIndex = 7;
			this.lblHelp.Text = "Approve: Customer will receive the assigned RMA number.";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(12, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(412, 29);
			this.label3.TabIndex = 8;
			this.label3.Text = "Deny: Customer will not received the assigned RMA number, but will be informed to" +
				" contact Yesco for more information.";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(181, 263);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormRMANoReturnApproval
			// 
			this.AcceptButton = this.btnApprove;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(436, 298);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblHelp);
			this.Controls.Add(this.lblSubHeader);
			this.Controls.Add(this.txtNoReturnReason);
			this.Controls.Add(this.lblShow_RMA);
			this.Controls.Add(this.btnDeny);
			this.Controls.Add(this.btnApprove);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMANoReturnApproval";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA \"No Return\" Approval";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnApprove;
		private System.Windows.Forms.Button btnDeny;
		private System.Windows.Forms.Label lblShow_RMA;
		private System.Windows.Forms.TextBox txtNoReturnReason;
		private System.Windows.Forms.Label lblSubHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblHelp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
	}
}