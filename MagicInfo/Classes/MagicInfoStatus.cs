using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoStatus
    {
        public int? ID { get; set; }
        
        public string Status { get; set; }

        public Color StatusColor { get; set; }

        public bool Disabled { get; set; } = false;

        public static void AddNew(MagicInfoStatus status)
        {
            if (status == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_status
                                   (status, color, disabled)
                            VALUES (@status, @color, @disabled);";
                    cmd.Parameters.AddWithValue("status", status.Status);
                    cmd.Parameters.AddWithValue("color", ColorTranslator.ToHtml(status.StatusColor));
                    cmd.Parameters.AddWithValue("disabled", status.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoStatus status)
        {
            if (status == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_status
                                  SET status = @status,
                                      color = @color,
                                      disabled = @disabled
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", status.ID);
                    cmd.Parameters.AddWithValue("status", status.Status);
                    cmd.Parameters.AddWithValue("color", ColorTranslator.ToHtml(status.StatusColor));
                    cmd.Parameters.AddWithValue("disabled", status.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static List<MagicInfoStatus> GetAll()
        {
            List<MagicInfoStatus> list = new List<MagicInfoStatus>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_status s
                        WHERE system_only = 0 AND disabled = 0
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

        public static List<MagicInfoStatus> GetAll_IncludingSystemOnly()
        {
            List<MagicInfoStatus> list = new List<MagicInfoStatus>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_status s
                        WHERE status != 'Closed' AND disabled = 0
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

        public static List<MagicInfoStatus> GetAll_IncludingDisabled()
        {
            List<MagicInfoStatus> list = new List<MagicInfoStatus>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_status s
                        WHERE system_only = 0
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

        public static MagicInfoStatus GetByID(int id)
        {
            MagicInfoStatus status = new MagicInfoStatus();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_status s
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
        public static MagicInfoStatus GetByName(string name)
        {
            MagicInfoStatus status = new MagicInfoStatus();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_status s
                        WHERE s.status = @status;";
                    cmd.Parameters.AddWithValue("status", name);
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


        private static MagicInfoStatus GetFromReader(MySqlDataReader reader)
        {
            var status_id = reader.GetDBInt_Null("id");
            if (!status_id.HasValue)
                return null;

            MagicInfoStatus status = new MagicInfoStatus
            {
                ID = status_id,
                Status = reader.GetDBString("status"),
                Disabled = reader.GetDBBool("disabled"),
            };

            string colorHex = reader.GetDBString("color");

            Color c = ColorTranslator.FromHtml(colorHex);
            status.StatusColor = c;

            return status;
        }
    }
}
