using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16DoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i < 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox1.Items.Add(i);
                i++;
            } while (i < 100);
        }
    }
}
