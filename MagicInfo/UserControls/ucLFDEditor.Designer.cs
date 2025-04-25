namespace SDB.MagicInfo.UserControls
{
    partial class ucLFDEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.addressComponent1 = new MagicInfo.Components.AddressComponent();
            this.assetComponent1 = new MagicInfo.Components.AssetComponent();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Add Information";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(565, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 374);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addressComponent1
            // 
            this.addressComponent1.Location = new System.Drawing.Point(10, 227);
            this.addressComponent1.Name = "addressComponent1";
            this.addressComponent1.Size = new System.Drawing.Size(333, 123);
            this.addressComponent1.TabIndex = 11;
            // 
            // assetComponent1
            // 
            this.assetComponent1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.assetComponent1.Location = new System.Drawing.Point(3, 34);
            this.assetComponent1.Name = "assetComponent1";
            this.assetComponent1.Size = new System.Drawing.Size(637, 334);
            this.assetComponent1.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 400);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // ucLFDEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.addressComponent1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.assetComponent1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "ucLFDEditor";
            this.Size = new System.Drawing.Size(650, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private Components.AddressComponent addressComponent1;
        private Components.AssetComponent assetComponent1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
    }
}
