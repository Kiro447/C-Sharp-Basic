using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeClasses.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private int _ssn { get; set; }
        public Person()
        {
            _ssn = GenerateSSN();
        }

        public Person(string firstName, string lastName, int age, int ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = GenerateSSN();
        }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            _ssn = GenerateSSN();
        }
        public string GetDescription()
        {
            return $"{FirstName} {LastName}, has {Age}, with SSN: ${_ssn} ";
        }
        private int GenerateSSN()
        {
            return new Random().Next(100000, 9999999);
        }


    }
}
