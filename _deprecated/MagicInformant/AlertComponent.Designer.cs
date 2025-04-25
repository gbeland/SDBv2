namespace MagicInformant
{
    partial class AlertComponent
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
            this.lblAlertData = new System.Windows.Forms.Label();
            this.lblAlertName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlertData
            // 
            this.lblAlertData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlertData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertData.Location = new System.Drawing.Point(-2, 19);
            this.lblAlertData.Name = "lblAlertData";
            this.lblAlertData.Size = new System.Drawing.Size(250, 50);
            this.lblAlertData.TabIndex = 0;
            this.lblAlertData.Text = "Alert: [Type]";
            this.lblAlertData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlertName
            // 
            this.lblAlertName.BackColor = System.Drawing.Color.Black;
            this.lblAlertName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlertName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAlertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlertName.Location = new System.Drawing.Point(0, 0);
            this.lblAlertName.Name = "lblAlertName";
            this.lblAlertName.Size = new System.Drawing.Size(248, 21);
            this.lblAlertName.TabIndex = 3;
            this.lblAlertName.Text = "NAME";
            this.lblAlertName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblAlertName);
            this.Controls.Add(this.lblAlertData);
            this.Name = "AlertComponent";
            this.Size = new System.Drawing.Size(248, 69);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblAlertData;
        public System.Windows.Forms.Label lblAlertName;
    }
}
