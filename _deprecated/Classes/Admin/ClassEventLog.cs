using System;
using SDB.Classes.General;

namespace SDB.Classes.Admin
{
	public static class ClassEventLog
	{
		public enum EventTypeEnum
		{
			/// <summary>
			/// Created a new object
			/// </summary>
			Create,
			/// <summary>
			/// Modified object: usually changing information (as opposed to adding it)
			/// </summary>
			Modify,
			/// <summary>
			/// Deleted object
			/// </summary>
			Delete,
			/// <summary>
			/// Undeleted object
			/// </summary>
			Restore,
			/// <summary>
			/// Logged on SDB
			/// </summary>
			LogOn,
			/// <summary>
			/// Logged off SDB
			/// </summary>
			LogOff,
			/// <summary>
			/// Placed object on hold
			/// </summary>
			Held,
			/// <summary>
			/// Took object off hold
			/// </summary>
			Released,
			/// <summary>
			/// Reopened object; removed completed status
			/// </summary>
			Reopen,
			/// <summary>
			/// Closed object (marked as being completed)
			/// </summary>
			Close,
			/// <summary>
			/// Updated information about object: usually adding information but not changing information
			/// </summary>
			Updated,
			/// <summary>
			/// Changed object to be expired
			/// </summary>
			Expired,
			/// <summary>
			/// Changed object to no longer be expired
			/// </summary>
			Unexpired,
			/// <summary>
			/// Object moved physically/geographically
			/// </summary>
			Moved,
			/// <summary>
			/// Permission denied for an operation.
			/// </summary>
			Denied,
			/// <summary>
			/// Requested password reset.
			/// </summary>
			RequestPwReset
		};

		public enum ObjectTypeEnum
		{
			Asset,
			Ticket,
			Customer,
			Market,
			PMA,
			Tech,
			RMA,
			Rental,
			RentalCompany,
			Salesperson,
			Shipment,
			AssemblyCategory,
			AssemblyType,
			Assembly,
			Component,
			User,
			GeneralNote,
			SystemBackup,
			RMABin,
			CameraCheck,
			TicketSymptom,
			TicketSolution
		};

		/// <summary>
		/// Writes an entry to eventlog.
		/// </summary>
		/// <param name="userID">User generating the event.</param>
		/// <param name="eventType">Type of event (create, modify, delete, etc.)</param>
		/// <param name="objectType">Type of object affected (asset, ticket, customer, etc.)</param>
		/// <param name="objectID">Object ID if applicable, otherwise null.</param>
		/// <param name="info">Additional information if desired.</param>
		public static void AddEntry(int userID, EventTypeEnum eventType, ObjectTypeEnum objectType, int? objectID, string info)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO eventlog
						(timestamp, user_id, event_type, object_type, object_id, info)
						VALUES
						(NOW(),  @UserID, @EventType, @ObjectType, @ObjectID, @Info);";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("EventType", eventType.ToString());
					cmd.Parameters.AddWithValue("ObjectType", objectType.ToString());
					cmd.Parameters.AddWithValue("ObjectID", objectID);
					cmd.Parameters.AddWithValue("Info", string.IsNullOrEmpty(info) ? null : info);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}