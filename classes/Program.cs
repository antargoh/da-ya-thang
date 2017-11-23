using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {


            

            Random rnd = new Random();
            int[] ages = { 2, 24, 38, 99, 84,  5 , 70 };
            string[] hair = { "no", "red", "blond", "brown", "black", "green", "bandaner cos of canser" };

            person p = new person(ages[rnd.Next(7)]);
            

            p.printAge();

            Console.ReadLine();





        }

    }

    class person
    {
        private int age;
        private string hair ;
        private float hight;


        public person(int age)
        {
            this.age = age;
            this.hair = hair;

        }


        public void printAge()
        { 
            Console.WriteLine($"that peson is {age} years old and has {hair} hair ");

        }



    }
















}
