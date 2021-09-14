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

        public HangmanGame()
        {
            var d = new WordToList();
            var l = new LetterPlay();
            d.MakeList();

            while (gameOver == false)
            {
                Console.WriteLine($"you have {l.remainingTurns} turns left");
                DashPrinter.printDashes(l.guessList, d.mysteryList);
                Console.WriteLine("Please enter your guess! Or type '*' to quit");
                string userInput = Console.ReadLine().ToLower();
                if (userInput.Length > 1)
                {
                    Console.WriteLine("Please only submit a single character!");
                }
                else if (userInput.Equals("*"))
                {
                    Console.WriteLine("goodbye");
                    System.Environment.Exit(0);
                }
                else
                {
                    char c = char.Parse(userInput);
                    l.compare(c, d.mysteryList);
                }
                gameOver = WinOrLose.compare(l.remainingTurns, d.mysteryList, l.guessList);
            }
        }
    }
}

