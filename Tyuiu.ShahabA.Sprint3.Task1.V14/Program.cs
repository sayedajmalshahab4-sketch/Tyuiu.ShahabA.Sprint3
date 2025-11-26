using System;
using Tyuiu.ShahabAJ2.Sprint3.Task3.V14.Lib;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шахаб А. Дж. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | СМАРТб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при t = 0.7:                                                *");
            Console.WriteLine("* S = ∑[k=1 to 14] (tᵏ + 1/(k+1)) * cos(t)                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double t = 0.7;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine($"Переменная t = {t}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(t, startValue, stopValue);

            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}