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

namespace MusicDatabase
{
    public partial class MainForm : Form
    {
        MySqlConnection connection = new MySqlConnection();
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        MySqlCommand cmd = new MySqlCommand();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                builder.Server = "localhost";
                builder.Port = 3306;
                builder.UserID = "root";
                builder.Password = "root";
                connection.ConnectionString = builder.ToString();
                connection.Open();

                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS music;Use music;CREATE TABLE IF NOT EXISTS genre(ID SERIAL, Name varchar(30));";
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();

                this.Text = connection.State.ToString();
                txtGenre.KeyDown += TxtGenre_KeyDown;
                ShowGenre();
                ShowHowManyRows();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowHowManyRows()
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM genre;";
                cmd.ExecuteNonQuery();
                string RowText = cmd.ExecuteScalar().ToString();
                lblRows.Text = "Row Count = " + RowText;

                //MySqlDataReader mdr = cmd.ExecuteReader();
                //mdr.Read();
                //ulong Rows = Convert.ToUInt64(mdr[0]);
                //string RowText = Rows.ToString();
                //lblRows.Text = "Row Count = " + RowText;
                //mdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowGenre()
        {
            lstDB.Items.Clear();
            ulong Tea; // Get it?(Genre ID)
            string Name;
            string listString;

            cmd.CommandText = "SELECT * FROM genre;";
            MySqlDataReader mydr = cmd.ExecuteReader();
            if (mydr.HasRows)
            {
                while (mydr.Read())
                {
                    Tea = Convert.ToUInt64(mydr["ID"]);
                    Name = mydr["Name"].ToString();

                    //if (!mydr.IsDBNull(0)) Tea = mydr.GetUInt64(0);
                    //else Tea = 0;
                    //if (!mydr.IsDBNull(1)) Name = mydr.GetString(1);
                    //else Name = "";


                    //Tea = 0;
                    //Name = "";
                    //for (int i = 0; i < 2; i++)
                    //{
                    //    if (mydr.GetDataTypeName(i) == "BIGINT") Tea = Convert.ToUInt64(mydr[i]);
                    //    if (mydr.GetDataTypeName(i) == "VARCHAR") Name = mydr[i].ToString();
                    //}

                    listString = Name + "(" + Tea.ToString() + ")";
                    lstDB.Items.Add(listString);
                }
            }
            mydr.Close();
        }

        private void TxtGenre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtGenre.Text))
                {
                    MessageBox.Show("Genre cannot be empty");
                }
                else
                {
                    cmd.CommandText = "INSERT INTO genre VALUES(NULL,'" + txtGenre.Text + "');";
                    cmd.ExecuteNonQuery();

                    txtGenre.Text = null;

                    ShowGenre();
                    ShowHowManyRows();
                    MessageBox.Show("Collumn added succesfully");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}