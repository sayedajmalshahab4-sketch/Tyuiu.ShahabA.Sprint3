using System;
using Tyuiu.ShahabA.Sprint3.Task5.V9.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму двойного ряда по формуле:                               *");
            Console.WriteLine("* y = ∑(i=1 to 3) ∑(k=1 to 14) (1/sin(k) + x) при x = 5                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага i = {startValue1}");
            Console.WriteLine($"Конец шага i = {stopValue1}");
            Console.WriteLine($"Старт шага k = {startValue2}");
            Console.WriteLine($"Конец шага k = {stopValue2}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Сумма двойного ряда = {result}");

            Console.ReadKey();
        }
    }
}