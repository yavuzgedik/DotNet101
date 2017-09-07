using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxBolumler.Items.Add("Fizik");
            cboxBolumler.Items.Add("Matematik");
            cboxBolumler.Items.Add("Biyoloji");
        }

        List<Ogrenci> ogrList = new List<Ogrenci>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.OgrNo = txtOgrNo.Text;
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.Bolum = cboxBolumler.SelectedItem.ToString();
            ogr.dogumTarihi = dateTimePicker.Value;
            ogr.dogumTarihiPro = dateTimePicker.Value.Year;

            if (ogr.dogumTarihiPro != 0)
            {
                ogrList.Add(ogr);
                Listele();
            }
        }

        void Listele()
        {
            listBox1.Items.Clear();
            foreach (var item in ogrList)
            {
                listBox1.Items.Add
                    (
                        item.OgrNo + "\t" 
                        + item.Ad + "\t"
                        + item.Soyad + "\t"
                        + item.Bolum + "\t"
                        + item.dogumTarihi.ToString("dd/MM/yyyy") + "\t"
                        + item.dogumTarihiPro + "\t"
                    );
            }
        }
    }
}
