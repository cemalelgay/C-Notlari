using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemalElgaySoru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //[1,n]sayıların toplamı.

            int n;
            Console.WriteLine("n: ?");
            n = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = 1; i <=n ; i++)
            {
                toplam += i;
                
            }
            for (int i = n; i >=1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Genel Toplam : " + toplam);
            Console.ReadKey();
        }
    }
}
