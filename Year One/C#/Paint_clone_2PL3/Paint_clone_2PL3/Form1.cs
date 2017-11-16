using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint_clone_2PL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SaveFileDialog1.Filter = "PNG file|*.png|JPG file|*.jpg;*.jpeg|TIFF file|*.tiff|BMP file|*.bmp";
            SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        }

        Color currentColor = Color.Black;
        Color currentColor2 = Color.White;
        Font currentFont;
        Bitmap currentPicture;
        Graphics gr;
        Pen currentPen;
        Pen eraserPen = new Pen(Color.White);
        float PenWidth = 1.0f;
        string Path = string.Empty;//where the file is saved
        bool ChangeMade = false;
        Point startLocation;
        Point endLocation;
        bool drawing;
        int height;
        int width;
        LinearGradientMode gradMode;

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = ColorDialog1.Color;
                ColorButton.BackColor = currentColor;
                UpdatePen();
            }
        }

        private void Color2Button_Click(object sender, EventArgs e)
        {
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor2 = ColorDialog1.Color;
                Color2Button.BackColor = currentColor2;
            }
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            if (FontDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFont = FontDialog1.Font;
                FontButton.Text = currentFont.Name + " " + currentFont.Size;
            }
        }

        private void P1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PenWidth = 1.0f;
            UpdatePen();
        }

        private void P2RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            PenWidth = 4.0f;
            UpdatePen();
        }

        private void P3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PenWidth = 8.0f;
            UpdatePen();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == string.Empty)
            {
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentPicture.Save(SaveFileDialog1.FileName);
                    Path = SaveFileDialog1.FileName;
                    ChangeMade = false;
                }
                currentPicture.Save(Path);
                ChangeMade = false;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPicture.Save(SaveFileDialog1.FileName);
                Path = SaveFileDialog1.FileName;
                ChangeMade = false;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangeMade)
            {
                DialogResult rez = MessageBox.Show("Do you want to save your masterpiece?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (rez == DialogResult.Yes)
                {
                    SaveAsToolStripMenuItem.PerformClick();
                    Application.Exit();
                }
                else if (rez == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult rez = MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rez == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentPicture = new Bitmap(MainPicture.Width, MainPicture.Height);
            gr = Graphics.FromImage(currentPicture);
            gr.Clear(Color.White);
            MainPicture.Image = currentPicture;
            ColorButton.BackColor = currentColor;
            Color2Button.BackColor = currentColor2;
            UpdatePen();
        }

        private void UpdatePen()
        {
            currentPen = new Pen(currentColor, PenWidth);
            eraserPen.Width = PenWidth * 3;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            MainPicture.Image = currentPicture;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = MessageBox.Show("Do you want to save your masterpiece and start painting a new one?", "Save?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rez == DialogResult.OK)
            {
                SaveAsToolStripMenuItem.PerformClick();
                ClearToolStripMenuItem.PerformClick();
                Path = String.Empty;
            }
        }

        private void MainPicture_Paint(object sender, PaintEventArgs e)
        {
            gr = this.CreateGraphics();
            gr = Graphics.FromImage(currentPicture);
        }

        private void MainPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (drawing == false)
                {
                    drawing = true;
                    startLocation = e.Location;
                }
                UpdatePicture();
            }
        }

        private void MainPicture_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                //save end location
                endLocation = e.Location;
                if (RectangleRadioButton.Checked)
                {
                    height = Math.Abs(endLocation.Y - startLocation.Y);
                    width = Math.Abs(endLocation.X - startLocation.X);
                    if (startLocation.X > endLocation.X)
                    {
                        startLocation.X = endLocation.X;
                    }
                    if (startLocation.Y > endLocation.Y)
                    {
                        startLocation.Y = endLocation.Y;
                    }
                    gr.DrawRectangle(currentPen, startLocation.X, startLocation.Y, width, height);
                }

                else if (GradientRectAngleRadioButton.Checked)
                {
                    height = Math.Abs(endLocation.Y - startLocation.Y);
                    width = Math.Abs(endLocation.X - startLocation.X);
                    if (startLocation.X > endLocation.X)
                    {
                        startLocation.X = endLocation.X;
                    }
                    if (startLocation.Y > endLocation.Y)
                    {
                        startLocation.Y = endLocation.Y;
                    }

                    if (height == 0 || width == 0) return;
                    LinearGradientBrush currentBrush = new LinearGradientBrush(new Rectangle(startLocation.X, startLocation.Y, width, height), currentColor, currentColor2, gradMode);
                    gr.FillRectangle(currentBrush, startLocation.X, startLocation.Y, width, height);
                }
                UpdatePicture();
                drawing = false;
            }
        }

        private void MainPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (ModernLineRadioButton.Checked)
                {
                    gr.DrawLine(currentPen, startLocation, e.Location);
                }

                else if (LineRadioButton.Checked)
                {
                    gr.DrawLine(currentPen, startLocation, e.Location);
                    startLocation = e.Location;
                }
                else if (EraserRadioButton.Checked)
                {
                    gr.DrawLine(eraserPen, startLocation, e.Location);
                    startLocation = e.Location;
                }
                UpdatePicture();
            }
        }
        private void UpdatePicture()
        {
            gr = Graphics.FromImage(currentPicture);
            MainPicture.Image = currentPicture;
        }

        private void GradientRectAngleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GradientRectAngleRadioButton.Checked)
            {
                gradientToolStripMenuItem.Visible = true;
                Color2Button.Visible = true;
            }
            else Color2Button.Visible = false;
        }

        private void TextRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TextRadioButton.Checked)
            {
                TextDrawTextBox.Visible = true;
            }
            else TextDrawTextBox.Visible = false;
        }

        private void ArcRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ArcRadioButton.Checked)
            {
                grbArc.Visible = true;
            }
            else grbArc.Visible = false;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradMode = LinearGradientMode.Horizontal;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradMode = LinearGradientMode.Vertical;
        }

        private void forwardDiagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradMode = LinearGradientMode.ForwardDiagonal;
        }

        private void backwardDiagonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradMode = LinearGradientMode.BackwardDiagonal;
        }
    }
}
