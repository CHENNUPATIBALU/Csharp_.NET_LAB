using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDemo
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bTech_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bTech_RadioButton.Checked)
            {
                Btech_label.Visible = true;
                MBALabel.Visible = false;
                BCAlabel.Visible = false;
                LawLabel.Visible = false;
                bTech_comboBox.Visible = true;
                mba_comboBox.Visible = false;
                bca_comboBox.Visible = false;
                lawComboBox.Visible = false;
            }
            else
                bTech_comboBox.Visible = false;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            String selectedCourse = GetSelection();

            MessageBox.Show("You have Enrolled/Selected "+selectedCourse,"Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private String GetSelection()
        {
            if (bTech_RadioButton.Checked)
            {
                try
                {
                    if (bTech_comboBox.SelectedItem.Equals("Computer Science and Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Information Science and Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Mechanical Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Electrical Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Electronics Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Civil Engineering"))
                        return bTech_comboBox.Text;
                    else if (bTech_comboBox.SelectedItem.Equals("Petroleum Engineering"))
                        return bTech_comboBox.Text;
                    else
                        return "No Branch is selected";
                }
                catch(NullReferenceException ne)
                { }
                
            }
            else if(law_RadioButton.Checked)
            {
                try
                {
                    if (lawComboBox.SelectedItem.Equals("Civil Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Tax Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Criminal Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Corporate Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("International Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Labour Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Real Estate Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Patent Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Media Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Competition Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Intellectual Property Law"))
                        return lawComboBox.Text;
                    else if (lawComboBox.SelectedItem.Equals("Mergers and Aquisition Law"))
                        return lawComboBox.Text;
                    else
                        return "No Branch is Selected";
                }
                catch (NullReferenceException nr) { }
            }
            else if(mba_RadioButton.Checked)
            {
                try
                {
                    if (mba_comboBox.SelectedItem.Equals("MBA in Finance"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Human Resource Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Information Technology(IT)"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Logistics Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Marketing Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Business Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Rural Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Health Care Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Operations Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Event Management"))
                        return mba_comboBox.Text;
                    else if (mba_comboBox.SelectedItem.Equals("MBA in Business Analytics"))
                        return mba_comboBox.Text;
                    else
                        return "No Branch is Selected";
                }
                catch (NullReferenceException ne) { }
            }
            else if(bca_RadioButton.Checked)
            {
                try
                {
                    if (bca_comboBox.SelectedItem.Equals("Programming Languages"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Database Management"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Computer Graphics"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Animation"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Accounting Application"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("System Analysis"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Word Processing"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Internet Technologies"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Personal Information Management"))
                        return bca_comboBox.Text;
                    else if (bca_comboBox.SelectedItem.Equals("Music and Video Processing"))
                        return bca_comboBox.Text;
                    else
                        return "No Branch is Selected";
                }
                catch(NullReferenceException nre) { }
                
            }
            return null;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void law_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(law_RadioButton.Checked)
            {
                Btech_label.Visible = false;
                MBALabel.Visible = false;
                BCAlabel.Visible = false;
                bTech_comboBox.Visible = false;
                mba_comboBox.Visible = false;
                bca_comboBox.Visible = false;
                LawLabel.Visible = true;
                lawComboBox.Visible = true;
            }
            else
            {
                lawComboBox.Visible = false;
            }
        }

        private void mba_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mba_RadioButton.Checked)
            {
                Btech_label.Visible = false;
                MBALabel.Visible = true;
                BCAlabel.Visible = false;
                LawLabel.Visible = false;
                bTech_comboBox.Visible = false;
                mba_comboBox.Visible = true;
                bca_comboBox.Visible = false;
                lawComboBox.Visible = false;
            }
            else
                mba_comboBox.Visible = false;
        }

        private void bTech_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bca_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bca_RadioButton.Checked)
            {
                Btech_label.Visible = false;
                MBALabel.Visible = false;
                BCAlabel.Visible = true;
                LawLabel.Visible = false;
                bTech_comboBox.Visible = false;
                mba_comboBox.Visible = false;
                bca_comboBox.Visible = true;
                lawComboBox.Visible = false;
            }
            else
                bca_comboBox.Visible = false;
        }
    }
}
