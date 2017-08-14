using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yükleniyorum...");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Çift Tikladi");
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            Text = "Hoşgeldin " + txtAdSoyad.Text;
            lblMesaj.Text = Text;
        }
    }
}
