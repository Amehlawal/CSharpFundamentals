﻿namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(age.GetType());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hello I am " + age + " years old");
        }
    }
}
