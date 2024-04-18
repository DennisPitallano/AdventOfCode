// See https://aka.ms/new-console-template for more information

string filePath = "input.txt";

// Read all lines from the file
var presents = GetInput(filePath);

// Calculate the total amount of wrapping paper and ribbon needed
Console.WriteLine($"The total amount of wrapping paper needed is: {Calculate.WrappingPaper(presents)}");

// Calculate the total amount of ribbon needed
Console.WriteLine($"The total amount of ribbon needed is: {Calculate.Ribbon(presents)}");


return;

// Read all lines from the file
string[] GetInput(string s)
{
    var strings = File.ReadAllLines(s);
    return strings;
}

