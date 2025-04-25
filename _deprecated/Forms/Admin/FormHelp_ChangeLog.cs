using System;
using System.IO;
using System.Windows.Forms;
using SDB.Classes.General;

namespace SDB.Forms.Admin
{
	public partial class FormHelp_ChangeLog : Form
	{
		public FormHelp_ChangeLog()
		{
			InitializeComponent();
		}

		private void FormHelp_ChangeLog_Load(object sender, EventArgs e)
		{
			string changeLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChangeLog.txt");
			try
			{
				rtbChangeLog.Text = File.ReadAllText(changeLogFile);
			}
			catch (Exception exc)
			{
				ClassLogFile.AppendToLog(exc);
				MessageBox.Show(string.Format("The Change Log could not be found/read:{0}{0}{1}", Environment.NewLine, exc.Message), "Change Log Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
		}
	}
}