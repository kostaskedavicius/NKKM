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

namespace Connect_to_DB
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection();
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public Form1()
        {
            InitializeComponent();
            connection.StateChange += Connection_StateChange;
        }

        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Closed:
                    lblStatus.BackColor = Color.Red;
                    break;
                case ConnectionState.Open:
                    lblStatus.BackColor = Color.Lime;
                    break;
                case ConnectionState.Connecting:
                    lblStatus.BackColor = Color.Yellow;
                    break;
                case ConnectionState.Executing:
                    lblStatus.BackColor = Color.RosyBrown;
                    break;
                case ConnectionState.Fetching:
                    lblStatus.BackColor = Color.Violet;
                    break;
                case ConnectionState.Broken:
                    lblStatus.BackColor = Color.Black;
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    builder.Server = txtServer.Text;
                    builder.Port = 3306;
                    builder.UserID = txtUID.Text;
                    builder.Password = txtpwd.Text;
                    builder.ConnectionLifeTime = 0;
                    builder.ConnectionTimeout = 30;

                    connection.ConnectionString = builder.ToString();
                    connection.Open();
                    string query = "show tables;";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();// For commands that do not return a value
                }
                else
                {
                    MessageBox.Show("Connection already exists");
                    return;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error" + ex.Number);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, ex.HResult.ToString());
            }
            finally
            {
                connection.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}