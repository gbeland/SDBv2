namespace SDB.Forms.Customer
{
	partial class FormList_Markets
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
			this.olvMarkets = new BrightIdeasSoftware.ObjectListView();
			this.olcCustomerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcMarketName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcTelephone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEmail_Open = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEmail_Close = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEmail_ToS = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcEmail_Rma = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact1_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact1_Position = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact1_Number = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact2_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact2_Position = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact2_Number = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact3_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact3_Position = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olcContact3_Number = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.pnlControl = new System.Windows.Forms.Panel();
			this.btnExport = new System.Windows.Forms.Button();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtMarketQty = new System.Windows.Forms.TextBox();
			this.pnlPagination = new System.Windows.Forms.Panel();
			this.lblPageMax = new System.Windows.Forms.Label();
			this.lblPage = new System.Windows.Forms.Label();
			this.cmbPage = new System.Windows.Forms.ComboBox();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.olvMarkets)).BeginInit();
			this.pnlContainer.SuspendLayout();
			this.pnlControl.SuspendLayout();
			this.pnlPagination.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvMarkets
			// 
			this.olvMarkets.AllColumns.Add(this.olcCustomerName);
			this.olvMarkets.AllColumns.Add(this.olcMarketName);
			this.olvMarkets.AllColumns.Add(this.olcAddress);
			this.olvMarkets.AllColumns.Add(this.olcCity);
			this.olvMarkets.AllColumns.Add(this.olcState);
			this.olvMarkets.AllColumns.Add(this.olcZip);
			this.olvMarkets.AllColumns.Add(this.olcCountry);
			this.olvMarkets.AllColumns.Add(this.olcTelephone);
			this.olvMarkets.AllColumns.Add(this.olcEmail_Open);
			this.olvMarkets.AllColumns.Add(this.olcEmail_Close);
			this.olvMarkets.AllColumns.Add(this.olcEmail_ToS);
			this.olvMarkets.AllColumns.Add(this.olcEmail_Rma);
			this.olvMarkets.AllColumns.Add(this.olcContact1_Name);
			this.olvMarkets.AllColumns.Add(this.olcContact1_Position);
			this.olvMarkets.AllColumns.Add(this.olcContact1_Number);
			this.olvMarkets.AllColumns.Add(this.olcContact2_Name);
			this.olvMarkets.AllColumns.Add(this.olcContact2_Position);
			this.olvMarkets.AllColumns.Add(this.olcContact2_Number);
			this.olvMarkets.AllColumns.Add(this.olcContact3_Name);
			this.olvMarkets.AllColumns.Add(this.olcContact3_Position);
			this.olvMarkets.AllColumns.Add(this.olcContact3_Number);
			this.olvMarkets.AllowColumnReorder = true;
			this.olvMarkets.CellEditUseWholeCell = false;
			this.olvMarkets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olcCustomerName,
            this.olcMarketName,
            this.olcAddress,
            this.olcCity,
            this.olcState,
            this.olcZip,
            this.olcCountry,
            this.olcTelephone,
            this.olcEmail_Open,
            this.olcEmail_Close,
            this.olcEmail_ToS,
            this.olcEmail_Rma,
            this.olcContact1_Name,
            this.olcContact1_Position,
            this.olcContact1_Number,
            this.olcContact2_Name,
            this.olcContact2_Position,
            this.olcContact2_Number,
            this.olcContact3_Name,
            this.olcContact3_Position,
            this.olcContact3_Number});
			this.olvMarkets.Cursor = System.Windows.Forms.Cursors.Default;
			this.olvMarkets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvMarkets.EmptyListMsg = "Please wait...";
			this.olvMarkets.FullRowSelect = true;
			this.olvMarkets.GridLines = true;
			this.olvMarkets.HeaderWordWrap = true;
			this.olvMarkets.Location = new System.Drawing.Point(0, 30);
			this.olvMarkets.MultiSelect = false;
			this.olvMarkets.Name = "olvMarkets";
			this.olvMarkets.RenderNonEditableCheckboxesAsDisabled = true;
			this.olvMarkets.SelectAllOnControlA = false;
			this.olvMarkets.ShowCommandMenuOnRightClick = true;
			this.olvMarkets.ShowImagesOnSubItems = true;
			this.olvMarkets.ShowItemCountOnGroups = true;
			this.olvMarkets.Size = new System.Drawing.Size(960, 571);
			this.olvMarkets.SortGroupItemsByPrimaryColumn = false;
			this.olvMarkets.TabIndex = 0;
			this.olvMarkets.UseCellFormatEvents = true;
			this.olvMarkets.UseCompatibleStateImageBehavior = false;
			this.olvMarkets.UseFilterIndicator = true;
			this.olvMarkets.UseFiltering = true;
			this.olvMarkets.UseSubItemCheckBoxes = true;
			this.olvMarkets.View = System.Windows.Forms.View.Details;
			this.olvMarkets.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.olvMarkets_FormatCell);
			this.olvMarkets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.olvMarkets_MouseDoubleClick);
			// 
			// olcCustomerName
			// 
			this.olcCustomerName.AspectName = "CustomerName";
			this.olcCustomerName.Text = "Customer";
			this.olcCustomerName.Width = 200;
			// 
			// olcMarketName
			// 
			this.olcMarketName.AspectName = "Name";
			this.olcMarketName.Text = "Market";
			this.olcMarketName.Width = 200;
			// 
			// olcAddress
			// 
			this.olcAddress.AspectName = "Address";
			this.olcAddress.Text = "Address";
			this.olcAddress.UseFiltering = false;
			this.olcAddress.Width = 200;
			// 
			// olcCity
			// 
			this.olcCity.AspectName = "City";
			this.olcCity.Text = "City";
			this.olcCity.Width = 90;
			// 
			// olcState
			// 
			this.olcState.AspectName = "State";
			this.olcState.Text = "State";
			this.olcState.Width = 45;
			// 
			// olcZip
			// 
			this.olcZip.AspectName = "Zip";
			this.olcZip.Text = "Zip";
			this.olcZip.UseFiltering = false;
			// 
			// olcCountry
			// 
			this.olcCountry.AspectName = "Country";
			this.olcCountry.Text = "Country";
			this.olcCountry.Width = 100;
			// 
			// olcTelephone
			// 
			this.olcTelephone.AspectName = "Telephone";
			this.olcTelephone.Text = "Telephone";
			this.olcTelephone.UseFiltering = false;
			this.olcTelephone.Width = 80;
			// 
			// olcEmail_Open
			// 
			this.olcEmail_Open.AspectName = "SendEmail_Open";
			this.olcEmail_Open.Text = "Open";
			this.olcEmail_Open.ToolTipText = "Email: Ticket Open";
			// 
			// olcEmail_Close
			// 
			this.olcEmail_Close.AspectName = "SendEmail_Close";
			this.olcEmail_Close.Text = "Close";
			this.olcEmail_Close.ToolTipText = "Email: Ticket Close";
			// 
			// olcEmail_ToS
			// 
			this.olcEmail_ToS.AspectName = "SendEmail_TechOnSite";
			this.olcEmail_ToS.Text = "ToS";
			this.olcEmail_ToS.ToolTipText = "Email: Tech On Site";
			// 
			// olcEmail_Rma
			// 
			this.olcEmail_Rma.AspectName = "SendEmail_RmaCreated";
			this.olcEmail_Rma.Text = "RMA";
			this.olcEmail_Rma.ToolTipText = "Email: RMA Created";
			// 
			// olcContact1_Name
			// 
			this.olcContact1_Name.AspectName = "Contact1_Name";
			this.olcContact1_Name.Text = "Contact 1 Name";
			this.olcContact1_Name.UseFiltering = false;
			this.olcContact1_Name.Width = 150;
			// 
			// olcContact1_Position
			// 
			this.olcContact1_Position.AspectName = "Contact1_Position";
			this.olcContact1_Position.Text = "Contact 1 Position";
			this.olcContact1_Position.UseFiltering = false;
			this.olcContact1_Position.Width = 100;
			// 
			// olcContact1_Number
			// 
			this.olcContact1_Number.AspectName = "Contact1_Number";
			this.olcContact1_Number.Text = "Contact 1 Number";
			this.olcContact1_Number.UseFiltering = false;
			this.olcContact1_Number.Width = 80;
			// 
			// olcContact2_Name
			// 
			this.olcContact2_Name.AspectName = "Contact2_Name";
			this.olcContact2_Name.Text = "Contact 2 Name";
			this.olcContact2_Name.UseFiltering = false;
			this.olcContact2_Name.Width = 150;
			// 
			// olcContact2_Position
			// 
			this.olcContact2_Position.AspectName = "Contact2_Position";
			this.olcContact2_Position.Text = "Contact 2 Position";
			this.olcContact2_Position.UseFiltering = false;
			this.olcContact2_Position.Width = 100;
			// 
			// olcContact2_Number
			// 
			this.olcContact2_Number.AspectName = "Contact2_Number";
			this.olcContact2_Number.Text = "Contact 2 Number";
			this.olcContact2_Number.UseFiltering = false;
			this.olcContact2_Number.Width = 80;
			// 
			// olcContact3_Name
			// 
			this.olcContact3_Name.AspectName = "Contact3_Name";
			this.olcContact3_Name.Text = "Contact 3 Name";
			this.olcContact3_Name.UseFiltering = false;
			this.olcContact3_Name.Width = 150;
			// 
			// olcContact3_Position
			// 
			this.olcContact3_Position.AspectName = "Contact3_Position";
			this.olcContact3_Position.Text = "Contact 3 Position";
			this.olcContact3_Position.UseFiltering = false;
			this.olcContact3_Position.Width = 100;
			// 
			// olcContact3_Number
			// 
			this.olcContact3_Number.AspectName = "Contact3_Number";
			this.olcContact3_Number.Text = "Contact 3 Number";
			this.olcContact3_Number.UseFiltering = false;
			this.olcContact3_Number.Width = 80;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(897, 631);
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
			this.btnCancel.Location = new System.Drawing.Point(816, 631);
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
			this.pnlContainer.Controls.Add(this.olvMarkets);
			this.pnlContainer.Controls.Add(this.pnlControl);
			this.pnlContainer.Location = new System.Drawing.Point(12, 12);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(960, 601);
			this.pnlContainer.TabIndex = 3;
			// 
			// pnlControl
			// 
			this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlControl.Controls.Add(this.btnExport);
			this.pnlControl.Controls.Add(this.lblQty);
			this.pnlControl.Controls.Add(this.txtMarketQty);
			this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlControl.Location = new System.Drawing.Point(0, 0);
			this.pnlControl.Name = "pnlControl";
			this.pnlControl.Size = new System.Drawing.Size(960, 30);
			this.pnlControl.TabIndex = 8;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnExport.Location = new System.Drawing.Point(3, 4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(100, 23);
			this.btnExport.TabIndex = 13;
			this.btnExport.Text = "&Export to file...";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(843, 9);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(48, 13);
			this.lblQty.TabIndex = 7;
			this.lblQty.Text = "Markets:";
			// 
			// txtMarketQty
			// 
			this.txtMarketQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarketQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMarketQty.Location = new System.Drawing.Point(897, 4);
			this.txtMarketQty.Name = "txtMarketQty";
			this.txtMarketQty.ReadOnly = true;
			this.txtMarketQty.Size = new System.Drawing.Size(60, 22);
			this.txtMarketQty.TabIndex = 8;
			this.txtMarketQty.TabStop = false;
			this.txtMarketQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pnlPagination
			// 
			this.pnlPagination.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.pnlPagination.Controls.Add(this.lblPageMax);
			this.pnlPagination.Controls.Add(this.lblPage);
			this.pnlPagination.Controls.Add(this.cmbPage);
			this.pnlPagination.Controls.Add(this.btnLast);
			this.pnlPagination.Controls.Add(this.btnNext);
			this.pnlPagination.Controls.Add(this.btnFirst);
			this.pnlPagination.Controls.Add(this.btnPrevious);
			this.pnlPagination.Location = new System.Drawing.Point(292, 631);
			this.pnlPagination.Name = "pnlPagination";
			this.pnlPagination.Size = new System.Drawing.Size(400, 33);
			this.pnlPagination.TabIndex = 15;
			this.pnlPagination.Visible = false;
			// 
			// lblPageMax
			// 
			this.lblPageMax.AutoSize = true;
			this.lblPageMax.Location = new System.Drawing.Point(235, 10);
			this.lblPageMax.Name = "lblPageMax";
			this.lblPageMax.Size = new System.Drawing.Size(25, 13);
			this.lblPageMax.TabIndex = 15;
			this.lblPageMax.Text = "of 0";
			// 
			// lblPage
			// 
			this.lblPage.AutoSize = true;
			this.lblPage.Location = new System.Drawing.Point(141, 10);
			this.lblPage.Name = "lblPage";
			this.lblPage.Size = new System.Drawing.Size(32, 13);
			this.lblPage.TabIndex = 14;
			this.lblPage.Text = "Page";
			// 
			// cmbPage
			// 
			this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPage.FormattingEnabled = true;
			this.cmbPage.Location = new System.Drawing.Point(179, 7);
			this.cmbPage.Name = "cmbPage";
			this.cmbPage.Size = new System.Drawing.Size(50, 21);
			this.cmbPage.TabIndex = 13;
			this.toolTip1.SetToolTip(this.cmbPage, "Select page");
			this.cmbPage.SelectedIndexChanged += new System.EventHandler(this.cmbPage_SelectedIndexChanged);
			// 
			// btnLast
			// 
			this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnLast.Location = new System.Drawing.Point(347, 5);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(50, 23);
			this.btnLast.TabIndex = 10;
			this.btnLast.Text = ">|";
			this.toolTip1.SetToolTip(this.btnLast, "Last page");
			this.btnLast.UseVisualStyleBackColor = true;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnNext.Location = new System.Drawing.Point(289, 5);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(50, 23);
			this.btnNext.TabIndex = 10;
			this.btnNext.Text = ">";
			this.toolTip1.SetToolTip(this.btnNext, "Next page");
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnFirst.Location = new System.Drawing.Point(5, 5);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(50, 23);
			this.btnFirst.TabIndex = 11;
			this.btnFirst.Text = "|<";
			this.toolTip1.SetToolTip(this.btnFirst, "First page");
			this.btnFirst.UseVisualStyleBackColor = true;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnPrevious.Location = new System.Drawing.Point(63, 5);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(50, 23);
			this.btnPrevious.TabIndex = 11;
			this.btnPrevious.Text = "<";
			this.toolTip1.SetToolTip(this.btnPrevious, "Previous page");
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// FormList_Markets
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(984, 666);
			this.Controls.Add(this.pnlPagination);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "FormList_Markets";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "List: Markets";
			this.Shown += new System.EventHandler(this.FormList_Markets_Shown);
			((System.ComponentModel.ISupportInitialize)(this.olvMarkets)).EndInit();
			this.pnlContainer.ResumeLayout(false);
			this.pnlControl.ResumeLayout(false);
			this.pnlControl.PerformLayout();
			this.pnlPagination.ResumeLayout(false);
			this.pnlPagination.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvMarkets;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private BrightIdeasSoftware.OLVColumn olcCustomerName;
		private BrightIdeasSoftware.OLVColumn olcMarketName;
		private BrightIdeasSoftware.OLVColumn olcAddress;
		private BrightIdeasSoftware.OLVColumn olcCity;
		private BrightIdeasSoftware.OLVColumn olcState;
		private BrightIdeasSoftware.OLVColumn olcZip;
		private BrightIdeasSoftware.OLVColumn olcCountry;
		private BrightIdeasSoftware.OLVColumn olcTelephone;
		private BrightIdeasSoftware.OLVColumn olcEmail_Open;
		private BrightIdeasSoftware.OLVColumn olcEmail_Close;
		private BrightIdeasSoftware.OLVColumn olcEmail_ToS;
		private BrightIdeasSoftware.OLVColumn olcContact1_Name;
		private BrightIdeasSoftware.OLVColumn olcContact1_Position;
		private BrightIdeasSoftware.OLVColumn olcContact1_Number;
		private BrightIdeasSoftware.OLVColumn olcContact2_Name;
		private BrightIdeasSoftware.OLVColumn olcContact2_Position;
		private BrightIdeasSoftware.OLVColumn olcContact2_Number;
		private BrightIdeasSoftware.OLVColumn olcContact3_Name;
		private BrightIdeasSoftware.OLVColumn olcContact3_Position;
		private BrightIdeasSoftware.OLVColumn olcContact3_Number;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Panel pnlControl;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtMarketQty;
		private System.Windows.Forms.Button btnExport;
		private BrightIdeasSoftware.OLVColumn olcEmail_Rma;
		private System.Windows.Forms.Panel pnlPagination;
		private System.Windows.Forms.Label lblPageMax;
		private System.Windows.Forms.Label lblPage;
		private System.Windows.Forms.ComboBox cmbPage;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}