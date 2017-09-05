using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28OOP1
{
    public class Araba
    {
        public string plaka;
        public string marka;
        public double fiyat;
        public string renk;

        public override string ToString()
        {
            return plaka + "\t" + marka + "\t\t" + fiyat;
        }
    }
}
