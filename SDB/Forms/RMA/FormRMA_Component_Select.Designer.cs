namespace SDB.Forms.RMA
{
	partial class FormRMA_Component_Select
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
			this.pnlComponent = new System.Windows.Forms.Panel();
			this.txtSilkscreenLetter = new System.Windows.Forms.TextBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.numQty = new System.Windows.Forms.NumericUpDown();
			this.txtSilkscreenNumbers = new System.Windows.Forms.TextBox();
			this.lblSilkscreenLetter = new System.Windows.Forms.Label();
			this.lblSilkscreenNumbers = new System.Windows.Forms.Label();
			this.cmbComponent = new System.Windows.Forms.ComboBox();
			this.lblComponent = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btnNew = new System.Windows.Forms.Button();
			this.pnlComponent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlComponent
			// 
			this.pnlComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlComponent.Controls.Add(this.txtSilkscreenLetter);
			this.pnlComponent.Controls.Add(this.lblQty);
			this.pnlComponent.Controls.Add(this.numQty);
			this.pnlComponent.Controls.Add(this.txtSilkscreenNumbers);
			this.pnlComponent.Controls.Add(this.lblSilkscreenLetter);
			this.pnlComponent.Controls.Add(this.lblSilkscreenNumbers);
			this.pnlComponent.Controls.Add(this.cmbComponent);
			this.pnlComponent.Controls.Add(this.lblComponent);
			this.pnlComponent.Location = new System.Drawing.Point(12, 12);
			this.pnlComponent.Name = "pnlComponent";
			this.pnlComponent.Size = new System.Drawing.Size(510, 128);
			this.pnlComponent.TabIndex = 0;
			// 
			// txtSilkscreenLetter
			// 
			this.txtSilkscreenLetter.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSilkscreenLetter.Location = new System.Drawing.Point(71, 77);
			this.txtSilkscreenLetter.MaxLength = 7;
			this.txtSilkscreenLetter.Name = "txtSilkscreenLetter";
			this.txtSilkscreenLetter.Size = new System.Drawing.Size(61, 20);
			this.txtSilkscreenLetter.TabIndex = 5;
			this.toolTip.SetToolTip(this.txtSilkscreenLetter, "Silkscreen ID Letter designation. For example \"R\" for resistors.");
			this.txtSilkscreenLetter.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblQty
			// 
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(3, 60);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(46, 13);
			this.lblQty.TabIndex = 2;
			this.lblQty.Text = "Quantity";
			// 
			// numQty
			// 
			this.numQty.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numQty.Location = new System.Drawing.Point(6, 77);
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
			this.numQty.TabIndex = 3;
			this.toolTip.SetToolTip(this.numQty, "Silkscreen ID not applicable for quantities over 1.");
			this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numQty.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// txtSilkscreenNumbers
			// 
			this.txtSilkscreenNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSilkscreenNumbers.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSilkscreenNumbers.Location = new System.Drawing.Point(140, 76);
			this.txtSilkscreenNumbers.Multiline = true;
			this.txtSilkscreenNumbers.Name = "txtSilkscreenNumbers";
			this.txtSilkscreenNumbers.Size = new System.Drawing.Size(367, 49);
			this.txtSilkscreenNumbers.TabIndex = 7;
			this.toolTip.SetToolTip(this.txtSilkscreenNumbers, "Silkscreen ID number. Multiples can be entered using commas and hypens.\r\nFor exam" +
        "ple: 100, 105, 110-113");
			this.txtSilkscreenNumbers.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblSilkscreenLetter
			// 
			this.lblSilkscreenLetter.AutoSize = true;
			this.lblSilkscreenLetter.Location = new System.Drawing.Point(68, 61);
			this.lblSilkscreenLetter.Name = "lblSilkscreenLetter";
			this.lblSilkscreenLetter.Size = new System.Drawing.Size(62, 13);
			this.lblSilkscreenLetter.TabIndex = 4;
			this.lblSilkscreenLetter.Text = "SSID Letter";
			// 
			// lblSilkscreenNumbers
			// 
			this.lblSilkscreenNumbers.AutoSize = true;
			this.lblSilkscreenNumbers.Location = new System.Drawing.Point(137, 60);
			this.lblSilkscreenNumbers.Name = "lblSilkscreenNumbers";
			this.lblSilkscreenNumbers.Size = new System.Drawing.Size(83, 13);
			this.lblSilkscreenNumbers.TabIndex = 6;
			this.lblSilkscreenNumbers.Text = "SSID Number(s)";
			// 
			// cmbComponent
			// 
			this.cmbComponent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbComponent.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbComponent.FormattingEnabled = true;
			this.cmbComponent.Location = new System.Drawing.Point(3, 32);
			this.cmbComponent.MaxLength = 128;
			this.cmbComponent.Name = "cmbComponent";
			this.cmbComponent.Size = new System.Drawing.Size(504, 21);
			this.cmbComponent.TabIndex = 1;
			this.cmbComponent.SelectedIndexChanged += new System.EventHandler(this.cmbComponent_SelectedIndexChanged);
			// 
			// lblComponent
			// 
			this.lblComponent.AutoSize = true;
			this.lblComponent.Location = new System.Drawing.Point(3, 16);
			this.lblComponent.Name = "lblComponent";
			this.lblComponent.Size = new System.Drawing.Size(61, 13);
			this.lblComponent.TabIndex = 0;
			this.lblComponent.Text = "Component";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(447, 146);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(366, 146);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnNew
			// 
			this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNew.Location = new System.Drawing.Point(15, 146);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 23);
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "New Component";
			this.toolTip.SetToolTip(this.btnNew, "Component not listed; click to add a new component.");
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// FormRMA_Component_Select
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(534, 181);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.pnlComponent);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(750, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 190);
			this.Name = "FormRMA_Component_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Specify Component";
			this.pnlComponent.ResumeLayout(false);
			this.pnlComponent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlComponent;
		private System.Windows.Forms.ComboBox cmbComponent;
		private System.Windows.Forms.Label lblComponent;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtSilkscreenNumbers;
		private System.Windows.Forms.Label lblSilkscreenNumbers;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.NumericUpDown numQty;
		private System.Windows.Forms.TextBox txtSilkscreenLetter;
		private System.Windows.Forms.Label lblSilkscreenLetter;
	}
}