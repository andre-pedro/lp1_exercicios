using System;

namespace LP1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 0;

            ///Teste: Pedir ao utilizador que indique o número de espaços no array
         
            Console.WriteLine("Indique a quantidade de numeros");
            nums =  Convert.ToInt32(Console.ReadLine());
            double[] numeros = new double[nums];

            for (int i = 0; i < numeros.Length; i++)
            {
                double tmp;
                Console.WriteLine("Escreva um numero");
                tmp = Convert.ToDouble(Console.ReadLine());
                numeros[i] = tmp;
            }

            Console.WriteLine();
            Console.WriteLine($"Moda:{Stats.Moda(numeros)} Mediana:{Stats.Mediana(numeros)} " +
                $"Média:{Stats.Media(numeros)} Máximo:{Stats.Maximo(numeros)}" +
                $" Minimo:{Stats.Minimo(numeros)}");

            ///Teste extra: Passar um número variável de parâmetros em vez de um array.

            Console.WriteLine();
            Console.WriteLine("Teste com novos dados passados por código");
            Console.WriteLine($"Moda:{Stats.Moda(1,2,5,5,3)} " +
                $"Mediana:{Stats.Mediana(1,5,10,20,1,3,5,9,8,7,4,2)} " +
                $"Média:{Stats.Media(1,9,9,8,7)} " +
                $"Máximo:{Stats.Maximo(1, 5, 9, 8, 7, 6, 3, 2, 1, 22, 4, 5, 6, 8)} " +
                $"Mínimo:{Stats.Minimo(20,23,21,22,10,2,3,4,5,6)}");

        }
    }
}
