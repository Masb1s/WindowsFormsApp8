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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void save()
        {
            System.IO.StreamWriter write =
                new System.IO.StreamWriter(
                    saveFileDialog1.FileName,
                    false,
                    System.Text.Encoding.UTF8);

            write.Write(richTextBox1.Text);

            write.Close();

            richTextBox1.Modified = false;
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
       "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader read =
                    new StreamReader(
                        openFileDialog1.FileName,
                        System.Text.Encoding.UTF8);

                richTextBox1.Text = read.ReadToEnd();

                read.Close();
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter =
       "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                save();
            }
        }

        private void друкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void проАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Розробник: Максим Кузьменко Група: оІк-43",
        "Довідка");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            richTextBox1.SelectionFont = fontDialog1.Font;
        }
    }
}
