using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShahabA.Sprint3.Task4.V19.Lib
{
    public class DataService
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1;

            // Вычисление произведения значений функции на отрезке от -5 до 5
            for (int x = startValue; x <= stopValue; x++)
            {
                // Если x = 0, прерываем цикл
                if (x == 0)
                {
                    break;
                }

                // Вычисление значения функции
                double y = x / (Math.Cos(x) + x) + 0.5;
                product *= y;
            }

            return Math.Round(product, 3);
        }
    }
}