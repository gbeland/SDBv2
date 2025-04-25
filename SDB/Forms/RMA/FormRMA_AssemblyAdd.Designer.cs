namespace SDB.Forms.RMA
{
	partial class FormRMA_AssemblyAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlAssemblyAdd = new System.Windows.Forms.Panel();
            this.grpAssetInfo = new System.Windows.Forms.GroupBox();
            this.txtAsset_ModulePitch = new System.Windows.Forms.TextBox();
            this.txtAsset_Interface = new System.Windows.Forms.TextBox();
            this.lblAsset_ModulePitch = new System.Windows.Forms.Label();
            this.lblAsset_Interface = new System.Windows.Forms.Label();
            this.chkDiscard = new System.Windows.Forms.CheckBox();
            this.lblAssembly = new System.Windows.Forms.Label();
            this.cmbAssembly = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbFailureType = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblFailureNotes = new System.Windows.Forms.Label();
            this.lblFailureType = new System.Windows.Forms.Label();
            this.txtFailureNotes = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblAssemNum = new System.Windows.Forms.Label();
            this.tbxAssemNum = new System.Windows.Forms.TextBox();
            this.pnlAssemblyAdd.SuspendLayout();
            this.grpAssetInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(707, 307);
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
            this.btnOK.Location = new System.Drawing.Point(788, 307);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlAssemblyAdd
            // 
            this.pnlAssemblyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAssemblyAdd.Controls.Add(this.grpAssetInfo);
            this.pnlAssemblyAdd.Controls.Add(this.chkDiscard);
            this.pnlAssemblyAdd.Controls.Add(this.lblAssembly);
            this.pnlAssemblyAdd.Controls.Add(this.cmbAssembly);
            this.pnlAssemblyAdd.Controls.Add(this.lblQty);
            this.pnlAssemblyAdd.Controls.Add(this.numQty);
            this.pnlAssemblyAdd.Controls.Add(this.cmbFailureType);
            this.pnlAssemblyAdd.Controls.Add(this.txtLocation);
            this.pnlAssemblyAdd.Controls.Add(this.lblLocation);
            this.pnlAssemblyAdd.Controls.Add(this.lblFailureNotes);
            this.pnlAssemblyAdd.Controls.Add(this.lblFailureType);
            this.pnlAssemblyAdd.Controls.Add(this.txtFailureNotes);
            this.pnlAssemblyAdd.Controls.Add(this.lblCategory);
            this.pnlAssemblyAdd.Controls.Add(this.lblType);
            this.pnlAssemblyAdd.Controls.Add(this.cmbCategory);
            this.pnlAssemblyAdd.Controls.Add(this.cmbType);
            this.pnlAssemblyAdd.Location = new System.Drawing.Point(12, 12);
            this.pnlAssemblyAdd.Name = "pnlAssemblyAdd";
            this.pnlAssemblyAdd.Size = new System.Drawing.Size(851, 289);
            this.pnlAssemblyAdd.TabIndex = 0;
            // 
            // grpAssetInfo
            // 
            this.grpAssetInfo.Controls.Add(this.tbxAssemNum);
            this.grpAssetInfo.Controls.Add(this.lblAssemNum);
            this.grpAssetInfo.Controls.Add(this.txtAsset_ModulePitch);
            this.grpAssetInfo.Controls.Add(this.txtAsset_Interface);
            this.grpAssetInfo.Controls.Add(this.lblAsset_ModulePitch);
            this.grpAssetInfo.Controls.Add(this.lblAsset_Interface);
            this.grpAssetInfo.Location = new System.Drawing.Point(574, 11);
            this.grpAssetInfo.Name = "grpAssetInfo";
            this.grpAssetInfo.Size = new System.Drawing.Size(274, 120);
            this.grpAssetInfo.TabIndex = 15;
            this.grpAssetInfo.TabStop = false;
            this.grpAssetInfo.Text = "Asset Info";
            // 
            // txtAsset_ModulePitch
            // 
            this.txtAsset_ModulePitch.Location = new System.Drawing.Point(105, 43);
            this.txtAsset_ModulePitch.Name = "txtAsset_ModulePitch";
            this.txtAsset_ModulePitch.ReadOnly = true;
            this.txtAsset_ModulePitch.Size = new System.Drawing.Size(163, 20);
            this.txtAsset_ModulePitch.TabIndex = 3;
            // 
            // txtAsset_Interface
            // 
            this.txtAsset_Interface.Location = new System.Drawing.Point(105, 17);
            this.txtAsset_Interface.Name = "txtAsset_Interface";
            this.txtAsset_Interface.ReadOnly = true;
            this.txtAsset_Interface.Size = new System.Drawing.Size(163, 20);
            this.txtAsset_Interface.TabIndex = 2;
            // 
            // lblAsset_ModulePitch
            // 
            this.lblAsset_ModulePitch.AutoSize = true;
            this.lblAsset_ModulePitch.Location = new System.Drawing.Point(44, 43);
            this.lblAsset_ModulePitch.Name = "lblAsset_ModulePitch";
            this.lblAsset_ModulePitch.Size = new System.Drawing.Size(58, 13);
            this.lblAsset_ModulePitch.TabIndex = 1;
            this.lblAsset_ModulePitch.Text = "LED Pitch:";
            // 
            // lblAsset_Interface
            // 
            this.lblAsset_Interface.AutoSize = true;
            this.lblAsset_Interface.Location = new System.Drawing.Point(24, 20);
            this.lblAsset_Interface.Name = "lblAsset_Interface";
            this.lblAsset_Interface.Size = new System.Drawing.Size(79, 13);
            this.lblAsset_Interface.TabIndex = 0;
            this.lblAsset_Interface.Text = "Interface Type:";
            // 
            // chkDiscard
            // 
            this.chkDiscard.AutoSize = true;
            this.chkDiscard.Location = new System.Drawing.Point(433, 152);
            this.chkDiscard.Name = "chkDiscard";
            this.chkDiscard.Size = new System.Drawing.Size(135, 17);
            this.chkDiscard.TabIndex = 12;
            this.chkDiscard.Text = "Discarded by Customer";
            this.toolTip.SetToolTip(this.chkDiscard, "Indicates that defective item will be discarded by customer and not returned.");
            this.chkDiscard.UseVisualStyleBackColor = true;
            // 
            // lblAssembly
            // 
            this.lblAssembly.AutoSize = true;
            this.lblAssembly.Location = new System.Drawing.Point(65, 94);
            this.lblAssembly.Name = "lblAssembly";
            this.lblAssembly.Size = new System.Drawing.Size(51, 13);
            this.lblAssembly.TabIndex = 6;
            this.lblAssembly.Text = "Assembly";
            // 
            // cmbAssembly
            // 
            this.cmbAssembly.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAssembly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssembly.FormattingEnabled = true;
            this.cmbAssembly.Location = new System.Drawing.Point(68, 110);
            this.cmbAssembly.Name = "cmbAssembly";
            this.cmbAssembly.Size = new System.Drawing.Size(500, 21);
            this.cmbAssembly.TabIndex = 7;
            this.cmbAssembly.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAssembly_DrawItem);
            this.cmbAssembly.SelectedIndexChanged += new System.EventHandler(this.cmbAssembly_SelectedIndexChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(3, 93);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Qty";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(3, 110);
            this.numQty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(59, 20);
            this.numQty.TabIndex = 5;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Enter += new System.EventHandler(this.NumUpDown_Enter);
            // 
            // cmbFailureType
            // 
            this.cmbFailureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFailureType.FormattingEnabled = true;
            this.cmbFailureType.Location = new System.Drawing.Point(68, 150);
            this.cmbFailureType.Name = "cmbFailureType";
            this.cmbFailureType.Size = new System.Drawing.Size(307, 21);
            this.cmbFailureType.TabIndex = 11;
            this.cmbFailureType.SelectedIndexChanged += new System.EventHandler(this.cmbFailureType_SelectedIndexChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(776, 154);
            this.txtLocation.MaxLength = 8;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(67, 20);
            this.txtLocation.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtLocation, "Location on sign, if applicable. For example, \"H-08\" or \"Bottom\"");
            this.txtLocation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(722, 158);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // lblFailureNotes
            // 
            this.lblFailureNotes.AutoSize = true;
            this.lblFailureNotes.Location = new System.Drawing.Point(65, 174);
            this.lblFailureNotes.Name = "lblFailureNotes";
            this.lblFailureNotes.Size = new System.Drawing.Size(69, 13);
            this.lblFailureNotes.TabIndex = 13;
            this.lblFailureNotes.Text = "Failure Notes";
            // 
            // lblFailureType
            // 
            this.lblFailureType.AutoSize = true;
            this.lblFailureType.Location = new System.Drawing.Point(65, 134);
            this.lblFailureType.Name = "lblFailureType";
            this.lblFailureType.Size = new System.Drawing.Size(65, 13);
            this.lblFailureType.TabIndex = 10;
            this.lblFailureType.Text = "Failure Type";
            // 
            // txtFailureNotes
            // 
            this.txtFailureNotes.Location = new System.Drawing.Point(68, 190);
            this.txtFailureNotes.MaxLength = 1024;
            this.txtFailureNotes.Multiline = true;
            this.txtFailureNotes.Name = "txtFailureNotes";
            this.txtFailureNotes.Size = new System.Drawing.Size(780, 92);
            this.txtFailureNotes.TabIndex = 14;
            this.txtFailureNotes.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(65, 11);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(65, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(68, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(500, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(68, 67);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(500, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbAssemblyType_SelectedIndexChanged);
            // 
            // lblAssemNum
            // 
            this.lblAssemNum.AutoSize = true;
            this.lblAssemNum.Location = new System.Drawing.Point(25, 72);
            this.lblAssemNum.Name = "lblAssemNum";
            this.lblAssemNum.Size = new System.Drawing.Size(78, 13);
            this.lblAssemNum.TabIndex = 4;
            this.lblAssemNum.Text = "LED Assembly:";
            // 
            // tbxAssemNum
            // 
            this.tbxAssemNum.Location = new System.Drawing.Point(105, 69);
            this.tbxAssemNum.Name = "tbxAssemNum";
            this.tbxAssemNum.ReadOnly = true;
            this.tbxAssemNum.Size = new System.Drawing.Size(162, 20);
            this.tbxAssemNum.TabIndex = 5;
            // 
            // FormRMA_AssemblyAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(875, 342);
            this.Controls.Add(this.pnlAssemblyAdd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRMA_AssemblyAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RMA: Add Assembly";
            this.pnlAssemblyAdd.ResumeLayout(false);
            this.pnlAssemblyAdd.PerformLayout();
            this.grpAssetInfo.ResumeLayout(false);
            this.grpAssetInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Panel pnlAssemblyAdd;
		private System.Windows.Forms.ComboBox cmbFailureType;
		private System.Windows.Forms.TextBox txtLocation;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label lblFailureNotes;
		private System.Windows.Forms.Label lblFailureType;
		private System.Windows.Forms.TextBox txtFailureNotes;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.NumericUpDown numQty;
		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.ComboBox cmbAssembly;
		private System.Windows.Forms.CheckBox chkDiscard;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox grpAssetInfo;
        private System.Windows.Forms.TextBox txtAsset_ModulePitch;
        private System.Windows.Forms.TextBox txtAsset_Interface;
        private System.Windows.Forms.Label lblAsset_ModulePitch;
        private System.Windows.Forms.Label lblAsset_Interface;
        private System.Windows.Forms.TextBox tbxAssemNum;
        private System.Windows.Forms.Label lblAssemNum;
    }
}