using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCode.Classes
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog()
        {
            Console.WriteLine("Dogs parameterless constructor");
        }
        public Dog(string name, string color, string breed) : base(name, color) //Base constructor od parent classata
        {
            //Name = name; // Gi nasleduva od Animal -- Ama mora da go dodades base
            //Breed = breed; // Nemora da gi pisuvas ako gi nasleduvas
            Color = color;
            Console.WriteLine("Dog's constructow with parameters was called!");
        }
        public void Eat() // Razlicna metoda od metodata vo Animal  poso nema input Parametar
        {
            Console.WriteLine("The dogs love to eat");
        }
        public override void Eat (string food) // OVERRIDE
        {
            //base.Eat(food); // Mora da ima base.Eat(Food) - da ja vikne ako nema override napisano
            Console.WriteLine($"The dog eats {food}");
        }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        public void PrintName()
        {
            Console.WriteLine($"{Name}"); // Public property Animal
        }
        public void PrintId ()
        {
            Console.WriteLine($"{Id}"); // protected - nasledeno od parentot
        }
        //public void PrintPrivateProperty()
        //{
        //    Console.WriteLine($"{_privateProperty}"); // Protected moze // Private nemoжi
        //}
    }
}
