using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(cboxUcakTurleri.SelectedItem.ToString() == "AirBus")
            {
                AirBus ab = new AirBus();

                //ab.KoltukSayisi = int.Parse(txtKoltukSayisi.Text);
                ab.KoltukSayisi = Convert.ToInt32(txtKoltukSayisi.Text);

                ab.Agirlik = Convert.ToDouble(txtAgirilik.Text);
                ab.Isim = txtIsim.Text;
                ab.Model = txtModel.Text;

                listBox1.Items.Add(ab);

                MessageBox.Show(ab.BilgiVer());
            }
            else if (cboxUcakTurleri.SelectedItem.ToString() == "Boing")
            {
                Boing bo = new Boing();
                bo.Agirlik = Convert.ToDouble(txtAgirilik.Text);
                bo.KoltukSayisi = Convert.ToInt32(txtKoltukSayisi.Text);
                bo.Model = txtModel.Text;

                listBox1.Items.Add(bo);

                MessageBox.Show(bo.BilgiVer());
            }
        }

        private void cboxUcakTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxUcakTurleri.SelectedItem.ToString() == "Boing")
            {
                txtIsim.Enabled = false;
            }
            else
            {
                txtIsim.Enabled = true;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
