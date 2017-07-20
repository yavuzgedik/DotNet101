using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07FormsControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtMetin.Text;
        }

        private void txtMetin_MouseEnter(object sender, EventArgs e)
        {
            txtMetin.BackColor = Color.Maroon;
            txtMetin.ForeColor = Color.Orange;
        }

        private void txtMetin_MouseLeave(object sender, EventArgs e)
        {
            txtMetin.BackColor = Color.White;
            txtMetin.ForeColor = Color.Black;
        }

        private void txtMetin_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
