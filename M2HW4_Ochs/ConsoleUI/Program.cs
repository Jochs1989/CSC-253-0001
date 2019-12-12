using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool exit = false;
            do
            {
                Console.WriteLine("Would you like to run the program (type 'yes' or 'no')");
                input = Console.ReadLine();
                input = input.ToLower();
                switch (input)
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
