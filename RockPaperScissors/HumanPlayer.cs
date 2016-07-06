using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : IPlayer
    {
        public int HumanMove;
        int getNextMove()
        {
            while (true)
            {
                Console.Write("Enter R (Rock), P (Paper), or S (Scissors), Q (quit): ");

                string choice = Console.ReadLine().ToUpper();
              
                if (choice == "R")
                {
                    HumanMove = 0;
                    return 0;
                }
                if (choice == "P")
                {
                    HumanMove = 1;
                    return 1;
                }
                if (choice == "S")
                {
                    HumanMove = 2;
                    return 2;
                }
                if (choice == "Q")
                {
                    HumanMove = -1;
                    return -1;
                }
                Console.WriteLine("I didn't understand that.");

            }
        }


        public int NextMove()
        {
            return getNextMove();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // do nothing
        }
    }
}
