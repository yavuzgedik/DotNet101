using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            btn.Text = "Tıklandım"; // Toolbox dan eklenen butonun Text özelliğine yeni bir ifade atandı.
            MessageBox.Show("Hello World"); // EKrana Mesaj Kutusu Çıkartır.
            btn.BackColor = Color.Blue; // Butonun arka plan rengine mavi renk atandı.
            btn.ForeColor = Color.White; // Butonun yazı rengine beyaz renk atandı.

            //Application.Exit(); // Uygulamayı sonlandırır.
        }
    }
}
