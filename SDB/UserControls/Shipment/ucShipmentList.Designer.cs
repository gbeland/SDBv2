namespace SDB.UserControls.Shipment
{
	partial class ucShipmentList
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
			this.olcShipmentId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcRequestedDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcRequestedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcDestination = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcMethod = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcFulfilledDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTracking = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcPickedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcShippedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlShipments_Control = new System.Windows.Forms.Panel();
			this.lblShipmentsQty = new System.Windows.Forms.Label();
			this.txtShipmentsQty = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.olvShipments)).BeginInit();
			this.pnlShipments_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvShipments
			// 
			this.olvShipments.AllColumns.Add(this.olcShipmentId);
			this.olvShipments.AllColumns.Add(this.olcRequestedDate);
			this.olvShipments.AllColumns.Add(this.olcRequestedBy);
			this.olvShipments.AllColumns.Add(this.olcDestination);
			this.olvShipments.AllColumns.Add(this.olcMethod);
			this.olvShipments.AllColumns.Add(this.olcFulfilledDate);
			this.olvShipments.AllColumns.Add(this.olcTracking);
			this.olvShipments.AllColumns.Add(this.olcStatus);
			this.olvShipments.AllColumns.Add(this.olcPickedBy);
			this.olvShipments.AllColumns.Add(this.olcShippedBy);
			this.olvShipments.AllowColumnReorder = true;
			this.olvShipments.CellEditUseWholeCell = false;
			this.olvShipments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcShipmentId,
            this.olcRequestedDate,
            this.olcRequestedBy,
            this.olcDestination,
            this.olcMethod,
            this.olcFulfilledDate,
            this.olcTracking,
            this.olcStatus,
            this.olcPickedBy,
            this.olcShippedBy});
			this.olvShipments.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvShipments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvShipments.EmptyListMsg = "No shipments for this item.";
			this.olvShipments.FullRowSelect = true;
			this.olvShipments.GridLines = true;
			this.olvShipments.HasCollapsibleGroups = false;
			this.olvShipments.Location = new System.Drawing.Point(0, 30);
			this.olvShipments.Name = "olvShipments";
			this.olvShipments.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvShipments.ShowCommandMenuOnRightClick = true;
			this.olvShipments.ShowGroups = false;
			this.olvShipments.Size = new System.Drawing.Size(905, 348);
			this.olvShipments.TabIndex = 9;
			this.olvShipments.UseCompatibleStateImageBehavior = false;
			this.olvShipments.UseHyperlinks = true;
			this.olvShipments.View = System.Windows.Forms.View.Details;
			this.olvShipments.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvShipments_FormatRow);
			this.olvShipments.HyperlinkClicked += new System.EventHandler<BrightIdeasSoftware.HyperlinkClickedEventArgs>(this.olvShipments_HyperlinkClicked);
			this.olvShipments.DoubleClick += new System.EventHandler(this.olvShipments_DoubleClick);
			// 
			// olcShipmentId
			// 
			this.olcShipmentId.AspectName = "ID";
			this.olcShipmentId.Groupable = false;
			this.olcShipmentId.IsEditable = false;
			this.olcShipmentId.Text = "#";
			this.olcShipmentId.Width = 50;
			// 
			// olcRequestedDate
			// 
			this.olcRequestedDate.AspectName = "Requested_Date";
			this.olcRequestedDate.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcRequestedDate.Text = "Requested";
			this.olcRequestedDate.Width = 70;
			// 
			// olcRequestedBy
			// 
			this.olcRequestedBy.AspectName = "Requested_By";
			this.olcRequestedBy.Text = "Requested By";
			this.olcRequestedBy.Width = 80;
			// 
			// olcDestination
			// 
			this.olcDestination.AspectName = "Destination.Company";
			this.olcDestination.Text = "Destination";
			this.olcDestination.Width = 145;
			// 
			// olcMethod
			// 
			this.olcMethod.AspectName = "ShipMethod_Name";
			this.olcMethod.Text = "Method";
			this.olcMethod.Width = 90;
			// 
			// olcFulfilledDate
			// 
			this.olcFulfilledDate.AspectName = "Fulfilled_Date";
			this.olcFulfilledDate.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olcFulfilledDate.Text = "Shipped";
			this.olcFulfilledDate.Width = 70;
			// 
			// olcTracking
			// 
			this.olcTracking.AspectName = "Tracking";
			this.olcTracking.Groupable = false;
			this.olcTracking.Hyperlink = true;
			this.olcTracking.Text = "Tracking";
			this.olcTracking.Width = 140;
			// 
			// olcStatus
			// 
			this.olcStatus.AspectName = "Status";
			this.olcStatus.Text = "Status";
			// 
			// olcPickedBy
			// 
			this.olcPickedBy.AspectName = "Picked_By";
			this.olcPickedBy.Text = "Picked By";
			this.olcPickedBy.Width = 80;
			// 
			// olcShippedBy
			// 
			this.olcShippedBy.AspectName = "Fulfilled_By";
			this.olcShippedBy.Text = "Shipped By";
			this.olcShippedBy.Width = 80;
			// 
			// pnlShipments_Control
			// 
			this.pnlShipments_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlShipments_Control.Controls.Add(this.lblShipmentsQty);
			this.pnlShipments_Control.Controls.Add(this.txtShipmentsQty);
			this.pnlShipments_Control.Controls.Add(this.btnCreate);
			this.pnlShipments_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlShipments_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlShipments_Control.Name = "pnlShipments_Control";
			this.pnlShipments_Control.Size = new System.Drawing.Size(905, 30);
			this.pnlShipments_Control.TabIndex = 8;
			// 
			// lblShipmentsQty
			// 
			this.lblShipmentsQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblShipmentsQty.AutoSize = true;
			this.lblShipmentsQty.Location = new System.Drawing.Point(792, 8);
			this.lblShipmentsQty.Name = "lblShipmentsQty";
			this.lblShipmentsQty.Size = new System.Drawing.Size(59, 13);
			this.lblShipmentsQty.TabIndex = 9;
			this.lblShipmentsQty.Text = "Shipments:";
			// 
			// txtShipmentsQty
			// 
			this.txtShipmentsQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtShipmentsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtShipmentsQty.Location = new System.Drawing.Point(857, 4);
			this.txtShipmentsQty.Name = "txtShipmentsQty";
			this.txtShipmentsQty.ReadOnly = true;
			this.txtShipmentsQty.Size = new System.Drawing.Size(45, 22);
			this.txtShipmentsQty.TabIndex = 10;
			this.txtShipmentsQty.TabStop = false;
			this.txtShipmentsQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create Shipment";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// ucShipmentList
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.olvShipments);
			this.Controls.Add(this.pnlShipments_Control);
			this.Name = "ucShipmentList";
			this.Size = new System.Drawing.Size(905, 378);
			((System.ComponentModel.ISupportInitialize)(this.olvShipments)).EndInit();
			this.pnlShipments_Control.ResumeLayout(false);
			this.pnlShipments_Control.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvShipments;
		private BrightIdeasSoftware.OLVColumn olcShipmentId;
		private BrightIdeasSoftware.OLVColumn olcRequestedDate;
		private BrightIdeasSoftware.OLVColumn olcDestination;
		private BrightIdeasSoftware.OLVColumn olcFulfilledDate;
		private BrightIdeasSoftware.OLVColumn olcTracking;
		private System.Windows.Forms.Panel pnlShipments_Control;
		private System.Windows.Forms.Label lblShipmentsQty;
		private System.Windows.Forms.TextBox txtShipmentsQty;
		private System.Windows.Forms.Button btnCreate;
		private BrightIdeasSoftware.OLVColumn olcStatus;
		private BrightIdeasSoftware.OLVColumn olcMethod;
		private BrightIdeasSoftware.OLVColumn olcRequestedBy;
		private BrightIdeasSoftware.OLVColumn olcPickedBy;
		private BrightIdeasSoftware.OLVColumn olcShippedBy;

	}
}
