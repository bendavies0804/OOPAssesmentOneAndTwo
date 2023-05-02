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
            Pack pack = new Pack();
            Random random = new Random();
            List<Card> shuffledPack = new List<Card>();
            bool valid = true;

            if (typeOfShuffle == "1")                   //If the user types 1, fisher yates shuffle starts
            {
                Console.WriteLine("Fisher Yates shuffle chosen");
                for (int i = 52; i > 0; i--)
                {
                    int x = random.Next(i);
                    var temp = pack.pack[x];                    //Performs the fisher yates shuffle
                    shuffledPack.Add(temp);
                    pack.pack.RemoveAt(x);
                
                }
                pack.pack = shuffledPack;
                Pack.dealCard(2, pack.pack);                                //Deals the amount of cards the user specifies after the shuffle
                return true;
                //Console.ReadLine();
            }
            else if (typeOfShuffle == "2")
            {
                Console.Write("Riffle shuffle chosen");
                List <Card> firstHalf = new List<Card>();                       //Creates two new lists
                List<Card> secondHalf = new List<Card>();
                for (int i = 0; i < 26; i++)
                {
                    firstHalf.Add(pack.pack[i]);                                 //Adds the first hald of the pack to firstHalf list
                }
                for (int i = 26; i < 52; i++)
                {
                    secondHalf.Add(pack.pack[i]);                               //Adds the second half of the pack to secondHalf list
                }
                for (int i = 0; i<26; i++)
                {
                    shuffledPack.Add(firstHalf[i]);                            //Takes one at a time from each of those lists in puts them shuffled list
                    shuffledPack.Add(secondHalf[i]);
                }

                pack.pack = shuffledPack;
                int amount = 0;
                while (valid)
                {
                    Console.Write("How many cards do you want?: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > 0 && amount < 53)
                    {
                        valid = false;                                          //This while loop only allows the user to type a number between 1 and 52
                    }
                    else
                    {
                        Console.WriteLine("Number of cards is invalid try again.");
                    }
                }

                dealCard(amount, pack.pack); //Deals the amount of cards the user specifies after the shuffle
                return true;
            }
            else
            {
                Console.WriteLine("No shuffle chosen");
                while (valid)
                {
                    Console.WriteLine("How many cards do you want?: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > 0 && amount < 53)
                    {
                        Pack.dealCard(amount, pack.pack);                           //This while loop only allows the user to type a number between 1 and 52
                        valid = false;
                    }
                    else
                    {
                        Console.WriteLine("Number of cards is invalid try again.");
                        valid = true;
                    }

                }

                return true;
            }
            //Shuffles the pack based on the type of shuffle   
            //return true;

        }


        /*
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

        */
       public static Card dealCard(int amount, List<Card> list)
       {
            //Deals the number of cards specified by 'amount
            var dealCard = list.Take(amount);
            dealCard = list.Take(amount);
            int i = 0;
            int j;
            int num1;
            int num2;
            foreach (Card card in dealCard)
            {
                if (i == 0)
                {
                    num1 = card.Value;
                    Console.Write(card.Value);    //Deals the cards specified by the user
                    Console.Write(" ");
                    Console.Write(card.Suit);
                    Console.Write(" ");
                    if (card.Suit == "+")
                    {
                        j = 1;
                    }
                    if (card.Suit == "X")
                    {
                        j = 2;
                    }
                    if(card.Suit == "-")
                    {
                        j = 3;
                    }
                    if (card.Suit == "÷")
                    {
                        j = 4;
                    }
                }
                if (i == 1)
                {
                    num2 = card.Value;
                    Console.Write(card.Value);    //Deals the cards specified by the user
                }
                i = i + 1;
            }
            Console.ReadLine();
            return dealCard.FirstOrDefault();
       }
    }
}
