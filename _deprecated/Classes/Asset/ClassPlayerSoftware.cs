using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.Classes.Asset
{
    public class ClassPlayerSoftware
    {

        private const string _SQL_TABLE_NAME = "asset_player_sw";
        private const string _SQL_ASSET_TABLE_COL = "player_sw";

        public int ID { get; set; }
        public string Description { get; set; }

        [UsedImplicitly]
        public string DisplayMember => Description;

        public override string ToString()
        {
            return $"{Description} [{ID}]";
        }

        public static ClassPlayerSoftware GetByID(int? controllerConnectionID)
        {
            if (!controllerConnectionID.HasValue)
                return null;

            ClassPlayerSoftware playerSoftware;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"SELECT *
						FROM {_SQL_TABLE_NAME}
						WHERE id = @player_sw_id;";
                    cmd.Parameters.AddWithValue("player_sw_id", controllerConnectionID);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            playerSoftware = GetFromReader(reader);
                        }
                        else
                            return null;
                }
                conn.Close();
            }
            return playerSoftware;
        }

        public static IEnumerable<ClassPlayerSoftware> GetAll()
        {
            var allplayerSoftware = new List<ClassPlayerSoftware>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"SELECT *
						FROM {_SQL_TABLE_NAME};";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            allplayerSoftware.Add(GetFromReader(reader));
                }
                conn.Close();
            }
            return allplayerSoftware;
        }

        public static void AddNew(ref ClassPlayerSoftware playerSoftware)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"INSERT INTO {_SQL_TABLE_NAME}
							(description)
						VALUES
							(@description)";
                    cmd.Parameters.AddWithValue("description", playerSoftware.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    playerSoftware.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(ClassPlayerSoftware playerSoftware)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"UPDATE {_SQL_TABLE_NAME} SET
							description = @description
						WHERE id = @player_sw_id;";
                    cmd.Parameters.AddWithValue("player_sw_id", playerSoftware.ID);
                    cmd.Parameters.AddWithValue("description", playerSoftware.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Reports how many times the specified <see cref="ClassPlayerSoftware"/> is used throughout the database.
        /// </summary>
        public static int GetUsedQty(int playerSoftwareID)
        {
            var usedQty = 0;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("player_sw_id", playerSoftwareID);

                    cmd.CommandText =
                        $@"SELECT COUNT(*) qty
						FROM assets
						WHERE {_SQL_ASSET_TABLE_COL} = @player_sw_id;";
                    usedQty += Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                }
            }
            return usedQty;
        }

        /// <summary>
        /// Replaces all occurrences of <param name="deprecatedID"/> with <param name="replacementID"/> throughout the database.
        /// Removes <paramref name="deprecatedID"/> from the controller connection table.
        /// *** It is not necessary to delete the deprecated controller connection after calling this method.
        /// </summary>
        public static void Merge(int deprecatedID, int replacementID)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Update Assets
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        $@"UPDATE assets
						SET {_SQL_ASSET_TABLE_COL} = @replacementID
						WHERE {_SQL_ASSET_TABLE_COL} = @deprecatedID;";
                    cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
                    cmd.Parameters.AddWithValue("replacementID", replacementID);
                    cmd.ExecuteNonQuery();

                    // Delete deprecated controller connection
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        $@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @deprecatedID;";
                    cmd.Parameters.AddWithValue("deprecatedID", deprecatedID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static void Delete(int playerSoftwareID)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText =
                        $@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @player_sw_id;";
                    cmd.Parameters.AddWithValue("player_sw_id", playerSoftwareID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private static ClassPlayerSoftware GetFromReader(MySqlDataReader reader)
        {
            var playerSoftware = new ClassPlayerSoftware();
            var id = reader.GetDBInt_Null("id");
            if (!id.HasValue)
                return null;

            playerSoftware.ID = id.Value;
            playerSoftware.Description = reader.GetDBString("description");
            return playerSoftware;
        }

    }
}
