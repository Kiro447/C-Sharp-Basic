// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int DayOfTheWeek = 4;

switch (DayOfTheWeek)
{
    case 1:
        Console.WriteLine("Today is monday");
        break;
    case 2:
        Console.WriteLine("Today is tuesday");
        break;
    default:
        Console.WriteLine("Its other than monady and tuesday");
        break;
}

double firstNumber;
double secondNumber;
double result;
char operation;

Console.WriteLine("Enter the first number");
firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the first number");
secondNumber = Convert.ToDouble(Console.ReadLine());

operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine(result);
        break;
    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine(result);
        break;
    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("Invadli operator");
        break;
}


Console.WriteLine("Enter number");
int inputNum = Convert.ToInt32(Console.ReadLine());

switch (inputNum)
{
    case 1:
        Console.WriteLine("You got a new car");
        break;
    case 2:
        Console.WriteLine("You got a new plane");
        break;
    case 3:
        Console.WriteLine("You got a new bike");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}
