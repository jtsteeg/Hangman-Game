using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class LetterPlay
    {
        public int remainingTurns { get; set; }
        public List<char> guessList { get; set; }
        public LetterPlay()
        {
            remainingTurns = 10;
            this.guessList = new List<char>();
        }

        public bool compare(char guess, List<char> mysteryList)
        {
            guessList.Add(guess);
            if (mysteryList.Contains(guess))
            {
                Console.WriteLine($"Hooray! {guess} is a letter in the mystery word!");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry! {guess} is NOT a letter in the mystery word!");
                remainingTurns -= 1;
                return false;
            }
        }
    }
}
