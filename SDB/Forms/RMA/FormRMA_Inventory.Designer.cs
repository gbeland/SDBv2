namespace SDB.Forms.RMA
{
	partial class FormRMA_Inventory
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
			System.Windows.Forms.TextBox txtInventory_Info;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRMA_Inventory));
			this.btnInventory_PrintBinLabels = new System.Windows.Forms.Button();
			this.btnInventory_DeleteEmptyBins = new System.Windows.Forms.Button();
			this.btnInventory_View = new System.Windows.Forms.Button();
			this.btnInventory_BinScan = new System.Windows.Forms.Button();
			this.btnInventory_MoveItems = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnInventory_SerialNumberSearch = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			txtInventory_Info = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtInventory_Info
			// 
			txtInventory_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			txtInventory_Info.BackColor = System.Drawing.SystemColors.Control;
			txtInventory_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
			txtInventory_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			txtInventory_Info.Location = new System.Drawing.Point(12, 12);
			txtInventory_Info.Multiline = true;
			txtInventory_Info.Name = "txtInventory_Info";
			txtInventory_Info.ReadOnly = true;
			txtInventory_Info.Size = new System.Drawing.Size(305, 62);
			txtInventory_Info.TabIndex = 7;
			txtInventory_Info.TabStop = false;
			txtInventory_Info.Text = "These RMA inventory features are new in version 1.8.7.x. They may be regarded as " +
    "beta features, may have bugs, and are subject to change.";
			// 
			// btnInventory_PrintBinLabels
			// 
			this.btnInventory_PrintBinLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnInventory_PrintBinLabels.Location = new System.Drawing.Point(170, 80);
			this.btnInventory_PrintBinLabels.Name = "btnInventory_PrintBinLabels";
			this.btnInventory_PrintBinLabels.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_PrintBinLabels.TabIndex = 3;
			this.btnInventory_PrintBinLabels.Text = "&Print Bin Labels";
			this.toolTip1.SetToolTip(this.btnInventory_PrintBinLabels, "Print labels for bins.");
			this.btnInventory_PrintBinLabels.UseVisualStyleBackColor = true;
			this.btnInventory_PrintBinLabels.Click += new System.EventHandler(this.btnInventory_PrintBinLabels_Click);
			// 
			// btnInventory_DeleteEmptyBins
			// 
			this.btnInventory_DeleteEmptyBins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnInventory_DeleteEmptyBins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnInventory_DeleteEmptyBins.ForeColor = System.Drawing.Color.Red;
			this.btnInventory_DeleteEmptyBins.Location = new System.Drawing.Point(12, 344);
			this.btnInventory_DeleteEmptyBins.Name = "btnInventory_DeleteEmptyBins";
			this.btnInventory_DeleteEmptyBins.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_DeleteEmptyBins.TabIndex = 5;
			this.btnInventory_DeleteEmptyBins.Text = "Delete Empty Bins";
			this.toolTip1.SetToolTip(this.btnInventory_DeleteEmptyBins, "Delete all empty bins.");
			this.btnInventory_DeleteEmptyBins.UseVisualStyleBackColor = true;
			this.btnInventory_DeleteEmptyBins.Visible = false;
			this.btnInventory_DeleteEmptyBins.Click += new System.EventHandler(this.btnInventory_DeleteEmptyBins_Click);
			// 
			// btnInventory_View
			// 
			this.btnInventory_View.Location = new System.Drawing.Point(12, 186);
			this.btnInventory_View.Name = "btnInventory_View";
			this.btnInventory_View.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_View.TabIndex = 2;
			this.btnInventory_View.Text = "View &Inventory";
			this.toolTip1.SetToolTip(this.btnInventory_View, "View all RMA inventory.");
			this.btnInventory_View.UseVisualStyleBackColor = true;
			this.btnInventory_View.Click += new System.EventHandler(this.btnInventory_View_Click);
			// 
			// btnInventory_BinScan
			// 
			this.btnInventory_BinScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnInventory_BinScan.Location = new System.Drawing.Point(12, 80);
			this.btnInventory_BinScan.Name = "btnInventory_BinScan";
			this.btnInventory_BinScan.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_BinScan.TabIndex = 0;
			this.btnInventory_BinScan.Text = "&Bin Contents/History";
			this.toolTip1.SetToolTip(this.btnInventory_BinScan, "Show contents and history of a bin.");
			this.btnInventory_BinScan.UseVisualStyleBackColor = true;
			this.btnInventory_BinScan.Click += new System.EventHandler(this.btnInventory_BinScan_Click);
			// 
			// btnInventory_MoveItems
			// 
			this.btnInventory_MoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnInventory_MoveItems.Location = new System.Drawing.Point(12, 133);
			this.btnInventory_MoveItems.Name = "btnInventory_MoveItems";
			this.btnInventory_MoveItems.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_MoveItems.TabIndex = 1;
			this.btnInventory_MoveItems.Text = "&Move Items";
			this.toolTip1.SetToolTip(this.btnInventory_MoveItems, "Move assemblies to bins, or bins to zones.");
			this.btnInventory_MoveItems.UseVisualStyleBackColor = true;
			this.btnInventory_MoveItems.Click += new System.EventHandler(this.btnInventory_MoveItems_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(242, 361);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnInventory_SerialNumberSearch
			// 
			this.btnInventory_SerialNumberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.btnInventory_SerialNumberSearch.Location = new System.Drawing.Point(170, 133);
			this.btnInventory_SerialNumberSearch.Name = "btnInventory_SerialNumberSearch";
			this.btnInventory_SerialNumberSearch.Size = new System.Drawing.Size(120, 36);
			this.btnInventory_SerialNumberSearch.TabIndex = 4;
			this.btnInventory_SerialNumberSearch.Text = "&SN Search";
			this.toolTip1.SetToolTip(this.btnInventory_SerialNumberSearch, "View history by serial number.");
			this.btnInventory_SerialNumberSearch.UseVisualStyleBackColor = true;
			this.btnInventory_SerialNumberSearch.Click += new System.EventHandler(this.btnInventory_SerialNumberSearch_Click);
			// 
			// FormRMA_Inventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(329, 396);
			this.Controls.Add(this.btnInventory_SerialNumberSearch);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnInventory_PrintBinLabels);
			this.Controls.Add(txtInventory_Info);
			this.Controls.Add(this.btnInventory_DeleteEmptyBins);
			this.Controls.Add(this.btnInventory_View);
			this.Controls.Add(this.btnInventory_BinScan);
			this.Controls.Add(this.btnInventory_MoveItems);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRMA_Inventory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "RMA Inventory";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnInventory_PrintBinLabels;
		private System.Windows.Forms.Button btnInventory_DeleteEmptyBins;
		private System.Windows.Forms.Button btnInventory_View;
		private System.Windows.Forms.Button btnInventory_BinScan;
		private System.Windows.Forms.Button btnInventory_MoveItems;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnInventory_SerialNumberSearch;
	}
}