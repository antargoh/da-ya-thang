using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stuff");

            List<ConsoleColor> colors = new List<ConsoleColor>();
            colors.Add(ConsoleColor.Black);
            colors.Add(ConsoleColor.Blue);
            colors.Add(ConsoleColor.Cyan);
            colors.Add(ConsoleColor.DarkBlue);
            colors.Add(ConsoleColor.DarkCyan);
            colors.Add(ConsoleColor.DarkGray);
            colors.Add(ConsoleColor.DarkGreen);
            colors.Add(ConsoleColor.DarkMagenta);
            colors.Add(ConsoleColor.DarkRed);
            colors.Add(ConsoleColor.DarkYellow);
            colors.Add(ConsoleColor.Red);

            int colors_index = 0;

            string sy = Console.ReadLine();
            int y = int.Parse(sy);
           
            for(int x = 1; x < y; x += 1) 
            {

                Console.Write($"{colors_index} ");
                
                if(x % 5 == 0)
                {
                    colors_index += 1;
                    colors_index %= colors.Count;

                    Console.BackgroundColor = colors[colors_index];
                } 

            }


            Console.ReadLine();



            int j = 1;
            while (j <= j*j)
            {

                Console.WriteLine("hi");



            }


            Console.ReadLine();





        }
    }
}
