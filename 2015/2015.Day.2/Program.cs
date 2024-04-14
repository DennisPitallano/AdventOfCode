// See https://aka.ms/new-console-template for more information

string filePath = "input.txt";

try
{
    // Read all lines from the file
    var presents = GetInput(filePath);

    Console.WriteLine($"The total amount of wrapping paper needed is: {Calculate.WrappingPaper(presents)}");

    Console.WriteLine($"The total amount of ribbon needed is: {Calculate.Ribbon(presents)}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

return;


string[] GetInput(string s)
{
    var strings = File.ReadAllLines(s);
    return strings;
}

