using System;

namespace LP1Exercises
{
    class TestCar
    {
        static void Main(string[] args)
        {
            Car car = new Car {Weight = 1000, Fuel = FuelType.Gasoline };
            
            // Stats
            Car.MaxSpeed = 220;
            Console.WriteLine($"Car Fuel: {car.Fuel}");
            Console.WriteLine($"Car Weight: {car.Weight}");
            Console.WriteLine($"Car Max Speed: {Car.MaxSpeed}");
            Console.WriteLine();
            // Test Accelerate and Break
            Console.WriteLine($"Speed: {car.Speed}");
            car.Accelerate(50);
            Console.WriteLine($"Speed: {car.Speed}");
            car.Accelerate(500);
            Console.WriteLine($"Speed: {car.Speed}");
            car.Break(50);
            Console.WriteLine($"Speed: {car.Speed}");
            car.Break(500);
            Console.WriteLine($"Speed: {car.Speed}");
            Console.WriteLine();
            // Changing MaxSpeed
            Car.MaxSpeed = 300;
            Console.WriteLine($"Car Max Speed: {Car.MaxSpeed}");
            car.Accelerate(500);
        }
    }
}