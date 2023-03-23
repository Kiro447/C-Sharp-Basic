// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int [] emptyIntegerArray = new int [3];
emptyIntegerArray [0] = 1;
emptyIntegerArray [1] = 7;
emptyIntegerArray [2] = 33;
Console.WriteLine(emptyIntegerArray[1]);
//emptyIntegerArray[3] = 55; // out of range 
for(int i = 0; i< emptyIntegerArray.Length; i++)
{
    Console.WriteLine(emptyIntegerArray [i]);
}


string [] emptyStringArray = {"Damjan","lukaku","Zarkovo - Cerak"};
Console.Write ($"StringArray length {emptyStringArray.Length} ");


for(int i = 0; i< emptyStringArray.Length; i++)
{
    Console.WriteLine (emptyStringArray [i]);
}


double[] doubleArray = { 2, 33.3, 44.6};
double[] doubleArraySecond = { 2, 33.3, 44.6, 7, 234 };
//doubleArraySecond[4] = 333.2;
Console.WriteLine(doubleArraySecond[4]);

//RESIZE

Array.Resize(ref doubleArray, 7);
//Console.WriteLine(doubleArray[7]);

//INDEX OF
int indexFound = Array.IndexOf (doubleArray, 44.6);
Console.Write("Indef of  44.6 : ");
Console.WriteLine (indexFound);

//REVERSE
Console.WriteLine (doubleArraySecond[0]);
Array.Reverse (doubleArraySecond);
Console.WriteLine (doubleArraySecond[0]);

for (int i = 1; i < doubleArraySecond.Length; i++)
{
    Console.WriteLine(doubleArraySecond[i]);
}


// for each

foreach (double i in doubleArraySecond)
{
    Console.WriteLine (i + "KING");
}

string[] names = { "Lukaku", "Dana", "Stevo", "KING" };
//Array.Reverse(names);
foreach(string name in names)
{
    Console.WriteLine(name);
    if(name == "Stevo")
    {
        break;
    }
}

