using System;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;

namespace MagicInformant
{
	public static class ClassDatabase
	{
		public static MySqlConnection CreateMagicInformantMySqlConnection()
		{
			return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; Pwd = {3}; Encrypt = true; Connection Timeout = {4};",
			                                         "192.168.90.19",
			                                         "magic_informant",
			                                         "sdb",
			                                         "yesco",
			                                         "30"));
		}

        public static MySqlConnection CreateSamsungMySqlConnection()
        {
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; Pwd = {3}; Encrypt = true; Connection Timeout = {4};",
                                                     "192.168.90.19",
                                                     "magicinfo_lfd",
                                                     "sdb",
                                                     "yesco",
                                                     "30"));
        }

        /// <summary>
        /// Creates a connection to the specified database with supplied credentials.
        /// </summary>
        /// <param name="server">MySQL server address</param>
        /// <param name="database">Specifies the database to use by default</param>
        /// <param name="user">User name</param>
        /// <param name="password">User password</param>
        /// <param name="timeout">Timeout in seconds</param>
        public static MySqlConnection CreateMySqlConnection(string server, string database, string user, string password, string timeout)
        {
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}Encrypt = true; Connection Timeout = {4};",
                                                     server,
                                                     database,
                                                     user,
                                                     string.IsNullOrEmpty(password) ? string.Empty : string.Format("Pwd = {0}; ", password),
                                                     timeout));
        }

        /// <summary>
        /// Convert any parameter with null value to <see cref="DBNull"/>
        /// </summary>
        public static void ConvertAllNullParameters(IDataParameterCollection parameters)
		{
			foreach (IDataParameter p in parameters.Cast<IDataParameter>().Where(p => p.Value == null))
				p.Value = DBNull.Value;
		}

		// ReSharper disable UnusedMember.Global
		// BOOL
		public static bool GetDBBool(this MySqlDataReader reader, string fieldName, bool Default = false)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetBoolean(fieldName);
		}
		public static bool? GetDBBool_Null(this MySqlDataReader reader, string fieldName, bool? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetBoolean(fieldName);
		}

		// DATETIME
		public static DateTime GetDBDateTime(this MySqlDataReader reader, string fieldName, DateTime Default)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDateTime(fieldName);
		}
		public static DateTime GetDBDateTime(this MySqlDataReader reader, string fieldName)
		{
			return GetDBDateTime(reader, fieldName, DateTime.MinValue);
		}
		public static DateTime? GetDBDateTime_Null(this MySqlDataReader reader, string fieldName, DateTime? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDateTime(fieldName);
		}

		// DOUBLE
		public static double GetDBDouble(this MySqlDataReader reader, string fieldName, double Default = 0D)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDouble(fieldName);
		}
		public static double? GetDBDouble_Null(this MySqlDataReader reader, string fieldName, double? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDouble(fieldName);
		}

		// DECIMAL
		public static decimal GetDBDecimal(this MySqlDataReader reader, string fieldName, decimal Default = 0M)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDecimal(fieldName);
		}
		public static decimal? GetDBDecimal_Null(this MySqlDataReader reader, string fieldName, decimal? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetDecimal(fieldName);
		}

		// FLOAT
		public static float GetDBFloat(this MySqlDataReader reader, string fieldName, float Default = 0F)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetFloat(fieldName);
		}
		public static float? GetDBFloat_Null(this MySqlDataReader reader, string fieldName, float? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetFloat(fieldName);
		}

		// INT
		public static int GetDBInt(this MySqlDataReader reader, string fieldName, int Default = 0)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetInt32(fieldName);
		}
		public static int? GetDBInt_Null(this MySqlDataReader reader, string fieldName, int? Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetInt32(fieldName);
		}

		// STRING
		public static string GetDBString(this MySqlDataReader reader, string fieldName, string Default = "")
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetString(fieldName);
		}
		public static string GetDBString_Null(this MySqlDataReader reader, string fieldName, string Default = null)
		{
			return reader[fieldName].Equals(DBNull.Value) ? Default : reader.GetString(fieldName);
		}

		// BYTE ARRAY (BLOBS)
		public static byte[] GetDBBytes(this MySqlDataReader reader, string fieldName)
		{
			int colOrdinal = reader.GetOrdinal(fieldName);
			const int BLOB_LENGTH = 1024000;

			if (reader[fieldName].Equals(DBNull.Value))
				return null;

			byte[] blobData = new byte[BLOB_LENGTH];
			reader.GetBytes(colOrdinal, 0, blobData, 0, BLOB_LENGTH);
			return blobData;
		}



		// ReSharper restore UnusedMember.Global

		/// <summary>
		/// Gets the current datetime from the MySQL server.
		/// </summary>
		public static DateTime GetCurrentTime()
		{
			DateTime serverTime;
			using (MySqlConnection conn = CreateSamsungMySqlConnection())
			{
				conn.Open();
				using (MySqlCommand cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT NOW();";
					serverTime = Convert.ToDateTime(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return serverTime;
		}
	}
}