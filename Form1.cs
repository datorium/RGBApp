using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBApp
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void ColorBox_Click(object sender, EventArgs e)
        {
            int red = rand.Next(0, 256);
            int green = rand.Next(0, 256);
            int blue = rand.Next(0, 256);

            ColorBox.BackColor = Color.FromArgb(red, green, blue);
        }

        private void ColorBox_MouseEnter(object sender, EventArgs e)
        {
            ColorBox.BackColor = Color.Black;
        }

        private void ColorBox_MouseLeave(object sender, EventArgs e)
        {
            ColorBox.BackColor = Color.Red;
        }

        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            //pixel bulb can have value between 0-255
            int red = (int)NumericRed.Value;
            int green = (int)NumericGreen.Value;
            int blue = (int)NumericBlue.Value;

            RedBox.BackColor = Color.FromArgb(red, 0, 0);
            ColorBox.BackColor = Color.FromArgb(red, green, blue);
        }

        private void NumericGreen_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)NumericRed.Value;
            int green = (int)NumericGreen.Value;
            int blue = (int)NumericBlue.Value;

            GreenBox.BackColor = Color.FromArgb(0, green, 0);
            ColorBox.BackColor = Color.FromArgb(red, green, blue);
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)NumericRed.Value;
            int green = (int)NumericGreen.Value;
            int blue = (int)NumericBlue.Value;

            BlueBox.BackColor = Color.FromArgb(0, 0, blue);
            ColorBox.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
