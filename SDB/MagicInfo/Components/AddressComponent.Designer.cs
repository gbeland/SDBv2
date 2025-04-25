namespace SDB.MagicInfo.Components
{
    partial class AddressComponent
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
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.btnAddNewAddress = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.btnFindAddress = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpAddress.Controls.Add(this.btnAddNewAddress);
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.lblZip);
            this.grpAddress.Controls.Add(this.tbxCity);
            this.grpAddress.Controls.Add(this.tbxZip);
            this.grpAddress.Controls.Add(this.tbxStreet);
            this.grpAddress.Controls.Add(this.tbxState);
            this.grpAddress.Controls.Add(this.tbxCountry);
            this.grpAddress.Controls.Add(this.btnFindAddress);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.label8);
            this.grpAddress.Controls.Add(this.lblState);
            this.grpAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(0, 0);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(333, 123);
            this.grpAddress.TabIndex = 7;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // btnAddNewAddress
            // 
            this.btnAddNewAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAddress.Location = new System.Drawing.Point(171, 6);
            this.btnAddNewAddress.Name = "btnAddNewAddress";
            this.btnAddNewAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewAddress.TabIndex = 28;
            this.btnAddNewAddress.Text = "Add New";
            this.btnAddNewAddress.UseVisualStyleBackColor = true;
            this.btnAddNewAddress.Click += new System.EventHandler(this.btnAddNewAddress_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Street:";
            // 
            // lblZip
            // 
            this.lblZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(217, 35);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 23;
            this.lblZip.Text = "Zip:";
            // 
            // tbxCity
            // 
            this.tbxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.Location = new System.Drawing.Point(140, 35);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ReadOnly = true;
            this.tbxCity.Size = new System.Drawing.Size(71, 20);
            this.tbxCity.TabIndex = 16;
            // 
            // tbxZip
            // 
            this.tbxZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZip.Location = new System.Drawing.Point(264, 35);
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.ReadOnly = true;
            this.tbxZip.Size = new System.Drawing.Size(63, 20);
            this.tbxZip.TabIndex = 20;
            // 
            // tbxStreet
            // 
            this.tbxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStreet.Location = new System.Drawing.Point(6, 35);
            this.tbxStreet.Multiline = true;
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.ReadOnly = true;
            this.tbxStreet.Size = new System.Drawing.Size(92, 82);
            this.tbxStreet.TabIndex = 1;
            // 
            // tbxState
            // 
            this.tbxState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxState.Location = new System.Drawing.Point(140, 60);
            this.tbxState.Name = "tbxState";
            this.tbxState.ReadOnly = true;
            this.tbxState.Size = new System.Drawing.Size(71, 20);
            this.tbxState.TabIndex = 18;
            // 
            // tbxCountry
            // 
            this.tbxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCountry.Location = new System.Drawing.Point(264, 60);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.ReadOnly = true;
            this.tbxCountry.Size = new System.Drawing.Size(63, 20);
            this.tbxCountry.TabIndex = 22;
            // 
            // btnFindAddress
            // 
            this.btnFindAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAddress.Enabled = false;
            this.btnFindAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAddress.Location = new System.Drawing.Point(252, 6);
            this.btnFindAddress.Name = "btnFindAddress";
            this.btnFindAddress.Size = new System.Drawing.Size(75, 23);
            this.btnFindAddress.TabIndex = 0;
            this.btnFindAddress.Text = "Find Existing";
            this.btnFindAddress.UseVisualStyleBackColor = true;
            this.btnFindAddress.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(104, 38);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City: ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Country:";
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(99, 67);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State:";
            // 
            // AddressComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpAddress);
            this.Name = "AddressComponent";
            this.Size = new System.Drawing.Size(333, 123);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Button btnFindAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblState;
        public System.Windows.Forms.TextBox tbxCity;
        public System.Windows.Forms.TextBox tbxZip;
        public System.Windows.Forms.TextBox tbxStreet;
        public System.Windows.Forms.TextBox tbxState;
        public System.Windows.Forms.TextBox tbxCountry;
        public System.Windows.Forms.GroupBox grpAddress;
    }
}
