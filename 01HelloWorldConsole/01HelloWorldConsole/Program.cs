using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); // Bir satır boşluk bırakır (Tek satırda yorum yapma yöntemi)
            Console.WriteLine("Hello World");
            Console.Write("Yavuz Gedik");
            Console.WriteLine(" 2017");
            Console.ReadKey(); //Kullanıcı bir tuşa basana kadar Console ekranını bekletir

            /*
             * Merhaba,
             * Ben Yavuz Gedik.
             * yavuz@pialab.com
             * Bu bir çok satırlı yorum yapma yöntemidir.
             */
        }
    }
}
