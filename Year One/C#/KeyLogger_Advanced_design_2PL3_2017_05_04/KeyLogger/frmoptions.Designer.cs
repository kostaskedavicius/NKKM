﻿namespace KeyLogger
{
    partial class Frmoptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_autoemailer = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emailAddress = new System.Windows.Forms.TextBox();
            this.txt_emailpassword = new System.Windows.Forms.TextBox();
            this.txt_smtpport = new System.Windows.Forms.TextBox();
            this.txt_smtpServer = new System.Windows.Forms.TextBox();
            this.pnl_emailer = new System.Windows.Forms.Panel();
            this.chk_usessl = new System.Windows.Forms.CheckBox();
            this.numeric_emailtime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_saver = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_savetimer = new System.Windows.Forms.NumericUpDown();
            this.txt_filelocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_brwose = new System.Windows.Forms.Button();
            this.chk_autosaver = new System.Windows.Forms.CheckBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnl_Screenshot = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.num_Screenshot = new System.Windows.Forms.NumericUpDown();
            this.txt_ScreenshotLocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnScreenshotBrowse = new System.Windows.Forms.Button();
            this.chk_Screenshot = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnl_record = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.num_FPS = new System.Windows.Forms.NumericUpDown();
            this.txt_recordLocation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_RecordBrowse = new System.Windows.Forms.Button();
            this.chk_record = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_Codec = new System.Windows.Forms.ComboBox();
            this.cmb_Bitrate = new System.Windows.Forms.ComboBox();
            this.pnl_emailer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_emailtime)).BeginInit();
            this.pnl_saver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_savetimer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl_Screenshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Screenshot)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.pnl_record.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FPS)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_autoemailer
            // 
            this.chk_autoemailer.AutoSize = true;
            this.chk_autoemailer.Location = new System.Drawing.Point(15, 11);
            this.chk_autoemailer.Name = "chk_autoemailer";
            this.chk_autoemailer.Size = new System.Drawing.Size(176, 17);
            this.chk_autoemailer.TabIndex = 0;
            this.chk_autoemailer.Text = "Automatically email result log file";
            this.chk_autoemailer.UseVisualStyleBackColor = true;
            this.chk_autoemailer.CheckedChanged += new System.EventHandler(this.chk_autoemailer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SMTP Server :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SMTP Port number :";
            // 
            // txt_emailAddress
            // 
            this.txt_emailAddress.Location = new System.Drawing.Point(114, 11);
            this.txt_emailAddress.Name = "txt_emailAddress";
            this.txt_emailAddress.Size = new System.Drawing.Size(147, 20);
            this.txt_emailAddress.TabIndex = 5;
            // 
            // txt_emailpassword
            // 
            this.txt_emailpassword.Location = new System.Drawing.Point(114, 37);
            this.txt_emailpassword.Name = "txt_emailpassword";
            this.txt_emailpassword.PasswordChar = '|';
            this.txt_emailpassword.Size = new System.Drawing.Size(147, 20);
            this.txt_emailpassword.TabIndex = 6;
            // 
            // txt_smtpport
            // 
            this.txt_smtpport.Location = new System.Drawing.Point(114, 88);
            this.txt_smtpport.Name = "txt_smtpport";
            this.txt_smtpport.Size = new System.Drawing.Size(33, 20);
            this.txt_smtpport.TabIndex = 8;
            this.txt_smtpport.Text = "465";
            // 
            // txt_smtpServer
            // 
            this.txt_smtpServer.Location = new System.Drawing.Point(114, 63);
            this.txt_smtpServer.Name = "txt_smtpServer";
            this.txt_smtpServer.Size = new System.Drawing.Size(147, 20);
            this.txt_smtpServer.TabIndex = 7;
            this.txt_smtpServer.Text = "smtp.gmail.com";
            // 
            // pnl_emailer
            // 
            this.pnl_emailer.Controls.Add(this.chk_usessl);
            this.pnl_emailer.Controls.Add(this.label1);
            this.pnl_emailer.Controls.Add(this.numeric_emailtime);
            this.pnl_emailer.Controls.Add(this.label4);
            this.pnl_emailer.Controls.Add(this.label6);
            this.pnl_emailer.Controls.Add(this.txt_emailAddress);
            this.pnl_emailer.Controls.Add(this.label5);
            this.pnl_emailer.Controls.Add(this.label3);
            this.pnl_emailer.Controls.Add(this.txt_emailpassword);
            this.pnl_emailer.Controls.Add(this.txt_smtpport);
            this.pnl_emailer.Controls.Add(this.label2);
            this.pnl_emailer.Controls.Add(this.txt_smtpServer);
            this.pnl_emailer.Enabled = false;
            this.pnl_emailer.Location = new System.Drawing.Point(7, 34);
            this.pnl_emailer.Name = "pnl_emailer";
            this.pnl_emailer.Size = new System.Drawing.Size(313, 156);
            this.pnl_emailer.TabIndex = 12;
            // 
            // chk_usessl
            // 
            this.chk_usessl.AutoSize = true;
            this.chk_usessl.Checked = true;
            this.chk_usessl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_usessl.Location = new System.Drawing.Point(156, 90);
            this.chk_usessl.Name = "chk_usessl";
            this.chk_usessl.Size = new System.Drawing.Size(46, 17);
            this.chk_usessl.TabIndex = 12;
            this.chk_usessl.Text = "SSL";
            this.chk_usessl.UseVisualStyleBackColor = true;
            // 
            // numeric_emailtime
            // 
            this.numeric_emailtime.Location = new System.Drawing.Point(114, 114);
            this.numeric_emailtime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numeric_emailtime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_emailtime.Name = "numeric_emailtime";
            this.numeric_emailtime.Size = new System.Drawing.Size(47, 20);
            this.numeric_emailtime.TabIndex = 10;
            this.numeric_emailtime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "minutes ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Send Every ";
            // 
            // pnl_saver
            // 
            this.pnl_saver.Controls.Add(this.label7);
            this.pnl_saver.Controls.Add(this.numeric_savetimer);
            this.pnl_saver.Controls.Add(this.txt_filelocation);
            this.pnl_saver.Controls.Add(this.label8);
            this.pnl_saver.Controls.Add(this.label9);
            this.pnl_saver.Controls.Add(this.btn_brwose);
            this.pnl_saver.Enabled = false;
            this.pnl_saver.Location = new System.Drawing.Point(7, 33);
            this.pnl_saver.Name = "pnl_saver";
            this.pnl_saver.Size = new System.Drawing.Size(313, 98);
            this.pnl_saver.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "file Location :";
            // 
            // numeric_savetimer
            // 
            this.numeric_savetimer.Location = new System.Drawing.Point(147, 52);
            this.numeric_savetimer.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numeric_savetimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_savetimer.Name = "numeric_savetimer";
            this.numeric_savetimer.Size = new System.Drawing.Size(47, 20);
            this.numeric_savetimer.TabIndex = 13;
            this.numeric_savetimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_filelocation
            // 
            this.txt_filelocation.Location = new System.Drawing.Point(91, 11);
            this.txt_filelocation.Name = "txt_filelocation";
            this.txt_filelocation.ReadOnly = true;
            this.txt_filelocation.Size = new System.Drawing.Size(174, 20);
            this.txt_filelocation.TabIndex = 11;
            this.txt_filelocation.Text = "Activitylog.docx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "minutes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Save Every";
            // 
            // btn_brwose
            // 
            this.btn_brwose.Location = new System.Drawing.Point(271, 9);
            this.btn_brwose.Name = "btn_brwose";
            this.btn_brwose.Size = new System.Drawing.Size(31, 23);
            this.btn_brwose.TabIndex = 12;
            this.btn_brwose.Text = "...";
            this.btn_brwose.UseVisualStyleBackColor = true;
            this.btn_brwose.Click += new System.EventHandler(this.btn_brwose_Click);
            // 
            // chk_autosaver
            // 
            this.chk_autosaver.AutoSize = true;
            this.chk_autosaver.Location = new System.Drawing.Point(13, 10);
            this.chk_autosaver.Name = "chk_autosaver";
            this.chk_autosaver.Size = new System.Drawing.Size(188, 17);
            this.chk_autosaver.TabIndex = 9;
            this.chk_autosaver.Text = "Automatically save result to the file";
            this.chk_autosaver.UseVisualStyleBackColor = true;
            this.chk_autosaver.CheckedChanged += new System.EventHandler(this.chk_autosaver_CheckedChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Location = new System.Drawing.Point(237, 243);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(108, 23);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(10, 243);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(10, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 222);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl_emailer);
            this.tabPage1.Controls.Add(this.chk_autoemailer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnl_saver);
            this.tabPage2.Controls.Add(this.chk_autosaver);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Save to file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnl_Screenshot);
            this.tabPage3.Controls.Add(this.chk_Screenshot);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(327, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Screenshot";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnl_Screenshot
            // 
            this.pnl_Screenshot.Controls.Add(this.label10);
            this.pnl_Screenshot.Controls.Add(this.num_Screenshot);
            this.pnl_Screenshot.Controls.Add(this.txt_ScreenshotLocation);
            this.pnl_Screenshot.Controls.Add(this.label11);
            this.pnl_Screenshot.Controls.Add(this.label12);
            this.pnl_Screenshot.Controls.Add(this.btnScreenshotBrowse);
            this.pnl_Screenshot.Enabled = false;
            this.pnl_Screenshot.Location = new System.Drawing.Point(10, 39);
            this.pnl_Screenshot.Name = "pnl_Screenshot";
            this.pnl_Screenshot.Size = new System.Drawing.Size(309, 98);
            this.pnl_Screenshot.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "file Location :";
            // 
            // num_Screenshot
            // 
            this.num_Screenshot.Location = new System.Drawing.Point(147, 52);
            this.num_Screenshot.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_Screenshot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Screenshot.Name = "num_Screenshot";
            this.num_Screenshot.Size = new System.Drawing.Size(47, 20);
            this.num_Screenshot.TabIndex = 13;
            this.num_Screenshot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_ScreenshotLocation
            // 
            this.txt_ScreenshotLocation.Location = new System.Drawing.Point(91, 11);
            this.txt_ScreenshotLocation.Name = "txt_ScreenshotLocation";
            this.txt_ScreenshotLocation.ReadOnly = true;
            this.txt_ScreenshotLocation.Size = new System.Drawing.Size(174, 20);
            this.txt_ScreenshotLocation.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(200, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "minutes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Save Every";
            // 
            // btnScreenshotBrowse
            // 
            this.btnScreenshotBrowse.Location = new System.Drawing.Point(271, 9);
            this.btnScreenshotBrowse.Name = "btnScreenshotBrowse";
            this.btnScreenshotBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnScreenshotBrowse.TabIndex = 12;
            this.btnScreenshotBrowse.Text = "...";
            this.btnScreenshotBrowse.UseVisualStyleBackColor = true;
            this.btnScreenshotBrowse.Click += new System.EventHandler(this.btnScreenshotBrowse_Click);
            // 
            // chk_Screenshot
            // 
            this.chk_Screenshot.AutoSize = true;
            this.chk_Screenshot.Location = new System.Drawing.Point(10, 16);
            this.chk_Screenshot.Name = "chk_Screenshot";
            this.chk_Screenshot.Size = new System.Drawing.Size(188, 17);
            this.chk_Screenshot.TabIndex = 16;
            this.chk_Screenshot.Text = "Automatically save result to the file";
            this.chk_Screenshot.UseVisualStyleBackColor = true;
            this.chk_Screenshot.CheckedChanged += new System.EventHandler(this.chk_Screenshot_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pnl_record);
            this.tabPage4.Controls.Add(this.chk_record);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(327, 196);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Video";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnl_record
            // 
            this.pnl_record.Controls.Add(this.cmb_Bitrate);
            this.pnl_record.Controls.Add(this.cmb_Codec);
            this.pnl_record.Controls.Add(this.label17);
            this.pnl_record.Controls.Add(this.label16);
            this.pnl_record.Controls.Add(this.label13);
            this.pnl_record.Controls.Add(this.num_FPS);
            this.pnl_record.Controls.Add(this.txt_recordLocation);
            this.pnl_record.Controls.Add(this.label15);
            this.pnl_record.Controls.Add(this.btn_RecordBrowse);
            this.pnl_record.Enabled = false;
            this.pnl_record.Location = new System.Drawing.Point(11, 35);
            this.pnl_record.Name = "pnl_record";
            this.pnl_record.Size = new System.Drawing.Size(309, 122);
            this.pnl_record.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "file Location :";
            // 
            // num_FPS
            // 
            this.num_FPS.Location = new System.Drawing.Point(91, 93);
            this.num_FPS.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_FPS.Name = "num_FPS";
            this.num_FPS.Size = new System.Drawing.Size(47, 20);
            this.num_FPS.TabIndex = 13;
            this.num_FPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_recordLocation
            // 
            this.txt_recordLocation.Location = new System.Drawing.Point(91, 11);
            this.txt_recordLocation.Name = "txt_recordLocation";
            this.txt_recordLocation.ReadOnly = true;
            this.txt_recordLocation.Size = new System.Drawing.Size(174, 20);
            this.txt_recordLocation.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "FPS";
            // 
            // btn_RecordBrowse
            // 
            this.btn_RecordBrowse.Location = new System.Drawing.Point(271, 9);
            this.btn_RecordBrowse.Name = "btn_RecordBrowse";
            this.btn_RecordBrowse.Size = new System.Drawing.Size(31, 23);
            this.btn_RecordBrowse.TabIndex = 12;
            this.btn_RecordBrowse.Text = "...";
            this.btn_RecordBrowse.UseVisualStyleBackColor = true;
            this.btn_RecordBrowse.Click += new System.EventHandler(this.btn_RecordBrowse_Click);
            // 
            // chk_record
            // 
            this.chk_record.AutoSize = true;
            this.chk_record.Location = new System.Drawing.Point(15, 11);
            this.chk_record.Name = "chk_record";
            this.chk_record.Size = new System.Drawing.Size(188, 17);
            this.chk_record.TabIndex = 18;
            this.chk_record.Text = "Automatically save result to the file";
            this.chk_record.UseVisualStyleBackColor = true;
            this.chk_record.CheckedChanged += new System.EventHandler(this.chk_record_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Codec:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Bitrate:";
            // 
            // cmb_Codec
            // 
            this.cmb_Codec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Codec.FormattingEnabled = true;
            this.cmb_Codec.Location = new System.Drawing.Point(91, 39);
            this.cmb_Codec.Name = "cmb_Codec";
            this.cmb_Codec.Size = new System.Drawing.Size(174, 21);
            this.cmb_Codec.TabIndex = 17;
            // 
            // cmb_Bitrate
            // 
            this.cmb_Bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bitrate.FormattingEnabled = true;
            this.cmb_Bitrate.Location = new System.Drawing.Point(91, 67);
            this.cmb_Bitrate.Name = "cmb_Bitrate";
            this.cmb_Bitrate.Size = new System.Drawing.Size(174, 21);
            this.cmb_Bitrate.TabIndex = 18;
            // 
            // Frmoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 278);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmoptions";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.pnl_emailer.ResumeLayout(false);
            this.pnl_emailer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_emailtime)).EndInit();
            this.pnl_saver.ResumeLayout(false);
            this.pnl_saver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_savetimer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnl_Screenshot.ResumeLayout(false);
            this.pnl_Screenshot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Screenshot)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.pnl_record.ResumeLayout(false);
            this.pnl_record.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_FPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.CheckBox chk_autoemailer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_emailAddress;
        internal System.Windows.Forms.TextBox txt_emailpassword;
        internal System.Windows.Forms.TextBox txt_smtpport;
        internal System.Windows.Forms.TextBox txt_smtpServer;
        internal System.Windows.Forms.CheckBox chk_autosaver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.NumericUpDown numeric_emailtime;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.NumericUpDown numeric_savetimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_brwose;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txt_filelocation;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel pnl_emailer;
        private System.Windows.Forms.Panel pnl_saver;
        internal System.Windows.Forms.CheckBox chk_usessl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnl_Screenshot;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.NumericUpDown num_Screenshot;
        internal System.Windows.Forms.TextBox txt_ScreenshotLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnScreenshotBrowse;
        internal System.Windows.Forms.CheckBox chk_Screenshot;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel pnl_record;
        internal System.Windows.Forms.ComboBox cmb_Bitrate;
        internal System.Windows.Forms.ComboBox cmb_Codec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.NumericUpDown num_FPS;
        internal System.Windows.Forms.TextBox txt_recordLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_RecordBrowse;
        internal System.Windows.Forms.CheckBox chk_record;
    }
}