namespace Antroji_cs_pamoka
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblInfoPass = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.txtSwap1 = new System.Windows.Forms.TextBox();
            this.txtSwap2 = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoEllipsis = true;
            this.lblInfoName.BackColor = System.Drawing.Color.LawnGreen;
            this.lblInfoName.Font = new System.Drawing.Font("Orator Std", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoName.ForeColor = System.Drawing.Color.White;
            this.lblInfoName.Location = new System.Drawing.Point(-7, 0);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(854, 334);
            this.lblInfoName.TabIndex = 1;
            this.lblInfoName.Text = "Enter your name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.AutoCompleteCustomSource.AddRange(new string[] {
            "Hello"});
            this.txtBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxName.BackColor = System.Drawing.Color.LawnGreen;
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxName.Font = new System.Drawing.Font("Orator Std", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.ForeColor = System.Drawing.Color.White;
            this.txtBoxName.Location = new System.Drawing.Point(3, 60);
            this.txtBoxName.MaxLength = 10;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(398, 52);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.AutoCompleteCustomSource.AddRange(new string[] {
            "Hello"});
            this.txtBoxPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxPass.BackColor = System.Drawing.Color.LawnGreen;
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPass.Font = new System.Drawing.Font("Orator Std", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPass.ForeColor = System.Drawing.Color.White;
            this.txtBoxPass.Location = new System.Drawing.Point(3, 199);
            this.txtBoxPass.MaxLength = 10;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(495, 52);
            this.txtBoxPass.TabIndex = 4;
            // 
            // lblInfoPass
            // 
            this.lblInfoPass.AutoEllipsis = true;
            this.lblInfoPass.BackColor = System.Drawing.Color.LawnGreen;
            this.lblInfoPass.Font = new System.Drawing.Font("Orator Std", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPass.ForeColor = System.Drawing.Color.White;
            this.lblInfoPass.Location = new System.Drawing.Point(-7, 115);
            this.lblInfoPass.Name = "lblInfoPass";
            this.lblInfoPass.Size = new System.Drawing.Size(854, 334);
            this.lblInfoPass.TabIndex = 3;
            this.lblInfoPass.Text = "Enter your password";
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(719, 260);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(114, 58);
            this.btnPass.TabIndex = 5;
            this.btnPass.Text = "Enter Password";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // listUsers
            // 
            this.listUsers.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 28;
            this.listUsers.Location = new System.Drawing.Point(719, 60);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(114, 172);
            this.listUsers.TabIndex = 6;
            // 
            // txtSwap1
            // 
            this.txtSwap1.Location = new System.Drawing.Point(63, 271);
            this.txtSwap1.Name = "txtSwap1";
            this.txtSwap1.Size = new System.Drawing.Size(100, 20);
            this.txtSwap1.TabIndex = 7;
            this.txtSwap1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSwap1_KeyDown);
            // 
            // txtSwap2
            // 
            this.txtSwap2.Location = new System.Drawing.Point(63, 297);
            this.txtSwap2.Name = "txtSwap2";
            this.txtSwap2.Size = new System.Drawing.Size(100, 20);
            this.txtSwap2.TabIndex = 8;
            this.txtSwap2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSwap1_KeyDown);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(183, 260);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(109, 74);
            this.btnSwap.TabIndex = 9;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 364);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.txtSwap2);
            this.Controls.Add(this.txtSwap1);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblInfoPass);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblInfoName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblInfoPass;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.TextBox txtSwap1;
        private System.Windows.Forms.TextBox txtSwap2;
        private System.Windows.Forms.Button btnSwap;
    }
}

