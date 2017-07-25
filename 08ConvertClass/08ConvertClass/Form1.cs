using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08ConvertClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi = 38;
            string mesaj = sayi.ToString();
            sayi++;
            //MessageBox.Show(sayi.ToString());

            MessageBox.Show("Sayi: " + sayi);
            MessageBox.Show("Mesaj: " + mesaj);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string cevrilecekDeger = txtSayi.Text;

            MessageBox.Show("Int : " + Convert.ToInt32(cevrilecekDeger));
            MessageBox.Show("Byte : " + Convert.ToByte(cevrilecekDeger));
            MessageBox.Show("Float : " + Convert.ToSingle(cevrilecekDeger));

            bool burak = true;
            MessageBox.Show(burak.ToString());
        }
    }
}
