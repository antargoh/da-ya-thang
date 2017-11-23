using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace green_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("enter number for y");
            float y = float.Parse(Console.ReadLine());

            Console.WriteLine($"stuff {x} plus {y} = " + (x + y));
            Console.WriteLine($"stuff {x} minus {y} = " + (x - y));
            Console.WriteLine($"stuff {x} times {y} = " + (x * y));
            Console.WriteLine($"stuff {x} devide {y} = " + (x / y));
            Console.WriteLine($"stuff {x}(x)is equil to {y}(y) {x} = " + (x = y));
            //Math.Round  x + y($"stuff {x} rounded {y} = " + (x  y));





            Console.ReadLine();
        }
    }
}
