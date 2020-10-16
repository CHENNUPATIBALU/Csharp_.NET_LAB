﻿using System;
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

        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel!=null)
                {
                    int randomNumber = rand.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            SoundPlayer sp1 = new SoundPlayer(Matching_Game.Properties.Resources.Click2_Sebastian_759472264);

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    sp1.Play();
                    clickedLabel.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                sp1.Play();
                clickedLabel.ForeColor = Color.Black;

                CheckForWinner();

                if(firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SoundPlayer sp2 = new SoundPlayer(Matching_Game.Properties.Resources.Button_Push_Mike_Koenig_1659525069);
            timer1.Stop();

            sp2.Play();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel!=null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            SoundPlayer sp = new SoundPlayer(Matching_Game.Properties.Resources.game_win_sound_effect__online_audio_converter_com_);
            sp.Play();
            MessageBox.Show("You matched all the Icons", "Congratulations", MessageBoxButtons.OK);
            Close();
        }
    }
}
