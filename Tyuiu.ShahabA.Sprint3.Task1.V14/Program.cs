using System;
using Tyuiu.ShahabA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            Console.WriteLine($"t = {t}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(t);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}