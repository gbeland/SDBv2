namespace SDB.Forms.RMA
{
	partial class FormRMA_InventoryView
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
			this.tvInventory = new System.Windows.Forms.TreeView();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// tvInventory
			// 
			this.tvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvInventory.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tvInventory.Location = new System.Drawing.Point(0, 0);
			this.tvInventory.Name = "tvInventory";
			this.tvInventory.Size = new System.Drawing.Size(541, 667);
			this.tvInventory.TabIndex = 0;
			this.tvInventory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvInventory_NodeMouseDoubleClick);
			// 
			// pnlControl
			// 
			this.pnlControl.Controls.Add(this.btnClose);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlControl.Location = new System.Drawing.Point(0, 667);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(541, 30);
			this.pnlControl.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(463, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormRMA_InventoryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(541, 697);
			this.Controls.Add(this.tvInventory);
			this.Controls.Add(this.pnlControl);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_InventoryView";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Inventory";
			this.Load += new System.EventHandler(this.FormRMA_Inventory_Load);
			this.pnlControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tvInventory;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Button btnClose;
	}
}