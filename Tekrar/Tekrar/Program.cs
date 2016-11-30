using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dört işlem.

            //bool devam = true;

            //while (devam)
            //{
            //    Console.Write("Birinci Sayi: ");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İkinci Sayi: ");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("İslem Sec: ");
            //    char islem = Convert.ToChar(Console.ReadLine());

            //    double sonuc;

            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;

            //        default:
            //            Console.WriteLine("Böyle bir islem tipi yok!");
            //            sonuc = 0;
            //            break;

            //    }
            //    Console.WriteLine("Sonuc: " + sonuc);

            //    Console.WriteLine("Devam edelim mi? (evet)");
            //    string cevap = Console.ReadLine();

            //    if (cevap == "evet")
            //    {
            //        devam = true;
            //    }
            //    else
            //    {
            //        devam = false;
            //    }

            //}
            //Console.WriteLine("Görüşmek Üzere");
            //Console.ReadLine();

            #endregion


            #region Taban Dönüştürme

            int sayi = Convert.ToInt32(Console.ReadLine());

            int sonuc = 0;
            int basamak = 1;
            while (sayi > 0)
            {
                sonuc += (sayi % 2) * basamak;
                    basamak *= 10;
                sayi /= 2;
            }

            Console.WriteLine(sonuc);
            Console.ReadKey();

            #endregion





        }
    }
}
