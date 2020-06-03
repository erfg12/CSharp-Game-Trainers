using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace SuperTuxTrainer
{
    public partial class MainForm : Form
    {
        public Mem m = new Mem();
        public bool ProcOpen = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // constantly check if the process is available and open
            ProcOpen = m.OpenProcess("supertux2");

            Thread.Sleep(100);
            BGWorker.ReportProgress(0); // do UI thread stuff
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.ForeColor = Color.Green;
                ProcOpenLabel.Text = "Game Found";
            }
            else
            {
                ProcOpenLabel.ForeColor = Color.Red;
                ProcOpenLabel.Text = "N/A";
                return; // do not continue if process is not available/open
            }

            if (LevelTimerFreeze.Checked)
            {
                m.WriteMemory("base+00213150,ac", "int", "0");
            }

            if (TuxAlwaysFire.Checked)
            {
                m.WriteMemory("base+00213150,a8,18,4", "int", "2");
                m.WriteMemory("base+00213150,a8,18,8", "int", "99");
            }

            if (InfiniteJumpBox.Checked)
            {
                m.WriteMemory("base+91F76", "byte", "1");
            } 
            else
            {
                m.WriteMemory("base+91F76", "byte", "0");
            }

            if (GodModeBox.Checked)
            {
                m.WriteMemory("supertux2.exe+91027", "bytes", "90 90 90");
                m.WriteMemory("supertux2.exe+8FFD2", "bytes", "90 90 90 90 90 90 90 90 90 90 90 90 90 90 90");

            } 
            else
            {
                m.WriteMemory("supertux2.exe+91027", "bytes", "89 70 04");
                m.WriteMemory("supertux2.exe+8FFD2", "bytes", "83 78 04 00 0F 84 23 01 00 00 A1 00 B4 B0 00");
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void SendCoinValue_Click(object sender, EventArgs e)
        {
            if (AllCoinsTextBox.Text != "" && ProcOpen) // check if process is avialable/open and if textbox has text in it
                m.WriteMemory("base+00213150,a8,18,0", "int", AllCoinsTextBox.Text);
        }

        private void AllCoinsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // only allow digits
                e.Handled = true;
        }
    }
}
