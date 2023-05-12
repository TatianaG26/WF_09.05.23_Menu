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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_09._05._23_Menu
{
    public partial class Form1 : Form
    {
        OpenFileDialog f1;
        string filePath;
        SaveFileDialog f2;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f1 = new OpenFileDialog();
                f1.InitialDirectory = Directory.GetCurrentDirectory();
                f1.Filter = "Text Files|*.txt"; //Чтобы открыть файл в формате.txt
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    filePath = f1.FileName; // путь к выбраному файлу
                    this.Text = filePath;   // установка пути в заголовок формы

                    StreamReader r = new StreamReader(f1.FileName);
                    richTextBox.Text = r.ReadToEnd();
                    r.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f2 = new SaveFileDialog();
                f2.Filter = "Text Files|*.txt"; // Чтобы сохранить файл в формате .txt
                f2.InitialDirectory = filePath; // Сохранить в ранее открытой папке
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter w = new StreamWriter(f2.FileName, true);
                    w.WriteLine(richTextBox.Text);
                    w.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void новыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f2 = new SaveFileDialog();
                f2.Filter = "Text Files|*.txt"; // Чтобы сохранить файл в формате .txt
                f2.InitialDirectory = Directory.GetCurrentDirectory();
                if (f2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter w = new StreamWriter(f2.FileName);
                    w.WriteLine(richTextBox.Text);
                    w.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.BackColor = colorDialog.Color; // весь фон
            }
        }
        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }
        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

    }
}
