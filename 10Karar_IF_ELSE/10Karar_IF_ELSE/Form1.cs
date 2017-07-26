using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Karar_IF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtDeger.Text.ToLower().Trim() == "admin") // iki değerin birbiri ile aynı olma durumu
            {
                MessageBox.Show("Hoşgeldin Admin");
            }
            else
            {
                MessageBox.Show("Tanıyamadım, Kimsiniz?");
            }

            txtDeger.Clear();
            txtDeger.Focus();
        }

        private void txtDeger_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdmin_Click(sender, e);
            }
            else
            {
                this.Text = txtDeger.Text;
            }
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            try
            {
                int not = Convert.ToInt32(txtDeger.Text);

                if (not < 0)
                {
                    MessageBox.Show("0 dan küçük değer giremezsiniz!");
                }
                else if (not > 100)
                {
                    MessageBox.Show("100 den büyük değer giremezsiniz!");
                }
                else
                {
                    MessageBox.Show("Hatasız not girişi yaptınız.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not gireceksen sence de bir sayı yazman gerekmez miydi?");
            }
            
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtDeger.Text);

                // Kolayca string'e çevirme yöntemi (string ile birleştirmek) 
                //string strSayi = sayi + "";
                //MessageBox.Show(strSayi);

                if(sayi % 2 == 0)
                {
                    this.Text = sayi + " Çifttir";
                }
                else
                {
                    this.Text = sayi + " Tektir";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sayı Girseydin Keşke!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '?';

            if(txtPassword.Text.Length >= 8)
            {
                MessageBox.Show("Giriş Onaylandı!");
            }
            else
            {
                MessageBox.Show("Daha Uzun Bir Şifre Girmeniz Gerekiyor!");
            }

            txtPassword.BackColor = Color.Green;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.Red;
            txtPassword.ForeColor = Color.White;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
        }
    }
}
