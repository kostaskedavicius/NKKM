using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dynaminiai_Objektai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //create event
            txtAmount.KeyDown += TxtAmount_KeyDown1;
            txtRemove.KeyDown += txtRemove_KeyDown1;
        }

        private void txtRemove_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bool del = false;
                //check for user name
                for (int i = 0; i < lstRegister.Items.Count; i++)
                {
                    if (txtRemove.Text == ((Person)lstRegister.Items[i]).FullName)
                    {
                        lstRegister.Items.RemoveAt(i);
                        i--;
                        del = true;
                    }
                }
                if (!del)
                {
                    MessageBox.Show("The specified person is not on the list", "An Error Occured");
                }
            }
        }

        List<Label> lblList = new List<Label>();
        List<TextBox> txtList = new List<TextBox>();
        List<ComboBox> cmbList = new List<ComboBox>();

        private void TxtAmount_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                //check if a number is entered
                if (!uint.TryParse(txtAmount.Text, out amount) || amount == 0)
                {
                    MessageBox.Show("Please enter a valid number", "An Error Occured");
                    return;
                }
                ClearDesign();
                GenerateDesign();
            }
        }

        private void ClearDesign()
        {
            pnlRegister.Controls.Clear();
            lblList.Clear();
            txtList.Clear();
            cmbList.Clear();
        }

        private void GenerateDesign()
        {
            for (int i = 0; i < amount; i++)
            {
                //create label
                Label lbl = new Label();
                //assign properties to the label
                lbl.AutoSize = true;
                lbl.Text = "Full Name";
                lbl.Location = new Point(0, i * (lbl.Height + 10));
                //display label in form
                lblList.Add(lbl);
                pnlRegister.Controls.Add(lblList[i]);

                //create text box
                TextBox txt = new TextBox();
                //assign properties to the text box
                txt.Location = new Point(lbl.Width + 10, lbl.Location.Y);
                txt.Size = new Size(180, lbl.Height);
                //display label in form
                txtList.Add(txt);
                pnlRegister.Controls.Add(txtList[i]);

                //create combo box
                ComboBox cmb = new ComboBox();
                //assign properties to said combo box
                cmb.Location = new Point(txt.Location.X + txt.Width + 10, txt.Location.Y);
                cmb.Size = txt.Size;
                cmb.DataSource = new string[] { "", "Game Developer", "Marketing Specialist", "IT Engineer", "VIP" };
                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                //display combo box in form
                cmbList.Add(cmb);
                pnlRegister.Controls.Add(cmbList[i]);
            }
            //create new button
            int poz = txtList.Count - 1;
            Button Batonas = new Button()
            {
                Text = "Register",
                AutoSize = true,
                Location = new Point(txtList[poz].Location.X + 20, txtList[poz].Location.Y + txtList[poz].Height + 20),
                UseVisualStyleBackColor = true
            };
            Batonas.Click += Batonas_Click;
            pnlRegister.Controls.Add(Batonas);

        }

        private void Batonas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amount; i++)
            {
                //check if username exists
                if (string.IsNullOrWhiteSpace(txtList[i].Text)) continue;

                bool Found = false;
                //check if user exists in the registered list
                for (int j = 0; j < lstRegister.Items.Count; j++)
                {
                    if (((Person)lstRegister.Items[j]).FullName == txtList[i].Text && ((Person)lstRegister.Items[j]).JobTitle == cmbList[i].Text)
                    {
                        MessageBox.Show(((Person)lstRegister.Items[j]).FullName + ", who works as " + ((Person)lstRegister.Items[j]).JobTitle + ", is already in the list", "An Error Occured");
                        Found = true;
                        break;
                    }
                }
                if (Found) continue;

                //Create Person
                Person p = new Person()
                {
                    FullName = txtList[i].Text,
                    JobTitle = cmbList[i].Text
                };
                //Add person to registered list
                lstRegister.Items.Add(p);


            }
        }

        uint amount;

        private void lstRegister_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush;
            Person item;
            //check if there is something to draw
            if (e.Index == -1) return;

            //draw selected item
            if ((e.State & DrawItemState.Checked) == 0)
            {
                myBrush = SystemBrushes.WindowText;
            }
            else
            {
                myBrush = SystemBrushes.HighlightText;
            }
            e.DrawBackground();

            //get current item
            item = (Person)lstRegister.Items[e.Index];

            //draw item
            e.Graphics.DrawString(item.FullName, e.Font, myBrush, 0, e.Bounds.Top);
            e.Graphics.DrawString(item.JobTitle, e.Font, myBrush, 150, e.Bounds.Top);
        }

        private void lstRegister_DoubleClick(object sender, EventArgs e)
        {
            //check if something is selected
            if (lstRegister.SelectedIndex == -1) return;
            Person item = (Person)lstRegister.SelectedItem;
            MessageBox.Show(item.FullName + " " + item.JobTitle);
        }
    }
}

