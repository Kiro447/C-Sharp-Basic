using ClassCode.Classes;
// Default constructor called
Animal animal = new Animal();
//Console.WriteLine(animal.Id); // Ne dava poso e protected 
//Console.WriteLine(animal._privateProperty); Private property
Dog jacky = new Dog();
Dog lea = new Dog("Lea","Golden","Retriver"); // 2 konstruktori vika Po6o BASE constructor vikame u DOG
Dog lina = new Dog("Lina","Gray","Husky");
Console.WriteLine(lina.Name);
//Console.WriteLine(lina._privateProperty); PRIVATE PROPERTY
//Console.WriteLine(lina.Id); // protected property
lina.PrintId(); // ID E protected i moze niz klasite i metodite da se koristni no ne i vo Program.cs 
// inherited method from Animal
lea.PrintBasicInfo();
lea.Eat("Sarma"); // Ja zima od Dog metodata so ja override

lina.Eat(); // Ja prepoznava formata od - dog klasnicnata Eat bezparametar 

Cat maco = new Cat()
{
    Name = "Maco",
    Color = "Grey",
    IsLazy = true,
}; // Parametarless

maco.PrintBasicInfo();
maco.Eat("fish");
