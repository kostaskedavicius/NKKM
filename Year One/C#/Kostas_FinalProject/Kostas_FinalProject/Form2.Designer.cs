namespace Kostas_FinalProject
{
    partial class SettingsForm
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
            this.rbtn_TimerOn = new System.Windows.Forms.RadioButton();
            this.rbtn_TimerOff = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.rbtn_HintsOn = new System.Windows.Forms.RadioButton();
            this.rbtn_HintsOff = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_HealthShow = new System.Windows.Forms.RadioButton();
            this.rbtn_HealthHide = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_TimerOn
            // 
            this.rbtn_TimerOn.AutoSize = true;
            this.rbtn_TimerOn.Checked = true;
            this.rbtn_TimerOn.Enabled = false;
            this.rbtn_TimerOn.ForeColor = System.Drawing.Color.White;
            this.rbtn_TimerOn.Location = new System.Drawing.Point(6, 29);
            this.rbtn_TimerOn.Name = "rbtn_TimerOn";
            this.rbtn_TimerOn.Size = new System.Drawing.Size(50, 24);
            this.rbtn_TimerOn.TabIndex = 4;
            this.rbtn_TimerOn.TabStop = true;
            this.rbtn_TimerOn.Text = "On";
            this.rbtn_TimerOn.UseVisualStyleBackColor = true;
            this.rbtn_TimerOn.CheckedChanged += new System.EventHandler(this.rbtn_TimerOn_CheckedChanged);
            // 
            // rbtn_TimerOff
            // 
            this.rbtn_TimerOff.AutoSize = true;
            this.rbtn_TimerOff.ForeColor = System.Drawing.Color.White;
            this.rbtn_TimerOff.Location = new System.Drawing.Point(74, 29);
            this.rbtn_TimerOff.Name = "rbtn_TimerOff";
            this.rbtn_TimerOff.Size = new System.Drawing.Size(52, 24);
            this.rbtn_TimerOff.TabIndex = 5;
            this.rbtn_TimerOff.Text = "Off";
            this.rbtn_TimerOff.UseVisualStyleBackColor = true;
            this.rbtn_TimerOff.CheckedChanged += new System.EventHandler(this.rbtn_TimerOff_CheckedChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(115, 184);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 31);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // rbtn_HintsOn
            // 
            this.rbtn_HintsOn.AutoSize = true;
            this.rbtn_HintsOn.Checked = true;
            this.rbtn_HintsOn.Enabled = false;
            this.rbtn_HintsOn.ForeColor = System.Drawing.Color.White;
            this.rbtn_HintsOn.Location = new System.Drawing.Point(6, 25);
            this.rbtn_HintsOn.Name = "rbtn_HintsOn";
            this.rbtn_HintsOn.Size = new System.Drawing.Size(50, 24);
            this.rbtn_HintsOn.TabIndex = 8;
            this.rbtn_HintsOn.TabStop = true;
            this.rbtn_HintsOn.Text = "On";
            this.rbtn_HintsOn.UseVisualStyleBackColor = true;
            this.rbtn_HintsOn.CheckedChanged += new System.EventHandler(this.rbtn_HintsOn_CheckedChanged);
            // 
            // rbtn_HintsOff
            // 
            this.rbtn_HintsOff.AutoSize = true;
            this.rbtn_HintsOff.ForeColor = System.Drawing.Color.White;
            this.rbtn_HintsOff.Location = new System.Drawing.Point(74, 25);
            this.rbtn_HintsOff.Name = "rbtn_HintsOff";
            this.rbtn_HintsOff.Size = new System.Drawing.Size(52, 24);
            this.rbtn_HintsOff.TabIndex = 9;
            this.rbtn_HintsOff.Text = "Off";
            this.rbtn_HintsOff.UseVisualStyleBackColor = true;
            this.rbtn_HintsOff.CheckedChanged += new System.EventHandler(this.rbtn_HintsOff_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_TimerOn);
            this.groupBox1.Controls.Add(this.rbtn_TimerOff);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 67);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_HintsOn);
            this.groupBox2.Controls.Add(this.rbtn_HintsOff);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(150, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 67);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hints";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtn_HealthShow);
            this.groupBox3.Controls.Add(this.rbtn_HealthHide);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(75, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 72);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Health";
            // 
            // rbtn_HealthShow
            // 
            this.rbtn_HealthShow.AutoSize = true;
            this.rbtn_HealthShow.Checked = true;
            this.rbtn_HealthShow.Enabled = false;
            this.rbtn_HealthShow.ForeColor = System.Drawing.Color.White;
            this.rbtn_HealthShow.Location = new System.Drawing.Point(6, 29);
            this.rbtn_HealthShow.Name = "rbtn_HealthShow";
            this.rbtn_HealthShow.Size = new System.Drawing.Size(71, 24);
            this.rbtn_HealthShow.TabIndex = 4;
            this.rbtn_HealthShow.TabStop = true;
            this.rbtn_HealthShow.Text = "Show";
            this.rbtn_HealthShow.UseVisualStyleBackColor = true;
            this.rbtn_HealthShow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn_HealthHide
            // 
            this.rbtn_HealthHide.AutoSize = true;
            this.rbtn_HealthHide.ForeColor = System.Drawing.Color.White;
            this.rbtn_HealthHide.Location = new System.Drawing.Point(78, 29);
            this.rbtn_HealthHide.Name = "rbtn_HealthHide";
            this.rbtn_HealthHide.Size = new System.Drawing.Size(64, 24);
            this.rbtn_HealthHide.TabIndex = 5;
            this.rbtn_HealthHide.Text = "Hide";
            this.rbtn_HealthHide.UseVisualStyleBackColor = true;
            this.rbtn_HealthHide.CheckedChanged += new System.EventHandler(this.rbtn_HealthHide_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(304, 243);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ok);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.RadioButton rbtn_TimerOn;
        internal System.Windows.Forms.RadioButton rbtn_TimerOff;
        private System.Windows.Forms.Button btn_Ok;
        internal System.Windows.Forms.RadioButton rbtn_HintsOn;
        internal System.Windows.Forms.RadioButton rbtn_HintsOff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.RadioButton rbtn_HealthShow;
        internal System.Windows.Forms.RadioButton rbtn_HealthHide;
    }
}