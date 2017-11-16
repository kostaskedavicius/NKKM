using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ushort port;
        string serverIP;
        string clientName;
        TcpClient client = new TcpClient(); // Create new Tcp client object
        NetworkStream stream;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdress.Text)) //check if adress is entered
            {
                MessageBox.Show("You have not entered a correct server address", "Error");
                return;
            }
            if (!ushort.TryParse(txtPort.Text, out port))
            {
                MessageBox.Show("You do not appear to have entered a number. Check your port number again", "Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text)) MessageBox.Show("Please enter your UserName", "Error");

            serverIP = txtAdress.Text;
            clientName = txtName.Text;

            try
            {
                client.Connect(serverIP, port); // Try to connect to server
            }
            catch
            {
                MessageBox.Show("Couldn't connect to server");
            }
            stream = client.GetStream(); // Open data link with server
            byte[] name = Encoding.ASCII.GetBytes(clientName);
            stream.Write(name, 0, name.Length); // Send name to server
            stream.Flush();

            txtMessage.Enabled = true;
            btnSend.Enabled = true;
            btnConnect.Enabled = false;

            new Thread(GetBroadcast).Start();
        }

        private void GetBroadcast()
        {
            while (true)
            {
                if (!client.Connected)
                {
                    client.Close();
                }
                else
                {
                    byte[] data = new byte[1024];
                    stream = client.GetStream();
                    stream.Read(data, 0, data.Length);
                    string msg = Encoding.ASCII.GetString(data);
                    msg = msg.Remove(msg.IndexOf('\0'));
                    if (this.InvokeRequired) Invoke(new MethodInvoker(
                            () =>
                            {
                                lstChatFeed.Items.Add(msg);
                                lstChatFeed.TopIndex = lstChatFeed.Items.Count - 1;
                            }
                      ));
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!client.Connected) MessageBox.Show("You are not connected to a server");
            else
            {
                stream = client.GetStream(); // Open data link with server
                byte[] name = Encoding.ASCII.GetBytes(txtMessage.Text); // Get message text
                stream.Write(name, 0, name.Length);
                stream.Flush();
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            lstChatFeed.Items.Clear();
        }
    }
}
