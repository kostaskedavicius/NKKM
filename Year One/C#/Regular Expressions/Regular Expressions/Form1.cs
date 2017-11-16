using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text = "Today is a very strange day indeed!";
        string pattern = "\bday\b";

        //string phonePattern = @"^\+370\d\d\d\d\d\d\d\d$";

        string phonePattern = @"^(\+370|8)\s?[1-9]\d{2}\s?\d{5}$";

        // [1-9] interval
        // /s whitespace
        // ? one or zero repetitions

        //\+ literal +
        //^beggining
        //$end

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = Regex.IsMatch(text, pattern);
            MessageBox.Show(found.ToString());

            if (found)
            {
                foreach (var item in Regex.Matches(text, pattern))
                {
                    MessageBox.Show(item.ToString());
                }
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            bool found = Regex.IsMatch(txtPhone.Text, phonePattern);
            MessageBox.Show(found.ToString());
        }
    }
}
