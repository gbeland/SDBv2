namespace SDB.Forms.Assembly
{
	partial class FormAssemblyPicker
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
			this.lblAssembly = new System.Windows.Forms.Label();
			this.cmbAssembly = new System.Windows.Forms.ComboBox();
			this.lblAssemblyType = new System.Windows.Forms.Label();
			this.cmbAssemblyType = new System.Windows.Forms.ComboBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblAssembly
			// 
			this.lblAssembly.AutoSize = true;
			this.lblAssembly.Location = new System.Drawing.Point(9, 65);
			this.lblAssembly.Name = "lblAssembly";
			this.lblAssembly.Size = new System.Drawing.Size(51, 13);
			this.lblAssembly.TabIndex = 17;
			this.lblAssembly.Text = "Assembly";
			// 
			// cmbAssembly
			// 
			this.cmbAssembly.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cmbAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssembly.FormattingEnabled = true;
			this.cmbAssembly.Location = new System.Drawing.Point(12, 81);
			this.cmbAssembly.Name = "cmbAssembly";
			this.cmbAssembly.Size = new System.Drawing.Size(500, 21);
			this.cmbAssembly.TabIndex = 18;
			this.cmbAssembly.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAssembly_DrawItem);
			this.cmbAssembly.SelectedIndexChanged += new System.EventHandler(this.cmbAssembly_SelectedIndexChanged);
			// 
			// lblAssemblyType
			// 
			this.lblAssemblyType.AutoSize = true;
			this.lblAssemblyType.Location = new System.Drawing.Point(9, 25);
			this.lblAssemblyType.Name = "lblAssemblyType";
			this.lblAssemblyType.Size = new System.Drawing.Size(78, 13);
			this.lblAssemblyType.TabIndex = 15;
			this.lblAssemblyType.Text = "Assembly Type";
			// 
			// cmbAssemblyType
			// 
			this.cmbAssemblyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAssemblyType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbAssemblyType.FormattingEnabled = true;
			this.cmbAssemblyType.Location = new System.Drawing.Point(12, 41);
			this.cmbAssemblyType.Name = "cmbAssemblyType";
			this.cmbAssemblyType.Size = new System.Drawing.Size(500, 21);
			this.cmbAssemblyType.TabIndex = 16;
			this.cmbAssemblyType.SelectedIndexChanged += new System.EventHandler(this.cmbAssemblyType_SelectedIndexChanged);
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.Location = new System.Drawing.Point(443, 128);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 19;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(362, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormAssemblyPicker
			// 
			this.AcceptButton = this.btnSelect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(530, 163);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.lblAssembly);
			this.Controls.Add(this.cmbAssembly);
			this.Controls.Add(this.lblAssemblyType);
			this.Controls.Add(this.cmbAssemblyType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAssemblyPicker";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Assembly";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.Label lblAssemblyType;
		private System.Windows.Forms.ComboBox cmbAssemblyType;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnCancel;
	}
}