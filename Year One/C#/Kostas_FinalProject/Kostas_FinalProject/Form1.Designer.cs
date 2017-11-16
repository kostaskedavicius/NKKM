namespace Kostas_FinalProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnyHint1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHint2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHint3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHint4 = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHealth2 = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblTimerMin1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.restarToolStripMenuItem,
            this.bbToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.hintToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aaToolStripMenuItem.Text = "Settings";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
            // 
            // restarToolStripMenuItem
            // 
            this.restarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.restarToolStripMenuItem.Name = "restarToolStripMenuItem";
            this.restarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.restarToolStripMenuItem.Text = "Restart";
            this.restarToolStripMenuItem.Click += new System.EventHandler(this.restarToolStripMenuItem_Click);
            // 
            // bbToolStripMenuItem
            // 
            this.bbToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bbToolStripMenuItem.Name = "bbToolStripMenuItem";
            this.bbToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.bbToolStripMenuItem.Text = "Credits";
            this.bbToolStripMenuItem.Click += new System.EventHandler(this.bbToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnyHint1,
            this.mnuHint2,
            this.mnuHint3,
            this.mnuHint4});
            this.hintToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.hintToolStripMenuItem.Text = "Hint";
            // 
            // mnyHint1
            // 
            this.mnyHint1.Name = "mnyHint1";
            this.mnyHint1.Size = new System.Drawing.Size(110, 22);
            this.mnyHint1.Text = "Hint#1";
            this.mnyHint1.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnuHint2
            // 
            this.mnuHint2.Name = "mnuHint2";
            this.mnuHint2.Size = new System.Drawing.Size(110, 22);
            this.mnuHint2.Text = "Hint#2";
            this.mnuHint2.Visible = false;
            this.mnuHint2.Click += new System.EventHandler(this.mnuHint2_Click);
            // 
            // mnuHint3
            // 
            this.mnuHint3.Name = "mnuHint3";
            this.mnuHint3.Size = new System.Drawing.Size(110, 22);
            this.mnuHint3.Text = "Hint#3";
            this.mnuHint3.Visible = false;
            // 
            // mnuHint4
            // 
            this.mnuHint4.Name = "mnuHint4";
            this.mnuHint4.Size = new System.Drawing.Size(110, 22);
            this.mnuHint4.Text = "Hint#4";
            this.mnuHint4.Visible = false;
            this.mnuHint4.Click += new System.EventHandler(this.mnuHint4_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.label1);
            this.pnl_Main.Controls.Add(this.button1);
            this.pnl_Main.Location = new System.Drawing.Point(13, 45);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(790, 311);
            this.pnl_Main.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "If you are restarting the game, check the settings.";
            // 
            // lblHealth2
            // 
            this.lblHealth2.AutoSize = true;
            this.lblHealth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth2.ForeColor = System.Drawing.Color.White;
            this.lblHealth2.Location = new System.Drawing.Point(599, 9);
            this.lblHealth2.Name = "lblHealth2";
            this.lblHealth2.Size = new System.Drawing.Size(60, 20);
            this.lblHealth2.TabIndex = 9;
            this.lblHealth2.Text = "Health:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(665, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(18, 20);
            this.lblHealth.TabIndex = 10;
            this.lblHealth.Text = "0";
            // 
            // lblTimerMin1
            // 
            this.lblTimerMin1.AutoSize = true;
            this.lblTimerMin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerMin1.ForeColor = System.Drawing.Color.White;
            this.lblTimerMin1.Location = new System.Drawing.Point(770, 9);
            this.lblTimerMin1.Name = "lblTimerMin1";
            this.lblTimerMin1.Size = new System.Drawing.Size(18, 20);
            this.lblTimerMin1.TabIndex = 12;
            this.lblTimerMin1.Text = "0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(712, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(52, 20);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Timer:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(815, 368);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerMin1);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblHealth2);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Escape!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem hintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnyHint1;
        private System.Windows.Forms.ToolStripMenuItem mnuHint2;
        private System.Windows.Forms.ToolStripMenuItem mnuHint3;
        private System.Windows.Forms.ToolStripMenuItem mnuHint4;
        private System.Windows.Forms.Panel pnl_Main;
        internal System.Windows.Forms.Label lblHealth2;
        internal System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimerMin1;
        internal System.Windows.Forms.Label lblTimer;
    }
}

