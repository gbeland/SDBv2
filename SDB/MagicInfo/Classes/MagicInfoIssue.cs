using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    class MagicInfoIssue
    {
        public int? ID { get; set; }

        public string Issue { get; set; }

        public bool AlertFlag { get; set; }

        public bool Disabled { get; set; } = false;

        public static void AddNew(MagicInfoIssue issue)
        {
            if (issue == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_issue
                                   (issue, alert_flag, disabled)
                            VALUES (@issue, @alert_flag, @disabled);";
                    cmd.Parameters.AddWithValue("issue", issue.Issue);
                    cmd.Parameters.AddWithValue("alert_flag", issue.AlertFlag);
                    cmd.Parameters.AddWithValue("disabled", issue.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoIssue issue)
        {
            if (issue == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_issue
                                  SET issue = @issue,
                                      alert_flag = @alert_flag,
                                      disabled = @disabled
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", issue.ID);
                    cmd.Parameters.AddWithValue("issue", issue.Issue);
                    cmd.Parameters.AddWithValue("alert_flag", issue.AlertFlag);
                    cmd.Parameters.AddWithValue("disabled", issue.Disabled);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static List<MagicInfoIssue> GetAll()
        {
            List<MagicInfoIssue> list = new List<MagicInfoIssue>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT i.*
						FROM magicinfo_issue i
						ORDER BY i.id DESC;";
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

        public static List<MagicInfoIssue> GetAllEnabled()
        {
            List<MagicInfoIssue> list = new List<MagicInfoIssue>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT i.*
						FROM magicinfo_issue i
                        WHERE i.disabled = 0
						ORDER BY i.id DESC;";
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

        public static MagicInfoIssue GetByID(int id)
        {
            MagicInfoIssue status = new MagicInfoIssue();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT i.*
						FROM magicinfo_issue i
                        WHERE i.id = @id
						ORDER BY i.id DESC;";
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

        private static MagicInfoIssue GetFromReader(MySqlDataReader reader)
        {
            var issue_id = reader.GetDBInt_Null("id");
            if (!issue_id.HasValue)
                return null;

            MagicInfoIssue issue = new MagicInfoIssue
            {
                ID = issue_id,
                Issue = reader.GetDBString("issue"),
                AlertFlag = reader.GetDBBool("alert_flag"),
                Disabled = reader.GetDBBool("disabled"),
            };

            return issue;
        }
    }
}
