using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30OOP3
{
    class Boing : Ucak
    {
        public string Model { get; set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
