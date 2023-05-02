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
            Value = (val % 12) + 1;
            if (val / 13 == 0)
            {
                Suit = "+";
            }
            else if (val / 12 == 1)
            {
                Suit = "-";                         //Only done up to 12 as maths in primary school only usually goes up to 12 times table
            }
            else if (val / 12 == 2)
            {
                Suit = "÷";
            }
            else
            {
                Suit = "X";
            }
        }
        
    }
}
