// See https://aka.ms/new-console-template for more information

using _2015.Day._6;

Console.WriteLine("Hello, World!");


Console.WriteLine(Calculate.Part1(GetInput()));
Console.WriteLine(Calculate.Part2(GetInput()));

return;

string[] GetInput()
{
    const string filePath = "input.txt";
    var strings = File.ReadAllLines(filePath);
    return strings;
}
