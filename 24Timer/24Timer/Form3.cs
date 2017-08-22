using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Timer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Timer tmr = new Timer();
        Random rnd = new Random();
        private void Form3_Load(object sender, EventArgs e)
        {
            tmr.Interval = 1000;
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            this.Width = rnd.Next(100, 500);
            this.Height = rnd.Next(100, 500);
            Point p = 
                new Point
                (
                    rnd.Next(0, Screen.PrimaryScreen.Bounds.Width - Width), 
                    rnd.Next(0, Screen.PrimaryScreen.Bounds.Height - Height)
                );
            this.Location = p;

            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            this.BackColor = color;

            this.Text = Width + "x" + Height;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
