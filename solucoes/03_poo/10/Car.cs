using System;

namespace LP1Exercises
{
    public enum FuelType { Gasoline, Diesel, LPG, Electric };

    public class Car
    {
        private FuelType _Fuel;
        private float _Weight;
        private float _Speed;
        public static float _MaxSpeed;

        public float Speed
        {
            get { return _Speed; }
            set { }
        }

        public float Weight
        {
            get { return _Weight; }
            set { }
        }

        public FuelType Fuel
        {
            get { return _Fuel; }
            set { }
        }

        public static float MaxSpeed
        {
            get { return _MaxSpeed; }
            set { _MaxSpeed = MaxSpeed; }
        }

        public Car(float weight, float maxSpeed, FuelType fuel)
        {
            _Fuel = fuel;
            _Weight = weight;
            _MaxSpeed = maxSpeed;
            _Speed = 0;
        }

        public float Accelerate(float x)
        {
            Console.WriteLine($"\tAccelerating {x}");

            _Speed += x;

            if (_Speed > MaxSpeed)
            {
                Console.WriteLine($"\t\tHitted Max Speed ({MaxSpeed}), accelerated {x - (_Speed - MaxSpeed)}");
                _Speed = MaxSpeed;
            }
            return _Speed;
        }

        public float Break(float x)
        {
            Console.WriteLine($"\tBreaking {x}");

            _Speed -= x;

            if (_Speed < 0)
            {
                Console.WriteLine($"\t\tHitted Full Stop (0), breaked {_Speed + x}");
                _Speed = 0;
            }
            return _Speed;
        }
    }
}
