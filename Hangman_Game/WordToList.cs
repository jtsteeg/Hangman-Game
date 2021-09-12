using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game
{
    class WordToList
    {
        private List<string> wordLibrary;
        public WordToList()
        {
            List<string> wordLibrary = new List<string>() { "table", "chair", "lamp", "desk", "chandelier" };
        }


        private string GetRandomWord()
        {
            var random = new Random();
            var i = random.Next(0, wordLibrary.Count - 1);
            return wordLibrary[i];
        }

        public List<char> MakeList()
        {
            string mysteryWord = GetRandomWord();
            List<char> mysteryList = new List<char>();

            foreach (var item in mysteryWord)
            {
                mysteryList.Add(item);
            }

            return mysteryList;
        }
    }
}
