using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            int num1 = (int)numBirinci.Value;
            int num2 = (int)numIkinci.Value;
            int toplam = Topla(num1, num2);

            MessageBox.Show($"Girdiğin Sayıların Toplamı: {toplam}");
        }
    }
}
