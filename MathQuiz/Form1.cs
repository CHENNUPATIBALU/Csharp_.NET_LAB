using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object to generate random numbers for Quiz
        Random rand = new Random();

        int addlabel1, addlabel2;
        int sublabel1, sublabel2;
        int mullabel1, mullabel2;
        int divlabel1, divlabel2;

        int timeLeft;

        SoundPlayer simpleSound = new SoundPlayer(MathQuiz.Properties.Resources.BeepSound);
        SoundPlayer simpleSound1 = new SoundPlayer(MathQuiz.Properties.Resources.SuccessSound);

        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            tickLabel.Visible = false;
            tickLabel1.Visible = false;
            ticklabel2.Visible = false;
            tickLabel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startQuizButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            progressBar1.Visible = true;
            startQuizButton.Enabled = false;
        }

        public void StartTheQuiz()
        {
            // For addition,
            // Assigning the generated random numbers to integer variables
            addlabel1 = rand.Next(51);
            addlabel2 = rand.Next(51);

            // Setting the integer values to plusLabels after converting them to string
            plusLeftLabel.Text = addlabel1.ToString();
            plusRightLabel.Text = addlabel2.ToString();

            // For subtraction,
            // Assigning the generated random numbers to integer variables
            sublabel1 = rand.Next(51);
            sublabel2 = rand.Next(51);

            // Setting the integer values to minusLabels after converting them to string
            minusLeftLabel.Text = sublabel1.ToString();
            minusRightLabel.Text = sublabel2.ToString();

            // For mutiplication,
            // Assigning the generated random numbers to integer variables
            mullabel1 = rand.Next(51);
            mullabel2 = rand.Next(51);

            // Setting the integer values to mulLabels after converting them to string
            mulLeftLabel.Text = mullabel1.ToString();
            mulRightLabel.Text = mullabel2.ToString();

            // For division,
            // Assigning the generated random numbers to integer variables
            divlabel1 = rand.Next(51);
            divlabel2 = rand.Next(51);

            // Setting the integer values to divLabels after converting them to string
            divLeftLabel.Text = divlabel1.ToString();
            divRightLabel.Text = divlabel2.ToString();

            // Assigning the initial values of all NumericUpDown components to '0'
            sum.Value = 0;
            multiplication.Value = 0;
            division.Value = 0;
            subtraction.Value = 0;

            // Undo to original Colors
            sum.BackColor = Color.Empty;
            multiplication.BackColor = Color.Empty;
            division.BackColor = Color.Empty;
            subtraction.BackColor = Color.Empty;

            timeLeft = 30;
            progressBar1.Value = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft<=5)
            {
                timeLabel.BackColor = Color.Red;
            }
            if(CheckAddition() && CheckSubtraction() && CheckMultiplication() && CheckDivision())
            {
                timer1.Stop();

                // plays sound
                simpleSound1.Play();

                // Sets color of NumericUpDown color to Green
                sum.BackColor = Color.LightGreen;
                subtraction.BackColor = Color.LightGreen;
                multiplication.BackColor = Color.LightGreen;
                division.BackColor = Color.LightGreen;

                // Shows this Message
                MessageBox.Show("You have answered right..","✔",MessageBoxButtons.OK,MessageBoxIcon.None);
                startQuizButton.Enabled = true;
            }
            if (CheckDivision())
            {
                tickLabel3.Text = "✔";
                tickLabel3.Visible = true;
            }
            else
            {
                tickLabel3.Text = "✖";
                tickLabel3.Visible = true;
            }
                

            if (CheckMultiplication())
            {
                ticklabel2.Text = "✔";
                ticklabel2.Visible = true;
            }
            else
                ticklabel2.Text = "✖";ticklabel2.Visible = true;

            if (CheckSubtraction())
            {
                tickLabel1.Text = "✔";
                tickLabel1.Visible = true;
            }
            else
                tickLabel1.Text = "✖";tickLabel1.Visible = true;

            if (CheckAddition())
            {
                tickLabel.Text = "✔";
                tickLabel.Visible = true;
            }
            else
                tickLabel.Text = "✖";tickLabel.Visible = true;

            if(timeLeft>0)
            {
                simpleSound.Play();
                progressBar1.Value = progressBar1.Value - 1;
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft.ToString()+" seconds";
            }
            else
            {
                // Stopping the timer
                timer1.Stop();
                timeLabel.BackColor = Color.White;
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn''t finish in time.", "Sorry");

                // Reveals the correct answers
                sum.Value = addlabel1 + addlabel2;
                subtraction.Value = sublabel1 - sublabel2;
                multiplication.Value = mullabel1 * mullabel2;
                try
                {
                    float res = divlabel1 / divlabel2;
                    division.Value = Int32.Parse(res.ToString());
                }
                catch(DivideByZeroException de)
                {
                    division.Value = 0;
                }
                startQuizButton.Enabled = true;
            }
        }

        private void sum_Enter(object sender, EventArgs e)
        {
            NumericUpDown answer = sender as NumericUpDown;
            if(answer!=null)
            {
                answer.Select(0, answer.Value.ToString().Length);
            }
        }

        public bool CheckAddition()
        {
            if ((addlabel1 + addlabel2 == sum.Value))
                return true;
            return false;
        }

        public bool CheckSubtraction()
        {
            if ((sublabel1 - sublabel2 == subtraction.Value))
                return true;
            return false;
        }
        public bool CheckMultiplication()
        {
            if ((mullabel1 * mullabel2 == multiplication.Value))
                return true;
            return false;
        }
        public bool CheckDivision()
        {
            float divresult = float.Parse(division.Value.ToString());
            try
            {
                if ((divlabel1 / divlabel2 == divresult))
                    return true;
            }
            catch(DivideByZeroException de1)
            { }
            
            return false;
        }
    }
}
