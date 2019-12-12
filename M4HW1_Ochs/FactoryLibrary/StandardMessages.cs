using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryLibrary
{
    public class StandardMessages
    {
        public static string StartProgram()
        {
            Console.WriteLine("Create a worker? Enter 'yes' or 'no': > ");
            return Console.ReadLine();
        }

        public static void GetErrorMessage()
        {
            Console.WriteLine("Invalid input");
        }
    }
}
