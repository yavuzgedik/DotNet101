using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutRefParams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // OUT ile geriye değer dönmeyen bir metot dan geriye değer dönebiliriz.
        void GeriyeDegerDon(int sayi, out double firlatilanSonuc)
        {
            firlatilanSonuc = Math.Pow(sayi, 2);
        }

        private void btnOut1_Click(object sender, EventArgs e)
        {
            double yakalananSonuc;
            GeriyeDegerDon(12, out yakalananSonuc);
            MessageBox.Show(yakalananSonuc.ToString());
        }

        // OUT ile bir metot dan geriye birden fazla değer dönebiliriz.
        void Hesapla(int sayi1, int sayi2, out int toplam, out int cikarma, out long carpma, out double bolme, out byte mod)
        {
            toplam = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;
            mod = (byte)(sayi1 % sayi2);
        }
        private void btnOut2_Click(object sender, EventArgs e)
        {
            int toplam, cikarma;
            long carpma;
            double bolme;
            byte mod;

            Hesapla(8, 3, out toplam, out cikarma, out carpma, out bolme, out mod);
        }

        // PARAMS ile bir metotun kaç parametre alacağınızı bilemediğimiz durumlarda çözüm üretiriz. Bir dizi şeklinde dilediğimiz kadar paremetre gönderebiliriz.
        double FiyatHesapla(params double[] fiyatlar)
        {
            double toplamFiyat = 0;
            foreach (var item in fiyatlar)
            {
                toplamFiyat += item;
            }
            return toplamFiyat;
        }
        private void btnParams_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FiyatHesapla(193.20,56.55,68.74,123.54,02.03).ToString());
        }

        void Arttir(ref int sayi)
        {
            sayi++;
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            int number = 8;
            Arttir(ref number);
            MessageBox.Show(number.ToString());
        }
    }
}
