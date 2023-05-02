using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CMP1903M_A01_2223
{

    class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }
        public Card(int val)
        {
            Value = (val % 13) + 1;
            if (val / 13 == 0)
            {
                Suit = "+";
            }
            else if (val / 13 == 1)
            {
                Suit = "-";                         //Takes the first 13 cards, makes their suit Spades, second 13 as hearts, etc...
            }
            else if (val / 13 == 2)
            {
                Suit = "÷";
            }
            else
            {
                Suit = "X";
            }
        }

      
        public static string correctWords(int Value, string Suit)
        {
            if (Value == 1)
            {
                return "1 " + Suit;
            }
            else if (Value == 11)
            {
                return "11 " + Suit;                       
            }                                               //This changes the corresponding values to Ace, jack, queen, and king
            else if (Value == 12)                           //Instead of 1,11,12,13
            {
                return "12 " + Suit;
            }
            else if (Value == 13)
            {
                return "13 " + Suit;
            }
            else
            {
                return Value + " " + Suit + " ";
            }

        }
        
    }
}
