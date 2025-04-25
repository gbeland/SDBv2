namespace SDB.Forms.RMA
{
	partial class FormRMA_MoveStuff
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
			this.btnInput = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblStatus = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.timerInputWaitTimeout = new System.Windows.Forms.Timer(this.components);
			this.lblMoveInfo = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(441, 33);
			this.btnInput.Name = "btnInput";
			this.btnInput.Size = new System.Drawing.Size(76, 45);
			this.btnInput.TabIndex = 2;
			this.btnInput.Text = "Input";
			this.btnInput.UseVisualStyleBackColor = true;
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInput.Location = new System.Drawing.Point(12, 33);
			this.txtInput.MaxLength = 32;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(423, 45);
			this.txtInput.TabIndex = 1;
			this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
			// 
			// txtStatus
			// 
			this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStatus.BackColor = System.Drawing.Color.Black;
			this.txtStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.txtStatus.Location = new System.Drawing.Point(12, 97);
			this.txtStatus.Multiline = true;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(505, 293);
			this.txtStatus.TabIndex = 4;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(447, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblMoveInfo);
			this.panel1.Controls.Add(this.lblStatus);
			this.panel1.Controls.Add(this.txtInput);
			this.panel1.Controls.Add(this.txtStatus);
			this.panel1.Controls.Add(this.btnInput);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(534, 426);
			this.panel1.TabIndex = 0;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(12, 81);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "Status";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 396);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(534, 30);
			this.panel2.TabIndex = 1;
			// 
			// timerInputWaitTimeout
			// 
			this.timerInputWaitTimeout.Interval = 10000;
			this.timerInputWaitTimeout.Tick += new System.EventHandler(this.timerInputWaitTimeout_Tick);
			// 
			// lblMoveInfo
			// 
			this.lblMoveInfo.AutoSize = true;
			this.lblMoveInfo.Location = new System.Drawing.Point(12, 9);
			this.lblMoveInfo.Name = "lblMoveInfo";
			this.lblMoveInfo.Size = new System.Drawing.Size(285, 13);
			this.lblMoveInfo.TabIndex = 0;
			this.lblMoveInfo.Text = "First scan the item being moved, followed by its destination.";
			// 
			// FormRMA_MoveStuff
			// 
			this.AcceptButton = this.btnInput;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(534, 426);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_MoveStuff";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Inventory: Move Items";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnInput;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Timer timerInputWaitTimeout;
		private System.Windows.Forms.Label lblMoveInfo;
	}
}