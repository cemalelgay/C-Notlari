using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
{
                Console.Write("Karenin Yıldız Uzunluğunu Yazınız: ");
                int kare_sayisi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < kare_sayisi; i++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                for (int i = 0; i < kare_sayisi - 2; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < kare_sayisi - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" *");
                    Console.Write("\n");
                }
                for (int i = 0; i < kare_sayisi; i++)
                {
                    Console.Write("* ");
                }
                Console.ReadKey();
            }

        }
    }
}
