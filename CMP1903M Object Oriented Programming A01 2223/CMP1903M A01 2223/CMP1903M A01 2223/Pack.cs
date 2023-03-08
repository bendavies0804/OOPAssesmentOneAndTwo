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
            List<Card> pack = new List<Card>();
            Pack deck = new Pack();
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                
                }
            }

        }
        public static bool shuffleCardPack(string typeOfShuffle)
        {
            //Console.Write("Choose a shuffle");
            //Console.Write("1 -- Fisher Yates || 2 -- Riffle || 3 -- no shuffle");
            //string userInput = Console.ReadLine();

            if (typeOfShuffle == "1")
            {

                Console.Write("Fisher yates shuffle chosen");
                Console.ReadLine();

            }  
            else if (typeOfShuffle == "2")
            {
                Console.Write("Riffle shuffle chosen");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No shuffle chosen");
                Console.ReadLine();
            }
            //Shuffles the pack based on the type of shuffle   
            return true;

        }

        //public static Card deal()
        //{
            //Deals one card

        //}
        //public static List<Card> dealCard(int amount)
        //{
            //Deals the number of cards specified by 'amount'
        //}
    }
}
