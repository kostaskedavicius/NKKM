namespace Picture_Browser
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
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.picCurrent = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.BackColor = System.Drawing.SystemColors.Control;
            this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(568, 28);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "N/A";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(586, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 28);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picPrevious
            // 
            this.picPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.picPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPrevious.Location = new System.Drawing.Point(12, 40);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(182, 281);
            this.picPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrevious.TabIndex = 2;
            this.picPrevious.TabStop = false;
            // 
            // picCurrent
            // 
            this.picCurrent.BackColor = System.Drawing.SystemColors.Control;
            this.picCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCurrent.Location = new System.Drawing.Point(200, 40);
            this.picCurrent.Name = "picCurrent";
            this.picCurrent.Size = new System.Drawing.Size(274, 408);
            this.picCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCurrent.TabIndex = 3;
            this.picCurrent.TabStop = false;
            this.picCurrent.DoubleClick += new System.EventHandler(this.picCurrent_DoubleClick);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.SystemColors.Control;
            this.picNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNext.Location = new System.Drawing.Point(480, 43);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(184, 278);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 4;
            this.picNext.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(58, 327);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(87, 42);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "<=";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(531, 327);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 42);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "=>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(676, 456);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picCurrent);
            this.Controls.Add(this.picPrevious);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picCurrent;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

