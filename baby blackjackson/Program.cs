using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baby_blackjackson 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            float money = 10;
            Playgame(ref money);
            Console.WriteLine("2");

        }

        private static void Playgame(ref float money)
        {
            Console.Clear();
            float betamount = makebet(ref money);
            Random rnd = new Random();
            int playertotal = dealcards(rnd, "you");
            int comtotal = dealcards(rnd, "the com");
            bool playerwins = determainewinner(playertotal, comtotal);
            payout(playerwins, betamount, ref money);
            menu(ref money);
        }

        private static void menu(ref float money)
        {
            Console.Write("would you like to play agian y/n ");
            if (Console.ReadLine() == "y")
            {
                Playgame(ref money);
            }
        }

        private static void payout(bool playerwins, float betamount, ref float money)
        {
            if (playerwins)
            {
                money = money + (betamount * 2);

            }
        }

        private static bool determainewinner(int playertotal, int comtotal)
        {
            if (playertotal > comtotal)
            {
                Console.WriteLine("you win");
                return true;
            }
            else if (playertotal < comtotal)
            {
                Console.WriteLine("you lose");
                return false;
            }
            else
            {
                Console.WriteLine("draw you lose");
                return false;
            }
        }

        private static int dealcards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine(player + " drew " + card1 + " and " + card2 + "for a total of" + total);
            return total;
        }

        private static float makebet(ref float money)
        {
            float betamount = 0;
            bool valibet = false;
            while (valibet != true) ;
            Console.WriteLine($"make a bet you have ${money}");
            {
                valibet = float.TryParse(Console.ReadLine(), out betamount);

                if (betamount > money)
                {
                    Console.WriteLine("you cant bet that learn math");
                    valibet = false;
                }
                else if (betamount < 0)
                {
                    Console.WriteLine("you broke go home");
                    valibet = false;
                }
            }
            money = money - betamount;
            return betamount;
        }
    }
}

