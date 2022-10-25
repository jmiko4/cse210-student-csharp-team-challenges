using System;
using System.Collections.Generic;


namespace _05_jumper.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {   
        Words word = new Words();
        TerminalService display = new TerminalService();
        Jumper jumper = new Jumper();
        bool _isPlaying = true;
        string _guess;
        string _guess_blanks;
        string _game_word;
        int _guess_count = 0;


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        { 
            _game_word = word.getWord();
            Console.WriteLine(_game_word);
            _guess_blanks = word.CreateSpaces(_game_word);
            Console.WriteLine(_guess_blanks);
            // Console.WriteLine(word.CreateSpaces(_game_word));
            display.DisplayJumper(jumper.GetJumper());
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// picks the word
        /// </summary>
        /// <summary>
        ///Gets user input
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine("Guess a letter");
            _guess = Console.ReadLine();
        }

        /// <summary>
        /// Updates the jumper
        /// </summary>
        public void DoUpdates()
        {
            _guess_count++;
            if (_game_word.Contains(_guess)){
                char[] ch = _guess_blanks.ToCharArray();
                char[] ch2 = _guess.ToCharArray();
                for (int i = 0; i < _game_word.Length; i++){
                    if (_game_word[i]==_guess[0]){
                        ch[i] = ch2[0] ;
                    }
                }
                _guess_blanks = new string(ch);
                // _guess_blanks = new_guess_blanks;
            }
            else { jumper.RemoveLine(); }

            if (!_guess_blanks.Contains("_")){
                _isPlaying=false;
                Console.WriteLine("You won!");
            }
            else if(_guess_count ==4){
                Console.WriteLine("Game over!");
                _isPlaying=false;
            }
        }

        /// <summary>
        /// Displays stuff
        /// </summary>
        public void DoOutputs()
        {
            // Console.WriteLine(_game_word);
            if(_isPlaying){
                Console.WriteLine(_guess_blanks);
                Console.WriteLine("");
                display.DisplayJumper(jumper.GetJumper());
            }
            else{return;}
        }

    }
}