using System.Collections.Generic;
using System.Drawing;
using SDB.Classes.Tech;

namespace SDB.Classes.General
{
	public static class ClassDefinitions
	{
		public const string PASSWORD_ENCODE_SALT = @"YESco1DATAbase07";

		public static readonly Dictionary<int, string> PRIORITY_TYPES = new Dictionary<int, string>
			                                                               {
				                                                               {1, "2 Days"},
				                                                               {2, "5 Days"},
				                                                               {3, "15 Days"},
				                                                               {4, "No Priority"},
				                                                               {5, ""}
			                                                               };

		public static readonly ClassTech_Status[] TECH_STATUS_TYPES = {
				                                                            new ClassTech_Status {Value = null, Color = Color.Gray, Description = "No Status"},
				                                                            new ClassTech_Status {Value = 0, Color = Color.DarkGreen, Description = "Trained"},
				                                                            new ClassTech_Status {Value = 1, Color = Color.Red, Description = "Untrained"},
				                                                            new ClassTech_Status {Value = 2, Color = Color.Goldenrod, Description = "OEM"},
				                                                            new ClassTech_Status {Value = 3, Color = Color.Black, Description = "Do Not Use"}
			                                                            };

		/// <summary>
		/// Google map zoom levels: "State" = 6, "City" = 13, "Street" = 17
		/// Actual accepted zoom levels are 0-21.
		/// </summary>
		public static readonly Dictionary<int, string> MAP_ZOOM_LEVELS = new Dictionary<int, string>
			                                                               {
				                                                               {6, "State/Province Level"},
				                                                               {13, "City Level"},
				                                                               {17, "Street Level"}
			                                                               };
	}
}