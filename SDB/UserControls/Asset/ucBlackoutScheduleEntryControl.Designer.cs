namespace SDB.UserControls.Asset
{
	partial class ucBlackoutScheduleEntryControl
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
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.dtpStop = new System.Windows.Forms.DateTimePicker();
			this.lblTo = new System.Windows.Forms.Label();
			this.cmbDays = new System.Windows.Forms.ComboBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// dtpStart
			// 
			this.dtpStart.CustomFormat = "HH:mm";
			this.dtpStart.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStart.Location = new System.Drawing.Point(3, 3);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.ShowUpDown = true;
			this.dtpStart.Size = new System.Drawing.Size(70, 20);
			this.dtpStart.TabIndex = 0;
			this.dtpStart.Value = new System.DateTime(2014, 12, 23, 0, 0, 0, 0);
			this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
			// 
			// dtpStop
			// 
			this.dtpStop.CustomFormat = "HH:mm";
			this.dtpStop.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStop.Location = new System.Drawing.Point(101, 3);
			this.dtpStop.Name = "dtpStop";
			this.dtpStop.ShowUpDown = true;
			this.dtpStop.Size = new System.Drawing.Size(70, 20);
			this.dtpStop.TabIndex = 1;
			this.dtpStop.Value = new System.DateTime(2014, 12, 23, 0, 0, 0, 0);
			this.dtpStop.ValueChanged += new System.EventHandler(this.dtpStop_ValueChanged);
			// 
			// lblTo
			// 
			this.lblTo.AutoSize = true;
			this.lblTo.Location = new System.Drawing.Point(79, 6);
			this.lblTo.Name = "lblTo";
			this.lblTo.Size = new System.Drawing.Size(16, 13);
			this.lblTo.TabIndex = 2;
			this.lblTo.Text = "to";
			// 
			// cmbDays
			// 
			this.cmbDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDays.FormattingEnabled = true;
			this.cmbDays.Location = new System.Drawing.Point(177, 3);
			this.cmbDays.Name = "cmbDays";
			this.cmbDays.Size = new System.Drawing.Size(111, 21);
			this.cmbDays.TabIndex = 3;
			this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnRemove.Location = new System.Drawing.Point(294, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(23, 21);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "X";
			this.toolTip1.SetToolTip(this.btnRemove, "Click to remove. Click again to undo.");
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// ucBlackoutScheduleEntryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.cmbDays);
			this.Controls.Add(this.lblTo);
			this.Controls.Add(this.dtpStop);
			this.Controls.Add(this.dtpStart);
			this.Name = "ucBlackoutScheduleEntryControl";
			this.Size = new System.Drawing.Size(320, 29);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.DateTimePicker dtpStop;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.ComboBox cmbDays;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
