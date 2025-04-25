namespace SDB.Forms.Admin
{
	sealed partial class FormAdmin_AssemblyCategory_AddEdit
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
			this.pnlAssemblyCategoryEdit = new System.Windows.Forms.Panel();
			this.txtAssemblyTypeDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.pnlAssemblyCategoryEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAssemblyCategoryEdit
			// 
			this.pnlAssemblyCategoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAssemblyCategoryEdit.Controls.Add(this.txtAssemblyTypeDescription);
			this.pnlAssemblyCategoryEdit.Controls.Add(this.lblDescription);
			this.pnlAssemblyCategoryEdit.Location = new System.Drawing.Point(12, 12);
			this.pnlAssemblyCategoryEdit.Name = "pnlAssemblyCategoryEdit";
			this.pnlAssemblyCategoryEdit.Size = new System.Drawing.Size(627, 100);
			this.pnlAssemblyCategoryEdit.TabIndex = 0;
			// 
			// txtAssemblyTypeDescription
			// 
			this.txtAssemblyTypeDescription.Location = new System.Drawing.Point(127, 16);
			this.txtAssemblyTypeDescription.MaxLength = 128;
			this.txtAssemblyTypeDescription.Name = "txtAssemblyTypeDescription";
			this.txtAssemblyTypeDescription.Size = new System.Drawing.Size(359, 20);
			this.txtAssemblyTypeDescription.TabIndex = 1;
			this.txtAssemblyTypeDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(61, 19);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 0;
			this.lblDescription.Text = "Description";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(483, 118);
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
			this.btnOK.Location = new System.Drawing.Point(564, 118);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FormAdmin_AssemblyCategory_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(651, 153);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlAssemblyCategoryEdit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_AssemblyCategory_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Assembly Category";
			this.pnlAssemblyCategoryEdit.ResumeLayout(false);
			this.pnlAssemblyCategoryEdit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAssemblyCategoryEdit;
		private System.Windows.Forms.TextBox txtAssemblyTypeDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}