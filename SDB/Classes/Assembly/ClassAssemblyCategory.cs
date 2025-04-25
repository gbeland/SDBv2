using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SDB.Classes.Admin;
using SDB.Classes.General;

namespace SDB.Classes.Assembly
{
	/// <summary>
	/// The top-level category which contains Assembly Types.
	/// </summary>
	public class ClassAssemblyCategory
	{
		public int ID { get; set; }
		public string Description { get; set; }

		[UsedImplicitly]
		public string DisplayMember => Description;

		public override string ToString()
		{
			return string.Format("{0} [{1}]", Description, ID);
		}

		public static IEnumerable<ClassAssemblyCategory> GetAll()
		{
			var assyCategories = new List<ClassAssemblyCategory>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assembly_categories
						ORDER BY description ASC;";
					using (var reader = cmd.ExecuteReader())
						while (reader.Read())
							assyCategories.Add(GetFromReader(reader));
				}
				conn.Close();
			}
			return assyCategories;
		}

		public static ClassAssemblyCategory GetByID(int assemblyCategoryID)
		{
			var assyCategory = new ClassAssemblyCategory();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT *
						FROM assembly_categories
						WHERE id = @AssemblyCategoryID;";
					cmd.Parameters.AddWithValue("AssemblyCategoryID", assemblyCategoryID);
					using (var reader = cmd.ExecuteReader())
						if (reader.HasRows)
						{
							reader.Read();
							assyCategory = GetFromReader(reader);
						}
				}
				conn.Close();
			}
			return assyCategory;
		}

		private static ClassAssemblyCategory GetFromReader(MySqlDataReader reader)
		{
			return new ClassAssemblyCategory
					   {
						   ID = reader.GetDBInt("id"),
						   Description = reader.GetDBString("description")
					   };
		}

		/// <summary>
		/// Returns how many times specified assembly category is utilized by the database.
		/// </summary>
		public static int GetUsedQty(int assemblyCategoryID)
		{
			int usedQty;
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.Parameters.AddWithValue("AssemblyCategoryID", assemblyCategoryID);

					cmd.CommandText =
						@"SELECT COUNT(*) qty
						FROM assembly_types
						WHERE category_id = @AssemblyCategoryID;";
					usedQty = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			return usedQty;
		}

		/// <summary>
		/// Updates the specified AssemblyCategory.
		/// </summary>
		public static void Update(ClassAssemblyCategory assemblyCategory)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"UPDATE assembly_categories SET
							description = @Description,
						WHERE id = @AssemblyCategoryID;";
					cmd.Parameters.AddWithValue("AssemblyCategoryID", assemblyCategory.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.AssemblyType, assemblyCategory.ID, assemblyCategory.Description);
		}

		public static void AddNew(ref ClassAssemblyCategory assemblyCategory)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"INSERT INTO assembly_categories
						(description)
						VALUES
						(@Description);";
					cmd.Parameters.AddWithValue("Description", assemblyCategory.Description);
					cmd.ExecuteNonQuery();

					cmd.Parameters.Clear();
					cmd.CommandText = @"SELECT @@IDENTITY";
					assemblyCategory.ID = Convert.ToInt32(cmd.ExecuteScalar());
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Create, ClassEventLog.ObjectTypeEnum.AssemblyCategory, assemblyCategory.ID, assemblyCategory.Description);
		}

		/// <summary>
		/// Permanently deletes specified assembly category from the database.
		/// Use AssemblyCategory_UsedQty() first to determine if it is used somewhere first.
		/// </summary>
		public static void Delete(ClassAssemblyCategory assemblyCategory)
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = @"DELETE FROM assembly_categories WHERE id = @AssemblyCategoryID;";
					cmd.Parameters.AddWithValue("AssemblyCategoryID", assemblyCategory.ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Delete, ClassEventLog.ObjectTypeEnum.AssemblyCategory, assemblyCategory.ID, assemblyCategory.Description);
		}

		/// <summary>
		/// Replaces all occurrences of DeprecatedAssemblyCategoryID with ReplacementAssemblyCategoryID throughout the database.
		/// </summary>
		public static void Merge(int deprecatedAssemblyCategoryID, int replacementAssemblyCategoryID)
		{
			var oldCategory = GetByID(deprecatedAssemblyCategoryID);
			var newCategory = GetByID(replacementAssemblyCategoryID);

			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					// Move assembly types from old to new assembly category
					cmd.Parameters.Clear();
					cmd.CommandText =
						@"UPDATE assembly_types
						SET category_id = @ReplacementAssemblyCategoryID
						WHERE category_id = @DeprecatedAssemblyCategoryID;";
					cmd.Parameters.AddWithValue("DeprecatedAssemblyCategoryID", deprecatedAssemblyCategoryID);
					cmd.Parameters.AddWithValue("ReplacementAssemblyCategoryID", replacementAssemblyCategoryID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
			ClassEventLog.AddEntry(GS.Settings.LoggedOnUser.ID, ClassEventLog.EventTypeEnum.Modify, ClassEventLog.ObjectTypeEnum.AssemblyCategory, deprecatedAssemblyCategoryID, string.Format("Merged {0} into {1}", oldCategory.Description, newCategory.Description));
		}
	}
}