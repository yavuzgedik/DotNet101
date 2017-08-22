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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        Random rnd = new Random();
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Text = rnd.Next(1, 101).ToString();
            Text = i.ToString();
            i++;
        }
    }
}
