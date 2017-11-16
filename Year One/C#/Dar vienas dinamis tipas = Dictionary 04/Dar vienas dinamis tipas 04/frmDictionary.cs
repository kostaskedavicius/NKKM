using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dar_vienas_dinamis_tipas_04
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Dictionary<int, string> AllStudents = new Dictionary<int, string>();

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            string student = Interaction.InputBox("Enter student name", "Add new student");
            if (!string.IsNullOrWhiteSpace(student))
            {
                Hell:
                //create unique id for student and add to list
                int id = rnd.Next();
                if (!AllStudents.Keys.Contains(id))
                {
                    AllStudents.Add(id, student);
                    liststudents.Items.Add(student);
                }
                else { goto Hell; }


            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnstdnumb_Click(object sender, EventArgs e)
        {
            //find selected student  number
            if (liststudents.SelectedIndex != -1)
            {
                //search dcitionary
                //save selected student name
                string name = liststudents.SelectedItem.ToString();
                foreach (KeyValuePair<int,string> item in AllStudents)
                {
                    if(item.Value == name)
                    {
                        MessageBox.Show("This student's unique ID is "+item.Key.ToString(),"Student ID");
                    }
                }
            }
        }
    }
}
