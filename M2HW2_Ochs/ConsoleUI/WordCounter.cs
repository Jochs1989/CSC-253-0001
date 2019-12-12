using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class WordCounter
    {
        public static decimal GetWordCount(string text)
        {
            //variables to store results in for loop and foreach.
            int wordCount = 0;
            int charCount = 0;
            //this stores each word from the users sentence.
            string[] charArray = text.Split(' ');
            //this counts amount of words in a users sentence.
            for (int index = 0; index < text.Length; index++)
            {
                wordCount = text.Trim().Split(' ').Count();
            }
            //this counts the amount of characters in a users sentence.
            foreach(string character in charArray)
            {
                charCount += character.Count();
            }
            //calculation to find the average number of letters in the users sentence.
            decimal average = charCount / wordCount;

            return average;
        }
    }
}
