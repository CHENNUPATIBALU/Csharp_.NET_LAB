using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Student_Community_Library
{
    public partial class Form1 : Form
    {
        string loginQuery;
        public Form1()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            if (CheckLoginDetails(userName, password))
            {
                new LibraryHomePage(userName,password,this).Show();
                Hide();
            }
            else
                MessageBox.Show("Incorrect Credentials");
        }
        public bool CheckLoginDetails(string userName,string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            loginQuery = "select * from User_Login where UserName = @UserName and Password = @Password";
            SqlCommand sqlCommand = new SqlCommand(loginQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", userName);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
                return true;
            else
                return false;
        }
    }
}
