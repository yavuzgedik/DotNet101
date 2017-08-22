using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23FormlarArasiGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
        private void btnGonder_Click(object sender, EventArgs e)
        {
            frm2.mesaj = txtMesaj.Text;
            frm2.Show();
            this.Hide();
        }
    }
}
