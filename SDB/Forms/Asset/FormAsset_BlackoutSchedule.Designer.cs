namespace SDB.Forms.Asset
{
	partial class FormAsset_BlackoutSchedule
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAddEntry = new System.Windows.Forms.Button();
			this.flpBlackoutScheduleEntries = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(214, 227);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(295, 227);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAddEntry
			// 
			this.btnAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddEntry.Location = new System.Drawing.Point(12, 227);
			this.btnAddEntry.Name = "btnAddEntry";
			this.btnAddEntry.Size = new System.Drawing.Size(97, 23);
			this.btnAddEntry.TabIndex = 4;
			this.btnAddEntry.Text = "Add Entry";
			this.btnAddEntry.UseVisualStyleBackColor = true;
			this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
			// 
			// flpBlackoutScheduleEntries
			// 
			this.flpBlackoutScheduleEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpBlackoutScheduleEntries.AutoScroll = true;
			this.flpBlackoutScheduleEntries.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpBlackoutScheduleEntries.Location = new System.Drawing.Point(12, 12);
			this.flpBlackoutScheduleEntries.Name = "flpBlackoutScheduleEntries";
			this.flpBlackoutScheduleEntries.Size = new System.Drawing.Size(360, 209);
			this.flpBlackoutScheduleEntries.TabIndex = 6;
			this.flpBlackoutScheduleEntries.WrapContents = false;
			// 
			// FormAsset_BlackoutScheduleImproved
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(384, 262);
			this.Controls.Add(this.flpBlackoutScheduleEntries);
			this.Controls.Add(this.btnAddEntry);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 600);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(380, 200);
			this.Name = "FormAsset_BlackoutScheduleImproved";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Blackout Schedule";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAddEntry;
		private System.Windows.Forms.FlowLayoutPanel flpBlackoutScheduleEntries;
	}
}