using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDB.Forms.CameraCheck
{
	public partial class FormCameraCheck_Log : Form
	{
		private readonly Queue<string> _log = new Queue<string>();

		public FormCameraCheck_Log()
		{
			InitializeComponent();
		}

		public void AddToLog(string s)
		{
			_log.Enqueue(s);
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			while (_log.Count > 0)
			{
				var line = _log.Dequeue() + Environment.NewLine;
				rtbLog.AppendText(line);
			}
		}

		public void Clear()
		{
			_log.Clear();
			rtbLog.Clear();
		}
	}
}