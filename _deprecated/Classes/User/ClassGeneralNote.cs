using System;
using System.Collections.Generic;

namespace SDB.Classes
{
	public class ClassGeneralNote
	{
		/// <summary>
		/// Note ID.
		/// </summary>
		public int ID { get; set; }
		/// <summary>
		/// User ID of author of note.
		/// </summary>
		public int UserID { get; set; }
		/// <summary>
		/// DateTime when note was created.
		/// </summary>
		public DateTime NoteDateTime { get; set; }
		//public ClassUser User { get; set; }
		/// <summary>
		/// Body of note.
		/// </summary>
		public string NoteText { get; set; }

		/// <summary>
		/// Gets all general notes.
		/// </summary>
		public static List<ClassGeneralNote> GetAll()
		{
			var generalNotes = new List<ClassGeneralNote>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT * FROM general_notes ORDER BY id ASC;";
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var n = new ClassGeneralNote
							        {
								        ID = reader.GetDBInt("id"),
								        NoteDateTime = reader.GetDBDateTime("timestamp"),
								        NoteText = reader.GetDBString("note"),
								        UserID = reader.GetDBInt("userid")
							        };
							generalNotes.Add(n);
						}
					}
					conn.Close();
				}
			}
			return generalNotes;
		}

		public static void AddNew(ref ClassGeneralNote generalNote)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO general_notes
							(timestamp, userid, note)
						VALUES
							(NOW(), @UserID, @NoteText);";
					cmd.Parameters.AddWithValue("UserID", generalNote.UserID);
					cmd.Parameters.AddWithValue("NoteText", generalNote.NoteText);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					generalNote.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.GeneralNote, generalNote.ID, string.Empty);
		}

		public void Delete()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM general_notes WHERE id = @NoteID;";
					cmd.Parameters.AddWithValue("NoteID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.GeneralNote, ID, string.Format("By {0} on {1:yyyy-MM-dd HH:mm:ss}", ClassUser.GetFirstL(UserID), NoteDateTime));
		}
	}
}