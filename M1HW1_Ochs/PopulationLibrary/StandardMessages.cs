using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationLibrary
{
    public class StandardMessages
    {
        // Method for user to see and use a menu.
        public static void DisplayMenu()
        {
            Console.WriteLine("\nPopulation Calculator!");
            Console.WriteLine("1. Starting number of organisms!");
            Console.WriteLine("2. Rate of Increase");
            Console.WriteLine("3. Number of days.");
            Console.WriteLine("4. Results.");
            Console.WriteLine("5. Exit");
            Console.Write("1/2/3/4/5 > ");
        }

        // Method for use in places that could be considered errors.
        public static void DisplayMenuError()
        {
            Console.WriteLine("\nNot a valid choice!");
            Console.WriteLine("");
        }
    }
}
