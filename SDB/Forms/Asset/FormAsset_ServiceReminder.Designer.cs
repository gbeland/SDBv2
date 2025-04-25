namespace SDB.Forms.Asset
{
    partial class FormAsset_ServiceReminder
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtServiceReminder = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblLastUpdated = new System.Windows.Forms.Label();
			this.txtLastUpdated_User = new System.Windows.Forms.TextBox();
			this.txtLastUpdated_Date = new System.Windows.Forms.TextBox();
			this.lblLastUpdatedOn = new System.Windows.Forms.Label();
			this.pnlLastUpdated = new System.Windows.Forms.Panel();
			this.btnClearAndSave = new System.Windows.Forms.Button();
			this.lblServiceReminderInfo = new System.Windows.Forms.Label();
			this.pnlLastUpdated.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(121, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(201, 16);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Service Reminder for Asset:";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtServiceReminder
			// 
			this.txtServiceReminder.AcceptsTab = true;
			this.txtServiceReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtServiceReminder.Location = new System.Drawing.Point(16, 67);
			this.txtServiceReminder.MaxLength = 10000;
			this.txtServiceReminder.Name = "txtServiceReminder";
			this.txtServiceReminder.Size = new System.Drawing.Size(415, 134);
			this.txtServiceReminder.TabIndex = 1;
			this.txtServiceReminder.Text = "";
			this.txtServiceReminder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServiceReminder_KeyDown);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(356, 241);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(275, 241);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblLastUpdated
			// 
			this.lblLastUpdated.AutoSize = true;
			this.lblLastUpdated.Location = new System.Drawing.Point(23, 6);
			this.lblLastUpdated.Name = "lblLastUpdated";
			this.lblLastUpdated.Size = new System.Drawing.Size(86, 13);
			this.lblLastUpdated.TabIndex = 4;
			this.lblLastUpdated.Text = "Last updated by:";
			// 
			// txtLastUpdated_User
			// 
			this.txtLastUpdated_User.BackColor = System.Drawing.Color.LightGray;
			this.txtLastUpdated_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastUpdated_User.Location = new System.Drawing.Point(115, 4);
			this.txtLastUpdated_User.Name = "txtLastUpdated_User";
			this.txtLastUpdated_User.ReadOnly = true;
			this.txtLastUpdated_User.Size = new System.Drawing.Size(101, 20);
			this.txtLastUpdated_User.TabIndex = 0;
			this.txtLastUpdated_User.TabStop = false;
			this.txtLastUpdated_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtLastUpdated_Date
			// 
			this.txtLastUpdated_Date.BackColor = System.Drawing.Color.LightGray;
			this.txtLastUpdated_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastUpdated_Date.Location = new System.Drawing.Point(250, 4);
			this.txtLastUpdated_Date.Name = "txtLastUpdated_Date";
			this.txtLastUpdated_Date.ReadOnly = true;
			this.txtLastUpdated_Date.Size = new System.Drawing.Size(115, 20);
			this.txtLastUpdated_Date.TabIndex = 2;
			this.txtLastUpdated_Date.TabStop = false;
			this.txtLastUpdated_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblLastUpdatedOn
			// 
			this.lblLastUpdatedOn.AutoSize = true;
			this.lblLastUpdatedOn.Location = new System.Drawing.Point(222, 6);
			this.lblLastUpdatedOn.Name = "lblLastUpdatedOn";
			this.lblLastUpdatedOn.Size = new System.Drawing.Size(22, 13);
			this.lblLastUpdatedOn.TabIndex = 1;
			this.lblLastUpdatedOn.Text = "on:";
			// 
			// pnlLastUpdated
			// 
			this.pnlLastUpdated.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pnlLastUpdated.Controls.Add(this.lblLastUpdated);
			this.pnlLastUpdated.Controls.Add(this.txtLastUpdated_Date);
			this.pnlLastUpdated.Controls.Add(this.txtLastUpdated_User);
			this.pnlLastUpdated.Controls.Add(this.lblLastUpdatedOn);
			this.pnlLastUpdated.Location = new System.Drawing.Point(27, 207);
			this.pnlLastUpdated.Name = "pnlLastUpdated";
			this.pnlLastUpdated.Size = new System.Drawing.Size(388, 28);
			this.pnlLastUpdated.TabIndex = 0;
			this.pnlLastUpdated.Visible = false;
			// 
			// btnClearAndSave
			// 
			this.btnClearAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearAndSave.Location = new System.Drawing.Point(16, 241);
			this.btnClearAndSave.Name = "btnClearAndSave";
			this.btnClearAndSave.Size = new System.Drawing.Size(120, 23);
			this.btnClearAndSave.TabIndex = 4;
			this.btnClearAndSave.Text = "Clear and Save";
			this.btnClearAndSave.UseVisualStyleBackColor = true;
			this.btnClearAndSave.Click += new System.EventHandler(this.btnClearAndSave_Click);
			// 
			// lblServiceReminderInfo
			// 
			this.lblServiceReminderInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblServiceReminderInfo.Location = new System.Drawing.Point(16, 29);
			this.lblServiceReminderInfo.Name = "lblServiceReminderInfo";
			this.lblServiceReminderInfo.Size = new System.Drawing.Size(415, 35);
			this.lblServiceReminderInfo.TabIndex = 5;
			this.lblServiceReminderInfo.Text = "A service reminder should be something to be performed and cleared on next tech v" +
    "isit. Information that always pertains to the asset should be in asset notes.";
			// 
			// FormAsset_ServiceReminder
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(443, 276);
			this.Controls.Add(this.lblServiceReminderInfo);
			this.Controls.Add(this.btnClearAndSave);
			this.Controls.Add(this.pnlLastUpdated);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtServiceReminder);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAsset_ServiceReminder";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Service Reminder";
			this.Load += new System.EventHandler(this.frmAssetServiceReminder_Load);
			this.pnlLastUpdated.ResumeLayout(false);
			this.pnlLastUpdated.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtServiceReminder;
        private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblLastUpdated;
		private System.Windows.Forms.TextBox txtLastUpdated_User;
		private System.Windows.Forms.TextBox txtLastUpdated_Date;
		private System.Windows.Forms.Label lblLastUpdatedOn;
		private System.Windows.Forms.Panel pnlLastUpdated;
		private System.Windows.Forms.Button btnClearAndSave;
		private System.Windows.Forms.Label lblServiceReminderInfo;
	}
}