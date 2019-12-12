using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class StandardMessages
    {
        public static string StartProgram()
        {
            Console.WriteLine("1. Create Worker!");
            Console.WriteLine("2. Create Supervisor!");
            Console.WriteLine("3. Exit!");
            Console.Write("Please enter 1/2/3 : > ");
            return Console.ReadLine();
        }

        public static void GetErrorMessage()
        {
            Console.WriteLine("Invalid input");
        }
    }
}
