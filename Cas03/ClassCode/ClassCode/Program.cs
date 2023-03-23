// See https://aka.ms/new-console-template for more information

//Console.WriteLine("===For loop===");
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i.ToString() + "FOR");
//}
////for (; ; )
////{
////    Console.WriteLine("Hello");
////}

//for (; ; )
//{
//    Console.WriteLine("Enter input");
//    string input = Console.ReadLine().ToLower();

//    if (input == "x") break;

//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine("Breaking");
//        break;
//    }
//    if (i == 3) { Console.WriteLine("Skipping"); continue; }
//}

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine(counter + "While");
//    counter++;
//}

//while (true)
//{
//    Console.WriteLine("Enter impup");
//    string inpit = Console.ReadLine().ToLower();
//    if(inpit == "yes")
//    {
//        break;
//    }
//}

//int anotherCounter = 0;
//while(anotherCounter <= 10)
//{
//    if(anotherCounter == 3)
//    {
//        Console.WriteLine("Skipping in while");
//        anotherCounter++;
//        continue;
//    }
//    if(anotherCounter == 5)
//    {
//        Console.WriteLine("Breaking in while..");
//        break;
//    }
//    Console.WriteLine(anotherCounter);
//    anotherCounter++;
//}
//Console.WriteLine("DOHILE");
//int thirdCounter = 0;

//do
//{
//Console.WriteLine("RAUSE");
//thirdCounter++;
//}
//while (false);

//Console.WriteLine("Enter number");
//int inputNumber = Convert.ToInt32(Console.ReadLine());
//for(int i = 1; i <= inputNumber; i++)
//{
//    Console.WriteLine(i);

//    Console.WriteLine("Enter second number");
//    int secondNumber = Convert.ToInt32(Console.ReadLine());
//    for( int j = 1; secondNumber >= j; secondNumber--)
//    {
//        Console.WriteLine(secondNumber);
//        continue;
//    }

//}

//Console.WriteLine("Enter a number");
//bool success = int.TryParse(Console.ReadLine(), out int counter);
//if (success) { 
//        for (int i=1; i< counter; i++)
//    {
//        Console.WriteLine(i);
//    }
//    Console.WriteLine("Enter another input");
//    int anotherCounter = int.Parse(Console.ReadLine());
//    for (int j = 1; anotherCounter >= j; anotherCounter--)
//        //int j = 1; anotherCounter >= j; anotherCounter--
//    {
//        Console.WriteLine(anotherCounter);
//        if(anotherCounter < 0)
//        {
//            Console.WriteLine("Num lower than 0");
//            break;
//        }
//    };

//}


//Console.WriteLine("Enter first Number");
//int inputNum = Convert.ToInt32(Console.ReadLine());

//for (int i = 2; i <= inputNum; i += 2)
//{
//    Console.WriteLine(i + " even number");
//}

//Console.WriteLine("Enter second Number");
//int secondNum = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= secondNum; i += 2)
//{
//    Console.WriteLine(i + " odd number");
//}



Console.WriteLine("enter a number");
bool success = int.TryParse(Console.ReadLine(), out int inputNumber);
if (success)
{
    for (int i = 0; i<= inputNumber; i++)
    {
        if(i % 3 == 0 || i % 7 == 0){
            continue;
        }
        else if (i == 100)
        {
            Console.WriteLine("Error 100 numbers limit");
            break;
        }

            Console.WriteLine(i);
    }
}

// empty integer array with length 3;
int[] emptyIntegerArray = new int[3];

