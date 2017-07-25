using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            long gelenDeger = long.Parse(txtDeger.Text);
            //long gelenDeger = Convert.ToInt64(txtDeger.Text);

            MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
        }

        private void btnKontrolluOnay_Click(object sender, EventArgs e)
        {
            try
            {
                // Hata riski olan kodların yazıldığı alan

                long gelenDeger = Convert.ToInt64(txtDeger.Text);
                MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
            }
            catch (Exception hata)
            {
                // Hatalı işlem yapıldığında çalışan kod

                //MessageBox.Show("Bir telefon numarası bile giremiyorsun!");

                MessageBox.Show(hata.Message);
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                long gelenDeger = Convert.ToInt64(txtDeger.Text);
                MessageBox.Show("Tebrikler, Iphone 8s plus kazandınız!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Hatasız Kul Olmaz, ben her türlü çalışırım");
            }
        }
    }
}
