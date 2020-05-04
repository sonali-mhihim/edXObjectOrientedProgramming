using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var car1 = new Car();

            // Using dot notation
            car1.Color = "Black";
            car1.Year = 2000;
            car1.Mileage = 1590;

            // Output to console window
            Console.WriteLine($"This car is painted {car1.Color}, was built in {car1.Year}, and has {car1.Mileage} miles on it");
        }
    }

    public class Car
    {
        // Properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }
}
