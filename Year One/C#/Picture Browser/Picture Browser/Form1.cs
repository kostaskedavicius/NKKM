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
using System.Diagnostics;

namespace Picture_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> allPictures;
        int poz = 0;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // create folder browser dialog
            var fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder that contains pictures";
            fbd.ShowNewFolderButton = false;

            //show dialog
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = fbd.SelectedPath;

                //scan selected folder for pictures
                ScanFolder(fbd.SelectedPath);
            }
        }

        private void ScanFolder(string path)
        {
            //DirectoryInfo object to get info and files from folder
            var root = new DirectoryInfo(path);

            //create pciture list
            allPictures = new List<string>();
            poz = 0;
            picPrevious.Image = null;
            picCurrent.Image = null;
            picNext.Image = null;

            //get all picture files
            foreach (var item in root.GetFiles())
            {
                //select only jpg, jpeg, bmp, tiff, gif, png files
                switch (item.Extension)
                {
                    case ".jpg":
                    case ".png":
                    case ".gif":
                    case ".tif":
                    case ".bmp":
                    case ".jpeg":
                    case ".tiff":
                        allPictures.Add(item.FullName);
                        break;
                }
            }
            ShowPictures();
        }

        private void ShowPictures()
        {
            //check if picture list isn't empty
            if (allPictures.Count == 0)
            {
                MessageBox.Show("No picture detected", "An Error Occured");
                return;
            }
            //bad way
            //picCurrent.Image = Image.FromFile(allPictures[0]);

            //good way
            var img = new Image.GetThumbnailImageAbort(CallBack);

            //save thumbnail
            if (poz < allPictures.Count)
            {
                Bitmap currImg = new Bitmap(allPictures[poz]);
                picCurrent.Image = currImg.GetThumbnailImage(picCurrent.Width, picCurrent.Height, img, IntPtr.Zero);
            }

            //save next image thumbnail
            if (poz < allPictures.Count - 1)
            {
                Bitmap nextImg = new Bitmap(allPictures[poz + 1]);
                picNext.Image = nextImg.GetThumbnailImage(picNext.Width, picNext.Height, img, IntPtr.Zero);
            }

            //save previous image thumbnail
            if (poz > 0)
            {
                Bitmap prevImg = new Bitmap(allPictures[poz - 1]);
                picPrevious.Image = prevImg.GetThumbnailImage(picPrevious.Width, picPrevious.Height, img, IntPtr.Zero);
            }
        }

        private bool CallBack()
        {
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (allPictures != null && poz < allPictures.Count - 1)
            {
                poz++;
                if (poz == allPictures.Count - 1) picNext.Image = null;
                ShowPictures();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (allPictures != null && poz > 0)
            {
                poz--;
                if (poz == 0) picPrevious.Image = null;
                ShowPictures();
            }

        }
        private void picCurrent_DoubleClick(object sender, EventArgs e)
        {
            if (allPictures != null && allPictures.Count > 0)
            {
                Process.Start(allPictures[poz]);
            }
        }
    }
}
