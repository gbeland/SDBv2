using ucSpellCheckSmall = SDB.UserControls.General.ucSpellCheckSmall;

namespace SDB.Forms.General
{
	sealed partial class FormUserInput_WithExpire
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
			this.btnCommit = new System.Windows.Forms.Button();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.ucSpellCheckSmall1 = new ucSpellCheckSmall();
			this.pnlExpires = new System.Windows.Forms.Panel();
			this.numExpires_Minutes = new System.Windows.Forms.NumericUpDown();
			this.lblExpires_Minutes = new System.Windows.Forms.Label();
			this.numExpires_Hours = new System.Windows.Forms.NumericUpDown();
			this.lblExpires_Hours = new System.Windows.Forms.Label();
			this.radExpires_HoursMinutes = new System.Windows.Forms.RadioButton();
			this.radExpires_Date = new System.Windows.Forms.RadioButton();
			this.dtpExpires_Date = new System.Windows.Forms.DateTimePicker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlExpires.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCommit
			// 
			this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCommit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnCommit.Location = new System.Drawing.Point(617, 86);
			this.btnCommit.Name = "btnCommit";
			this.btnCommit.Size = new System.Drawing.Size(150, 36);
			this.btnCommit.TabIndex = 2;
			this.btnCommit.Text = "Commit";
			this.btnCommit.UseVisualStyleBackColor = true;
			this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
			// 
			// elementHost1
			// 
			this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.elementHost1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elementHost1.Location = new System.Drawing.Point(12, 3);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(420, 119);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.ucSpellCheckSmall1;
			// 
			// pnlExpires
			// 
			this.pnlExpires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlExpires.Controls.Add(this.numExpires_Minutes);
			this.pnlExpires.Controls.Add(this.lblExpires_Minutes);
			this.pnlExpires.Controls.Add(this.numExpires_Hours);
			this.pnlExpires.Controls.Add(this.lblExpires_Hours);
			this.pnlExpires.Controls.Add(this.radExpires_HoursMinutes);
			this.pnlExpires.Controls.Add(this.radExpires_Date);
			this.pnlExpires.Controls.Add(this.dtpExpires_Date);
			this.pnlExpires.Location = new System.Drawing.Point(438, 3);
			this.pnlExpires.Name = "pnlExpires";
			this.pnlExpires.Size = new System.Drawing.Size(329, 52);
			this.pnlExpires.TabIndex = 1;
			// 
			// numExpires_Minutes
			// 
			this.numExpires_Minutes.Location = new System.Drawing.Point(267, 1);
			this.numExpires_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.numExpires_Minutes.Name = "numExpires_Minutes";
			this.numExpires_Minutes.Size = new System.Drawing.Size(40, 20);
			this.numExpires_Minutes.TabIndex = 3;
			this.numExpires_Minutes.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblExpires_Minutes
			// 
			this.lblExpires_Minutes.AutoSize = true;
			this.lblExpires_Minutes.Location = new System.Drawing.Point(311, 3);
			this.lblExpires_Minutes.Name = "lblExpires_Minutes";
			this.lblExpires_Minutes.Size = new System.Drawing.Size(15, 13);
			this.lblExpires_Minutes.TabIndex = 4;
			this.lblExpires_Minutes.Text = "m";
			// 
			// numExpires_Hours
			// 
			this.numExpires_Hours.Location = new System.Drawing.Point(202, 1);
			this.numExpires_Hours.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numExpires_Hours.Name = "numExpires_Hours";
			this.numExpires_Hours.Size = new System.Drawing.Size(40, 20);
			this.numExpires_Hours.TabIndex = 1;
			this.numExpires_Hours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numExpires_Hours.Enter += new System.EventHandler(this.numUpDown_Enter);
			// 
			// lblExpires_Hours
			// 
			this.lblExpires_Hours.AutoSize = true;
			this.lblExpires_Hours.Location = new System.Drawing.Point(248, 3);
			this.lblExpires_Hours.Name = "lblExpires_Hours";
			this.lblExpires_Hours.Size = new System.Drawing.Size(13, 13);
			this.lblExpires_Hours.TabIndex = 2;
			this.lblExpires_Hours.Text = "h";
			// 
			// radExpires_HoursMinutes
			// 
			this.radExpires_HoursMinutes.AutoSize = true;
			this.radExpires_HoursMinutes.Checked = true;
			this.radExpires_HoursMinutes.Location = new System.Drawing.Point(3, 3);
			this.radExpires_HoursMinutes.Name = "radExpires_HoursMinutes";
			this.radExpires_HoursMinutes.Size = new System.Drawing.Size(92, 17);
			this.radExpires_HoursMinutes.TabIndex = 0;
			this.radExpires_HoursMinutes.TabStop = true;
			this.radExpires_HoursMinutes.Text = "Item expires in";
			this.radExpires_HoursMinutes.UseVisualStyleBackColor = true;
			this.radExpires_HoursMinutes.CheckedChanged += new System.EventHandler(this.radExpires_HoursMinutes_CheckedChanged);
			// 
			// radExpires_Date
			// 
			this.radExpires_Date.AutoSize = true;
			this.radExpires_Date.Location = new System.Drawing.Point(2, 30);
			this.radExpires_Date.Name = "radExpires_Date";
			this.radExpires_Date.Size = new System.Drawing.Size(93, 17);
			this.radExpires_Date.TabIndex = 5;
			this.radExpires_Date.Text = "Item expires at";
			this.radExpires_Date.UseVisualStyleBackColor = true;
			this.radExpires_Date.CheckedChanged += new System.EventHandler(this.radExpires_Date_CheckedChanged);
			// 
			// dtpExpires_Date
			// 
			this.dtpExpires_Date.CustomFormat = "yyyy-MM-dd HH:mm";
			this.dtpExpires_Date.Enabled = false;
			this.dtpExpires_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpExpires_Date.Location = new System.Drawing.Point(202, 27);
			this.dtpExpires_Date.Name = "dtpExpires_Date";
			this.dtpExpires_Date.Size = new System.Drawing.Size(121, 20);
			this.dtpExpires_Date.TabIndex = 6;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(536, 99);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormUserInput_WithExpire
			// 
			this.AcceptButton = this.btnCommit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(779, 134);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.pnlExpires);
			this.Controls.Add(this.elementHost1);
			this.Controls.Add(this.btnCommit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(795, 168);
			this.Name = "FormUserInput_WithExpire";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Title";
			this.pnlExpires.ResumeLayout(false);
			this.pnlExpires.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnCommit;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private System.Windows.Forms.Panel pnlExpires;
		private System.Windows.Forms.DateTimePicker dtpExpires_Date;
		private ucSpellCheckSmall ucSpellCheckSmall1;
		private System.Windows.Forms.NumericUpDown numExpires_Minutes;
		private System.Windows.Forms.Label lblExpires_Minutes;
		private System.Windows.Forms.NumericUpDown numExpires_Hours;
		private System.Windows.Forms.Label lblExpires_Hours;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton radExpires_HoursMinutes;
		private System.Windows.Forms.RadioButton radExpires_Date;
    }
}