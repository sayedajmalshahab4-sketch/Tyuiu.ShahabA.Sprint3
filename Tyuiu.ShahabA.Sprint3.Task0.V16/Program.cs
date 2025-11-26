using System;
using Tyuiu.ShahabAJ2.Sprint3.Task3.V16.Lib;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Шахаб А. Дж. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | СМАРТб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* ряда по формуле, при x = 5:                                             *");
            Console.WriteLine("* p = ∏[k=1 to 6] (x/k)^3                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue = 1;
            int stopValue = 6;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}
        }
    }
}