// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! What is today: ");

string day = Console.ReadLine();



switch(day)
{
    case "Monday":
        Console.WriteLine("It is monday");
        break;
    case "Tuesday":
        Console.WriteLine("It is Tuesday");
        break;
    case "Wednesday":
        Console.WriteLine("It is wednesday");
        break;
    case "Friday":
        Console.WriteLine("It is friday");
        break;
    default:
        Console.WriteLine("holla");
        break;
}