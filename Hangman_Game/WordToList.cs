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
        public List<char> mysteryList { get; set; }
        public WordToList()
        {
             wordLibrary = new List<string>() { "table", "chair", "lamp", "desk", "chandelier", "bread", "silver", "revolution", };
        }


        private string GetRandomWord()
        {
            var random = new Random();
            var i = random.Next(0, wordLibrary.Count - 1);
            return wordLibrary[i];
        }

        public void MakeList()
        {
            string mysteryWord = GetRandomWord();
            List<char> mysteryList = new List<char>();

            foreach (var item in mysteryWord)
            {
                mysteryList.Add(item);
            }
            this.mysteryList = mysteryList;
            //return mysteryList;
        }
    }
}
