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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void rbtn_TimerOn_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_TimerOff.Enabled = true;
        }

        private void rbtn_TimerOff_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_TimerOn.Enabled = true;
        }

        private void rbtn_HintsOn_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_HintsOff.Enabled = true;
        }

        private void rbtn_HintsOff_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_HintsOn.Enabled = true;
        }

        //Name is fixed
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_HealthHide.Enabled = true;
        }

        private void rbtn_HealthHide_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_HealthShow.Enabled = true;
        }
    }
}
