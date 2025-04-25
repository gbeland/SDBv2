using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoCustomer
    {

        #region Public Properties
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int? Address_ID { get; set; }
        #endregion

        #region  Private Properties
        private readonly string _tableName = "magicinfo_customer";
        #endregion

        #region Init
        #endregion

        #region Public Methods
        #endregion

        #region SQL Calls 
        public static IEnumerable<MagicInfoCustomer> GetAll()
        {
            List<MagicInfoCustomer> list = new List<MagicInfoCustomer>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"SELECT c.*
						FROM magicinfo_customer c
						ORDER BY c.id DESC;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        public static MagicInfoCustomer GetByID(int customer_id)
        {
            MagicInfoCustomer customer = new MagicInfoCustomer();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT c.*
						FROM magicinfo_customer c
                        WHERE c.id = @customer_id
						ORDER BY c.id DESC;";
                    cmd.Parameters.AddWithValue("customer_id", customer_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            customer = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return customer;
        }

        public static void AddNew(MagicInfoCustomer customer)
        {
            if (customer == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_customer 
                                   (customer_name, tag, address_fky)
                            VALUES (@customer_name, @tag, @address_fky);";
                    cmd.Parameters.AddWithValue("customer_name", customer.Name);
                    cmd.Parameters.AddWithValue("tag", customer.Tag);
                    cmd.Parameters.AddWithValue("address_fky", customer.Address_ID);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoCustomer customer)
        {
            if (customer == null)
                return;

            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_customer 
                                  SET customer_name = @customer_name, 
                                      tag = @tag,
                                      address_fky = @address_fky
                                  WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", customer.ID);
                    cmd.Parameters.AddWithValue("customer_name", customer.Name);
                    cmd.Parameters.AddWithValue("tag", customer.Tag);
                    cmd.Parameters.AddWithValue("address_fky", customer.Address_ID);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        private static MagicInfoCustomer GetFromReader(MySqlDataReader reader)
        {

            var customer_id = reader.GetDBInt_Null("id");
            if (!customer_id.HasValue)
                return null;

            MagicInfoCustomer customer = new MagicInfoCustomer
            {
                ID = customer_id,
                Name = reader.GetDBString("customer_name"),
                Tag = reader.GetDBString("tag"),
                Address_ID = reader.GetDBInt("address_fky"),
            };

            return customer;
        }


        #endregion

        #region Private Methods

        

        #endregion
    }
}
