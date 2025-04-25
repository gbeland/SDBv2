namespace SDB.MagicInfo.UserControls
{
    partial class ucMarketEditor
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
            this.addressComponent1 = new MagicInfo.Components.AddressComponent();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.marketComponent1 = new MagicInfo.Components.MarketComponent();
            this.SuspendLayout();
            // 
            // addressComponent1
            // 
            this.addressComponent1.Location = new System.Drawing.Point(271, 29);
            this.addressComponent1.Name = "addressComponent1";
            this.addressComponent1.Size = new System.Drawing.Size(330, 123);
            this.addressComponent1.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 158);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add Customer Information";
            // 
            // marketComponent1
            // 
            this.marketComponent1.Location = new System.Drawing.Point(3, 29);
            this.marketComponent1.Name = "marketComponent1";
            this.marketComponent1.Size = new System.Drawing.Size(262, 123);
            this.marketComponent1.TabIndex = 39;
            // 
            // ucMarketEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.marketComponent1);
            this.Controls.Add(this.addressComponent1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "ucMarketEditor";
            this.Size = new System.Drawing.Size(606, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.AddressComponent addressComponent1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private Components.MarketComponent marketComponent1;
    }
}
