using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class DisplayResults
    {
        public static void GetSentence()
        {
            Console.Write("Please type the sentence you would like to count!");
            Console.WriteLine(">");
            string input = Console.ReadLine();
            Console.WriteLine($"\nYou have an average of '{WordSeparator.GetSeperation(input)}' per word!\n");
        }
    }
}
