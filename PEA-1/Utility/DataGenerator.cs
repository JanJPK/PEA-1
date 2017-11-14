using System;
using System.Collections.Generic;

namespace PEA_1.Utility
{
    public static class DataGenerator
    {
        private static Random rng;

        /// <summary>
        ///     Tworzy listę wejściową (taką jak wczytywaną z pliku) o podanych parametrach.
        /// </summary>
        /// <param name="cityAmount">Ilość miast.</param>
        /// <param name="lower">Dolny zakres losowania wag.</param>
        /// <param name="upper">Górny zakres losowania wag</param>
        /// <returns>Lista w formacie przyjmowanym przez SalesmanData.</returns>
        public static List<int> Salesman(int cityAmount, int lower = 0, int upper = 0)
        {
            // lower, upper - zakres losowania wag.
            if (upper == 0 || lower == 0 || lower >= upper)
            {
                upper = (int)(cityAmount * 1.5);
                lower = cityAmount / 2;
            }

            // pierwsza linia: [liczba miast][rozwiązanie (tutaj 0 bo losowe)]
            // kolejnie linie: [miasto][odległości do wszystkich innych(tam gdzie jest obecne miasto = 0)]
            rng = new Random();
            List<int> dataList = new List<int>();
            dataList.Add(cityAmount);
            dataList.Add(0);

            //int lower = cityAmount / 2;
            //int upper = (int) (cityAmount * 1.5);

            for (int i = 0; i < cityAmount; i++)
            {
                for (int j = 0; j < cityAmount; j++)
                {
                    if (i == j)
                    {
                        dataList.Add(0);
                    }
                    else
                    {
                        dataList.Add(rng.Next(lower, upper));
                    }
                }
            }

            return dataList;
        }
    }
}
