using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Degiskenler
{
    public partial class Form1 : Form
    {
        // Değişkenler, verileri kaydettiğimiz alanlardır.
        
        byte sayi; // 0-255 arasında bir değer ataması yapılabilir
        string metin; // metinsel ifadeler tutulur

        public Form1()
        {
            InitializeComponent();
            sayi = 5;
            metin = "2017 yılındayız.";

            byte number;
            sbyte numder2; // -128 127 arasınde bir değer alır

            short number3; // short secili iken F12'ye basarak ayrıntılara gidilebilir
            ushort number4;

            int number5;
            uint number6;

            long number7;
            ulong number8;


            float kesirli; // virgülden sonra 7 basamak duyarlı
            double kesirli2; // virgülden sonra 13-14 basamak duyarlı
            decimal kesirli3; // virgülden sonra 28 basmak duyarlı

            string isim = "Yavuz Gedik";
            string harf = "a";
            char c = 'y';


            bool bugunTatilMi = false;
            bool bugunDersVarMi = true;
            bool result = 10 > 2; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sayi.ToString());
            sayi = 10;
            MessageBox.Show(sayi.ToString());
            MessageBox.Show(metin);
        }

        private void btnMerhaba_Click(object sender, EventArgs e)
        {
            string gelenMetin = txtMetin.Text;
            MessageBox.Show("Merhaba " + gelenMetin);
            btnMerhaba.Text = gelenMetin;
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtMetin.Text;
        }
    }
}
