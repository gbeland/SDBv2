using System;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;

namespace SDB.Classes.General
{
    public static class ClassDatabase
	{
        // public static string DBPassword = "so1ongMyOldFriend";

        public static MySqlConnection CreateMySqlConnection()
		{
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}SslMode = Preferred; Connection Timeout = {4};",
                                                     GS.Settings.DBServer,
                                                     GS.Settings.DBName_Service,
                                                     GS.Settings.DBUser,
                                                     string.IsNullOrEmpty(GS.Settings.DBPassword) ? string.Empty : string.Format("Pwd = {0}; ", GS.Settings.DBPassword),
                                                     GS.Settings.DBTimeout));

        }

        public static MySqlConnection CreateDevMySqlConnection()
        {
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}SslMode = Preferred; Connection Timeout = {4};",
                                                     "192.168.90.102",
                                                     GS.Settings.DBName_Service,
                                                     GS.Settings.DBUser,
                                                     string.IsNullOrEmpty(GS.Settings.DBPassword) ? string.Empty : string.Format("Pwd = {0}; ", GS.Settings.DBPassword),
                                                     GS.Settings.DBTimeout));
        }

        public static MySqlConnection CreateMagicInformantMySqlConnection()
        {
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}; SslMode = Preferred; Connection Timeout = {4};",
                                                     GS.Settings.DBServer,
                                                     "magic_informant",
                                                     GS.Settings.DBUser,
                                                     string.IsNullOrEmpty(GS.Settings.DBPassword) ? string.Empty : string.Format("Pwd = {0}; ", GS.Settings.DBPassword),
                                                     GS.Settings.DBTimeout));
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
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}SslMode = Preferred; Connection Timeout = {4};",
                                                     server,
                                                     database,
                                                     user,
                                                     string.IsNullOrEmpty(password) ? string.Empty : string.Format("Pwd = {0}; ", password),
                                                     timeout));
        }

        public static MySqlConnection CreateMySqlConnection_MagicinfoLfd()
        {
            return new MySqlConnection(string.Format("Server = {0}; Database = {1}; Uid = {2}; {3}SslMode = Preferred; Connection Timeout = {4};",
                                                     GS.Settings.DBServer,
                                                     GS.Settings.DBName_Samsung,
                                                     GS.Settings.DBUser,
                                                     string.IsNullOrEmpty(GS.Settings.DBPassword) ? string.Empty : string.Format("Pwd = {0}; ", GS.Settings.DBPassword),
                                                     GS.Settings.DBTimeout));
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

		// IMAGE
		/// <summary>
		/// Gets an image from the specified MySqlDataReader and FieldName. Wraps GetDBBytes().
		/// </summary>
		public static Image GetDBImage(this MySqlDataReader reader, string fieldName)
		{
			return ClassUtility.ByteArrayToImage(reader.GetDBBytes(fieldName));
		}

		// ReSharper restore UnusedMember.Global

		/// <summary>
		/// Gets the current datetime from the MySQL server.
		/// </summary>
		public static DateTime GetCurrentTime()
		{
			DateTime serverTime;
			using (MySqlConnection conn = CreateMySqlConnection())
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

        /// <summary>
        /// Attempts to connect to the database and returns true if successful.
        /// Catches and logs any exceptions.
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = CreateMySqlConnection())
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                try
                {
                    ClassLogFile.AppendToLog("Database Connection Test Failed: " + ex.ToString());
                }
                catch { /* Ignore logging failure */ }
                return false;
            }
        }
	}
}