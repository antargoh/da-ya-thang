using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insault_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            //subparths / randome funcation 
            string name = getname();
            Random rnd = new Random();
            makeinsult(name, rnd);
        }
        //join words
        private static void makeinsult(string name, Random rnd)
        {
            Console.WriteLine("");
            Console.WriteLine(name + " you are " + getadj(rnd) + "" + getcomadj(rnd) + "" + getob(rnd));
            menu(name, rnd);
        }
        //replay?
        private static void menu(string name, Random rnd)
        {
            Console.WriteLine("agin?");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");
            if (Console.ReadLine() == "1")
            {
                makeinsult(name, rnd);
            }
        }
        //part object
        private static string getob(Random rnd)
        {
            string[] ob = { "noob head ", "tony abbout ", "jacksons lef nut ", "nip ", "shit ", "asian food ", "african " };
            return ob[rnd.Next(7)];

        }
        //part compound adjuitv
        private static string getcomadj(Random rnd)
        {
            string[] comadj = { "pice of ", "under educated ", "pat loveing ", "cis-gender ", "cunt bagging ", "muffin munching ", "commie supporting " };
            return comadj[rnd.Next(7)];

        }
        //part adjitive 
        private static string getadj(Random rnd)
        {
            string[] adj = { "smelly ", "pitafull ", "usless ", "ginger ", "sjw ", "hairy ", "left wing " };
            return adj[rnd.Next(7)];
        }
        //getnamey

        private static string getname()
        {
            Console.WriteLine("what is your name");
            return Console.ReadLine();

        }
    }
}




