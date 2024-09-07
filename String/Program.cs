// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string fullname = "Lawal";

string phoneNumber = "123-456-789";

phoneNumber = phoneNumber.Replace("-", "");

Console.WriteLine(phoneNumber);

string userName = fullname.Insert(0, "@");

string shortLawal = fullname.Substring(0, 2);

Console.WriteLine(shortLawal);

Console.WriteLine(fullname.Length);

Console.WriteLine(userName);