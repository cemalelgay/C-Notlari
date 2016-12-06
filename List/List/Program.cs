using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TANIM.!!!!
            //List<int> numbers = new List<int>();

            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3, 4 });

            //Console.WriteLine(numbers.Count);

            //Console.Clear();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0}. = {1}", i, numbers[i]);
            //}
            //Console.ReadLine();

            #endregion

            #region Array / List

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;

            //List<int> list = new List<int>(array);

            //Console.WriteLine("{0} tane eleman yazdıracağım", list.Count);

            //foreach (var elm in list)
            //{
            //    Console.Write(elm + " ");
            //}
            //Console.ReadKey();
            #endregion

            #region IndexOF

            //List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905, }); //1907
            //int index = numbers.IndexOf(1907); // değer yoksa inde = -1



            #endregion

            #region MyRegion

            //List<string> isimler = new List<string>();

            //isimler.AddRange(new string[] { "Ali", "Veli", "Ayşe", "Fatma", "Hayriye" });

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Numara Silme

            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            /////*numbers.RemoveAt(0);*/ // 0.indisi siler (3) // girilen index silinir.
            ////// numbers.Remove(3); // ilk gördüğü 3 değerini siler.  // girilen değer silinir. ama o değerden birden fazla varsa ilki silinir.
            //////numbers.RemoveRange(3, 2);  // aralık siler // 3.indeksten sonra 2 tane siler (10,13)
            ////bool varmi = numbers.Contains(15); //15 varsa true olur.
            ////foreach (var item in numbers)
            ////{
            ////    Console.WriteLine("\n\t" + item);
            ////}

            //bool varmi = true;

            //while (varmi)
            //{
            //    if (numbers.Contains(8))
            //    {
            //        numbers.Remove(8);
            //    }
            //    else
            //    {
            //        varmi = false;
            //    }
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("\n\t" + item);
            //}

            #endregion

            #region Döndürme

            //var result = numbers.Find(i => i > 5); // 5 ten büyük ilk değer döner

            /*var result = numbers.FindAll(i => i > 5); */// 5 ten büyük elemanları List olarak atar.

            // var result = numbers.FindAll(i => i > 5).Count(); // 5 den büyük tüm elemanlar döner.

            numbers.Sort(); // küçükten büyüğe sıralar.
            numbers.Reverse(); // büyükten küşüğe bu iki koşuluğu kullanmak lazım.

            foreach (var item in numbers) 
            {
                Console.WriteLine("\n\t" + item);
                
            }

            #endregion

        }
    }
}
