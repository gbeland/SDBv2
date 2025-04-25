using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.General;

namespace SDB.Classes.Asset
{
    public class ClassCabinetType
    {
        public int ID { get; set; }
        public string Description { get; set; }

        [UsedImplicitly]
        public string DisplayMember => Description;

	    public override string ToString()
        {
            return string.Format("{0} [{1}]", Description, ID);
        }

        public static IEnumerable<ClassCabinetType> GetCabinetTypes()
        {
            List<ClassCabinetType> cabinetTypes = new List<ClassCabinetType>();
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM cabinet_types
						ORDER BY description ASC;";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                            cabinetTypes.Add(GetFromReader(reader));
                }
                conn.Close();
            }
            return cabinetTypes;
        }

        public static ClassCabinetType GetByID(int? cabinetTypeID)
        {
            if (!cabinetTypeID.HasValue)
                return null;

            ClassCabinetType cabinetType;
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM cabinet_types
						WHERE id = @CabinetTypeID;";
                    cmd.Parameters.AddWithValue("CabinetTypeID", cabinetTypeID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            cabinetType = GetFromReader(reader);
                        }
                        else
                            return null;
                }
                conn.Close();
            }
            return cabinetType;
        }

        public static IEnumerable<ClassCabinetType> GetAll()
        {
            List<ClassCabinetType> allCabinetTypes = new List<ClassCabinetType>();
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM cabinet_types;";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                            allCabinetTypes.Add(GetFromReader(reader));
                }
                conn.Close();
            }
            return allCabinetTypes;
        }

        public static void AddNew(ref ClassCabinetType cabinetType)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"INSERT INTO cabinet_types
							(description)
						VALUES
							(@description);";
                    cmd.Parameters.AddWithValue("description", cabinetType.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    cabinetType.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(ClassCabinetType cabinetType)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"UPDATE cabinet_types SET
							description = @description
						WHERE id = @CabinetTypeID;";
                    cmd.Parameters.AddWithValue("CabinetTypeID", cabinetType.ID);
                    cmd.Parameters.AddWithValue("description", cabinetType.Description);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Reports how many times the specified <see cref="ClassCabinetType"/> is used throughout the database.
        /// </summary>
        public static int GetUsedQty(int cabinetTypeID)
        {
            int usedQty = 0;
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("CabinetTypeID", cabinetTypeID);

                    cmd.CommandText =
                        @"SELECT COUNT(*) qty
						FROM assets
						WHERE cabinet_type = @CabinetTypeID;";
                    usedQty += Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                }
            }
            return usedQty;
        }

        /// <summary>
        /// Replaces all occurrences of <param name="deprecatedCabinetTypeID"/> with <param name="replacementCabinetTypeID"/> throughout the database.
        /// Removes <paramref name="deprecatedCabinetTypeID"/> from the cabinet types table.
        /// *** It is not necessary to delete the deprecated cabinet type after calling this method.
        /// </summary>
        public static void Merge(int deprecatedCabinetTypeID, int replacementCabinetTypeID)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    // Update Assets
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE assets
						SET cabinet_type = @replacementCabinetTypeID
						WHERE cabinet_type = @deprecatedCabinetTypeID;";
                    cmd.Parameters.AddWithValue("deprecatedCabinetTypeID", deprecatedCabinetTypeID);
                    cmd.Parameters.AddWithValue("replacementCabinetTypeID", replacementCabinetTypeID);
                    cmd.ExecuteNonQuery();

                    // Delete deprecated cabinet type
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"DELETE FROM cabinet_types
						WHERE id = @deprecatedCabinetTypeID;";
                    cmd.Parameters.AddWithValue("deprecatedCabinetTypeID", deprecatedCabinetTypeID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Deletes specified cabinet type. (Does not log.)
        /// </summary>
        public static void Delete(int liftTypeID)
        {
            using (MySqlConnection conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"DELETE FROM cabinet_types
						WHERE id = @CabinetTypeID;";
                    cmd.Parameters.AddWithValue("CabinetTypeID", liftTypeID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private static ClassCabinetType GetFromReader(MySqlDataReader reader)
        {
            ClassCabinetType cabinetType = new ClassCabinetType();
            int? id = reader.GetDBInt_Null("id");
            if (!id.HasValue)
                return null;

            cabinetType.ID = id.Value;
            cabinetType.Description = reader.GetDBString("description");
            return cabinetType;
        }
    }
}
