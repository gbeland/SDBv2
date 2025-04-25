using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoAsset
    {

        public int? ID { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Firmware { get; set; }
        public string Model { get; set; }
        public string IP { get; set; }
        public string Serial { get; set; }

        public string ContractNumber { get; set; }
        public DateTime InstallDate { get; set; }
        public bool IgnoreAlerts { get; set; }
        public string MAC_Address { get; set; }
        public int? Address_ID { get; set; }
        public int? Customer_ID { get; set; }
        public int? Market_ID { get; set; }
        public int? Server_ID { get; set; }

        private readonly string _tableName = "magicinfo_asset";

        #region Init
        public MagicInfoAsset()
        {

        }

        #endregion

        

        #region SQL Calls 

        public static IEnumerable<MagicInfoAsset> GetAllByServerID(int server_id)
        {
            List<MagicInfoAsset> list = new List<MagicInfoAsset>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE server_fky = @server_id
						ORDER BY a.id DESC;";
                    cmd.Parameters.AddWithValue("server_id", server_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        public static IEnumerable<MagicInfoAsset> GetAllByMarketID(int market_id)
        {
            List<MagicInfoAsset> list = new List<MagicInfoAsset>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE market_fky = @market_fky
						ORDER BY a.id DESC;";
                    cmd.Parameters.AddWithValue("market_fky", market_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }



        public static MagicInfoAsset GetByID(int id)
        {
            MagicInfoAsset asset = new MagicInfoAsset();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE id = @id
						ORDER BY a.id DESC;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            asset = (GetFromReader(reader));
                }
                conn.Close();
            }

            return asset;
        }

        public static void AddNew(ref MagicInfoAsset asset)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_asset 
                                   (asset_name, alias, firmware, ip, model, mac_address, serial, contract_number, install_date, ignore_alert, address_fky, customer_fky, market_fky, server_fky)
                            VALUES (@asset_name, @alias, @firmware, @ip, @model, @mac_address, @serial, @contract_number, @install_date, @ignore_alert, @address_fky, @customer_fky, @market_fky, @server_fky);";
                    cmd.Parameters.AddWithValue("asset_name", asset.Name);
                    cmd.Parameters.AddWithValue("alias", asset.Alias);
                    cmd.Parameters.AddWithValue("firmware", asset.Firmware);
                    cmd.Parameters.AddWithValue("ip", asset.IP);
                    cmd.Parameters.AddWithValue("model", asset.Model);
                    cmd.Parameters.AddWithValue("mac_address", asset.MAC_Address);
                    cmd.Parameters.AddWithValue("serial", asset.Serial);
                    cmd.Parameters.AddWithValue("install_date", asset.InstallDate);
                    cmd.Parameters.AddWithValue("contract_number", asset.ContractNumber);
                    cmd.Parameters.AddWithValue("ignore_alert", asset.IgnoreAlerts);
                    cmd.Parameters.AddWithValue("address_fky", asset.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", asset.Customer_ID);
                    cmd.Parameters.AddWithValue("market_fky", asset.Market_ID);
                    cmd.Parameters.AddWithValue("server_fky", asset.Server_ID);

                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static bool AssetExists(string MAC)
        {
            MagicInfoAsset asset = new MagicInfoAsset();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE mac_address = @mac;";
                    cmd.Parameters.AddWithValue("mac", MAC);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            asset = (GetFromReader(reader));
                }
                conn.Close();
            }
            if (asset.ID != null)
                return true;
            else return false;

        }

        

        public static MagicInfoAsset GetAssetByMAC(string MAC)
        {
            MagicInfoAsset asset = new MagicInfoAsset();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE mac_address = @mac;";
                    cmd.Parameters.AddWithValue("mac", MAC);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            asset = (GetFromReader(reader));
                }
                conn.Close();
            }
            return asset;
        }

        public static void Update(ref MagicInfoAsset asset)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE magicinfo_asset 
                            SET asset_name = @asset_name, 
                                alias = @alias, 
                                firmware = @firmware, 
                                ip = @ip, 
                                model = @model, 
                                mac_address = @mac_address, 
                                serial = @serial, 
                                install_date = @install_date,
                                contract_number = @contract_number,
                                ignore_alert = @ignore_alert,
                                address_fky = @address_fky, 
                                customer_fky = @customer_fky, 
                                market_fky = @market_fky, 
                                server_fky = @server_fky
                            WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", asset.ID);
                    cmd.Parameters.AddWithValue("asset_name", asset.Name);
                    cmd.Parameters.AddWithValue("alias", asset.Alias);
                    cmd.Parameters.AddWithValue("firmware", asset.Firmware);
                    cmd.Parameters.AddWithValue("ip", asset.IP);
                    cmd.Parameters.AddWithValue("model", asset.Model);
                    cmd.Parameters.AddWithValue("mac_address", asset.MAC_Address);
                    cmd.Parameters.AddWithValue("serial", asset.Serial);
                    cmd.Parameters.AddWithValue("install_date", asset.InstallDate);
                    cmd.Parameters.AddWithValue("contract_number", asset.ContractNumber);
                    cmd.Parameters.AddWithValue("ignore_alert", asset.IgnoreAlerts);
                    cmd.Parameters.AddWithValue("address_fky", asset.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", asset.Customer_ID);
                    cmd.Parameters.AddWithValue("market_fky", asset.Market_ID);
                    cmd.Parameters.AddWithValue("server_fky", asset.Server_ID);
                    
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private static MagicInfoAsset GetFromReader(MySqlDataReader reader)
        {

            var AssetID = reader.GetDBInt_Null("id");
            if (!AssetID.HasValue)
                return null;

            MagicInfoAsset _asset = new MagicInfoAsset
            {
                ID = AssetID,
                Name = reader.GetString("asset_name"),
                Alias = reader.GetString("alias"),
                Firmware = reader.GetDBString("firmware"),
                Model = reader.GetDBString("model"),
                Serial = reader.GetDBString("serial"),
                ContractNumber = reader.GetDBString("contract_number"),
                InstallDate = reader.GetDBDateTime("install_date"),
                IP = reader.GetDBString("ip"),
                IgnoreAlerts = reader.GetDBBool("ignore_alert"),
                MAC_Address = reader.GetDBString("mac_address"),
                Address_ID = reader.GetDBInt_Null("address_fky"),
                Customer_ID = reader.GetDBInt_Null("customer_fky"),
                Market_ID = reader.GetDBInt_Null("market_fky"),
                Server_ID = reader.GetDBInt_Null("server_fky"),

            };

            return _asset;
        }

        #endregion


    }
}
