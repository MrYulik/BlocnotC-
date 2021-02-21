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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string PATH;

        public Form1()
        {
            InitializeComponent();
        }

        private void вилToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void переносПроСтрокамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            переносПроСтрокамToolStripMenuItem.Checked = !переносПроСтрокамToolStripMenuItem.Checked;
            textBox1.WordWrap = переносПроСтрокамToolStripMenuItem.Checked;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PATH = dialog.FileName;
                    textBox1.Text = File.ReadAllText(PATH);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PATH))
            {
                using(SaveFileDialog dialog = new SaveFileDialog())
                {
                    if(dialog.ShowDialog() == DialogResult.OK)
                    {
                        PATH = dialog.FileName;
                        File.WriteAllText(PATH, textBox1.Text);
                    }
                }
            }
            File.WriteAllText(PATH, textBox1.Text);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Undo();

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Cut();

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Copy();

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Paste();

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Clear();

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.SelectAll();

        private void времяToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Text += DateTime.Now;

        private void темаToolStripMenuItem_Click(object sender, EventArgs e) => textBox1.Text += "Скоро!";
    }
}
