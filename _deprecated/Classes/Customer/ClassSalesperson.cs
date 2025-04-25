using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Customer
{
	public class ClassSalesperson
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public string Phone_Office { get; set; }
		public string Phone_Mobile { get; set; }

		public string FullName => string.Format("{0} {1}", FirstName, LastName);

		[UsedImplicitly]
		public string DisplayMember => FullName;

		public override string ToString()
		{
			return FullName;
		}
		
		public string DetailsAsString()
		{
			// todo
			return string.Empty;
		}

		public static IEnumerable<ClassSalesperson> GetSalespeople()
		{
			var salespeople = new List<ClassSalesperson>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM salespeople
						ORDER BY lastname ASC, firstname ASC;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							salespeople.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return salespeople;
		}

		public static void AddNew(ref ClassSalesperson salesperson)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO salespeople
							(firstname, lastname, address, city, state, zip, country, email, tel_office, tel_mobile)
						VALUES
							(@FirstName, @LastName, @Address, @City, @State, @Zip, @Country, @Email, @Phone_Office, @Phone_Mobile);";
					cmd.Parameters.AddWithValue("FirstName", salesperson.FirstName);
					cmd.Parameters.AddWithValue("LastName", salesperson.LastName);
					cmd.Parameters.AddWithValue("Address", salesperson.Address);
					cmd.Parameters.AddWithValue("City", salesperson.City);
					cmd.Parameters.AddWithValue("State", salesperson.State);
					cmd.Parameters.AddWithValue("Zip", salesperson.Zip);
					cmd.Parameters.AddWithValue("Country", salesperson.Country);
					cmd.Parameters.AddWithValue("Email", salesperson.Email);
					cmd.Parameters.AddWithValue("Phone_Office", salesperson.Phone_Office);
					cmd.Parameters.AddWithValue("Phone_Mobile", salesperson.Phone_Mobile);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					salesperson.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Salesperson, salesperson.ID, salesperson.FullName);
		}

		public static void Update(ClassSalesperson salesperson)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE salespeople SET
						firstname = @FirstName,
						lastname = @LastName,
						address = @Address,
						city = @City,
						state = @State,
						zip = @Zip,
						country = @Country,
						email = @Email,
						tel_office = @Phone_Office,
						tel_mobile = @Phone_Mobile
						WHERE id = @SalespersonID;";
					cmd.Parameters.AddWithValue("SalespersonID", salesperson.ID);
					cmd.Parameters.AddWithValue("FirstName", salesperson.FirstName);
					cmd.Parameters.AddWithValue("LastName", salesperson.LastName);
					cmd.Parameters.AddWithValue("Address", salesperson.Address);
					cmd.Parameters.AddWithValue("City", salesperson.City);
					cmd.Parameters.AddWithValue("State", salesperson.State);
					cmd.Parameters.AddWithValue("Zip", salesperson.Zip);
					cmd.Parameters.AddWithValue("Country", salesperson.Country);
					cmd.Parameters.AddWithValue("Email", salesperson.Email);
					cmd.Parameters.AddWithValue("Phone_Office", salesperson.Phone_Office);
					cmd.Parameters.AddWithValue("Phone_Mobile", salesperson.Phone_Mobile);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.Salesperson, salesperson.ID, salesperson.FullName);
		}

		public static ClassSalesperson GetByID(int salespersonID)
		{
			var salesperson = new ClassSalesperson();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT * FROM salespeople WHERE id = @SalespersonID;";
					cmd.Parameters.AddWithValue("SalespersonID", salespersonID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							salesperson = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return salesperson;
		}

		public static int GetUsedQty(int salespersonID)
		{
			var usedQty = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("SalespersonID", salespersonID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM markets
						WHERE salesperson_id = @SalespersonID;";
					usedQty += Convert.ToInt32(cmd.ExecuteScalar());

				}
				conn.Close();
			}
			return usedQty;
		}

		public static void Delete(ClassSalesperson salesperson)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM salespeople WHERE id = @SalespersonID;";
					cmd.Parameters.AddWithValue("SalespersonID", salesperson.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.Salesperson, salesperson.ID, salesperson.FullName);
		}

		private static ClassSalesperson GetFromReader(MySqlDataReader reader)
		{
			return new ClassSalesperson
				       {
					       ID = reader.GetDBInt("id"),
					       FirstName = reader.GetDBString("firstname"),
					       LastName = reader.GetDBString("lastname"),
					       Address = reader.GetDBString("address"),
					       City = reader.GetDBString("city"),
					       State = reader.GetDBString("state"),
					       Zip = reader.GetDBString("zip"),
					       Country = reader.GetDBString("country"),
					       Email = reader.GetDBString("email"),
					       Phone_Office = reader.GetDBString("tel_office"),
					       Phone_Mobile = reader.GetDBString("tel_mobile")
				       };
		}
	}
}