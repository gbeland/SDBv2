namespace SDB.Forms.Tech
{
	partial class FormList_Techs
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
            this.olvTechs = new BrightIdeasSoftware.ObjectListView();
            this.olvColTechName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTech1Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTech2Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTech3Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColFax = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRateNormal = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRateAfterHours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColRateEmergency = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlSubControlRight = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTechQty = new System.Windows.Forms.Label();
            this.txtTechQty = new System.Windows.Forms.TextBox();
            this.pnlSubControlLeft = new System.Windows.Forms.Panel();
            this.lblView = new System.Windows.Forms.Label();
            this.radAssigned = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.olvColPriority = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvTechs)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlSubControlRight.SuspendLayout();
            this.pnlSubControlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvTechs
            // 
            this.olvTechs.AllColumns.Add(this.olvColPriority);
            this.olvTechs.AllColumns.Add(this.olvColTechName);
            this.olvTechs.AllColumns.Add(this.olvColAddress);
            this.olvTechs.AllColumns.Add(this.olvColCity);
            this.olvTechs.AllColumns.Add(this.olvColState);
            this.olvTechs.AllColumns.Add(this.olvColZip);
            this.olvTechs.AllColumns.Add(this.olvColCountry);
            this.olvTechs.AllColumns.Add(this.olvColStatus);
            this.olvTechs.AllColumns.Add(this.olvColTech1Name);
            this.olvTechs.AllColumns.Add(this.olvColTech2Name);
            this.olvTechs.AllColumns.Add(this.olvColTech3Name);
            this.olvTechs.AllColumns.Add(this.olvColTelephone);
            this.olvTechs.AllColumns.Add(this.olvColFax);
            this.olvTechs.AllColumns.Add(this.olvColEmail);
            this.olvTechs.AllColumns.Add(this.olvColRateNormal);
            this.olvTechs.AllColumns.Add(this.olvColRateAfterHours);
            this.olvTechs.AllColumns.Add(this.olvColRateEmergency);
            this.olvTechs.AllowColumnReorder = true;
            this.olvTechs.CellEditUseWholeCell = false;
            this.olvTechs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColPriority,
            this.olvColTechName,
            this.olvColAddress,
            this.olvColCity,
            this.olvColState,
            this.olvColZip,
            this.olvColCountry,
            this.olvColStatus,
            this.olvColTech1Name,
            this.olvColTech2Name,
            this.olvColTech3Name,
            this.olvColTelephone,
            this.olvColFax,
            this.olvColEmail,
            this.olvColRateNormal,
            this.olvColRateAfterHours,
            this.olvColRateEmergency});
            this.olvTechs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvTechs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvTechs.EmptyListMsg = "Please wait...";
            this.olvTechs.FullRowSelect = true;
            this.olvTechs.GridLines = true;
            this.olvTechs.HeaderWordWrap = true;
            this.olvTechs.Location = new System.Drawing.Point(0, 30);
            this.olvTechs.MultiSelect = false;
            this.olvTechs.Name = "olvTechs";
            this.olvTechs.SelectAllOnControlA = false;
            this.olvTechs.ShowCommandMenuOnRightClick = true;
            this.olvTechs.ShowGroups = false;
            this.olvTechs.ShowItemCountOnGroups = true;
            this.olvTechs.Size = new System.Drawing.Size(960, 471);
            this.olvTechs.SortGroupItemsByPrimaryColumn = false;
            this.olvTechs.TabIndex = 0;
            this.olvTechs.UseCellFormatEvents = true;
            this.olvTechs.UseCompatibleStateImageBehavior = false;
            this.olvTechs.UseFilterIndicator = true;
            this.olvTechs.UseFiltering = true;
            this.olvTechs.View = System.Windows.Forms.View.Details;
            this.olvTechs.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvTechs_FormatCell);
            this.olvTechs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvTechs_MouseDoubleClick);
            // 
            // olvColTechName
            // 
            this.olvColTechName.AspectName = "TechName";
            this.olvColTechName.Groupable = false;
            this.olvColTechName.Hideable = false;
            this.olvColTechName.IsEditable = false;
            this.olvColTechName.Text = "Tech Name";
            this.olvColTechName.Width = 170;
            // 
            // olvColAddress
            // 
            this.olvColAddress.AspectName = "Address";
            this.olvColAddress.Groupable = false;
            this.olvColAddress.IsEditable = false;
            this.olvColAddress.Text = "Address";
            this.olvColAddress.UseFiltering = false;
            this.olvColAddress.Width = 160;
            // 
            // olvColCity
            // 
            this.olvColCity.AspectName = "City";
            this.olvColCity.IsEditable = false;
            this.olvColCity.Text = "City";
            this.olvColCity.Width = 90;
            // 
            // olvColState
            // 
            this.olvColState.AspectName = "State";
            this.olvColState.IsEditable = false;
            this.olvColState.Text = "State";
            this.olvColState.Width = 45;
            // 
            // olvColZip
            // 
            this.olvColZip.AspectName = "Zip";
            this.olvColZip.Groupable = false;
            this.olvColZip.IsEditable = false;
            this.olvColZip.Text = "Zip";
            this.olvColZip.UseFiltering = false;
            // 
            // olvColCountry
            // 
            this.olvColCountry.AspectName = "Country";
            this.olvColCountry.IsEditable = false;
            this.olvColCountry.Text = "Country";
            this.olvColCountry.Width = 100;
            // 
            // olvColStatus
            // 
            this.olvColStatus.AspectName = "TechStatus";
            this.olvColStatus.AspectToStringFormat = "{0}";
            this.olvColStatus.IsEditable = false;
            this.olvColStatus.Searchable = false;
            this.olvColStatus.Text = "Status";
            this.olvColStatus.Width = 80;
            // 
            // olvColTech1Name
            // 
            this.olvColTech1Name.AspectName = "Contact1_Name";
            this.olvColTech1Name.Groupable = false;
            this.olvColTech1Name.IsEditable = false;
            this.olvColTech1Name.Text = "Contact 1";
            this.olvColTech1Name.UseFiltering = false;
            this.olvColTech1Name.Width = 100;
            // 
            // olvColTech2Name
            // 
            this.olvColTech2Name.AspectName = "Contact2_Name";
            this.olvColTech2Name.Groupable = false;
            this.olvColTech2Name.IsEditable = false;
            this.olvColTech2Name.Text = "Contact 2";
            this.olvColTech2Name.UseFiltering = false;
            this.olvColTech2Name.Width = 100;
            // 
            // olvColTech3Name
            // 
            this.olvColTech3Name.AspectName = "Contact3_Name";
            this.olvColTech3Name.Groupable = false;
            this.olvColTech3Name.IsEditable = false;
            this.olvColTech3Name.Text = "Contact 3";
            this.olvColTech3Name.UseFiltering = false;
            this.olvColTech3Name.Width = 100;
            // 
            // olvColTelephone
            // 
            this.olvColTelephone.AspectName = "Telephone";
            this.olvColTelephone.Groupable = false;
            this.olvColTelephone.IsEditable = false;
            this.olvColTelephone.Text = "Telephone";
            this.olvColTelephone.UseFiltering = false;
            this.olvColTelephone.Width = 80;
            // 
            // olvColFax
            // 
            this.olvColFax.AspectName = "Fax";
            this.olvColFax.Groupable = false;
            this.olvColFax.IsEditable = false;
            this.olvColFax.Text = "Fax";
            this.olvColFax.UseFiltering = false;
            this.olvColFax.Width = 80;
            // 
            // olvColEmail
            // 
            this.olvColEmail.AspectName = "Email";
            this.olvColEmail.Groupable = false;
            this.olvColEmail.IsEditable = false;
            this.olvColEmail.Text = "Email";
            this.olvColEmail.UseFiltering = false;
            this.olvColEmail.Width = 120;
            // 
            // olvColRateNormal
            // 
            this.olvColRateNormal.AspectName = "Rate_Normal";
            this.olvColRateNormal.AspectToStringFormat = "{0:0.00}";
            this.olvColRateNormal.Groupable = false;
            this.olvColRateNormal.IsEditable = false;
            this.olvColRateNormal.Text = "Normal Rate";
            this.olvColRateNormal.Width = 70;
            // 
            // olvColRateAfterHours
            // 
            this.olvColRateAfterHours.AspectName = "Rate_AfterHours";
            this.olvColRateAfterHours.AspectToStringFormat = "{0:0.00}";
            this.olvColRateAfterHours.Groupable = false;
            this.olvColRateAfterHours.IsEditable = false;
            this.olvColRateAfterHours.Text = "After Hours Rate";
            this.olvColRateAfterHours.Width = 70;
            // 
            // olvColRateEmergency
            // 
            this.olvColRateEmergency.AspectName = "Rate_Emergency";
            this.olvColRateEmergency.AspectToStringFormat = "{0:0.00}";
            this.olvColRateEmergency.Groupable = false;
            this.olvColRateEmergency.IsEditable = false;
            this.olvColRateEmergency.Text = "Emergency Rate";
            this.olvColRateEmergency.Width = 70;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(897, 531);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(816, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Controls.Add(this.olvTechs);
            this.pnlContainer.Controls.Add(this.pnlControl);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(960, 501);
            this.pnlContainer.TabIndex = 3;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlControl.Controls.Add(this.pnlSubControlRight);
            this.pnlControl.Controls.Add(this.pnlSubControlLeft);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(960, 30);
            this.pnlControl.TabIndex = 8;
            // 
            // pnlSubControlRight
            // 
            this.pnlSubControlRight.Controls.Add(this.btnExport);
            this.pnlSubControlRight.Controls.Add(this.btnPrint);
            this.pnlSubControlRight.Controls.Add(this.lblTechQty);
            this.pnlSubControlRight.Controls.Add(this.txtTechQty);
            this.pnlSubControlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubControlRight.Location = new System.Drawing.Point(167, 0);
            this.pnlSubControlRight.Name = "pnlSubControlRight";
            this.pnlSubControlRight.Size = new System.Drawing.Size(793, 30);
            this.pnlSubControlRight.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(3, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "&Export to file...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(109, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "&Print...";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTechQty
            // 
            this.lblTechQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTechQty.AutoSize = true;
            this.lblTechQty.Location = new System.Drawing.Point(684, 7);
            this.lblTechQty.Name = "lblTechQty";
            this.lblTechQty.Size = new System.Drawing.Size(40, 13);
            this.lblTechQty.TabIndex = 7;
            this.lblTechQty.Text = "Techs:";
            // 
            // txtTechQty
            // 
            this.txtTechQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTechQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechQty.Location = new System.Drawing.Point(730, 2);
            this.txtTechQty.Name = "txtTechQty";
            this.txtTechQty.ReadOnly = true;
            this.txtTechQty.Size = new System.Drawing.Size(60, 22);
            this.txtTechQty.TabIndex = 8;
            this.txtTechQty.TabStop = false;
            this.txtTechQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlSubControlLeft
            // 
            this.pnlSubControlLeft.Controls.Add(this.lblView);
            this.pnlSubControlLeft.Controls.Add(this.radAssigned);
            this.pnlSubControlLeft.Controls.Add(this.radAll);
            this.pnlSubControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubControlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlSubControlLeft.Name = "pnlSubControlLeft";
            this.pnlSubControlLeft.Size = new System.Drawing.Size(167, 30);
            this.pnlSubControlLeft.TabIndex = 9;
            this.pnlSubControlLeft.Visible = false;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(3, 9);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(33, 13);
            this.lblView.TabIndex = 3;
            this.lblView.Text = "View:";
            // 
            // radAssigned
            // 
            this.radAssigned.AutoSize = true;
            this.radAssigned.Checked = true;
            this.radAssigned.Location = new System.Drawing.Point(42, 7);
            this.radAssigned.Name = "radAssigned";
            this.radAssigned.Size = new System.Drawing.Size(68, 17);
            this.radAssigned.TabIndex = 0;
            this.radAssigned.TabStop = true;
            this.radAssigned.Text = "Assigned";
            this.radAssigned.UseVisualStyleBackColor = true;
            this.radAssigned.CheckedChanged += new System.EventHandler(this.radAssigned_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(116, 7);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 1;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // olvColPriority
            // 
            this.olvColPriority.AspectName = "Priority";
            this.olvColPriority.Text = "Priority";
            // 
            // FormList_Techs
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormList_Techs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List: Techs";
            ((System.ComponentModel.ISupportInitialize)(this.olvTechs)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlSubControlRight.ResumeLayout(false);
            this.pnlSubControlRight.PerformLayout();
            this.pnlSubControlLeft.ResumeLayout(false);
            this.pnlSubControlLeft.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvTechs;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private BrightIdeasSoftware.OLVColumn olvColTechName;
		private BrightIdeasSoftware.OLVColumn olvColAddress;
		private BrightIdeasSoftware.OLVColumn olvColCity;
		private BrightIdeasSoftware.OLVColumn olvColState;
		private BrightIdeasSoftware.OLVColumn olvColStatus;
		private BrightIdeasSoftware.OLVColumn olvColTech1Name;
		private BrightIdeasSoftware.OLVColumn olvColTech2Name;
		private BrightIdeasSoftware.OLVColumn olvColTech3Name;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Panel pnlSubControlLeft;
		private System.Windows.Forms.Label lblView;
		private System.Windows.Forms.RadioButton radAssigned;
		private System.Windows.Forms.RadioButton radAll;
		private System.Windows.Forms.Label lblTechQty;
		private System.Windows.Forms.TextBox txtTechQty;
		private BrightIdeasSoftware.OLVColumn olvColZip;
		private BrightIdeasSoftware.OLVColumn olvColCountry;
		private BrightIdeasSoftware.OLVColumn olvColTelephone;
		private BrightIdeasSoftware.OLVColumn olvColFax;
		private BrightIdeasSoftware.OLVColumn olvColEmail;
		private BrightIdeasSoftware.OLVColumn olvColRateNormal;
		private BrightIdeasSoftware.OLVColumn olvColRateAfterHours;
		private BrightIdeasSoftware.OLVColumn olvColRateEmergency;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Panel pnlSubControlRight;
        private BrightIdeasSoftware.OLVColumn olvColPriority;
    }
}