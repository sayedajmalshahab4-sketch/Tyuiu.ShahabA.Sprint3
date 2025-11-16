using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShahabA.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public DataService()
        {
        }

        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            // Перебор всех чисел в заданном диапазоне
            for (int num = startValue; num <= stopValue; num++)
            {
                // Поиск делителей для текущего числа
                for (int divisor = 12; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}