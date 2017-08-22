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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rasgeleSayi;
        List<int> sayilar = new List<int>();
        int turSayisi = 0;
        int count = 0;
        private void btnBah_Click(object sender, EventArgs e)
        {
            turSayisi = 0;
            timer1.Interval = 200;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (turSayisi == 15)
            {
                timer1.Interval = 500;
            }

            if (turSayisi == 18)
            {
                timer1.Interval = 800;
            }

            if (turSayisi == 20)
            {
                timer1.Stop();
            }
            else
            {
                sayilar.Clear();

                while (count < 6)
                {
                    rasgeleSayi = rnd.Next(1, 50);

                    if (!sayilar.Contains(rasgeleSayi))
                    {
                        sayilar.Add(rasgeleSayi);
                        count++;
                    }
                }
                count = 0;
                turSayisi++;
                this.Text = turSayisi.ToString();

                sayilar.Sort();
                label1.Text = sayilar[0].ToString();
                label2.Text = sayilar[1].ToString();
                label3.Text = sayilar[2].ToString();
                label4.Text = sayilar[3].ToString();
                label5.Text = sayilar[4].ToString();
                label6.Text = sayilar[5].ToString();
            }
        }
    }
}
