using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1den1000e_Click(object sender, EventArgs e)
        {
            // 1-1000 e 1 er artım
            for (int i = 1; i <= 5; i++)
            {
                listBox1.Items.Add(i);
            }

            // 1-1000 e 2 şer artım
            //for (int i = 0; i <= 1000; i += 2) // (i = i + 2) eşit (i += 2)
            //{
            //    listBox1.Items.Add(i);
            //}

            // BONUS
            int a = 5;
            int b = a++; // a = a + 1; önce ata sonra attır
            int c = ++a; // önce attır sonra ata
            // a = 7, b = 5, c = 7
        }

        private void btn1000den1e_Click(object sender, EventArgs e)
        {
            for (int i = 5; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            //char c = 'B';
            //char c2 = 'b';

            //MessageBox.Show(Convert.ToInt32(c) + " - " + Convert.ToInt32(c2));

            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c);
                //listBox1.Items.Add(c + " - " + Convert.ToInt32(c));
            }
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((100*101)/2 + ""); // Carl Friedrich Gauss

            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                //toplam = toplam + i;
                toplam += i;
            }

            MessageBox.Show(toplam + "");
        }
    }
}
