namespace WorkWithDatabase
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
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.btnDBCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.lblFieldLength = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericFields = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDB.SuspendLayout();
            this.gbTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFields)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDB
            // 
            this.gbDB.BackColor = System.Drawing.Color.MintCream;
            this.gbDB.Controls.Add(this.txtDBName);
            this.gbDB.Controls.Add(this.btnDBCreate);
            this.gbDB.Controls.Add(this.label1);
            this.gbDB.Location = new System.Drawing.Point(13, 13);
            this.gbDB.Name = "gbDB";
            this.gbDB.Size = new System.Drawing.Size(498, 70);
            this.gbDB.TabIndex = 0;
            this.gbDB.TabStop = false;
            this.gbDB.Text = "Database";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(111, 17);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(381, 20);
            this.txtDBName.TabIndex = 2;
            // 
            // btnDBCreate
            // 
            this.btnDBCreate.Location = new System.Drawing.Point(417, 43);
            this.btnDBCreate.Name = "btnDBCreate";
            this.btnDBCreate.Size = new System.Drawing.Size(75, 22);
            this.btnDBCreate.TabIndex = 1;
            this.btnDBCreate.Text = "Create";
            this.btnDBCreate.UseVisualStyleBackColor = true;
            this.btnDBCreate.Click += new System.EventHandler(this.btnDBCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataBase Name";
            // 
            // gbTable
            // 
            this.gbTable.BackColor = System.Drawing.Color.MintCream;
            this.gbTable.Controls.Add(this.panel1);
            this.gbTable.Enabled = false;
            this.gbTable.Location = new System.Drawing.Point(13, 90);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(498, 295);
            this.gbTable.TabIndex = 1;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Items";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblFieldType);
            this.panel1.Controls.Add(this.lblFieldLength);
            this.panel1.Controls.Add(this.lblFieldName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericFields);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 276);
            this.panel1.TabIndex = 0;
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldType.Location = new System.Drawing.Point(217, 48);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(66, 13);
            this.lblFieldType.TabIndex = 16;
            this.lblFieldType.Text = "Field Type";
            // 
            // lblFieldLength
            // 
            this.lblFieldLength.AutoSize = true;
            this.lblFieldLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldLength.Location = new System.Drawing.Point(349, 48);
            this.lblFieldLength.Name = "lblFieldLength";
            this.lblFieldLength.Size = new System.Drawing.Size(77, 13);
            this.lblFieldLength.TabIndex = 15;
            this.lblFieldLength.Text = "Field Length";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldName.Location = new System.Drawing.Point(4, 48);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(70, 13);
            this.lblFieldName.TabIndex = 14;
            this.lblFieldName.Text = "Field Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericFields
            // 
            this.numericFields.Location = new System.Drawing.Point(343, 5);
            this.numericFields.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericFields.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFields.Name = "numericFields";
            this.numericFields.Size = new System.Drawing.Size(56, 20);
            this.numericFields.TabIndex = 13;
            this.numericFields.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "# of fields";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(99, 6);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(162, 20);
            this.txtTableName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(523, 397);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.gbDB);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            this.gbTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDB;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Button btnDBCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Label lblFieldLength;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
    }
}

