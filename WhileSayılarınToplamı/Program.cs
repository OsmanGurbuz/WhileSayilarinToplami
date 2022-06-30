using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSayılarınToplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            int sayi = 0;
            int toplam = 0;

            while (sayac<=5)
            {
                Console.Write("{0}. sayıyı giriniz", sayac);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
                sayac++;


            }
            Console.Write("sayıların toplamı:{0}",toplam);
            Console.ReadKey();
        }
    }
}
