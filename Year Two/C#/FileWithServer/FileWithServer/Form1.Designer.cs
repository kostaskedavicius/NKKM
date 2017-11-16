namespace FileWithServer
{
    partial class Form1
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblProg = new System.Windows.Forms.Label();
            this.progDone = new System.Windows.Forms.ProgressBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(12, 32);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(564, 26);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "http://";
            // 
            // txtMisc
            // 
            this.txtMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMisc.Location = new System.Drawing.Point(12, 64);
            this.txtMisc.Multiline = true;
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(564, 377);
            this.txtMisc.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(253, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // btnString
            // 
            this.btnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnString.ForeColor = System.Drawing.Color.Black;
            this.btnString.Location = new System.Drawing.Point(12, 447);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(136, 50);
            this.btnString.TabIndex = 3;
            this.btnString.Text = "Download String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(440, 447);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(136, 50);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "Download File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.ForeColor = System.Drawing.Color.White;
            this.lblProg.Location = new System.Drawing.Point(8, 9);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(128, 20);
            this.lblProg.TabIndex = 5;
            this.lblProg.Text = "Downloaded: 0";
            // 
            // progDone
            // 
            this.progDone.Location = new System.Drawing.Point(154, 460);
            this.progDone.Name = "progDone";
            this.progDone.Size = new System.Drawing.Size(280, 23);
            this.progDone.TabIndex = 6;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(436, 9);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(81, 20);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Speed: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 507);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.progDone);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtMisc);
            this.Controls.Add(this.txtAddress);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Or Page String Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.ProgressBar progDone;
        private System.Windows.Forms.Label lblSpeed;
    }
}

