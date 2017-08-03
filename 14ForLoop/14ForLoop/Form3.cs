using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14ForLoop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnYanYanaX_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X";
            }
        }

        private void btnAltAltaX_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < 5; i++)
            {
                label1.Text += "X\n";
            }
        }

        private void btnKare_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // İçi boş kare
                    //if ((j > 0 && j < 4) && (i > 0 && i < 4))
                    //{
                    //    label1.Text += "    ";
                    //}
                    //else
                    //{
                    //    label1.Text += "X  ";
                    //}

                    // içi dolu kare
                    label1.Text += "X  ";
                }
                label1.Text += "\n";
            }
        }

        private void btnDikUcgen_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    label1.Text += "X  ";
                }
                label1.Text += "\n";
            }
        }

        private void btnCarpimTablosu_Click(object sender, EventArgs e)
        {
            // 3 X 5 = 15

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    //listBox1.Items.Add(i + " X " + j + " = " + i * j);

                    //listBox1.Items.Add($"{i} X {j} = {i * j}");

                    listBox1.Items.Add(string.Format("{0} X {1} = {2}", i, j, i * j));
                }
                listBox1.Items.Add("-----------");
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 100; i++)
            {
                if (i == 20)
                {
                    listBox1.Items.Add(i);
                    break;
                }
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add(i);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                int sayi = rnd.Next(1, 10);

                if (listBox1.Items.Contains(sayi))
                {
                    continue; // Continue bir sonraki iterasyona gönderir
                }
                else
                {
                    listBox1.Items.Add(sayi);
                }
                listBox1.Items.Add(11);
            }
        }
    }
}
