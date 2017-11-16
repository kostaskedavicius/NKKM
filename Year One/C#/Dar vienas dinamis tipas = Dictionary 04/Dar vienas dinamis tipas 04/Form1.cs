using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dar_vienas_dinamis_tipas_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList(); //creating new global array list
        double sum = 0;

        private void btnarraylist_Click(object sender, EventArgs e)
        {
            //fill array list
            list.Add(5);
            list.Add("Labas");
            list.Add(5.4);
            list.Add(5.3f);
            list.Add('A');
            list.Add(false);

            //show list
            for (int i = 0; i < list.Count; i++)
            {
                listarray.Items.Add(list[i]);
            }
        }

        private void btnsumnumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetType() == typeof(int) ||
                   list[i].GetType() == typeof(float) ||
                   list[i].GetType() == typeof(byte) ||
                   list[i].GetType() == typeof(short) ||
                   list[i].GetType() == typeof(uint) ||
                   list[i].GetType() == typeof(ushort) ||
                   list[i].GetType() == typeof(long) ||
                   list[i].GetType() == typeof(ulong) ||
                   list[i].GetType() == typeof(sbyte))
                {

                    //implicit cast object to double
                    sum += Convert.ToDouble(list[i]);
                }
            }
            MessageBox.Show(sum.ToString());
        }
        private void btnDictionary_Click(object sender, EventArgs e)
        {
            //method 1(Form opening)
            // frmDictionary frm = new frmDictionary(); // create new form instance
            //  frm.Show();
            //  this.Close();

            //method 2
            //new frmDictionary().Show();

            //method 3
            new frmDictionary().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
