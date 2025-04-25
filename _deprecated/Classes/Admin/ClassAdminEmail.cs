using System;
using System.Collections.Generic;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Admin
{
	public class ClassAdminEmail
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }

		[UsedImplicitly]
		public string DisplayMember => ToString();

		public override string ToString()
		{
			return string.Format("\"{0}\" <{1}>", Name, Email);
		}

		public static IEnumerable<ClassAdminEmail> GetAll()
		{
			List<ClassAdminEmail> adminEmails = new List<ClassAdminEmail>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM admin_emails
						ORDER BY name ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							adminEmails.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return adminEmails;
		}

		public static IEnumerable<MailAddress> GetAllAsMailAddresses()
		{
			MailAddressCollection adminAddressCollection = new MailAddressCollection();
			foreach (ClassAdminEmail adminEmail in GetAll())
				adminAddressCollection.Add(new MailAddress(adminEmail.Email, adminEmail.Name));
			return adminAddressCollection;
		}

		public static ClassAdminEmail GetByID(int? adminEmailID)
		{
			if (!adminEmailID.HasValue)
				return null;

			ClassAdminEmail adminEmail;
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM admin_emails
						WHERE id = @AdminEmailID;";
					cmd.Parameters.AddWithValue("AdminEmailID", adminEmailID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							adminEmail = GetFromReader(reader);
						}
						else
							return null;
				}
				conn.Close();
			}
			return adminEmail;
		}

		public static void AddNew(ref ClassAdminEmail adminEmail)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO admin_emails
							(name, email)
						VALUES
							(@name, @email);";
					cmd.Parameters.AddWithValue("name", adminEmail.Name);
					cmd.Parameters.AddWithValue("email", adminEmail.Email);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					adminEmail.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
		}

		public static void Update(ClassAdminEmail adminEmail)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE admin_emails SET
							name = @name,
							email = @email
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", adminEmail.ID);
					cmd.Parameters.AddWithValue("name", adminEmail.Name);
					cmd.Parameters.AddWithValue("email", adminEmail.Email);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(int adminEmailID)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"DELETE FROM admin_emails
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", adminEmailID);
					cmd.ExecuteNonQuery();
					conn.Close();
				}
			}
		}

		private static ClassAdminEmail GetFromReader(MySqlDataReader reader)
		{
			ClassAdminEmail adminEmail = new ClassAdminEmail();
			
			int? id = reader.GetDBInt_Null("id");
			if (!id.HasValue)
				return null;

			adminEmail.ID = id.Value;
			adminEmail.Name = reader.GetDBString("name");
			adminEmail.Email = reader.GetDBString("email");

			return adminEmail;
		}
	}
}