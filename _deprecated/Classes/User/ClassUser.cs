using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.User
{
	public class ClassUser
	{
		public const string USERTYPE_STANDARD = @"Standard User";
		public const string USERTYPE_MODERATOR = @"Moderator";
		public const string USERTYPE_ADMIN = @"Administrator";
		public const string USERTYPE_SSR = @"SSR";
		public const int PIN_MINIMUM_LENGTH = 4;
		public const int TEMPORARY_PASSWORD_VALID_FOR_HOURS = 24;

		public enum UserAccountStatus
		{
			All,
			Enabled,
			Disabled
		}

		public int ID { get; set; }

		public string First { get; set; }
		public string Last { get; set; }

		public string Email { get; set; }
		public string UserType { get; set; }
		public DateTime? LoggedIn { get; set; }
		public string LoginFromIpAddress { get; set; }
		public bool LoginDisabled { get; set; }

		/// <summary>
		/// When the user last interacted with the database (used for idle timeout).
		/// </summary>
		public DateTime LastInteraction { get; set; }

		/// <summary>
		/// Returns true if user is a user type moderator or user type SSR as
		/// a SSR is a moderator but an SSR also has additional uses.
		/// </summary>
		public bool IsAdmin => (UserType == USERTYPE_ADMIN || UserType == USERTYPE_SSR);

		public bool IsMod => (UserType == USERTYPE_MODERATOR);

		public bool IsSSR => UserType == USERTYPE_SSR;

		public bool IsLoggedIn => LoggedIn.HasValue;

		[UsedImplicitly]
		public TimeSpan LoggedInDuration => LoggedIn.HasValue ? DateTime.Now - LoggedIn.Value : TimeSpan.Zero;

		public string FirstL => string.Format("{0}{1}", First, Last.Truncate(1));

		public string FLast => string.Format("{0}{1}", First.Truncate(1), Last);

		/// <summary>
		/// Formats name as "John Sample" including a space between first and last names.
		/// </summary>
		public string FirstLast => string.Format("{0} {1}", First, Last).Trim();

		public ClassUser()
		{
			ID = -1;
			First = string.Empty;
			Last = string.Empty;
			Email = string.Empty;
			UserType = USERTYPE_STANDARD;
		}

		public override string ToString()
		{
			return string.Format("{0} [{1}]", FLast, ID);
		}

		[UsedImplicitly]
		public string DisplayMember => string.Format("{0}, {1}", Last, First);

		/// <summary>
		/// Gets all users.
		/// </summary>
		/// <param name="accountStatus">Specifies which account statuses to include.</param>
		public static IEnumerable<ClassUser> GetAll(UserAccountStatus accountStatus)
		{
			var users = new List<ClassUser>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					string statusCondition;
					switch (accountStatus)
					{
						case UserAccountStatus.All:
							statusCondition = string.Empty;
							break;

						case UserAccountStatus.Disabled:
							statusCondition = @"WHERE disabled IS TRUE";
							break;

						default:
							statusCondition = @"WHERE disabled IS FALSE";
							break;
					}
					cmd.CommandText = string.Format(
						@"SELECT u.*
						FROM users u
						{0}
						ORDER BY u.lastname, u.firstname ASC;", statusCondition);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							users.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return users;
		}

		/// <summary>
		/// gets SSR users
		/// </summary>
		/// <returns>
		/// returns an IEnumerable of ClassUser
		/// </returns>
		public static IEnumerable<ClassUser> GetSSRs()
		{
			var users = new List<ClassUser>();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT u.*
						FROM users u
                        WHERE u.usertype = 'SSR'
						ORDER BY u.lastname, u.firstname ASC;");
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							users.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return users;
		}

		/// <summary>
		/// Gets all users as a dictionary where the key is the user ID and the value is the FirstL.
		/// </summary>
		public static Dictionary<int, string> GetIdToNameDictionary()
		{
			var users = new Dictionary<int, string>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT u.userid, concat(u.firstname, LEFT(u.lastname, 1)) firstl
						FROM users u;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							users.Add(reader.GetDBInt("userid"), reader.GetDBString("firstl"));
				}
				conn.Close();
			}
			return users;
		}

		/// <summary>
		/// Gets user from database. Note this does not get passwords or PIN numbers.
		/// </summary>
		public static ClassUser GetByID(int userID)
		{
			ClassUser user = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM users
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							user = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return user;
		}

		/// <summary>
		/// Returns only the first name and last initial of the specified user.
		/// Use when only name is needed.
		/// </summary>
		public static string GetFirstL(int userID)
		{
			var firstL = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				using (var cmd = conn.CreateCommand())
				{
					conn.Open();
					cmd.CommandText =
						@"SELECT firstname, lastname
						FROM users
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
						{
							var first = reader.GetDBString("firstname");
							var last = reader.GetDBString("lastname");
							firstL = string.Format("{0}{1}", first, last.Truncate(1));
						}
					conn.Close();
				}
			}
			return firstL;
		}

		/// <summary>
		/// Updates user name, email, type. (Use <see cref="SetPassword"/> to change password.)
		/// </summary>
		/// <param name="user"></param>
		public static void Update(ClassUser user)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					//cmd.CommandText = string.Format(@"UPDATE users SET {0} WHERE userid = @UserID;", String.Join(",", _userDBFields.Select(s => string.Format("{0} = @{0}", s)).ToArray()));
					cmd.CommandText =
						@"UPDATE users
						SET firstname = @firstname,
						lastname = @lastname,
						email = @email,
						usertype = @usertype
						WHERE userid = @userid;";
					cmd.Parameters.AddWithValue("UserID", user.ID);
					cmd.Parameters.AddWithValue("firstname", user.First);
					cmd.Parameters.AddWithValue("lastname", user.Last);
					cmd.Parameters.AddWithValue("email", user.Email);
					cmd.Parameters.AddWithValue("usertype", user.UserType);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}

				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.User, user.ID, string.Format("{0} {1}", user.First, user.Last));
		}

		/// <summary>
		/// Inserts a new user into the database. Users IDs are admin-assigned (not auto-increment).
		/// </summary>
		public static void AddNew(ClassUser user, string password)
		{
			var hash = ClassEncDec.Encrypt(password, ClassDefinitions.PASSWORD_ENCODE_SALT);
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Insert new user
					cmd.CommandText =
						@"INSERT INTO users
							(userid, firstname, lastname, email, usertype, cpassword)
						VALUES
							(@userid, @firstname, @lastname, @email, @usertype, @cpassword);";
					cmd.Parameters.AddWithValue("userid", user.ID);
					cmd.Parameters.AddWithValue("firstname", user.First);
					cmd.Parameters.AddWithValue("lastname", user.Last);
					cmd.Parameters.AddWithValue("email", user.Email);
					cmd.Parameters.AddWithValue("usertype", user.UserType);
					cmd.Parameters.AddWithValue("cpassword", hash);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.User, user.ID, string.Format("{0} {1}", user.First, user.Last));
		}

		/// <summary>
		/// Uses the new "cpin" encrypted PIN in user table.
		/// Returns true if PIN matches the User's current PIN.
		/// User account must be active.
		/// </summary>
		public bool VerifyPin(string suppliedPin)
		{
			var hash = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT cpin
						FROM users
						WHERE userid = @UserID
						AND disabled IS FALSE;";
					cmd.Parameters.AddWithValue("UserID", ID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							hash = reader.GetDBString_Null("cpin");
						}
				}
				conn.Close();
			}
			return (!string.IsNullOrEmpty(hash) && hash == ClassEncDec.Encrypt(suppliedPin, ClassDefinitions.PASSWORD_ENCODE_SALT));
		}

		/// <summary>
		/// Hashes supplied <paramref name="password"/> and compares it to stored hash for specified user <paramref name="userID"/>. Returns true on match.
		/// </summary>
		public static bool VerifyPassword(int userID, string password)
		{
			var hash = string.Empty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT cpassword FROM users WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							hash = reader.GetDBString("cpassword");
						}
				}
				conn.Close();
			}
			return (!string.IsNullOrWhiteSpace(hash) && hash == ClassEncDec.Encrypt(password, ClassDefinitions.PASSWORD_ENCODE_SALT));
		}

		/// <summary>
		/// Used for password reset logins.
		/// Hashes supplied <paramref name="temporaryPassword"/> and compares it to stored hash for specified user <paramref name="userID"/>.
		/// Returns true if matched and within <paramref name="allowedTimeFromIssued"/> elapsed time from when issued.
		/// </summary>
		public static bool VerifyTemporaryPassword(int userID, string temporaryPassword, TimeSpan allowedTimeFromIssued)
		{
			string hash = null;
			DateTime? issuedDate = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT tpassword, tpassword_issued FROM users WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							hash = reader.GetDBString_Null("tpassword");
							issuedDate = reader.GetDBDateTime_Null("tpassword_issued");
						}
				}
				conn.Close();
			}
			if (string.IsNullOrEmpty(hash) || !issuedDate.HasValue)
				return false;

			var now = ClassDatabase.GetCurrentTime();
			if (issuedDate.Value.Add(allowedTimeFromIssued) < now)
				return false;

			return hash == ClassEncDec.Encrypt(temporaryPassword, ClassDefinitions.PASSWORD_ENCODE_SALT);
		}

		/// <summary>
		/// Change the user password.
		/// </summary>
		public static void SetPassword(int userID, string password)
		{
			var hash = ClassEncDec.Encrypt(password, ClassDefinitions.PASSWORD_ENCODE_SALT);
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET cpassword = @EncPassword
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("EncPassword", hash);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Used for password resets.
		/// Sets the user's temporary password with the current date for its issue date.
		/// </summary>
		public void SetTemporaryPassword(string temporaryPassword)
		{
			var hash = ClassEncDec.Encrypt(temporaryPassword, ClassDefinitions.PASSWORD_ENCODE_SALT);
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET tpassword = @EncTempPassword,
						tpassword_issued = NOW()
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", ID);
					cmd.Parameters.AddWithValue("EncTempPassword", hash);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Clear the user's temporary password. (Use when normal password has been successfully changed.)
		/// </summary>
		public void ClearTemporaryPassword()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET tpassword = NULL,
						tpassword_issued = NULL
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void SetPin(int userID, string pin)
		{
			var hash = ClassEncDec.Encrypt(pin, ClassDefinitions.PASSWORD_ENCODE_SALT);
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET cpin = @EncPin
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("EncPin", hash);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void SetType(int userID, string userType)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET usertype = @UserType
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("UserType", userType);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Marks the specified user account as being logged in (in the database).
		/// </summary>
		public static void SetLoggedIn(int userID)
		{
			var clientAddress = string.Empty;
			try
			{
				clientAddress = ClassUtility.GetLocalIPAddress();
			}
			catch
			{
			}

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET login_datetime = NOW(),
						last_login = NOW(),
						login_ip = @clientIP
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("clientIP", clientAddress.Truncate(15));
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.LogOn, ClassEventLog.ObjectTypeEnum.User, GS.Settings.LoggedOnUser.ID, clientAddress);
		}

		/// <summary>
		/// Marks the specified user account as being logged out (in the database).
		/// </summary>
		public static void SetLoggedOut(int userID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET login_datetime = NULL
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static void SetLoginDisabled(int userID, bool isLoginDisabled)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE users
						SET disabled = @LoginDisabled,
						usertype = @UserType
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", userID);
					cmd.Parameters.AddWithValue("UserType", USERTYPE_STANDARD);
					cmd.Parameters.AddWithValue("LoginDisabled", isLoginDisabled);
					cmd.ExecuteNonQuery();

					if (isLoginDisabled)
					{
						cmd.CommandText =
							@"DELETE FROM user_subscriptions WHERE user_id = @UserID;";
						cmd.ExecuteNonQuery();

						cmd.CommandText =
							@"DELETE FROM user_notifications WHERE notify_user = @UserID;";
						cmd.ExecuteNonQuery();
					}
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Checks if force logout is true in the user table for this user.
		/// </summary>
		public bool GetForceLogout()
		{
			bool forceLogout;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT force_logout
						FROM users
						WHERE userid = @UserID;";
					cmd.Parameters.AddWithValue("UserID", ID);
					forceLogout = Convert.ToBoolean(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return forceLogout;
		}

		private static ClassUser GetFromReader(MySqlDataReader reader)
		{
			var userID = reader.GetDBInt_Null("userid");
			if (!userID.HasValue)
				return null;

			var user = new ClassUser
			{
				ID = userID.Value,
				First = reader.GetDBString("firstname"),
				Last = reader.GetDBString("lastname"),
				Email = reader.GetDBString("email"),
				UserType = reader.GetDBString("usertype"),
				LoggedIn = reader.GetDBDateTime_Null("login_datetime"),
				LoginFromIpAddress = reader.GetDBString_Null("login_ip"),
				LoginDisabled = reader.GetDBBool("disabled")
			};
			return user;
		}
	}
}