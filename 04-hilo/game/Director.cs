using System;
using System.Collections.Generic;


namespace Unit04.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Card card = new Card();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;
        int _currentCard;
        int _newCard;
        string _guess;


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            _newCard = card.generate();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GenerateNumber();
                GetInputs();
                DoUpdates();
                DoOutputs();
                PlayAgain();
            }
        }

        /// <summary>
        /// generates the card.
        /// </summary>

        public void GenerateNumber()
        {   if (!_isPlaying)
                {
                    return;
                }
            _currentCard = card.generate();
            while (_currentCard == _newCard){
                _newCard = card.generate();
            }
            Console.WriteLine($"The Card is {_currentCard}");
        }

        /// <summary>
        ///Gets user input
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Higher or Lower? [h/l] ");
            _guess = Console.ReadLine();
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if ((_newCard > _currentCard) && (_guess == "h")){
                _score = 100;
            }

            
            else if ((_newCard < _currentCard) && (_guess == "l")){
                _score = 100;
            }

            else _score = -75;

            _totalScore += _score;
        }

        /// <summary>
        /// Displays the score. 
        /// </summary>
        public void DoOutputs()
        {
        
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }

        /// <summary>
        /// Asks the user if they want to play again 
        /// </summary>
        public void PlayAgain(){
            if (!_isPlaying)
            {
                return;
            }
            Console.WriteLine("Would You Like to play Again?(y/n)");
            string again =Console.ReadLine();

            if (again == "y"){
                _isPlaying = true;
            }
            else _isPlaying = false;
        }
    }
}


