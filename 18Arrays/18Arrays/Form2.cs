using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18Arrays
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            for (int i = 0; i < arabalar.Length; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        string[] arabalar =
        {
            "Mazda",
            "Renault",
            "Porsche",
            "Mercedes",
            "BMW",
            "Bugatti",
            "Honda",
            "Tofaş",
            "Opel",
            "Toyota",
            "Ford",
            "Yavuz"
        };
        private void btnSonEleman_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Son Araç Markası: {arabalar[arabalar.Length - 1]}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(comboBox1.SelectedItem.ToString());
            Text = $"Seçilen Araç: {arabalar[index]}";
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            /*int index = rnd.Next(0, 10);*/ // 0,1,2,3,4,5,6,7,8,9
            int index = rnd.Next(0, arabalar.Length); // 0,1,2,..,11
            Text = $"Rasgele Araç: {arabalar[index]}";
        }

        int[] sayilar = { 12, 23, 34, 45, 56 };
        int i = 0, j = 1, toplam = 0;
        private void btnEkleTopla_Click(object sender, EventArgs e)
        {
            if (toplam == 0)
            {
                i = 0;
                j = 1;
            }

            if (i < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[i]);
                toplam += sayilar[i];
                Text = $"Şuan ki toplam : {toplam}";
                listBox1.SelectedIndex = i;
            }
            else
            {
                listBox1.Items.RemoveAt(i - j);
                toplam -= sayilar[i - j];
                Text = $"Şuan ki toplam : {toplam}";
                listBox1.SelectedIndex = (i - j) - 1;
                j = j + 2;
            }
            i++;
        }
    }
}
