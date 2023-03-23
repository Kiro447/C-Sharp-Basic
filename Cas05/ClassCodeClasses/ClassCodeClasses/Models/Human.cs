using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeClasses.Models
{
    public class Human
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string GetPersonStats()
        {
            return $"Hello this is {FirstName} {LastName} and he is {Age}";
        }
    }

}


