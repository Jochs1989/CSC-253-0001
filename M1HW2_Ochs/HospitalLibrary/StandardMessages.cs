using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class StandardMessages
    {
        // Method for user to see and use a menu.
        public static void DisplayMenu()
        {
            Console.WriteLine("\nHospital Charges!");
            Console.WriteLine("1. Enter how many days you stayed!");
            Console.WriteLine("2. Enter Misc Charges!");
            Console.WriteLine("3. Results!");
            Console.WriteLine("4. Exit!");
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
