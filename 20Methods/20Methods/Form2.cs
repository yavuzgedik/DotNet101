using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        string TekCift(int sayi)
        {
            if (sayi % 2 == 0)
            {
                return "Çift";
            }
            else
            {
                return "Tek";
            }
        }
        void RenkDegistir(string color)
        {
            BackColor = Color.FromName(color);
            Text = BackColor.Name;
        }
        void RenkDegistir()
        {
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            BackColor = Color.FromArgb(red, green, blue);
        }
        Color ArkaPlanRengi()
        {
            return BackColor;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int num1 = (int)numBirinci.Value;
            int num2 = (int)numIkinci.Value;
            int toplam = Topla(num1, num2);

            MessageBox.Show($"Girdiğin Sayıların Toplamı: {toplam}");
        }
        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TekCift(int.Parse(txtSayi.Text)));
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            int sayi = rnd.Next(1, 10000);

            if(TekCift(sayi) == "Tek")
            {
                MessageBox.Show($"{sayi} tek olduğundan kaybettiniz!");
            }
            else
            {
                MessageBox.Show($"{sayi} çift olduğundan kazandınız!");
            }
        }
        private void cboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenkDegistir(cboxColor.SelectedItem.ToString());
        }
        private void btnRandomColor_Click(object sender, EventArgs e)
        {
            RenkDegistir();
        }

        private void btnWC_Click(object sender, EventArgs e)
        {
            Color c = ArkaPlanRengi();
            MessageBox.Show(c.Name);
            //System.Diagnostics.Process.Start("http://www.YavuzGedik.com"); 
        }
    }
}
