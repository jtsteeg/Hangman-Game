using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class HangmanGame
    {

        bool gameOver = false;
        List<char> mysteryList = new List<char>();
        List<char> guessList = new List<char>();

        public HangmanGame()
        {
            var d = new WordToList();
            mysteryList = d.MakeList();
            var l = new LetterPlay();
            while (gameOver == false)
            {
                Console.WriteLine($"you have {l.remainingTurns} turns left");
                DashPrinter.printDashes(guessList, mysteryList);
                Console.WriteLine("Please enter your guess! Or type '*' to quit");
                string userInput = Console.ReadLine().ToLower();
                if (userInput.Length > 1)
                {
                    Console.WriteLine("Please only submit a single character!");
                }
                else if (userInput.Equals("*"))
                {
                    Console.WriteLine("goodbye");
                    gameOver = true;
                }
                else
                {
                    char c = char.Parse(userInput);
                    guessList.Add(c);
                    l.compare(c, mysteryList);
                }
                gameOver = WinOrLose.compare(l.remainingTurns, mysteryList, guessList);
            }
        }
    }
}

