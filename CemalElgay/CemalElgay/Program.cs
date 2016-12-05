using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemalElgay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32("5");

            int toplam = 0;
            for (int i = 1; i <= n; i++)
            {
                toplam += i;
                Console.WriteLine("i : {0} \t Toplam: {1}", i, toplam);
            }
            Console.WriteLine("Genel Toplam : " + toplam);
            Console.ReadKey();
        }
    }
}
