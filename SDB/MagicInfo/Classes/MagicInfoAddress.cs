using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoAddress
    {
        #region Public Properties

        public int? ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        #endregion

        #region  Private Properties



        #endregion

        #region Init

        public MagicInfoAddress()
        {

        }

        #endregion

        #region SQL Calls 

        public static MagicInfoAddress GetByID(int? address_id)
        {
            if (address_id == null)
                return null;
            MagicInfoAddress address = new MagicInfoAddress();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT a.*
						FROM magicinfo_address a
                        WHERE a.id = @address_id;";
                    cmd.Parameters.AddWithValue("address_id", address_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            address = GetFromReader(reader);
                        }
                }
                conn.Close();
            }

            return address;
        }

        public static void AddNew(ref MagicInfoAddress address)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_address 
                                   (street, city, state, country, zip) 
                            values (@street, @city, @state, @country, @zip);";
                    cmd.Parameters.AddWithValue("street", address.Street);
                    cmd.Parameters.AddWithValue("city", address.City);
                    cmd.Parameters.AddWithValue("state", address.State);
                    cmd.Parameters.AddWithValue("country", address.Country);
                    cmd.Parameters.AddWithValue("zip", address.Zip);

                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = @"SELECT @@IDENTITY";
                    address.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        private static MagicInfoAddress GetFromReader(MySqlDataReader reader)
        {

            var addressID = reader.GetDBInt_Null("id");
            if (!addressID.HasValue)
                return null;

            MagicInfoAddress _address = new MagicInfoAddress
            {
                ID = addressID,
                Street = reader.GetDBString("street"),
                City = reader.GetDBString("city"),
                State = reader.GetDBString("state"),
                Country = reader.GetDBString("country"),
                Zip = reader.GetDBString("zip"),

            };

            return _address;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion



    }
}
