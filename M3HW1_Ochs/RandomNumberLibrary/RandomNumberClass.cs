using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RandomNumberLibrary
{
    public class RandomNumberClass
    {
        public static void CreateFile(string userInput)
        {
            int number;
            // This will make sure that the user entered a proper integer
            if (int.TryParse(userInput, out number))
            {
                //Now if the user enters a proper integer it will use that integer and create a file.
                try
                {
                    StreamWriter outputFile;

                    outputFile = File.CreateText("RandomNumber.txt");

                    Random rand = new Random();
                    // The for loop will allow the program to write how ever many random numbers the user identified the file.
                    for (int index = 0; index < number; index++)
                    {
                        outputFile.WriteLine(rand.Next(1, 100));
                    }

                    outputFile.Close();
                }
                // This is used in case the file information has an error.
                catch
                {
                    Console.WriteLine("File Read Error");
                }

            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }
    }
}
