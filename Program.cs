// EXERCISE 8 INSTRUCTIONS

// Define a Dictionary that contains information about several members of your family. Use the following example as a template.

// Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

// myFamily.Add("sister", new Dictionary<string, string>(){ 
//     {"name", "Krista"},
//     {"age", "42"}
// });
// Next, iterate over each item in myFamily and produce the following output.

// Krista is my sister and is 42 years old


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

// OUTPUT FROM TERMINAL:
// Diane is my mom and is 65 years old
// Clyde is my dad and is 67 years old
// Jarod is my brother and is 37 years old
// Christine is my wife and is 26 years old