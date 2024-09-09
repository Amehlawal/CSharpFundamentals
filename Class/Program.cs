namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Car car1 = new Car("Lambo", 12);
            Car car = new Car();
            Console.WriteLine(car.wheels);
            car.go();
        }

        
    }
    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
        
  
   
    }
    class Car : Vehicle
    {
        public int wheels = 4;

    }

}
