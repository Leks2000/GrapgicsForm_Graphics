using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrapgicsForm
{
  
    public partial class Form1 : Form
    {  
        private Graphics gr;
        private Pen p;
        private int  w, h;
        private double r, s;
        private int count = 0;
        LinearGradientBrush gradBrush;

        private void butClear_Click(object sender, EventArgs e)
        {
            gr.FillRectangle(new SolidBrush(Color.White), 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            count++;
            s = 0;
        }

        private void butGraf_Click(object sender, EventArgs e)
        {
         
            while (s < 20 * Math.PI )
            {
                if (count == 0)
                {

                    r = s / 2;
                    var x = r * Math.Cos(s);
                    var y = r * Math.Sin(s);
                    var x1 = Math.Round(x * 4) + w;
                    var y1 = Math.Round(y * 4) + h;
                    // MessageBox.Show($"{x1}, {y1}");
                    gr.FillRectangle(gradBrush, (int)x1, (int)y1, 5, 5);
                    s += 0.01;
                }
                else if (count == 1)
                {
                    int a = 26, c = 18, d = 14, b = 20;
                    double k = (a / (double)b) * s;
                    var x = (a - c) * Math.Cos(s) + d * Math.Cos(k);
                    var y = (a - c) * Math.Sin(s) - d * Math.Sin(k);
                    var x1 = Math.Round(x * 10) + w;
                    var y1 = Math.Round(y * 10) + h;
                    // MessageBox.Show($"{x1}, {y1}");
                    gr.FillRectangle(gradBrush, (int)x1, (int)y1, 5, 5);
                    s += 0.01;
                }
                else if (count == 2)
                {
                    var x = 6.2 * (Math.Cos(s) - (Math.Cos(3.1 * s) / 3.1));
                    var y = 6.2 * (Math.Sin(s) - (Math.Sin(3.1 * s) / 3.1));
                    var x1 = Math.Round(x * 20) + w;
                    var y1 = Math.Round(y * 20) + h;
                    // MessageBox.Show($"{x1}, {y1}");
                    gr.FillRectangle(gradBrush, (int)x1, (int)y1, 5, 5);
                    s += 0.005;
                }
                else if (count == 3)
                {
                    var x = 20 * (Math.Cos(s) + (Math.Cos(5 * s) / 5));
                    var y = 20 * (Math.Sin(s) - (Math.Sin(5 * s) / 5));
                    var x1 = Math.Round(x * 5) + w;
                    var y1 = Math.Round(y * 5) + h;
                    // MessageBox.Show($"{x1}, {y1}");
                    gr.FillRectangle(gradBrush, (int)x1, (int)y1, 5, 5);
                    s += 0.005;
                }
                else if (count == 4)
                {
                    var x = Math.Sin(s) * (Math.Exp(Math.Cos(s)) - 2 * Math.Cos(4 * s) + Math.Pow(Math.Sin((double)1 / 12.0 * s), 5));
                    var y = -Math.Cos(s) * (Math.Exp(Math.Cos(s)) - 2 * Math.Cos(4 * s) + Math.Pow(Math.Sin((double)1 / 12.0 * s), 5));
                    var x1 = Math.Round(x * 50) + w;
                    var y1 = Math.Round(y * 50) + h;
                    //MessageBox.Show($"{x1}, {y1}");
                    gr.FillRectangle(gradBrush, (int)x1, (int)y1, 5, 5);
                    s += 0.001;

                }
            }
            butClear_Click(sender, e);
        }

        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            var rect = new Rectangle(w, h, this.Width, this.Height);
            gradBrush = new LinearGradientBrush(rect, Color.Red, Color.Blue,LinearGradientMode.Vertical);
            s = 0; r = 100; w = this.Width / 2; h = this.Height / 2;
        }
    }
}
