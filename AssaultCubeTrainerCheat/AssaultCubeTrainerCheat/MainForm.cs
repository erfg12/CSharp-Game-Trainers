using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AssaultCubeTrainerCheat
{
    public partial class AssaultCubeTrainer : Form
    {
        private readonly Mem mem = new();
        private bool IsProcOpen;
        private int ProcessID;

        public AssaultCubeTrainer()
        {
            InitializeComponent();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessID = mem.GetProcIdFromName("ac_client");
            if (ProcessID != 0)
            {
                IsProcOpen = mem.OpenProcess(ProcessID);
                Thread.Sleep(100);
                BGWorker.ReportProgress(0);
            }
            else
            {
                ProcOpenLabel.Invoke(new MethodInvoker(delegate
                {
                    ProcOpenLabel.Text = "NONE";
                    ProcOpenLabel.ForeColor = Color.Red;
                }));
                ProcIDIntLabel.Invoke(new MethodInvoker(delegate
                {
                    ProcIDIntLabel.Text = "NONE";
                    ProcIDIntLabel.ForeColor = Color.Red;
                }));
            }
        }

        private void AssaultCubeTrainer_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (IsProcOpen)
            {
                ProcOpenLabel.Text = "AssaultCube";
                ProcOpenLabel.ForeColor = Color.Green;
                ProcIDIntLabel.Text = ProcessID.ToString();
                ProcIDIntLabel.ForeColor = Color.Green;
                ReadLocalPlayerPos(XPosLabel, YPosLabel, ZPosLabel);
                FreezeLocalPlayerHealth(FreezeHealth);
                FreezeAssaultRifleAmmo(FreezePrimaryARifleAmmo, FreezeSecondaryARifleAmmo);
                ChangePistolAmmo(FreezePistolPrimaryAmmo, UnlimitedSecondaryPistolAmmo);
                SetKevlarArmorValue(KevlarArmorValueTrackbar);
            }
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void ReadLocalPlayerPos(Label xPos, Label yPos, Label zPos)
        {
            // please tell me there's a better way than this
            xPos.Invoke((MethodInvoker)delegate
            {
                xPos.Text = $"X: {mem.ReadFloat(PointersAddr.LocalPlayerXPosAddr)}";
            });
            yPos.Invoke((MethodInvoker)delegate
            {
                yPos.Text = $"Y: {mem.ReadFloat(PointersAddr.LocalPlayerYPosAddr)}";
            });
            zPos.Invoke((MethodInvoker)delegate
            {
                zPos.Text = $"Z: {mem.ReadFloat(PointersAddr.LocalPlayerZPosAddr)}";
            });
        }

        private void FreezeLocalPlayerHealth(CheckBox freezeHealth)
        {
            bool canFreezeCustomHealth = freezeHealth.Checked && !string.IsNullOrEmpty(HealthValueTextBox.Text) && IsTextNumeric(HealthValueTextBox.Text);
            if (canFreezeCustomHealth)
                mem.FreezeValue(PointersAddr.HealthAddr, "int", HealthValueTextBox.Text);
            else if (freezeHealth.Checked)
                mem.FreezeValue(PointersAddr.HealthAddr, "int", "100");
            else
                mem.UnfreezeValue(PointersAddr.HealthAddr);
        }

        private void FreezeAssaultRifleAmmo(CheckBox freezePrimary, CheckBox freezeSecondary)
        {
            bool canFreezeCustomPrimary = freezePrimary.Checked && !string.IsNullOrEmpty(PrimaryARifleAmmoTextbox.Text) && IsTextNumeric(PrimaryARifleAmmoTextbox.Text);
            bool canFreezeCustomSecondary = freezeSecondary.Checked && !string.IsNullOrEmpty(SecondaryARifleAmmoTextbox.Text) && IsTextNumeric(SecondaryARifleAmmoTextbox.Text);
            if (canFreezeCustomPrimary)
                mem.FreezeValue(PointersAddr.ARiflePrimaryAmmoAddr, "int", PrimaryARifleAmmoTextbox.Text);
            else if (freezePrimary.Checked)
                mem.FreezeValue(PointersAddr.ARiflePrimaryAmmoAddr, "int", "20");
            else
                mem.UnfreezeValue(PointersAddr.ARiflePrimaryAmmoAddr);

            if (canFreezeCustomSecondary)
                mem.FreezeValue(PointersAddr.ARifleSecondaryAmmoAddr, "int", SecondaryARifleAmmoTextbox.Text);
            else if (freezeSecondary.Checked)
                mem.FreezeValue(PointersAddr.ARifleSecondaryAmmoAddr, "int", "40");
            else
                mem.UnfreezeValue(PointersAddr.ARifleSecondaryAmmoAddr);
        }

        private void ChangePistolAmmo(CheckBox freezePrimary, CheckBox unlimitedSecondary)
        {
            if (freezePrimary.Checked)
                mem.FreezeValue(PointersAddr.PistolPrimaryAmmoAdr, "int", "10");
            else
                mem.UnfreezeValue(PointersAddr.PistolPrimaryAmmoAdr);
            if (unlimitedSecondary.Checked)
                mem.WriteMemory(PointersAddr.PistolSecondaryAmmoAdr, "int", "999");
        }

        private void SetKevlarArmorValue(TrackBar kevlararmorTrackbar)
        {
            if(kevlararmorTrackbar.Value > 0)
                mem.WriteMemory(PointersAddr.KevlarArmorAddr, "int", kevlararmorTrackbar.Value.ToString());
            else if(kevlararmorTrackbar.Value == 0)
                mem.WriteMemory(PointersAddr.KevlarArmorAddr, "int", "0");
        }

        private void ApplyhealthButton_Click(object sender, EventArgs e)
        {
            if (IsTextNumeric(HealthValueTextBox.Text))
                mem.WriteMemory(PointersAddr.HealthAddr, "int", HealthValueTextBox.Text);
            else
                MessageBox.Show("Please enter a valid integer value.", "Error occured while setting a custom health value");
        }

        private void RevertHealthButton_Click(object sender, EventArgs e)
        {
            FreezeHealth.Checked = false;
            mem.WriteMemory(PointersAddr.HealthAddr, "int", "100");
        }

        private void ApplyPrimaryARifleAmmo_Click(object sender, EventArgs e)
        {
            if (IsTextNumeric(PrimaryARifleAmmoTextbox.Text))
                mem.WriteMemory(PointersAddr.ARiflePrimaryAmmoAddr, "int", PrimaryARifleAmmoTextbox.Text);
            else
                MessageBox.Show("Please enter a valid integer value.", "Error occured while setting a custom ammo value");
        }

        private void ApplySecondaryARifleAmmo_Click(object sender, EventArgs e)
        {
            if (IsTextNumeric(SecondaryARifleAmmoTextbox.Text))
                mem.WriteMemory(PointersAddr.ARifleSecondaryAmmoAddr, "int", SecondaryARifleAmmoTextbox.Text);
            else
                MessageBox.Show("Please enter a valid integer value.", "Error occured while setting a custom ammo value");
        }

        private void RevertARifleAmmoButton_Click(object sender, EventArgs e)
        {
            FreezePrimaryARifleAmmo.Checked = false;
            FreezeSecondaryARifleAmmo.Checked = false;
            mem.WriteMemory(PointersAddr.ARiflePrimaryAmmoAddr, "int", "20");
            mem.WriteMemory(PointersAddr.ARifleSecondaryAmmoAddr, "int", "40");
        }

        private bool IsTextNumeric(string text)
        {
            return int.TryParse(text, out _) && Convert.ToInt32(text) > 0;
        }

        private void UnlimitedSecondaryPistolAmmo_CheckedChanged(object sender, EventArgs e)
        {
            mem.WriteMemory(PointersAddr.PistolSecondaryAmmoAdr, "int", "50");
        }
    }
}
