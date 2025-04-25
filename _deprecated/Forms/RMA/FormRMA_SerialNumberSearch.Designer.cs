namespace SDB.Forms.RMA
{
	partial class FormRMA_SerialNumberSearch
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
			this.txtSerialNumberInput = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblSN = new System.Windows.Forms.Label();
			this.txtDetail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtSerialNumberInput
			// 
			this.txtSerialNumberInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSerialNumberInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSerialNumberInput.Location = new System.Drawing.Point(15, 25);
			this.txtSerialNumberInput.Name = "txtSerialNumberInput";
			this.txtSerialNumberInput.Size = new System.Drawing.Size(136, 26);
			this.txtSerialNumberInput.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(157, 25);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(797, 527);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblSN
			// 
			this.lblSN.AutoSize = true;
			this.lblSN.Location = new System.Drawing.Point(12, 9);
			this.lblSN.Name = "lblSN";
			this.lblSN.Size = new System.Drawing.Size(73, 13);
			this.lblSN.TabIndex = 0;
			this.lblSN.Text = "Serial Number";
			// 
			// txtDetail
			// 
			this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDetail.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDetail.Location = new System.Drawing.Point(15, 73);
			this.txtDetail.Multiline = true;
			this.txtDetail.Name = "txtDetail";
			this.txtDetail.ReadOnly = true;
			this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDetail.Size = new System.Drawing.Size(857, 448);
			this.txtDetail.TabIndex = 3;
			// 
			// FormRMA_SerialNumberSearch
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.txtDetail);
			this.Controls.Add(this.lblSN);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSerialNumberInput);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_SerialNumberSearch";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA SN Search";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSerialNumberInput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblSN;
		private System.Windows.Forms.TextBox txtDetail;
	}
}