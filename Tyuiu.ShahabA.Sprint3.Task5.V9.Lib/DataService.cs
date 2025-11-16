using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShahabA.Sprint3.Task5.V9.Lib
{
    public class DataService : ISprint3Task5V9
    {
        public DataService()
        {
        }

        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            // Внешний цикл для i от startValue1 до stopValue1
            for (int i = startValue1; i <= stopValue1; i++)
            {
                // Внутренний цикл для k от startValue2 до stopValue2
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double term = (1 / Math.Sin(k)) + x;
                    sum += term;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}