using MySql.Data.MySqlClient;
using SDB.Classes.General;
using SDB.Classes.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoJournalEntry
    {

        public int? ID { get; set; }
        public string Entry { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int User_fky { get; set; }
        public int Status_fky { get; set; }
        public int Ticket_fky { get; set; }
        public int? ParentEntry_fky { get; set; }

        public MagicInfoStatus EntryStatus {
            get
            {
                return MagicInfoStatus.GetByID(Status_fky);
            }
        }

        public ClassUser EntryUser
        {
            get
            {
                return ClassUser.GetByID(User_fky);
            }
        } 

        public static void AddNew(MagicInfoJournalEntry entry)
        {
            if (entry == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_journal_entry
                                   (entry, expire_dt, start_dt, user_fky, status_fky, ticket_fky, parent_entry_fky)
                            VALUES (@entry, @expire_dt, @start_dt, @user_fky, @status_fky, @ticket_fky, @parent_entry_fky);";
                    cmd.Parameters.AddWithValue("entry", entry.Entry);
                    cmd.Parameters.AddWithValue("expire_dt", entry.ExpireDate);
                    cmd.Parameters.AddWithValue("start_dt", entry.StartDate);
                    cmd.Parameters.AddWithValue("user_fky", entry.User_fky);
                    cmd.Parameters.AddWithValue("status_fky", entry.Status_fky);
                    cmd.Parameters.AddWithValue("ticket_fky", entry.Ticket_fky);
                    cmd.Parameters.AddWithValue("parent_entry_fky", entry.ParentEntry_fky);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoJournalEntry entry)
        {
            if (entry == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_journal_entry
                                  SET entry = @entry,
                                      expire_dt = @expire_dt,
                                      start_dt = @start_dt,
                                       user_fky = @user_fky,
                                       status_fky = @status_fky,
                                       ticket_fky = @ticket_fky,
                                       parent_entry_fky = @parent_entry_fky
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", entry.ID);
                    cmd.Parameters.AddWithValue("entry", entry.Entry);
                    cmd.Parameters.AddWithValue("expire_dt", entry.ExpireDate);
                    cmd.Parameters.AddWithValue("start_dt", entry.StartDate);
                    cmd.Parameters.AddWithValue("user_fky", entry.User_fky);
                    cmd.Parameters.AddWithValue("status_fky", entry.Status_fky);
                    cmd.Parameters.AddWithValue("ticket_fky", entry.Ticket_fky);
                    cmd.Parameters.AddWithValue("parent_entry_fky", entry.ParentEntry_fky);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static List<MagicInfoJournalEntry> GetAllByTicketID(int ticket_id)
        {
            List<MagicInfoJournalEntry> list = new List<MagicInfoJournalEntry>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT e.*
						FROM magicinfo_journal_entry e
                        WHERE ticket_fky = @fky
                        ORDER BY e.expire_dt DESC;";
                    cmd.Parameters.AddWithValue("fky", ticket_id);
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

        public static MagicInfoJournalEntry GetByID(int id)
        {
            MagicInfoJournalEntry entry = new MagicInfoJournalEntry();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT e.*
						FROM magicinfo_journal_entry e
                        WHERE e.id = @id;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            entry = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return entry;
        }

        private static MagicInfoJournalEntry GetFromReader(MySqlDataReader reader)
        {
            var entry_id = reader.GetDBInt_Null("id");
            if (!entry_id.HasValue)
                return null;

            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                ID = entry_id,
                Entry = reader.GetDBString("entry"),
                ExpireDate = reader.GetDBDateTime("expire_dt"),
                StartDate = reader.GetDBDateTime("start_dt"),
                User_fky = reader.GetDBInt("user_fky"),
                Status_fky = reader.GetDBInt("status_fky"),
                Ticket_fky = reader.GetDBInt("ticket_fky"),
                ParentEntry_fky = reader.GetDBInt_Null("parent_entry_fky"),
            };

            

            return entry;
        }


    }
}
