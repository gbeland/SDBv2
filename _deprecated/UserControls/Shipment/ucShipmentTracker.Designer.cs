namespace SDB.UserControls.Shipment
{
    partial class ucShipmentTracker
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
            this.olvShipments = new BrightIdeasSoftware.ObjectListView();
            this.olcAsset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcLastUpdate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcLastUpdateBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcExpiration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblShipmentQty = new System.Windows.Forms.Label();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.lblList_Show = new System.Windows.Forms.Label();
            this.olvStatusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvShipmentColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvShipments)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvShipments
            // 
            this.olvShipments.AllColumns.Add(this.olvShipmentColumn);
            this.olvShipments.AllColumns.Add(this.olcAsset);
            this.olvShipments.AllColumns.Add(this.olvStatusColumn);
            this.olvShipments.AllColumns.Add(this.olcLastUpdate);
            this.olvShipments.AllColumns.Add(this.olcLastUpdateBy);
            this.olvShipments.AllColumns.Add(this.olcExpiration);
            this.olvShipments.AllowColumnReorder = true;
            this.olvShipments.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.olvShipments.CausesValidation = false;
            this.olvShipments.CellEditUseWholeCell = false;
            this.olvShipments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvShipmentColumn,
            this.olcAsset,
            this.olvStatusColumn,
            this.olcLastUpdate,
            this.olcLastUpdateBy,
            this.olcExpiration});
            this.olvShipments.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvShipments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvShipments.EmptyListMsg = "";
            this.olvShipments.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvShipments.GridLines = true;
            this.olvShipments.Location = new System.Drawing.Point(0, 32);
            this.olvShipments.Name = "olvShipments";
            this.olvShipments.RowHeight = 48;
            this.olvShipments.SelectAllOnControlA = false;
            this.olvShipments.ShowCommandMenuOnRightClick = true;
            this.olvShipments.ShowGroups = false;
            this.olvShipments.Size = new System.Drawing.Size(826, 601);
            this.olvShipments.SortGroupItemsByPrimaryColumn = false;
            this.olvShipments.TabIndex = 2;
            this.olvShipments.UseAlternatingBackColors = true;
            this.olvShipments.UseCellFormatEvents = true;
            this.olvShipments.UseCompatibleStateImageBehavior = false;
            this.olvShipments.UseFilterIndicator = true;
            this.olvShipments.UseFiltering = true;
            this.olvShipments.View = System.Windows.Forms.View.Details;
            // 
            // olcAsset
            // 
            this.olcAsset.AspectName = "AssetName";
            this.olcAsset.MaximumWidth = 100;
            this.olcAsset.MinimumWidth = 100;
            this.olcAsset.Text = "Asset";
            this.olcAsset.ToolTipText = "Asset Name";
            this.olcAsset.Width = 100;
            this.olcAsset.WordWrap = true;
            // 
            // olcLastUpdate
            // 
            this.olcLastUpdate.AspectName = "Journal.LastUserEntry.JournalText";
            this.olcLastUpdate.CellVerticalAlignment = System.Drawing.StringAlignment.Near;
            this.olcLastUpdate.DisplayIndex = 2;
            this.olcLastUpdate.MaximumWidth = 315;
            this.olcLastUpdate.MinimumWidth = 315;
            this.olcLastUpdate.Text = "Last Update";
            this.olcLastUpdate.ToolTipText = "Last Journal Update";
            this.olcLastUpdate.Width = 315;
            this.olcLastUpdate.WordWrap = true;
            // 
            // olcLastUpdateBy
            // 
            this.olcLastUpdateBy.AspectName = "Journal.LastUserEntry.User_Name";
            this.olcLastUpdateBy.DisplayIndex = 3;
            this.olcLastUpdateBy.MaximumWidth = 100;
            this.olcLastUpdateBy.MinimumWidth = 100;
            this.olcLastUpdateBy.Text = "By";
            this.olcLastUpdateBy.Width = 100;
            // 
            // olcExpiration
            // 
            this.olcExpiration.AspectName = "Journal.LastUserEntry.SoftExpireDateTime";
            this.olcExpiration.DisplayIndex = 4;
            this.olcExpiration.Groupable = false;
            this.olcExpiration.MaximumWidth = 100;
            this.olcExpiration.MinimumWidth = 100;
            this.olcExpiration.Text = "Expire";
            this.olcExpiration.ToolTipText = "When the most recent journal entry expires.";
            this.olcExpiration.Width = 100;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlControl.Controls.Add(this.lblShipmentQty);
            this.pnlControl.Controls.Add(this.txtTicketQty);
            this.pnlControl.Controls.Add(this.lblList_Show);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(826, 30);
            this.pnlControl.TabIndex = 3;
            // 
            // lblShipmentQty
            // 
            this.lblShipmentQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShipmentQty.AutoSize = true;
            this.lblShipmentQty.Location = new System.Drawing.Point(713, 9);
            this.lblShipmentQty.Name = "lblShipmentQty";
            this.lblShipmentQty.Size = new System.Drawing.Size(59, 13);
            this.lblShipmentQty.TabIndex = 4;
            this.lblShipmentQty.Text = "Shipments:";
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketQty.Location = new System.Drawing.Point(778, 4);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.ReadOnly = true;
            this.txtTicketQty.Size = new System.Drawing.Size(45, 22);
            this.txtTicketQty.TabIndex = 5;
            this.txtTicketQty.TabStop = false;
            // 
            // lblList_Show
            // 
            this.lblList_Show.AutoSize = true;
            this.lblList_Show.Location = new System.Drawing.Point(3, 9);
            this.lblList_Show.Name = "lblList_Show";
            this.lblList_Show.Size = new System.Drawing.Size(37, 13);
            this.lblList_Show.TabIndex = 0;
            this.lblList_Show.Text = "Show:";
            // 
            // olvStatusColumn
            // 
            this.olvStatusColumn.DisplayIndex = 5;
            this.olvStatusColumn.MaximumWidth = 100;
            this.olvStatusColumn.MinimumWidth = 100;
            this.olvStatusColumn.Text = "Status";
            this.olvStatusColumn.Width = 100;
            // 
            // olvShipmentColumn
            // 
            this.olvShipmentColumn.MaximumWidth = 100;
            this.olvShipmentColumn.MinimumWidth = 100;
            this.olvShipmentColumn.Text = "Shipment";
            this.olvShipmentColumn.Width = 100;
            // 
            // ucShipmentTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.olvShipments);
            this.Name = "ucShipmentTracker";
            this.Size = new System.Drawing.Size(826, 633);
            ((System.ComponentModel.ISupportInitialize)(this.olvShipments)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvShipments;
        private BrightIdeasSoftware.OLVColumn olcAsset;
        private BrightIdeasSoftware.OLVColumn olcLastUpdate;
        private BrightIdeasSoftware.OLVColumn olcLastUpdateBy;
        private BrightIdeasSoftware.OLVColumn olcExpiration;
        private BrightIdeasSoftware.OLVColumn olvShipmentColumn;
        private BrightIdeasSoftware.OLVColumn olvStatusColumn;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblShipmentQty;
        private System.Windows.Forms.TextBox txtTicketQty;
        private System.Windows.Forms.Label lblList_Show;
    }
}
