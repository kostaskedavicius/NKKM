using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using System.Threading;

namespace ConsoleSocketServer
{
    class Program
    {
        static Hashtable clientlist = new Hashtable(); // Storage

        public static void Broadcast(string msg, string name)
        {
            foreach (DictionaryEntry item in clientlist)
            {
                TcpClient client = (TcpClient)item.Value; // Getting user IP and Port
                if (!client.Connected)
                {
                    client.Close();
                    break;
                }
                byte[] BytesToSend = null; // Creating byte array
                BytesToSend = Encoding.ASCII.GetBytes(name + " says:" + msg);
                NetworkStream networkStream = client.GetStream(); // Open connection with client
                if (!client.Connected) break;
                networkStream.Write(BytesToSend, 0, BytesToSend.Length);
                networkStream.Flush(); // Close stream
            }
        }

        static void Main(string[] args)
        {
            var servsock = new TcpListener(IPAddress.Any, 1337); // Server Socket Listener
            var client = new TcpClient();
            servsock.Start(); // Start server
            Console.WriteLine("Server has started.");
            while (true)
            {
                client = servsock.AcceptTcpClient(); // Let client join
                if (!client.Connected)
                {
                    client.Close();
                    break;
                }
                byte[] data = new byte[1024];
                string DataFromClient = null;
                NetworkStream stream = client.GetStream();
                stream.Read(data, 0, data.Length); // Get data from client, size depends on msg size
                DataFromClient = Encoding.ASCII.GetString(data);
                DataFromClient = DataFromClient.Remove(DataFromClient.IndexOf('\0'));// Delete empty space
                stream.Flush();
                clientlist[DataFromClient] = client;
                Broadcast(DataFromClient + " has joined the chat", "Server"); // Notify all that a chat member has joined
                Console.WriteLine(DataFromClient + " has joined the chat", "Server"); // Display same info in console
                ManageClient newClient = new ManageClient(client, DataFromClient); // Create new client object
                newClient.StartChat();
                if (!client.Connected)
                {
                    client.Close();
                    Broadcast(DataFromClient + " has left the chat", "Server");
                    Console.WriteLine(DataFromClient + " has joined the chat", "Server"); // Display same info in console
                }
            }
            servsock.Stop();
            Console.WriteLine("Server Stopped");
        }
    }
    public class ManageClient
    {
        private TcpClient client;
        private string dataFromClient;

        public ManageClient(TcpClient client, string dataFromClient)
        {
            this.client = client;
            this.dataFromClient = dataFromClient;
        }

        public void StartChat()
        {
            new Thread(Chat).Start();
        }

        private void Chat()
        {
            while (true)
            {
                if (!client.Connected)
                {
                    client.Close();
                    break;
                }
                byte[] data = new byte[1024];
                string msg = null;
                NetworkStream stream = client.GetStream();
                stream.Read(data, 0, data.Length); // Get data from client, size depends on msg size
                msg = Encoding.ASCII.GetString(data);
                msg = msg.Remove(msg.IndexOf('\0'));// Delete empty space
                Program.Broadcast(msg, this.dataFromClient);
                stream.Flush();
            }
        }
    }
}
