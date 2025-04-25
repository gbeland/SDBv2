using SDB.Classes.Misc;

namespace SDB.UserControls.RMA
{
	partial class ucLegacyRMAJobLogLine
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
			this.components = new System.ComponentModel.Container();
			this.pnlJobLogLine = new System.Windows.Forms.Panel();
			this.lblZone = new System.Windows.Forms.Label();
			this.cmbZone = new System.Windows.Forms.ComboBox();
			this.lblAPR_RiskKit = new System.Windows.Forms.Label();
			this.ndtpReturned = new NullableDateTimePicker();
			this.ndtpReceived = new NullableDateTimePicker();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblDateReceived = new System.Windows.Forms.Label();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtPart = new System.Windows.Forms.TextBox();
			this.lblPart = new System.Windows.Forms.Label();
			this.txtRepairs = new System.Windows.Forms.TextBox();
			this.lblRepairType = new System.Windows.Forms.Label();
			this.cmbRepairType = new System.Windows.Forms.ComboBox();
			this.lblDesignation = new System.Windows.Forms.Label();
			this.txtTracking = new System.Windows.Forms.TextBox();
			this.lblReturnTracking = new System.Windows.Forms.Label();
			this.txtReturnedBy = new System.Windows.Forms.TextBox();
			this.txtRepairedByTech = new System.Windows.Forms.TextBox();
			this.txtMU = new System.Windows.Forms.TextBox();
			this.lblDateReturned = new System.Windows.Forms.Label();
			this.lblReturnedBy = new System.Windows.Forms.Label();
			this.lblTech = new System.Windows.Forms.Label();
			this.lblMU = new System.Windows.Forms.Label();
			this.lblRepairs = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlJobLogLine.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlJobLogLine
			// 
			this.pnlJobLogLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlJobLogLine.Controls.Add(this.lblZone);
			this.pnlJobLogLine.Controls.Add(this.cmbZone);
			this.pnlJobLogLine.Controls.Add(this.lblAPR_RiskKit);
			this.pnlJobLogLine.Controls.Add(this.ndtpReturned);
			this.pnlJobLogLine.Controls.Add(this.ndtpReceived);
			this.pnlJobLogLine.Controls.Add(this.txtQty);
			this.pnlJobLogLine.Controls.Add(this.lblDateReceived);
			this.pnlJobLogLine.Controls.Add(this.lblQty);
			this.pnlJobLogLine.Controls.Add(this.txtPart);
			this.pnlJobLogLine.Controls.Add(this.lblPart);
			this.pnlJobLogLine.Controls.Add(this.txtRepairs);
			this.pnlJobLogLine.Controls.Add(this.lblRepairType);
			this.pnlJobLogLine.Controls.Add(this.cmbRepairType);
			this.pnlJobLogLine.Controls.Add(this.lblDesignation);
			this.pnlJobLogLine.Controls.Add(this.txtTracking);
			this.pnlJobLogLine.Controls.Add(this.lblReturnTracking);
			this.pnlJobLogLine.Controls.Add(this.txtReturnedBy);
			this.pnlJobLogLine.Controls.Add(this.txtRepairedByTech);
			this.pnlJobLogLine.Controls.Add(this.txtMU);
			this.pnlJobLogLine.Controls.Add(this.lblDateReturned);
			this.pnlJobLogLine.Controls.Add(this.lblReturnedBy);
			this.pnlJobLogLine.Controls.Add(this.lblTech);
			this.pnlJobLogLine.Controls.Add(this.lblMU);
			this.pnlJobLogLine.Controls.Add(this.lblRepairs);
			this.pnlJobLogLine.Location = new System.Drawing.Point(0, 0);
			this.pnlJobLogLine.Name = "pnlJobLogLine";
			this.pnlJobLogLine.Size = new System.Drawing.Size(905, 109);
			this.pnlJobLogLine.TabIndex = 0;
			// 
			// lblZone
			// 
			this.lblZone.AutoSize = true;
			this.lblZone.Location = new System.Drawing.Point(355, 1);
			this.lblZone.Name = "lblZone";
			this.lblZone.Size = new System.Drawing.Size(32, 13);
			this.lblZone.TabIndex = 7;
			this.lblZone.Text = "Zone";
			this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbZone
			// 
			this.cmbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZone.FormattingEnabled = true;
			this.cmbZone.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "AA",
            "BB",
            "CC",
            "DD",
            "EE",
            "FF",
            "GG",
            "HH",
            "II",
            "JJ",
            "KK",
            "LL",
            "MM",
            "NN",
            "OO",
            "PP",
            "QQ",
            "RR",
            "SS",
            "TT",
            "UU",
            "VV",
            "WW",
            "XX",
            "YY",
            "ZZ"});
			this.cmbZone.Location = new System.Drawing.Point(358, 17);
			this.cmbZone.Name = "cmbZone";
			this.cmbZone.Size = new System.Drawing.Size(40, 21);
			this.cmbZone.TabIndex = 8;
			this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
			// 
			// lblAPR_RiskKit
			// 
			this.lblAPR_RiskKit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAPR_RiskKit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.lblAPR_RiskKit.Location = new System.Drawing.Point(539, 12);
			this.lblAPR_RiskKit.Name = "lblAPR_RiskKit";
			this.lblAPR_RiskKit.Size = new System.Drawing.Size(71, 23);
			this.lblAPR_RiskKit.TabIndex = 17;
			this.lblAPR_RiskKit.Text = "APR";
			this.lblAPR_RiskKit.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblAPR_RiskKit.Visible = false;
			// 
			// ndtpReturned
			// 
			this.ndtpReturned.CustomFormat = " ";
			this.ndtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpReturned.Location = new System.Drawing.Point(732, 18);
			this.ndtpReturned.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.ndtpReturned.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.ndtpReturned.Name = "ndtpReturned";
			this.ndtpReturned.Size = new System.Drawing.Size(92, 20);
			this.ndtpReturned.TabIndex = 21;
			this.ndtpReturned.Value = null;
			this.ndtpReturned.ValueChanged += new System.EventHandler(this.ndtpReturned_ValueChanged);
			this.ndtpReturned.Enter += new System.EventHandler(this.ndtpReturned_Enter);
			this.ndtpReturned.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ndtpReturned_MouseDown);
			// 
			// ndtpReceived
			// 
			this.ndtpReceived.CustomFormat = " ";
			this.ndtpReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.ndtpReceived.Location = new System.Drawing.Point(260, 18);
			this.ndtpReceived.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.ndtpReceived.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			this.ndtpReceived.Name = "ndtpReceived";
			this.ndtpReceived.Size = new System.Drawing.Size(92, 20);
			this.ndtpReceived.TabIndex = 6;
			this.ndtpReceived.Value = null;
			this.ndtpReceived.ValueChanged += new System.EventHandler(this.ndtpReceived_ValueChanged);
			this.ndtpReceived.Enter += new System.EventHandler(this.ndtpReceived_Enter);
			this.ndtpReceived.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ndtpReceived_MouseDown);
			// 
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQty.Location = new System.Drawing.Point(29, 17);
			this.txtQty.Name = "txtQty";
			this.txtQty.ReadOnly = true;
			this.txtQty.Size = new System.Drawing.Size(40, 21);
			this.txtQty.TabIndex = 2;
			// 
			// lblDateReceived
			// 
			this.lblDateReceived.AutoSize = true;
			this.lblDateReceived.Location = new System.Drawing.Point(257, 1);
			this.lblDateReceived.Name = "lblDateReceived";
			this.lblDateReceived.Size = new System.Drawing.Size(79, 13);
			this.lblDateReceived.TabIndex = 5;
			this.lblDateReceived.Text = "Date Received";
			this.lblDateReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblQty
			// 
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(26, 1);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(23, 13);
			this.lblQty.TabIndex = 1;
			this.lblQty.Text = "Qty";
			this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPart
			// 
			this.txtPart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPart.Location = new System.Drawing.Point(75, 17);
			this.txtPart.Name = "txtPart";
			this.txtPart.ReadOnly = true;
			this.txtPart.Size = new System.Drawing.Size(179, 21);
			this.txtPart.TabIndex = 4;
			// 
			// lblPart
			// 
			this.lblPart.AutoSize = true;
			this.lblPart.Location = new System.Drawing.Point(75, 1);
			this.lblPart.Name = "lblPart";
			this.lblPart.Size = new System.Drawing.Size(26, 13);
			this.lblPart.TabIndex = 3;
			this.lblPart.Text = "Part";
			this.lblPart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtRepairs
			// 
			this.txtRepairs.AcceptsReturn = true;
			this.txtRepairs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRepairs.Location = new System.Drawing.Point(28, 57);
			this.txtRepairs.MaxLength = 400;
			this.txtRepairs.Multiline = true;
			this.txtRepairs.Name = "txtRepairs";
			this.txtRepairs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRepairs.Size = new System.Drawing.Size(324, 44);
			this.txtRepairs.TabIndex = 10;
			this.txtRepairs.TextChanged += new System.EventHandler(this.txtRepairs_TextChanged);
			// 
			// lblRepairType
			// 
			this.lblRepairType.AutoSize = true;
			this.lblRepairType.Location = new System.Drawing.Point(355, 84);
			this.lblRepairType.Name = "lblRepairType";
			this.lblRepairType.Size = new System.Drawing.Size(65, 13);
			this.lblRepairType.TabIndex = 15;
			this.lblRepairType.Text = "Repair Type";
			this.lblRepairType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbRepairType
			// 
			this.cmbRepairType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRepairType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbRepairType.FormattingEnabled = true;
			this.cmbRepairType.Location = new System.Drawing.Point(426, 81);
			this.cmbRepairType.Name = "cmbRepairType";
			this.cmbRepairType.Size = new System.Drawing.Size(253, 21);
			this.cmbRepairType.TabIndex = 16;
			this.cmbRepairType.SelectedIndexChanged += new System.EventHandler(this.cmbRepairType_SelectedIndexChanged);
			// 
			// lblDesignation
			// 
			this.lblDesignation.BackColor = System.Drawing.Color.Gainsboro;
			this.lblDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDesignation.Location = new System.Drawing.Point(0, -1);
			this.lblDesignation.Name = "lblDesignation";
			this.lblDesignation.Size = new System.Drawing.Size(20, 109);
			this.lblDesignation.TabIndex = 0;
			this.lblDesignation.Text = "#";
			this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTracking
			// 
			this.txtTracking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTracking.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTracking.Location = new System.Drawing.Point(616, 54);
			this.txtTracking.MaxLength = 20;
			this.txtTracking.Name = "txtTracking";
			this.txtTracking.Size = new System.Drawing.Size(286, 21);
			this.txtTracking.TabIndex = 23;
			this.txtTracking.TextChanged += new System.EventHandler(this.txtTracking_TextChanged);
			// 
			// lblReturnTracking
			// 
			this.lblReturnTracking.AutoSize = true;
			this.lblReturnTracking.Location = new System.Drawing.Point(613, 38);
			this.lblReturnTracking.Name = "lblReturnTracking";
			this.lblReturnTracking.Size = new System.Drawing.Size(124, 13);
			this.lblReturnTracking.TabIndex = 22;
			this.lblReturnTracking.Text = "Return Tracking Number";
			this.lblReturnTracking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtReturnedBy
			// 
			this.txtReturnedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtReturnedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtReturnedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReturnedBy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReturnedBy.Location = new System.Drawing.Point(616, 17);
			this.txtReturnedBy.MaxLength = 50;
			this.txtReturnedBy.Name = "txtReturnedBy";
			this.txtReturnedBy.Size = new System.Drawing.Size(110, 21);
			this.txtReturnedBy.TabIndex = 19;
			this.txtReturnedBy.TextChanged += new System.EventHandler(this.txtReturnedBy_TextChanged);
			// 
			// txtRepairedByTech
			// 
			this.txtRepairedByTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtRepairedByTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtRepairedByTech.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRepairedByTech.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRepairedByTech.Location = new System.Drawing.Point(426, 57);
			this.txtRepairedByTech.MaxLength = 50;
			this.txtRepairedByTech.Name = "txtRepairedByTech";
			this.txtRepairedByTech.Size = new System.Drawing.Size(110, 21);
			this.txtRepairedByTech.TabIndex = 14;
			this.txtRepairedByTech.TextChanged += new System.EventHandler(this.txtTech_TextChanged);
			// 
			// txtMU
			// 
			this.txtMU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMU.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMU.Location = new System.Drawing.Point(426, 17);
			this.txtMU.MaxLength = 10;
			this.txtMU.Name = "txtMU";
			this.txtMU.Size = new System.Drawing.Size(106, 21);
			this.txtMU.TabIndex = 12;
			this.txtMU.TextChanged += new System.EventHandler(this.txtMU_TextChanged);
			// 
			// lblDateReturned
			// 
			this.lblDateReturned.AutoSize = true;
			this.lblDateReturned.Location = new System.Drawing.Point(729, 1);
			this.lblDateReturned.Name = "lblDateReturned";
			this.lblDateReturned.Size = new System.Drawing.Size(77, 13);
			this.lblDateReturned.TabIndex = 20;
			this.lblDateReturned.Text = "Date Returned";
			this.lblDateReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblReturnedBy
			// 
			this.lblReturnedBy.AutoSize = true;
			this.lblReturnedBy.Location = new System.Drawing.Point(613, 1);
			this.lblReturnedBy.Name = "lblReturnedBy";
			this.lblReturnedBy.Size = new System.Drawing.Size(66, 13);
			this.lblReturnedBy.TabIndex = 18;
			this.lblReturnedBy.Text = "Returned By";
			this.lblReturnedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTech
			// 
			this.lblTech.AutoSize = true;
			this.lblTech.Location = new System.Drawing.Point(426, 41);
			this.lblTech.Name = "lblTech";
			this.lblTech.Size = new System.Drawing.Size(99, 13);
			this.lblTech.TabIndex = 13;
			this.lblTech.Text = "Repaired By (Tech)";
			this.lblTech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMU
			// 
			this.lblMU.AutoSize = true;
			this.lblMU.Location = new System.Drawing.Point(426, 1);
			this.lblMU.Name = "lblMU";
			this.lblMU.Size = new System.Drawing.Size(31, 13);
			this.lblMU.TabIndex = 11;
			this.lblMU.Text = "MU#";
			this.lblMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRepairs
			// 
			this.lblRepairs.AutoSize = true;
			this.lblRepairs.Location = new System.Drawing.Point(26, 40);
			this.lblRepairs.Name = "lblRepairs";
			this.lblRepairs.Size = new System.Drawing.Size(43, 13);
			this.lblRepairs.TabIndex = 9;
			this.lblRepairs.Text = "Repairs";
			this.lblRepairs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ucRMAJobLogLine
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlJobLogLine);
			this.Name = "ucRMAJobLogLine";
			this.Size = new System.Drawing.Size(905, 109);
			this.pnlJobLogLine.ResumeLayout(false);
			this.pnlJobLogLine.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlJobLogLine;
		private System.Windows.Forms.TextBox txtRepairs;
		private System.Windows.Forms.Label lblRepairType;
		private System.Windows.Forms.ComboBox cmbRepairType;
		private System.Windows.Forms.Label lblDesignation;
		private System.Windows.Forms.Label lblDateReceived;
		private System.Windows.Forms.TextBox txtTracking;
		private System.Windows.Forms.Label lblReturnTracking;
		private System.Windows.Forms.TextBox txtReturnedBy;
		private System.Windows.Forms.TextBox txtRepairedByTech;
		private System.Windows.Forms.TextBox txtMU;
		private System.Windows.Forms.Label lblDateReturned;
		private System.Windows.Forms.Label lblReturnedBy;
		private System.Windows.Forms.Label lblTech;
		private System.Windows.Forms.Label lblMU;
		private System.Windows.Forms.Label lblRepairs;
		private System.Windows.Forms.TextBox txtPart;
		private System.Windows.Forms.Label lblPart;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label lblQty;
		private NullableDateTimePicker ndtpReceived;
		private NullableDateTimePicker ndtpReturned;
		private System.Windows.Forms.Label lblAPR_RiskKit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label lblZone;
		private System.Windows.Forms.ComboBox cmbZone;
	}
}
