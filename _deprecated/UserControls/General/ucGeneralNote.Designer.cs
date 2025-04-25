namespace SDB.UserControls.General
{
	partial class ucGeneralNote
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
			this.components = new System.ComponentModel.Container();
			this.lblDateTime = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDateTime
			// 
			this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateTime.ForeColor = System.Drawing.Color.DarkBlue;
			this.lblDateTime.Location = new System.Drawing.Point(0, 0);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(91, 16);
			this.lblDateTime.TabIndex = 2;
			this.lblDateTime.Text = "2011-01-01 23:59";
			this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblUser
			// 
			this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.Color.Green;
			this.lblUser.Location = new System.Drawing.Point(91, 0);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(61, 16);
			this.lblUser.TabIndex = 4;
			this.lblUser.Text = "User";
			this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pnlHeader.Controls.Add(this.lblUser);
			this.pnlHeader.Controls.Add(this.lblDateTime);
			this.pnlHeader.Controls.Add(this.btnDelete);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(4, 4);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(172, 16);
			this.pnlHeader.TabIndex = 5;
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
			this.btnDelete.Location = new System.Drawing.Point(152, 0);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(20, 16);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "X";
			this.toolTip1.SetToolTip(this.btnDelete, "Delete this note.");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// txtNote
			// 
			this.txtNote.BackColor = System.Drawing.Color.White;
			this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtNote.Location = new System.Drawing.Point(4, 20);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ReadOnly = true;
			this.txtNote.Size = new System.Drawing.Size(172, 20);
			this.txtNote.TabIndex = 3;
			// 
			// ucGeneralNote
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.pnlHeader);
			this.Name = "ucGeneralNote";
			this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
			this.Size = new System.Drawing.Size(180, 40);
			this.ClientSizeChanged += new System.EventHandler(this.ucGeneralNote_ClientSizeChanged);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDateTime;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Panel pnlHeader;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
