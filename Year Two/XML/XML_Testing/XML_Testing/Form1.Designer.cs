namespace XML_Testing
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
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnFood2 = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(12, 12);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(77, 31);
            this.btnAddress.TabIndex = 0;
            this.btnAddress.Text = "Address";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(12, 49);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(77, 31);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Food";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnFood2
            // 
            this.btnFood2.Location = new System.Drawing.Point(95, 49);
            this.btnFood2.Name = "btnFood2";
            this.btnFood2.Size = new System.Drawing.Size(77, 31);
            this.btnFood2.TabIndex = 2;
            this.btnFood2.Text = "Ingredients";
            this.btnFood2.UseVisualStyleBackColor = true;
            this.btnFood2.Click += new System.EventHandler(this.btnFood2_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(95, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(77, 31);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "FromFile";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(191, 89);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnFood2);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnFood2;
        private System.Windows.Forms.Button btnFile;
    }
}

