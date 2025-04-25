using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	/// <summary>
	/// Preventive Maintenance Action: Items that can be managed for the tech-on-site preventive maintenance checklist.
	/// </summary>
	public class ClassPreventiveMaintenanceAction
	{
		public int ID { get; set; }
		public string Description { get; set; }

		/// <summary>
		/// Used for indicating completed items when shown as a checklist.
		/// </summary>
		public bool Completed { get; set; }

		public static IEnumerable<ClassPreventiveMaintenanceAction> GetPreventiveMaintenanceActions()
		{
			List<ClassPreventiveMaintenanceAction> pmas = new List<ClassPreventiveMaintenanceAction>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT *
						FROM pmas
						ORDER BY description ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							pmas.Add(GetFromReader(reader));
					conn.Close();
				}
			}
			return pmas;
		}

		public static ClassPreventiveMaintenanceAction GetByID(int pmaID)
		{
			ClassPreventiveMaintenanceAction pma = new ClassPreventiveMaintenanceAction();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = @"SELECT * FROM pmas WHERE id = @PMAID;";
					cmd.Parameters.AddWithValue("PMAID", pmaID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							pma = GetFromReader(reader);
						}
					conn.Close();
				}
			}
			return pma;
		}

		public static void AddNew(ref ClassPreventiveMaintenanceAction pma)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"INSERT INTO pmas
							(description)
						VALUES
							(@Description);";
					cmd.Parameters.AddWithValue("Description", pma.Description);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					pma.ID = Convert.ToInt32(cmd.ExecuteScalar());
					conn.Close();
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.PMA, pma.ID, pma.Description);
		}

		public static void Update(ClassPreventiveMaintenanceAction pma)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"UPDATE pmas SET
						description = @Description
						WHERE id = @PMAID;";
					cmd.Parameters.AddWithValue("PMAID", pma.ID);
					cmd.Parameters.AddWithValue("Description", pma.Description);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.PMA, pma.ID, pma.Description);
		}

		public static int GetUsedQty(int pmaID)
		{
			int usedQty = 0;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("PMAID", pmaID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM ticket_pmas
						WHERE pma_id = @PMAID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		public static void Delete(ClassPreventiveMaintenanceAction pma)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText = @"DELETE FROM pmas WHERE id = @PMAID;";
					cmd.Parameters.AddWithValue("PMAID", pma.ID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.PMA, pma.ID, pma.Description);
		}

		private static ClassPreventiveMaintenanceAction GetFromReader(MySqlDataReader reader)
		{
			return new ClassPreventiveMaintenanceAction
				       {
					       ID = reader.GetDBInt("id"),
					       Description = reader.GetDBString("description")
				       };
		}
	}
}