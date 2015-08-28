using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using System.Web;
using Ionic.Zip;

namespace Trainer_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string defaultDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cheat_trainers";

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.trainer_folder;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Clear(); }));

            XmlTextReader reader = new XmlTextReader("https://newagesoldier.com/myfiles/trainers/tscan.php");
            while (reader.Read()) //read line by line
            {
                try
                {
                    if (reader.Name == "name")
                        listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add(reader.ReadString()); }));

                    //if (reader.Name == "title")
                    //    title = reader.ReadString();
                }
                catch
                {
                    //MessageBox.Show("Could not create covers. Your internet connection may have been interrupted.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox1.Text))
                Directory.CreateDirectory(textBox1.Text);

            string[] dirs = Directory.GetFiles(textBox1.Text, listBox1.Text + @".*");

            if (dirs == null || dirs.Length == 0) //begin the download
            {
                if (!backgroundWorker2.IsBusy)
                    backgroundWorker2.RunWorkerAsync();
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
            dlprogressLabel.Invoke(new MethodInvoker(delegate { dlprogressLabel.Text = "Unzipping files..."; }));

            FileStream fs = File.OpenRead(zipFileName);
            string tmpFile = "";
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
            dlprogressLabel.Visible = false;
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (dlprogressLabel.InvokeRequired)
                dlprogressLabel.Invoke(new MethodInvoker(delegate
                {
                    dlprogressLabel.Text = e.ProgressPercentage.ToString() + "%";
                }));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var file in Directory.GetFiles(textBox1.Text + "\\" + listBox1.Text, "*.exe", SearchOption.AllDirectories))
            {
                System.Diagnostics.Process.Start(file);
            }
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
                if (!Directory.Exists(textBox1.Text + "\\" + listBox1.Text))
                    Directory.CreateDirectory(textBox1.Text + "\\" + listBox1.Text);
                sFilePathToWriteFileTo = textBox1.Text + "\\" + listBox1.Text + @"\tmp.zip";
            }));

            string sUrlToReadFileFrom = realURL;

            Uri url = new Uri(sUrlToReadFileFrom);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Close();
            long iSize = response.ContentLength;
            Int64 iRunningByteTotal = 0;

            dlprogressLabel.Invoke(new MethodInvoker(delegate
            {
                dlprogressLabel.Visible = true;
            }));

            using (WebClient DLclient = new WebClient())
            {
                using (Stream streamRemote = DLclient.OpenRead(new Uri(sUrlToReadFileFrom)))
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
                ExtractFileToDirectory(sFilePathToWriteFileTo, textBox1.Text + "\\" + listBox1.Text);
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

            string[] files = Directory.GetFiles(fbd.SelectedPath);
            textBox1.Text = fbd.SelectedPath;
        }

        private void form1_Closing()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = defaultDir;
        }
    }
}
