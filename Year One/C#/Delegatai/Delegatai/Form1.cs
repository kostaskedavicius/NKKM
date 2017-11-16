using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegatai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnTest.Click += delegate { MessageBox.Show("Test"); };
        }

        Calculator calc = new Calculator();

        private void btnCount_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            if (txtSign.Text == "^" && !calc.OperationExists(txtSign.Text))
            {
                calc.AddOperation(txtSign.Text, delegate (double x, double y) { return Math.Pow(x, y); });
            }
            MessageBox.Show("Operation added");


            double rez = calc.PerformOperation(num1, num2, txtSign.Text);
            MessageBox.Show(rez.ToString());
        }
    }
}
