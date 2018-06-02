using System;

namespace LP1Exercises
{
    static class Program
    {
        static void Main(string[] args)
        {
            double xValue = 0, yValue = 0, zValue = 0, vectorValue;
            bool xRepeat = true, yRepeat = true, zRepeat = true;

            ConsoleKeyInfo xCoord, yCoord, zCoord;

            Console.WriteLine("Type a number from 0 to 9");
            Console.Write("x: ");
            while (xRepeat)
            {
                xCoord = Console.ReadKey();
                if (char.IsDigit(xCoord.KeyChar))
                {
                    xValue = int.Parse(xCoord.KeyChar.ToString());
                    Convert.ToDouble(xValue);
                    xRepeat = false;
                    Console.Write(", ");
                }
            }
            Console.Write("y: ");
            while (yRepeat)
            {
                yCoord = Console.ReadKey();
                if (char.IsDigit(yCoord.KeyChar))
                {
                    yValue = int.Parse(yCoord.KeyChar.ToString());
                    Convert.ToDouble(yValue);
                    yRepeat = false;
                    Console.Write(", ");
                }
            }
            Console.Write("z: ");
            while (zRepeat)
            {
                zCoord = Console.ReadKey();
                if (char.IsDigit(zCoord.KeyChar))
                {
                    zValue = int.Parse(zCoord.KeyChar.ToString());
                    Convert.ToDouble(zValue);
                    zRepeat = false;
                    Console.Write("\n");
                }
            }
            var vector = new { xValue, yValue, zValue };
            Console.WriteLine($"Your vector is ({vector.xValue}, {vector.yValue}, {vector.zValue})");
            vectorValue = Math.Sqrt((Math.Pow(vector.xValue, 2) + Math.Pow(vector.yValue, 2) + Math.Pow(vector.zValue, 2)));
            Console.WriteLine($"The vector's size is {vectorValue:f3}");
        }
    }
}
