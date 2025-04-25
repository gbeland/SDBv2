namespace SDB.Forms.Ticket
{
	partial class FormTicket_AddImage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket_AddImage));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblProcessing = new System.Windows.Forms.Label();
			this.btnCamera = new System.Windows.Forms.Button();
			this.btnFile = new System.Windows.Forms.Button();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.bgwGetImage = new System.ComponentModel.BackgroundWorker();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(149, 305);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(230, 305);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblProcessing
			// 
			this.lblProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProcessing.BackColor = System.Drawing.Color.Transparent;
			this.lblProcessing.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProcessing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblProcessing.Image = ((System.Drawing.Image)(resources.GetObject("lblProcessing.Image")));
			this.lblProcessing.Location = new System.Drawing.Point(88, 106);
			this.lblProcessing.Name = "lblProcessing";
			this.lblProcessing.Size = new System.Drawing.Size(140, 41);
			this.lblProcessing.TabIndex = 41;
			this.lblProcessing.Text = "Getting Camera Image";
			this.lblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblProcessing.Visible = false;
			// 
			// btnCamera
			// 
			this.btnCamera.Location = new System.Drawing.Point(12, 12);
			this.btnCamera.Name = "btnCamera";
			this.btnCamera.Size = new System.Drawing.Size(135, 25);
			this.btnCamera.TabIndex = 38;
			this.btnCamera.Text = "Get Webcam Image";
			this.btnCamera.UseVisualStyleBackColor = true;
			this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
			// 
			// btnFile
			// 
			this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFile.Location = new System.Drawing.Point(169, 12);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(135, 25);
			this.btnFile.TabIndex = 39;
			this.btnFile.Text = "Get Image from File";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// pbImage
			// 
			this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Location = new System.Drawing.Point(12, 43);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(292, 166);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImage.TabIndex = 40;
			this.pbImage.TabStop = false;
			// 
			// bgwGetImage
			// 
			this.bgwGetImage.WorkerSupportsCancellation = true;
			this.bgwGetImage.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetImage_DoWork);
			this.bgwGetImage.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGetImage_Complete);
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(12, 234);
			this.txtDescription.MaxLength = 256;
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(292, 65);
			this.txtDescription.TabIndex = 42;
			// 
			// lblDescription
			// 
			this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(10, 218);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(60, 13);
			this.lblDescription.TabIndex = 43;
			this.lblDescription.Text = "Description";
			// 
			// FormTicket_AddImage
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(317, 340);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblProcessing);
			this.Controls.Add(this.btnCamera);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.pbImage);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormTicket_AddImage";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Image";
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblProcessing;
		private System.Windows.Forms.Button btnCamera;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.PictureBox pbImage;
		private System.ComponentModel.BackgroundWorker bgwGetImage;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
	}
}