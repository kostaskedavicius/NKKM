namespace ReadingWritingFile
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
            this.btnFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnFileStream = new System.Windows.Forms.Button();
            this.btnReadFileStream = new System.Windows.Forms.Button();
            this.btnWriteFileStream = new System.Windows.Forms.Button();
            this.btnReadFileStram2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 300);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(93, 43);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "ReadFile";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(594, 233);
            this.textBox1.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "TextFiles|*.txt";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(10, 251);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(95, 43);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "WriteFile";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnFileStream
            // 
            this.btnFileStream.Location = new System.Drawing.Point(111, 251);
            this.btnFileStream.Name = "btnFileStream";
            this.btnFileStream.Size = new System.Drawing.Size(95, 43);
            this.btnFileStream.TabIndex = 3;
            this.btnFileStream.Text = "WriteFileStream";
            this.btnFileStream.UseVisualStyleBackColor = true;
            this.btnFileStream.Click += new System.EventHandler(this.btnFileStream_Click);
            // 
            // btnReadFileStream
            // 
            this.btnReadFileStream.Location = new System.Drawing.Point(111, 300);
            this.btnReadFileStream.Name = "btnReadFileStream";
            this.btnReadFileStream.Size = new System.Drawing.Size(95, 43);
            this.btnReadFileStream.TabIndex = 4;
            this.btnReadFileStream.Text = "ReadFileStream";
            this.btnReadFileStream.UseVisualStyleBackColor = true;
            this.btnReadFileStream.Click += new System.EventHandler(this.btnReadFileStream_Click);
            // 
            // btnWriteFileStream
            // 
            this.btnWriteFileStream.Location = new System.Drawing.Point(212, 251);
            this.btnWriteFileStream.Name = "btnWriteFileStream";
            this.btnWriteFileStream.Size = new System.Drawing.Size(105, 43);
            this.btnWriteFileStream.TabIndex = 5;
            this.btnWriteFileStream.Text = "WriteFileStream2";
            this.btnWriteFileStream.UseVisualStyleBackColor = true;
            this.btnWriteFileStream.Click += new System.EventHandler(this.btnWriteFileStream_Click);
            // 
            // btnReadFileStram2
            // 
            this.btnReadFileStram2.Location = new System.Drawing.Point(212, 300);
            this.btnReadFileStram2.Name = "btnReadFileStram2";
            this.btnReadFileStram2.Size = new System.Drawing.Size(105, 43);
            this.btnReadFileStram2.TabIndex = 6;
            this.btnReadFileStram2.Text = "ReadFileStream2";
            this.btnReadFileStram2.UseVisualStyleBackColor = true;
            this.btnReadFileStram2.Click += new System.EventHandler(this.btnReadFileStram2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.btnReadFileStram2);
            this.Controls.Add(this.btnWriteFileStream);
            this.Controls.Add(this.btnReadFileStream);
            this.Controls.Add(this.btnFileStream);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnFileStream;
        private System.Windows.Forms.Button btnReadFileStream;
        private System.Windows.Forms.Button btnWriteFileStream;
        private System.Windows.Forms.Button btnReadFileStram2;
    }
}

