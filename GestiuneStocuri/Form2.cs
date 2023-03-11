using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneStocuri
{
    public partial class Form2 : Form
    {
        public int[] stocuri;

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int ymax = stocuri.Max();
            float rapScalare = panel1.Height / ymax;
            Brush[] culori = new Brush[]
            {
                Brushes.LightBlue,Brushes.LightPink
            };
            int lat = panel1.Width / 10;
            int vb = panel1.Bottom;
            for (int i = 0; i < 10; i++)
            {
                g.FillRectangle(culori[i % culori.Length], i * lat, vb - stocuri[i] * rapScalare, lat, stocuri[i] * rapScalare);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
