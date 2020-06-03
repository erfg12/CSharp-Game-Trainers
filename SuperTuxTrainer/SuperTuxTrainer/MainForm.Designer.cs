namespace SuperTuxTrainer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.AllCoinsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendCoinValue = new System.Windows.Forms.Button();
            this.TuxAlwaysFire = new System.Windows.Forms.CheckBox();
            this.LevelTimerFreeze = new System.Windows.Forms.CheckBox();
            this.InfiniteJumpBox = new System.Windows.Forms.CheckBox();
            this.GodModeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(59, 10);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(27, 13);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // AllCoinsTextBox
            // 
            this.AllCoinsTextBox.Location = new System.Drawing.Point(62, 43);
            this.AllCoinsTextBox.MaxLength = 4;
            this.AllCoinsTextBox.Name = "AllCoinsTextBox";
            this.AllCoinsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AllCoinsTextBox.TabIndex = 2;
            this.AllCoinsTextBox.Text = "9999";
            this.AllCoinsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllCoinsTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coins:";
            // 
            // SendCoinValue
            // 
            this.SendCoinValue.Location = new System.Drawing.Point(167, 41);
            this.SendCoinValue.Name = "SendCoinValue";
            this.SendCoinValue.Size = new System.Drawing.Size(45, 23);
            this.SendCoinValue.TabIndex = 4;
            this.SendCoinValue.Text = "SEND";
            this.SendCoinValue.UseVisualStyleBackColor = true;
            this.SendCoinValue.Click += new System.EventHandler(this.SendCoinValue_Click);
            // 
            // TuxAlwaysFire
            // 
            this.TuxAlwaysFire.AutoSize = true;
            this.TuxAlwaysFire.Checked = true;
            this.TuxAlwaysFire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TuxAlwaysFire.Location = new System.Drawing.Point(26, 70);
            this.TuxAlwaysFire.Name = "TuxAlwaysFire";
            this.TuxAlwaysFire.Size = new System.Drawing.Size(151, 17);
            this.TuxAlwaysFire.TabIndex = 5;
            this.TuxAlwaysFire.Text = "Tux Always Has Firepower";
            this.TuxAlwaysFire.UseVisualStyleBackColor = true;
            // 
            // LevelTimerFreeze
            // 
            this.LevelTimerFreeze.AutoSize = true;
            this.LevelTimerFreeze.Checked = true;
            this.LevelTimerFreeze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LevelTimerFreeze.Location = new System.Drawing.Point(26, 93);
            this.LevelTimerFreeze.Name = "LevelTimerFreeze";
            this.LevelTimerFreeze.Size = new System.Drawing.Size(159, 17);
            this.LevelTimerFreeze.TabIndex = 6;
            this.LevelTimerFreeze.Text = "Level Time Never Increases";
            this.LevelTimerFreeze.UseVisualStyleBackColor = true;
            // 
            // InfiniteJumpBox
            // 
            this.InfiniteJumpBox.AutoSize = true;
            this.InfiniteJumpBox.Checked = true;
            this.InfiniteJumpBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InfiniteJumpBox.Location = new System.Drawing.Point(26, 117);
            this.InfiniteJumpBox.Name = "InfiniteJumpBox";
            this.InfiniteJumpBox.Size = new System.Drawing.Size(85, 17);
            this.InfiniteJumpBox.TabIndex = 7;
            this.InfiniteJumpBox.Text = "Infinite Jump";
            this.InfiniteJumpBox.UseVisualStyleBackColor = true;
            // 
            // GodModeBox
            // 
            this.GodModeBox.AutoSize = true;
            this.GodModeBox.Checked = true;
            this.GodModeBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GodModeBox.Location = new System.Drawing.Point(26, 141);
            this.GodModeBox.Name = "GodModeBox";
            this.GodModeBox.Size = new System.Drawing.Size(76, 17);
            this.GodModeBox.TabIndex = 8;
            this.GodModeBox.Text = "God Mode";
            this.GodModeBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 172);
            this.Controls.Add(this.GodModeBox);
            this.Controls.Add(this.InfiniteJumpBox);
            this.Controls.Add(this.LevelTimerFreeze);
            this.Controls.Add(this.TuxAlwaysFire);
            this.Controls.Add(this.SendCoinValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllCoinsTextBox);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "SuperTux Trainer v0.6.2 x86";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.TextBox AllCoinsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendCoinValue;
        private System.Windows.Forms.CheckBox TuxAlwaysFire;
        private System.Windows.Forms.CheckBox LevelTimerFreeze;
        private System.Windows.Forms.CheckBox InfiniteJumpBox;
        private System.Windows.Forms.CheckBox GodModeBox;
    }
}

