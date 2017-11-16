using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LambdaAndLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public byte Age { get; set; }
        }


        List<int> numbers = new List<int>() { 34, 32, 51122, 22, 1, 7876, 33552, 334, 2278, 66453, 7432, 9 };
        List<Person> ppl = new List<Person>()
        {
            new Person() {Name="Vardenis",LastName="Pavardenis",Age=17},
            new Person() {Name="Vard",LastName="enis",Age=25},
            new Person() {Name="Vardenis",LastName="Pavandenis",Age=22},
            new Person() {Name="Who's",LastName="this guy",Age=25},
            new Person() {Name="Vardenis",LastName="fon Pavardenis XIV",Age=255},
            new Person() {Name="Local",LastName="Barbarian",Age=55}
        };


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //foreach (int item in numbers)
            //{
            //    if (item%2 == 0)
            //    {
            //        listBox1.Items.Add(item);
            //    }
            //}

            //same, but with lambda ( => )
            listBox1.DataSource = numbers.FindAll(item => item % 2 == 0);
        }

        private void btnVardenis_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //find all people with the name Vardenis
            // var rez = ppl.FindAll(People => People.Name == "Vardenis");

            //combine name and last name into one string
            var rez = ppl.FindAll(item => item.Name == "Vardenis").Select(item => new { FullName = item.Name + " " + item.LastName, Age = item.Age });
            foreach (var item in rez)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSortPeople_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var x in ppl.OrderBy(item => item.Name).ThenBy(item => item.Age))
            {
                listBox1.Items.Add(x.Name + " " + x.LastName + " " + x.Age);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = (from item in numbers where item % 2 == 0 select item).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var x in (from item in ppl where item.Name == "Vardenis" select item).ToList())
            {
                listBox1.Items.Add(x.Name + " " + x.LastName + " " + x.Age);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            var rez = (from item in ppl orderby item.LastName descending, item.Age ascending select item).ToList();
            foreach (var item in rez)
            {
                listBox1.Items.Add(item.Name + " " + item.LastName + " " + item.Age);
            }
        }
    }
}