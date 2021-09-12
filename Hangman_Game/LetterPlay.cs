using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class LetterPlay
    {
        //    string input;
        //    List<char> mysteryList;
        //    public LetterPlay(string input, List<char> mysteryList)
        //    {
        //        this.input = input;
        //        this.mysteryList = mysteryList;
        //    }

        public static bool compare(char guess, List<char> mysteryList)
        {           
           if (mysteryList.Contains(guess))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
