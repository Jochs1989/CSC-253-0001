using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class WordCounter
    {
        public static char GetWordCount(string text)
        {
            //created an array to store each character.
            //the size is 255 to cover all characters possible.
            int[] charCount = new int[255];
            //variables that are used in the second for loop to find the most frequent character.
            int maxCount = -1;
            char character = ' ';
            //the for loop runs though each char and counts them incrementing... 
            //the array for a specific character when a character appears more than once.
            for (int index = 0; index < text.Length; index++)
            {
                charCount[text[index]]++;
            }
            //this for loop goes to the if statement only when the array increment...
            //is lower than highest increment in the array.
            for (int index = 0; index < text.Length; index++)
            {
                if (maxCount < charCount[text[index]])
                {
                    maxCount = charCount[text[index]];
                    character = text[index];
                }
            }
            return character;
        }
    }
}
