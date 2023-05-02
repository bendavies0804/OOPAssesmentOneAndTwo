using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

            if (typeOfShuffle == "1")                   //If the user types 1, fisher yates shuffle starts
            {
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
            return true;
        }



       public static Card dealCard(int amount, List<Card> list)
       {
            //Deals the number of cards specified by 'amount
            var dealCard = list.Take(amount);
            dealCard = list.Take(amount);
            int i = 0;
            int num1 = 1;
            int num2 = 1;
            int j = 1;
            foreach (Card card in dealCard)
            {
                if (i == 0)
                {
                    num1 = card.Value;

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
                    num2 = card.Value;    //Deals the cards specified by the user
                }
                i = i + 1;
            }
            Pack.Maths(num1, j, num2);
            return dealCard.FirstOrDefault();
       }


        public static bool Maths(int num1, int j, int num2)
        {

            int answer = 0;
            if (j == 1)
            {
                Console.WriteLine(num1 + " + " + num2);
                answer = num1 + num2;
            }
            if (j == 2)
            {
                Console.WriteLine(num1 + " X " + num2);
                answer = (num1 * num2);
            }
            if (j == 3)
            {
                Console.WriteLine(num1 + " - " + num2);
                answer = num1 - num2;
            }
            if (j == 4)
            {
                Console.WriteLine(num1 + " ÷ " + num2);
                answer = num1 / num2;
            }
            string uAnswerStr = Console.ReadLine();
            int uAnswer = Convert.ToInt32(uAnswerStr);
            if (uAnswer == answer)
            {
                Console.WriteLine("Correct!");

            }
            else
            {
                Console.WriteLine("Incorrect! The answer was: " + Convert.ToString(answer));
            }
            bool valid = true;
            while (valid){
                Console.Write("Would you like: 1 -- Another question || 2 -- Main Menu:  ");
                string option = Console.ReadLine();
                if (Convert.ToInt32(option) < 3 && Convert.ToInt32(option) > 0)
                {
                    if (option == "1")
                    {
                        Pack.shuffleCardPack("1");
                    }
                    if (option == "2")
                    {
                        Tutorial.Menu();
                    }
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Invalid option, try again!");
                }
            }

            return true;
        }
    }
}
