namespace SDB.UserControls.Asset
{
	partial class ucAssetList
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
            this.olvAssets = new BrightIdeasSoftware.ObjectListView();
            this.olvColAsset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColPanel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColLocation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlAssets_Control = new System.Windows.Forms.Panel();
            this.lblAssetQty = new System.Windows.Forms.Label();
            this.txtAssetQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssets)).BeginInit();
            this.pnlAssets_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvAssets
            // 
            this.olvAssets.AllColumns.Add(this.olvColAsset);
            this.olvAssets.AllColumns.Add(this.olvColPanel);
            this.olvAssets.AllColumns.Add(this.olvColLocation);
            this.olvAssets.AllColumns.Add(this.olvColCity);
            this.olvAssets.AllColumns.Add(this.olvColState);
            this.olvAssets.AllColumns.Add(this.olvColCountry);
            this.olvAssets.AllowColumnReorder = true;
            this.olvAssets.CellEditUseWholeCell = false;
            this.olvAssets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColAsset,
            this.olvColPanel,
            this.olvColLocation,
            this.olvColCity,
            this.olvColState,
            this.olvColCountry});
            this.olvAssets.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAssets.EmptyListMsg = "";
            this.olvAssets.FullRowSelect = true;
            this.olvAssets.GridLines = true;
            this.olvAssets.HasCollapsibleGroups = false;
            this.olvAssets.Location = new System.Drawing.Point(0, 30);
            this.olvAssets.Name = "olvAssets";
            this.olvAssets.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
            this.olvAssets.ShowCommandMenuOnRightClick = true;
            this.olvAssets.ShowGroups = false;
            this.olvAssets.Size = new System.Drawing.Size(659, 314);
            this.olvAssets.TabIndex = 3;
            this.olvAssets.UseCellFormatEvents = true;
            this.olvAssets.UseCompatibleStateImageBehavior = false;
            this.olvAssets.View = System.Windows.Forms.View.Details;
            this.olvAssets.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvAssets_FormatCell);
            this.olvAssets.DoubleClick += new System.EventHandler(this.olvAssets_DoubleClick);
            // 
            // olvColAsset
            // 
            this.olvColAsset.AspectName = "AssetName";
            this.olvColAsset.Groupable = false;
            this.olvColAsset.IsEditable = false;
            this.olvColAsset.Text = "Asset";
            this.olvColAsset.Width = 90;
            // 
            // olvColPanel
            // 
            this.olvColPanel.AspectName = "Panel";
            this.olvColPanel.Groupable = false;
            this.olvColPanel.IsEditable = false;
            this.olvColPanel.Text = "Panel";
            this.olvColPanel.Width = 90;
            // 
            // olvColLocation
            // 
            this.olvColLocation.AspectName = "Location";
            this.olvColLocation.Groupable = false;
            this.olvColLocation.IsEditable = false;
            this.olvColLocation.Text = "Location";
            this.olvColLocation.Width = 190;
            // 
            // olvColCity
            // 
            this.olvColCity.AspectName = "City";
            this.olvColCity.IsEditable = false;
            this.olvColCity.Text = "City";
            this.olvColCity.Width = 100;
            // 
            // olvColState
            // 
            this.olvColState.AspectName = "State";
            this.olvColState.IsEditable = false;
            this.olvColState.Text = "State";
            this.olvColState.Width = 50;
            // 
            // olvColCountry
            // 
            this.olvColCountry.AspectName = "Country";
            this.olvColCountry.Text = "Country";
            this.olvColCountry.Width = 100;
            // 
            // pnlAssets_Control
            // 
            this.pnlAssets_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlAssets_Control.Controls.Add(this.lblAssetQty);
            this.pnlAssets_Control.Controls.Add(this.txtAssetQty);
            this.pnlAssets_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAssets_Control.Location = new System.Drawing.Point(0, 0);
            this.pnlAssets_Control.Name = "pnlAssets_Control";
            this.pnlAssets_Control.Size = new System.Drawing.Size(659, 30);
            this.pnlAssets_Control.TabIndex = 4;
            // 
            // lblAssetQty
            // 
            this.lblAssetQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssetQty.AutoSize = true;
            this.lblAssetQty.Location = new System.Drawing.Point(560, 7);
            this.lblAssetQty.Name = "lblAssetQty";
            this.lblAssetQty.Size = new System.Drawing.Size(41, 13);
            this.lblAssetQty.TabIndex = 5;
            this.lblAssetQty.Text = "Assets:";
            // 
            // txtAssetQty
            // 
            this.txtAssetQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssetQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetQty.Location = new System.Drawing.Point(611, 2);
            this.txtAssetQty.Name = "txtAssetQty";
            this.txtAssetQty.ReadOnly = true;
            this.txtAssetQty.Size = new System.Drawing.Size(45, 22);
            this.txtAssetQty.TabIndex = 6;
            this.txtAssetQty.TabStop = false;
            this.txtAssetQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ucAssetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvAssets);
            this.Controls.Add(this.pnlAssets_Control);
            this.Name = "ucAssetList";
            this.Size = new System.Drawing.Size(659, 344);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssets)).EndInit();
            this.pnlAssets_Control.ResumeLayout(false);
            this.pnlAssets_Control.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvAssets;
		private BrightIdeasSoftware.OLVColumn olvColAsset;
		private BrightIdeasSoftware.OLVColumn olvColPanel;
		private BrightIdeasSoftware.OLVColumn olvColLocation;
		private BrightIdeasSoftware.OLVColumn olvColCity;
		private BrightIdeasSoftware.OLVColumn olvColState;
		private System.Windows.Forms.Panel pnlAssets_Control;
		private System.Windows.Forms.Label lblAssetQty;
		private System.Windows.Forms.TextBox txtAssetQty;
		private BrightIdeasSoftware.OLVColumn olvColCountry;
    }
}
