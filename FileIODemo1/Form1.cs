using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIODemo1
{
    public partial class Form1 : Form
    {
        string selectedItem;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            const float oneKB = 1024;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                // Clear the items
                listBox1.Items.Clear();
                string fileName = openFileDialog1.FileName;
                FileInfo f = new FileInfo(fileName);
                listBox1.Items.Add("File name : " + f.Name);
                listBox1.Items.Add("Type of File : (" + f.Extension+")");
                listBox1.Items.Add("Location : "+f.Directory);
                listBox1.Items.Add("Size : " + (f.Length / oneKB)+ "KB" + " (" + f.Length + " bytes)");
                listBox1.Items.Add("Last Accessed Time : " + f.LastAccessTime);
                listBox1.Items.Add("Date modified : " + f.CreationTime);
                listBox1.Items.Add("ReadOnly : " + f.IsReadOnly);
            }
        }

        private void listDiskButton_Click(object sender, EventArgs e)
        {
            //Clears the ListBox
            listBox1.Items.Clear();
            //Displays the logical drives
            foreach(string diskDrive in Directory.GetLogicalDrives())
            {
                listBox1.Items.Add(diskDrive);
            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            selectedItem = listBox1.SelectedItem.ToString();
            try
            {
                if (selectedItem != null)
                {
                        listBox1.Items.Clear();
                        foreach (string directory in Directory.GetDirectories(selectedItem))
                        {
                            listBox1.Items.Add(directory);
                        }
                        foreach(string file in Directory.GetFiles(selectedItem))
                        {
                            listBox1.Items.Add(file);
                        }
                }
            }
            catch(DirectoryNotFoundException dnfe)
            {
                MessageBox.Show("Selected Item is not a directory");
            }
            catch(Exception be)
            {
                MessageBox.Show("Cannot open the file in ListBox");
            }
                
                
                
            
        }
    }
}
