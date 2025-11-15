using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShahabA.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double a)
        {
            double sum = 0;
            int k = 1;

            // Использование цикла do...while для вычисления суммы ряда
            do
            {
                double term = (Math.Pow(a, k) + 1) * Math.Cos(k);
                sum += term;
                k++;
            }
            while (k <= 20);

            return Math.Round(sum, 3);
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}