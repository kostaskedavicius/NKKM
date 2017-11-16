namespace Dar_vienas_dinamis_tipas_04
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
            this.btnarraylist = new System.Windows.Forms.Button();
            this.listarray = new System.Windows.Forms.ListBox();
            this.btnsumnumbers = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnarraylist
            // 
            this.btnarraylist.BackColor = System.Drawing.Color.White;
            this.btnarraylist.Location = new System.Drawing.Point(12, 12);
            this.btnarraylist.Name = "btnarraylist";
            this.btnarraylist.Size = new System.Drawing.Size(104, 52);
            this.btnarraylist.TabIndex = 0;
            this.btnarraylist.Text = "Click me!";
            this.btnarraylist.UseVisualStyleBackColor = false;
            this.btnarraylist.Click += new System.EventHandler(this.btnarraylist_Click);
            // 
            // listarray
            // 
            this.listarray.FormattingEnabled = true;
            this.listarray.Location = new System.Drawing.Point(12, 97);
            this.listarray.Name = "listarray";
            this.listarray.Size = new System.Drawing.Size(296, 121);
            this.listarray.TabIndex = 1;
            // 
            // btnsumnumbers
            // 
            this.btnsumnumbers.BackColor = System.Drawing.Color.White;
            this.btnsumnumbers.Location = new System.Drawing.Point(204, 12);
            this.btnsumnumbers.Name = "btnsumnumbers";
            this.btnsumnumbers.Size = new System.Drawing.Size(104, 52);
            this.btnsumnumbers.TabIndex = 2;
            this.btnsumnumbers.Text = "Click me too!";
            this.btnsumnumbers.UseVisualStyleBackColor = false;
            this.btnsumnumbers.Click += new System.EventHandler(this.btnsumnumbers_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.BackColor = System.Drawing.Color.White;
            this.btnDictionary.Location = new System.Drawing.Point(102, 268);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(109, 61);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Click me to open new form";
            this.btnDictionary.UseVisualStyleBackColor = false;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 52);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(320, 358);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnsumnumbers);
            this.Controls.Add(this.listarray);
            this.Controls.Add(this.btnarraylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnarraylist;
        private System.Windows.Forms.ListBox listarray;
        private System.Windows.Forms.Button btnsumnumbers;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnClose;
    }
}

