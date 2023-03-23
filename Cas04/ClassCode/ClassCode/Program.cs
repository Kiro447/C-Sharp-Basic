// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// returnType MethodName()
//body
//Method that has no input parameters :( =()

void Afirmation()
{
    Console.WriteLine("No matter how hard it gets, you should never give up");
}

//Call the method :@
Afirmation();

// Method with no return type, with input parameters

void PermitForDrink(int age)
{
    if (age < 18)
    {
        Console.WriteLine("You cant dring");
    }
    else Console.WriteLine("Dring fast");
}

//int newAge = 22;
//for (int i = 0; i < 3; i++)
//{
//    PermitForDrink(Convert.ToInt32(Console.ReadLine()));
//}

//Method with return type ;

string WeekendMind()
{
    string result = "The weeknd is best spent with frenC";
    return result;
}
string res = WeekendMind();
Console.WriteLine(WeekendMind());
Console.WriteLine(res);
string DayOfTheWeek(int day)
{
    string result;
    switch (day)
    {
        case 1: result = "Monday"; break;
        case 2: result = "Tuesday"; break;
        case 3: result = "Wednesday"; break;
        case 4: result = "Thursday"; break;
        case 5: result = "Friday"; break;
        case 6: result = "Saturday"; break;
        case 7: result = "Sunday"; break;
        default: result = "Invalid input. From 1 to  7 nigga"; break;
    }
    return result;
}

//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(DayOfTheWeek(i));
//}
string EnteredDay = DayOfTheWeek(10);
Console.WriteLine(EnteredDay);

string Introduction(string Name, int InputDay)
{
    string ResultDayOfTheWeek = DayOfTheWeek(InputDay);
    string result = $"This is {Name}, and today is {ResultDayOfTheWeek}";
    return result;
}
string newKing = Introduction("Kiril", 6);
Console.WriteLine(newKing);


int Sum(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
int Subtract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

void MainMethod(char newOperator)
{
    Console.WriteLine("Enter first number");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int result;
    switch (newOperator)
    {
        case '-':
            Console.WriteLine($" {Subtract(firstNumber, secondNumber)}");
            break;
        case '+':
            Console.WriteLine($"{Sum(firstNumber, secondNumber)}");
            break;
        default: Console.WriteLine("Invalid input"); break;

    }

}
Console.WriteLine("For sum enter + for else write - ");

char newOperator = Convert.ToChar(Console.ReadLine());
MainMethod(newOperator);


string name = "Dana";
string company = "Seavus";
string interPolation = $"My name is {name} and i live in {company}";

//Format string
//arguments

string formatExample = String.Format("Hello my name is {0} and i work in {1}",name,company);
Console.WriteLine(formatExample);
//string phoneNumber = string.Format("{0:0##-###-###}", 078223456);
//Console.WriteLine(phoneNumber);
//string percent = string.Format("This is {0:P}", 0.04);
//Console.WriteLine(percent);

//string number = string.Format("This is {0:N}", 125000);
//Console.WriteLine(number);

//string amount = string.Format("{0:C}", 124);
//Console.WriteLine(amount);

// escaping
string escaping = "This is \"string\" in C#";
Console.WriteLine(escaping);
string escapingExampleTwo = "This \\n means new line \n";
Console.WriteLine(escapingExampleTwo);

// @ Verbatim text
string VerbatimExample = @"This is ""string"" in c#";
Console.WriteLine(VerbatimExample);


