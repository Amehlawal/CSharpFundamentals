// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! what is the temperature outside");

double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 20 && temp <= 25)
{
    Console.WriteLine("It is warm outside");
}
else if (temp<= -50 || temp >= 50)
{
    Console.WriteLine("Don not go outside");
}


Console.WriteLine("Enter your name: ");

string name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("enter your name");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name);

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);

}
Console.WriteLine("Happy new Year");
