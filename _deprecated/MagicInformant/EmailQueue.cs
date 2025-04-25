using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MagicInformant
{
    class EmailQueue
    {
        private Queue<EmailData> _queue;
        private BackgroundWorker _worker;

        public struct EmailData
        {
            public int ID;
            public int AlertID;
            public int AssetID;
            public bool EmailSent;
        }

        public struct AssetData
        {
            public int AssetID;
            public string AssetName;
            public string AssetModel;
            public string AssetMAC;
            public string AssetAddress;
            public string AssetServerURL;
            public string AssetAlertEmails;
        }

        public struct EmailSettings
        {
            public string Server;
            public int Port;
            public string Email;
            public string Password;
        }

        public EmailQueue()
        {
            //init 
            _queue = new Queue<EmailData>();
            _worker = new BackgroundWorker();
            _worker.WorkerReportsProgress = true;
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += new DoWorkEventHandler(FlushQueue);
            _worker.ProgressChanged += new ProgressChangedEventHandler(EmailResultEvent);
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(QueueEmpty);
        }

        //Pulls the queue and then sends emails as background worker
        public void SendAllQueue()
        {
            //if worker is alreayd working on queue return and do nothing
            if (_worker.IsBusy)
                return;

            //Populate Queue 
            UpdateQueue();

            //check to see if queue is empty after update
            if (_queue.Count < 1)
                return;

            //Send Queue to worker to work on
            _worker.RunWorkerAsync(_queue);

            //Log Number of Emails in Queue
            EventLog.AddEvent(new EventLog.Event
            {
                Entry = "Email: " + _queue.Count + " Emails In Queue",
                TimeStamp = DateTime.Now,
                Type = "Email"
            });
        }

        //Add email to queue
        public void AddAlertEmailToQueue(WeaveAPI.AlertData data)
        {
            AddEmailToSqlEmailQueue(new EmailData
            {
                AssetID = (int)data.AssetID,
                AlertID = data.ID
            });
        }
        
        //Background worker function to send all emails in queue 
        private void FlushQueue(object sender, DoWorkEventArgs e)
        {
            //Make copy of Queue
            Queue<EmailData> _queue = e.Argument as Queue<EmailData>;
            //loop through each item in queue
            while(_queue.Count > 0)
            {
                
                //grab item from queue
                EmailData data = _queue.Dequeue();
                WeaveAPI.AlertData alert = WeaveAPI.GetAlertById(data.AlertID);
                AssetData asset = GetAssetData(data.AssetID);

                using(var client = new SmtpClient())
                {


                    EmailSettings es = GetEmailSettings();

                    //Email Server Information
                    //Temp for Testing
                    //Change to be configurable
                    client.Host = es.Server;
                    client.Port = es.Port;
                    client.EnableSsl = false;
                    client.Credentials = new NetworkCredential(es.Email, es.Password);

                    //Create Email
                    var email = new MailMessage
                    {
                        From = new MailAddress(es.Email),
                        IsBodyHtml = true
                    };

                    string issue = "Issue Resolved";
                    if (!alert.HasContent)
                        issue = "No Content";
                    if (!alert.InputSourceIsValid)
                        issue = "Invalid Input: " + alert.InputSource;
                    if (!alert.Connected)
                        issue = "No Connection";
                    
                    //load html email template
                    //Repalce ** with asset info
                    string html = File.ReadAllText("EmailTemplate.html");
                    html = html.Replace("*issue*", issue);
                    html = html.Replace("*timestamp*", alert.TimeStamp.ToUniversalTime().ToString() + " UTC");
                    html = html.Replace("*asset_name*", asset.AssetName);
                    html = html.Replace("*model*", asset.AssetModel);
                    html = html.Replace("*mac*", asset.AssetMAC);
                    html = html.Replace("*server*", asset.AssetServerURL);
                    html = html.Replace("*address*", GetAddressString(asset.AssetID));

                    email.Body = html;
                    email.Subject = "Samsung Alert On Asset: " + asset.AssetName;

                    string toEmails = asset.AssetAlertEmails;
                    if(toEmails == string.Empty)
                    {
                        EventLog.AddEvent(new EventLog.Event
                        {
                            Entry = "Error: No customer emails listed to receive alert information",
                            TimeStamp = DateTime.Now,
                            Type = "Error"
                        });
                        continue;
                    }

                    email.To.Add(toEmails + ", " + es.Email);
                    //email.ReplyToList.Add(toEmails + prosvc.noc@samsung.com);
                    

                    try
                    {
                        client.Send(email);
                        _worker.ReportProgress(0, asset);
                        MarkEmailAsSent(data.ID);
                    }
                    catch(Exception exc)
                    {
                        //If it fails to send email through samsung then send reort to IT
                        //then break the loop

                        EventLog.AddEvent(new EventLog.Event
                        {
                            Entry = "Error: Could not send email | Error Message - " + exc.Message,
                            TimeStamp = DateTime.Now,
                            Type = "Error"
                        });
                        
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("noreply@prismview.com", "y9H5$2nITl%MOH56wA");
                        email.From = new MailAddress("noreply@prismview.com");

                        email.To.Clear();
                        email.To.Add("logandev@prismview.com, loganit@prismview.com");
                        email.ReplyToList.Add("logandev@prismview.com, loganit@prismview.com");

                        email.Subject = "Notification: Failed To Send Email Alert";
                        email.Body = "Error Message: " + exc.Message;

                        try
                        {
                            client.Send(email);
                            _worker.ReportProgress(0, asset);
                            MarkEmailAsSent(data.ID);
                            return;
                        }
                        catch(Exception exx)
                        {
                            EventLog.AddEvent(new EventLog.Event
                            {
                                Entry = "Error: Could not send error email to loganit@prismview.com | Error Message - " + exc.Message,
                                TimeStamp = DateTime.Now,
                                Type = "Error"
                            });
                            return;
                        } 

                    }
                }

            }
        }

        public static EmailSettings GetEmailSettings()
        {
            EmailSettings es = new EmailSettings();
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"SELECT es.*
                            FROM config_settings es
                            WHERE es.id = 1;";
                   
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            es = new EmailSettings
                            {
                                Server = reader.GetDBString("email_host"),
                                Port = reader.GetDBInt("email_port"),
                                Email = reader.GetDBString("email_username"),
                                Password = reader.GetDBString("email_password")
                            };
                        }
                    }
                }
                conn.Close();
            }

            return es;
        }

        //Grab asset data from magicinfo_lfd DB
        private AssetData GetAssetData(int asset_id)
        {
            AssetData asset = new AssetData();
            using (var conn = ClassDatabase.CreateSamsungMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                     cmd.Parameters.Clear();
                        cmd.CommandText = cmd.CommandText +
                            $@"SELECT s.ip, a.id, a.asset_name, a.model, a.mac_address, s.alert_emails
                            FROM magicinfo_asset a
                            RIGHT JOIN magicinfo_server s ON a.server_fky = s.id
                            WHERE a.id = @id;";
                        cmd.Parameters.AddWithValue("id", asset_id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                asset = new AssetData
                                {
                                    AssetID = reader.GetDBInt("id"),
                                    AssetName = reader.GetDBString("asset_name"),
                                    AssetModel = reader.GetDBString("model"),
                                    AssetMAC = reader.GetDBString("mac_address"),
                                    AssetServerURL = reader.GetDBString("ip"),
                                    AssetAlertEmails = reader.GetDBString("alert_emails"),
                                    AssetAddress = GetAddressString(asset_id)
                                };    
                            }
                        }
                }
                conn.Close();
            }

            return asset;
        }
        
        private string GetAddressString(int asset_id)
        {
            string address = "";
            using (var conn = ClassDatabase.CreateSamsungMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"SELECT a.*, ad.*
                            FROM magicinfo_asset a
                            RIGHT JOIN magicinfo_address ad ON a.address_fky = ad.id
                            WHERE a.id = @id;";
                    cmd.Parameters.AddWithValue("id", asset_id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            address = reader.GetDBString("street") + ", " + reader.GetDBString("city") + ", " + reader.GetDBString("state") + " " + reader.GetDBString("zip");
                        }
                    }
                }
                conn.Close();
            }

            return address;
        }

        // update when an email is sent
        private void EmailResultEvent(object sender, ProgressChangedEventArgs e)
        {
            AssetData data = (AssetData)e.UserState;

            EventLog.AddEvent(new EventLog.Event
            {
                Entry = "Email: Customer Email Sent On " + data.AssetMAC,
                TimeStamp = DateTime.Now,
                Type = "Email"
            });
        }

        //Background worker finished
        private void QueueEmpty(object sender, RunWorkerCompletedEventArgs e)
        {
            EventLog.AddEvent(new EventLog.Event
            {
                Entry = "Email: All Emails Sent",
                TimeStamp = DateTime.Now,
                Type = "Email"
            });
        }

        //Adds an email to the SQL email queue table
        private void AddEmailToSqlEmailQueue(EmailData data)
        {
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                        cmd.CommandText =
                            $@"INSERT INTO email_queue
                            (asset_id, alert_id, email_sent)
                            VALUES (@asset_id, @alert_id, 0);";
                        cmd.Parameters.AddWithValue("asset_id", data.AssetID);
                        cmd.Parameters.AddWithValue("alert_id", data.AlertID);

                        cmd.ExecuteNonQuery();
                    }
                conn.Close();
            }
        }

        private void MarkEmailAsSent(int email_id)
        {
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"UPDATE email_queue
                         SET email_sent = @email_sent
                         WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", email_id);
                    cmd.Parameters.AddWithValue("email_sent", true);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        //Get all emails in the SQL email table that need to be sent
        private void UpdateQueue()
        {
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = cmd.CommandText +
                        $@"SELECT e.*
                            FROM email_queue e
                            WHERE e.email_sent = 0;";
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            _queue.Enqueue(new EmailData
                            {
                                ID = reader.GetDBInt("id"),
                                AssetID = reader.GetDBInt("asset_id"),
                                AlertID = reader.GetDBInt("alert_id"),
                                EmailSent = reader.GetDBBool("email_sent")
                            });
                        }
                    }
                }
                conn.Close();
            }
        }
    }
}
