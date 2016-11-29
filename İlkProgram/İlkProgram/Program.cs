using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("1. Lira Yükleme.");
            Console.WriteLine("2. İnternet Paketi.");
            Console.WriteLine("3. Konuşma Paketi.");
            Console.WriteLine("4. Mesaj Paketi.");
            Console.WriteLine("Yüklemek İstediğiniz Paketi Seçiniz...");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Lira Yükleme Servisine Hoşgeldiniz ");
                    break;

                case 2:
                    Console.WriteLine("İnternet Paketi Yükleme Servisine Hoşgeldiniz");
                    break;

                case 3:
                    Console.WriteLine("Konuşma Paketi Yükleme Servisine Hoşgeldiniz");
                    break;
                case 4:
                    Console.WriteLine("Mesaj Paketi Yükleme Servisine Hoşgeldiniz ");
                    break;
                default:
                    Console.WriteLine("Müşteri Temsilcisine Yönlendiriliyrosunuz...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
