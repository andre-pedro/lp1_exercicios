using System;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;

            Console.WriteLine("Indique a quantidade de numeros");
            nums =  Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[nums];

            for (int i = 0; i < numeros.Length; i++)
            {
                double tmp;
                Console.WriteLine("Escreva um numero");
                tmp = Convert.ToInt32(Console.ReadLine());
                numeros[i] = tmp;
            }

            Console.WriteLine();
            Console.WriteLine($"Moda:{Stats.Moda(numeros)} Mediana:{Stats.Mediana(numeros)} " +
                $"Média:{Stats.Media(numeros)} Máximo:{Stats.Maximo(numeros)} Minimo:{Stats.Minimo(numeros)}");

        }
    }
}
