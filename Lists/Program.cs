namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            String[] foods = new string[3];

            foods[0] = "pizza";
            foods[1] = "shawarma";
            foods[2] = "Meat Pie";

            foods = [..foods, "Sausage roll"];
            foreach (string food in foods)
            {
                Console.WriteLine($"I am a {food.ToUpper()}! please eat me");
            }

            // Lists

            List<string> fones = new List<string>();

            fones.Add("Iphone");
            fones.Add("Samsung");
            //Console.WriteLine(fones.Remove();

            foreach (string fone in fones)
            {
                Console.WriteLine(fone);
                Console.WriteLine(fone.Count());
            }
            Console.WriteLine(fones[^1]);

            var names = new List<string> { "Scott", "Ana", "Felipe" };

            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }

        }
    }
}
