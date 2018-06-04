using System.Linq;


namespace LP1Exercises
{
    public static class Stats
    {

        /// <summary>
        /// Metodo que calcula a media, recebe
        /// um array de doubles e devolve um double
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Media(double[] array)
        {
            double total = 0;
            foreach (double num in array)
            {
                total += num;
            }
            return total / array.Length;
        }


        /// <summary>
        /// Método que calcula a mediana, recebe um array
        /// de doubles e devolve um double
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Mediana(double[] array)
        {
            int size = array.Length;
            int mid = size / 2;

            double mediana = (size % 2 != 0) ? (double)array[mid] : ((double)array[mid]
                + (double)array[mid - 1]) / 2;

            return mediana;

        }

        /// <summary>
        /// Metodo que calcula a moda, recebe um array
        /// de doubles e devolve um double, que corresponde ao
        /// numero que aparece mais vezes, caso existe 2 numeros
        /// com o mesmo numero de aparição devolve o primeiro
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo que calcula o minimo atraves do Min()
        /// Ao usar using System.Linq
        /// permite-nos usar o método  Min() 
        /// disponíveis em coleções.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Minimo(double[] array)
        {
            double min = array.Min();

            return min;
        }

        /// <summary>
        /// Metodo que calcula o maximo atraves do Max()
        /// Ao usar using System.Linq
        /// permite-nos usar o método  Man() 
        /// disponíveis em coleções. 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double Maximo(double[] array)
        {
            double max = array.Max();

            return max;
        }
    }
}


