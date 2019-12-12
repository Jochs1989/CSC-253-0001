using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumberLibrary
{
    public class StandardMessages
    {
        // Allows the user to enter a number used to determine how many random numbers to show.
        public static void GetRandomNumbers()
        {
            Console.Write("How many numbers would you like to see? : ");

            RandomNumberClass.CreateFile(Console.ReadLine());
        }
        // Displays the main menu and lets the user either start or end the program.
        public static string  DisplayMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("-----------");
            Console.WriteLine("This program will give you a set amount of random numbers!");
            Console.Write("Do you wish to continue? (enter 'yes' or 'no') : ");

            return Console.ReadLine();
        }
    }
}
