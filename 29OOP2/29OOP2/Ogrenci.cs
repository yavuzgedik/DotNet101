using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29OOP2
{
    class Ogrenci
    {
        public string OgrNo;
        public string Ad;
        public string Soyad;
        public string Bolum;
        public DateTime dogumTarihi;

        int _dogumTarihiPro;
        public int dogumTarihiPro
        {
            get
            {
                return _dogumTarihiPro;
            }
            set
            {
                //_dogumTarihiPro = value;

                if (value > 1999)
                {
                    MessageBox.Show("Yaşınız Tutmuyor!");
                }
                else
                {
                    _dogumTarihiPro = value;
                }
            }
        }
    }
}
