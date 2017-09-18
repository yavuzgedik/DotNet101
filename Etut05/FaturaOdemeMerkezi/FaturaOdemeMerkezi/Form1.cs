using FaturaOdemeMerkezi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaOdemeMerkezi
{
    public partial class Form1 : Form
    {
        int vezneSayisi = 0;
        List<Vezne> Vezneler = new List<Vezne>();
        int vezneNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cboxVezneSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            vezneSayisi = cboxVezneSayisi.SelectedIndex + 1;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (vezneSayisi > 0)
            {
                lblBaslikMesaj.Text = $"{vezneSayisi} Adet Vezne Hizmete Hazır.";
                gboxAcilis.Enabled = false;
                VezneOlustur(vezneSayisi);
            }
            else
            {
                MessageBox.Show("Vezne Sayisi Hatalı");
            }
        }

        void VezneOlustur(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Left = gboxAcilis.Left + btn.Width * i;
                btn.Top = 180;
                btn.Text = (i + 1).ToString();
                btn.Click += Btn_Click;
                btn.MouseHover += Btn_MouseHover;
                btn.MouseLeave += Btn_MouseLeave;

                Vezne v = new Vezne();
                v.No = i + 1;

                //v.Veznedar = new Veznedar()
                //{
                //    No = 20171,
                //    Ad = "Burak",
                //    Soyad = "Salduz"
                //};

                #region FaturaOlusturma
                //v.Faturalar = new List<Fatura>();
                //v.Faturalar.Add(new Fatura()
                //{
                //    No = 1,
                //    IslemTarihi = DateTime.Now,
                //    SonOdemeTarihi = DateTime.Now,
                //    Tutar = 0,
                //    OdemeTipi = Enum.OdemeTip.KrediKarti,
                //    OdemeyiYapan = new Musteri()
                //    {
                //        Ad = "Yavuz",
                //        Soyad = "Gedik",
                //        Telefon = "05062928064",
                //    }
                //});
                #endregion
                #region Ctor
                Veznedar vz = new Veznedar(1, "Yavuz", "Gedik");
                Veznedar vz2 = new Veznedar();
                #endregion

                Vezneler.Add(v);

                btn.Tag = v;
                this.Controls.Add(btn);
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Vezne vezne = btn.Tag as Vezne;
            btn.Text = vezne.No.ToString();
        }

        private void Btn_MouseHover(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            //btn.Text = Vezneler[int.Parse(btn.Text) - 1].Veznedar.No
            //    + " "
            //    + Vezneler[int.Parse(btn.Text) - 1].Veznedar.Ad
            //    + " "
            //    + Vezneler[int.Parse(btn.Text) - 1].Veznedar.Soyad;

            Button btn = sender as Button;
            Vezne vezne = btn.Tag as Vezne;

            if (vezne.Veznedar == null)
            {
                gboxVeznedar.Enabled = true;
                vezneNo = vezne.No;
                Text = vezneNo.ToString();

                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {

                    }
                    else
                    {
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                gboxVeznedar.Enabled = false;
                btn.Text = vezne.Veznedar.No + " " + vezne.Veznedar.Ad + " " + vezne.Veznedar.Soyad;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
        }

        private void btnVeznedarKaydet_Click(object sender, EventArgs e)
        {
            if (vezneNo > 0)
            {
                //Vezneler[vezneNo - 1].Veznedar = new Veznedar();
                //Vezneler[vezneNo - 1].Veznedar.No = int.Parse(txtVeznedarNo.Text);
                //Vezneler[vezneNo - 1].Veznedar.Ad = txtVeznedarAd.Text;
                //Vezneler[vezneNo - 1].Veznedar.Soyad = txtVeznedarSoyad.Text;

                Vezneler[vezneNo - 1].Veznedar = new Veznedar()
                {
                    Ad = txtVeznedarAd.Text,
                    Soyad = txtVeznedarSoyad.Text,
                    No = int.Parse(txtVeznedarNo.Text)
                };


                gboxVeznedar.Enabled = false;

                txtVeznedarNo.Clear();
                txtVeznedarAd.Clear();
                txtVeznedarSoyad.Clear();

                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {

                    }
                    else
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void gboxFatura_Enter(object sender, EventArgs e)
        {

        }

        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {
            Fatura f = new Fatura()
            {
                No = int.Parse(txtFaturaNo.Text),
                IslemTarihi = dtpIslem.Value,
                SonOdemeTarihi = dtpSonOdeme.Value,
                OdemeTipi = (FaturaOdemeMerkezi.Enum.OdemeTip)cboxOdemeTip.SelectedIndex,
                OdemeyiYapan = new Musteri()
                {
                    Ad = txtMusteriAd.Text,
                    Soyad = txtMusteriSoyAd.Text,
                    Telefon = "12345678900",
                },
                Tutar = Convert.ToDouble(txtFaturaTutari),
            };

            if 
        }
    }
}
