namespace SDB.Forms.CameraCheck
{
	partial class FormCameraCheck
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraCheck));
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.chkAutoCycle = new System.Windows.Forms.CheckBox();
			this.chkAutoSubmitContinue = new System.Windows.Forms.CheckBox();
			this.chkHideButtons = new System.Windows.Forms.CheckBox();
			this.btnSubmitRetrieveNext = new System.Windows.Forms.Button();
			this.flpMode = new System.Windows.Forms.FlowLayoutPanel();
			this.lblMode = new System.Windows.Forms.Label();
			this.radModeNormal = new System.Windows.Forms.RadioButton();
			this.radModeTicketed = new System.Windows.Forms.RadioButton();
			this.radModeBlackout = new System.Windows.Forms.RadioButton();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.timerQtyCheck = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblMessage = new System.Windows.Forms.Label();
			this.prgLoading = new System.Windows.Forms.ProgressBar();
			this.lblLoading = new System.Windows.Forms.Label();
			this.pnlControl.SuspendLayout();
			this.flpMode.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRetrieve
			// 
			this.btnRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnRetrieve.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnRetrieve.Location = new System.Drawing.Point(328, 0);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(120, 30);
			this.btnRetrieve.TabIndex = 1;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.Gray;
			this.pnlControl.Controls.Add(this.chkAutoCycle);
			this.pnlControl.Controls.Add(this.chkAutoSubmitContinue);
			this.pnlControl.Controls.Add(this.chkHideButtons);
			this.pnlControl.Controls.Add(this.btnSubmitRetrieveNext);
			this.pnlControl.Controls.Add(this.btnRetrieve);
			this.pnlControl.Controls.Add(this.flpMode);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(1067, 30);
			this.pnlControl.TabIndex = 0;
			// 
			// ckbAutoCycle
			// 
			this.chkAutoCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAutoCycle.AutoSize = true;
			this.chkAutoCycle.Location = new System.Drawing.Point(612, 7);
			this.chkAutoCycle.Name = "chkAutoCycle";
			this.chkAutoCycle.Size = new System.Drawing.Size(114, 17);
			this.chkAutoCycle.TabIndex = 5;
			this.chkAutoCycle.Text = "Auto Cycle Images";
			this.chkAutoCycle.UseVisualStyleBackColor = true;
			this.chkAutoCycle.Click += new System.EventHandler(this.ckbAutoCycle_Click);
			// 
			// chkAutoSubmitContinue
			// 
			this.chkAutoSubmitContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkAutoSubmitContinue.AutoSize = true;
			this.chkAutoSubmitContinue.Location = new System.Drawing.Point(732, 7);
			this.chkAutoSubmitContinue.Name = "chkAutoSubmitContinue";
			this.chkAutoSubmitContinue.Size = new System.Drawing.Size(137, 17);
			this.chkAutoSubmitContinue.TabIndex = 4;
			this.chkAutoSubmitContinue.Text = "Auto Submit && Continue";
			this.toolTip1.SetToolTip(this.chkAutoSubmitContinue, "Automatically submit and continue when all camera checks pass.");
			this.chkAutoSubmitContinue.UseVisualStyleBackColor = true;
			this.chkAutoSubmitContinue.CheckedChanged += new System.EventHandler(this.chkAutoSubmitContinue_CheckedChanged);
			// 
			// chkHideButtons
			// 
			this.chkHideButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkHideButtons.AutoSize = true;
			this.chkHideButtons.Location = new System.Drawing.Point(875, 7);
			this.chkHideButtons.Name = "chkHideButtons";
			this.chkHideButtons.Size = new System.Drawing.Size(180, 17);
			this.chkHideButtons.TabIndex = 3;
			this.chkHideButtons.Text = "Hide Buttons on Camera Checks";
			this.chkHideButtons.UseVisualStyleBackColor = true;
			this.chkHideButtons.CheckedChanged += new System.EventHandler(this.chkHideButtons_CheckedChanged);
			// 
			// btnSubmitRetrieveNext
			// 
			this.btnSubmitRetrieveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSubmitRetrieveNext.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSubmitRetrieveNext.Enabled = false;
			this.btnSubmitRetrieveNext.Location = new System.Drawing.Point(448, 0);
			this.btnSubmitRetrieveNext.Name = "btnSubmitRetrieveNext";
			this.btnSubmitRetrieveNext.Size = new System.Drawing.Size(120, 30);
			this.btnSubmitRetrieveNext.TabIndex = 2;
			this.btnSubmitRetrieveNext.Text = "Submit && Continue";
			this.btnSubmitRetrieveNext.UseVisualStyleBackColor = false;
			this.btnSubmitRetrieveNext.Click += new System.EventHandler(this.btnSubmitRetrieveNext_Click);
			// 
			// flpMode
			// 
			this.flpMode.Controls.Add(this.lblMode);
			this.flpMode.Controls.Add(this.radModeNormal);
			this.flpMode.Controls.Add(this.radModeTicketed);
			this.flpMode.Controls.Add(this.radModeBlackout);
			this.flpMode.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpMode.Location = new System.Drawing.Point(0, 0);
			this.flpMode.Name = "flpMode";
			this.flpMode.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.flpMode.Size = new System.Drawing.Size(328, 30);
			this.flpMode.TabIndex = 0;
			this.flpMode.WrapContents = false;
			// 
			// lblMode
			// 
			this.lblMode.Location = new System.Drawing.Point(3, 4);
			this.lblMode.Name = "lblMode";
			this.lblMode.Size = new System.Drawing.Size(37, 21);
			this.lblMode.TabIndex = 3;
			this.lblMode.Text = "Mode:";
			this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// radModeNormal
			// 
			this.radModeNormal.AutoSize = true;
			this.radModeNormal.Checked = true;
			this.radModeNormal.Location = new System.Drawing.Point(46, 7);
			this.radModeNormal.Name = "radModeNormal";
			this.radModeNormal.Size = new System.Drawing.Size(58, 17);
			this.radModeNormal.TabIndex = 0;
			this.radModeNormal.TabStop = true;
			this.radModeNormal.Text = "Normal";
			this.radModeNormal.UseVisualStyleBackColor = true;
			this.radModeNormal.CheckedChanged += new System.EventHandler(this.radModeNormal_CheckedChanged);
			// 
			// radModeTicketed
			// 
			this.radModeTicketed.AutoSize = true;
			this.radModeTicketed.Location = new System.Drawing.Point(110, 7);
			this.radModeTicketed.Name = "radModeTicketed";
			this.radModeTicketed.Size = new System.Drawing.Size(67, 17);
			this.radModeTicketed.TabIndex = 1;
			this.radModeTicketed.Text = "Ticketed";
			this.radModeTicketed.UseVisualStyleBackColor = true;
			this.radModeTicketed.CheckedChanged += new System.EventHandler(this.radModeTicketed_CheckedChanged);
			// 
			// radModeBlackout
			// 
			this.radModeBlackout.AutoSize = true;
			this.radModeBlackout.Location = new System.Drawing.Point(183, 7);
			this.radModeBlackout.Name = "radModeBlackout";
			this.radModeBlackout.Size = new System.Drawing.Size(67, 17);
			this.radModeBlackout.TabIndex = 2;
			this.radModeBlackout.Text = "Blackout";
			this.radModeBlackout.UseVisualStyleBackColor = true;
			this.radModeBlackout.CheckedChanged += new System.EventHandler(this.radModeBlackout_CheckedChanged);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.Gray;
			this.pnlBottom.Controls.Add(this.btnSubmit);
			this.pnlBottom.Controls.Add(this.lblStatus);
			this.pnlBottom.Controls.Add(this.btnClose);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 677);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(1067, 32);
			this.pnlBottom.TabIndex = 2;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSubmit.Enabled = false;
			this.btnSubmit.Location = new System.Drawing.Point(827, 0);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(120, 32);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 10);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(218, 13);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Select a mode and click \"Retrieve\" to begin.";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.Location = new System.Drawing.Point(947, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 32);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 647);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// timerQtyCheck
			// 
			this.timerQtyCheck.Interval = 10000;
			this.timerQtyCheck.Tick += new System.EventHandler(this.timerQtyCheck_Tick);
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.BackColor = System.Drawing.Color.Black;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.lblMessage.Location = new System.Drawing.Point(50, 80);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(419, 29);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "No camera checks of this type due.";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMessage.Visible = false;
			// 
			// prgbrLoading
			// 
			this.prgLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.prgLoading.Location = new System.Drawing.Point(279, 363);
			this.prgLoading.Name = "prgLoading";
			this.prgLoading.Size = new System.Drawing.Size(508, 23);
			this.prgLoading.Step = 1;
			this.prgLoading.TabIndex = 7;
			this.prgLoading.Visible = false;
			// 
			// lblLoading
			// 
			this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLoading.AutoSize = true;
			this.lblLoading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblLoading.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoading.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblLoading.Location = new System.Drawing.Point(341, 323);
			this.lblLoading.Name = "lblLoading";
			this.lblLoading.Size = new System.Drawing.Size(418, 37);
			this.lblLoading.TabIndex = 6;
			this.lblLoading.Text = "Loading Camera Checks...";
			this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLoading.Visible = false;
			// 
			// FormCameraCheck
			// 
			this.AcceptButton = this.btnSubmitRetrieveNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1067, 709);
			this.Controls.Add(this.prgLoading);
			this.Controls.Add(this.lblLoading);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.pnlControl);
			this.Controls.Add(this.pnlBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCameraCheck";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "SDB: Camera Check";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCameraCheck_FormClosing);
			this.Load += new System.EventHandler(this.FormCameraCheck_Load);
			this.Shown += new System.EventHandler(this.FormCameraCheck_Shown);
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.flpMode.ResumeLayout(false);
			this.flpMode.PerformLayout();
			this.pnlBottom.ResumeLayout(false);
			this.pnlBottom.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRetrieve;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.FlowLayoutPanel flpMode;
		private System.Windows.Forms.RadioButton radModeBlackout;
		private System.Windows.Forms.RadioButton radModeTicketed;
		private System.Windows.Forms.RadioButton radModeNormal;
		private System.Windows.Forms.Label lblMode;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Timer timerQtyCheck;
		private System.Windows.Forms.Button btnSubmitRetrieveNext;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.CheckBox chkHideButtons;
		private System.Windows.Forms.CheckBox chkAutoSubmitContinue;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox chkAutoCycle;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Label lblLoading;
    }
}