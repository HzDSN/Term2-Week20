using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static Sensor.EnvironmentVariables;
using  MySql.Data.MySqlClient;

namespace Sensor
{
    public partial class AppMain : Form
    {
        private string dataReadLine;
        MySqlConnection connection = new MySqlConnection(EnvironmentVariables.ConnectionString);
        int exiting;
        public AppMain()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = EnvironmentVariables.AppName;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exiting != 1)
            {
                var isExit = MessageBox.Show("Are you sure want to exit?", AppName, YesNo, Question);
                if (isExit == DialogResult.Yes)
                {
                    exiting = 1;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "Open":
                    OpenPort();
                    break;
                default:
                    ClosePort();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "Start Transferring to Database":
                {
                    StartTrans();
                    button2.Text = "Stop Transferring";
                    break;
                }
                default:
                {
                    StopTrans();
                    button2.Text = "Start Transferring to Database";
                    break;
                }
            }
        }

        public void OpenPort()
        {
            
            try
            {
            serial1.PortName = textBox1.Text;
            serial1.BaudRate = Convert.ToInt32(textBox3.Text);
            serial1.DataBits = 8;
                serial1.Open();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.GetType().ToString() + "\n" + exception.Message.ToString());
                //MessageBox.Show("Open port failed! Check your port name and baud rate.", AppName, OK, Exclamation);
                return;
            }
            toolStripStatusLabel1.ForeColor = Color.Green;
            toolStripStatusLabel1.Text = $"Serial Port: {textBox1.Text}";
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = true;
            button1.Text = "Close";
        }

        public void ClosePort()
        {
            StopTrans();
            serial1.Close();
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Text = "Serial Port: Closed";
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = false;
            button1.Text = "Open";
        }

        public void StartTrans()
        {
            connection.Open();
            toolStripStatusLabel2.Text = "Database: Open";
            toolStripStatusLabel2.ForeColor=Color.Green;
        }

        public void StopTrans()
        {
            connection.Close();
            toolStripStatusLabel2.Text = "Database: Closed";
            toolStripStatusLabel2.ForeColor = Color.Red;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.Text = EnvironmentVariables.AppName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.Print(this.Text);
        }

        private void serial1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            dataReadLine = serial1.ReadLine();
            textBox2.Text += dataReadLine;
            textBox2.Text += (char)0x0a;
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                
                
                    var splited = dataReadLine.Split(':');
                    var commandText = $"insert into oreki values ('{timestamp().ToString()}','{splited[0]}','{/*Convert.ToDouble(*/splited[1]/*)*/}')";
                    var command = new MySqlCommand(commandText,connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.GetType().ToString()+"\n"+exception.Message.ToString());
                }


            }
        }

        private long timestamp()
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            long timeStamp = (long)(DateTime.Now - startTime).TotalSeconds; // 相差秒数
            return timeStamp;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Text=String.Empty;
        }
    }
}

