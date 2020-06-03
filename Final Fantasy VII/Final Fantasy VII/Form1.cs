using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Final_Fantasy_VII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string codeFile = Application.StartupPath + @"\codes.ini";
        public Mem MemLib = new Mem();
        bool gameProc = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void openGame()
        {
            gameProc = MemLib.OpenProcess("ff7_en"); //use task manager to find game name. For CoD MW2 it is iw4sp. Do not add .exe extension
            if (gameProc)
            {
                ProcessID.Text = "Process: " + gameProc.ToString();
                MemLib.OpenProcess("ff7_en");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (gameProc)
                {
                    try {
                        if (char1_infHP.Checked)
                            MemLib.WriteMemory("char1_HP", "int", "9999", codeFile);
                        if (char1_infMP.Checked)
                            MemLib.WriteMemory("char1_MP", "int", "99", codeFile);
                        if (char1_maxLimit.Checked)
                            MemLib.WriteMemory("char1_limit", "byte", "255", codeFile);
                        if (char1_maxTime.Checked)
                            MemLib.WriteMemory("char1_time", "byte", "255", codeFile);

                        if (char2_infHP.Checked)
                            MemLib.WriteMemory("char2_HP", "int", "9999", codeFile);
                        if (char2_infMP.Checked)
                            MemLib.WriteMemory("char2_MP", "int", "99", codeFile);
                        if (char2_maxLimit.Checked)
                            MemLib.WriteMemory("char2_limit", "byte", "255", codeFile);
                        if (char2_maxTime.Checked)
                            MemLib.WriteMemory("char2_time", "byte", "255", codeFile);

                        if (char3_infHP.Checked)
                            MemLib.WriteMemory("char3_HP", "int", "9999", codeFile);
                        if (char3_infMP.Checked)
                            MemLib.WriteMemory("char3_MP", "int", "99", codeFile);
                        if (char3_maxLimit.Checked)
                            MemLib.WriteMemory("char3_limit", "byte", "255", codeFile);
                        if (char3_maxTime.Checked)
                            MemLib.WriteMemory("char3_time", "byte", "255", codeFile);

                        if (maxGil.Checked)
                            MemLib.WriteMemory("gil", "int", "99999", codeFile);

                        if (maxHP.Checked)
                        {
                            MemLib.WriteMemory("char1_maxHP", "int", "9999", codeFile);
                            MemLib.WriteMemory("char2_maxHP", "int", "9999", codeFile);
                            MemLib.WriteMemory("char3_maxHP", "int", "9999", codeFile);
                        }

                        if (maxQty.Checked)
                        {
                            for (int i = 0; i < 40; i++)
                            {
                                int sNum = i * 6;
                                MemLib.WriteMove("item_slot1_qty", "byte", "99", sNum, codeFile); //requires v1.0.3 (newer)
                            }
                        }
                    } catch
                    {
                        MessageBox.Show("crashed");
                    }
                } else
                    openGame();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://newagesoldier.com");
        }
    }
}
