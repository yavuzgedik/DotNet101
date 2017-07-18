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
            btn.Text = "Tıklandım";
            MessageBox.Show("Hello World"); // Mesaj Çıkartır.
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;

            //Application.Exit(); // Uygulamayı sonlandırır.
        }
    }
}
