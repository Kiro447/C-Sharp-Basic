using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Classes
{
    public class Animal
    {
        //Protected members can be accessed in the class or in the inheritance
        protected int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        // private member can only be accessed in the class it is defined
        private string _privateProperty { get; set; }
        // If we have more constructors, we should write also the default c-tor if we need it (-)-(-)
        public Animal()
        {
            Id = new Random().Next(1, 999999999);
            Console.WriteLine("Default constructor was called");
        }

        public Animal(string name , string color)
        {
            Id = new Random().Next(1,999999999);
            Name = name;
            Color = color;
            Console.WriteLine("Constructor with parameters was Called:)");
        }
        public void PrintBasicInfo()
        {
            Console.WriteLine($"ID: {Id} , Name: {Name} , Color: {Color}");
        }
        // Virtual ke se pravi override u drugite classi
        public virtual void Eat(string food)
        {
            Console.WriteLine($"The animal {Name} eats {food}");
        }
    }

}
