using System;

namespace Dog
{/// <summary>
/// Test all functionality of class Dog
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog(34.3f, 10.0f, 1, "black");

            Console.WriteLine(d.Hungry);
            d.Poop();
            Console.WriteLine(d.Hungry);
            d.Eat();
            Console.WriteLine(d.Hungry);
            Console.WriteLine(d.Run());
            d.Barking();
        }
    }
}