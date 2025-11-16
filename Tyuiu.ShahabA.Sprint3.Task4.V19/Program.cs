using System;
using Tyuiu.ShahabA.Sprint3.Task4.V19.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов break и continue в циклах               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("* функции y=x/(cos(x) + x)+0.5. При х = 0 прервать цикл.                 *");
            Console.WriteLine("* Полученные значения перемножать.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"Произведение значений функции = {result}");

            Console.ReadKey();
        }
    }
}