using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class FirstLetterToCap
    {
        // This is used to help for validation of whether the users input matches the Class or Race enums.
        public static string MakeFirstLetterCap(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {
                return input.First().ToString().ToUpper() + input.Substring(1);
            }
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}
