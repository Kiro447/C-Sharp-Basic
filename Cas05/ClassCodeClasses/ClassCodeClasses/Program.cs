using ClassCodeClasses.Models;


//constructor -> new
Person personPaul = new Person();


//Console.WriteLine(personPaul._ssn);  samo u klasa se koristi Private Property :@
//SeT --- ako u class e samo  get - propertyto e readOnly
Person secondPerson = new Person("King","Luka",23,5555555);

Console.WriteLine(personPaul.FirstName + personPaul.LastName + personPaul.Age);
Console.WriteLine(secondPerson.GetDescription());


// constructor with parameters


Person bob = new Person("Bob","Sokratovski",23);
Console.WriteLine(bob.GetDescription());
Console.WriteLine($"Description for Bob: {bob.GetDescription()}");


//Default constroctuor
Product car = new Product();
car.Name = "BMW";
car.Price = 4555.6;
car.Code = 123;


//Mew product

Product pizza = new Product()
{
    Code = 354,
    Name = "Alpolia",
    Price = 255
};
pizza.Buy(256);

//Console.WriteLine("Enter object");
//string className = Console.ReadLine();

Console.WriteLine("Do you want to add new Person. Y for add N for no");
string question = Console.ReadLine();

if ( question == "y") {
    Console.WriteLine("Enter age");
int ageInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter name");
string nameInput = Console.ReadLine();
    Console.WriteLine("Enter lastName");
string lastName = Console.ReadLine();
    Human className = new Human(nameInput, lastName, ageInput);
    Console.WriteLine(className.GetPersonStats());
}
else
{
    Console.WriteLine("ByeBye");
}
