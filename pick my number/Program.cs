using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pick_my_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("heyyyy");



            Random rnd = new Random();
            int rand1 = rnd.Next(1, 499);
            int rand2 = rnd.Next(rand1+1, 1000);
            int rand = rnd.Next(rand1, rand2);

            int guess = -1;

            

            //123443

            
            int count = 0;

            //yes no mabye i dont know 
            while (guess != rand)
            {
                count++;
                Console.WriteLine($"what num between {rand1} and {rand2} ");
                guess = int.Parse(Console.ReadLine());
                

            if (guess < rand)
                {
                    Console.WriteLine("nope to low");

                }
                else if (guess > rand)
                {
                    Console.WriteLine("nope to high ");

                }
                 else 
                {
                    Console.WriteLine($"yep it took you {count} goes");

                }
            }


















            // im so lonely
            Console.ReadLine();



        }
    }
}
