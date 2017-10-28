using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PEA_1.Salesman;

namespace PEA_1.Utility
{
    public static class DataGenerator
    {
        private static Random rng;

        public static List<int> Salesman(int cityAmount)
        {
            // pierwsza linia: [liczba miast]
            // kolejnie linie: [miasto][odległości do wszystkich innych(tam gdzie jest obecne miasto = 0)]
            rng = new Random();
            List<int> dataList = new List<int>();
            dataList.Add(cityAmount);
            int lower = (int)(cityAmount / 2);
            int upper = (int)(cityAmount * 1.5);
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
