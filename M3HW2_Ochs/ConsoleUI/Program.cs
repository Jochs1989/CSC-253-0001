using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberLibrary;

/**
* 09-20-2019
* CSC 253
* Jeffrey Ochs
* Creates a file that stores a user designated amount of random numbers, then pulls that file and displays results.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            //The program will loop so it doesn't end until the user is ready to stop.
            do
            {
                //The switch will continue till the user says "no" or will display an error when the user doesn't input "yes" or "no".
                switch (StandardMessages.DisplayMenu().ToLower())
                {
                    case "yes":
                        StandardMessages.GetRandomNumbers();
                        break;
                    case "no":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter 'yes' or 'no'!");
                        break;
                }


            } while (exit == false);
        }
    }
}
