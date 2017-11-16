using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FTP_ServerCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FtpWebRequest request;
        FtpWebResponse response;
        string firstAddress = string.Empty;


        void ConnectToFTP(string addr, string user, string pass)
        {
            lstBox.Items.Clear();

            // Create FTP Web request
            request = (FtpWebRequest)WebRequest.Create(addr);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            // Specify credentials
            request.Credentials = new NetworkCredential(user, pass);
            // Get response
            response = (FtpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();

            // Get details from FileProperties class
            lstBox.Items.AddRange(FileProperties.GetDetails(stream).ToArray());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstAddress) || !txtAddress.Text.Contains(firstAddress))
            {
                firstAddress = txtAddress.Text;
            }
            ConnectToFTP(txtAddress.Text, "", "");
        }

        private void lstBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            FileProperties fileProperties;
            Brush myBrush;

            lstBox.ForeColor = Color.White;

            // If nothing exists
            if (e.Index == -1) return;

            // Select brush type and highlight text
            if ((e.State & DrawItemState.Selected) != 0) myBrush = SystemBrushes.HighlightText;
            else myBrush = SystemBrushes.WindowText;

            e.DrawBackground();
            lstBox.ForeColor = Color.White;
            // Convert current object to FileProperties
            fileProperties = lstBox.Items[e.Index] as FileProperties;

            // Draw Name
            e.Graphics.DrawString(fileProperties.Name, e.Font, myBrush, new Rectangle(0, e.Bounds.Top, lblSize.Left - lblName.Left, e.Bounds.Height));

            // Draw Size
            e.Graphics.DrawString((fileProperties.Size / 1024.0).ToString("0.00"), e.Font, myBrush, new Rectangle(lblSize.Left, e.Bounds.Top, lblType.Left - lblSize.Left, e.Bounds.Height));

            // Draw Type
            e.Graphics.DrawString(fileProperties.Type.ToString(), e.Font, myBrush, new Rectangle(lblType.Left, e.Bounds.Top, lblType.Left, e.Bounds.Height));
        }

        private async void lstBox_DoubleClick(object sender, EventArgs e)
        {
            // Check if something is selected
            if (lstBox.SelectedIndex == -1) return;
            FileProperties item = lstBox.SelectedItem as FileProperties;
            if (item == null) return;

            // Check item type
            if (item.Type == Types.Folder || item.Type == Types.Link)
            {
                // Add name to the address
                txtAddress.AppendText("/" + item.Name);

                // Connect to new address
                btnConnect.PerformClick();
            }
            else
            {
                // Download file
                request = (FtpWebRequest)WebRequest.Create(txtAddress.Text + "/" + item.Name);
                request.Credentials = new NetworkCredential("", "");
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.KeepAlive = true;
                request.UseBinary = true;
                request.UsePassive = true;

                response = (FtpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                byte[] data = new byte[response.ContentLength];
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + item.Name;
                FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                await file.WriteAsync(data, 0, data.Length);
                file.Close();
                reader.Close();
                stream.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (firstAddress != txtAddress.Text && txtAddress.Text.Contains(firstAddress))
            {
                txtAddress.Text = txtAddress.Text.Remove(txtAddress.Text.LastIndexOf("/"));
                btnConnect.PerformClick();
            }
        }
    }
}