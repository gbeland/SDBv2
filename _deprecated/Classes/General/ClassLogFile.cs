using System;
using System.IO;

namespace SDB.Classes.General
{
	public static class ClassLogFile
	{
		private static readonly string _logFile = Path.Combine(GS.Settings.SettingsPath, ClassSettings.LOG_FILE);

		public static void AppendToLog(string message)
		{
			try
			{
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: {1}{2}", DateTime.Now, message, Environment.NewLine));
			}
			catch
			{
			}
		}

		public static void AppendToLog(Exception exc)
		{
			try
			{
				var now = DateTime.Now;
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: Exception at {1}{2}", now, exc.Source.Trim(), Environment.NewLine));
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: \t{1}{2}", now, exc.Message, Environment.NewLine));
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: \t{1}{2}", now, exc.StackTrace, Environment.NewLine));
			}
			catch
			{
			}
		}

		public static void AppendToLog(string message, Exception exc)
		{
			try
			{
				var now = DateTime.Now;
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: {1}{2}", now, message, Environment.NewLine));
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: \tException at {1}{2}", now, exc.Source.Trim(), Environment.NewLine));
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: \t{1}{2}", now, exc.Message, Environment.NewLine));
				File.AppendAllText(_logFile, string.Format("{0:yyyy-MM-dd HH:mm:ss}: \t{1}{2}", now, exc.StackTrace, Environment.NewLine));
			}
			catch
			{
			}
		}
	}
}