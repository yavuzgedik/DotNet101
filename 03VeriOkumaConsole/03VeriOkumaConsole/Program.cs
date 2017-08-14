using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03VeriOkumaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Yazıların rengini yeşil yapar
            Console.WriteLine("Lütfen Adınızı ve Soyadınızı Giriniz: ");
            string gelenMetin = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hoşgeldin " + gelenMetin + "\nçıkmak için bir tuşa basın.");
            // aşağıdaki kod yerine \n 
            //console.writeline("çıkmak için bir tuşa basın."); 

            Console.Beep(); // Ses Çıkartır

            Console.ReadKey();
            Console.Beep();
        }
    }
}
