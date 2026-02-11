namespace SDB.UserControls.RMA
{
	partial class RmaList
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
			this.components = new System.ComponentModel.Container();
			this.olvRmas = new BrightIdeasSoftware.ObjectListView();
			this.olvColRMA_ID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Created = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_CreatedBy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_IssuedTo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Completed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColRMA_Finalized = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlRMA_Control = new System.Windows.Forms.Panel();
			this.cmbFilter = new System.Windows.Forms.ComboBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblRMAQty = new System.Windows.Forms.Label();
			this.txtRMAQty = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.olvRmas)).BeginInit();
			this.pnlRMA_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvRmas
			// 
			this.olvRmas.AllColumns.Add(this.olvColRMA_ID);
			this.olvRmas.AllColumns.Add(this.olvColRMA_Created);
			this.olvRmas.AllColumns.Add(this.olvColRMA_CreatedBy);
			this.olvRmas.AllColumns.Add(this.olvColRMA_IssuedTo);
			this.olvRmas.AllColumns.Add(this.olvColRMA_Completed);
			this.olvRmas.AllColumns.Add(this.olvColRMA_Finalized);
			this.olvRmas.AllowColumnReorder = true;
			this.olvRmas.CellEditUseWholeCell = false;
			this.olvRmas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColRMA_ID,
            this.olvColRMA_Created,
            this.olvColRMA_CreatedBy,
            this.olvColRMA_IssuedTo,
            this.olvColRMA_Completed,
            this.olvColRMA_Finalized});
			this.olvRmas.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvRmas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvRmas.EmptyListMsg = "No RMAs for this item.";
			this.olvRmas.FullRowSelect = true;
			this.olvRmas.GridLines = true;
			this.olvRmas.HasCollapsibleGroups = false;
			this.olvRmas.Location = new System.Drawing.Point(0, 30);
			this.olvRmas.Name = "olvRmas";
			this.olvRmas.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.Submenu;
			this.olvRmas.ShowCommandMenuOnRightClick = true;
			this.olvRmas.ShowGroups = false;
			this.olvRmas.ShowItemToolTips = true;
			this.olvRmas.Size = new System.Drawing.Size(522, 274);
			this.olvRmas.TabIndex = 6;
			this.olvRmas.UseCompatibleStateImageBehavior = false;
			this.olvRmas.View = System.Windows.Forms.View.Details;
			this.olvRmas.CellToolTipShowing += new System.EventHandler<BrightIdeasSoftware.ToolTipShowingEventArgs>(this.olvRmas_CellToolTipShowing);
			this.olvRmas.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvRmas_FormatRow);
			this.olvRmas.DoubleClick += new System.EventHandler(this.olvRmas_DoubleClick);
			// 
			// olvColRMA_ID
			// 
			this.olvColRMA_ID.AspectName = "ID";
			this.olvColRMA_ID.Groupable = false;
			this.olvColRMA_ID.IsEditable = false;
			this.olvColRMA_ID.Text = "#";
			this.olvColRMA_ID.Width = 50;
			// 
			// olvColRMA_Created
			// 
			this.olvColRMA_Created.AspectName = "Creation_Date";
			this.olvColRMA_Created.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Created.Text = "Created";
			this.olvColRMA_Created.Width = 70;
			// 
			// olvColRMA_CreatedBy
			// 
			this.olvColRMA_CreatedBy.AspectName = "Creation_UserName";
			this.olvColRMA_CreatedBy.Text = "Created by";
			this.olvColRMA_CreatedBy.Width = 65;
			// 
			// olvColRMA_IssuedTo
			// 
			this.olvColRMA_IssuedTo.AspectName = "TechName";
			this.olvColRMA_IssuedTo.Text = "Issued To";
			this.olvColRMA_IssuedTo.Width = 170;
			// 
			// olvColRMA_Completed
			// 
			this.olvColRMA_Completed.AspectName = "Completed_Date";
			this.olvColRMA_Completed.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Completed.Text = "Completed";
			this.olvColRMA_Completed.Width = 70;
			// 
			// olvColRMA_Finalized
			// 
			this.olvColRMA_Finalized.AspectName = "Finalized_Date";
			this.olvColRMA_Finalized.AspectToStringFormat = "{0:yyyy-MM-dd}";
			this.olvColRMA_Finalized.Text = "Finalized";
			this.olvColRMA_Finalized.Width = 70;
			// 
			// pnlRMA_Control
			// 
			this.pnlRMA_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlRMA_Control.Controls.Add(this.cmbFilter);
			this.pnlRMA_Control.Controls.Add(this.btnCreate);
			this.pnlRMA_Control.Controls.Add(this.lblRMAQty);
			this.pnlRMA_Control.Controls.Add(this.txtRMAQty);
			this.pnlRMA_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlRMA_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlRMA_Control.Name = "pnlRMA_Control";
			this.pnlRMA_Control.Size = new System.Drawing.Size(522, 30);
			this.pnlRMA_Control.TabIndex = 5;
			// 
			// cmbFilter
			// 
			this.cmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFilter.FormattingEnabled = true;
			this.cmbFilter.Location = new System.Drawing.Point(302, 5);
			this.cmbFilter.Name = "cmbFilter";
			this.cmbFilter.Size = new System.Drawing.Size(121, 21);
			this.cmbFilter.TabIndex = 11;
			this.cmbFilter.Visible = false;
			this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 23);
			this.btnCreate.TabIndex = 7;
			this.btnCreate.Text = "Create RMA";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Visible = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// lblRMAQty
			// 
			this.lblRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRMAQty.AutoSize = true;
			this.lblRMAQty.Location = new System.Drawing.Point(429, 9);
			this.lblRMAQty.Name = "lblRMAQty";
			this.lblRMAQty.Size = new System.Drawing.Size(39, 13);
			this.lblRMAQty.TabIndex = 9;
			this.lblRMAQty.Text = "RMAs:";
			// 
			// txtRMAQty
			// 
			this.txtRMAQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRMAQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRMAQty.Location = new System.Drawing.Point(474, 4);
			this.txtRMAQty.Name = "txtRMAQty";
			this.txtRMAQty.ReadOnly = true;
			this.txtRMAQty.Size = new System.Drawing.Size(45, 22);
			this.txtRMAQty.TabIndex = 10;
			this.txtRMAQty.TabStop = false;
			this.txtRMAQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// RmaList
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.olvRmas);
			this.Controls.Add(this.pnlRMA_Control);
			this.Name = "RmaList";
			this.Size = new System.Drawing.Size(522, 304);
			((System.ComponentModel.ISupportInitialize)(this.olvRmas)).EndInit();
			this.pnlRMA_Control.ResumeLayout(false);
			this.pnlRMA_Control.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvRmas;
		private BrightIdeasSoftware.OLVColumn olvColRMA_ID;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Created;
		private BrightIdeasSoftware.OLVColumn olvColRMA_CreatedBy;
		private BrightIdeasSoftware.OLVColumn olvColRMA_IssuedTo;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Completed;
		private System.Windows.Forms.Panel pnlRMA_Control;
		private System.Windows.Forms.Label lblRMAQty;
		private System.Windows.Forms.TextBox txtRMAQty;
		private BrightIdeasSoftware.OLVColumn olvColRMA_Finalized;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
