using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class WinOrLose
    {
        public static bool isSubset(List<char> mysteryList, List<char> guessList)
        {
            bool x = false;
            for (int i = 0; i < mysteryList.Count; i++)
            {
                if (guessList.Contains(mysteryList[i]))
                {
                    x = true;
                }
                else
                {
                    return false;
                }
            }
            return x;
        }

        public static bool compare(int turnsLeft, List<char> mysteryList, List<char> guessList)
        {
            if(isSubset(mysteryList, guessList) == true)
            {
                Console.WriteLine("congratulations! you win the game!");
                return true;
            } 
            else if (turnsLeft < 1)
            {
                Console.WriteLine("Sorry! you lose!");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
