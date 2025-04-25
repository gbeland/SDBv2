using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.Tech;
using Seagull.BarTender.Print;

namespace SDB.Classes.RMA
{
	/// <summary>
	/// Describes a container of assemblies submitted for RMA repair. A bin contains multiple assemblies.
	/// </summary>
	public class ClassRMA_Bin
	{
		public const string RMA_BIN_LABEL_DOCUMENT = @"RMA Bin Label.btw";
		private const int _LABEL_PRINT_TIMEOUT_MS = 8000;

		private static readonly Regex _binIDRegex = new Regex(@"^B(?<binID>[0-9]{1,6})$");

		/// <summary>
		/// Internal unique bin ID; primary key in DB
		/// </summary>
		public int ID { get; set; }

		/// <summary>
		/// The zone ID the bin is currently stored in (physically in the warehouse)
		/// Note Zone ID is the database ID, not the zone name.
		/// A null Zone_ID means the bin has been generated in receiving but not stored anywhere yet.
		/// </summary>
		public int? Zone_ID { get; private set; }

		public DateTime CreationDate { get; private set; }
		public int CreationUserID { get; private set; }

		/// <summary>
		/// Optional (for lists), not in table
		/// </summary>
		public int AssemblyQty { get; set; }
		/// <summary>
		/// Optional, not in table
		/// </summary>
		public string ZoneName { get; set; }

		[UsedImplicitly]
		public string ListDisplayMember => string.Format("{0} (in {1}) ({2} assembl{3})", BinName, ZoneName ?? "N/A", AssemblyQty, AssemblyQty == 1 ? "y" : "ies");

		[UsedImplicitly]
		public string DisplayMember => BinName;

		/// <summary>
		/// Returns the Bin ID as referred to by users (and printed on labels).
		/// </summary>
		public string BinName => string.Format("B{0:00000}", ID);

		public static string FormatBinName(int binID)
		{
			return string.Format("B{0:00000}", binID);
		}

		public override string ToString()
		{
			return string.Format("{0}, Zone ID {1}", BinName, Zone_ID.HasValue ? Zone_ID.Value.ToString(CultureInfo.InvariantCulture) : "NULL");
		}

		public ClassRMA_Bin()
		{
			ID = 0;
			Zone_ID = null;
		}

		public static ClassRMA_Bin GetByID(int? binID)
		{
			if (binID == null)
				return null;

			ClassRMA_Bin bin = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id, zone_id, creation_date, creation_user
							FROM rma_bins rb
						WHERE rb.id = @binID;";
					cmd.Parameters.AddWithValue("binID", binID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							bin = GetFromReader(reader);
				}
				conn.Close();
			}
			return bin;
		}

		/// <summary>
		/// Uses the human-readable Bin ID String (i.e. B000001)
		/// </summary>
		public static ClassRMA_Bin GetByName(string binName)
		{
			var match = _binIDRegex.Match(binName);
			if (!match.Success)
				return null;

			int binID = int.Parse(match.Result("${binID}"));
			int foundBinID;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT id
						FROM rma_bins
						WHERE id = @binID;";
					cmd.Parameters.AddWithValue("binID", binID);
					foundBinID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return GetByID(foundBinID);
		}

		private static ClassRMA_Bin GetFromReader(MySqlDataReader reader)
		{
			return new ClassRMA_Bin
				       {
					       ID = reader.GetDBInt("id"),
					       Zone_ID = reader.GetDBInt_Null("zone_id"),
						   CreationDate = reader.GetDBDateTime("creation_date"),
						   CreationUserID = reader.GetDBInt("creation_user")
				       };
		}

		/// <summary>
		/// Gets all bins in system.
		/// </summary>
		public static List<ClassRMA_Bin> GetAll()
		{
			var bins = new List<ClassRMA_Bin>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT rb.id, rb.zone_id, rb.creation_date, rb.creation_user,
							COUNT(ra.id) assembly_qty,
							rz.zone zone_name
						FROM rma_bins rb
						LEFT JOIN rma_assemblies ra ON ra.bin_id = rb.id
						LEFT JOIN rma_zones rz ON rb.zone_id = rz.id
						GROUP BY rb.id;";
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var bin = GetFromReader(reader);
							bin.AssemblyQty = reader.GetDBInt("assembly_qty");
							bin.ZoneName = reader.GetDBString_Null("zone_name");
							bins.Add(bin);
						}
					}
				}
				conn.Close();
			}
			return bins;
		}

		/// <summary>
		/// Creates a new bin in the database and assigns it to the default zone. If no default zone is specified, an error is generated.
		/// </summary>
		public static ClassRMA_Bin AddNew()
		{
			var defaultZone = ClassRMA_Zone.GetDefault();
			if (defaultZone == null)
				throw new Exception("No default zone specified.");

			var newBin = new ClassRMA_Bin();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO rma_bins
							(zone_id, creation_date, creation_user)
						VALUES
							(@zoneID, NOW(), @creation_user);";
					cmd.Parameters.AddWithValue("zoneID", defaultZone.ID);
					cmd.Parameters.AddWithValue("creation_user", GS.Settings.LoggedOnUser.ID);
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					newBin.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.RMABin, newBin.ID, newBin.BinName);
			UpdateBinHistory(newBin.ID, ClassRMA_BinHistory.BinEventType.Created, null);
			return newBin;
		}

		/// <summary>
		/// Marks bin as being stored at specified zone.
		/// </summary>
		public void Move(int newZoneID)
		{
			var prevZoneName = Zone_ID.HasValue ? ClassRMA_Zone.GetByID(Zone_ID.Value).ZoneName : "NULL";
		
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_bins rb
							SET rb.zone_id = @newZoneID
						WHERE rb.id = @binID;";
					cmd.Parameters.AddWithValue("binID", ID);
					cmd.Parameters.AddWithValue("newZoneID", newZoneID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}

			var newZone = ClassRMA_Zone.GetByID(newZoneID);
			Zone_ID = newZone.ID;
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Moved, ClassEventLog.ObjectTypeEnum.RMABin, ID, string.Format("from {0} to {1}", prevZoneName, newZone.ZoneName));
			UpdateBinHistory(ID, ClassRMA_BinHistory.BinEventType.Moved, newZone.AreaAndZoneName());
		}

		/// <summary>
		/// Gets the last box (by ID) that contains assemblies for specified RMA.
		/// Returns null if none exist.
		/// </summary>
		public static ClassRMA_Bin GetLastBin(int rmaID)
		{
			ClassRMA_Bin bin = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT rb.id
							FROM rma_bins rb
							JOIN rma_assemblies ra ON ra.bin_id = rb.id
						WHERE ra.rma_id = @rmaID
						ORDER BY rb.id DESC
						LIMIT 1;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							bin = GetByID(reader.GetDBInt("id"));
				}
				conn.Close();
			}
			return bin;
		}

		/// <summary>
		/// Gets the quantity of assemblies assigned to bin.
		/// </summary>
		public int GetAssemblyQty()
		{
			int assyQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT COUNT(ra.id) assy_qty
						FROM rma_assemblies ra
						WHERE ra.bin_id = @binID";
					cmd.Parameters.AddWithValue("binID", ID);
					assyQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return assyQty;
		}

		/// <summary>
		/// Deletes bin from database. Ensure the bin is empty by calling <see cref="GetAssemblyQty"/> first.
		/// </summary>
		public void DeleteBin()
		{
			var binName = BinName;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM
						rma_bins
						WHERE id = @binID";
					cmd.Parameters.AddWithValue("binID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.RMABin, ID, binName);
			UpdateBinHistory(ID, ClassRMA_BinHistory.BinEventType.Deleted, null);
		}

		/// <summary>
		/// Assigns specified RMA Assembly ID to this bin.
		/// If assembly is already assigned to another bin, that assignment will be removed.
		/// </summary>
		public void AssignAssemblyToBin(ClassRMA.ClassRMAAssembly rmaAssembly)
		{
			if(ID < 1 || rmaAssembly == null)
				throw new ArgumentOutOfRangeException("rmaAssembly", "Invalid Bin or Assembly ID");

			UnassignAssemblyFromAnyBin(rmaAssembly.ID);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
						SET ra.bin_id = @binID
						WHERE ra.id = @rmaAssemblyID;";
					cmd.Parameters.AddWithValue("rmaAssemblyID", rmaAssembly.ID);
					cmd.Parameters.AddWithValue("binID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			UpdateBinHistory(ID, ClassRMA_BinHistory.BinEventType.AddAssembly, null, rmaAssembly.SerialNumber);
		}

		/// <summary>
		/// Removes assignment of assembly from any bins.
		/// </summary>
		public static void UnassignAssemblyFromAnyBin(int rmaAssemblyID)
		{
			int? binID;
			string serialNumber;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("assemblyID", rmaAssemblyID);
					cmd.CommandText =
						@"SELECT ra.bin_id, ra.serial_number
						FROM rma_assemblies ra
						WHERE ra.id = @assemblyID;";
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.HasRows && reader.Read())
						{
							binID = reader.GetDBInt_Null("bin_id");
							serialNumber = reader.GetDBString_Null("serial_number");
						}
						else return;
					}
					
					cmd.CommandText =
						@"UPDATE rma_assemblies ra
						SET ra.bin_id = NULL
						WHERE ra.id = @assemblyID";
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			UpdateBinHistory(binID, ClassRMA_BinHistory.BinEventType.RemoveAssembly, null, serialNumber);
		}

		/// <summary>
		/// Retrieves the box assigned to specified assembly. If assembly is not assigned to a box, returns null.
		/// </summary>
		public static ClassRMA_Bin GetBinForAssembly(int assemblyID)
		{
			var binID = GetBinIDForAssembly(assemblyID);
			return !binID.HasValue ? null : GetByID(binID.Value);
		}

		/// <summary>
		/// Gets box ID for specified assembly. Null if not assigned.
		/// </summary>
		private static int? GetBinIDForAssembly(int assemblyID)
		{
			int? binID = null;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT bin_id
						FROM rma_assemblies
						WHERE id = @assemblyID";
					cmd.Parameters.AddWithValue("assemblyID", assemblyID);

					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows && reader.Read())
							binID = reader.GetDBInt("bin_id");
				}
				conn.Close();
			}
			return binID;
		}

		/// <summary>
		/// Gets all bins for specified zone.
		/// If specified zone is null, all bins that are unassigned are retrieved.
		/// </summary>
		public static List<ClassRMA_Bin> GetByZone(int? zoneID)
		{
			var binsForZone = new List<ClassRMA_Bin>();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT id, zone_id, creation_date, creation_user
						FROM rma_bins
						WHERE {0};", zoneID.HasValue ? @"zone_id = @zoneID" : @"zone_id IS NULL");
					cmd.Parameters.AddWithValue("zoneID", zoneID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							binsForZone.Add(GetFromReader(reader));
				}
				conn.Close();
			}

			return binsForZone;
		}

		/// <summary>
		/// Gets all bins that contain assemblies for specified RMA.
		/// </summary>
		public static List<ClassRMA_Bin> GetByRMA(int rmaID)
		{
			var binsForRMA = new List<ClassRMA_Bin>();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT rb.id, rb.zone_id, rb.creation_date, rb.creation_user
						FROM rma_bins rb
							JOIN rma_assemblies ra ON ra.bin_id = rb.id
						WHERE ra.rma_id = @rmaID
						GROUP BY rb.id;";
					cmd.Parameters.AddWithValue("rmaID", rmaID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							binsForRMA.Add(GetFromReader(reader));
				}
				conn.Close();
			}

			return binsForRMA;
		}

		/// <summary>
		/// Gets all assemblies assigned to this bin.
		/// </summary>
		public List<ClassRMA.ClassRMAAssembly> GetAssemblies()
		{
			var assembliesForBin = new List<ClassRMA.ClassRMAAssembly>();

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ra.id
						FROM rma_assemblies ra
						WHERE ra.bin_id = @binID;";
					cmd.Parameters.AddWithValue("binID", ID);
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
						{
							var rmaAssyID = reader.GetDBInt("id");
							assembliesForBin.Add(ClassRMA.ClassRMAAssembly.GetByID(rmaAssyID));
						}
				}
				conn.Close();
			}

			return assembliesForBin;
		}

		/// <summary>
		/// Checks if supplied bin name is valid.
		/// </summary>
		public static bool ValidateBinName(string binName)
		{
			var match = _binIDRegex.Match(binName);
			return match.Success;
		}

		/// <summary>
		/// Adds an entry to the bin history table showing moves for this bin.
		/// </summary>
		private static void UpdateBinHistory(int? binId, ClassRMA_BinHistory.BinEventType eventType, string areaZoneName, string assemblySerialNumber = null)
		{
			if (!binId.HasValue && eventType != ClassRMA_BinHistory.BinEventType.RemoveAssembly)
				throw new ArgumentNullException("binId", "Bin ID cannot be empty except when removing an assembly from nonexistant bin.");

			// Do not record "RemoveAssembly" events for null bin.
			if (!binId.HasValue && eventType == ClassRMA_BinHistory.BinEventType.RemoveAssembly)
				return;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"INSERT INTO rma_bin_history
						(bin_id, user_id, event_type, rma_area_zone_name, datetime, assy_sn)
						VALUES
						(@id, @userId, @eventType, @rmaAreaZoneName, NOW(), @assemblySerialNumber);";
					cmd.Parameters.AddWithValue("id", binId);
					cmd.Parameters.AddWithValue("userId", GS.Settings.LoggedOnUser.ID);
					cmd.Parameters.AddWithValue("eventType", eventType.ToString());
					cmd.Parameters.AddWithValue("rmaAreaZoneName", areaZoneName.Truncate(32));
					cmd.Parameters.AddWithValue("assemblySerialNumber", assemblySerialNumber.Truncate(16));
					ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}

		/// <summary>
		/// Removes all empty bins in the database.
		/// </summary>
		/// <returns>Number of bins deleted.</returns>
		public static int DeleteAllEmpty()
		{
			var inUseBinIds = new List<int>();
			var emptyBinIds = new List<int>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Get list of in-use bin IDs
					cmd.CommandText =
						@"SELECT DISTINCT(bin_id)
						FROM rma_assemblies;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							inUseBinIds.Add(reader.GetDBInt("bin_id"));

					// Get list of empty bin IDs
					cmd.CommandText = string.Format(
						@"SELECT id
						FROM rma_bins
						WHERE id NOT IN ({0});", string.Join(",", inUseBinIds));

					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							emptyBinIds.Add(reader.GetDBInt("id"));

					if (!emptyBinIds.Any())
						return 0;

					foreach (var emptyBinId in emptyBinIds)
						UpdateBinHistory(emptyBinId, ClassRMA_BinHistory.BinEventType.Deleted, null);

					cmd.CommandText = string.Format(
						@"DELETE FROM
							rma_bins
						WHERE id IN ({0})", string.Join(",", emptyBinIds));
                    cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.RMABin, null, string.Format("{0} empty bins removed", emptyBinIds.Count));
			return emptyBinIds.Count;
		}

		public IEnumerable<ClassRMA_BinHistory> GetHistory()
		{
			return ClassRMA_BinHistory.GetHistoryForBin(ID);
		}

		public static void PrintBinLabels(IEnumerable<ClassRMA_Bin> bins)
		{
			var rmaBinLabelWithPath = Path.Combine(Application.StartupPath, @"Required Files", RMA_BIN_LABEL_DOCUMENT);

			#region Validation
			if (string.IsNullOrEmpty(GS.Settings.RMA_BinLabel_PrinterName))
			{
				MessageBox.Show("No printer selected for RMA Bin Labels.", "Printer Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			if (!File.Exists(rmaBinLabelWithPath))
			{
				var message = string.Format("Error: Could not find the RMA Bin Label Document \"{0}\". Label printing is not possible.", rmaBinLabelWithPath);
				MessageBox.Show(message, "Missing Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			Engine barTenderEngine;
			try
			{
				barTenderEngine = new Engine(true);
				barTenderEngine.ResponsiveTimeout = TimeSpan.FromSeconds(8);
			}
			catch (Exception exc)
			{
				var message = string.Format("Error starting BarTender Engine:{0}{0}{1}", Environment.NewLine, exc.Message);
				MessageBox.Show(message, "BarTender Engine Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			LabelFormatDocument barTenderDocument;

			try
			{
				barTenderDocument = barTenderEngine.Documents.Open(rmaBinLabelWithPath);
			}
			catch (COMException comException)
			{
				var message = string.Format("Error opening RMA Bin Label Document \"{0}\":{1}{1}{2}", rmaBinLabelWithPath, Environment.NewLine, comException.Message);
				MessageBox.Show(message, "Error Opening Label Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
				barTenderEngine.Stop();
				return;
			}

			// Printed label is designed to be half of a physical 4x6 label, print two side-by-side on the same label
			barTenderDocument.PrintSetup.IdenticalCopiesOfLabel = 2;
			barTenderDocument.PrintSetup.NumberOfSerializedLabels = 1;
			barTenderDocument.PrintSetup.PrinterName = GS.Settings.RMA_BinLabel_PrinterName;

			var sbSummary = new StringBuilder();
			var sbDetail = new StringBuilder();

			var printMessages = new Messages();
			foreach (var bin in bins)
			{
				var binAssemblies = bin.GetAssemblies();
				
				var techBlock = GetTechBlock(binAssemblies);

				barTenderDocument.SubStrings["bin_id"].Value = bin.BinName;
				barTenderDocument.SubStrings["created"].Value = string.Format("E{0} D{1:yyyyMMdd}", bin.CreationUserID, bin.CreationDate);
				barTenderDocument.SubStrings["rmas"].Value = GetRmaStringForBin(binAssemblies);
				barTenderDocument.SubStrings["qty"].Value = string.Format("{0}", binAssemblies.Count);
				barTenderDocument.SubStrings["asc"].Value = techBlock;
				barTenderDocument.SubStrings["version"].Value = string.Format("SDB {0}", Application.ProductVersion);

				var printResult = barTenderDocument.Print(bin.BinName, _LABEL_PRINT_TIMEOUT_MS, out printMessages);
				var messageString = printMessages.Aggregate("\n\nMessages:", (current, m) => current + ("\n\n" + m.Text));
				sbSummary.AppendFormat("{0}: {1}", bin.BinName, printResult == Result.Success ? "Success" : "Failed").AppendLine();
				sbDetail.AppendFormat("{0}{1}{1}", messageString, Environment.NewLine);
			}

			barTenderEngine.Stop();

			// Show dialog for print results if any were warning or error level
			if (!printMessages.Any(m => m.Severity == MessageSeverity.Error || m.Severity == MessageSeverity.Warning))
				return;
			
			var summaryMessage = string.Format("{0}{1}{1}Show details?", sbSummary, Environment.NewLine);
			if (MessageBox.Show(summaryMessage, "Label Print Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
				return;

			MessageBox.Show(sbDetail.ToString(), "Label Print Details");
		}

		/// <summary>
		/// Generates text for ASC based on a collection of assemblies.
		/// Assigned tech (ASC) name, address, CSZ, and phone are provided if all assemblies belong to same RMA.
		/// If assemblies are from assorted RMAs, "MULTIPLE ASCS" is returned instead.
		/// </summary>
		private static string GetTechBlock(IEnumerable<ClassRMA.ClassRMAAssembly> binAssemblies)
		{
			var techBlock = "MULTIPLE ASCS";

			var rmaIds = binAssemblies.Select(ba => ba.RMA_ID).Distinct().ToList();
			var techIds = GetTechIdsForRmas(rmaIds).ToList();

			if (techIds.Count() == 1)
			{
				var tech = ClassTech.GetByID(techIds[0]);
				techBlock = string.Format("{1}{0}{2}{0}{3}, {4} {5}{0}{6}", Environment.NewLine, tech.TechName, tech.Address.Split(new[] {Environment.NewLine}, StringSplitOptions.None)[0], tech.City, tech.State, tech.Zip, tech.Telephone);
			}

			return techBlock;
		}

		/// <summary>
		/// Retrieves a distinct list of tech IDs assigned to the specified list of RMA IDs.
		/// </summary>
		private static IEnumerable<int> GetTechIdsForRmas(List<int> rmaIds)
		{
			var techIds = new List<int>();
			if (!rmaIds.Any())
				return techIds;

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = string.Format(
						@"SELECT r.tech_id
						FROM rma r
						WHERE r.id IN ({0});", string.Join(",", rmaIds));
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							techIds.Add(reader.GetDBInt("tech_id"));
				}
				conn.Close();
			}
			return techIds.Distinct();
		}

		/// <summary>
		/// Constructs a string showing how many assemblies are present for each RMA
		/// i.e. 10300(2) 10301(1) 10302(3)
		/// </summary>
		private static string GetRmaStringForBin(List<ClassRMA.ClassRMAAssembly> assemblies)
		{
			var rmas = assemblies.Select(a => a.RMA_ID);
			var rmaAssemblyCounts = rmas.Distinct().Select(r => string.Format("{0}({1})", r, assemblies.Count(a => a.RMA_ID == r)));
			return string.Join(" ", rmaAssemblyCounts);
		}
	}
}