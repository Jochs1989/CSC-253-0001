using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCreationLibrary
{
    public class StandardMessages
    {
        // Displays the main menu and lets the user either start or end the program.
        public static string DisplayMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("-----------");
            Console.WriteLine("This program will let you create a person!");
            Console.Write("Do you wish to continue? (enter 'yes' or 'no') : ");

            return Console.ReadLine();
         
        }
    }
}
