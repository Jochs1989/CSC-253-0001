using System;
using System.Collections.Generic;
using System.Text;

namespace ReadFileLibrary
{
    public class StandardMessages
    {
        public string PromptInfo
        {
            get
            {
                return "This program will load data from a file and create a class object then display that objects info to user";
            }

        }

        public static string DisplayClass(UserClass myClass)
        {
            return $"Name is {myClass.FirstName} {myClass.LastName} and is {myClass.Age} years old.";
        }
    }
}
