namespace Bards_Tail_Trainer
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.silver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vitality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.luck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dexterity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.charisma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rhythm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addrstones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.TextBox();
            this.readStatsBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.TextBox();
            this.procLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // silver
            // 
            this.silver.Location = new System.Drawing.Point(91, 107);
            this.silver.MaxLength = 9;
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(71, 20);
            this.silver.TabIndex = 0;
            this.silver.TextChanged += new System.EventHandler(this.silver_TextChanged);
            this.silver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.silver_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silver:";
            // 
            // strength
            // 
            this.strength.Location = new System.Drawing.Point(205, 55);
            this.strength.MaxLength = 3;
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(37, 20);
            this.strength.TabIndex = 2;
            this.strength.TextChanged += new System.EventHandler(this.strength_TextChanged);
            this.strength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strength_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Str:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vit:";
            // 
            // vitality
            // 
            this.vitality.Location = new System.Drawing.Point(205, 81);
            this.vitality.MaxLength = 3;
            this.vitality.Name = "vitality";
            this.vitality.Size = new System.Drawing.Size(37, 20);
            this.vitality.TabIndex = 4;
            this.vitality.TextChanged += new System.EventHandler(this.vitality_TextChanged);
            this.vitality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vitality_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Luck:";
            // 
            // luck
            // 
            this.luck.Location = new System.Drawing.Point(205, 107);
            this.luck.MaxLength = 3;
            this.luck.Name = "luck";
            this.luck.Size = new System.Drawing.Size(37, 20);
            this.luck.TabIndex = 6;
            this.luck.TextChanged += new System.EventHandler(this.luck_TextChanged);
            this.luck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.luck_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dex:";
            // 
            // dexterity
            // 
            this.dexterity.Location = new System.Drawing.Point(205, 133);
            this.dexterity.MaxLength = 3;
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(37, 20);
            this.dexterity.TabIndex = 8;
            this.dexterity.TextChanged += new System.EventHandler(this.dexterity_TextChanged);
            this.dexterity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dexterity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Char:";
            // 
            // charisma
            // 
            this.charisma.Location = new System.Drawing.Point(205, 159);
            this.charisma.MaxLength = 3;
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(37, 20);
            this.charisma.TabIndex = 10;
            this.charisma.TextChanged += new System.EventHandler(this.charisma_TextChanged);
            this.charisma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.charisma_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rhy:";
            // 
            // rhythm
            // 
            this.rhythm.Location = new System.Drawing.Point(205, 185);
            this.rhythm.MaxLength = 3;
            this.rhythm.Name = "rhythm";
            this.rhythm.Size = new System.Drawing.Size(37, 20);
            this.rhythm.TabIndex = 12;
            this.rhythm.TextChanged += new System.EventHandler(this.rhythm_TextChanged);
            this.rhythm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rhythm_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Addr:";
            // 
            // addrstones
            // 
            this.addrstones.Location = new System.Drawing.Point(91, 133);
            this.addrstones.MaxLength = 3;
            this.addrstones.Name = "addrstones";
            this.addrstones.Size = new System.Drawing.Size(71, 20);
            this.addrstones.TabIndex = 14;
            this.addrstones.TextChanged += new System.EventHandler(this.addrstones_TextChanged);
            this.addrstones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addrstones_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Exp:";
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(91, 81);
            this.experience.MaxLength = 9;
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(71, 20);
            this.experience.TabIndex = 16;
            this.experience.TextChanged += new System.EventHandler(this.experience_TextChanged);
            this.experience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.experience_KeyPress);
            // 
            // readStatsBtn
            // 
            this.readStatsBtn.Location = new System.Drawing.Point(104, 236);
            this.readStatsBtn.Name = "readStatsBtn";
            this.readStatsBtn.Size = new System.Drawing.Size(89, 34);
            this.readStatsBtn.TabIndex = 18;
            this.readStatsBtn.Text = "Read Stats";
            this.readStatsBtn.UseVisualStyleBackColor = true;
            this.readStatsBtn.Click += new System.EventHandler(this.readStatsBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "HP:";
            // 
            // health
            // 
            this.health.Location = new System.Drawing.Point(91, 55);
            this.health.MaxLength = 9;
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(71, 20);
            this.health.TabIndex = 19;
            this.health.TextChanged += new System.EventHandler(this.health_TextChanged);
            this.health.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.health_KeyPress);
            // 
            // procLabel
            // 
            this.procLabel.AutoSize = true;
            this.procLabel.Location = new System.Drawing.Point(110, 19);
            this.procLabel.Name = "procLabel";
            this.procLabel.Size = new System.Drawing.Size(83, 13);
            this.procLabel.TabIndex = 21;
            this.procLabel.Text = "Process: Closed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 282);
            this.Controls.Add(this.procLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.health);
            this.Controls.Add(this.readStatsBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addrstones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rhythm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dexterity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.luck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vitality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.strength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silver);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "The Bard\'s Tale Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox silver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox strength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vitality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox luck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dexterity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox charisma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rhythm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addrstones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.Button readStatsBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox health;
        private System.Windows.Forms.Label procLabel;
    }
}

