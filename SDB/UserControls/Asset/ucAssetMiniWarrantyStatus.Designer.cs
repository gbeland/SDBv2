namespace SDB.UserControls.Asset
{
	partial class MiniWarrantyStatus
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
            this.lblContract = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblLaborWarranty = new System.Windows.Forms.Label();
            this.lblPartsWarranty = new System.Windows.Forms.Label();
            this.lblPartsContract = new System.Windows.Forms.Label();
            this.lblLaborContract = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblCradlepoint = new System.Windows.Forms.Label();
            this.lblCreative_c = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContract
            // 
            this.lblContract.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblContract.Location = new System.Drawing.Point(0, 33);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(14, 20);
            this.lblContract.TabIndex = 7;
            this.lblContract.Text = "C";
            this.lblContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWarranty
            // 
            this.lblWarranty.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWarranty.Location = new System.Drawing.Point(0, 13);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(14, 20);
            this.lblWarranty.TabIndex = 6;
            this.lblWarranty.Text = "W";
            this.lblWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParts
            // 
            this.lblParts.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblParts.Location = new System.Drawing.Point(34, 0);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(20, 14);
            this.lblParts.TabIndex = 5;
            this.lblParts.Text = "P";
            this.lblParts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblLabor
            // 
            this.lblLabor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblLabor.Location = new System.Drawing.Point(14, 0);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(20, 14);
            this.lblLabor.TabIndex = 4;
            this.lblLabor.Text = "L";
            this.lblLabor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblLaborWarranty
            // 
            this.lblLaborWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborWarranty.Location = new System.Drawing.Point(14, 13);
            this.lblLaborWarranty.Name = "lblLaborWarranty";
            this.lblLaborWarranty.Size = new System.Drawing.Size(20, 20);
            this.lblLaborWarranty.TabIndex = 8;
            this.lblLaborWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblLaborWarranty, "Unknown");
            this.lblLaborWarranty.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblPartsWarranty
            // 
            this.lblPartsWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartsWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsWarranty.Location = new System.Drawing.Point(34, 13);
            this.lblPartsWarranty.Name = "lblPartsWarranty";
            this.lblPartsWarranty.Size = new System.Drawing.Size(20, 20);
            this.lblPartsWarranty.TabIndex = 9;
            this.lblPartsWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblPartsWarranty, "Unknown");
            this.lblPartsWarranty.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblPartsContract
            // 
            this.lblPartsContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartsContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsContract.Location = new System.Drawing.Point(34, 33);
            this.lblPartsContract.Name = "lblPartsContract";
            this.lblPartsContract.Size = new System.Drawing.Size(20, 20);
            this.lblPartsContract.TabIndex = 11;
            this.lblPartsContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblPartsContract, "Unknown");
            this.lblPartsContract.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblLaborContract
            // 
            this.lblLaborContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaborContract.Location = new System.Drawing.Point(14, 33);
            this.lblLaborContract.Name = "lblLaborContract";
            this.lblLaborContract.Size = new System.Drawing.Size(20, 20);
            this.lblLaborContract.TabIndex = 10;
            this.lblLaborContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lblLaborContract, "Unknown");
            this.lblLaborContract.Click += new System.EventHandler(this.lbl_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 100;
            // 
            // lblCradlepoint
            // 
            this.lblCradlepoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCradlepoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCradlepoint.Location = new System.Drawing.Point(60, 34);
            this.lblCradlepoint.Name = "lblCradlepoint";
            this.lblCradlepoint.Size = new System.Drawing.Size(30, 20);
            this.lblCradlepoint.TabIndex = 12;
            this.lblCradlepoint.Text = "Cp";
            this.lblCradlepoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lblCradlepoint, "Unknown");
            // 
            // lblCreative_c
            // 
            this.lblCreative_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreative_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreative_c.Location = new System.Drawing.Point(60, 14);
            this.lblCreative_c.Name = "lblCreative_c";
            this.lblCreative_c.Size = new System.Drawing.Size(30, 20);
            this.lblCreative_c.TabIndex = 13;
            this.lblCreative_c.Text = "Cr";
            this.lblCreative_c.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lblCreative_c, "Unknown");
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(60, -1);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 14;
            this.lblExtra.Text = "Extra";
            // 
            // MiniWarrantyStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblCreative_c);
            this.Controls.Add(this.lblCradlepoint);
            this.Controls.Add(this.lblPartsContract);
            this.Controls.Add(this.lblLaborContract);
            this.Controls.Add(this.lblPartsWarranty);
            this.Controls.Add(this.lblLaborWarranty);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblLabor);
            this.Name = "MiniWarrantyStatus";
            this.Size = new System.Drawing.Size(93, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblContract;
		private System.Windows.Forms.Label lblWarranty;
		private System.Windows.Forms.Label lblParts;
		private System.Windows.Forms.Label lblLabor;
		private System.Windows.Forms.Label lblLaborWarranty;
		private System.Windows.Forms.Label lblPartsWarranty;
		private System.Windows.Forms.Label lblPartsContract;
		private System.Windows.Forms.Label lblLaborContract;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblCradlepoint;
        private System.Windows.Forms.Label lblCreative_c;
        private System.Windows.Forms.Label lblExtra;
    }
}
