using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05OperatorlerIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sayi1 = 38;
            int sayi2 = 83;

            int toplam = sayi1 + sayi2;

            //MessageBox.Show(toplam.ToString());
            //MessageBox.Show("Sonuç : " + toplam);

            MessageBox.Show("Toplam : " + (sayi1 + sayi2));
            MessageBox.Show("Toplam : " + sayi1 + sayi2);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int sayi1 = 93;
            int sayi2 = 39;

            int fark = sayi1 - sayi2;

            MessageBox.Show("Fark : " + fark);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayi1 = 11;
            int sayi2 = 88;

            int sonuc = sayi1 * sayi2;
            MessageBox.Show("Çarpım: " + sonuc);
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            int sayi1 = 83;
            int sayi2 = 5;

            double bolum = sayi1 / sayi2;
            MessageBox.Show(bolum.ToString());
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int sayi1 = 15;
            int sayi2 = 4;
            int mod = sayi1 % sayi2;
            //MessageBox.Show("Mod = " + mod);

            Debug.WriteLine("Mod = {0}", mod); //System.Diagnostics;
            Debug.WriteLine("{0} mod {1} = {2}", sayi1, sayi2, mod);
        }

        private void btnArtAzalt_Click(object sender, EventArgs e)
        {
            int sayi = 8;
            //sayi= sayi + 1;
            sayi++;

            MessageBox.Show(sayi.ToString());

            sayi = 84;
            sayi--; // sayi = sayi - 1;

            MessageBox.Show(sayi.ToString());
        }
    }
}
