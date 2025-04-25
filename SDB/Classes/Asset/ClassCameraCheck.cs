using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
	/// <summary>
	/// Camera check class which represents a camera check submission in the asset_camera_check table
	/// </summary>
	public class ClassCameraCheck
	{
		#region Delegates and Events
		#endregion

		#region Enums and Structs
		public enum CheckStatus
		{
			Failed = 0,
			Passed = 1,
			Unassigned = 2
		};
		#endregion

		#region Private Fields
		#endregion

		#region Public Properties
		public int ID { get; set; }
		public int Asset_ID { get; set; }
		public int User_ID { get; set; }
		public DateTime Submitted { get; set; }
		public DateTime? ImageDateTime { get; set; }
		public string ImageName { get; set; }
		public CheckStatus Status { get; set; }
		public int? Symptom_ID { get; set; }
		public int? Ticket_ID { get; set; }
		public bool? NewTicket { get; set; }

		public static readonly Color COLOR_UNDETERMINED = Color.FromArgb(224, 224, 224);
		public static readonly Color COLOR_PASS = Color.Green;
		public static readonly Color COLOR_FAIL = Color.Red;
		#endregion

		#region Constructor
		#endregion

		#region Private Methods
		private static ClassCameraCheck GetFromReader(MySqlDataReader reader)
		{
			return new ClassCameraCheck
			{
				ID = reader.GetDBInt("id"),
				Asset_ID = reader.GetDBInt("asset_id"),
				User_ID = reader.GetDBInt("user_id"),
				Submitted = reader.GetDBDateTime("submit_dt"),
				ImageDateTime = reader.GetDBDateTime_Null("image_dt"),
				ImageName = reader.GetDBString("image_name"),
				Status = NullIntToCameraCheckStatus(reader.GetDBInt("status")),
				Symptom_ID = reader.GetDBInt_Null("symptom_id"),
				Ticket_ID = reader.GetDBInt_Null("ticket_id"),
				NewTicket = reader.GetDBBool_Null("new_ticket")
			};
		}

		private static CheckStatus NullIntToCameraCheckStatus(int val)
		{
			switch (val)
			{
				case 0:
					return CheckStatus.Failed;

				case 1:
					return CheckStatus.Passed;

				default:
					return CheckStatus.Unassigned;
			}
		}

		private static CameraCheckQtys GetDueQtys_NoTickets()
		{
			var qtys = new CameraCheckQtys { Normal = 0, Ticketed = 0, Blackout = 0 };
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT
							SUM(IF(cc.blackout = 0, 1, 0)) normal,
							0 ticketed,
							SUM(IF(cc.blackout > 0, 1, 0)) blackout
						FROM
						(
							SELECT
								COALESCE(b.active, 0) blackout
							FROM assets a
								LEFT JOIN
								(
									SELECT ab.asset_id, 1 active
									FROM asset_blackout ab
									WHERE (ab.daymask >> 7 - DAYOFWEEK(NOW())) & 1 = 1
										AND
										(
											(HOUR(NOW()) * 60 + MINUTE(NOW()) >= ab.start AND HOUR(NOW()) * 60 + MINUTE(NOW()) < ab.stop)
											OR
											(HOUR(NOW()) * 60 + MINUTE(NOW()) >= ab.start AND ab.stop = 0)
										)
								) AS b ON b.asset_id = a.id
							WHERE
								(
									a.camera_check_lastsubmit IS NULL
									OR 
									NOW() > DATE_ADD(a.camera_check_lastsubmit, INTERVAL (CAST(a.camera_check_interval AS SIGNED) - {0}) MINUTE)
								)
								AND (DATE(a.labor_w_end_dt) > CURDATE() OR DATE(a.labor_c_end_dt) > CURDATE())
								AND a.webcaminstalled IS TRUE
								AND a.camera_check_interval > 0
								AND a.retired IS FALSE
							GROUP BY a.id
						) AS cc;", ClassConfig.GetCameraCheckPaddingMinutes());
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							qtys.Normal = reader.GetDBInt("normal");
							qtys.Ticketed = reader.GetDBInt("ticketed");
							qtys.Blackout = reader.GetDBInt("blackout");
						}
					}
				}
				conn.Close();
			}
			return qtys;
		}

		private static CameraCheckQtys GetDueQtys_WithTickets()
		{
			var qtys = new CameraCheckQtys { Normal = 0, Ticketed = 0, Blackout = 0 };
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT
							SUM(IF(cc.ticket_qty = 0 AND cc.blackout  = 0, 1, 0)) normal,
							SUM(IF(cc.ticket_qty > 0, 1, 0)) ticketed,
							SUM(IF(cc.blackout > 0 AND cc.ticket_qty = 0, 1, 0)) blackout
						FROM
						(
							SELECT
								COUNT(t.id) ticket_qty,
								COALESCE(b.active, 0) blackout
							FROM assets a
								LEFT JOIN tickets t ON (t.asset_id = a.id AND t.close_dt IS NULL AND t.deleted IS FALSE)
								LEFT JOIN
								(
									SELECT ab.asset_id, 1 active
									FROM asset_blackout ab
									WHERE (ab.daymask >> 7 - DAYOFWEEK(NOW())) & 1 = 1
										AND
										(
											(HOUR(NOW()) * 60 + MINUTE(NOW()) >= ab.start AND HOUR(NOW()) * 60 + MINUTE(NOW()) < ab.stop)
											OR
											(HOUR(NOW()) * 60 + MINUTE(NOW()) >= ab.start AND ab.stop = 0)
										)
								) AS b ON b.asset_id = a.id
							WHERE
								(
									a.camera_check_lastsubmit IS NULL
									OR 
									NOW() > DATE_ADD(a.camera_check_lastsubmit, INTERVAL (CAST(a.camera_check_interval AS SIGNED) - {0}) MINUTE)
								)
								AND (DATE(a.labor_w_end_dt) > CURDATE() OR DATE(a.labor_c_end_dt) > CURDATE())
								AND a.webcaminstalled IS TRUE
								AND a.camera_check_interval > 0
								AND a.retired IS FALSE
							GROUP BY a.id
						) AS cc;", ClassConfig.GetCameraCheckPaddingMinutes());
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							qtys.Normal = reader.GetDBInt("normal");
							qtys.Ticketed = reader.GetDBInt("ticketed");
							qtys.Blackout = reader.GetDBInt("blackout");
						}
					}
				}
				conn.Close();
			}
			return qtys;
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// Submits a camera check for the specified asset.
		/// </summary>
		/// <param name="assetID">Asset which the camera check is for.</param>
		/// <param name="status">Pass/fail status</param>
		/// <param name="symptomID">The ticket symptom ID (if applicable and visible).</param>
		/// <param name="imageName">Name of the image (most recent) used to evaluate the camera check. Null if N/A.</param>
		/// <param name="imageDateTime">Datetime of the image (most recent) used to evaluate the camera check. Null if N/A.</param>
		public static bool Submit(int assetID, CheckStatus status, int? symptomID, string imageName, DateTime? imageDateTime)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT a.camera_check_request_user, a.camera_check_request_dt
						FROM assets a
						WHERE a.id = @assetID;";
					cmd.Parameters.AddWithValue("assetID", assetID);
					using (var reader = cmd.ExecuteReader())
					{
						reader.Read();
						var requestUserId = reader.GetDBInt_Null("camera_check_request_user");
						var requestDateTime = reader.GetDBDateTime_Null("camera_check_request_dt");
						if (requestUserId.HasValue && requestUserId.Value != GS.Settings.LoggedOnUser.ID)
						{
							ClassLogFile.AppendToLog($"CC submit fail.  Asset ID: {assetID}  Request UID: {requestUserId}  Request DT: {requestDateTime}");
							return false;
						}
					}

					cmd.Parameters.Clear();
					cmd.CommandText =
						@"INSERT INTO asset_camera_check
						(asset_id, user_id, submit_dt, image_dt, image_name, status, symptom_id)
						VALUES
						(@assetID, @userID, NOW(), @imageDateTime, @imageName, @status, @symptom_id);";
					cmd.Parameters.AddWithValue("assetID", assetID);
					cmd.Parameters.AddWithValue("userID", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("imageDateTime", imageDateTime);
					cmd.Parameters.AddWithValue("imageName", imageName);
					cmd.Parameters.AddWithValue("status", (int)status);
					cmd.Parameters.AddWithValue("symptom_id", symptomID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			return true;
		}

		/// <summary>
		/// Adds a Ticket ID to the specified camera check, covering it (clearing it from fail by pointing to a covering ticket).
		/// </summary>
		/// <returns>True if successful, false if already covered.</returns>
		public bool Cover(int ticketID, bool isNewTicket)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT new_ticket
						FROM asset_camera_check
						WHERE id = @cameraCheckID;";
					cmd.Parameters.AddWithValue("cameraCheckID", ID);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows && reader.Read())
						{
							var coveringTicket = reader.GetDBInt_Null("new_ticket");
							if (coveringTicket.HasValue)
								return false;
						}
					}
					
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE asset_camera_check SET
						ticket_id = @ticketID,
						new_ticket= @isNewTicket
						WHERE id = @cameraCheckID;";
					cmd.Parameters.AddWithValue("ticketID", ticketID);
					cmd.Parameters.AddWithValue("isNewTicket", isNewTicket);
					cmd.Parameters.AddWithValue("cameraCheckID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			return true;
		}

		/// <summary>
		/// Changes camera check from fail to pass. Should only be invoked by users with appropriate permissions.
		/// Changes camera check submission from original submitter to currently logged in user.
		/// </summary>
		public void Revert()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE asset_camera_check SET
						status = @checkStatus,
						user_id = @revertUserId,
						ticket_id = NULL,
						new_ticket = NULL
						WHERE id = @cameraCheckID;";
					cmd.Parameters.AddWithValue("checkStatus", (int)CheckStatus.Passed);
					cmd.Parameters.AddWithValue("revertUserId", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("cameraCheckID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Gets all camera checks that are marked as failed and have no ticket coverage.
		/// For speed, only considers last 3 days of data.
		/// </summary>
		public static List<ClassCameraCheck> GetFails()
		{
			var failedCameraChecks = new List<ClassCameraCheck>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT acc.*
						FROM asset_camera_check acc
						WHERE id IN
							(
								SELECT MAX(acc.id)
								FROM asset_camera_check acc
								FORCE INDEX (submit_dt_IX)
								WHERE submit_dt >= DATE_SUB(NOW(), INTERVAL 3 DAY)
								GROUP BY acc.asset_id
							)
							AND acc.ticket_id IS NULL
							AND acc.status = 0;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							failedCameraChecks.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return failedCameraChecks;
		}

		/// <summary>
		/// Gets the specified camera check.
		/// </summary>
		public static ClassCameraCheck GetByID(int id)
		{
			ClassCameraCheck cc = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = 
						@"SELECT acc.*
						FROM asset_camera_check acc
						WHERE acc.id = @cameraCheckID;";
					cmd.Parameters.AddWithValue("cameraCheckID", id);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							cc = GetFromReader(reader);
				}
				conn.Close();
			}
			return cc;
		}

		/// <summary>
		/// Gets all camera checks submitted by specified user IDs within specified time period.
		/// </summary>
		public static List<ClassCameraCheck> GetByUser(int[] userIDs, DateTime start, DateTime stop, bool onlyFailed = false)
		{
			var userCameraChecks = new List<ClassCameraCheck>();
			if (!userIDs.Any())
				return userCameraChecks;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT acc.*
						FROM asset_camera_check acc
						WHERE acc.user_id IN ({0})
						AND submit_dt >= @start
						AND submit_dt <= @stop
						{1};", string.Join(",", userIDs), onlyFailed ? @"AND status = 0" : string.Empty);
					cmd.Parameters.AddWithValue("start", start);
					cmd.Parameters.AddWithValue("stop", stop);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							userCameraChecks.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return userCameraChecks;
		}

		/// <summary>
		/// Gets all camera checks submitted for specified market IDs within specified time period.
		/// </summary>
		public static List<ClassCameraCheck> GetByMarket(int[] marketIDs, DateTime start, DateTime stop, bool onlyFailed = false)
		{
			var marketCameraChecks = new List<ClassCameraCheck>();
			if (!marketIDs.Any())
				return marketCameraChecks;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT acc.*
						FROM asset_camera_check acc
						JOIN assets a ON acc.asset_id = a.id
						WHERE a.market_id IN ({0})
						AND submit_dt >= @start
						AND submit_dt <= @stop
						{1};", string.Join(",", marketIDs), onlyFailed ? @"AND status = 0" : string.Empty);
					cmd.Parameters.AddWithValue("start", start);
					cmd.Parameters.AddWithValue("stop", stop);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							marketCameraChecks.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return marketCameraChecks;
		}

		/// <summary>
		/// Gets the number of camera checks that are due (or going to be within the padding tolerance).
		/// </summary>
		public static CameraCheckQtys GetDueQtys()
		{
			return ClassConfig.GetCameraCheckTicketModeEnabled() ? GetDueQtys_WithTickets() : GetDueQtys_NoTickets();
		}

		/// <summary>
		/// Gets the number of camera checks that have been marked as failed and do not have tickets to cover them.
		/// </summary>
		/// <returns></returns>
		public static int GetFailQty()
		{
			int qty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(*)
						FROM asset_camera_check acc
						WHERE id IN
							(
								SELECT MAX(acc.id)
								FROM asset_camera_check acc
								FORCE INDEX (submit_dt_IX)
								WHERE submit_dt >= DATE_SUB(NOW(), INTERVAL 3 DAY)
								GROUP BY acc.asset_id
							)
							AND acc.ticket_id IS NULL
							AND acc.status = 0
							AND acc.submit_dt >= DATE_SUB(NOW(), INTERVAL 3 DAY);";
					qty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return qty;
		}

		public static Image GetImageForCameraCheck(ClassCameraCheck cameraCheck)
		{
			if (string.IsNullOrEmpty(cameraCheck.ImageName))
				return GenerateNoImagesBitmap();

			var assetName = ClassAsset.GetName(cameraCheck.Asset_ID);
			var assetFolder = Path.Combine(GS.Settings.CameraImagePath, assetName);
			var assetDateFolder = string.Format("{0}_{1:yyyyMMdd}", assetName, cameraCheck.ImageDateTime);
			var imageFile = Path.Combine(assetFolder, assetDateFolder, cameraCheck.ImageName);
			return File.Exists(imageFile) ? new Bitmap(imageFile) : GenerateImageNotFoundBitmap();
		}

		/// <summary>
		/// Gets camera images from the current <see cref="CameraCheckAsset.RequestTime"/> going back the camera check interval.
		/// For example if camera check interval is 60 minutes, searches for images from now to 60 minutes ago.
		/// Returns all images from now until camera check interval ago, or <paramref name="maxImagesToReturn"/> (default 10) at most.
		/// </summary>
		public static IEnumerable<CameraCheckImageReference> GetLastImages(CameraCheckAsset ccAsset, int maxImagesToReturn = 10)
		{
			var imageRefs = new List<CameraCheckImageReference>();
			var assetFolderName = ClassUtility.MakeSafeFileName(ccAsset.Asset.AssetName);
			var assetCameraFolder = Path.Combine(GS.Settings.CameraImagePath, assetFolderName);
			var oldestAllowedImageTime = ccAsset.RequestTime.AddMinutes(-ccAsset.Asset.CameraCheckInterval);

			// Check subfolder matching today's date first and work backward as needed until N images obtained
			// In normal cases the loop should only need to check the current date and possibly the previous day (when checking near midnight)
			var daysAgo = 0;
			var quotaMet = false;
			while (!quotaMet && imageRefs.Count < maxImagesToReturn && daysAgo < 2)
			{
				var assetDayFolderName = string.Format("{0}_{1:yyyyMMdd}", ccAsset.Asset.AssetName, ccAsset.RequestTime.AddDays(-daysAgo));
				var assetDayFolderPath = Path.Combine(assetCameraFolder, assetDayFolderName);
				if (!Directory.Exists(assetDayFolderPath))
				{
					daysAgo++;
					continue;
				}
				try
				{
					var assetDayFolderInfo = new DirectoryInfo(assetDayFolderPath);
					var imageFiles = assetDayFolderInfo.GetFiles("*.jpg", SearchOption.TopDirectoryOnly).OrderByDescending(f => f.LastWriteTime);

					foreach (var imageFile in imageFiles)
					{
						if (ClassUtility.GetDateTimeFromCameraImageFileName(imageFile.Name) < oldestAllowedImageTime)
						{
							quotaMet = true;
							break;
						}
						imageRefs.Add(new CameraCheckImageReference(imageFile));
						if (imageRefs.Count >= maxImagesToReturn)
						{
							quotaMet = true;
							break;
						}
					}
				}
				catch (IOException exc)
				{
					ClassLogFile.AppendToLog("Error getting camera check images", exc);
				}
				daysAgo++;
			}
			return imageRefs.OrderBy(i => i.ImageDate);
		}

		public static Bitmap GenerateNoImagesBitmap()
		{
			var noImagesBitmap = new Bitmap(320, 240);
			using (var g = Graphics.FromImage(noImagesBitmap))
			{
				const string NO_IMAGES_MESSAGE = "NO IMAGES";
				var font = new Font("Arial Black", 18F);
				var brush = Brushes.Red;

				var messageSize = g.MeasureString(NO_IMAGES_MESSAGE, font);
				var messageTopLeftPoint = new PointF((noImagesBitmap.Width / 2F) - (messageSize.Width / 2F), (noImagesBitmap.Height / 2F) - (messageSize.Height / 2F));

				g.Clear(Color.Black);
				g.DrawString(NO_IMAGES_MESSAGE, font, brush, messageTopLeftPoint);
			}
			return noImagesBitmap;
		}

		public static Bitmap GenerateImageNotFoundBitmap()
		{
			var imageNotFoundBitmap = new Bitmap(320, 240);
			using (var g = Graphics.FromImage(imageNotFoundBitmap))
			{
				const string IMAGE_NOT_FOUND_MESSAGE = "IMAGE NOT FOUND";
				var font = new Font("Arial Black", 18F);
				var brush = Brushes.Orange;

				var messageSize = g.MeasureString(IMAGE_NOT_FOUND_MESSAGE, font);
				var messageTopLeftPoint = new PointF((imageNotFoundBitmap.Width / 2F) - (messageSize.Width / 2F), (imageNotFoundBitmap.Height / 2F) - (messageSize.Height / 2F));

				g.Clear(Color.Black);
				g.DrawString(IMAGE_NOT_FOUND_MESSAGE, font, brush, messageTopLeftPoint);
			}
			return imageNotFoundBitmap;
		}

		/// <summary>
		/// Returns false if camera check is currently locked. If not, locks it and returns true.
		/// </summary>
		public static bool ObtainLock()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"SELECT is_locked FROM asset_camera_check_lock WHERE id = 1;";
					var isLocked = Convert.ToBoolean(cmd.ExecuteScalar());
					if (isLocked)
						return false;

					cmd.CommandText =
						@"UPDATE asset_camera_check_lock
						SET is_locked = 1,
						locked_by = @userID
						WHERE id = 1;";
					cmd.Parameters.AddWithValue("userID", GS.Settings.LoggedOnUser.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			return true;
		}

		public static void ReleaseLock()
		{
           using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
                    cmd.CommandText =
						@"UPDATE asset_camera_check_lock
						SET is_locked = 0,
						locked_by = NULL
						WHERE id = 1;";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		public static int GetLockedBy()
		{
			int lockedByUserID;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT locked_by
						FROM asset_camera_check_lock
						WHERE id = 1;";
					lockedByUserID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return lockedByUserID;
		}

		/// <summary>
		/// Forcibly removes prior lock.
		/// </summary>
		public static void ForceClearLock()
		{
			var lockedByUserID = GetLockedBy();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"UPDATE asset_camera_check_lock
						SET is_locked = 0,
						locked_by = NULL
						WHERE id = 1;";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            ClassLogFile.AppendToLog(string.Format("Forcibly cleared camera check lock (by {0}).", lockedByUserID));
		}

		/// <summary>
		/// Checks if access to camera check folder is working and more than one subfolder (asset folder) is visible.
		/// </summary>
		public static bool ValidateCameraCheckFolder()
		{
			if (!Directory.Exists(GS.Settings.CameraImagePath))
				return false;

			var cameraRootFolder = new DirectoryInfo(GS.Settings.CameraImagePath);
			var assetFolders = cameraRootFolder.GetDirectories();
			return assetFolders.Any();
		}
		#endregion
	}

	/// <summary>
	/// Simple class which combines a <see cref="ClassAsset"/> and list of <see cref="CameraCheckImageReference"/> with a datetime for the request.
	/// </summary>
	public class CameraCheckAsset
	{
		public ClassAsset Asset { get; set; }
		public List<CameraCheckImageReference> ImageList { get; set; }
		public DateTime RequestTime { get; set; }

		public CameraCheckAsset(int assetID, DateTime requestTime)
		{
			Asset = ClassAsset.GetByID(assetID);
			ImageList = new List<CameraCheckImageReference>();
			RequestTime = requestTime;
		}
	}

	/// <summary>
	/// Wrapper class for a camera check image. Contains FileInfo for the file but uses the datetime encapsulated in the filename rather than the file system date.
	/// </summary>
	public class CameraCheckImageReference
	{
		/// <summary>
		/// System.IO.FileInfo for the image file
		/// </summary>
		public FileInfo ImageFileInfo { get; set; }
		/// <summary>
		/// The image date as specified in the image filename, which may differ from the FileInfo.LastWriteTime.
		/// </summary>
		public DateTime ImageDate { get; set; }

		public CameraCheckImageReference(FileInfo imageFileInfo)
		{
			ImageFileInfo = imageFileInfo;
			ImageDate = ClassUtility.GetDateTimeFromCameraImageFileName(ImageFileInfo.Name);
		}
	}

	public struct CameraCheckQtys
	{
		public int Normal { get; set; }
		public int Ticketed { get; set; }
		public int Blackout { get; set; }

		public int Total => Normal + Ticketed + Blackout;
	}
}