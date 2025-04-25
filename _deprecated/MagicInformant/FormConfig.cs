using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicInformant
{
    public partial class FormConfig : Form
    {

        EmailQueue.EmailSettings settings;

        public FormConfig()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            settings = EmailQueue.GetEmailSettings();

            tbxServer.Text = settings.Server;
            tbxPort.Text = settings.Port.ToString();
            tbxEmail.Text = settings.Email;
            tbxPassword.Text = settings.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //TODO move this all to a differnet place since data and view should be seperate, but I am running out of time. [TA]
            using (var conn = ClassDatabase.CreateMagicInformantMySqlConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = cmd.CommandText +
                        $@"UPDATE config_settings
                         SET email_host = @server, email_port = @port, email_username = @email, email_password = @password
                         WHERE id = @id";
                    cmd.Parameters.AddWithValue("id", 1);
                    cmd.Parameters.AddWithValue("server", tbxServer.Text);
                    cmd.Parameters.AddWithValue("port", Convert.ToInt32(tbxPort.Text));
                    cmd.Parameters.AddWithValue("email", tbxEmail.Text);
                    cmd.Parameters.AddWithValue("password", tbxPassword.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            Close();

        }
    }
}
