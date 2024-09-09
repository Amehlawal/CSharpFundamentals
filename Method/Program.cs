namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double x;
            double y;

            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine(result);

            double buy = CheckOut(2, 3, 4, 4, 5);
            Console.WriteLine( buy);


        }
        static double Multiply(double x, double y)
        {
            double z = x * y;

            return z;
        }
        static double CheckOut(params double[] z)
        {
           double total = 0;
            foreach (double x in z)
            {
                total += x;
            }

            return total;
        }
    }
}
