using System;

namespace Mod1_Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Using dot notation
            var car1 = new Car();
            car1.Color = "Black";
            car1.Year = 2000;
            car1.Mileage = 1590;

            var car2 = new Car("Red", 2008);

            var carCount = Car.CountCars();
            Console.WriteLine($"There are {carCount} cars on inventory");
        }
    }
}
