using System;
using System.Linq;

namespace LP1Exercises
{
    public static class Stats
    {

        /// <summary>
        /// Método que calcula a média.
        /// </summary>
        /// <param name="array">Obtem a média dos valores que
        /// se encontram dentro desde array de doubles.
        ///</param>
        /// <returns>Devolve o cálculo da média através de um
        /// double.</returns>
        public static double Media(params double[] array)
        {
            double total = 0;
            foreach (double num in array)
            {
                total += num;
            }
            return total / array.Length;
        }


        /// <summary>
        /// Método que calcula a mediana.
        /// </summary>
        /// <param name="array">Obtem a mediana dos valores que
        /// se encontram dentro desde array de doubles.</param>
        /// <returns>Devolve o cálculo da mediana.</returns>
        public static double Mediana(params double[] array)
        {
            Array.Sort(array);
            int size = array.Length;
            int mid = size / 2;

            double mediana = (size % 2 != 0) ? (double)array[mid] : ((double)array[mid]
                + (double)array[mid - 1]) / 2;

            return mediana;

        }

        /// <summary>
        /// Método que calcula a moda, ou seja o número 
        /// que aparece mais vezes no array.
        /// </summary>
        /// <param name="array">Obtem a moda dos valores que
        /// se encontram dentro desde array de doubles</param>
        /// <returns>Devolve a moda através de um double</returns>
        public static double Moda(params double[] array)
        {
            double tmp = 0;
            int tempCont, cont = 1;

            double moda = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                {
                    tmp = array[i];
                    tempCont = 0;

                    for (int j = 0; j < array.Length; j++)
                    {
                        {
                            if (tmp == array[j])

                                tempCont++;

                        }
                    }
                    if (tempCont > cont)
                    {
                        moda = tmp;
                        cont = tempCont;
                    }

                }
            }
            return moda;
        }


        /// <summary>
        /// Método que devolve o mínimo.
        /// </summary>
        /// <param name="array">Obtem o mínimo dos valores que
        /// se encontram dentro desde array de doubles</param>
        /// <returns>Devolve o mínimo através de um double</returns>
        public static double Minimo(params double[] array)
        {

            ///O using System.Linq é necessário para termos os
            ///métodos Max() e Min() disponíveis em coleções.
            double min = array.Min();

            return min;
        }

        /// <summary>
        /// Método que indica o máximo.
        /// </summary>
        /// <param name="array">Obtem o máximo dos valores
        /// que se encontram no array fornecido.</param>
        /// <returns>Devolve o máximo através de um double</returns>
        public static double Maximo(params double[] array)
        {

            ///O using System.Linq é necessário para termos os
            ///métodos Max() e Min() disponíveis em coleções.
            double max = array.Max();

            return max;
        }
    }
}


