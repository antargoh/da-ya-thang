using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flower_2
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong total = 1;
            for (ulong i = 2;i <= 100000;)
            {
                total *= 2;
                Console.WriteLine($"{total} {i}");
                total = i;
            }
            Console.ReadLine();
        }
    }
}
