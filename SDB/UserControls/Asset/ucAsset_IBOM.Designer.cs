using SDB.Classes.Misc;

namespace SDB.UserControls.Asset
{
	partial class ucAsset_IBOM
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
			this.pnlIBOM = new System.Windows.Forms.Panel();
			this.pnlInterfaces = new System.Windows.Forms.Panel();
			this.txtInterfaces_EpromType = new System.Windows.Forms.TextBox();
			this.lblInterfaces_EpromType = new System.Windows.Forms.Label();
			this.lblInterfaces = new System.Windows.Forms.Label();
			this.lblInterfaces_EpromFirmwareVersion = new System.Windows.Forms.Label();
			this.txtInterfaces_EpromFirmwareVersion = new System.Windows.Forms.TextBox();
			this.pnlPowerSupplies = new System.Windows.Forms.Panel();
			this.numPS_Voltages_Logic = new ClassFixedNumericUpDown();
			this.lblPowerSupplies = new System.Windows.Forms.Label();
			this.numPS_Voltages_Blue = new ClassFixedNumericUpDown();
			this.txtPS_Assy = new System.Windows.Forms.TextBox();
			this.numPS_Voltages_Green = new ClassFixedNumericUpDown();
			this.lblPS_Voltages_Blue = new System.Windows.Forms.Label();
			this.numPS_Voltages_Red = new ClassFixedNumericUpDown();
			this.lblPS_Voltages_Green = new System.Windows.Forms.Label();
			this.lblPS_Voltages_Logic = new System.Windows.Forms.Label();
			this.lblPS_Voltages = new System.Windows.Forms.Label();
			this.lblPS_Voltage_Red = new System.Windows.Forms.Label();
			this.lblPS_Assy = new System.Windows.Forms.Label();
			this.pnlLedBoards = new System.Windows.Forms.Panel();
			this.txtLED_JobNum = new System.Windows.Forms.TextBox();
			this.lblLED_JobNum = new System.Windows.Forms.Label();
			this.lblLedBoards = new System.Windows.Forms.Label();
			this.lblLED_Assy = new System.Windows.Forms.Label();
			this.txtLED_Calibration = new System.Windows.Forms.TextBox();
			this.lblLED_Calibration = new System.Windows.Forms.Label();
			this.txtLED_Assy = new System.Windows.Forms.TextBox();
			this.lblInterfaces_InterfaceAssembly = new System.Windows.Forms.Label();
			this.txtInterfaces_InterfaceAssembly = new System.Windows.Forms.TextBox();
			this.btnInterfaces_SelectInterfaceAssembly = new System.Windows.Forms.Button();
			this.pnlIBOM.SuspendLayout();
			this.pnlInterfaces.SuspendLayout();
			this.pnlPowerSupplies.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Logic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Blue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Red)).BeginInit();
			this.pnlLedBoards.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlIBOM
			// 
			this.pnlIBOM.AutoScroll = true;
			this.pnlIBOM.Controls.Add(this.pnlInterfaces);
			this.pnlIBOM.Controls.Add(this.pnlPowerSupplies);
			this.pnlIBOM.Controls.Add(this.pnlLedBoards);
			this.pnlIBOM.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlIBOM.Location = new System.Drawing.Point(0, 0);
			this.pnlIBOM.Name = "pnlIBOM";
			this.pnlIBOM.Size = new System.Drawing.Size(620, 280);
			this.pnlIBOM.TabIndex = 0;
			// 
			// pnlInterfaces
			// 
			this.pnlInterfaces.BackColor = System.Drawing.Color.LightGray;
			this.pnlInterfaces.Controls.Add(this.btnInterfaces_SelectInterfaceAssembly);
			this.pnlInterfaces.Controls.Add(this.txtInterfaces_InterfaceAssembly);
			this.pnlInterfaces.Controls.Add(this.lblInterfaces_InterfaceAssembly);
			this.pnlInterfaces.Controls.Add(this.txtInterfaces_EpromType);
			this.pnlInterfaces.Controls.Add(this.lblInterfaces_EpromType);
			this.pnlInterfaces.Controls.Add(this.lblInterfaces);
			this.pnlInterfaces.Controls.Add(this.lblInterfaces_EpromFirmwareVersion);
			this.pnlInterfaces.Controls.Add(this.txtInterfaces_EpromFirmwareVersion);
			this.pnlInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlInterfaces.Location = new System.Drawing.Point(0, 184);
			this.pnlInterfaces.Name = "pnlInterfaces";
			this.pnlInterfaces.Size = new System.Drawing.Size(620, 96);
			this.pnlInterfaces.TabIndex = 6;
			// 
			// txtInterfaces_EpromType
			// 
			this.txtInterfaces_EpromType.Location = new System.Drawing.Point(148, 20);
			this.txtInterfaces_EpromType.MaxLength = 25;
			this.txtInterfaces_EpromType.Name = "txtInterfaces_EpromType";
			this.txtInterfaces_EpromType.Size = new System.Drawing.Size(206, 20);
			this.txtInterfaces_EpromType.TabIndex = 1;
			this.txtInterfaces_EpromType.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblInterfaces_EpromType
			// 
			this.lblInterfaces_EpromType.AutoSize = true;
			this.lblInterfaces_EpromType.Location = new System.Drawing.Point(69, 23);
			this.lblInterfaces_EpromType.Name = "lblInterfaces_EpromType";
			this.lblInterfaces_EpromType.Size = new System.Drawing.Size(73, 13);
			this.lblInterfaces_EpromType.TabIndex = 0;
			this.lblInterfaces_EpromType.Text = "EPROM Type";
			this.lblInterfaces_EpromType.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblInterfaces
			// 
			this.lblInterfaces.AutoEllipsis = true;
			this.lblInterfaces.BackColor = System.Drawing.Color.DimGray;
			this.lblInterfaces.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblInterfaces.ForeColor = System.Drawing.Color.White;
			this.lblInterfaces.Location = new System.Drawing.Point(0, 0);
			this.lblInterfaces.Name = "lblInterfaces";
			this.lblInterfaces.Size = new System.Drawing.Size(620, 17);
			this.lblInterfaces.TabIndex = 0;
			this.lblInterfaces.Text = "Interfaces";
			this.lblInterfaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInterfaces_EpromFirmwareVersion
			// 
			this.lblInterfaces_EpromFirmwareVersion.AutoSize = true;
			this.lblInterfaces_EpromFirmwareVersion.Location = new System.Drawing.Point(11, 43);
			this.lblInterfaces_EpromFirmwareVersion.Name = "lblInterfaces_EpromFirmwareVersion";
			this.lblInterfaces_EpromFirmwareVersion.Size = new System.Drawing.Size(131, 13);
			this.lblInterfaces_EpromFirmwareVersion.TabIndex = 2;
			this.lblInterfaces_EpromFirmwareVersion.Text = "EPROM/Firmware Version";
			this.lblInterfaces_EpromFirmwareVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtInterfaces_EpromFirmwareVersion
			// 
			this.txtInterfaces_EpromFirmwareVersion.Location = new System.Drawing.Point(148, 40);
			this.txtInterfaces_EpromFirmwareVersion.MaxLength = 25;
			this.txtInterfaces_EpromFirmwareVersion.Name = "txtInterfaces_EpromFirmwareVersion";
			this.txtInterfaces_EpromFirmwareVersion.Size = new System.Drawing.Size(206, 20);
			this.txtInterfaces_EpromFirmwareVersion.TabIndex = 3;
			this.txtInterfaces_EpromFirmwareVersion.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// pnlPowerSupplies
			// 
			this.pnlPowerSupplies.BackColor = System.Drawing.Color.LightGray;
			this.pnlPowerSupplies.Controls.Add(this.numPS_Voltages_Logic);
			this.pnlPowerSupplies.Controls.Add(this.lblPowerSupplies);
			this.pnlPowerSupplies.Controls.Add(this.numPS_Voltages_Blue);
			this.pnlPowerSupplies.Controls.Add(this.txtPS_Assy);
			this.pnlPowerSupplies.Controls.Add(this.numPS_Voltages_Green);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Voltages_Blue);
			this.pnlPowerSupplies.Controls.Add(this.numPS_Voltages_Red);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Voltages_Green);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Voltages_Logic);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Voltages);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Voltage_Red);
			this.pnlPowerSupplies.Controls.Add(this.lblPS_Assy);
			this.pnlPowerSupplies.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlPowerSupplies.Location = new System.Drawing.Point(0, 92);
			this.pnlPowerSupplies.Name = "pnlPowerSupplies";
			this.pnlPowerSupplies.Size = new System.Drawing.Size(620, 92);
			this.pnlPowerSupplies.TabIndex = 6;
			// 
			// numPS_Voltages_Logic
			// 
			this.numPS_Voltages_Logic.DecimalPlaces = 2;
			this.numPS_Voltages_Logic.Location = new System.Drawing.Point(478, 47);
			this.numPS_Voltages_Logic.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
			this.numPS_Voltages_Logic.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147352576});
			this.numPS_Voltages_Logic.Name = "numPS_Voltages_Logic";
			this.numPS_Voltages_Logic.Size = new System.Drawing.Size(54, 20);
			this.numPS_Voltages_Logic.TabIndex = 10;
			this.numPS_Voltages_Logic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numPS_Voltages_Logic.Enter += new System.EventHandler(this.NumericUpDown_Enter);
			// 
			// lblPowerSupplies
			// 
			this.lblPowerSupplies.AutoEllipsis = true;
			this.lblPowerSupplies.BackColor = System.Drawing.Color.DimGray;
			this.lblPowerSupplies.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPowerSupplies.ForeColor = System.Drawing.Color.White;
			this.lblPowerSupplies.Location = new System.Drawing.Point(0, 0);
			this.lblPowerSupplies.Name = "lblPowerSupplies";
			this.lblPowerSupplies.Size = new System.Drawing.Size(620, 17);
			this.lblPowerSupplies.TabIndex = 0;
			this.lblPowerSupplies.Text = "Power Supplies";
			this.lblPowerSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numPS_Voltages_Blue
			// 
			this.numPS_Voltages_Blue.DecimalPlaces = 2;
			this.numPS_Voltages_Blue.Location = new System.Drawing.Point(379, 47);
			this.numPS_Voltages_Blue.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
			this.numPS_Voltages_Blue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147352576});
			this.numPS_Voltages_Blue.Name = "numPS_Voltages_Blue";
			this.numPS_Voltages_Blue.Size = new System.Drawing.Size(54, 20);
			this.numPS_Voltages_Blue.TabIndex = 8;
			this.numPS_Voltages_Blue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numPS_Voltages_Blue.Enter += new System.EventHandler(this.NumericUpDown_Enter);
			// 
			// txtPS_Assy
			// 
			this.txtPS_Assy.Location = new System.Drawing.Point(148, 20);
			this.txtPS_Assy.MaxLength = 30;
			this.txtPS_Assy.Name = "txtPS_Assy";
			this.txtPS_Assy.Size = new System.Drawing.Size(246, 20);
			this.txtPS_Assy.TabIndex = 1;
			this.txtPS_Assy.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// numPS_Voltages_Green
			// 
			this.numPS_Voltages_Green.DecimalPlaces = 2;
			this.numPS_Voltages_Green.Location = new System.Drawing.Point(285, 47);
			this.numPS_Voltages_Green.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
			this.numPS_Voltages_Green.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147352576});
			this.numPS_Voltages_Green.Name = "numPS_Voltages_Green";
			this.numPS_Voltages_Green.Size = new System.Drawing.Size(54, 20);
			this.numPS_Voltages_Green.TabIndex = 6;
			this.numPS_Voltages_Green.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numPS_Voltages_Green.Enter += new System.EventHandler(this.NumericUpDown_Enter);
			// 
			// lblPS_Voltages_Blue
			// 
			this.lblPS_Voltages_Blue.AutoSize = true;
			this.lblPS_Voltages_Blue.Location = new System.Drawing.Point(345, 49);
			this.lblPS_Voltages_Blue.Name = "lblPS_Voltages_Blue";
			this.lblPS_Voltages_Blue.Size = new System.Drawing.Size(28, 13);
			this.lblPS_Voltages_Blue.TabIndex = 7;
			this.lblPS_Voltages_Blue.Text = "Blue";
			this.lblPS_Voltages_Blue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// numPS_Voltages_Red
			// 
			this.numPS_Voltages_Red.DecimalPlaces = 2;
			this.numPS_Voltages_Red.Location = new System.Drawing.Point(183, 47);
			this.numPS_Voltages_Red.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
			this.numPS_Voltages_Red.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147352576});
			this.numPS_Voltages_Red.Name = "numPS_Voltages_Red";
			this.numPS_Voltages_Red.Size = new System.Drawing.Size(54, 20);
			this.numPS_Voltages_Red.TabIndex = 4;
			this.numPS_Voltages_Red.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numPS_Voltages_Red.Enter += new System.EventHandler(this.NumericUpDown_Enter);
			// 
			// lblPS_Voltages_Green
			// 
			this.lblPS_Voltages_Green.AutoSize = true;
			this.lblPS_Voltages_Green.Location = new System.Drawing.Point(243, 49);
			this.lblPS_Voltages_Green.Name = "lblPS_Voltages_Green";
			this.lblPS_Voltages_Green.Size = new System.Drawing.Size(36, 13);
			this.lblPS_Voltages_Green.TabIndex = 5;
			this.lblPS_Voltages_Green.Text = "Green";
			this.lblPS_Voltages_Green.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPS_Voltages_Logic
			// 
			this.lblPS_Voltages_Logic.AutoSize = true;
			this.lblPS_Voltages_Logic.Location = new System.Drawing.Point(439, 49);
			this.lblPS_Voltages_Logic.Name = "lblPS_Voltages_Logic";
			this.lblPS_Voltages_Logic.Size = new System.Drawing.Size(33, 13);
			this.lblPS_Voltages_Logic.TabIndex = 9;
			this.lblPS_Voltages_Logic.Text = "Logic";
			this.lblPS_Voltages_Logic.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPS_Voltages
			// 
			this.lblPS_Voltages.AutoSize = true;
			this.lblPS_Voltages.Location = new System.Drawing.Point(96, 49);
			this.lblPS_Voltages.Name = "lblPS_Voltages";
			this.lblPS_Voltages.Size = new System.Drawing.Size(48, 13);
			this.lblPS_Voltages.TabIndex = 2;
			this.lblPS_Voltages.Text = "Voltages";
			this.lblPS_Voltages.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPS_Voltage_Red
			// 
			this.lblPS_Voltage_Red.AutoSize = true;
			this.lblPS_Voltage_Red.Location = new System.Drawing.Point(150, 49);
			this.lblPS_Voltage_Red.Name = "lblPS_Voltage_Red";
			this.lblPS_Voltage_Red.Size = new System.Drawing.Size(27, 13);
			this.lblPS_Voltage_Red.TabIndex = 3;
			this.lblPS_Voltage_Red.Text = "Red";
			this.lblPS_Voltage_Red.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPS_Assy
			// 
			this.lblPS_Assy.AutoSize = true;
			this.lblPS_Assy.Location = new System.Drawing.Point(13, 23);
			this.lblPS_Assy.Name = "lblPS_Assy";
			this.lblPS_Assy.Size = new System.Drawing.Size(129, 13);
			this.lblPS_Assy.TabIndex = 0;
			this.lblPS_Assy.Text = "Power Supply Assembly #";
			this.lblPS_Assy.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pnlLedBoards
			// 
			this.pnlLedBoards.BackColor = System.Drawing.Color.LightGray;
			this.pnlLedBoards.Controls.Add(this.txtLED_JobNum);
			this.pnlLedBoards.Controls.Add(this.lblLED_JobNum);
			this.pnlLedBoards.Controls.Add(this.lblLedBoards);
			this.pnlLedBoards.Controls.Add(this.lblLED_Assy);
			this.pnlLedBoards.Controls.Add(this.txtLED_Calibration);
			this.pnlLedBoards.Controls.Add(this.lblLED_Calibration);
			this.pnlLedBoards.Controls.Add(this.txtLED_Assy);
			this.pnlLedBoards.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLedBoards.Location = new System.Drawing.Point(0, 0);
			this.pnlLedBoards.Name = "pnlLedBoards";
			this.pnlLedBoards.Size = new System.Drawing.Size(620, 92);
			this.pnlLedBoards.TabIndex = 3;
			// 
			// txtLED_JobNum
			// 
			this.txtLED_JobNum.Location = new System.Drawing.Point(148, 20);
			this.txtLED_JobNum.MaxLength = 10;
			this.txtLED_JobNum.Name = "txtLED_JobNum";
			this.txtLED_JobNum.Size = new System.Drawing.Size(86, 20);
			this.txtLED_JobNum.TabIndex = 1;
			this.txtLED_JobNum.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblLED_JobNum
			// 
			this.lblLED_JobNum.AutoSize = true;
			this.lblLED_JobNum.Location = new System.Drawing.Point(84, 23);
			this.lblLED_JobNum.Name = "lblLED_JobNum";
			this.lblLED_JobNum.Size = new System.Drawing.Size(58, 13);
			this.lblLED_JobNum.TabIndex = 0;
			this.lblLED_JobNum.Text = "LED Job #";
			this.lblLED_JobNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblLedBoards
			// 
			this.lblLedBoards.AutoEllipsis = true;
			this.lblLedBoards.BackColor = System.Drawing.Color.DimGray;
			this.lblLedBoards.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblLedBoards.ForeColor = System.Drawing.Color.White;
			this.lblLedBoards.Location = new System.Drawing.Point(0, 0);
			this.lblLedBoards.Name = "lblLedBoards";
			this.lblLedBoards.Size = new System.Drawing.Size(620, 17);
			this.lblLedBoards.TabIndex = 0;
			this.lblLedBoards.Text = "LED Boards";
			this.lblLedBoards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblLED_Assy
			// 
			this.lblLED_Assy.AutoSize = true;
			this.lblLED_Assy.Location = new System.Drawing.Point(57, 43);
			this.lblLED_Assy.Name = "lblLED_Assy";
			this.lblLED_Assy.Size = new System.Drawing.Size(85, 13);
			this.lblLED_Assy.TabIndex = 2;
			this.lblLED_Assy.Text = "LED Assembly #";
			this.lblLED_Assy.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtLED_Calibration
			// 
			this.txtLED_Calibration.Location = new System.Drawing.Point(148, 60);
			this.txtLED_Calibration.MaxLength = 27;
			this.txtLED_Calibration.Name = "txtLED_Calibration";
			this.txtLED_Calibration.Size = new System.Drawing.Size(222, 20);
			this.txtLED_Calibration.TabIndex = 5;
			this.txtLED_Calibration.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblLED_Calibration
			// 
			this.lblLED_Calibration.AutoSize = true;
			this.lblLED_Calibration.Location = new System.Drawing.Point(62, 63);
			this.lblLED_Calibration.Name = "lblLED_Calibration";
			this.lblLED_Calibration.Size = new System.Drawing.Size(80, 13);
			this.lblLED_Calibration.TabIndex = 4;
			this.lblLED_Calibration.Text = "LED Calibration";
			this.lblLED_Calibration.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtLED_Assy
			// 
			this.txtLED_Assy.Location = new System.Drawing.Point(148, 40);
			this.txtLED_Assy.MaxLength = 34;
			this.txtLED_Assy.Name = "txtLED_Assy";
			this.txtLED_Assy.Size = new System.Drawing.Size(278, 20);
			this.txtLED_Assy.TabIndex = 3;
			this.txtLED_Assy.Enter += new System.EventHandler(this.TextBox_Enter);
			// 
			// lblInterfaces_InterfaceAssembly
			// 
			this.lblInterfaces_InterfaceAssembly.AutoSize = true;
			this.lblInterfaces_InterfaceAssembly.Location = new System.Drawing.Point(46, 64);
			this.lblInterfaces_InterfaceAssembly.Name = "lblInterfaces_InterfaceAssembly";
			this.lblInterfaces_InterfaceAssembly.Size = new System.Drawing.Size(96, 13);
			this.lblInterfaces_InterfaceAssembly.TabIndex = 4;
			this.lblInterfaces_InterfaceAssembly.Text = "Interface Assembly";
			this.lblInterfaces_InterfaceAssembly.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtInterfaces_InterfaceAssembly
			// 
			this.txtInterfaces_InterfaceAssembly.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInterfaces_InterfaceAssembly.Location = new System.Drawing.Point(148, 61);
			this.txtInterfaces_InterfaceAssembly.MaxLength = 25;
			this.txtInterfaces_InterfaceAssembly.Name = "txtInterfaces_InterfaceAssembly";
			this.txtInterfaces_InterfaceAssembly.Size = new System.Drawing.Size(388, 20);
			this.txtInterfaces_InterfaceAssembly.TabIndex = 5;
			// 
			// btnInterfaces_SelectInterfaceAssembly
			// 
			this.btnInterfaces_SelectInterfaceAssembly.Location = new System.Drawing.Point(542, 59);
			this.btnInterfaces_SelectInterfaceAssembly.Name = "btnInterfaces_SelectInterfaceAssembly";
			this.btnInterfaces_SelectInterfaceAssembly.Size = new System.Drawing.Size(75, 23);
			this.btnInterfaces_SelectInterfaceAssembly.TabIndex = 6;
			this.btnInterfaces_SelectInterfaceAssembly.Text = "Select...";
			this.btnInterfaces_SelectInterfaceAssembly.UseVisualStyleBackColor = true;
			this.btnInterfaces_SelectInterfaceAssembly.Click += new System.EventHandler(this.btnInterfaces_SelectInterfaceAssembly_Click);
			// 
			// ucAsset_IBOM
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlIBOM);
			this.Name = "ucAsset_IBOM";
			this.Size = new System.Drawing.Size(620, 280);
			this.pnlIBOM.ResumeLayout(false);
			this.pnlInterfaces.ResumeLayout(false);
			this.pnlInterfaces.PerformLayout();
			this.pnlPowerSupplies.ResumeLayout(false);
			this.pnlPowerSupplies.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Logic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Blue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPS_Voltages_Red)).EndInit();
			this.pnlLedBoards.ResumeLayout(false);
			this.pnlLedBoards.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlIBOM;
		private System.Windows.Forms.Label lblPS_Assy;
		private System.Windows.Forms.Label lblPS_Voltages;
		private System.Windows.Forms.Label lblPS_Voltages_Green;
		private System.Windows.Forms.Label lblPS_Voltages_Blue;
		private System.Windows.Forms.TextBox txtPS_Assy;
		private System.Windows.Forms.TextBox txtInterfaces_EpromType;
		private System.Windows.Forms.Label lblInterfaces_EpromType;
		private System.Windows.Forms.Label lblInterfaces_EpromFirmwareVersion;
		private System.Windows.Forms.TextBox txtInterfaces_EpromFirmwareVersion;
		private System.Windows.Forms.TextBox txtLED_JobNum;
		private System.Windows.Forms.Label lblLED_JobNum;
		private System.Windows.Forms.Label lblLED_Assy;
		private System.Windows.Forms.Label lblLED_Calibration;
		private System.Windows.Forms.TextBox txtLED_Assy;
		private System.Windows.Forms.TextBox txtLED_Calibration;
		private System.Windows.Forms.Label lblPS_Voltage_Red;
		private System.Windows.Forms.Label lblPS_Voltages_Logic;
		private ClassFixedNumericUpDown numPS_Voltages_Logic;
		private ClassFixedNumericUpDown numPS_Voltages_Blue;
		private ClassFixedNumericUpDown numPS_Voltages_Green;
		private ClassFixedNumericUpDown numPS_Voltages_Red;
		private System.Windows.Forms.Panel pnlLedBoards;
		private System.Windows.Forms.Label lblLedBoards;
		private System.Windows.Forms.Panel pnlInterfaces;
		private System.Windows.Forms.Label lblInterfaces;
		private System.Windows.Forms.Panel pnlPowerSupplies;
		private System.Windows.Forms.Label lblPowerSupplies;
		private System.Windows.Forms.Label lblInterfaces_InterfaceAssembly;
		private System.Windows.Forms.Button btnInterfaces_SelectInterfaceAssembly;
		private System.Windows.Forms.TextBox txtInterfaces_InterfaceAssembly;
	}
}
