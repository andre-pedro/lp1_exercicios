/*Solução Proposta por André Santos*/

using static System.Console;
using static System.Math;
using static System.Convert;


namespace LP1Exercises
{
    class Program
    {
        static void Main()
        {
            float number;
            WriteLine("Escreve um número: ");
            number = ToSingle(ReadLine());
            WriteLine("O coseno desse número é {0:f3}", Cos(number));
        }
    }
}
