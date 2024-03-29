﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Tutorial
    {
        public static void Menu()
        {
            bool valid = true;
            while (valid)
            {

                Console.Write("Main Menu: \n\t\t ");
                Console.Write("1 -- Questions || 2 -- Instructions || 3 -- Quit:  ");
                string choice = Console.ReadLine();
                int b = -1;
                bool a = int.TryParse(choice, out b);
                if (a == true && b > 0 && b < 4)
                {
                    if (choice == "1")
                    {
                        Pack.shuffleCardPack("1");
                    }                                                        //This while loop will only allow the user to put in a number between 1 and 3 for the options.
                    if (choice == "2")
                    {
                        Tutorial.Instructions();
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        Task.Delay(5000);
                        System.Environment.Exit(0);
                    }
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Invalid selection, try again.");
                }


            }
        }

        public static void Instructions()
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine("You are given a maths question. This can be either +,-,X,÷. (Division is only whole numbers)");
            Console.WriteLine("After you have answered, it will tell you correct or incorrect depending on what answer you put.");          //instructions
            Console.WriteLine("After each question, you will have the option to have another question or go back to the menu.");
            Console.WriteLine("Have fun!");
            Tutorial.Menu();
        }

    }
}
