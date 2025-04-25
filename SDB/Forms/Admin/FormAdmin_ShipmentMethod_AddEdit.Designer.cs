namespace SDB.Forms.Admin
{
	partial class FormAdmin_ShipmentMethod_AddEdit
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TextBox txtInfo;
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.chkDefault = new System.Windows.Forms.CheckBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblAbbreviation = new System.Windows.Forms.Label();
			this.txtAbbreviation = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
			txtInfo.Text = "Add shipment method.";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(277, 139);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
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
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chkDefault
			// 
			this.chkDefault.AutoSize = true;
			this.chkDefault.Location = new System.Drawing.Point(342, 77);
			this.chkDefault.Name = "chkDefault";
			this.chkDefault.Size = new System.Drawing.Size(79, 17);
			this.chkDefault.TabIndex = 5;
			this.chkDefault.Text = "Set Default";
			this.toolTip1.SetToolTip(this.chkDefault, "Note you cannot un-set default status. Change default shipping method by selectin" +
        "g default on another shipment method.");
			this.chkDefault.UseVisualStyleBackColor = true;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(46, 75);
			this.txtDescription.MaxLength = 64;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(215, 20);
			this.txtDescription.TabIndex = 2;
			this.txtDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(43, 59);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 1;
			this.lblDescription.Text = "Description";
			// 
			// lblAbbreviation
			// 
			this.lblAbbreviation.AutoSize = true;
			this.lblAbbreviation.Location = new System.Drawing.Point(264, 59);
			this.lblAbbreviation.Name = "lblAbbreviation";
			this.lblAbbreviation.Size = new System.Drawing.Size(66, 13);
			this.lblAbbreviation.TabIndex = 3;
			this.lblAbbreviation.Text = "Abbreviation";
			// 
			// txtAbbreviation
			// 
			this.txtAbbreviation.Location = new System.Drawing.Point(267, 75);
			this.txtAbbreviation.MaxLength = 8;
			this.txtAbbreviation.Name = "txtAbbreviation";
			this.txtAbbreviation.Size = new System.Drawing.Size(63, 20);
			this.txtAbbreviation.TabIndex = 4;
			this.txtAbbreviation.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// FormAdmin_ShipmentMethod_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 174);
			this.Controls.Add(this.lblAbbreviation);
			this.Controls.Add(this.txtAbbreviation);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(txtInfo);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.chkDefault);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_ShipmentMethod_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Shipment Method";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox chkDefault;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblAbbreviation;
		private System.Windows.Forms.TextBox txtAbbreviation;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}