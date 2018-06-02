using System;

namespace LP1Exercises
{
    class Program
    {
        readonly static double GoldenRatio = (1 + Math.Sqrt(5)) / 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a positive number and I will give you the respective Lucas number.");
            double choice = Convert.ToDouble(Console.ReadLine());
            // Only works until 1474, after that the number is too high
            if (choice == 1) Console.WriteLine("Your Lucas number is 1.");
            if (choice >= 2)
            {
                Console.WriteLine($"Your Lucas number is " +
                    $"{Math.Round(Math.Pow(GoldenRatio, choice), MidpointRounding.AwayFromZero)}.");
            }
        }
    }
}
