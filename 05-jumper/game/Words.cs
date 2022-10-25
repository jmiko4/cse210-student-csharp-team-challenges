using System;
using System.Collections.Generic;

namespace _05_jumper.Game{

    public class Words{

        // creates the words list
        private List<string> words= new List<string>() {"friend", "dad", "food", "animal", "france", "dave", "dance"};

        public Words(){}
        private string spaces;

        public string getWord()
        {   //returns a random word from the list
            Random rand = new Random();
            int index = rand.Next(words.Count);
            return words[index];
        }

        public string CreateSpaces(string word){
            // creates the spaces for the game
            for (int i = 0; i < word.Length; i++){
                spaces = spaces + "_";
                // Console.Write("_ ");
            }
            return spaces;
        }


    }



}