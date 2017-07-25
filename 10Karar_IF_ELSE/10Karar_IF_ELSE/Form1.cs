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
    }
}
