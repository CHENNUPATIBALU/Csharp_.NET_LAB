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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.textBox1.Text;
            String password = this.textBox2.Text;
            if (username.Equals("balu") && password.Equals("1234"))
            {
                Selection s = new Selection();
                this.Hide();
                s.Show();
                //MessageBox.Show("Successfully Logged in", "Important Note", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Incorrect credentials", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
