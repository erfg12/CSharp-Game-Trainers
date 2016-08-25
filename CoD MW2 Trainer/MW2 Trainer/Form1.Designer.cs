namespace MW2_Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.godmode_checkbox = new System.Windows.Forms.CheckBox();
            this.timescale_trackbar = new System.Windows.Forms.TrackBar();
            this.timescale_Label = new System.Windows.Forms.Label();
            this.infammo_checkbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noclip_toggle = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timescale_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(28, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessID.ForeColor = System.Drawing.Color.SteelBlue;
            this.ProcessID.Location = new System.Drawing.Point(126, 208);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(103, 25);
            this.ProcessID.TabIndex = 1;
            this.ProcessID.Text = "Not Found";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // godmode_checkbox
            // 
            this.godmode_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godmode_checkbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.godmode_checkbox.Location = new System.Drawing.Point(33, 277);
            this.godmode_checkbox.Name = "godmode_checkbox";
            this.godmode_checkbox.Size = new System.Drawing.Size(161, 28);
            this.godmode_checkbox.TabIndex = 2;
            this.godmode_checkbox.Text = "God Mode";
            this.godmode_checkbox.UseVisualStyleBackColor = true;
            this.godmode_checkbox.CheckedChanged += new System.EventHandler(this.godmode_checkbox_CheckedChanged);
            // 
            // timescale_trackbar
            // 
            this.timescale_trackbar.Location = new System.Drawing.Point(593, 47);
            this.timescale_trackbar.Maximum = 30;
            this.timescale_trackbar.Name = "timescale_trackbar";
            this.timescale_trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.timescale_trackbar.Size = new System.Drawing.Size(45, 480);
            this.timescale_trackbar.TabIndex = 3;
            this.timescale_trackbar.Value = 5;
            this.timescale_trackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timescale_Label
            // 
            this.timescale_Label.AutoSize = true;
            this.timescale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timescale_Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.timescale_Label.Location = new System.Drawing.Point(577, 19);
            this.timescale_Label.Name = "timescale_Label";
            this.timescale_Label.Size = new System.Drawing.Size(121, 25);
            this.timescale_Label.TabIndex = 4;
            this.timescale_Label.Text = "Time Scale";
            // 
            // infammo_checkbox
            // 
            this.infammo_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infammo_checkbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.infammo_checkbox.Location = new System.Drawing.Point(33, 315);
            this.infammo_checkbox.Name = "infammo_checkbox";
            this.infammo_checkbox.Size = new System.Drawing.Size(180, 29);
            this.infammo_checkbox.TabIndex = 5;
            this.infammo_checkbox.Text = "Infinite Ammo";
            this.infammo_checkbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(82, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "No Clip Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(28, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Clip Mode:";
            // 
            // noclip_toggle
            // 
            this.noclip_toggle.AutoSize = true;
            this.noclip_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noclip_toggle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.noclip_toggle.Location = new System.Drawing.Point(173, 421);
            this.noclip_toggle.Name = "noclip_toggle";
            this.noclip_toggle.Size = new System.Drawing.Size(96, 25);
            this.noclip_toggle.TabIndex = 8;
            this.noclip_toggle.Text = "Disabled";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.SlateGray;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(635, 269);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(61, 23);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "+ Increase Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "- Decrease Speed";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(635, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(635, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(559, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Created by The New Age Soldier";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(33, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "F2";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Octapost NBP", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(21, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(423, 41);
            this.label7.TabIndex = 16;
            this.label7.Text = "Call of Duty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Octapost NBP", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MintCream;
            this.label8.Location = new System.Drawing.Point(21, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(548, 41);
            this.label8.TabIndex = 17;
            this.label8.Text = "Modern Warfare 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(763, 645);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.noclip_toggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infammo_checkbox);
            this.Controls.Add(this.timescale_Label);
            this.Controls.Add(this.timescale_trackbar);
            this.Controls.Add(this.godmode_checkbox);
            this.Controls.Add(this.ProcessID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CoD: MW 2 SP Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timescale_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcessID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox godmode_checkbox;
        private System.Windows.Forms.TrackBar timescale_trackbar;
        private System.Windows.Forms.Label timescale_Label;
        private System.Windows.Forms.CheckBox infammo_checkbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noclip_toggle;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

