using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Code done in a quick manner by request from Sasmsung
/// please excuse any spegetti code, I will attempt to come back and clean some of this up in the future [TA]
/// </summary>
namespace MagicInformant
{
    public partial class FormMagicInformant : Form
    {
        WeaveAPI api;
        EmailQueue emailQueue;
        //List<WeaveAPI.AlertData> ActiveAlertList;

        public FormMagicInformant()
        {
            InitializeComponent();
            api = new WeaveAPI();
            emailQueue = new EmailQueue();
        }

        public void UpdateAlerts()
        {
            api.GenerateAlerts();
            GenerateAlertList();
            
            UpdateEmailQueue();
            
        }

        public void UpdateLogData()
        {
            while (EventLog.LogQueue.Count != 0)
            {
                EventLog.Event e = EventLog.LogQueue.Dequeue();
                ClearLogView();
                AddLogLine(e);
                ScrollToBottomOfLogTbx();
            }
        }

        public void GenerateAlertList()
        {
            try
            {
                int c = 0; //count for ui display

                //List of aerts that were marked as active last data pull
                List<WeaveAPI.AlertData> CurAlertList = new List<WeaveAPI.AlertData>();
                CurAlertList = WeaveAPI.GetActiveAlerts();

                floAlertList.Controls.Clear();
                //Get alert list for active assets
                foreach (WeaveAPI.AlertData d in api.Data)
                {
                    //if asset doesn't match with SDB assets ignore
                    if (d.AssetID == null)
                        continue;


                    //check if any data indicates an alert active
                    if (!d.Connected || !d.HasContent || !d.InputSourceIsValid)
                    {
                        //check to see if alert already exists
                        if (CurAlertList.Any(x => x.AssetID == d.AssetID && x.Server == d.Server))
                        {
                            //ignore alerts if marked
                            if (!d.IgnoreAlert)
                                api.MarkAlertActive(d.ID); //otherwise mark new data as active

                            //mark old data as not active
                            int old_id = CurAlertList.Find(x => x.AssetID == d.AssetID).ID;
                            api.MarkAlertActive(old_id, false);

                        }
                        //Skip if Ignore Alert marked
                        else if (d.IgnoreAlert)
                            continue;
                        else
                        {
                            //data as active alert
                            api.MarkAlertActive(d.ID);

                            //Email customer about new Alert
                            if (d.EmailCustomer)
                                emailQueue.AddAlertEmailToQueue(d);

                        }

                        //Log the alert 
                        //TODO Change based if already exists
                        LogAlert(d);

                        //add UI control to form to show alert
                        AlertComponent ac = new AlertComponent();
                        ac.lblAlertName.Text = d.UID;
                        if (!d.Connected)
                            ac.lblAlertData.Text = "No Connection";
                        else
                            ac.lblAlertData.Text = "No Content";
                        ac.Width = floAlertList.Width - 25;
                        floAlertList.Controls.Add(ac);

                        c++;
                    }
                    else // check to see if it was previously active 
                    {
                        if (CurAlertList.Any(x => x.AssetID == d.AssetID))
                        {
                            List<WeaveAPI.AlertData> oldIDS = CurAlertList.FindAll(x => x.AssetID == d.AssetID);

                            foreach (WeaveAPI.AlertData a in oldIDS)
                                api.MarkAlertActive(a.ID, false);

                            if (d.EmailCustomer)
                                emailQueue.AddAlertEmailToQueue(d);

                        }
                    }

                }

                //indicae the number of alerts
                gbxAlerts.Text = "Alerts [" + c + "]";
            }
            catch(Exception ex)
            {
                EventLog.Event e = new EventLog.Event
                {
                    Entry = "Error: " + ex.Message,
                    TimeStamp = DateTime.Now,
                    Type = "Error"
                };
                EventLog.AddEvent(e);
            }
        }

        public void UpdateEmailQueue()
        {
            emailQueue.SendAllQueue();
        }

        public void ClearLogView()
        {
            if (tbxLog.Text.Length > 2147000000)
                tbxLog.Text = string.Empty;
        }

        private void ScrollToBottomOfLogTbx()
        {
            tbxLog.SelectionStart = tbxLog.TextLength;
            tbxLog.ScrollToCaret();
        }

        private void LogAlert(WeaveAPI.AlertData d)
        {
            EventLog.Event e = new EventLog.Event
            {
                Entry = "Alert: An Alert Is Active On " + d.UID,
                TimeStamp = DateTime.Now,
                Type = "Alert"
            };
            EventLog.AddEvent(e);
        }

        private void AddLogLine(EventLog.Event e)
        {
            //TODO change to Enum for type

            if(e.Type == "Alert")
                tbxLog.AppendText(Environment.NewLine + e.TimeStamp + " : " + e.Entry, Color.Purple);
            else if(e.Type == "Error")
                tbxLog.AppendText(Environment.NewLine + e.TimeStamp + " : " + e.Entry, Color.Red);
            else if(e.Type == "Email")
                tbxLog.AppendText(Environment.NewLine + e.TimeStamp + " : " + e.Entry, Color.Blue);
            else
                tbxLog.AppendText(Environment.NewLine + e.TimeStamp + " : " + e.Entry, Color.DarkGreen);    
        }

        //Events

        //Event to trigger data update
        private void timerUpdateAlerts_Tick(object sender, EventArgs e)
        {
            UpdateAlerts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAlerts();
        }

        private void FormMagicInformant_Load(object sender, EventArgs e)
        {
            List<EventLog.Event> el = new List<EventLog.Event>();
            el = EventLog.GetLastEvents();

            foreach(EventLog.Event ev in el)
            {
                AddLogLine(ev);
            }
            ScrollToBottomOfLogTbx();

        }

        private void timerUpdateLog_Tick(object sender, EventArgs e)
        {
            UpdateLogData();
        }

        private void tmiConfigure_Click(object sender, EventArgs e)
        {
            using(var form = new FormConfig())
            {
                form.ShowDialog();
            }
        }

        private void FormMagicInformant_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventLog.AddEvent(new EventLog.Event
            {
                Entry = "ERROR: MagicInfomant IS Closing For:" + e.CloseReason,
                TimeStamp = DateTime.Now,
                Type = "Error"
            });
        }
    }
}

//Extention Classes
public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = text.Length;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}