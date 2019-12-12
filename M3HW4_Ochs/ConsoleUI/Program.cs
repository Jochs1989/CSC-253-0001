using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonCreationLibrary;

/**
* 09-29-2019
* CSC 253
* Jeffrey Ochs
* Creates a file for users information to later be put in a class. Then reads the file information and assigns it to the class along with displaying it to the user. 
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            // Both objects used to display stored information
            StandardMessages myMessages = new StandardMessages();
            Person myPerson = new Person();

            do
            {
                //The switch will continue till the user says "no" or will display an error when the user doesn't input "yes" or "no".
                switch (myMessages.DisplayMenu.ToLower())
                {
                    case "yes":
                        // Creates the file for the persons information
                        PersonToFile.CreatePerson();
                        // After reading the file takes the information and stores it in the person class.
                        myPerson = PersonFromFile.GetPerson();
                        // Used to display the information gained from the class method above.
                        Console.WriteLine(StandardMessages.DisplayPerson(myPerson));
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
