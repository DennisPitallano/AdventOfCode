// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


try
{
    // Read all lines from the file
    var moves = GetInput();

    // Calculate the number of houses
    Console.WriteLine(Calculate.Houses(moves));

    Console.WriteLine(Calculate.Houses(moves, 2));
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

return;




static string GetInput()
{
    const string filePath = "input.txt";
    var strings = File.ReadAllText(filePath);
    return strings;
}