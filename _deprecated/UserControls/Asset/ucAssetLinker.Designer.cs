namespace SDB.UserControls.Asset
{
	partial class AssetLinker
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
			this.flpLinkPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpLinkPanel
			// 
			this.flpLinkPanel.AutoScroll = true;
			this.flpLinkPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flpLinkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpLinkPanel.Location = new System.Drawing.Point(0, 0);
			this.flpLinkPanel.Name = "flpLinkPanel";
			this.flpLinkPanel.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
			this.flpLinkPanel.Size = new System.Drawing.Size(222, 23);
			this.flpLinkPanel.TabIndex = 0;
			// 
			// AssetLinker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flpLinkPanel);
			this.Name = "AssetLinker";
			this.Size = new System.Drawing.Size(222, 23);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpLinkPanel;
	}
}
