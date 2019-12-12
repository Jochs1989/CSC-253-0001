using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class WordSeparator
    {
        public static int GetSeperation(string text)
        {
            int wordCount = 0;
            string newString = null;
            char[] input2 = text.Trim().ToCharArray();

            for (int index = 0; index < input2.Length; index++)
            {
                if (char.IsUpper(input2[index]))
                {
                    newString = text.Insert(input2[index], " ");
                }
                Console.WriteLine(newString);
            }
            Console.ReadLine();
            return wordCount;
        }
    }
}
