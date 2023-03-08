using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.


        //Value: numbers 1 - 13
        
        public enum Value 
        { 
            Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King 
        };
        //Suit: numbers 1 - 4
        public enum Suit 
        { 
            Spades, Hearts, Diamonds, Clubs 
        };

        //The 'set' methods for these properties could have some validation
        public Value _value { get; set; }
        public Suit _suit { get; set; }

        public Card(Value value, Suit suit)
        {
            _value = value;
            _suit = suit; 

        }
    }
}
