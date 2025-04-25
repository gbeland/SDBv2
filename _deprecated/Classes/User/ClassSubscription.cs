using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Shipments;
using SDB.Classes.Ticket;

namespace SDB.Classes.User
{
	/// <summary>
	/// A subscription links a user to various objects, indicating that they want to receive notifications when that object has changes or updates.
	/// Subscriptions can be applied to Assets, Customers, Markets, RMAs, Shipments, and Tickets
	/// </summary>
	public class ClassSubscription
	{
		/// <summary>
		/// Distinguish the object type for proper object link creation.
		/// </summary>
		/// <remarks>MySQL fields are only 8 characters for this value.</remarks>
		public enum ObjectTypeEnum
		{
			Asset,
			Customer,
			Market,
			RMA,
			Shipment,
			Ticket
		};

		public int ID { get; set; }
		public int UserID { get; set; }
		public ObjectTypeEnum ObjectType { get; set; }
		public int ObjectID { get; set; }
		/// <summary>
		/// Used for subscriptions to objects that are usually known by a string name instead of an ID, like Customers and Markets.
		/// </summary>
		public string ObjectName { get; set; }

		/// <summary>
		/// A human-readable string like "Ticket: 12345", "Customer: ACME", or "Market: ACME: Chicago"
		/// </summary>
		public string LinkText {
			get
			{
				switch (ObjectType)
				{
					case ObjectTypeEnum.Asset:
					case ObjectTypeEnum.Market:
					case ObjectTypeEnum.Customer:
						return string.Format("{0}: {1}", ObjectType, ObjectName);
					default:
						return string.Format("{0}: {1}", ObjectType, ObjectID);
				}
			}
		}

		public static ClassSubscription GetByID(int subscriptionID)
		{
			ClassSubscription sub = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM user_subscriptions
						WHERE id = @id;";
					cmd.Parameters.AddWithValue("id", subscriptionID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							sub = GetFromReader(reader);
				}
				conn.Close();
			}
			return sub;
		}

		/// <summary>
		/// Returns a list of <see cref="ClassSubscription"/>s for the specified object.
		/// If the object has a parent, subscriptions for the parent are also returned.
		/// (For example, a ticket has a parent asset, an asset has a parent market, and a market has a parent customer.)
		/// </summary>
		public static IEnumerable<ClassSubscription> GetByObject(ObjectTypeEnum objectType, int objectID)
		{
			var subscriptions = new List<ClassSubscription>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, user_id, obj_name
						FROM user_subscriptions
						WHERE obj_type = @obj_type
						AND obj_id = @obj_id;";
					cmd.Parameters.AddWithValue("obj_type", objectType.ToString());
					cmd.Parameters.AddWithValue("obj_id", objectID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							subscriptions.Add(new ClassSubscription
												  {
													  ID = reader.GetDBInt("id"),
													  UserID = reader.GetDBInt("user_id"),
													  ObjectType = objectType,
													  ObjectID = objectID,
													  ObjectName = reader.GetDBString_Null("obj_name")
												  });
						}
				}

				switch (objectType)
				{
					case ObjectTypeEnum.Asset:
						// Get parent market
						subscriptions.AddRange(GetByObject(ObjectTypeEnum.Market, ClassMarket.GetMarketIDByAsset(objectID)).ToList());
						break;

					case ObjectTypeEnum.Customer:
						// No parent
						break;

					case ObjectTypeEnum.Market:
						// Get parent customer
						subscriptions.AddRange(GetByObject(ObjectTypeEnum.Customer, ClassCustomer.GetCustomerIDByMarket(objectID)).ToList());
						break;

					case ObjectTypeEnum.RMA:
						// Get parent ticket
						subscriptions.AddRange(GetByObject(ObjectTypeEnum.Ticket,  ClassTicket.GetID_ByRMA(objectID)).ToList());
						break;

					case ObjectTypeEnum.Shipment:
						// Parents can be tickets, RMAs, and assets
						var inventory = ClassShipment.GetInventory(objectID).ToList();
						var ticketIDs = inventory.Where(i => i.Ticket_ID.HasValue).Select(i => i.Ticket_ID.Value).Distinct().ToArray();
						var rmaIDs = inventory.Where(i => i.RMA_ID.HasValue).Select(i => i.RMA_ID.Value).Distinct().ToArray();
						var assetIDs = inventory.Where(i => i.Asset_ID.HasValue).Select(i => i.Asset_ID.Value).Distinct().ToArray();

						foreach (var t in ticketIDs)
							subscriptions.AddRange(GetByObject(ObjectTypeEnum.Ticket, t));
						foreach (var r in rmaIDs)
							subscriptions.AddRange(GetByObject(ObjectTypeEnum.RMA, r));
						foreach (var a in assetIDs)
							subscriptions.AddRange(GetByObject(ObjectTypeEnum.Asset, a));
						break;

					case ObjectTypeEnum.Ticket:
						// Get parent asset
						subscriptions.AddRange(GetByObject(ObjectTypeEnum.Asset, ClassAsset.GetAssetIDByTicket(objectID)).ToList());
						break;
				}
				conn.Close();
			}

			return subscriptions;
		}

		/// <summary>
		/// Returns a list of <see cref="ClassSubscription"/>s for the specified user.
		/// </summary>
		public static IEnumerable<ClassSubscription> GetByUser(int userID)
		{
			var subscriptions = new List<ClassSubscription>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, obj_type, obj_id, obj_name
						FROM user_subscriptions
						WHERE user_id = @user_id;";
					cmd.Parameters.AddWithValue("user_id", userID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							subscriptions.Add(new ClassSubscription
												  {
													  ID = reader.GetDBInt("id"),
													  UserID = userID,
													  ObjectType = (ObjectTypeEnum)Enum.Parse(typeof(ObjectTypeEnum), reader.GetDBString("obj_type")),
													  ObjectID = reader.GetDBInt("obj_id"),
													  ObjectName = reader.GetDBString_Null("obj_name")
												  });
						}
				}
				conn.Close();
			}
			return subscriptions;
		}

		/// <summary>
		/// Gets the subscription for the specified user and object; null if no subscription exists for the data combination.
		/// </summary>
		public static ClassSubscription GetByUserAndObject(int userID, ObjectTypeEnum objectType, int objectID)
		{
			ClassSubscription userObjectSubscription = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id
						FROM user_subscriptions
						WHERE obj_type = @obj_type
						AND obj_id = @obj_id
						AND user_id = @user_id;";
					cmd.Parameters.AddWithValue("obj_type", objectType.ToString());
					cmd.Parameters.AddWithValue("obj_id", objectID);
					cmd.Parameters.AddWithValue("user_id", userID);
					using (var reader = cmd.ExecuteReader())
						if (reader.Read())
							userObjectSubscription = GetByID(reader.GetDBInt("id"));
				}
				conn.Close();
			}
			return userObjectSubscription;
		}

		/// <summary>
		/// Unsubscribes the current user from an object.
		/// </summary>
		/// <param name="objectType">The object type.</param>
		/// <param name="objectID">The object ID.</param>
		public static void Unsubscribe(ObjectTypeEnum objectType, int objectID)
		{
			var sub = GetByUserAndObject(GS.Settings.LoggedOnUser.ID, objectType, objectID);
			if (sub != null)
				Unsubscribe(sub);
		}

		/// <summary>
		/// Removes the specified subscription.
		/// </summary>
		public static void Unsubscribe(ClassSubscription subscription)
		{
			if (subscription == null)
				return;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("subscription_id", subscription.ID);

					cmd.CommandText =
						@"DELETE FROM user_subscriptions
						WHERE id = @subscription_id;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE user_notifications
						SET subscription_id = NULL
						WHERE subscription_id = @subscription_id;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Unsubscribes all users from the specified object but leaves notifications intact. Use when an object is closed or deleted.
		/// </summary>
		public static void UnsubscribeObject(ObjectTypeEnum objectType, int objectID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("obj_type", objectType.ToString());
					cmd.Parameters.AddWithValue("obj_id", objectID);

					cmd.CommandText =
						@"DELETE FROM user_subscriptions
						WHERE obj_type = @obj_type
						AND obj_id = @obj_id;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"UPDATE user_notifications
						SET subscription_id = NULL
						WHERE obj_type = @obj_type
						AND obj_id = @obj_id;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Unsubscribe a user from ALL objects. (For the user login being disabled or similar activity.)
		/// Also deletes all notifications for that user.
		/// </summary>
		/// <param name="userID">User ID to unsubscribe.</param>
		public static void UnsubscribeAll(int userID)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("user_id", userID);

					cmd.CommandText =
						@"DELETE FROM user_subscriptions
						WHERE user_id = @user_id;";
					cmd.ExecuteNonQuery();

					cmd.CommandText =
						@"DELETE FROM user_notifications
						WHERE notify_user = @user_id;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Subscribe the current user to an object.
		/// Does not cause an error if the user is already subscribed to the object.
		/// </summary>
		/// <param name="objectType">The object type.</param>
		/// <param name="objectID">The object ID.</param>
		/// <param name="objectName">Name of the object (for Assets, Markets, and Customers or any object which is not referred to by ID)</param>
		public static void Subscribe(ObjectTypeEnum objectType, int objectID, string objectName = null)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT IGNORE INTO user_subscriptions
						(user_id, obj_type, obj_id, obj_name)
						VALUES
						(@user_id, @obj_type, @obj_id, @obj_name);";
					cmd.Parameters.AddWithValue("user_id", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("obj_type", objectType.ToString());
					cmd.Parameters.AddWithValue("obj_id", objectID);
					cmd.Parameters.AddWithValue("obj_name", objectName);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Whether the specified user is subscribed to the specified object.
		/// </summary>
		public static bool IsUserSubscribed(int userID, ObjectTypeEnum objectType, int objectID)
		{
			bool isSubscribed;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(id)
						FROM user_subscriptions
						WHERE user_id = @user_id
						AND obj_type = @obj_type
						ANd obj_id = @obj_id;";
					cmd.Parameters.AddWithValue("user_id", userID);
					cmd.Parameters.AddWithValue("obj_type", objectType.ToString());
					cmd.Parameters.AddWithValue("obj_id", objectID);
					isSubscribed = Convert.ToInt32(cmd.ExecuteScalar()) == 1;
				}
				conn.Close();
			}
			return isSubscribed;
		}

		private static ClassSubscription GetFromReader(MySqlDataReader reader)
		{
			return new ClassSubscription
			{
				ID = reader.GetDBInt("id"),
				ObjectID = reader.GetDBInt("obj_id"),
				ObjectType = (ObjectTypeEnum)Enum.Parse(typeof(ObjectTypeEnum), reader.GetDBString("obj_type")),
				ObjectName = reader.GetDBString_Null("obj_name"),
				UserID = reader.GetDBInt("user_id")
			};
		}
	}
}