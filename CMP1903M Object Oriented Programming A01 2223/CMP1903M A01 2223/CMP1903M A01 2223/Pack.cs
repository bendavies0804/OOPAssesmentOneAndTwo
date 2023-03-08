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
                    pack.Add(new Card((Value)i, (Suit)j));
                }
            }
            Console.WriteLine(String.Join(", ", pack));
        }
        public static bool shuffleCardPack(string typeOfShuffle)
        {
 

            if (typeOfShuffle == "1")
            {

                Console.Write("Fisher yates shuffle chosen");
                Console.ReadLine();
                //Console.WriteLine(String.Join(", ", Pack.deck));

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
