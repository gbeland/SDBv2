namespace SDB.MagicInfo.Components
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
            this.btnOpenTicket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAlertType = new System.Windows.Forms.Label();
            this.lblAlertName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenTicket
            // 
            this.btnOpenTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTicket.Location = new System.Drawing.Point(367, 49);
            this.btnOpenTicket.Name = "btnOpenTicket";
            this.btnOpenTicket.Size = new System.Drawing.Size(75, 23);
            this.btnOpenTicket.TabIndex = 0;
            this.btnOpenTicket.Text = "Open Ticket";
            this.btnOpenTicket.UseVisualStyleBackColor = true;
            this.btnOpenTicket.Click += new System.EventHandler(this.btnOpenTicket_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(3, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ignore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAlertType
            // 
            this.lblAlertType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertType.Location = new System.Drawing.Point(-2, 19);
            this.lblAlertType.Name = "lblAlertType";
            this.lblAlertType.Size = new System.Drawing.Size(502, 21);
            this.lblAlertType.TabIndex = 0;
            this.lblAlertType.Text = "Alert: [Type]";
            this.lblAlertType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlertName
            // 
            this.lblAlertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertName.Location = new System.Drawing.Point(-2, -2);
            this.lblAlertName.Name = "lblAlertName";
            this.lblAlertName.Size = new System.Drawing.Size(502, 21);
            this.lblAlertName.TabIndex = 3;
            this.lblAlertName.Text = "Alert: [Type]";
            this.lblAlertName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblAlertName);
            this.Controls.Add(this.lblAlertType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenTicket);
            this.Name = "AlertComponent";
            this.Size = new System.Drawing.Size(460, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTicket;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblAlertType;
        public System.Windows.Forms.Label lblAlertName;
    }
}
