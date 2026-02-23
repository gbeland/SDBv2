using System;
using System.Threading;
using System.Windows.Forms;
using SDB.Forms.General;
using SDB.Classes.General;

namespace SDB
{
	internal static class Program
	{
		private static Mutex _m;

		[STAThread]
		private static void Main()
		{

            bool ok;
			_m = new Mutex(true, "NOC Service Database", out ok);
			if (!ok)
			{
				MessageBox.Show("Another instance of NOC Service Database is already running.");
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			 
            // Composition Root
            var settingsService = new SettingsService(); 

            Classes.General.GS.LoadSettings();

            using (var splash = new FormSplash())
            {
                Application.Run(splash);
                if (splash.DialogResult == DialogResult.Abort)
                {
                    return;
                }
            }

#if DEBUG
			Application.Run(new FormMain(settingsService));
#else
			try
			{
				Application.Run(new FormMain(settingsService));
			}
			catch (Exception exc)
			{
				MessageBox.Show(string.Format("An error has occured which has caused the program to shut down.{0}{0}{1}", Environment.NewLine, exc), "NOC Service Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
#endif
			GC.KeepAlive(_m);
		}
	}
}