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
using Microsoft.VisualBasic;

namespace KostasExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDrive.DropDownStyle = ComboBoxStyle.DropDownList;
            GetDrives();
        }
        bool sorted = false;
        bool sortchanged = false;

        private void GetDrives()
        {
            //simple way
            //cmbDrive.DataSource = Environment.GetLogicalDrives();

            //harder way
            foreach (var item in DriveInfo.GetDrives())
            {
                cmbDrive.Items.Add(item.Name);
            }
        }

        private void cmbDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
            button1.Enabled = true;
            btnNewFolder.Enabled = true;
            btnDelete.Enabled = true;
            DriveInfo drive = new DriveInfo(cmbDrive.Text);
            if (!drive.IsReady)
            {
                MessageBox.Show("Drive not ready", "An Error Occured");
                return;
            }
            lblStatus2.Text = string.Format("Free Space: {0} GB Total Size: {1} GB", Math.Round((drive.AvailableFreeSpace / 1024 / 1024 / 1024f), 2), Math.Round((drive.TotalSize / 1024 / 1024 / 1024f), 2));
            lblStatus1.Text = cmbDrive.Text;
            ListFolder(drive.Name);
        }

        private void ListFolder(string path)
        {
            lstBrowser.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileSystemInfo[] allItems = dir.GetFileSystemInfos(); ;
            if (sorted)
            {
                allItems = allItems.OrderByDescending(x => x.LastWriteTime).ToArray();
            }
            else allItems = allItems.OrderByDescending(x => x.Name).ToArray();

            foreach (var item in allItems)
            {
                if (item.Attributes.HasFlag(FileAttributes.Hidden) || item.Attributes.HasFlag(FileAttributes.System))
                {
                    continue;
                }

                OneItem one = new OneItem();
                one.Name = item.Name;
                one.FullName = item.FullName;
                one.DateModified = item.LastWriteTime;
                one.Type = item.Attributes;

                lstBrowser.Items.Add(one);
            }
            lblStatus1.Text = dir.FullName;
        }

        private void lstBrowser_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush;
            OneItem one;
            if (e.Index == -1) return;
            if (e.State == DrawItemState.Checked)
            {
                myBrush = SystemBrushes.HighlightText;
            }

            else
            {
                myBrush = SystemBrushes.WindowText;
            }
            e.DrawBackground();
            one = lstBrowser.Items[e.Index] as OneItem;
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.EllipsisCharacter;//...


            //draw data
            e.Graphics.DrawString(one.Name, e.Font, myBrush, new Rectangle(0, e.Bounds.Top, lblDate.Left - lblName.Left, e.Bounds.Height), format);
            e.Graphics.DrawString(one.DateModified.ToString(), e.Font, myBrush, lblDate.Left - lstBrowser.Left, e.Bounds.Top);
            e.Graphics.DrawString(one.Type.ToString(), e.Font, myBrush, lblType.Left - lstBrowser.Left, e.Bounds.Top);
        }

        private void lstBrowser_DoubleClick(object sender, EventArgs e)
        {
            if (lstBrowser.SelectedIndex == -1) return;

            var item = lstBrowser.SelectedItem as OneItem;

            if (item.Type.HasFlag(FileAttributes.Directory))
            {
                lblStatus1.Text = item.FullName;
                ListFolder(item.FullName);
                btnBack.Enabled = true;
                lblStatus2.Text = string.Empty;
            }

            else if (item.Type.HasFlag(FileAttributes.Archive))
            {
                System.Diagnostics.Process.Start(item.FullName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parent = (new DirectoryInfo(lblStatus1.Text)).Parent;
            if (parent.FullName == cmbDrive.Text) btnBack.Enabled = false;
            ListFolder(parent.FullName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sortchanged) btnSort.Text = "Sort by Date";

            else btnSort.Text = "Sort by Name";

            sorted = !sorted;
            sortchanged = !sortchanged;
            ListFolder(lblStatus1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lstBrowser.SelectedItem as OneItem;
            if (lstBrowser.SelectedIndex != -1)
            {
                System.Diagnostics.Process.Start(item.FullName);
            }
            else System.Diagnostics.Process.Start(lblStatus1.Text);

        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            string rez = Interaction.InputBox("Create a name for your folder", "New Folder Creation", "New Folder");
            if (rez != string.Empty)
            {
                int count = new DirectoryInfo(lblStatus1.Text).GetFileSystemInfos("New Folder*").Length;
                if (count == 0)
                {
                    Directory.CreateDirectory(lblStatus1.Text + @"\" + rez);
                }
                else Directory.CreateDirectory(lblStatus1.Text + @"\" + rez + " " + count);

                ListFolder(lblStatus1.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var item = lstBrowser.SelectedItem as OneItem;
            Directory.Delete(item.FullName);
            ListFolder(lblStatus1.Text);
        }
    }
}
