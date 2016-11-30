using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanım
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("{0}.Merhaba Dünya", i);
            //}
            //Console.ReadKey();
            #endregion

            #region WhileFor

            //int n = 10, fakto = 1, counter = 1;

            //while (counter <= n)
            //{
            //    fakto *= counter;
            //    counter++;
            //}
            //Console.WriteLine(fakto);
            //Console.ReadKey();

            /* ********* FORCA ******* */

            //int n = 5, fakto = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fakto *= i;
            //}
            //Console.WriteLine(fakto);

            //Console.ReadLine();

            #endregion

            #region BirdenFazlaKontrol
            //bool durum = true;
            //for (int i = 0; durum == true && i < 100; i++) //durum==true
            //{
            //    if (i * 2 > 20)
            //    {
            //        durum = false;
            //        //break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}İken devam ediyorum", i);
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region BreakCountinue
            //for (int i = 0; i < 100; i += 5)
            //{
            //    if (i * 2 < 20)
            //    {
            //        //break; İşlemden direk çıkartır. // döngüyü sonlandırır.
            //        continue; // bir sonrakine geçirir. // bir sonraki değere gönderir - geçirir.
            //    }
            //    Console.WriteLine("{0} iken devam ediyorum", i);
            //}
            //Console.ReadKey();
            #endregion

            #region [1,n]Aralığindaki sayilarin toplami
            //int n = Convert.ToInt32(Console.ReadLine());
            ////int n = Convert.ToInt32("5");

            //int toplam = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    toplam += i;
            //    Console.WriteLine("i : {0} \t Toplam: {1}", i, toplam);
            //}
            //Console.WriteLine("Genel Toplam : " + toplam);
            //Console.ReadKey();
            #endregion

            #region 

            #endregion

        }
    }
}
