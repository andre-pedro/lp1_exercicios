using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            double moda = 0 ;
            foreach (double num in array)
            {
                if (num != 0 && moda != num)
                {
                    moda = num;
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
