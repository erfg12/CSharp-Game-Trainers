namespace Trainer_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.visitWeb = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otherSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamSaveBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bingRewardsBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTrainerMemorydllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.downloadBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.downloadBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // visitWeb
            // 
            this.visitWeb.BackColor = System.Drawing.Color.SteelBlue;
            this.visitWeb.Cursor = System.Windows.Forms.Cursors.Default;
            this.visitWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visitWeb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitWeb.Location = new System.Drawing.Point(758, 4);
            this.visitWeb.Name = "visitWeb";
            this.visitWeb.Size = new System.Drawing.Size(108, 23);
            this.visitWeb.TabIndex = 5;
            this.visitWeb.Text = "newagesoldier.com";
            this.visitWeb.UseVisualStyleBackColor = false;
            this.visitWeb.Click += new System.EventHandler(this.visitWeb_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.visitWeb);
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.minimizeButton);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.aboutButton);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 30);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(197, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOWNLOADING COVER ART...";
            // 
            // settingsButton
            // 
            this.settingsButton.AccessibleDescription = "Trainer Manager Settings";
            this.settingsButton.AccessibleName = "Settings Button";
            this.settingsButton.BackColor = System.Drawing.Color.Chocolate;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.Lavender;
            this.settingsButton.Location = new System.Drawing.Point(896, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(24, 23);
            this.settingsButton.TabIndex = 100;
            this.settingsButton.Text = "⚙";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Game Trainer Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // minimizeButton
            // 
            this.minimizeButton.AccessibleDescription = "Minimize Trainer Manager";
            this.minimizeButton.AccessibleName = "Minimize Button";
            this.minimizeButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.Lavender;
            this.minimizeButton.Location = new System.Drawing.Point(923, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 23);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.Tag = "";
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // closeButton
            // 
            this.closeButton.AccessibleDescription = "Close Trainer Manager";
            this.closeButton.AccessibleName = "Close Button";
            this.closeButton.BackColor = System.Drawing.Color.RosyBrown;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(950, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AccessibleDescription = "About Trainer Manager";
            this.aboutButton.AccessibleName = "About Button";
            this.aboutButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.Lavender;
            this.aboutButton.Location = new System.Drawing.Point(869, 4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(24, 23);
            this.aboutButton.TabIndex = 10;
            this.aboutButton.Text = "?";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Cheat Trainer Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherSoftwareToolStripMenuItem,
            this.closeSoftwareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // otherSoftwareToolStripMenuItem
            // 
            this.otherSoftwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamSaveBackupToolStripMenuItem,
            this.bingRewardsBotToolStripMenuItem,
            this.gameTrainerMemorydllToolStripMenuItem});
            this.otherSoftwareToolStripMenuItem.Name = "otherSoftwareToolStripMenuItem";
            this.otherSoftwareToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.otherSoftwareToolStripMenuItem.Text = "Other Software";
            // 
            // steamSaveBackupToolStripMenuItem
            // 
            this.steamSaveBackupToolStripMenuItem.Name = "steamSaveBackupToolStripMenuItem";
            this.steamSaveBackupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.steamSaveBackupToolStripMenuItem.Text = "SteamSaveBackup";
            this.steamSaveBackupToolStripMenuItem.Click += new System.EventHandler(this.steamSaveBackupToolStripMenuItem_Click);
            // 
            // bingRewardsBotToolStripMenuItem
            // 
            this.bingRewardsBotToolStripMenuItem.Name = "bingRewardsBotToolStripMenuItem";
            this.bingRewardsBotToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bingRewardsBotToolStripMenuItem.Text = "Bing Rewards Bot";
            this.bingRewardsBotToolStripMenuItem.Click += new System.EventHandler(this.bingRewardsBotToolStripMenuItem_Click);
            // 
            // gameTrainerMemorydllToolStripMenuItem
            // 
            this.gameTrainerMemorydllToolStripMenuItem.Name = "gameTrainerMemorydllToolStripMenuItem";
            this.gameTrainerMemorydllToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gameTrainerMemorydllToolStripMenuItem.Text = "Game Trainer memory.dll";
            this.gameTrainerMemorydllToolStripMenuItem.Click += new System.EventHandler(this.gameTrainerMemorydllToolStripMenuItem_Click);
            // 
            // closeSoftwareToolStripMenuItem
            // 
            this.closeSoftwareToolStripMenuItem.Name = "closeSoftwareToolStripMenuItem";
            this.closeSoftwareToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeSoftwareToolStripMenuItem.Text = "Close Program";
            this.closeSoftwareToolStripMenuItem.Click += new System.EventHandler(this.closeSoftwareToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.Color.LightSlateGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(182, 625);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(160, 72);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(160, 68);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.downloadBox);
            this.panel3.Location = new System.Drawing.Point(193, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 684);
            this.panel3.TabIndex = 11;
            // 
            // downloadBox
            // 
            this.downloadBox.BackColor = System.Drawing.SystemColors.Control;
            this.downloadBox.Controls.Add(this.progressBar1);
            this.downloadBox.Location = new System.Drawing.Point(219, 267);
            this.downloadBox.Name = "downloadBox";
            this.downloadBox.Size = new System.Drawing.Size(293, 52);
            this.downloadBox.TabIndex = 0;
            this.downloadBox.TabStop = false;
            this.downloadBox.Text = "Downloading";
            this.downloadBox.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(190, 651);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(182, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.ToolTipText = "PC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(182, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.ToolTipText = "Playstation 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.BackColor = System.Drawing.Color.LightSlateGray;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.LargeImageList = this.imageList2;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(182, 629);
            this.listView2.TabIndex = 0;
            this.listView2.TileSize = new System.Drawing.Size(80, 120);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(80, 120);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(182, 625);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.ToolTipText = "Xbox 360";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.AllowColumnReorder = true;
            this.listView3.BackColor = System.Drawing.Color.LightSlateGray;
            this.listView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.LargeImageList = this.imageList3;
            this.listView3.Location = new System.Drawing.Point(0, -2);
            this.listView3.Name = "listView3";
            this.listView3.ShowItemToolTips = true;
            this.listView3.Size = new System.Drawing.Size(182, 629);
            this.listView3.TabIndex = 1;
            this.listView3.TileSize = new System.Drawing.Size(80, 120);
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Tile;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(182, 625);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.ToolTipText = "Wii U";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.AllowColumnReorder = true;
            this.listView4.BackColor = System.Drawing.Color.LightSlateGray;
            this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView4.FullRowSelect = true;
            this.listView4.GridLines = true;
            this.listView4.LargeImageList = this.imageList4;
            this.listView4.Location = new System.Drawing.Point(0, -2);
            this.listView4.Name = "listView4";
            this.listView4.ShowItemToolTips = true;
            this.listView4.Size = new System.Drawing.Size(182, 629);
            this.listView4.TabIndex = 1;
            this.listView4.TileSize = new System.Drawing.Size(80, 120);
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Tile;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(978, 687);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheat Trainer Manager :: http://newagesoldier.com";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.downloadBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otherSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamSaveBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bingRewardsBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameTrainerMemorydllToolStripMenuItem;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ToolStripMenuItem browseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSoftwareToolStripMenuItem;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button visitWeb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox downloadBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.Label label2;
    }
}

