namespace SDB.Forms.Eparts
{
    partial class FormEpartsQoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEpartsQoute));
            this.olvFG = new BrightIdeasSoftware.ObjectListView();
            this.colColAssembly = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olcCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.olvTPH = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblMarkup = new System.Windows.Forms.Label();
            this.lblGrandCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.btnSendToMarket = new System.Windows.Forms.Button();
            this.cmbShippingMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTPH)).BeginInit();
            this.SuspendLayout();
            // 
            // olvFG
            // 
            this.olvFG.AllColumns.Add(this.colColAssembly);
            this.olvFG.AllColumns.Add(this.olcDescription);
            this.olvFG.AllColumns.Add(this.olcQuantity);
            this.olvFG.AllColumns.Add(this.olcCost);
            this.olvFG.AllowColumnReorder = true;
            this.olvFG.AlternateRowBackColor = System.Drawing.Color.DarkGray;
            this.olvFG.CausesValidation = false;
            this.olvFG.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvFG.CellEditEnterChangesRows = true;
            this.olvFG.CellEditUseWholeCell = false;
            this.olvFG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colColAssembly,
            this.olcDescription,
            this.olcQuantity,
            this.olcCost});
            this.olvFG.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvFG.EmptyListMsg = "No  Parts";
            this.olvFG.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvFG.FullRowSelect = true;
            this.olvFG.GridLines = true;
            this.olvFG.Location = new System.Drawing.Point(0, 59);
            this.olvFG.Name = "olvFG";
            this.olvFG.RowHeight = 48;
            this.olvFG.SelectAllOnControlA = false;
            this.olvFG.SelectedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.olvFG.ShowCommandMenuOnRightClick = true;
            this.olvFG.ShowGroups = false;
            this.olvFG.ShowItemToolTips = true;
            this.olvFG.Size = new System.Drawing.Size(822, 222);
            this.olvFG.SortGroupItemsByPrimaryColumn = false;
            this.olvFG.TabIndex = 5;
            this.olvFG.UseAlternatingBackColors = true;
            this.olvFG.UseCellFormatEvents = true;
            this.olvFG.UseCompatibleStateImageBehavior = false;
            this.olvFG.UseFilterIndicator = true;
            this.olvFG.UseFiltering = true;
            this.olvFG.View = System.Windows.Forms.View.Details;
            // 
            // colColAssembly
            // 
            this.colColAssembly.AspectName = "Assembly.DisplayMember";
            this.colColAssembly.AspectToStringFormat = "";
            this.colColAssembly.Groupable = false;
            this.colColAssembly.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colColAssembly.Hideable = false;
            this.colColAssembly.IsEditable = false;
            this.colColAssembly.Text = "Assembly";
            this.colColAssembly.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colColAssembly.ToolTipText = "Ticket ID";
            this.colColAssembly.Width = 111;
            // 
            // olcDescription
            // 
            this.olcDescription.AspectName = "Assembly.Description";
            this.olcDescription.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcDescription.IsEditable = false;
            this.olcDescription.Text = "Description";
            this.olcDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcDescription.ToolTipText = "";
            this.olcDescription.Width = 420;
            // 
            // olcQuantity
            // 
            this.olcQuantity.AspectName = "Quantity";
            this.olcQuantity.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcQuantity.IsEditable = false;
            this.olcQuantity.Text = "Quantity";
            this.olcQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olcQuantity.ToolTipText = "Rental Active";
            this.olcQuantity.Width = 132;
            // 
            // olcCost
            // 
            this.olcCost.AspectName = "Assembly.Cost";
            this.olcCost.AspectToStringFormat = "{0:N2}";
            this.olcCost.IsEditable = false;
            this.olcCost.Text = "Cost";
            this.olcCost.ToolTipText = "Last Journal Update";
            this.olcCost.Width = 150;
            this.olcCost.WordWrap = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(735, 653);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(481, 565);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(586, 565);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(29, 13);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "*qty*";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(700, 565);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "*cost*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Finished Good:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Third Party Hardware:";
            // 
            // olvTPH
            // 
            this.olvTPH.AllColumns.Add(this.olvColumn1);
            this.olvTPH.AllColumns.Add(this.olvColumn2);
            this.olvTPH.AllColumns.Add(this.olvColumn3);
            this.olvTPH.AllColumns.Add(this.olvColumn4);
            this.olvTPH.AllowColumnReorder = true;
            this.olvTPH.AlternateRowBackColor = System.Drawing.Color.DarkGray;
            this.olvTPH.CausesValidation = false;
            this.olvTPH.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvTPH.CellEditEnterChangesRows = true;
            this.olvTPH.CellEditUseWholeCell = false;
            this.olvTPH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.olvTPH.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTPH.EmptyListMsg = "No  Parts";
            this.olvTPH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvTPH.FullRowSelect = true;
            this.olvTPH.GridLines = true;
            this.olvTPH.Location = new System.Drawing.Point(0, 308);
            this.olvTPH.Name = "olvTPH";
            this.olvTPH.RowHeight = 48;
            this.olvTPH.SelectAllOnControlA = false;
            this.olvTPH.SelectedForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.olvTPH.ShowCommandMenuOnRightClick = true;
            this.olvTPH.ShowGroups = false;
            this.olvTPH.ShowItemToolTips = true;
            this.olvTPH.Size = new System.Drawing.Size(822, 222);
            this.olvTPH.SortGroupItemsByPrimaryColumn = false;
            this.olvTPH.TabIndex = 11;
            this.olvTPH.UseAlternatingBackColors = true;
            this.olvTPH.UseCellFormatEvents = true;
            this.olvTPH.UseCompatibleStateImageBehavior = false;
            this.olvTPH.UseFilterIndicator = true;
            this.olvTPH.UseFiltering = true;
            this.olvTPH.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Assembly.DisplayMember";
            this.olvColumn1.AspectToStringFormat = "";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.Hideable = false;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Assembly";
            this.olvColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn1.ToolTipText = "Ticket ID";
            this.olvColumn1.Width = 111;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Assembly.Description";
            this.olvColumn2.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Description";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn2.ToolTipText = "";
            this.olvColumn2.Width = 420;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Quantity";
            this.olvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Quantity";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvColumn3.ToolTipText = "Rental Active";
            this.olvColumn3.Width = 132;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Assembly.Cost";
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "Cost";
            this.olvColumn4.ToolTipText = "Last Journal Update";
            this.olvColumn4.Width = 150;
            this.olvColumn4.WordWrap = true;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(417, 598);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(98, 13);
            this.lblMarkup.TabIndex = 13;
            this.lblMarkup.Text = "Total After Markup:";
            // 
            // lblGrandCost
            // 
            this.lblGrandCost.AutoSize = true;
            this.lblGrandCost.Location = new System.Drawing.Point(700, 598);
            this.lblGrandCost.Name = "lblGrandCost";
            this.lblGrandCost.Size = new System.Drawing.Size(35, 13);
            this.lblGrandCost.TabIndex = 15;
            this.lblGrandCost.Text = "*cost*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Markup: 2.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Markup: 1.6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Expires:";
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Location = new System.Drawing.Point(83, 565);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(44, 13);
            this.lblExpires.TabIndex = 19;
            this.lblExpires.Text = "*expires";
            // 
            // btnSendToMarket
            // 
            this.btnSendToMarket.Location = new System.Drawing.Point(13, 636);
            this.btnSendToMarket.Name = "btnSendToMarket";
            this.btnSendToMarket.Size = new System.Drawing.Size(121, 40);
            this.btnSendToMarket.TabIndex = 20;
            this.btnSendToMarket.Text = "Generate Accounting Sheet";
            this.btnSendToMarket.UseVisualStyleBackColor = true;
            this.btnSendToMarket.Click += new System.EventHandler(this.btnSendToMarket_Click);
            // 
            // cmbShippingMethod
            // 
            this.cmbShippingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShippingMethod.FormattingEnabled = true;
            this.cmbShippingMethod.Location = new System.Drawing.Point(514, 655);
            this.cmbShippingMethod.Name = "cmbShippingMethod";
            this.cmbShippingMethod.Size = new System.Drawing.Size(196, 21);
            this.cmbShippingMethod.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Shipping Method:";
            // 
            // FormEpartsQoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 688);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbShippingMethod);
            this.Controls.Add(this.btnSendToMarket);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGrandCost);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.olvTPH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.olvFG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEpartsQoute";
            this.Text = "Qoute";
            ((System.ComponentModel.ISupportInitialize)(this.olvFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvTPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvFG;
        private BrightIdeasSoftware.OLVColumn colColAssembly;
        private BrightIdeasSoftware.OLVColumn olcDescription;
        private BrightIdeasSoftware.OLVColumn olcQuantity;
        private BrightIdeasSoftware.OLVColumn olcCost;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BrightIdeasSoftware.ObjectListView olvTPH;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Label lblGrandCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExpires;
        private System.Windows.Forms.Button btnSendToMarket;
        private System.Windows.Forms.ComboBox cmbShippingMethod;
        private System.Windows.Forms.Label label6;
    }
}