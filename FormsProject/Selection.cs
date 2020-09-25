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
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
            else
                groupBox2.Visible = false;
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
                if (cse_radioButton.Checked)
                    return "Computer Science";
                else if (mec_radioButton.Checked)
                    return "Mechanical";
                else if (electrical_radioButton.Checked)
                    return "Electrical";
                else if (electronics_radioButton.Checked)
                    return "Electronics";
                else if (ise_radioButton.Checked)
                    return "Information Science";
                else if (civil_radioButton.Checked)
                    return "Civil";
                else if (pet_radioButton.Checked)
                    return "Petroleum";
                else
                    return "No Branch is Selected";
            }
            else if(law_RadioButton.Checked)
            {
                if (civilLaw_radioButton.Checked)
                    return "Civil Law";
                else if (criminalLaw_RadioButton.Checked)
                    return "Criminal Law";
                else if (corporateLaw_radioButton.Checked)
                    return "Corporate Law";
                else if (internationalLaw_radioButton.Checked)
                    return "International Law";
                else if (labourLaw_RadioButton.Checked)
                    return "Labour Law";
                else if (realEstateLaw_radioButton.Checked)
                    return "RealEstate Law";
                else if (patentLaw_radioButton.Checked)
                    return "Patent Law";
                else if (mediaLaw_radioButton.Checked)
                    return "Media Law";
                else if (competitionLaw_radioButton.Checked)
                    return "Competition Law";
                else if (intellectualPropertyLaw_radioButton.Checked)
                    return "Intellectual Property Law";
                else if (mergersAquisitionLaw_radioButton.Checked)
                    return "Mergers and Aquisition Law";
                else
                    return "Branch Not Selected";
            }
            else if(mba_RadioButton.Checked)
            {
                if (finance_radioButton.Checked)
                    return "MBA in Finanace";
                else if (humanResourceManagement_radioButton.Checked)
                    return "MBA in Human Resource Management";
                else if (informationTechnology_radioButton.Checked)
                    return "MBA in Information Technology";
                else if (logisticsManagement_radioButton.Checked)
                    return "MBA in Logistics Management";
                else if (marketingManagement_radioButton.Checked)
                    return "MBA in Marketing Management";
                else if (businessManagement_radioButton.Checked)
                    return "MBA in Business Management";
                else if (ruralManagement_radioButton.Checked)
                    return "MBA in Rural Management";
                else if (healthCareManagement_radioButton.Checked)
                    return "MBA in Health Care Management";
                else if (operationsManagement_radioButton.Checked)
                    return "MBA in Operations Management";
                else if (eventManagement_radioButton.Checked)
                    return "MBA in Event Management";
                else if (businessManagement_radioButton.Checked)
                    return "MBA in Business Analytics";
                else
                    return "Branch not Selected";
            }
            /*else if(bca_RadioButton.Checked)
            {

            }*/
            else
                return null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void law_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(law_RadioButton.Checked)
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void mba_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mba_RadioButton.Checked)
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
            }
            else
                groupBox4.Visible = false;
        }
    }
}
