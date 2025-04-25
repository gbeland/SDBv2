namespace SDB.MagicInfo.UserControls
{
    partial class ucJournalEntry
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpExpireTime = new System.Windows.Forms.GroupBox();
            this.txtExpires_SameAsPrior = new System.Windows.Forms.TextBox();
            this.dtpExpires_Date = new System.Windows.Forms.DateTimePicker();
            this.radExpires_SameAsPrior = new System.Windows.Forms.RadioButton();
            this.radExpires_HoursMinutes = new System.Windows.Forms.RadioButton();
            this.radExpires_Date = new System.Windows.Forms.RadioButton();
            this.numExpires_Minutes = new System.Windows.Forms.NumericUpDown();
            this.lblExpires_Minutes = new System.Windows.Forms.Label();
            this.numExpires_Hours = new System.Windows.Forms.NumericUpDown();
            this.lblExpires_Hours = new System.Windows.Forms.Label();
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.ticketJournalComponent1 = new SDB.MagicInfo.Components.TicketJournalComponent();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.ucSpellCheckLarge1 = new SDB.UserControls.General.ucSpellCheckLarge();
            this.grpExpireTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).BeginInit();
            this.grpEntry.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Status";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(6, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(275, 21);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.TextChanged += new System.EventHandler(this.cmbStatus_TextChanged);
            // 
            // grpExpireTime
            // 
            this.grpExpireTime.Controls.Add(this.txtExpires_SameAsPrior);
            this.grpExpireTime.Controls.Add(this.dtpExpires_Date);
            this.grpExpireTime.Controls.Add(this.radExpires_SameAsPrior);
            this.grpExpireTime.Controls.Add(this.radExpires_HoursMinutes);
            this.grpExpireTime.Controls.Add(this.radExpires_Date);
            this.grpExpireTime.Controls.Add(this.numExpires_Minutes);
            this.grpExpireTime.Controls.Add(this.lblExpires_Minutes);
            this.grpExpireTime.Controls.Add(this.numExpires_Hours);
            this.grpExpireTime.Controls.Add(this.lblExpires_Hours);
            this.grpExpireTime.Location = new System.Drawing.Point(403, 3);
            this.grpExpireTime.Name = "grpExpireTime";
            this.grpExpireTime.Size = new System.Drawing.Size(287, 141);
            this.grpExpireTime.TabIndex = 5;
            this.grpExpireTime.TabStop = false;
            this.grpExpireTime.Text = "Expire Time";
            // 
            // txtExpires_SameAsPrior
            // 
            this.txtExpires_SameAsPrior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpires_SameAsPrior.Location = new System.Drawing.Point(150, 84);
            this.txtExpires_SameAsPrior.Name = "txtExpires_SameAsPrior";
            this.txtExpires_SameAsPrior.ReadOnly = true;
            this.txtExpires_SameAsPrior.Size = new System.Drawing.Size(126, 20);
            this.txtExpires_SameAsPrior.TabIndex = 16;
            // 
            // dtpExpires_Date
            // 
            this.dtpExpires_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpires_Date.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpExpires_Date.Enabled = false;
            this.dtpExpires_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpires_Date.Location = new System.Drawing.Point(150, 46);
            this.dtpExpires_Date.Name = "dtpExpires_Date";
            this.dtpExpires_Date.Size = new System.Drawing.Size(126, 20);
            this.dtpExpires_Date.TabIndex = 15;
            // 
            // radExpires_SameAsPrior
            // 
            this.radExpires_SameAsPrior.AutoSize = true;
            this.radExpires_SameAsPrior.Location = new System.Drawing.Point(10, 84);
            this.radExpires_SameAsPrior.Name = "radExpires_SameAsPrior";
            this.radExpires_SameAsPrior.Size = new System.Drawing.Size(138, 17);
            this.radExpires_SameAsPrior.TabIndex = 14;
            this.radExpires_SameAsPrior.Text = "&Same as prior user entry";
            this.radExpires_SameAsPrior.UseVisualStyleBackColor = true;
            this.radExpires_SameAsPrior.Click += new System.EventHandler(this.radExpires_HoursMinutes_CheckedChanged);
            // 
            // radExpires_HoursMinutes
            // 
            this.radExpires_HoursMinutes.AutoSize = true;
            this.radExpires_HoursMinutes.Location = new System.Drawing.Point(10, 20);
            this.radExpires_HoursMinutes.Name = "radExpires_HoursMinutes";
            this.radExpires_HoursMinutes.Size = new System.Drawing.Size(118, 17);
            this.radExpires_HoursMinutes.TabIndex = 12;
            this.radExpires_HoursMinutes.Text = "This entry expires &in";
            this.radExpires_HoursMinutes.UseVisualStyleBackColor = true;
            this.radExpires_HoursMinutes.Click += new System.EventHandler(this.radExpires_HoursMinutes_CheckedChanged);
            // 
            // radExpires_Date
            // 
            this.radExpires_Date.AutoSize = true;
            this.radExpires_Date.Location = new System.Drawing.Point(9, 50);
            this.radExpires_Date.Name = "radExpires_Date";
            this.radExpires_Date.Size = new System.Drawing.Size(119, 17);
            this.radExpires_Date.TabIndex = 13;
            this.radExpires_Date.Text = "This entry &expires at";
            this.radExpires_Date.UseVisualStyleBackColor = true;
            this.radExpires_Date.Click += new System.EventHandler(this.radExpires_HoursMinutes_CheckedChanged);
            // 
            // numExpires_Minutes
            // 
            this.numExpires_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numExpires_Minutes.Enabled = false;
            this.numExpires_Minutes.Location = new System.Drawing.Point(215, 19);
            this.numExpires_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numExpires_Minutes.Name = "numExpires_Minutes";
            this.numExpires_Minutes.Size = new System.Drawing.Size(40, 20);
            this.numExpires_Minutes.TabIndex = 10;
            // 
            // lblExpires_Minutes
            // 
            this.lblExpires_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpires_Minutes.AutoSize = true;
            this.lblExpires_Minutes.Enabled = false;
            this.lblExpires_Minutes.Location = new System.Drawing.Point(261, 21);
            this.lblExpires_Minutes.Name = "lblExpires_Minutes";
            this.lblExpires_Minutes.Size = new System.Drawing.Size(15, 13);
            this.lblExpires_Minutes.TabIndex = 11;
            this.lblExpires_Minutes.Text = "m";
            // 
            // numExpires_Hours
            // 
            this.numExpires_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numExpires_Hours.Enabled = false;
            this.numExpires_Hours.Location = new System.Drawing.Point(150, 19);
            this.numExpires_Hours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numExpires_Hours.Name = "numExpires_Hours";
            this.numExpires_Hours.Size = new System.Drawing.Size(40, 20);
            this.numExpires_Hours.TabIndex = 8;
            // 
            // lblExpires_Hours
            // 
            this.lblExpires_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpires_Hours.AutoSize = true;
            this.lblExpires_Hours.Enabled = false;
            this.lblExpires_Hours.Location = new System.Drawing.Point(196, 21);
            this.lblExpires_Hours.Name = "lblExpires_Hours";
            this.lblExpires_Hours.Size = new System.Drawing.Size(13, 13);
            this.lblExpires_Hours.TabIndex = 9;
            this.lblExpires_Hours.Text = "h";
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.elementHost1);
            this.grpEntry.Location = new System.Drawing.Point(3, 3);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(394, 242);
            this.grpEntry.TabIndex = 12;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "Entry";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.cmbStatus);
            this.grpStatus.Location = new System.Drawing.Point(403, 150);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(287, 92);
            this.grpStatus.TabIndex = 13;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // ticketJournalComponent1
            // 
            this.ticketJournalComponent1.AutoScroll = true;
            this.ticketJournalComponent1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ticketJournalComponent1.Location = new System.Drawing.Point(9, 248);
            this.ticketJournalComponent1.Name = "ticketJournalComponent1";
            this.ticketJournalComponent1.Size = new System.Drawing.Size(681, 255);
            this.ticketJournalComponent1.TabIndex = 14;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 16);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(388, 223);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.ucSpellCheckLarge1;
            // 
            // ucJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.ticketJournalComponent1);
            this.Controls.Add(this.grpStatus);
            this.Controls.Add(this.grpEntry);
            this.Controls.Add(this.grpExpireTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "ucJournalEntry";
            this.Size = new System.Drawing.Size(695, 535);
            this.grpExpireTime.ResumeLayout(false);
            this.grpExpireTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).EndInit();
            this.grpEntry.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpExpireTime;
        private System.Windows.Forms.NumericUpDown numExpires_Minutes;
        private System.Windows.Forms.Label lblExpires_Minutes;
        private System.Windows.Forms.NumericUpDown numExpires_Hours;
        private System.Windows.Forms.Label lblExpires_Hours;
        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radExpires_SameAsPrior;
        private System.Windows.Forms.RadioButton radExpires_HoursMinutes;
        private System.Windows.Forms.RadioButton radExpires_Date;
        private System.Windows.Forms.DateTimePicker dtpExpires_Date;
        private System.Windows.Forms.TextBox txtExpires_SameAsPrior;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SDB.UserControls.General.ucSpellCheckLarge ucSpellCheckLarge1;
        private Components.TicketJournalComponent ticketJournalComponent1;
    }
}
