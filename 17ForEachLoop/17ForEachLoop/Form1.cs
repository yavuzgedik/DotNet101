using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17ForEachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehirler =
        {
            "Ankara",
            "İzmir",
            "İstanbul",
            "Manisa",
            "Muş",
            "Iğdır",
            "Rize",
            "Çorum"
        };

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (string str in sehirler)
            {
                listBox1.Items.Add(str);
            }

            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //}
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 123, 45, 56, 876, 753, 734, 11, 9, 2017 };

            // hem 2 hemde 3 e tam bölünebilen kaç sayı var mesaj box da yazın
            // 2 ye tam bölünen sayıları listbox1
            // 3 e tam bölünen sayıları listbox2 ye ekleyin

            int tamBolunenler = 0;
            foreach (int sayi in sayilar)
            {
                // && Ve işareti solundaki ve sağındaki iki durumda sağlandığında
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    tamBolunenler++;
                }
                

                #region 2ye3ebölünenANDsiz
                //if (sayi % 2 == 0)
                //{
                //    if (sayi % 3 == 0)
                //    {
                //        tamBolunenler++;
                //    }
                //}
                #endregion

                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }

                if (sayi % 3 == 0)
                {
                    listBox2.Items.Add(sayi);
                }
                
                if (sayi % 2 != 0 && sayi % 3 != 0)
                {
                    listBox3.Items.Add(sayi);
                }
            }

            MessageBox.Show($"2 ve 3 e tam bölünen {tamBolunenler} sayi vardır.");
        }
    }
}
