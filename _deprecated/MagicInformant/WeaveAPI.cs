using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace MagicInformant
{
    class WeaveAPI
    {
        public static readonly string API_URL = "http://magicmonitor.prismview.com/displayapi/nocdisplaydata";

        public AlertData[] Data;
        public struct AlertData
        {
            public int ID;
            public DateTime TimeStamp;
            public string UID;
            public string Name;
            public string Server;
            public string InputSource;
            public bool InputSourceIsValid;
            public double Temperature;
            public bool HasContent;
            public bool Connected;
            public int? AssetID;
            public bool IgnoreAlert;
            public bool EmailCustomer;
        }

        public void GenerateAlerts()
        {
            RefreshData();
            RecordData();
        }

        private void RecordData()
        {
            if(Data == null)
            {
                EventLog.AddEvent(new EventLog.Event
                {
                    Entry = "Error: Unable To Pull Alert Data",
                    TimeStamp = DateTime.Now,
                    Type = "Error"
                });
                return;
            }


            PopulateAssetData();

            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    for (int i = 0; i < Data.Length; i++)
                    {
                        if (Data[i].AssetID == null)
                            continue;
                        

                        cmd.Parameters.Clear();
                        cmd.CommandText =
                            $@"INSERT INTO data
                            (timestamp, uid, name, ip, temperature, has_content, has_connection, has_input, input_type, asset_id, email_customer, ignore_alert)
                            VALUES (@timestamp, @uid, @name, @ip, @temperature, @has_content, @has_connection, @has_input, @input_type, @asset_id, @email_customer, @ignore_alert);";
                        cmd.Parameters.AddWithValue("timestamp", ClassDatabase.GetCurrentTime());
                        cmd.Parameters.AddWithValue("uid", Data[i].UID);
                        cmd.Parameters.AddWithValue("name", Data[i].Name);
                        cmd.Parameters.AddWithValue("ip", Data[i].Server);
                        cmd.Parameters.AddWithValue("temperature", Data[i].Temperature);
                        cmd.Parameters.AddWithValue("has_content", Data[i].HasContent);
                        cmd.Parameters.AddWithValue("has_connection", Data[i].Connected);
                        cmd.Parameters.AddWithValue("has_input", Data[i].InputSourceIsValid);
                        cmd.Parameters.AddWithValue("input_type", Data[i].InputSource);
                        cmd.Parameters.AddWithValue("asset_id", Data[i].AssetID);
                        cmd.Parameters.AddWithValue("email_customer", Data[i].EmailCustomer);
                        cmd.Parameters.AddWithValue("ignore_alert", Data[i].IgnoreAlert);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        cmd.CommandText = @"SELECT @@IDENTITY";
                        Data[i].ID = Convert.ToInt32(cmd.ExecuteScalar());

                        EventLog.AddEvent(new EventLog.Event
                        {
                            Entry = "Event: Retrieved Data on Asset " + Data[i].UID,
                            TimeStamp = DateTime.Now,
                            Type = "Event"
                        });
                    }

                }
                conn.Close();
            }

        }

        private void PopulateAssetData()
        {
            using (var conn = ClassDatabase.CreateSamsungMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    for (int i = 0; i < Data.Length; i++)
                    {

                        cmd.Parameters.Clear();
                        cmd.CommandText = cmd.CommandText +
                            $@"SELECT a.id, a.ignore_alert, s.email_customer
                            FROM magicinfo_asset a
                            RIGHT JOIN magicinfo_server s ON a.server_fky = s.id
                            WHERE a.mac_address = @mac AND s.ip = @sip;";
                        cmd.Parameters.AddWithValue("mac", Data[i].Name);
                        cmd.Parameters.AddWithValue("sip", Data[i].Server);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Data[i].AssetID = reader.GetDBInt_Null("id");
                                Data[i].EmailCustomer = reader.GetDBBool("email_customer");
                                Data[i].IgnoreAlert = reader.GetDBBool("ignore_alert");
                            }
                        }
                    }

                }
                conn.Close();
            }
        }

        public void MarkAlertActive(int alert_id, bool active = true)
        {
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                { 
                    cmd.CommandText = cmd.CommandText +
                        $@"UPDATE data
                         SET active = @active
                         WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", alert_id);
                    cmd.Parameters.AddWithValue("active", active);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static AlertData GetAlertById(int alert_id)
        {
            AlertData data = new AlertData();
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"SELECT a.*
                            FROM data a
                            WHERE a.id = @id;";
                    cmd.Parameters.AddWithValue("id", alert_id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data = new AlertData
                            {
                                TimeStamp = reader.GetDBDateTime("timestamp"),
                                UID = reader.GetDBString("uid"),
                                Name = reader.GetDBString("name"),
                                Server = reader.GetDBString("ip"),
                                Temperature = reader.GetDBDouble("temperature"),
                                HasContent = reader.GetDBBool("has_content"),
                                Connected = reader.GetDBBool("has_connection"),
                                AssetID = reader.GetDBInt("asset_id"),
                                IgnoreAlert = reader.GetDBBool("ignore_alert"),
                                EmailCustomer = reader.GetDBBool("email_customer"),
                                InputSource = reader.GetDBString("input_type"),
                                InputSourceIsValid = reader.GetDBBool("has_input")
                            };
                        }
                    }
                }
                conn.Close();
            }

            return data;
        }

        public static List<AlertData> GetActiveAlerts()
        {
            List<AlertData> list = new List<AlertData>();
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                            $@"SELECT d.*
                            FROM data d
                            WHERE d.active = 1;";
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Data[i].AssetID = reader.GetDBInt_Null("id");
                            list.Add(new AlertData
                            {
                                ID = reader.GetDBInt("id"),
                                TimeStamp = reader.GetDBDateTime("timestamp"),
                                UID = reader.GetDBString("uid"),
                                Name = reader.GetDBString("name"),
                                Server = reader.GetDBString("ip"),
                                Temperature = reader.GetDBDouble("temperature"),
                                HasContent = reader.GetDBBool("has_content"),
                                Connected = reader.GetDBBool("has_connection"),
                                AssetID = reader.GetDBInt("asset_id"),
                                IgnoreAlert = reader.GetDBBool("ignore_alert"),
                                EmailCustomer = reader.GetDBBool("email_customer"),
                                InputSource = reader.GetDBString("input_type"),
                                InputSourceIsValid = reader.GetDBBool("has_input")
                            });
                        }
                    }
                }
                conn.Close();
            }
            return list;
        }

        private void RefreshData()
        {
            Data = GetDataFromWeaveAPI<WeaveAPI>().Data;
        }

        private static WeaveAPI GetDataFromWeaveAPI<WeaveAPIData>() where WeaveAPIData : new()
        {
            using (var wc = new WebClient())
            {
                var json = string.Empty;
                try
                {
                    json = wc.DownloadString(API_URL);
                }
                catch (Exception) { }

                WeaveAPI data = !string.IsNullOrEmpty(json) ? JsonConvert.DeserializeObject<WeaveAPI>(json) : new WeaveAPI();

                return data;
            }
        }
    }
}
