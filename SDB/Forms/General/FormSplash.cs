using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDB.Classes.General;
using System.IO;
using System.Drawing;

namespace SDB.Forms.General
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private async void FormSplash_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Connecting to database...";

                string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Required Files", "program_icon_gs_256x256.png");
                if (File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                }
                
                // Create a task for the connection check
                // Create a task for the connection check
                var connectionTask = Task.Run(() =>
                {
                    // Attempt to connect to the database safely
                    return ClassDatabase.TestConnection();
                });

                // Create a task for the minimum display time (e.g. 2 seconds)
                var delayTask = Task.Delay(2000);

                // Wait for both to complete
                await Task.WhenAll(connectionTask, delayTask);

                if (connectionTask.Result)
                {
                    // Connection successful
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    // Connection failed (logged internally by TestConnection)
                    MessageBox.Show("Failed to connect to the database. Please check your network connection and try again.", 
                                    "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
            catch (Exception ex)
            {
                // This catch block handles unexpected errors in the Splash logic itself
                try 
                {
                    ClassLogFile.AppendToLog("Splash Screen Error: " + ex.ToString());
                }
                catch { /* Ignore logging failure */ }

                MessageBox.Show("An unexpected error occurred: " + ex.Message, 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                DialogResult = DialogResult.Abort;
                Close();
            }
        }
    }
}
