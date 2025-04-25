using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Restart
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void Restart_Load(object sender, EventArgs e)
        {
			Application.Idle += Application_Idle;
        }

		void Application_Idle(object sender, EventArgs e)
		{
			Application.Idle -= Application_Idle;
			Thread.Sleep(500);
			Process.Start(Path.Combine(Application.ExecutablePath, "SDB.exe"));
			Close();
		}
    }
}