using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadingWritingFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\TestFile.txt";

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                textBox1.Text = File.ReadAllText(path);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //check if file exists
            if (!File.Exists(desktop))
            {
                File.Create(desktop).Close();
            }
            //write data to file
            File.WriteAllText(desktop, textBox1.Text);
        }

        private void btnFileStream_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(desktop);
            writer.Write(textBox1.Text);
            writer.Close();
        }

        private void btnReadFileStream_Click(object sender, EventArgs e)
        {

            if (File.Exists(desktop))
            {
                StreamReader reader = new StreamReader(desktop);

                //             while (!reader.EndOfStream)
                //               {
                //                   textBox1.AppendText(reader.ReadLine() + "\n");
                //                }
                while (!reader.EndOfStream)
                {
                    textBox1.Text = ((char)reader.Read()).ToString();
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void btnWriteFileStream_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(desktop, FileMode.Create, FileAccess.Write);
            byte[] outBytes = Encoding.UTF8.GetBytes(textBox1.Text);
            stream.Write(outBytes, 0, outBytes.Length);
            stream.Close();
        }

        private void btnReadFileStram2_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(desktop, FileMode.Open, FileAccess.Read);
            byte[] outBytes = new byte[stream.Length];
            stream.Read(outBytes, 0, outBytes.Length);
            textBox1.Text = Encoding.UTF8.GetString(outBytes);
            stream.Close();
        }
    }
}
