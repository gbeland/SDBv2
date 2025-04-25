namespace SDB.Forms.Customer
{
    partial class FormCustomerAdvancedEmail
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
            this.olvSymptoms = new BrightIdeasSoftware.ObjectListView();
            this.olvColSymptom = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblExplain = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).BeginInit();
            this.SuspendLayout();
            // 
            // olvSymptoms
            // 
            this.olvSymptoms.AllColumns.Add(this.olvColSymptom);
            this.olvSymptoms.CellEditUseWholeCell = false;
            this.olvSymptoms.CheckBoxes = true;
            this.olvSymptoms.CheckedAspectName = "Selected";
            this.olvSymptoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColSymptom});
            this.olvSymptoms.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSymptoms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.olvSymptoms.EmptyListMsg = "No selectable symptoms.";
            this.olvSymptoms.Enabled = false;
            this.olvSymptoms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvSymptoms.Location = new System.Drawing.Point(0, 107);
            this.olvSymptoms.MultiSelect = false;
            this.olvSymptoms.Name = "olvSymptoms";
            this.olvSymptoms.SelectAllOnControlA = false;
            this.olvSymptoms.ShowFilterMenuOnRightClick = false;
            this.olvSymptoms.ShowGroups = false;
            this.olvSymptoms.Size = new System.Drawing.Size(502, 463);
            this.olvSymptoms.TabIndex = 3;
            this.olvSymptoms.UseCompatibleStateImageBehavior = false;
            this.olvSymptoms.View = System.Windows.Forms.View.Details;
            // 
            // olvColSymptom
            // 
            this.olvColSymptom.AspectName = "Symptom";
            this.olvColSymptom.FillsFreeSpace = true;
            this.olvColSymptom.Groupable = false;
            this.olvColSymptom.Text = "Symptom";
            this.olvColSymptom.Width = 200;
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoEllipsis = true;
            this.lblSymptoms.BackColor = System.Drawing.Color.Black;
            this.lblSymptoms.ForeColor = System.Drawing.Color.White;
            this.lblSymptoms.Location = new System.Drawing.Point(0, 82);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(502, 22);
            this.lblSymptoms.TabIndex = 2;
            this.lblSymptoms.Text = "Symptom(s)";
            this.lblSymptoms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Black;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(205, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(89, 24);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(281, 26);
            this.lblExplain.TabIndex = 5;
            this.lblExplain.Text = "Please enable advanced options and select the symptoms\r\n that you would like the " +
    "customer be emailed on.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCustomerAdvancedEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.olvSymptoms);
            this.Controls.Add(this.lblSymptoms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCustomerAdvancedEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomerAdvancedEmail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.olvSymptoms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvSymptoms;
        private BrightIdeasSoftware.OLVColumn olvColSymptom;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button button1;
    }
}