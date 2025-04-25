namespace SDB.Forms.Admin
{
	partial class FormAdmin_Solution_AddEdit
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
			System.Windows.Forms.TextBox txtInfo;
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.chkSolutionRequiresParts = new System.Windows.Forms.CheckBox();
			this.txtSolutionName = new System.Windows.Forms.TextBox();
			this.lblSolutionName = new System.Windows.Forms.Label();
			txtInfo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtInfo
			// 
			txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtInfo.Location = new System.Drawing.Point(12, 12);
			txtInfo.Multiline = true;
			txtInfo.Name = "txtInfo";
			txtInfo.ReadOnly = true;
			txtInfo.Size = new System.Drawing.Size(421, 40);
			txtInfo.TabIndex = 0;
			txtInfo.TabStop = false;
			txtInfo.Text = "Add or edit solution.";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(277, 139);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(358, 139);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chkSolutionRequiresParts
			// 
			this.chkSolutionRequiresParts.AutoSize = true;
			this.chkSolutionRequiresParts.Location = new System.Drawing.Point(253, 78);
			this.chkSolutionRequiresParts.Name = "chkSolutionRequiresParts";
			this.chkSolutionRequiresParts.Size = new System.Drawing.Size(95, 17);
			this.chkSolutionRequiresParts.TabIndex = 3;
			this.chkSolutionRequiresParts.Text = "Requires Parts";
			this.chkSolutionRequiresParts.UseVisualStyleBackColor = true;
			// 
			// txtSolutionName
			// 
			this.txtSolutionName.Location = new System.Drawing.Point(32, 75);
			this.txtSolutionName.Name = "txtSolutionName";
			this.txtSolutionName.Size = new System.Drawing.Size(215, 20);
			this.txtSolutionName.TabIndex = 2;
			// 
			// lblSolutionName
			// 
			this.lblSolutionName.AutoSize = true;
			this.lblSolutionName.Location = new System.Drawing.Point(29, 59);
			this.lblSolutionName.Name = "lblSolutionName";
			this.lblSolutionName.Size = new System.Drawing.Size(76, 13);
			this.lblSolutionName.TabIndex = 1;
			this.lblSolutionName.Text = "Solution Name";
			// 
			// FormAdmin_Solution_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(445, 174);
			this.Controls.Add(this.lblSolutionName);
			this.Controls.Add(txtInfo);
			this.Controls.Add(this.txtSolutionName);
			this.Controls.Add(this.chkSolutionRequiresParts);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_Solution_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add/Edit Solution";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox chkSolutionRequiresParts;
		private System.Windows.Forms.TextBox txtSolutionName;
		private System.Windows.Forms.Label lblSolutionName;
	}
}