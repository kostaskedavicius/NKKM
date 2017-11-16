using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kostas_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            settings = new SettingsForm();
            invslct = new InventorySelect();
        }
        private readonly SettingsForm settings;
        private readonly InventorySelect invslct;
        Stopwatch sw = new Stopwatch();
        int Statistic = 0;
        int UpdateP = 1;
        int UpdateP2 = 0;
        bool ShowStats = false;
        bool ShowInventory = false;
        bool StrengthCheck = false;
        bool AgilityCheck = false;
        bool CharismaCheck = false;
        int ButtonCheck = 0;
        string Sword = "Not owned";
        string Spear = "Not owned";
        string Dagger = "Not owned";
        string Armor = "Not owned";
        int Outcome = 0;
        int Hurt = 0;

        //Step 1
        Label lbl_1_1 = new Label();
        RadioButton rbtn_1_Warrior = new RadioButton();
        RadioButton rbtn_1_Thief = new RadioButton();
        RadioButton rbtn_1_Noble = new RadioButton();
        Button btn_1_1 = new Button();

        //Step 2
        RadioButton rbtn_2_Warrior = new RadioButton();
        RadioButton rbtn_2_Thief = new RadioButton();
        RadioButton rbtn_2_Noble = new RadioButton();
        Button btn_2_1 = new Button();

        //Step 3
        RadioButton rbtn_3_Death = new RadioButton();
        RadioButton rbtn_3_Life = new RadioButton();
        Button btn_3_1 = new Button();

        //Step 4
        //InventorySelect

        //Step 5
        RadioButton rbtn_SneakAway = new RadioButton();
        RadioButton rbtn_FightToFreedom = new RadioButton();
        RadioButton rbtn_ImpersonateAGuard = new RadioButton();
        Button btn_5_1 = new Button();

        //Step 6
        Button btn_6_1 = new Button();

        //Step 7
        Button btn_7_1 = new Button();

        //Step 8
        Button btn_8_1 = new Button();

        //Step 9
        Button btnRestart_9 = new Button();

        //Final Step(10)
        Button btn_Win = new Button();

        private void bbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreditsForm().ShowDialog();
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.ShowDialog() == DialogResult.OK)
            {
                //check if timer is supposed to be working
                //even if timer is turned off, then turned on it will still be counting from the start(Intentional)
                if (settings.rbtn_TimerOff.Checked)
                {
                    timer1.Enabled = false;
                    lblTimerMin1.Enabled = false;
                    lblTimerMin1.Visible = false;
                    lblTimer.Enabled = false;
                    lblTimer.Visible = false;
                }
                else if (settings.rbtn_TimerOn.Checked)
                {
                    timer1.Enabled = true;
                    lblTimerMin1.Enabled = true;
                    lblTimerMin1.Visible = true;
                    lblTimer.Enabled = true;
                    lblTimer.Visible = true;
                }

                //check if hints are supposed to show
                if (settings.rbtn_HintsOff.Checked)
                {
                    hintToolStripMenuItem.Visible = false;
                }
                else if (settings.rbtn_HintsOn.Checked)
                {
                    hintToolStripMenuItem.Visible = true;
                }

                //check if health is supposed to be shown
                if (settings.rbtn_HealthHide.Checked)
                {
                    lblHealth.Visible = false;
                    lblHealth2.Visible = false;
                }
                else if (settings.rbtn_HealthShow.Checked)
                {
                    lblHealth.Visible = true;
                    lblHealth2.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimerMin1.Text = sw.Elapsed.TotalSeconds.ToString();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your goal is to escape a prison.The rules are simple: In each situation you have to select what to do from several choices, but you can only select one unless stated otherwise. There are a few paths to freedom.", "Rules");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sw.Start();
            mnuHint2.Visible = true;
            UpdateP = 0;
            UpdatePanel();
        }
        public void UpdatePanel()
        {
            pnl_Main.Controls.Clear();
            switch (UpdateP)
            {
                case 0:
                    //add label
                    lbl_1_1.AutoSize = true;
                    lbl_1_1.Font = new Font("Arial", 12);
                    lbl_1_1.ForeColor = Color.White;
                    lbl_1_1.Location = new Point(0, 0);
                    lbl_1_1.Text = "You do not remember much. You only remember darkness, pain and hunger." + Environment.NewLine + "But now, sometime after the last beating, you start to remember:";

                    //add radio buttons
                    //Warrior
                    RadioButton rbtn_1_Warrior = new RadioButton();
                    rbtn_1_Warrior.Font = new Font("Arial", 10);
                    rbtn_1_Warrior.ForeColor = Color.White;
                    rbtn_1_Warrior.Location = new Point(0, 100);
                    rbtn_1_Warrior.AutoSize = true;
                    rbtn_1_Warrior.Text = "You are a warrior, a veteran of a thousand battles. You were wounded in battle and forced to surrender," + Environment.NewLine + "but not before leaving a mountain of bodies. You are best at combat.";
                    rbtn_1_Warrior.CheckedChanged += Rbtn_1_Warrior_CheckedChanged;

                    //Thief
                    rbtn_1_Thief.Font = new Font("Arial", 10);
                    rbtn_1_Thief.ForeColor = Color.White;
                    rbtn_1_Thief.Location = new Point(0, 150);
                    rbtn_1_Thief.AutoSize = true;
                    rbtn_1_Thief.Text = "You are a thief,swift and nimble,but nevertheless caught in what you called The One Last Job. You are best at stealth.";
                    rbtn_1_Thief.CheckedChanged += Rbtn_1_Thief_CheckedChanged;

                    //Noble
                    rbtn_1_Noble.Font = new Font("Arial", 10);
                    rbtn_1_Noble.ForeColor = Color.White;
                    rbtn_1_Noble.Location = new Point(0, 200);
                    rbtn_1_Noble.AutoSize = true;
                    rbtn_1_Noble.Text = "You are a noble, loyal to the king. Your rival framed you for treason and had you thrown in prison." + Environment.NewLine + "You are best at persuasion.";
                    rbtn_1_Noble.CheckedChanged += Rbtn_1_Noble_CheckedChanged;

                    //add button
                    btn_1_1.Font = new Font("Arial", 10);
                    btn_1_1.BackColor = Color.White;
                    btn_1_1.AutoSize = true;
                    btn_1_1.Text = "Continue";
                    btn_1_1.Location = new Point(340, 250);
                    btn_1_1.Click += Btn_1_1_Click;

                    pnl_Main.Controls.Add(lbl_1_1);
                    pnl_Main.Controls.Add(rbtn_1_Warrior);
                    pnl_Main.Controls.Add(rbtn_1_Thief);
                    pnl_Main.Controls.Add(rbtn_1_Noble);
                    break;

                case 1:
                    switch (UpdateP2)
                    {
                        case 1:
                            //add label
                            Label lbl_2_1 = new Label();
                            lbl_2_1.AutoSize = true;
                            lbl_2_1.Font = new Font("Arial", 12);
                            lbl_2_1.ForeColor = Color.White;
                            lbl_2_1.Location = new Point(0, 0);
                            lbl_2_1.Text = "Your wounds are yet to be healed. You must break out of your enemy's prison and get back to your allies, " + Environment.NewLine + "inform them of the defeat. But how?";
                            pnl_Main.Controls.Add(lbl_2_1);
                            UpdateP2 = 0;
                            break;
                        case 2:
                            //add label
                            Label lbl_2_2 = new Label();
                            lbl_2_2.AutoSize = true;
                            lbl_2_2.Font = new Font("Arial", 12);
                            lbl_2_2.ForeColor = Color.White;
                            lbl_2_2.Location = new Point(0, 0);
                            lbl_2_2.Text = "Your partner is dead and you are scheduled for exucution. You must break out and save yourself. But how?";
                            pnl_Main.Controls.Add(lbl_2_2);
                            UpdateP2 = 0;
                            break;
                        case 3:
                            //add label
                            Label lbl_2_3 = new Label();
                            lbl_2_3.AutoSize = true;
                            lbl_2_3.Font = new Font("Arial", 12);
                            lbl_2_3.ForeColor = Color.White;
                            lbl_2_3.Location = new Point(0, 0);
                            lbl_2_3.Text = "Thankfuly, your family is out of the city. You must break out and warn them. But how?";
                            pnl_Main.Controls.Add(lbl_2_3);
                            UpdateP2 = 0;
                            break;
                    }
                    //add radio buttons
                    //Warrior
                    rbtn_2_Warrior.Enabled = true;
                    rbtn_2_Warrior.Font = new Font("Arial", 10);
                    rbtn_2_Warrior.ForeColor = Color.White;
                    rbtn_2_Warrior.Location = new Point(0, 100);
                    rbtn_2_Warrior.AutoSize = true;
                    rbtn_2_Warrior.Text = "This is an old prison.You have developed your strength so much,you break the bars with your bare hands.";
                    pnl_Main.Controls.Add(rbtn_2_Warrior);
                    rbtn_2_Warrior.CheckedChanged += Rbtn_2_Warrior_CheckedChanged;
                    if (StrengthCheck == false) rbtn_2_Warrior.Enabled = false;

                    //Thief
                    rbtn_2_Thief.Enabled = true;
                    rbtn_2_Thief.Font = new Font("Arial", 10);
                    rbtn_2_Thief.ForeColor = Color.White;
                    rbtn_2_Thief.Location = new Point(0, 150);
                    rbtn_2_Thief.AutoSize = true;
                    rbtn_2_Thief.Text = "You always wondered why they leave such big gaps between bars. Sneaking out is a joke for you.";
                    pnl_Main.Controls.Add(rbtn_2_Thief);
                    rbtn_2_Thief.CheckedChanged += Rbtn_2_Thief_CheckedChanged;
                    if (AgilityCheck == false) rbtn_2_Thief.Enabled = false;

                    //Noble
                    rbtn_2_Noble.Font = new Font("Arial", 10);
                    rbtn_2_Noble.ForeColor = Color.White;
                    rbtn_2_Noble.Location = new Point(0, 200);
                    rbtn_2_Noble.AutoSize = true;
                    rbtn_2_Noble.Text = "The guards here are dim-witted. Nobody smart stays a prison guard for long. " + Environment.NewLine + "You convince the guard that you are here on purpose, by the king's orders, to report on the guards performance";
                    pnl_Main.Controls.Add(rbtn_2_Noble);
                    rbtn_2_Noble.CheckedChanged += Rbtn_2_Noble_CheckedChanged;
                    if (CharismaCheck == false) rbtn_2_Noble.Enabled = false;

                    //add button
                    btn_2_1.Font = new Font("Arial", 10);
                    btn_2_1.BackColor = Color.White;
                    btn_2_1.AutoSize = true;
                    btn_2_1.Text = "Continue";
                    btn_2_1.Location = new Point(340, 250);
                    btn_2_1.Click += Btn_2_1_Click;
                    break;
                case 2:
                    Label lbl_3_1 = new Label();
                    lbl_3_1.AutoSize = true;
                    lbl_3_1.Font = new Font("Arial", 12);
                    lbl_3_1.ForeColor = Color.White;
                    lbl_3_1.Location = new Point(0, 0);
                    lbl_3_1.Text = "The guard has his back turned to you. What do you do?";
                    pnl_Main.Controls.Add(lbl_3_1);

                    rbtn_3_Death.Font = new Font("Arial", 10);
                    rbtn_3_Death.ForeColor = Color.White;
                    rbtn_3_Death.Location = new Point(0, 100);
                    rbtn_3_Death.AutoSize = true;
                    rbtn_3_Death.Text = "Attack the guard from behind";
                    rbtn_3_Death.CheckedChanged += Rbtn_3_Death_CheckedChanged;

                    rbtn_3_Life.Font = new Font("Arial", 10);
                    rbtn_3_Life.ForeColor = Color.White;
                    rbtn_3_Life.Location = new Point(0, 150);
                    rbtn_3_Life.AutoSize = true;
                    rbtn_3_Life.Text = "Attempt to sneak away";
                    rbtn_3_Life.CheckedChanged += Rbtn_3_Life_CheckedChanged;

                    btn_3_1.Font = new Font("Arial", 10);
                    btn_3_1.BackColor = Color.White;
                    btn_3_1.AutoSize = true;
                    btn_3_1.Text = "Continue";
                    btn_3_1.Location = new Point(340, 250);
                    btn_3_1.Click += Btn_3_1_Click;

                    pnl_Main.Controls.Add(rbtn_3_Death);
                    pnl_Main.Controls.Add(rbtn_3_Life);
                    break;
                case 3:
                    if (AgilityCheck == true)
                    {
                        Label lbl_4_1 = new Label();
                        lbl_4_1.AutoSize = true;
                        lbl_4_1.Font = new Font("Arial", 12);
                        lbl_4_1.ForeColor = Color.White;
                        lbl_4_1.Location = new Point(0, 0);
                        lbl_4_1.Text = "You succesfuly sneaked away";
                        pnl_Main.Controls.Add(lbl_4_1);

                        Button btn_4_1 = new Button();
                        btn_4_1.Font = new Font("Arial", 10);
                        btn_4_1.BackColor = Color.White;
                        btn_4_1.AutoSize = true;
                        btn_4_1.Text = "Continue";
                        btn_4_1.Location = new Point(340, 250);
                        btn_4_1.Click += Btn_4_1_Click;
                        pnl_Main.Controls.Add(btn_4_1);
                    }
                    else
                    {
                        UpdateP = 9;
                        UpdatePanel();
                    }
                    break;
                case 4:
                    if (invslct.ShowDialog() == DialogResult.OK)
                    {
                        ChangeInventory();
                        UpdateP = 5;
                        UpdatePanel();
                    }
                    break;
                case 5:
                    Label lbl_5_1 = new Label();
                    lbl_5_1.AutoSize = true;
                    lbl_5_1.Font = new Font("Arial", 12);
                    lbl_5_1.ForeColor = Color.White;
                    lbl_5_1.Location = new Point(0, 0);
                    lbl_5_1.Text = "You managed to get away from the main prison room. You must now choose where to go from here";
                    pnl_Main.Controls.Add(lbl_5_1);

                    rbtn_SneakAway.Font = new Font("Arial", 10);
                    rbtn_SneakAway.ForeColor = Color.White;
                    rbtn_SneakAway.Location = new Point(0, 120);
                    rbtn_SneakAway.AutoSize = true;
                    rbtn_SneakAway.Text = "Attempt to sneak away through the ventilation shafts. This prison is underground, but the guards still need air to survive.";
                    rbtn_SneakAway.CheckedChanged += Rbtn_SneakAway_CheckedChanged;

                    rbtn_FightToFreedom.Font = new Font("Arial", 10);
                    rbtn_FightToFreedom.ForeColor = Color.White;
                    rbtn_FightToFreedom.Location = new Point(0, 160);
                    rbtn_FightToFreedom.AutoSize = true;
                    rbtn_FightToFreedom.Text = "Attempt to fight your way to freedom. Those puny guards stand no chance.";
                    rbtn_FightToFreedom.CheckedChanged += Rbtn_FightToFreedom_CheckedChanged;

                    rbtn_ImpersonateAGuard.Font = new Font("Arial", 10);
                    rbtn_ImpersonateAGuard.ForeColor = Color.White;
                    rbtn_ImpersonateAGuard.Location = new Point(0, 200);
                    rbtn_ImpersonateAGuard.AutoSize = true;
                    rbtn_ImpersonateAGuard.Text = "Attemot to impersonate a guard. Why not just simply walk out?";
                    rbtn_ImpersonateAGuard.CheckedChanged += Rbtn_ImpersonateAGuard_CheckedChanged;

                    btn_5_1.Font = new Font("Arial", 10);
                    btn_5_1.BackColor = Color.White;
                    btn_5_1.AutoSize = true;
                    btn_5_1.Text = "Continue";
                    btn_5_1.Location = new Point(300, 250);
                    btn_5_1.Click += Btn_5_1_Click;
                    btn_5_1.Enabled = true;

                    pnl_Main.Controls.Add(rbtn_ImpersonateAGuard);
                    pnl_Main.Controls.Add(rbtn_SneakAway);
                    pnl_Main.Controls.Add(rbtn_FightToFreedom);
                    break;
                case 6:
                    if (AgilityCheck == false)
                    {
                        Label lbl_6_1 = new Label();
                        lbl_6_1.AutoSize = true;
                        lbl_6_1.Font = new Font("Arial", 12);
                        lbl_6_1.ForeColor = Color.White;
                        lbl_6_1.Location = new Point(0, 0);
                        lbl_6_1.Text = "Because you were not accustomed to climbing through narrow places you fell. The guards quickly recaptured you.";
                        pnl_Main.Controls.Add(lbl_6_1);
                        Outcome = 1;
                    }

                    else if (invslct.rbtn_Armor.Checked)
                    {
                        Label lbl_6_2 = new Label();
                        lbl_6_2.AutoSize = true;
                        lbl_6_2.Font = new Font("Arial", 12);
                        lbl_6_2.ForeColor = Color.White;
                        lbl_6_2.Location = new Point(0, 0);
                        lbl_6_2.Text = "Your armor weighed you down and you fell. The guards quickly recaptured you.";
                        pnl_Main.Controls.Add(lbl_6_2);
                        Outcome = 1;
                    }
                    else
                    {
                        Label lbl_6_3 = new Label();
                        lbl_6_3.AutoSize = true;
                        lbl_6_3.Font = new Font("Arial", 12);
                        lbl_6_3.ForeColor = Color.White;
                        lbl_6_3.Location = new Point(0, 0);
                        lbl_6_3.Text = "You succesfuly managed to climb through the ventilation shafts.";
                        pnl_Main.Controls.Add(lbl_6_3);
                        Outcome = 2;
                    }
                    Button btn_6_1 = new Button();
                    btn_6_1.Font = new Font("Arial", 10);
                    btn_6_1.BackColor = Color.White;
                    btn_6_1.AutoSize = true;
                    btn_6_1.Text = "Continue";
                    btn_6_1.Location = new Point(340, 250);
                    btn_6_1.Click += Btn_6_1_Click;
                    pnl_Main.Controls.Add(btn_6_1);
                    break;
                case 7:
                    if (StrengthCheck == true && (invslct.rbtn_Sword.Checked || invslct.rbtn_Spear.Checked))
                    {
                        Label lbl_7_1 = new Label();
                        lbl_7_1.AutoSize = true;
                        lbl_7_1.Font = new Font("Arial", 12);
                        lbl_7_1.ForeColor = Color.White;
                        lbl_7_1.Location = new Point(0, 0);
                        lbl_7_1.Text = "You succesfuly managed to defeat all the guards that stood in your way. You truly are a great warrior!";
                        pnl_Main.Controls.Add(lbl_7_1);
                        Hurt = 1;
                        Outcome = 2;
                    }
                    else if (StrengthCheck == false && invslct.rbtn_Armor.Checked && invslct.rbtn_Spear.Checked)
                    {
                        Label lbl_7_2 = new Label();
                        lbl_7_2.AutoSize = true;
                        lbl_7_2.Font = new Font("Arial", 12);
                        lbl_7_2.ForeColor = Color.White;
                        lbl_7_2.Location = new Point(0, 0);
                        lbl_7_2.Text = "You managed to defeat all the guards, but at a great cost. You only survived because you were wearing armor" + Environment.NewLine + "and because your spear proved to be advantageous agains the enemy's big swords in narrow corridors" + Environment.NewLine + "of the prison";
                        pnl_Main.Controls.Add(lbl_7_2);
                        Hurt = 1;
                        ChangeStats();
                        Outcome = 2;
                    }
                    else
                    {
                        Label lbl_7_3 = new Label();
                        lbl_7_3.AutoSize = true;
                        lbl_7_3.Font = new Font("Arial", 12);
                        lbl_7_3.ForeColor = Color.White;
                        lbl_7_3.Location = new Point(0, 0);
                        lbl_7_3.Text = "You underestimated your enemy and overestimated your own prowess in combat. You were defeated. Perhaps the weapons you chose proved to not be so effective?";
                        pnl_Main.Controls.Add(lbl_7_3);
                        Outcome = 1;
                    }
                    btn_7_1.Font = new Font("Arial", 10);
                    btn_7_1.BackColor = Color.White;
                    btn_7_1.AutoSize = true;
                    btn_7_1.Text = "Continue";
                    btn_7_1.Location = new Point(340, 250);
                    btn_7_1.Click += Btn_7_1_Click;
                    pnl_Main.Controls.Add(btn_7_1);
                    break;
                case 8:
                    if (CharismaCheck == true && invslct.rbtn_Armor.Checked)
                    {
                        Label lbl_8_1 = new Label();
                        lbl_8_1.AutoSize = true;
                        lbl_8_1.Font = new Font("Arial", 12);
                        lbl_8_1.ForeColor = Color.White;
                        lbl_8_1.Location = new Point(0, 0);
                        lbl_8_1.Text = "You managed to fool all the guards and simply walked out. It was easy for you, but no one else would have managed to do it.";
                        pnl_Main.Controls.Add(lbl_8_1);
                        Outcome = 2;
                    }
                    if (!invslct.rbtn_Armor.Checked)
                    {
                        Label lbl_8_2 = new Label();
                        lbl_8_2.AutoSize = true;
                        lbl_8_2.Font = new Font("Arial", 12);
                        lbl_8_2.ForeColor = Color.White;
                        lbl_8_2.Location = new Point(0, 0);
                        lbl_8_2.Text = "What were you thinking? You can't just simply walk out if you don't even look like a guard? Where is your armor? The guards attack you!";
                        pnl_Main.Controls.Add(lbl_8_2);
                        Outcome = 1;
                    }
                    if (CharismaCheck == false)
                    {
                        Label lbl_8_3 = new Label();
                        lbl_8_3.AutoSize = true;
                        lbl_8_3.Font = new Font("Arial", 12);
                        lbl_8_3.ForeColor = Color.White;
                        lbl_8_3.Location = new Point(0, 0);
                        lbl_8_3.Text = "What were you thinking? The guards see that you are nervous and try to question you. Your accent gives you away. The guards attack you!";
                        pnl_Main.Controls.Add(lbl_8_3);
                        Outcome = 1;
                    }
                    btn_8_1.Font = new Font("Arial", 10);
                    btn_8_1.BackColor = Color.White;
                    btn_8_1.AutoSize = true;
                    btn_8_1.Text = "Continue";
                    btn_8_1.Location = new Point(340, 250);
                    btn_8_1.Click += Btn_8_1_Click;
                    pnl_Main.Controls.Add(btn_8_1);
                    break;
                case 9:
                    Label lbl_9_1 = new Label();
                    lbl_9_1.AutoSize = true;
                    lbl_9_1.Font = new Font("Arial", 12);
                    lbl_9_1.ForeColor = Color.White;
                    lbl_9_1.Location = new Point(0, 0);
                    lbl_9_1.Text = "Even though you tried your best, you were caught and imprisoned once again. " + Environment.NewLine + "This time guards didn't leave your side all the way to the execution. Better luck next time!";
                    pnl_Main.Controls.Add(lbl_9_1);

                    btnRestart_9.Font = new Font("Arial", 10);
                    btnRestart_9.BackColor = Color.White;
                    btnRestart_9.AutoSize = true;
                    btnRestart_9.Text = "Restart";
                    btnRestart_9.Location = new Point(340, 250);
                    btnRestart_9.Click += BtnRestart_9_Click;
                    pnl_Main.Controls.Add(btnRestart_9);
                    break;
                case 10:
                    Label lbl_Win = new Label();
                    lbl_Win.AutoSize = true;
                    lbl_Win.Font = new Font("Arial", 12);
                    lbl_Win.ForeColor = Color.White;
                    lbl_Win.Location = new Point(0, 0);
                    lbl_Win.Text = "You have succesfuly escaped this prison! Nothing could stand in your way!" + Environment.NewLine + "The only question that remains: What to do now?";
                    pnl_Main.Controls.Add(lbl_Win);

                    btn_Win.Font = new Font("Arial", 10);
                    btn_Win.BackColor = Color.White;
                    btn_Win.AutoSize = true;
                    btn_Win.Text = "Click here" + Environment.NewLine + "if you want to play again";
                    btn_Win.Location = new Point(300, 220);
                    btn_Win.Click += BtnRestart_9_Click;
                    pnl_Main.Controls.Add(btn_Win);
                    break;
            }
        }

        private void Btn_8_1_Click(object sender, EventArgs e)
        {
            if (Outcome == 1) UpdateP = 7;
            else if (Outcome == 2) UpdateP = 10;
            UpdatePanel();
        }

        private void Btn_5_1_Click(object sender, EventArgs e)
        {
            UpdatePanel();
        }

        private void Btn_7_1_Click(object sender, EventArgs e)
        {
            if (Outcome == 1) UpdateP = 9;
            else if (Outcome == 2) UpdateP = 10;
            UpdatePanel();
            ChangeStats();
        }

        private void Btn_6_1_Click(object sender, EventArgs e)
        {
            if (Outcome == 1) UpdateP = 9;
            else if (Outcome == 2) UpdateP = 10;
            UpdatePanel();
        }

        private void Rbtn_ImpersonateAGuard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateP = 8;
            ButtonCheck = 4;
            CheckButton();
        }

        private void Rbtn_FightToFreedom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateP = 7;
            ButtonCheck = 4;
            CheckButton();
        }

        private void Rbtn_SneakAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateP = 6;
            ButtonCheck = 4;
            CheckButton();
        }


        private void Btn_4_1_Click(object sender, EventArgs e)
        {
            UpdateP = 5;
            UpdatePanel();
        }

        private void BtnRestart_9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void Btn_3_1_Click(object sender, EventArgs e)
        {
            UpdatePanel();
        }

        private void Rbtn_3_Life_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck = 3;
            UpdateP = 3;
            CheckButton();
        }

        private void Rbtn_3_Death_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck = 3;
            UpdateP = 4;
            mnuHint4.Visible = true;
            CheckButton();
        }

        private void CheckButton()
        {
            switch (ButtonCheck)
            {
                case 1:
                    pnl_Main.Controls.Add(btn_1_1);
                    break;
                case 2:
                    pnl_Main.Controls.Add(btn_2_1);
                    break;
                case 3:
                    pnl_Main.Controls.Add(btn_3_1);
                    break;
                case 4:
                    pnl_Main.Controls.Add(btn_5_1);
                    break;

            }
            ButtonCheck = 0;
        }

        public void Btn_1_1_Click(object sender, EventArgs e)
        {
            ChangeStats();
            mnuHint3.Visible = true;
            UpdateP = 1;
            UpdatePanel();
        }

        public void Btn_2_1_Click(object sender, EventArgs e)
        {
            UpdateP = 2;
            UpdatePanel();
        }

        private void Rbtn_2_Noble_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck = 2;
            CheckButton();
        }

        private void Rbtn_2_Thief_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck = 2;
            CheckButton();
        }

        private void Rbtn_1_Noble_CheckedChanged(object sender, EventArgs e)
        {
            Statistic = 3;
            UpdateP2 = 3;
            ButtonCheck = 1;
            CheckButton();
        }

        private void Rbtn_1_Thief_CheckedChanged(object sender, EventArgs e)
        {
            Statistic = 2;
            UpdateP2 = 2;
            ButtonCheck = 1;
            CheckButton();
        }

        public void Rbtn_1_Warrior_CheckedChanged(object sender, EventArgs e)
        {
            Statistic = 1;
            UpdateP2 = 1;
            ButtonCheck = 1;
            CheckButton();
        }

        private void Rbtn_2_Warrior_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCheck = 2;
            CheckButton();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the Start button.", "Hint");
        }

        private void mnuHint2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Each backstory changes your stats differently.", "Hint");
        }
        private void mnuHint3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't do some actions because of your stats and earlier choices.", "Hint");
        }

        private void mnuHint4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carefuly consider what items you want to take. Not all will help you, you must consider how you want to break out", "Hint");
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStats = true;
            ChangeStats();
        }


        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OTHER WAY PRODUCED TOO MANY BUGS, BUT NOW YOU HAVE TO RE-CHOSE SETTINGS
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close(); //to turn off current app
        }

        public void ChangeStats()
        {
            Stats MyStats = new Stats();
            switch (Statistic)
            {
                case 0:
                    MyStats.Agility = 0;
                    MyStats.Strenght = 0;
                    MyStats.Charisma = 0;
                    MyStats.Health = 0;
                    if (ShowStats == true)
                    {
                        MessageBox.Show("Health: " + MyStats.Health.ToString() + Environment.NewLine + "Backstory: " + MyStats.Backstory + Environment.NewLine + "Strength: " + MyStats.Strenght.ToString() + Environment.NewLine + "Agility: " + MyStats.Agility.ToString() + Environment.NewLine + "Charisma: " + MyStats.Charisma.ToString(), "Stats");
                        ShowStats = false;
                    }
                    break;
                case 1:
                    MyStats.Agility = 5;
                    MyStats.Strenght = 10;
                    MyStats.Charisma = 2;
                    MyStats.Health = 70;
                    MyStats.Backstory = "Warrior";
                    if (ShowStats == true)
                    {
                        MessageBox.Show("Health: " + MyStats.Health.ToString() + Environment.NewLine + "Backstory: " + MyStats.Backstory + Environment.NewLine + "Strength: " + MyStats.Strenght.ToString() + Environment.NewLine + "Agility: " + MyStats.Agility.ToString() + Environment.NewLine + "Charisma: " + MyStats.Charisma.ToString(), "Stats");
                        ShowStats = false;
                    }
                    StrengthCheck = true;
                    break;
                case 2:
                    MyStats.Agility = 10;
                    MyStats.Strenght = 5;
                    MyStats.Charisma = 2;
                    MyStats.Health = 100;
                    MyStats.Backstory = "Thief";
                    if (ShowStats == true)
                    {
                        MessageBox.Show("Health: " + MyStats.Health.ToString() + Environment.NewLine + "Backstory: " + MyStats.Backstory + Environment.NewLine + "Strength: " + MyStats.Strenght.ToString() + Environment.NewLine + "Agility: " + MyStats.Agility.ToString() + Environment.NewLine + "Charisma: " + MyStats.Charisma.ToString(), "Stats");
                        ShowStats = false;
                    }
                    AgilityCheck = true;

                    break;
                case 3:
                    MyStats.Agility = 5;
                    MyStats.Strenght = 2;
                    MyStats.Charisma = 10;
                    MyStats.Health = 100;
                    MyStats.Backstory = "Noble";
                    if (ShowStats == true)
                    {
                        MessageBox.Show("Health: " + MyStats.Health.ToString() + Environment.NewLine + "Backstory: " + MyStats.Backstory + Environment.NewLine + "Strength: " + MyStats.Strenght.ToString() + Environment.NewLine + "Agility: " + MyStats.Agility.ToString() + Environment.NewLine + "Charisma: " + MyStats.Charisma.ToString(), "Stats");
                        ShowStats = false;
                    }
                    CharismaCheck = true;
                    break;
            }
            if (Hurt == 1)
            {
                MyStats.Health = 50;
                lblHealth.Text = MyStats.Health.ToString();
            }
            if (Hurt == 2)
            {
                MyStats.Health = 20;
                lblHealth.Text = MyStats.Health.ToString();
            }
            lblHealth.Text = MyStats.Health.ToString();
        }

        private void ChangeInventory()
        {
            if (ShowInventory == true)
            {
                if (invslct.rbtn_Sword.Checked)
                {
                    Sword = "Sword";
                }
                if (invslct.rbtn_Spear.Checked)
                {
                    Spear = "Spear";
                }
                if (invslct.rbtn_Dagger.Checked)
                {
                    Dagger = "Dagger";
                }
                if (invslct.rbtn_Armor.Checked)
                {
                    Armor = "Armor";
                }
                MessageBox.Show(Sword + Environment.NewLine + Spear + Environment.NewLine + Dagger + Environment.NewLine + Armor, "Inventory");
                ShowInventory = false;
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory = true;
            ChangeInventory();
        }

    }
}
