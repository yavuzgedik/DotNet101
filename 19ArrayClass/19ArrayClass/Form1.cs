using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19ArrayClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler =
        {
            "Adana",
            "İstanbul",
            "İzmir",
            "Ankara",
            "Konya",
            "Bursa",
            "Adana",
            "Trabzon"
        };
        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(sehirler, 1, 1);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string[] ornek = new string[4];

            Array.Copy(sehirler, ornek, 3);

            //Array.Copy(sehirler, 3, ornek, 0, 2);
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            int index = Array.LastIndexOf(sehirler, "Adana");
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //int index = Array.IndexOf(sehirler, "İzmir");

            string sehir = txtMetin.Text;

            if (Array.IndexOf(sehirler, sehir) != -1)
            {
                if (Array.IndexOf(sehirler, sehir) == Array.LastIndexOf(sehirler, sehir))
                {
                    MessageBox.Show("Bu Şehirden Bir Tane Var");
                }
                else
                {
                    MessageBox.Show("Bu Şehirden Birden fazla Var");
                }
            }
            else
            {
                MessageBox.Show("Şehir Bulunamadı!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Array.Sort(sehirler);
            foreach (var item in sehirler)
            {
                listBox1.Items.Add(item);
            }

            //int[] sayilar = { 45, 99, 75, 98, -1, 32 };
            //Array.Sort(sayilar);
            //foreach (var item in sayilar)
            //{
            //    listBox1.Items.Add(item);
            //}
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Array.Reverse(sehirler);
            foreach (var item in sehirler)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
