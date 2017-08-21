using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Degiskenler
{
    public partial class Form1 : Form
    {
        // Değişkenler, verileri kaydettiğimiz alanlardır.

        // Herhangi bir metot içine yazılmayan değişkenler, GLOBAL değişkenler olarak adlandırılır.
        // Class dışında değişken tanımlaması yapılamaz.
        byte sayi; // 0-255 arasında bir değer ataması yapılabilir.
        string metin; // metinsel ifadeler tutulur.

        public Form1()
        {
            // InitialComponent metotu form ve form üzerinde nesnelerin oluşturan (görsel olarak) fonksiyondur.
            InitializeComponent();

            // sayi ve metin değişkenleri global değişken olduğu için, bu metot içinde ilgili değişkenlere erişip kullanabiliyorum.
            sayi = 5;
            metin = "2017 yılındayız.";

            /*
             * değişken tiplerinin üzerine tıklayıp F12'ye basarak ilgili tipin ayrıntılarını görebilirsiniz.
             * Veya değişen tiplerinin üzerine sağ tık yapıp Go To Definition seçeneği ile aynı işlevi yapabilirsiniz.
             */
            byte number;
            sbyte numder2; // -128 127 arasınde bir değer alır.

            short number3; // short secili iken F12'ye basarak ayrıntılara gidilebilir.
            ushort number4;

            int number5;
            uint number6;

            long number7;
            ulong number8;


            float kesirli; // virgülden sonra 7 basamak duyarlı
            double kesirli2; // virgülden sonra 13-14 basamak duyarlı
            decimal kesirli3; // virgülden sonra 28 basmak duyarlı

            string isim = "Yavuz Gedik";
            string harf = "a";
            char c = 'y'; // karakter tipi

            // True (1) veya False (0) değerlerini tutulur.
            bool bugunTatilMi = false;
            bool bugunDersVarMi = true;
            bool result = 10 > 2;

            var deger = "Ahmet"; // var tipli değişkene ne atanırsa o tipe bürünür.
            var deger1 = 5;
            var durum = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show metotu ile ekranda mesaj gösteriyoruz.
            // Bu metot içine string bir ifade yazmamız gerekiyor.
            MessageBox.Show(sayi.ToString()); // sayi değişkenin tipi Byte olduğu ve ekranda değerini yazmamız için ToString() metotu ile string tipine dönüştürülür.
            
            // sayi değişkeni global değişken olduğu için, bu metot içinde erişip kullanabiliyorum.
            sayi = 10;
            MessageBox.Show(sayi.ToString());
            MessageBox.Show(metin); // metin değişkeninin tipi string olduğu için ToString() metotu kullanımına gerek yoktur.
        }

        private void btnMerhaba_Click(object sender, EventArgs e)
        {
            string gelenMetin = txtMetin.Text; // txtMetin adlı TextBox'ın Text değeri ilgili değişkene atanıyor. (Text özelliği string'dir.)
            MessageBox.Show("Merhaba " + gelenMetin); // + karakteri ile ik string birleştirilir.
            btnMerhaba.Text = gelenMetin; // btnMerhaba adlı Button'ın Text değerine gelenMetin'in değeri atanıyor.
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtMetin.Text; // Form'un Text değerine atama yapılıyor.
            
            // this.Text yerine sadece Text kullanılabilir.
            //Text = txtMetin.Text;
        }

        private void BtnZaman_Click(object sender, EventArgs e)
        {
            DateTime zaman = new DateTime(); // Tarih, Zaman ve Saat işlemleri için kullandığımız Class ve Tip
            zaman = DateTime.Now; // Kod satırının çalıştığı andaki tarih ve saat bilgileri zaman değişkenine atanıyor.

            MessageBox.Show(zaman.ToString());
        }
    }
}
