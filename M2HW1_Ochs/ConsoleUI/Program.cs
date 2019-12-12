using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*   Jeffrey Ochs
*   CSC-253-001
*   09-16-2019
*   This program asks the user to enter a sentence then displays how many words are in the users sentence.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables and do while so that the program does end until the user is done.
            string input;
            bool exit = false;
            do
            {
                //Gets user input for the menu.
                Console.WriteLine("Would you like to run the program (type 'yes' or 'no')");
                input = Console.ReadLine();
                
                switch(input.ToLower())
                {
                    //calls the class method or exits in respose to users input.
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
