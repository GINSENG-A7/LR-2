using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap picture = new Bitmap(pictureBox1.Image);
            int a, b;
            double k = (4.0) / 255;
            int brightness = 0;
            int gij = 0;
            for (a = 0; a < picture.Width; a++)
                for (b = 0; b < picture.Height; b++)
                {
                    brightness = (int)(255 * picture.GetPixel(a, b).GetBrightness());
                    gij = Convert.ToInt32((k) * (255 - brightness) * brightness);
                    Color c = Color.FromArgb(255, (int)gij, (int)gij, (int)gij);
                    picture.SetPixel(a, b, c);
                }
            pictureBox1.Image = picture;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap picture = new Bitmap(pictureBox1.Image);
            int a, b;
            double k = (1.0) / 255;
            int brightness = 0;
            int brightnessPlusThree = 0;
            int gij = 0;
            for (a = 0; a < picture.Width - 3; a++)
                for (b = 0; b < picture.Height - 3; b++)
                {
                    brightness = (int)(255 * picture.GetPixel(a, b).GetBrightness());
                    brightnessPlusThree = (int)(255 * picture.GetPixel(a + 3, b +
                    3).GetBrightness());
                    gij = Convert.ToInt32((k) * (255 - brightness) * brightnessPlusThree);
                    Color c = Color.FromArgb(255, (int)gij, (int)gij, (int)gij);
                    picture.SetPixel(a, b, c);
                }
            pictureBox1.Image = picture;
        }
    }
}
