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

namespace Trainer_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string defaultDir;
        Dictionary<int, string> last_modified = new Dictionary<int, string>();
        private string trainerDir = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                Process[] p = Process.GetProcessesByName("New Age Trainer Manager");
                if (p.Count() > 1)
                {
                    Close();
                    return;
                }
                defaultDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cheat_trainers";
                if (!String.IsNullOrEmpty(Properties.Settings.Default.trainer_folder))
                    textBox1.Text = Properties.Settings.Default.trainer_folder;
                else
                    textBox1.Text = defaultDir;

                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            } catch
            {
                MessageBox.Show("ERROR starting program");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Clear(); }));

            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://newagesoldier.com/myfiles/trainers/tscan.php");
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode != HttpStatusCode.OK)
                    listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add("ERROR: There was a problem pulling the XML data."); }));
            }
            catch {
                listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add("ERROR: Cant connect to the internet."); }));
                return;
            }

            using (WebClient client = new WebClient())
            {
                centerNews.DocumentText = client.DownloadString("https://newagesoldier.com/myfiles/trainers/news.php");
            }

            XmlTextReader reader = new XmlTextReader("https://newagesoldier.com/myfiles/trainers/tscan.php");
            int i = 0;
            while (reader.Read()) //read line by line
            {
                try
                {
                    if (reader.Name == "name")
                    {
                        listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add(reader.ReadString()); }));
                        //(contextMenuStrip1.Items[0] as ToolStripMenuItem).DropDownItems.Add(reader.ReadString());
                    }

                    if (reader.Name == "last_modified")
                    {
                        last_modified.Add(i, reader.ReadString());
                        i++;
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR: Your internet connection may have been interrupted.");
                }
            }
        }

        private void launchTrainer()
        {
            foreach (var file in Directory.GetFiles(trainerDir, "*.exe", SearchOption.AllDirectories))
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
            }
            foreach (var file in Directory.GetFiles(trainerDir, "*trainer*.exe", SearchOption.AllDirectories))
            {
                ProcessStartInfo info = new ProcessStartInfo(file);
                info.UseShellExecute = true;
                info.Verb = "runas";
                Process.Start(info);
                return;
            }
        }

        private void startDownload()
        {
            //dlprogressLabel.Visible = true;
            progressBar1.Value = 0;
            dlprogressLabel.Text = "Downloading...";
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           getTrainer(listBox1.Text);
        }

        void getTrainer(string tname)
        {
            trainerDir = textBox1.Text + "\\" + tname;
            
            if (!Directory.Exists(textBox1.Text) && textBox1.Text != "")
                Directory.CreateDirectory(textBox1.Text);

            string[] dirs = Directory.GetFiles(textBox1.Text, tname + @".*");

            if (Directory.Exists(trainerDir))
            {
                if (Directory.GetFiles(trainerDir, "*trainer*.exe").Length == 0) //directory is empty? I guess it could happen...
                {
                    Directory.Delete(trainerDir, true);
                    startDownload();
                    return;
                }
                else
                {
                    if (Convert.ToDateTime(last_modified[listBox1.FindString(tname)]) > Directory.GetCreationTime(trainerDir))
                    { //check if we need to upate this trainer
                        //MessageBox.Show(Convert.ToDateTime("DEBUG: " + last_modified[listBox1.SelectedIndex]).ToString() + " > " + Directory.GetCreationTime(trainerDir));
                        Directory.Delete(trainerDir, true);
                        startDownload();
                    }
                    else
                        launchTrainer();
                }
            }
            else
                startDownload();
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
            dlprogressLabel.Invoke(new MethodInvoker(delegate { dlprogressLabel.Text = "Unzipping files..."; }));

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
            //dlprogressLabel.Visible = false;
            dlprogressLabel.Text = "Nothing to do...";
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Invoke(new MethodInvoker(delegate{ progressBar1.Value = e.ProgressPercentage; }));
            dlprogressLabel.Invoke(new MethodInvoker(delegate { dlprogressLabel.Text = e.ProgressPercentage.ToString() + "%"; }));
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            launchTrainer();
            progressBar1.Value = 0;
        }

        async Task PutTaskDelay()
        {
            await Task.Delay(2000);
        }

        async void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            await PutTaskDelay();
            adBrowser.Document.Window.ScrollTo(0, 9999);
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button1.PerformClick();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string realURL = null;
            string sFilePathToWriteFileTo = null;

            listBox1.Invoke(new MethodInvoker(delegate
            {
                realURL = HttpUtility.HtmlDecode("https://newagesoldier.com/myfiles/trainers/" + listBox1.Text + ".zip");

                if (!Directory.Exists(trainerDir))
                    Directory.CreateDirectory(trainerDir);

                Directory.SetCreationTime(trainerDir, Convert.ToDateTime(last_modified[listBox1.SelectedIndex])); //server time can be different, so let's update the folder create time to match

                sFilePathToWriteFileTo = trainerDir + @"\tmp.zip";
            }));

            Uri url = new Uri(realURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("ERROR: There was a problem pulling the zip file. Check internet connection.");
                return;
            }

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

                            double dIndex = (double)(iRunningByteTotal);
                            double dTotal = (double)byteBuffer.Length;
                            double dProgressPercentage = (dIndex / dTotal);
                            int iProgressPercentage = (int)(dProgressPercentage * 100);
                            if (dIndex > 0 && dTotal > 0)
                            {
                                dlprogressLabel.Invoke(new MethodInvoker(delegate
                                {
                                    dlprogressLabel.Text = BytesToString(dIndex).ToString() + "/" + BytesToString(dTotal).ToString() + " (" + iProgressPercentage.ToString() + "%)";
                                }));
                            }
                            backgroundWorker2.ReportProgress(iProgressPercentage);
                        }
                        streamLocal.Close();
                    }
                    streamRemote.Close();
                }
            }
            listBox1.Invoke(new MethodInvoker(delegate
            {
                ExtractFileToDirectory(sFilePathToWriteFileTo, trainerDir);
            }));
        }

        private void form1_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.trainer_folder = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (!String.IsNullOrEmpty(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = defaultDir;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button1.Enabled = true;
                if (!Directory.Exists(textBox1.Text + "//" + listBox1.Text))
                    button1.Text = "DOWNLOAD && EXECUTE";
                else
                    button1.Text = "EXECUTE TRAINER";
            }
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
            if (textBox1.Text != "")
                Process.Start(textBox1.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
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
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                    contextMenuStrip2.Show(Cursor.Position);
            }
        }

        private void browseFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string trainerDir = textBox1.Text + "\\" + listBox1.Text;
                if (Directory.Exists(trainerDir))
                    Process.Start(trainerDir);
                else
                    MessageBox.Show("No directory for this trainer. Please download first.");
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
            Process.Start("http://newagesoldier.com");
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
