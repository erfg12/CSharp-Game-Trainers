
namespace AssaultCubeTrainer
{
    partial class AssaultCubeTrainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.LocalPlayerLocationLabel = new System.Windows.Forms.Label();
            this.XPosLabel = new System.Windows.Forms.Label();
            this.YPosLabel = new System.Windows.Forms.Label();
            this.ZPosLabel = new System.Windows.Forms.Label();
            this.ProcessIDLabel = new System.Windows.Forms.Label();
            this.ProcIDIntLabel = new System.Windows.Forms.Label();
            this.HealthOptionsLabel = new System.Windows.Forms.Label();
            this.FreezeHealth = new System.Windows.Forms.CheckBox();
            this.HealthValueTextBox = new System.Windows.Forms.TextBox();
            this.ApplyhealthButton = new System.Windows.Forms.Button();
            this.RevertHealthButton = new System.Windows.Forms.Button();
            this.AssaultRifleLabel = new System.Windows.Forms.Label();
            this.PrimaryAmmoLabel = new System.Windows.Forms.Label();
            this.PrimaryARifleAmmoTextbox = new System.Windows.Forms.TextBox();
            this.ApplyPrimaryARifleAmmo = new System.Windows.Forms.Button();
            this.FreezePrimaryARifleAmmo = new System.Windows.Forms.CheckBox();
            this.SecondaryAmmoLabel = new System.Windows.Forms.Label();
            this.SecondaryARifleAmmoTextbox = new System.Windows.Forms.TextBox();
            this.ApplySecondaryARifleAmmo = new System.Windows.Forms.Button();
            this.FreezeSecondaryARifleAmmo = new System.Windows.Forms.CheckBox();
            this.RevertARifleAmmoButton = new System.Windows.Forms.Button();
            this.PistolAmmoLabel = new System.Windows.Forms.Label();
            this.FreezePistolPrimaryAmmo = new System.Windows.Forms.CheckBox();
            this.UnlimitedSecondaryPistolAmmo = new System.Windows.Forms.CheckBox();
            this.HealthValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KevlarArmorValueTrackbar = new System.Windows.Forms.TrackBar();
            this.KevlarArmorSliderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KevlarArmorValueTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(23, 9);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(51, 13);
            this.ProcessLabel.TabIndex = 0;
            this.ProcessLabel.Text = "Process: ";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProcOpenLabel.Location = new System.Drawing.Point(71, 9);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // LocalPlayerLocationLabel
            // 
            this.LocalPlayerLocationLabel.AutoSize = true;
            this.LocalPlayerLocationLabel.Location = new System.Drawing.Point(237, 9);
            this.LocalPlayerLocationLabel.Name = "LocalPlayerLocationLabel";
            this.LocalPlayerLocationLabel.Size = new System.Drawing.Size(112, 13);
            this.LocalPlayerLocationLabel.TabIndex = 2;
            this.LocalPlayerLocationLabel.Text = "Local Player Location:";
            // 
            // XPosLabel
            // 
            this.XPosLabel.AutoSize = true;
            this.XPosLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XPosLabel.Location = new System.Drawing.Point(352, 9);
            this.XPosLabel.Name = "XPosLabel";
            this.XPosLabel.Size = new System.Drawing.Size(51, 13);
            this.XPosLabel.TabIndex = 3;
            this.XPosLabel.Text = "X: NONE";
            // 
            // YPosLabel
            // 
            this.YPosLabel.AutoSize = true;
            this.YPosLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YPosLabel.Location = new System.Drawing.Point(409, 9);
            this.YPosLabel.Name = "YPosLabel";
            this.YPosLabel.Size = new System.Drawing.Size(51, 13);
            this.YPosLabel.TabIndex = 4;
            this.YPosLabel.Text = "Y: NONE";
            // 
            // ZPosLabel
            // 
            this.ZPosLabel.AutoSize = true;
            this.ZPosLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZPosLabel.Location = new System.Drawing.Point(466, 9);
            this.ZPosLabel.Name = "ZPosLabel";
            this.ZPosLabel.Size = new System.Drawing.Size(51, 13);
            this.ZPosLabel.TabIndex = 5;
            this.ZPosLabel.Text = "Z: NONE";
            // 
            // ProcessIDLabel
            // 
            this.ProcessIDLabel.AutoSize = true;
            this.ProcessIDLabel.Location = new System.Drawing.Point(12, 22);
            this.ProcessIDLabel.Name = "ProcessIDLabel";
            this.ProcessIDLabel.Size = new System.Drawing.Size(62, 13);
            this.ProcessIDLabel.TabIndex = 6;
            this.ProcessIDLabel.Text = "ProcessID: ";
            // 
            // ProcIDIntLabel
            // 
            this.ProcIDIntLabel.AutoSize = true;
            this.ProcIDIntLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProcIDIntLabel.Location = new System.Drawing.Point(71, 22);
            this.ProcIDIntLabel.Name = "ProcIDIntLabel";
            this.ProcIDIntLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcIDIntLabel.TabIndex = 7;
            this.ProcIDIntLabel.Text = "N/A";
            // 
            // HealthOptionsLabel
            // 
            this.HealthOptionsLabel.AutoSize = true;
            this.HealthOptionsLabel.Location = new System.Drawing.Point(33, 49);
            this.HealthOptionsLabel.Name = "HealthOptionsLabel";
            this.HealthOptionsLabel.Size = new System.Drawing.Size(80, 13);
            this.HealthOptionsLabel.TabIndex = 8;
            this.HealthOptionsLabel.Text = "Health Options:";
            // 
            // FreezeHealth
            // 
            this.FreezeHealth.AutoSize = true;
            this.FreezeHealth.Location = new System.Drawing.Point(119, 77);
            this.FreezeHealth.Name = "FreezeHealth";
            this.FreezeHealth.Size = new System.Drawing.Size(122, 17);
            this.FreezeHealth.TabIndex = 9;
            this.FreezeHealth.Text = "Freeze Health Value";
            this.FreezeHealth.UseVisualStyleBackColor = true;
            // 
            // HealthValueTextBox
            // 
            this.HealthValueTextBox.Location = new System.Drawing.Point(119, 49);
            this.HealthValueTextBox.Name = "HealthValueTextBox";
            this.HealthValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.HealthValueTextBox.TabIndex = 10;
            // 
            // ApplyhealthButton
            // 
            this.ApplyhealthButton.Location = new System.Drawing.Point(225, 46);
            this.ApplyhealthButton.Name = "ApplyhealthButton";
            this.ApplyhealthButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyhealthButton.TabIndex = 11;
            this.ApplyhealthButton.Text = "Apply";
            this.ApplyhealthButton.UseVisualStyleBackColor = true;
            this.ApplyhealthButton.Click += new System.EventHandler(this.ApplyhealthButton_Click);
            // 
            // RevertHealthButton
            // 
            this.RevertHealthButton.Location = new System.Drawing.Point(249, 73);
            this.RevertHealthButton.Name = "RevertHealthButton";
            this.RevertHealthButton.Size = new System.Drawing.Size(51, 23);
            this.RevertHealthButton.TabIndex = 12;
            this.RevertHealthButton.Text = "Revert";
            this.RevertHealthButton.UseVisualStyleBackColor = true;
            this.RevertHealthButton.Click += new System.EventHandler(this.RevertHealthButton_Click);
            // 
            // AssaultRifleLabel
            // 
            this.AssaultRifleLabel.AutoSize = true;
            this.AssaultRifleLabel.Location = new System.Drawing.Point(12, 133);
            this.AssaultRifleLabel.Name = "AssaultRifleLabel";
            this.AssaultRifleLabel.Size = new System.Drawing.Size(101, 13);
            this.AssaultRifleLabel.TabIndex = 13;
            this.AssaultRifleLabel.Text = "Assault RIfle Ammo:";
            // 
            // PrimaryAmmoLabel
            // 
            this.PrimaryAmmoLabel.AutoSize = true;
            this.PrimaryAmmoLabel.Location = new System.Drawing.Point(134, 117);
            this.PrimaryAmmoLabel.Name = "PrimaryAmmoLabel";
            this.PrimaryAmmoLabel.Size = new System.Drawing.Size(73, 13);
            this.PrimaryAmmoLabel.TabIndex = 14;
            this.PrimaryAmmoLabel.Text = "Primary Ammo";
            // 
            // PrimaryARifleAmmoTextbox
            // 
            this.PrimaryARifleAmmoTextbox.Location = new System.Drawing.Point(119, 133);
            this.PrimaryARifleAmmoTextbox.Name = "PrimaryARifleAmmoTextbox";
            this.PrimaryARifleAmmoTextbox.Size = new System.Drawing.Size(100, 20);
            this.PrimaryARifleAmmoTextbox.TabIndex = 15;
            // 
            // ApplyPrimaryARifleAmmo
            // 
            this.ApplyPrimaryARifleAmmo.Location = new System.Drawing.Point(225, 130);
            this.ApplyPrimaryARifleAmmo.Name = "ApplyPrimaryARifleAmmo";
            this.ApplyPrimaryARifleAmmo.Size = new System.Drawing.Size(75, 23);
            this.ApplyPrimaryARifleAmmo.TabIndex = 16;
            this.ApplyPrimaryARifleAmmo.Text = "Apply";
            this.ApplyPrimaryARifleAmmo.UseVisualStyleBackColor = true;
            this.ApplyPrimaryARifleAmmo.Click += new System.EventHandler(this.ApplyPrimaryARifleAmmo_Click);
            // 
            // FreezePrimaryARifleAmmo
            // 
            this.FreezePrimaryARifleAmmo.AutoSize = true;
            this.FreezePrimaryARifleAmmo.Location = new System.Drawing.Point(119, 159);
            this.FreezePrimaryARifleAmmo.Name = "FreezePrimaryARifleAmmo";
            this.FreezePrimaryARifleAmmo.Size = new System.Drawing.Size(157, 17);
            this.FreezePrimaryARifleAmmo.TabIndex = 17;
            this.FreezePrimaryARifleAmmo.Text = "Freeze Primary Ammo Value";
            this.FreezePrimaryARifleAmmo.UseVisualStyleBackColor = true;
            // 
            // SecondaryAmmoLabel
            // 
            this.SecondaryAmmoLabel.AutoSize = true;
            this.SecondaryAmmoLabel.Location = new System.Drawing.Point(348, 117);
            this.SecondaryAmmoLabel.Name = "SecondaryAmmoLabel";
            this.SecondaryAmmoLabel.Size = new System.Drawing.Size(90, 13);
            this.SecondaryAmmoLabel.TabIndex = 18;
            this.SecondaryAmmoLabel.Text = "Secondary Ammo";
            // 
            // SecondaryARifleAmmoTextbox
            // 
            this.SecondaryARifleAmmoTextbox.Location = new System.Drawing.Point(343, 133);
            this.SecondaryARifleAmmoTextbox.Name = "SecondaryARifleAmmoTextbox";
            this.SecondaryARifleAmmoTextbox.Size = new System.Drawing.Size(100, 20);
            this.SecondaryARifleAmmoTextbox.TabIndex = 19;
            // 
            // ApplySecondaryARifleAmmo
            // 
            this.ApplySecondaryARifleAmmo.Location = new System.Drawing.Point(449, 130);
            this.ApplySecondaryARifleAmmo.Name = "ApplySecondaryARifleAmmo";
            this.ApplySecondaryARifleAmmo.Size = new System.Drawing.Size(75, 23);
            this.ApplySecondaryARifleAmmo.TabIndex = 20;
            this.ApplySecondaryARifleAmmo.Text = "Apply";
            this.ApplySecondaryARifleAmmo.UseVisualStyleBackColor = true;
            this.ApplySecondaryARifleAmmo.Click += new System.EventHandler(this.ApplySecondaryARifleAmmo_Click);
            // 
            // FreezeSecondaryARifleAmmo
            // 
            this.FreezeSecondaryARifleAmmo.AutoSize = true;
            this.FreezeSecondaryARifleAmmo.Location = new System.Drawing.Point(343, 160);
            this.FreezeSecondaryARifleAmmo.Name = "FreezeSecondaryARifleAmmo";
            this.FreezeSecondaryARifleAmmo.Size = new System.Drawing.Size(174, 17);
            this.FreezeSecondaryARifleAmmo.TabIndex = 21;
            this.FreezeSecondaryARifleAmmo.Text = "Freeze Secondary Ammo Value";
            this.FreezeSecondaryARifleAmmo.UseVisualStyleBackColor = true;
            // 
            // RevertARifleAmmoButton
            // 
            this.RevertARifleAmmoButton.Location = new System.Drawing.Point(119, 182);
            this.RevertARifleAmmoButton.Name = "RevertARifleAmmoButton";
            this.RevertARifleAmmoButton.Size = new System.Drawing.Size(405, 23);
            this.RevertARifleAmmoButton.TabIndex = 22;
            this.RevertARifleAmmoButton.Text = "Revert Assault Rifle Ammo to default";
            this.RevertARifleAmmoButton.UseVisualStyleBackColor = true;
            this.RevertARifleAmmoButton.Click += new System.EventHandler(this.RevertARifleAmmoButton_Click);
            // 
            // PistolAmmoLabel
            // 
            this.PistolAmmoLabel.AutoSize = true;
            this.PistolAmmoLabel.Location = new System.Drawing.Point(46, 224);
            this.PistolAmmoLabel.Name = "PistolAmmoLabel";
            this.PistolAmmoLabel.Size = new System.Drawing.Size(67, 13);
            this.PistolAmmoLabel.TabIndex = 23;
            this.PistolAmmoLabel.Text = "Pistol Ammo:";
            // 
            // FreezePistolPrimaryAmmo
            // 
            this.FreezePistolPrimaryAmmo.AutoSize = true;
            this.FreezePistolPrimaryAmmo.Location = new System.Drawing.Point(119, 224);
            this.FreezePistolPrimaryAmmo.Name = "FreezePistolPrimaryAmmo";
            this.FreezePistolPrimaryAmmo.Size = new System.Drawing.Size(127, 17);
            this.FreezePistolPrimaryAmmo.TabIndex = 24;
            this.FreezePistolPrimaryAmmo.Text = "Freeze Primary Ammo";
            this.FreezePistolPrimaryAmmo.UseVisualStyleBackColor = true;
            // 
            // UnlimitedSecondaryPistolAmmo
            // 
            this.UnlimitedSecondaryPistolAmmo.AutoSize = true;
            this.UnlimitedSecondaryPistolAmmo.Location = new System.Drawing.Point(252, 224);
            this.UnlimitedSecondaryPistolAmmo.Name = "UnlimitedSecondaryPistolAmmo";
            this.UnlimitedSecondaryPistolAmmo.Size = new System.Drawing.Size(155, 17);
            this.UnlimitedSecondaryPistolAmmo.TabIndex = 25;
            this.UnlimitedSecondaryPistolAmmo.Text = "Unlimited Secondary Ammo";
            this.UnlimitedSecondaryPistolAmmo.UseVisualStyleBackColor = true;
            this.UnlimitedSecondaryPistolAmmo.CheckedChanged += new System.EventHandler(this.UnlimitedSecondaryPistolAmmo_CheckedChanged);
            // 
            // HealthValueLabel
            // 
            this.HealthValueLabel.AutoSize = true;
            this.HealthValueLabel.Location = new System.Drawing.Point(134, 33);
            this.HealthValueLabel.Name = "HealthValueLabel";
            this.HealthValueLabel.Size = new System.Drawing.Size(68, 13);
            this.HealthValueLabel.TabIndex = 26;
            this.HealthValueLabel.Text = "Health Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kevlar Armor Options:";
            // 
            // KevlarArmorValueTrackbar
            // 
            this.KevlarArmorValueTrackbar.Location = new System.Drawing.Point(115, 294);
            this.KevlarArmorValueTrackbar.Maximum = 999;
            this.KevlarArmorValueTrackbar.Name = "KevlarArmorValueTrackbar";
            this.KevlarArmorValueTrackbar.Size = new System.Drawing.Size(409, 45);
            this.KevlarArmorValueTrackbar.TabIndex = 0;
            // 
            // KevlarArmorSliderLabel
            // 
            this.KevlarArmorSliderLabel.AutoSize = true;
            this.KevlarArmorSliderLabel.Location = new System.Drawing.Point(253, 278);
            this.KevlarArmorSliderLabel.Name = "KevlarArmorSliderLabel";
            this.KevlarArmorSliderLabel.Size = new System.Drawing.Size(96, 13);
            this.KevlarArmorSliderLabel.TabIndex = 29;
            this.KevlarArmorSliderLabel.Text = "Kevlar Value Slider";
            // 
            // AssaultCubeTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 361);
            this.Controls.Add(this.KevlarArmorSliderLabel);
            this.Controls.Add(this.KevlarArmorValueTrackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HealthValueLabel);
            this.Controls.Add(this.UnlimitedSecondaryPistolAmmo);
            this.Controls.Add(this.FreezePistolPrimaryAmmo);
            this.Controls.Add(this.PistolAmmoLabel);
            this.Controls.Add(this.RevertARifleAmmoButton);
            this.Controls.Add(this.FreezeSecondaryARifleAmmo);
            this.Controls.Add(this.ApplySecondaryARifleAmmo);
            this.Controls.Add(this.SecondaryARifleAmmoTextbox);
            this.Controls.Add(this.SecondaryAmmoLabel);
            this.Controls.Add(this.FreezePrimaryARifleAmmo);
            this.Controls.Add(this.ApplyPrimaryARifleAmmo);
            this.Controls.Add(this.PrimaryARifleAmmoTextbox);
            this.Controls.Add(this.PrimaryAmmoLabel);
            this.Controls.Add(this.AssaultRifleLabel);
            this.Controls.Add(this.RevertHealthButton);
            this.Controls.Add(this.ApplyhealthButton);
            this.Controls.Add(this.HealthValueTextBox);
            this.Controls.Add(this.FreezeHealth);
            this.Controls.Add(this.HealthOptionsLabel);
            this.Controls.Add(this.ProcIDIntLabel);
            this.Controls.Add(this.ProcessIDLabel);
            this.Controls.Add(this.ZPosLabel);
            this.Controls.Add(this.YPosLabel);
            this.Controls.Add(this.XPosLabel);
            this.Controls.Add(this.LocalPlayerLocationLabel);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.ProcessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssaultCubeTrainer";
            this.ShowIcon = false;
            this.Text = "AssaultCube Trainer";
            this.Shown += new System.EventHandler(this.AssaultCubeTrainer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.KevlarArmorValueTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label LocalPlayerLocationLabel;
        private System.Windows.Forms.Label XPosLabel;
        private System.Windows.Forms.Label YPosLabel;
        private System.Windows.Forms.Label ZPosLabel;
        private System.Windows.Forms.Label ProcessIDLabel;
        private System.Windows.Forms.Label ProcIDIntLabel;
        private System.Windows.Forms.Label HealthOptionsLabel;
        private System.Windows.Forms.CheckBox FreezeHealth;
        private System.Windows.Forms.TextBox HealthValueTextBox;
        private System.Windows.Forms.Button ApplyhealthButton;
        private System.Windows.Forms.Button RevertHealthButton;
        private System.Windows.Forms.Label AssaultRifleLabel;
        private System.Windows.Forms.Label PrimaryAmmoLabel;
        private System.Windows.Forms.TextBox PrimaryARifleAmmoTextbox;
        private System.Windows.Forms.Button ApplyPrimaryARifleAmmo;
        private System.Windows.Forms.CheckBox FreezePrimaryARifleAmmo;
        private System.Windows.Forms.Label SecondaryAmmoLabel;
        private System.Windows.Forms.TextBox SecondaryARifleAmmoTextbox;
        private System.Windows.Forms.Button ApplySecondaryARifleAmmo;
        private System.Windows.Forms.CheckBox FreezeSecondaryARifleAmmo;
        private System.Windows.Forms.Button RevertARifleAmmoButton;
        private System.Windows.Forms.Label PistolAmmoLabel;
        private System.Windows.Forms.CheckBox FreezePistolPrimaryAmmo;
        private System.Windows.Forms.CheckBox UnlimitedSecondaryPistolAmmo;
        private System.Windows.Forms.Label HealthValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar KevlarArmorValueTrackbar;
        private System.Windows.Forms.Label KevlarArmorSliderLabel;
    }
}

