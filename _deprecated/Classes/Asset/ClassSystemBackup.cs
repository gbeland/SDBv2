using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;
using SDB.Classes.Misc;

namespace SDB.Classes.Asset
{
    public class ClassSystemBackup
    {
        private const string _FIRST_SYSTEM_VERSION_TO_SUPPORT_BACKUP = @"13.05.23.00";

        /// <summary>
        /// Unique ID of this backup.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Which asset this backup is associated with.
        /// </summary>
        public int AssetID { get; set; }
        /// <summary>
        /// Date and time the backup was created.
        /// </summary>
        public DateTime BackupDate { get; set; }
        /// <summary>
        /// Prismview System version the backup is from.
        /// </summary>
        public string SystemVersion { get; set; }
        /// <summary>
        /// User-entered notes about the backup.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Byte array representing the compressed ZIP file.
        /// </summary>
        public byte[] BackupData { get; set; }

        public override string ToString()
        {
            return string.Format("{0:yyyy-MM-dd HH:mm:ss}: ver {1}", BackupDate, SystemVersion);
        }

        public static ClassSystemBackup GetByID(int? backupID)
        {
            if (!backupID.HasValue)
                return null;

            ClassSystemBackup backup;
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT *
						FROM asset_system_backups
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", backupID);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows && reader.Read())
                            backup = GetFromReader(reader);
                        else
                            return null;
                }
                conn.Close();
            }
            return backup;
        }

        public static IEnumerable<ClassSystemBackup> GetByAsset(int assetID)
        {
            var backups = new List<ClassSystemBackup>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT *
						FROM asset_system_backups
						WHERE asset_id = @asset_id;";
                    cmd.Parameters.AddWithValue("asset_id", assetID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            backups.Add(GetFromReader(reader));
                        }
                    }
                }
                conn.Close();
            }
            return backups;
        }

        /// <summary>
        /// Inserts a new <see cref="ClassSystemBackup"/> into the database and populates its ID.
        /// </summary>
        public static void AddNew(ref ClassSystemBackup backup)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO asset_system_backups
						(asset_id, backup_date, system_version, notes, backup_data)
						VALUES
						(@asset_id, @backup_date, @system_version, @notes, @backup_data);";
                    cmd.Parameters.AddWithValue("asset_id", backup.AssetID);
                    cmd.Parameters.AddWithValue("backup_date", backup.BackupDate);
                    cmd.Parameters.AddWithValue("system_version", backup.SystemVersion);
                    cmd.Parameters.AddWithValue("notes", backup.Notes);
                    cmd.Parameters.AddWithValue("backup_data", backup.BackupData);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    backup.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
            ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.SystemBackup, backup.ID, string.Format("For asset '{0}'", ClassAsset.GetName(backup.AssetID)));
        }

        /// <summary>
        /// Deletes this <see cref="ClassSystemBackup"/>.
        /// </summary>
        public void Delete()
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"DELETE FROM asset_system_backups
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", ID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.SystemBackup, ID, string.Format("For asset '{0}' on {1:yyyy-MM-dd HH:mm:ss}", ClassAsset.GetName(AssetID), BackupDate));
        }

        /// <summary>
        /// Creates a <see cref="ClassSystemBackup"/> by connecting to specified asset.
        /// </summary>
        /// <param name="asset">The asset to obtain a backup from.</param>
        /// <param name="notes">User-entered notes about the <see cref="ClassSystemBackup"/></param>
        /// <returns></returns>
        public static ClassSystemBackup CreateFromSystem(ClassAsset asset, string notes)
        {
            using (var wc = new ClassWebDownload(15000))
            {
                // Get Prismview System Version from target system
                string assetXML;
                try
                {
                    assetXML = wc.DownloadString(asset.URL_SystemXML);
                }
                catch (Exception exc)
                {
                    exc.Data.Add(0, asset.URL_SystemXML);
                    throw;
                }
                assetXML = RemoveAllXmlNamespaces(assetXML);
                var doc = new XmlDocument();
                doc.LoadXml(assetXML);
                var versionNode = doc.SelectSingleNode("//DetailedInfo/server/PrismViewVersion");

                if (versionNode == null)
                    throw new Exception("Could not determine version of remote system.");

                if (ClassUtility.CompareVersions(versionNode.InnerText, _FIRST_SYSTEM_VERSION_TO_SUPPORT_BACKUP) < 1)
                    throw new NotSupportedException(ClassUtility.StringFormatNull("Version {0} of System does not support configuration backup.", "Could not determine version.", versionNode.InnerText));

                // Get backup data
                var backupData = wc.DownloadData(asset.URL_SystemGetSettings);

                // Create 
                return new ClassSystemBackup
                {
                    AssetID = asset.ID,
                    SystemVersion = versionNode.InnerText,
                    BackupDate = ClassDatabase.GetCurrentTime(),
                    Notes = notes,
                    BackupData = backupData
                };
            }
        }

        /// <summary>
        /// Restores the backup to the specified <see cref="ClassAsset"/>
        /// </summary>
        /// <param name="targetAssetID">The <see cref="ClassAsset"/> ID to restore the backup to, if not the one the backup is associated with.</param>
        public string Restore(int targetAssetID)
        {
            var originalAsset = ClassAsset.GetByID(AssetID);
            var targetAsset = ClassAsset.GetByID(targetAssetID);

            using (var wc = new WebClient())
            {
                var tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                File.WriteAllBytes(tempFilePath, BackupData);

                var response = wc.UploadFile(targetAsset.URL_SystemRestoreSettings, tempFilePath);
                File.Delete(tempFilePath);
                wc.DownloadString(targetAsset.URL_SystemRestart);

                var logDetail = string.Format("From asset '{0}' on {1:yyyy-MM-dd HH:mm:ss} to '{2}'", originalAsset.AssetName, BackupDate, targetAsset.AssetName);
                ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Restore, ClassEventLog.ObjectTypeEnum.SystemBackup, ID, logDetail);

                return System.Text.Encoding.ASCII.GetString(response);
            }
        }

        /// <summary>
        /// Restores the backup to its associated <see cref="ClassAsset"/>.
        /// </summary>
        public string Restore()
        {
            return Restore(AssetID);
        }

        private static ClassSystemBackup GetFromReader(MySqlDataReader reader)
        {
            var backup = new ClassSystemBackup();
            var id = reader.GetDBInt_Null("id");
            if (!id.HasValue)
                return null;

            backup.ID = id.Value;
            backup.AssetID = reader.GetDBInt("asset_id");
            backup.BackupDate = reader.GetDBDateTime("backup_date");
            backup.SystemVersion = reader.GetDBString("system_version");
            backup.Notes = reader.GetDBString("notes");
            backup.BackupData = reader.GetDBBytes("backup_data");
            return backup;
        }

        private static string RemoveAllXmlNamespaces(string xmlDocument)
        {
            // http://stackoverflow.com/questions/987135/how-to-remove-all-namespaces-from-xml-with-c
            var xmlDocumentWithoutNs = RemoveAllXmlNamespaces(XElement.Parse(xmlDocument));
            return xmlDocumentWithoutNs.ToString();
        }

        private static XElement RemoveAllXmlNamespaces(XElement xmlDocument)
        {
            // http://stackoverflow.com/questions/987135/how-to-remove-all-namespaces-from-xml-with-c
            // Core recursion function
            if (!xmlDocument.HasElements)
            {
                var xElement = new XElement(xmlDocument.Name.LocalName) { Value = xmlDocument.Value };
                return xElement;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(RemoveAllXmlNamespaces));
        }
    }
}