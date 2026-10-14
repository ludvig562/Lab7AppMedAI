using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab7AppMedAI
{
    internal class ScrableWords
    {
        public string Word { get; set; }

        public ScrableWords(string word)// konstruktor
        {
            Word = word;
        }

        //AI
        //public string ScrableWord()
        //{
        //    Random random = new Random();

        //    char[] letters = Word.ToCharArray();

        //    letters = letters.OrderBy(x => random.Next()).ToArray(); // Makes so that every letter in the word get its own random number and then sorts it from lowes to highest 

        //    return new string(letters);
        //}

        public string ScrableWord()
        {
            char[] letters = Word.ToCharArray();// creates a char array and and ToCharArray makes the word in to letter and puts it in the array 
            Random random = new Random();

            for (int i = letters.Length - 1; i > 0; i--)// for loop to switch each ofleter with a random letter using tupel switch
            {
                int randomIndex = random.Next(i + 1);

                (letters[i], letters[randomIndex]) =
                    (letters[randomIndex], letters[i]);
            }

            return new string(letters); // creates a new string using the letters from the char array 
        }
    }
}
