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
                Console.Write(@"
                                         _______________
                                        |@@@@|     |####|
                                        |@@@@|     |####|
                                        |@@@@|     |####|
                                        \@@@@|     |####/
                                         \@@@|     |###/
                                          `@@|_____|##'
                                               (O)
                                            .-'''''-.
                                          .'  * * *  `.
                                         :  *       *  :
                                        : ~ ~ Y O U ~ ~ :
                                        : ~ ~ W I N ~ ~ :
                                         :  *       *  :
                                          `.  * * *  .'
                                            `-.....-'
                      ");
                return true;
            } 
            else if (turnsLeft < 1)
            {
                Console.WriteLine(@"
                                     _                     
                                    | |                    
                                    | | ___  ___  ___ _ __ 
                                    | |/ _ \/ __|/ _ \ '__|
                                    | | (_) \__ \  __/ |   
                                    |_|\___/|___/\___|_|   
                     ");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
