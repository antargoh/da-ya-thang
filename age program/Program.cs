using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stuf");
            int age = int.Parse(Console.ReadLine());

            DateTime age2 = DateTime.Parse(Console.ReadLine());



           
            




            if  (age < 13)
            {

                Console.WriteLine("your a child");




            }
            else if (age < 20)
            {
                Console.WriteLine("your a teen ");

            }
            else if (age > 21)
            {
                Console.WriteLine("your really old");


            }

            Console.WriteLine("and you are " + age * 12 + " mouthes old");
            Console.WriteLine("and you are " + age * 52 + " weeks old");
            Console.WriteLine("and you are " + age*365 + " days old");
            Console.WriteLine("and you are " + age * 365 * 24 + " hours old");



            Console.ReadLine();



        }
    }
}
