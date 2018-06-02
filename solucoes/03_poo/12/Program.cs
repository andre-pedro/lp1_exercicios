using System;

namespace LP1Exercises
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type three numbers to form a vector.");
            var vector = new { xValue = Convert.ToDouble(Console.ReadLine()),
                               yValue = Convert.ToDouble(Console.ReadLine()),
                               zValue = Convert.ToDouble(Console.ReadLine()) };
            Console.WriteLine($"Your vector's coordinates is ({vector.xValue}," +
                               $" {vector.yValue}, {vector.zValue})");
            Console.WriteLine($"Your vector's size is " +
                $"{(Math.Sqrt((Math.Pow(vector.xValue, 2) + Math.Pow(vector.yValue, 2) + Math.Pow(vector.zValue, 2)))):f3}.");
        }
    }
}
