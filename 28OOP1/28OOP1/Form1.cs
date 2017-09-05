using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "EKLE")
            {
                Araba a1 = new Araba();
                a1.fiyat = (double)numFiyat.Value;
                a1.marka = txtMarka.Text;
                a1.plaka = txtPlaka.Text;
                a1.renk = cboxRenk.SelectedItem.ToString();

                listAraclar.Items.Add(a1);
                Temizle();
            }
            else
            {
                Araba car = (Araba)listAraclar.SelectedItem;
                listAraclar.Items.Remove(car);
                car.fiyat = (double)numFiyat.Value;
                car.marka = txtMarka.Text;
                car.plaka = txtPlaka.Text;
                car.renk = cboxRenk.SelectedItem.ToString();
                listAraclar.Items.Add(car);
            }
            
        }

        private void listAraclar_Click(object sender, EventArgs e)
        {
            try
            {
                Araba car = (Araba)listAraclar.SelectedItem;
                txtMarka.Text = car.marka;
                txtPlaka.Text = car.plaka;
                numFiyat.Value = (decimal)car.fiyat;
                int index = cboxRenk.Items.IndexOf(car.renk);
                cboxRenk.SelectedIndex = index;
                btnEkle.Text = "GÜNCELLE";
                btnEkle.BackColor = Color.Orange;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void Temizle()
        {
            txtMarka.Clear();
            txtPlaka.Clear();
            numFiyat.Value = 100;
            cboxRenk.SelectedIndex = 0;
        }

        private void listAraclar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Araba car = (Araba)listAraclar.SelectedItem;
                listAraclar.Items.Remove(car);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void checkBoxEkleGüncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEkleGüncelle.Text == "Ekle")
            {
                btnEkle.Text = "EKLE";
                btnEkle.BackColor = Color.DarkGreen;
                checkBoxEkleGüncelle.Text = "Güncelle";
            }
            else
            {
                btnEkle.Text = "GÜNCELLE";
                btnEkle.BackColor = Color.Orange;
                checkBoxEkleGüncelle.Text = "Ekle";
            }
        }
    }
    //class Car
    //{

    //}
}
