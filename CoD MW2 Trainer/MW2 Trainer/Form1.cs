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

        public string gameProcId;
        public bool loaded;

        private void openGame()
        {
            if (loaded)
                return;

            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName == "iw4sp") //find iw4sp.exe in the process list (use task manager to find the name)
                {
                    gameProcId = theprocess.Id.ToString();
                    loaded = true;
                    break; //just grab the first process, ignore the others.
                }
            }
            if (!String.IsNullOrEmpty(gameProcId))
            {
                ProcessID.Text = gameProcId;
                MemLib.OpenGameProcess(gameProcId);

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
                        MemLib.writeMemory("noClip", codeFile, "int", "0");
                    else
                        MemLib.writeMemory("noClip", codeFile, "int", "1");
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

                if (infammo_checkbox.Checked) //since backgroundworker stays running, this will lock our ammo/magazine values
                {
                    MemLib.writeMemory("grenades", codeFile, "int", "4");
                    MemLib.writeMemory("flashGrenades", codeFile, "int", "4");
                    MemLib.writeMemory("grenadeLauncher", codeFile, "int", "4");

                    //sometimes the game switches these around, so I want to set them all to 50 for now
                    MemLib.writeMemory("RPG", codeFile, "int", "50"); //supposed to be 2, but sometimes it can be primary ammo?
                    MemLib.writeMemory("primaryAmmo", codeFile, "int", "50");
                    MemLib.writeMemory("primaryWieldedMagazine", codeFile, "int", "50");
                    MemLib.writeMemory("primaryMagazine", codeFile, "int", "50");
                    MemLib.writeMemory("secondaryAmmo", codeFile, "int", "50");
                    MemLib.writeMemory("secondaryMagazine", codeFile, "int", "50");
                }
            }
        }

        private void godmode_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (godmode_checkbox.Checked)
                MemLib.writeMemory("godMode", codeFile, "int", "1");
            else
                MemLib.writeMemory("godMode", codeFile, "int", "0");
        }

        private void noClip(bool enabled)
        {
            if (enabled)
                MemLib.writeMemory("noClip", codeFile, "int", "1");
            else
                MemLib.writeMemory("noClip", codeFile, "int", "0");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double timeScale = timescale_trackbar.Value * 0.2;
            MemLib.writeMemory("timescale", codeFile, "float", timeScale.ToString());
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timescale_trackbar.Value = 5; //5 * 0.2 = 1.0 (normal speed) See trackBar1_Scroll function for example
            MemLib.writeMemory("timescale", codeFile, "float", "1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timescale_trackbar.Value = timescale_trackbar.Value + 1;
            MemLib.writeMemory("timescale", codeFile, "float", (timescale_trackbar.Value * 0.2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timescale_trackbar.Value = timescale_trackbar.Value - 1;
            MemLib.writeMemory("timescale", codeFile, "float", (timescale_trackbar.Value * 0.2).ToString());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("http://newagesoldier.com");
        }
    }
}
