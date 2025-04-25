using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicInformant
{
    class EventLog
    {
        public struct Event
        {
            public string Entry;
            public DateTime TimeStamp;
            public string Type;
        }
        public static Queue<Event> LogQueue = new Queue<Event>();

        public static void AddEvent(Event e)
        {
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                LogQueue.Enqueue(e);
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"INSERT INTO event_log
                        (event, timestamp, type)
                        VALUES (@event, @timestamp, @type);";
                    cmd.Parameters.AddWithValue("event", e.Entry);
                    cmd.Parameters.AddWithValue("timestamp", e.TimeStamp);
                    cmd.Parameters.AddWithValue("type", e.Type);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            
        }

        public static List<Event> GetLastEvents(int range = 100)
        {
            List<Event> list = new List<Event>();

            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"SELECT e.*
                        FROM event_log e
                        ORDER BY e.id DESC
                        LIMIT @n;";
                    cmd.Parameters.AddWithValue("n", range);
                    cmd.ExecuteNonQuery();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Event e = new Event
                            {
                                Entry = reader.GetDBString("event"),
                                TimeStamp = reader.GetDBDateTime("timestamp"),
                                Type = reader.GetDBString("type")
                            };
                            list.Add(e);
                        }
                    }
                }
                conn.Close();
            }

            return list;
        }



    }
}
