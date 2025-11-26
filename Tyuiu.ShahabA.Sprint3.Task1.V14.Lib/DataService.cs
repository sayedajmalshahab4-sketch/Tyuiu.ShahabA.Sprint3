using System;
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public DataService()
        {
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                double term = (Math.Pow(value, k) + 1) * Math.Cos(k);
                sum += term;
                k++;
            }
            while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}