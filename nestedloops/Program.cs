// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("How many rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How many columns ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("what symbol ");
string symbol = Console.ReadLine();


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}