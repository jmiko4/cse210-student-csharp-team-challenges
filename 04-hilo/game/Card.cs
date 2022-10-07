using System;

namespace Unit04.Game
{
    public class Card{

        public int _value;
        public int _currentCard;

        public Card(){}

        public int generate(){
            // generates a random number between 1 and 13
            Random rand = new Random();
            _value = rand.Next(1,14);
            return _value;

        }

    }









}