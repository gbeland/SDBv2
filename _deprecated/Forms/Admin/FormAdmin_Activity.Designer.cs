namespace SDB.Forms.Admin
{
	partial class FormAdmin_Activity
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin_Activity));
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.pnlLoggedIn = new System.Windows.Forms.Panel();
			this.olvLoggedIn = new BrightIdeasSoftware.ObjectListView();
			this.olvColLoggedIn_UserID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColLoggedIn_FirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColLoggedIn_LastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColLoggedIn_LoggedIn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColLoggedIn_Duration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColLoggedIn_IpAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlLoggedIn_Control = new System.Windows.Forms.Panel();
			this.txtLoggedIn_Qty = new System.Windows.Forms.TextBox();
			this.lblLoggedIn_Qty = new System.Windows.Forms.Label();
			this.lblLoggedIn = new System.Windows.Forms.Label();
			this.pnlRMARepairs = new System.Windows.Forms.Panel();
			this.olvRMARepairs = new BrightIdeasSoftware.ObjectListView();
			this.olvColRMARepairs_RMAID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMARepairs_TicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMARepairs_Assembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMARepairs_StartDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMARepairs_User = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlRMARepairs_Control = new System.Windows.Forms.Panel();
			this.txtRMARepairs_Qty = new System.Windows.Forms.TextBox();
			this.lblRMARepairs_Qty = new System.Windows.Forms.Label();
			this.lblRMARepairs = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabUsers = new System.Windows.Forms.TabPage();
			this.lblDivider = new System.Windows.Forms.Label();
			this.tabRMAActivity = new System.Windows.Forms.TabPage();
			this.tabEventLog = new System.Windows.Forms.TabPage();
			this.rtbEventLog = new System.Windows.Forms.RichTextBox();
			this.btnPause = new System.Windows.Forms.Button();
			this.pnlLoggedIn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvLoggedIn)).BeginInit();
			this.pnlLoggedIn_Control.SuspendLayout();
			this.pnlRMARepairs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvRMARepairs)).BeginInit();
			this.pnlRMARepairs_Control.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabUsers.SuspendLayout();
			this.tabRMAActivity.SuspendLayout();
			this.tabEventLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerRefresh
			// 
			this.timerRefresh.Interval = 3000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// pnlLoggedIn
			// 
			this.pnlLoggedIn.Controls.Add(this.olvLoggedIn);
			this.pnlLoggedIn.Controls.Add(this.pnlLoggedIn_Control);
			this.pnlLoggedIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLoggedIn.Location = new System.Drawing.Point(3, 3);
			this.pnlLoggedIn.Name = "pnlLoggedIn";
			this.pnlLoggedIn.Size = new System.Drawing.Size(856, 491);
			this.pnlLoggedIn.TabIndex = 0;
			// 
			// olvLoggedIn
			// 
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_UserID);
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_FirstName);
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_LastName);
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_LoggedIn);
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_Duration);
			this.olvLoggedIn.AllColumns.Add(this.olvColLoggedIn_IpAddress);
			this.olvLoggedIn.CellEditUseWholeCell = false;
			this.olvLoggedIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColLoggedIn_UserID,
            this.olvColLoggedIn_FirstName,
            this.olvColLoggedIn_LastName,
            this.olvColLoggedIn_LoggedIn,
            this.olvColLoggedIn_Duration,
            this.olvColLoggedIn_IpAddress});
			this.olvLoggedIn.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvLoggedIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvLoggedIn.FullRowSelect = true;
			this.olvLoggedIn.GridLines = true;
			this.olvLoggedIn.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.olvLoggedIn.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.olvLoggedIn.Location = new System.Drawing.Point(0, 30);
			this.olvLoggedIn.MultiSelect = false;
			this.olvLoggedIn.Name = "olvLoggedIn";
			this.olvLoggedIn.ShowGroups = false;
			this.olvLoggedIn.ShowImagesOnSubItems = true;
			this.olvLoggedIn.Size = new System.Drawing.Size(856, 461);
			this.olvLoggedIn.TabIndex = 0;
			this.olvLoggedIn.UseCompatibleStateImageBehavior = false;
			this.olvLoggedIn.UseSubItemCheckBoxes = true;
			this.olvLoggedIn.View = System.Windows.Forms.View.Details;
			this.olvLoggedIn.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvLoggedIn_FormatRow);
			// 
			// olvColLoggedIn_UserID
			// 
			this.olvColLoggedIn_UserID.AspectName = "ID";
			this.olvColLoggedIn_UserID.Text = "User ID";
			// 
			// olvColLoggedIn_FirstName
			// 
			this.olvColLoggedIn_FirstName.AspectName = "First";
			this.olvColLoggedIn_FirstName.Text = "First";
			this.olvColLoggedIn_FirstName.Width = 90;
			// 
			// olvColLoggedIn_LastName
			// 
			this.olvColLoggedIn_LastName.AspectName = "Last";
			this.olvColLoggedIn_LastName.Text = "Last";
			this.olvColLoggedIn_LastName.Width = 90;
			// 
			// olvColLoggedIn_LoggedIn
			// 
			this.olvColLoggedIn_LoggedIn.AspectName = "LoggedIn";
			this.olvColLoggedIn_LoggedIn.IsEditable = false;
			this.olvColLoggedIn_LoggedIn.Text = "Logged In";
			this.olvColLoggedIn_LoggedIn.Width = 120;
			// 
			// olvColLoggedIn_Duration
			// 
			this.olvColLoggedIn_Duration.AspectName = "LoggedInDuration";
			this.olvColLoggedIn_Duration.Text = "Duration";
			this.olvColLoggedIn_Duration.Width = 100;
			// 
			// olvColLoggedIn_IpAddress
			// 
			this.olvColLoggedIn_IpAddress.AspectName = "LoginFromIpAddress";
			this.olvColLoggedIn_IpAddress.Text = "IP Address";
			this.olvColLoggedIn_IpAddress.Width = 100;
			// 
			// pnlLoggedIn_Control
			// 
			this.pnlLoggedIn_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlLoggedIn_Control.Controls.Add(this.txtLoggedIn_Qty);
			this.pnlLoggedIn_Control.Controls.Add(this.lblLoggedIn_Qty);
			this.pnlLoggedIn_Control.Controls.Add(this.lblLoggedIn);
			this.pnlLoggedIn_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLoggedIn_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlLoggedIn_Control.Name = "pnlLoggedIn_Control";
			this.pnlLoggedIn_Control.Size = new System.Drawing.Size(856, 30);
			this.pnlLoggedIn_Control.TabIndex = 1;
			// 
			// txtLoggedIn_Qty
			// 
			this.txtLoggedIn_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLoggedIn_Qty.Location = new System.Drawing.Point(810, 6);
			this.txtLoggedIn_Qty.Name = "txtLoggedIn_Qty";
			this.txtLoggedIn_Qty.ReadOnly = true;
			this.txtLoggedIn_Qty.Size = new System.Drawing.Size(43, 20);
			this.txtLoggedIn_Qty.TabIndex = 2;
			this.txtLoggedIn_Qty.TabStop = false;
			this.txtLoggedIn_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblLoggedIn_Qty
			// 
			this.lblLoggedIn_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLoggedIn_Qty.AutoSize = true;
			this.lblLoggedIn_Qty.Location = new System.Drawing.Point(770, 9);
			this.lblLoggedIn_Qty.Name = "lblLoggedIn_Qty";
			this.lblLoggedIn_Qty.Size = new System.Drawing.Size(34, 13);
			this.lblLoggedIn_Qty.TabIndex = 1;
			this.lblLoggedIn_Qty.Text = "Users";
			// 
			// lblLoggedIn
			// 
			this.lblLoggedIn.AutoSize = true;
			this.lblLoggedIn.Location = new System.Drawing.Point(3, 9);
			this.lblLoggedIn.Name = "lblLoggedIn";
			this.lblLoggedIn.Size = new System.Drawing.Size(118, 13);
			this.lblLoggedIn.TabIndex = 0;
			this.lblLoggedIn.Text = "Users Logged In Status";
			// 
			// pnlRMARepairs
			// 
			this.pnlRMARepairs.Controls.Add(this.olvRMARepairs);
			this.pnlRMARepairs.Controls.Add(this.pnlRMARepairs_Control);
			this.pnlRMARepairs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlRMARepairs.Location = new System.Drawing.Point(3, 3);
			this.pnlRMARepairs.Name = "pnlRMARepairs";
			this.pnlRMARepairs.Size = new System.Drawing.Size(856, 491);
			this.pnlRMARepairs.TabIndex = 2;
			// 
			// olvRMARepairs
			// 
			this.olvRMARepairs.AllColumns.Add(this.olvColRMARepairs_RMAID);
			this.olvRMARepairs.AllColumns.Add(this.olvColRMARepairs_TicketID);
			this.olvRMARepairs.AllColumns.Add(this.olvColRMARepairs_Assembly);
			this.olvRMARepairs.AllColumns.Add(this.olvColRMARepairs_StartDate);
			this.olvRMARepairs.AllColumns.Add(this.olvColRMARepairs_User);
			this.olvRMARepairs.CellEditUseWholeCell = false;
			this.olvRMARepairs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRMARepairs_RMAID,
            this.olvColRMARepairs_TicketID,
            this.olvColRMARepairs_Assembly,
            this.olvColRMARepairs_StartDate,
            this.olvColRMARepairs_User});
			this.olvRMARepairs.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvRMARepairs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRMARepairs.FullRowSelect = true;
			this.olvRMARepairs.GridLines = true;
			this.olvRMARepairs.HighlightBackgroundColor = System.Drawing.Color.Empty;
			this.olvRMARepairs.HighlightForegroundColor = System.Drawing.Color.Empty;
			this.olvRMARepairs.Location = new System.Drawing.Point(0, 30);
			this.olvRMARepairs.MultiSelect = false;
			this.olvRMARepairs.Name = "olvRMARepairs";
			this.olvRMARepairs.ShowGroups = false;
			this.olvRMARepairs.ShowImagesOnSubItems = true;
			this.olvRMARepairs.Size = new System.Drawing.Size(856, 461);
			this.olvRMARepairs.TabIndex = 0;
			this.olvRMARepairs.UseCompatibleStateImageBehavior = false;
			this.olvRMARepairs.UseSubItemCheckBoxes = true;
			this.olvRMARepairs.View = System.Windows.Forms.View.Details;
			// 
			// olvColRMARepairs_RMAID
			// 
			this.olvColRMARepairs_RMAID.AspectName = "RMA_ID";
			this.olvColRMARepairs_RMAID.Text = "RMA";
			// 
			// olvColRMARepairs_TicketID
			// 
			this.olvColRMARepairs_TicketID.AspectName = "Ticket_ID";
			this.olvColRMARepairs_TicketID.Text = "Ticket";
			// 
			// olvColRMARepairs_Assembly
			// 
			this.olvColRMARepairs_Assembly.AspectName = "AssemblyType";
			this.olvColRMARepairs_Assembly.Text = "Assembly Type";
			this.olvColRMARepairs_Assembly.Width = 200;
			// 
			// olvColRMARepairs_StartDate
			// 
			this.olvColRMARepairs_StartDate.AspectName = "Repair_Start";
			this.olvColRMARepairs_StartDate.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
			this.olvColRMARepairs_StartDate.Text = "Date";
			this.olvColRMARepairs_StartDate.Width = 120;
			// 
			// olvColRMARepairs_User
			// 
			this.olvColRMARepairs_User.AspectName = "UserName";
			this.olvColRMARepairs_User.Text = "User";
			this.olvColRMARepairs_User.Width = 90;
			// 
			// pnlRMARepairs_Control
			// 
			this.pnlRMARepairs_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlRMARepairs_Control.Controls.Add(this.txtRMARepairs_Qty);
			this.pnlRMARepairs_Control.Controls.Add(this.lblRMARepairs_Qty);
			this.pnlRMARepairs_Control.Controls.Add(this.lblRMARepairs);
			this.pnlRMARepairs_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRMARepairs_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlRMARepairs_Control.Name = "pnlRMARepairs_Control";
			this.pnlRMARepairs_Control.Size = new System.Drawing.Size(856, 30);
			this.pnlRMARepairs_Control.TabIndex = 1;
			// 
			// txtRMARepairs_Qty
			// 
			this.txtRMARepairs_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRMARepairs_Qty.Location = new System.Drawing.Point(810, 6);
			this.txtRMARepairs_Qty.Name = "txtRMARepairs_Qty";
			this.txtRMARepairs_Qty.ReadOnly = true;
			this.txtRMARepairs_Qty.Size = new System.Drawing.Size(43, 20);
			this.txtRMARepairs_Qty.TabIndex = 2;
			this.txtRMARepairs_Qty.TabStop = false;
			this.txtRMARepairs_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRMARepairs_Qty
			// 
			this.lblRMARepairs_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRMARepairs_Qty.AutoSize = true;
			this.lblRMARepairs_Qty.Location = new System.Drawing.Point(761, 9);
			this.lblRMARepairs_Qty.Name = "lblRMARepairs_Qty";
			this.lblRMARepairs_Qty.Size = new System.Drawing.Size(43, 13);
			this.lblRMARepairs_Qty.TabIndex = 1;
			this.lblRMARepairs_Qty.Text = "Repairs";
			// 
			// lblRMARepairs
			// 
			this.lblRMARepairs.AutoSize = true;
			this.lblRMARepairs.Location = new System.Drawing.Point(3, 9);
			this.lblRMARepairs.Name = "lblRMARepairs";
			this.lblRMARepairs.Size = new System.Drawing.Size(125, 13);
			this.lblRMARepairs.TabIndex = 0;
			this.lblRMARepairs.Text = "RMA Repairs in Progress";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(807, 541);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabUsers);
			this.tabControl1.Controls.Add(this.tabRMAActivity);
			this.tabControl1.Controls.Add(this.tabEventLog);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(870, 523);
			this.tabControl1.TabIndex = 4;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabUsers
			// 
			this.tabUsers.Controls.Add(this.lblDivider);
			this.tabUsers.Controls.Add(this.pnlLoggedIn);
			this.tabUsers.Location = new System.Drawing.Point(4, 22);
			this.tabUsers.Name = "tabUsers";
			this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
			this.tabUsers.Size = new System.Drawing.Size(862, 497);
			this.tabUsers.TabIndex = 0;
			this.tabUsers.Text = "Users";
			this.tabUsers.UseVisualStyleBackColor = true;
			// 
			// lblDivider
			// 
			this.lblDivider.BackColor = System.Drawing.Color.Black;
			this.lblDivider.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblDivider.Location = new System.Drawing.Point(3, 3);
			this.lblDivider.Name = "lblDivider";
			this.lblDivider.Size = new System.Drawing.Size(1, 491);
			this.lblDivider.TabIndex = 3;
			// 
			// tabRMAActivity
			// 
			this.tabRMAActivity.Controls.Add(this.pnlRMARepairs);
			this.tabRMAActivity.Location = new System.Drawing.Point(4, 22);
			this.tabRMAActivity.Name = "tabRMAActivity";
			this.tabRMAActivity.Padding = new System.Windows.Forms.Padding(3);
			this.tabRMAActivity.Size = new System.Drawing.Size(862, 497);
			this.tabRMAActivity.TabIndex = 2;
			this.tabRMAActivity.Text = "RMA Activity";
			this.tabRMAActivity.UseVisualStyleBackColor = true;
			// 
			// tabEventLog
			// 
			this.tabEventLog.Controls.Add(this.rtbEventLog);
			this.tabEventLog.Location = new System.Drawing.Point(4, 22);
			this.tabEventLog.Name = "tabEventLog";
			this.tabEventLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabEventLog.Size = new System.Drawing.Size(862, 497);
			this.tabEventLog.TabIndex = 1;
			this.tabEventLog.Text = "Event Log";
			this.tabEventLog.UseVisualStyleBackColor = true;
			// 
			// rtbEventLog
			// 
			this.rtbEventLog.BackColor = System.Drawing.Color.Black;
			this.rtbEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbEventLog.ForeColor = System.Drawing.Color.White;
			this.rtbEventLog.Location = new System.Drawing.Point(3, 3);
			this.rtbEventLog.Name = "rtbEventLog";
			this.rtbEventLog.Size = new System.Drawing.Size(856, 491);
			this.rtbEventLog.TabIndex = 0;
			this.rtbEventLog.Text = "";
			// 
			// btnPause
			// 
			this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPause.Location = new System.Drawing.Point(12, 541);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(75, 23);
			this.btnPause.TabIndex = 1;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// FormAdmin_Activity
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(894, 576);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnClose);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 200);
			this.Name = "FormAdmin_Activity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Admin: Activity";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_Activity_FormClosing);
			this.Load += new System.EventHandler(this.FormAdminActivity_Load);
			this.pnlLoggedIn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvLoggedIn)).EndInit();
			this.pnlLoggedIn_Control.ResumeLayout(false);
			this.pnlLoggedIn_Control.PerformLayout();
			this.pnlRMARepairs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvRMARepairs)).EndInit();
			this.pnlRMARepairs_Control.ResumeLayout(false);
			this.pnlRMARepairs_Control.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabUsers.ResumeLayout(false);
			this.tabRMAActivity.ResumeLayout(false);
			this.tabEventLog.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer timerRefresh;
		private System.Windows.Forms.Panel pnlLoggedIn;
		private BrightIdeasSoftware.ObjectListView olvLoggedIn;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_UserID;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_FirstName;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_LastName;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_LoggedIn;
		private System.Windows.Forms.Panel pnlLoggedIn_Control;
		private System.Windows.Forms.TextBox txtLoggedIn_Qty;
		private System.Windows.Forms.Label lblLoggedIn_Qty;
		private System.Windows.Forms.Label lblLoggedIn;
		private System.Windows.Forms.Panel pnlRMARepairs;
		private BrightIdeasSoftware.ObjectListView olvRMARepairs;
		private System.Windows.Forms.Panel pnlRMARepairs_Control;
		private System.Windows.Forms.TextBox txtRMARepairs_Qty;
		private System.Windows.Forms.Label lblRMARepairs_Qty;
		private System.Windows.Forms.Label lblRMARepairs;
		private BrightIdeasSoftware.OLVColumn olvColRMARepairs_RMAID;
		private BrightIdeasSoftware.OLVColumn olvColRMARepairs_TicketID;
		private BrightIdeasSoftware.OLVColumn olvColRMARepairs_Assembly;
		private BrightIdeasSoftware.OLVColumn olvColRMARepairs_StartDate;
		private BrightIdeasSoftware.OLVColumn olvColRMARepairs_User;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabUsers;
		private System.Windows.Forms.Label lblDivider;
		private System.Windows.Forms.TabPage tabEventLog;
		private System.Windows.Forms.RichTextBox rtbEventLog;
		private System.Windows.Forms.Button btnPause;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_Duration;
		private System.Windows.Forms.TabPage tabRMAActivity;
		private BrightIdeasSoftware.OLVColumn olvColLoggedIn_IpAddress;
	}
}