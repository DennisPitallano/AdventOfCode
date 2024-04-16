// See https://aka.ms/new-console-template for more information

using _2015.Day._5;

Console.WriteLine("Hello, World!");

Console.WriteLine(Calculate.CountNice(GetInput()));
Console.WriteLine(Calculate.CountNice2(GetInput()));

return;

static string GetInput()
{
    const string filePath = "input.txt";
    var strings = File.ReadAllText(filePath);
    return strings;
}