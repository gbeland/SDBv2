using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SDB.Classes.General;
// Do not remove, used in Release mode
// ReSharper disable HeuristicUnreachableCode
#pragma warning disable 162

namespace SDB.Forms.General
{
    public partial class FormUpdateCheck : Form
    {
        private bool _isExitRequired;
		private readonly string _remoteVersionFile = $"http://{GS.Settings.UpdateServer}/appupdate/latestversion.txt";
		private readonly string _remoteSetupFile = $"http://{GS.Settings.UpdateServer}/appupdate/setup.msi";
		private readonly string _localSetupFile = Path.Combine(GS.Settings.SettingsPath, "setup.msi");
		private string _latestVersion;
		private const int _READ_DELAY = 300;
		private const int _ERROR_DELAY = 3000;

        public FormUpdateCheck()
        {
            InitializeComponent();
        }

        private void frmUpdateCheck_Load(object sender, EventArgs e)
        {
            rtfStatus.Text = string.Empty;
            bgwCheck.RunWorkerAsync();
        }

        private void bgwCheck_DoWork(object sender, DoWorkEventArgs e)
        {
	        using (var client = new WebClient())
	        {
		        bgwCheck.ReportProgress(0, $"Database server: {GS.Settings.DBServer}{Environment.NewLine}");
		        bgwCheck.ReportProgress(10, $"Update server: {GS.Settings.UpdateServer}");
		        bgwCheck.ReportProgress(20, string.Format("{0}{0}Running version: {1}", Environment.NewLine, Application.ProductVersion));
		        Thread.Sleep(_READ_DELAY);

		        bgwCheck.ReportProgress(30, string.Format("{0}{0}Checking for updates: ", Environment.NewLine));

		        int versionRelativeToServer;
		        try
		        {
			        using (var stream = client.OpenRead(_remoteVersionFile))
			        {
				        if (stream == null)
				        {
					        bgwCheck.ReportProgress(30, "Failed");
					        bgwCheck.ReportProgress(100, $"{Environment.NewLine}\tCannot determine latest version.");
					        Thread.Sleep(_ERROR_DELAY);
					        return;
				        }
				        using (var sr = new StreamReader(stream))
				        {
					        sr.ReadLine(); // discard first line
					        _latestVersion = sr.ReadLine();
					        sr.Close();
				        }
				        stream.Close();
			        }
			        versionRelativeToServer = ClassUtility.CompareVersions(Application.ProductVersion, _latestVersion);
		        }
		        catch (Exception exc)
		        {
			        bgwCheck.ReportProgress(40, "Failed");
			        bgwCheck.ReportProgress(100, string.Format("{0}\tCannot determine latest version:{0}\t\t{1}", Environment.NewLine, exc.Message));
			        Thread.Sleep(_ERROR_DELAY);
			        return;
		        }

		        if (versionRelativeToServer < 0)
			        HandleUpdateRestart(client);
		        else if (versionRelativeToServer == 0)
			        HandleSameVersion();
		        else
			        HandleOlderVersion();
	        }
        }
		
	    private void HandleUpdateRestart(WebClient client)
	    {
		    bgwCheck.ReportProgress(50, $"{Environment.NewLine}\t{_latestVersion} available!");
		    Thread.Sleep(_READ_DELAY);
#if DEBUG
			return;
#endif
		    bgwCheck.ReportProgress(60, string.Format("{0}{0}Downloading: ", Environment.NewLine));
		    Thread.Sleep(_READ_DELAY);

		    try
		    {
			    if (File.Exists(_localSetupFile))
				    File.Delete(_localSetupFile);

			    client.DownloadFile(_remoteSetupFile, _localSetupFile);
		    }
		    catch (Exception exc)
		    {
			    bgwCheck.ReportProgress(70, "Failed");
			    bgwCheck.ReportProgress(100, string.Format("{0}\tCannot download latest version:{0}\t\t{1}{0}\t\t{2}", Environment.NewLine, exc.Message, exc.InnerException?.Message ?? string.Empty));
			    Thread.Sleep(_ERROR_DELAY);
			    return;
		    }
		    bgwCheck.ReportProgress(70, "Success");

		    bgwCheck.ReportProgress(80, string.Format("{0}{0}Preparing to install update...", Environment.NewLine));
		    bgwCheck.ReportProgress(90, $"{Environment.NewLine}The program will now close and the update will start.");
		    Thread.Sleep(_READ_DELAY);
			Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "msiexec.exe"), $"/package \"{_localSetupFile}\" /passive");
		    bgwCheck.ReportProgress(100, $"{Environment.NewLine}Exiting...");
		    _isExitRequired = true;
	    }

		private void HandleSameVersion()
		{
			bgwCheck.ReportProgress(100, $"{Environment.NewLine}\t{_latestVersion} is current, continuing...");
			Thread.Sleep(_READ_DELAY);
			try
			{
				if (File.Exists(_localSetupFile))
					File.Delete(_localSetupFile);
			}
			catch
			{
				// could not delete setup.msi
			}
		}

		private void HandleOlderVersion()
		{
			bgwCheck.ReportProgress(100, $"{Environment.NewLine}\t{_latestVersion} is older, continuing...");
			Thread.Sleep(_READ_DELAY);
		}

		private void bgwCheck_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
			// Progressbar hack because sliding animation isn't fast enough
			//http://stackoverflow.com/questions/977278/how-can-i-make-the-progress-bar-update-fast-enough/1214147#1214147
			progressBar.Value = e.ProgressPercentage;
			var stepValue = e.ProgressPercentage - 1;
			if (stepValue < 0)
				stepValue = 0;
			progressBar.Value = stepValue;
			progressBar.Value = e.ProgressPercentage;
			rtfStatus.AppendText(e.UserState.ToString());
        }

        private void bgwCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_isExitRequired)
                Application.Exit();
            else
            {
                Application.DoEvents();
                Close();
            }
        }
    }
}