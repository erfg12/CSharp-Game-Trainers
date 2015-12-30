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
        int gameProcId;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void openGame()
        {
            if (gameProcId > 0)
                return;

            gameProcId = MemLib.getProcIDFromName("ff7_en"); //use task manager to find game name. For CoD MW2 it is iw4sp. Do not add .exe extension
            if (gameProcId > 0)
            {
                ProcessID.Text = "Proc: " + gameProcId.ToString();
                MemLib.OpenGameProcess(gameProcId);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (gameProcId > 0)
                {
                    try {
                        if (char1_infHP.Checked)
                            MemLib.writeMemory("char1_HP", codeFile, "int", "9999");
                        if (char1_infMP.Checked)
                            MemLib.writeMemory("char1_MP", codeFile, "int", "99");
                        if (char1_maxLimit.Checked)
                            MemLib.writeMemory("char1_limit", codeFile, "byte", "255");
                        if (char1_maxTime.Checked)
                            MemLib.writeMemory("char1_time", codeFile, "byte", "255");

                        if (char2_infHP.Checked)
                            MemLib.writeMemory("char2_HP", codeFile, "int", "9999");
                        if (char2_infMP.Checked)
                            MemLib.writeMemory("char2_MP", codeFile, "int", "99");
                        if (char2_maxLimit.Checked)
                            MemLib.writeMemory("char2_limit", codeFile, "byte", "255");
                        if (char2_maxTime.Checked)
                            MemLib.writeMemory("char2_time", codeFile, "byte", "255");

                        if (char3_infHP.Checked)
                            MemLib.writeMemory("char3_HP", codeFile, "int", "9999");
                        if (char3_infMP.Checked)
                            MemLib.writeMemory("char3_MP", codeFile, "int", "99");
                        if (char3_maxLimit.Checked)
                            MemLib.writeMemory("char3_limit", codeFile, "byte", "255");
                        if (char3_maxTime.Checked)
                            MemLib.writeMemory("char3_time", codeFile, "byte", "255");

                        if (maxGil.Checked)
                            MemLib.writeMemory("gil", codeFile, "int", "99999");

                        if (maxHP.Checked)
                        {
                            MemLib.writeMemory("char1_maxHP", codeFile, "int", "9999");
                            MemLib.writeMemory("char2_maxHP", codeFile, "int", "9999");
                            MemLib.writeMemory("char3_maxHP", codeFile, "int", "9999");
                        }

                        if (maxQty.Checked)
                        {
                            for (int i = 0; i < 40; i++)
                            {
                                int sNum = i * 6;
                                MemLib.writeMove("item_slot1_qty", codeFile, sNum, "byte", "99"); //requires v1.0.3
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
    }
}
