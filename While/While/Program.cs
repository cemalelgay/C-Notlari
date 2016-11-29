using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [0.9] Sayilari Dahil

            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;

            //}
            //Console.ReadKey();

            #endregion
            #region [1.10]Toplam
            //int a = 1, toplam = 0;
            //while (a <= 10)
            //{
            //    toplam += a;
            //    a++;

            //}
            //Console.WriteLine(toplam);
            //Console.ReadKey();
            //Console.WriteLine(10 * 11 / 2);
            //Console.ReadKey();
            #endregion

            #region FAKTÖRİYEL

            //int a = 10, fakto = 1,n;
            //Console.WriteLine("Faktöriyelini almak istediğiniz sayı");
            //n = Convert.ToInt32(Console.ReadLine());
            //while (a <=n)
            //{
            //    fakto *= a;
            //    a++;
            //}

            //Console.WriteLine("Sonuc= "+toplam);
            //Console.ReadLine();

            //10 tabanındaki sayıyı binary'ye çevirme ÖDEV
            //Kullanıcının istediği tabanındaki sayiyi istediği tabanli sayiya çevir.


            #endregion

            #region SayıTahmini

            Console.WriteLine("[1-10] bir sayı tuttum hadi bul bakalım.");

            Random rnd = new Random(); //object tanımla
            int rasgeleSayi = rnd.Next(1, 11); // min 1 max 10 için (1,11)
            int tahmin, counter = 0;

            while (true)
            {
                counter++;
                Console.Write("Tahminin Ne: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == rasgeleSayi)
                {
                    break;
                }


            }

            Console.WriteLine("\nTebrikler...{0}, adımda bildin", counter);
            Console.ReadLine();
            #endregion



        }
    }
}
