using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Guest> GuestList = new List<Guest>();
        Random rnd = new Random();

        #region calc
        double num1, num2;

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirst.Text, out num1) && txtFirst.TextLength > 0)
            {
                MessageBox.Show("Please enter a number", "Something went wrong");
            }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSecond.Text, out num2) && txtSecond.TextLength > 0)
            {
                MessageBox.Show("Please enter a number", "Something went wrong");
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Guest oneguest = new Guest();
            oneguest.SetName(txtname.Text);
            oneguest.SetLastName(txtlastname.Text);
            oneguest.SetCompany(txtcomp.Text);

            GuestList.Add(oneguest);

            listguests.Items.Add(oneguest.GetName() + " " + oneguest.GetLastName() + " " + oneguest.GetCompany());
            listView1.Items.Add(oneguest.GetName() + " " + oneguest.GetLastName() + " " + oneguest.GetCompany());

            txtname.Clear();
            txtlastname.Clear();
            txtcomp.Clear();
        }

        private void btnPrizes_Click(object sender, EventArgs e)
        {
            foreach (Guest item in GuestList)
            {
                item.SetWinner(false);
            }
            foreach (ListViewItem item in listView1.Items)
            {
                item.BackColor = Color.White;
            }

            int index;
            for (int i = 0; i < rnd.Next(1, GuestList.Count + 1); i++)
            {
                index = rnd.Next(GuestList.Count);
                while (GuestList[index].GetWinner() == true)
                {
                    index = rnd.Next(GuestList.Count);
                }

                GuestList[index].SetWinner(true);
                GuestList[index].SetPrize();
                listView1.Items[index].BackColor = Color.LimeGreen;
            }
            MessageBox.Show("Double click your name to show what you have won", "The lottery has concluded");
        }

        private void listguests_DoubleClick(object sender, EventArgs e)
        {
            if (listguests.SelectedIndex == -1) return;
            Guest item = GuestList[listguests.SelectedIndex];
            MessageBox.Show(item.GetPrize().ToString());
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (combolist.Text)
            {
                case "+":
                    MessageBox.Show((calc.Plus(num1, num2).ToString()));
                    break;
                case "-":
                    MessageBox.Show((calc.Minus(num1, num2).ToString()));
                    break;
                case "*":
                    MessageBox.Show((calc.Multiplication(num1, num2).ToString()));
                    break;
                case "/":
                    MessageBox.Show((calc.Division(num1, num2).ToString()));
                    break;
                default:
                    MessageBox.Show("An error occured", "Something went wrong");
                    break;
            }
        }
        #endregion

    }
}
