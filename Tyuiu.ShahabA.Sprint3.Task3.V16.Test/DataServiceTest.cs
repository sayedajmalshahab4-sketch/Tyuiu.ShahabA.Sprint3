using System;
using Tyuiu.ShahabA.Sprint3.Task3.V16.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'c' в строке:         *");
            Console.WriteLine("* 'ice nice ice creamcc'                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "ice nice ice creamcc";
            char ch = 'c';

            Console.WriteLine($"Исходная строка: {str}");
            Console.WriteLine($"Искомый символ: {ch}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetCharCount(str, ch);
            Console.WriteLine($"Количество букв '{ch}' в строке = {result}");

            Console.ReadKey();
        }
    }
}