using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15WhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 

            //int i = 100;
            //while (i > 0)
            //{
            //    i--;
            //    listBox1.Items.Add(100 - i);
            //}
        }

        private void btnTabanDonusumu_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            int sonuc = 0;

            int basamak = 1;

            while (sayi > 0)
            {
                sonuc += (sayi % 2) * basamak;
                basamak *= 10;
                sayi /= 2;
            }

            MessageBox.Show(sonuc.ToString());
        }

        int sayac = 1;
        private void btnOyun_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            if (sayi == tahmin)
            {
                Text = "TEBRİKLER " + sayac + " kere de bildin";
                sayac = 0;
            }
            else
            {
                Text = "OLMADI BİR DAHA DENE";
            }

            sayac++;
        }

        int tahmin;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tahmin = rnd.Next(1, 2);
        }
    }
}
