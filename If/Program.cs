// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter your age ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 10)
{
    Console.WriteLine("You loser");
}
else if (age > 20)
{
    Console.WriteLine("You are a winner");
}
else
{
    Console.WriteLine("get out of my face");
}

Console.ReadKey();