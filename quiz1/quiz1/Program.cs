using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 n Toplamı
            //int n = 10; // bu sayıya kadar, 1den itibaren toplama yapacağım.
            //int sayac = 1, toplam = 0;

            //while (sayac <= n)
            //{
            //    toplam += sayac;
            //    sayac++;
            //}

            //Console.WriteLine(toplam);
            //Console.Write("Tersten: ");
            //while (n > 0)
            //{
            //    Console.Write(n + " ");
            //    n --;
            //}
            //Console.ReadKey();                 //Her iki döngüde de tersten yazıyor.
            //for (int i = n; i > 0; i--)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.ReadKey();
            #endregion

            //Kare

            #region Kare

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
                #endregion

                // Dikdörtgen
                #region Dikdörtgen
                //for (int i = 0; i < 5; i++)
                //{
                //    for (int j = 0; j < 8; j++)
                //    {
                //        if (i == 0 || i == 4 || j == 0 || j == 7)
                //        {
                //            Console.Write("* ");
                //        }
                //        else
                //        {
                //            Console.Write("  ");
                //        }
                //    }
                //    Console.WriteLine();
                #endregion



                //            for (int i = 0; i < 3; i++)
                //            {
                //                for (int j = 0; i < 8; i++)
                //                {
                //                    if (i == 0 && j >= 2)
                //                    {
                //                        Console.Write("*");
                //                    }
                //                    else
                //                    {
                //                        Console.Write(" ");
                //                    }
                //                }
                //                Console.WriteLine();
            }
        }
    }
}

