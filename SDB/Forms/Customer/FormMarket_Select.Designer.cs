namespace SDB.Forms.Customer
{
	partial class FormMarket_Select
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
			this.tvMarketList = new System.Windows.Forms.TreeView();
			this.btnMarketList_OK = new System.Windows.Forms.Button();
			this.btnMarketList_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tvMarketList
			// 
			this.tvMarketList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvMarketList.Location = new System.Drawing.Point(13, 13);
			this.tvMarketList.Name = "tvMarketList";
			this.tvMarketList.Size = new System.Drawing.Size(339, 508);
			this.tvMarketList.TabIndex = 0;
			this.tvMarketList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvMarketList_MouseDoubleClick);
			// 
			// btnMarketList_OK
			// 
			this.btnMarketList_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMarketList_OK.Location = new System.Drawing.Point(277, 527);
			this.btnMarketList_OK.Name = "btnMarketList_OK";
			this.btnMarketList_OK.Size = new System.Drawing.Size(75, 23);
			this.btnMarketList_OK.TabIndex = 1;
			this.btnMarketList_OK.Text = "OK";
			this.btnMarketList_OK.UseVisualStyleBackColor = true;
			this.btnMarketList_OK.Click += new System.EventHandler(this.btnMarketList_OK_Click);
			// 
			// btnMarketList_Cancel
			// 
			this.btnMarketList_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMarketList_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnMarketList_Cancel.Location = new System.Drawing.Point(196, 527);
			this.btnMarketList_Cancel.Name = "btnMarketList_Cancel";
			this.btnMarketList_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btnMarketList_Cancel.TabIndex = 2;
			this.btnMarketList_Cancel.Text = "Cancel";
			this.btnMarketList_Cancel.UseVisualStyleBackColor = true;
			this.btnMarketList_Cancel.Click += new System.EventHandler(this.btnMarketList_Cancel_Click);
			// 
			// FormMarket_Select
			// 
			this.AcceptButton = this.btnMarketList_OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnMarketList_Cancel;
			this.ClientSize = new System.Drawing.Size(364, 562);
			this.Controls.Add(this.btnMarketList_Cancel);
			this.Controls.Add(this.btnMarketList_OK);
			this.Controls.Add(this.tvMarketList);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(380, 300);
			this.Name = "FormMarket_Select";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Market List";
			this.Load += new System.EventHandler(this.FormMarketList_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tvMarketList;
		private System.Windows.Forms.Button btnMarketList_OK;
		private System.Windows.Forms.Button btnMarketList_Cancel;
	}
}