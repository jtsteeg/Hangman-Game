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
            //var l = new LetterPlay();
            //int x = l.remainingTurns;
            while(gameOver == false)
                {
                Console.WriteLine($"you have {turnsLeft} turns left");
                DashPrinter.printDashes(guessList, mysteryList);
                Console.WriteLine("Please enter your guess! Or type '*' to quit");
                string userInput = Console.ReadLine().ToLower();
                if(userInput.Length > 1)
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
                    bool iscorrect = LetterPlay.compare(c, mysteryList);
                    if(iscorrect == true)
                    {
                        Console.WriteLine($"Yes! {c} is a letter in the mystery word!");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry! {c} is NOT a letter in the mystery word!");
                        turnsLeft -= 1;
                    }
                }
                gameOver = WinOrLose.compare(turnsLeft, mysteryList, guessList); 
            }
        }
    }
