using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	public class ClassLiftType
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassLiftType> GetAll()
		{
			List<ClassLiftType> liftTypes = new List<ClassLiftType>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_lift_types
						ORDER BY description ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							liftTypes.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return liftTypes;
		}

		public static ClassLiftType GetByID(int? liftTypeID)
		{
			if (!liftTypeID.HasValue)
				return null;

			ClassLiftType liftType;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_lift_types
						WHERE id = @LiftTypeID;";
					cmd.Parameters.AddWithValue("LiftTypeID", liftTypeID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							liftType = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return liftType;
		}

		public static void AddNew(ref ClassLiftType liftType)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rental_lift_types
							(description)
						VALUES
							(@description)";
					cmd.Parameters.AddWithValue("description", liftType.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					liftType.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassLiftType liftType)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rental_lift_types SET
							description = @description
						WHERE id = @LiftTypeID;";
					cmd.Parameters.AddWithValue("LiftTypeID", liftType.ID);
					cmd.Parameters.AddWithValue("description", liftType.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Reports how many times the specified <see cref="ClassLiftType"/> is used throughout the database.
		/// </summary>
		public static int GetUsedQty(int liftTypeID)
		{
			int usedQty = 0;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.Parameters.AddWithValue("LiftTypeID", liftTypeID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM assets
						WHERE lift_type = @LiftTypeID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

					conn.Close();
				}
			}
			return usedQty;
		}

		public static void Delete(ClassLiftType liftType)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"DELETE FROM rental_lift_types
						WHERE id = @LiftTypeID;";
					cmd.Parameters.AddWithValue("LiftTypeID", liftType.ID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedLiftTypeID"/> with <param name="replacementLiftTypeID"/> throughout the database.
		/// Removes <paramref name="deprecatedLiftTypeID"/> from the lift types table.
		/// *** It is not necessary to delete the deprecated lift type after calling this method.
		/// </summary>
		public static void Merge(int deprecatedLiftTypeID, int replacementLiftTypeID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					// Update Ticket Rental Log
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE ticket_rental_log
						SET lift_Type = @replacementLiftTypeID
						WHERE lift_type = @deprecatedLiftTypeID;";
					cmd.Parameters.AddWithValue("deprecatedLiftTypeID", deprecatedLiftTypeID);
					cmd.Parameters.AddWithValue("replacementLiftTypeID", replacementLiftTypeID);
					cmd.ExecuteNonQuery();

					// Update Assets
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE assets
						SET lift_type = @replacementLiftTypeID
						WHERE lift_type = @deprecatedLiftTypeID;";
					cmd.Parameters.AddWithValue("deprecatedLiftTypeID", deprecatedLiftTypeID);
					cmd.Parameters.AddWithValue("replacementLiftTypeID", replacementLiftTypeID);
					cmd.ExecuteNonQuery();

					// Delete deprecated lift type
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM rental_lift_types
						WHERE id = @deprecatedLiftTypeID;";
					cmd.Parameters.AddWithValue("deprecatedLiftTypeID", deprecatedLiftTypeID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassLiftType GetFromReader(MySqlDataReader reader)
		{
			ClassLiftType liftType = new ClassLiftType();
			int? id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			liftType.ID = id.Value;
			liftType.Description = reader.GetDBString("description");
			return liftType;
		}
	}
}