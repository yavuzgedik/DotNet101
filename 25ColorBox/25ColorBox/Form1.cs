using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _25ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Color RasgeleRenk()
        {
            return Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int j = 0, z = 0;
            for (int i = 0; i < 30; i++)
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.BackColor = RasgeleRenk();
                btn.Click += Btn_Click;
                if (i > 9 && i < 20)
                {
                    btn.Left = btn.Width * j;
                    btn.Top = 10 + btn.Height * 1;
                    j++;
                }
                else if (i > 19)
                {
                    btn.Left = btn.Width * z;
                    btn.Top = 10 + btn.Height * 2;
                    z++;
                }
                else
                {
                    btn.Left = btn.Width * i;
                    btn.Top = 10;
                }
                this.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button seciliBtn = (Button)sender; //Button seciliBtn = sender as Button;
            this.BackColor = seciliBtn.BackColor;
        }
    }
}