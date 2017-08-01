using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14ForLoop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] takimlar =
            {
                "Galatasaray",
                "Beşiktaş",
                "Fenarbahçe",
                "Bursa Spor",
                "Trabzon Spor",
                "Göztepe",
                "Buca Spor",
                "Karşıyaka Spor"
            };

        private void btnTakimlar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(takimlar[5]);

            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }

            // listbox boyutunu form'un text'ine atar
            Text = listBox1.Items.Count.ToString(); 

            listBox1.SelectedIndex = 0; // İlk elemanı seçer
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // listbox boyutunu form'un text'ine atar
            Text = listBox1.Items.Count.ToString();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);

            // listbox boyutunu form'un text'ine atar
            Text = listBox1.Items.Count.ToString();
        }

        private void btnGez_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                    Thread.Sleep(100); // 100 milisaniye
                }
            }
            else
            {
                MessageBox.Show("ListBox Boş!");
            }
            
        }

        private void btnSayilar_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 38, 83, 45, 50, 60, 89, 56, 32 };
            int cift = 0, tek = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }

            MessageBox.Show($"Çift Sayı : {cift}, Tek Sayi : {tek}");
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //int sayi = rnd.Next(0, 101); // 0 dan 100 de dahil rasgele bir sayi bulunur
            //MessageBox.Show(sayi.ToString());

            for (int i = 0; i < 10; i++)
            {
                int sayi = rnd.Next(1, 11);
                listBox1.Items.Add(sayi);
            }
        }

        private void btnRastgeleCiftTek_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cift = 0, tek = 0;

            for (int i = 0; i < 10; i++)
            {
                // [1,100] arasında rastgele bir sayi belirle
                int sayi = rnd.Next(1, 101);

                //Sayi Tek mi Çift mi
                if (sayi % 2 != 0)
                {
                    tek++;
                }
                else
                {
                    cift++;
                }

                listBox1.Items.Add(sayi);
            }

            MessageBox.Show($"Çift Sayı: {cift}, Tek Sayı: {tek}");
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            // Form da yer alan Control Sayisi
            //MessageBox.Show(this.Controls.Count.ToString());

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button)
                {
                    if (Controls[i].Text != "Temizle")
                    {
                        Controls[i].BackColor = Color.Blue;
                        Controls[i].ForeColor = Color.White;
                    }
                }
                else
                {
                    Controls[i].BackColor = Color.Green;
                    Controls[i].ForeColor = Color.Red;
                }
            }
        }

        private void btnSon_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            string deger = txtMetin.Text;

            for (int i = 0; i < deger.Length; i++)
            {
                try
                {
                    int sayi = Convert.ToInt32(deger[i].ToString());
                    toplam += sayi; // toplam = toplam + sayi;
                }
                catch (Exception)
                {
                    //MessageBox.Show("Rakadamdan farklı karakter girilmiş");
                }
            }

            MessageBox.Show($"Toplam: {toplam}");
        }
    }
}
