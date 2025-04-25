namespace SDB.Forms.Asset
{
    partial class FormAsset_Document_New
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDocumentLink = new System.Windows.Forms.TextBox();
            this.lblExample = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(180, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(286, 26);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "This window is for adding a link to a document.\r\nAccepted format are website URL " +
    "or network drive file path\r\n";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(5, 138);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(92, 13);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "Document Link";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(561, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(5, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(103, 110);
            this.tbxName.MaxLength = 255;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(533, 20);
            this.tbxName.TabIndex = 6;
            // 
            // tbxDocumentLink
            // 
            this.tbxDocumentLink.Location = new System.Drawing.Point(103, 135);
            this.tbxDocumentLink.MaxLength = 255;
            this.tbxDocumentLink.Name = "tbxDocumentLink";
            this.tbxDocumentLink.Size = new System.Drawing.Size(533, 20);
            this.tbxDocumentLink.TabIndex = 7;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Location = new System.Drawing.Point(100, 52);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(347, 52);
            this.lblExample.TabIndex = 8;
            this.lblExample.Text = "Network Drive Format: file://[Drive IP]/[File Path]\r\n\r\nExample:\r\nfile://192.168.9" +
    "0.3/Users/1-Packet/Sample%20Box%20Label%201.doc";
            // 
            // FormAsset_Document_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 192);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.tbxDocumentLink);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAsset_Document_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asset Documents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDocumentLink;
        private System.Windows.Forms.Label lblExample;
    }
}