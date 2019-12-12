using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PersonCreationLibrary
{
    public class PersonFromFile
    {
        public static Person GetPerson()
        {
            //This is used to take the information in the file and assign it to the auto properties in the Person class.
            try
            {
                StreamReader inputFile;

                inputFile = File.OpenText("UserInformation.txt");
                // Variables that store the information in the file so that it can be assigned a person object later.
                string firstName = inputFile.ReadLine();
                string lastName = inputFile.ReadLine();
                int age = int.Parse(inputFile.ReadLine());

                inputFile.Close();
                // Object used to store the inforamtion from the file to the person class.
                Person myPerson = new Person(firstName, lastName, age);
                //returns current information in the object to the object in the Program class
                return myPerson;
            }

            //returns errors incase information in the file has errors
            catch
            {
                return new Person("File Read Error", "File Read Error", 0);
            }
        }
    }
}
