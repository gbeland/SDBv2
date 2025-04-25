using System;
using System.Net.Mail;
using SDB.Classes.General;

namespace SDB.Classes.Admin
{
	/// <summary>
	/// This class imports global configuration information from the MySQL database. (Stuff stored in the "config" table.)
	/// </summary>
	public static class ClassConfig
	{
		/// <summary>
		/// The name of the company that provides service and receives assemblies for repair. (Electronic Service Group)
		/// </summary>
		public static string GetServiceCompany()
		{
			return GetConfigString("service_company");
		}

		/// <summary>
		/// The address of the company that provides service and receives assemblies for repair.
		/// </summary>
		public static string GetServiceAddress()
		{
			return GetConfigString("service_address");
		}

		/// <summary>
		/// The phone number of the company that provides service and receives assemblies for repair.
		/// </summary>
		public static string GetServicePhone()
		{
			return GetConfigString("service_phone");
		}

		/// <summary>
		/// The email address of the company that provides service and receives assemblies for repair.
		/// </summary>
		public static MailAddress GetServiceEmail()
		{
			var address = GetConfigString("service_email_address");
			var name = GetConfigString("service_email_name");
			return new MailAddress(address, name);
		}

		/// <summary>
		/// The email address for SDB development (feature requests, problem reports, etc)
		/// </summary>
		public static MailAddress GetDevEmail()
		{
			var address = GetConfigString("dev_email_address");
			var name = GetConfigString("dev_email_name");
			return new MailAddress(address, name);
		}

		/// <summary>
		/// The name of the company
		/// </summary>
		public static string GetMainCompany()
		{
			return GetConfigString("main_company");
		}

		/// <summary>
		/// The address of the company
		/// </summary>
		public static string GetMainAddress()
		{
			return GetConfigString("main_address");
		}

		/// <summary>
		/// The phone number of the company
		/// </summary>
		public static string GetMainPhone()
		{
			return GetConfigString("main_phone");
		}

		/// <summary>
		/// The number of minutes that a camera check can be requested (checked out) before it is recycled and given to another requestor.
		/// </summary>
		public static int GetCameraCheckExpireMinutes()
		{
			try
			{
				return GetConfigInt("camera_check_expire_minutes");
			}
			catch
			{
				return 5;
			}
		}

		/// <summary>
		/// The number of minutes prior to a camera check being due when it will appear as being due (to always meet or precede the interval).
		/// </summary>
		public static int GetCameraCheckPaddingMinutes()
		{
			try
			{
				return GetConfigInt("camera_check_padding");
			}
			catch
			{
				return 10;
			}
		}

		/// <summary>
		/// Whether camera check shows a group of assets that currently have a ticket open.
		/// </summary>
		public static bool GetCameraCheckTicketModeEnabled()
		{
			try
			{
				return GetConfigBool("camera_check_ticket_mode");
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Gets the minimum SDB Client version required by the database.
		/// </summary>
		/// <returns></returns>
		public static Version GetMinimumClientVersion()
		{
			try
			{
				return new Version(GetConfigString("min_client_version"));
			}
			catch
			{
				return new Version("1.9.2.0");
			}
		}

		/// <summary>
		/// Gets the user idle timeout in seconds.
		/// </summary>
		public static int GetUserIdleTimeout()
		{
			try
			{
				return GetConfigInt("user_idle_timeout");
			}
			catch
			{
				return 28800;
			}
		}

		/// <summary>
		/// Gets the number of minutes for expiration on journal quick-add
		/// </summary>
		/// <returns></returns>
		public static int GetQuickAddJournalExpirationMinutes()
		{
			try
			{
				return GetConfigInt("quick_add_expire_minutes");
			}
			catch
			{
				return 30;
			}
		}

		private static string GetConfigString(string fieldName)
		{
			var configString = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT {0}
						FROM config
						WHERE id = 1;", fieldName);
					var reader = cmd.ExecuteReader();
					if (reader.HasRows && reader.Read())
						configString = reader.GetDBString(fieldName);
				}
				conn.Close();
			}
			return configString;
		}

		private static int GetConfigInt(string fieldName)
		{
			var configInt = 0;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT {0}
						FROM config
						WHERE id = 1;", fieldName);
					var reader = cmd.ExecuteReader();
					if (reader.HasRows && reader.Read())
						configInt = reader.GetDBInt(fieldName);
				}
				conn.Close();
			}
			return configInt;
		}

		private static bool GetConfigBool(string fieldName)
		{
			var configBool = false;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT {0}
						FROM config
						WHERE id = 1;", fieldName);
					var reader = cmd.ExecuteReader();
					if (reader.HasRows && reader.Read())
						configBool = reader.GetDBBool(fieldName);
				}
				conn.Close();
			}
			return configBool;
		}
	}
}