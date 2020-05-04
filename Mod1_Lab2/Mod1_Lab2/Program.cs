using System;

namespace Mod1_Lab2
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

        public class Car
        {
            // create static variable and assign intial value as zeo.
            private static int instances = 0;

            // Properties
            public string Color { get; set; }
            public int Year { get; set; }
            public int Mileage { get; set; }

            public Car()
            {
                // Every time the constructor runs, increment "instances"
                instances++;
            }

            public static int CountCars()
            {
                return instances;
            }

            /// <summary> 
            /// This constructor instantiates a Car() object while only having the car's color and year information available 
            /// </summary>
            /// <param name="color"></param>
            /// <param name="year"></param>
            public Car(string color, int year)
            {
                this.Color = color;
                this.Year = year;

                // Every time the constructor runs, increment "instances"
                instances++;
            }

            /// <summary>
            /// This constructor instantiates a Car() object while only having the car's year and mileage information available.
            /// </summary>
            /// <param name="year"></param>
            /// <param name="mileage"></param>
            public Car(int year, int mileage)
            {
                this.Year = year;
                this.Mileage = mileage;

                // Every time the constructor runs, increment "instances"
                instances++;
            }
        }
    }
}
