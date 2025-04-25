namespace SDB.UserControls
{
    partial class ucRMADetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRMANum = new System.Windows.Forms.Label();
            this.tbxRMANum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStatus = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCreationNote = new System.Windows.Forms.Label();
            this.tbxCreationNote = new System.Windows.Forms.TextBox();
            this.tbxAssignedTo = new System.Windows.Forms.TextBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.cbxHot = new System.Windows.Forms.CheckBox();
            this.cbxAPR = new System.Windows.Forms.CheckBox();
            this.tbxJobPO = new System.Windows.Forms.TextBox();
            this.lblJobPO = new System.Windows.Forms.Label();
            this.tbxCreatedDate = new System.Windows.Forms.TextBox();
            this.tbxCreatedBy = new System.Windows.Forms.TextBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 23);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RMA Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRMANum
            // 
            this.lblRMANum.AutoSize = true;
            this.lblRMANum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMANum.Location = new System.Drawing.Point(14, 26);
            this.lblRMANum.Name = "lblRMANum";
            this.lblRMANum.Size = new System.Drawing.Size(61, 24);
            this.lblRMANum.TabIndex = 1;
            this.lblRMANum.Text = "RMA:";
            // 
            // tbxRMANum
            // 
            this.tbxRMANum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRMANum.Location = new System.Drawing.Point(81, 26);
            this.tbxRMANum.Name = "tbxRMANum";
            this.tbxRMANum.Size = new System.Drawing.Size(174, 26);
            this.tbxRMANum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // tbxStatus
            // 
            this.tbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStatus.Location = new System.Drawing.Point(81, 58);
            this.tbxStatus.Name = "tbxStatus";
            this.tbxStatus.Size = new System.Drawing.Size(174, 26);
            this.tbxStatus.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCreationNote);
            this.panel2.Controls.Add(this.tbxCreationNote);
            this.panel2.Controls.Add(this.tbxAssignedTo);
            this.panel2.Controls.Add(this.lblAssignedTo);
            this.panel2.Controls.Add(this.cbxHot);
            this.panel2.Controls.Add(this.cbxAPR);
            this.panel2.Controls.Add(this.tbxJobPO);
            this.panel2.Controls.Add(this.lblJobPO);
            this.panel2.Controls.Add(this.tbxCreatedDate);
            this.panel2.Controls.Add(this.tbxCreatedBy);
            this.panel2.Controls.Add(this.lblCreatedBy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 189);
            this.panel2.TabIndex = 6;
            // 
            // lblCreationNote
            // 
            this.lblCreationNote.AutoSize = true;
            this.lblCreationNote.Location = new System.Drawing.Point(5, 111);
            this.lblCreationNote.Name = "lblCreationNote";
            this.lblCreationNote.Size = new System.Drawing.Size(75, 13);
            this.lblCreationNote.TabIndex = 10;
            this.lblCreationNote.Text = "Creation Note:";
            // 
            // tbxCreationNote
            // 
            this.tbxCreationNote.Location = new System.Drawing.Point(6, 127);
            this.tbxCreationNote.Multiline = true;
            this.tbxCreationNote.Name = "tbxCreationNote";
            this.tbxCreationNote.Size = new System.Drawing.Size(248, 57);
            this.tbxCreationNote.TabIndex = 9;
            // 
            // tbxAssignedTo
            // 
            this.tbxAssignedTo.Location = new System.Drawing.Point(79, 55);
            this.tbxAssignedTo.Name = "tbxAssignedTo";
            this.tbxAssignedTo.Size = new System.Drawing.Size(175, 20);
            this.tbxAssignedTo.TabIndex = 8;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(5, 58);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(69, 13);
            this.lblAssignedTo.TabIndex = 7;
            this.lblAssignedTo.Text = "Assigned To:";
            // 
            // cbxHot
            // 
            this.cbxHot.AutoSize = true;
            this.cbxHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHot.Location = new System.Drawing.Point(73, 84);
            this.cbxHot.Name = "cbxHot";
            this.cbxHot.Size = new System.Drawing.Size(51, 24);
            this.cbxHot.TabIndex = 6;
            this.cbxHot.Text = "Hot";
            this.cbxHot.UseVisualStyleBackColor = true;
            // 
            // cbxAPR
            // 
            this.cbxAPR.AutoSize = true;
            this.cbxAPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAPR.Location = new System.Drawing.Point(8, 84);
            this.cbxAPR.Name = "cbxAPR";
            this.cbxAPR.Size = new System.Drawing.Size(58, 24);
            this.cbxAPR.TabIndex = 5;
            this.cbxAPR.Text = "APR";
            this.cbxAPR.UseVisualStyleBackColor = true;
            // 
            // tbxJobPO
            // 
            this.tbxJobPO.Location = new System.Drawing.Point(80, 31);
            this.tbxJobPO.Name = "tbxJobPO";
            this.tbxJobPO.Size = new System.Drawing.Size(174, 20);
            this.tbxJobPO.TabIndex = 4;
            // 
            // lblJobPO
            // 
            this.lblJobPO.AutoSize = true;
            this.lblJobPO.Location = new System.Drawing.Point(47, 34);
            this.lblJobPO.Name = "lblJobPO";
            this.lblJobPO.Size = new System.Drawing.Size(27, 13);
            this.lblJobPO.TabIndex = 3;
            this.lblJobPO.Text = "Job:";
            // 
            // tbxCreatedDate
            // 
            this.tbxCreatedDate.Location = new System.Drawing.Point(181, 7);
            this.tbxCreatedDate.Name = "tbxCreatedDate";
            this.tbxCreatedDate.Size = new System.Drawing.Size(73, 20);
            this.tbxCreatedDate.TabIndex = 2;
            // 
            // tbxCreatedBy
            // 
            this.tbxCreatedBy.Location = new System.Drawing.Point(80, 7);
            this.tbxCreatedBy.Name = "tbxCreatedBy";
            this.tbxCreatedBy.Size = new System.Drawing.Size(95, 20);
            this.tbxCreatedBy.TabIndex = 1;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(12, 10);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(62, 13);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // ucRMADetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxRMANum);
            this.Controls.Add(this.lblRMANum);
            this.Controls.Add(this.panel1);
            this.Name = "ucRMADetails";
            this.Size = new System.Drawing.Size(260, 279);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRMANum;
        private System.Windows.Forms.TextBox tbxRMANum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxAssignedTo;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.CheckBox cbxHot;
        private System.Windows.Forms.CheckBox cbxAPR;
        private System.Windows.Forms.TextBox tbxJobPO;
        private System.Windows.Forms.Label lblJobPO;
        private System.Windows.Forms.TextBox tbxCreatedDate;
        private System.Windows.Forms.TextBox tbxCreatedBy;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblCreationNote;
        private System.Windows.Forms.TextBox tbxCreationNote;
    }
}
