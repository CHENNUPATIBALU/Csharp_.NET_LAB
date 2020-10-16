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

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Label firstClicked = null;
        Label secondClicked = null;
        bool winner = false;
        static int endTime = 0;

        // List
        // Icons to the labels
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z",
            "j", "j", "t", "t", "u", "u", "p", "p",
            "f", "f", "F", "F", "G", "G", "H", "H",
            "I", "I", "J", "J", "K", "K", "P", "P",
            "Q", "Q", "R", "R", "S", "S", "T", "T",
            "%", "%", "&", "&", "?", "?", "``", "``",
            "~", "~", "@", "@", "^", "^", "+", "+"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()        // Assigning the icons to Squares
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel!=null)
                {
                    // Generating random numbers to assign labels in the label
                    int randomNumber = rand.Next(icons.Count);

                    // Assigning the icons
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;

                    // Remove string icon from the list
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            // Setting the Sound Players
            SoundPlayer sp1 = new SoundPlayer(Matching_Game.Properties.Resources.Click2_Sebastian_759472264);
            SoundPlayer sp3 = new SoundPlayer(Matching_Game.Properties.Resources.Pellet_Gun_Pump_SoundBible_com_517750307);

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // shows the label, if it is null
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    sp1.Play();
                    clickedLabel.ForeColor = Color.Black; timer3.Start();
                    return;
                }

                secondClicked = clickedLabel;
                // plays the sound
                sp1.Play();
                clickedLabel.ForeColor = Color.Black;

                // Checks for the Winner
                CheckForWinner();

                if(firstClicked.Text == secondClicked.Text)
                {
                    // Assigning 'null' to the Label references
                    firstClicked = null;
                    secondClicked = null;
                    sp3.Play();     // plays sound
                    return;
                }

                // Starting of timers
                timer1.Start();
                timer2.Start();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sp2 = new SoundPlayer(Matching_Game.Properties.Resources.Button_Push_Mike_Koenig_1659525069);

            timer1.Stop();  // Stops the timer

            sp2.Play();     // plays sound

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Assigning 'null' to the Label references
            firstClicked = null;
            secondClicked = null;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval > 0 && !winner)
                endTime += timer2.Interval / 1000;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked == null)
            {
                firstClicked.ForeColor = firstClicked.BackColor;
                timer3.Stop();
            }
        }

        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel!=null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)     //Checks whether the fore-color and back-color is same
                        return;
                }
            }

            SoundPlayer sp = new SoundPlayer(Matching_Game.Properties.Resources.game_win_sound_effect__online_audio_converter_com_);
            sp.Play();      // Plays a Sound
            winner = true;

            // Showing a message that the user WON
            MessageBox.Show("You matched all the Icons"+"\n\n"+"Time taken to match : "+endTime+" seconds", "Congratulations ✌", MessageBoxButtons.OK);
            Close();    // Closes the Form
        }
        
    }
}
