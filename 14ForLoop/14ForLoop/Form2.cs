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
                    Thread.Sleep(100);
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
    }
}
