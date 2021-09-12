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
            while(gameOver == false)
                {
                Console.WriteLine("type 'exit' to quit");
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
