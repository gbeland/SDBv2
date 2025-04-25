namespace SDB.MagicInfo.Components
{
    partial class ActionsComponent
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
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.tblButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnEscalate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnTeamviewer = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.grpActions.SuspendLayout();
            this.tblButtonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpActions
            // 
            this.grpActions.AutoSize = true;
            this.grpActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpActions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpActions.Controls.Add(this.tblButtonLayout);
            this.grpActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActions.Location = new System.Drawing.Point(2, 2);
            this.grpActions.Margin = new System.Windows.Forms.Padding(10);
            this.grpActions.Name = "grpActions";
            this.grpActions.Padding = new System.Windows.Forms.Padding(2);
            this.grpActions.Size = new System.Drawing.Size(225, 177);
            this.grpActions.TabIndex = 0;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // tblButtonLayout
            // 
            this.tblButtonLayout.AutoScroll = true;
            this.tblButtonLayout.AutoSize = true;
            this.tblButtonLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblButtonLayout.ColumnCount = 1;
            this.tblButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtonLayout.Controls.Add(this.btnEscalate, 0, 3);
            this.tblButtonLayout.Controls.Add(this.btnConnect, 0, 0);
            this.tblButtonLayout.Controls.Add(this.btnTeamviewer, 0, 1);
            this.tblButtonLayout.Controls.Add(this.btnDispatch, 0, 2);
            this.tblButtonLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblButtonLayout.Location = new System.Drawing.Point(2, 15);
            this.tblButtonLayout.Name = "tblButtonLayout";
            this.tblButtonLayout.RowCount = 4;
            this.tblButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButtonLayout.Size = new System.Drawing.Size(221, 160);
            this.tblButtonLayout.TabIndex = 0;
            // 
            // btnEscalate
            // 
            this.btnEscalate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEscalate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEscalate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscalate.Image = global::SDB.Properties.Resources.escalate;
            this.btnEscalate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscalate.Location = new System.Drawing.Point(5, 125);
            this.btnEscalate.Margin = new System.Windows.Forms.Padding(5);
            this.btnEscalate.Name = "btnEscalate";
            this.btnEscalate.Size = new System.Drawing.Size(211, 30);
            this.btnEscalate.TabIndex = 14;
            this.btnEscalate.Text = "Escalate";
            this.btnEscalate.UseVisualStyleBackColor = false;
            this.btnEscalate.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.AutoSize = true;
            this.btnConnect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Image = global::SDB.Properties.Resources.magicinfo_logo2;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(5, 5);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(211, 30);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "MagicInfo Server";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTeamviewer
            // 
            this.btnTeamviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeamviewer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTeamviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamviewer.Image = global::SDB.Properties.Resources.teamviewer_icon_16x16;
            this.btnTeamviewer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamviewer.Location = new System.Drawing.Point(5, 45);
            this.btnTeamviewer.Margin = new System.Windows.Forms.Padding(5);
            this.btnTeamviewer.Name = "btnTeamviewer";
            this.btnTeamviewer.Size = new System.Drawing.Size(211, 30);
            this.btnTeamviewer.TabIndex = 11;
            this.btnTeamviewer.Text = "Teamviewer";
            this.btnTeamviewer.UseVisualStyleBackColor = false;
            this.btnTeamviewer.Visible = false;
            // 
            // btnDispatch
            // 
            this.btnDispatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispatch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDispatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatch.Image = global::SDB.Properties.Resources.worker;
            this.btnDispatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDispatch.Location = new System.Drawing.Point(5, 85);
            this.btnDispatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(211, 30);
            this.btnDispatch.TabIndex = 12;
            this.btnDispatch.Text = "Dispatch";
            this.btnDispatch.UseVisualStyleBackColor = false;
            this.btnDispatch.Visible = false;
            // 
            // ActionsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.grpActions);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ActionsComponent";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(229, 233);
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.tblButtonLayout.ResumeLayout(false);
            this.tblButtonLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.TableLayoutPanel tblButtonLayout;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnTeamviewer;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Button btnEscalate;
    }
}
