using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxMevsimler.Items.Add("Kış");
            cboxMevsimler.Items.Add("İlkbahar");
            cboxMevsimler.Items.Add("Yaz");
            cboxMevsimler.Items.Add("Sonbahar");
        }

        private void cboxMevsimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. YOL
            //string mevsim = cboxMevsimler.SelectedItem.ToString();
            //MessageBox.Show(mevsim);

            // 2. YOL
            //int index = cboxMevsimler.SelectedIndex;
            //MessageBox.Show(cboxMevsimler.Items[index].ToString());

            string mevsim = cboxMevsimler.SelectedItem.ToString();

            switch (mevsim)
            {
                case "Kış":
                    MessageBox.Show("Aralık\nOcak\nŞubat");
                    break;

                case "İlkbahar":
                    MessageBox.Show("Mart\nNisan\nMayıs");
                    break;

                case "Yaz":
                    MessageBox.Show("Haziran\nTemmuz\nAğustos");
                    break;

                case "Sonbahar":
                    MessageBox.Show("Eylül\nEkim\nKasım");
                    break;

                default:
                    MessageBox.Show("Hatalı Seçim!");
                    break;
            }

        }
    }
}
