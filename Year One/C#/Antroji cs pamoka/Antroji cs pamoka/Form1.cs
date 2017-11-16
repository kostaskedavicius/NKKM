using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antroji_cs_pamoka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pass = "Password";
        string temp;
        private void btnPass_Click(object sender, EventArgs e)
        {


            if (txtBoxPass.Text == pass)
            {
                if (listUsers.Items.Contains(txtBoxName.Text))
                {
                    MessageBox.Show("This name is already in the list", "An error occured");
                    ClearFields();
                    return;
                }
                listUsers.Items.Add(txtBoxName.Text);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Wrong Password", "You made a mistake");
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtBoxName.Clear();
            txtBoxPass.Clear();
        }


        private void btnSwap_Click(object sender, EventArgs e)
        {

            temp = txtSwap2.Text;
            txtSwap2.Text = txtSwap1.Text;
            txtSwap1.Text = temp;

        }

        private void txtSwap1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSwap.PerformClick();
            }
        }
    }
}
