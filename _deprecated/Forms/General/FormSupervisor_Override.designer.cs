namespace SDB.Forms.General
{
	partial class FormSupervisor_Override
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
			this.lblMainText = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtPIN = new System.Windows.Forms.TextBox();
			this.btnPermit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMainText
			// 
			this.lblMainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMainText.ForeColor = System.Drawing.Color.Firebrick;
			this.lblMainText.Location = new System.Drawing.Point(12, 9);
			this.lblMainText.Name = "lblMainText";
			this.lblMainText.Size = new System.Drawing.Size(418, 64);
			this.lblMainText.TabIndex = 0;
			this.lblMainText.Text = "The asset has an expired or undefined warranty or contract, or the contract is mo" +
    "nitoring-only.  Contact a supervisor to proceed.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(115, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Supervisor ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(133, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password:";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(195, 94);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(150, 22);
			this.txtID.TabIndex = 2;
			// 
			// txtPIN
			// 
			this.txtPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPIN.Location = new System.Drawing.Point(195, 120);
			this.txtPIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPIN.Name = "txtPIN";
			this.txtPIN.PasswordChar = '*';
			this.txtPIN.Size = new System.Drawing.Size(150, 22);
			this.txtPIN.TabIndex = 4;
			// 
			// btnPermit
			// 
			this.btnPermit.Location = new System.Drawing.Point(350, 202);
			this.btnPermit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPermit.Name = "btnPermit";
			this.btnPermit.Size = new System.Drawing.Size(80, 23);
			this.btnPermit.TabIndex = 5;
			this.btnPermit.Text = "Permit";
			this.btnPermit.UseVisualStyleBackColor = true;
			this.btnPermit.Click += new System.EventHandler(this.btnPermit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(264, 202);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormSupervisor_Override
			// 
			this.AcceptButton = this.btnPermit;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(442, 236);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPermit);
			this.Controls.Add(this.txtPIN);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblMainText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormSupervisor_Override";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Supervisor Override";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMainText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtPIN;
		private System.Windows.Forms.Button btnPermit;
		private System.Windows.Forms.Button btnCancel;
	}
}