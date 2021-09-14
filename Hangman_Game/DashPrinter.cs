using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class DashPrinter
    {
        public static void printDashes(List<char> guessList, List<char> mysteryList)
        {
          Console.WriteLine($"The Mystery word is: \n");
            for (int i = 0; i < mysteryList.Count; i++)
            {
                if (guessList.Contains(mysteryList[i]))
                {
                    Console.Write(mysteryList[i] + " ");
                }
                else
                {
                    Console.Write("- ");
                }
            }
            Console.Write("\n");
        }
    }
}
