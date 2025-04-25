namespace SDB.Forms.Admin
{
	partial class FormAdmin_Salespeople
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
			this.olvSalespeople = new BrightIdeasSoftware.ObjectListView();
			this.olvColFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.pnlSalespeople_Control = new System.Windows.Forms.Panel();
			this.btnSalesperson_Edit = new System.Windows.Forms.Button();
			this.btnSalesperson_Remove = new System.Windows.Forms.Button();
			this.btnSalesperson_Add = new System.Windows.Forms.Button();
			this.pnlSalespeople = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.olvColLastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColCity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColZip = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColPhone_Office = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColPhone_Mobile = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			((System.ComponentModel.ISupportInitialize)(this.olvSalespeople)).BeginInit();
			this.pnlSalespeople_Control.SuspendLayout();
			this.pnlSalespeople.SuspendLayout();
			this.SuspendLayout();
			// 
			// olvSalespeople
			// 
			this.olvSalespeople.AllColumns.Add(this.olvColFirstName);
			this.olvSalespeople.AllColumns.Add(this.olvColLastName);
			this.olvSalespeople.AllColumns.Add(this.olvColAddress);
			this.olvSalespeople.AllColumns.Add(this.olvColCity);
			this.olvSalespeople.AllColumns.Add(this.olvColState);
			this.olvSalespeople.AllColumns.Add(this.olvColZip);
			this.olvSalespeople.AllColumns.Add(this.olvColCountry);
			this.olvSalespeople.AllColumns.Add(this.olvColEmail);
			this.olvSalespeople.AllColumns.Add(this.olvColPhone_Office);
			this.olvSalespeople.AllColumns.Add(this.olvColPhone_Mobile);
			this.olvSalespeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColFirstName,
            this.olvColLastName,
            this.olvColAddress,
            this.olvColCity,
            this.olvColState,
            this.olvColZip,
            this.olvColCountry,
            this.olvColEmail,
            this.olvColPhone_Office,
            this.olvColPhone_Mobile});
			this.olvSalespeople.Dock = System.Windows.Forms.DockStyle.Fill;
			this.olvSalespeople.FullRowSelect = true;
			this.olvSalespeople.GridLines = true;
			this.olvSalespeople.HasCollapsibleGroups = false;
			this.olvSalespeople.Location = new System.Drawing.Point(0, 30);
			this.olvSalespeople.MultiSelect = false;
			this.olvSalespeople.Name = "olvSalespeople";
			this.olvSalespeople.SelectAllOnControlA = false;
			this.olvSalespeople.SelectColumnsOnRightClick = false;
			this.olvSalespeople.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.olvSalespeople.ShowFilterMenuOnRightClick = false;
			this.olvSalespeople.ShowGroups = false;
			this.olvSalespeople.ShowImagesOnSubItems = true;
			this.olvSalespeople.Size = new System.Drawing.Size(820, 281);
			this.olvSalespeople.TabIndex = 0;
			this.olvSalespeople.UseCompatibleStateImageBehavior = false;
			this.olvSalespeople.View = System.Windows.Forms.View.Details;
			this.olvSalespeople.SelectedIndexChanged += new System.EventHandler(this.olvSalespeople_SelectedIndexChanged);
			this.olvSalespeople.DoubleClick += new System.EventHandler(this.olvSalespeople_DoubleClick);
			// 
			// olvColFirstName
			// 
			this.olvColFirstName.AspectName = "FirstName";
			this.olvColFirstName.Text = "First Name";
			this.olvColFirstName.Width = 120;
			// 
			// pnlSalespeople_Control
			// 
			this.pnlSalespeople_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Edit);
			this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Remove);
			this.pnlSalespeople_Control.Controls.Add(this.btnSalesperson_Add);
			this.pnlSalespeople_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSalespeople_Control.Location = new System.Drawing.Point(0, 0);
			this.pnlSalespeople_Control.Name = "pnlSalespeople_Control";
			this.pnlSalespeople_Control.Size = new System.Drawing.Size(820, 30);
			this.pnlSalespeople_Control.TabIndex = 1;
			// 
			// btnSalesperson_Edit
			// 
			this.btnSalesperson_Edit.BackColor = System.Drawing.SystemColors.Control;
			this.btnSalesperson_Edit.Location = new System.Drawing.Point(297, 3);
			this.btnSalesperson_Edit.Name = "btnSalesperson_Edit";
			this.btnSalesperson_Edit.Size = new System.Drawing.Size(140, 23);
			this.btnSalesperson_Edit.TabIndex = 13;
			this.btnSalesperson_Edit.Text = "Edit Salesperson";
			this.btnSalesperson_Edit.UseVisualStyleBackColor = false;
			this.btnSalesperson_Edit.Click += new System.EventHandler(this.btnSalesperson_Edit_Click);
			// 
			// btnSalesperson_Remove
			// 
			this.btnSalesperson_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnSalesperson_Remove.Location = new System.Drawing.Point(151, 3);
			this.btnSalesperson_Remove.Name = "btnSalesperson_Remove";
			this.btnSalesperson_Remove.Size = new System.Drawing.Size(140, 23);
			this.btnSalesperson_Remove.TabIndex = 3;
			this.btnSalesperson_Remove.Text = "Remove Salesperson";
			this.btnSalesperson_Remove.UseVisualStyleBackColor = false;
			this.btnSalesperson_Remove.Click += new System.EventHandler(this.btnSalesperson_Remove_Click);
			// 
			// btnSalesperson_Add
			// 
			this.btnSalesperson_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSalesperson_Add.Location = new System.Drawing.Point(3, 3);
			this.btnSalesperson_Add.Name = "btnSalesperson_Add";
			this.btnSalesperson_Add.Size = new System.Drawing.Size(140, 23);
			this.btnSalesperson_Add.TabIndex = 2;
			this.btnSalesperson_Add.Text = "Add Salesperson";
			this.btnSalesperson_Add.UseVisualStyleBackColor = false;
			this.btnSalesperson_Add.Click += new System.EventHandler(this.btnSalesperson_Add_Click);
			// 
			// pnlSalespeople
			// 
			this.pnlSalespeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSalespeople.Controls.Add(this.olvSalespeople);
			this.pnlSalespeople.Controls.Add(this.pnlSalespeople_Control);
			this.pnlSalespeople.Location = new System.Drawing.Point(12, 12);
			this.pnlSalespeople.Name = "pnlSalespeople";
			this.pnlSalespeople.Size = new System.Drawing.Size(820, 311);
			this.pnlSalespeople.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(757, 341);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// olvColLastName
			// 
			this.olvColLastName.AspectName = "LastName";
			this.olvColLastName.Text = "Last Name";
			this.olvColLastName.Width = 120;
			// 
			// olvColAddress
			// 
			this.olvColAddress.AspectName = "Address";
			this.olvColAddress.Text = "Address";
			this.olvColAddress.Width = 200;
			// 
			// olvColCity
			// 
			this.olvColCity.AspectName = "City";
			this.olvColCity.Text = "City";
			this.olvColCity.Width = 100;
			// 
			// olvColState
			// 
			this.olvColState.AspectName = "State";
			this.olvColState.Text = "State";
			// 
			// olvColZip
			// 
			this.olvColZip.AspectName = "Zip";
			this.olvColZip.Text = "Zip";
			// 
			// olvColCountry
			// 
			this.olvColCountry.AspectName = "Country";
			this.olvColCountry.Text = "Country";
			this.olvColCountry.Width = 100;
			// 
			// olvColEmail
			// 
			this.olvColEmail.AspectName = "Email";
			this.olvColEmail.Text = "Email";
			this.olvColEmail.Width = 100;
			// 
			// olvColPhone_Office
			// 
			this.olvColPhone_Office.AspectName = "Phone_Office";
			this.olvColPhone_Office.Text = "Office";
			this.olvColPhone_Office.Width = 80;
			// 
			// olvColPhone_Mobile
			// 
			this.olvColPhone_Mobile.AspectName = "Phone_Mobile";
			this.olvColPhone_Mobile.Text = "Mobile";
			this.olvColPhone_Mobile.Width = 80;
			// 
			// FormSalespeople
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(844, 376);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.pnlSalespeople);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormSalespeople";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Salespeople";
			this.Load += new System.EventHandler(this.FormSalespeople_Load);
			((System.ComponentModel.ISupportInitialize)(this.olvSalespeople)).EndInit();
			this.pnlSalespeople_Control.ResumeLayout(false);
			this.pnlSalespeople.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BrightIdeasSoftware.ObjectListView olvSalespeople;
		private System.Windows.Forms.Panel pnlSalespeople_Control;
		private System.Windows.Forms.Panel pnlSalespeople;
		private BrightIdeasSoftware.OLVColumn olvColFirstName;
		private System.Windows.Forms.Button btnSalesperson_Remove;
		private System.Windows.Forms.Button btnSalesperson_Add;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSalesperson_Edit;
		private BrightIdeasSoftware.OLVColumn olvColLastName;
		private BrightIdeasSoftware.OLVColumn olvColAddress;
		private BrightIdeasSoftware.OLVColumn olvColCity;
		private BrightIdeasSoftware.OLVColumn olvColState;
		private BrightIdeasSoftware.OLVColumn olvColZip;
		private BrightIdeasSoftware.OLVColumn olvColCountry;
		private BrightIdeasSoftware.OLVColumn olvColEmail;
		private BrightIdeasSoftware.OLVColumn olvColPhone_Office;
		private BrightIdeasSoftware.OLVColumn olvColPhone_Mobile;
	}
}