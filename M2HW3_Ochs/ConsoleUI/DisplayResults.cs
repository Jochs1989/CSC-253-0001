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
            //gets the users input and sends the input to the class method which returns the answer.
            Console.Write("Please type your sentence!");
            Console.WriteLine(">");
            string input = Console.ReadLine();
            //displays results after going to the class method to get the most fequent letter.
            Console.WriteLine($"\nThe most frquent Letter is : '{WordCounter.GetWordCount(input)}'\n");

        }
    }
}
