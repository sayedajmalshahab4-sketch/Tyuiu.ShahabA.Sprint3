using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShahabA.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
  

    public double GetSumSeries(double t)
        {
            double sum = 0;
            int k = 1;

            while (k <= 14)
            {
                double term = (Math.Pow(t, k) + (1.0 / (k + 1))) * Math.Cos(t);
                sum += term;
                k++;
            }

            return Math.Round(sum, 3);
        }
    }
}