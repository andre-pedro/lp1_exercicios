using System;
using System.Linq;


namespace _07
{
    static class Stats
    {

        public static double Media(double[] array)
        {
            double total = 0;
            foreach (double num in array)
            {
                total += num;
            }
            return total / array.Length;
        }

        public static double Mediana(double[] array)
        {
            int size = array.Length;
            int mid = size / 2;

            double mediana = (size % 2 != 0) ? (double)array[mid] : (double)array[mid] + (double)array[mid - 1] / 2;
            return mediana;

        }

        public static double Moda(double[] array)
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

        public static double Minimo(double[] array)
        {
            double min = array.Min();

            return min;
        }

        public static double Maximo(double[] array)
        {
            double max = array.Max();

            return max;
        }
    }
}


