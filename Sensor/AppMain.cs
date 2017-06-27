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
            //check_chk();
            if(connection.State!=ConnectionState.Open)connection.Open();
            
            string commandText =
                $"select * from oreki where timestamp >= {timestamp(dateTimePicker1.Value)} and timestamp <= {timestamp(dateTimePicker2.Value)}";
            string newCommandText = string.Empty;
            if (rb01TempC.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'TempC'";
            }
            else if (rb02TempF.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'TempF'";
            }
            else if(rb03HeatIndexC.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'HeatIndexC'";
            }
            else if (rb04HeatIndexF.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'HeatIndexF'";
            }
            else if(rb05Light.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'GY30'";
            }
            else if(rb06Humidity.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'Humidity'";
            }
            else if(rb07IR.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'IRSensor'";
            }
            else if(rb08Touch.Checked)
            {
                newCommandText = commandText + $" and sensor_type = 'TouchSensor'";
            }
            
            MySqlDataAdapter dataAdapter=new MySqlDataAdapter(newCommandText,ConnectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "timestamp");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "timestamp";
            dataGridView1.Columns[0].DataPropertyName = dataSet.Tables[0].Columns[0].ToString();
            dataAdapter.Fill(dataSet, "sensor_type");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "sensor_type";
            dataGridView1.Columns[1].DataPropertyName = dataSet.Tables[1].Columns[1].ToString();
            dataAdapter.Fill(dataSet, "value");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "value";
            dataGridView1.Columns[2].DataPropertyName = dataSet.Tables[2].Columns[2].ToString();

        }

        private void AppMain_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
        }

        public string timestamp(DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            long timeStamp = (long)(time - startTime).TotalSeconds; // 相差秒数
            return timeStamp.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = radioButton1.Checked;
        }
    }
}

