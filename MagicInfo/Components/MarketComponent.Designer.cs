namespace SDB.MagicInfo.Components
{
    partial class MarketComponent
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
            this.grpMarketInfo = new System.Windows.Forms.GroupBox();
            this.tbxTag = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMarketInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMarketInfo
            // 
            this.grpMarketInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpMarketInfo.Controls.Add(this.tbxTag);
            this.grpMarketInfo.Controls.Add(this.tbxName);
            this.grpMarketInfo.Controls.Add(this.label3);
            this.grpMarketInfo.Controls.Add(this.label2);
            this.grpMarketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMarketInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMarketInfo.Location = new System.Drawing.Point(0, 0);
            this.grpMarketInfo.Name = "grpMarketInfo";
            this.grpMarketInfo.Size = new System.Drawing.Size(275, 94);
            this.grpMarketInfo.TabIndex = 31;
            this.grpMarketInfo.TabStop = false;
            this.grpMarketInfo.Text = "Market Info";
            // 
            // tbxTag
            // 
            this.tbxTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTag.Location = new System.Drawing.Point(50, 47);
            this.tbxTag.Name = "tbxTag";
            this.tbxTag.ReadOnly = true;
            this.tbxTag.Size = new System.Drawing.Size(194, 20);
            this.tbxTag.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(50, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(194, 20);
            this.tbxName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // MarketComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMarketInfo);
            this.Name = "MarketComponent";
            this.Size = new System.Drawing.Size(275, 94);
            this.grpMarketInfo.ResumeLayout(false);
            this.grpMarketInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMarketInfo;
        private System.Windows.Forms.TextBox tbxTag;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
