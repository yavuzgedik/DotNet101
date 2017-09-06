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

        List<Araba> Araclar = new List<Araba>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "EKLE")
            {
                Araba a1 = new Araba();
                a1.fiyat = (double)numFiyat.Value;
                a1.marka = txtMarka.Text.ToUpper();
                a1.plaka = txtPlaka.Text.ToUpper();
                a1.renk = cboxRenk.SelectedItem.ToString();
                
                if (!PlakaSorgula(a1.plaka))
                {
                    Araclar.Add(a1);
                }
                else
                {
                    MessageBox.Show("Plaka Kayıtlı!");
                }
                
                Listele();
                Temizle();
            }
            else
            {
                Araba car = (Araba)listAraclar.SelectedItem;
                var guncellenecekAraba = Araclar.
                    FirstOrDefault(a => a.plaka.ToUpper() == car.plaka.ToUpper());

                guncellenecekAraba.fiyat = (double)numFiyat.Value;
                guncellenecekAraba.marka = txtMarka.Text.ToUpper();
                guncellenecekAraba.plaka = txtPlaka.Text.ToUpper();
                guncellenecekAraba.renk = cboxRenk.SelectedItem.ToString();
                Listele();
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
            }
        }
        
        private void listAraclar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Araba car = (Araba)listAraclar.SelectedItem;
                Araclar.Remove(car);
            }
            catch (Exception)
            {
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

        void Temizle()
        {
            txtMarka.Clear();
            txtPlaka.Clear();
            numFiyat.Value = 100;
            cboxRenk.SelectedIndex = 0;
        }

        void Listele()
        {
            listAraclar.Items.Clear();

            foreach (var item in Araclar)
            {
                listAraclar.Items.Add(item);
            }
        }

        bool PlakaSorgula(string plaka)
        {
            #region FirstOrDefault
            //var result = Araclar.FirstOrDefault(a => a.plaka.ToLower() == plaka.ToLower());
            //if (result != null)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            #endregion
            
            #region DonguIle
            foreach (var item in Araclar)
            {
                if (item.plaka.ToLower() == plaka.ToLower())
                {
                    return true;
                }
            }
            return false;
            #endregion
        }
    }
}
