using System;
using static Sensor.EnvironmentVariables;

namespace Sensor
{
    partial class Read
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial1 = new System.IO.Ports.SerialPort(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb08Touch = new System.Windows.Forms.RadioButton();
            this.rb07IR = new System.Windows.Forms.RadioButton();
            this.rb06Humidity = new System.Windows.Forms.RadioButton();
            this.rb05Light = new System.Windows.Forms.RadioButton();
            this.rb04HeatIndexF = new System.Windows.Forms.RadioButton();
            this.rb03HeatIndexC = new System.Windows.Forms.RadioButton();
            this.rb02TempF = new System.Windows.Forms.RadioButton();
            this.rb01TempC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(323, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb08Touch);
            this.groupBox1.Controls.Add(this.rb07IR);
            this.groupBox1.Controls.Add(this.rb06Humidity);
            this.groupBox1.Controls.Add(this.rb05Light);
            this.groupBox1.Controls.Add(this.rb04HeatIndexF);
            this.groupBox1.Controls.Add(this.rb03HeatIndexC);
            this.groupBox1.Controls.Add(this.rb02TempF);
            this.groupBox1.Controls.Add(this.rb01TempC);
            this.groupBox1.Location = new System.Drawing.Point(32, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rb08Touch
            // 
            this.rb08Touch.AutoSize = true;
            this.rb08Touch.Location = new System.Drawing.Point(399, 52);
            this.rb08Touch.Name = "rb08Touch";
            this.rb08Touch.Size = new System.Drawing.Size(56, 17);
            this.rb08Touch.TabIndex = 7;
            this.rb08Touch.Text = "Touch";
            this.rb08Touch.UseVisualStyleBackColor = true;
            // 
            // rb07IR
            // 
            this.rb07IR.AutoSize = true;
            this.rb07IR.Location = new System.Drawing.Point(399, 19);
            this.rb07IR.Name = "rb07IR";
            this.rb07IR.Size = new System.Drawing.Size(36, 17);
            this.rb07IR.TabIndex = 6;
            this.rb07IR.Text = "IR";
            this.rb07IR.UseVisualStyleBackColor = true;
            // 
            // rb06Humidity
            // 
            this.rb06Humidity.AutoSize = true;
            this.rb06Humidity.Location = new System.Drawing.Point(312, 52);
            this.rb06Humidity.Name = "rb06Humidity";
            this.rb06Humidity.Size = new System.Drawing.Size(65, 17);
            this.rb06Humidity.TabIndex = 5;
            this.rb06Humidity.Text = "Humidity";
            this.rb06Humidity.UseVisualStyleBackColor = true;
            // 
            // rb05Light
            // 
            this.rb05Light.AutoSize = true;
            this.rb05Light.Location = new System.Drawing.Point(312, 19);
            this.rb05Light.Name = "rb05Light";
            this.rb05Light.Size = new System.Drawing.Size(48, 17);
            this.rb05Light.TabIndex = 4;
            this.rb05Light.Text = "Light";
            this.rb05Light.UseVisualStyleBackColor = true;
            // 
            // rb04HeatIndexF
            // 
            this.rb04HeatIndexF.AutoSize = true;
            this.rb04HeatIndexF.Location = new System.Drawing.Point(190, 53);
            this.rb04HeatIndexF.Name = "rb04HeatIndexF";
            this.rb04HeatIndexF.Size = new System.Drawing.Size(90, 17);
            this.rb04HeatIndexF.TabIndex = 3;
            this.rb04HeatIndexF.Text = "HeatIndex(*F)";
            this.rb04HeatIndexF.UseVisualStyleBackColor = true;
            // 
            // rb03HeatIndexC
            // 
            this.rb03HeatIndexC.AutoSize = true;
            this.rb03HeatIndexC.Location = new System.Drawing.Point(190, 20);
            this.rb03HeatIndexC.Name = "rb03HeatIndexC";
            this.rb03HeatIndexC.Size = new System.Drawing.Size(91, 17);
            this.rb03HeatIndexC.TabIndex = 2;
            this.rb03HeatIndexC.Text = "HeatIndex(*C)";
            this.rb03HeatIndexC.UseVisualStyleBackColor = true;
            // 
            // rb02TempF
            // 
            this.rb02TempF.AutoSize = true;
            this.rb02TempF.Location = new System.Drawing.Point(43, 53);
            this.rb02TempF.Name = "rb02TempF";
            this.rb02TempF.Size = new System.Drawing.Size(101, 17);
            this.rb02TempF.TabIndex = 1;
            this.rb02TempF.Text = "Temperature(*F)";
            this.rb02TempF.UseVisualStyleBackColor = true;
            // 
            // rb01TempC
            // 
            this.rb01TempC.AutoSize = true;
            this.rb01TempC.Checked = true;
            this.rb01TempC.Location = new System.Drawing.Point(43, 20);
            this.rb01TempC.Name = "rb01TempC";
            this.rb01TempC.Size = new System.Drawing.Size(102, 17);
            this.rb01TempC.TabIndex = 0;
            this.rb01TempC.TabStop = true;
            this.rb01TempC.Text = "Temperature(*C)";
            this.rb01TempC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 280);
            this.dataGridView1.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(457, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Other";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(504, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 9;
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 593);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Upload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamZ Serial-Database Adapater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.AppMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serial1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb06Humidity;
        private System.Windows.Forms.RadioButton rb05Light;
        private System.Windows.Forms.RadioButton rb04HeatIndexF;
        private System.Windows.Forms.RadioButton rb03HeatIndexC;
        private System.Windows.Forms.RadioButton rb02TempF;
        private System.Windows.Forms.RadioButton rb01TempC;
        private System.Windows.Forms.RadioButton rb08Touch;
        private System.Windows.Forms.RadioButton rb07IR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}