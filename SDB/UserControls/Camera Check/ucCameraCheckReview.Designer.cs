namespace SDB.UserControls.Camera_Check
{
	partial class CameraCheckReview
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
            this.components = new System.ComponentModel.Container();
            this.pbCheckedImage = new System.Windows.Forms.PictureBox();
            this.lblAsset = new System.Windows.Forms.Label();
            this.btnOpenNewTicket = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTicketing = new System.Windows.Forms.Panel();
            this.olvTickets = new BrightIdeasSoftware.ObjectListView();
            this.olcTicketID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcSymptoms = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDuration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnAssignTicket = new System.Windows.Forms.Button();
            this.lblTicketQty = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubmitInfo = new System.Windows.Forms.Label();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedImage)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlTicketing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCheckedImage
            // 
            this.pbCheckedImage.BackColor = System.Drawing.Color.Black;
            this.pbCheckedImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCheckedImage.Location = new System.Drawing.Point(0, 0);
            this.pbCheckedImage.Name = "pbCheckedImage";
            this.pbCheckedImage.Size = new System.Drawing.Size(320, 240);
            this.pbCheckedImage.TabIndex = 0;
            this.pbCheckedImage.TabStop = false;
            // 
            // lblAsset
            // 
            this.lblAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAsset.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsset.ForeColor = System.Drawing.Color.White;
            this.lblAsset.Location = new System.Drawing.Point(0, 0);
            this.lblAsset.Name = "lblAsset";
            this.lblAsset.Size = new System.Drawing.Size(320, 40);
            this.lblAsset.TabIndex = 0;
            this.lblAsset.Text = "ASSET";
            this.lblAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenNewTicket
            // 
            this.btnOpenNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenNewTicket.Location = new System.Drawing.Point(216, 4);
            this.btnOpenNewTicket.Name = "btnOpenNewTicket";
            this.btnOpenNewTicket.Size = new System.Drawing.Size(74, 23);
            this.btnOpenNewTicket.TabIndex = 1;
            this.btnOpenNewTicket.Text = "New Ticket";
            this.toolTip1.SetToolTip(this.btnOpenNewTicket, "Open a new ticket in response to camera check.");
            this.btnOpenNewTicket.UseVisualStyleBackColor = true;
            this.btnOpenNewTicket.Click += new System.EventHandler(this.btnOpenNewTicket_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlTicketing);
            this.pnlBottom.Controls.Add(this.pbCheckedImage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 40);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(670, 240);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlTicketing
            // 
            this.pnlTicketing.Controls.Add(this.olvTickets);
            this.pnlTicketing.Controls.Add(this.txtSymptom);
            this.pnlTicketing.Controls.Add(this.pnlControl);
            this.pnlTicketing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTicketing.Location = new System.Drawing.Point(320, 0);
            this.pnlTicketing.Name = "pnlTicketing";
            this.pnlTicketing.Size = new System.Drawing.Size(350, 240);
            this.pnlTicketing.TabIndex = 3;
            // 
            // olvTickets
            // 
            this.olvTickets.AllColumns.Add(this.olcTicketID);
            this.olvTickets.AllColumns.Add(this.olcSymptoms);
            this.olvTickets.AllColumns.Add(this.olcDuration);
            this.olvTickets.CellEditUseWholeCell = false;
            this.olvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcTicketID,
            this.olcSymptoms,
            this.olcDuration});
            this.olvTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTickets.EmptyListMsg = "No open tickets.";
            this.olvTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTickets.FullRowSelect = true;
            this.olvTickets.GridLines = true;
            this.olvTickets.HasCollapsibleGroups = false;
            this.olvTickets.HideSelection = false;
            this.olvTickets.Location = new System.Drawing.Point(0, 16);
            this.olvTickets.MultiSelect = false;
            this.olvTickets.Name = "olvTickets";
            this.olvTickets.SelectAllOnControlA = false;
            this.olvTickets.SelectColumnsMenuStaysOpen = false;
            this.olvTickets.SelectColumnsOnRightClick = false;
            this.olvTickets.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvTickets.ShowFilterMenuOnRightClick = false;
            this.olvTickets.ShowGroups = false;
            this.olvTickets.Size = new System.Drawing.Size(350, 194);
            this.olvTickets.TabIndex = 0;
            this.olvTickets.UseCompatibleStateImageBehavior = false;
            this.olvTickets.View = System.Windows.Forms.View.Details;
            this.olvTickets.SelectedIndexChanged += new System.EventHandler(this.olvTickets_SelectedIndexChanged);
            this.olvTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTickets_MouseDoubleClick);
            // 
            // olcTicketID
            // 
            this.olcTicketID.AspectName = "TicketID";
            this.olcTicketID.Text = "Ticket";
            this.olcTicketID.Width = 70;
            // 
            // olcSymptoms
            // 
            this.olcSymptoms.AspectName = "CombinedSymptoms";
            this.olcSymptoms.Text = "Symptoms";
            this.olcSymptoms.Width = 200;
            // 
            // olcDuration
            // 
            this.olcDuration.AspectName = "DurationAsRoundedString";
            this.olcDuration.Text = "Duration";
            this.olcDuration.Width = 70;
            // 
            // txtSymptom
            // 
            this.txtSymptom.BackColor = System.Drawing.Color.Silver;
            this.txtSymptom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymptom.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSymptom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymptom.ForeColor = System.Drawing.Color.Red;
            this.txtSymptom.Location = new System.Drawing.Point(0, 0);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ReadOnly = true;
            this.txtSymptom.Size = new System.Drawing.Size(350, 16);
            this.txtSymptom.TabIndex = 2;
            this.txtSymptom.TabStop = false;
            this.txtSymptom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSymptom.Visible = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.DimGray;
            this.pnlControl.Controls.Add(this.btnDashboard);
            this.pnlControl.Controls.Add(this.btnRevert);
            this.pnlControl.Controls.Add(this.btnAssignTicket);
            this.pnlControl.Controls.Add(this.btnOpenNewTicket);
            this.pnlControl.Controls.Add(this.lblTicketQty);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 210);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(350, 30);
            this.pnlControl.TabIndex = 1;
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.BackColor = System.Drawing.Color.LightGreen;
            this.btnRevert.Location = new System.Drawing.Point(136, 3);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(74, 23);
            this.btnRevert.TabIndex = 5;
            this.btnRevert.Text = "Pass";
            this.toolTip1.SetToolTip(this.btnRevert, "Reverts failed camera check status to a pass.");
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignTicket.Enabled = false;
            this.btnAssignTicket.Location = new System.Drawing.Point(296, 4);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(51, 23);
            this.btnAssignTicket.TabIndex = 0;
            this.btnAssignTicket.Text = "Assign";
            this.toolTip1.SetToolTip(this.btnAssignTicket, "Assign selected ticket to camera check.");
            this.btnAssignTicket.UseVisualStyleBackColor = true;
            this.btnAssignTicket.Click += new System.EventHandler(this.btnAssignTicket_Click);
            // 
            // lblTicketQty
            // 
            this.lblTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTicketQty.AutoSize = true;
            this.lblTicketQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTicketQty.Location = new System.Drawing.Point(3, 9);
            this.lblTicketQty.Name = "lblTicketQty";
            this.lblTicketQty.Size = new System.Drawing.Size(83, 13);
            this.lblTicketQty.TabIndex = 4;
            this.lblTicketQty.Text = "Open Tickets: 0";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTop.Controls.Add(this.lblSubmitInfo);
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(670, 40);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSubmitInfo
            // 
            this.lblSubmitInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubmitInfo.ForeColor = System.Drawing.Color.White;
            this.lblSubmitInfo.Location = new System.Drawing.Point(320, 0);
            this.lblSubmitInfo.Name = "lblSubmitInfo";
            this.lblSubmitInfo.Size = new System.Drawing.Size(350, 40);
            this.lblSubmitInfo.TabIndex = 1;
            this.lblSubmitInfo.Text = "Submitted 2016-03-04 11:56:14\r\nby JYelton";
            this.lblSubmitInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.lblAsset);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(320, 40);
            this.pnlTopLeft.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImage = global::SDB.Properties.Resources.program_icon_16x16;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(106, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(24, 22);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // CameraCheckReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "CameraCheckReview";
            this.Size = new System.Drawing.Size(670, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedImage)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlTicketing.ResumeLayout(false);
            this.pnlTicketing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTickets)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbCheckedImage;
		private System.Windows.Forms.Label lblAsset;
		private System.Windows.Forms.Button btnOpenNewTicket;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlTicketing;
		private System.Windows.Forms.Label lblSubmitInfo;
		private BrightIdeasSoftware.ObjectListView olvTickets;
		private BrightIdeasSoftware.OLVColumn olcTicketID;
		private BrightIdeasSoftware.OLVColumn olcSymptoms;
		private BrightIdeasSoftware.OLVColumn olcDuration;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblTicketQty;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnAssignTicket;
		private System.Windows.Forms.Button btnRevert;
		private System.Windows.Forms.Panel pnlTopLeft;
		private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.Button btnDashboard;
    }
}
