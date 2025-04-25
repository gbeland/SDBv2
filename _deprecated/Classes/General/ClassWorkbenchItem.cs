using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SDB.Classes.General
{
	public class ClassWorkbenchItem
	{
		public string CatalogNumber { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public float UnitCost { get; set; }
		public string PartComponent { get; set; }

		[UsedImplicitly]
		public string DisplayMember => string.Format("{0}  {1}", CatalogNumber, Description);

		public override string ToString()
		{
			return Description;
		}

		public static IEnumerable<ClassWorkbenchItem> GetWorkbenchItems()
		{
			List<ClassWorkbenchItem> workbenchItems = new List<ClassWorkbenchItem>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT *
						FROM workbench_import
						ORDER BY category ASC, description ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							workbenchItems.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return workbenchItems;
		}

		private static ClassWorkbenchItem GetFromReader(MySqlDataReader reader)
		{
			return new ClassWorkbenchItem
				       {
					       CatalogNumber = reader.GetDBString("catalog_number"),
					       Category = reader.GetDBString("category"),
					       Description = reader.GetDBString("description"),
					       UnitCost = reader.GetDBFloat("unit_cost"),
					       PartComponent = reader.GetDBString("part_component")
				       };
		}
	}
}