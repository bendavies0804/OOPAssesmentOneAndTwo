using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();             //Creates a list

            for (int i = 0; i < 52; i++)
            {
                pack.Add(new Card(i));          //Adds all 52 cards to the deck (list)
            }

        }
        public static bool shuffleCardPack(string typeOfShuffle)
        {

            if (typeOfShuffle == "1")                   //If the user types 1, fisher yates shuffle starts
            {

                Console.WriteLine("Fisher Yates shuffle chosen");
                Pack pack = new Pack();
                Random random = new Random();
                List<Card> shuffledPack = new List<Card>();
                for (int i = 52; i > 0; i--)
                {
                    int x = random.Next(i);
                    var temp = pack.pack[x];                    //Performs the fisher yates shuffle
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(x);
                
                }
                pack.pack = shuffledPack;
                deal(pack.pack);                                //Deals the card after the shuffle
                return true;
                //Console.ReadLine();
            }
            else if (typeOfShuffle == "2")
            {
                Console.Write("Riffle shuffle chosen");
                Pack pack = new Pack();
                List<Card> shuffledPack = new List<Card>();                 
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

        public static Card deal(List<Card> list)
        {
            //Deals one card
            var deal = list.Take(1);
            deal = list.Take(1);
            foreach(Card card in deal)
            {
                Console.WriteLine(card.Value + " of " + card.Suit);
                Console.ReadLine();
            }
            return deal.First();
        }
       //public static List<Card> dealCard(int amount)
        //{
            //Deals the number of cards specified by 'amount'
        //}
    }
}
