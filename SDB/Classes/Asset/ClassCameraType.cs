using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
    public class ClassCameraType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string URL_Format_Still { get; set; }
        public string URL_Format_Video { get; set; }
        public string URL_Format_Monitor { get; set; }
        public int? AssemblyID { get; set; }

        [UsedImplicitly]
        public string DisplayMember => Description;

	    public override string ToString()
        {
            return string.Format("{0} [{1}]", Description, ID);
        }

        static public IEnumerable<ClassCameraType> GetCameraTypes()
        {
            List<ClassCameraType> cameraTypes = new List<ClassCameraType>();
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM camera_types
						ORDER BY description ASC;";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                            cameraTypes.Add(GetFromReader(reader));
                }
                conn.Close();
            }
            return cameraTypes;
        }

        static public ClassCameraType GetByID(int? cameraTypeID)
        {
            if (!cameraTypeID.HasValue) return null;

            ClassCameraType cameraType;
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM camera_types
						WHERE id = @CameraTypeID;";
                    cmd.Parameters.AddWithValue("CameraTypeID", cameraTypeID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            cameraType = GetFromReader(reader);
                        }
                        else
                            return null;
                }
                conn.Close();
            }
            return cameraType;
        }

        static public void AddNew(ref ClassCameraType cameraType)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"INSERT INTO camera_types
							(description, url_format_still, url_format_monitor, url_format_video, assembly_id)
						VALUES
							(@description, @url_format_still, @url_format_monitor, @url_format_video, @assembly_id);";
                    cmd.Parameters.AddWithValue("description", cameraType.Description);
                    cmd.Parameters.AddWithValue("url_format_still", cameraType.URL_Format_Still);
                    cmd.Parameters.AddWithValue("url_format_monitor", cameraType.URL_Format_Monitor);
                    cmd.Parameters.AddWithValue("url_format_video", cameraType.URL_Format_Video);
                    cmd.Parameters.AddWithValue("assembly_id", cameraType.AssemblyID);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    cameraType.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        static public void Update(ClassCameraType cameraType)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"UPDATE camera_types SET
							description = @description,
							url_format_still = @url_format_still,
							url_format_monitor = @url_format_monitor,
							url_format_video = @url_format_video,
							assembly_id = @assembly_id
						WHERE id = @CameraTypeID;";
                    cmd.Parameters.AddWithValue("CameraTypeID", cameraType.ID);
                    cmd.Parameters.AddWithValue("description", cameraType.Description);
                    cmd.Parameters.AddWithValue("url_format_still", cameraType.URL_Format_Still);
                    cmd.Parameters.AddWithValue("url_format_monitor", cameraType.URL_Format_Monitor);
                    cmd.Parameters.AddWithValue("url_format_video", cameraType.URL_Format_Video);
                    cmd.Parameters.AddWithValue("assembly_id", cameraType.AssemblyID);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Reports how many times the specified <paramref name="cameraTypeID"/> is used throughout the database.
        /// </summary>
        static public int GetUsedQty(int cameraTypeID)
        {
            int usedQty = 0;
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("CameraTypeID", cameraTypeID);

                    cmd.CommandText =
                        @"SELECT COUNT(*) qty
						FROM assets
						WHERE webcam_type = @CameraTypeID;";
                    usedQty += Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                }
            }
            return usedQty;
        }

        static public void Delete(int cameraTypeID)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText =
                        @"DELETE FROM camera_types
						WHERE id = @CameraTypeID;";
                    cmd.Parameters.AddWithValue("CameraTypeID", cameraTypeID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        static private ClassCameraType GetFromReader(MySqlDataReader reader)
        {
            ClassCameraType cameraType = new ClassCameraType();
            int? id = reader.GetDBInt_Null("id");
            if (!id.HasValue)
                return null;

            cameraType.ID = id.Value;
            cameraType.Description = reader.GetDBString("description");
            cameraType.URL_Format_Still = reader.GetDBString("url_format_still");
            cameraType.URL_Format_Monitor = reader.GetDBString("url_format_monitor");
            cameraType.URL_Format_Video = reader.GetDBString("url_format_video");
            cameraType.AssemblyID = reader.GetDBInt_Null("assembly_id");
            return cameraType;
        }
    }
}
