using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using Memory;

// This source is an example of how to add internal codes without the use of a codes.ini file.

namespace MW3_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        
        public Mem MemLib = new Mem();

        public bool loaded;

        private void openGame()
        {
            if (loaded)
                return;
            
            int gameProcId = MemLib.getProcIDFromName("iw5sp"); //use task manager to find game name. For CoD MW3 it is iw5sp. Do not add .exe extension

            if (gameProcId != 0)
            {
                loaded = true;
                ProcessID.Text = gameProcId.ToString();
                MemLib.OpenGameProcess(gameProcId);
            }
        }

        protected override void WndProc(ref Message m) //hotbuttons
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    button1.PerformClick();
                }
                else if (id == 2)
                {
                    button2.PerformClick();
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 1, 0, (int)Keys.Oemplus);
            RegisterHotKey(this.Handle, 1, 0, (int)Keys.Add);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.OemMinus);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.Subtract);

            //start our backgroundworker. (similar to a timer, but works on a seperate thread)
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) //infinite loop
            {
                openGame();
                //because we are working on a seperate thread from the UI, we need to use invoke on our UI elements.

                if (godmode_checkbox.Checked)
                    MemLib.writeMemory("iw5sp.exe+D97C28", "int", "100"); //keep writing 100 to create our own "god mode"

                if (infammo_checkbox.Checked) //since backgroundworker stays running, this will lock our ammo/magazine values
                {
                    MemLib.writeMemory("iw5sp.exe+F820A0", "int", "999");
                    MemLib.writeMemory("iw5sp.exe+F82118", "int", "999");
                    MemLib.writeMemory("iw5sp.exe+F820B8", "int", "999");
                    MemLib.writeMemory("iw5sp.exe+F8213C", "int", "999");
                    MemLib.writeMemory("iw5sp.exe+F82124", "int", "4");
                    MemLib.writeMemory("iw5sp.exe+F82130", "int", "4");
                }
            }
        }

        private void godmode_checkbox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void noClip(bool enabled)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double timeScale = timescale_trackbar.Value * 0.2;
            MemLib.writeMemory("iw5sp.exe+185DBE8", "float", timeScale.ToString());
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timescale_trackbar.Value = 5; //5 * 0.2 = 1.0 (normal speed) See trackBar1_Scroll function for example
            MemLib.writeMemory("iw5sp.exe+185DBE8", "float", "1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timescale_trackbar.Value == 30)
                return;

            timescale_trackbar.Value = timescale_trackbar.Value + 1;
            MemLib.writeMemory("iw5sp.exe+185DBE8", "float", (timescale_trackbar.Value * 0.2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timescale_trackbar.Value == 0)
                return;

            timescale_trackbar.Value = timescale_trackbar.Value - 1;
            MemLib.writeMemory("iw5sp.exe+185DBE8", "float", (timescale_trackbar.Value * 0.2).ToString());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("http://newagesoldier.com");
        }
    }
}
