namespace SDB.MagicInfo.Forms
{
    partial class FormLFDEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLFDEditor));
            this.btnManualSingle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCVSImport = new System.Windows.Forms.Button();
            this.btnServerMultiple = new System.Windows.Forms.Button();
            this.btnServerSingle = new System.Windows.Forms.Button();
            this.ucAddLFDManually1 = new MagicInfo.UserControls.ucLFDEditor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManualSingle
            // 
            this.btnManualSingle.Location = new System.Drawing.Point(445, 83);
            this.btnManualSingle.Name = "btnManualSingle";
            this.btnManualSingle.Size = new System.Drawing.Size(89, 36);
            this.btnManualSingle.TabIndex = 1;
            this.btnManualSingle.Text = "Manually [Single]";
            this.btnManualSingle.UseVisualStyleBackColor = true;
            this.btnManualSingle.Click += new System.EventHandler(this.btnManualSingle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "How would you like to add new LFDs?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCVSImport);
            this.panel1.Controls.Add(this.btnServerMultiple);
            this.panel1.Controls.Add(this.btnServerSingle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnManualSingle);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 133);
            this.panel1.TabIndex = 3;
            // 
            // btnCVSImport
            // 
            this.btnCVSImport.Enabled = false;
            this.btnCVSImport.Location = new System.Drawing.Point(14, 83);
            this.btnCVSImport.Name = "btnCVSImport";
            this.btnCVSImport.Size = new System.Drawing.Size(144, 36);
            this.btnCVSImport.TabIndex = 5;
            this.btnCVSImport.Text = "Import From .cvs File [Multiple]";
            this.btnCVSImport.UseVisualStyleBackColor = true;
            // 
            // btnServerMultiple
            // 
            this.btnServerMultiple.Enabled = false;
            this.btnServerMultiple.Location = new System.Drawing.Point(164, 83);
            this.btnServerMultiple.Name = "btnServerMultiple";
            this.btnServerMultiple.Size = new System.Drawing.Size(144, 36);
            this.btnServerMultiple.TabIndex = 4;
            this.btnServerMultiple.Text = "Import From Server [Multiple]";
            this.btnServerMultiple.UseVisualStyleBackColor = true;
            // 
            // btnServerSingle
            // 
            this.btnServerSingle.Enabled = false;
            this.btnServerSingle.Location = new System.Drawing.Point(314, 83);
            this.btnServerSingle.Name = "btnServerSingle";
            this.btnServerSingle.Size = new System.Drawing.Size(125, 36);
            this.btnServerSingle.TabIndex = 3;
            this.btnServerSingle.Text = "Import From Server [Single]";
            this.btnServerSingle.UseVisualStyleBackColor = true;
            // 
            // ucAddLFDManually1
            // 
            this.ucAddLFDManually1.Location = new System.Drawing.Point(0, 0);
            this.ucAddLFDManually1.Name = "ucAddLFDManually1";
            this.ucAddLFDManually1.Size = new System.Drawing.Size(650, 400);
            this.ucAddLFDManually1.TabIndex = 4;
            this.ucAddLFDManually1.Visible = false;
            // 
            // FormLFDEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucAddLFDManually1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLFDEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LFD Editor";
            this.Shown += new System.EventHandler(this.FormAddLFDToServer_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnManualSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCVSImport;
        private System.Windows.Forms.Button btnServerMultiple;
        private System.Windows.Forms.Button btnServerSingle;
        private MagicInfo.UserControls.ucLFDEditor ucAddLFDManually1;
    }
}