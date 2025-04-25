namespace Curator
{
	sealed partial class FormCurator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurator));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInitiate = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInitiate_UnreceivedRma1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInitiate_UnreceivedRma2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblEmailStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblLog = new System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHide = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timerUnreceivedRmaCheck = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.timerGuiUpdate = new System.Windows.Forms.Timer(this.components);
			this.bgwEmailSender = new System.ComponentModel.BackgroundWorker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(343, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInitiate,
            this.toolStripSeparator2,
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(37, 20);
			this.mnuFile.Text = "&File";
			// 
			// mnuInitiate
			// 
			this.mnuInitiate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInitiate_UnreceivedRma1,
            this.mnuInitiate_UnreceivedRma2});
			this.mnuInitiate.Name = "mnuInitiate";
			this.mnuInitiate.Size = new System.Drawing.Size(135, 22);
			this.mnuInitiate.Text = "&Initiate";
			// 
			// mnuInitiate_UnreceivedRma1
			// 
			this.mnuInitiate_UnreceivedRma1.Name = "mnuInitiate_UnreceivedRma1";
			this.mnuInitiate_UnreceivedRma1.Size = new System.Drawing.Size(229, 22);
			this.mnuInitiate_UnreceivedRma1.Text = "Unreceived RMA Check (&1st)";
			this.mnuInitiate_UnreceivedRma1.Click += new System.EventHandler(this.mnuInitiateUnreceivedRma1_Click);
			// 
			// mnuInitiate_UnreceivedRma2
			// 
			this.mnuInitiate_UnreceivedRma2.Name = "mnuInitiate_UnreceivedRma2";
			this.mnuInitiate_UnreceivedRma2.Size = new System.Drawing.Size(229, 22);
			this.mnuInitiate_UnreceivedRma2.Text = "Unreceived RMA Check (&2nd)";
			this.mnuInitiate_UnreceivedRma2.Click += new System.EventHandler(this.mnuInitiateUnreceivedRma2_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.mnuExit.Size = new System.Drawing.Size(135, 22);
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuEdit
			// 
			this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSettings});
			this.mnuEdit.Name = "mnuEdit";
			this.mnuEdit.Size = new System.Drawing.Size(39, 20);
			this.mnuEdit.Text = "&Edit";
			// 
			// mnuSettings
			// 
			this.mnuSettings.Name = "mnuSettings";
			this.mnuSettings.Size = new System.Drawing.Size(125, 22);
			this.mnuSettings.Text = "&Settings...";
			this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblEmailStatus,
            this.lblSpacer,
            this.lblLog});
			this.statusStrip1.Location = new System.Drawing.Point(0, 173);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(343, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(39, 19);
			this.lblStatus.Text = "Status";
			// 
			// lblEmailStatus
			// 
			this.lblEmailStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.lblEmailStatus.Name = "lblEmailStatus";
			this.lblEmailStatus.Size = new System.Drawing.Size(90, 19);
			this.lblEmailStatus.Text = "Email Queue: 0";
			// 
			// lblSpacer
			// 
			this.lblSpacer.Name = "lblSpacer";
			this.lblSpacer.Size = new System.Drawing.Size(172, 19);
			this.lblSpacer.Spring = true;
			// 
			// lblLog
			// 
			this.lblLog.IsLink = true;
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(27, 19);
			this.lblLog.Text = "Log";
			this.lblLog.Click += new System.EventHandler(this.lblLog_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTitle,
            this.tsmiShow,
            this.tsmiHide,
            this.toolStripSeparator1,
            this.tsmiExit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(144, 98);
			// 
			// tsmiTitle
			// 
			this.tsmiTitle.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tsmiTitle.Enabled = false;
			this.tsmiTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.tsmiTitle.Name = "tsmiTitle";
			this.tsmiTitle.Size = new System.Drawing.Size(143, 22);
			this.tsmiTitle.Text = "NOC Service Database Curator";
			// 
			// tsmiShow
			// 
			this.tsmiShow.Name = "tsmiShow";
			this.tsmiShow.Size = new System.Drawing.Size(143, 22);
			this.tsmiShow.Text = "&Show";
			this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
			// 
			// tsmiHide
			// 
			this.tsmiHide.Name = "tsmiHide";
			this.tsmiHide.Size = new System.Drawing.Size(143, 22);
			this.tsmiHide.Text = "&Hide";
			this.tsmiHide.Click += new System.EventHandler(this.tsmiHide_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(143, 22);
			this.tsmiExit.Text = "E&xit";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// timerUnreceivedRmaCheck
			// 
			this.timerUnreceivedRmaCheck.Interval = 60000;
			this.timerUnreceivedRmaCheck.Tick += new System.EventHandler(this.timerUnreceivedRmaCheck_Tick);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "NOC Service Database Curator";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// timerGuiUpdate
			// 
			this.timerGuiUpdate.Enabled = true;
			this.timerGuiUpdate.Interval = 1000;
			this.timerGuiUpdate.Tick += new System.EventHandler(this.timerGuiUpdate_Tick);
			// 
			// bgwEmailSender
			// 
			this.bgwEmailSender.WorkerReportsProgress = true;
			this.bgwEmailSender.WorkerSupportsCancellation = true;
			this.bgwEmailSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwEmailSender_DoWork);
			this.bgwEmailSender.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwEmailSender_ProgressChanged);
			this.bgwEmailSender.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwEmailSender_RunWorkerCompleted);
			// 
			// btnCancel
			// 
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(174, 87);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnStartStop
			// 
			this.btnStartStop.Location = new System.Drawing.Point(93, 87);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 8;
			this.btnStartStop.Text = "Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// FormCurator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(343, 197);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCurator";
			this.Text = "Curator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCurator_FormClosing);
			this.Load += new System.EventHandler(this.FormCurator_Load);
			this.ResizeEnd += new System.EventHandler(this.FormCurator_ResizeEnd);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mnuFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiTitle;
		private System.Windows.Forms.ToolStripMenuItem tsmiShow;
		private System.Windows.Forms.ToolStripMenuItem tsmiHide;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuEdit;
		private System.Windows.Forms.ToolStripMenuItem mnuSettings;
		private System.Windows.Forms.Timer timerUnreceivedRmaCheck;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripMenuItem mnuInitiate;
		private System.Windows.Forms.ToolStripMenuItem mnuInitiate_UnreceivedRma1;
		private System.Windows.Forms.ToolStripMenuItem mnuInitiate_UnreceivedRma2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Timer timerGuiUpdate;
		private System.ComponentModel.BackgroundWorker bgwEmailSender;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolStripStatusLabel lblEmailStatus;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
		private System.Windows.Forms.ToolStripStatusLabel lblLog;
	}
}

