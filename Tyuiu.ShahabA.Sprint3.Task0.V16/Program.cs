using System;
using Tyuiu.ShahabA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 5;
            Console.WriteLine($"X = {x}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(x);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}