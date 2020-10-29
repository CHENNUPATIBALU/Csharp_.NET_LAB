using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileIODemo
{
    public partial class Form1 : Form
    {
        private readonly string fileFilter = @"C:\\Users\\chenn\\Desktop";
        private readonly string fileType = @"Plain Text Format (.txt)|*.txt|CSharp Source File (.cs)|*.cs";
        public Form1()
        {
            InitializeComponent();
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = null;
            openFileDialog1.InitialDirectory = fileFilter;
            openFileDialog1.Filter = fileType;
            if (reader == null)
            {
                try
                {
                    if(openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        reader = new StreamReader(openFileDialog1.FileName);
                        textBox1.Text = reader.ReadToEnd();
                    }  
                }
                catch (FileNotFoundException de)
                {
                    MessageBox.Show("Error! File is not found");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Error");
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter writer = null;
            saveFileDialog1.InitialDirectory = fileFilter;
            saveFileDialog1.Filter = fileType;
            if (writer == null)
            {
                try
                {
                    if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        writer = new StreamWriter(saveFileDialog1.FileName);
                        writer.Write(textBox1.Text);
                    }    
                }
                catch (DirectoryNotFoundException de)
                {
                    MessageBox.Show("Error! Directory is not found" + "\n" + "Check the directory");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Error");
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
