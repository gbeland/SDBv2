using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoServer
    {
        #region Public Properties

        public int? ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Tag { get; set; }
        public string License { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public bool IsUrl { get; set; }

        public int? Customer_ID { get; set; }
        public int? Address_ID { get; set; }

        public string TeamviewerID { get; set; }
        public string TeamviewerPassword { get; set; }
        public string ServerUsername { get; set; }
        public string ServerPassword { get; set; }
        public string ServerNote { get; set; }
        public string AlertEmails { get; set; }
        public bool SendEmail { get; set; }


        #endregion


        #region Init
        #endregion

        #region SQL Calls 

        public static IEnumerable<MagicInfoServer> GetAll()
        {

            List<MagicInfoServer> list = new List<MagicInfoServer>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_server s
						ORDER BY s.id DESC;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        public static MagicInfoServer GetByID(int server_id)
        {
            MagicInfoServer server = new MagicInfoServer();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT s.*
						FROM magicinfo_server s
                        WHERE s.id = @server_id;";
                    cmd.Parameters.AddWithValue("server_id", server_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            server = GetFromReader(reader);
                        }
                }
                conn.Close();
            }
            if (server.ID == null)
                return null;
            return server;
        }

        public static void AddNew(MagicInfoServer server)
        {
            if (server == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_server 
                                   (server_name, alias, tag, license, version, type, ip, port, is_url, address_fky, customer_fky, teamviewer_id, teamviewer_password, magicinfo_username, magicinfo_password, server_note, alert_emails, email_customer)
                            VALUES (@server_name, @alias, @tag, @license, @version, @type, @ip, @port, @is_url, @address_fky, @customer_fky, @teamviewer_id, @teamviewer_password, @magicinfo_username, @magicinfo_password, @server_note, @alert_emails, email_customer);";
                    cmd.Parameters.AddWithValue("server_name", server.Name);
                    cmd.Parameters.AddWithValue("alias", server.Alias);
                    cmd.Parameters.AddWithValue("tag", server.Tag);
                    cmd.Parameters.AddWithValue("ip", server.IP);
                    cmd.Parameters.AddWithValue("port", server.Port);
                    cmd.Parameters.AddWithValue("license", server.License);
                    cmd.Parameters.AddWithValue("version", server.Version);
                    cmd.Parameters.AddWithValue("type", server.Type);
                    cmd.Parameters.AddWithValue("address_fky", server.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", server.Customer_ID);
                    cmd.Parameters.AddWithValue("teamviewer_id", server.TeamviewerID);
                    cmd.Parameters.AddWithValue("teamviewer_password", server.TeamviewerID);
                    cmd.Parameters.AddWithValue("magicinfo_username", server.ServerUsername);
                    cmd.Parameters.AddWithValue("magicinfo_password", server.ServerPassword);
                    cmd.Parameters.AddWithValue("server_note", server.ServerNote);
                    cmd.Parameters.AddWithValue("is_url", server.IsUrl);
                    cmd.Parameters.AddWithValue("alert_emails", server.AlertEmails);
                    cmd.Parameters.AddWithValue("email_customer", server.SendEmail);

                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(ref MagicInfoServer server)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE magicinfo_server 
                            SET server_name = @server_name, 
                                alias = @alias, 
                                tag = @tag, 
                                ip = @ip,
                                port = @port,
                                is_url = @is_url,
                                license = @license, 
                                version = @version, 
                                type = @type, 
                                address_fky = @address_fky, 
                                customer_fky = @customer_fky, 
                                teamviewer_id = @teamviewer_id,
                                teamviewer_password = @teamviewer_password,
                                magicinfo_username = @magicinfo_username,
                                magicinfo_password = @magicinfo_password,
                                server_note = @server_note,
                                alert_emails = @alert_emails,
                                email_customer = @email_customer
                            WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", server.ID);
                    cmd.Parameters.AddWithValue("server_name", server.Name);
                    cmd.Parameters.AddWithValue("tag", server.Tag);
                    cmd.Parameters.AddWithValue("alias", server.Alias);
                    cmd.Parameters.AddWithValue("ip", server.IP);
                    cmd.Parameters.AddWithValue("port", server.Port);
                    cmd.Parameters.AddWithValue("license", server.License);
                    cmd.Parameters.AddWithValue("version", server.Version);
                    cmd.Parameters.AddWithValue("type", server.Type);
                    cmd.Parameters.AddWithValue("address_fky", server.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", server.Customer_ID);
                    cmd.Parameters.AddWithValue("teamviewer_id", server.TeamviewerID);
                    cmd.Parameters.AddWithValue("teamviewer_password", server.TeamviewerID);
                    cmd.Parameters.AddWithValue("magicinfo_username", server.ServerUsername);
                    cmd.Parameters.AddWithValue("magicinfo_password", server.ServerPassword);
                    cmd.Parameters.AddWithValue("server_note", server.ServerNote);
                    cmd.Parameters.AddWithValue("is_url", server.IsUrl);
                    cmd.Parameters.AddWithValue("alert_emails", server.AlertEmails);
                    cmd.Parameters.AddWithValue("email_customer", server.SendEmail);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void UpdateNote(int server_id, string note)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE magicinfo_server 
                            SET server_note = @server_note
                            WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", server_id);
                    cmd.Parameters.AddWithValue("server_note", note);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private static MagicInfoServer GetFromReader(MySqlDataReader reader)
        {

            var serverID = reader.GetDBInt_Null("id");
            if (!serverID.HasValue)
                return null;

            MagicInfoServer _server = new MagicInfoServer
            {
                ID = serverID,
                Name = reader.GetDBString("server_name"),
                Alias = reader.GetDBString("alias"),
                Tag = reader.GetDBString("tag"),
                License = reader.GetDBString("license"),
                Version = reader.GetDBString("version"),
                Type = reader.GetDBString("type"),
                IP = reader.GetDBString("ip"),
                Port = reader.GetDBString("port"),
                IsUrl = reader.GetDBBool("is_url"),
                Customer_ID = reader.GetDBInt_Null("customer_fky"),
                Address_ID = reader.GetDBInt_Null("address_fky"),
                TeamviewerID = reader.GetDBString_Null("teamviewer_id"),
                TeamviewerPassword = reader.GetDBString_Null("teamviewer_password"),
                ServerUsername = reader.GetDBString_Null("magicinfo_username"),
                ServerPassword = reader.GetDBString_Null("magicinfo_password"),
                ServerNote = reader.GetDBString_Null("server_note"),
                AlertEmails = reader.GetDBString_Null("alert_emails"),
                SendEmail = reader.GetDBBool("email_customer")
            };

            return _server;
        }

        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion

    }
}
