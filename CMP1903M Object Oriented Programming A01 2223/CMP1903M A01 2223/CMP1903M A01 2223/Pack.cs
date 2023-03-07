using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();
            for(int i = 1; i <=4; i++)
            {
                for(int j = 1; j <=13; j++)
                {
                    Card card = new Card(i,j);
                    pack.Add(card);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                //FiSHER YATES
            }  
            else if (typeOfShuffle == 2)
            {
                //RIFFLE
            }
            else
            {
                //no shuffle
            }
            //Shuffles the pack based on the type of shuffle   
            return true;

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
