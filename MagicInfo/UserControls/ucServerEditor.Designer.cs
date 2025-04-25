namespace SDB.MagicInfo.UserControls
{
    partial class ucServerEditor
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
            this.serverComponent1 = new MagicInfo.Components.ServerComponent();
            this.addressComponent1 = new MagicInfo.Components.AddressComponent();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverComponent1
            // 
            this.serverComponent1.Location = new System.Drawing.Point(3, 3);
            this.serverComponent1.Name = "serverComponent1";
            this.serverComponent1.Size = new System.Drawing.Size(546, 161);
            this.serverComponent1.TabIndex = 0;
            // 
            // addressComponent1
            // 
            this.addressComponent1.Location = new System.Drawing.Point(3, 170);
            this.addressComponent1.Name = "addressComponent1";
            this.addressComponent1.Size = new System.Drawing.Size(546, 123);
            this.addressComponent1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucServerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.addressComponent1);
            this.Controls.Add(this.serverComponent1);
            this.Name = "ucServerEditor";
            this.Size = new System.Drawing.Size(559, 329);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ServerComponent serverComponent1;
        private Components.AddressComponent addressComponent1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
