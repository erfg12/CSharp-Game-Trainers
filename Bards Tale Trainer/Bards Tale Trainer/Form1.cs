using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Bards_Tail_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (m.OpenProcess("The Bard's Tale"))
                {
                    readStatsBtn.Invoke(new MethodInvoker(delegate
                    {
                        readStatsBtn.PerformClick(); //press read stats button for me
                    }));
                    procLabel.Invoke(new MethodInvoker(delegate
                    {
                        procLabel.Text = "Process: Open";
                        procLabel.ForeColor = Color.Green;
                    }));
                }
            }
        }

        void writeTheByte(string byte2write, string address, string type = "byte")
        {
            //this will check if our textboxes are blank. If they are, write 0 to code.
            //this also converts our integers to hex values for byte writing.
            string value = "0";

            if (byte2write == "")
                value = "0";
            else
            {
                value = byte2write;
                if (Convert.ToInt64(value) > 127 && type == "byte") //byte cant be bigger than 127
                    value = "127";

                if (Convert.ToInt64(value) > 999999 && type == "int") //integer cant be bigger than 999999
                    value = "999999";

                if (type == "byte")
                    value = Convert.ToInt64(value).ToString("X");
            }

            m.WriteMemory(address, type, value);
        }

        private void experience_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(experience.Text, "base+0x0087030C", "2bytes");
        }

        private void silver_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(silver.Text, "base+0x0087031C", "int");
        }

        private void strength_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(strength.Text, "base+0x0087044d");
        }

        private void vitality_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(vitality.Text, "base+0x0087044e");
        }

        private void luck_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(luck.Text, "base+0x0087044f");
        }

        private void dexterity_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(dexterity.Text, "base+0x00870450");
        }

        private void charisma_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(charisma.Text, "base+0x00870451");
        }

        private void rhythm_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(rhythm.Text, "base+0x00870452");
        }

        private void addrstones_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(addrstones.Text, "base+0x008703CA");
        }

        private void health_TextChanged(object sender, EventArgs e)
        {
            writeTheByte(health.Text, "base+0x008703C4", "int");
        }

        private void silver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void strength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void vitality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void luck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void dexterity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void charisma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void rhythm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void addrstones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void experience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void health_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true; //only digits
        }

        private void readStatsBtn_Click(object sender, EventArgs e)
        {
            if (m.OpenProcess("The Bard's Tale")) //write defaults
            {
                health.Text = m.Read2Byte("base+0x008703C4").ToString();
                experience.Text = m.ReadInt("base+0x0087030C").ToString();
                silver.Text = m.ReadInt("base+0x0087031C").ToString();
                strength.Text = m.ReadByte("base+0x0087044d").ToString();
                vitality.Text = m.ReadByte("base+0x0087044e").ToString();
                luck.Text = m.ReadByte("base+0x0087044f").ToString();
                dexterity.Text = m.ReadByte("base+0x00870450").ToString();
                charisma.Text = m.ReadByte("base+0x00870451").ToString();
                rhythm.Text = m.ReadByte("base+0x00870452").ToString();
                addrstones.Text = m.ReadByte("base+0x008703CA").ToString();
            }
        }  
    }
}
