using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Memory;

namespace South_Park___SoT
{
    public partial class Form1 : Form
    {
        public static IntPtr pHandle;
        private ProcessModule mainModule;
        public static string gameID, exp, LVL;
        public static float combatHP;

        public string codeFile = Application.StartupPath + @"\codes.ini";
        public Mem MemLib = new Mem();

        bool gameProc;

        private void openGame()
        {
            gameProc = MemLib.OpenProcess("South Park - The Stick of Truth");

            if (gameProc)
            {
                procID_label.Text = gameProc.ToString();
                toggleHP.Text = "ON";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (gameProc)
                {
                    MemLib.WriteMemory("combatHP", "int", "99999", codeFile);
                    MemLib.WriteMemory("combatMP", "int", "20", codeFile);
                    MemLib.WriteMemory("buddyCombatHP", "int", "99999", codeFile);
                    MemLib.WriteMemory("buddyCombatMP", "int", "20", codeFile);

                    if (!String.ReferenceEquals(expBox.Text, exp))
                        expBox.Text = exp;

                    if (!String.ReferenceEquals(levelBox.Text, LVL))
                        levelBox.Text = LVL;
                } else
                    openGame();
            }
        }

        private void levelBox_TextChanged(object sender, EventArgs e)
        {
            if (gameProc)
            {
                if (!String.IsNullOrEmpty(levelBox.Text))
                    MemLib.WriteMemory("level", "int", levelBox.Text, codeFile);
            }
        }

        private void expBox_TextChanged(object sender, EventArgs e)
        {
            if (gameProc)
            {
                if (!String.IsNullOrEmpty(expBox.Text))
                    MemLib.WriteMemory("experience", "int", expBox.Text, codeFile);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://newagesoldier.com");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameProc)
            {
                exp = MemLib.ReadString("experience", codeFile);
                LVL = MemLib.ReadString("level", codeFile);
            }
        }
    }
}
