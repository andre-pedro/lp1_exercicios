using System;

namespace LP1Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a positive number and I will give you the respective Lucas number.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Lucas Number is {Lucas(choice)}");
        }

        public static int Lucas(int choice)
        {
            if (choice == 0)
            {
                return 2;
            }
            if (choice == 1)
            {
                return 1;
            }
            else
            {
                return Lucas(choice - 1) + Lucas(choice - 2);
            }
        }
    }
}
