using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// Ticket symptom categories.
	/// </summary>
	public class ClassTicket_Symptom
	{
		public int ID { get; private set; }
		public string Symptom { get; set; }

		/// <summary>
		/// Whether the symptom is visible on camera checks.
		/// </summary>
		public bool IsVisible { get; set; }

		/// <summary>
		/// Used only in the context of a new ticket (not a standard symptom property).
		/// </summary>
		public bool Selected { get; [UsedImplicitly] set; }

		[UsedImplicitly]
		public string DisplayMember => Symptom;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Symptom, ID);
		}

		/// <summary>
		/// Gets all possible symptoms.
		/// </summary>
		public static IEnumerable<ClassTicket_Symptom> GetAll()
		{
			var symptoms = new List<ClassTicket_Symptom>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT s.*
						FROM symptoms s
						ORDER BY s.symptom ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							symptoms.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return symptoms;
		}

		public static ClassTicket_Symptom GetByID(int symptomID)
		{
			var symptom = new ClassTicket_Symptom();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT s.*
						FROM symptoms s
						WHERE s.id = @symptom_id;";
					cmd.Parameters.AddWithValue("symptom_id", symptomID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							symptom = GetFromReader(reader);
				}
				conn.Close();
			}
			return symptom;
		}

		public static IEnumerable<ClassTicket_Symptom> GetByTicket(int ticketID)
		{
			var symptoms = new List<ClassTicket_Symptom>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT s.*
						FROM symptoms s
							JOIN ticket_symptoms ts ON ts.symptom_id = s.id
						WHERE ts.ticket_id = @TicketID
						ORDER BY s.symptom ASC;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							symptoms.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return symptoms;
		}

		public static void AddNew(ref ClassTicket_Symptom newSymptom)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"INSERT INTO symptoms
						(symptom, is_visible)
						VALUES
						(@Symptom, @IsVisible);";
					cmd.Parameters.AddWithValue("Symptom", newSymptom.Symptom);
					cmd.Parameters.AddWithValue("IsVisible", newSymptom.IsVisible);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					newSymptom.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassTicket_Symptom symptom)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE symptoms SET
							symptom = @symptom,
							is_visible = @is_visible
						WHERE id = @symptom_id";

					cmd.Parameters.AddWithValue("symptom", symptom.Symptom);
					cmd.Parameters.AddWithValue("is_visible", symptom.IsVisible);
					cmd.Parameters.AddWithValue("symptom_id", symptom.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Returns how many times specified symptom is utilized by tickets.
		/// </summary>
		public static int GetUsedQty(int symptomID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("SymptomID", symptomID);
					
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM ticket_symptoms
						WHERE symptom_id = @SymptomID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM asset_camera_check
						WHERE symptom_id = @SymptomID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		public void Delete()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM symptoms
						WHERE id = @SymptomID;";
					cmd.Parameters.AddWithValue("SymptomID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.TicketSymptom, ID, Symptom);
		}

		/// <summary>
		/// Replaces all occurrences of this symptom with <paramref name="replacementSymptomId"/> throughout the database.
		/// (This applies to ticket symptoms as well as camera check identified symptoms.)
		/// </summary>
		public void Merge(int replacementSymptomId)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("deprecatedSymptomId", ID);
					cmd.Parameters.AddWithValue("replacementSymptomId", replacementSymptomId);

					cmd.CommandText =
						@"UPDATE ticket_symptoms
						SET symptom_id = @replacementSymptomId
						WHERE symptom_id = @deprecatedSymptomId;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE asset_camera_check
						SET symptom_id = @replacementSymptomId
						WHERE symptom_id = @deprecatedSymptomId;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassTicket_Symptom GetFromReader(MySqlDataReader reader)
		{
			return new ClassTicket_Symptom
			       {
				       ID = reader.GetDBInt("id"),
				       Symptom = reader.GetDBString("symptom"),
				       IsVisible = reader.GetDBBool("is_visible")
			       };
		}
	}
}