using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            while (valid)
            {
                Console.Write("Choose a shuffle \n\t\t ");
                Console.Write("1 -- Fisher Yates || 2 -- Riffle || 3 -- no shuffle:  ");
                string typeOfShuffle = Console.ReadLine();
                if (Convert.ToInt32(typeOfShuffle) > 0 && Convert.ToInt32(typeOfShuffle) < 4)
                {
                    Pack.shuffleCardPack(typeOfShuffle);                                                //This while loop will only allow the user to put in a number between 1 and 3 for the shuffles.
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Invalid shuffle chosen, try again.");
                }
                

            }

        }
    }
}
