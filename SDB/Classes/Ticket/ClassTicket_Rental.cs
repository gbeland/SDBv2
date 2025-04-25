using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	/// <summary>
	/// Used for equipment rental events on tickets
	/// </summary>
	public class ClassTicket_Rental
	{
		public int ID { get; set; }
		public int Ticket_ID { get; set; }
		public int Rental_Company_ID { get; set; }
		/// <summary>
		/// Must be populated by joining rental companies table
		/// </summary>
		public string Rental_Company_Name { get; set; }
		public DateTime Reservation_Start { get; set; }
		public string Reservation_Number { get; set; }
		public string Equipment_Number { get; set; }
		public string PickUp_Number { get; set; }
		public int? Lift_Type_ID { get; set; }
		/// <summary>
		/// Must be populated by joining lift types table
		/// </summary>
		public string Lift_Type_Desc { get; set; }
		public int? Lift_Height { get; set; }
		public DateTime? Reservation_End { get; set; }

		public static IEnumerable<ClassTicket_Rental> GetByTicket(int ticketID)
		{
			var ticketRentals = new List<ClassTicket_Rental>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT trl.*, rc.company rental_company_name, rlt.description lift_type_description
						FROM ticket_rental_log trl
							JOIN rental_companies rc ON trl.rental_company = rc.id
							LEFT JOIN rental_lift_types rlt ON trl.lift_type = rlt.id
						WHERE ticket_id = @TicketID;";
					cmd.Parameters.AddWithValue("@TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var ticketRental = GetFromReader(reader);
							ticketRental.Rental_Company_Name = reader.GetDBString("rental_company_name");
							ticketRental.Lift_Type_Desc = reader.GetDBString("lift_type_description");
							ticketRentals.Add(ticketRental);
						}
					}
				}
				conn.Close();
			}
			return ticketRentals;
		}

		public static void AddNew(ref ClassTicket_Rental ticketRental)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO ticket_rental_log
						(ticket_id, reservation_start, rental_company, reservation_num, equipment_num, pickup_num, lift_type, lift_height, reservation_end)
						VALUES
						(@ticket_id, @reservation_start, @rental_company, @reservation_num, @equipment_num, @pickup_num, @lift_type, @lift_height, @reservation_end);";
					cmd.Parameters.AddWithValue("ticket_id", ticketRental.Ticket_ID);
					cmd.Parameters.AddWithValue("reservation_start", ticketRental.Reservation_Start);
					cmd.Parameters.AddWithValue("rental_company", ticketRental.Rental_Company_ID);
					cmd.Parameters.AddWithValue("reservation_num", ticketRental.Reservation_Number);
					cmd.Parameters.AddWithValue("equipment_num", ticketRental.Equipment_Number);
					cmd.Parameters.AddWithValue("pickup_num", ticketRental.PickUp_Number);
					cmd.Parameters.AddWithValue("lift_type", ticketRental.Lift_Type_ID);
					cmd.Parameters.AddWithValue("lift_height", ticketRental.Lift_Height);
					cmd.Parameters.AddWithValue("reservation_end", ticketRental.Reservation_End);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					ticketRental.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.Rental, ticketRental.ID, $"For ticket {ticketRental.Ticket_ID}");
		}

		public static void Update(ClassTicket_Rental ticketRental)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE ticket_rental_log
						SET
							ticket_id = @ticket_id,
							reservation_start = @reservation_start,
							rental_company = @rental_company,
							reservation_num = @reservation_num,
							equipment_num = @equipment_num,
							pickup_num = @pickup_num,
							lift_type = @lift_type,
							lift_height = @lift_height,
							reservation_end = @reservation_end
						WHERE id = @ticketRentalID;";
					cmd.Parameters.AddWithValue("ticketRentalID", ticketRental.ID);
					cmd.Parameters.AddWithValue("ticket_id", ticketRental.Ticket_ID);
					cmd.Parameters.AddWithValue("reservation_start", ticketRental.Reservation_Start);
					cmd.Parameters.AddWithValue("rental_company", ticketRental.Rental_Company_ID);
					cmd.Parameters.AddWithValue("reservation_num", ticketRental.Reservation_Number);
					cmd.Parameters.AddWithValue("equipment_num", ticketRental.Equipment_Number);
					cmd.Parameters.AddWithValue("pickup_num", ticketRental.PickUp_Number);
					cmd.Parameters.AddWithValue("lift_type", ticketRental.Lift_Type_ID);
					cmd.Parameters.AddWithValue("lift_height", ticketRental.Lift_Height);
					cmd.Parameters.AddWithValue("reservation_end", ticketRental.Reservation_End);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void Delete(ClassTicket_Rental ticketRental)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM ticket_rental_log
						WHERE id = @ticketRentalID;";
					cmd.Parameters.AddWithValue("ticketRentalID", ticketRental.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Gets whether the specified ticket has one or more active rentals.
		/// </summary>
		public static bool GetActiveRental(int ticketID)
		{
			int activeRentalQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id)
						FROM ticket_rental_log
						WHERE reservation_end IS NULL
						AND ticket_id = @ticketID;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					activeRentalQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return activeRentalQty > 0;
		}

		/// <summary>
		/// Marks <see cref="ClassTicket.IsRentalActive"/> ("rental_active") true or false based on whether there are any active rentals for specified ticket.
		/// Returns whether any active rentals are present.
		/// </summary>
		public static bool SetTicketRentalIndicator(int ticketId)
		{
			var isActive = GetActiveRental(ticketId);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE tickets t
						SET t.rental_active = @isActive
						WHERE t.id = @ticketId;";
					cmd.Parameters.AddWithValue("isActive", isActive);
					cmd.Parameters.AddWithValue("ticketId", ticketId);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			return isActive;
		}

		private static ClassTicket_Rental GetFromReader(MySqlDataReader reader)
		{
			var ticketRentalID = reader.GetDBInt_Null("id");
			if (!ticketRentalID.HasValue)
				return null;

			return new ClassTicket_Rental
			{
				ID = ticketRentalID.Value,
				Ticket_ID = reader.GetDBInt("ticket_id"),
				Rental_Company_ID = reader.GetDBInt("rental_company"),
				Reservation_Start = reader.GetDBDateTime("reservation_start"),
				Reservation_Number = reader.GetDBString_Null("reservation_num"),
				Equipment_Number = reader.GetDBString_Null("equipment_num"),
				PickUp_Number = reader.GetDBString_Null("pickup_num"),
				Lift_Type_ID = reader.GetDBInt_Null("lift_type"),
				Lift_Height = reader.GetDBInt_Null("lift_height"),
				Reservation_End = reader.GetDBDateTime_Null("reservation_end")
			};
		}
	}
}