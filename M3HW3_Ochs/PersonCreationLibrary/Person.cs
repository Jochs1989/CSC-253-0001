using System;
using System.Collections.Generic;
using System.Text;

namespace PersonCreationLibrary
{
    public class Person
    {
        //auto properties to assign user information.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // A default incase nothing is entereed
        public Person()
        {
            FirstName = "";
            LastName = "";
            Age = 0;
        }
        // Constructor so that we can assign information gained to proper properties.
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
