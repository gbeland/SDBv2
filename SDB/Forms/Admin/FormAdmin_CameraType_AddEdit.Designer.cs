namespace SDB.Forms.Admin
{
	partial class FormAdmin_CameraType_AddEdit
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
			this.pnlCameraType_Edit = new System.Windows.Forms.Panel();
			this.txtUrlFormat_Video = new System.Windows.Forms.TextBox();
			this.lblUrlFormat_Video = new System.Windows.Forms.Label();
			this.txtUrlFormat_Monitor = new System.Windows.Forms.TextBox();
			this.lblUrlFormat_Monitor = new System.Windows.Forms.Label();
			this.btnInsertField_Channel = new System.Windows.Forms.Button();
			this.txtCameraType_Description = new System.Windows.Forms.TextBox();
			this.lblCameraType_Description = new System.Windows.Forms.Label();
			this.txtUrlFormat_Still = new System.Windows.Forms.TextBox();
			this.lblUrlFormat_Still = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAssembly_Select = new System.Windows.Forms.Button();
			this.btnAssembly_Clear = new System.Windows.Forms.Button();
			this.txtAssembly = new System.Windows.Forms.TextBox();
			this.lblAssembly = new System.Windows.Forms.Label();
			this.pnlCameraType_Edit.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(526, 286);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pnlCameraType_Edit
			// 
			this.pnlCameraType_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCameraType_Edit.Controls.Add(this.txtAssembly);
			this.pnlCameraType_Edit.Controls.Add(this.lblAssembly);
			this.pnlCameraType_Edit.Controls.Add(this.btnAssembly_Clear);
			this.pnlCameraType_Edit.Controls.Add(this.btnAssembly_Select);
			this.pnlCameraType_Edit.Controls.Add(this.txtUrlFormat_Video);
			this.pnlCameraType_Edit.Controls.Add(this.lblUrlFormat_Video);
			this.pnlCameraType_Edit.Controls.Add(this.txtUrlFormat_Monitor);
			this.pnlCameraType_Edit.Controls.Add(this.lblUrlFormat_Monitor);
			this.pnlCameraType_Edit.Controls.Add(this.btnInsertField_Channel);
			this.pnlCameraType_Edit.Controls.Add(this.txtCameraType_Description);
			this.pnlCameraType_Edit.Controls.Add(this.lblCameraType_Description);
			this.pnlCameraType_Edit.Controls.Add(this.txtUrlFormat_Still);
			this.pnlCameraType_Edit.Controls.Add(this.lblUrlFormat_Still);
			this.pnlCameraType_Edit.Location = new System.Drawing.Point(12, 12);
			this.pnlCameraType_Edit.Name = "pnlCameraType_Edit";
			this.pnlCameraType_Edit.Size = new System.Drawing.Size(670, 268);
			this.pnlCameraType_Edit.TabIndex = 0;
			// 
			// txtUrlFormat_Video
			// 
			this.txtUrlFormat_Video.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUrlFormat_Video.Location = new System.Drawing.Point(3, 187);
			this.txtUrlFormat_Video.MaxLength = 255;
			this.txtUrlFormat_Video.Name = "txtUrlFormat_Video";
			this.txtUrlFormat_Video.Size = new System.Drawing.Size(664, 20);
			this.txtUrlFormat_Video.TabIndex = 11;
			this.txtUrlFormat_Video.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblUrlFormat_Video
			// 
			this.lblUrlFormat_Video.AutoSize = true;
			this.lblUrlFormat_Video.Location = new System.Drawing.Point(3, 171);
			this.lblUrlFormat_Video.Name = "lblUrlFormat_Video";
			this.lblUrlFormat_Video.Size = new System.Drawing.Size(130, 13);
			this.lblUrlFormat_Video.TabIndex = 10;
			this.lblUrlFormat_Video.Text = "Video Stream URL Format";
			// 
			// txtUrlFormat_Monitor
			// 
			this.txtUrlFormat_Monitor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUrlFormat_Monitor.Location = new System.Drawing.Point(3, 144);
			this.txtUrlFormat_Monitor.MaxLength = 255;
			this.txtUrlFormat_Monitor.Name = "txtUrlFormat_Monitor";
			this.txtUrlFormat_Monitor.Size = new System.Drawing.Size(664, 20);
			this.txtUrlFormat_Monitor.TabIndex = 9;
			this.txtUrlFormat_Monitor.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblUrlFormat_Monitor
			// 
			this.lblUrlFormat_Monitor.AutoSize = true;
			this.lblUrlFormat_Monitor.Location = new System.Drawing.Point(3, 128);
			this.lblUrlFormat_Monitor.Name = "lblUrlFormat_Monitor";
			this.lblUrlFormat_Monitor.Size = new System.Drawing.Size(148, 13);
			this.lblUrlFormat_Monitor.TabIndex = 8;
			this.lblUrlFormat_Monitor.Text = "Monitoring Image URL Format";
			// 
			// btnInsertField_Channel
			// 
			this.btnInsertField_Channel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnInsertField_Channel.Location = new System.Drawing.Point(270, 220);
			this.btnInsertField_Channel.Name = "btnInsertField_Channel";
			this.btnInsertField_Channel.Size = new System.Drawing.Size(130, 45);
			this.btnInsertField_Channel.TabIndex = 12;
			this.btnInsertField_Channel.Text = "Insert &Channel\r\nPlaceholder";
			this.btnInsertField_Channel.UseVisualStyleBackColor = true;
			this.btnInsertField_Channel.Click += new System.EventHandler(this.btnInsertField_Channel_Click);
			// 
			// txtCameraType_Description
			// 
			this.txtCameraType_Description.Location = new System.Drawing.Point(142, 6);
			this.txtCameraType_Description.MaxLength = 32;
			this.txtCameraType_Description.Name = "txtCameraType_Description";
			this.txtCameraType_Description.Size = new System.Drawing.Size(179, 20);
			this.txtCameraType_Description.TabIndex = 1;
			this.txtCameraType_Description.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblCameraType_Description
			// 
			this.lblCameraType_Description.AutoSize = true;
			this.lblCameraType_Description.Location = new System.Drawing.Point(3, 9);
			this.lblCameraType_Description.Name = "lblCameraType_Description";
			this.lblCameraType_Description.Size = new System.Drawing.Size(133, 13);
			this.lblCameraType_Description.TabIndex = 0;
			this.lblCameraType_Description.Text = "Camera Model/Description";
			// 
			// txtUrlFormat_Still
			// 
			this.txtUrlFormat_Still.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUrlFormat_Still.Location = new System.Drawing.Point(3, 101);
			this.txtUrlFormat_Still.MaxLength = 255;
			this.txtUrlFormat_Still.Name = "txtUrlFormat_Still";
			this.txtUrlFormat_Still.Size = new System.Drawing.Size(664, 20);
			this.txtUrlFormat_Still.TabIndex = 7;
			this.txtUrlFormat_Still.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblUrlFormat_Still
			// 
			this.lblUrlFormat_Still.AutoSize = true;
			this.lblUrlFormat_Still.Location = new System.Drawing.Point(3, 85);
			this.lblUrlFormat_Still.Name = "lblUrlFormat_Still";
			this.lblUrlFormat_Still.Size = new System.Drawing.Size(115, 13);
			this.lblUrlFormat_Still.TabIndex = 6;
			this.lblUrlFormat_Still.Text = "Still Image URL Format";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(607, 286);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnAssembly_Select
			// 
			this.btnAssembly_Select.Location = new System.Drawing.Point(469, 30);
			this.btnAssembly_Select.Name = "btnAssembly_Select";
			this.btnAssembly_Select.Size = new System.Drawing.Size(72, 23);
			this.btnAssembly_Select.TabIndex = 4;
			this.btnAssembly_Select.Text = "Select...";
			this.btnAssembly_Select.UseVisualStyleBackColor = true;
			this.btnAssembly_Select.Click += new System.EventHandler(this.btnAssembly_Select_Click);
			// 
			// btnAssembly_Clear
			// 
			this.btnAssembly_Clear.Location = new System.Drawing.Point(547, 30);
			this.btnAssembly_Clear.Name = "btnAssembly_Clear";
			this.btnAssembly_Clear.Size = new System.Drawing.Size(72, 23);
			this.btnAssembly_Clear.TabIndex = 5;
			this.btnAssembly_Clear.Text = "Clear";
			this.btnAssembly_Clear.UseVisualStyleBackColor = true;
			this.btnAssembly_Clear.Click += new System.EventHandler(this.btnAssembly_Clear_Click);
			// 
			// txtAssembly
			// 
			this.txtAssembly.Location = new System.Drawing.Point(142, 32);
			this.txtAssembly.MaxLength = 32;
			this.txtAssembly.Name = "txtAssembly";
			this.txtAssembly.ReadOnly = true;
			this.txtAssembly.Size = new System.Drawing.Size(321, 20);
			this.txtAssembly.TabIndex = 3;
			// 
			// lblAssembly
			// 
			this.lblAssembly.AutoSize = true;
			this.lblAssembly.Location = new System.Drawing.Point(30, 35);
			this.lblAssembly.Name = "lblAssembly";
			this.lblAssembly.Size = new System.Drawing.Size(106, 13);
			this.lblAssembly.TabIndex = 2;
			this.lblAssembly.Text = "Associated Assembly";
			// 
			// FormCameraType_AddEdit
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(694, 321);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.pnlCameraType_Edit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCameraType_AddEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Camera Type";
			this.pnlCameraType_Edit.ResumeLayout(false);
			this.pnlCameraType_Edit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel pnlCameraType_Edit;
		private System.Windows.Forms.TextBox txtCameraType_Description;
		private System.Windows.Forms.Label lblCameraType_Description;
		private System.Windows.Forms.TextBox txtUrlFormat_Still;
		private System.Windows.Forms.Label lblUrlFormat_Still;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnInsertField_Channel;
		private System.Windows.Forms.TextBox txtUrlFormat_Video;
		private System.Windows.Forms.Label lblUrlFormat_Video;
		private System.Windows.Forms.TextBox txtUrlFormat_Monitor;
		private System.Windows.Forms.Label lblUrlFormat_Monitor;
		private System.Windows.Forms.TextBox txtAssembly;
		private System.Windows.Forms.Label lblAssembly;
		private System.Windows.Forms.Button btnAssembly_Clear;
		private System.Windows.Forms.Button btnAssembly_Select;
	}
}