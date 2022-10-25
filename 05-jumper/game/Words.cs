using System;
using System.Collections.Generic;

namespace _05_jumper.Game{

    public class Words{

        // List<String> words = new List<String>();
        private List<string> words= new List<string>() {"friend", "dad", "food", "animal", "france"};

        public Words(){}
        private string spaces;

        public string getWord()
        {   
            Random rand = new Random();
            int index = rand.Next(words.Count);
            return words[index];
        }

        public string CreateSpaces(string word){
            // string spaces;
            for (int i = 0; i < word.Length; i++){
                spaces = spaces + "_";
                // Console.Write("_ ");
            }
            return spaces;
        }


    }



}