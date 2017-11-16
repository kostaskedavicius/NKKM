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
        Guest oneguest = new Guest();

        #region calc
        double num1, num2;

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirst.Text, out num1) && txtFirst.TextLength > 0)
            {
                MessageBox.Show("Please enter an actual number", "Something went wrong");
            }
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSecond.Text, out num2) && txtSecond.TextLength > 0)
            {
                MessageBox.Show("Please enter an actual number", "Something went wrong");
            }
        }

        private void btnreg_Click(object sender, EventArgs e)
        {

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
