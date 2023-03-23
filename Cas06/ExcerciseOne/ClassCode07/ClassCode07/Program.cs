// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Dictionary works on key/value pair system this sys give us the option to get values from colections by some keys

Dictionary<string,string> firstDictionary = new Dictionary<string,string>();
firstDictionary.Add("song1", "Have a nice day");
firstDictionary.Add("song2", "Wind of change");

bool firstKeyExists = firstDictionary.ContainsKey("song2");
Console.WriteLine(firstKeyExists);