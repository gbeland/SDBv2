using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.Classes.Asset
{
    public class ClassClientConnection
    {

        private const string _SQL_TABLE_NAME = "asset_client_conn";
        private const string _SQL_ASSET_TABLE_COL = "client_conn";

        public int ID { get; set; }
        public string Description { get; set; }

        [UsedImplicitly]
        public string DisplayMember => Description;

        public override string ToString()
        {
            return $"{Description} [{ID}]";
        }

        public static ClassClientConnection GetByID(int? clientConnectionID)
        {
            if (!clientConnectionID.HasValue)
                return null;

            ClassClientConnection clientConnection;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"SELECT *
						FROM {_SQL_TABLE_NAME}
						WHERE id = @clientConnectionID;";
                    cmd.Parameters.AddWithValue("clientConnectionID", clientConnectionID);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            clientConnection = GetFromReader(reader);
                        }
                        else
                            return null;
                }
                conn.Close();
            }
            return clientConnection;
        }

        public static IEnumerable<ClassClientConnection> GetAll()
        {
            var allClientConnection = new List<ClassClientConnection>();
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
                            allClientConnection.Add(GetFromReader(reader));
                }
                conn.Close();
            }
            return allClientConnection;
        }

        public static void AddNew(ref ClassClientConnection clientConnection)
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
                    cmd.Parameters.AddWithValue("description", clientConnection.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    clientConnection.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(ClassClientConnection clientConnection)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"UPDATE {_SQL_TABLE_NAME} SET
							description = @description
						WHERE id = @clientConnectionID;";
                    cmd.Parameters.AddWithValue("clientConnectionID", clientConnection.ID);
                    cmd.Parameters.AddWithValue("description", clientConnection.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Reports how many times the specified <see cref="ClassClientConnection"/> is used throughout the database.
        /// </summary>
        public static int GetUsedQty(int clientConnectionID)
        {
            var usedQty = 0;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText =
                        $@"SELECT COUNT(*) qty
						FROM assets
						WHERE {_SQL_ASSET_TABLE_COL} = @clientConnectionID;";
                    
                    cmd.Parameters.AddWithValue("clientConnectionID", clientConnectionID);
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

        public static void Delete(int clientConnectionID)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText =
                        $@"DELETE FROM {_SQL_TABLE_NAME}
						WHERE id = @clientConnectionID;";
                    cmd.Parameters.AddWithValue("clientConnectionID", clientConnectionID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private static ClassClientConnection GetFromReader(MySqlDataReader reader)
        {
            var ClassClientConnection = new ClassClientConnection();
            var id = reader.GetDBInt_Null("id");
            if (!id.HasValue)
                return null;

            ClassClientConnection.ID = id.Value;
            ClassClientConnection.Description = reader.GetDBString("description");
            return ClassClientConnection;
        }
    }
}
