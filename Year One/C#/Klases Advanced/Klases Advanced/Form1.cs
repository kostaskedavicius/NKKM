using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klases_Advanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create dog
            Suo suo = new Suo();
            suo.ArYraUodega = true;
            suo.KojuSkaicius = 4;
            suo.Spalva = "Juoda";
            suo.Veisle = "Nezinoma";

            //create snake
            Gyvate gyv = new Gyvate()
            {
                ArYraUodega = true,
                KojuSkaicius = 0,
                Rusis = "Python",
                Spalva = "Spalvota"
            };
            label1.Text = "Suns aprasaymas: " + suo.Aprasymas();
            label1.Text += "\n\nGyvates aprasymas: " + gyv.Aprasymas();
    }

    }
}
