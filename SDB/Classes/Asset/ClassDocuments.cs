using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using SDB.Classes.General;
using SDB.Classes.User;

namespace SDB.Classes.Asset
{
	public class ClassDocuments
	{
		public int Id { get; set; }
		public int AssetId { get; set; }
		public string Document_Link { get; set; }
		public string Name { get; set; }

        public DateTime? DateModified { get; set; }
        public int? UserId { get; set; }

        public string UserFirstL
        {
            get
            {
                if (UserId.HasValue)
                    return ClassUser.GetFirstL((int)UserId);
                return string.Empty;
            }
        }

        public string DateString
        {
            get
            {
                if (DateModified.HasValue)
                    return DateModified.Value.ToShortDateString();
                return DateTime.Now.ToShortDateString();
            }
        }


        [UsedImplicitly]
		public string DisplayMember => Name;

		public override string ToString()
		{
			return Name;
		}

		public static IEnumerable<ClassDocuments> GetAllAssetDocuments(int? assetId)
		{
			var docs = new List<ClassDocuments>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM asset_documents
                        WHERE asset_id = @asset_id
						ORDER BY name ASC;";
					cmd.Parameters.AddWithValue("asset_id", assetId);

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							docs.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return docs;
		}


		public static void AddNew(ref ClassDocuments doc)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = (@"INSERT INTO asset_documents
						(`asset_id`, `document_link`, `name`, `date_modified`, `userid`)
						VALUES
						(@asset_id, @document_link, @name, @date_modified, @userid);");
					cmd.Parameters.AddWithValue("asset_id", doc.AssetId);
					cmd.Parameters.AddWithValue("document_link", doc.Document_Link);
                    cmd.Parameters.AddWithValue("date_modified", doc.DateModified);
                    cmd.Parameters.AddWithValue("userid", doc.UserId);
                    cmd.Parameters.AddWithValue("name", doc.Name);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Update(ClassDocuments doc)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE asset_documents
						SET asset_id = @asset_id,
                            document_link = @document_link,
                            name = @name,
                            userid = @userid,
                            date_modified = @date_modified
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", doc.Id);
					cmd.Parameters.AddWithValue("asset_id", doc.AssetId);
					cmd.Parameters.AddWithValue("document_link", doc.Document_Link);
                    cmd.Parameters.AddWithValue("date_modified", doc.DateModified);
                    cmd.Parameters.AddWithValue("userid", doc.UserId);
                    cmd.Parameters.AddWithValue("name", doc.Name);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(ClassDocuments doc)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("DocumentID", doc.Id);
					cmd.CommandText = @"DELETE FROM asset_documents WHERE id = @DocumentID;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassDocuments GetFromReader(MySqlDataReader reader)
		{
			var docID = reader.GetDBInt_Null("id");
			if (!docID.HasValue)
				return null;
			return new ClassDocuments
			{
				Id = docID.Value,
				AssetId = reader.GetDBInt("asset_id"),
				Document_Link = reader.GetDBString("document_link"),
				Name = reader.GetDBString("name"),
                DateModified = reader.GetDBDateTime_Null("date_modified"),
                UserId = reader.GetDBInt("userid")
            };
		}
	}
}