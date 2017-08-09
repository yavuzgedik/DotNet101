using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[100];
        string[] soyIsimler = new string[100];
        string[] telefonlar = new string[100];

        int index = 0; 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string isim = txtAd.Text.Trim();
            string soyIsim = txtSoyad.Text.Trim();
            string tel = txtTel.Text.Trim();

            isimler[index] = isim;
            soyIsimler[index] = soyIsim;
            telefonlar[index] = tel;

            lboxRehber.Items.Add($"{isim} {soyIsim} \t {tel}");

            index++;

            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lboxRehber.Items.Clear();

            if (txtAd.Text != "")
            {
                for (int i = 0; i < index; i++)
                {
                    if (txtAd.Text.Trim().ToLower() == isimler[i].ToLower())
                    {
                        lboxRehber.Items.Add($"{isimler[i]} {soyIsimler[i]} \t {telefonlar[i]}");
                    }
                }
            }
            else if (txtSoyad.Text != "")
            {
                for (int i = 0; i < index; i++)
                {
                    if (txtSoyad.Text.Trim().ToLower() == soyIsimler[i].ToLower())
                    {
                        lboxRehber.Items.Add($"{isimler[i]} {soyIsimler[i]} \t {telefonlar[i]}");
                    }
                }
            }
            else if (txtTel.Text != "")
            {
                for (int i = 0; i < index; i++)
                {
                    if (txtTel.Text.Trim() == telefonlar[i])
                    {
                        lboxRehber.Items.Add($"{isimler[i]} {soyIsimler[i]} \t {telefonlar[i]}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad, Soyad veya Telefon Numarası Girin!");
            }

            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
        }

        private void btnTümü_Click(object sender, EventArgs e)
        {
            lboxRehber.Items.Clear();

            for (int i = 0; i < index; i++)
            {
                lboxRehber.Items.Add($"{isimler[i]} {soyIsimler[i]} \t {telefonlar[i]}");
            }

            txtAd.Clear();
            txtSoyad.Clear();
            txtTel.Clear();
        }
    }
}
