using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static Sensor.EnvironmentVariables;

namespace Sensor
{
    public partial class AppMain : Form
    {
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
                    break;
                }
                default:
                {
                    StopTrans();
                    break;
                }
            }
        }

        public void OpenPort()
        {
            serial1.PortName = textBox1.Text;
            serial1.BaudRate = Convert.ToInt32(textBox3.Text);
            serial1.DataBits = 8;
            try
            {
                serial1.Open();
            }
            catch
            {
                MessageBox.Show("Open port failed! Check your port name and baud rate.", AppName, OK, Exclamation);
                return;
            }
            toolStripStatusLabel1.ForeColor = Color.Green;
            toolStripStatusLabel1.Text = $"Serial Port: {textBox1.Text}";
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = true;
        }

        public void ClosePort()
        {
            StopTrans();
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Text = "Serial Port: Closed";
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = false;
        }

        public void StartTrans()
        {

        }

        public void StopTrans()
        {

        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.Text = EnvironmentVariables.AppName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.Print(this.Text);
        }
    }
}
