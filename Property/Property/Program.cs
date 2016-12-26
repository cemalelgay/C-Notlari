using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            AA nesne = new AA();
            nesne.Z = 85;

            Console.WriteLine(nesne.Z);
            Console.ReadLine();
        }
    }
}
