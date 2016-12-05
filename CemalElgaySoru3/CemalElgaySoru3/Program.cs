using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemalElgaySoru3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sekil;
            Console.WriteLine("Kare mi? Dikdörtgen mi? Paralelkenar mı?");
            sekil = Console.ReadLine();
            switch (sekil)
            {
                case "kare":
                    for (int i = 5; i < 10; i++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                    
                    for (int c = 0; c < 5; c++)
                    {
                        Console.WriteLine(" *");

                       


                    }
                    Console.WriteLine();
                    
                    break;
                default:
                    Console.WriteLine("Böyle bir şekil yok!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
