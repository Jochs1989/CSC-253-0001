using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PersonCreationLibrary
{
    public class PersonToFile
    {
        // Allows the user to enter their information and store it in 
        public static void CreatePerson()
        {
            //This object will store the users infomation for later use.
            Person newPerson = new Person();
            Console.Write("What is your first name? > ");
            newPerson.FirstName = Console.ReadLine();

            Console.Write("What is your last name? > ");
            newPerson.LastName = Console.ReadLine();

            Console.Write("What is your Age? > ");
            newPerson.Age = int.Parse(Console.ReadLine());
            
            //Here we use the previous entered information and write it to a file.
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText("UserInformation.txt");
                // These use the Person class to write the information to a file.
                outputFile.WriteLine(newPerson.FirstName);
                outputFile.WriteLine(newPerson.LastName);
                outputFile.WriteLine(newPerson.Age);

                outputFile.Close();
            }
            // This is used in case the file information has an error.
            catch
            {
                Console.WriteLine("File Read Error");
            }
        }
    }
}
