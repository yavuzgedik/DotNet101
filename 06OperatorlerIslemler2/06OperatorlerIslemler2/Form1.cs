using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06OperatorlerIslemler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            txtBirinci.Text = "0";
            txtIkinci.Text = "0";
        }

        private void btnBirinci_Click(object sender, EventArgs e)
        {
            // Girilen İki Sayının Toplamının Farkına Modu

            int ilkSayi = Convert.ToInt32(txtBirinci.Text);
            int ikinciSayi = Convert.ToInt32(txtIkinci.Text);

            //MessageBox.Show("Birinci Sayi: " + ilkSayi + "\nİkinci Sayi: " + ikinciSayi);

            int toplam = ilkSayi + ikinciSayi;
            int fark = ilkSayi - ikinciSayi;

            MessageBox.Show("Toplam Mod Fark = " + toplam % fark);
        }

        private void btnIkinci_Click(object sender, EventArgs e)
        {
            // ilk textbox (txtBirinci) ın değerinin 10 eksiğinin 20 fazlsının
            // 2 ye bolumunden kalanın karesi kaçtır?

            int sayi = Convert.ToInt32(txtBirinci.Text);

            sayi = ((sayi - 10) + 20) % 2;

            int sonuc = sayi * sayi;

            //MessageBox.Show("İşlem Sonucu: " + sonuc);
            MessageBox.Show($"İşlem Sonucu: {sonuc}");
        }

        private void btnUcuncu_Click(object sender, EventArgs e)
        {
            // Girilen sayıların karelerinin toplamı ile karelerinin farkının toplamı
            int sayi1 = Convert.ToInt32(txtBirinci.Text);
            int sayi2 = Convert.ToInt32(txtIkinci.Text);

            int birinciKare = sayi1 * sayi1;
            int ikinciKare = sayi2 * sayi2;

            int toplam = birinciKare + ikinciKare;
            int fark = birinciKare - ikinciKare;

            //MessageBox.Show($"Sonuc: {(birinciKare + ikinciKare) + (birinciKare - ikinciKare)}");
            MessageBox.Show($"Sonuc : {toplam + fark}");
        }

        private void btnDort_Click(object sender, EventArgs e)
        {
            //Not Hesaplama
            // 1.sayi Vize %30
            // 2.sayi Final %70 

            int vize = Convert.ToInt32(txtBirinci.Text);
            int final = Convert.ToInt32(txtIkinci.Text);

            double not  = vize * 0.3 + final * 0.7;

            MessageBox.Show($"Notun: {not}");
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            string ad = txtBirinci.Text;
            string soyad = txtIkinci.Text;

            MessageBox.Show("Mail Adresiniz: " + ad + "." + soyad + "@hotmail.com");
        }
    }
}
