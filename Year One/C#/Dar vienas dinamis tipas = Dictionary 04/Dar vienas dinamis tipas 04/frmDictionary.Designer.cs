namespace Dar_vienas_dinamis_tipas_04
{
    partial class frmDictionary
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
            this.btnClose = new System.Windows.Forms.Button();
            this.liststudents = new System.Windows.Forms.ListBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnstdnumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(126, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 52);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // liststudents
            // 
            this.liststudents.FormattingEnabled = true;
            this.liststudents.Location = new System.Drawing.Point(13, 94);
            this.liststudents.Name = "liststudents";
            this.liststudents.Size = new System.Drawing.Size(300, 238);
            this.liststudents.TabIndex = 6;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(12, 12);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(75, 52);
            this.btnNewStudent.TabIndex = 7;
            this.btnNewStudent.Text = "Add new student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnstdnumb
            // 
            this.btnstdnumb.Location = new System.Drawing.Point(238, 12);
            this.btnstdnumb.Name = "btnstdnumb";
            this.btnstdnumb.Size = new System.Drawing.Size(75, 52);
            this.btnstdnumb.TabIndex = 8;
            this.btnstdnumb.Text = "View student number";
            this.btnstdnumb.UseVisualStyleBackColor = true;
            this.btnstdnumb.Click += new System.EventHandler(this.btnstdnumb_Click);
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(325, 341);
            this.Controls.Add(this.btnstdnumb);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.liststudents);
            this.Controls.Add(this.btnClose);
            this.Name = "frmDictionary";
            this.Text = "frmDictionary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox liststudents;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnstdnumb;
    }
}