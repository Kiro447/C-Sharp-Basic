// See https://aka.ms/new-console-template for more information
using Excercise2.Models;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter name");
string name = Console.ReadLine();
Console.WriteLine("Enter race");
string race = Console.ReadLine();
Console.WriteLine("Enter Color");
string color = Console.ReadLine();
Dog sarko = new Dog(name,race,color);
sarko.Command();

void NumberStats(double num)
{
    string positivity;
    string evenodd;
    string doubleInt;
    if (num < 0)
    { positivity = "negative";  }
    else
    {
        positivity = "positive";
    } if( num % 2 == 0)
    {
        evenodd = "even";
    }
    else
    {
        evenodd = "odd";
    }
    if(num % 1 == 0)
    {
        doubleInt = "int";
    }
    else { doubleInt = "double"; }

    string specs = $"The {num} has theese values: {positivity}, {evenodd}, {doubleInt}";
    Console.WriteLine(specs);
}
Console.WriteLine("Enter number");
 double king = Convert.ToDouble(Console.ReadLine());
NumberStats(king);

//Console.WriteLine("Enter number");
//double steve = Convert.ToDouble((Console.ReadLine()));
//NumberStats(steve);

