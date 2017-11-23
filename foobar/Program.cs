using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foobar
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 to input
            // get inpu
            string jj = Console.ReadLine();
            int j = int.Parse(jj);
            //loop
            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine($"{i}");

                if (i%3==0 && i%5==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("foobar");
                    Console.Beep(600, 100);
                    
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("foo");
                    Console.Beep(700, 100);
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("bar");
                    Console.Beep(800, 100);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine($"{i}");
                    Console.Beep(600, 100);
                }







            }



            Console.ReadLine();
        }
    }
}
