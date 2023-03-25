using System.Collections;

static void iterateColleciton(IEnumerable colleciton) // Nasleduva dictionary od IEnumberable
{
    foreach (var item in colleciton) {
        Console.WriteLine(item);
    }

}


// Dictionary works on key/value pair system this sys give us the option to get values from colections by some keys

Dictionary<string,string> firstDictionary = new Dictionary<string,string>();
firstDictionary.Add("song1", "Have a nice day");
firstDictionary.Add("song2", "Wind of change");

bool firstKeyExists = firstDictionary.ContainsKey("song2");
bool secondKeyExists = firstDictionary.ContainsKey("song3");
Console.WriteLine(firstKeyExists);
Console.WriteLine(secondKeyExists);

Console.WriteLine("num of elements" + firstDictionary.Count);
Console.WriteLine(firstDictionary["song1"]);
//Console.WriteLine(firstDictionary["song3"]);


Dictionary<int,string> products = new Dictionary<int,string>()
{
    { 12345, "Bread"},
    { 12421, "Milk"},
    { 32345, "salt"}
};

iterateColleciton(products);

Console.WriteLine(products[12345]);
Console.WriteLine(products[32345]);
bool success = products.TryGetValue(666666, out string errorMessage);
Console.WriteLine(errorMessage);
Console.WriteLine(success);


// LIST - type and has no fixed length
List<int> integerList = new List<int>();
integerList.Add(1111111);
integerList.Add(2222222);
integerList.Add(3333333);
integerList.Add(4444444);
//integerList.Remove(1111111); // Removes from value


Console.WriteLine(integerList[1]);

Console.WriteLine(integerList[2]);
//integerList.RemoveAt(integerList.Count - 1); // Spored index
for (int i = 0; i < integerList.Count; i++)
{
    Console.WriteLine(integerList[i]);
}



// ARRAY LIST
ArrayList arrayList = new ArrayList() { "Hello", 2};
arrayList.Add(true);
arrayList.Add(new string [] {"Hi","Senpo"}); 
Console.WriteLine(arrayList[3]);
Console.WriteLine(arrayList.Count);
arrayList.Remove(2);
Console.WriteLine(arrayList.Count);
Console.WriteLine(((string[])arrayList[2])[0]); // 2 - Index 2 array list - 0 element od nizata
iterateColleciton(arrayList);


// QUEUE - First in first out

Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(5); // Add item to the Queue
intQueue.Enqueue(7); // Add item to the Queue
intQueue.Enqueue(9); // Add item to the Queue
Console.WriteLine(intQueue);
iterateColleciton(intQueue);
int firstNumber = intQueue.Peek(); // get the value of the first element
Console.WriteLine(firstNumber);
Console.WriteLine(intQueue.Count);
int firstMemberOut = intQueue.Dequeue(); // get and (Removes ) first element of the queue
Console.WriteLine(firstMemberOut);
//Console.WriteLine(intQueue.Count);

firstNumber = intQueue.Peek();
Console.WriteLine(firstNumber);


// STACK - Last in First Out

Stack<string> ourStack = new Stack<string>();
ourStack.Push("Hello");
ourStack.Push("Hi");
ourStack.Push("Goodbye");
iterateColleciton(ourStack);
string lastMember = ourStack.Peek();
Console.WriteLine(lastMember);
Console.WriteLine(ourStack.Count);

string lastMemberOut = ourStack.Pop(); // get the last element out of the stack
Console.WriteLine(lastMemberOut);
Console.WriteLine(ourStack.Count);


lastMember = ourStack.Peek();
Console.WriteLine(lastMember);



Dictionary<string, int> ourDictionary = new Dictionary<string, int>()
{
    { "luka", 1078},
    { "stefan", 1079},
    { "marko", 1077},
    { "king", 1076}
};
Console.WriteLine("Enter a name and check the number");
string user = Console.ReadLine();

static void checkDictionary(Dictionary <string,int> dict , string input)
{

    if(!dict.TryGetValue(input, out int result))
    {
        Console.WriteLine("it does not exist");
        return;
    } 
    Console.WriteLine(dict[input]);
};

checkDictionary(ourDictionary , user);

