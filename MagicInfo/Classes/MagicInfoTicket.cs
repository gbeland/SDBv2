using MySql.Data.MySqlClient;
using SDB.Classes.General;
using SDB.Classes.Tech;
using SDB.Classes.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoTicket
    {

        public int? ID { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? Issue_fky { get; set; }
        public int? Solution_fky { get; set; }
        public int? OpenUser_fky { get; set; }
        public int? Asset_fky { get; set; }
        public int? CurrentStatus_fky { get; set; }
        public int? Server_fky { get; set; }
        public bool Deleted { get; set; } = false;

        public string LastJournalEntryText
        {
            get
            {
                MagicInfoJournalEntry lastEntry = new MagicInfoJournalEntry();
                foreach (MagicInfoJournalEntry e in Journal)
                {
                    if (lastEntry.ID == null)
                    {
                        lastEntry = e;
                        continue;
                    }
                    else if (lastEntry.StartDate.Ticks < e.StartDate.Ticks)
                    {
                        lastEntry = e;
                    }
                }
                return lastEntry.Entry;
            }
        }

        public MagicInfoJournalEntry LastJournalEntry
        {
            get
            {
                MagicInfoJournalEntry lastEntry = new MagicInfoJournalEntry();
                foreach (MagicInfoJournalEntry e in Journal)
                {
                    if (lastEntry.ID == null)
                    {
                        lastEntry = e;
                        continue;
                    }
                    else if (lastEntry.StartDate.Ticks < e.StartDate.Ticks)
                    {
                        lastEntry = e;
                    }
                }
                return lastEntry;
            }
        }

        public string ExpireDateTimeText
        {
            get
            {
                MagicInfoJournalEntry lastEntry = new MagicInfoJournalEntry();
                foreach (MagicInfoJournalEntry e in Journal)
                {
                    if (lastEntry.ID == null)
                    {
                        lastEntry = e;
                        continue;
                    }
                    else if (lastEntry.StartDate.Ticks < e.StartDate.Ticks)
                    {
                        lastEntry = e;
                    }
                }
                TimeSpan ts = new TimeSpan(lastEntry.ExpireDate.Ticks - DateTime.Now.Ticks);
                if(ts.Ticks < 0)
                {
                    string s;
                    if (Math.Abs(ts.Days) > 0)
                        s = Math.Abs(ts.Days) + "d Ago";
                    else if (Math.Abs(ts.Hours) > 0)
                        s = Math.Abs(ts.Hours) + "hr Ago";
                    else
                        s = Math.Abs(ts.Minutes) + "min Ago";

                    return s;
                }
                else 
                {
                    string s;
                    if (Math.Abs(ts.Days) > 0)
                        s = ts.Days + "d";
                    else if (Math.Abs(ts.Hours) > 0)
                        s = ts.Hours + "hr";
                    else
                        s = ts.Minutes + "min";

                    return s;
                }
            }
        }

        public bool isExpired
        {
            get
            {
                MagicInfoJournalEntry lastEntry = new MagicInfoJournalEntry();
                foreach (MagicInfoJournalEntry e in Journal)
                {
                    if (lastEntry.ID == null)
                    {
                        lastEntry = e;
                        continue;
                    }
                    else if (lastEntry.StartDate.Ticks < e.StartDate.Ticks)
                    {
                        lastEntry = e;
                    }
                }
                if (lastEntry.ExpireDate < DateTime.Now)
                    return true;
                else
                    return false;
            }
        }

        public List<MagicInfoJournalEntry> Journal
        {
            get
            {
                if (ID == null)
                    return null;
                return MagicInfoJournalEntry.GetAllByTicketID((int)ID);
            }
        }
        
        public string SolutionText
        {
            get
            {
                if (Solution_fky == null)
                    return null;
                return MagicInfoSolution.GetByID((int)Solution_fky).Solution;
            }
        }

        public string IssueText
        {
            get
            {
                if (Issue_fky == null)
                    return null;
                return MagicInfoIssue.GetByID((int)Issue_fky).Issue;
            }
        }

        public DateTime? OpenDuration
        {
            get
            {
                if (OpenDate != null && CloseDate != null)
                {
                    return new DateTime((CloseDate.Value - OpenDate.Value).Ticks);
                }
                else return null;
            }
            
        }

        public string ReportedByUserName
        {
            get
            {
                if (OpenUser_fky == null)
                    return null;
                return ClassUser.GetFirstL((int)OpenUser_fky);
            }
        }

        public string ServerNameText
        {
            get
            {
                return MagicInfoServer.GetByID((int)Server_fky).Name;
            }
        }
        public string AssetNameText
        {
            get
            {
                if(Asset_fky == null)
                {
                    return "";
                }
                return MagicInfoAsset.GetByID((int)Asset_fky).Name;
            }
        }

        public bool AddJournalEntry(string text, MagicInfoStatus status, int user_id, DateTime expire_dt)
        {
            if (ID == null)
                return false;
            if (status.ID == null)
                return false;
            MagicInfoJournalEntry entry = new MagicInfoJournalEntry
            {
                Entry = text,
                StartDate = DateTime.Today,
                ExpireDate = expire_dt,
                User_fky = user_id,
                Ticket_fky = (int)this.ID,
                Status_fky = (int)status.ID
            };
            MagicInfoJournalEntry.AddNew(entry);
            
            return true;
        }

        public MagicInfoStatus TicketStatus
        {
            get
            {
                if (CurrentStatus_fky == null)
                    return null;
                return MagicInfoStatus.GetByID((int)CurrentStatus_fky);
            }
        }

        public static void UpdateStatus(MagicInfoTicket ticket, MagicInfoStatus status)
        {
            if (ticket == null || status == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_ticket
                                  SET ticket_status_fky = @ticket_status_fky
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", ticket.ID);
                    cmd.Parameters.AddWithValue("ticket_status_fky", status.ID);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static bool HasTicketOpenWithAlertFlag(int asset_id)
        {
            MagicInfoTicket ticket = new MagicInfoTicket();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
                           FROM magicinfo_ticket t
                           RIGHT JOIN magicinfo_issue i ON t.issue_fky = i.id
                           WHERE t.asset_fky = @id AND i.alert_flag = 1 AND t.close_dt IS NULL;";
                    cmd.Parameters.AddWithValue("id", asset_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            ticket = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            if (ticket.ID != null)
                return false;
            else return true;


        }

        public static MagicInfoTicket GetByID(int ticket_id)
        {
            MagicInfoTicket ticket = new MagicInfoTicket();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
						FROM magicinfo_ticket t
                        WHERE t.id = @id
						ORDER BY t.id DESC;";
                    cmd.Parameters.AddWithValue("id", ticket_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            ticket = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return ticket;
        }

        public static List<MagicInfoTicket> GetByServerID(int server_id)
        {
            List<MagicInfoTicket> list = new List<MagicInfoTicket>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
						FROM magicinfo_ticket t
                        WHERE t.server_fky = @server_id
						ORDER BY t.id DESC;";
                    cmd.Parameters.AddWithValue("server_id", server_id);
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

        public static List<MagicInfoTicket> GetByAssetID(int asset_id)
        {
            List<MagicInfoTicket> list = new List<MagicInfoTicket>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
						FROM magicinfo_ticket t
                        WHERE t.asset_fky = @asset_id
						ORDER BY t.id DESC;";
                    cmd.Parameters.AddWithValue("asset_id", asset_id);
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


        public static void AddNew(ref MagicInfoTicket ticket)
        {
            if (ticket == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_ticket
                                   (open_dt, close_dt, issue_fky, ticket_status_fky, solution_fky, open_user_fky, asset_fky, server_fky)
                            VALUES (@open_dt, @close_dt, @issue_fky, @ticket_status_fky, @solution_fky, @open_user_fky, @asset_fky, @server_fky);";
                    cmd.Parameters.AddWithValue("open_dt", ticket.OpenDate);
                    cmd.Parameters.AddWithValue("close_dt", ticket.CloseDate);
                    cmd.Parameters.AddWithValue("issue_fky", ticket.Issue_fky);
                    cmd.Parameters.AddWithValue("ticket_status_fky", ticket.CurrentStatus_fky);
                    cmd.Parameters.AddWithValue("solution_fky", ticket.Solution_fky);
                    cmd.Parameters.AddWithValue("open_user_fky", ticket.OpenUser_fky);
                    cmd.Parameters.AddWithValue("asset_fky", ticket.Asset_fky);
                    cmd.Parameters.AddWithValue("server_fky", ticket.Server_fky);
                    cmd.Parameters.AddWithValue("deleted", ticket.Deleted);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    ticket.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoTicket ticket)
        {
            if (ticket == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_ticket
                                  SET open_dt = @open_dt,
                                      close_dt = @close_dt,
                                      issue_fky = @issue_fky,
                                      solution_fky = @solution_fky,
                                      ticket_status_fky = @ticket_status_fky,
                                      open_user_fky = @open_user_fky,
                                      asset_fky = @asset_fky,
                                      server_fky = @server_fky,
                                      deleted = @deleted
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", ticket.ID);
                    cmd.Parameters.AddWithValue("open_dt", ticket.OpenDate);
                    cmd.Parameters.AddWithValue("close_dt", ticket.CloseDate);
                    cmd.Parameters.AddWithValue("issue_fky", ticket.Issue_fky);
                    cmd.Parameters.AddWithValue("ticket_status_fky", ticket.CurrentStatus_fky);
                    cmd.Parameters.AddWithValue("solution_fky", ticket.Solution_fky);
                    cmd.Parameters.AddWithValue("open_user_fky", ticket.OpenUser_fky);
                    cmd.Parameters.AddWithValue("asset_fky", ticket.Asset_fky);
                    cmd.Parameters.AddWithValue("server_fky", ticket.Server_fky);
                    cmd.Parameters.AddWithValue("deleted", ticket.Deleted);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static List<MagicInfoTicket> GetAllByStatus(MagicInfoStatus status)
        {
            List<MagicInfoTicket> list = new List<MagicInfoTicket>();

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
						FROM magicinfo_ticket t
                        WHERE t.deleted != 1 AND t.ticket_status_fky = @status_fky
						ORDER BY t.id DESC;";
                    cmd.Parameters.AddWithValue("status_fky", status.ID);
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

        public static List<MagicInfoTicket> GetAllOpen()
        {
            List<MagicInfoTicket> list = new List<MagicInfoTicket>();

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT t.*
						FROM magicinfo_ticket t
                        WHERE t.deleted != 1 AND t.close_dt IS NULL
						ORDER BY t.id DESC;";
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

        private static MagicInfoTicket GetFromReader(MySqlDataReader reader)
        {
            var ticket_id = reader.GetDBInt_Null("id");
            if (!ticket_id.HasValue)
                return null;

            MagicInfoTicket ticket = new MagicInfoTicket
            {
                ID = ticket_id,
                OpenDate = reader.GetDBDateTime_Null("open_dt"),
                CloseDate = reader.GetDBDateTime_Null("close_dt"),
                Issue_fky = reader.GetDBInt_Null("issue_fky"),
                Solution_fky = reader.GetDBInt_Null("solution_fky"),
                OpenUser_fky = reader.GetDBInt_Null("open_user_fky"),
                Asset_fky = reader.GetDBInt_Null("asset_fky"),
                Server_fky = reader.GetDBInt_Null("server_fky"),
                CurrentStatus_fky = reader.GetDBInt_Null("ticket_status_fky"),
                Deleted = reader.GetDBBool("deleted"),
            };

            return ticket;
        }

    }
}
