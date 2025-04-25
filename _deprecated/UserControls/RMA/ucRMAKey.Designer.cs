namespace SDB.UserControls
{
	partial class RMAKey
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
			this.lblKey_Finalized = new System.Windows.Forms.Label();
			this.lblKey_Completed = new System.Windows.Forms.Label();
			this.lblKey_InProgress = new System.Windows.Forms.Label();
			this.lblKey_Received = new System.Windows.Forms.Label();
			this.lblKey_NotReceived = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// lblKey_Finalized
			// 
			this.lblKey_Finalized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_Finalized.Location = new System.Drawing.Point(99, 0);
			this.lblKey_Finalized.Name = "lblKey_Finalized";
			this.lblKey_Finalized.Size = new System.Drawing.Size(16, 16);
			this.lblKey_Finalized.TabIndex = 14;
			// 
			// lblKey_Completed
			// 
			this.lblKey_Completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_Completed.Location = new System.Drawing.Point(75, 0);
			this.lblKey_Completed.Name = "lblKey_Completed";
			this.lblKey_Completed.Size = new System.Drawing.Size(16, 16);
			this.lblKey_Completed.TabIndex = 13;
			// 
			// lblKey_InProgress
			// 
			this.lblKey_InProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_InProgress.Location = new System.Drawing.Point(51, 0);
			this.lblKey_InProgress.Name = "lblKey_InProgress";
			this.lblKey_InProgress.Size = new System.Drawing.Size(16, 16);
			this.lblKey_InProgress.TabIndex = 12;
			// 
			// lblKey_Received
			// 
			this.lblKey_Received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_Received.Location = new System.Drawing.Point(27, 0);
			this.lblKey_Received.Name = "lblKey_Received";
			this.lblKey_Received.Size = new System.Drawing.Size(16, 16);
			this.lblKey_Received.TabIndex = 11;
			// 
			// lblKey_NotReceived
			// 
			this.lblKey_NotReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_NotReceived.Location = new System.Drawing.Point(3, 0);
			this.lblKey_NotReceived.Name = "lblKey_NotReceived";
			this.lblKey_NotReceived.Size = new System.Drawing.Size(16, 16);
			this.lblKey_NotReceived.TabIndex = 10;
			// 
			// RMAKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblKey_Finalized);
			this.Controls.Add(this.lblKey_Completed);
			this.Controls.Add(this.lblKey_InProgress);
			this.Controls.Add(this.lblKey_Received);
			this.Controls.Add(this.lblKey_NotReceived);
			this.Name = "RMAKey";
			this.Size = new System.Drawing.Size(116, 124);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblKey_Finalized;
		private System.Windows.Forms.Label lblKey_Completed;
		private System.Windows.Forms.Label lblKey_InProgress;
		private System.Windows.Forms.Label lblKey_Received;
		private System.Windows.Forms.Label lblKey_NotReceived;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
