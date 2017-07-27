using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Alistirma01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboxIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string islem = cboxIslem.SelectedItem.ToString();

            switch (islem)
            {
                case "Toplama":
                    lblSonuc.Text = (numBirinciSayi.Value + numIkinciSayi.Value) + "";
                    break;

                case "Çıkarma":
                    lblSonuc.Text = (numBirinciSayi.Value - numIkinciSayi.Value) + "";
                    break;

                case "Çarpma":
                    lblSonuc.Text = (numBirinciSayi.Value * numIkinciSayi.Value) + "";
                    break;

                case "Bölme":
                    lblSonuc.Text = (numBirinciSayi.Value / numIkinciSayi.Value) + "";
                    break;

                default:
                    break;
            }
        }

        private void numIkinciSayi_ValueChanged(object sender, EventArgs e)
        {
            lblSonuc.Text = (numBirinciSayi.Value + numIkinciSayi.Value) + "";
        }
    }
}
