namespace SDB.UserControls.RMA
{
	partial class ucLegacyRMAPartLineEditor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlPartLine = new System.Windows.Forms.Panel();
			this.numQty = new System.Windows.Forms.NumericUpDown();
			this.txtDisplayName = new System.Windows.Forms.TextBox();
			this.lblDisplayName = new System.Windows.Forms.Label();
			this.txtJobNumber = new System.Windows.Forms.TextBox();
			this.lblJobNumber = new System.Windows.Forms.Label();
			this.lblDesignation = new System.Windows.Forms.Label();
			this.lblPriority = new System.Windows.Forms.Label();
			this.cmbPriority = new System.Windows.Forms.ComboBox();
			this.txtRepair = new System.Windows.Forms.RichTextBox();
			this.cmbPart = new System.Windows.Forms.ComboBox();
			this.txtMfg = new System.Windows.Forms.TextBox();
			this.lblRepair = new System.Windows.Forms.Label();
			this.lblPart = new System.Windows.Forms.Label();
			this.lblMfg = new System.Windows.Forms.Label();
			this.lblQty = new System.Windows.Forms.Label();
			this.pnlPartLine.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlPartLine
			// 
			this.pnlPartLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlPartLine.Controls.Add(this.numQty);
			this.pnlPartLine.Controls.Add(this.txtDisplayName);
			this.pnlPartLine.Controls.Add(this.lblDisplayName);
			this.pnlPartLine.Controls.Add(this.txtJobNumber);
			this.pnlPartLine.Controls.Add(this.lblJobNumber);
			this.pnlPartLine.Controls.Add(this.lblDesignation);
			this.pnlPartLine.Controls.Add(this.lblPriority);
			this.pnlPartLine.Controls.Add(this.cmbPriority);
			this.pnlPartLine.Controls.Add(this.txtRepair);
			this.pnlPartLine.Controls.Add(this.cmbPart);
			this.pnlPartLine.Controls.Add(this.txtMfg);
			this.pnlPartLine.Controls.Add(this.lblRepair);
			this.pnlPartLine.Controls.Add(this.lblPart);
			this.pnlPartLine.Controls.Add(this.lblMfg);
			this.pnlPartLine.Controls.Add(this.lblQty);
			this.pnlPartLine.Location = new System.Drawing.Point(0, 0);
			this.pnlPartLine.Name = "pnlPartLine";
			this.pnlPartLine.Size = new System.Drawing.Size(895, 88);
			this.pnlPartLine.TabIndex = 68;
			// 
			// numQty
			// 
			this.numQty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numQty.Location = new System.Drawing.Point(32, 20);
			this.numQty.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numQty.Name = "numQty";
			this.numQty.Size = new System.Drawing.Size(58, 22);
			this.numQty.TabIndex = 2;
			this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
			this.numQty.Enter += new System.EventHandler(this.numQty_Enter);
			// 
			// txtDisplayName
			// 
			this.txtDisplayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.txtDisplayName.Enabled = false;
			this.txtDisplayName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplayName.Location = new System.Drawing.Point(32, 61);
			this.txtDisplayName.MaxLength = 100;
			this.txtDisplayName.Name = "txtDisplayName";
			this.txtDisplayName.ReadOnly = true;
			this.txtDisplayName.Size = new System.Drawing.Size(151, 20);
			this.txtDisplayName.TabIndex = 14;
			this.txtDisplayName.Visible = false;
			this.txtDisplayName.TextChanged += new System.EventHandler(this.txtDisplayName_TextChanged);
			// 
			// lblDisplayName
			// 
			this.lblDisplayName.AutoSize = true;
			this.lblDisplayName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisplayName.Location = new System.Drawing.Point(29, 45);
			this.lblDisplayName.Name = "lblDisplayName";
			this.lblDisplayName.Size = new System.Drawing.Size(80, 14);
			this.lblDisplayName.TabIndex = 13;
			this.lblDisplayName.Text = "Display Name";
			this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDisplayName.Visible = false;
			// 
			// txtJobNumber
			// 
			this.txtJobNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.txtJobNumber.Enabled = false;
			this.txtJobNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJobNumber.Location = new System.Drawing.Point(189, 61);
			this.txtJobNumber.MaxLength = 10;
			this.txtJobNumber.Name = "txtJobNumber";
			this.txtJobNumber.ReadOnly = true;
			this.txtJobNumber.Size = new System.Drawing.Size(84, 20);
			this.txtJobNumber.TabIndex = 12;
			this.txtJobNumber.Visible = false;
			this.txtJobNumber.TextChanged += new System.EventHandler(this.txtJobNumber_TextChanged);
			// 
			// lblJobNumber
			// 
			this.lblJobNumber.AutoSize = true;
			this.lblJobNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblJobNumber.Location = new System.Drawing.Point(186, 45);
			this.lblJobNumber.Name = "lblJobNumber";
			this.lblJobNumber.Size = new System.Drawing.Size(74, 14);
			this.lblJobNumber.TabIndex = 11;
			this.lblJobNumber.Text = "Job Number";
			this.lblJobNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblJobNumber.Visible = false;
			// 
			// lblDesignation
			// 
			this.lblDesignation.BackColor = System.Drawing.Color.Gainsboro;
			this.lblDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesignation.Location = new System.Drawing.Point(3, 3);
			this.lblDesignation.Name = "lblDesignation";
			this.lblDesignation.Size = new System.Drawing.Size(20, 81);
			this.lblDesignation.TabIndex = 0;
			this.lblDesignation.Text = "#";
			this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPriority
			// 
			this.lblPriority.AutoSize = true;
			this.lblPriority.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriority.Location = new System.Drawing.Point(300, 58);
			this.lblPriority.Name = "lblPriority";
			this.lblPriority.Size = new System.Drawing.Size(54, 16);
			this.lblPriority.TabIndex = 7;
			this.lblPriority.Text = "Priority";
			this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmbPriority
			// 
			this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPriority.Enabled = false;
			this.cmbPriority.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPriority.FormattingEnabled = true;
			this.cmbPriority.Items.AddRange(new object[] {
            "",
            "2 Days",
            "5 Days",
            "15 Days",
            "No Priority"});
			this.cmbPriority.Location = new System.Drawing.Point(360, 55);
			this.cmbPriority.Name = "cmbPriority";
			this.cmbPriority.Size = new System.Drawing.Size(174, 24);
			this.cmbPriority.TabIndex = 8;
			this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
			// 
			// txtRepair
			// 
			this.txtRepair.Enabled = false;
			this.txtRepair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRepair.Location = new System.Drawing.Point(556, 22);
			this.txtRepair.MaxLength = 200;
			this.txtRepair.Name = "txtRepair";
			this.txtRepair.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.txtRepair.Size = new System.Drawing.Size(334, 57);
			this.txtRepair.TabIndex = 10;
			this.txtRepair.Text = "";
			this.txtRepair.TextChanged += new System.EventHandler(this.txtRepair_TextChanged);
			// 
			// cmbPart
			// 
			this.cmbPart.Enabled = false;
			this.cmbPart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPart.FormattingEnabled = true;
			this.cmbPart.Items.AddRange(new object[] {
            "",
            "LED Boards",
            "LED Power Supplies",
            "Battery Backup Unit",
            "Beehive Head",
            "Beehive Hub",
            "Bug Smasher",
            "Camera",
            "Camera Server",
            "Computer",
            "Diagnostics Card",
            "Display Fan",
            "Distribution Card",
            "iBoot",
            "Minigoose",
            "Miscellaneous Hardware",
            "Monitor",
            "Network Router/Firewall",
            "Power Distribution/Fuse Board",
            "Power Supply: 3.3KVA Transformer",
            "Power Supply: Dongah",
            "PrismView Mini Controller",
            "Rectifier Board",
            "Temp Probe 15",
            "Temp Probe 16",
            "Y3 Interface",
            "Y4 D Card",
            "Y4 DVI Card",
            "Y5DVIX8 Interface"});
			this.cmbPart.Location = new System.Drawing.Point(360, 19);
			this.cmbPart.MaxLength = 30;
			this.cmbPart.Name = "cmbPart";
			this.cmbPart.Size = new System.Drawing.Size(174, 24);
			this.cmbPart.TabIndex = 6;
			this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.cmbPart_SelectedIndexChanged);
			// 
			// txtMfg
			// 
			this.txtMfg.Enabled = false;
			this.txtMfg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMfg.Location = new System.Drawing.Point(112, 20);
			this.txtMfg.MaxLength = 30;
			this.txtMfg.Name = "txtMfg";
			this.txtMfg.Size = new System.Drawing.Size(108, 22);
			this.txtMfg.TabIndex = 4;
			this.txtMfg.Text = "Yesco";
			this.txtMfg.TextChanged += new System.EventHandler(this.txtMfg_TextChanged);
			// 
			// lblRepair
			// 
			this.lblRepair.AutoSize = true;
			this.lblRepair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRepair.Location = new System.Drawing.Point(553, 3);
			this.lblRepair.Name = "lblRepair";
			this.lblRepair.Size = new System.Drawing.Size(181, 16);
			this.lblRepair.TabIndex = 9;
			this.lblRepair.Text = "Describe the repair needed";
			this.lblRepair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPart
			// 
			this.lblPart.AutoSize = true;
			this.lblPart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPart.Location = new System.Drawing.Point(245, 22);
			this.lblPart.Name = "lblPart";
			this.lblPart.Size = new System.Drawing.Size(109, 16);
			this.lblPart.TabIndex = 5;
			this.lblPart.Text = "Part Description";
			this.lblPart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMfg
			// 
			this.lblMfg.AutoSize = true;
			this.lblMfg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMfg.Location = new System.Drawing.Point(109, 3);
			this.lblMfg.Name = "lblMfg";
			this.lblMfg.Size = new System.Drawing.Size(92, 16);
			this.lblMfg.TabIndex = 3;
			this.lblMfg.Text = "Manufacturer";
			this.lblMfg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblQty
			// 
			this.lblQty.AutoSize = true;
			this.lblQty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQty.Location = new System.Drawing.Point(29, 3);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(61, 16);
			this.lblQty.TabIndex = 1;
			this.lblQty.Text = "Quantity";
			this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ucRMAPartLineEditor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlPartLine);
			this.Name = "ucRMAPartLineEditor";
			this.Size = new System.Drawing.Size(895, 88);
			this.pnlPartLine.ResumeLayout(false);
			this.pnlPartLine.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlPartLine;
		private System.Windows.Forms.Label lblDesignation;
		private System.Windows.Forms.Label lblPriority;
		private System.Windows.Forms.ComboBox cmbPriority;
		private System.Windows.Forms.RichTextBox txtRepair;
		private System.Windows.Forms.ComboBox cmbPart;
		private System.Windows.Forms.TextBox txtMfg;
		private System.Windows.Forms.Label lblRepair;
		private System.Windows.Forms.Label lblPart;
		private System.Windows.Forms.Label lblMfg;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtJobNumber;
		private System.Windows.Forms.Label lblJobNumber;
		private System.Windows.Forms.TextBox txtDisplayName;
		private System.Windows.Forms.Label lblDisplayName;
		private System.Windows.Forms.NumericUpDown numQty;
	}
}
