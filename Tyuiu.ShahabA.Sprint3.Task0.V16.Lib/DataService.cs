using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShahabA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(double x)
        {
            double product = 1;

            for (int k = 1; k <= 6; k++)
            {
                double term = Math.Pow(x / k, 3);
                product *= term;
            }

            return Math.Round(product, 3);
        }

        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}