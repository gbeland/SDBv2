using MySql.Data.MySqlClient;
using SDB.Classes.Assembly;
using SDB.Classes.Asset;
using SDB.Classes.Customer;
using SDB.Classes.General;
using SDB.Classes.Shipments;
using SDB.Classes.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDB.Classes.Eparts
{
    public class Eparts
    {
        public int? ID {get; set;}

        public string FormattedID
        {
            get
            {
                if (ID == null)
                    return "Error Finding ID";
                return ((int)ID).ToString("D6");
            }
        }

        public string PO { get; set; }

        //Populated and used only by qoute generator
        public string Shipping_Method { get; set; }

        public int? Shipment_ID { get; set; }
        public int? Asset_ID { get; set; } 
        public int? Market_ID { get; set; }
        public int? Status_ID { get; set; }
        public bool Deleted { get; set; } 
        public DateTime? Deleted_DT { get; set; }

        public DateTime? Creation_DT { get; set; }
        public DateTime? Completion_DT { get; set; }

        public string S_Company { get; set; }
        public string S_Attn { get; set; }
        public string S_Address { get; set; }
        public string S_City { get; set; }
        public string S_State { get; set; }
        public string S_Country { get; set; }
        public string S_Zip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public List<ClassAssembly> Inventory;
  
        public struct EpartsEntry
        {
            public int ID;
            public int Eparts_ID;
            public DateTime? Date;
            public int User_ID;
            public string Entry;
            public bool System_Msg;
        }

        public List<EpartsEntry> Journal;
        
        public struct EpartsStatus
        {
            public int ID;
            public int Eparts_ID;
            public int Status_ID;
            public string Status;
            public DateTime Date;
        }

        public List<EpartsStatus> StatusHistory;

        public ClassMarket Market
        {
            get
            {
                if (Market_ID != null)
                    return ClassMarket.GetByID((int)Market_ID);
                else
                    return null;
            }
        }
        public ClassShipment Shipment
        {
            get
            {
                if (Shipment_ID != null)
                    return ClassShipment.GetByID((int)Shipment_ID);
                else
                    return null;
            }
        }
        public ClassAsset Asset
        {
            get
            {
                if (Asset_ID != null)
                    return ClassAsset.GetByID((int)Asset_ID);
                else
                    return null;
            }
        }

        public string Status
        {
            get
            {
                if (StatusHistory != null && StatusHistory.Count != 0)
                    return StatusHistory.OrderByDescending(x => x.Date).First().Status;
                else return null;
            }
        }

        public string LastEntry
        {
            get
            {
                if (Journal.Count != 0)
                    return Journal.OrderByDescending(x => x.Date.ToString()).First().Entry;
                else return "No Entry Found";
            }
        }

        public string LastEntryUser
        {
            get
            {
                if (Journal.Count != 0)
                    return ClassUser.GetByID(Journal.OrderByDescending(x => x.Date).First().User_ID).FirstL;
                else return "User Not Found";
            }
        }

        public Eparts Populate()
        {
            

            StatusHistory = GetStatusHistory(this);
            Journal = GetEpartsJournal(this);
            Inventory = GetInventory(this);
            return this;
        }

        public static List<Eparts> GetAllOpen()
        {
            List<Eparts> _eparts = new List<Eparts>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts
						WHERE deleted != 1 AND completion_dt IS NULL;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            _eparts.Add(GetFromReader(reader).Populate());
                        }
                }
                conn.Close();
            }
            return _eparts;
        }

        public static List<Eparts> GetAllSearchPaged(int pageCount, int page, string search)
        {
            int startIndex = page * pageCount;

            search = "%" + search + "%";

            List<Eparts> _eparts = new List<Eparts>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM eparts WHERE deleted != 1 AND completion_dt IS NULL AND id LIKE @search Order By id LIMIT @startIndex, @pageCount;";
                    cmd.Parameters.AddWithValue("startIndex", startIndex);
                    cmd.Parameters.AddWithValue("pageCount", pageCount);
                    cmd.Parameters.AddWithValue("search", search);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            _eparts.Add(GetFromReader(reader).Populate());
                        }
                }
                conn.Close();
            }
            return _eparts;
        }



        public static List<Eparts> GetAllOpenPaged(int pageCount, int page)
        {

            int startIndex = page * pageCount;
            

            List<Eparts> _eparts = new List<Eparts>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts
						WHERE deleted != 1 AND completion_dt IS NULL
                        Order By id
                        LIMIT @startIndex, @pageCount;";
                    cmd.Parameters.AddWithValue("startIndex", startIndex);
                    cmd.Parameters.AddWithValue("pageCount", pageCount);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            _eparts.Add(GetFromReader(reader).Populate());
                        }
                }
                conn.Close();
            }
            return _eparts;
        }

        public static List<Eparts> GetAllClosed()
        {
            List<Eparts> _eparts = new List<Eparts>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts
						WHERE deleted != 1 AND completion_dt IS NOT NULL;";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            _eparts.Add(GetFromReader(reader).Populate());
                        }
                }
                conn.Close();
            }
            return _eparts;
        }

        public static Eparts GetByID(int id)
        {
            var _eparts = new Eparts();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            _eparts = GetFromReader(reader);
                        }
                }
                conn.Close();
            }
            return _eparts;
        }

        public static void AddNew(ref Eparts eparts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"INSERT INTO eparts
							(shipment_id, asset_id, market_id, status_id, creation_dt, s_company, s_attn, s_address, s_city, s_state, s_country, s_zip, email, phone, po)
						VALUES
							(@shipment_id, @asset_id, @market_id, @status_id, @creation_dt, @s_company, @s_attn, @s_address, @s_city, @s_state, @s_country, @s_zip, @email, @phone, @po);";
                    cmd.Parameters.AddWithValue("shipment_id", eparts.Shipment_ID);
                    cmd.Parameters.AddWithValue("asset_id", eparts.Asset_ID);
                    cmd.Parameters.AddWithValue("market_id", eparts.Market_ID);
                    cmd.Parameters.AddWithValue("status_id", eparts.Status_ID);
                    cmd.Parameters.AddWithValue("creation_dt", ClassDatabase.GetCurrentTime());
                    cmd.Parameters.AddWithValue("s_company", eparts.S_Company);
                    cmd.Parameters.AddWithValue("s_attn", eparts.S_Attn);
                    cmd.Parameters.AddWithValue("s_address", eparts.S_Address);
                    cmd.Parameters.AddWithValue("s_city", eparts.S_City);
                    cmd.Parameters.AddWithValue("s_state", eparts.S_State);
                    cmd.Parameters.AddWithValue("s_country", eparts.S_Country);
                    cmd.Parameters.AddWithValue("s_zip", eparts.S_Zip);
                    cmd.Parameters.AddWithValue("email", eparts.Email);
                    cmd.Parameters.AddWithValue("phone", eparts.Phone);
                    cmd.Parameters.AddWithValue("po", eparts.PO);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = @"SELECT @@IDENTITY";
                    eparts.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                conn.Close();
            }
        }

        public static void Update(Eparts eparts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE eparts
						SET shipment_id = @shipment_id,
							asset_id = @asset_id,
							market_id = @market_id,
                            status_id = @status_id,
                            s_company = @s_company,
                            s_attn = @s_attn,
                            s_address = @s_address,
                            s_city = @s_city,
                            s_state = @s_state,
                            s_country = @s_country,
                            s_zip = @s_zip,
                            email = @email,
                            phone = @phone,
                            po = @po
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("shipment_id", eparts.Shipment_ID);
                    cmd.Parameters.AddWithValue("asset_id", eparts.Asset_ID);
                    cmd.Parameters.AddWithValue("market_id", eparts.Market_ID);
                    cmd.Parameters.AddWithValue("status_id", eparts.Status_ID);
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    cmd.Parameters.AddWithValue("s_company", eparts.S_Company);
                    cmd.Parameters.AddWithValue("s_attn", eparts.S_Attn);
                    cmd.Parameters.AddWithValue("s_address", eparts.S_Address);
                    cmd.Parameters.AddWithValue("s_city", eparts.S_City);
                    cmd.Parameters.AddWithValue("s_state", eparts.S_State);
                    cmd.Parameters.AddWithValue("s_country", eparts.S_Country);
                    cmd.Parameters.AddWithValue("s_zip", eparts.S_Zip);
                    cmd.Parameters.AddWithValue("email", eparts.Email);
                    cmd.Parameters.AddWithValue("phone", eparts.Phone);
                    cmd.Parameters.AddWithValue("po", eparts.PO);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static void Close(Eparts eparts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE eparts
						SET completion_dt = @completion_dt
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("completion_dt", DateTime.Now);
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static void ReOpen(Eparts eparts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE eparts
						SET completion_dt = @completion_dt
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("completion_dt", null);
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static void Delete(Eparts eparts)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE eparts
						SET deleted = @deleted,
                            deleted_dt = @deleted_dt
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("deleted", eparts.Deleted);
                    cmd.Parameters.AddWithValue("deleted_dt", eparts.Deleted_DT);
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static List<ClassAssembly> GetInventory(Eparts eparts)
        {
            List<ClassAssembly> _inventory = new List<ClassAssembly>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT ei.*
						FROM eparts_inventory ei
						WHERE eparts_id = @id AND deleted = 0;";
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            
                            ClassAssembly assem = ClassAssembly.GetByID(reader.GetDBInt("assembly_id"));
                            _inventory.Add(assem);
                        }
                }
                conn.Close();
            }
            return _inventory;
        }

        public static void AddToInventory(Eparts eparts, ClassAssembly assembly)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"INSERT INTO eparts_inventory
							(eparts_id, assembly_id)
						VALUES
							(@eparts_id, @assembly_id);";
                    cmd.Parameters.AddWithValue("eparts_id", eparts.ID);
                    cmd.Parameters.AddWithValue("assembly_id", assembly.ID);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                    
                }
                conn.Close();
            }
        }

        public static void RemoveFromInventory(Eparts eparts, ClassAssembly assembly)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        @"UPDATE eparts_inventory
						SET deleted = @deleted,
                            deleted_dt = @deleted_dt
						WHERE eparts_id = @eid AND assembly_id = @aid";
                    cmd.Parameters.AddWithValue("deleted", 1);
                    cmd.Parameters.AddWithValue("deleted_dt", ClassDatabase.GetCurrentTime());
                    cmd.Parameters.AddWithValue("eid", eparts.ID);
                    cmd.Parameters.AddWithValue("aid", assembly.ID);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }

        public static List<EpartsEntry> GetEpartsJournal(Eparts eparts)
        {
            List<EpartsEntry> _journal = new List<EpartsEntry>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT ej.*
						FROM eparts_journal ej
						WHERE eparts_id = @id;";
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            EpartsEntry entry = new EpartsEntry
                            {
                                ID = reader.GetDBInt("id"),
                                Eparts_ID = reader.GetDBInt("eparts_id"),
                                User_ID = reader.GetDBInt("user_id"),
                                Date = reader.GetDBDateTime_Null("dt"),
                                Entry = reader.GetDBString("entry"),
                                System_Msg = reader.GetDBBool("system_msg")
                            };
                            _journal.Add(entry);
                        }
                }
                conn.Close();
            }
            return _journal;
        }

        public static void AddJournalEntry(EpartsEntry entry)
        {

            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"INSERT INTO eparts_journal
							(eparts_id, dt, user_id, entry, system_msg)
						VALUES
							(@eparts_id, @dt, @user_id, @entry, @system_msg);";
                    cmd.Parameters.AddWithValue("eparts_id", entry.Eparts_ID);
                    cmd.Parameters.AddWithValue("dt", ClassDatabase.GetCurrentTime());
                    cmd.Parameters.AddWithValue("user_id", entry.User_ID);
                    cmd.Parameters.AddWithValue("entry", entry.Entry);
                    cmd.Parameters.AddWithValue("system_msg", entry.System_Msg);
                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public static string GetStatusByID(int id)
        {
            string _status = "Status Text Not Found. [ID=" + id +"]";
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts_status
						WHERE id = @id;";
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            _status = reader.GetDBString("status");
                        }
                }
                conn.Close();
            }
            return _status;
        }

        public static List<string> GetAllStatuses()
        {
            List<string> _statuses = new List<string>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT es.*
						FROM eparts_status es
                        WHERE status != 'Closed';";
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            _statuses.Add(reader.GetDBString("status"));
                        }
                }
                conn.Close();
            }
            return _statuses;
        }

        public static List<EpartsStatus> GetStatusHistory(Eparts eparts)
        {
            List<EpartsStatus> _history = new List<EpartsStatus>();
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT es.*
						FROM eparts_status_history es
						WHERE eparts_id = @id
                        ORDER BY status_dt DESC;";
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            EpartsStatus _status = new EpartsStatus
                            {
                                ID = reader.GetDBInt("id"),
                                Eparts_ID = reader.GetDBInt("eparts_id"),
                                Status_ID = reader.GetDBInt("status_id"),
                                Status = GetStatusByID(reader.GetDBInt("status_id")),
                                Date = reader.GetDBDateTime("status_dt")
                            };
                            _history.Add(_status);
                        }
                }
                conn.Close();
            }
            return _history;
        }

        public static void UpdateStatus(Eparts eparts, string status)
        {
            int status_id = 0;

            
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        @"SELECT *
						FROM eparts_status
						WHERE status = @status;";
                    cmd.Parameters.AddWithValue("status", status);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                        {
                            reader.Read();
                            status_id = reader.GetDBInt("id");
                        }
                }
                conn.Close();
            }
            if (status_id == 0)
                return;
            else UpdateStatus(eparts, status_id);


        }

        public static void UpdateStatus(Eparts eparts, int status_id)
        {
            using (var conn = ClassDatabase.CreateMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText =
                        $@"INSERT INTO eparts_status_history
							(eparts_id, status_id, status_dt)
						VALUES
							(@eparts_id, @status_id, @status_dt);";
                    cmd.Parameters.AddWithValue("eparts_id", eparts.ID);
                    cmd.Parameters.AddWithValue("status_id", status_id);
                    cmd.Parameters.AddWithValue("status_dt", ClassDatabase.GetCurrentTime());

                    ClassDatabase.ConvertAllNullParameters(cmd.Parameters);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        $@"Update eparts
						   SET status_id = @status_id
                           WHERE id=@id;";
                    cmd.Parameters.AddWithValue("status_id", status_id);
                    cmd.Parameters.AddWithValue("id", eparts.ID);
                }
                conn.Close();
            }
        }

        private static Eparts GetFromReader(MySqlDataReader reader)
        {
            var epartsID = reader.GetDBInt_Null("id");
            if (!epartsID.HasValue)
                return null;
            return new Eparts
            {
                ID = epartsID.Value,
                Shipment_ID = reader.GetDBInt_Null("shipment_id"),
                Asset_ID = reader.GetDBInt_Null("asset_id"),
                Market_ID = reader.GetDBInt_Null("market_id"),
                Status_ID = reader.GetDBInt_Null("status_id"),
                Deleted = reader.GetDBBool("deleted"),
                Deleted_DT = reader.GetDBDateTime_Null("deleted_dt"),
                Creation_DT = reader.GetDBDateTime_Null("creation_dt"),
                Completion_DT = reader.GetDBDateTime_Null("completion_dt"),

                S_Company = reader.GetDBString("s_company"),
                S_Attn = reader.GetDBString("s_attn"),
                S_Address = reader.GetDBString("s_address"),
                S_City = reader.GetDBString("s_city"),
                S_State = reader.GetDBString("s_state"),
                S_Country = reader.GetDBString("s_country"),
                S_Zip = reader.GetDBString("s_zip"),

                Phone = reader.GetDBString("phone"),
                Email = reader.GetDBString("email"),
                PO = reader.GetDBString("po")
            };
        }

    }
}
