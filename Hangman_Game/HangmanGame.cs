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
        int turnsLeft = 10;
        List<char> mysteryList = new List<char>();
        List<char> guessList = new List<char>();

        public HangmanGame() 
        {
            var d = new WordToList();
            mysteryList = d.MakeList();
            while(gameOver == false)
                {
                Console.WriteLine("type '*' to quit");
                string userCommand = Console.ReadLine().ToLower();
                switch (userCommand)
                {
                    case "exit":
                        Console.WriteLine("goodbye");
                        gameOver = true;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
