using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaOdemeMerkezi.Models
{
    public class Veznedar : Insan
    {
        public Veznedar()
        {

        }
        public Veznedar(int _no, string _ad, string _soyad)
        {
            No = _no;
            Ad = _ad;
            Soyad = _soyad;
        }
        public int No { get; set; }
    }
}
