using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.Forms.General
{
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
			cmbDefaultMapZoomLevel.DisplayMember = "Value";
			cmbDefaultMapZoomLevel.ValueMember = "Key";
			cmbDefaultMapZoomLevel.DataSource = new BindingSource(ClassDefinitions.MAP_ZOOM_LEVELS, null);
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			// SERVERS
			txtServer_Server.Text = GS.Settings.DBServer;
			txtServer_Password.Text = GS.Settings.DBPassword;
			txtServer_User.Text = GS.Settings.DBUser;

			numServer_Timeout.Value = GS.Settings.DBTimeout;
			tbxSamsungDBName.Text = GS.Settings.DBName_Samsung;
			txtDBName_Service.Text = GS.Settings.DBName_Service;
			txtDBName_Monitoring.Text = GS.Settings.DBName_Monitoring;

			txtEmail_Server.Text = GS.Settings.EmailServer;
			txtEmail_ServerPort.Text = GS.Settings.EmailServerPort;
			chkEmail_UseSSL.Checked = GS.Settings.EmailUseSSL;
			txtEmail_User.Text = GS.Settings.EmailUser;
			txtEmail_Password.Text = GS.Settings.EmailPassword;

			txtServer_Update.Text = GS.Settings.UpdateServer;

			txtCameraImagePath.Text = GS.Settings.CameraImagePath;

			// EXTERNAL PROGRAMS
			txtDashboardURL.Text = GS.Settings.DashboardWebURL;

			txtVNCPath.Text = GS.Settings.VNCPath;
			tbxRealVNCPath.Text = GS.Settings.RealVNCPath;
			numVNCTimeout.Value = GS.Settings.VNCTimeout;
			txtVNCPasswordWindowTitle.Text = GS.Settings.VNCPasswordWindowTitle;

			txtTeamViewerPath.Text = GS.Settings.TeamviewerPath;

			// PREFERENCES
			radStartupScreen_Tracker.Checked = GS.Settings.StartupMode == ClassSettings.StartupModeEnum.Tracker;
			radStartupScreen_RMA.Checked = GS.Settings.StartupMode == ClassSettings.StartupModeEnum.RMA;
			radStartupScreen_Reports.Checked = GS.Settings.StartupMode == ClassSettings.StartupModeEnum.Reports;
			radStartupScreen_Shipments.Checked = GS.Settings.StartupMode == ClassSettings.StartupModeEnum.Shipments;
			radStartupScreen_MagicInfo.Checked = GS.Settings.StartupMode == ClassSettings.StartupModeEnum.MagicInfo;

			chkCameraCheckEnable.Checked = GS.Settings.CameraCheck_Enable;

			cmbDefaultMapZoomLevel.SelectedValue = GS.Settings.DefaultMapZoomLevel;
			PopulateJournalFontBox(GS.Settings.JournalFont);

			chkAutoSubscribe_Create.Checked = GS.Settings.AutoSubscribe_Create;
			chkAutoSubscribe_Modify.Checked = GS.Settings.AutoSubscribe_Modify;

			//var printers = new Seagull.BarTender.Print.Printers();
			//foreach (var printer in printers)
			//{
			//	cmbRMA_BinLabel_PrinterName.Items.Add(printer.PrinterName);
			//	cmbRMA_ZoneLabel_PrinterName.Items.Add(printer.PrinterName);
			//}

			//if (printers.Any(p => p.PrinterName == GS.Settings.RMA_BinLabel_PrinterName))
			//	cmbRMA_BinLabel_PrinterName.SelectedItem = GS.Settings.RMA_BinLabel_PrinterName;

			//if (printers.Any(p => p.PrinterName == GS.Settings.RMA_ZoneLabel_PrinterName))
			//	cmbRMA_ZoneLabel_PrinterName.SelectedItem = GS.Settings.RMA_ZoneLabel_PrinterName;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// SERVERS
			GS.Settings.DBServer = txtServer_Server.Text;
			GS.Settings.DBPassword = txtServer_Password.Text.Trim();
			GS.Settings.DBUser = txtServer_User.Text.Trim();
			
			GS.Settings.DBTimeout = (int)numServer_Timeout.Value;
            GS.Settings.DBName_Samsung = tbxSamsungDBName.Text.Trim();
			GS.Settings.DBName_Service = txtDBName_Service.Text.Trim();
			GS.Settings.DBName_Monitoring = txtDBName_Monitoring.Text.Trim();

			GS.Settings.EmailServer = txtEmail_Server.Text.Trim();
			GS.Settings.EmailServerPort = txtEmail_ServerPort.Text.Trim();
			GS.Settings.EmailUseSSL = chkEmail_UseSSL.Checked;
			GS.Settings.EmailUser = txtEmail_User.Text.Trim();
			GS.Settings.EmailPassword = txtEmail_Password.Text.Trim();

			GS.Settings.UpdateServer = txtServer_Update.Text.Trim();

			GS.Settings.CameraImagePath = txtCameraImagePath.Text.Trim();

			// EXTERNAL PROGRAMS
			GS.Settings.DashboardWebURL = txtDashboardURL.Text.Trim();

			GS.Settings.VNCPath = txtVNCPath.Text.Trim();
            GS.Settings.RealVNCPath = tbxRealVNCPath.Text.Trim();
			GS.Settings.VNCTimeout = (int)numVNCTimeout.Value;
			GS.Settings.VNCPasswordWindowTitle = txtVNCPasswordWindowTitle.Text.Trim();

			GS.Settings.TeamviewerPath = txtTeamViewerPath.Text.Trim();

			// PREFERENCES
			if (radStartupScreen_Reports.Checked)
				GS.Settings.StartupMode = ClassSettings.StartupModeEnum.Reports;
			else if (radStartupScreen_RMA.Checked)
				GS.Settings.StartupMode = ClassSettings.StartupModeEnum.RMA;
			else if (radStartupScreen_Shipments.Checked)
				GS.Settings.StartupMode = ClassSettings.StartupModeEnum.Shipments;
            else if (radStartupScreen_MagicInfo.Checked)
                GS.Settings.StartupMode = ClassSettings.StartupModeEnum.MagicInfo;
            else
				GS.Settings.StartupMode = ClassSettings.StartupModeEnum.Tracker;

			GS.Settings.CameraCheck_Enable = chkCameraCheckEnable.Checked;

			GS.Settings.DefaultMapZoomLevel = (int)cmbDefaultMapZoomLevel.SelectedValue;
			GS.Settings.JournalFont = txtJournalFont.Font;

			GS.Settings.AutoSubscribe_Create = chkAutoSubscribe_Create.Checked;
			GS.Settings.AutoSubscribe_Modify = chkAutoSubscribe_Modify.Checked;

			if (cmbRMA_BinLabel_PrinterName.SelectedItem != null)
				GS.Settings.RMA_BinLabel_PrinterName = cmbRMA_BinLabel_PrinterName.SelectedItem.ToString();
			if (cmbRMA_ZoneLabel_PrinterName.SelectedItem != null)
				GS.Settings.RMA_ZoneLabel_PrinterName = cmbRMA_ZoneLabel_PrinterName.SelectedItem.ToString();

			GS.Settings.SaveSettings();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void btnVNCPathBrowse_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				ofd.Title = "Select VNC Executable";
				ofd.Filter = "Executable Files (*.exe)|*.exe";
				ofd.InitialDirectory = File.Exists(txtVNCPath.Text) ? Path.GetDirectoryName(txtVNCPath.Text) : Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
				ofd.ShowDialog();
				if (File.Exists(ofd.FileName))
					txtVNCPath.Text = ofd.FileName;
			}
		}

		private void btnTeamViewerPathBrowse_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				ofd.Title = "Select TeamViewer Executable";
				ofd.Filter = "Executable Files (*.exe)|*.exe";
				ofd.InitialDirectory = File.Exists(txtTeamViewerPath.Text) ? Path.GetDirectoryName(txtTeamViewerPath.Text) : Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
				ofd.ShowDialog();
				if (File.Exists(ofd.FileName))
					txtTeamViewerPath.Text = ofd.FileName;
			}
		}

		private void NumericUpDown_Enter(object sender, EventArgs e)
		{
			var numUpDown = (NumericUpDown)sender;
			numUpDown.Select(0, numUpDown.Text.Length);
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			var textBox = (TextBox)sender;
			textBox.SelectAll();
		}

		private void btnCameraImagePath_Click(object sender, EventArgs e)
		{
			using (var folderBrowser = new FolderBrowserDialog())
			{
				folderBrowser.Description = "Select the root folder where Camera Images are stored.";
				folderBrowser.ShowNewFolderButton = false;
				folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
				if (Directory.Exists(GS.Settings.CameraImagePath))
					folderBrowser.SelectedPath = GS.Settings.CameraImagePath;
				if (folderBrowser.ShowDialog() != DialogResult.OK)
					return;
				txtCameraImagePath.Text = folderBrowser.SelectedPath;
			}
		}

		private void btnJournalFont_Change_Click(object sender, EventArgs e)
		{
			using (var fontDialog = new FontDialog())
			{
				try
				{
					fontDialog.Font = txtJournalFont.Font;
				}
				catch
				{
					fontDialog.Font = new Font("MS Sans Serif", 8);
				}
				fontDialog.AllowScriptChange = false;
				fontDialog.AllowVectorFonts = true;
				fontDialog.AllowVerticalFonts = false;
				fontDialog.ShowColor = false;
				fontDialog.ShowEffects = false;
				fontDialog.MinSize = 6;
				fontDialog.MaxSize = 16;

				if (fontDialog.ShowDialog() != DialogResult.OK)
					return;

				PopulateJournalFontBox(fontDialog.Font);
			}
		}

		private void PopulateJournalFontBox(Font font)
		{
			txtJournalFont.Text = $"{font.Name} {font.Style} ({font.Size:0.00} pt)";
			txtJournalFont.Font = font;
		}

        private void btnRealVNCEXE_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Select VNC Executable";
                ofd.Filter = "Executable Files (*.exe)|*.exe";
                ofd.InitialDirectory = File.Exists(tbxRealVNCPath.Text) ? Path.GetDirectoryName(tbxRealVNCPath.Text) : Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                ofd.ShowDialog();
                if (File.Exists(ofd.FileName))
                    tbxRealVNCPath.Text = ofd.FileName;
            }
        }
    }
}