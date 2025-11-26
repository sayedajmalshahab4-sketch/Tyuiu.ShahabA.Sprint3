using System;
using Tyuiu.ShahabAJ2.Sprint3.Task3.V5.Lib;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шахаб А. Дж. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | СМАРТб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
            Console.WriteLine("* ряда по формуле, при a = 0.75:                                          *");
            Console.WriteLine("* S = ∑[k=1 to 20] (a^k + 1) * cos(k)                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.75;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine($"Переменная a = {a}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}