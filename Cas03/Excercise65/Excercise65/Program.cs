// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] newArr = new int[5];
int sum = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter Number to array");
    newArr[i] = Convert.ToInt32(Console.ReadLine());
    sum += newArr[i];
    
    
};
Console.WriteLine(newArr);
Console.WriteLine($"The sum of the array is {sum}");
