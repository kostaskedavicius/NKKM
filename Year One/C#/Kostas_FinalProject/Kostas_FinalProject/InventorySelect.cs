using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostas_FinalProject
{
    public partial class InventorySelect : Form
    {
        public InventorySelect()
        {
            InitializeComponent();
            this.FormClosing += InventorySelect_FormClosing;
            rbtn_Sword.Font = new Font("Arial", 10);
            rbtn_Sword.ForeColor = Color.White;
            rbtn_Sword.AutoSize = true;
            rbtn_Sword.Text = "A sword";
            rbtn_Sword.Checked = false;

            rbtn_Spear.Font = new Font("Arial", 10);
            rbtn_Spear.ForeColor = Color.White;
            rbtn_Spear.AutoSize = true;
            rbtn_Spear.Text = "A spear";
            rbtn_Spear.Checked = false;

            rbtn_Dagger.Font = new Font("Arial", 10);
            rbtn_Dagger.ForeColor = Color.White;
            rbtn_Dagger.AutoSize = true;
            rbtn_Dagger.Text = "A dagger";
            rbtn_Dagger.Checked = false;

            rbtn_Armor.Font = new Font("Arial", 10);
            rbtn_Armor.ForeColor = Color.White;
            rbtn_Armor.AutoSize = true;
            rbtn_Armor.Text = "His armor";
            rbtn_Armor.Checked = false;

            btn_ok.Enabled = false;
        }

        private void InventorySelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }

        int Rbtn2Checked = 0;

        private void rbtn_Sword_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn2Checked = Rbtn2Checked + 1;
            if (Rbtn2Checked == 2)
            {
                if (!rbtn_Armor.Checked) rbtn_Armor.Enabled = false;
                if (!rbtn_Dagger.Checked) rbtn_Dagger.Enabled = false;
                if (!rbtn_Spear.Checked) rbtn_Spear.Enabled = false;
                if (!rbtn_Sword.Checked) rbtn_Sword.Enabled = false;
                btn_ok.Enabled = true;
            }
        }

        private void rbtn_Spear_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn2Checked = Rbtn2Checked + 1;
            if (Rbtn2Checked == 2)
            {
                if (!rbtn_Armor.Checked) rbtn_Armor.Enabled = false;
                if (!rbtn_Dagger.Checked) rbtn_Dagger.Enabled = false;
                if (!rbtn_Spear.Checked) rbtn_Spear.Enabled = false;
                if (!rbtn_Sword.Checked) rbtn_Sword.Enabled = false;
                btn_ok.Enabled = true;
            }
        }

        private void rbtn_Dagger_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn2Checked = Rbtn2Checked + 1;
            if (Rbtn2Checked == 2)
            {
                if (!rbtn_Armor.Checked) rbtn_Armor.Enabled = false;
                if (!rbtn_Dagger.Checked) rbtn_Dagger.Enabled = false;
                if (!rbtn_Spear.Checked) rbtn_Spear.Enabled = false;
                if (!rbtn_Sword.Checked) rbtn_Sword.Enabled = false;
                btn_ok.Enabled = true;

            }
        }

        private void rbtn_Armor_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn2Checked = Rbtn2Checked + 1;
            if (Rbtn2Checked == 2)
            {
                if (!rbtn_Armor.Checked) rbtn_Armor.Enabled = false;
                if (!rbtn_Dagger.Checked) rbtn_Dagger.Enabled = false;
                if (!rbtn_Spear.Checked) rbtn_Spear.Enabled = false;
                if (!rbtn_Sword.Checked) rbtn_Sword.Enabled = false;
                btn_ok.Enabled = true;
            }
        }
    }
}
