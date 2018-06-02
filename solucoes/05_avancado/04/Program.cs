/*
 * 4 - De modo a que o seguinte código passe a funcionar é necessário adicionar algumas linhas antes do mesmo. Quais são?

class Program
{
    public static void Main()
    {
        float number;
        WriteLine("Escreve um número: ");
        number = ToSingle(ReadLine());
        WriteLine("O coseno desse número é {0:f3}", Cos(number));
    }
}

 Solução Proposta por André Santos*/


 //Foi adicionado a linha 19 a 21
using static System.Console;
using static System.Math;
using static System.Convert;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
