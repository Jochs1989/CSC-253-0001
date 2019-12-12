using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class StandardMessages
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Create Car.");
            Console.WriteLine("2. Accelerate Car.");
            Console.WriteLine("3. Deccelerate Car.");
            Console.WriteLine("4. Exit");
            Console.Write("1/2/3/4 > ");
        }

        public static void DisplayMenuError()
        {
            Console.WriteLine("Not a valid choice!");
            Console.WriteLine("");
        }

        public static void DisplayCarSpeed(Car input)
        {
            Console.WriteLine($"The {input.Year} {input.Make} is going {input.Speed} mph.");
            Console.WriteLine("");
        }
    }
}
