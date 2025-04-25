using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using SDB.Classes.General;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoAlertData
    {

        public AlertData[] Data;
        public struct AlertData
        {
            public int ID;
            public DateTime TimeStamp;
            public string UID;
            public string Name;
            public string Server;
            public double Temperature;
            public bool HasContent;
            public bool Connected;
            public string InputSource;
            public bool InputSourceIsValid;
            public int? AssetID;
            public bool IgnoreAlert;
            public bool EmailCustomer;
        }


        public static MagicInfoAlertData GetAlerts()
        {
            MagicInfoAlertData data = new MagicInfoAlertData();
            data.Data = GetActiveAlerts().ToArray();
            data = FilterAlertData(data);
            return data;
        } 

        private static MagicInfoAlertData FilterAlertData(MagicInfoAlertData data)
        {
            List<AlertData> filteredData = new List<AlertData>();
            foreach(AlertData d in data.Data)
            {
                MagicInfoAsset asset = MagicInfoAsset.GetAssetByMAC(d.Name);
                if (asset != null && asset.ID != null)
                {
                   
                    if (!asset.IgnoreAlerts)
                    {
                        if(MagicInfoTicket.HasTicketOpenWithAlertFlag((int)asset.ID)) 
                        {
                            bool triggerAlert = false;
                            if (!d.Connected)
                                triggerAlert = true;
                            else if(!d.InputSourceIsValid)
                                triggerAlert = true;
                            else if (!d.HasContent)
                                triggerAlert = true;
                            
                            if (triggerAlert)
                                filteredData.Add(d);
                        }
                    }
                }
            }

            data.Data = filteredData.ToArray();
            return data;
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


        private static MagicInfoAPI JSONToClass<MagicInfoAPI>() where MagicInfoAPI : new()
        {
            using (var wc = new WebClient())
            {
                var json = string.Empty;
                try
                {
                    json = wc.DownloadString("http://magicmonitor.prismview.com/displayapi/nocdisplaydata");
                }
                catch (Exception) { }

                MagicInfoAPI data = !string.IsNullOrEmpty(json) ? JsonConvert.DeserializeObject<MagicInfoAPI>(json) : new MagicInfoAPI();

                return data;
            }
        }

    }
}
