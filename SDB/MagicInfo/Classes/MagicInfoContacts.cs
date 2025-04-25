using MySql.Data.MySqlClient;
using SDB.Classes.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.MagicInfo.Classes
{
    public class MagicInfoContacts
    {
        public int? ID;
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;
        public bool isAuthorizedContact;
        public int Server_Fky;

        public static void AddNew(MagicInfoContacts contacts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"INSERT INTO magicinfo_contact
                                   (firstname, lastname, phone, email, is_authorized, server_fky) 
                            values (@firstname, @lastname, @phone, @email, @is_authorized, @server_fky);";
                    cmd.Parameters.AddWithValue("firstname", contacts.FirstName);
                    cmd.Parameters.AddWithValue("lastname", contacts.LastName);
                    cmd.Parameters.AddWithValue("phone", contacts.PhoneNumber);
                    cmd.Parameters.AddWithValue("email", contacts.Email);
                    cmd.Parameters.AddWithValue("is_authorized", contacts.isAuthorizedContact);
                    cmd.Parameters.AddWithValue("server_fky", contacts.Server_Fky);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    cmd.CommandText = @"SELECT @@IDENTITY";
                    contacts.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(MagicInfoContacts contacts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    // Insert new asset
                    cmd.CommandText =
                        $@"UPDATE magicinfo_contact
                                   SET firstname = @firstname, 
                                       lastname = @lastname, 
                                       phone = @phone, 
                                       email = @email, 
                                       is_authorized = @is_authorized
                                    WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", contacts.ID);
                    cmd.Parameters.AddWithValue("firstname", contacts.FirstName);
                    cmd.Parameters.AddWithValue("lastname", contacts.LastName);
                    cmd.Parameters.AddWithValue("phone", contacts.PhoneNumber);
                    cmd.Parameters.AddWithValue("email", contacts.Email);
                    cmd.Parameters.AddWithValue("is_authorized", contacts.isAuthorizedContact);

                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                }
                conn.Close();
            }
        }

        public static IEnumerable<MagicInfoContacts> GetAllByServer(MagicInfoServer s)
        {
            if (s.ID == null)
                return null;
            return GetAllByServer((int)s.ID);
        }

        public static IEnumerable<MagicInfoContacts> GetAllByServer(int contact_id)
        {
            List<MagicInfoContacts> list = new List<MagicInfoContacts>();
            using (var conn = ClassDatabase.CreateMySqlConnection_MagicinfoLfd())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {

                    cmd.CommandText =
                        $@"SELECT c.*
						FROM magicinfo_contact c
                        WHERE server_fky = @server_id
						ORDER BY c.id DESC;";
                    cmd.Parameters.AddWithValue("server_id", contact_id);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(GetFromReader(reader));
                }
                conn.Close();
            }

            return list;
        }

        private static MagicInfoContacts GetFromReader(MySqlDataReader reader)
        {

            var contactID = reader.GetDBInt_Null("id");
            if (!contactID.HasValue)
                return null;

            MagicInfoContacts _address = new MagicInfoContacts
            {
                ID = contactID,
                FirstName = reader.GetDBString("firstname"),
                LastName = reader.GetDBString("lastname"),
                PhoneNumber = reader.GetDBString("phone"),
                Email = reader.GetDBString("email"),
                isAuthorizedContact = reader.GetDBBool("is_authorized")
            };
            return _address;
        }

    }
}
