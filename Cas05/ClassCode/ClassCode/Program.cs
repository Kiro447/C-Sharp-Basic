// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string precantegeExamp = String.Format("This is {0:P}", 0.5);
Console.WriteLine(precantegeExamp);


//Number
string numberExample = String.Format("This is {0:N}", 125000);
Console.WriteLine(numberExample);

// Two Decima spaces
string decimalSpaces = String.Format("Two dec spaces {0:0.00}", 125.265);
Console.WriteLine(decimalSpaces);

// Custom Format =) () (=
string customExapmle = String.Format("{0:0##/###-###}",070447419);
Console.WriteLine(customExapmle);
// Lower / Upper
string s = "     Sometimes you win, sometimes you lose     ";
Console.WriteLine(s);
string upperExamp = s.ToUpper();
Console.WriteLine(upperExamp);
string lowerExamp = upperExamp.ToLower();
Console.WriteLine(lowerExamp);

// Spacing remover 
string trimmer = s.Trim();
Console.WriteLine(trimmer);

// length 

int lengthExample = s.Length;
Console.WriteLine(lengthExample);

//Starts with
string s1 = "Enjoy your day";
bool king = s1.StartsWith("E");
Console.WriteLine(king);
// EndWith - same
//IndexOf

Console.WriteLine("OVOJ E INDEXOT "+s1.IndexOf("y",2));
int indexOfExample = s1.IndexOf("a");
Console.WriteLine(indexOfExample);

//SubString (+)(+)

string substringExample = s1.Substring(2, 2);
Console.WriteLine(substringExample);


// Split

string splitExample = "C#::is::fun:programming:language";
string[] split = splitExample.Split(":");
foreach (string sing in split)
{
    Console.WriteLine(sing);
}


string splitExample2 = "C#::is::fun:programming:language";
string[] split2 = splitExample2.Split("m");
foreach (string sing in split2)
{
    Console.WriteLine(sing);
}


// To Char ARRay
string charArrayExample = "Language";
char [] splitChars = charArrayExample.ToCharArray();
foreach(char c in splitChars)
{
    Console.WriteLine(c);
}

//

string testSample(string example, int n , int m)
{
    //int king = example.Length;
    //Console.WriteLine(king);
    if (example.Length > n && example.Length == m && m > n)
    {
        string split = example.Substring(n, m);
        Console.WriteLine(split);
        return split;
    }
    else {
        return example;
    }

}
//string newKing = "Jas sum najsilen";
//string splitTest = newKing.Substring(3, newKing.Length - 1);
//Console.WriteLine(splitTest);
string newKing = "Jas sum najsilen";
string testerKing = testSample(newKing, 0, 7);
Console.WriteLine(testerKing);


// default date 
DateTime dt = new DateTime();
Console.WriteLine(dt);

// custom date
DateTime dt2 = new DateTime(2023,03,16);
Console.WriteLine(dt2);

//custom date and time 
DateTime dt3 = new DateTime(2023, 03, 16 , 19 ,11, 10);
Console.WriteLine(dt3);

// Now 
DateTime dt4 = DateTime.Now;
Console.WriteLine(dt4);


// AddDays

DateTime dt5 = dt4.AddDays(5);
dt5 = dt4.AddDays(-5);
Console.WriteLine(dt5);
Console.WriteLine(dt5 - dt4);

// AddMonths
DateTime currentDateTime = DateTime.Now;
DateTime dt7 = currentDateTime.AddMonths(5);
Console.WriteLine(dt7);

//Add years .. add hours


//Date Time Properties

int month = currentDateTime.Month;
Console.WriteLine(month);
int day = currentDateTime.Day;
Console.WriteLine(day);

// Convert String to datetime
string dayTimeConvert = "2023-01-01";
DateTime convertDateTime = Convert.ToDateTime(dayTimeConvert);
Console.WriteLine(convertDateTime);
Console.WriteLine(dayTimeConvert);


//String Format 
DateTime newKing2 = DateTime.Now;
Console.WriteLine(newKing2);
string dateFormat1 = string.Format("Today is: {0:dd/MM/yyyy}, {0:dddd}", newKing2);
Console.WriteLine(dateFormat1);

string dateFormat2 = string.Format("Today is: {0:dd-MM-yyyy}, {0:t}",newKing2);
Console.WriteLine(dateFormat2);

