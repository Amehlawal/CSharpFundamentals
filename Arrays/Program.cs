string[] cars = { "BMW", "Mustang", "Converter" };

Console.WriteLine(cars[0]);

for(int i = 0;i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

foreach(string car in cars)
{
    Console.WriteLine(car);
}