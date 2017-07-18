using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Yazıların rengini yeşil yapar
            Console.WriteLine("Lütfen Adınızı ve Soyadınızı Giriniz: ");
            string gelenMetin = Console.ReadLine();

            Console.WriteLine("Hoşgeldin " + gelenMetin + "\nçıkmak için bir tuşa basın.");
            // aşağıdaki kod yerine \n 
            //console.writeline("çıkmak için bir tuşa basın."); 

            Console.Beep(); // Ses Çıkartır

            Console.ReadKey();
        }
    }
}
