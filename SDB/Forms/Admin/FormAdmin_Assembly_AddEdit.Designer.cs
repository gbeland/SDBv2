namespace SDB.Forms.Admin
{
	partial class FormAdmin_Assembly_AddEdit
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
            this.pnlAssemblyEdit = new System.Windows.Forms.Panel();
            this.grpInventoryItems = new System.Windows.Forms.GroupBox();
            this.txtAssemblyLocation = new System.Windows.Forms.TextBox();
            this.lblAssemblyLocation = new System.Windows.Forms.Label();
            this.numAssemblyCost = new System.Windows.Forms.NumericUpDown();
            this.lblAssemblyCost = new System.Windows.Forms.Label();
            this.lblAssemblyInventoryQty = new System.Windows.Forms.Label();
            this.numAssemblyInventoryQty = new System.Windows.Forms.NumericUpDown();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.lblReplacement = new System.Windows.Forms.Label();
            this.cmbReplacementAssy = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtAssemblyDescription = new System.Windows.Forms.TextBox();
            this.lblAssemblyDescription = new System.Windows.Forms.Label();
            this.lblAssemblyCategory = new System.Windows.Forms.Label();
            this.lblAssemblyType = new System.Windows.Forms.Label();
            this.cmbAssemblyCategory = new System.Windows.Forms.ComboBox();
            this.cmbAssemblyType = new System.Windows.Forms.ComboBox();
            this.txtAssemblyNumber = new System.Windows.Forms.TextBox();
            this.lblAssemblyNumber = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxThirdParty = new System.Windows.Forms.CheckBox();
            this.pnlAssemblyEdit.SuspendLayout();
            this.grpInventoryItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAssemblyCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssemblyInventoryQty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(460, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAssemblyEdit
            // 
            this.pnlAssemblyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAssemblyEdit.Controls.Add(this.cbxThirdParty);
            this.pnlAssemblyEdit.Controls.Add(this.grpInventoryItems);
            this.pnlAssemblyEdit.Controls.Add(this.chkDisabled);
            this.pnlAssemblyEdit.Controls.Add(this.lblReplacement);
            this.pnlAssemblyEdit.Controls.Add(this.cmbReplacementAssy);
            this.pnlAssemblyEdit.Controls.Add(this.btnImport);
            this.pnlAssemblyEdit.Controls.Add(this.txtAssemblyDescription);
            this.pnlAssemblyEdit.Controls.Add(this.lblAssemblyDescription);
            this.pnlAssemblyEdit.Controls.Add(this.lblAssemblyCategory);
            this.pnlAssemblyEdit.Controls.Add(this.lblAssemblyType);
            this.pnlAssemblyEdit.Controls.Add(this.cmbAssemblyCategory);
            this.pnlAssemblyEdit.Controls.Add(this.cmbAssemblyType);
            this.pnlAssemblyEdit.Controls.Add(this.txtAssemblyNumber);
            this.pnlAssemblyEdit.Controls.Add(this.lblAssemblyNumber);
            this.pnlAssemblyEdit.Location = new System.Drawing.Point(12, 12);
            this.pnlAssemblyEdit.Name = "pnlAssemblyEdit";
            this.pnlAssemblyEdit.Size = new System.Drawing.Size(604, 240);
            this.pnlAssemblyEdit.TabIndex = 0;
            // 
            // grpInventoryItems
            // 
            this.grpInventoryItems.Controls.Add(this.txtAssemblyLocation);
            this.grpInventoryItems.Controls.Add(this.lblAssemblyLocation);
            this.grpInventoryItems.Controls.Add(this.numAssemblyCost);
            this.grpInventoryItems.Controls.Add(this.lblAssemblyCost);
            this.grpInventoryItems.Controls.Add(this.lblAssemblyInventoryQty);
            this.grpInventoryItems.Controls.Add(this.numAssemblyInventoryQty);
            this.grpInventoryItems.Location = new System.Drawing.Point(101, 109);
            this.grpInventoryItems.Name = "grpInventoryItems";
            this.grpInventoryItems.Size = new System.Drawing.Size(454, 52);
            this.grpInventoryItems.TabIndex = 9;
            this.grpInventoryItems.TabStop = false;
            this.grpInventoryItems.Text = "Inventory Control";
            // 
            // txtAssemblyLocation
            // 
            this.txtAssemblyLocation.Location = new System.Drawing.Point(79, 19);
            this.txtAssemblyLocation.MaxLength = 16;
            this.txtAssemblyLocation.Name = "txtAssemblyLocation";
            this.txtAssemblyLocation.Size = new System.Drawing.Size(71, 20);
            this.txtAssemblyLocation.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAssemblyLocation, "Assembly location in stock room.");
            this.txtAssemblyLocation.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblAssemblyLocation
            // 
            this.lblAssemblyLocation.AutoSize = true;
            this.lblAssemblyLocation.Location = new System.Drawing.Point(23, 23);
            this.lblAssemblyLocation.Name = "lblAssemblyLocation";
            this.lblAssemblyLocation.Size = new System.Drawing.Size(48, 13);
            this.lblAssemblyLocation.TabIndex = 0;
            this.lblAssemblyLocation.Text = "Location";
            // 
            // numAssemblyCost
            // 
            this.numAssemblyCost.DecimalPlaces = 2;
            this.numAssemblyCost.Location = new System.Drawing.Point(351, 19);
            this.numAssemblyCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAssemblyCost.Name = "numAssemblyCost";
            this.numAssemblyCost.Size = new System.Drawing.Size(71, 20);
            this.numAssemblyCost.TabIndex = 5;
            this.numAssemblyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAssemblyCost.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // lblAssemblyCost
            // 
            this.lblAssemblyCost.AutoSize = true;
            this.lblAssemblyCost.Location = new System.Drawing.Point(315, 23);
            this.lblAssemblyCost.Name = "lblAssemblyCost";
            this.lblAssemblyCost.Size = new System.Drawing.Size(28, 13);
            this.lblAssemblyCost.TabIndex = 4;
            this.lblAssemblyCost.Text = "Cost";
            // 
            // lblAssemblyInventoryQty
            // 
            this.lblAssemblyInventoryQty.AutoSize = true;
            this.lblAssemblyInventoryQty.Location = new System.Drawing.Point(158, 23);
            this.lblAssemblyInventoryQty.Name = "lblAssemblyInventoryQty";
            this.lblAssemblyInventoryQty.Size = new System.Drawing.Size(70, 13);
            this.lblAssemblyInventoryQty.TabIndex = 2;
            this.lblAssemblyInventoryQty.Text = "Inventory Qty";
            // 
            // numAssemblyInventoryQty
            // 
            this.numAssemblyInventoryQty.Location = new System.Drawing.Point(236, 19);
            this.numAssemblyInventoryQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAssemblyInventoryQty.Name = "numAssemblyInventoryQty";
            this.numAssemblyInventoryQty.Size = new System.Drawing.Size(71, 20);
            this.numAssemblyInventoryQty.TabIndex = 3;
            this.numAssemblyInventoryQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAssemblyInventoryQty.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDisabled.Location = new System.Drawing.Point(101, 187);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(123, 17);
            this.chkDisabled.TabIndex = 10;
            this.chkDisabled.Text = "Disabled/End of Life";
            this.toolTip1.SetToolTip(this.chkDisabled, "Indicates the assembly is disabled, obsolete, or end-of-life.");
            this.chkDisabled.UseVisualStyleBackColor = true;
            this.chkDisabled.CheckedChanged += new System.EventHandler(this.chkDisabled_CheckedChanged);
            // 
            // lblReplacement
            // 
            this.lblReplacement.AutoSize = true;
            this.lblReplacement.Enabled = false;
            this.lblReplacement.Location = new System.Drawing.Point(25, 213);
            this.lblReplacement.Name = "lblReplacement";
            this.lblReplacement.Size = new System.Drawing.Size(70, 13);
            this.lblReplacement.TabIndex = 11;
            this.lblReplacement.Text = "Replacement";
            // 
            // cmbReplacementAssy
            // 
            this.cmbReplacementAssy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReplacementAssy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplacementAssy.Enabled = false;
            this.cmbReplacementAssy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReplacementAssy.FormattingEnabled = true;
            this.cmbReplacementAssy.Location = new System.Drawing.Point(101, 210);
            this.cmbReplacementAssy.Name = "cmbReplacementAssy";
            this.cmbReplacementAssy.Size = new System.Drawing.Size(500, 21);
            this.cmbReplacementAssy.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmbReplacementAssy, "Repalcement assembly to use if the current assembly is disabled.");
            this.cmbReplacementAssy.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbReplacementAssy_DrawItem);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(306, 55);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(154, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import from Workbench";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtAssemblyDescription
            // 
            this.txtAssemblyDescription.Location = new System.Drawing.Point(101, 83);
            this.txtAssemblyDescription.MaxLength = 128;
            this.txtAssemblyDescription.Name = "txtAssemblyDescription";
            this.txtAssemblyDescription.Size = new System.Drawing.Size(359, 20);
            this.txtAssemblyDescription.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAssemblyDescription, "Assembly description.");
            this.txtAssemblyDescription.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblAssemblyDescription
            // 
            this.lblAssemblyDescription.AutoSize = true;
            this.lblAssemblyDescription.Location = new System.Drawing.Point(35, 86);
            this.lblAssemblyDescription.Name = "lblAssemblyDescription";
            this.lblAssemblyDescription.Size = new System.Drawing.Size(60, 13);
            this.lblAssemblyDescription.TabIndex = 7;
            this.lblAssemblyDescription.Text = "Description";
            // 
            // lblAssemblyCategory
            // 
            this.lblAssemblyCategory.AutoSize = true;
            this.lblAssemblyCategory.Location = new System.Drawing.Point(46, 5);
            this.lblAssemblyCategory.Name = "lblAssemblyCategory";
            this.lblAssemblyCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAssemblyCategory.TabIndex = 0;
            this.lblAssemblyCategory.Text = "Category";
            // 
            // lblAssemblyType
            // 
            this.lblAssemblyType.AutoSize = true;
            this.lblAssemblyType.Location = new System.Drawing.Point(17, 32);
            this.lblAssemblyType.Name = "lblAssemblyType";
            this.lblAssemblyType.Size = new System.Drawing.Size(78, 13);
            this.lblAssemblyType.TabIndex = 2;
            this.lblAssemblyType.Text = "Assembly Type";
            // 
            // cmbAssemblyCategory
            // 
            this.cmbAssemblyCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssemblyCategory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssemblyCategory.FormattingEnabled = true;
            this.cmbAssemblyCategory.Location = new System.Drawing.Point(101, 3);
            this.cmbAssemblyCategory.Name = "cmbAssemblyCategory";
            this.cmbAssemblyCategory.Size = new System.Drawing.Size(500, 21);
            this.cmbAssemblyCategory.TabIndex = 1;
            this.cmbAssemblyCategory.SelectedIndexChanged += new System.EventHandler(this.cmbAssemblyCategory_SelectedIndexChanged);
            // 
            // cmbAssemblyType
            // 
            this.cmbAssemblyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssemblyType.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssemblyType.FormattingEnabled = true;
            this.cmbAssemblyType.Location = new System.Drawing.Point(101, 30);
            this.cmbAssemblyType.Name = "cmbAssemblyType";
            this.cmbAssemblyType.Size = new System.Drawing.Size(500, 21);
            this.cmbAssemblyType.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbAssemblyType, "Assembly Type this assembly will belong to.");
            // 
            // txtAssemblyNumber
            // 
            this.txtAssemblyNumber.Location = new System.Drawing.Point(101, 57);
            this.txtAssemblyNumber.MaxLength = 32;
            this.txtAssemblyNumber.Name = "txtAssemblyNumber";
            this.txtAssemblyNumber.Size = new System.Drawing.Size(199, 20);
            this.txtAssemblyNumber.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtAssemblyNumber, "Unique assembly part number or identifier.");
            this.txtAssemblyNumber.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // lblAssemblyNumber
            // 
            this.lblAssemblyNumber.AutoSize = true;
            this.lblAssemblyNumber.Location = new System.Drawing.Point(4, 60);
            this.lblAssemblyNumber.Name = "lblAssemblyNumber";
            this.lblAssemblyNumber.Size = new System.Drawing.Size(91, 13);
            this.lblAssemblyNumber.TabIndex = 4;
            this.lblAssemblyNumber.Text = "Assembly Number";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(541, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxThirdParty
            // 
            this.cbxThirdParty.AutoSize = true;
            this.cbxThirdParty.Location = new System.Drawing.Point(101, 164);
            this.cbxThirdParty.Name = "cbxThirdParty";
            this.cbxThirdParty.Size = new System.Drawing.Size(77, 17);
            this.cbxThirdParty.TabIndex = 13;
            this.cbxThirdParty.Text = "Third Party";
            this.cbxThirdParty.UseVisualStyleBackColor = true;
            // 
            // FormAdmin_Assembly_AddEdit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(628, 293);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlAssemblyEdit);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin_Assembly_AddEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Assembly";
            this.pnlAssemblyEdit.ResumeLayout(false);
            this.pnlAssemblyEdit.PerformLayout();
            this.grpInventoryItems.ResumeLayout(false);
            this.grpInventoryItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAssemblyCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssemblyInventoryQty)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlAssemblyEdit;
		private System.Windows.Forms.TextBox txtAssemblyLocation;
		private System.Windows.Forms.TextBox txtAssemblyDescription;
		private System.Windows.Forms.NumericUpDown numAssemblyInventoryQty;
		private System.Windows.Forms.Label lblAssemblyInventoryQty;
		private System.Windows.Forms.Label lblAssemblyCost;
		private System.Windows.Forms.Label lblAssemblyLocation;
		private System.Windows.Forms.Label lblAssemblyDescription;
		private System.Windows.Forms.Label lblAssemblyType;
		private System.Windows.Forms.ComboBox cmbAssemblyType;
		private System.Windows.Forms.NumericUpDown numAssemblyCost;
		private System.Windows.Forms.TextBox txtAssemblyNumber;
		private System.Windows.Forms.Label lblAssemblyNumber;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.CheckBox chkDisabled;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblReplacement;
		private System.Windows.Forms.ComboBox cmbReplacementAssy;
		private System.Windows.Forms.Label lblAssemblyCategory;
		private System.Windows.Forms.ComboBox cmbAssemblyCategory;
		private System.Windows.Forms.GroupBox grpInventoryItems;
        private System.Windows.Forms.CheckBox cbxThirdParty;
    }
}