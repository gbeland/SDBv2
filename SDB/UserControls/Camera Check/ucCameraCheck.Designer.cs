namespace SDB.UserControls.Camera_Check
{
	partial class CameraCheckControl
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
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.lblRequested = new System.Windows.Forms.Label();
            this.lblTicketInfo = new System.Windows.Forms.Label();
            this.lblSymptom = new System.Windows.Forms.Label();
            this.pbCameraImage = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblAssetInfo = new System.Windows.Forms.Label();
            this.lblImageInfo = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnServiceReminder = new System.Windows.Forms.Button();
            this.btnCycleImages = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPreviousImage = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.pnlStatusBorder = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerImageCycle = new System.Windows.Forms.Timer(this.components);
            this.timerEvalDelay = new System.Windows.Forms.Timer(this.components);
            this.cmSymptoms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraImage)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlStatusBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            this.pnlLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLayout.Controls.Add(this.lblRequested);
            this.pnlLayout.Controls.Add(this.lblTicketInfo);
            this.pnlLayout.Controls.Add(this.lblSymptom);
            this.pnlLayout.Controls.Add(this.pbCameraImage);
            this.pnlLayout.Controls.Add(this.pnlInfo);
            this.pnlLayout.Controls.Add(this.pnlControl);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(10, 10);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(352, 300);
            this.pnlLayout.TabIndex = 1;
            // 
            // lblRequested
            // 
            this.lblRequested.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequested.BackColor = System.Drawing.Color.Aqua;
            this.lblRequested.Location = new System.Drawing.Point(229, 0);
            this.lblRequested.Name = "lblRequested";
            this.lblRequested.Size = new System.Drawing.Size(120, 13);
            this.lblRequested.TabIndex = 1;
            this.lblRequested.Text = "Requested by";
            this.lblRequested.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblRequested.Visible = false;
            // 
            // lblTicketInfo
            // 
            this.lblTicketInfo.AutoSize = true;
            this.lblTicketInfo.BackColor = System.Drawing.Color.LightSalmon;
            this.lblTicketInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketInfo.Location = new System.Drawing.Point(0, 0);
            this.lblTicketInfo.Name = "lblTicketInfo";
            this.lblTicketInfo.Size = new System.Drawing.Size(73, 13);
            this.lblTicketInfo.TabIndex = 2;
            this.lblTicketInfo.Text = "Ticket Info";
            this.lblTicketInfo.Visible = false;
            // 
            // lblSymptom
            // 
            this.lblSymptom.BackColor = System.Drawing.Color.Transparent;
            this.lblSymptom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSymptom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptom.ForeColor = System.Drawing.Color.Red;
            this.lblSymptom.Location = new System.Drawing.Point(0, 227);
            this.lblSymptom.Name = "lblSymptom";
            this.lblSymptom.Size = new System.Drawing.Size(352, 13);
            this.lblSymptom.TabIndex = 3;
            this.lblSymptom.Text = "Symptom";
            this.lblSymptom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSymptom.Visible = false;
            // 
            // pbCameraImage
            // 
            this.pbCameraImage.BackColor = System.Drawing.Color.Black;
            this.pbCameraImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCameraImage.Location = new System.Drawing.Point(0, 0);
            this.pbCameraImage.Name = "pbCameraImage";
            this.pbCameraImage.Size = new System.Drawing.Size(352, 240);
            this.pbCameraImage.TabIndex = 0;
            this.pbCameraImage.TabStop = false;
            this.pbCameraImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbCameraImage_MouseClick);
            this.pbCameraImage.MouseHover += new System.EventHandler(this.pnlStatusBorder_MouseHover);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlInfo.Controls.Add(this.lblAssetInfo);
            this.pnlInfo.Controls.Add(this.lblImageInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 240);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(352, 30);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblAssetInfo
            // 
            this.lblAssetInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAssetInfo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetInfo.ForeColor = System.Drawing.Color.White;
            this.lblAssetInfo.Location = new System.Drawing.Point(0, 0);
            this.lblAssetInfo.Name = "lblAssetInfo";
            this.lblAssetInfo.Size = new System.Drawing.Size(292, 30);
            this.lblAssetInfo.TabIndex = 0;
            this.lblAssetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.AutoSize = true;
            this.lblImageInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblImageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageInfo.ForeColor = System.Drawing.Color.White;
            this.lblImageInfo.Location = new System.Drawing.Point(292, 0);
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(60, 13);
            this.lblImageInfo.TabIndex = 1;
            this.lblImageInfo.Text = "No images.";
            this.lblImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnServiceReminder);
            this.pnlControl.Controls.Add(this.btnCycleImages);
            this.pnlControl.Controls.Add(this.btnNextImage);
            this.pnlControl.Controls.Add(this.btnPreviousImage);
            this.pnlControl.Controls.Add(this.btnFail);
            this.pnlControl.Controls.Add(this.btnPass);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 270);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(352, 30);
            this.pnlControl.TabIndex = 1;
            // 
            // btnServiceReminder
            // 
            this.btnServiceReminder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnServiceReminder.BackColor = System.Drawing.Color.Silver;
            this.btnServiceReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceReminder.Location = new System.Drawing.Point(179, 4);
            this.btnServiceReminder.Name = "btnServiceReminder";
            this.btnServiceReminder.Size = new System.Drawing.Size(32, 23);
            this.btnServiceReminder.TabIndex = 5;
            this.btnServiceReminder.Text = "SR";
            this.toolTip1.SetToolTip(this.btnServiceReminder, "Set service reminder.\r\nOver image: Middle-click");
            this.btnServiceReminder.UseVisualStyleBackColor = false;
            this.btnServiceReminder.Click += new System.EventHandler(this.btnServiceReminder_Click);
            // 
            // btnCycleImages
            // 
            this.btnCycleImages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCycleImages.BackColor = System.Drawing.Color.Silver;
            this.btnCycleImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCycleImages.Location = new System.Drawing.Point(141, 4);
            this.btnCycleImages.Name = "btnCycleImages";
            this.btnCycleImages.Size = new System.Drawing.Size(32, 23);
            this.btnCycleImages.TabIndex = 4;
            this.btnCycleImages.Text = "@";
            this.toolTip1.SetToolTip(this.btnCycleImages, "Auto cycle images\r\nOver image: Shift+click\r\nButton or image: Control+click for Da" +
        "shboard");
            this.btnCycleImages.UseVisualStyleBackColor = false;
            this.btnCycleImages.Click += new System.EventHandler(this.btnCycleImages_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextImage.BackColor = System.Drawing.Color.Silver;
            this.btnNextImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextImage.Location = new System.Drawing.Point(233, 4);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(55, 23);
            this.btnNextImage.TabIndex = 3;
            this.btnNextImage.Text = ">";
            this.toolTip1.SetToolTip(this.btnNextImage, "Next image\r\nOver image: Mousewheel down\r\nButton: Shift+click for last image");
            this.btnNextImage.UseVisualStyleBackColor = false;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.BackColor = System.Drawing.Color.Silver;
            this.btnPreviousImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousImage.Location = new System.Drawing.Point(64, 4);
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(55, 23);
            this.btnPreviousImage.TabIndex = 2;
            this.btnPreviousImage.Text = "<";
            this.toolTip1.SetToolTip(this.btnPreviousImage, "Previous image\r\nOver image: Mousewheel up\r\nButton: Shift+click for first image");
            this.btnPreviousImage.UseVisualStyleBackColor = false;
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // btnFail
            // 
            this.btnFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFail.Location = new System.Drawing.Point(3, 4);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(55, 23);
            this.btnFail.TabIndex = 1;
            this.btnFail.Text = "Fail";
            this.toolTip1.SetToolTip(this.btnFail, "Fail this camera check.\r\nOver image: Right-click");
            this.btnFail.UseVisualStyleBackColor = false;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnPass
            // 
            this.btnPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Location = new System.Drawing.Point(294, 4);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(55, 23);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "Pass";
            this.toolTip1.SetToolTip(this.btnPass, "Pass this camera check.\r\nOver image: Left-click");
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // pnlStatusBorder
            // 
            this.pnlStatusBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlStatusBorder.Controls.Add(this.pnlLayout);
            this.pnlStatusBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatusBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusBorder.Name = "pnlStatusBorder";
            this.pnlStatusBorder.Padding = new System.Windows.Forms.Padding(10);
            this.pnlStatusBorder.Size = new System.Drawing.Size(372, 320);
            this.pnlStatusBorder.TabIndex = 0;
            // 
            // timerImageCycle
            // 
            this.timerImageCycle.Enabled = true;
            this.timerImageCycle.Interval = 1000;
            this.timerImageCycle.Tick += new System.EventHandler(this.timerImageCycle_Tick);
            // 
            // timerEvalDelay
            // 
            this.timerEvalDelay.Tick += new System.EventHandler(this.timerEvalDelay_Tick);
            // 
            // cmSymptoms
            // 
            this.cmSymptoms.Name = "cmSymptoms";
            this.cmSymptoms.ShowImageMargin = false;
            this.cmSymptoms.Size = new System.Drawing.Size(36, 4);
            // 
            // CameraCheckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlStatusBorder);
            this.Name = "CameraCheckControl";
            this.Size = new System.Drawing.Size(372, 320);
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraImage)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlStatusBorder.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbCameraImage;
		private System.Windows.Forms.Panel pnlLayout;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnFail;
		private System.Windows.Forms.Button btnPass;
		private System.Windows.Forms.Panel pnlStatusBorder;
		private System.Windows.Forms.Button btnNextImage;
		private System.Windows.Forms.Button btnPreviousImage;
		private System.Windows.Forms.Button btnCycleImages;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Label lblAssetInfo;
		private System.Windows.Forms.Label lblImageInfo;
		private System.Windows.Forms.Timer timerImageCycle;
		private System.Windows.Forms.Label lblRequested;
		private System.Windows.Forms.Label lblTicketInfo;
		private System.Windows.Forms.Button btnServiceReminder;
		private System.Windows.Forms.Timer timerEvalDelay;
		private System.Windows.Forms.ContextMenuStrip cmSymptoms;
		private System.Windows.Forms.Label lblSymptom;
	}
}
