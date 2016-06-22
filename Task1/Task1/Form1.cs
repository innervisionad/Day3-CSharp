using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;
            int year = ((int)ageDays.TotalDays) / 365;
            int day = dateTimePicker1.Value.Day;
            string month = dateTimePicker1.Value.ToString("MMMM");
            BirthdayMessage.Text = "Hello," + Name + "! You will be " + year + " years old on " + day + " " + month + ".";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Name = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
