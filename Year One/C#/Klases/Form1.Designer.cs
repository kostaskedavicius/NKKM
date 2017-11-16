namespace Klases
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.combolist = new System.Windows.Forms.ComboBox();
            this.groupguests = new System.Windows.Forms.GroupBox();
            this.btnPrizes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listguests = new System.Windows.Forms.ListBox();
            this.groupguests.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(1, 39);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(103, 20);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(129, 39);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(78, 53);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Use calculator";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(229, 39);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(103, 20);
            this.txtSecond.TabIndex = 8;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            // 
            // combolist
            // 
            this.combolist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combolist.FormattingEnabled = true;
            this.combolist.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.combolist.Location = new System.Drawing.Point(100, 12);
            this.combolist.Name = "combolist";
            this.combolist.Size = new System.Drawing.Size(132, 21);
            this.combolist.TabIndex = 9;
            // 
            // groupguests
            // 
            this.groupguests.Controls.Add(this.listView1);
            this.groupguests.Controls.Add(this.btnPrizes);
            this.groupguests.Controls.Add(this.label4);
            this.groupguests.Controls.Add(this.listguests);
            this.groupguests.Controls.Add(this.btnreg);
            this.groupguests.Controls.Add(this.txtcomp);
            this.groupguests.Controls.Add(this.label3);
            this.groupguests.Controls.Add(this.txtlastname);
            this.groupguests.Controls.Add(this.label2);
            this.groupguests.Controls.Add(this.txtname);
            this.groupguests.Controls.Add(this.label1);
            this.groupguests.Location = new System.Drawing.Point(12, 122);
            this.groupguests.Name = "groupguests";
            this.groupguests.Size = new System.Drawing.Size(314, 267);
            this.groupguests.TabIndex = 10;
            this.groupguests.TabStop = false;
            this.groupguests.Text = "Guest Registration";
            // 
            // btnPrizes
            // 
            this.btnPrizes.Location = new System.Drawing.Point(21, 209);
            this.btnPrizes.Name = "btnPrizes";
            this.btnPrizes.Size = new System.Drawing.Size(100, 48);
            this.btnPrizes.TabIndex = 9;
            this.btnPrizes.Text = "Win a prize!";
            this.btnPrizes.UseVisualStyleBackColor = true;
            this.btnPrizes.Click += new System.EventHandler(this.btnPrizes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Guests";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(21, 157);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(100, 48);
            this.btnreg.TabIndex = 6;
            this.btnreg.Text = "Add to list";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(21, 131);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcomp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(21, 92);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(21, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(150, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 111);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listguests
            // 
            this.listguests.FormattingEnabled = true;
            this.listguests.Location = new System.Drawing.Point(150, 45);
            this.listguests.Name = "listguests";
            this.listguests.Size = new System.Drawing.Size(158, 95);
            this.listguests.TabIndex = 7;
            this.listguests.DoubleClick += new System.EventHandler(this.listguests_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(338, 401);
            this.Controls.Add(this.groupguests);
            this.Controls.Add(this.combolist);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtFirst);
            this.Name = "Form1";
            this.Text = "This calculator sucks!";
            this.groupguests.ResumeLayout(false);
            this.groupguests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.ComboBox combolist;
        private System.Windows.Forms.GroupBox groupguests;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrizes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listguests;
    }
}

