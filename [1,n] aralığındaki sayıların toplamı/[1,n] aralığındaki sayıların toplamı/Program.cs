using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_n__aralığındaki_sayıların_toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
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
