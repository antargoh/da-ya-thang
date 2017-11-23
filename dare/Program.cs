using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dare
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("hey welocome to our joyfull game show whear evryone is a winner");
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} mmm.. sounds asian ");
            Console.WriteLine("moveing on");

            Console.WriteLine("pick door 1 2 or 3 and you will be greated with a prize");
            string that_one = Console.ReadLine();


            if (that_one == "1")
                {
                Console.WriteLine("you picked 1... thears nothing in that 1");




            }
            else if (that_one == "2")
            {

                Console.WriteLine("you picked 2... sadness...");
            }

            else if (that_one == "3")
            {

                Console.WriteLine("you picked 3... just wasted your time :(");
            }

            else
            {
                Console.WriteLine("idot 1 2 or 3 those wore your options ");
         
            }








            Console.ReadLine();
        
        }
    }
}
