using System.Linq;


namespace LP1Exercises
{
    public static class Stats
    {

        /// <summary>
        /// Método que calcula a media
        /// </summary>
        /// <param name="array">recebe um array de doubles</param>
        /// <returns>devolve um double</returns>
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
        /// Método que calcula a mediana
        /// </summary>
        /// <param name="array">recebe um array de doubles</param>
        /// <returns>devolve um double</returns>
        public static double Mediana(params double[] array)
        {
            int size = array.Length;
            int mid = size / 2;

            double mediana = (size % 2 != 0) ? (double)array[mid] : ((double)array[mid]
                + (double)array[mid - 1]) / 2;

            return mediana;

        }

        /// <summary>
        /// Método que calcula a moda
        /// </summary>
        /// <param name="array">recebe um array de doubles</param>
        /// <returns>devolve a moda</returns>
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
        ///O using System.Linq é necessário para termos os
        ///métodos Max() e Min() disponíveis em coleções.


        /// <summary>
        /// Método que calcula o minimo 
        /// </summary>
        /// <param name="array">recebe um array de doubles</param>
        /// <returns>devolve um double</returns>
        public static double Minimo(params double[] array)
        {
            double min = array.Min();

            return min;
        }

        /// <summary>
        /// Metodo que calcula o maximo  
        /// </summary>
        /// <param name="array">recebe um array de doubles</param>
        /// <returns>devolve um double</returns>
        public static double Maximo(params double[] array)
        {
            double max = array.Max();

            return max;
        }
    }
}


