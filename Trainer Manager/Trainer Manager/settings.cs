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

namespace Trainer_Manager
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        string defaultDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cheat_trainers";
        private void settings_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.trainer_folder))
                textBox1.Text = Properties.Settings.Default.trainer_folder;
            else
                textBox1.Text = defaultDir;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.trainer_folder = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = defaultDir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!String.IsNullOrEmpty(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                textBox1.Text = fbd.SelectedPath;
            }
        }
    }
}
