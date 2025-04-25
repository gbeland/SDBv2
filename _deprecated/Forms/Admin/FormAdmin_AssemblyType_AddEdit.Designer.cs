namespace SDB.Forms.Admin
{
	sealed partial class FormAdmin_AssemblyType_AddEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_AssemblyType_AddEdit));
			this.pnlAssemblyTypeEdit = new System.Windows.Forms.Panel();
			this.lblCategory = new System.Windows.Forms.Label();
			this.chkAllowDiscard = new System.Windows.Forms.CheckBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.lnkRegexLink = new System.Windows.Forms.LinkLabel();
			this.lblRegexExamples = new System.Windows.Forms.Label();
			this.lblRegexHelp = new System.Windows.Forms.Label();
			this.txtSerialNumberFormat = new System.Windows.Forms.TextBox();
			this.lblSerialNumberFormat = new System.Windows.Forms.Label();
			this.chkIsComputer = new System.Windows.Forms.CheckBox();
			this.txtAssemblyTypeDescription = new System.Windows.Forms.TextBox();
			this.lblAssemblyTypeDescription = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomsDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mtxtTariffCode = new System.Windows.Forms.MaskedTextBox();
			this.pnlAssemblyTypeEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAssemblyTypeEdit
			// 
			this.pnlAssemblyTypeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlAssemblyTypeEdit.Controls.Add(this.mtxtTariffCode);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lblCategory);
			this.pnlAssemblyTypeEdit.Controls.Add(this.chkAllowDiscard);
			this.pnlAssemblyTypeEdit.Controls.Add(this.cmbCategory);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lnkRegexLink);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lblRegexExamples);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lblRegexHelp);
			this.pnlAssemblyTypeEdit.Controls.Add(this.txtSerialNumberFormat);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lblSerialNumberFormat);
			this.pnlAssemblyTypeEdit.Controls.Add(this.chkIsComputer);
			this.pnlAssemblyTypeEdit.Controls.Add(this.label2);
			this.pnlAssemblyTypeEdit.Controls.Add(this.txtCustomsDescription);
			this.pnlAssemblyTypeEdit.Controls.Add(this.label1);
			this.pnlAssemblyTypeEdit.Controls.Add(this.txtAssemblyTypeDescription);
			this.pnlAssemblyTypeEdit.Controls.Add(this.lblAssemblyTypeDescription);
			this.pnlAssemblyTypeEdit.Location = new System.Drawing.Point(12, 12);
			this.pnlAssemblyTypeEdit.Name = "pnlAssemblyTypeEdit";
			this.pnlAssemblyTypeEdit.Size = new System.Drawing.Size(627, 348);
			this.pnlAssemblyTypeEdit.TabIndex = 0;
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(81, 17);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(49, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category";
			// 
			// chkAllowDiscard
			// 
			this.chkAllowDiscard.AutoSize = true;
			this.chkAllowDiscard.Location = new System.Drawing.Point(136, 91);
			this.chkAllowDiscard.Name = "chkAllowDiscard";
			this.chkAllowDiscard.Size = new System.Drawing.Size(396, 17);
			this.chkAllowDiscard.TabIndex = 5;
			this.chkAllowDiscard.Text = "Can Discard: Assemblies of this type can be discarded when creating an RMA.";
			this.chkAllowDiscard.UseVisualStyleBackColor = true;
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(136, 15);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(359, 21);
			this.cmbCategory.TabIndex = 1;
			// 
			// lnkRegexLink
			// 
			this.lnkRegexLink.AutoSize = true;
			this.lnkRegexLink.Location = new System.Drawing.Point(451, 322);
			this.lnkRegexLink.Name = "lnkRegexLink";
			this.lnkRegexLink.Size = new System.Drawing.Size(153, 13);
			this.lnkRegexLink.TabIndex = 14;
			this.lnkRegexLink.TabStop = true;
			this.lnkRegexLink.Text = "More info: Regular Expressions";
			this.lnkRegexLink.VisitedLinkColor = System.Drawing.Color.Blue;
			this.lnkRegexLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegexLink_LinkClicked);
			// 
			// lblRegexExamples
			// 
			this.lblRegexExamples.AutoSize = true;
			this.lblRegexExamples.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRegexExamples.ForeColor = System.Drawing.Color.DarkGray;
			this.lblRegexExamples.Location = new System.Drawing.Point(451, 256);
			this.lblRegexExamples.Name = "lblRegexExamples";
			this.lblRegexExamples.Size = new System.Drawing.Size(139, 52);
			this.lblRegexExamples.TabIndex = 13;
			this.lblRegexExamples.Text = "[0-9]{5}\r\nY[0-9]{4}\r\nSN[0-9]{3,5}\r\n[A-Z]{1}[0-9]{3}[A-Z]?";
			// 
			// lblRegexHelp
			// 
			this.lblRegexHelp.AutoSize = true;
			this.lblRegexHelp.ForeColor = System.Drawing.Color.DarkGray;
			this.lblRegexHelp.Location = new System.Drawing.Point(133, 204);
			this.lblRegexHelp.Name = "lblRegexHelp";
			this.lblRegexHelp.Size = new System.Drawing.Size(312, 104);
			this.lblRegexHelp.TabIndex = 12;
			this.lblRegexHelp.Text = resources.GetString("lblRegexHelp.Text");
			// 
			// txtSerialNumberFormat
			// 
			this.txtSerialNumberFormat.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNumberFormat.Location = new System.Drawing.Point(136, 181);
			this.txtSerialNumberFormat.MaxLength = 32;
			this.txtSerialNumberFormat.Name = "txtSerialNumberFormat";
			this.txtSerialNumberFormat.Size = new System.Drawing.Size(359, 20);
			this.txtSerialNumberFormat.TabIndex = 11;
			// 
			// lblSerialNumberFormat
			// 
			this.lblSerialNumberFormat.AutoSize = true;
			this.lblSerialNumberFormat.Location = new System.Drawing.Point(22, 184);
			this.lblSerialNumberFormat.Name = "lblSerialNumberFormat";
			this.lblSerialNumberFormat.Size = new System.Drawing.Size(108, 13);
			this.lblSerialNumberFormat.TabIndex = 10;
			this.lblSerialNumberFormat.Text = "Serial Number Format";
			// 
			// chkIsComputer
			// 
			this.chkIsComputer.AutoSize = true;
			this.chkIsComputer.Location = new System.Drawing.Point(136, 68);
			this.chkIsComputer.Name = "chkIsComputer";
			this.chkIsComputer.Size = new System.Drawing.Size(408, 17);
			this.chkIsComputer.TabIndex = 4;
			this.chkIsComputer.Text = "Requires Prep: This assembly type is a computer or requires prep before shipping." +
    "";
			this.chkIsComputer.UseVisualStyleBackColor = true;
			// 
			// txtAssemblyTypeDescription
			// 
			this.txtAssemblyTypeDescription.Location = new System.Drawing.Point(136, 42);
			this.txtAssemblyTypeDescription.MaxLength = 128;
			this.txtAssemblyTypeDescription.Name = "txtAssemblyTypeDescription";
			this.txtAssemblyTypeDescription.Size = new System.Drawing.Size(359, 20);
			this.txtAssemblyTypeDescription.TabIndex = 3;
			this.txtAssemblyTypeDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblAssemblyTypeDescription
			// 
			this.lblAssemblyTypeDescription.AutoSize = true;
			this.lblAssemblyTypeDescription.Location = new System.Drawing.Point(70, 45);
			this.lblAssemblyTypeDescription.Name = "lblAssemblyTypeDescription";
			this.lblAssemblyTypeDescription.Size = new System.Drawing.Size(60, 13);
			this.lblAssemblyTypeDescription.TabIndex = 2;
			this.lblAssemblyTypeDescription.Text = "Description";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(483, 366);
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
			this.btnOK.Location = new System.Drawing.Point(564, 366);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Customs Description";
			// 
			// txtCustomsDescription
			// 
			this.txtCustomsDescription.Location = new System.Drawing.Point(136, 114);
			this.txtCustomsDescription.MaxLength = 32;
			this.txtCustomsDescription.Name = "txtCustomsDescription";
			this.txtCustomsDescription.Size = new System.Drawing.Size(211, 20);
			this.txtCustomsDescription.TabIndex = 7;
			this.txtCustomsDescription.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Tariff Code";
			// 
			// mtxtTariffCode
			// 
			this.mtxtTariffCode.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.mtxtTariffCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtTariffCode.HidePromptOnLeave = true;
			this.mtxtTariffCode.Location = new System.Drawing.Point(136, 141);
			this.mtxtTariffCode.Mask = "0000.00.0000";
			this.mtxtTariffCode.Name = "mtxtTariffCode";
			this.mtxtTariffCode.PromptChar = 'x';
			this.mtxtTariffCode.Size = new System.Drawing.Size(83, 20);
			this.mtxtTariffCode.TabIndex = 9;
			this.mtxtTariffCode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.mtxtTariffCode.Enter += new System.EventHandler(this.MaskedTextBox_Enter);
			// 
			// FormAdmin_AssemblyType_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(651, 401);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlAssemblyTypeEdit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAdmin_AssemblyType_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Assembly Type";
			this.Load += new System.EventHandler(this.FormAdmin_AssemblyType_AddEdit_Load);
			this.pnlAssemblyTypeEdit.ResumeLayout(false);
			this.pnlAssemblyTypeEdit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlAssemblyTypeEdit;
		private System.Windows.Forms.TextBox txtAssemblyTypeDescription;
		private System.Windows.Forms.Label lblAssemblyTypeDescription;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.CheckBox chkIsComputer;
		private System.Windows.Forms.TextBox txtSerialNumberFormat;
		private System.Windows.Forms.Label lblSerialNumberFormat;
		private System.Windows.Forms.LinkLabel lnkRegexLink;
		private System.Windows.Forms.Label lblRegexExamples;
		private System.Windows.Forms.Label lblRegexHelp;
		private System.Windows.Forms.CheckBox chkAllowDiscard;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.MaskedTextBox mtxtTariffCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCustomsDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}