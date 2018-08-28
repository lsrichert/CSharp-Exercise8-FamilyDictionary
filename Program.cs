using System;
using System.Collections.Generic;

namespace exercise8FamilyDictionary
{
    class Program
    {
      
        static void Main(string[] args)
        {
              Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

myFamily.Add("mom", new Dictionary<string, string>(){ 
    {"name", "Diane"},
    {"age", "65"}    
});
myFamily.Add("dad", new Dictionary<string, string>(){
    {"name", "Clyde"},
    {"age", "67"}
});
myFamily.Add("brother", new Dictionary<string, string>(){
    {"name", "Jarod"},
    {"age", "37"}
});
myFamily.Add("wife", new Dictionary<string, string>(){
    {"name", "Christine"},
    {"age", "26"}
});

foreach (var familyMember in myFamily)
{
Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
        }
    }
}
}

