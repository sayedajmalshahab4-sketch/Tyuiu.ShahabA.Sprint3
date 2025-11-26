using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public DataService()
        {
        }

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow((double)value / k, 3);
                p *= term;

                // Для отладки - можно раскомментировать
                // Console.WriteLine($"k={k}, term={term}, p={p}");
            }

            return Math.Round(p, 3);
        }
    }
}