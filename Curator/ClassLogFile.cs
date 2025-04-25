using System;
using System.IO;

namespace Curator
{
	internal static class ClassLogFile
	{
		public static readonly string LOG_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"SEA\NOC Service Database");
		public const string LOG_FILENAME = @"curator.log";

		public static void AddEntry(string entry)
		{
			string entryLine = string.Format("{0:yyyy-MM-dd HH:mm:ss}:  {1}{2}", DateTime.Now, entry, Environment.NewLine);
			try
			{
				File.AppendAllText(Path.Combine(LOG_PATH, LOG_FILENAME), entryLine);
			}
			catch
			{
			}
		}
	}
}