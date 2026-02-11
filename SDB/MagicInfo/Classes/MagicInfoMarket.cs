using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    
    public class MagicInfoMarket
    {
        #region Public Properties
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int? Address_ID { get; set; }
        public int? Customer_ID { get; set; }
        public int? Server_ID { get; set; }

        #endregion

        #region  Private Properties


        #endregion


        #region Public Methods
        #endregion

        #region SQL Calls 

        /// <summary>
        /// Get a list of all markets
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<MagicInfoMarket> GetAll()
        {

            List<MagicInfoMarket> list = new List<MagicInfoMarket>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    
                    cmd.CommandText =
                        $@"SELECT m.*
						FROM magicinfo_market m
						ORDER BY m.id DESC;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        public static IEnumerable<MagicInfoMarket> GetAllByCustomer(int customer_id)
        {
            List<MagicInfoMarket> list = new List<MagicInfoMarket>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT m.*
						FROM magicinfo_market m
                        WHERE m.customer_fky = @customer_id
						ORDER BY m.id DESC;";
                    cmd.Parameters.AddWithValue("customer_id", customer_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        /// <summary>
        /// Get customer by ID
        /// </summary>
        /// <param name="market_id"></param>
        /// <returns></returns>
        public static MagicInfoMarket GetByID(int market_id)
        {
            MagicInfoMarket market = new MagicInfoMarket();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT m.*
						FROM magicinfo_market m
                        WHERE m.id = @market_id
						ORDER BY m.id DESC;";
                    cmd.Parameters.AddWithValue("market_id", market_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            market = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return market;
        }
        /// <summary>
        /// Get Customer from its server ID
        /// </summary>
        /// <param name="server_id"></param>
        /// <returns></returns>
        public static IEnumerable<MagicInfoMarket> GetAllByServerID(int server_id)
        {
            List<MagicInfoMarket> market = new List<MagicInfoMarket>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT m.*
						FROM magicinfo_market m
                        WHERE m.server_fky = @server_id;";
                    cmd.Parameters.AddWithValue("server_id", server_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            market.Add(GetFromReader(reader));
                        }
                }
                conn.Close();
            }

            return market;
        }

        /// <summary>
        /// Get customer from AssetID
        /// </summary>
        /// <param name="asset_id"></param>
        /// <returns></returns>
        public static MagicInfoMarket GetByAssetID(int asset_id)
        {
            MagicInfoMarket customer = new MagicInfoMarket();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_asset a
                        WHERE a.id = @asset_id;";
                    cmd.Parameters.AddWithValue("asset_id", asset_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            int? market_id = reader.GetDBInt_Null("market_fky");
                            if (market_id == null)
                                return null;
                            customer = GetByID((int)market_id);
                        }
                }
                conn.Close();
            }

            return customer;
        }

        public static void AddNew(MagicInfoMarket market)
        {
            if (market == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_market 
                                   (market_name, tag, address_fky, customer_fky, server_fky)
                            VALUES (@customer_name, @tag, @address_fky, @customer_fky, @server_fky);";
                    cmd.Parameters.AddWithValue("customer_name", market.Name);
                    cmd.Parameters.AddWithValue("tag", market.Tag);
                    cmd.Parameters.AddWithValue("address_fky", market.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", market.Customer_ID);
                    cmd.Parameters.AddWithValue("server_fky", market.Server_ID);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoMarket market)
        {
            if (market == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_market 
                                  SET market_name = @market_name,
                                      tag = @tag,
                                      address_fky = @address_fky,
                                      customer_fky = @customer_fky,
                                      server_fky = @server_fky
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", market.ID);
                    cmd.Parameters.AddWithValue("market_name", market.Name);
                    cmd.Parameters.AddWithValue("tag", market.Tag);
                    cmd.Parameters.AddWithValue("address_fky", market.Address_ID);
                    cmd.Parameters.AddWithValue("customer_fky", market.Customer_ID);
                    cmd.Parameters.AddWithValue("server_fky", market.Server_ID);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private static MagicInfoMarket GetFromReader(MySqlDataReader reader)
        {

            var market_id = reader.GetDBInt_Null("id");
            if (!market_id.HasValue)
                return null;

            MagicInfoMarket market = new MagicInfoMarket
            {
                ID = market_id,
                Name = reader.GetDBString("market_name"),
                Tag = reader.GetDBString("tag"),
                Address_ID = reader.GetDBInt_Null("address_fky"),
                Customer_ID = reader.GetDBInt_Null("customer_fky"),
                Server_ID = reader.GetDBInt_Null("server_fky"),
            };

            return market;
        }


        #endregion

    }
}


