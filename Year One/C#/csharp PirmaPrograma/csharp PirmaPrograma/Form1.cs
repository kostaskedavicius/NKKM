using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_PirmaPrograma
{
    public partial class Form1 : Form
    {
        //constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            DialogResult rez; // Variable
            rez = MessageBox.Show("You clicked me!", "You got a message!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
            if (rez == DialogResult.Yes)
            {
                    this.BackColor = Color.Lime;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
    }
}
