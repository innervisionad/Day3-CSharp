using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionQuiz
{
    public partial class Form1 : Form
    {
        int timeLeft;



        public Form1()
        {
            InitializeComponent();

            question1Picture.Visible = false;
            question2Picture.Visible = false;
            question3Picture.Visible = false;

            groupBoxQuestion1.Visible = false;
            groupBoxQuestion2.Visible = false;
            groupBoxQuestion3.Visible = false;



        }
        
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("You're out of time", "Gameover");
                
            }
            else
            {
                timeLeft--;
                timerWindow.Text = timeLeft.ToString();
            }

            if (q1Answer == true && q2Answer == true && q3Answer == true)
            {
                timer1.Stop();
                MessageBox.Show("You got them all correct!", "Congratulations");
            }
        }


        bool q1Answer = false;
        bool q2Answer = false;
        bool q3Answer = false;


        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timeLeft = 60;
            startButton.Enabled = false;

            question1Picture.Visible = true;
            question2Picture.Visible = true;
            question3Picture.Visible = true;

            groupBoxQuestion1.Visible = true;
            groupBoxQuestion2.Visible = true;
            groupBoxQuestion3.Visible = true;
        }


        //question 1 options

        private void question1Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (question1Option1.Checked == true)
                question1Feedback.Text = ("X");
        }

        private void question1Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (question1Option2.Checked == true)
                question1Feedback.Text = ("\u2713");
                q1Answer = true; 
        }

        private void question1Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (question1Option3.Checked == true)
                question1Feedback.Text = ("X");
        }




        //question 2 options

        private void question2Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (question2Option1.Checked == true)
                question2Feedback.Text = ("X");
        }

        private void question2Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (question2Option2.Checked == true)
                question2Feedback.Text = ("X");
        }

        private void question2Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (question2Option3.Checked == true)
                question2Feedback.Text = ("\u2713");
                 q2Answer = true;
        }


        //question 3 options

        private void question3Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (question3Option1.Checked == true)
                question3Feedback.Text = ("\u2713");
            q3Answer = true;
        }

        private void question3Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (question3Option2.Checked == true)
                question3Feedback.Text = ("X");
        }

        private void question3Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (question3Option3.Checked == true)
                question3Feedback.Text = ("X");
        }







        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
