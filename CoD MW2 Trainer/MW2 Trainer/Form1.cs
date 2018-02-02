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

namespace MW2_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public string codeFile = Application.StartupPath + @"\codes.ini";
        public Mem MemLib = new Mem();

        public bool loaded;

        private void openGame()
        {
            if (loaded)
                return;

            //new memory.dll 1.0.2 function
            int gameProcId = MemLib.getProcIDFromName("iw4sp"); //use task manager to find game name. For CoD MW2 it is iw4sp. Do not add .exe extension

            if (gameProcId != 0)
            {
                loaded = true;
                ProcessID.Text = gameProcId.ToString();
                MemLib.OpenProcess(gameProcId.ToString());

                int godMode = MemLib.readInt("godMode", codeFile);

                if (godMode == 1)
                    godmode_checkbox.Checked = true;
                else
                    godmode_checkbox.Checked = false;
            }
        }

        protected override void WndProc(ref Message m) //hotbuttons
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    if (MemLib.readInt("noClip", codeFile) == 1)
                        MemLib.writeMemory("noClip", "int", "0", codeFile);
                    else
                        MemLib.writeMemory("noClip", "int", "1", codeFile);
                }
                else if (id == 2)
                {
                    button1.PerformClick();
                }
                else if (id == 3)
                {
                    button2.PerformClick();
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 1, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.Oemplus);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.Add);
            RegisterHotKey(this.Handle, 3, 0, (int)Keys.OemMinus);
            RegisterHotKey(this.Handle, 3, 0, (int)Keys.Subtract);

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
                //start reading our values
                int noClip = MemLib.readInt("noClip", codeFile);
                if (noClip == 1)
                {
                    noclip_toggle.Invoke(new MethodInvoker(delegate { noclip_toggle.Text = "Enabled"; noclip_toggle.ForeColor = System.Drawing.Color.DarkGreen; }));
                }
                else
                {
                    noclip_toggle.Invoke(new MethodInvoker(delegate { noclip_toggle.Text = "Disabled"; noclip_toggle.ForeColor = System.Drawing.Color.DarkRed; }));
                }

                if (godmode_checkbox.Checked) //make sure we keep this
                    MemLib.writeMemory("godMode", "int", "1", codeFile);

                if (infammo_checkbox.Checked) //since backgroundworker stays running, this will lock our ammo/magazine values
                {
                    MemLib.writeMemory("grenades", "int", "4", codeFile);
                    MemLib.writeMemory("flashGrenades", "int", "4", codeFile);

                    //sometimes the game switches these around, so I want to set them all to 50 for now
                    MemLib.writeMemory("RPG", "int", "50", codeFile);
                    MemLib.writeMemory("grenadeLauncher", "int", "50", codeFile); //can be picked up weapons ammo too sometimes
                    MemLib.writeMemory("primaryAmmo", "int", "50", codeFile);
                    MemLib.writeMemory("primaryWieldedMagazine", "int", "50", codeFile);
                    MemLib.writeMemory("primaryWieldedMagazine2", "int", "50", codeFile);
                    MemLib.writeMemory("secondaryWieldedMagazine", "int", "50", codeFile);
                    MemLib.writeMemory("primaryMagazine", "int", "50", codeFile);
                    MemLib.writeMemory("secondaryAmmo", "int", "50", codeFile);
                    MemLib.writeMemory("secondaryMagazine", "int", "50", codeFile);
                }
            }
        }

        private void godmode_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (godmode_checkbox.Checked)
                MemLib.writeMemory("godMode", "int", "1", codeFile);
            else
                MemLib.writeMemory("godMode", "int", "0", codeFile);
        }

        private void noClip(bool enabled)
        {
            if (enabled)
                MemLib.writeMemory("noClip", "int", "1", codeFile);
            else
                MemLib.writeMemory("noClip", "int", "0", codeFile);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double timeScale = timescale_trackbar.Value * 0.2;
            MemLib.writeMemory("timescale", "float", timeScale.ToString(), codeFile);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timescale_trackbar.Value = 5; //5 * 0.2 = 1.0 (normal speed) See trackBar1_Scroll function for example
            MemLib.writeMemory("timescale", "float", "1", codeFile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timescale_trackbar.Value == 30)
                return;

            timescale_trackbar.Value = timescale_trackbar.Value + 1;
            MemLib.writeMemory("timescale", "float", (timescale_trackbar.Value * 0.2).ToString(), codeFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timescale_trackbar.Value == 0)
                return;

            timescale_trackbar.Value = timescale_trackbar.Value - 1;
            MemLib.writeMemory("timescale", "float", (timescale_trackbar.Value * 0.2).ToString(), codeFile);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("http://newagesoldier.com");
        }
    }
}
