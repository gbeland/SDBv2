namespace SDB.Forms.RMA
{
	partial class FormRMA_BinScan
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
			this.txtBinIDInput = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblBinID = new System.Windows.Forms.Label();
			this.txtDetail = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtBinIDInput
			// 
			this.txtBinIDInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBinIDInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBinIDInput.Location = new System.Drawing.Point(15, 25);
			this.txtBinIDInput.Name = "txtBinIDInput";
			this.txtBinIDInput.Size = new System.Drawing.Size(136, 26);
			this.txtBinIDInput.TabIndex = 1;
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
			this.btnClose.Location = new System.Drawing.Point(697, 827);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblBinID
			// 
			this.lblBinID.AutoSize = true;
			this.lblBinID.Location = new System.Drawing.Point(12, 9);
			this.lblBinID.Name = "lblBinID";
			this.lblBinID.Size = new System.Drawing.Size(36, 13);
			this.lblBinID.TabIndex = 0;
			this.lblBinID.Text = "Bin ID";
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
			this.txtDetail.Size = new System.Drawing.Size(757, 748);
			this.txtDetail.TabIndex = 3;
			// 
			// FormRMA_BinScan
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(784, 862);
			this.Controls.Add(this.txtDetail);
			this.Controls.Add(this.lblBinID);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtBinIDInput);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_BinScan";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Bin Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBinIDInput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblBinID;
		private System.Windows.Forms.TextBox txtDetail;
	}
}