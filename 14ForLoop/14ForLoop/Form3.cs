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
            label1.Text = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j > 0 && j < 4) && (i > 0 && i < 4))
                    {
                        label1.Text += "     ";
                    }
                    else
                    {
                        label1.Text += "X  ";
                    }

                    //label1.Text += "X  ";
                }
                label1.Text += "\n";
            }
        }
    }
}
