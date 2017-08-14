using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double[] fiyatlar = new double[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            fiyatlar[0] = 110;
            fiyatlar[1] = 120;
            fiyatlar[2] = 140;

            cboxAraclar.Items.Add("Renault Clio");
            cboxAraclar.Items.Add("Fiat Egea");
            cboxAraclar.Items.Add("Opel Astra");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "";

            int count = cboxAraclar.SelectedIndex;
            int gun = (int)numGun.Value;
            double price = 0;
            switch (gun)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    price = fiyatlar[count] * gun;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    price = (fiyatlar[count] * 0.9) * gun;
                    labelMessage.Text = "Araca %10 indirim uygulanmıştır.";
                    break;
                default:
                    price = (fiyatlar[count] * 0.8) * gun;
                    labelMessage.Text = "Araca %20 indirim uygulanmıştır.";
                    break;
            }

            MessageBox.Show($"{cboxAraclar.Items[count].ToString()} aracının {gun} luk fiyati: {price}₺");
        }
    }
}
