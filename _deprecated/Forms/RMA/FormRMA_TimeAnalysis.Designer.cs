namespace SDB.Forms.RMA
{
	partial class FormRMA_TimeAnalysis
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
			this.txtCreated = new System.Windows.Forms.TextBox();
			this.lblV1 = new System.Windows.Forms.Label();
			this.lblCreated = new System.Windows.Forms.Label();
			this.pnlRMATime = new System.Windows.Forms.Panel();
			this.lblV3 = new System.Windows.Forms.Label();
			this.lblV2 = new System.Windows.Forms.Label();
			this.lblTotalTime = new System.Windows.Forms.Label();
			this.txtTotalTime = new System.Windows.Forms.TextBox();
			this.lblTimeToRepair = new System.Windows.Forms.Label();
			this.txtTimeToRepair = new System.Windows.Forms.TextBox();
			this.lblTimeToReceive = new System.Windows.Forms.Label();
			this.txtTimeToReceive = new System.Windows.Forms.TextBox();
			this.lblFinalized = new System.Windows.Forms.Label();
			this.txtFinalized = new System.Windows.Forms.TextBox();
			this.lblCompleted = new System.Windows.Forms.Label();
			this.txtCompleted = new System.Windows.Forms.TextBox();
			this.lblReceived = new System.Windows.Forms.Label();
			this.txtReceived = new System.Windows.Forms.TextBox();
			this.lblH1 = new System.Windows.Forms.Label();
			this.lblH2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.timerRefresh = new System.Windows.Forms.Timer(this.components);
			this.pnlRMATime.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCreated
			// 
			this.txtCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCreated.Location = new System.Drawing.Point(3, 16);
			this.txtCreated.Name = "txtCreated";
			this.txtCreated.ReadOnly = true;
			this.txtCreated.Size = new System.Drawing.Size(100, 20);
			this.txtCreated.TabIndex = 1;
			this.txtCreated.TabStop = false;
			this.txtCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblV1
			// 
			this.lblV1.BackColor = System.Drawing.Color.Gray;
			this.lblV1.Location = new System.Drawing.Point(52, 36);
			this.lblV1.Name = "lblV1";
			this.lblV1.Size = new System.Drawing.Size(2, 90);
			this.lblV1.TabIndex = 1;
			// 
			// lblCreated
			// 
			this.lblCreated.Location = new System.Drawing.Point(3, 0);
			this.lblCreated.Name = "lblCreated";
			this.lblCreated.Size = new System.Drawing.Size(100, 13);
			this.lblCreated.TabIndex = 0;
			this.lblCreated.Text = "Created";
			this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlRMATime
			// 
			this.pnlRMATime.Controls.Add(this.lblV3);
			this.pnlRMATime.Controls.Add(this.lblV2);
			this.pnlRMATime.Controls.Add(this.lblTotalTime);
			this.pnlRMATime.Controls.Add(this.txtTotalTime);
			this.pnlRMATime.Controls.Add(this.lblTimeToRepair);
			this.pnlRMATime.Controls.Add(this.txtTimeToRepair);
			this.pnlRMATime.Controls.Add(this.lblTimeToReceive);
			this.pnlRMATime.Controls.Add(this.txtTimeToReceive);
			this.pnlRMATime.Controls.Add(this.lblFinalized);
			this.pnlRMATime.Controls.Add(this.txtFinalized);
			this.pnlRMATime.Controls.Add(this.lblCompleted);
			this.pnlRMATime.Controls.Add(this.txtCompleted);
			this.pnlRMATime.Controls.Add(this.lblReceived);
			this.pnlRMATime.Controls.Add(this.txtReceived);
			this.pnlRMATime.Controls.Add(this.lblCreated);
			this.pnlRMATime.Controls.Add(this.txtCreated);
			this.pnlRMATime.Controls.Add(this.lblV1);
			this.pnlRMATime.Controls.Add(this.lblH1);
			this.pnlRMATime.Controls.Add(this.lblH2);
			this.pnlRMATime.Location = new System.Drawing.Point(12, 12);
			this.pnlRMATime.Name = "pnlRMATime";
			this.pnlRMATime.Size = new System.Drawing.Size(528, 139);
			this.pnlRMATime.TabIndex = 0;
			// 
			// lblV3
			// 
			this.lblV3.BackColor = System.Drawing.Color.Gray;
			this.lblV3.Location = new System.Drawing.Point(334, 36);
			this.lblV3.Name = "lblV3";
			this.lblV3.Size = new System.Drawing.Size(2, 90);
			this.lblV3.TabIndex = 17;
			// 
			// lblV2
			// 
			this.lblV2.BackColor = System.Drawing.Color.Gray;
			this.lblV2.Location = new System.Drawing.Point(192, 36);
			this.lblV2.Name = "lblV2";
			this.lblV2.Size = new System.Drawing.Size(2, 40);
			this.lblV2.TabIndex = 16;
			// 
			// lblTotalTime
			// 
			this.lblTotalTime.Location = new System.Drawing.Point(143, 100);
			this.lblTotalTime.Name = "lblTotalTime";
			this.lblTotalTime.Size = new System.Drawing.Size(100, 13);
			this.lblTotalTime.TabIndex = 12;
			this.lblTotalTime.Text = "Total Time";
			this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTotalTime
			// 
			this.txtTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTotalTime.Location = new System.Drawing.Point(143, 116);
			this.txtTotalTime.Name = "txtTotalTime";
			this.txtTotalTime.ReadOnly = true;
			this.txtTotalTime.Size = new System.Drawing.Size(100, 20);
			this.txtTotalTime.TabIndex = 13;
			this.txtTotalTime.TabStop = false;
			this.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTimeToRepair
			// 
			this.lblTimeToRepair.Location = new System.Drawing.Point(215, 50);
			this.lblTimeToRepair.Name = "lblTimeToRepair";
			this.lblTimeToRepair.Size = new System.Drawing.Size(100, 13);
			this.lblTimeToRepair.TabIndex = 10;
			this.lblTimeToRepair.Text = "Time to Repair";
			this.lblTimeToRepair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTimeToRepair
			// 
			this.txtTimeToRepair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeToRepair.Location = new System.Drawing.Point(215, 66);
			this.txtTimeToRepair.Name = "txtTimeToRepair";
			this.txtTimeToRepair.ReadOnly = true;
			this.txtTimeToRepair.Size = new System.Drawing.Size(100, 20);
			this.txtTimeToRepair.TabIndex = 11;
			this.txtTimeToRepair.TabStop = false;
			this.txtTimeToRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTimeToReceive
			// 
			this.lblTimeToReceive.Location = new System.Drawing.Point(73, 50);
			this.lblTimeToReceive.Name = "lblTimeToReceive";
			this.lblTimeToReceive.Size = new System.Drawing.Size(100, 13);
			this.lblTimeToReceive.TabIndex = 8;
			this.lblTimeToReceive.Text = "Time to Receive";
			this.lblTimeToReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTimeToReceive
			// 
			this.txtTimeToReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeToReceive.Location = new System.Drawing.Point(73, 66);
			this.txtTimeToReceive.Name = "txtTimeToReceive";
			this.txtTimeToReceive.ReadOnly = true;
			this.txtTimeToReceive.Size = new System.Drawing.Size(100, 20);
			this.txtTimeToReceive.TabIndex = 9;
			this.txtTimeToReceive.TabStop = false;
			this.txtTimeToReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblFinalized
			// 
			this.lblFinalized.Location = new System.Drawing.Point(423, 0);
			this.lblFinalized.Name = "lblFinalized";
			this.lblFinalized.Size = new System.Drawing.Size(100, 13);
			this.lblFinalized.TabIndex = 6;
			this.lblFinalized.Text = "Finalized";
			this.lblFinalized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtFinalized
			// 
			this.txtFinalized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtFinalized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFinalized.Location = new System.Drawing.Point(423, 16);
			this.txtFinalized.Name = "txtFinalized";
			this.txtFinalized.ReadOnly = true;
			this.txtFinalized.Size = new System.Drawing.Size(100, 20);
			this.txtFinalized.TabIndex = 7;
			this.txtFinalized.TabStop = false;
			this.txtFinalized.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblCompleted
			// 
			this.lblCompleted.Location = new System.Drawing.Point(283, 0);
			this.lblCompleted.Name = "lblCompleted";
			this.lblCompleted.Size = new System.Drawing.Size(100, 13);
			this.lblCompleted.TabIndex = 4;
			this.lblCompleted.Text = "Completed";
			this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCompleted
			// 
			this.txtCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.txtCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCompleted.Location = new System.Drawing.Point(283, 16);
			this.txtCompleted.Name = "txtCompleted";
			this.txtCompleted.ReadOnly = true;
			this.txtCompleted.Size = new System.Drawing.Size(100, 20);
			this.txtCompleted.TabIndex = 5;
			this.txtCompleted.TabStop = false;
			this.txtCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblReceived
			// 
			this.lblReceived.Location = new System.Drawing.Point(143, 0);
			this.lblReceived.Name = "lblReceived";
			this.lblReceived.Size = new System.Drawing.Size(100, 13);
			this.lblReceived.TabIndex = 2;
			this.lblReceived.Text = "Received";
			this.lblReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtReceived
			// 
			this.txtReceived.BackColor = System.Drawing.Color.Gray;
			this.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtReceived.Location = new System.Drawing.Point(143, 16);
			this.txtReceived.Name = "txtReceived";
			this.txtReceived.ReadOnly = true;
			this.txtReceived.Size = new System.Drawing.Size(100, 20);
			this.txtReceived.TabIndex = 3;
			this.txtReceived.TabStop = false;
			this.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblH1
			// 
			this.lblH1.BackColor = System.Drawing.Color.Gray;
			this.lblH1.Location = new System.Drawing.Point(52, 76);
			this.lblH1.Name = "lblH1";
			this.lblH1.Size = new System.Drawing.Size(284, 2);
			this.lblH1.TabIndex = 15;
			// 
			// lblH2
			// 
			this.lblH2.BackColor = System.Drawing.Color.Gray;
			this.lblH2.Location = new System.Drawing.Point(52, 126);
			this.lblH2.Name = "lblH2";
			this.lblH2.Size = new System.Drawing.Size(284, 2);
			this.lblH2.TabIndex = 18;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(467, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// timerRefresh
			// 
			this.timerRefresh.Interval = 1000;
			this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
			// 
			// FormRMA_TimeAnalysis
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(554, 195);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlRMATime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_TimeAnalysis";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA: Time Analysis";
			this.Load += new System.EventHandler(this.FormRMA_TimeAnalysis_Load);
			this.pnlRMATime.ResumeLayout(false);
			this.pnlRMATime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtCreated;
		private System.Windows.Forms.Label lblV1;
		private System.Windows.Forms.Label lblCreated;
		private System.Windows.Forms.Panel pnlRMATime;
		private System.Windows.Forms.Label lblFinalized;
		private System.Windows.Forms.TextBox txtFinalized;
		private System.Windows.Forms.Label lblCompleted;
		private System.Windows.Forms.TextBox txtCompleted;
		private System.Windows.Forms.Label lblReceived;
		private System.Windows.Forms.TextBox txtReceived;
		private System.Windows.Forms.Label lblV3;
		private System.Windows.Forms.Label lblV2;
		private System.Windows.Forms.Label lblTotalTime;
		private System.Windows.Forms.TextBox txtTotalTime;
		private System.Windows.Forms.Label lblTimeToRepair;
		private System.Windows.Forms.TextBox txtTimeToRepair;
		private System.Windows.Forms.Label lblTimeToReceive;
		private System.Windows.Forms.TextBox txtTimeToReceive;
		private System.Windows.Forms.Label lblH1;
		private System.Windows.Forms.Label lblH2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Timer timerRefresh;
	}
}