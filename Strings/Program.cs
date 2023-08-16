//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

//Console.WriteLine("Hello, Strings!");

using System.Diagnostics.Tracing;

string drSuess = "I would not, could not, in a box. I would not, could not with a fox.\r\nI will not eat them in a house. I will not eat them with a mouse.";
//divide the string at each space
string[] space = drSuess.Split(' ');
Console.WriteLine(string.Join(",", space));
//divide the string at each sentence
string[] sentence = drSuess.Split('.');
Console.WriteLine(string.Join(",", sentence));
