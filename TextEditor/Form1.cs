using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private readonly string fileFilter = @"C:\\Users\\chenn\\Desktop";
        private readonly string fileType = "Rich Text Format (.rtf) |*.rtf|Plain Text Format (.txt)|*.txt|CSharp Source File (.cs)|*.cs";
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel1.Text = e.ClickedItem.Text;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Equals("") && newToolStripMenuItem.Enabled)
            {
                richTextBox1.Clear();
            }
            else
            {
                MessageBox.Show("Save the file", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                saveToolStripMenuItem_Click(sender, e);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = fileFilter;
            saveFileDialog1.Filter = fileType;
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.FileName != null)
            {
                if (saveFileDialog1.Filter.Contains(".txt"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = fileFilter;
            openFileDialog1.Filter = fileType;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != null)
                {
                    if (openFileDialog1.FileName.Contains(".txt"))
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    else
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Empty file Name", "Error");
                }
            }
        }

        private void plainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = fileFilter;
            saveFileDialog1.Filter = @"Plain Text Format (.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != null)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void cSourceFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = fileFilter;
            saveFileDialog1.Filter = @"CSharp Source File(.cs)| *.cs";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != null)
            {
                if (saveFileDialog1.FileName.Contains(".cs"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }
        }

        private void richTextFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.FileName != null)
            {
                if (saveFileDialog1.FileName.Contains(".rtf"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is done by CHENNUPATI BALU" + "\n" + " This a tutorial project in C#", "About");
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            contentsToolStripMenuItem.Enabled = true;
        }
    }
}
