using ucSpellCheckSmall = SDB.UserControls.General.ucSpellCheckSmall;

namespace SDB.Forms.Ticket
{
    partial class FormJournal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.numExpires_Hours = new System.Windows.Forms.NumericUpDown();
            this.dtpExpires_Date = new System.Windows.Forms.DateTimePicker();
            this.lblExpires_Hours = new System.Windows.Forms.Label();
            this.radExpires_HoursMinutes = new System.Windows.Forms.RadioButton();
            this.radExpires_Date = new System.Windows.Forms.RadioButton();
            this.pnlExpires = new System.Windows.Forms.Panel();
            this.txtExpires_SameAsPrior = new System.Windows.Forms.TextBox();
            this.pnlRadioButtonGrouper = new System.Windows.Forms.Panel();
            this.radExpires_SameAsPrior = new System.Windows.Forms.RadioButton();
            this.numExpires_Minutes = new System.Windows.Forms.NumericUpDown();
            this.lblExpires_Minutes = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkReleaseHold = new System.Windows.Forms.CheckBox();
            this.btnQuickAddEntry = new System.Windows.Forms.Button();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.ucSpellCheckSmall1 = new SDB.UserControls.General.ucSpellCheckSmall();
            this.cbxHoldTicket = new System.Windows.Forms.CheckBox();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).BeginInit();
            this.pnlExpires.SuspendLayout();
            this.pnlRadioButtonGrouper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntry.Location = new System.Drawing.Point(577, 129);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(180, 37);
            this.btnAddEntry.TabIndex = 2;
            this.btnAddEntry.Text = "&Add Journal Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.AllowUserToOrderColumns = true;
            this.dgvJournal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvJournal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colDate,
            this.colJournalEntry,
            this.colJournalExpires});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJournal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJournal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvJournal.Location = new System.Drawing.Point(12, 172);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersVisible = false;
            this.dgvJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvJournal.ShowCellErrors = false;
            this.dgvJournal.ShowCellToolTips = false;
            this.dgvJournal.ShowEditingIcon = false;
            this.dgvJournal.ShowRowErrors = false;
            this.dgvJournal.Size = new System.Drawing.Size(745, 282);
            this.dgvJournal.TabIndex = 4;
            this.dgvJournal.TabStop = false;
            // 
            // numExpires_Hours
            // 
            this.numExpires_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numExpires_Hours.Enabled = false;
            this.numExpires_Hours.Location = new System.Drawing.Point(159, 4);
            this.numExpires_Hours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numExpires_Hours.Name = "numExpires_Hours";
            this.numExpires_Hours.Size = new System.Drawing.Size(40, 20);
            this.numExpires_Hours.TabIndex = 0;
            this.numExpires_Hours.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // dtpExpires_Date
            // 
            this.dtpExpires_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpires_Date.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpExpires_Date.Enabled = false;
            this.dtpExpires_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpires_Date.Location = new System.Drawing.Point(159, 30);
            this.dtpExpires_Date.Name = "dtpExpires_Date";
            this.dtpExpires_Date.Size = new System.Drawing.Size(121, 20);
            this.dtpExpires_Date.TabIndex = 4;
            // 
            // lblExpires_Hours
            // 
            this.lblExpires_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpires_Hours.AutoSize = true;
            this.lblExpires_Hours.Enabled = false;
            this.lblExpires_Hours.Location = new System.Drawing.Point(205, 6);
            this.lblExpires_Hours.Name = "lblExpires_Hours";
            this.lblExpires_Hours.Size = new System.Drawing.Size(13, 13);
            this.lblExpires_Hours.TabIndex = 1;
            this.lblExpires_Hours.Text = "h";
            // 
            // radExpires_HoursMinutes
            // 
            this.radExpires_HoursMinutes.AutoSize = true;
            this.radExpires_HoursMinutes.Location = new System.Drawing.Point(4, 4);
            this.radExpires_HoursMinutes.Name = "radExpires_HoursMinutes";
            this.radExpires_HoursMinutes.Size = new System.Drawing.Size(118, 17);
            this.radExpires_HoursMinutes.TabIndex = 0;
            this.radExpires_HoursMinutes.TabStop = true;
            this.radExpires_HoursMinutes.Text = "This entry expires &in";
            this.radExpires_HoursMinutes.UseVisualStyleBackColor = true;
            this.radExpires_HoursMinutes.CheckedChanged += new System.EventHandler(this.radExpires_HoursMinutes_CheckedChanged);
            // 
            // radExpires_Date
            // 
            this.radExpires_Date.AutoSize = true;
            this.radExpires_Date.Location = new System.Drawing.Point(4, 31);
            this.radExpires_Date.Name = "radExpires_Date";
            this.radExpires_Date.Size = new System.Drawing.Size(119, 17);
            this.radExpires_Date.TabIndex = 1;
            this.radExpires_Date.TabStop = true;
            this.radExpires_Date.Text = "This entry &expires at";
            this.radExpires_Date.UseVisualStyleBackColor = true;
            this.radExpires_Date.CheckedChanged += new System.EventHandler(this.radExpires_Date_CheckedChanged);
            // 
            // pnlExpires
            // 
            this.pnlExpires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExpires.Controls.Add(this.txtExpires_SameAsPrior);
            this.pnlExpires.Controls.Add(this.pnlRadioButtonGrouper);
            this.pnlExpires.Controls.Add(this.numExpires_Minutes);
            this.pnlExpires.Controls.Add(this.lblExpires_Minutes);
            this.pnlExpires.Controls.Add(this.numExpires_Hours);
            this.pnlExpires.Controls.Add(this.dtpExpires_Date);
            this.pnlExpires.Controls.Add(this.lblExpires_Hours);
            this.pnlExpires.Location = new System.Drawing.Point(467, 12);
            this.pnlExpires.Name = "pnlExpires";
            this.pnlExpires.Size = new System.Drawing.Size(290, 82);
            this.pnlExpires.TabIndex = 1;
            // 
            // txtExpires_SameAsPrior
            // 
            this.txtExpires_SameAsPrior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpires_SameAsPrior.Location = new System.Drawing.Point(159, 57);
            this.txtExpires_SameAsPrior.Name = "txtExpires_SameAsPrior";
            this.txtExpires_SameAsPrior.ReadOnly = true;
            this.txtExpires_SameAsPrior.Size = new System.Drawing.Size(121, 20);
            this.txtExpires_SameAsPrior.TabIndex = 5;
            // 
            // pnlRadioButtonGrouper
            // 
            this.pnlRadioButtonGrouper.Controls.Add(this.radExpires_SameAsPrior);
            this.pnlRadioButtonGrouper.Controls.Add(this.radExpires_HoursMinutes);
            this.pnlRadioButtonGrouper.Controls.Add(this.radExpires_Date);
            this.pnlRadioButtonGrouper.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRadioButtonGrouper.Location = new System.Drawing.Point(0, 0);
            this.pnlRadioButtonGrouper.Name = "pnlRadioButtonGrouper";
            this.pnlRadioButtonGrouper.Size = new System.Drawing.Size(150, 82);
            this.pnlRadioButtonGrouper.TabIndex = 0;
            // 
            // radExpires_SameAsPrior
            // 
            this.radExpires_SameAsPrior.AutoSize = true;
            this.radExpires_SameAsPrior.Location = new System.Drawing.Point(4, 58);
            this.radExpires_SameAsPrior.Name = "radExpires_SameAsPrior";
            this.radExpires_SameAsPrior.Size = new System.Drawing.Size(138, 17);
            this.radExpires_SameAsPrior.TabIndex = 2;
            this.radExpires_SameAsPrior.TabStop = true;
            this.radExpires_SameAsPrior.Text = "&Same as prior user entry";
            this.radExpires_SameAsPrior.UseVisualStyleBackColor = true;
            // 
            // numExpires_Minutes
            // 
            this.numExpires_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numExpires_Minutes.Enabled = false;
            this.numExpires_Minutes.Location = new System.Drawing.Point(224, 4);
            this.numExpires_Minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numExpires_Minutes.Name = "numExpires_Minutes";
            this.numExpires_Minutes.Size = new System.Drawing.Size(40, 20);
            this.numExpires_Minutes.TabIndex = 2;
            this.numExpires_Minutes.Enter += new System.EventHandler(this.numUpDown_Enter);
            // 
            // lblExpires_Minutes
            // 
            this.lblExpires_Minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpires_Minutes.AutoSize = true;
            this.lblExpires_Minutes.Enabled = false;
            this.lblExpires_Minutes.Location = new System.Drawing.Point(270, 6);
            this.lblExpires_Minutes.Name = "lblExpires_Minutes";
            this.lblExpires_Minutes.Size = new System.Drawing.Size(15, 13);
            this.lblExpires_Minutes.TabIndex = 3;
            this.lblExpires_Minutes.Text = "m";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkReleaseHold
            // 
            this.chkReleaseHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReleaseHold.AutoSize = true;
            this.chkReleaseHold.Location = new System.Drawing.Point(471, 104);
            this.chkReleaseHold.Name = "chkReleaseHold";
            this.chkReleaseHold.Size = new System.Drawing.Size(90, 17);
            this.chkReleaseHold.TabIndex = 5;
            this.chkReleaseHold.Text = "&Release Hold";
            this.chkReleaseHold.UseVisualStyleBackColor = true;
            // 
            // btnQuickAddEntry
            // 
            this.btnQuickAddEntry.Location = new System.Drawing.Point(577, 100);
            this.btnQuickAddEntry.Name = "btnQuickAddEntry";
            this.btnQuickAddEntry.Size = new System.Drawing.Size(180, 23);
            this.btnQuickAddEntry.TabIndex = 6;
            this.btnQuickAddEntry.Text = "&Quick Add (expires in N minutes)";
            this.btnQuickAddEntry.UseVisualStyleBackColor = true;
            this.btnQuickAddEntry.Click += new System.EventHandler(this.btnQuickAddEntry_Click);
            // 
            // elementHost2
            // 
            this.elementHost2.Location = new System.Drawing.Point(12, 12);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(449, 154);
            this.elementHost2.TabIndex = 0;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.ucSpellCheckSmall1;
            // 
            // cbxHoldTicket
            // 
            this.cbxHoldTicket.AutoSize = true;
            this.cbxHoldTicket.Location = new System.Drawing.Point(471, 120);
            this.cbxHoldTicket.Name = "cbxHoldTicket";
            this.cbxHoldTicket.Size = new System.Drawing.Size(81, 17);
            this.cbxHoldTicket.TabIndex = 7;
            this.cbxHoldTicket.Text = "&Hold Ticket";
            this.cbxHoldTicket.UseVisualStyleBackColor = true;
            // 
            // colUser
            // 
            this.colUser.Frozen = true;
            this.colUser.HeaderText = "User";
            this.colUser.Name = "colUser";
            this.colUser.ReadOnly = true;
            this.colUser.Width = 70;
            // 
            // colDate
            // 
            this.colDate.Frozen = true;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colJournalEntry
            // 
            this.colJournalEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJournalEntry.HeaderText = "Entry";
            this.colJournalEntry.Name = "colJournalEntry";
            this.colJournalEntry.ReadOnly = true;
            // 
            // colJournalExpires
            // 
            this.colJournalExpires.HeaderText = "Expires";
            this.colJournalExpires.Name = "colJournalExpires";
            this.colJournalExpires.ReadOnly = true;
            this.colJournalExpires.Width = 130;
            // 
            // FormJournal
            // 
            this.AcceptButton = this.btnAddEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(769, 466);
            this.Controls.Add(this.cbxHoldTicket);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.btnQuickAddEntry);
            this.Controls.Add(this.chkReleaseHold);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlExpires);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.btnAddEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 1200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(785, 450);
            this.Name = "FormJournal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Journal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Hours)).EndInit();
            this.pnlExpires.ResumeLayout(false);
            this.pnlExpires.PerformLayout();
            this.pnlRadioButtonGrouper.ResumeLayout(false);
            this.pnlRadioButtonGrouper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpires_Minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btnAddEntry;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private ucSpellCheckSmall ucSpellCheckSmall;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private ucSpellCheckSmall ucSpellCheckSmall1;
        private System.Windows.Forms.DataGridView dgvJournal;
		private System.Windows.Forms.NumericUpDown numExpires_Hours;
		private System.Windows.Forms.DateTimePicker dtpExpires_Date;
		private System.Windows.Forms.Label lblExpires_Hours;
		private System.Windows.Forms.RadioButton radExpires_HoursMinutes;
		private System.Windows.Forms.RadioButton radExpires_Date;
		private System.Windows.Forms.Panel pnlExpires;
		private System.Windows.Forms.NumericUpDown numExpires_Minutes;
		private System.Windows.Forms.Label lblExpires_Minutes;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlRadioButtonGrouper;
		private System.Windows.Forms.CheckBox chkReleaseHold;
		private System.Windows.Forms.TextBox txtExpires_SameAsPrior;
		private System.Windows.Forms.RadioButton radExpires_SameAsPrior;
		private System.Windows.Forms.Button btnQuickAddEntry;
        public System.Windows.Forms.CheckBox cbxHoldTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
    }
}