using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Sensor.EnvironmentVariables;

namespace Sensor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString=
                $@"Server={textBox1.Text};Port={textBox2.Text};Database={textBox5.Text};Uid={textBox3.Text};Pwd={
                    textBox4.Text
                };";
            var connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Connection failed!
1. Check your network connection.
2. Ensure that your user id or password are right.
3. Contact your network administrator for more information.", AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if(connection.State != ConnectionState.Closed)connection.Close();
            AppMain form2 = new AppMain();
            form2.Show();
            form2.Text = $"{EnvironmentVariables.AppName} - [{textBox1.Text}]";
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
