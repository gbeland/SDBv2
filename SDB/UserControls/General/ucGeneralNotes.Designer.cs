namespace SDB.UserControls.General
{
	partial class ucGeneralNotes
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.pnlGeneralNotes = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAdd.Location = new System.Drawing.Point(0, 277);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(200, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add Note";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlGeneralNotes
			// 
			this.pnlGeneralNotes.AutoScroll = true;
			this.pnlGeneralNotes.BackColor = System.Drawing.Color.White;
			this.pnlGeneralNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGeneralNotes.Location = new System.Drawing.Point(0, 0);
			this.pnlGeneralNotes.Name = "pnlGeneralNotes";
			this.pnlGeneralNotes.Size = new System.Drawing.Size(200, 277);
			this.pnlGeneralNotes.TabIndex = 1;
			// 
			// ucGeneralNotes
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlGeneralNotes);
			this.Controls.Add(this.btnAdd);
			this.DoubleBuffered = true;
			this.Name = "ucGeneralNotes";
			this.Size = new System.Drawing.Size(200, 300);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel pnlGeneralNotes;
	}
}
