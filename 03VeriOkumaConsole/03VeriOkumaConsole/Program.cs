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
            Console.ForegroundColor = ConsoleColor.Green; // Consol ekranındaki yazıların rengini yeşil yapar
            Console.WriteLine("Lütfen Adınızı ve Soyadınızı Giriniz: ");
            string gelenMetin = Console.ReadLine(); // girilen ifadeleri okuyup gelenMetin değişkenine atar

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hoşgeldin " + gelenMetin + "\nçıkmak için bir tuşa basın.");
            // aşağıdaki kod yerine \n kullanılır
            //console.writeline("çıkmak için bir tuşa basın."); 

            Console.Beep(); // Ses Çıkartır

            Console.ReadKey();
            Console.Beep();
        }
    }
}
