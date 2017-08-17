using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] urunFiyat = new double[20];
        double[] turuncgillerFiyat = new double[3];
        double[] baklagillerFiyat = new double[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            cboxUrunler.Items.Add("Baklagiller");
            cboxUrunler.Items.Add("Turunçgiller");

            turuncgillerFiyat[0] = 3;
            turuncgillerFiyat[1] = 4;
            turuncgillerFiyat[2] = 8;

            baklagillerFiyat[0] = 5;
            baklagillerFiyat[1] = 3;
            baklagillerFiyat[2] = 4;
        }

        void BaklagilListele()
        {
            listUrunler.Items.Clear();
            listUrunler.Items.Add("Nohut\t\t5₺ (kg)");
            listUrunler.Items.Add("Bezelye\t\t3₺ (kg)");
            listUrunler.Items.Add("Fasulye\t\t4₺ (kg)");
        }

        void TuruncgilListele()
        {
            listUrunler.Items.Clear();
            listUrunler.Items.Add("Portakal\t\t3₺ (kg)");
            listUrunler.Items.Add("Mandalina\t4₺ (kg)");
            listUrunler.Items.Add("Limon\t\t8₺ (kg)");
        }

        private void cboxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboxUrunler.SelectedIndex;

            if(index == 0)
            {
                BaklagilListele();
                turuncgilMi = false;
            }
            else if (index == 1)
            {
                TuruncgilListele();
                turuncgilMi = true;
            }
        }

        int count = 0;
        bool turuncgilMi = false;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urun = listUrunler.SelectedItem.ToString();
            double kilo = (double)numKilo.Value;
            int index = listUrunler.SelectedIndex;

            if (turuncgilMi == true)
            {
                urunFiyat[count] = kilo * turuncgillerFiyat[index];
            }
            else
            {
                urunFiyat[count] = kilo * baklagillerFiyat[index];
            }
            
            listSepet.Items.Add(urun + "\tx " + kilo);

            count++;
            numKilo.Value = 1;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            foreach (var item in urunFiyat)
            {
                toplam += item;
            }

            MessageBox.Show($"Toplam Tutar: {toplam}₺");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            count = 0;
            listSepet.Items.Clear();
            listUrunler.Items.Clear();
            urunFiyat = new double[20];
            turuncgilMi = false;
        }
    }
}
