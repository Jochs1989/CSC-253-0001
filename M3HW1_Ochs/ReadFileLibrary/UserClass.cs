using System;
using System.Collections.Generic;
using System.Text;

namespace ReadFileLibrary
{
    public class UserClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public UserClass(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
