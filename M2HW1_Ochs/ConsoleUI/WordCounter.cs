using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class WordCounter
    {
        public static int GetWordCount(string text)
        {
            //delims so that the string only has letters and a varibale to count the result.
            char[] delim = {' '};
            int wordCount = 0;
            //for loop that counts a word after every word in a sting
            for (int index = 0; index < text.Length; index++)
            {
                wordCount = text.Trim().Split(delim).Count();
            }

            return wordCount;
        }
    }
}
