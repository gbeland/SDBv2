using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    class MagicInfoSolution
    {

        public int? ID { get; set; }

        public string Solution { get; set; }

        public bool Disabled { get; set; } = false;

        public static void AddNew(MagicInfoSolution solution)
        {
            if (solution == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_solutions
                                   (solution, disabled)
                            VALUES (@solution, @disabled);";
                    cmd.Parameters.AddWithValue("solution", solution.Solution);
                    cmd.Parameters.AddWithValue("disabled", solution.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoSolution solution)
        {
            if (solution == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_solutions
                                  SET solution = @solution,
                                      disabled = @disabled
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", solution.ID);
                    cmd.Parameters.AddWithValue("solution", solution.Solution);
                    cmd.Parameters.AddWithValue("disabled", solution.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static List<MagicInfoSolution> GetAll()
        {
            List<MagicInfoSolution> list = new List<MagicInfoSolution>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_solutions s
						ORDER BY s.id DESC;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            list.Add(GetFromReader(reader));
                        }
                }
                conn.Close();
            }

            return list;
        }

        public static List<MagicInfoSolution> GetAllEnabled()
        {
            List<MagicInfoSolution> list = new List<MagicInfoSolution>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_solutions s
                        WHERE s.disabled = 0
						ORDER BY s.id DESC;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            list.Add(GetFromReader(reader));
                        }
                }
                conn.Close();
            }

            return list;
        }

        public static MagicInfoSolution GetByID(int id)
        {
            MagicInfoSolution status = new MagicInfoSolution();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_solutions s
                        WHERE s.id = @id
						ORDER BY s.id DESC;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            status = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return status;
        }


        private static MagicInfoSolution GetFromReader(MySqlDataReader reader)
        {
            var solution_id = reader.GetDBInt_Null("id");
            if (!solution_id.HasValue)
                return null;

            MagicInfoSolution solution = new MagicInfoSolution
            {
                ID = solution_id,
                Solution = reader.GetDBString("solution"),
                Disabled = reader.GetDBBool("disabled"),
            };
            
            return solution;
        }


    }
}
