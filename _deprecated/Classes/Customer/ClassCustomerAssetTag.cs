using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.General;
using SDB.Classes.Ticket;

namespace SDB.Classes.Customer
{
	class ClassCustomerAssetTag
	{
		public int Id { get; set; }
		public string Tag { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Tag;

		public override string ToString()
		{
			return Tag;
		}

		public static IEnumerable<ClassCustomerAssetTag> GetAll()
		{
			var assetTags = new List<ClassCustomerAssetTag>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_tags
						ORDER BY id ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assetTags.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return assetTags;
		}

		public static int? GetCustomerAssetIdByTag(string tag)
		{
			int? assetTag = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_tags
						WHERE tag = @tag;";
					cmd.Parameters.AddWithValue("tag", tag);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							assetTag = reader.GetDBInt_Null("id");
				}
				conn.Close();
			}
			return assetTag;
		}

		public static ClassCustomerAssetTag GetCustomerAssetTagByID(int id)
		{
			var assetTag = new ClassCustomerAssetTag();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_tags
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", id);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							assetTag = GetFromReader(reader);
				}
				conn.Close();
			}
			return assetTag;
		}

		/// <summary>
		/// Returns a dictionary linking Ticket ID to <see cref="ClassCustomerAssetTag"/>. Used to populate non-ticket properties for <see cref="TicketExtraProperties"/>.
		/// </summary>
		public static Dictionary<int, string> GetCustomerAssetTagForTicketIds(IEnumerable<int> ticketIds)
		{
			var ticketToAssetTagDictionary = new Dictionary<int, string>();
			ticketIds = ticketIds.GroupBy(t => t).Select(g => g.First()).ToArray();
			if (!ticketIds.Any())
				return ticketToAssetTagDictionary;

			var ticketIdsCsv = string.Join(",", ticketIds);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = $@"SELECT t.id, cat.tag
						FROM tickets t
						JOIN assets a ON t.asset_id = a.id
						JOIN markets m ON a.market_id = m.id
						JOIN customers c ON m.customer_id = c.id
						LEFT JOIN asset_tags cat ON c.asset_tag = cat.id
						WHERE t.id IN ({ticketIdsCsv});";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							ticketToAssetTagDictionary.Add(reader.GetDBInt("id"), reader.GetDBString("tag"));
				}
				conn.Close();
			}
			return ticketToAssetTagDictionary;
		}

		public static void AddNew(ref ClassCustomerAssetTag assetTag)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO asset_tags
							(tag, description)
						VALUES
							(@tag, @description);";
					cmd.Parameters.AddWithValue("tag", assetTag.Tag);
					cmd.Parameters.AddWithValue("description", assetTag.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					assetTag.Id = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassCustomerAssetTag assetTag)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE asset_tags SET
                            tag = @tag,
							description = @description
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", assetTag.Id);
					cmd.Parameters.AddWithValue("tag", assetTag.Tag);
					cmd.Parameters.AddWithValue("description", assetTag.Description);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(int id)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM asset_tags
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", id);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassCustomerAssetTag GetFromReader(MySqlDataReader reader)
		{
			var assetTag = new ClassCustomerAssetTag();
			var id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			assetTag.Id = id.Value;
			assetTag.Description = reader.GetDBString("description");
			assetTag.Tag = reader.GetDBString("tag");
			return assetTag;
		}
	}
}