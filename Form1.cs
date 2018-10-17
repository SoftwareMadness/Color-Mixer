using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using color.mix;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colormixer
{
    
    public partial class Form1 : Form
    {
        Color col;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBox2.BackColor;
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pictureBox1.BackColor;
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox4.BackColor = mix.Blend(pictureBox1.BackColor, pictureBox2.BackColor, 100.90);  
        }
       
    }
}
namespace color.mix
{
    public static class mix
    {
 public static Color Blend(this Color color, Color backColor, double amount)
        {
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }
    }
}
