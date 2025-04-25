using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	public class ClassRentalCompany
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		#endregion

		#region Private Fields
		private string _reservationNumberFormat;
		private string _equipmentNumberFormat;
		private string _pickupNumberFormat;
		#endregion

		#region Public Properties
		public static readonly Regex NUMBER_FORMAT_REG_EX = new Regex(@"^[#X\*\.\-]+$|^\?$");

		public int ID { get; set; }
		public string Company { get; set; }
		public string AccountNumber { get; set; }
		public string Telephone { get; set; }

		/// <summary>
		/// Whether the company uses a reservation number.
		/// </summary>
		public bool UsesReservationNumber { get; set; }

		/// <summary>
		/// A string which uses # for a digit, X for a letter, and * for any character. Hyphens and dots are literal.
		/// </summary>
		public string ReservationNumber_Format
		{
			get => _reservationNumberFormat;
			set
			{
				if (string.IsNullOrEmpty(value) || NUMBER_FORMAT_REG_EX.IsMatch(value))
					_reservationNumberFormat = value;
				else
					throw new FormatException();
			}
		}

		/// <summary>
		/// Whether the company uses an equipment number.
		/// </summary>
		public bool UsesEquipmentNumber { get; set; }

		public string EquipmentNumber_Format
		{
			get => _equipmentNumberFormat;
			set
			{
				if (string.IsNullOrEmpty(value) || NUMBER_FORMAT_REG_EX.IsMatch(value))
					_equipmentNumberFormat = value;
				else
					throw new FormatException();
			}
		}

		/// <summary>
		/// Whether the company uses a pickup number.
		/// </summary>
		public bool UsesPickupNumber { get; set; }

		public string PickupNumber_Format
		{
			get => _pickupNumberFormat;
			set
			{
				if (string.IsNullOrEmpty(value) || NUMBER_FORMAT_REG_EX.IsMatch(value))
					_pickupNumberFormat = value;
				else
					throw new FormatException();
			}
		}

		/// <summary>
		/// List of divisions for this rental company.
		/// </summary>
		public List<ClassRentalDivision> Divisions = new List<ClassRentalDivision>();

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Company, ID);
		}

		[UsedImplicitly]
		public string DisplayMember => Company;
		#endregion

		#region Constructor
		#endregion

		#region Private Methods
		private static ClassRentalCompany GetFromReader(MySqlDataReader reader)
		{
			int? rentalCompanyID = reader.GetDBInt_Null("id");
			if (!rentalCompanyID.HasValue)
				return null;

			return new ClassRentalCompany
			{
				ID = rentalCompanyID.Value,
				Company = reader.GetDBString("company"),
				AccountNumber = reader.GetDBString("account_number"),
				Telephone = reader.GetDBString("telephone"),
				UsesReservationNumber = reader.GetDBBool("use_reservation_number"),
				ReservationNumber_Format = reader.GetDBString_Null("reservation_format"),
				UsesEquipmentNumber = reader.GetDBBool("use_equipment_number"),
				EquipmentNumber_Format = reader.GetDBString_Null("equipment_format"),
				UsesPickupNumber = reader.GetDBBool("use_pickup_number"),
				PickupNumber_Format = reader.GetDBString_Null("pickup_format")
			};
		}

		/// <summary>
		/// Validates a rental company number against a proprietary format.
		/// </summary>
		private static bool ValidateNumber(string number, string format)
		{
			// A format starting with a question mark means no validation needed.
			if (format.StartsWith("?"))
				return true;

			if (string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(format))
				return false;

			if (number.Length != format.Length)
				return false;

			var pattern = string.Empty;
			foreach (char c in format)
			{
				switch (c)
				{
					case '#':
						pattern += @"[0-9]";
						break;

					case 'X':
						pattern += @"[A-Za-z]";
						break;

					case '*':
						pattern += @"[A-Za-z0-9]";
						break;

					case '-':
						pattern += @"\-";
						break;

					case '.':
						pattern += @"\.";
						break;
				}
			}
			var tempRegex = new Regex(pattern);
			return tempRegex.IsMatch(number);
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Validates the supplied reservation number against the company's <see cref="ReservationNumber_Format"/>.
		/// If the company does not use a reservation number, any value is valid.
		/// If the company does not specify a reservation number format, any value is valid.
		/// </summary>
		public bool Validate_ReservationNumber(string reservationNumber)
		{
			if (!UsesReservationNumber)
				return true;

			if (string.IsNullOrWhiteSpace(ReservationNumber_Format))
				return true;

			return ValidateNumber(reservationNumber, ReservationNumber_Format);
		}

		/// <summary>
		/// Validates the supplied equipment number against the company's <see cref="EquipmentNumber_Format"/>.
		/// If the company does not use a equipment number, any value is valid.
		/// If the company does not specify a equipment number format, any value is valid.
		/// </summary>
		public bool Validate_EquipmentNumber(string equipmentNumber)
		{
			if (!UsesEquipmentNumber)
				return true;

			if (string.IsNullOrWhiteSpace(EquipmentNumber_Format))
				return true;

			return ValidateNumber(equipmentNumber, EquipmentNumber_Format);
		}

		/// <summary>
		/// Validates the supplied pickup number against the company's <see cref="PickupNumber_Format"/>.
		/// If the company does not use a pickup number, any value is valid.
		/// If the company does not specify a pickup number format, any value is valid.
		/// </summary>
		public bool Validate_PickupNumber(string pickupNumber)
		{
			if (!UsesPickupNumber)
				return true;

			if (string.IsNullOrWhiteSpace(PickupNumber_Format))
				return true;

			return ValidateNumber(pickupNumber, PickupNumber_Format);
		}

		public static IEnumerable<ClassRentalCompany> GetAll()
		{
			var rentalCompanies = new List<ClassRentalCompany>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_companies
						ORDER BY company ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							rentalCompanies.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return rentalCompanies;
		}

		/// <summary>
		/// Returns how many times specified rental company is utilized by the database.
		/// </summary>
		public static int GetUsedQty(int rentalCompanyID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("RentalCompanyID", rentalCompanyID);

					// TICKET RENTAL LOG
					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM ticket_rental_log
						WHERE rental_company = @RentalCompanyID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Inserts a new rental company into the database and populates its ID.
		/// </summary>
		public static void AddNew(ref ClassRentalCompany rentalCompany)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Insert new rental company
					cmd.CommandText =
						@"INSERT INTO rental_companies
							(company, account_number, telephone,
							use_reservation_number, reservation_format,
							use_equipment_number, equipment_format,
							use_pickup_number, pickup_format)
						VALUES
							(@company, @account_number, @telephone,
							@use_reservation_number, @reservation_format,
							@use_equipment_number, @equipment_format,
							@use_pickup_number, @pickup_format)";
					cmd.Parameters.AddWithValue("company", rentalCompany.Company);
					cmd.Parameters.AddWithValue("account_number", rentalCompany.AccountNumber);
					cmd.Parameters.AddWithValue("telephone", rentalCompany.Telephone);
					cmd.Parameters.AddWithValue("use_reservation_number", rentalCompany.UsesReservationNumber);
					cmd.Parameters.AddWithValue("reservation_format", rentalCompany.ReservationNumber_Format);
					cmd.Parameters.AddWithValue("use_equipment_number", rentalCompany.UsesEquipmentNumber);
					cmd.Parameters.AddWithValue("equipment_format", rentalCompany.EquipmentNumber_Format);
					cmd.Parameters.AddWithValue("use_pickup_number", rentalCompany.UsesPickupNumber);
					cmd.Parameters.AddWithValue("pickup_format", rentalCompany.PickupNumber_Format);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					rentalCompany.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}

				conn.Close();

				// Insert rental divisions
				foreach (var div in rentalCompany.Divisions)
				{
					var division = div;
					division.Rental_Company_ID = rentalCompany.ID;
					ClassRentalDivision.AddNew(ref division);
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.RentalCompany, rentalCompany.ID, rentalCompany.Company);
		}

		/// <summary>
		/// Updates rental company in database. Updates its divisions also.
		/// </summary>
		public static void Update(ClassRentalCompany rentalCompany)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"UPDATE rental_companies
						SET company = @company,
						account_number = @account_number,
						telephone = @telephone,
						use_reservation_number = @use_reservation_number,
						reservation_format = @reservation_format,
						use_equipment_number = @use_equipment_number,
						equipment_format = @equipment_format,
						use_pickup_number = @use_pickup_number,
						pickup_format = @pickup_format
						WHERE id = @id;";

					cmd.Parameters.AddWithValue("id", rentalCompany.ID);
					cmd.Parameters.AddWithValue("company", rentalCompany.Company);
					cmd.Parameters.AddWithValue("account_number", rentalCompany.AccountNumber);
					cmd.Parameters.AddWithValue("telephone", rentalCompany.Telephone);
					cmd.Parameters.AddWithValue("use_reservation_number", rentalCompany.UsesReservationNumber);
					cmd.Parameters.AddWithValue("reservation_format", rentalCompany.ReservationNumber_Format);
					cmd.Parameters.AddWithValue("use_equipment_number", rentalCompany.UsesEquipmentNumber);
					cmd.Parameters.AddWithValue("equipment_format", rentalCompany.EquipmentNumber_Format);
					cmd.Parameters.AddWithValue("use_pickup_number", rentalCompany.UsesPickupNumber);
					cmd.Parameters.AddWithValue("pickup_format", rentalCompany.PickupNumber_Format);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}

				conn.Close();

				// Get list of divisions prior to update
				List<ClassRentalDivision> previousDivisions = ClassRentalDivision.GetByRentalCompany(rentalCompany.ID).ToList();

				// Delete removed divisions
				foreach (var removedDivision in previousDivisions.Where(e => !rentalCompany.Divisions.Select(d => d.ID).Contains(e.ID)))
					ClassRentalDivision.Delete(removedDivision);

				// Update existing divisions
				foreach (var division in rentalCompany.Divisions.Where(d => d.ID != 0))
					ClassRentalDivision.Update(division);

				// Add new divisions
				foreach (var newDivision in rentalCompany.Divisions.Where(d => d.ID == 0))
				{
					ClassRentalDivision thisNewDivision = newDivision;
					thisNewDivision.Rental_Company_ID = rentalCompany.ID;
					ClassRentalDivision.AddNew(ref thisNewDivision);
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.RentalCompany, rentalCompany.ID, rentalCompany.Company);
		}

		/// <summary>
		/// Permanently deletes specified rental company from the database.
		/// Use UsedQty first to determine if the rental company is used before deleting.
		/// </summary>
		public static void Delete(ClassRentalCompany rentalCompany)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("rentalCompanyID", rentalCompany.ID);

					cmd.CommandText = @"DELETE FROM rental_companies WHERE id = @rentalCompanyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM rental_divisions WHERE rental_company = @rentalCompanyID;";
					cmd.ExecuteNonQuery();

					cmd.CommandText = @"DELETE FROM ticket_rental_log WHERE rental_company = @rentalCompanyID;";
					cmd.ExecuteNonQuery();

					conn.Close();
				}
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.RentalCompany, rentalCompany.ID, rentalCompany.Company);
		}

		/// <summary>
		/// Replaces all occurrences of <param name="deprecatedRentalCompanyID"/> with <param name="replacementRentalCompanyID"/> throughout the database.
		/// Removes <paramref name="deprecatedRentalCompanyID"/> from the rental companies table.
		/// *** It is not necessary to delete the deprecated rental company after calling this method.
		/// </summary>
		public static void Merge(int deprecatedRentalCompanyID, int replacementRentalCompanyID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Update Ticket Rental Log
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE ticket_rental_log
						SET rental_company = @replacementRentalCompanyID
						WHERE rental_company = @deprecatedRentalCompanyID;";
					cmd.Parameters.AddWithValue("deprecatedRentalCompanyID", deprecatedRentalCompanyID);
					cmd.Parameters.AddWithValue("replacementRentalCompanyID", replacementRentalCompanyID);
					cmd.ExecuteNonQuery();

					// Update rental divisions
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE rental_divisions
						SET rental_company = @replacementRentalCompanyID
						WHERE rental_company = @deprecatedRentalCompanyID;";
					cmd.Parameters.AddWithValue("deprecatedRentalCompanyID", deprecatedRentalCompanyID);
					cmd.Parameters.AddWithValue("replacementRentalCompanyID", replacementRentalCompanyID);
					cmd.ExecuteNonQuery();

					// Rental Companies table, delete deprecated rental company
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"DELETE FROM rental_companies
						WHERE id = @deprecatedRentalCompanyID;";
					cmd.Parameters.AddWithValue("deprecatedRentalCompanyID", deprecatedRentalCompanyID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static ClassRentalCompany GetByID(int rentalCompanyID)
		{
			var rentalCompany = new ClassRentalCompany();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM rental_companies
						WHERE id = @RentalCompanyID;";
					cmd.Parameters.AddWithValue("RentalCompanyID", rentalCompanyID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							rentalCompany = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return rentalCompany;
		}
		#endregion
	}
}