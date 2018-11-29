using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingAStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yValue;
            int xValue;
            float starSize;

            Graphics g = this.CreateGraphics();
            Pen starPen = new Pen(Color.Red);

            xValue = Convert.ToInt16(textBox1.Text);
            yValue = Convert.ToInt16(textBox2.Text);
            starSize = Convert.ToInt16(textBox3.Text);

            Refresh();
            DrawStar(starPen, xValue, yValue, starSize);
        }


        public void DrawStar(Pen star, int x, int y, float size)
        {
            Graphics g = this.CreateGraphics();
            float scale;
            scale = size / 170;

           // g.DrawRectangle(star, x, y, size, size);

            g.DrawLine(star, 0 * scale + x, 70 * scale + y, 70 * scale + x, 70 * scale + y);
            g.DrawLine(star, 70 * scale + x, 70 * scale + y, 90 * scale + x, 10 * scale + y);
            g.DrawLine(star, 90 * scale + x, 10 * scale + y, 110 * scale + x, 70 * scale + y);
            g.DrawLine(star, 110 * scale + x, 70 * scale + y, 170 * scale + x, 70 * scale + y);
            g.DrawLine(star, 170 * scale + x, 70 * scale + y, 125 * scale + x, 110 * scale + y);
            g.DrawLine(star, 125 * scale + x, 110 * scale + y, 140 * scale + x, 170 * scale + y);
            g.DrawLine(star, 140 * scale + x, 170 * scale + y, 90 * scale + x, 140 * scale + y);
            g.DrawLine(star, 90 * scale + x, 140 * scale + y, 40 * scale + x, 170 * scale + y);
            g.DrawLine(star, 40 * scale + x, 170 * scale + y, 60 * scale + x, 110 * scale + y);
            g.DrawLine(star, 60 * scale + x, 110 * scale + y, 0 * scale + x, 70 * scale + y);
            //    g.DrawLine(star, x2, y2, x3, y3);
            //    g.DrawLine(star, x3, y3, x1, y1);


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
