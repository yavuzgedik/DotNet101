using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21MathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            Text = Math.PI.ToString();
        }

        private void btnMutlak_Click(object sender, EventArgs e)
        {
            Text = Math.Abs(-45).ToString();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            Text = Math.Floor(12.98).ToString();
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            Text = Math.Ceiling(12.98).ToString();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            Text = Math.Round(12.49).ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Text = Math.Max(45, 46).ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Text = Math.Min(45, 46).ToString();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int taban = int.Parse(txtTaban.Text); // 3
            int us = int.Parse(txtUs.Text); // 4

            //long sonuc = taban;

            //for (int i = 1; i < us; i++)
            //{
            //    sonuc *= taban; // 3 * 3 * 3 * 3
            //}

            //Text = sonuc.ToString();

            Text = Math.Pow(taban, us).ToString();
        }
    }
}
