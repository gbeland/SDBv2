using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	public class ClassRentalDivision
	{
		public int ID { get; set; }
		public int Rental_Company_ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string Telephone { get; set; }

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Name, ID);
		}

		[UsedImplicitly]
		public string DisplayMember => Name;

		public static IEnumerable<ClassRentalDivision> GetAll()
		{
			List<ClassRentalDivision> rentalDivisions = new List<ClassRentalDivision>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_divisions;";
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							rentalDivisions.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return rentalDivisions;
		}

		public static ClassRentalDivision GetByID(int rentalDivisionID)
		{
			ClassRentalDivision rentalDivision = new ClassRentalDivision();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_divisions
						WHERE id = @RentalDivisionID;";
					cmd.Parameters.AddWithValue("RentalDivisionID", rentalDivisionID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							rentalDivision = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return rentalDivision;
		}

		public static IEnumerable<ClassRentalDivision> GetByRentalCompany(int rentalCompanyID)
		{
			List<ClassRentalDivision> rentalDivisions = new List<ClassRentalDivision>();
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_divisions
						WHERE rental_company = @RentalCompanyID;";
					cmd.Parameters.AddWithValue("RentalCompanyID", rentalCompanyID);
					using (MySqlDataReader reader = cmd.ExecuteReader())
						while (reader.Read())
							rentalDivisions.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return rentalDivisions;
		}

		public static void AddNew(ref ClassRentalDivision rentalDivision)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rental_divisions
								(rental_company, name, address, city, state, zip, country, telephone)
								VALUES
								(@rental_company, @name, @address, @city, @state, @zip, @country, @telephone);";

					cmd.Parameters.AddWithValue("rental_company", rentalDivision.Rental_Company_ID);
					cmd.Parameters.AddWithValue("name", rentalDivision.Name);
					cmd.Parameters.AddWithValue("address", rentalDivision.Address);
					cmd.Parameters.AddWithValue("city", rentalDivision.City);
					cmd.Parameters.AddWithValue("state", rentalDivision.State);
					cmd.Parameters.AddWithValue("zip", rentalDivision.Zip);
					cmd.Parameters.AddWithValue("country", rentalDivision.Country);
					cmd.Parameters.AddWithValue("telephone", rentalDivision.Telephone);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Update(ClassRentalDivision rentalDivision)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rental_divisions
						SET rental_company = @rental_company,
						name = @name,
						address = @address,
						city = @city,
						state = @state,
						zip = @zip,
						country = @country,
						telephone = @telephone
						WHERE id = @id;";

					cmd.Parameters.AddWithValue("id", rentalDivision.ID);
					cmd.Parameters.AddWithValue("rental_company", rentalDivision.Rental_Company_ID);
					cmd.Parameters.AddWithValue("name", rentalDivision.Name);
					cmd.Parameters.AddWithValue("address", rentalDivision.Address);
					cmd.Parameters.AddWithValue("city", rentalDivision.City);
					cmd.Parameters.AddWithValue("state", rentalDivision.State);
					cmd.Parameters.AddWithValue("zip", rentalDivision.Zip);
					cmd.Parameters.AddWithValue("country", rentalDivision.Country);
					cmd.Parameters.AddWithValue("telephone", rentalDivision.Telephone);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Rental Divisions are not "used" in the database so this method always returns 0.
		/// </summary>
		public static int GetUsedQty(int rentalDivisionID)
		{
			return 0;
		}

		public static void Delete(ClassRentalDivision rentalDivision)
		{
			using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM rental_divisions WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", rentalDivision.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		private static ClassRentalDivision GetFromReader(MySqlDataReader reader)
		{
			int? rentalDivisionID = reader.GetDBInt_Null("id");
			if (!rentalDivisionID.HasValue)
				return null;

			return new ClassRentalDivision
				       {
					       ID = rentalDivisionID.Value,
						   Rental_Company_ID = reader.GetDBInt("rental_company"),
						   Name = reader.GetDBString("name"),
						   Address = reader.GetDBString("address"),
						   City = reader.GetDBString("city"),
						   State = reader.GetDBString("state"),
						   Zip = reader.GetDBString("zip"),
						   Country = reader.GetDBString("country"),
						   Telephone = reader.GetDBString("telephone")
				       };
		}
	}
}