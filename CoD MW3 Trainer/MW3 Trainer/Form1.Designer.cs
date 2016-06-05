namespace MW3_Trainer
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
            this.resetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timescale_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSize = true;
            this.ProcessID.Location = new System.Drawing.Point(62, 11);
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Size = new System.Drawing.Size(57, 13);
            this.ProcessID.TabIndex = 1;
            this.ProcessID.Text = "Not Found";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // godmode_checkbox
            // 
            this.godmode_checkbox.AutoSize = true;
            this.godmode_checkbox.Location = new System.Drawing.Point(13, 49);
            this.godmode_checkbox.Name = "godmode_checkbox";
            this.godmode_checkbox.Size = new System.Drawing.Size(76, 17);
            this.godmode_checkbox.TabIndex = 2;
            this.godmode_checkbox.Text = "God Mode";
            this.godmode_checkbox.UseVisualStyleBackColor = true;
            this.godmode_checkbox.CheckedChanged += new System.EventHandler(this.godmode_checkbox_CheckedChanged);
            // 
            // timescale_trackbar
            // 
            this.timescale_trackbar.Location = new System.Drawing.Point(228, 26);
            this.timescale_trackbar.Maximum = 30;
            this.timescale_trackbar.Name = "timescale_trackbar";
            this.timescale_trackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.timescale_trackbar.Size = new System.Drawing.Size(45, 210);
            this.timescale_trackbar.TabIndex = 3;
            this.timescale_trackbar.Value = 5;
            this.timescale_trackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timescale_Label
            // 
            this.timescale_Label.AutoSize = true;
            this.timescale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timescale_Label.Location = new System.Drawing.Point(212, 10);
            this.timescale_Label.Name = "timescale_Label";
            this.timescale_Label.Size = new System.Drawing.Size(83, 13);
            this.timescale_Label.TabIndex = 4;
            this.timescale_Label.Text = "Gravity Scale";
            // 
            // infammo_checkbox
            // 
            this.infammo_checkbox.AutoSize = true;
            this.infammo_checkbox.Location = new System.Drawing.Point(13, 69);
            this.infammo_checkbox.Name = "infammo_checkbox";
            this.infammo_checkbox.Size = new System.Drawing.Size(89, 17);
            this.infammo_checkbox.TabIndex = 5;
            this.infammo_checkbox.Text = "Infinite Ammo";
            this.infammo_checkbox.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(272, 119);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(61, 23);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "+ Increase Gravity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "- Decrease Gravity";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(7, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Created by The New Age Soldier";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(393, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetBtn);
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
            this.Text = "CoD: MW 3 SP Trainer";
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
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}

