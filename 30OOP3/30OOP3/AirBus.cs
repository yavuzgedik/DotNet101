using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30OOP3
{
    class AirBus : Ucak
    {
        public string Model { get; set; }
        public string Isim { get; set; }

        public override string BilgiVer()
        {
            //return 
            //    string.Format
            //    ("Model: {0}, Isim: {1}, Ağırlık: {2}, Koltuk Sayisi: {3}"
            //    ,Model, Isim, Agirlik, KoltukSayisi);

            return
                string.Format
                ($"Model: {Model}, Isim: {Isim}, Ağırlık: {Agirlik}, Koltuk Sayisi: {KoltukSayisi}");
        }

        public override string ToString()
        {
            return Model + " " + Isim;
        }
    }
}
