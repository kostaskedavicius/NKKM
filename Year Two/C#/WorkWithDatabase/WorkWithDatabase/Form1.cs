using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WorkWithDatabase
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection();
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlCommand cmd = new MySqlCommand();

        List<TextBox> txtList = new List<TextBox>();
        List<ComboBox> cmbList = new List<ComboBox>();
        List<NumericUpDown> numList = new List<NumericUpDown>();

        string pattern = @"[^0-9<>-+?$%{}&]+[^-<>+?$%{}&]";


        public Form1()
        {
            InitializeComponent();

            gbTable.Enabled = false;

            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "root";

            connection.ConnectionString = builder.ToString();


        }

        private void btnDBCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDBName.Text))
            {
                MessageBox.Show("Invalid table name", "An Error Has Occured");
                return;
            }

            string query = "CREATE DATABASE IF NOT EXISTS " + txtDBName.Text + ";";

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            cmd.CommandText = query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
            gbDB.Enabled = false;
            gbTable.Enabled = true;
            txtTableName.Focus();
            txtTableName.KeyDown += TxtTableName_KeyDown;
        }

        private void TxtTableName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearObjects();

            if (string.IsNullOrWhiteSpace(txtTableName.Text))
            {
                MessageBox.Show("Invalid table name", "An Error Has Occured");
                return;
            }

            CreateObjects();
        }

        private void ClearObjects()
        {
            for (int i = 0; i < numList.Count; i++)
            {
                panel1.Controls.Remove(txtList[i]);
                panel1.Controls.Remove(cmbList[i]);
                panel1.Controls.Remove(numList[i]);
            }

            txtList.Clear();
            cmbList.Clear();
            numList.Clear();
            panel1.Controls.RemoveByKey("btnSave");

        }

        private void CreateObjects()
        {
            for (int i = 0; i < numericFields.Value; i++)
            {
                TextBox txt = new TextBox();
                txt.Width = 175;
                txt.Location = new Point(lblFieldName.Location.X, lblFieldName.Location.Y + lblFieldName.Height + (i * txt.Height) + (i * 10));
                txtList.Add(txt);

                ComboBox combo = new ComboBox();
                combo.Name = i.ToString();
                combo.Width = 75;
                combo.Location = new Point(lblFieldType.Location.X, lblFieldType.Location.Y + lblFieldType.Height + (i * combo.Height) + (i * 10));
                combo.DataSource = new string[] { "SERIAL", "INT", "BIGINT", "TINYINT", "SMALLINT", "FLOAT", "DOUBLE", "VARCHAR", "CHAR", "TEXT", "DATE", "DATETIME", "TIMESTAMP", "LONG", "BLOB", "BOOLEAN" };
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
                combo.SelectedIndexChanged += Combo_SelectedIndexChanged;
                cmbList.Add(combo);

                NumericUpDown num2 = new NumericUpDown();
                num2.Width = 100;
                num2.Location = new Point(lblFieldLength.Location.X, lblFieldLength.Location.Y + lblFieldLength.Height + (i * num2.Height) + (i * 10));
                num2.Maximum = 255;
                num2.Minimum = 0;
                num2.Enabled = false;
                numList.Add(num2);

                panel1.Controls.Add(txtList[i]);
                panel1.Controls.Add(cmbList[i]);
                panel1.Controls.Add(numList[i]);
            }

            int index = numList.Count - 1;

            Button btnSave = new Button();// Object name
            btnSave.Name = "btnSave";// Button name
            btnSave.AutoSize = true;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Text = "Save";
            btnSave.Location = new Point(numList[index].Location.X + 25, numList[index].Location.Y + numList[index].Height + 20);
            btnSave.Click += BtnSave_Click;
            panel1.Controls.Add(btnSave);

        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox temp = sender as ComboBox;

            int index = Convert.ToInt32(temp.Name);

            numList[index].Enabled = true;

            switch (temp.Text.ToLower())
            {
                case "serial":
                case "float":
                case "double":
                case "date":
                case "datetime":
                case "timestamp":
                case "char":
                case "blob":
                    numList[index].Enabled = false;
                    numList[index].Value = 0;
                    break;
                case "tinyint":
                    numList[index].Maximum = 3;
                    break;
                case "int":
                    numList[index].Maximum = 11;
                    break;
                case "smallint":
                    numList[index].Maximum = 6;
                    break;
                case "bigint":
                    numList[index].Maximum = 20;
                    break;
                case "varchar":
                    numList[index].Maximum = 255;
                    break;
                case "text":
                    numList[index].Maximum = 65535;
                    break;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckNames())
            {
                MessageBox.Show("Table field names are not entered correctly");
                return;
            }

            if (CheckSerials())
            {
                MessageBox.Show("There are more than one SERIAL types");
                return;
            }

            StringBuilder query = new StringBuilder();
            query.Append("USE " + txtDBName.Text + ";" + "CREATE TABLE IF NOT EXISTS " + txtTableName.Text + "(");
            for (int i = 0; i < txtList.Count; i++)
            {
                query.Append(txtList[i].Text + " " + cmbList[i].Text);
                if (numList[i].Enabled = false || numList[i].Value == 0)
                {
                    query.Append(",");
                }
                else
                {
                    query.Append("(" + numList[i].Value + "),");
                }
            }
            query.Remove(query.Length - 1, 1);
            query.Append(")");
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.CommandText = query.ToString();
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seems to work");
                txtTableName.Text = string.Empty;
                numericFields.Value = 1;
                ClearObjects();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); ;
            }
        }

        private bool CheckSerials()
        {
            //byte count = 0;
            //foreach (var item in cmbList)
            //{
            //    if (item.Text.ToLower() == "serial") count++;
            //    if (count > 1) return true;
            //}
            //return false;

            //Same but better
            if (cmbList.FindAll(item => item.Text == "serial").Count > 1) return true;
            return false;
        }

        private bool CheckNames()
        {
            for (int i = 0; i < txtList.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(txtList[i].Text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}