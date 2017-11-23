using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_8_ball
{
    class Program
    {
        static void Main(string[] args)
        {


            playgame();


        }

        private static void playgame()
        {
            //index
            string[] word = { "yes", "no", "mabye", "who can know", "try agin", "100% YES!!!", "nope to bad your going to die soon" };
            //promt
            Console.WriteLine("ask me a yes no mabye queston");
            //looop game
            if (Console.ReadLine() != "exit")
            {
                Random rnd = new Random();
                //pick word
                Console.WriteLine(word[rnd.Next(5)]);
                //repeat 
                playgame();
            }
        }
    }
}

