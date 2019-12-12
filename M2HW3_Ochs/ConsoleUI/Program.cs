using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*   Jeffrey Ochs
*   CSC-253-001
*   09-16-2019
*   This program asks the user to enter a sentence then displays the most frequent letter in their sentence.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while for a menu
            string input;
            bool exit = false;
            do
            {
                //gets user input to be used for the switch.
                Console.WriteLine("Would you like to run the program (type 'yes' or 'no')");
                input = Console.ReadLine();
                //switch either calls the class method or exits the program.
                switch (input.ToLower())
                {
                    case "yes":
                        DisplayResults.GetSentence();
                        break;
                    case "no":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }

            } while (exit == false);
        }
    }
}
