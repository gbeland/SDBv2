namespace SDB.Forms.General
{
	partial class FormNotifications
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotifications));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblNotificationQty = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSubscriptions = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNotifications = new System.Windows.Forms.TabPage();
			this.olvNotifications = new BrightIdeasSoftware.ObjectListView();
			this.olcNotifications_DateTime = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotifications_From = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotifications_Link = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotifications_Text = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotifications_MarkRead = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcNotifications_Unsubscribe = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
			this.pnlNotifications_Control = new System.Windows.Forms.Panel();
			this.btnMarkAllRead = new System.Windows.Forms.Button();
			this.btnNotifications_Refresh = new System.Windows.Forms.Button();
			this.tabSubscriptions = new System.Windows.Forms.TabPage();
			this.olvSubscriptions = new BrightIdeasSoftware.ObjectListView();
			this.olcSubscriptions_ObjLink = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcSubscriptions_Unsubscribe = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlSubscriptions_Control = new System.Windows.Forms.Panel();
			this.btnUnsubscribeAll = new System.Windows.Forms.Button();
			this.btnSubscriptions_Refresh = new System.Windows.Forms.Button();
			this.timerRefreshNotifications = new System.Windows.Forms.Timer(this.components);
			this.timerRefreshSubscriptions = new System.Windows.Forms.Timer(this.components);
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabNotifications.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvNotifications)).BeginInit();
			this.pnlNotifications_Control.SuspendLayout();
			this.tabSubscriptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.olvSubscriptions)).BeginInit();
			this.pnlSubscriptions_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNotificationQty,
            this.lblSubscriptions});
			this.statusStrip.Location = new System.Drawing.Point(0, 438);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(604, 24);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// lblNotificationQty
			// 
			this.lblNotificationQty.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.lblNotificationQty.Name = "lblNotificationQty";
			this.lblNotificationQty.Size = new System.Drawing.Size(88, 19);
			this.lblNotificationQty.Text = "0 Notifications";
			// 
			// lblSubscriptions
			// 
			this.lblSubscriptions.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.lblSubscriptions.Name = "lblSubscriptions";
			this.lblSubscriptions.Size = new System.Drawing.Size(91, 19);
			this.lblSubscriptions.Text = "0 Subscriptions";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabNotifications);
			this.tabControl.Controls.Add(this.tabSubscriptions);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(604, 438);
			this.tabControl.TabIndex = 1;
			// 
			// tabNotifications
			// 
			this.tabNotifications.Controls.Add(this.olvNotifications);
			this.tabNotifications.Controls.Add(this.pnlNotifications_Control);
			this.tabNotifications.Location = new System.Drawing.Point(4, 22);
			this.tabNotifications.Name = "tabNotifications";
			this.tabNotifications.Padding = new System.Windows.Forms.Padding(3);
			this.tabNotifications.Size = new System.Drawing.Size(596, 412);
			this.tabNotifications.TabIndex = 0;
			this.tabNotifications.Text = "Notifications";
			this.tabNotifications.UseVisualStyleBackColor = true;
			// 
			// olvNotifications
			// 
			this.olvNotifications.AllColumns.Add(this.olcNotifications_DateTime);
			this.olvNotifications.AllColumns.Add(this.olcNotifications_From);
			this.olvNotifications.AllColumns.Add(this.olcNotifications_Link);
			this.olvNotifications.AllColumns.Add(this.olcNotifications_Text);
			this.olvNotifications.AllColumns.Add(this.olcNotifications_MarkRead);
			this.olvNotifications.AllColumns.Add(this.olcNotifications_Unsubscribe);
			this.olvNotifications.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.olvNotifications.CellEditUseWholeCell = false;
			this.olvNotifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcNotifications_DateTime,
            this.olcNotifications_From,
            this.olcNotifications_Link,
            this.olcNotifications_Text,
            this.olcNotifications_MarkRead,
            this.olcNotifications_Unsubscribe});
			this.olvNotifications.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvNotifications.EmptyListMsg = "No Notifications";
			this.olvNotifications.GridLines = true;
			this.olvNotifications.HasCollapsibleGroups = false;
			this.olvNotifications.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvNotifications.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvNotifications.Location = new System.Drawing.Point(3, 33);
			this.olvNotifications.MultiSelect = false;
			this.olvNotifications.Name = "olvNotifications";
			this.olvNotifications.ShowGroups = false;
			this.olvNotifications.Size = new System.Drawing.Size(590, 376);
			this.olvNotifications.SmallImageList = this.imageList16x16;
			this.olvNotifications.TabIndex = 1;
			this.olvNotifications.UseCompatibleStateImageBehavior = false;
			this.olvNotifications.UseHyperlinks = true;
			this.olvNotifications.View = System.Windows.Forms.View.Details;
			this.olvNotifications.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.olvNotifications_CellEditStarting);
			this.olvNotifications.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.olvNotifications_HyperlinkClicked);
			// 
			// olcNotifications_DateTime
			// 
			this.olcNotifications_DateTime.AspectName = "MessageDate";
			this.olcNotifications_DateTime.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcNotifications_DateTime.IsEditable = false;
			this.olcNotifications_DateTime.Text = "Date";
			this.olcNotifications_DateTime.Width = 80;
			// 
			// olcNotifications_From
			// 
			this.olcNotifications_From.AspectName = "FromUserName";
			this.olcNotifications_From.IsEditable = false;
			this.olcNotifications_From.Text = "From";
			this.olcNotifications_From.Width = 65;
			// 
			// olcNotifications_Link
			// 
			this.olcNotifications_Link.AspectName = "LinkText";
			this.olcNotifications_Link.Hyperlink = true;
			this.olcNotifications_Link.IsEditable = false;
			this.olcNotifications_Link.Text = "ID/Name";
			this.olcNotifications_Link.Width = 120;
			// 
			// olcNotifications_Text
			// 
			this.olcNotifications_Text.AspectName = "Message";
			this.olcNotifications_Text.FillsFreeSpace = true;
			this.olcNotifications_Text.IsEditable = false;
			this.olcNotifications_Text.Text = "Text";
			this.olcNotifications_Text.Width = 240;
			// 
			// olcNotifications_MarkRead
			// 
			this.olcNotifications_MarkRead.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcNotifications_MarkRead.Text = "Read";
			this.olcNotifications_MarkRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcNotifications_MarkRead.ToolTipText = "Mark as Read (Delete)";
			this.olcNotifications_MarkRead.Width = 40;
			// 
			// olcNotifications_Unsubscribe
			// 
			this.olcNotifications_Unsubscribe.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcNotifications_Unsubscribe.Text = "XSub";
			this.olcNotifications_Unsubscribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcNotifications_Unsubscribe.ToolTipText = "Unsubscribe";
			this.olcNotifications_Unsubscribe.Width = 40;
			// 
			// imageList16x16
			// 
			this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
			this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList16x16.Images.SetKeyName(0, "markread");
			this.imageList16x16.Images.SetKeyName(1, "unsubscribe");
			// 
			// pnlNotifications_Control
			// 
			this.pnlNotifications_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlNotifications_Control.Controls.Add(this.btnMarkAllRead);
			this.pnlNotifications_Control.Controls.Add(this.btnNotifications_Refresh);
			this.pnlNotifications_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNotifications_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlNotifications_Control.Name = "pnlNotifications_Control";
			this.pnlNotifications_Control.Size = new System.Drawing.Size(590, 30);
			this.pnlNotifications_Control.TabIndex = 0;
			// 
			// btnMarkAllRead
			// 
			this.btnMarkAllRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnMarkAllRead.Location = new System.Drawing.Point(5, 3);
			this.btnMarkAllRead.Name = "btnMarkAllRead";
			this.btnMarkAllRead.Size = new System.Drawing.Size(110, 23);
			this.btnMarkAllRead.TabIndex = 6;
			this.btnMarkAllRead.Text = "Mark All Read";
			this.btnMarkAllRead.UseVisualStyleBackColor = false;
			this.btnMarkAllRead.Click += new System.EventHandler(this.btnMarkAllRead_Click);
			// 
			// btnNotifications_Refresh
			// 
			this.btnNotifications_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNotifications_Refresh.Location = new System.Drawing.Point(510, 3);
			this.btnNotifications_Refresh.Name = "btnNotifications_Refresh";
			this.btnNotifications_Refresh.Size = new System.Drawing.Size(75, 23);
			this.btnNotifications_Refresh.TabIndex = 5;
			this.btnNotifications_Refresh.Text = "Refresh";
			this.btnNotifications_Refresh.UseVisualStyleBackColor = true;
			this.btnNotifications_Refresh.Click += new System.EventHandler(this.btnNotifications_Refresh_Click);
			// 
			// tabSubscriptions
			// 
			this.tabSubscriptions.Controls.Add(this.olvSubscriptions);
			this.tabSubscriptions.Controls.Add(this.pnlSubscriptions_Control);
			this.tabSubscriptions.Location = new System.Drawing.Point(4, 22);
			this.tabSubscriptions.Name = "tabSubscriptions";
			this.tabSubscriptions.Padding = new System.Windows.Forms.Padding(3);
			this.tabSubscriptions.Size = new System.Drawing.Size(596, 412);
			this.tabSubscriptions.TabIndex = 1;
			this.tabSubscriptions.Text = "Subscriptions";
			this.tabSubscriptions.UseVisualStyleBackColor = true;
			// 
			// olvSubscriptions
			// 
			this.olvSubscriptions.AllColumns.Add(this.olcSubscriptions_ObjLink);
			this.olvSubscriptions.AllColumns.Add(this.olcSubscriptions_Unsubscribe);
			this.olvSubscriptions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
			this.olvSubscriptions.CellEditUseWholeCell = false;
			this.olvSubscriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcSubscriptions_ObjLink,
            this.olcSubscriptions_Unsubscribe});
			this.olvSubscriptions.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvSubscriptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSubscriptions.EmptyListMsg = "No Subscriptions";
			this.olvSubscriptions.GridLines = true;
			this.olvSubscriptions.HasCollapsibleGroups = false;
			this.olvSubscriptions.SelectedBackColor = System.Drawing.Color.Empty;
			this.olvSubscriptions.SelectedForeColor = System.Drawing.Color.Empty;
			this.olvSubscriptions.Location = new System.Drawing.Point(3, 33);
			this.olvSubscriptions.MultiSelect = false;
			this.olvSubscriptions.Name = "olvSubscriptions";
			this.olvSubscriptions.ShowGroups = false;
			this.olvSubscriptions.Size = new System.Drawing.Size(590, 376);
			this.olvSubscriptions.SmallImageList = this.imageList16x16;
			this.olvSubscriptions.TabIndex = 3;
			this.olvSubscriptions.UseCompatibleStateImageBehavior = false;
			this.olvSubscriptions.UseHyperlinks = true;
			this.olvSubscriptions.View = System.Windows.Forms.View.Details;
			this.olvSubscriptions.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.olvSubscriptions_CellEditStarting);
			this.olvSubscriptions.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.olvSubscriptions_HyperlinkClicked);
			// 
			// olcSubscriptions_ObjLink
			// 
			this.olcSubscriptions_ObjLink.AspectName = "LinkText";
			this.olcSubscriptions_ObjLink.FillsFreeSpace = true;
			this.olcSubscriptions_ObjLink.Hyperlink = true;
			this.olcSubscriptions_ObjLink.IsEditable = false;
			this.olcSubscriptions_ObjLink.Text = "ID/Name";
			this.olcSubscriptions_ObjLink.Width = 250;
			// 
			// olcSubscriptions_Unsubscribe
			// 
			this.olcSubscriptions_Unsubscribe.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcSubscriptions_Unsubscribe.Text = "XSub";
			this.olcSubscriptions_Unsubscribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.olcSubscriptions_Unsubscribe.ToolTipText = "Unsubscribe";
			this.olcSubscriptions_Unsubscribe.Width = 40;
			// 
			// pnlSubscriptions_Control
			// 
			this.pnlSubscriptions_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlSubscriptions_Control.Controls.Add(this.btnUnsubscribeAll);
			this.pnlSubscriptions_Control.Controls.Add(this.btnSubscriptions_Refresh);
			this.pnlSubscriptions_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSubscriptions_Control.Location = new System.Drawing.Point(3, 3);
			this.pnlSubscriptions_Control.Name = "pnlSubscriptions_Control";
			this.pnlSubscriptions_Control.Size = new System.Drawing.Size(590, 30);
			this.pnlSubscriptions_Control.TabIndex = 2;
			// 
			// btnUnsubscribeAll
			// 
			this.btnUnsubscribeAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnUnsubscribeAll.Location = new System.Drawing.Point(5, 3);
			this.btnUnsubscribeAll.Name = "btnUnsubscribeAll";
			this.btnUnsubscribeAll.Size = new System.Drawing.Size(110, 23);
			this.btnUnsubscribeAll.TabIndex = 7;
			this.btnUnsubscribeAll.Text = "Unsubscribe All";
			this.btnUnsubscribeAll.UseVisualStyleBackColor = false;
			this.btnUnsubscribeAll.Click += new System.EventHandler(this.btnUnsubscribeAll_Click);
			// 
			// btnSubscriptions_Refresh
			// 
			this.btnSubscriptions_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubscriptions_Refresh.Location = new System.Drawing.Point(510, 3);
			this.btnSubscriptions_Refresh.Name = "btnSubscriptions_Refresh";
			this.btnSubscriptions_Refresh.Size = new System.Drawing.Size(75, 23);
			this.btnSubscriptions_Refresh.TabIndex = 4;
			this.btnSubscriptions_Refresh.Text = "Refresh";
			this.btnSubscriptions_Refresh.UseVisualStyleBackColor = true;
			this.btnSubscriptions_Refresh.Click += new System.EventHandler(this.btnSubscriptions_Refresh_Click);
			// 
			// timerRefreshNotifications
			// 
			this.timerRefreshNotifications.Interval = 10000;
			this.timerRefreshNotifications.Tick += new System.EventHandler(this.timerRefreshNotifications_Tick);
			// 
			// timerRefreshSubscriptions
			// 
			this.timerRefreshSubscriptions.Interval = 60000;
			this.timerRefreshSubscriptions.Tick += new System.EventHandler(this.timerRefreshSubscriptions_Tick);
			// 
			// FormNotifications
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 462);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(620, 500);
			this.Name = "FormNotifications";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Notifications";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotifications_FormClosing);
			this.Load += new System.EventHandler(this.FormNotifications_Load);
			this.Shown += new System.EventHandler(this.FormNotifications_Shown);
			this.VisibleChanged += new System.EventHandler(this.FormNotifications_VisibleChanged);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabNotifications.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvNotifications)).EndInit();
			this.pnlNotifications_Control.ResumeLayout(false);
			this.tabSubscriptions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.olvSubscriptions)).EndInit();
			this.pnlSubscriptions_Control.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabNotifications;
		private System.Windows.Forms.TabPage tabSubscriptions;
		private System.Windows.Forms.ToolStripStatusLabel lblNotificationQty;
		private System.Windows.Forms.ToolStripStatusLabel lblSubscriptions;
		private BrightIdeasSoftware.ObjectListView olvNotifications;
		private BrightIdeasSoftware.OLVColumn olcNotifications_DateTime;
		private BrightIdeasSoftware.OLVColumn olcNotifications_From;
		private BrightIdeasSoftware.OLVColumn olcNotifications_Link;
		private BrightIdeasSoftware.OLVColumn olcNotifications_Text;
		private BrightIdeasSoftware.OLVColumn olcNotifications_MarkRead;
		private BrightIdeasSoftware.OLVColumn olcNotifications_Unsubscribe;
		private System.Windows.Forms.Panel pnlNotifications_Control;
		private BrightIdeasSoftware.ObjectListView olvSubscriptions;
		private BrightIdeasSoftware.OLVColumn olcSubscriptions_ObjLink;
		private System.Windows.Forms.Panel pnlSubscriptions_Control;
		private System.Windows.Forms.Timer timerRefreshNotifications;
		private System.Windows.Forms.Timer timerRefreshSubscriptions;
		private System.Windows.Forms.Button btnSubscriptions_Refresh;
		private System.Windows.Forms.Button btnNotifications_Refresh;
		private BrightIdeasSoftware.OLVColumn olcSubscriptions_Unsubscribe;
		private System.Windows.Forms.ImageList imageList16x16;
		private System.Windows.Forms.Button btnMarkAllRead;
		private System.Windows.Forms.Button btnUnsubscribeAll;
	}
}