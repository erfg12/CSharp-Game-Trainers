using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Net;
using System.Web;
using Ionic.Zip;
using System.Runtime.InteropServices;
using System.Threading;
using System.Reflection;

namespace Trainer_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Dictionary<int, string> last_modified = new Dictionary<int, string>();
        private string trainerDir = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        string saveDir = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.LargeImageList = imageList1;
            try {
                Process[] p = Process.GetProcessesByName("New Age Trainer Manager");
                if (p.Count() > 1)
                {
                    Close();
                    return;
                }

                if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                    listView1.Invoke(new MethodInvoker(delegate { listView1.Items.Clear(); }));
                else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                    listView2.Invoke(new MethodInvoker(delegate { listView2.Items.Clear(); }));
                else if (tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                    listView3.Invoke(new MethodInvoker(delegate { listView3.Items.Clear(); }));
                else if (tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                    listView4.Invoke(new MethodInvoker(delegate { listView4.Items.Clear(); }));

                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            } catch
            {
                MessageBox.Show("ERROR starting program");
            }

            if (String.IsNullOrEmpty(saveDir))
            {
                saveDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cheat_trainers";
                Properties.Settings.Default.trainer_folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cheat_trainers";
                Properties.Settings.Default.Save();
            }
            saveDir = Properties.Settings.Default.trainer_folder + "/pc";
        }

        Process tProc = null;

        private Bitmap LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                try
                {
                    wreq = (HttpWebRequest)WebRequest.Create(url);
                    wreq.AllowWriteStreamBuffering = true;
                    wresp = (HttpWebResponse)wreq.GetResponse();
                    if ((mystream = wresp.GetResponseStream()) != null)
                        bmp = new Bitmap(mystream);
                }
                catch
                {
                    using (Stream BitmapStream = System.IO.File.Open("header.jpg", System.IO.FileMode.Open))
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(BitmapStream);
                        bmp = new Bitmap(img);
                    }
                }
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }
            return (bmp);
        }

        private void versionCheck()
        {
            try
            {
                string line;
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("http://newagesoldier.com/myfiles/versions.txt");
                using (StreamReader file = new StreamReader(stream))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains("trainer_manager"))
                        {
                            string[] words = line.Split('=');
                            //MessageBox.Show("DEBUG: " + "Online:" + words[1] + " Current:" + Assembly.GetExecutingAssembly().GetName().Version.ToString());
                            int result = String.CompareOrdinal(words[1], Assembly.GetExecutingAssembly().GetName().Version.ToString());
                            //MessageBox.Show("DEBUG: " + ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to")));\
                            if (result > 0)
                            {
                                update updatebox = new update();
                                updatebox.Show();
                            }
                        }
                        else
                            MessageBox.Show("Update function couldn't find version number online.");
                    }
                }
                
            } catch
            {
                MessageBox.Show("Update checking function crashed.");
            }
        }

        public HttpStatusCode GetHeaders(string url)
        {
            HttpStatusCode result = default(HttpStatusCode);

            var request = HttpWebRequest.Create(url);
            request.Method = "HEAD";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                if (response != null)
                {
                    result = response.StatusCode;
                    response.Close();
                }
            }

            return result;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string tscanURL = "https://newagesoldier.com/myfiles/trainers/tscan.php";
                if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                    tscanURL = "https://newagesoldier.com/myfiles/trainers/tscan.php";
                else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                    tscanURL = "https://newagesoldier.com/myfiles/trainers/ps3/tscan.php";
                else if (tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                    tscanURL = "https://newagesoldier.com/myfiles/trainers/xbox360/tscan.php";
                else if (tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                    tscanURL = "https://newagesoldier.com/myfiles/trainers/wiiu/tscan.php";

                XmlTextReader reader = new XmlTextReader(tscanURL);
                last_modified.Clear();
                int i = 0;
                int count = 0;
                while (reader.Read()) //read line by line
                {
                    try
                    {
                        if (reader.Name == "name")
                        {
                            if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                            {
                                string[] words = reader.ReadString().Split('-');
                                ListViewItem lst = new ListViewItem();
                                lst.Tag = words[0];
                                lst.Text = words[1];
                                lst.ToolTipText = lst.Text;
                                lst.ImageIndex = count;
                                listView1.Invoke(new MethodInvoker(delegate { imageList1.Images.Add(LoadPicture("http://cdn.akamai.steamstatic.com/steam/apps/" + words[0] + "/header.jpg")); listView1.Items.Add(lst); }));
                                count++;
                            }
                            else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                            {
                                string[] words = reader.ReadString().Split('-');
                                ListViewItem lst = new ListViewItem();
                                lst.Tag = words[0];
                                lst.Text = words[1];
                                lst.ToolTipText = lst.Text;
                                lst.ImageIndex = count;
                                string url = "http://art.gametdb.com/ps3/cover/EN/" + words[0] + ".jpg";
                                //MessageBox.Show(GetHeaders(url).ToString());
                                listView2.Invoke(new MethodInvoker(delegate {
                                    try
                                    {
                                        imageList2.Images.Add(LoadPicture("http://art.gametdb.com/ps3/cover/EN/" + words[0] + ".jpg")); listView2.Items.Add(lst);
                                    } catch
                                    {
                                        imageList2.Images.Add(Image.FromFile("ps3_empty.jpg")); listView2.Items.Add(lst);
                                    }
                                }));
                                count++;
                            }
                            else if (tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                            {
                                string[] words = reader.ReadString().Split('-');
                                ListViewItem lst = new ListViewItem();
                                lst.Tag = words[0];
                                lst.Text = words[1];
                                lst.ToolTipText = lst.Text;
                                lst.ImageIndex = count;
                                listView3.Invoke(new MethodInvoker(delegate { imageList3.Images.Add(LoadPicture("http://www.freecovers.net/preview/0/" + words[0] + "/big.jpg")); listView3.Items.Add(lst); }));
                                count++;
                            }
                            else if (tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                            {
                                string[] words = reader.ReadString().Split('-');
                                ListViewItem lst = new ListViewItem();
                                lst.Tag = words[0];
                                lst.Text = words[1];
                                lst.ToolTipText = lst.Text;
                                lst.ImageIndex = count;
                                listView4.Invoke(new MethodInvoker(delegate { imageList4.Images.Add(LoadPicture("http://art.gametdb.com/wiiu/cover/EN/" + words[0] + ".jpg")); listView4.Items.Add(lst); }));
                                count++;
                            }
                        }
                        if (reader.Name == "last_modified")
                        {
                            //MessageBox.Show("i:" + i.ToString() + " " + reader.ReadString());
                            last_modified.Add(i, reader.ReadString());
                            i++;
                        }
                    }
                    catch
                    {
                        //MessageBox.Show("ERROR: Your internet connection may have been interrupted.");
                    }
                }
            }
            catch {
                MessageBox.Show("ERROR: Downloading tscan.php failed!");
            }
        }

        private void launchTrainer()
        {
            //MessageBox.Show("DEBUG: Launching Trainer - Dir:" + trainerDir);
            try
            {
                /*foreach (var file in Directory.GetFiles(trainerDir, "*.exe", SearchOption.AllDirectories))
                {
                    try
                    {
                        Microsoft.Win32.RegistryKey key;
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers");
                        key.SetValue(file, "RUNASADMIN");
                        key.Close();
                    }
                    catch
                    {
                        //MessageBox.Show("ERROR: Cannot add admin privileges to program " + Path.GetFileName(file));
                    }
                }*/
                foreach (var file in Directory.GetFiles(trainerDir, "*trainer*.exe", SearchOption.AllDirectories))
                {
                    //ProcessStartInfo info = new ProcessStartInfo(file);
                    //info.UseShellExecute = true;
                    //info.Verb = "runas";
                    //Process.Start(info);
                    //try
                    //{
                    if (tProc != null) //close old trainer
                    {
                        tProc.CloseMainWindow();
                        tProc.Close();
                    }
                    tProc = new Process();
                    tProc.StartInfo.FileName = file;
                    tProc.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                    tProc.Start();
                    while (string.IsNullOrEmpty(tProc.MainWindowTitle))
                    {
                        //System.Threading.Thread.Sleep(100);
                        tProc.Refresh();
                    }
                    ShowWindow(tProc.MainWindowHandle, 0);
                    SetParent(tProc.MainWindowHandle, panel3.Handle);
                    ShowWindow(tProc.MainWindowHandle, SW_SHOWMAXIMIZED);
                    /*} catch
                    {

                    }*/
                    return;
                }
            } catch
            {
                MessageBox.Show("ERROR: Issue launching trainer application.");
            }
        }

        private void startDownload()
        {
            //MessageBox.Show("DEBUG: starting download...");
            //dlprogressLabel.Visible = true;
            progressBar1.Value = 0;
            //dlprogressLabel.Text = "Downloading...";
            if (!Directory.Exists(trainerDir))
            {
                //MessageBox.Show("[DEBUG] Making trainerDir:" + trainerDir);
                Directory.CreateDirectory(trainerDir);
            }

            //MessageBox.Show("[DEBUG] Modify this... " + last_modified[listView2.SelectedItems[0].Index]);

            if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                Directory.SetCreationTime(trainerDir, Convert.ToDateTime(last_modified[listView1.SelectedItems[0].Index])); //server time can be different, so let's update the folder create time to match
            else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                Directory.SetCreationTime(trainerDir, Convert.ToDateTime(last_modified[listView2.SelectedItems[0].Index]));
            else if (tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                Directory.SetCreationTime(trainerDir, Convert.ToDateTime(last_modified[listView3.SelectedItems[0].Index]));
            else if (tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                Directory.SetCreationTime(trainerDir, Convert.ToDateTime(last_modified[listView4.SelectedItems[0].Index]));

            downloadBox.Visible = true;
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        void getTrainer(string tname)
        {
            try
            {
                trainerDir = saveDir + "\\" + tname;
                if (!Directory.Exists(saveDir) && saveDir != "")
                    Directory.CreateDirectory(saveDir);

                string[] dirs = Directory.GetFiles(saveDir, tname + @".*");

                //MessageBox.Show("[DEBUG] tname:" + tname + " trainerDir:" + trainerDir);

                if (Directory.Exists(trainerDir))
                {
                    //MessageBox.Show("[DEBUG] dir exists! trainerDir:" + trainerDir);
                    if (Directory.GetFiles(trainerDir, "*trainer*.exe").Length == 0) //directory is empty? I guess it could happen...
                    {
                        //Directory.Delete(trainerDir, true);
                        startDownload();
                        return;
                    }
                    else
                    {
                        //MessageBox.Show("[DEBUG] cant find trainer.exe! trainerDir:" + trainerDir);
                        int lastmod = 0;
                        if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                            lastmod = listView1.Items.IndexOf(listView1.FindItemWithText(tname));
                        else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                            lastmod = listView2.Items.IndexOf(listView2.FindItemWithText(tname));
                        else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //xbox360
                            lastmod = listView3.Items.IndexOf(listView3.FindItemWithText(tname));
                        else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //wiiu
                            lastmod = listView4.Items.IndexOf(listView4.FindItemWithText(tname));
                        if (Convert.ToDateTime(last_modified[lastmod]) > Directory.GetCreationTime(trainerDir))
                        { //check if we need to upate this trainer
                            Directory.Delete(trainerDir, true);
                            startDownload();
                        }
                        else
                            launchTrainer();
                    }
                }
                else
                {
                    //MessageBox.Show("[DEBUG] dir doesnt exist! Downloading trainerDir:" + trainerDir);
                    startDownload();
                }
            } catch
            {
                MessageBox.Show("ERROR: Issue with getTrainer function. trainerDir:" + trainerDir);
            }
        }

        static String BytesToString(double byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs((long)byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        public void ExtractFileToDirectory(string zipFileName, string outputDirectory)
        {
            progressBar1.Value = 100;
            //dlprogressLabel.Invoke(new MethodInvoker(delegate { dlprogressLabel.Text = "Unzipping files..."; }));

            FileStream fs = File.OpenRead(zipFileName);
            string tmpFile = null;
            if (zipFileName.Contains(".zip") == true)
            {
                ZipFile zip = ZipFile.Read(fs);
                foreach (ZipEntry e in zip)
                {
                    e.Extract(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
                }
                tmpFile = outputDirectory + @"\tmp.zip";
            }

            fs.Close();

            File.Delete(tmpFile);
            //MessageBox.Show("zipfilename:" + zipFileName + " outputdir:" + outputDirectory);
            //dlprogressLabel.Visible = false;
            //dlprogressLabel.Text = "Nothing to do...";
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Invoke(new MethodInvoker(delegate{ progressBar1.Value = e.ProgressPercentage; }));
            //dlprogressLabel.Invoke(new MethodInvoker(delegate { dlprogressLabel.Text = e.ProgressPercentage.ToString() + "%"; }));
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            launchTrainer();
            progressBar1.Value = 0;
            downloadBox.Visible = false;
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(2000);
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string realURL = null;
                string sFilePathToWriteFileTo = null;
                sFilePathToWriteFileTo = trainerDir + @"\tmp.zip";

                //listView1.Invoke(new MethodInvoker(delegate
                //{
                    if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                        realURL = HttpUtility.HtmlDecode("https://newagesoldier.com/myfiles/trainers/" + listView1.SelectedItems[0].Tag + "-" + listView1.SelectedItems[0].Text + ".zip");
                    else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                        realURL = HttpUtility.HtmlDecode("https://newagesoldier.com/myfiles/trainers/ps3/" + listView2.SelectedItems[0].Tag + "-" + listView2.SelectedItems[0].Text + ".zip");
                    else if(tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                        realURL = HttpUtility.HtmlDecode("https://newagesoldier.com/myfiles/trainers/xbox360/" + listView3.SelectedItems[0].Tag + "-" + listView3.SelectedItems[0].Text + ".zip");
                    else if(tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                        realURL = HttpUtility.HtmlDecode("https://newagesoldier.com/myfiles/trainers/wiiu/" + listView4.SelectedItems[0].Tag + "-" + listView4.SelectedItems[0].Text + ".zip");
                //}));
                
                Uri url = new Uri(realURL);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("ERROR: There was a problem pulling the zip file. Check internet connection.");
                    return;
                }

                //MessageBox.Show("DEBUG: Creating tmp file: " + sFilePathToWriteFileTo);

                response.Close();
                long iSize = response.ContentLength;
                Int64 iRunningByteTotal = 0;

                using (WebClient DLclient = new WebClient())
                {
                    using (Stream streamRemote = DLclient.OpenRead(new Uri(realURL)))
                    {
                        using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            int iByteSize = 0;
                            byte[] byteBuffer;
                            byteBuffer = new byte[iSize];
                            while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                            {
                                streamLocal.Write(byteBuffer, 0, iByteSize);
                                iRunningByteTotal += iByteSize;

                                if (backgroundWorker2.CancellationPending == true)
                                {
                                    e.Cancel = true;
                                    break;
                                }

                                double bytesIn = double.Parse(iRunningByteTotal.ToString());
                                double totalBytes = double.Parse(byteBuffer.Length.ToString());
                                double percentage = bytesIn / totalBytes * 100;

                                int iProgressPercentage = int.Parse(Math.Truncate(percentage).ToString());
                                backgroundWorker2.ReportProgress(iProgressPercentage);
                            }
                            streamLocal.Close();
                        }
                        streamRemote.Close();
                    }
                }
                ExtractFileToDirectory(sFilePathToWriteFileTo, trainerDir);
            } catch
            {
                MessageBox.Show("ERROR: Trainer downloading issue. URL:" + "https://newagesoldier.com/myfiles/trainers/" + listView1.SelectedItems[0].Tag + "-" + listView1.SelectedItems[0].Text + ".zip");
            }
        }

        private void form1_Closing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void steamSaveBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://newagesoldier.com/steam-save-backup/");
        }

        private void bingRewardsBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://newagesoldier.com/bing-rewards-bot/");
        }

        private void gameTrainerMemorydllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://newagesoldier.com/memory-hacker/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (saveDir != "")
            //    Process.Start(saveDir);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            /*if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }*/
        }

        private void notifyIcon_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Show();
        }

        private void ct_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                /*listView1.FocusedItem.Index = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                    contextMenuStrip2.Show(Cursor.Position);*/
            }
        }

        private void closeSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void visitWeb_Click(object sender, EventArgs e)
        {
            Process.Start("http://newage.software");
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                ImageList iconsList = new ImageList();
                iconsList.TransparentColor = Color.Blue;
                iconsList.ColorDepth = ColorDepth.Depth32Bit;
                iconsList.ImageSize = new Size(15, 15);
                iconsList.Images.Add(Image.FromFile(@"pc.jpg"));
                iconsList.Images.Add(Image.FromFile(@"playstation.png"));
                iconsList.Images.Add(Image.FromFile(@"xbox360.png"));
                iconsList.Images.Add(Image.FromFile(@"wiiu.png"));
                tabControl1.ImageList = iconsList;
                tabControl1.ShowToolTips = true;
                tabPage1.ImageIndex = 0;
                tabPage2.ImageIndex = 1;
                tabPage3.ImageIndex = 2;
                tabPage4.ImageIndex = 3;
            } catch { }
            versionCheck();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (listView1.SelectedItems.Count > 0)
            {
                button1.Enabled = true;
                if (!Directory.Exists(saveDir + "//" + listView1.SelectedItems[0].Text))
                    button1.Text = "START";
                else
                    button1.Text = "START";
            }*/
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                getTrainer(listView1.SelectedItems[0].Text);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.Controls[0] == tabControl1.SelectedTab)
                saveDir = Properties.Settings.Default.trainer_folder + "/pc";
            else if (tabControl1.Controls[1] == tabControl1.SelectedTab)
                saveDir = Properties.Settings.Default.trainer_folder + "/ps3";
            else if(tabControl1.Controls[2] == tabControl1.SelectedTab)
                saveDir = Properties.Settings.Default.trainer_folder + "/xbox360";
            else if (tabControl1.Controls[3] == tabControl1.SelectedTab)
                saveDir = Properties.Settings.Default.trainer_folder + "/wiiu";

            label2.Visible = true;
            listView1.Cursor = Cursors.WaitCursor;
            listView2.Cursor = Cursors.WaitCursor;
            listView3.Cursor = Cursors.WaitCursor;
            listView4.Cursor = Cursors.WaitCursor;

            if (tabControl1.Controls[0] == tabControl1.SelectedTab) //PC
                listView1.Invoke(new MethodInvoker(delegate { listView1.Items.Clear(); }));
            else if (tabControl1.Controls[1] == tabControl1.SelectedTab) //PS3
                listView2.Invoke(new MethodInvoker(delegate { listView2.Items.Clear(); }));
            else if (tabControl1.Controls[2] == tabControl1.SelectedTab) //xbox360
                listView3.Invoke(new MethodInvoker(delegate { listView3.Items.Clear(); }));
            else if (tabControl1.Controls[3] == tabControl1.SelectedTab) //wiiu
                listView4.Invoke(new MethodInvoker(delegate { listView4.Items.Clear(); }));

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                getTrainer(listView2.SelectedItems[0].Text);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listView1.Cursor = Cursors.Hand;
            listView2.Cursor = Cursors.Hand;
            listView3.Cursor = Cursors.Hand;
            listView4.Cursor = Cursors.Hand;
            label2.Visible = false;
        }

        private void listView3_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
                getTrainer(listView3.SelectedItems[0].Text);
        }

        private void listView4_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
                getTrainer(listView4.SelectedItems[0].Text);
        }
    }
}
