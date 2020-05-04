using System;
using System.Collections.Generic;
using System.Text;

namespace Mod1_Lab3
{
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
