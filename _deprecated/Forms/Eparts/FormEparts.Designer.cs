namespace SDB.Forms.Eparts
{
    partial class FormEparts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEparts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblTrackerFilter = new System.Windows.Forms.Label();
            this.olvEparts = new BrightIdeasSoftware.ObjectListView();
            this.colEpartsID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcMarket = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcShipmentID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcEntry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.epartsInfoPanel = new SDB.UserControls.Eparts.EpartsInfo();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvEparts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.epartsInfoPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1021, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 631);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1454, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.olvEparts);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 626);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbxSearch);
            this.panel3.Controls.Add(this.cmbFilter);
            this.panel3.Controls.Add(this.btnNewOrder);
            this.panel3.Controls.Add(this.lblTrackerFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 28);
            this.panel3.TabIndex = 3;
            // 
            // cmbFilter
            // 
            this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(852, 4);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(146, 21);
            this.cmbFilter.TabIndex = 3;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(3, 3);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblTrackerFilter
            // 
            this.lblTrackerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackerFilter.AutoSize = true;
            this.lblTrackerFilter.Location = new System.Drawing.Point(814, 8);
            this.lblTrackerFilter.Name = "lblTrackerFilter";
            this.lblTrackerFilter.Size = new System.Drawing.Size(32, 13);
            this.lblTrackerFilter.TabIndex = 0;
            this.lblTrackerFilter.Text = "Filter:";
            // 
            // olvEparts
            // 
            this.olvEparts.AllColumns.Add(this.colEpartsID);
            this.olvEparts.AllColumns.Add(this.olcMarket);
            this.olvEparts.AllColumns.Add(this.olcShipmentID);
            this.olvEparts.AllColumns.Add(this.olcStatus);
            this.olvEparts.AllColumns.Add(this.olcEntry);
            this.olvEparts.AllColumns.Add(this.olvBy);
            this.olvEparts.AllowColumnReorder = true;
            this.olvEparts.AlternateRowBackColor = System.Drawing.Color.DarkGray;
            this.olvEparts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvEparts.CausesValidation = false;
            this.olvEparts.CellEditUseWholeCell = false;
            this.olvEparts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpartsID,
            this.olcMarket,
            this.olcShipmentID,
            this.olcStatus,
            this.olcEntry,
            this.olvBy});
            this.olvEparts.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvEparts.EmptyListMsg = "No Eparts Orders Found";
            this.olvEparts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvEparts.FullRowSelect = true;
            this.olvEparts.GridLines = true;
            this.olvEparts.Location = new System.Drawing.Point(0, 39);
            this.olvEparts.Name = "olvEparts";
            this.olvEparts.RowHeight = 48;
            this.olvEparts.SelectAllOnControlA = false;
            this.olvEparts.SelectedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.olvEparts.ShowCommandMenuOnRightClick = true;
            this.olvEparts.ShowGroups = false;
            this.olvEparts.ShowItemToolTips = true;
            this.olvEparts.Size = new System.Drawing.Size(998, 587);
            this.olvEparts.SortGroupItemsByPrimaryColumn = false;
            this.olvEparts.TabIndex = 4;
            this.olvEparts.UseAlternatingBackColors = true;
            this.olvEparts.UseCellFormatEvents = true;
            this.olvEparts.UseCompatibleStateImageBehavior = false;
            this.olvEparts.UseFilterIndicator = true;
            this.olvEparts.UseFiltering = true;
            this.olvEparts.View = System.Windows.Forms.View.Details;
            this.olvEparts.SelectedIndexChanged += new System.EventHandler(this.olvEparts_SelectedIndexChanged);
            // 
            // colEpartsID
            // 
            this.colEpartsID.AspectName = "FormattedID";
            this.colEpartsID.AspectToStringFormat = "";
            this.colEpartsID.Groupable = false;
            this.colEpartsID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEpartsID.Hideable = false;
            this.colEpartsID.Text = "Eparts Order";
            this.colEpartsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEpartsID.ToolTipText = "Ticket ID";
            this.colEpartsID.Width = 111;
            // 
            // olcMarket
            // 
            this.olcMarket.AspectName = "Market.Name";
            this.olcMarket.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcMarket.Text = "Market";
            this.olcMarket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcMarket.ToolTipText = "Tech On-Site";
            this.olcMarket.Width = 116;
            // 
            // olcShipmentID
            // 
            this.olcShipmentID.AspectName = "Shipment_ID";
            this.olcShipmentID.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcShipmentID.Text = "Shipment";
            this.olcShipmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcShipmentID.ToolTipText = "Rental Active";
            this.olcShipmentID.Width = 132;
            // 
            // olcStatus
            // 
            this.olcStatus.AspectName = "Status";
            this.olcStatus.Text = "Status";
            this.olcStatus.ToolTipText = "Last Journal Update";
            this.olcStatus.Width = 150;
            this.olcStatus.WordWrap = true;
            // 
            // olcEntry
            // 
            this.olcEntry.AspectName = "LastEntry";
            this.olcEntry.Groupable = false;
            this.olcEntry.Text = "Last Entry";
            this.olcEntry.ToolTipText = "When the most recent journal entry expires.";
            this.olcEntry.Width = 300;
            // 
            // olvBy
            // 
            this.olvBy.AspectName = "LastEntryUser";
            this.olvBy.Text = "By";
            this.olvBy.Width = 89;
            // 
            // epartsInfoPanel
            // 
            this.epartsInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epartsInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.epartsInfoPanel.Name = "epartsInfoPanel";
            this.epartsInfoPanel.Size = new System.Drawing.Size(433, 631);
            this.epartsInfoPanel.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(632, 5);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(176, 20);
            this.tbxSearch.TabIndex = 4;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // FormEparts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEparts";
            this.Text = "Eparts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEparts_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormEparts_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvEparts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblTrackerFilter;
        private BrightIdeasSoftware.ObjectListView olvEparts;
        private BrightIdeasSoftware.OLVColumn colEpartsID;
        private BrightIdeasSoftware.OLVColumn olcMarket;
        private BrightIdeasSoftware.OLVColumn olcShipmentID;
        private BrightIdeasSoftware.OLVColumn olcStatus;
        private BrightIdeasSoftware.OLVColumn olcEntry;
        private BrightIdeasSoftware.OLVColumn olvBy;
        private UserControls.Eparts.EpartsInfo epartsInfoPanel;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}