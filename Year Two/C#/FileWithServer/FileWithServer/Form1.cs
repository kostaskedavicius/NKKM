using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace FileWithServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebClient client;
        Stopwatch watch = new Stopwatch();

        private void btnString_Click(object sender, EventArgs e)
        {
            // Check if http:// or https://
            if (!txtAddress.Text.ToLower().Contains("http://"))
            {
                txtAddress.Text = txtAddress.Text.Insert(0, "http://");
            }

            // Creating a WebClient and reading string
            client = new WebClient();
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri(txtAddress.Text));

        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            txtMisc.ScrollBars = ScrollBars.Both;
            txtMisc.Text = e.Result;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            watch.Start();
            // Cleaning up in case of prolonged use
            lblSpeed.Text = "Speed: 0";
            lblProg.Text = "Downloaded: 0";
            // Creating a WebClient and downloading file
            client = new WebClient();
            // Save to downloads
            // Define download folder
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            // Check if Donwloads folder exists
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileAsync(new Uri(txtAddress.Text), dir + @"\MyFile.zip");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            ShowProgress(e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage);
            if ((e.BytesReceived / 1024) > 1000)
            {
                lblSpeed.Text = ((e.BytesReceived / 1048576.0) / watch.Elapsed.Seconds).ToString("0.00") + "Mb/s";
            }
            else lblSpeed.Text = ((e.BytesReceived / 1024.0) / watch.Elapsed.Seconds).ToString("0.00") + "Kb/s";

        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded succesfully");

            watch.Stop();
            watch.Reset();
        }

        void ShowProgress(long inBytes, long toDown, int Prog)
        {
            progDone.Value = Prog;
            if (inBytes < 1024)
            {
                lblProg.Text = "Downloaded: " + inBytes.ToString() + " b";
            }
            else if (inBytes / 1024 < 1024)
            {
                lblProg.Text = "Downloaded: " + (inBytes / 1024).ToString() + " Kb";
            }
            else if (inBytes / 1024 < 1048576)
            {
                lblProg.Text = "Downloaded: " + (inBytes / 1048576.0).ToString("0.00") + " Mb";
            }
            else
            {
                lblProg.Text = "Downloaded: " + (inBytes / 1073741824.0).ToString("0.00") + "Gb";
            }
        }
    }
}
