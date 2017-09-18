using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaOdemeMerkezi.Models
{
    public class Vezne
    {
        public Vezne()
        {
            Faturalar = new List<Fatura>();
        }
        public int No { get; set; }
        public Veznedar Veznedar { get; set; }
        public List<Fatura> Faturalar { get; set; }
    }
}
