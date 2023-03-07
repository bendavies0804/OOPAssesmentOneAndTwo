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
        List<int> Value = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13};
        //Suit: numbers 1 - 4
        List<int> Suit = new List<int>() {1,2,3,4};

        //The 'set' methods for these properties could have some validation
       public int value { get; set; }
       public int suit { get; set; }

        public Card(int Value, int Suit)
        {
            Value = Value;
            Suit = Suit;  

        }
    }
}
