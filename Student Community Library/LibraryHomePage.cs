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
    public partial class LibraryHomePage : Form
    {
        Form form2 = new Form();
        string userName,id,book;
        string getDetailsQuery = "select * from Student_Details where StudentId = @UserName";
        string getBooksDetailsQuery = "select * from Book_Details where StudentId = @StudentId";
        string borrowQuery = "select StudentId,NameOfBook from Book_Details where NameOfBook = @NameOfBook";
        string updateAvailabilityQuery = "update Book_Details set Availability = @Availability where StudentId = @StudentId";
        string updateBookQuery = "update Book_Details set NameOfBook = @NameOfBook,Availability = @Availability where StudentId = @StudentId";
        public LibraryHomePage(string userName,string password,Form form2)
        {
            InitializeComponent();
            this.userName = userName;
            this.form2 = form2;
            nameLabel.Text = "Welcome " + userName;
            GetStudentDetails();
            GetBookDetails();
        }
        public void GetStudentDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(getDetailsQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", userName);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                studentDetailsListBox.Items.Add("Student Id: "+sqlDataReader.GetString(0));
                studentDetailsListBox.Items.Add("Student Name: "+sqlDataReader.GetString(1));
                studentDetailsListBox.Items.Add("Student Mail: "+sqlDataReader.GetString(2));
                studentDetailsListBox.Items.Add("Contact: "+sqlDataReader.GetString(3));
            }
            sqlConnection.Close();
        }
        public void GetBookDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(getBooksDetailsQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentId", userName);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bookDetailsListBox.Items.Clear();
            while (sqlDataReader.Read())
            {
                bookDetailsListBox.Items.Add("Name of Book: " + sqlDataReader.GetString(1));
                bookDetailsListBox.Items.Add("Author: " + sqlDataReader.GetString(2));
                bookDetailsListBox.Items.Add("Availability: " + sqlDataReader.GetString(3));
            }
            sqlConnection.Close();
        }
        private void BorrowBook()
        {
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            SqlCommand sqlCommand1 = new SqlCommand(updateBookQuery, sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@NameOfBook", book);
            sqlCommand1.Parameters.AddWithValue("@Availability", "yes");
            sqlCommand1.Parameters.AddWithValue("@StudentId", userName);
            int rows = sqlCommand1.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show(book + " Book borrowed");
            UpdateAvailability("no", id);
            GetBookDetails();
        }
        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            BorrowBook();
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            form2.Show();
            Close();
        }
        private void UpdateAvailability(string availability,string id)
        {
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(updateAvailabilityQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@StudentId", id);
            sqlCommand.Parameters.AddWithValue("@Availability", availability);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            SqlConnection sqlConnection = new SqlConnection(Student_Community_Library.Properties.Settings.Default.Community_LibraryConnectionString1);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(borrowQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NameOfBook", searchText);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                id = sqlDataReader.GetString(0);
                book = sqlDataReader.GetString(1);
                DialogResult dialogResult = MessageBox.Show("Book: "+book + " is with Id number: " + id+ "\nDo you want to borrow ?", "Found",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
                {
                    BorrowBook();
                }
            }
            else
                MessageBox.Show("No Book Found with the name "+searchText);

            sqlDataReader.Close();
            sqlConnection.Close();
        }
    }
}
