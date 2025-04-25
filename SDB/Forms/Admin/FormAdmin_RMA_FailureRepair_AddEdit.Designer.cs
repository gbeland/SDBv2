namespace SDB.Forms.Admin
{
	partial class FormAdmin_RMA_FailureRepair_AddEdit
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
			this.pnlFailureRepair = new System.Windows.Forms.Panel();
			this.txtFailureRepairDescription = new System.Windows.Forms.TextBox();
			this.lblFailureRepairDescription = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlFailureRepair.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlFailureRepair
			// 
			this.pnlFailureRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFailureRepair.Controls.Add(this.txtFailureRepairDescription);
			this.pnlFailureRepair.Controls.Add(this.lblFailureRepairDescription);
			this.pnlFailureRepair.Location = new System.Drawing.Point(12, 12);
			this.pnlFailureRepair.Name = "pnlFailureRepair";
			this.pnlFailureRepair.Size = new System.Drawing.Size(462, 54);
			this.pnlFailureRepair.TabIndex = 0;
			// 
			// txtFailureRepairDescription
			// 
			this.txtFailureRepairDescription.Location = new System.Drawing.Point(79, 16);
			this.txtFailureRepairDescription.MaxLength = 128;
			this.txtFailureRepairDescription.Name = "txtFailureRepairDescription";
			this.txtFailureRepairDescription.Size = new System.Drawing.Size(359, 20);
			this.txtFailureRepairDescription.TabIndex = 1;
			this.txtFailureRepairDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblFailureRepairDescription
			// 
			this.lblFailureRepairDescription.AutoSize = true;
			this.lblFailureRepairDescription.Location = new System.Drawing.Point(13, 19);
			this.lblFailureRepairDescription.Name = "lblFailureRepairDescription";
			this.lblFailureRepairDescription.Size = new System.Drawing.Size(60, 13);
			this.lblFailureRepairDescription.TabIndex = 0;
			this.lblFailureRepairDescription.Text = "Description";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(318, 72);
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
			this.btnOK.Location = new System.Drawing.Point(399, 72);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormRMA_FailureRepair_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(486, 107);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlFailureRepair);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_FailureRepair_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Assembly Failure/Repair/RootCause";
			this.pnlFailureRepair.ResumeLayout(false);
			this.pnlFailureRepair.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlFailureRepair;
		private System.Windows.Forms.TextBox txtFailureRepairDescription;
		private System.Windows.Forms.Label lblFailureRepairDescription;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}