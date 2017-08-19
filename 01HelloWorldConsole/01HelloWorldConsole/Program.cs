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
            // Tek satırda yorum yapma yöntemi
            Console.WriteLine(); // Bir satır boşluk bırakır
            Console.WriteLine("Hello World"); // tırnak içindeki ifadeyi yazıp yeni satıra geçer
            Console.Write("Yavuz Gedik"); // tırnak içindeki ifadeyi yazıp kaldığı yerden devam eder
            Console.WriteLine(" 2017"); // bir önceki kod satırında yeni satıra geçilmediği için tırnak içindeki ifadeyeilk karakteri boşluk oldu. Bitişik bir yazı yazılmaması için
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
