using System.Threading.Channels;

int x;
int y;

int result;
try
{
    Console.WriteLine("Enter in number 1: ");
    x = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter in number 2: ");
    y = Convert.ToInt32(Console.ReadLine());

    result = x / y;

    Console.WriteLine(result);
}
//catch(FormatException e)
//{
//    Console.WriteLine("Enter a number FOOL");
//}
//catch(DivideByZeroException e)
//{
//    Console.WriteLine("You cannot divide by 0 idiot");
//}
catch (Exception e)
{
    Console.WriteLine("something is wrong");
}
finally
{
    Console.WriteLine("Momman is calling");
}

double temperature = 20;

string message;

message = (temperature > 15) ? "It's warm outside" : "Its cold";

Console.WriteLine(message);
Console.WriteLine($"You are sweating cause {message}");

string[,] parkingLot = { { "benz, toyota"},
    {"Honda" },
    {"hyndai" }
                            };

foreach(string car in parkingLot)
{
    Console.WriteLine(car   );
}