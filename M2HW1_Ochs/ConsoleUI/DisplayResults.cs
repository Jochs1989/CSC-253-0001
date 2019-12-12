﻿using System;
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
            //Asks the user for input, which is sent to the word counter class method for calculation.
            Console.Write("Please type the sentence!");
            Console.WriteLine(">");
            string input = Console.ReadLine();

            //Displays a result after going to the class method for calculation.
            Console.WriteLine($"There were '{WordCounter.GetWordCount(input)}' words!");
        }
    }
}
