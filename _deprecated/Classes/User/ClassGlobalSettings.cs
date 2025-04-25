namespace SDB.Classes
{
	public static class GS
	{
		public static ClassSettings Settings = new ClassSettings();

		public static void SaveSettings()
		{
			Settings.SaveSettings();
		}

		public static void LoadSettings()
		{
			Settings = Settings.LoadSettings();
		}
	}
}