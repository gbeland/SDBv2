using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.Classes.RMA
{
    class ClassRepair_Actions
    {

       
        

        public static string GetActionByID(int id)
        {
            string action = "";
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT r.*
						  FROM rma_repair_actions r
						  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            action = reader.GetDBString("action");
                        }
                }
                conn.Close();
            }
            return action;
        }

        public static int? GetIDByString(string action)
        {
            int? id = null;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT r.*
						  FROM rma_repair_actions r
						  WHERE action = @action;";
                    cmd.Parameters.AddWithValue("action", action);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            id = reader.GetDBInt("id");
                        }
                }
                conn.Close();
            }
            return id;
        }

        public static List<string> GetAllActions()
        {
            List<string> actions = new List<string>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT r.*
						  FROM rma_repair_actions r";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            actions.Add(reader.GetDBString("action"));
                        }
                }
                conn.Close();
            }
            return actions;
        }

        public static void AddAction(string action)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"INSERT INTO rma_repair_actions
								(action)
							VALUES
								(@action);";
                    cmd.Parameters.AddWithValue("action", action);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}
