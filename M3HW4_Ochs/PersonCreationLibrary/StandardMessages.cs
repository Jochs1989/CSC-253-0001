using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCreationLibrary
{
    public class StandardMessages
    {
        // Displays the main menu and lets the user either start or end the program (this is assigned to the object in the Program class.
        public string DisplayMenu
        {
            get 
            {
                Console.WriteLine("MENU");
                Console.WriteLine("-----------");
                Console.WriteLine("This program will let you create a person and display the info!");
                Console.Write("Do you wish to continue? (enter 'yes' or 'no') : ");

                return Console.ReadLine();
            }
            
        }
        // Used the information from the Person class and returns it to be displayed.
        public static string DisplayPerson(Person myPerson)
        {
            return $"Name is {myPerson.FirstName} {myPerson.LastName} and is {myPerson.Age} years old.";
        }
    }
}
