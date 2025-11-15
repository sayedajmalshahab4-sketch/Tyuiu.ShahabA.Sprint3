using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShahabA.Sprint3.Task3.V16.Lib
{
    public class DataService : ISprint3Task3V16
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;

            // Использование цикла foreach для подсчета букв
            foreach (char ch in value)
            {
                if (ch == item)
                {
                    count++;
                }
            }

            return count;
        }
    }
}