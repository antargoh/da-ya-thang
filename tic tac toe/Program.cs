using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            
            
            getplay1(ref board);
            gamestart(ref board);
            getplay2(ref board);
            gamestart(ref board);
            getplay1(ref board);
            gamestart(ref board);
            getplay2(ref board);
            gamestart(ref board);
            getplay1(ref board);
            gamestart(ref board);
            getplay2(ref board);
            gamestart(ref board);
            getplay1(ref board);
            gamestart(ref board);
            getplay2(ref board);
            gamestart(ref board);
            getplay1(ref board);
            gamestart(ref board);
          



            //get playe 1 input
            //int py1o1 = int.Parse(Console.ReadLine());
            //int py1o2 = int.Parse(Console.ReadLine());
            //display


            //board[py1o1, py1o2] = "x";

            //Console.WriteLine("-------");
            // for (int i = 0; i < 3; i++)
            //{
            // for(int j = 0; j < 3; j++)
            //{
            //Console.Write("|" + board[i, j]);
            // }
            // Console.WriteLine("|");
            // Console.WriteLine("-------");
            //}


            // gamestart();
            //getplay1();
            //checkwin();
            //getplay2();
            //checkwin();
            //showscore();
            Console.ReadLine();

            


        }

        private static void showscore()
        {
            
        }

        private static void getplay2(ref string[,] board)
        {
            int py1o1 = int.Parse(Console.ReadLine());
            int py1o2 = int.Parse(Console.ReadLine());
            board[py1o1, py1o2] = "0";
        }

        private static void checkwin()
        {
            
        }

        private static void getplay1(ref string[,]board)
        {
            int py1o1 = int.Parse(Console.ReadLine());
            int py1o2 = int.Parse(Console.ReadLine());
            board[py1o1, py1o2] = "x";
        }

        private static void gamestart(ref string[,] board)
        {
            Console.WriteLine("-------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + board[i, j]);
                }
                Console.WriteLine("|");
                Console.WriteLine("-------");
            }

        }
    }
}
