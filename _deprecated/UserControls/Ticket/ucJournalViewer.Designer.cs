namespace SDB.UserControls.Ticket
{
	partial class ucJournalViewer
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvJournal = new System.Windows.Forms.DataGridView();
			this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJournalEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colJournalExpires = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlJournal = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
			this.pnlJournal.SuspendLayout();
			this.SuspendLayout();
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
			this.dgvJournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvJournal.BackgroundColor = System.Drawing.SystemColors.Window;
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
			this.dgvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvJournal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvJournal.Location = new System.Drawing.Point(0, 0);
			this.dgvJournal.Name = "dgvJournal";
			this.dgvJournal.ReadOnly = true;
			this.dgvJournal.RowHeadersVisible = false;
			this.dgvJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvJournal.ShowCellErrors = false;
			this.dgvJournal.ShowCellToolTips = false;
			this.dgvJournal.ShowEditingIcon = false;
			this.dgvJournal.ShowRowErrors = false;
			this.dgvJournal.Size = new System.Drawing.Size(700, 221);
			this.dgvJournal.TabIndex = 34;
			this.dgvJournal.TabStop = false;
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
			// pnlJournal
			// 
			this.pnlJournal.AutoScroll = true;
			this.pnlJournal.Controls.Add(this.dgvJournal);
			this.pnlJournal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlJournal.Location = new System.Drawing.Point(0, 0);
			this.pnlJournal.Name = "pnlJournal";
			this.pnlJournal.Size = new System.Drawing.Size(700, 221);
			this.pnlJournal.TabIndex = 35;
			// 
			// ucJournalViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlJournal);
			this.Name = "ucJournalViewer";
			this.Size = new System.Drawing.Size(700, 221);
			((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
			this.pnlJournal.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvJournal;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalEntry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colJournalExpires;
		private System.Windows.Forms.Panel pnlJournal;
	}
}
