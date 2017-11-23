using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_papper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userscore = 0;     //user currant score
            int commyscore = 0;    //com currant score
            bool repeat = true;    //replay

            while (repeat)    //loop
            {
                string result = "draw";
                printscore(ref userscore, ref commyscore);    //showscore
                string userchoice = userturn();      //u go
                string commychoice = computerturn();    //com go
                result = determinewinner(userchoice, commychoice);    //whowon
                givefeedback(result, userchoice, commychoice);       //feedback
                updatescores(result, ref userscore, ref commyscore);    //updatescore
                repeat = playagin();  //replay


            }


        }

        private static bool playagin() //replay
        {
            Console.WriteLine("do you want to play agin");
            Console.WriteLine("1.yes");
            Console.WriteLine("2.no");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private static void updatescores(string result, ref int userscore, ref int commyscore) //updatescore
        {
            if (result == "win")
            {
                userscore++;
            }
            else if (result == "lose")
            {
                commyscore++;
            }
        }

        private static void givefeedback(string result, string userchoice, object commychice) //feedback
        {
            Console.WriteLine("you did " + userchoice + " the computer used " + commychice);
            Console.WriteLine("you " + result);
        }

        private static string determinewinner(string userchoice, string commychoice) //whowon
        {
            if (userchoice == "rock")
            {
                if (commychoice == "rock")
                {
                    return "draw";
                }
                else if (commychoice == "paper")
                {
                    return "lose";
                }
                else
                {
                    return "win";
                }
            }
            else if (userchoice == "paper")
            {
                if (commychoice == "rock")
                {
                    return "win";
                }
                else if (commychoice == "paper")
                {
                    return "draw";
                }
                else
                {
                    return "lose";
                }

            }
            else
            {
                if (commychoice == "rock")
                {
                    return "lose";
                }
                else if (commychoice == "paper")
                {
                    return "win";
                }
                else
                {
                    return "draw";
                }

            }
        }

        private static string computerturn()  //com go

        {
            Random rnd = new Random();
            int comchoice = rnd.Next(1, 4);
            if (comchoice == 1)
            {
                return "rock";
            }
            else if (comchoice == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }

        private static string userturn()  //u go
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: rock");
                Console.WriteLine("2: papper");
                Console.WriteLine("3: scissors");
                Console.WriteLine("your pick");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                return "rock";
            }
            else if (choice == "2")
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }

        private static void printscore(ref int userscore, ref int commyscore)  //showscore
        {
            Console.Clear();
            Console.WriteLine("your score " + userscore + " the computer score " + commyscore);
        }




    }

}
