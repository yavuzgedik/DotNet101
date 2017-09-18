using FaturaOdemeMerkezi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaOdemeMerkezi.Models
{
    public class Fatura
    {
        public int No { get; set; }

        double _tutar;
        public double Tutar
        {
            get
            {
                return _tutar;
            }
            set
            {
                _tutar = value;
            }
        }
        public DateTime SonOdemeTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public OdemeTip OdemeTipi { get; set; }
        public Musteri OdemeyiYapan { get; set; }
    }
}
