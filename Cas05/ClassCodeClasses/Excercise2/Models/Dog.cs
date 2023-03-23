using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2.Models
{
    internal class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }
        public string Eat()
        {
            return $"The {Name} is now eating.Dont touch him he is a {Race} ";
        }
        public string Play()
        {
            return $"The {Name} is now playing";
        }
        public string ChaseTail()
        {
            return $"The {Name} is now chasing its {Color} tail";
        }
        public void Command() { 
        Console.WriteLine("Enter 1 for Eat 2 for Play 3 for ChaseTail");
        int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine(Eat());
                    break;
                case 2:
                    Console.WriteLine(Play());
                    break;
                case 3:
                    Console.WriteLine(ChaseTail());
                    break;
                default:
                    Console.WriteLine("Nigga");
                    return;

            }
        }

    }


}
