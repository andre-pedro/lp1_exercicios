using System;

namespace LP1Exercises
{
    public enum FuelType { Gasoline, Diesel, LPG, Electric };

    public class Car
    {
        public float Speed { get; set; }
        public float Weight { get; set; }
        public FuelType Fuel { get; set; }
        public static float MaxSpeed { get; set; }

        public Car(float weight, float maxSpeed, FuelType fuel)
        {
            Fuel = fuel;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Speed = 0;
        }

        public float Accelerate(float x)
        {
            Console.WriteLine($"\tAccelerating {x}");

            Speed += x;

            if (Speed > MaxSpeed)
            {
                Console.WriteLine($"\t\tHitted Max Speed ({MaxSpeed}), accelerated {x - (Speed - MaxSpeed)}");
                Speed = MaxSpeed;
            }
            return Speed;
        }

        public float Break(float x)
        {
            Console.WriteLine($"\tBreaking {x}");

            Speed -= x;

            if (Speed < 0)
            {
                Console.WriteLine($"\t\tHitted Full Stop (0), breaked {Speed + x}");
                Speed = 0;
            }
            return Speed;
        }
    }
}